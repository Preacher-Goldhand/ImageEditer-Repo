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

namespace ImageEditer
{
    public partial class MainForm : Form
    {
        //Setting of variables.
        Image img;
        Rectangle rect = new Rectangle();
        Point a;
        Point b;
        float cont = 0;
        Boolean mouseDown = false;
        OpenFileDialog ofd = new OpenFileDialog();

        public MainForm()
        {
            InitializeComponent();
        }
        //Reset method for Restet button.
        void Reset()
        {
            img = Image.FromFile(ofd.FileName);
            MainPictureBox.Image = img;
        }
        //Filter 1 etc.
        void Filter1()
        {
            img = MainPictureBox.Image;
            Bitmap bmpInverted = new Bitmap(img.Width, img.Height);
            ImageAttributes imga = new ImageAttributes();
            ColorMatrix cmpPicture = new ColorMatrix(new float[][] 
            {
                new float[] {1,0,0,0,0},
                new float[] {0,1,1,0,0},
                new float[] {0,0,0,0,0},
                new float[] {0,0,0,1,0},
                new float[] {0,0,0,0,1} });
            imga.SetColorMatrix(cmpPicture);
            Graphics grps = Graphics.FromImage(bmpInverted);
            grps.DrawImage(img, new Rectangle(0, 0, img.Width, img.Height), 0, 0, img.Width, img.Height, GraphicsUnit.Pixel, imga);
            grps.Dispose();
            MainPictureBox.Image = bmpInverted;          
        }
        void Filter2()
        {
            img = MainPictureBox.Image;
            Bitmap bmpInverted = new Bitmap(img.Width, img.Height);
            ImageAttributes imga = new ImageAttributes();
            ColorMatrix cmPicture = new ColorMatrix(new float[][] {
              new float[]{.393f, .349f, .272f, 0, 0},
              new float[]{.769f, .686f, .534f, 0, 0},
              new float[]{.189f, .168f, .131f, 0, 0},
              new float[]{0, 0, 0, 1, 0},
              new float[]{0, 0, 0, 0, 1} });
            imga.SetColorMatrix(cmPicture);
            Graphics grps = Graphics.FromImage(bmpInverted);
            grps.DrawImage(img, new Rectangle(0, 0, img.Width, img.Height), 0, 0, img.Width, img.Height, GraphicsUnit.Pixel, imga);
            grps.Dispose();
            MainPictureBox.Image = bmpInverted;
        }
        void Filter3()
        {
            img = MainPictureBox.Image;
            Bitmap bmpInverted = new Bitmap(img.Width, img.Height);
            ImageAttributes imga = new ImageAttributes();
            ColorMatrix cmPicture = new ColorMatrix(new float[][] {
              new float[]{.3f, .3f, .3f, 0, 0},    
              new float[]{.59f, .59f, .59f, 0, 0},
              new float[]{.11f, .11f, .11f, 0, 0},
              new float[]{0, 0, 0, 1, 0},
              new float[]{0, 0, 0, 0, 1} });
            imga.SetColorMatrix(cmPicture);
            Graphics grps = Graphics.FromImage(bmpInverted);
            grps.DrawImage(img, new Rectangle(0, 0, img.Width, img.Height), 0, 0, img.Width, img.Height, GraphicsUnit.Pixel, imga);
            grps.Dispose();
            MainPictureBox.Image = bmpInverted;
        }
        void Filter4()
        {
            img = MainPictureBox.Image;
            Bitmap bmpInverted = new Bitmap(img.Width, img.Height);
            ImageAttributes imga = new ImageAttributes();
            ColorMatrix cmPicture = new ColorMatrix(new float[][] {
             new float[] {1,1,0,0,0,0},
             new float[] {0,0,1,0,0},
             new float[] {0,0,0,0,0},
             new float[] {0,0,0,1,0},
             new float[]{0,0,0,0,1} });
            imga.SetColorMatrix(cmPicture);
            Graphics grps = Graphics.FromImage(bmpInverted);
            grps.DrawImage(img, new Rectangle(0, 0, img.Width, img.Height), 0, 0, img.Width, img.Height, GraphicsUnit.Pixel, imga);
            grps.Dispose();
            MainPictureBox.Image = bmpInverted;
        }
        void Filter5()
        {
            img = MainPictureBox.Image;
            Bitmap bmpInverted = new Bitmap(img.Width, img.Height);
            ImageAttributes imga = new ImageAttributes();
            ColorMatrix cmPicture = new ColorMatrix(new float[][] {
             new float[] {1,1,1,0,0},
             new float[] {0,0,1,1,0},
             new float[] {0,0,0,0,0},
             new float[] {0,0,0,1,0},
             new float[]{0,0,0,0,1} });

            imga.SetColorMatrix(cmPicture);
            Graphics grps = Graphics.FromImage(bmpInverted);
            grps.DrawImage(img, new Rectangle(0, 0, img.Width, img.Height), 0, 0, img.Width, img.Height, GraphicsUnit.Pixel, imga);
            grps.Dispose();
            MainPictureBox.Image = bmpInverted;
        }
        //HUE method.
        void Hue()
        {
            img = MainPictureBox.Image;
            Bitmap bmpInverted = new Bitmap(img.Width, img.Height);
            ImageAttributes imga = new ImageAttributes();
            ColorMatrix cmPicture = new ColorMatrix(new float[][] {
             new float[] {1,0,(HUETrackBar.Value),0,0,0,0},
             new float[] {0,1,0,0,0},
             new float[] {0,0,0,0,0},
             new float[] {0,0,0,1,0},
             new float[]{0,0,0,0,1} });
            imga.SetColorMatrix(cmPicture);
            Graphics grps = Graphics.FromImage(bmpInverted);
            grps.DrawImage(img, new Rectangle(0, 0, img.Width, img.Height), 0, 0, img.Width, img.Height, GraphicsUnit.Pixel, imga);
            grps.Dispose();
            MainPictureBox.Image = bmpInverted;
            WindowPictureBox.Image = MainPictureBox.Image;
        }
        //Contrast method.
        void Contrast()
        {
            cont = 0.2f * ContrastTrackBar.Value;

            Bitmap bmpInverted = new Bitmap(img.Width, img.Height);
            ImageAttributes imga = new ImageAttributes();
            ColorMatrix cmPicture = new ColorMatrix(new float[][] {
              new float[]{cont ,0f,0f,0f,0f },
              new float[]{0f,cont,0f,0f,0f },
              new float[]{0f,0f,cont,0f,0f },
              new float[]{0f,0f,0f,1f,0f },
              new float[]{0.001f,0.001f,0.001f,0f,1f} });
            imga.SetColorMatrix(cmPicture);
            Graphics grps = Graphics.FromImage(bmpInverted);
            grps.DrawImage(img, new Rectangle(0, 0, img.Width, img.Height), 0, 0, img.Width, img.Height, GraphicsUnit.Pixel, imga);
            grps.Dispose();
            MainPictureBox.Image = bmpInverted;
        }
        //Brightness method.
        void Brightness()
        {
            img = MainPictureBox.Image;
            float fvalue = BrightnessTrackBar.Value / 50f;
            Bitmap bmpInverted = new Bitmap(img.Width, img.Height);
            ImageAttributes imga = new ImageAttributes();
            ColorMatrix cmPicture = new ColorMatrix(new float[][] {
            new float[] {1,0,0,0,0},
             new float[] {0,1,0,0,0},
             new float[] {0,0,1,0,0 },
             new float[] {0,0,0,0,0},
             new float[]{fvalue,fvalue,fvalue,1,1} });
            imga.SetColorMatrix(cmPicture);
            Graphics grps = Graphics.FromImage(bmpInverted);
            grps.DrawImage(img, new Rectangle(0, 0, img.Width, img.Height), 0, 0, img.Width, img.Height, GraphicsUnit.Pixel, imga);
            grps.Dispose();
            MainPictureBox.Image = bmpInverted;
        }
        //Select an image button event hanler.
        private void SelectButton_Click(object sender, EventArgs e)
        {
            MainPictureBox.Image = null;
            ofd.Filter = "images|*.png;*.jpg;*.jpeg;*.gif";

            if (ofd.ShowDialog() == DialogResult.OK)
            {
                MainPictureBox.Image = new Bitmap(ofd.FileName);
                WindowPictureBox.Image = new Bitmap(ofd.FileName);
                MainPictureBox.SizeMode = PictureBoxSizeMode.Zoom;
                WindowPictureBox.SizeMode = PictureBoxSizeMode.Zoom;
                ImgSizeTextBox.Text = ofd.FileName;
                img = Image.FromFile(ofd.FileName);
                ImgSizeLabel.Text = MainPictureBox.Image.Size.ToString();
            }
        }

