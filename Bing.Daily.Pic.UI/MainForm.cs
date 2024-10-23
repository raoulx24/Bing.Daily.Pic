using Bing.Daily.Pic.Common.Dtos;
using Bing.Daily.Pic.Common.Settings;
using Bing.Daily.Pic.UI.UserControls.Pages;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bing.Daily.Pic.UI
{
    public partial class MainForm : Form
    {
        public MainForm(BingDailyPageBase injectedStartBingDailyPage)
        {
            bingDailyPage = injectedStartBingDailyPage;
            InitializeComponentBingDailyPage(bingDailyPage);

            InitializeComponent();

            SetParamsInBingDailyPage(bingDailyPage);
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private AppSettings _appSettings = new AppSettings();

        private void MainForm_Load(object sender, EventArgs e)
        {
            bingDailyPage.RefreshBingDailyInfo();
        }

        private void btnHorizontal_Click(object sender, EventArgs e)
        {
            ChangeBingDailyPageTo<BingDailyWithSmallPictureContainerPage>();
        }

        private void btnVertical_Click(object sender, EventArgs e)
        {
            ChangeBingDailyPageTo<BingDailyWithSmallPictureVerticalContainerPage>();
        }

        private void btnBig_Click(object sender, EventArgs e)
        {
            ChangeBingDailyPageTo<BingDailyWithBigPictureContainerPage>();
        }

        private void btnDetails_Click(object sender, EventArgs e)
        {
            ChangeBingDailyPageTo<BingDailyWithDetailedPictureContainerPage>();
        }

        private void ChangeBingDailyPageTo<TBingDailyPagePictureContainer>()
            where TBingDailyPagePictureContainer : BingDailyPageBase, new()
        {
            if (bingDailyPage is TBingDailyPagePictureContainer)
                return;

            List<BingImageInfoDto> images = bingDailyPage.Images;

            TBingDailyPagePictureContainer newPage = new TBingDailyPagePictureContainer();
            newPage.Dock = DockStyle.Fill;

            SetParamsInBingDailyPage(newPage);
            InitializeComponentBingDailyPage(newPage);

            pnlBingDailyPage.SuspendLayout();

            pnlBingDailyPage.Controls.Remove(bingDailyPage);

            bingDailyPage = newPage;

            pnlBingDailyPage.Controls.Add(bingDailyPage);

            pnlBingDailyPage.ResumeLayout();

            newPage.Images = images;
        }

        private void SetParamsInBingDailyPage(BingDailyPageBase bingPage)
        {
            bingPage.CountriesManger = _appSettings.CountriesManger;
            bingPage.TempFilesStorageManager = _appSettings.TempFiles;
            bingPage.OutImageFolder = _appSettings.OutPictureFolder;
        }

        private void InitializeComponentBingDailyPage(BingDailyPageBase bingPage)
        {
            // 
            // bingDailyPage
            //
            bingPage.Dock = System.Windows.Forms.DockStyle.Fill;
            bingPage.Location = new System.Drawing.Point(0, 0);
            bingPage.Name = "bingDailyPage";
            bingPage.Size = new System.Drawing.Size(792, 395);
            bingPage.TabIndex = 0;
        }
    }
}
