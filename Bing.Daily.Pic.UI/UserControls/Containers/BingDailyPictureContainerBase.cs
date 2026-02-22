using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Bing.Daily.Pic.UI.Interfaces;
using Bing.Daily.Pic.Common.Dtos;
using Bing.Daily.Pic.UI.BingDailyEventArgs;
using Bing.Daily.Pic.UI.Presenters;
using Bing.Daily.Pic.Common.Interfaces;
using Bing.Daily.Pic.Common.Managers;
using System.Globalization;
using Bing.Daily.Pic.UI.UserControls.Views;

namespace Bing.Daily.Pic.UI.UserControls.Containers
{
    public abstract partial class BingDailyPictureContainerBase : UserControl, IPicInfoView, IBingDailyPictureChangedManager
    {
        public BingDailyPictureContainerBase()
        {
            InitializeComponent();

            InitializePresenters();
        }

        private void InitializePresenters()
        {
            _bingPicInfoPresenter = new BingPicInfoPresenter(this);
        }

        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public List<BingImageInfoDto> NewImages
        {
            set
            {
                if (Images is null)
                    Images = new List<BingImageInfoDto>();

                Images.AddRange(value);

                AddUserControlsForBingDaily(value);
            }
        }

        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public List<BingImageInfoDto> Images
        {
            get { return _images; }
            set { _images = value; }
        }

        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public ICountrySettingsManager CountriesManger { get => _countriesManger; set => _countriesManger = value; }
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public ImagesStorageManager TempFilesStorageManager { get => _tempFilesStorageManager; set => _tempFilesStorageManager = value; }
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public string OutImageFolder { get => _outImageFolder; set => _outImageFolder = value; }

        public event EventHandler<BingPicInfoEventArgs> PicInfoRequested;

        protected void OnPicInfoRequested(object sender, CountryDto country)
        {
            if (PicInfoRequested == null)
            {
                return;
            }

            BingPicInfoEventArgs e = new BingPicInfoEventArgs
            {
                Country = country,
            };

            PicInfoRequested(sender, e);
        }

        protected void OnBingDailyPictureViewEntered(object sender, EventArgs e)
        {
            if (sender is BingDailyPictureViewBase)
            {
                mainBingPicture.ImageLocation = ((BingDailyPictureViewBase)sender).DownloadedFileName;
            }
        }

        protected abstract void AddUserControlsForBingDaily(List<BingImageInfoDto> imageInfos);

        public abstract void SortByDate();

        public abstract void SortByCountry();

        public void RefreshFromWebBingDailyInfo()
        {
            if (CountriesManger is null)
                return;

            flowLayoutBingDaily.Controls.Clear();

            foreach (CountryDto country in CountriesManger.Countries)
            {
                OnPicInfoRequested(this, country);
            }
        }

        public void BingDailyPictureChanged(string filePath)
        {
            mainBingPicture.ImageLocation = filePath;
        }

        private BingPicInfoPresenter _bingPicInfoPresenter;
        private ICountrySettingsManager _countriesManger = null;
        private ImagesStorageManager _tempFilesStorageManager;
        private string _outImageFolder;
        private List<BingImageInfoDto> _images;
    }
}
