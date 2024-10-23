using Bing.Daily.Pic.Common.Dtos;
using Bing.Daily.Pic.Common.Managers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bing.Daily.Pic.UI.Interfaces
{
    public interface IBingDailyPictureView
    {
        CountryDto FromCountry { get; set; }

        DateTime PicDate { get; set; }

        Uri PicUri { get; set; }

        string Caption { get; set; }

        ImagesStorageManager TempImagesStorageManager { get; set; }

        string OutImageFolder { get; set; }

        void DownloadBingImage();

        void ArrangeControls();
    }
}
