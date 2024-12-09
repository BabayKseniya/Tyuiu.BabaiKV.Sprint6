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
                textBoxResult_SBI.Text = Convert.ToString(dataService.Calculate(Convert.ToInt32(textBoxX_SBI.Text)));
            }
            catch
            {
                MessageBox.Show("������� �������� ������", "������", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void textBoxVarX_SBI_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar <= 47 || e.KeyChar >= 58) && (e.KeyChar != '.') && (e.KeyChar != 8))
            {
                e.Handled = true;
            }
        }
        private void buttonQuestion_SBI_Click(object sender, EventArgs e)
        {
            MessageBox.Show("���� 0 ��������� ��������� ������ ������-24-1 ����� ������ ����������", "���������", MessageBoxButtons.OK);
        }
    }
}