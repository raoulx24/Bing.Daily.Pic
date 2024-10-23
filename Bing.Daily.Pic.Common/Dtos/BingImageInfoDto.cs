using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bing.Daily.Pic.Common.Dtos
{
    public class BingImageInfoDto
    {
        public string fullstartdate { get; set; }

        public string urlbase { get; set; }

        public string copyright { get; set; }

        public string title { get; set; }

        public CountryDto Country { get; set; }

        public string url { get; set; }

        public string DownloadedFileName { get; set; }
    }
}
