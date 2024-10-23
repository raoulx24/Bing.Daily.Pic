using Bing.Daily.Pic.Common.Dtos;
using Bing.Daily.Pic.UI.BingDailyEventArgs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bing.Daily.Pic.UI.Interfaces
{
    public interface IPicInfoView
    {
        event EventHandler<BingPicInfoEventArgs> PicInfoRequested;

        List<BingImageInfoDto> NewImages { set; }
    }
}
