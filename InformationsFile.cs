using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Imaging;
using System.IO;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace ViewPictures
{
    public partial class InformationsFile : Form
    {
        private Image image;
        private string imagePath;
        public InformationsFile(Image img, string imgP)
        {
            InitializeComponent();
            image = img;
            imagePath = imgP;
            themeApp();
        }

        private void InformationsFile_Load(object sender, EventArgs e)
        {
            textBoxMain.Text += $"{stringLanguage.InformationSizePhoto}: {image.Width}x{image.Height}{Environment.NewLine}" +
                                $"{stringLanguage.InformationFileExtension}: {Path.GetExtension(imagePath)}{Environment.NewLine}" +
                                $"{stringLanguage.InformationFileSize}: {new FileInfo(imagePath).Length} {stringLanguage.textByte}{Environment.NewLine}" +
                                $"{stringLanguage.InformationFileName}: {Path.GetFileName(imagePath)}{Environment.NewLine}" +
                                $"{stringLanguage.InformationFullPath}: {Path.GetFullPath(imagePath)}{Environment.NewLine}" +
                                $"{stringLanguage.InformationDateOfCreation}: {File.GetCreationTime(imagePath)}{Environment.NewLine}" +
                                $"{stringLanguage.InformationLastAccessDate}: {File.GetLastAccessTime(imagePath)}{Environment.NewLine}" +
                                $"{stringLanguage.InformationLastModifiedDate}: {File.GetLastWriteTime(imagePath)}{Environment.NewLine}" +
                                $"{stringLanguage.InformationFileType}: {Path.GetExtension(imagePath).TrimStart('.').ToUpper()}{Environment.NewLine}" +
                                $"{stringLanguage.InformationLastAccessTimeInUTC}: {File.GetLastAccessTimeUtc(imagePath)}{Environment.NewLine}" +
                                $"{stringLanguage.InformationLastModifiedTimeInUTC}: {File.GetLastWriteTimeUtc(imagePath)}{Environment.NewLine}" +
                                $"{stringLanguage.InformationCreationTimeInUTC}: {File.GetCreationTimeUtc(imagePath)}{Environment.NewLine}" +
                                $"{stringLanguage.InformationParentFolder}: {Path.GetDirectoryName(imagePath)}{Environment.NewLine}" +
                                $"{stringLanguage.InformationAllowedFileOperations}: {File.GetAccessControl(imagePath).GetAccessRules(true, true, typeof(System.Security.Principal.SecurityIdentifier))}{Environment.NewLine}" +
                                $"{stringLanguage.InformationFileOwner}: {File.GetAccessControl(imagePath).GetOwner(typeof(System.Security.Principal.SecurityIdentifier))}{Environment.NewLine}" +
                                $"{stringLanguage.InformationFileGroup}: {File.GetAccessControl(imagePath).GetGroup(typeof(System.Security.Principal.SecurityIdentifier))}{Environment.NewLine}" +
                                $"{stringLanguage.InformationFileAttributes}: {File.GetAttributes(imagePath)}{Environment.NewLine}";
            textBoxMain.Select(0, 0);
        }


        private void InformationsFile_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
                Close();
        }

        private void textBoxMain_KeyDown(object sender, KeyEventArgs e)
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
                textBoxMain.BackColor = Color.IndianRed;
                textBoxMain.ForeColor = Color.FromArgb(64, 0, 0);
            }
            else if (Properties.Settings.Default.theme == "темная")
            {
                BackColor = Color.MidnightBlue;
                textBoxMain.BackColor = Color.MidnightBlue;
                textBoxMain.ForeColor = Color.White;
            }
            else
            {
                BackColor = Properties.Settings.Default.backgroundColorInterface;
                textBoxMain.BackColor = Properties.Settings.Default.backgroundColorInterface;
                textBoxMain.ForeColor = Properties.Settings.Default.colorTextInterface;
            }
        }
    }
}
