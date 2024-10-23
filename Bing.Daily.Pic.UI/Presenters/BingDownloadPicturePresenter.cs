using Bing.Daily.Pic.UI.BingDailyEventArgs;
using Bing.Daily.Pic.UI.Interfaces;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace Bing.Daily.Pic.UI.Presenters
{
    public class BingDownloadPicturePresenter : DownloadPicturePresenterBase
    {
        public BingDownloadPicturePresenter(IDownloadPictureView view) : base(view)
        { }

        protected override async void DownloadPicture(object sender, DownloadPictureEventArgs e)
        {
            //return;

            string fullFileName = Path.Combine(e.ImagesFolder, e.FileName);

            using (WebClient client = new WebClient())
            {
                await Task.Run(() => client.DownloadFile(e.PictureUrl, fullFileName));
            }

            _view.DownloadedFileName = fullFileName;
        }
    }
}
