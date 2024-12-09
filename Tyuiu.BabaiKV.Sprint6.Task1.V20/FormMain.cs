using Tyuiu.BabaiKV.Sprint6.Task1.V20.Lib;
namespace Tyuiu.BabaiKV.Sprint6.Task1.V20
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        DataService dataService = new DataService();
        private void buttonDone_Click(object sender, EventArgs e)
        {
            try
            {
                int startStep = Convert.ToInt32(textBoxStartStep_BKV.Text);
                int stopStep = Convert.ToInt32(textBoxStopStep_BKV.Text);
                string strLine;
                int len = dataService.GetMassFunction(startStep, stopStep).Length;

                double[] valueArray = dataService.GetMassFunction(startStep, stopStep);

                textBoxResult_BKV.Text = "";
                textBoxResult_BKV.AppendText("+----------+----------+" + Environment.NewLine);
                textBoxResult_BKV.AppendText("|    X     |    f(x)  |" + Environment.NewLine);
                textBoxResult_BKV.AppendText("+----------+----------+" + Environment.NewLine);
                for (int i = 0; i <= len - 1; i++)
                {
                    strLine = String.Format("|{0,5:d}     | {1,6:f2}   |", startStep, valueArray[i]);
                    textBoxResult_BKV.AppendText(strLine + Environment.NewLine);
                    startStep++;
                }
                textBoxResult_BKV.AppendText("+----------+----------+" + Environment.NewLine);

            }
            catch (Exception ex)
            {
                MessageBox.Show("Введены неверные данные " + ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
        private void textBoxSteps_BKV_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar < '0' || e.KeyChar > '9') && (e.KeyChar != '.') && (e.KeyChar != 8) && (e.KeyChar != '-'))
            {
                e.Handled = true;
            }
        }
        private void buttonHelp_BKV_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Таск 1 выполнила студентка группы СМАРТб-24-1 Бабай Ксения Витальевна", "Сообщение", MessageBoxButtons.OK);
        }
    }
}
