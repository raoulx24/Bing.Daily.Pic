using Bing.Daily.Pic.UI.BingDailyEventArgs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bing.Daily.Pic.UI.Interfaces
{
    public interface ISavePictureView
    {
        event EventHandler<SavePictureEventArgs> SavePictureRequested;

        bool FileSaved { set; }
    }
}
