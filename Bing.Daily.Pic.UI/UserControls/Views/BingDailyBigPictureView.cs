using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Bing.Daily.Pic.Common.Dtos;

namespace Bing.Daily.Pic.UI.UserControls.Views
{
    public partial class BingDailyBigPictureView : BingDailyPictureViewBase
    {
        public BingDailyBigPictureView() : base()
        {
            InitializeComponent();
        }

        public override DateTime PicDate
        {
            set
            {
                base.PicDate = value;

                lblDate.Text = base.PicDate.ToString("yyyy-MM-dd");
            }
        }

        public override string Caption
        {
            set
            {
                base.Caption = value;

                lblCaption.Text = base.Caption;
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

        public override CountryDto FromCountry
        {
            set
            {
                base.FromCountry = value;

                lblCountry.Text = base.FromCountry == null ? string.Empty : base.FromCountry.Name;
            }
        }

        public override bool FileSaved
        {
            set
            {
                base.FileSaved = value;

                lblSaved.Text = value ? "Saved √" : string.Empty;
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            OnSavePictureRequested(this);
        }

        private void btnOpen_Click(object sender, EventArgs e)
        {
            OnOpenFileRequested(this);
        }
    }
}
