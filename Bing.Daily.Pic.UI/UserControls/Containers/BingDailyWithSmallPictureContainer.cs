using Bing.Daily.Pic.UI.UserControls.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bing.Daily.Pic.UI.UserControls.Containers
{
    public class BingDailyWithSmallPictureContainer : BingDailyContainerWithGenericsBase<BingDailySmallPictureView>
    {
        public BingDailyWithSmallPictureContainer() : base()
        {
            InitializeComponents();
        }

        private void InitializeComponents()
        {
            this.AutoScroll = false;

            flowLayoutBingDaily.AutoScroll = true;
            flowLayoutBingDaily.WrapContents = false;

            mainBingPicture.Visible = true;
        }
    }
}
