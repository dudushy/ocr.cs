namespace OCR
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.buttonSelectFile = new System.Windows.Forms.Button();
            this.labelFilename = new System.Windows.Forms.Label();
            this.textBoxOutput = new System.Windows.Forms.TextBox();
            this.buttonRun = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonSelectFile
            // 
            this.buttonSelectFile.FlatAppearance.BorderColor = System.Drawing.Color.Lime;
            this.buttonSelectFile.FlatAppearance.BorderSize = 2;
            this.buttonSelectFile.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSelectFile.Location = new System.Drawing.Point(12, 12);
            this.buttonSelectFile.Name = "buttonSelectFile";
            this.buttonSelectFile.Size = new System.Drawing.Size(142, 160);
            this.buttonSelectFile.TabIndex = 0;
            this.buttonSelectFile.Text = "Select file";
            this.buttonSelectFile.UseVisualStyleBackColor = true;
            this.buttonSelectFile.Click += new System.EventHandler(this.buttonSelectFile_Click);
            // 
            // labelFilename
            // 
            this.labelFilename.AutoEllipsis = true;
            this.labelFilename.AutoSize = true;
            this.labelFilename.Location = new System.Drawing.Point(328, 12);
            this.labelFilename.Name = "labelFilename";
            this.labelFilename.Size = new System.Drawing.Size(104, 17);
            this.labelFilename.TabIndex = 1;
            this.labelFilename.Text = "Filename: --";
            // 
            // textBoxOutput
            // 
            this.textBoxOutput.BackColor = System.Drawing.Color.Black;
            this.textBoxOutput.ForeColor = System.Drawing.Color.Lime;
            this.textBoxOutput.Location = new System.Drawing.Point(12, 178);
            this.textBoxOutput.Multiline = true;
            this.textBoxOutput.Name = "textBoxOutput";
            this.textBoxOutput.Size = new System.Drawing.Size(890, 320);
            this.textBoxOutput.TabIndex = 2;
            this.textBoxOutput.Text = "output";
            // 
            // buttonRun
            // 
            this.buttonRun.BackColor = System.Drawing.Color.Lime;
            this.buttonRun.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.buttonRun.FlatAppearance.BorderSize = 5;
            this.buttonRun.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonRun.Font = new System.Drawing.Font("Cascadia Mono", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonRun.ForeColor = System.Drawing.Color.Black;
            this.buttonRun.Location = new System.Drawing.Point(777, 12);
            this.buttonRun.Name = "buttonRun";
            this.buttonRun.Size = new System.Drawing.Size(125, 160);
            this.buttonRun.TabIndex = 3;
            this.buttonRun.Text = "RUN";
            this.buttonRun.UseVisualStyleBackColor = false;
            this.buttonRun.Click += new System.EventHandler(this.buttonRun_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox1.Image = global::OCR.Properties.Resources.block;
            this.pictureBox1.Location = new System.Drawing.Point(160, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(162, 160);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.DefaultExt = "png, jpeg, jpg";
            this.openFileDialog1.FileName = "openFileDialog1";
            this.openFileDialog1.Title = "Select a image";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(914, 510);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.buttonRun);
            this.Controls.Add(this.textBoxOutput);
            this.Controls.Add(this.labelFilename);
            this.Controls.Add(this.buttonSelectFile);
            this.Font = new System.Drawing.Font("Cascadia Mono", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ForeColor = System.Drawing.Color.Lime;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "OCR";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button buttonSelectFile;
        private Label labelFilename;
        private TextBox textBoxOutput;
        private Button buttonRun;
        private PictureBox pictureBox1;
        private OpenFileDialog openFileDialog1;
    }
}