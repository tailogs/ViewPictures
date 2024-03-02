namespace ViewPictures
{
    partial class ZoomMode
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ZoomMode));
            this.trackBarZoomImage = new System.Windows.Forms.TrackBar();
            this.pictureBoxMain = new System.Windows.Forms.PictureBox();
            this.panelMain = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarZoomImage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxMain)).BeginInit();
            this.panelMain.SuspendLayout();
            this.SuspendLayout();
            // 
            // trackBarZoomImage
            // 
            resources.ApplyResources(this.trackBarZoomImage, "trackBarZoomImage");
            this.trackBarZoomImage.LargeChange = 1;
            this.trackBarZoomImage.Minimum = 1;
            this.trackBarZoomImage.Name = "trackBarZoomImage";
            this.trackBarZoomImage.Value = 1;
            this.trackBarZoomImage.Scroll += new System.EventHandler(this.trackBarZoomImage_Scroll);
            // 
            // pictureBoxMain
            // 
            resources.ApplyResources(this.pictureBoxMain, "pictureBoxMain");
            this.pictureBoxMain.Name = "pictureBoxMain";
            this.pictureBoxMain.TabStop = false;
            // 
            // panelMain
            // 
            resources.ApplyResources(this.panelMain, "panelMain");
            this.panelMain.Controls.Add(this.pictureBoxMain);
            this.panelMain.Name = "panelMain";
            // 
            // ZoomMode
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.IndianRed;
            this.Controls.Add(this.trackBarZoomImage);
            this.Controls.Add(this.panelMain);
            this.DoubleBuffered = true;
            this.Name = "ZoomMode";
            this.Load += new System.EventHandler(this.ZoomMode_Load);
            ((System.ComponentModel.ISupportInitialize)(this.trackBarZoomImage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxMain)).EndInit();
            this.panelMain.ResumeLayout(false);
            this.panelMain.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TrackBar trackBarZoomImage;
        private System.Windows.Forms.PictureBox pictureBoxMain;
        private System.Windows.Forms.Panel panelMain;
    }
}