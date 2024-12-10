using Tyuiu.BabaiKV.Sprint6.Task4.V13.Lib;
namespace Tyuiu.BabaiKV.Sprint6.Task4.V13
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }
        DataService ds = new DataService();
        private void SolveButton_BKV_Click(object sender, EventArgs e)
        {
            try
            {
                int startValue = Convert.ToInt32(InputTextBoxStart_BKV.Text);
                int stopValue = Convert.ToInt32(InputTextBoxStop_BKV.Text);

                int len = ds.GetMassFunction(startValue, stopValue).Length;

                double[] TempArray = new double[len];

                TempArray = ds.GetMassFunction(startValue, stopValue);

                this.ChartFunctionResult_BKV.ChartAreas[0].AxisX.Title = "ось X";
                this.ChartFunctionResult_BKV.ChartAreas[0].AxisY.Title = "ось Y";

                ResultTextBox_BKV.Text = "";

                ChartFunctionResult_BKV.Series[0].Points.Clear();
                for (int i = 0; i < len; i++)
                {
                    this.ChartFunctionResult_BKV.Series[0].Points.AddXY(startValue, TempArray[i]);
                    ResultTextBox_BKV.AppendText(TempArray[i] + Environment.NewLine);
                    startValue++;
                }
            }
            catch
            {
                MessageBox.Show("Введены неверные данные", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void HelpButton_BKV_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Таск 4 выполнил студент группы СМАРТб-24-1 Бабай К.В.", "Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void SaveButton_BKV_Click(object sender, EventArgs e)
        {
            try
            {
                string path = Path.Combine("C:", "DataSprint6", "OutPutDataFileTask4V13.txt");
                File.WriteAllText(path, ResultTextBox_BKV.Text);

                DialogResult dr = MessageBox.Show("Файл " + path+ " Сохранён успешно!\nОткрыть его в блокноте?", "Сообщение", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                if (dr == DialogResult.Yes)
                {
                    System.Diagnostics.Process txt = new System.Diagnostics.Process();
                    txt.StartInfo.FileName = "notepad.exe";
                    txt.StartInfo.Arguments = path;
                    txt.Start();
                }
            }
            catch
            {
                MessageBox.Show("Сбой при сохранении файла", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
