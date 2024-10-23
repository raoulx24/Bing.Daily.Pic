using Bing.Daily.Pic.Common.Interfaces;
using Bing.Daily.Pic.Common.Managers;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bing.Daily.Pic.Common.Settings
{
    public class AppSettings
    {
        public ICountrySettingsManager CountriesManger
        {
            get { return _countriesManger; }
        }

        public string OutPictureFolder
        {
            get { return _outPictureFolder; }
        }

        public ImagesStorageManager TempFiles
        {
            get { return _tempFiles; }
        }

        private ICountrySettingsManager _countriesManger = new WellKnownCountries();
        private string _outPictureFolder = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.MyPictures), "Bing.Daily");
        private ImagesStorageManager _tempFiles = new ImagesStorageManager(Path.Combine(Path.GetTempPath(), "Bing.Daily"));
    }
}
