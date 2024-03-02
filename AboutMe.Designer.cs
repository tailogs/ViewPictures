namespace ViewPictures
{
    partial class AboutMe
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AboutMe));
            this.lblAuthor = new System.Windows.Forms.Label();
            this.lblOpenDeveloperPage = new System.Windows.Forms.Label();
            this.lblGmailDeveloper = new System.Windows.Forms.Label();
            this.textBoxGmailDeveloper = new System.Windows.Forms.TextBox();
            this.textBoxYandexDeveloper = new System.Windows.Forms.TextBox();
            this.lblYandexDeveloper = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblAuthor
            // 
            resources.ApplyResources(this.lblAuthor, "lblAuthor");
            this.lblAuthor.ForeColor = System.Drawing.Color.Pink;
            this.lblAuthor.Name = "lblAuthor";
            // 
            // lblOpenDeveloperPage
            // 
            resources.ApplyResources(this.lblOpenDeveloperPage, "lblOpenDeveloperPage");
            this.lblOpenDeveloperPage.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblOpenDeveloperPage.ForeColor = System.Drawing.Color.Maroon;
            this.lblOpenDeveloperPage.Name = "lblOpenDeveloperPage";
            this.lblOpenDeveloperPage.Click += new System.EventHandler(this.lblOpenDeveloperPage_Click);
            // 
            // lblGmailDeveloper
            // 
            resources.ApplyResources(this.lblGmailDeveloper, "lblGmailDeveloper");
            this.lblGmailDeveloper.ForeColor = System.Drawing.Color.Pink;
            this.lblGmailDeveloper.Name = "lblGmailDeveloper";
            // 
            // textBoxGmailDeveloper
            // 
            this.textBoxGmailDeveloper.BackColor = System.Drawing.Color.IndianRed;
            this.textBoxGmailDeveloper.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            resources.ApplyResources(this.textBoxGmailDeveloper, "textBoxGmailDeveloper");
            this.textBoxGmailDeveloper.ForeColor = System.Drawing.Color.Pink;
            this.textBoxGmailDeveloper.Name = "textBoxGmailDeveloper";
            this.textBoxGmailDeveloper.ReadOnly = true;
            // 
            // textBoxYandexDeveloper
            // 
            this.textBoxYandexDeveloper.BackColor = System.Drawing.Color.IndianRed;
            this.textBoxYandexDeveloper.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            resources.ApplyResources(this.textBoxYandexDeveloper, "textBoxYandexDeveloper");
            this.textBoxYandexDeveloper.ForeColor = System.Drawing.Color.Pink;
            this.textBoxYandexDeveloper.Name = "textBoxYandexDeveloper";
            this.textBoxYandexDeveloper.ReadOnly = true;
            // 
            // lblYandexDeveloper
            // 
            resources.ApplyResources(this.lblYandexDeveloper, "lblYandexDeveloper");
            this.lblYandexDeveloper.ForeColor = System.Drawing.Color.Pink;
            this.lblYandexDeveloper.Name = "lblYandexDeveloper";
            // 
            // AboutMe
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.IndianRed;
            this.Controls.Add(this.textBoxYandexDeveloper);
            this.Controls.Add(this.lblYandexDeveloper);
            this.Controls.Add(this.textBoxGmailDeveloper);
            this.Controls.Add(this.lblGmailDeveloper);
            this.Controls.Add(this.lblOpenDeveloperPage);
            this.Controls.Add(this.lblAuthor);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "AboutMe";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.AboutMe_KeyDown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblAuthor;
        private System.Windows.Forms.Label lblOpenDeveloperPage;
        private System.Windows.Forms.Label lblGmailDeveloper;
        private System.Windows.Forms.TextBox textBoxGmailDeveloper;
        private System.Windows.Forms.TextBox textBoxYandexDeveloper;
        private System.Windows.Forms.Label lblYandexDeveloper;
    }
}