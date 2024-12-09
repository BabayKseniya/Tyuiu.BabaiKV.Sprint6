namespace Tyuiu.BabaiKV.Sprint6.Task0.V29
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
            groupBoxTask_BKV = new GroupBox();
            pictureBoxTask_BKV = new PictureBox();
            textBoxTask_BKV = new TextBox();
            groupBoxInput_BKV = new GroupBox();
            label1 = new Label();
            textBoxX_BKV = new TextBox();
            groupBoxOutput_BKV = new GroupBox();
            label4 = new Label();
            textBoxResult_BKV = new TextBox();
            buttonQuestion_BKV = new Button();
            buttonDoneResult_BKV = new Button();
            groupBoxTask_BKV.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxTask_BKV).BeginInit();
            groupBoxInput_BKV.SuspendLayout();
            groupBoxOutput_BKV.SuspendLayout();
            SuspendLayout();
            // 
            // groupBoxTask_BKV
            // 
            groupBoxTask_BKV.Controls.Add(pictureBoxTask_BKV);
            groupBoxTask_BKV.Controls.Add(textBoxTask_BKV);
            groupBoxTask_BKV.Location = new Point(12, 12);
            groupBoxTask_BKV.Name = "groupBoxTask_BKV";
            groupBoxTask_BKV.Size = new Size(706, 231);
            groupBoxTask_BKV.TabIndex = 0;
            groupBoxTask_BKV.TabStop = false;
            groupBoxTask_BKV.Text = "Условие";
            // 
            // pictureBoxTask_BKV
            // 
            pictureBoxTask_BKV.BorderStyle = BorderStyle.FixedSingle;
            pictureBoxTask_BKV.InitialImage = null;
            pictureBoxTask_BKV.Location = new Point(462, 19);
            pictureBoxTask_BKV.Name = "pictureBoxTask_BKV";
            pictureBoxTask_BKV.Size = new Size(220, 127);
            pictureBoxTask_BKV.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBoxTask_BKV.TabIndex = 1;
            pictureBoxTask_BKV.TabStop = false;
            // 
            // textBoxTask_BKV
            // 
            textBoxTask_BKV.BorderStyle = BorderStyle.None;
            textBoxTask_BKV.Location = new Point(11, 19);
            textBoxTask_BKV.Multiline = true;
            textBoxTask_BKV.Name = "textBoxTask_BKV";
            textBoxTask_BKV.ReadOnly = true;
            textBoxTask_BKV.Size = new Size(326, 127);
            textBoxTask_BKV.TabIndex = 0;
            textBoxTask_BKV.Text = "Вычислить выражение по формуле";
            // 
            // groupBoxInput_BKV
            // 
            groupBoxInput_BKV.Controls.Add(label1);
            groupBoxInput_BKV.Controls.Add(textBoxX_BKV);
            groupBoxInput_BKV.Location = new Point(12, 261);
            groupBoxInput_BKV.Name = "groupBoxInput_BKV";
            groupBoxInput_BKV.Size = new Size(426, 100);
            groupBoxInput_BKV.TabIndex = 1;
            groupBoxInput_BKV.TabStop = false;
            groupBoxInput_BKV.Text = "Ввод данных";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(22, 35);
            label1.Name = "label1";
            label1.Size = new Size(89, 15);
            label1.TabIndex = 3;
            label1.Text = "Переменная X:";
            // 
            // textBoxX_BKV
            // 
            textBoxX_BKV.Location = new Point(11, 53);
            textBoxX_BKV.Name = "textBoxX_BKV";
            textBoxX_BKV.Size = new Size(108, 23);
            textBoxX_BKV.TabIndex = 0;
            textBoxX_BKV.KeyPress += textBoxVarX_BKV_KeyPress;
            // 
            // groupBoxOutput_BKV
            // 
            groupBoxOutput_BKV.Controls.Add(label4);
            groupBoxOutput_BKV.Controls.Add(textBoxResult_BKV);
            groupBoxOutput_BKV.Location = new Point(444, 261);
            groupBoxOutput_BKV.Name = "groupBoxOutput_BKV";
            groupBoxOutput_BKV.Size = new Size(274, 100);
            groupBoxOutput_BKV.TabIndex = 2;
            groupBoxOutput_BKV.TabStop = false;
            groupBoxOutput_BKV.Text = "Вывод данных";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(6, 35);
            label4.Name = "label4";
            label4.Size = new Size(63, 15);
            label4.TabIndex = 9;
            label4.Text = "Результат:";
            // 
            // textBoxResult_BKV
            // 
            textBoxResult_BKV.Location = new Point(6, 53);
            textBoxResult_BKV.Name = "textBoxResult_BKV";
            textBoxResult_BKV.ReadOnly = true;
            textBoxResult_BKV.Size = new Size(262, 23);
            textBoxResult_BKV.TabIndex = 8;
            // 
            // buttonQuestion_BKV
            // 
            buttonQuestion_BKV.FlatStyle = FlatStyle.Flat;
            buttonQuestion_BKV.Location = new Point(450, 376);
            buttonQuestion_BKV.Name = "buttonQuestion_BKV";
            buttonQuestion_BKV.Size = new Size(63, 62);
            buttonQuestion_BKV.TabIndex = 3;
            buttonQuestion_BKV.Text = "?";
            buttonQuestion_BKV.UseVisualStyleBackColor = true;
            buttonQuestion_BKV.Click += buttonQuestion_BKV_Click;
            // 
            // buttonDoneResult_BKV
            // 
            buttonDoneResult_BKV.BackgroundImageLayout = ImageLayout.None;
            buttonDoneResult_BKV.FlatStyle = FlatStyle.System;
            buttonDoneResult_BKV.Location = new Point(530, 376);
            buttonDoneResult_BKV.Name = "buttonDoneResult_BKV";
            buttonDoneResult_BKV.Size = new Size(182, 62);
            buttonDoneResult_BKV.TabIndex = 4;
            buttonDoneResult_BKV.Text = "Выполнить";
            buttonDoneResult_BKV.UseVisualStyleBackColor = true;
            buttonDoneResult_BKV.Click += buttonDone_Click;
            // 
            // FormMain
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(730, 450);
            Controls.Add(buttonDoneResult_BKV);
            Controls.Add(buttonQuestion_BKV);
            Controls.Add(groupBoxOutput_BKV);
            Controls.Add(groupBoxInput_BKV);
            Controls.Add(groupBoxTask_BKV);
            FormBorderStyle = FormBorderStyle.Fixed3D;
            Name = "FormMain";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Спринт 6 | Таск 0 | Вариант 29 | Бабай К.В.";
            groupBoxTask_BKV.ResumeLayout(false);
            groupBoxTask_BKV.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxTask_BKV).EndInit();
            groupBoxInput_BKV.ResumeLayout(false);
            groupBoxInput_BKV.PerformLayout();
            groupBoxOutput_BKV.ResumeLayout(false);
            groupBoxOutput_BKV.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBoxTask_BKV;
        private GroupBox groupBoxInput_BKV;
        private GroupBox groupBoxOutput_BKV;
        private TextBox textBoxTask_BKV;
        private Label label1;
        private TextBox textBoxX_BKV;
        private Label label4;
        private TextBox textBoxResult_BKV;
        private Button buttonQuestion_BKV;
        private Button buttonDoneResult_BKV;
        private PictureBox pictureBoxTask_BKV;
    }
}

