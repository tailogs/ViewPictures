namespace ViewPictures
{
    partial class TrimImage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TrimImage));
            this.btnSaveTrimImage = new System.Windows.Forms.Button();
            this.textBoxСropX = new System.Windows.Forms.TextBox();
            this.textBoxCropY = new System.Windows.Forms.TextBox();
            this.textBoxCropWidth = new System.Windows.Forms.TextBox();
            this.textBoxCropHeight = new System.Windows.Forms.TextBox();
            this.lblСropX = new System.Windows.Forms.Label();
            this.lblCropY = new System.Windows.Forms.Label();
            this.lblCropWidth = new System.Windows.Forms.Label();
            this.lblCropHeight = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnSaveTrimImage
            // 
            this.btnSaveTrimImage.BackColor = System.Drawing.Color.LightCoral;
            resources.ApplyResources(this.btnSaveTrimImage, "btnSaveTrimImage");
            this.btnSaveTrimImage.ForeColor = System.Drawing.Color.Black;
            this.btnSaveTrimImage.Name = "btnSaveTrimImage";
            this.btnSaveTrimImage.UseVisualStyleBackColor = false;
            this.btnSaveTrimImage.Click += new System.EventHandler(this.btnSaveTrimImage_Click);
            // 
            // textBoxСropX
            // 
            this.textBoxСropX.BackColor = System.Drawing.Color.LightCoral;
            this.textBoxСropX.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            resources.ApplyResources(this.textBoxСropX, "textBoxСropX");
            this.textBoxСropX.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.textBoxСropX.Name = "textBoxСropX";
            // 
            // textBoxCropY
            // 
            this.textBoxCropY.BackColor = System.Drawing.Color.LightCoral;
            this.textBoxCropY.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            resources.ApplyResources(this.textBoxCropY, "textBoxCropY");
            this.textBoxCropY.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.textBoxCropY.Name = "textBoxCropY";
            // 
            // textBoxCropWidth
            // 
            this.textBoxCropWidth.BackColor = System.Drawing.Color.LightCoral;
            this.textBoxCropWidth.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            resources.ApplyResources(this.textBoxCropWidth, "textBoxCropWidth");
            this.textBoxCropWidth.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.textBoxCropWidth.Name = "textBoxCropWidth";
            // 
            // textBoxCropHeight
            // 
            this.textBoxCropHeight.BackColor = System.Drawing.Color.LightCoral;
            this.textBoxCropHeight.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            resources.ApplyResources(this.textBoxCropHeight, "textBoxCropHeight");
            this.textBoxCropHeight.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.textBoxCropHeight.Name = "textBoxCropHeight";
            // 
            // lblСropX
            // 
            resources.ApplyResources(this.lblСropX, "lblСropX");
            this.lblСropX.ForeColor = System.Drawing.Color.Pink;
            this.lblСropX.Name = "lblСropX";
            // 
            // lblCropY
            // 
            resources.ApplyResources(this.lblCropY, "lblCropY");
            this.lblCropY.ForeColor = System.Drawing.Color.Pink;
            this.lblCropY.Name = "lblCropY";
            // 
            // lblCropWidth
            // 
            resources.ApplyResources(this.lblCropWidth, "lblCropWidth");
            this.lblCropWidth.ForeColor = System.Drawing.Color.Pink;
            this.lblCropWidth.Name = "lblCropWidth";
            // 
            // lblCropHeight
            // 
            resources.ApplyResources(this.lblCropHeight, "lblCropHeight");
            this.lblCropHeight.ForeColor = System.Drawing.Color.Pink;
            this.lblCropHeight.Name = "lblCropHeight";
            // 
            // TrimImage
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.IndianRed;
            this.Controls.Add(this.lblCropHeight);
            this.Controls.Add(this.lblCropWidth);
            this.Controls.Add(this.lblCropY);
            this.Controls.Add(this.lblСropX);
            this.Controls.Add(this.textBoxCropHeight);
            this.Controls.Add(this.textBoxCropWidth);
            this.Controls.Add(this.textBoxCropY);
            this.Controls.Add(this.textBoxСropX);
            this.Controls.Add(this.btnSaveTrimImage);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "TrimImage";
            this.Load += new System.EventHandler(this.TrimImage_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSaveTrimImage;
        private System.Windows.Forms.TextBox textBoxСropX;
        private System.Windows.Forms.TextBox textBoxCropY;
        private System.Windows.Forms.TextBox textBoxCropWidth;
        private System.Windows.Forms.TextBox textBoxCropHeight;
        private System.Windows.Forms.Label lblСropX;
        private System.Windows.Forms.Label lblCropY;
        private System.Windows.Forms.Label lblCropWidth;
        private System.Windows.Forms.Label lblCropHeight;
    }
}