using Bing.Daily.Pic.Common.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bing.Daily.Pic.Common.Dtos
{
    public class CountryDto
    {
        public CountryDto(string languageCode, string countryCode, string name, string timeZoneId)
        {
            LanguageCode = languageCode;
            CountryCode = countryCode;
            Name = name;
            TimeZoneId = timeZoneId;
        }
        public string LanguageCode { get; set; }
        
        public string CountryCode { get; set; }

        public string Name { get; set; }

        public string TimeZoneId { get; set; }

        //private string _languageCode;
        //private string _countryCode;
        //private string _name;
    }
}
