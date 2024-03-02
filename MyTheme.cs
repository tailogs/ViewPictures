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
    public partial class MyTheme : Form
    {
        Root root = new Root();

        public MyTheme(Root r)
        {
            InitializeComponent();

            root = r;

            // Восстановление сохраненных цветов при открытии окна
            textBoxBackgroundColorInterface.BackColor = Properties.Settings.Default.backgroundColorInterface;
            textBoxBackgroundColorElements.BackColor = Properties.Settings.Default.backgroundColorElements;
            textBoxBackgroundColorMenu.BackColor = Properties.Settings.Default.backgroundColorMenu;
            textBoxColorTextInterface.BackColor = Properties.Settings.Default.colorTextInterface;
            textBoxColorTextElements.BackColor = Properties.Settings.Default.colorTextElements;
            textBoxFontSizeText.Font = Properties.Settings.Default.fontSizeText;

            themeApp();
        }

        private void textBoxBackgroundColorInterface_Click(object sender, EventArgs e)
        {
            ColorDialog colorDialog = new ColorDialog();
            if (colorDialog.ShowDialog() == DialogResult.OK)
            {
                Properties.Settings.Default.backgroundColorInterface = colorDialog.Color;
                textBoxBackgroundColorInterface.BackColor = colorDialog.Color;
            }
        }

        private void textBoxBackgroundColorElements_Click(object sender, EventArgs e)
        {
            ColorDialog colorDialog = new ColorDialog();
            if (colorDialog.ShowDialog() == DialogResult.OK)
            {
                Properties.Settings.Default.backgroundColorElements = colorDialog.Color;
                textBoxBackgroundColorElements.BackColor = colorDialog.Color;
            }
        }

        private void textBoxBackgroundColorMenu_Click(object sender, EventArgs e)
        {
            ColorDialog colorDialog = new ColorDialog();
            if (colorDialog.ShowDialog() == DialogResult.OK)
            {
                Properties.Settings.Default.backgroundColorMenu = colorDialog.Color;
                textBoxBackgroundColorMenu.BackColor = colorDialog.Color;
            }
        }

        private void textBoxColorTextInterface_Click(object sender, EventArgs e)
        {
            ColorDialog colorDialog = new ColorDialog();
            if (colorDialog.ShowDialog() == DialogResult.OK)
            {
                Properties.Settings.Default.colorTextInterface = colorDialog.Color;
                textBoxColorTextInterface.BackColor = colorDialog.Color;
            }
        }

        private void textBoxColorTextElements_Click(object sender, EventArgs e)
        {
            ColorDialog colorDialog = new ColorDialog();
            if (colorDialog.ShowDialog() == DialogResult.OK)
            {
                Properties.Settings.Default.colorTextElements = colorDialog.Color;
                textBoxColorTextElements.BackColor = colorDialog.Color;
            }
        }

        private void textBoxFontSizeText_Click(object sender, EventArgs e)
        {
            using (FontDialog fontDialog = new FontDialog())
            {
                if (fontDialog.ShowDialog() == DialogResult.OK)
                {
                    Properties.Settings.Default.fontSizeText = fontDialog.Font;
                    Properties.Settings.Default.fontSizeTextString = $"Шрифт: {fontDialog.Font.Name}, Размер: {fontDialog.Font.Size}";
                    textBoxFontSizeText.Text = Properties.Settings.Default.fontSizeTextString;
                }
            }
        }

        private void btnSettingsSave_Click(object sender, EventArgs e)
        {
            // Сохранение всех параметров из переменных в свойства
            Properties.Settings.Default.backgroundColorInterface = textBoxBackgroundColorInterface.BackColor;
            Properties.Settings.Default.backgroundColorElements = textBoxBackgroundColorElements.BackColor;
            Properties.Settings.Default.backgroundColorMenu = textBoxBackgroundColorMenu.BackColor;
            Properties.Settings.Default.colorTextInterface = textBoxColorTextInterface.BackColor;
            Properties.Settings.Default.colorTextElements = textBoxColorTextElements.BackColor;
            Properties.Settings.Default.fontSizeText = textBoxFontSizeText.Font;

            Properties.Settings.Default.Save();

            Properties.Settings.Default.theme = "другая";

            root.themeApp();
            themeApp();
        }

        private void btnResetSettings_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.theme = "светлая";

            Properties.Settings.Default.Save();

            root.themeApp();
            themeApp();
        }

        private void themeApp()
        {
            if (Properties.Settings.Default.theme == "светлая")
            {
                Color lightCoral = Color.FromArgb(240, 128, 128);

                BackColor = Color.IndianRed;

                btnResetSettings.BackColor = lightCoral;
                btnResetSettings.ForeColor = Color.Black;

                btnSettingsSave.BackColor = lightCoral;
                btnSettingsSave.ForeColor = Color.Black;

                btnSettingsExport.BackColor = lightCoral;
                btnSettingsExport.ForeColor = Color.Black;

                btnSettingsImport.BackColor = lightCoral;
                btnSettingsImport.ForeColor = Color.Black;

                lvlBackgroundColarInterface.BackColor = Color.IndianRed;
                lvlBackgroundColarInterface.ForeColor = Color.Pink;

                lblBackgroundColorElements.BackColor = Color.IndianRed;
                lblBackgroundColorElements.ForeColor = Color.Pink;

                lblBackgroundColorMenu.BackColor = Color.IndianRed;
                lblBackgroundColorMenu.ForeColor = Color.Pink;

                lblColorTextElements.BackColor = Color.IndianRed;
                lblColorTextElements.ForeColor = Color.Pink;

                lblColorTextInterface.BackColor = Color.IndianRed;
                lblColorTextInterface.ForeColor = Color.Pink;

                lblFontSizeText.BackColor = Color.IndianRed;
                lblFontSizeText.ForeColor = Color.Pink;

                textBoxFontSizeText.BackColor = Properties.Settings.Default.backgroundColorElements;
                textBoxFontSizeText.ForeColor = Properties.Settings.Default.colorTextInterface;
            }
            else if (Properties.Settings.Default.theme == "темная")
            {
                BackColor = Color.MidnightBlue;

                btnResetSettings.BackColor = Color.FromArgb(0, 0, 64);
                btnResetSettings.ForeColor = Color.White;

                btnSettingsSave.BackColor = Color.FromArgb(0, 0, 64);
                btnSettingsSave.ForeColor = Color.White;

                btnSettingsExport.BackColor = Color.FromArgb(0, 0, 64);
                btnSettingsExport.ForeColor = Color.White;

                btnSettingsImport.BackColor = Color.FromArgb(0, 0, 64);
                btnSettingsImport.ForeColor = Color.White;

                lvlBackgroundColarInterface.BackColor = Color.MidnightBlue;
                lvlBackgroundColarInterface.ForeColor = Color.White;

                lblBackgroundColorElements.BackColor = Color.MidnightBlue;
                lblBackgroundColorElements.ForeColor = Color.White;

                lblBackgroundColorMenu.BackColor = Color.MidnightBlue;
                lblBackgroundColorMenu.ForeColor = Color.White;

                lblColorTextElements.BackColor = Color.MidnightBlue;
                lblColorTextElements.ForeColor = Color.White;

                lblColorTextInterface.BackColor = Color.MidnightBlue;
                lblColorTextInterface.ForeColor = Color.White;

                lblFontSizeText.BackColor = Color.MidnightBlue;
                lblFontSizeText.ForeColor = Color.White;

                textBoxFontSizeText.BackColor = Properties.Settings.Default.backgroundColorElements;
                textBoxFontSizeText.ForeColor = Properties.Settings.Default.colorTextInterface;
            }
            else
            {
                BackColor = Properties.Settings.Default.backgroundColorInterface;

                btnResetSettings.BackColor = Properties.Settings.Default.backgroundColorElements;
                btnResetSettings.ForeColor = Properties.Settings.Default.colorTextElements;

                btnSettingsSave.BackColor = Properties.Settings.Default.backgroundColorElements;
                btnSettingsSave.ForeColor = Properties.Settings.Default.colorTextElements;

                btnSettingsExport.BackColor = Properties.Settings.Default.backgroundColorElements;
                btnSettingsExport.ForeColor = Properties.Settings.Default.colorTextElements;

                btnSettingsImport.BackColor = Properties.Settings.Default.backgroundColorElements;
                btnSettingsImport.ForeColor = Properties.Settings.Default.colorTextElements;

                lvlBackgroundColarInterface.BackColor = Properties.Settings.Default.backgroundColorInterface;
                lvlBackgroundColarInterface.ForeColor = Properties.Settings.Default.colorTextInterface;

                lblBackgroundColorElements.BackColor = Properties.Settings.Default.backgroundColorInterface;
                lblBackgroundColorElements.ForeColor = Properties.Settings.Default.colorTextInterface;

                lblBackgroundColorMenu.BackColor = Properties.Settings.Default.backgroundColorInterface;
                lblBackgroundColorMenu.ForeColor = Properties.Settings.Default.colorTextInterface;

                lblColorTextElements.BackColor = Properties.Settings.Default.backgroundColorInterface;
                lblColorTextElements.ForeColor = Properties.Settings.Default.colorTextInterface;

                lblColorTextInterface.BackColor = Properties.Settings.Default.backgroundColorInterface;
                lblColorTextInterface.ForeColor = Properties.Settings.Default.colorTextInterface;

                lblFontSizeText.BackColor = Properties.Settings.Default.backgroundColorInterface;
                lblFontSizeText.ForeColor = Properties.Settings.Default.colorTextInterface;

                textBoxFontSizeText.BackColor = Properties.Settings.Default.backgroundColorElements;
                textBoxFontSizeText.ForeColor = Properties.Settings.Default.colorTextInterface;
            }
        }

        private void btnSettingsExport_Click(object sender, EventArgs e)
        {
            // Create a SaveFileDialog to choose the export file location
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "Theme Files (*.theme)|*.theme";
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                // Get the file path from the SaveFileDialog
                string filePath = saveFileDialog.FileName;

                // Create a StreamWriter to write the theme properties to the file
                using (StreamWriter writer = new StreamWriter(filePath))
                {
                    // Write the theme properties to the file
                    writer.WriteLine(Properties.Settings.Default.backgroundColorInterface.ToArgb());
                    writer.WriteLine(Properties.Settings.Default.backgroundColorElements.ToArgb());
                    writer.WriteLine(Properties.Settings.Default.backgroundColorMenu.ToArgb());
                    writer.WriteLine(Properties.Settings.Default.colorTextInterface.ToArgb());
                    writer.WriteLine(Properties.Settings.Default.colorTextElements.ToArgb());
                    writer.WriteLine(Properties.Settings.Default.fontSizeText.Name);
                    writer.WriteLine(Properties.Settings.Default.fontSizeText.Size);
                }
            }
        }

        private void btnSettingsImport_Click(object sender, EventArgs e)
        {
            // Create an OpenFileDialog to choose the import file
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Theme Files (*.theme)|*.theme";
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                // Get the file path from the OpenFileDialog
                string filePath = openFileDialog.FileName;

                // Create a StreamReader to read the theme properties from the file
                using (StreamReader reader = new StreamReader(filePath))
                {
                    // Read the theme properties from the file
                    int backgroundColorInterface = int.Parse(reader.ReadLine());
                    int backgroundColorElements = int.Parse(reader.ReadLine());
                    int backgroundColorMenu = int.Parse(reader.ReadLine());
                    int colorTextInterface = int.Parse(reader.ReadLine());
                    int colorTextElements = int.Parse(reader.ReadLine());
                    string fontName = reader.ReadLine();
                    float fontSize = float.Parse(reader.ReadLine());

                    // Set the theme properties from the imported values
                    Properties.Settings.Default.backgroundColorInterface = System.Drawing.Color.FromArgb(backgroundColorInterface);
                    Properties.Settings.Default.backgroundColorElements = System.Drawing.Color.FromArgb(backgroundColorElements);
                    Properties.Settings.Default.backgroundColorMenu = System.Drawing.Color.FromArgb(backgroundColorMenu);
                    Properties.Settings.Default.colorTextInterface = System.Drawing.Color.FromArgb(colorTextInterface);
                    Properties.Settings.Default.colorTextElements = System.Drawing.Color.FromArgb(colorTextElements);
                    Properties.Settings.Default.fontSizeText = new System.Drawing.Font(fontName, fontSize);

                    // Save the imported theme properties
                    Properties.Settings.Default.Save();

                    // Update the global color variables
                    textBoxBackgroundColorInterface.BackColor = Properties.Settings.Default.backgroundColorInterface;
                    textBoxBackgroundColorElements.BackColor = Properties.Settings.Default.backgroundColorElements;
                    textBoxBackgroundColorMenu.BackColor = Properties.Settings.Default.backgroundColorMenu;
                    textBoxColorTextInterface.BackColor = Properties.Settings.Default.colorTextInterface;
                    textBoxColorTextElements.BackColor = Properties.Settings.Default.colorTextElements;
                    textBoxFontSizeText.Font = Properties.Settings.Default.fontSizeText;

                    // Call the apply function to update the colors in the entire program
                    root.themeApp();
                    themeApp();
                }
            }
        }
    }
}