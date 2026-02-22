using Bing.Daily.Pic.Common.Dtos;
using Bing.Daily.Pic.Common.Managers;
using Bing.Daily.Pic.UI.BingDailyEventArgs;
using Bing.Daily.Pic.UI.Interfaces;
using Bing.Daily.Pic.UI.Presenters;
using CustomUserControls;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.ComponentModel;

namespace Bing.Daily.Pic.UI.UserControls.Views
{
    public class BingDailyPictureViewBase : UserControl, IDownloadPictureView, IBingDailyPictureView, ISavePictureView
    {
        public BingDailyPictureViewBase()
        {
            InitializeComponent();

            InitializeInternalPresenters();
        }

        private void InitializeInternalPresenters()
        {
            _savePicturePresenter = new SavePicturePresenter(this);
        }

        public void DownloadBingImage()
        {
            OnDownloadPictureRequested(this);
        }

        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public virtual DateTime PicDate
        {
            get
            {
                return _picDateUtc;
            }
            set
            {
                TimeZoneInfo tzi = FromCountry is null ? TimeZoneInfo.Local : TimeZoneInfo.FindSystemTimeZoneById(FromCountry.TimeZoneId);

                _picDateUtc = TimeZoneInfo.ConvertTimeFromUtc(value, tzi);
            }
        }

        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public virtual Uri PicUri
        {
            get { return _picUri; }
            set { _picUri = value; }
        }

        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public virtual string Caption
        {
            get { return _caption; }
            set
            {
                string caption = value;

                if (!string.IsNullOrEmpty(value))
                {
                    int indexOf = value.IndexOf(" (©");

                    if (indexOf >= 0)
                    {
                        caption = caption.Substring(0, indexOf);
                    }
                }

                _caption = caption;
            }
        }

        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public virtual CountryDto FromCountry
        {
            get { return _country; }
            set { _country = value; }
        }

        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public virtual string DownloadedFileName
        {
            get { return _downloadedFileName; }
            set
            {
                _downloadedFileName = value;
                ImageInfo.DownloadedFileName = value;
            }
        }

        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public virtual string OutImageFolder
        {
            get { return _outImageFolder; }
            set { _outImageFolder = value; }
        }

        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public virtual ImagesStorageManager TempImagesStorageManager
        {
            get { return _tempImagesStorageManager; }
            set { _tempImagesStorageManager = value; }
        }

        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public virtual bool FileSaved
        {
            get { return _fileSaved; }
            set { _fileSaved = value; }
        }

        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public BingImageInfoDto ImageInfo { get; set; }

        public event EventHandler<DownloadPictureEventArgs> DownloadPictureRequested;

        public event EventHandler<SavePictureEventArgs> SavePictureRequested;

        protected virtual void OnDownloadPictureRequested(object sender)
        {
            if (DownloadPictureRequested == null)
            {
                return;
            }

            DownloadPictureEventArgs e = new DownloadPictureEventArgs
            {
                PictureUrl = PicUri,
                FileName = _tempImagesStorageManager.AddNewTempFile("jpg"),
                ImagesFolder = _tempImagesStorageManager.TempFolder
            };

            DownloadPictureRequested(sender, e);
        }

        protected virtual void OnSavePictureRequested(object sender)
        {
            if (SavePictureRequested is null)
                return;

            SavePictureEventArgs e = new SavePictureEventArgs
            {
                Description = Caption,
                PictureCountry = FromCountry,
                PictureDate = PicDate,
                SaveToFolder = OutImageFolder,
                TempDownloadedFile = DownloadedFileName
            };

            SavePictureRequested(this, e);
        }

        protected virtual void OnOpenFileRequested(object sender)
        {
            Process.Start(new ProcessStartInfo(DownloadedFileName) { UseShellExecute = true });
        }

        protected virtual Image LoadImageFromFile(string fileName)
        {
            if (fileName != null)
                return Image.FromFile(fileName);

            return new Bitmap(1, 1);
        }

        private void InitializeComponent()
        {
            this.pnlTransparent = new TransparentPanel();
            this.SuspendLayout();
            // 
            // pnlTransparent
            // 
            this.pnlTransparent.BackColor = System.Drawing.Color.Transparent;
            this.pnlTransparent.Location = new System.Drawing.Point(0, 0);
            this.pnlTransparent.Name = "pnlTransparent";
            this.pnlTransparent.Size = new System.Drawing.Size(10, 10);
            this.pnlTransparent.TabIndex = 0;
            this.pnlTransparent.Click += new System.EventHandler(this.pnlTransparent_Click);
            this.pnlTransparent.SendToBack();
            // 
            // BingDailyPictureViewBase
            // 
            this.Controls.Add(this.pnlTransparent);
            this.Name = "BingDailyPictureViewBase";
            this.ResumeLayout(false);

        }

        public void ArrangeControls()
        {
            pnlTransparent.Size = this.Size;
            pnlTransparent.Location = new System.Drawing.Point(0, 0);

            pnlTransparent.BringToFront();

            ArrangeControlsRecursive(this.Controls);
        }

        private void ArrangeControlsRecursive(ControlCollection controls)
        {
            foreach(Control control in controls)
            {
                if (control is Button || control is Panel)
                {
                    control.BringToFront();
                }

                ArrangeControlsRecursive(control.Controls);
            }
        }

        private void pnlTransparent_Click(object sender, EventArgs e)
        {
            pnlTransparent.Select();
        }

        private CountryDto _country;
        private DateTime _picDateUtc;
        private Uri _picUri;
        private string _caption;
        private string _downloadedFileName;
        private string _outImageFolder;
        private Panel pnlTransparent;
        private ImagesStorageManager _tempImagesStorageManager;
        private bool _fileSaved = false;

        private SavePicturePresenter _savePicturePresenter;
    }
}
