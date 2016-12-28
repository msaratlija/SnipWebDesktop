using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Screenshoot : Form
    {

        Rectangle   cropRect;
        SolidBrush  myBrush;
        Pen         myPen;
        Point       startPosition;
        Point       currentPosition;
        Bitmap      cropedImage;
        Random      random;

        bool     draw;
        byte[]   postStreamImageArray;

        public Screenshoot()
        {
            InitializeComponent();
            
            //The look of the form Screenshot
            this.WindowState = FormWindowState.Maximized;
            this.FormBorderStyle = FormBorderStyle.None;
            this.BackColor = Color.Black;
            this.Cursor = Cursors.Cross;

            //Defining form actions
            this.KeyDown += Screenshoot_KeyDown;
            pictureBox1.MouseDown += pictureBox1_MouseDown;
            pictureBox1.MouseMove += pictureBox1_MouseMove;
            pictureBox1.MouseUp += pictureBox1_MouseUp;
            pictureBox1.Paint += pictureBox1_Paint;
            draw = false;
        }


        private void Screenshoot_Load(object sender, EventArgs e)
        {
            draw = false;
            myPen = new Pen(Color.Black, 1);
            myBrush = new SolidBrush(Color.FromArgb(100, 128, 128, 128));
            random = new Random();
            //selectPen.DashStyle = System.Drawing.Drawing2D.DashStyle.Dash;


            using (MemoryStream s = new MemoryStream())
            {
                //Save graphic variable into memory
                Form1.bitmapScreenshot.Save(s, ImageFormat.Png);
                pictureBox1.Size = new System.Drawing.Size(this.Width, this.Height);
                pictureBox1.Image = Image.FromStream(s);
            }

            Form1.InstanceForm1.Opacity = 1;
            
        }



        //Exit Screenshot form with ESC key
        private void Screenshoot_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                this.DialogResult = System.Windows.Forms.DialogResult.Cancel;
                this.Close();
            }
        }

        
        //Aquire of the current point on left mouse click
        private void pictureBox1_MouseDown(object sender, MouseEventArgs e)
        {
            if (!draw && 
                pictureBox1.Image != null &&
                e.Button == System.Windows.Forms.MouseButtons.Left)
            {
                    startPosition = e.Location;
                    draw = true;
            }
        }

        

        //Check if mouse is down and being draged, then draw rectangle
        private void pictureBox1_MouseMove(object sender, MouseEventArgs e)
        {
            if (draw)
            {
                currentPosition = e.Location;
                cropRect = GetRectangle();
                pictureBox1.Invalidate();
            }
        }

        //When left click is released after dragging mouse
        private void pictureBox1_MouseUp(object sender, MouseEventArgs e)
        {
            draw = false;
            CropScreenshot();
            if (Form1.InstanceForm1.getRadioCheck2())
            {
                String cropTempPictureName = "desk_app_" + Upload.imageNumberName + ".png"; //RandomString(4)
                cropedImage.Save(Form1.destinationForCropedImage + "\\" + cropTempPictureName);
                Upload.imageNumberName ++;
                MessageBox.Show("Croped picture is saved at: " + 
                                 Form1.destinationForCropedImage +  "\\" + cropTempPictureName);
            }else
            {
                Upload uploadImage = new Upload();
                uploadImage.UploadImageWithPost(postStreamImageArray);
            }


            pictureBox1.Invalidate();
            this.Close();
        }

        //Paints rectangle in pictureBox without flickering effect
        private void pictureBox1_Paint(object sender, PaintEventArgs e)
        {
            if (draw)
            {
                e.Graphics.DrawRectangle(myPen, cropRect);
                e.Graphics.FillRectangle(myBrush, cropRect);
            }
            
        }

        //Gets rectangle from dragging mouse
        private Rectangle GetRectangle()
        {
            cropRect = new Rectangle(
                Math.Min(startPosition.X, currentPosition.X),
                Math.Min(startPosition.Y, currentPosition.Y),
                Math.Abs(startPosition.X - currentPosition.X),
                Math.Abs(startPosition.Y - currentPosition.Y));

            return cropRect;
        }

        //Make crop out of the screenshot
        private void CropScreenshot()
        {
            cropedImage = new Bitmap(Form1.bitmapScreenshot);
            cropedImage = cropedImage.Clone(cropRect, cropedImage.PixelFormat);
            using (MemoryStream s = new MemoryStream())
            {
                cropedImage.Save(s, ImageFormat.Png);
                postStreamImageArray = s.ToArray();
            }
        }

    }
}
