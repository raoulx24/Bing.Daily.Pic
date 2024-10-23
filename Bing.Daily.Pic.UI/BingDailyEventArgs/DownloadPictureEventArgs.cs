using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bing.Daily.Pic.UI.BingDailyEventArgs
{
    public class DownloadPictureEventArgs : EventArgs
    {
        public Uri PictureUrl { get; set; }
        public string FileName { get; set; }
        public string ImagesFolder { get; set; }
    }
}
