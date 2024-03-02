using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using System.IO;

namespace ViewPictures
{
    public partial class Root : Form
    {
        [DllImport("user32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        private static extern int SystemParametersInfo(int uAction, int uParam, IntPtr lpvParam, int fuWinIni);

        private const int SPI_SETDESKWALLPAPER = 20;
        private const int SPIF_UPDATEINIFILE = 0x1;

        private string imagePath;

        private int cropX;
        private int cropY;
        private int cropWidth;
        private int cropHeight;

        public Root()
        {
            if (!String.IsNullOrEmpty(Properties.Settings.Default.language))
            {
                try
                {
                    System.Threading.Thread.CurrentThread.CurrentUICulture =
                        System.Globalization.CultureInfo.GetCultureInfo(Properties.Settings.Default.language);
                    System.Threading.Thread.CurrentThread.CurrentCulture =
                        System.Globalization.CultureInfo.GetCultureInfo(Properties.Settings.Default.language);
                }
                catch (System.Globalization.CultureNotFoundException ex)
                {
                    // Обработка ошибки, если идентификатор культуры недопустим
                    Console.WriteLine("Ошибка: " + ex.Message);
                }
            }
            InitializeComponent();
            themeApp();
            sizeApp();
        }


        private void открытьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Image Files (*.png; *.jpg; *.jpeg; *.gif; *.bmp; *.ico)|*.png; *.jpg; *.jpge; *.gif; *.bmp; *.ico)";

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                imagePath = openFileDialog.FileName;
                pictureBoxMain.Image = Image.FromFile(imagePath);
            }
        }

