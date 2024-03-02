using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ViewPictures.Properties;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace ViewPictures
{
    public partial class Settings : Form
    {
        public Settings()
        {
            InitializeComponent();
            changeLanguage();
            themeApp();
        }

        private void themeApp()
        {
            if (Properties.Settings.Default.theme == "светлая")
            {
                Color lightCoral = Color.FromArgb(240, 128, 128);

                BackColor = Color.IndianRed;

                lblLanguage.BackColor = Color.IndianRed;
                lblLanguage.ForeColor = Color.Pink;

                comboBoxLanguage.BackColor = lightCoral;
                comboBoxLanguage.ForeColor = Color.FromArgb(64, 64, 64);

                btnSaveSettings.BackColor = Color.LightCoral;
                btnSaveSettings.ForeColor = Color.Black;
            }
            else if (Properties.Settings.Default.theme == "темная")
            {
                BackColor = Color.MidnightBlue;

                lblLanguage.BackColor = Color.MidnightBlue;
                lblLanguage.ForeColor = Color.White;

                comboBoxLanguage.BackColor = Color.FromArgb(0, 0, 64);
                comboBoxLanguage.ForeColor = Color.White;

                btnSaveSettings.BackColor = Color.MidnightBlue;
                btnSaveSettings.ForeColor = Color.White;
            }
            else
            {
                BackColor = Properties.Settings.Default.backgroundColorInterface;

                lblLanguage.BackColor = Properties.Settings.Default.backgroundColorInterface;
                lblLanguage.ForeColor = Properties.Settings.Default.colorTextElements;

                comboBoxLanguage.BackColor = Properties.Settings.Default.backgroundColorElements;
                comboBoxLanguage.ForeColor = Properties.Settings.Default.colorTextElements;

                btnSaveSettings.BackColor = Properties.Settings.Default.backgroundColorInterface;
                btnSaveSettings.ForeColor = Properties.Settings.Default.colorTextElements;
            }
        }

        private void changeLanguage()
        {
            // Заполняем comboBoxLanguage теми языками, на которые был произведен перевод
            comboBoxLanguage.DataSource = new System.Globalization.CultureInfo[]
            {
                System.Globalization.CultureInfo.GetCultureInfo("ru-RU"),
                System.Globalization.CultureInfo.GetCultureInfo("en-US")
            };
            comboBoxLanguage.DisplayMember = "NativeName";
            comboBoxLanguage.ValueMember = "Name";

            // Указываем какой язык используется, если параметр не пуст
            if (!String.IsNullOrEmpty(Properties.Settings.Default.language))
            {
                comboBoxLanguage.SelectedValue = Properties.Settings.Default.language;
            }
        }

        private void Settings_FormClosing(object sender, FormClosingEventArgs e) {}

        private void btnSaveTrimImage_Click(object sender, EventArgs e)
        {
            if (comboBoxLanguage.SelectedItem != null)
                Properties.Settings.Default.language = comboBoxLanguage.SelectedValue.ToString();
            Properties.Settings.Default.Save();
            Environment.Exit(0);
        }
    }
}
