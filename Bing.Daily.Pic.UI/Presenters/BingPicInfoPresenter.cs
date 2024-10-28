using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Net;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using Bing.Daily.Pic.Common.Dtos;
using Bing.Daily.Pic.UI.BingDailyEventArgs;
using Bing.Daily.Pic.UI.Interfaces;

namespace Bing.Daily.Pic.UI.Presenters
{
    public class BingPicInfoPresenter : PicInfoPresenterBase
    {
        public BingPicInfoPresenter(IPicInfoView view) : base(view)
        { }

        protected override async void getPicInfo_internal(object sender, BingPicInfoEventArgs e)
        {
            // https://www.bing.com/HPImageArchive.aspx?format=js&idx=0&n=1&mkt=en-US

            string initReqUri = string.Format("https://www.bing.com/?cc={0}",
                e.Country.CountryCode.ToLower());

            string reqUri = string.Format("https://www.bing.com/HPImageArchive.aspx?format=js&idx=0&n=8&mkt={0}-{1}",
                e.Country.LanguageCode,
                e.Country.CountryCode);

            Uri initUri = new Uri(initReqUri);
            Uri bingUri = new Uri(reqUri);

            string reqJson = string.Empty;

            using (WebClient client = new WebClient() { Encoding = Encoding.UTF8 })
            {
                //CookieContainer cc = new CookieContainer();

                //cc.SetCookies(bingUri, string.Format("_EDGE_S =mkt={0}-{1}", e.Country.LanguageCode, e.Country.CountryCode));
                //string cookies = cc.GetCookieHeader(bingUri);

                await Task.Run(() => client.DownloadString(initUri));

                string cookies = client.ResponseHeaders["Set-Cookie"]?.ToString();

                client.Headers.Add(HttpRequestHeader.Cookie, cookies);

                reqJson = await Task.Run(() => client.DownloadString(bingUri));
            }

            if (string.IsNullOrEmpty(reqJson))
                return;

            BingReqContentDto bingDailyPicIfo = JsonSerializer.Deserialize<BingReqContentDto>(reqJson);

            bingDailyPicIfo.images.ForEach(x => { x.url = new Uri(_baseBingUri, string.Format("{0}{1}", x.urlbase, _uriSuffix)).AbsoluteUri; x.Country = e.Country; });

            _view.NewImages = bingDailyPicIfo.images;
        }

        private Uri _baseBingUri = new Uri("https://www.bing.com/");
        private string _uriSuffix = "_1920x1080.jpg";
    }
}
