namespace Tyuiu.BabaiKV.Sprint6.Task3.V20
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
            dataGridViewMtrx_BKV = new DataGridView();
            textBoxData_BKV = new TextBox();
            groupBoxResults_BKV = new GroupBox();
            dataGridViewResultMatrix = new DataGridView();
            buttonDone_BKV = new Button();
            buttonHelp_BKV = new Button();
            text1 = new TextBox();
            groupBoxTask_BKV.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewMtrx_BKV).BeginInit();
            groupBoxResults_BKV.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewResultMatrix).BeginInit();
            SuspendLayout();
            // 
            // groupBoxTask_BKV
            // 
            groupBoxTask_BKV.Controls.Add(dataGridViewMtrx_BKV);
            groupBoxTask_BKV.Controls.Add(textBoxData_BKV);
            groupBoxTask_BKV.Location = new Point(12, 12);
            groupBoxTask_BKV.Name = "groupBoxTask_BKV";
            groupBoxTask_BKV.Size = new Size(718, 438);
            groupBoxTask_BKV.TabIndex = 0;
            groupBoxTask_BKV.TabStop = false;
            groupBoxTask_BKV.Text = "Условие";
            // 
            // dataGridViewMtrx_BKV
            // 
            dataGridViewMtrx_BKV.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewMtrx_BKV.Location = new Point(493, 30);
            dataGridViewMtrx_BKV.Name = "dataGridViewMtrx_BKV";
            dataGridViewMtrx_BKV.RowHeadersVisible = false;
            dataGridViewMtrx_BKV.Size = new Size(223, 404);
            dataGridViewMtrx_BKV.TabIndex = 1;
            // 
            // textBoxData_BKV
            // 
            textBoxData_BKV.Location = new Point(6, 31);
            textBoxData_BKV.Multiline = true;
            textBoxData_BKV.Name = "textBoxData_BKV";
            textBoxData_BKV.ReadOnly = true;
            textBoxData_BKV.Size = new Size(481, 401);
            textBoxData_BKV.TabIndex = 0;
            textBoxData_BKV.Text = "Дана матрица 5 на 5\r\n-14  17 -19   3   2\r\n  -4 -14 -19  -9 -1\r\n   1   0  13  14   8\r\n  13   7   8  -3 -15\r\n   2 -20  12 -14   4\r\n\r\n Заменить четные значения в пятой строке на 0.";
            // 
            // groupBoxResults_BKV
            // 
            groupBoxResults_BKV.Controls.Add(dataGridViewResultMatrix);
            groupBoxResults_BKV.Controls.Add(buttonDone_BKV);
            groupBoxResults_BKV.Controls.Add(buttonHelp_BKV);
            groupBoxResults_BKV.Controls.Add(text1);
            groupBoxResults_BKV.Location = new Point(736, 12);
            groupBoxResults_BKV.Name = "groupBoxResults_BKV";
            groupBoxResults_BKV.Size = new Size(251, 432);
            groupBoxResults_BKV.TabIndex = 1;
            groupBoxResults_BKV.TabStop = false;
            groupBoxResults_BKV.Text = "Вывод данных";
            // 
            // dataGridViewResultMatrix
            // 
            dataGridViewResultMatrix.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewResultMatrix.EnableHeadersVisualStyles = false;
            dataGridViewResultMatrix.Location = new Point(15, 61);
            dataGridViewResultMatrix.Name = "dataGridViewResultMatrix";
            dataGridViewResultMatrix.Size = new Size(209, 175);
            dataGridViewResultMatrix.TabIndex = 4;
            // 
            // buttonDone_BKV
            // 
            buttonDone_BKV.Location = new Point(86, 365);
            buttonDone_BKV.Name = "buttonDone_BKV";
            buttonDone_BKV.Size = new Size(136, 51);
            buttonDone_BKV.TabIndex = 3;
            buttonDone_BKV.Text = "Выполнить";
            buttonDone_BKV.UseVisualStyleBackColor = true;
            buttonDone_BKV.Click += buttonDone_BKV_Click;
            // 
            // buttonHelp_BKV
            // 
            buttonHelp_BKV.Location = new Point(21, 365);
            buttonHelp_BKV.Name = "buttonHelp_BKV";
            buttonHelp_BKV.Size = new Size(59, 51);
            buttonHelp_BKV.TabIndex = 2;
            buttonHelp_BKV.Text = "?";
            buttonHelp_BKV.UseVisualStyleBackColor = true;
            buttonHelp_BKV.Click += buttonHelp_BKV_Click;
            // 
            // text1
            // 
            text1.BackColor = SystemColors.ButtonFace;
            text1.Location = new Point(11, 31);
            text1.Multiline = true;
            text1.Name = "text1";
            text1.ReadOnly = true;
            text1.Size = new Size(213, 24);
            text1.TabIndex = 1;
            text1.Text = "Результат:";
            // 
            // FormMain
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1003, 450);
            Controls.Add(groupBoxResults_BKV);
            Controls.Add(groupBoxTask_BKV);
            MaximizeBox = false;
            Name = "FormMain";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Спринт 6|Таск 3 | Вариант 20| Бабай К.В.";
            Load += FormMain_Load;
            groupBoxTask_BKV.ResumeLayout(false);
            groupBoxTask_BKV.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewMtrx_BKV).EndInit();
            groupBoxResults_BKV.ResumeLayout(false);
            groupBoxResults_BKV.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewResultMatrix).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBoxTask_BKV;
        private TextBox textBoxData_BKV;
        private GroupBox groupBoxResults_BKV;
        private DataGridView dataGridViewMtrx_BKV;
        private Button buttonHelp_BKV;
        private TextBox text1;
        private Button buttonDone_BKV;
        private DataGridView dataGridViewResultMatrix;
    }
}
