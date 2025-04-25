using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ViewPictures
{
    public partial class AboutMe : Form
    {
        public AboutMe()
        {
            InitializeComponent();
            themeApp();
        }

        private void AboutMe_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
                Close();
        }

        // Функция для смены темы
        private void themeApp()
        {
            if (Properties.Settings.Default.theme == "светлая")
            {
                BackColor = Color.IndianRed;
                lblAuthor.ForeColor = Color.Pink;
                lblOpenDeveloperPage.ForeColor = Color.Maroon;
                lblGmailDeveloper.ForeColor = Color.Pink;
                textBoxGmailDeveloper.ForeColor = Color.Pink;
                textBoxGmailDeveloper.BackColor = Color.IndianRed;
                btnCopyGmail.ForeColor = Color.Pink;
                btnCopyGmail.BackColor = Color.Maroon;
                lblVersion.ForeColor = Color.Pink;
            }
            else if (Properties.Settings.Default.theme == "темная")
            {
                BackColor = Color.MidnightBlue;
                lblAuthor.ForeColor = Color.RoyalBlue;
                lblOpenDeveloperPage.ForeColor = Color.BlueViolet;
                lblGmailDeveloper.ForeColor = Color.RoyalBlue;
                textBoxGmailDeveloper.ForeColor = Color.RoyalBlue;
                textBoxGmailDeveloper.BackColor = Color.MidnightBlue;
                btnCopyGmail.ForeColor = Color.RoyalBlue;
                btnCopyGmail.BackColor = Color.Navy;
                lblVersion.ForeColor = Color.RoyalBlue;
            }
            else
            {
                BackColor = Properties.Settings.Default.backgroundColorInterface;
                lblAuthor.ForeColor = Properties.Settings.Default.colorTextInterface;
                lblOpenDeveloperPage.ForeColor = Properties.Settings.Default.colorTextElements;
                lblGmailDeveloper.ForeColor = Properties.Settings.Default.colorTextInterface;
                textBoxGmailDeveloper.ForeColor = Properties.Settings.Default.colorTextInterface;
                textBoxGmailDeveloper.BackColor = Properties.Settings.Default.backgroundColorInterface;
                btnCopyGmail.ForeColor = Properties.Settings.Default.colorTextInterface;
                btnCopyGmail.BackColor = Properties.Settings.Default.colorTextElements;
                lblVersion.ForeColor = Properties.Settings.Default.colorTextInterface;
            }
        }

        private void lblOpenDeveloperPage_Click(object sender, EventArgs e)
        {
            Color c = lblOpenDeveloperPage.ForeColor;
            lblOpenDeveloperPage.ForeColor = Color.Red;
            System.Diagnostics.Process.Start("https://tailogs.github.io");
            System.Threading.Thread.Sleep(100);
            lblOpenDeveloperPage.ForeColor = c;
        }

        private void textBoxGmailDeveloper_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnCopyGmail_Click(object sender, EventArgs e)
        {
            string gmailDeveloper = textBoxGmailDeveloper.Text;
            Clipboard.SetText(gmailDeveloper);
        }

        private void textBoxGmailDeveloper_MouseDown(object sender, MouseEventArgs e)
        {
            // Отменяем выделение текста
            textBoxGmailDeveloper.SelectionLength = 0;
        }

        private void AboutMe_Load(object sender, EventArgs e)
        {
            // Снимаем выделение текста в textBoxGmailDeveloper
            textBoxGmailDeveloper.SelectionLength = 0;
            textBoxGmailDeveloper.SelectionStart = textBoxGmailDeveloper.Text.Length; // курсор в конец текста
        }
    }
}
