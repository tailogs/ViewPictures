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
                lblYandexDeveloper.ForeColor = Color.Pink;
                textBoxGmailDeveloper.ForeColor = Color.Pink;
                textBoxGmailDeveloper.BackColor = Color.IndianRed;
                textBoxYandexDeveloper.ForeColor = Color.Pink;
                textBoxYandexDeveloper.BackColor = Color.IndianRed;
            }
            else if (Properties.Settings.Default.theme == "темная")
            {
                BackColor = Color.MidnightBlue;
                lblAuthor.ForeColor = Color.RoyalBlue;
                lblOpenDeveloperPage.ForeColor = Color.BlueViolet;
                lblGmailDeveloper.ForeColor = Color.RoyalBlue;
                lblYandexDeveloper.ForeColor = Color.RoyalBlue;
                textBoxGmailDeveloper.ForeColor = Color.RoyalBlue;
                textBoxGmailDeveloper.BackColor = Color.MidnightBlue;
                textBoxYandexDeveloper.ForeColor = Color.RoyalBlue;
                textBoxYandexDeveloper.BackColor = Color.MidnightBlue;
            }
            else
            {
                BackColor = Properties.Settings.Default.backgroundColorInterface;
                lblAuthor.ForeColor = Properties.Settings.Default.colorTextInterface;
                lblOpenDeveloperPage.ForeColor = Properties.Settings.Default.colorTextElements;
                lblGmailDeveloper.ForeColor = Properties.Settings.Default.colorTextInterface;
                lblYandexDeveloper.ForeColor = Properties.Settings.Default.colorTextInterface;
                textBoxGmailDeveloper.ForeColor = Properties.Settings.Default.colorTextInterface;
                textBoxGmailDeveloper.BackColor = Properties.Settings.Default.backgroundColorInterface;
                textBoxYandexDeveloper.ForeColor = Properties.Settings.Default.colorTextInterface;
                textBoxYandexDeveloper.BackColor = Properties.Settings.Default.backgroundColorInterface;
            }
        }

        private void lblOpenDeveloperPage_Click(object sender, EventArgs e)
        {
            Color c = lblOpenDeveloperPage.ForeColor;
            lblOpenDeveloperPage.ForeColor = Color.Red;
            System.Diagnostics.Process.Start("https://github.com/FadisNet");
            System.Threading.Thread.Sleep(100);
            lblOpenDeveloperPage.ForeColor = c;
        }
    }
}