        //Method Resize() of Image type.
        //Returning Bitmap of the image.
        new Image Resize(Image image, int width, int height)
        {
            Bitmap bmp = new Bitmap(width, height);
            Graphics graphic = Graphics.FromImage(bmp);
            graphic.DrawImage(image, 0, 0, width, height);
            graphic.Dispose();
            return bmp;
        }
        //Set button event handler.
        private void SetButton_Click(object sender, EventArgs e)
        {
            int width = Convert.ToInt32(WidthTextBox.Text), height = Convert.ToInt32(HeightTextBox.Text);
            img = Resize(img, width, height);
            WindowPictureBox.Image = img;
            WidthTextBox.Text = "";
            HeightTextBox.Text = "";
        }
        //Save the image button.

        private void SaveButton_Click(object sender, EventArgs e)
        {
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.Filter = "JPEG|*.JPG|PNG|*.PNG|GIF|*.GIF|BMP|*.BMP|All files (*.*)|*.*";
            if (sfd.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    using (Bitmap bitmap = new Bitmap(WindowPictureBox.Image))
                    {
                        bitmap.Save(sfd.FileName, ImageFormat.Jpeg);
                    }
                    MessageBox.Show("Picture Saved Successfully.");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("An Error has occured");
                }
            }
        }
        //Rotate button.
        private void RotateButton_Click(object sender, EventArgs e)
        {
            WindowPictureBox.Image = MainPictureBox.Image;
            MainPictureBox.Image.RotateFlip(RotateFlipType.Rotate180FlipX);
            MainPictureBox.Image.RotateFlip(RotateFlipType.Rotate90FlipX);
            MainPictureBox.Refresh();
        }
        //Reset button with implementing of Reset method.
        private void ResetButton_Click(object sender, EventArgs e)
        {
            WidthTextBox.Text = "";
            HeightTextBox.Text = "";
            HUETrackBar.Value = 0;
            ContrastTrackBar.Value = 0;
            BrightnessTrackBar.Value = 0;
            Reset();
        }
        //Buttons for filters.
        private void Filter1Button_Click(object sender, EventArgs e)
        {
            Reset();
            Filter1();
        }

