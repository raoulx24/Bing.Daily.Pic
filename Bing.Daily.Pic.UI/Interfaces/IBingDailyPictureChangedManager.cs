using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bing.Daily.Pic.UI.Interfaces
{
    public interface IBingDailyPictureChangedManager
    {
        void BingDailyPictureChanged(string filePath);
    }
}
