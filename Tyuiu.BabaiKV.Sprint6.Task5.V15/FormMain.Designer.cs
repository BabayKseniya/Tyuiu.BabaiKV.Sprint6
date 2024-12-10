namespace Tyuiu.BabaiKV.Sprint6.Task5.V15
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            panel1 = new Panel();
            buttonHelp_BKV = new Button();
            buttonOpenFille_BKV = new Button();
            buttonDone_BKV = new Button();
            groupBoxTask_BKV = new GroupBox();
            textBoxTask_BKV = new TextBox();
            panel2 = new Panel();
            groupBoxResults_BKV = new GroupBox();
            dataGridViewResults_BKV = new DataGridView();
            panel3 = new Panel();
            chartData_BKV = new System.Windows.Forms.DataVisualization.Charting.Chart();
            splitter1 = new Splitter();
            panel1.SuspendLayout();
            groupBoxTask_BKV.SuspendLayout();
            panel2.SuspendLayout();
            groupBoxResults_BKV.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewResults_BKV).BeginInit();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)chartData_BKV).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(buttonHelp_BKV);
            panel1.Controls.Add(buttonOpenFille_BKV);
            panel1.Controls.Add(buttonDone_BKV);
            panel1.Controls.Add(groupBoxTask_BKV);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(934, 87);
            panel1.TabIndex = 0;
            // 
            // buttonHelp_BKV
            // 
            buttonHelp_BKV.BackColor = Color.SkyBlue;
            buttonHelp_BKV.Location = new Point(831, 12);
            buttonHelp_BKV.Name = "buttonHelp_BKV";
            buttonHelp_BKV.Size = new Size(91, 59);
            buttonHelp_BKV.TabIndex = 3;
            buttonHelp_BKV.Text = "?";
            buttonHelp_BKV.UseVisualStyleBackColor = false;
            buttonHelp_BKV.Click += buttonHelp_BKV_Click;
            // 
            // buttonOpenFille_BKV
            // 
            buttonOpenFille_BKV.BackColor = Color.ForestGreen;
            buttonOpenFille_BKV.Location = new Point(651, 12);
            buttonOpenFille_BKV.Name = "buttonOpenFille_BKV";
            buttonOpenFille_BKV.Size = new Size(102, 59);
            buttonOpenFille_BKV.TabIndex = 2;
            buttonOpenFille_BKV.Text = "Файл";
            buttonOpenFille_BKV.UseVisualStyleBackColor = false;
            buttonOpenFille_BKV.Click += buttonOpenFille_BKV_Click;
            // 
            // buttonDone_BKV
            // 
            buttonDone_BKV.BackColor = Color.YellowGreen;
            buttonDone_BKV.Location = new Point(545, 12);
            buttonDone_BKV.Name = "buttonDone_BKV";
            buttonDone_BKV.Size = new Size(100, 63);
            buttonDone_BKV.TabIndex = 1;
            buttonDone_BKV.Text = "Выполнить";
            buttonDone_BKV.UseVisualStyleBackColor = false;
            buttonDone_BKV.Click += buttonDone_BKV_Click;
            // 
            // groupBoxTask_BKV
            // 
            groupBoxTask_BKV.Controls.Add(textBoxTask_BKV);
            groupBoxTask_BKV.Location = new Point(12, 4);
            groupBoxTask_BKV.Name = "groupBoxTask_BKV";
            groupBoxTask_BKV.Size = new Size(484, 81);
            groupBoxTask_BKV.TabIndex = 0;
            groupBoxTask_BKV.TabStop = false;
            groupBoxTask_BKV.Text = "Условие";
            // 
            // textBoxTask_BKV
            // 
            textBoxTask_BKV.Location = new Point(0, 22);
            textBoxTask_BKV.Multiline = true;
            textBoxTask_BKV.Name = "textBoxTask_BKV";
            textBoxTask_BKV.ReadOnly = true;
            textBoxTask_BKV.Size = new Size(472, 53);
            textBoxTask_BKV.TabIndex = 0;
            textBoxTask_BKV.Text = "Прочитать данные из файла InPutFileTask5V15.txt. Вывести в dataGridView.Вывести все числа от 2 до 7. Построить диаграмму по этим значениям. ";
            // 
            // panel2
            // 
            panel2.Controls.Add(groupBoxResults_BKV);
            panel2.Dock = DockStyle.Left;
            panel2.Location = new Point(0, 87);
            panel2.Name = "panel2";
            panel2.Size = new Size(200, 363);
            panel2.TabIndex = 1;
            // 
            // groupBoxResults_BKV
            // 
            groupBoxResults_BKV.Controls.Add(dataGridViewResults_BKV);
            groupBoxResults_BKV.Location = new Point(12, 15);
            groupBoxResults_BKV.Name = "groupBoxResults_BKV";
            groupBoxResults_BKV.Size = new Size(182, 336);
            groupBoxResults_BKV.TabIndex = 0;
            groupBoxResults_BKV.TabStop = false;
            groupBoxResults_BKV.Text = "Вывод данных";
            // 
            // dataGridViewResults_BKV
            // 
            dataGridViewResults_BKV.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewResults_BKV.Location = new Point(6, 22);
            dataGridViewResults_BKV.Name = "dataGridViewResults_BKV";
            dataGridViewResults_BKV.ScrollBars = ScrollBars.Vertical;
            dataGridViewResults_BKV.Size = new Size(170, 308);
            dataGridViewResults_BKV.TabIndex = 0;
            // 
            // panel3
            // 
            panel3.Controls.Add(chartData_BKV);
            panel3.Dock = DockStyle.Fill;
            panel3.Location = new Point(200, 87);
            panel3.Name = "panel3";
            panel3.Size = new Size(734, 363);
            panel3.TabIndex = 2;
            // 
            // chartData_BKV
            // 
            chartArea2.Name = "ChartArea1";
            chartData_BKV.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            chartData_BKV.Legends.Add(legend2);
            chartData_BKV.Location = new Point(9, 15);
            chartData_BKV.Name = "chartData_BKV";
            series2.ChartArea = "ChartArea1";
            series2.Legend = "Legend1";
            series2.Name = "Series1";
            chartData_BKV.Series.Add(series2);
            chartData_BKV.Size = new Size(713, 336);
            chartData_BKV.TabIndex = 0;
            chartData_BKV.Text = "chart1";
            // 
            // splitter1
            // 
            splitter1.Location = new Point(200, 87);
            splitter1.Name = "splitter1";
            splitter1.Size = new Size(3, 363);
            splitter1.TabIndex = 0;
            splitter1.TabStop = false;
            // 
            // FormMain
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(934, 450);
            Controls.Add(splitter1);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(panel1);
            MinimumSize = new Size(950, 489);
            Name = "FormMain";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Спринт 6 |Таск 5| Вариант 15| Бабай К.В.";
            Load += FormMain_Load;
            panel1.ResumeLayout(false);
            groupBoxTask_BKV.ResumeLayout(false);
            groupBoxTask_BKV.PerformLayout();
            panel2.ResumeLayout(false);
            groupBoxResults_BKV.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridViewResults_BKV).EndInit();
            panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)chartData_BKV).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private Panel panel3;
        private GroupBox groupBoxTask_BKV;
        private TextBox textBoxTask_BKV;
        private Splitter splitter1;
        private GroupBox groupBoxResults_BKV;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartData_BKV;
        private Button buttonHelp_BKV;
        private Button buttonOpenFille_BKV;
        private Button buttonDone_BKV;
        private DataGridView dataGridViewResults_BKV;
    }
}
