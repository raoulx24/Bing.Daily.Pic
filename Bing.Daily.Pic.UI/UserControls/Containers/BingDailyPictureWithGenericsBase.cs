using Bing.Daily.Pic.Common.Dtos;
using Bing.Daily.Pic.UI.Presenters;
using Bing.Daily.Pic.UI.UserControls.Views;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bing.Daily.Pic.UI.UserControls.Containers
{
    public class BingDailyContainerWithGenericsBase<TBingDailyPictureView> : BingDailyPictureContainerBase
        where TBingDailyPictureView : BingDailyPictureViewBase, new()
    {
        protected override async void AddUserControlsForBingDaily(List<BingImageInfoDto> imageInfos)
        {
            List<TBingDailyPictureView> newBingDailyPictures = await Task.Run(() =>
            {
                List<TBingDailyPictureView> bingDailyPictures = new List<TBingDailyPictureView>();

                foreach (BingImageInfoDto imageInfo in imageInfos)
                {
                    TBingDailyPictureView bdp = CreateBingDailyUserControl(imageInfo, OutImageFolder);

                    bingDailyPictures.Add(bdp);
                }

                return bingDailyPictures;
            });

            flowLayoutBingDaily.Visible = false;
            flowLayoutBingDaily.SuspendLayout();
            newBingDailyPictures.ForEach(x => flowLayoutBingDaily.Controls.Add(x));
            flowLayoutBingDaily.ResumeLayout();
            flowLayoutBingDaily.Visible = true;

            foreach(TBingDailyPictureView bingDailyPictureView in newBingDailyPictures.Where(x => string.IsNullOrEmpty(x.DownloadedFileName)))
            {
                bingDailyPictureView.DownloadBingImage();
            }
        }

        private TBingDailyPictureView CreateBingDailyUserControl(BingImageInfoDto imageInfo, string outFolder)
        {
            TBingDailyPictureView bdp = new TBingDailyPictureView
            {
                FromCountry = imageInfo.Country,
                ImageInfo = imageInfo,
                PicDate = DateTime.ParseExact(imageInfo.fullstartdate, "yyyyMMddHHmm", CultureInfo.InvariantCulture),
                PicUri = new Uri(imageInfo.url),
                Caption = imageInfo.copyright,
                TempImagesStorageManager = TempFilesStorageManager,
                OutImageFolder = outFolder,
                DownloadedFileName = imageInfo.DownloadedFileName
                //BorderStyle = BorderStyle.Fixed3D
            };

            BingDownloadPicturePresenter downloadPicPresenter = new BingDownloadPicturePresenter(bdp);

            bdp.Enter += OnBingDailyPictureViewEntered;

            bdp.ArrangeControls();

            return bdp;
        }

        public override void SortByDate()
        {
            IEnumerable<BingDailyPictureViewBase> bingDailyPicures = new List<BingDailyPictureViewBase>(flowLayoutBingDaily.Controls.OfType<BingDailyPictureViewBase>());

            IEnumerable<BingDailyPictureViewBase> bingDailyPicuresSorted = bingDailyPicures.OrderByDescending(x => x.PicDate).ThenBy(x => x.FromCountry.Name);

            flowLayoutBingDaily.SuspendLayout();
            flowLayoutBingDaily.Controls.Clear();
            foreach (BingDailyPictureViewBase bdps in bingDailyPicuresSorted)
            {
                flowLayoutBingDaily.Controls.Add(bdps);
            }
            flowLayoutBingDaily.ResumeLayout();
        }

        public override void SortByCountry()
        {
            IEnumerable<BingDailyPictureViewBase> bingDailyPicures = new List<BingDailyPictureViewBase>(flowLayoutBingDaily.Controls.OfType<BingDailyPictureViewBase>());

            IEnumerable<BingDailyPictureViewBase> bingDailyPicuresSorted = bingDailyPicures.OrderBy(x => x.FromCountry.Name).ThenByDescending(x => x.PicDate);

            flowLayoutBingDaily.SuspendLayout();
            flowLayoutBingDaily.Controls.Clear();
            foreach (BingDailyPictureViewBase bdps in bingDailyPicuresSorted)
            {
                flowLayoutBingDaily.Controls.Add(bdps);
            }
            flowLayoutBingDaily.ResumeLayout();
        }
    }
}
