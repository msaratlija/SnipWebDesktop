using System;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {

        public static Bitmap bitmapScreenshot;
        public static Graphics graphicsScreenshot;
        public static Form1 InstanceForm1;
        public static String destinationForCropedImage;
        private String pathToTheFile;

        public Form1()
        {
            InitializeComponent();
            InstanceForm1 = this;
            Upload.imageNumberName = 0;
        }

        static bool getWorkingScreenshoot()
        {

            try
            {
                bitmapScreenshot = new Bitmap(Screen.PrimaryScreen.Bounds.Width,
                        Screen.PrimaryScreen.Bounds.Height, PixelFormat.Format24bppRgb);


                graphicsScreenshot = Graphics.FromImage(bitmapScreenshot);

                graphicsScreenshot.CopyFromScreen(Screen.PrimaryScreen.Bounds.X,
                    Screen.PrimaryScreen.Bounds.Y, 0, 0, Screen.PrimaryScreen.Bounds.Size,
                    CopyPixelOperation.SourceCopy);

                return true;
            }
            catch (Exception)
            {
                MessageBox.Show("Capture not saved.");
                return false;
                throw;
            }

        }



        private void Form1_Load(object sender, EventArgs e)
        {
            panel1.Enabled = false;
        }

        //Function Button: Crop, Save
        private void button1_Click(object sender, EventArgs e)
        {

            if (this.radioButton1.Checked || this.radioButton2.Checked)
            {
                Screenshoot screenShootForm = new Screenshoot();
                this.Opacity = 0;
                getWorkingScreenshoot();
                screenShootForm.Show();

            }
            else if (this.radioButton3.Checked)
            {
                byte[] fileArray = File.ReadAllBytes(pathToTheFile);
                Upload upload = new Upload();
                upload.UploadImageWithPost(fileArray);
            }

            //System.Windows.Forms.Application.Exit();

        }

        private void radioButton1_Click(object sender, EventArgs e)
        {
            panel1.Enabled = false;
            this.button1.Enabled = true;
            this.button1.Text = "Crop";
        }

        private void radioButton2_Click(object sender, EventArgs e)
        {
            panel1.Enabled = true;
            this.button1.Text = "Crop";
            this.button1.Enabled = false;
        }

        private void radioButton3_Click(object sender, EventArgs e)
        {
            panel1.Enabled = true;
            this.button1.Text = "Upload";
            this.button1.Enabled = false;
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            this.textBox1.Clear();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (this.radioButton2.Checked)
            {
                if (folderBrowserDialog1.ShowDialog() == DialogResult.OK)
                {
                    textBox1.Text = folderBrowserDialog1.SelectedPath;
                    destinationForCropedImage = textBox1.Text;
                }
            }
            else if (this.radioButton3.Checked)
            {
                if (openFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    textBox1.Text = openFileDialog1.FileName;
                    pathToTheFile = textBox1.Text;
                }
            }

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(this.textBox1.Text))
                this.button1.Enabled = true;
        }


        public bool getRadioCheck2()
        {
            return this.radioButton2.Checked;
        }

    }


}
