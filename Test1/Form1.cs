using System.Security.Cryptography.X509Certificates;
using System.Xml.Linq;

namespace Test1
{
    public partial class Form1 : Form
    {
        ���� ����;
        ���� �Ľ�;
        ���� ����;

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ���� = new ����(100, 20);
            ����.Name = "����";

            // �Ľ���
            �Ľ� = new ����(100, 20);
            �Ľ�.Name = "�Ľ�";

            // �ֹ���
            ���� = new ����(90, 10);
            ����.Name = "����";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            label1.Text = ����.HP.ToString();
            label2.Text = �Ľ�.HP.ToString();
            label3.Text = ����.HP.ToString();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            �Ľ�.����(����);
        }
    }



}