namespace Bing.Daily.Pic.UI.UserControls.Views
{
    partial class BingDailySmallPictureView
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
            this.pnlDetails = new System.Windows.Forms.Panel();
            this.lblDetails = new System.Windows.Forms.Label();
            this.picBingDaily = new System.Windows.Forms.PictureBox();
            this.pnlDetails.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picBingDaily)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlDetails
            // 
            this.pnlDetails.Controls.Add(this.lblDetails);
            this.pnlDetails.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlDetails.Location = new System.Drawing.Point(0, 138);
            this.pnlDetails.Name = "pnlDetails";
            this.pnlDetails.Size = new System.Drawing.Size(223, 44);
            this.pnlDetails.TabIndex = 0;
            // 
            // lblDetails
            // 
            this.lblDetails.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblDetails.Location = new System.Drawing.Point(3, 0);
            this.lblDetails.Name = "lblDetails";
            this.lblDetails.Size = new System.Drawing.Size(217, 44);
            this.lblDetails.TabIndex = 0;
            // 
            // picBingDaily
            // 
            this.picBingDaily.Dock = System.Windows.Forms.DockStyle.Fill;
            this.picBingDaily.Location = new System.Drawing.Point(0, 0);
            this.picBingDaily.Name = "picBingDaily";
            this.picBingDaily.Size = new System.Drawing.Size(223, 138);
            this.picBingDaily.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picBingDaily.TabIndex = 1;
            this.picBingDaily.TabStop = false;
            // 
            // BingDailySmallPictureView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.picBingDaily);
            this.Controls.Add(this.pnlDetails);
            this.Name = "BingDailySmallPictureView";
            this.Size = new System.Drawing.Size(223, 182);
            this.pnlDetails.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picBingDaily)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlDetails;
        private System.Windows.Forms.Label lblDetails;
        private System.Windows.Forms.PictureBox picBingDaily;
    }
}
