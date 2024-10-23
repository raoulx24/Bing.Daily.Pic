using Bing.Daily.Pic.UI.Interfaces;
using System.Windows.Forms;

namespace Bing.Daily.Pic.UI.UserControls.Containers
{
    public partial class BingDailyPictureContainerBase
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
            this.flowLayoutBingDaily = new System.Windows.Forms.FlowLayoutPanel();
            this.mainBingPicture = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.mainBingPicture)).BeginInit();
            this.SuspendLayout();
            // 
            // flowLayoutBingDaily
            // 
            this.flowLayoutBingDaily.AutoSize = true;
            this.flowLayoutBingDaily.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.flowLayoutBingDaily.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.flowLayoutBingDaily.Dock = System.Windows.Forms.DockStyle.Top;
            this.flowLayoutBingDaily.Location = new System.Drawing.Point(0, 0);
            this.flowLayoutBingDaily.Name = "flowLayoutBingDaily";
            this.flowLayoutBingDaily.Size = new System.Drawing.Size(524, 4);
            this.flowLayoutBingDaily.TabIndex = 1;
            // 
            // mainBingPicture
            // 
            this.mainBingPicture.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainBingPicture.Location = new System.Drawing.Point(0, 4);
            this.mainBingPicture.Name = "mainBingPicture";
            this.mainBingPicture.Size = new System.Drawing.Size(524, 419);
            this.mainBingPicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.mainBingPicture.TabIndex = 2;
            this.mainBingPicture.TabStop = false;
            this.mainBingPicture.Visible = false;
            // 
            // BingDailyPictureContainerBase
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.Controls.Add(this.mainBingPicture);
            this.Controls.Add(this.flowLayoutBingDaily);
            this.Name = "BingDailyPictureContainerBase";
            this.Size = new System.Drawing.Size(524, 423);
            ((System.ComponentModel.ISupportInitialize)(this.mainBingPicture)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        protected System.Windows.Forms.FlowLayoutPanel flowLayoutBingDaily;
        protected System.Windows.Forms.PictureBox mainBingPicture;
    }
}