        private void Filter2Button_Click(object sender, EventArgs e)
        {
            Reset();
            Filter2();
        }

        private void Filter3Button_Click(object sender, EventArgs e)
        {
            Reset();
            Filter3();
        }

        private void Filter4Button_Click(object sender, EventArgs e)
        {
            Reset();
            Filter4();
        }

        private void Filter5Button_Click(object sender, EventArgs e)
        {
            Reset();
            Filter5();
        }
        //Dealing with Trackbars: HUE, Constrast and Brightness.
        private void HUETrackBar_ValueChanged(object sender, EventArgs e)
        {
            Reset();
            Hue();
        }

        private void ContrastTrackBar_ValueChanged(object sender, EventArgs e)
        {
            Contrast();
        }

        private void ContrastTrackBar_Scroll(object sender, EventArgs e)
        {
            Reset();
        }

        private void BrightnessTrackBar_ValueChanged(object sender, EventArgs e)
        {
            Brightness();
        }
        //Setting mouse event handlers.
        private void MainPictureBox_MouseDown(object sender, MouseEventArgs e)
        {
            mouseDown = true;
            a = e.Location;
        }

        private void MainPictureBox_MouseMove(object sender, MouseEventArgs e)
        {
            if (mouseDown == true)
            {
                b = e.Location;
                Refresh();
            }
        }

        private void MainPictureBox_MouseUp(object sender, MouseEventArgs e)
        {
            if (mouseDown == true)
            {
                b = e.Location;
                mouseDown = false;

                if (rect != null)
                {
                    Bitmap bitm = new Bitmap(MainPictureBox.Image, MainPictureBox.Width, MainPictureBox.Height);
                    Bitmap crop = new Bitmap(rect.Width, rect.Height);
                    Graphics g = Graphics.FromImage(crop);
                    g.DrawImage(bitm, 0, 0, rect, GraphicsUnit.Pixel);
                    WindowPictureBox.Image = crop;

                }
            }
        }
        //Getting method for Rectangle type and setting dimensions for the image.
        private Rectangle GetRect()
        {
            rect = new Rectangle();
            rect.X = Math.Min(a.X, b.X);
            rect.Y = Math.Min(a.Y, b.Y);
            rect.Width = Math.Abs(a.X - b.X);
            rect.Height = Math.Abs(a.Y - b.Y);
            return rect;
        }

        private void MainPictureBox_Paint(object sender, PaintEventArgs e)
        {
            if (rect != null)
            {
                e.Graphics.DrawRectangle(Pens.Aqua, GetRect());
            }
        }
        //Normal, stretch, autosize, center and zoom buttons.
        private void NormalButton_Click(object sender, EventArgs e)
        {
            MainPictureBox.SizeMode = PictureBoxSizeMode.Normal;
        }

        private void StretchButton_Click(object sender, EventArgs e)
        {
            MainPictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
        }

        private void AutoSizeButton_Click(object sender, EventArgs e)
        {
            MainPictureBox.SizeMode = PictureBoxSizeMode.AutoSize;
        }

        private void CenterButton_Click(object sender, EventArgs e)
        {
            MainPictureBox.SizeMode = PictureBoxSizeMode.CenterImage;
        }

        private void ZoomButton_Click(object sender, EventArgs e)
        {
            MainPictureBox.SizeMode = PictureBoxSizeMode.Zoom;
        }
        //Zooming for side-window picture box.
        private void MainPictureBox_Click(object sender, EventArgs e)
        {
            WindowPictureBox.SizeMode = PictureBoxSizeMode.Zoom;
        }
    }
}
