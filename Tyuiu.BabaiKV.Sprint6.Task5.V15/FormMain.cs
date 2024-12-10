using System.IO;
using Tyuiu.BabaiKV.Sprint6.Task5.V15.Lib;
namespace Tyuiu.BabaiKV.Sprint6.Task5.V15
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        DataService ds = new DataService();
        string path = @"C:\DataSprint6\InPutDataFileTask5V15.txt";
        private void FormMain_Load(object sender, EventArgs e)
        {

        }

        private void buttonHelp_BKV_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Таск 5 выполнила студентка группы СМАРТб-24-1 Бабай Ксения Витальевна", "Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void buttonOpenFille_BKV_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process txt = new System.Diagnostics.Process();
            txt.StartInfo.FileName = "notepad.exe";
            txt.StartInfo.Arguments = path;
            txt.Start();
        }

        private void buttonDone_BKV_Click(object sender, EventArgs e)
        {
            dataGridViewResults_BKV.ColumnCount = 2;
            dataGridViewResults_BKV.Columns[0].Width = 20;
            dataGridViewResults_BKV.Columns[1].Width = 50;

            chartData_BKV.ChartAreas[0].AxisX.Title = "Ось X";
            chartData_BKV.ChartAreas[0].AxisY.Title = "Ось Y";

            chartData_BKV.Series[0].Points.Clear();

            double[] numsMass = new double[ds.LoadFromDataFile(path).Length];
            numsMass = ds.LoadFromDataFile(path);

            for (int i = 0; i < numsMass.Length; i++)
            {
                dataGridViewResults_BKV.Rows.Add(Convert.ToString(i), Convert.ToString(numsMass[i]));
                chartData_BKV.Series[0].Points.AddXY(i, numsMass[i]);
            }
        }
    }
}
