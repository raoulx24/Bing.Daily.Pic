using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Bing.Daily.Pic.Common.Interfaces;
using Bing.Daily.Pic.Common.Managers;
using Bing.Daily.Pic.Common.Dtos;
using Bing.Daily.Pic.UI.UserControls.Containers;
using Bing.Daily.Pic.UI.Interfaces;
using Bing.Daily.Pic.UI.UserControls.Views;

namespace Bing.Daily.Pic.UI.UserControls.Pages
{
    public abstract partial class BingDailyPageBase : UserControl
    {
        public BingDailyPageBase()
        { }

        public BingDailyPageBase(BingDailyPictureContainerBase bingDailyPictureContainer)
        {
            this.bingDailyPictureContainer = bingDailyPictureContainer;

            InitializeComponent();

            bingDailyPictureContainer.CountriesManger = CountriesManger;
            bingDailyPictureContainer.TempFilesStorageManager = TempFilesStorageManager;
            bingDailyPictureContainer.OutImageFolder = OutImageFolder;
        }

        public void RefreshBingDailyInfo()
        {
            bingDailyPictureContainer.RefreshFromWebBingDailyInfo();
        }

        private void btnSortByCountry_Click(object sender, EventArgs e)
        {
            bingDailyPictureContainer.SortByCountry();
        }

        private void btnSortByDate_Click(object sender, EventArgs e)
        {
            bingDailyPictureContainer.SortByDate();
        }

        public ICountrySettingsManager CountriesManger
        {
            get { return _countriesManger; }
            set
            {
                _countriesManger = value;
                bingDailyPictureContainer.CountriesManger = value;
            }
        }
        public ImagesStorageManager TempFilesStorageManager
        {
            get { return _tempFilesStorageManager; }
            set
            {
                _tempFilesStorageManager = value;
                bingDailyPictureContainer.TempFilesStorageManager = value;
            }
        }
        public string OutImageFolder
        {
            get { return _outImageFolder; }
            set
            {
                _outImageFolder = value;
                bingDailyPictureContainer.OutImageFolder = value;
            }
        }
        public List<BingImageInfoDto> Images
        {
            get { return bingDailyPictureContainer.Images; }
            set { bingDailyPictureContainer.NewImages = value; }
        }

        //private void btnMasterDetails_Click(object sender, EventArgs e)
        //{
        //    List<BingImageInfoDto> images = Images;

        //}

        //private void btnBig_Click(object sender, EventArgs e)
        //{

        //}

        //private void bntDetails_Click(object sender, EventArgs e)
        //{

        //}

        private ICountrySettingsManager _countriesManger = null;
        private ImagesStorageManager _tempFilesStorageManager;
        private string _outImageFolder;
    }
}
