namespace SnippTool
{
    partial class SnipForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SnipForm));
            this.button1 = new System.Windows.Forms.Button();
            this.CropAndUpload = new System.Windows.Forms.RadioButton();
            this.CropAndSaveToComputer = new System.Windows.Forms.RadioButton();
            this.UploadMyImage = new System.Windows.Forms.RadioButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.BrowseBtn = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.folderBrowserDialog = new System.Windows.Forms.FolderBrowserDialog();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(24, 167);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(142, 40);
            this.button1.TabIndex = 0;
            this.button1.Text = "Crop";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // radioButton1
            // 
            this.CropAndUpload.AutoSize = true;
            this.CropAndUpload.Checked = true;
            this.CropAndUpload.Location = new System.Drawing.Point(24, 12);
            this.CropAndUpload.Name = "radioButton1";
            this.CropAndUpload.Size = new System.Drawing.Size(139, 24);
            this.CropAndUpload.TabIndex = 2;
            this.CropAndUpload.TabStop = true;
            this.CropAndUpload.Text = "Crop And Upload";
            this.CropAndUpload.UseVisualStyleBackColor = true;
            this.CropAndUpload.Click += new System.EventHandler(this.radioButton1_Click);
            // 
            // radioButton2
            // 
            this.CropAndSaveToComputer.AutoSize = true;
            this.CropAndSaveToComputer.Location = new System.Drawing.Point(24, 42);
            this.CropAndSaveToComputer.Name = "radioButton2";
            this.CropAndSaveToComputer.Size = new System.Drawing.Size(217, 24);
            this.CropAndSaveToComputer.TabIndex = 3;
            this.CropAndSaveToComputer.Text = "Crop And Save To Computer";
            this.CropAndSaveToComputer.UseVisualStyleBackColor = true;
            this.CropAndSaveToComputer.Click += new System.EventHandler(this.radioButton2_Click);
            // 
            // radioButton3
            // 
            this.UploadMyImage.AutoSize = true;
            this.UploadMyImage.Location = new System.Drawing.Point(24, 72);
            this.UploadMyImage.Name = "radioButton3";
            this.UploadMyImage.Size = new System.Drawing.Size(142, 24);
            this.UploadMyImage.TabIndex = 4;
            this.UploadMyImage.Text = "Upload My Image";
            this.UploadMyImage.UseVisualStyleBackColor = true;
            this.UploadMyImage.CheckedChanged += new System.EventHandler(this.radioButton3_CheckedChanged);
            this.UploadMyImage.Click += new System.EventHandler(this.radioButton3_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.BrowseBtn);
            this.panel1.Controls.Add(this.textBox1);
            this.panel1.ForeColor = System.Drawing.Color.White;
            this.panel1.Location = new System.Drawing.Point(12, 102);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(386, 67);
            this.panel1.TabIndex = 5;
            // 
            // button3
            // 
            this.BrowseBtn.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.BrowseBtn.Location = new System.Drawing.Point(285, 16);
            this.BrowseBtn.Name = "button3";
            this.BrowseBtn.Size = new System.Drawing.Size(89, 34);
            this.BrowseBtn.TabIndex = 1;
            this.BrowseBtn.Text = "Browse";
            this.BrowseBtn.UseVisualStyleBackColor = false;
            this.BrowseBtn.Click += new System.EventHandler(this.button3_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(12, 20);
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(258, 28);
            this.textBox1.TabIndex = 0;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightBlue;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(411, 222);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.UploadMyImage);
            this.Controls.Add(this.CropAndSaveToComputer);
            this.Controls.Add(this.CropAndUpload);
            this.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.Font = new System.Drawing.Font("Arial Unicode MS", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Form1";
            this.Text = "Snipp Web Tool";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.RadioButton CropAndUpload;
        private System.Windows.Forms.RadioButton CropAndSaveToComputer;
        private System.Windows.Forms.RadioButton UploadMyImage;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button BrowseBtn;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
    }
}

