using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bing.Daily.Pic.Common.Interfaces
{
    public interface IAppSettings
    {
        ICountrySettingsManager CountriesManger { get; }

        string OutPictureFolder { get; }
    }
}