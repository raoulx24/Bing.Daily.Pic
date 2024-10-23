using Bing.Daily.Pic.UI.Interfaces;
using Bing.Daily.Pic.UI.UserControls.Containers;
using Bing.Daily.Pic.UI.UserControls.Pages;
using Bing.Daily.Pic.UI.UserControls.Views;
using System.Windows.Forms;

namespace Bing.Daily.Pic.UI
{
    partial class MainForm
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.pnlViewTypes = new System.Windows.Forms.Panel();
            this.lblViewType = new System.Windows.Forms.Label();
            this.bntDetails = new System.Windows.Forms.Button();
            this.btnBig = new System.Windows.Forms.Button();
            this.btnHorizontal = new System.Windows.Forms.Button();
            this.btnVertical = new System.Windows.Forms.Button();
            this.pnlBottom = new System.Windows.Forms.Panel();
            this.btnClose = new System.Windows.Forms.Button();
            this.tabMain = new System.Windows.Forms.TabControl();
            this.tabPageBingDaily = new System.Windows.Forms.TabPage();
            this.pnlBingDailyPage = new System.Windows.Forms.Panel();
            this.tabPageBingArchive = new System.Windows.Forms.TabPage();
            this.pnlViewTypes.SuspendLayout();
            this.pnlBottom.SuspendLayout();
            this.tabMain.SuspendLayout();
            this.tabPageBingDaily.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlViewTypes
            // 
            this.pnlViewTypes.Controls.Add(this.lblViewType);
            this.pnlViewTypes.Controls.Add(this.bntDetails);
            this.pnlViewTypes.Controls.Add(this.btnBig);
            this.pnlViewTypes.Controls.Add(this.btnHorizontal);
            this.pnlViewTypes.Controls.Add(this.btnVertical);
            this.pnlViewTypes.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlViewTypes.Location = new System.Drawing.Point(0, 0);
            this.pnlViewTypes.Name = "pnlViewTypes";
            this.pnlViewTypes.Size = new System.Drawing.Size(792, 29);
            this.pnlViewTypes.TabIndex = 0;
            // 
            // lblViewType
            // 
            this.lblViewType.AutoSize = true;
            this.lblViewType.Location = new System.Drawing.Point(3, 8);
            this.lblViewType.Name = "lblViewType";
            this.lblViewType.Size = new System.Drawing.Size(59, 13);
            this.lblViewType.TabIndex = 4;
            this.lblViewType.Text = "View mode";
            // 
            // bntDetails
            // 
            this.bntDetails.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.bntDetails.Location = new System.Drawing.Point(471, 3);
            this.bntDetails.Name = "bntDetails";
            this.bntDetails.Size = new System.Drawing.Size(75, 23);
            this.bntDetails.TabIndex = 3;
            this.bntDetails.Text = "Details";
            this.bntDetails.UseVisualStyleBackColor = true;
            this.bntDetails.Click += new System.EventHandler(this.btnDetails_Click);
            // 
            // btnBig
            // 
            this.btnBig.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnBig.Location = new System.Drawing.Point(552, 3);
            this.btnBig.Name = "btnBig";
            this.btnBig.Size = new System.Drawing.Size(75, 23);
            this.btnBig.TabIndex = 2;
            this.btnBig.Text = "Big Images";
            this.btnBig.UseVisualStyleBackColor = true;
            this.btnBig.Click += new System.EventHandler(this.btnBig_Click);
            // 
            // btnHorizontal
            // 
            this.btnHorizontal.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnHorizontal.Location = new System.Drawing.Point(633, 3);
            this.btnHorizontal.Name = "btnHorizontal";
            this.btnHorizontal.Size = new System.Drawing.Size(75, 23);
            this.btnHorizontal.TabIndex = 1;
            this.btnHorizontal.Text = "Horizontal";
            this.btnHorizontal.UseVisualStyleBackColor = true;
            this.btnHorizontal.Click += new System.EventHandler(this.btnHorizontal_Click);
            // 
            // btnVertical
            // 
            this.btnVertical.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnVertical.Location = new System.Drawing.Point(714, 3);
            this.btnVertical.Name = "btnVertical";
            this.btnVertical.Size = new System.Drawing.Size(75, 23);
            this.btnVertical.TabIndex = 1;
            this.btnVertical.Text = "Vertical";
            this.btnVertical.UseVisualStyleBackColor = true;
            this.btnVertical.Click += new System.EventHandler(this.btnVertical_Click);
            // 
            // pnlBottom
            // 
            this.pnlBottom.Controls.Add(this.btnClose);
            this.pnlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlBottom.Location = new System.Drawing.Point(0, 421);
            this.pnlBottom.Name = "pnlBottom";
            this.pnlBottom.Size = new System.Drawing.Size(800, 29);
            this.pnlBottom.TabIndex = 1;
            // 
            // btnClose
            // 
            this.btnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClose.Location = new System.Drawing.Point(713, 3);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(75, 23);
            this.btnClose.TabIndex = 2;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // tabMain
            // 
            this.tabMain.Controls.Add(this.tabPageBingDaily);
            this.tabMain.Controls.Add(this.tabPageBingArchive);
            this.tabMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabMain.Location = new System.Drawing.Point(0, 0);
            this.tabMain.Name = "tabMain";
            this.tabMain.SelectedIndex = 0;
            this.tabMain.Size = new System.Drawing.Size(800, 421);
            this.tabMain.TabIndex = 2;
            // 
            // tabPageBingDaily
            // 
            this.tabPageBingDaily.Controls.Add(this.pnlBingDailyPage);
            this.tabPageBingDaily.Controls.Add(this.pnlViewTypes);
            this.tabPageBingDaily.Location = new System.Drawing.Point(4, 22);
            this.tabPageBingDaily.Name = "tabPageBingDaily";
            this.tabPageBingDaily.Size = new System.Drawing.Size(792, 395);
            this.tabPageBingDaily.TabIndex = 2;
            this.tabPageBingDaily.Text = "Bing Daily";
            this.tabPageBingDaily.UseVisualStyleBackColor = true;
            // 
            // pnlBingDailyPage
            // 
            this.pnlBingDailyPage.Controls.Add(this.bingDailyPage);
            this.pnlBingDailyPage.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlBingDailyPage.Location = new System.Drawing.Point(0, 29);
            this.pnlBingDailyPage.Name = "pnlBingDailyPage";
            this.pnlBingDailyPage.Size = new System.Drawing.Size(792, 366);
            this.pnlBingDailyPage.TabIndex = 1;
            // 
            // tabPageBingArchive
            // 
            this.tabPageBingArchive.Location = new System.Drawing.Point(4, 22);
            this.tabPageBingArchive.Name = "tabPageBingArchive";
            this.tabPageBingArchive.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageBingArchive.Size = new System.Drawing.Size(792, 395);
            this.tabPageBingArchive.TabIndex = 1;
            this.tabPageBingArchive.Text = "Bing Image Archive";
            this.tabPageBingArchive.UseVisualStyleBackColor = true;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tabMain);
            this.Controls.Add(this.pnlBottom);
            this.Name = "MainForm";
            this.Text = "Bing Daily Picture";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.pnlViewTypes.ResumeLayout(false);
            this.pnlViewTypes.PerformLayout();
            this.pnlBottom.ResumeLayout(false);
            this.tabMain.ResumeLayout(false);
            this.tabPageBingDaily.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlViewTypes;
        private System.Windows.Forms.Label lblViewType;
        private System.Windows.Forms.Button bntDetails;
        private System.Windows.Forms.Button btnBig;
        private System.Windows.Forms.Button btnHorizontal;
        private System.Windows.Forms.Button btnVertical;

        private System.Windows.Forms.Panel pnlBottom;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.TabControl tabMain;
        private System.Windows.Forms.TabPage tabPageBingArchive;
        private System.Windows.Forms.TabPage tabPageBingDaily;
        private Panel pnlBingDailyPage;
        private BingDailyPageBase bingDailyPage;
    }
}

