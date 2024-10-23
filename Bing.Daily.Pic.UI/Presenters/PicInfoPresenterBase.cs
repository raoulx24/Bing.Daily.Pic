using Bing.Daily.Pic.UI.BingDailyEventArgs;
using Bing.Daily.Pic.UI.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bing.Daily.Pic.UI.Presenters
{
    public abstract class PicInfoPresenterBase
    {
        public PicInfoPresenterBase(IPicInfoView view)
        {
            _view = view;

            InitializeEvents();
        }

        private void InitializeEvents()
        {
            _view.PicInfoRequested += getPicInfo;
        }

        protected void getPicInfo(object sender, BingPicInfoEventArgs e)
        {
            getPicInfo_internal(sender, e);
        }

        protected abstract void getPicInfo_internal(object sender, BingPicInfoEventArgs e);

        readonly protected IPicInfoView _view;
    }
}
