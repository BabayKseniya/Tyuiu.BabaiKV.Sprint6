namespace Tyuiu.BabaiKV.Sprint6.Task1.V20
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
            textBoxTask_BKV = new TextBox();
            groupBoxResult_BKV = new GroupBox();
            labelResult_BKV = new Label();
            textBoxResult_BKV = new TextBox();
            groupBoxInput_BKV = new GroupBox();
            label2 = new Label();
            textBoxStopStep_BKV = new TextBox();
            label1 = new Label();
            textBoxStartStep_BKV = new TextBox();
            buttonDone_BKV = new Button();
            buttonHelp_BKV = new Button();
            groupBoxTask_BKV.SuspendLayout();
            groupBoxResult_BKV.SuspendLayout();
            groupBoxInput_BKV.SuspendLayout();
            SuspendLayout();
            // 
            // groupBoxTask_BKV
            // 
            groupBoxTask_BKV.Controls.Add(textBoxTask_BKV);
            groupBoxTask_BKV.Location = new Point(12, 12);
            groupBoxTask_BKV.Name = "groupBoxTask_BKV";
            groupBoxTask_BKV.Size = new Size(485, 308);
            groupBoxTask_BKV.TabIndex = 1;
            groupBoxTask_BKV.TabStop = false;
            groupBoxTask_BKV.Text = "Условие";
            // 
            // textBoxTask_BKV
            // 
            textBoxTask_BKV.BorderStyle = BorderStyle.None;
            textBoxTask_BKV.Font = new Font("Consolas", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 204);
            textBoxTask_BKV.Location = new Point(11, 19);
            textBoxTask_BKV.Multiline = true;
            textBoxTask_BKV.Name = "textBoxTask_BKV";
            textBoxTask_BKV.ReadOnly = true;
            textBoxTask_BKV.Size = new Size(468, 127);
            textBoxTask_BKV.TabIndex = 0;
            textBoxTask_BKV.Text = "Протабулировать функцию (2x-3)/(cos(x)-2x) + 5x - sin(x) на заданном диапозоне.\r\nРезультат вывести в виде таблицы.";
            // 
            // groupBoxResult_BKV
            // 
            groupBoxResult_BKV.Controls.Add(labelResult_BKV);
            groupBoxResult_BKV.Controls.Add(textBoxResult_BKV);
            groupBoxResult_BKV.Location = new Point(503, 12);
            groupBoxResult_BKV.Name = "groupBoxResult_BKV";
            groupBoxResult_BKV.Size = new Size(285, 414);
            groupBoxResult_BKV.TabIndex = 2;
            groupBoxResult_BKV.TabStop = false;
            groupBoxResult_BKV.Text = "Вывод данных";
            // 
            // labelResult_BKV
            // 
            labelResult_BKV.AutoSize = true;
            labelResult_BKV.Location = new Point(6, 23);
            labelResult_BKV.Name = "labelResult_BKV";
            labelResult_BKV.Size = new Size(63, 15);
            labelResult_BKV.TabIndex = 2;
            labelResult_BKV.Text = "Результат:";
            // 
            // textBoxResult_BKV
            // 
            textBoxResult_BKV.BorderStyle = BorderStyle.None;
            textBoxResult_BKV.Font = new Font("Consolas", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            textBoxResult_BKV.Location = new Point(6, 41);
            textBoxResult_BKV.Multiline = true;
            textBoxResult_BKV.Name = "textBoxResult_BKV";
            textBoxResult_BKV.ReadOnly = true;
            textBoxResult_BKV.ScrollBars = ScrollBars.Vertical;
            textBoxResult_BKV.Size = new Size(273, 367);
            textBoxResult_BKV.TabIndex = 1;
            // 
            // groupBoxInput_BKV
            // 
            groupBoxInput_BKV.Controls.Add(label2);
            groupBoxInput_BKV.Controls.Add(textBoxStopStep_BKV);
            groupBoxInput_BKV.Controls.Add(label1);
            groupBoxInput_BKV.Controls.Add(textBoxStartStep_BKV);
            groupBoxInput_BKV.Location = new Point(12, 326);
            groupBoxInput_BKV.Name = "groupBoxInput_BKV";
            groupBoxInput_BKV.Size = new Size(273, 100);
            groupBoxInput_BKV.TabIndex = 3;
            groupBoxInput_BKV.TabStop = false;
            groupBoxInput_BKV.Text = "Ввод данных";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(136, 35);
            label2.Name = "label2";
            label2.Size = new Size(75, 15);
            label2.TabIndex = 5;
            label2.Text = "Конец шага:";
            // 
            // textBoxStopStep_BKV
            // 
            textBoxStopStep_BKV.Location = new Point(140, 53);
            textBoxStopStep_BKV.Name = "textBoxStopStep_BKV";
            textBoxStopStep_BKV.Size = new Size(128, 23);
            textBoxStopStep_BKV.TabIndex = 4;
            textBoxStopStep_BKV.KeyPress += textBoxSteps_BKV_KeyPress;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(6, 35);
            label1.Name = "label1";
            label1.Size = new Size(72, 15);
            label1.TabIndex = 3;
            label1.Text = "Старт шага:";
            // 
            // textBoxStartStep_BKV
            // 
            textBoxStartStep_BKV.Location = new Point(6, 53);
            textBoxStartStep_BKV.Name = "textBoxStartStep_BKV";
            textBoxStartStep_BKV.Size = new Size(128, 23);
            textBoxStartStep_BKV.TabIndex = 0;
            textBoxStartStep_BKV.KeyPress += textBoxSteps_BKV_KeyPress;
            // 
            // buttonDone_BKV
            // 
            buttonDone_BKV.BackColor = Color.Green;
            buttonDone_BKV.Location = new Point(363, 337);
            buttonDone_BKV.Name = "buttonDone_BKV";
            buttonDone_BKV.Size = new Size(134, 89);
            buttonDone_BKV.TabIndex = 5;
            buttonDone_BKV.Text = "Выполнить";
            buttonDone_BKV.UseVisualStyleBackColor = false;
            buttonDone_BKV.Click += buttonDone_Click;
            // 
            // buttonHelp_BKV
            // 
            buttonHelp_BKV.BackColor = SystemColors.MenuHighlight;
            buttonHelp_BKV.Location = new Point(291, 337);
            buttonHelp_BKV.Name = "buttonHelp_BKV";
            buttonHelp_BKV.Size = new Size(66, 89);
            buttonHelp_BKV.TabIndex = 6;
            buttonHelp_BKV.Text = "Справка";
            buttonHelp_BKV.UseVisualStyleBackColor = false;
            buttonHelp_BKV.Click += buttonHelp_BKV_Click;
            // 
            // FormMain
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(buttonHelp_BKV);
            Controls.Add(buttonDone_BKV);
            Controls.Add(groupBoxInput_BKV);
            Controls.Add(groupBoxResult_BKV);
            Controls.Add(groupBoxTask_BKV);
            Name = "FormMain";
            Text = "Спринт 6 | Таск 1 | Вариант 20 | Бабай К.В.";
            groupBoxTask_BKV.ResumeLayout(false);
            groupBoxTask_BKV.PerformLayout();
            groupBoxResult_BKV.ResumeLayout(false);
            groupBoxResult_BKV.PerformLayout();
            groupBoxInput_BKV.ResumeLayout(false);
            groupBoxInput_BKV.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBoxTask_BKV;
        private TextBox textBoxTask_BKV;
        private GroupBox groupBoxResult_BKV;
        private GroupBox groupBoxInput_BKV;
        private Label label1;
        private TextBox textBoxStartStep_BKV;
        private Label label2;
        private TextBox textBoxStopStep_BKV;
        private Label labelResult_BKV;
        private TextBox textBoxResult_BKV;
        private Button buttonDone_BKV;
        private Button buttonHelp_BKV;
    }
}
