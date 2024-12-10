namespace Tyuiu.BabaiKV.Sprint6.Task6.V15
{
    partial class FormMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            panel1 = new Panel();
            buttonDone_BKV = new Button();
            buttonOpenFile_BKV = new Button();
            groupBoxTask_BKV = new GroupBox();
            textBoxTask_BKV = new TextBox();
            buttonHelp_BKV = new Button();
            panel2 = new Panel();
            groupBoxInPut_BKV = new GroupBox();
            textBoxInPut_BKV = new TextBox();
            panel3 = new Panel();
            groupBoxOutPut_BKV = new GroupBox();
            textBoxOutPut_BKV = new TextBox();
            splitter1 = new Splitter();
            openFileDialog_BKV = new OpenFileDialog();
            panel1.SuspendLayout();
            groupBoxTask_BKV.SuspendLayout();
            panel2.SuspendLayout();
            groupBoxInPut_BKV.SuspendLayout();
            panel3.SuspendLayout();
            groupBoxOutPut_BKV.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(buttonDone_BKV);
            panel1.Controls.Add(buttonOpenFile_BKV);
            panel1.Controls.Add(groupBoxTask_BKV);
            panel1.Controls.Add(buttonHelp_BKV);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(800, 138);
            panel1.TabIndex = 0;
            // 
            // buttonDone_BKV
            // 
            buttonDone_BKV.BackColor = Color.YellowGreen;
            buttonDone_BKV.BackgroundImageLayout = ImageLayout.None;
            buttonDone_BKV.Image = Properties.Resources.folder_brick;
            buttonDone_BKV.Location = new Point(96, 3);
            buttonDone_BKV.Name = "buttonDone_BKV";
            buttonDone_BKV.Size = new Size(68, 60);
            buttonDone_BKV.TabIndex = 3;
            buttonDone_BKV.UseVisualStyleBackColor = false;
            buttonDone_BKV.Click += buttonDone_BKV_Click;
            // 
            // buttonOpenFile_BKV
            // 
            buttonOpenFile_BKV.Image = (Image)resources.GetObject("buttonOpenFile_BKV.Image");
            buttonOpenFile_BKV.Location = new Point(10, 3);
            buttonOpenFile_BKV.Name = "buttonOpenFile_BKV";
            buttonOpenFile_BKV.Size = new Size(63, 60);
            buttonOpenFile_BKV.TabIndex = 2;
            buttonOpenFile_BKV.UseVisualStyleBackColor = true;
            buttonOpenFile_BKV.Click += buttonOpenFile_BKV_Click;
            // 
            // groupBoxTask_BKV
            // 
            groupBoxTask_BKV.Controls.Add(textBoxTask_BKV);
            groupBoxTask_BKV.Location = new Point(3, 64);
            groupBoxTask_BKV.Name = "groupBoxTask_BKV";
            groupBoxTask_BKV.Size = new Size(794, 68);
            groupBoxTask_BKV.TabIndex = 1;
            groupBoxTask_BKV.TabStop = false;
            groupBoxTask_BKV.Text = "Условие";
            // 
            // textBoxTask_BKV
            // 
            textBoxTask_BKV.Location = new Point(6, 17);
            textBoxTask_BKV.Multiline = true;
            textBoxTask_BKV.Name = "textBoxTask_BKV";
            textBoxTask_BKV.Size = new Size(779, 45);
            textBoxTask_BKV.TabIndex = 0;
            textBoxTask_BKV.Text = resources.GetString("textBoxTask_BKV.Text");
            // 
            // buttonHelp_BKV
            // 
            buttonHelp_BKV.Image = Properties.Resources.report_user;
            buttonHelp_BKV.Location = new Point(718, 3);
            buttonHelp_BKV.Name = "buttonHelp_BKV";
            buttonHelp_BKV.Size = new Size(70, 72);
            buttonHelp_BKV.TabIndex = 0;
            buttonHelp_BKV.UseVisualStyleBackColor = true;
            buttonHelp_BKV.Click += buttonHelp_BKV_Click;
            // 
            // panel2
            // 
            panel2.Controls.Add(groupBoxInPut_BKV);
            panel2.Dock = DockStyle.Left;
            panel2.Location = new Point(0, 138);
            panel2.Name = "panel2";
            panel2.Size = new Size(377, 312);
            panel2.TabIndex = 1;
            // 
            // groupBoxInPut_BKV
            // 
            groupBoxInPut_BKV.Controls.Add(textBoxInPut_BKV);
            groupBoxInPut_BKV.Location = new Point(9, 6);
            groupBoxInPut_BKV.Name = "groupBoxInPut_BKV";
            groupBoxInPut_BKV.Size = new Size(365, 303);
            groupBoxInPut_BKV.TabIndex = 0;
            groupBoxInPut_BKV.TabStop = false;
            groupBoxInPut_BKV.Text = "Ввод";
            // 
            // textBoxInPut_BKV
            // 
            textBoxInPut_BKV.Location = new Point(6, 22);
            textBoxInPut_BKV.Multiline = true;
            textBoxInPut_BKV.Name = "textBoxInPut_BKV";
            textBoxInPut_BKV.ScrollBars = ScrollBars.Vertical;
            textBoxInPut_BKV.Size = new Size(352, 272);
            textBoxInPut_BKV.TabIndex = 0;
            // 
            // panel3
            // 
            panel3.Controls.Add(groupBoxOutPut_BKV);
            panel3.Controls.Add(splitter1);
            panel3.Dock = DockStyle.Fill;
            panel3.Location = new Point(377, 138);
            panel3.Name = "panel3";
            panel3.Size = new Size(423, 312);
            panel3.TabIndex = 2;
            // 
            // groupBoxOutPut_BKV
            // 
            groupBoxOutPut_BKV.Controls.Add(textBoxOutPut_BKV);
            groupBoxOutPut_BKV.Location = new Point(15, 6);
            groupBoxOutPut_BKV.Name = "groupBoxOutPut_BKV";
            groupBoxOutPut_BKV.Size = new Size(405, 303);
            groupBoxOutPut_BKV.TabIndex = 1;
            groupBoxOutPut_BKV.TabStop = false;
            groupBoxOutPut_BKV.Text = "Вывод";
            // 
            // textBoxOutPut_BKV
            // 
            textBoxOutPut_BKV.Location = new Point(8, 23);
            textBoxOutPut_BKV.Multiline = true;
            textBoxOutPut_BKV.Name = "textBoxOutPut_BKV";
            textBoxOutPut_BKV.ScrollBars = ScrollBars.Vertical;
            textBoxOutPut_BKV.Size = new Size(389, 273);
            textBoxOutPut_BKV.TabIndex = 0;
            // 
            // splitter1
            // 
            splitter1.Location = new Point(0, 0);
            splitter1.Name = "splitter1";
            splitter1.Size = new Size(3, 312);
            splitter1.TabIndex = 0;
            splitter1.TabStop = false;
            // 
            // openFileDialog_BKV
            // 
            openFileDialog_BKV.FileName = "openFileDialog1";
            // 
            // FormMain
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(panel1);
            MinimumSize = new Size(816, 489);
            Name = "FormMain";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Спринт 6| Таск 6| Вариант 15| Бабай К.В.";
            panel1.ResumeLayout(false);
            groupBoxTask_BKV.ResumeLayout(false);
            groupBoxTask_BKV.PerformLayout();
            panel2.ResumeLayout(false);
            groupBoxInPut_BKV.ResumeLayout(false);
            groupBoxInPut_BKV.PerformLayout();
            panel3.ResumeLayout(false);
            groupBoxOutPut_BKV.ResumeLayout(false);
            groupBoxOutPut_BKV.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private Panel panel3;
        private Splitter splitter1;
        private Button buttonHelp_BKV;
        private GroupBox groupBoxTask_BKV;
        private Button buttonOpenFile_BKV;
        private TextBox textBoxTask_BKV;
        private Button buttonDone_BKV;
        private OpenFileDialog openFileDialog_BKV;
        private GroupBox groupBoxInPut_BKV;
        private TextBox textBoxInPut_BKV;
        private GroupBox groupBoxOutPut_BKV;
        private TextBox textBoxOutPut_BKV;
    }
}
