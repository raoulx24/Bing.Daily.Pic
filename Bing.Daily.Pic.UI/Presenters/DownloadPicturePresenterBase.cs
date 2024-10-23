using Bing.Daily.Pic.UI.BingDailyEventArgs;
using Bing.Daily.Pic.UI.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bing.Daily.Pic.UI.Presenters
{
    public abstract class DownloadPicturePresenterBase
    {
        public DownloadPicturePresenterBase(IDownloadPictureView view)
        {
            _view = view;

            InitializeEvents();
        }

        private void InitializeEvents()
        {
            _view.DownloadPictureRequested += DownloadPicture;
        }

        protected abstract void DownloadPicture(object sender, DownloadPictureEventArgs e);

        readonly protected IDownloadPictureView _view;
    }
}
