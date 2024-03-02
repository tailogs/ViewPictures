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
    public partial class TrimImage : Form
    {
        private Image image;
        private string imagePath;

        // Declare variables to store the cropped image data
        private int cropX;
        private int cropY;
        private int cropWidth;
        private int cropHeight;

        public TrimImage(Image img, string imgPath)
        {
            InitializeComponent();
            image = img;
            imagePath = imgPath;
            themeApp();
        }

        private void btnSaveTrimImage_Click(object sender, EventArgs e)
        {
            // Retrieve the values from the controls
            cropX = int.Parse(textBoxСropX.Text);
            cropY = int.Parse(textBoxCropY.Text);
            cropWidth = int.Parse(textBoxCropWidth.Text);
            cropHeight = int.Parse(textBoxCropHeight.Text);

            // Pass the cropped image data back to the main form
            ((Root)this.Owner).SetCropData(cropX, cropY, cropWidth, cropHeight);

            // Close the child form
            this.Close();
        }

        private void TrimImage_Load(object sender, EventArgs e)
        {
            textBoxСropX.Text = "0";
            textBoxCropY.Text = "0";
            textBoxCropWidth.Text = image.Width.ToString();
            textBoxCropHeight.Text = image.Height.ToString();
        }

        // Функция для смены темы
        private void themeApp()
        {
            if (Properties.Settings.Default.theme == "светлая")
            {
                Color lightCoral = Color.FromArgb(240, 128, 128);

                BackColor = Color.IndianRed;

                lblСropX.BackColor = Color.IndianRed;
                lblСropX.ForeColor = Color.Pink;
                lblCropY.BackColor = Color.IndianRed;
                lblCropY.ForeColor = Color.Pink;
                lblCropWidth.BackColor = Color.IndianRed;
                lblCropWidth.ForeColor = Color.Pink;
                lblCropHeight.BackColor = Color.IndianRed;
                lblCropHeight.ForeColor = Color.Pink;

                textBoxСropX.BackColor = lightCoral;
                textBoxСropX.ForeColor = Color.FromArgb(64, 64, 64);
                textBoxCropY.BackColor = lightCoral;
                textBoxCropY.ForeColor = Color.FromArgb(64, 64, 64);
                textBoxCropWidth.BackColor = lightCoral;
                textBoxCropWidth.ForeColor = Color.FromArgb(64, 64, 64);
                textBoxCropHeight.BackColor = lightCoral;
                textBoxCropHeight.ForeColor = Color.FromArgb(64, 64, 64);

                btnSaveTrimImage.BackColor = lightCoral;
                btnSaveTrimImage.ForeColor = Color.Black;
            }
            else if (Properties.Settings.Default.theme == "темная")
            {
                BackColor = Color.MidnightBlue;

                lblСropX.BackColor = Color.MidnightBlue;
                lblСropX.ForeColor = Color.White;
                lblCropY.BackColor = Color.MidnightBlue;
                lblCropY.ForeColor = Color.White;
                lblCropWidth.BackColor = Color.MidnightBlue;
                lblCropWidth.ForeColor = Color.White;
                lblCropHeight.BackColor = Color.MidnightBlue;
                lblCropHeight.ForeColor = Color.White;

                textBoxСropX.BackColor = Color.RoyalBlue;
                textBoxСropX.ForeColor = Color.White;
                textBoxCropY.BackColor = Color.RoyalBlue;
                textBoxCropY.ForeColor = Color.White;
                textBoxCropWidth.BackColor = Color.RoyalBlue;
                textBoxCropWidth.ForeColor = Color.White;
                textBoxCropHeight.BackColor = Color.RoyalBlue;
                textBoxCropHeight.ForeColor = Color.White;

                btnSaveTrimImage.BackColor = Color.FromArgb(0, 0, 64);
                btnSaveTrimImage.ForeColor = Color.White;
            }
            else
            {
                BackColor = Properties.Settings.Default.backgroundColorInterface;

                lblСropX.BackColor = Properties.Settings.Default.backgroundColorInterface;
                lblСropX.ForeColor = Properties.Settings.Default.colorTextInterface;
                lblCropY.BackColor = Properties.Settings.Default.backgroundColorInterface;
                lblCropY.ForeColor = Properties.Settings.Default.colorTextInterface;
                lblCropWidth.BackColor = Properties.Settings.Default.backgroundColorInterface;
                lblCropWidth.ForeColor = Properties.Settings.Default.colorTextInterface;
                lblCropHeight.BackColor = Properties.Settings.Default.backgroundColorInterface;
                lblCropHeight.ForeColor = Properties.Settings.Default.colorTextInterface;

                textBoxСropX.BackColor = Properties.Settings.Default.backgroundColorElements;
                textBoxСropX.ForeColor = Properties.Settings.Default.colorTextElements;
                textBoxCropY.BackColor = Properties.Settings.Default.backgroundColorElements;
                textBoxCropY.ForeColor = Properties.Settings.Default.colorTextElements;
                textBoxCropWidth.BackColor = Properties.Settings.Default.backgroundColorElements;
                textBoxCropWidth.ForeColor = Properties.Settings.Default.colorTextElements;
                textBoxCropHeight.BackColor = Properties.Settings.Default.backgroundColorElements;
                textBoxCropHeight.ForeColor = Properties.Settings.Default.colorTextElements;

                btnSaveTrimImage.BackColor = Properties.Settings.Default.backgroundColorElements;
                btnSaveTrimImage.ForeColor = Properties.Settings.Default.colorTextInterface;
            }
        }
    }
}
