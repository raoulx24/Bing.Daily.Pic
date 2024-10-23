namespace Bing.Daily.Pic.UI.UserControls.Views
{
    partial class BingDailyDetailedPictureView
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
            this.pnlImage = new System.Windows.Forms.Panel();
            this.picBingDaily = new System.Windows.Forms.PictureBox();
            this.pnlInfo = new System.Windows.Forms.Panel();
            this.btnSave = new System.Windows.Forms.Button();
            this.txtPicDate = new CustomUserControls.EnhancedTextBox();
            this.txtCaption = new CustomUserControls.EnhancedTextBox();
            this.txtFromCountry = new CustomUserControls.EnhancedTextBox();
            this.txtPicUri = new CustomUserControls.EnhancedTextBox();
            this.pnlImage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picBingDaily)).BeginInit();
            this.pnlInfo.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlImage
            // 
            this.pnlImage.Controls.Add(this.picBingDaily);
            this.pnlImage.Dock = System.Windows.Forms.DockStyle.Right;
            this.pnlImage.Location = new System.Drawing.Point(509, 0);
            this.pnlImage.Name = "pnlImage";
            this.pnlImage.Size = new System.Drawing.Size(232, 126);
            this.pnlImage.TabIndex = 5;
            // 
            // picBingDaily
            // 
            this.picBingDaily.Dock = System.Windows.Forms.DockStyle.Fill;
            this.picBingDaily.Location = new System.Drawing.Point(0, 0);
            this.picBingDaily.Name = "picBingDaily";
            this.picBingDaily.Size = new System.Drawing.Size(232, 126);
            this.picBingDaily.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picBingDaily.TabIndex = 0;
            this.picBingDaily.TabStop = false;
            // 
            // pnlInfo
            // 
            this.pnlInfo.Controls.Add(this.btnSave);
            this.pnlInfo.Controls.Add(this.txtPicDate);
            this.pnlInfo.Controls.Add(this.txtCaption);
            this.pnlInfo.Controls.Add(this.txtFromCountry);
            this.pnlInfo.Controls.Add(this.txtPicUri);
            this.pnlInfo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlInfo.Location = new System.Drawing.Point(0, 0);
            this.pnlInfo.Name = "pnlInfo";
            this.pnlInfo.Size = new System.Drawing.Size(509, 126);
            this.pnlInfo.TabIndex = 6;
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(432, 100);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 4;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // txtPicDate
            // 
            this.txtPicDate.Label = "Date";
            this.txtPicDate.Location = new System.Drawing.Point(3, 87);
            this.txtPicDate.MultiLine = false;
            this.txtPicDate.Name = "txtPicDate";
            this.txtPicDate.ReadOnly = false;
            this.txtPicDate.Size = new System.Drawing.Size(115, 36);
            this.txtPicDate.TabIndex = 0;
            this.txtPicDate.TextBoxValue = "";
            // 
            // txtCaption
            // 
            this.txtCaption.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtCaption.Label = "Caption";
            this.txtCaption.Location = new System.Drawing.Point(3, 3);
            this.txtCaption.MultiLine = false;
            this.txtCaption.Name = "txtCaption";
            this.txtCaption.ReadOnly = false;
            this.txtCaption.Size = new System.Drawing.Size(500, 36);
            this.txtCaption.TabIndex = 2;
            this.txtCaption.TextBoxValue = "";
            // 
            // txtFromCountry
            // 
            this.txtFromCountry.Label = "Country";
            this.txtFromCountry.Location = new System.Drawing.Point(124, 87);
            this.txtFromCountry.MultiLine = false;
            this.txtFromCountry.Name = "txtFromCountry";
            this.txtFromCountry.ReadOnly = false;
            this.txtFromCountry.Size = new System.Drawing.Size(120, 36);
            this.txtFromCountry.TabIndex = 3;
            this.txtFromCountry.TextBoxValue = "";
            // 
            // txtPicUri
            // 
            this.txtPicUri.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtPicUri.Label = "URL";
            this.txtPicUri.Location = new System.Drawing.Point(3, 45);
            this.txtPicUri.MultiLine = false;
            this.txtPicUri.Name = "txtPicUri";
            this.txtPicUri.ReadOnly = false;
            this.txtPicUri.Size = new System.Drawing.Size(500, 36);
            this.txtPicUri.TabIndex = 1;
            this.txtPicUri.TextBoxValue = "";
            // 
            // BingDailyDetailedPictureView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.Controls.Add(this.pnlInfo);
            this.Controls.Add(this.pnlImage);
            this.Name = "BingDailyDetailedPictureView";
            this.Size = new System.Drawing.Size(741, 126);
            this.pnlImage.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picBingDaily)).EndInit();
            this.pnlInfo.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private CustomUserControls.EnhancedTextBox txtPicDate;
        private CustomUserControls.EnhancedTextBox txtPicUri;
        private CustomUserControls.EnhancedTextBox txtCaption;
        private CustomUserControls.EnhancedTextBox txtFromCountry;
        private System.Windows.Forms.Panel pnlImage;
        private System.Windows.Forms.Panel pnlInfo;
        private System.Windows.Forms.PictureBox picBingDaily;
        private System.Windows.Forms.Button btnSave;
    }
}
