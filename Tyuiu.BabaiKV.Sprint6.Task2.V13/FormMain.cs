using System.Windows.Forms.VisualStyles;
using Tyuiu.BabaiKV.Sprint6.Task2.V13.Lib;
namespace Tyuiu.BabaiKV.Sprint6.Task2.V13
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }
        DataService ds = new DataService();
        private void buttonDone_BKV_Click(object sender, EventArgs e)
        {
            try
            {
                int startStep = Convert.ToInt32(textBoxStart_BKV.Text);
                int stopStep = Convert.ToInt32(textBoxStop_BKV.Text);

                int len = ds.GetMassFunction(startStep, stopStep).Length;

                double[] valueArray;
                valueArray = new double[len];

                valueArray = ds.GetMassFunction(startStep, stopStep);
                this.chartFunction_BKV.Titles.Add("График Функции");

                this.chartFunction_BKV.ChartAreas[0].AxisX.Title = "Ось X";
                this.chartFunction_BKV.ChartAreas[0].AxisX.Title = "Ось Y";
                for (int i = 0; i <= len - 1; i++)
                {
                    this.dataGridViewFunction_BKV.Rows.Add(Convert.ToString(startStep), Convert.ToString(valueArray[i]));
                    this.chartFunction_BKV.Series[0].Points.AddXY(startStep, valueArray[i]);
                    startStep++;
                }
            }
            catch
            {
                MessageBox.Show("Введены неверные данные", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void buttonDone_MouseEnter(object sender, EventArgs e)
        {
            buttonDone_BKV.BackColor = Color.Red;
        }

        private void buttonDone_MouseLeave(object sender, EventArgs e)
        {
            buttonDone_BKV.BackColor = Color.Green;
        }

        private void buttonDone_MouseDown(object sender, MouseEventArgs e)
        {
            buttonDone_BKV.BackColor = Color.Blue;
        }

        private void buttonHelp_BKV_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Таск 2 выполнила студентка группы СМАРТб-24-1 Бабай Ксения Витальевна", "Сообщение", MessageBoxButtons.OK);
        }

        private void buttonHelp_BKV_Click_1(object sender, EventArgs e)
        {

        }
    }
}
