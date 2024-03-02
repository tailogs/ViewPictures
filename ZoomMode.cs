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
    public partial class ZoomMode : Form
    {
        private Image image;
        private string imagePath;
        public ZoomMode(Image img, string imgPath)
        {
            InitializeComponent();
            image = img;
            imagePath = imgPath;
            pictureBoxMain.MouseWheel += PictureBoxMain_MouseWheel;
            themeApp();
        }

        private void PictureBoxMain_MouseWheel(object sender, MouseEventArgs e)
        {
            if (e.Delta > 0) // при прокрутке колесика вперед (вверх)
            {
                if (pictureBoxMain.Width < image.Width * 2 && pictureBoxMain.Height < image.Height * 2)
                {
                    ZoomIn();
                }
            }
            else // при прокрутке колесика назад (вниз)
            {
                if (pictureBoxMain.Width > image.Width / 2 && pictureBoxMain.Height > image.Height / 2)
                {
                    ZoomOut();
                }
            }
        }

        private void ZoomIn()
        {
            int newWidth = (int)(pictureBoxMain.Width * 1.1);
            int newHeight = (int)(pictureBoxMain.Height * 1.1);

            Image newImage = ResizeImage(image, newWidth, newHeight);

            pictureBoxMain.Width = newWidth;
            pictureBoxMain.Height = newHeight;
            pictureBoxMain.Image = newImage;
        }

        private void ZoomOut()
        {
            int newWidth = (int)(pictureBoxMain.Width / 1.1);
            int newHeight = (int)(pictureBoxMain.Height / 1.1);

            Image newImage = ResizeImage(image, newWidth, newHeight);

            pictureBoxMain.Width = newWidth;
            pictureBoxMain.Height = newHeight;
            pictureBoxMain.Image = newImage;
        }

        private Image ResizeImage(Image image, int width, int height)
        {
            Bitmap newImage = new Bitmap(width, height);

            using (Graphics graphics = Graphics.FromImage(newImage))
            {
                graphics.InterpolationMode = System.Drawing.Drawing2D.InterpolationMode.HighQualityBicubic;
                graphics.DrawImage(image, 0, 0, width, height);
            }

            return newImage;
        }

        private void ZoomMode_Load(object sender, EventArgs e)
        {
            pictureBoxMain.Image = image;
        }

        private void trackBarZoomImage_Scroll(object sender, EventArgs e)
        {
            float zoom = trackBarZoomImage.Value;

            // Проверка на отрицательное значение зума
            if (zoom <= 0)
                zoom = 1;

            int newWidth = (int)(image.Width * zoom);
            int newHeight = (int)(image.Height * zoom);

            Image newImage = new Bitmap(image, newWidth, newHeight);

            pictureBoxMain.Image = newImage;
        }

        // Функция для смены темы
        private void themeApp()
        {
            if (Properties.Settings.Default.theme == "светлая")
            {
                BackColor = Color.IndianRed;
                trackBarZoomImage.BackColor = Color.IndianRed;
                panelMain.BackColor = Color.IndianRed;
                pictureBoxMain.BackColor = Color.IndianRed;
            }
            else if (Properties.Settings.Default.theme == "темная")
            {
                BackColor = Color.MidnightBlue;
                trackBarZoomImage.BackColor = Color.MidnightBlue;
                panelMain.BackColor = Color.MidnightBlue;
                pictureBoxMain.BackColor = Color.MidnightBlue;
            }
            else
            {
                BackColor = Properties.Settings.Default.backgroundColorInterface;
                trackBarZoomImage.BackColor = Properties.Settings.Default.backgroundColorInterface;
                panelMain.BackColor = Properties.Settings.Default.backgroundColorInterface;
                pictureBoxMain.BackColor = Properties.Settings.Default.backgroundColorInterface;
            }
        }
    }
}
