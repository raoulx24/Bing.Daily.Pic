using Bing.Daily.Pic.UI.UserControls.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bing.Daily.Pic.UI.UserControls.Containers
{
    public class BingDailyWithSmallPictureVerticalContainer : BingDailyContainerWithGenericsBase<BingDailySmallPictureView>
    {
        public BingDailyWithSmallPictureVerticalContainer() : base()
        {
            InitializeComponents();
        }

        private void InitializeComponents()
        {
            this.AutoScroll = false;

            flowLayoutBingDaily.AutoScroll = true;
            flowLayoutBingDaily.WrapContents = false;
            flowLayoutBingDaily.Dock = System.Windows.Forms.DockStyle.Left;
            flowLayoutBingDaily.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;

            mainBingPicture.Visible = true;
        }
    }
}
