using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Bing.Daily.Pic.UI.Interfaces;
using System.Globalization;
using Bing.Daily.Pic.UI.BingDailyEventArgs;
using Bing.Daily.Pic.Common.Managers;
using Bing.Daily.Pic.Common.Dtos;
using System.IO;
using CustomUserControls;

namespace Bing.Daily.Pic.UI.UserControls.Views
{
    public partial class BingDailyDetailedPictureView : BingDailyPictureViewBase//UserControl, IDownloadPictureView, IBingDailyPictureView
    {
        public BingDailyDetailedPictureView() : base()
        {
            InitializeComponent();
        }

        public override DateTime PicDate
        {
            set
            {
                base.PicDate = value;

                txtPicDate.TextBoxValue = base.PicDate.ToString("yyyyMMdd");
            }
        }
        public override Uri PicUri
        {
            set
            {
                base.PicUri = value;

                txtPicUri.TextBoxValue = base.PicUri == null ? string.Empty : base.PicUri.AbsoluteUri;
            }
        }
        public override string Caption
        {
            set
            {
                base.Caption = value;

                txtCaption.TextBoxValue = base.Caption;
            }
        }
        public override CountryDto FromCountry
        {
            set
            {
                base.FromCountry = value;

                txtFromCountry.TextBoxValue = base.FromCountry == null ? string.Empty : base.FromCountry.Name;
            }
        }
        public override string DownloadedFileName
        {
            set
            {
                base.DownloadedFileName = value;
                picBingDaily.Image = LoadImageFromFile(base.DownloadedFileName);
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            OnSavePictureRequested(this);
        }
    }
}
