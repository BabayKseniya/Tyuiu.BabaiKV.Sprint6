using System.Windows.Forms;
using Tyuiu.BabaiKV.Sprint6.Task6.V15.Lib;
namespace Tyuiu.BabaiKV.Sprint6.Task6.V15
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }
        DataService ds = new DataService();
        string openFilePath;
        private void buttonOpenFile_BKV_Click(object sender, EventArgs e)
        {
            try
            {
                openFileDialog_BKV.ShowDialog();
                openFilePath = openFileDialog_BKV.FileName;
                textBoxInPut_BKV.Text = File.ReadAllText(openFilePath);
                groupBoxInPut_BKV.Text = groupBoxInPut_BKV.Text + " " + openFilePath;
                buttonDone_BKV.Enabled = true;
            }
            catch
            {
                MessageBox.Show("Что-то пошло не так", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void buttonDone_BKV_Click(object sender, EventArgs e)
        {
            try
            {
                
                textBoxOutPut_BKV.Text = ds.CollectTextFromFile( openFilePath);
            }
            catch
            {
                MessageBox.Show("Что-то пошло не так", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonHelp_BKV_Click(object sender, EventArgs e)
        {
            FormAbout formAbout = new FormAbout();
            formAbout.ShowDialog();
        }
    }
}
