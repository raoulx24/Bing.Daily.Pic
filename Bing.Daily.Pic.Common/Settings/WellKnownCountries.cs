using Bing.Daily.Pic.Common.Dtos;
using Bing.Daily.Pic.Common.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bing.Daily.Pic.Common.Settings
{
    public class WellKnownCountries : ICountrySettingsManager
    {
        public WellKnownCountries()
        {
            _countries.Add(new CountryDto("ro", "RO", "Romania", "Pacific Standard Time"));
            _countries.Add(new CountryDto("de", "DE", "Germany", "W. Europe Standard Time"));
            _countries.Add(new CountryDto("fr", "FR", "France", "Romance Standard Time"));
            _countries.Add(new CountryDto("en", "GB", "Great Britain", "GMT Standard Time"));
            _countries.Add(new CountryDto("ja", "JP", "Japan", "Tokyo Standard Time"));
            _countries.Add(new CountryDto("zh", "CN", "China", "China Standard Time"));
            _countries.Add(new CountryDto("en", "IN", "India", "India Standard Time"));
            _countries.Add(new CountryDto("en", "AU", "Australia", "E. Australia Standard Time"));
            _countries.Add(new CountryDto("en", "US", "United States", "Pacific Standard Time"));
            _countries.Add(new CountryDto("en", "CA", "Canada", "Eastern Standard Time"));
        }

        public IReadOnlyList<CountryDto> Countries
        {
            get
            {
                return _countries;
            }
        }

        private List<CountryDto> _countries = new List<CountryDto>();
    }
}
