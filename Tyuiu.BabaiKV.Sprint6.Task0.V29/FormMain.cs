using Tyuiu.BabaiKV.Sprint6.Task0.V29.Lib;
namespace Tyuiu.BabaiKV.Sprint6.Task0.V29
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }
        private void buttonDone_Click(object sender, EventArgs e)
        {
            DataService dataService = new DataService();
            try
            {
                textBoxResult_BKV.Text = Convert.ToString(dataService.Calculate(Convert.ToInt32(textBoxX_BKV.Text)));
            }
            catch
            {
                MessageBox.Show("������� �������� ������", "������", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void textBoxVarX_BKV_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar <= 47 || e.KeyChar >= 58) && (e.KeyChar != '.') && (e.KeyChar != 8))
            {
                e.Handled = true;
            }
        }
        private void buttonQuestion_BKV_Click(object sender, EventArgs e)
        {
            MessageBox.Show("���� 0 ��������� ��������� ������ ������-24-1 ����� ������ ����������", "���������", MessageBoxButtons.OK);
        }
    }
}
