namespace Tyuiu.BabaiKV.Sprint6.Task2.V13
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            groupBoxTask_BKV = new GroupBox();
            textBoxText_BKV = new TextBox();
            groupBoxTasky_BKV = new GroupBox();
            buttonDone_BKV = new Button();
            buttonHelp_BKV = new Button();
            textBoxEnd_BKV = new TextBox();
            textBoxBeg_BKV = new TextBox();
            textBoxStop_BKV = new TextBox();
            textBoxStart_BKV = new TextBox();
            groupBoxResults_BKV = new GroupBox();
            chartFunction_BKV = new System.Windows.Forms.DataVisualization.Charting.Chart();
            dataGridViewFunction_BKV = new DataGridView();
            X = new DataGridViewTextBoxColumn();
            Y = new DataGridViewTextBoxColumn();
            groupBoxTask_BKV.SuspendLayout();
            groupBoxTasky_BKV.SuspendLayout();
            groupBoxResults_BKV.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)chartFunction_BKV).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewFunction_BKV).BeginInit();
            SuspendLayout();
            // 
            // groupBoxTask_BKV
            // 
            groupBoxTask_BKV.Controls.Add(textBoxText_BKV);
            groupBoxTask_BKV.Location = new Point(12, 12);
            groupBoxTask_BKV.Name = "groupBoxTask_BKV";
            groupBoxTask_BKV.Size = new Size(491, 278);
            groupBoxTask_BKV.TabIndex = 0;
            groupBoxTask_BKV.TabStop = false;
            groupBoxTask_BKV.Text = "Условие";
            // 
            // textBoxText_BKV
            // 
            textBoxText_BKV.BackColor = SystemColors.MenuBar;
            textBoxText_BKV.Location = new Point(6, 22);
            textBoxText_BKV.Name = "textBoxText_BKV";
            textBoxText_BKV.ReadOnly = true;
            textBoxText_BKV.Size = new Size(470, 23);
            textBoxText_BKV.TabIndex = 0;
            textBoxText_BKV.Text = "Написать программу, которая выводит таблицу на заданном промежутке:";
            // 
            // groupBoxTasky_BKV
            // 
            groupBoxTasky_BKV.Controls.Add(buttonDone_BKV);
            groupBoxTasky_BKV.Controls.Add(buttonHelp_BKV);
            groupBoxTasky_BKV.Controls.Add(textBoxEnd_BKV);
            groupBoxTasky_BKV.Controls.Add(textBoxBeg_BKV);
            groupBoxTasky_BKV.Controls.Add(textBoxStop_BKV);
            groupBoxTasky_BKV.Controls.Add(textBoxStart_BKV);
            groupBoxTasky_BKV.Location = new Point(12, 296);
            groupBoxTasky_BKV.Name = "groupBoxTasky_BKV";
            groupBoxTasky_BKV.Size = new Size(491, 142);
            groupBoxTasky_BKV.TabIndex = 1;
            groupBoxTasky_BKV.TabStop = false;
            groupBoxTasky_BKV.Text = "Ввод Данных";
            // 
            // buttonDone_BKV
            // 
            buttonDone_BKV.BackColor = Color.LightGreen;
            buttonDone_BKV.Location = new Point(369, 69);
            buttonDone_BKV.Name = "buttonDone_BKV";
            buttonDone_BKV.Size = new Size(116, 67);
            buttonDone_BKV.TabIndex = 5;
            buttonDone_BKV.Tag = "Выполнить";
            buttonDone_BKV.Text = "Выполнить";
            buttonDone_BKV.UseVisualStyleBackColor = false;
            buttonDone_BKV.Click += buttonDone_BKV_Click;
            // 
            // buttonHelp_BKV
            // 
            buttonHelp_BKV.BackColor = SystemColors.ActiveCaption;
            buttonHelp_BKV.Location = new Point(264, 83);
            buttonHelp_BKV.Name = "buttonHelp_BKV";
            buttonHelp_BKV.Size = new Size(99, 53);
            buttonHelp_BKV.TabIndex = 4;
            buttonHelp_BKV.Text = "Справка";
            buttonHelp_BKV.UseVisualStyleBackColor = false;
            buttonHelp_BKV.Click += buttonHelp_BKV_Click_1;
            // 
            // textBoxEnd_BKV
            // 
            textBoxEnd_BKV.Location = new Point(135, 84);
            textBoxEnd_BKV.Name = "textBoxEnd_BKV";
            textBoxEnd_BKV.Size = new Size(123, 23);
            textBoxEnd_BKV.TabIndex = 3;
            textBoxEnd_BKV.Text = "Конец шага:";
            // 
            // textBoxBeg_BKV
            // 
            textBoxBeg_BKV.Location = new Point(6, 84);
            textBoxBeg_BKV.Name = "textBoxBeg_BKV";
            textBoxBeg_BKV.Size = new Size(123, 23);
            textBoxBeg_BKV.TabIndex = 2;
            textBoxBeg_BKV.Text = "Старт шага:";
            // 
            // textBoxStop_BKV
            // 
            textBoxStop_BKV.Location = new Point(135, 113);
            textBoxStop_BKV.Name = "textBoxStop_BKV";
            textBoxStop_BKV.Size = new Size(123, 23);
            textBoxStop_BKV.TabIndex = 1;
            // 
            // textBoxStart_BKV
            // 
            textBoxStart_BKV.Location = new Point(6, 113);
            textBoxStart_BKV.Name = "textBoxStart_BKV";
            textBoxStart_BKV.Size = new Size(123, 23);
            textBoxStart_BKV.TabIndex = 0;
            // 
            // groupBoxResults_BKV
            // 
            groupBoxResults_BKV.Controls.Add(chartFunction_BKV);
            groupBoxResults_BKV.Controls.Add(dataGridViewFunction_BKV);
            groupBoxResults_BKV.Location = new Point(522, 12);
            groupBoxResults_BKV.Name = "groupBoxResults_BKV";
            groupBoxResults_BKV.Size = new Size(697, 430);
            groupBoxResults_BKV.TabIndex = 2;
            groupBoxResults_BKV.TabStop = false;
            groupBoxResults_BKV.Text = "Вывод Данных";
            // 
            // chartFunction_BKV
            // 
            chartArea1.Name = "ChartArea1";
            chartFunction_BKV.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            chartFunction_BKV.Legends.Add(legend1);
            chartFunction_BKV.Location = new Point(184, 19);
            chartFunction_BKV.Name = "chartFunction_BKV";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series1.IsVisibleInLegend = false;
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            chartFunction_BKV.Series.Add(series1);
            chartFunction_BKV.Size = new Size(507, 408);
            chartFunction_BKV.TabIndex = 1;
            chartFunction_BKV.Text = "chart1";
            // 
            // dataGridViewFunction_BKV
            // 
            dataGridViewFunction_BKV.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewFunction_BKV.Columns.AddRange(new DataGridViewColumn[] { X, Y });
            dataGridViewFunction_BKV.Location = new Point(3, 19);
            dataGridViewFunction_BKV.Name = "dataGridViewFunction_BKV";
            dataGridViewFunction_BKV.RowHeadersVisible = false;
            dataGridViewFunction_BKV.Size = new Size(165, 405);
            dataGridViewFunction_BKV.TabIndex = 0;
            // 
            // X
            // 
            X.HeaderText = "X";
            X.Name = "X";
            X.Width = 50;
            // 
            // Y
            // 
            Y.HeaderText = "F(X)";
            Y.Name = "Y";
            Y.Width = 50;
            // 
            // FormMain
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1231, 450);
            Controls.Add(groupBoxResults_BKV);
            Controls.Add(groupBoxTasky_BKV);
            Controls.Add(groupBoxTask_BKV);
            Name = "FormMain";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Спринт 6 | Таск 2 | Вариант 13 | Бабай К.В.";
            groupBoxTask_BKV.ResumeLayout(false);
            groupBoxTask_BKV.PerformLayout();
            groupBoxTasky_BKV.ResumeLayout(false);
            groupBoxTasky_BKV.PerformLayout();
            groupBoxResults_BKV.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)chartFunction_BKV).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewFunction_BKV).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private GroupBox groupBoxTask_BKV;
        private TextBox textBoxText_BKV;
        private GroupBox groupBoxTasky_BKV;
        private GroupBox groupBoxResults_BKV;
        private TextBox textBoxStart_BKV;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartFunction_BKV;
        private DataGridView dataGridViewFunction_BKV;
        private DataGridViewTextBoxColumn X;
        private DataGridViewTextBoxColumn Y;
        private TextBox textBoxBeg_BKV;
        private TextBox textBoxStop_BKV;
        private Button buttonDone_BKV;
        private Button buttonHelp_BKV;
        private TextBox textBoxEnd_BKV;
    }
}
