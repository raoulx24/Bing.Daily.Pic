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
    public partial class BingDailySmallPictureView : BingDailyPictureViewBase
    {
        public BingDailySmallPictureView() : base()
        {
            InitializeComponent();
        }

        public override DateTime PicDate
        {
            set
            {
                base.PicDate = value;

                UpdateDescription();
            }
        }

        public override string Caption
        {
            set
            {
                base.Caption = value;

                UpdateDescription();
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

                UpdateDescription();
            }
        }

        public override bool FileSaved
        {
            set
            {
                base.FileSaved = value;

                UpdateDescription();
            }
        }

        protected void UpdateDescription()
        {
            lblDetails.Text = string.Format("{0} - {1}\r\n{2}",
                PicDate == null ? string.Empty : PicDate.ToString("yyyy-MM-dd"),
                base.FromCountry == null ? string.Empty : base.FromCountry.Name,
                Caption);
        }
    }
}
