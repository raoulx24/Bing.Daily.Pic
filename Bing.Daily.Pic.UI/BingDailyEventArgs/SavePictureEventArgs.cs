using Bing.Daily.Pic.Common.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bing.Daily.Pic.UI.BingDailyEventArgs
{
    public class SavePictureEventArgs : EventArgs
    {
        public string SaveToFolder { get; set; }

        public DateTime PictureDate { get; set; }

        public CountryDto PictureCountry { get; set; }

        public string Description { get; set; }

        public string TempDownloadedFile { get; set; }
    }
}
