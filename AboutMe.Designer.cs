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
            this.btnCopyGmail = new System.Windows.Forms.Button();
            this.lblVersion = new System.Windows.Forms.Label();
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
            this.textBoxGmailDeveloper.TextChanged += new System.EventHandler(this.textBoxGmailDeveloper_TextChanged);
            this.textBoxGmailDeveloper.MouseDown += new System.Windows.Forms.MouseEventHandler(this.textBoxGmailDeveloper_MouseDown);
            // 
            // btnCopyGmail
            // 
            this.btnCopyGmail.BackColor = System.Drawing.Color.Maroon;
            resources.ApplyResources(this.btnCopyGmail, "btnCopyGmail");
            this.btnCopyGmail.ForeColor = System.Drawing.Color.Pink;
            this.btnCopyGmail.Name = "btnCopyGmail";
            this.btnCopyGmail.UseVisualStyleBackColor = false;
            this.btnCopyGmail.Click += new System.EventHandler(this.btnCopyGmail_Click);
            // 
            // lblVersion
            // 
            resources.ApplyResources(this.lblVersion, "lblVersion");
            this.lblVersion.ForeColor = System.Drawing.Color.Pink;
            this.lblVersion.Name = "lblVersion";
            // 
            // AboutMe
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.IndianRed;
            this.Controls.Add(this.lblVersion);
            this.Controls.Add(this.btnCopyGmail);
            this.Controls.Add(this.textBoxGmailDeveloper);
            this.Controls.Add(this.lblGmailDeveloper);
            this.Controls.Add(this.lblOpenDeveloperPage);
            this.Controls.Add(this.lblAuthor);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "AboutMe";
            this.Load += new System.EventHandler(this.AboutMe_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.AboutMe_KeyDown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblAuthor;
        private System.Windows.Forms.Label lblOpenDeveloperPage;
        private System.Windows.Forms.Label lblGmailDeveloper;
        private System.Windows.Forms.TextBox textBoxGmailDeveloper;
        private System.Windows.Forms.Button btnCopyGmail;
        private System.Windows.Forms.Label lblVersion;
    }
}