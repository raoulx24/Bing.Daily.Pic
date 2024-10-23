using Bing.Daily.Pic.UI.UserControls.Containers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bing.Daily.Pic.UI.UserControls.Pages
{
    public class BingDailyPagesWithGenericsBase<TBingDailyContainer> : BingDailyPageBase
        where TBingDailyContainer : BingDailyPictureContainerBase, new()
    {
        public BingDailyPagesWithGenericsBase():base(new TBingDailyContainer())
        {
        }
    }
}
