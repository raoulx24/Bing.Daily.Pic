using Bing.Daily.Pic.UI.BingDailyEventArgs;
using Bing.Daily.Pic.UI.Interfaces;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bing.Daily.Pic.UI.Presenters
{
    public class SavePicturePresenter
    {
        public SavePicturePresenter(ISavePictureView view)
        {
            _view = view;

            InitializeEvents();
        }

        private void InitializeEvents()
        {
            _view.SavePictureRequested += SavePicture;
        }

        protected void SavePicture(object sender, SavePictureEventArgs e)
        {
            if (!Directory.Exists(e.SaveToFolder))
                Directory.CreateDirectory(e.SaveToFolder);

            string validDescriptionForFile = MakeValidFileName(e.Description);

            string fileName = string.Format("{0} {1}.{2}.jpg", e.PictureDate.ToString("yyyy.MM.dd"), e.PictureCountry.CountryCode, validDescriptionForFile);

            string pathedFileName = Path.Combine(e.SaveToFolder, fileName);

            if (!File.Exists(pathedFileName))
                File.Copy(e.TempDownloadedFile, pathedFileName);

            _view.FileSaved = true;
        }

        private string MakeValidFileName(string name)
        {
            string invalidChars = System.Text.RegularExpressions.Regex.Escape(new string(System.IO.Path.GetInvalidFileNameChars()));
            string invalidRegStr = string.Format(@"([{0}]*\.+$)|([{0}]+)", invalidChars);

            return System.Text.RegularExpressions.Regex.Replace(name, invalidRegStr, "-");
        }

        readonly protected ISavePictureView _view;
    }
}
