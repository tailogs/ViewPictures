namespace ViewPictures
{
    partial class Export
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Export));
            this.pictureBoxMain = new System.Windows.Forms.PictureBox();
            this.radioButtonPNG = new System.Windows.Forms.RadioButton();
            this.groupBoxExt = new System.Windows.Forms.GroupBox();
            this.radioButtonBMP = new System.Windows.Forms.RadioButton();
            this.radioButtonICO = new System.Windows.Forms.RadioButton();
            this.radioButtonGIF = new System.Windows.Forms.RadioButton();
            this.radioButtonJPEG = new System.Windows.Forms.RadioButton();
            this.radioButtonJPG = new System.Windows.Forms.RadioButton();
            this.btnExport = new System.Windows.Forms.Button();
            this.trackBarImageScale = new System.Windows.Forms.TrackBar();
            this.textBoxImageScale = new System.Windows.Forms.TextBox();
            this.textBoxImageSize = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxMain)).BeginInit();
            this.groupBoxExt.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarImageScale)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBoxMain
            // 
            this.pictureBoxMain.BackColor = System.Drawing.Color.LightCoral;
            resources.ApplyResources(this.pictureBoxMain, "pictureBoxMain");
            this.pictureBoxMain.Name = "pictureBoxMain";
            this.pictureBoxMain.TabStop = false;
            // 
            // radioButtonPNG
            // 
            resources.ApplyResources(this.radioButtonPNG, "radioButtonPNG");
            this.radioButtonPNG.Name = "radioButtonPNG";
            this.radioButtonPNG.TabStop = true;
            this.radioButtonPNG.UseVisualStyleBackColor = true;
            // 
            // groupBoxExt
            // 
            this.groupBoxExt.Controls.Add(this.radioButtonBMP);
            this.groupBoxExt.Controls.Add(this.radioButtonICO);
            this.groupBoxExt.Controls.Add(this.radioButtonGIF);
            this.groupBoxExt.Controls.Add(this.radioButtonJPEG);
            this.groupBoxExt.Controls.Add(this.radioButtonJPG);
            this.groupBoxExt.Controls.Add(this.radioButtonPNG);
            resources.ApplyResources(this.groupBoxExt, "groupBoxExt");
            this.groupBoxExt.ForeColor = System.Drawing.Color.Pink;
            this.groupBoxExt.Name = "groupBoxExt";
            this.groupBoxExt.TabStop = false;
            // 
            // radioButtonBMP
            // 
            resources.ApplyResources(this.radioButtonBMP, "radioButtonBMP");
            this.radioButtonBMP.Name = "radioButtonBMP";
            this.radioButtonBMP.TabStop = true;
            this.radioButtonBMP.UseVisualStyleBackColor = true;
            // 
            // radioButtonICO
            // 
            resources.ApplyResources(this.radioButtonICO, "radioButtonICO");
            this.radioButtonICO.Name = "radioButtonICO";
            this.radioButtonICO.TabStop = true;
            this.radioButtonICO.UseVisualStyleBackColor = true;
            // 
            // radioButtonGIF
            // 
            resources.ApplyResources(this.radioButtonGIF, "radioButtonGIF");
            this.radioButtonGIF.Name = "radioButtonGIF";
            this.radioButtonGIF.TabStop = true;
            this.radioButtonGIF.UseVisualStyleBackColor = true;
            // 
            // radioButtonJPEG
            // 
            resources.ApplyResources(this.radioButtonJPEG, "radioButtonJPEG");
            this.radioButtonJPEG.Name = "radioButtonJPEG";
            this.radioButtonJPEG.TabStop = true;
            this.radioButtonJPEG.UseVisualStyleBackColor = true;
            // 
            // radioButtonJPG
            // 
            resources.ApplyResources(this.radioButtonJPG, "radioButtonJPG");
            this.radioButtonJPG.Name = "radioButtonJPG";
            this.radioButtonJPG.TabStop = true;
            this.radioButtonJPG.UseVisualStyleBackColor = true;
            // 
            // btnExport
            // 
            this.btnExport.BackColor = System.Drawing.Color.Brown;
            resources.ApplyResources(this.btnExport, "btnExport");
            this.btnExport.ForeColor = System.Drawing.Color.Pink;
            this.btnExport.Name = "btnExport";
            this.btnExport.UseVisualStyleBackColor = false;
            this.btnExport.Click += new System.EventHandler(this.btnExport_Click);
            // 
            // trackBarImageScale
            // 
            this.trackBarImageScale.LargeChange = 1;
            resources.ApplyResources(this.trackBarImageScale, "trackBarImageScale");
            this.trackBarImageScale.Maximum = 20;
            this.trackBarImageScale.Minimum = 1;
            this.trackBarImageScale.Name = "trackBarImageScale";
            this.trackBarImageScale.TickStyle = System.Windows.Forms.TickStyle.TopLeft;
            this.trackBarImageScale.Value = 10;
            this.trackBarImageScale.Scroll += new System.EventHandler(this.trackBarImageScale_Scroll);
            this.trackBarImageScale.ValueChanged += new System.EventHandler(this.trackBarImageScale_ValueChanged);
            // 
            // textBoxImageScale
            // 
            this.textBoxImageScale.BackColor = System.Drawing.Color.IndianRed;
            this.textBoxImageScale.BorderStyle = System.Windows.Forms.BorderStyle.None;
            resources.ApplyResources(this.textBoxImageScale, "textBoxImageScale");
            this.textBoxImageScale.ForeColor = System.Drawing.Color.Pink;
            this.textBoxImageScale.Name = "textBoxImageScale";
            this.textBoxImageScale.ReadOnly = true;
            // 
            // textBoxImageSize
            // 
            this.textBoxImageSize.BackColor = System.Drawing.Color.IndianRed;
            resources.ApplyResources(this.textBoxImageSize, "textBoxImageSize");
            this.textBoxImageSize.ForeColor = System.Drawing.Color.Pink;
            this.textBoxImageSize.Name = "textBoxImageSize";
            this.textBoxImageSize.ReadOnly = true;
            // 
            // Export
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.IndianRed;
            this.Controls.Add(this.textBoxImageSize);
            this.Controls.Add(this.textBoxImageScale);
            this.Controls.Add(this.trackBarImageScale);
            this.Controls.Add(this.btnExport);
            this.Controls.Add(this.groupBoxExt);
            this.Controls.Add(this.pictureBoxMain);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Export";
            this.Load += new System.EventHandler(this.Export_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxMain)).EndInit();
            this.groupBoxExt.ResumeLayout(false);
            this.groupBoxExt.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarImageScale)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBoxMain;
        private System.Windows.Forms.RadioButton radioButtonPNG;
        private System.Windows.Forms.GroupBox groupBoxExt;
        private System.Windows.Forms.RadioButton radioButtonJPEG;
        private System.Windows.Forms.RadioButton radioButtonJPG;
        private System.Windows.Forms.RadioButton radioButtonBMP;
        private System.Windows.Forms.RadioButton radioButtonICO;
        private System.Windows.Forms.RadioButton radioButtonGIF;
        private System.Windows.Forms.Button btnExport;
        private System.Windows.Forms.TrackBar trackBarImageScale;
        private System.Windows.Forms.TextBox textBoxImageScale;
        private System.Windows.Forms.TextBox textBoxImageSize;
    }
}