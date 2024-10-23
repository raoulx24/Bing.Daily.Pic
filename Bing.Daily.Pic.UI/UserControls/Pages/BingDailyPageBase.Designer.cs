using Bing.Daily.Pic.UI.UserControls.Containers;

namespace Bing.Daily.Pic.UI.UserControls.Pages
{
    public partial class BingDailyPageBase
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            //this.pnlViewTypes = new System.Windows.Forms.Panel();
            //this.btnMasterDetails = new System.Windows.Forms.Button();
            //this.btnBig = new System.Windows.Forms.Button();
            //this.bntDetails = new System.Windows.Forms.Button();
            //this.lblViewType = new System.Windows.Forms.Label();
            this.pnlCommands = new System.Windows.Forms.Panel();
            this.btnSortByCountry = new System.Windows.Forms.Button();
            this.btnSortByDate = new System.Windows.Forms.Button();
            //this.bingDailyPictureContainer = new TBingDailyContainer();
            //this.pnlViewTypes.SuspendLayout();
            this.pnlCommands.SuspendLayout();
            this.SuspendLayout();
            //// 
            //// pnlViewTypes
            //// 
            //this.pnlViewTypes.Controls.Add(this.lblViewType);
            //this.pnlViewTypes.Controls.Add(this.bntDetails);
            //this.pnlViewTypes.Controls.Add(this.btnBig);
            //this.pnlViewTypes.Controls.Add(this.btnMasterDetails);
            //this.pnlViewTypes.Dock = System.Windows.Forms.DockStyle.Top;
            //this.pnlViewTypes.Location = new System.Drawing.Point(0, 0);
            //this.pnlViewTypes.Name = "pnlViewTypes";
            //this.pnlViewTypes.Size = new System.Drawing.Size(744, 29);
            //this.pnlViewTypes.TabIndex = 0;
            //// 
            //// btnMasterDetails
            //// 
            //this.btnMasterDetails.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            //this.btnMasterDetails.Location = new System.Drawing.Point(666, 3);
            //this.btnMasterDetails.Name = "btnMasterDetails";
            //this.btnMasterDetails.Size = new System.Drawing.Size(75, 23);
            //this.btnMasterDetails.TabIndex = 1;
            //this.btnMasterDetails.Text = "Master/Detail";
            //this.btnMasterDetails.UseVisualStyleBackColor = true;
            //this.btnMasterDetails.Click += btnMasterDetails_Click;
            //// 
            //// btnBig
            //// 
            //this.btnBig.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            //this.btnBig.Location = new System.Drawing.Point(585, 3);
            //this.btnBig.Name = "btnBig";
            //this.btnBig.Size = new System.Drawing.Size(75, 23);
            //this.btnBig.TabIndex = 2;
            //this.btnBig.Text = "Big Images";
            //this.btnBig.UseVisualStyleBackColor = true;
            //this.btnBig.Click += btnBig_Click;
            //// 
            //// bntDetails
            //// 
            //this.bntDetails.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            //this.bntDetails.Location = new System.Drawing.Point(504, 3);
            //this.bntDetails.Name = "bntDetails";
            //this.bntDetails.Size = new System.Drawing.Size(75, 23);
            //this.bntDetails.TabIndex = 3;
            //this.bntDetails.Text = "Details";
            //this.bntDetails.UseVisualStyleBackColor = true;
            //this.bntDetails.Click += btnBig_Click;
            //// 
            //// lblViewType
            //// 
            //this.lblViewType.AutoSize = true;
            //this.lblViewType.Location = new System.Drawing.Point(3, 8);
            //this.lblViewType.Name = "lblViewType";
            //this.lblViewType.Size = new System.Drawing.Size(59, 13);
            //this.lblViewType.TabIndex = 4;
            //this.lblViewType.Text = "View mode";
            // 
            // pnlCommands
            // 
            this.pnlCommands.Controls.Add(this.btnSortByDate);
            this.pnlCommands.Controls.Add(this.btnSortByCountry);
            this.pnlCommands.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlCommands.Location = new System.Drawing.Point(0, 425);
            this.pnlCommands.Name = "pnlCommands";
            this.pnlCommands.Size = new System.Drawing.Size(744, 29);
            this.pnlCommands.TabIndex = 1;
            // 
            // btnSortByCountry
            // 
            this.btnSortByCountry.Location = new System.Drawing.Point(3, 3);
            this.btnSortByCountry.Name = "btnSortByCountry";
            this.btnSortByCountry.Size = new System.Drawing.Size(89, 23);
            this.btnSortByCountry.TabIndex = 0;
            this.btnSortByCountry.Text = "Sort by County";
            this.btnSortByCountry.UseVisualStyleBackColor = true;
            this.btnSortByCountry.Click += new System.EventHandler(this.btnSortByCountry_Click);
            // 
            // btnSortByDate
            // 
            this.btnSortByDate.Location = new System.Drawing.Point(98, 3);
            this.btnSortByDate.Name = "btnSortByDate";
            this.btnSortByDate.Size = new System.Drawing.Size(89, 23);
            this.btnSortByDate.TabIndex = 2;
            this.btnSortByDate.Text = "Sort by Date";
            this.btnSortByDate.UseVisualStyleBackColor = true;
            this.btnSortByDate.Click += new System.EventHandler(this.btnSortByDate_Click);
            // 
            // bingDailyPictureContainer
            // 
            this.bingDailyPictureContainer.CountriesManger = null;
            this.bingDailyPictureContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bingDailyPictureContainer.Images = null;
            this.bingDailyPictureContainer.Location = new System.Drawing.Point(0, 29);
            this.bingDailyPictureContainer.Name = "bingDailyPictureContainer";
            this.bingDailyPictureContainer.OutImageFolder = null;
            this.bingDailyPictureContainer.Size = new System.Drawing.Size(744, 396);
            this.bingDailyPictureContainer.TabIndex = 2;
            this.bingDailyPictureContainer.TempFilesStorageManager = null;
            // 
            // BingDailyPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.bingDailyPictureContainer);
            this.Controls.Add(this.pnlCommands);
            //this.Controls.Add(this.pnlViewTypes);
            this.Name = "BingDailyPage";
            this.Size = new System.Drawing.Size(744, 454);
            //this.pnlViewTypes.ResumeLayout(false);
            //this.pnlViewTypes.PerformLayout();
            this.pnlCommands.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        //private System.Windows.Forms.Panel pnlViewTypes;
        //private System.Windows.Forms.Label lblViewType;
        //private System.Windows.Forms.Button bntDetails;
        //private System.Windows.Forms.Button btnBig;
        //private System.Windows.Forms.Button btnMasterDetails;
        private System.Windows.Forms.Panel pnlCommands;
        private System.Windows.Forms.Button btnSortByDate;
        private System.Windows.Forms.Button btnSortByCountry;
        private BingDailyPictureContainerBase bingDailyPictureContainer;
    }
}
