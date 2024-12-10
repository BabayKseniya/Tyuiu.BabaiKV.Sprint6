namespace Tyuiu.BabaiKV.Sprint6.Task6.V15
{
    partial class FormAbout
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormAbout));
            pictureBoxAva = new PictureBox();
            panelInfo = new Panel();
            textBox1 = new TextBox();
            buttonOK_BKV = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBoxAva).BeginInit();
            panelInfo.SuspendLayout();
            SuspendLayout();
            // 
            // pictureBoxAva
            // 
            pictureBoxAva.Image = (Image)resources.GetObject("pictureBoxAva.Image");
            pictureBoxAva.ImageLocation = "";
            pictureBoxAva.InitialImage = (Image)resources.GetObject("pictureBoxAva.InitialImage");
            pictureBoxAva.Location = new Point(12, 12);
            pictureBoxAva.Name = "pictureBoxAva";
            pictureBoxAva.Size = new Size(166, 247);
            pictureBoxAva.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBoxAva.TabIndex = 0;
            pictureBoxAva.TabStop = false;
            // 
            // panelInfo
            // 
            panelInfo.Controls.Add(buttonOK_BKV);
            panelInfo.Controls.Add(textBox1);
            panelInfo.Location = new Point(184, 11);
            panelInfo.Name = "panelInfo";
            panelInfo.Size = new Size(233, 248);
            panelInfo.TabIndex = 1;
            // 
            // textBox1
            // 
            textBox1.BackColor = SystemColors.Menu;
            textBox1.Location = new Point(3, 10);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(223, 201);
            textBox1.TabIndex = 0;
            textBox1.Text = "Разработчик Бабай К.В.\r\nгруппа СМАРТб-24-1\r\n\r\nПрограмма написана на языке С#\r\nТюменский Индустриальный Университет 2024\r\nВысшая школа цифровых технологи 2024\r\nВнутреннее имя Tyuiu.Sprint6.Task6.V15";
            // 
            // buttonOK_BKV
            // 
            buttonOK_BKV.BackColor = SystemColors.AppWorkspace;
            buttonOK_BKV.Location = new Point(151, 217);
            buttonOK_BKV.Name = "buttonOK_BKV";
            buttonOK_BKV.Size = new Size(75, 23);
            buttonOK_BKV.TabIndex = 1;
            buttonOK_BKV.Text = "OK";
            buttonOK_BKV.UseVisualStyleBackColor = false;
            buttonOK_BKV.Click += buttonOK_BKV_Click;
            // 
            // FormAbout
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(422, 271);
            Controls.Add(panelInfo);
            Controls.Add(pictureBoxAva);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FormAbout";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Информация";
            ((System.ComponentModel.ISupportInitialize)pictureBoxAva).EndInit();
            panelInfo.ResumeLayout(false);
            panelInfo.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private PictureBox pictureBoxAva;
        private Panel panelInfo;
        private TextBox textBox1;
        private Button buttonOK_BKV;
    }
}