        private void закрытьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            pictureBoxMain.Image = null;
        }

        private void выходToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void pictureBoxMain_DragDrop(object sender, DragEventArgs e)
        {
            var data = e.Data.GetData(DataFormats.FileDrop);
            if (data != null)
            {
                var filenames = data as string[];
                if (filenames.Length > 0)
                {
                    imagePath = filenames[0];
                    using (FileStream stream = new FileStream(filenames[0], FileMode.Open))
                        pictureBoxMain.Image = Image.FromStream(stream);
                }
            }
        }

        private void Root_Load(object sender, EventArgs e)
        {
            pictureBoxMain.AllowDrop = true;
            if (Environment.GetCommandLineArgs().Length > 1)
            {
                imagePath = Environment.GetCommandLineArgs()[1];
                pictureBoxMain.Image = Image.FromFile(imagePath);
            }
        }

        private void pictureBoxMain_DragEnter(object sender, DragEventArgs e)
        {
            e.Effect = DragDropEffects.Copy;
        }

        private void Root_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
                Close();
        }

        private void повернутьНа90ГрадусовToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (pictureBoxMain.Image != null)
            {
                pictureBoxMain.Image.RotateFlip(RotateFlipType.Rotate90FlipNone);
                pictureBoxMain.Invalidate();
            }
        }

        private void повернутьНа180ГрадусовToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (pictureBoxMain.Image != null)
            {
                pictureBoxMain.Image.RotateFlip(RotateFlipType.Rotate180FlipNone);
                pictureBoxMain.Invalidate();
            }
        }

        private void отразитьПоГоризонталиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (pictureBoxMain.Image != null)
            {
                pictureBoxMain.Image.RotateFlip(RotateFlipType.RotateNoneFlipX);
                pictureBoxMain.Invalidate();
            }
        }

        private void отразитьПоВертикалиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (pictureBoxMain.Image != null)
            {
                pictureBoxMain.Image.RotateFlip(RotateFlipType.RotateNoneFlipY);
                pictureBoxMain.Invalidate();
            }
        }

        private void pictureBoxMain_MouseDown(object sender, MouseEventArgs e)
        {
        }

        private void pictureBoxMain_MouseMove(object sender, MouseEventArgs e)
        {
        }

        private void pictureBoxMain_MouseUp(object sender, MouseEventArgs e)
        {
        }

        private void разработчикFadisNetToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AboutMe am = new AboutMe();
            am.ShowDialog();
        }

        private void информацияОФотоToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (pictureBoxMain.Image != null)
            {
                InformationsFile infoFile = new InformationsFile(pictureBoxMain.Image, imagePath);
                infoFile.ShowDialog();
            }
        }

        private void экспортироватьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (pictureBoxMain.Image != null)
            {
                Export exp = new Export(pictureBoxMain.Image, imagePath);
                exp.ShowDialog();
            }
        }

        private void режимМасштабированияToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (pictureBoxMain.Image != null)
            {
                ZoomMode zm = new ZoomMode(pictureBoxMain.Image, imagePath);
                zm.ShowDialog();
            }
        }

        private void обрезатьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (pictureBoxMain.Image != null)
            {
                TrimImage tm = new TrimImage(pictureBoxMain.Image, imagePath);
                tm.Owner = this; // Установите главную форму владельцем дочерней формы
                tm.ShowDialog();
            }
        }

        public void SetCropData(int x, int y, int width, int height)
        {
            // Store the cropped image data
            cropX = x;
            cropY = y;
            cropWidth = width;
            cropHeight = height;
            SetCropPicture();
        }

        public void SetCropPicture()
        {
            // Изменяем размер и положение изображения в pictureBoxMain
            pictureBoxMain.Image = CropImage(pictureBoxMain.Image, cropX, cropY, cropWidth, cropHeight);
            pictureBoxMain.SizeMode = PictureBoxSizeMode.StretchImage;
        }

        private Image CropImage(Image image, int x, int y, int width, int height)
        {
            // Создаем новый Bitmap с указанными размерами
            Bitmap croppedImage = new Bitmap(width, height);

            // Создаем графику для нового изображения
            using (Graphics graphics = Graphics.FromImage(croppedImage))
                // Копируем часть исходного изображения в новое изображение
                graphics.DrawImage(image, new Rectangle(0, 0, width, height), new Rectangle(x, y, width, height), GraphicsUnit.Pixel);

            // Возвращаем обрезанное изображение
            return croppedImage;
        }

        private void установитьИзображениеНаРабочийСтолToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string path = imagePath;
            int result = SystemParametersInfo(SPI_SETDESKWALLPAPER, 0, Marshal.StringToBSTR(path), SPIF_UPDATEINIFILE);
        }

        private void чернобелыйToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                if (pictureBoxMain.Image == null)
                    return;

                Bitmap image = (Bitmap)pictureBoxMain.Image;
                Rectangle rect = new Rectangle(0, 0, image.Width, image.Height);
                BitmapData imageData = image.LockBits(rect, ImageLockMode.ReadWrite, PixelFormat.Format32bppArgb);

                IntPtr ptr = imageData.Scan0;
                int bytes = Math.Abs(imageData.Stride) * image.Height;
                byte[] rgbValues = new byte[bytes];
                Marshal.Copy(ptr, rgbValues, 0, bytes);

                for (int i = 0; i < rgbValues.Length; i += 4)
                {
                    byte gray = (byte)((rgbValues[i] + rgbValues[i + 1] + rgbValues[i + 2]) / 3);
                    rgbValues[i] = gray;
                    rgbValues[i + 1] = gray;
                    rgbValues[i + 2] = gray;
                }

                Marshal.Copy(rgbValues, 0, ptr, bytes);
                image.UnlockBits(imageData);

                pictureBoxMain.Image = image;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка при обработке изображения: " + ex.Message);
            }
        }

        private void сепияToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                if (pictureBoxMain.Image == null)
                    return;

                Bitmap image = (Bitmap)pictureBoxMain.Image;
                Rectangle rect = new Rectangle(0, 0, image.Width, image.Height);
                BitmapData imageData = image.LockBits(rect, ImageLockMode.ReadWrite, PixelFormat.Format32bppArgb);

                IntPtr ptr = imageData.Scan0;
                int bytes = Math.Abs(imageData.Stride) * image.Height;
                byte[] rgbValues = new byte[bytes];
                Marshal.Copy(ptr, rgbValues, 0, bytes);

                for (int i = 0; i < rgbValues.Length; i += 4)
                {
                    byte newRed = (byte)(rgbValues[i] * 0.393 + rgbValues[i + 1] * 0.769 + rgbValues[i + 2] * 0.189);
                    byte newGreen = (byte)(rgbValues[i] * 0.349 + rgbValues[i + 1] * 0.686 + rgbValues[i + 2] * 0.168);
                    byte newBlue = (byte)(rgbValues[i] * 0.272 + rgbValues[i + 1] * 0.534 + rgbValues[i + 2] * 0.131);

                    rgbValues[i] = newBlue;
                    rgbValues[i + 1] = newGreen;
                    rgbValues[i + 2] = newRed;
                }

                Marshal.Copy(rgbValues, 0, ptr, bytes);
                image.UnlockBits(imageData);

                pictureBoxMain.Image = image;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка при обработке изображения: " + ex.Message);
            }
        }

        private void ретроToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                if (pictureBoxMain.Image == null)
                    return;

                Bitmap image = (Bitmap)pictureBoxMain.Image;
                Rectangle rect = new Rectangle(0, 0, image.Width, image.Height);
                BitmapData imageData = image.LockBits(rect, ImageLockMode.ReadWrite, PixelFormat.Format32bppArgb);

                IntPtr ptr = imageData.Scan0;
                int bytes = Math.Abs(imageData.Stride) * image.Height;
                byte[] rgbValues = new byte[bytes];
                Marshal.Copy(ptr, rgbValues, 0, bytes);

                for (int i = 0; i < rgbValues.Length; i += 4)
                {
                    byte newRed = (byte)(0.393 * rgbValues[i] + 0.769 * rgbValues[i + 1] + 0.189 * rgbValues[i + 2]);
                    byte newGreen = (byte)(0.349 * rgbValues[i] + 0.686 * rgbValues[i + 1] + 0.168 * rgbValues[i + 2]);
                    byte newBlue = (byte)(0.272 * rgbValues[i] + 0.534 * rgbValues[i + 1] + 0.131 * rgbValues[i + 2]);

                    rgbValues[i] = newBlue;
                    rgbValues[i + 1] = newGreen;
                    rgbValues[i + 2] = newRed;
                }

                Marshal.Copy(rgbValues, 0, ptr, bytes);
                image.UnlockBits(imageData);

                pictureBoxMain.Image = image;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка при обработке изображения: " + ex.Message);
            }
        }

        private void негативToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                // Проверяем наличие изображения в pictureBoxMain
                if (pictureBoxMain.Image == null)
                    return;

                // Получаем изображение из PictureBox
                Bitmap image = (Bitmap)pictureBoxMain.Image;

                // Проходимся по каждому пикселю изображения
                for (int y = 0; y < image.Height; y++)
                {
                    for (int x = 0; x < image.Width; x++)
                    {
                        // Получаем текущий пиксель
                        Color pixel = image.GetPixel(x, y);

                        // Инвертируем значения компонент цвета
                        byte newRed = (byte)(255 - pixel.R);
                        byte newGreen = (byte)(255 - pixel.G);
                        byte newBlue = (byte)(255 - pixel.B);

                        // Создаем новый цвет с использованием инвертированных значений компонент цвета
                        Color newPixel = Color.FromArgb(newRed, newGreen, newBlue);

                        // Устанавливаем новый цвет пикселя
                        image.SetPixel(x, y, newPixel);
                    }
                }

                // Обновляем изображение в PictureBox
                pictureBoxMain.Image = image;
            }
            catch (Exception ex)
            {
                // Обработка ошибки
                MessageBox.Show("Ошибка при обработке изображения: " + ex.Message);
            }
        }


        private void контрастностьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                if (pictureBoxMain.Image == null)
                    return;

                Bitmap image = (Bitmap)pictureBoxMain.Image;

                for (int y = 0; y < image.Height; y++)
                {
                    for (int x = 0; x < image.Width; x++)
                    {
                        Color pixel = image.GetPixel(x, y);

                        int newRed = (int)(1.5 * (pixel.R - 128) + 128);
                        int newGreen = (int)(1.5 * (pixel.G - 128) + 128);
                        int newBlue = (int)(1.5 * (pixel.B - 128) + 128);

                        newRed = Math.Min(Math.Max(newRed, 0), 255);
                        newGreen = Math.Min(Math.Max(newGreen, 0), 255);
                        newBlue = Math.Min(Math.Max(newBlue, 0), 255);

                        Color newPixel = Color.FromArgb(newRed, newGreen, newBlue);

                        image.SetPixel(x, y, newPixel);
                    }
                }

                pictureBoxMain.Image = image;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка при обработке изображения: " + ex.Message);
            }
        }

        private void резкостьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                if (pictureBoxMain.Image == null)
                    return;

                Bitmap image = (Bitmap)pictureBoxMain.Image;

                int[,] sharpenMatrix = new int[,]
                {
            { 0, -1, 0 },
            { -1, 5, -1 },
            { 0, -1, 0 }
                };

                Bitmap sharpenedImage = new Bitmap(image.Width, image.Height); // Создаем новый Bitmap для сохранения резкого изображения

                for (int y = 1; y < image.Height - 1; y++)
                {
                    for (int x = 1; x < image.Width - 1; x++)
                    {
                        int newRed = 0;
                        int newGreen = 0;
                        int newBlue = 0;

                        for (int i = -1; i <= 1; i++)
                        {
                            for (int j = -1; j <= 1; j++)
                            {
                                Color pixel = image.GetPixel(x + j, y + i);

                                newRed += pixel.R * sharpenMatrix[i + 1, j + 1];
                                newGreen += pixel.G * sharpenMatrix[i + 1, j + 1];
                                newBlue += pixel.B * sharpenMatrix[i + 1, j + 1];
                            }
                        }

                        newRed = Math.Min(Math.Max(newRed, 0), 255);
                        newGreen = Math.Min(Math.Max(newGreen, 0), 255);
                        newBlue = Math.Min(Math.Max(newBlue, 0), 255);

                        Color newPixel = Color.FromArgb(newRed, newGreen, newBlue);

                        sharpenedImage.SetPixel(x, y, newPixel);
                    }
                }

                pictureBoxMain.Image = sharpenedImage;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка при обработке изображения: " + ex.Message);
            }
        }


        private void зерноToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                if (pictureBoxMain.Image == null)
                    return;

                Bitmap image = (Bitmap)pictureBoxMain.Image;
                Random random = new Random(); // Создаем экземпляр класса Random за пределами циклов

                for (int y = 0; y < image.Height; y++)
                {
                    for (int x = 0; x < image.Width; x++)
                    {
                        Color pixel = image.GetPixel(x, y);

                        int grain = random.Next(-50, 50); // Используем один экземпляр класса Random для генерации случайных чисел

                        int newRed = Math.Min(Math.Max(pixel.R + grain, 0), 255);
                        int newGreen = Math.Min(Math.Max(pixel.G + grain, 0), 255);
                        int newBlue = Math.Min(Math.Max(pixel.B + grain, 0), 255);

                        Color newPixel = Color.FromArgb(newRed, newGreen, newBlue);

                        image.SetPixel(x, y, newPixel);
                    }
                }

                pictureBoxMain.Image = image;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка при обработке изображения: " + ex.Message);
            }
        }

        private void светлаяТемаToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.theme = "светлая";
            Properties.Settings.Default.Save();
            themeApp();
        }

        private void темнаяТемаToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.theme = "темная";
            Properties.Settings.Default.Save();
            themeApp();
        }

        // Функция для смены темы
        public void themeApp()
        {
            if (Properties.Settings.Default.theme == "светлая")
            {
                Color lightCoral = Color.FromArgb(240, 128, 128);

                BackColor = Color.IndianRed;

                pictureBoxMain.BackColor = Color.IndianRed;

                menuStripMain.BackColor = lightCoral;

                файлToolStripMenuItem.BackColor = lightCoral;
                изображениеToolStripMenuItem.BackColor = lightCoral;
                настройкиToolStripMenuItem.BackColor = lightCoral;
                помощьToolStripMenuItem.BackColor = lightCoral;

                файлToolStripMenuItem.ForeColor = Color.White;
                изображениеToolStripMenuItem.ForeColor = Color.White;
                настройкиToolStripMenuItem.ForeColor = Color.White;
                помощьToolStripMenuItem.ForeColor = Color.White;

                открытьToolStripMenuItem.BackColor = lightCoral;
                открытьToolStripMenuItem.ForeColor = Color.White;
                экспортироватьToolStripMenuItem.BackColor = lightCoral;
                экспортироватьToolStripMenuItem.ForeColor = Color.White;
                копироватьToolStripMenuItem.BackColor = lightCoral;
                копироватьToolStripMenuItem.ForeColor = Color.White;
                вставитьToolStripMenuItem.BackColor = lightCoral;
                вставитьToolStripMenuItem.ForeColor = Color.White;
                извлечьToolStripMenuItem.BackColor = lightCoral;
                извлечьToolStripMenuItem.ForeColor = Color.White;
                закрытьToolStripMenuItem.BackColor = lightCoral;
                закрытьToolStripMenuItem.ForeColor = Color.White;
                выходToolStripMenuItem.BackColor = lightCoral;
                выходToolStripMenuItem.ForeColor = Color.White;

                повернутьНа90ГрадусовToolStripMenuItem.BackColor = lightCoral;
                повернутьНа90ГрадусовToolStripMenuItem.ForeColor = Color.White;
                повернутьНа180ГрадусовToolStripMenuItem.BackColor = lightCoral;
                повернутьНа180ГрадусовToolStripMenuItem.ForeColor = Color.White;
                отразитьПоГоризонталиToolStripMenuItem.BackColor = lightCoral;
                отразитьПоГоризонталиToolStripMenuItem.ForeColor = Color.White;
                отразитьПоВертикалиToolStripMenuItem.BackColor = lightCoral;
                отразитьПоВертикалиToolStripMenuItem.ForeColor = Color.White;
                информацияОФотоToolStripMenuItem.BackColor = lightCoral;
                информацияОФотоToolStripMenuItem.ForeColor = Color.White;
                режимМасштабированияToolStripMenuItem.BackColor = lightCoral;
                режимМасштабированияToolStripMenuItem.ForeColor = Color.White;
                обрезатьToolStripMenuItem.BackColor = lightCoral;
                обрезатьToolStripMenuItem.ForeColor = Color.White;
                отразитьПоВертикалиToolStripMenuItem.BackColor = lightCoral;
                отразитьПоВертикалиToolStripMenuItem.ForeColor = Color.White;
                установитьИзображениеНаРабочийСтолToolStripMenuItem.BackColor = lightCoral;
                установитьИзображениеНаРабочийСтолToolStripMenuItem.ForeColor = Color.White;
                фильтрыToolStripMenuItem.BackColor = lightCoral;
                фильтрыToolStripMenuItem.ForeColor = Color.White;
                чернобелыйToolStripMenuItem.BackColor = lightCoral;
                чернобелыйToolStripMenuItem.ForeColor = Color.White;
                сепияToolStripMenuItem.BackColor = lightCoral;
                сепияToolStripMenuItem.ForeColor = Color.White;
                ретроToolStripMenuItem.BackColor = lightCoral;
                ретроToolStripMenuItem.ForeColor = Color.White;
                негативToolStripMenuItem.BackColor = lightCoral;
                негативToolStripMenuItem.ForeColor = Color.White;
                контрастностьToolStripMenuItem.BackColor = lightCoral;
                контрастностьToolStripMenuItem.ForeColor = Color.White;
                резкостьToolStripMenuItem.BackColor = lightCoral;
                резкостьToolStripMenuItem.ForeColor = Color.White;
                зерноToolStripMenuItem.BackColor = lightCoral;
                зерноToolStripMenuItem.ForeColor = Color.White;

                темнаяТемаToolStripMenuItem.BackColor = lightCoral;
                темнаяТемаToolStripMenuItem.ForeColor = Color.White;
                светлаяТемаToolStripMenuItem.BackColor = lightCoral;
                светлаяТемаToolStripMenuItem.ForeColor = Color.White;
                настроитьСвюТемуToolStripMenuItem.BackColor = lightCoral;
                настроитьСвюТемуToolStripMenuItem.ForeColor = Color.White;
                настройкиToolStripMenuItem1.BackColor = lightCoral;
                настройкиToolStripMenuItem1.ForeColor = Color.White;

                разработчикFadisNetToolStripMenuItem.BackColor = lightCoral;
                разработчикFadisNetToolStripMenuItem.ForeColor = Color.White;
            }
            else if (Properties.Settings.Default.theme == "темная")
            {
                BackColor = Color.MidnightBlue;

                pictureBoxMain.BackColor = Color.MidnightBlue;

                menuStripMain.BackColor = Color.DarkSlateBlue;

                файлToolStripMenuItem.BackColor = Color.DarkSlateBlue;
                изображениеToolStripMenuItem.BackColor = Color.DarkSlateBlue;
                настройкиToolStripMenuItem.BackColor = Color.DarkSlateBlue;
                помощьToolStripMenuItem.BackColor = Color.DarkSlateBlue;

                файлToolStripMenuItem.ForeColor = Color.White;
                изображениеToolStripMenuItem.ForeColor = Color.White;
                настройкиToolStripMenuItem.ForeColor = Color.White;
                помощьToolStripMenuItem.ForeColor = Color.White;

                открытьToolStripMenuItem.BackColor = Color.DarkSlateBlue;
                открытьToolStripMenuItem.ForeColor = Color.White;
                экспортироватьToolStripMenuItem.BackColor = Color.DarkSlateBlue;
                экспортироватьToolStripMenuItem.ForeColor = Color.White;
                копироватьToolStripMenuItem.BackColor = Color.DarkSlateBlue;
                копироватьToolStripMenuItem.ForeColor = Color.White;
                вставитьToolStripMenuItem.BackColor = Color.DarkSlateBlue;
                вставитьToolStripMenuItem.ForeColor = Color.White;
                извлечьToolStripMenuItem.BackColor = Color.DarkSlateBlue;
                извлечьToolStripMenuItem.ForeColor = Color.White;
                закрытьToolStripMenuItem.BackColor = Color.DarkSlateBlue;
                закрытьToolStripMenuItem.ForeColor = Color.White;
                выходToolStripMenuItem.BackColor = Color.DarkSlateBlue;
                выходToolStripMenuItem.ForeColor = Color.White;

                повернутьНа90ГрадусовToolStripMenuItem.BackColor = Color.DarkSlateBlue;
                повернутьНа90ГрадусовToolStripMenuItem.ForeColor = Color.White;
                повернутьНа180ГрадусовToolStripMenuItem.BackColor = Color.DarkSlateBlue;
                повернутьНа180ГрадусовToolStripMenuItem.ForeColor = Color.White;
                отразитьПоГоризонталиToolStripMenuItem.BackColor = Color.DarkSlateBlue;
                отразитьПоГоризонталиToolStripMenuItem.ForeColor = Color.White;
                отразитьПоВертикалиToolStripMenuItem.BackColor = Color.DarkSlateBlue;
                отразитьПоВертикалиToolStripMenuItem.ForeColor = Color.White;
                информацияОФотоToolStripMenuItem.BackColor = Color.DarkSlateBlue;
                информацияОФотоToolStripMenuItem.ForeColor = Color.White;
                режимМасштабированияToolStripMenuItem.BackColor = Color.DarkSlateBlue;
                режимМасштабированияToolStripMenuItem.ForeColor = Color.White;
                обрезатьToolStripMenuItem.BackColor = Color.DarkSlateBlue;
                обрезатьToolStripMenuItem.ForeColor = Color.White;
                отразитьПоВертикалиToolStripMenuItem.BackColor = Color.DarkSlateBlue;
                отразитьПоВертикалиToolStripMenuItem.ForeColor = Color.White;
                установитьИзображениеНаРабочийСтолToolStripMenuItem.BackColor = Color.DarkSlateBlue;
                установитьИзображениеНаРабочийСтолToolStripMenuItem.ForeColor = Color.White;
                фильтрыToolStripMenuItem.BackColor = Color.DarkSlateBlue;
                фильтрыToolStripMenuItem.ForeColor = Color.White;
                чернобелыйToolStripMenuItem.BackColor = Color.DarkSlateBlue;
                чернобелыйToolStripMenuItem.ForeColor = Color.White;
                сепияToolStripMenuItem.BackColor = Color.DarkSlateBlue;
                сепияToolStripMenuItem.ForeColor = Color.White;
                ретроToolStripMenuItem.BackColor = Color.DarkSlateBlue;
                ретроToolStripMenuItem.ForeColor = Color.White;
                негативToolStripMenuItem.BackColor = Color.DarkSlateBlue;
                негативToolStripMenuItem.ForeColor = Color.White;
                контрастностьToolStripMenuItem.BackColor = Color.DarkSlateBlue;
                контрастностьToolStripMenuItem.ForeColor = Color.White;
                резкостьToolStripMenuItem.BackColor = Color.DarkSlateBlue;
                резкостьToolStripMenuItem.ForeColor = Color.White;
                зерноToolStripMenuItem.BackColor = Color.DarkSlateBlue;
                зерноToolStripMenuItem.ForeColor = Color.White;

                темнаяТемаToolStripMenuItem.BackColor = Color.DarkSlateBlue;
                темнаяТемаToolStripMenuItem.ForeColor = Color.White;
                светлаяТемаToolStripMenuItem.BackColor = Color.DarkSlateBlue;
                светлаяТемаToolStripMenuItem.ForeColor = Color.White;
                настроитьСвюТемуToolStripMenuItem.BackColor = Color.DarkSlateBlue;
                настроитьСвюТемуToolStripMenuItem.ForeColor = Color.White;
                настройкиToolStripMenuItem1.BackColor = Color.DarkSlateBlue;
                настройкиToolStripMenuItem1.ForeColor = Color.White;

                разработчикFadisNetToolStripMenuItem.BackColor = Color.DarkSlateBlue;
                разработчикFadisNetToolStripMenuItem.ForeColor = Color.White;
            }
            else
            {
                Color backgroundColorInterface = Properties.Settings.Default.backgroundColorInterface;
                Color backgroundColorMenu = Properties.Settings.Default.backgroundColorMenu;
                Color colorTextInterface = Properties.Settings.Default.colorTextInterface;

                BackColor = backgroundColorInterface;

                pictureBoxMain.BackColor = backgroundColorInterface;

                menuStripMain.BackColor = backgroundColorMenu;

                файлToolStripMenuItem.BackColor = backgroundColorMenu;
                изображениеToolStripMenuItem.BackColor = backgroundColorMenu;
                настройкиToolStripMenuItem.BackColor = backgroundColorMenu;
                помощьToolStripMenuItem.BackColor = backgroundColorMenu;

                файлToolStripMenuItem.ForeColor = colorTextInterface;
                изображениеToolStripMenuItem.ForeColor = colorTextInterface;
                настройкиToolStripMenuItem.ForeColor = colorTextInterface;
                помощьToolStripMenuItem.ForeColor = colorTextInterface;

                открытьToolStripMenuItem.BackColor = backgroundColorMenu;
                открытьToolStripMenuItem.ForeColor = colorTextInterface;
                экспортироватьToolStripMenuItem.BackColor = backgroundColorMenu;
                экспортироватьToolStripMenuItem.ForeColor = colorTextInterface;
                копироватьToolStripMenuItem.BackColor = backgroundColorMenu;
                копироватьToolStripMenuItem.ForeColor = colorTextInterface;
                вставитьToolStripMenuItem.BackColor = backgroundColorMenu;
                вставитьToolStripMenuItem.ForeColor = colorTextInterface;
                извлечьToolStripMenuItem.BackColor = backgroundColorMenu;
                извлечьToolStripMenuItem.ForeColor = colorTextInterface;
                закрытьToolStripMenuItem.BackColor = backgroundColorMenu;
                закрытьToolStripMenuItem.ForeColor = colorTextInterface;
                выходToolStripMenuItem.BackColor = backgroundColorMenu;
                выходToolStripMenuItem.ForeColor = colorTextInterface;

                повернутьНа90ГрадусовToolStripMenuItem.BackColor = backgroundColorMenu;
                повернутьНа90ГрадусовToolStripMenuItem.ForeColor = colorTextInterface;
                повернутьНа180ГрадусовToolStripMenuItem.BackColor = backgroundColorMenu;
                повернутьНа180ГрадусовToolStripMenuItem.ForeColor = colorTextInterface;
                отразитьПоГоризонталиToolStripMenuItem.BackColor = backgroundColorMenu;
                отразитьПоГоризонталиToolStripMenuItem.ForeColor = colorTextInterface;
                отразитьПоВертикалиToolStripMenuItem.BackColor = backgroundColorMenu;
                отразитьПоВертикалиToolStripMenuItem.ForeColor = colorTextInterface;
                информацияОФотоToolStripMenuItem.BackColor = backgroundColorMenu;
                информацияОФотоToolStripMenuItem.ForeColor = colorTextInterface;
                режимМасштабированияToolStripMenuItem.BackColor = backgroundColorMenu;
                режимМасштабированияToolStripMenuItem.ForeColor = colorTextInterface;
                обрезатьToolStripMenuItem.BackColor = backgroundColorMenu;
                обрезатьToolStripMenuItem.ForeColor = colorTextInterface;
                отразитьПоВертикалиToolStripMenuItem.BackColor = backgroundColorMenu;
                отразитьПоВертикалиToolStripMenuItem.ForeColor = colorTextInterface;
                установитьИзображениеНаРабочийСтолToolStripMenuItem.BackColor = backgroundColorMenu;
                установитьИзображениеНаРабочийСтолToolStripMenuItem.ForeColor = colorTextInterface;
                фильтрыToolStripMenuItem.BackColor = backgroundColorMenu;
                фильтрыToolStripMenuItem.ForeColor = colorTextInterface;
                чернобелыйToolStripMenuItem.BackColor = backgroundColorMenu;
                чернобелыйToolStripMenuItem.ForeColor = colorTextInterface;
                сепияToolStripMenuItem.BackColor = backgroundColorMenu;
                сепияToolStripMenuItem.ForeColor = colorTextInterface;
                ретроToolStripMenuItem.BackColor = backgroundColorMenu;
                ретроToolStripMenuItem.ForeColor = colorTextInterface;
                негативToolStripMenuItem.BackColor = backgroundColorMenu;
                негативToolStripMenuItem.ForeColor = colorTextInterface;
                контрастностьToolStripMenuItem.BackColor = backgroundColorMenu;
                контрастностьToolStripMenuItem.ForeColor = colorTextInterface;
                резкостьToolStripMenuItem.BackColor = backgroundColorMenu;
                резкостьToolStripMenuItem.ForeColor = colorTextInterface;
                зерноToolStripMenuItem.BackColor = backgroundColorMenu;
                зерноToolStripMenuItem.ForeColor = colorTextInterface;

                темнаяТемаToolStripMenuItem.BackColor = backgroundColorMenu;
                темнаяТемаToolStripMenuItem.ForeColor = colorTextInterface;
                светлаяТемаToolStripMenuItem.BackColor = backgroundColorMenu;
                светлаяТемаToolStripMenuItem.ForeColor = colorTextInterface;
                настроитьСвюТемуToolStripMenuItem.BackColor = backgroundColorMenu;
                настроитьСвюТемуToolStripMenuItem.ForeColor = colorTextInterface;
                настройкиToolStripMenuItem1.BackColor = backgroundColorMenu;
                настройкиToolStripMenuItem1.ForeColor = colorTextInterface;

                разработчикFadisNetToolStripMenuItem.BackColor = backgroundColorMenu;
                разработчикFadisNetToolStripMenuItem.ForeColor = colorTextInterface;
            }
        }

        private void копироватьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Clipboard.SetImage(pictureBoxMain.Image);
        }

        private void вставитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            pictureBoxMain.Image = Clipboard.GetImage();
        }

        private void извлечьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (pictureBoxMain.Image != null)
            {
                Clipboard.SetImage(pictureBoxMain.Image);
                pictureBoxMain.Image = null;
            }
        }

        private void sizeApp()
        {
            Width = Properties.Settings.Default.width;
            Height = Properties.Settings.Default.height;
        }

        private void Root_FormClosing(object sender, FormClosingEventArgs e)
        {
            Properties.Settings.Default.width = Width;
            Properties.Settings.Default.height = Height;
            Properties.Settings.Default.Save();
        }

        private void настроитьСвюТемуToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MyTheme mt = new MyTheme(this);
            mt.ShowDialog();
        }

        private void настройкиToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Settings s = new Settings();
            s.ShowDialog();
        }
    }
}



/*
Идеи на будущее:
+ Реализовать слайдер (чтобы можно было посмотравать все фотографи из каталога,
  где запущена программа);
+ Реализовать зум (приближение и отдаление программы);
+ Реализовать не открытие нового окна программы при клике на другое изображение,
  а обновление изображения в этой же открытой программе;
+ Добавить возможность работы с форматом webp и прочими (надеюсь хотя бы в будущем
  получиться, если не сейчас...);
+ Добавить возможность при экспорте при выборе расширения или изменения разрешения
  изображения получать заранее выходной размер файла
 */






/*
 Переменные проекта косаемо цвета

backgroundColorInterface
Properties.Settings.Default.backgroundColorElements
backgroundColorMenu
colorTextInterface
Properties.Settings.Default.colorTextElements
Properties.Settings.Default.fontSizeText

А для читабельности можно присвоить другим переменным
предварительно создав их и дав им такое же имя

private Color backgroundColorInterface;
private Color backgroundColorElements;
private Color backgroundColorMenu;
private Color colorTextInterface;
private Color colorTextElements;
private Font fontSizeText;
 */