using Bing.Daily.Pic.Common.Dtos;
using Bing.Daily.Pic.Common.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bing.Daily.Pic.UI.BingDailyEventArgs
{
    public class BingPicInfoEventArgs : EventArgs
    {
        public CountryDto Country { get; set; }
    }
}
