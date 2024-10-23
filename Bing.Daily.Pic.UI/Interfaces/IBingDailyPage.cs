using Bing.Daily.Pic.Common.Dtos;
using Bing.Daily.Pic.Common.Interfaces;
using Bing.Daily.Pic.Common.Managers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bing.Daily.Pic.UI.Interfaces
{
    public interface IBingDailyPage
    {
        ICountrySettingsManager CountriesManger { get; set; }
        
        ImagesStorageManager TempFilesStorageManager { get; set; }
        
        string OutImageFolder { get; set; }
        
        List<BingImageInfoDto> Images { get; set; }

        void RefreshBingDailyInfo();
    }
}