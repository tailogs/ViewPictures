using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ViewPictures
{
    public partial class Export : Form
    {
        private Image image;
        private string imagePath;
        private string pathForIco;
        private int imageScale = 100;
        public Export(Image img, string imgPath)
        {
            InitializeComponent();
            image = img;
            imagePath = imgPath;
            themeApp();
        }

        private void btnExport_Click(object sender, EventArgs e)
        {
            if (radioButtonPNG.Checked)
                SaveImage(image, ImageFormat.Png);
            else if (radioButtonJPG.Checked)
            {
                SaveImage(image, ImageFormat.Jpeg);
                ReplaceJpegToJpg();
            }
            else if (radioButtonJPEG.Checked)
                SaveImage(image, ImageFormat.Jpeg);
            else if (radioButtonICO.Checked)
            {
                SaveImage(image, ImageFormat.Icon);
                ReplageIconToIco();
            }
            else if (radioButtonBMP.Checked)
                SaveImage(image, ImageFormat.Bmp);
            else if (radioButtonGIF.Checked)
                SaveImage(image, ImageFormat.Gif);

            UpdateImageSize();
        }

        private void SaveImage(Image image, ImageFormat format)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = $"{format.ToString()} files (*.{format.ToString().ToLower()})|*.{format.ToString().ToLower()}";

            string imageName = Path.GetFileNameWithoutExtension(imagePath);
            saveFileDialog.FileName = imageName;

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                // Apply image scale
                int scaledWidth = (int)(image.Width * imageScale / 100.0);
                int scaledHeight = (int)(image.Height * imageScale / 100.0);
                Image scaledImage = new Bitmap(scaledWidth, scaledHeight);
                using (Graphics graphics = Graphics.FromImage(scaledImage))
                    graphics.DrawImage(image, 0, 0, scaledWidth, scaledHeight);

                scaledImage.Save(saveFileDialog.FileName, format);
            }
            pathForIco = Path.GetDirectoryName(imagePath) + '\\' + imageName;
        }


        private void ReplageIconToIco()
        {
            string iconFilePath = pathForIco + ".icon";
            string newIconFilePath = pathForIco + ".ico";

            // Проверяем, существует ли исходный файл и новый файл
            if (File.Exists(iconFilePath) && !File.Exists(newIconFilePath))
            {
                // Переименовываем исходный файл в новый файл
                File.Move(iconFilePath, newIconFilePath);
            }
        }

        private void ReplaceJpegToJpg()
        {
            string iconFilePath = pathForIco + ".jpeg";
            string newIconFilePath = pathForIco + ".jpg";

            // Проверяем, существует ли исходный файл и новый файл
            if (File.Exists(iconFilePath) && !File.Exists(newIconFilePath))
            {
                // Переименовываем исходный файл в новый файл
                File.Move(iconFilePath, newIconFilePath);
            }
        }


        private void Export_Load(object sender, EventArgs e)
        {
            pictureBoxMain.Image = image;
            // Добавляем обработчик события ValueChanged для trackBarImageScale
            trackBarImageScale.ValueChanged += trackBarImageScale_ValueChanged;
            UpdateImageSize();
        }

        private void trackBarImageScale_Scroll(object sender, EventArgs e)
        {
            imageScale = (int)(trackBarImageScale.Value) * 10;
            textBoxImageScale.Text = $"Масштаб: {imageScale}%";
        }

        private void trackBarImageScale_ValueChanged(object sender, EventArgs e)
        {
            // Обновляем значение textBoxImageScale
            imageScale = (int)(trackBarImageScale.Value) * 10;
            textBoxImageScale.Text = $"{stringLanguage.photoScale}: {imageScale}%";

            UpdateImageSize();
        }

        private void UpdateImageSize()
        {
            if (image != null)
            {
                // Вычисляем новые значения размеров изображения
                int scaledWidth = (int)(image.Width * imageScale / 100.0);
                int scaledHeight = (int)(image.Height * imageScale / 100.0);

                // Обновляем значения textBoxImageSize
                textBoxImageSize.Text = $"{stringLanguage.photoSize}: {scaledWidth}x{scaledHeight}";
            }
        }

        // Функция для смены темы
        private void themeApp()
        {
            if (Properties.Settings.Default.theme == "светлая")
            {
                Color lightCoral = Color.FromArgb(240, 128, 128);

                BackColor = Color.IndianRed;

                pictureBoxMain.BackColor = lightCoral;

                textBoxImageSize.BackColor = Color.IndianRed; ;
                textBoxImageSize.ForeColor = Color.Pink;

                trackBarImageScale.BackColor = Color.IndianRed;

                textBoxImageScale.BackColor = Color.IndianRed;
                textBoxImageScale.ForeColor = Color.Pink;

                groupBoxExt.BackColor = Color.IndianRed;
                groupBoxExt.ForeColor = Color.Pink;

                btnExport.BackColor = Color.Brown;
                btnExport.ForeColor = Color.Pink;
            }
            else if (Properties.Settings.Default.theme == "темная")
            {
                BackColor = Color.MidnightBlue;

                pictureBoxMain.BackColor = Color.RoyalBlue;

                textBoxImageSize.BackColor = Color.MidnightBlue;
                textBoxImageSize.ForeColor = Color.White;

                trackBarImageScale.BackColor = Color.MidnightBlue;

                textBoxImageScale.BackColor = Color.MidnightBlue;
                textBoxImageScale.ForeColor = Color.White;

                groupBoxExt.BackColor = Color.MidnightBlue;
                groupBoxExt.ForeColor = Color.White;

                btnExport.BackColor = Color.FromArgb(0, 0, 64);
                btnExport.ForeColor = Color.White;
            }
            else
            {
                BackColor = Properties.Settings.Default.backgroundColorInterface;

                pictureBoxMain.BackColor = Properties.Settings.Default.backgroundColorElements;

                textBoxImageSize.BackColor = Properties.Settings.Default.backgroundColorElements;
                textBoxImageSize.ForeColor = Properties.Settings.Default.colorTextElements;

                trackBarImageScale.BackColor = Properties.Settings.Default.backgroundColorInterface;

                textBoxImageScale.BackColor = Properties.Settings.Default.backgroundColorInterface;
                textBoxImageScale.ForeColor = Properties.Settings.Default.colorTextInterface;

                groupBoxExt.BackColor = Properties.Settings.Default.backgroundColorInterface;
                groupBoxExt.ForeColor = Properties.Settings.Default.colorTextInterface;

                btnExport.BackColor = Properties.Settings.Default.backgroundColorElements;
                btnExport.ForeColor = Properties.Settings.Default.colorTextElements;
            }
        }
    }
}
