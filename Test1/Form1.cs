using System.Security.Cryptography.X509Certificates;
using System.Xml.Linq;

namespace Test1
{
    public partial class Form1 : Form
    {
        ���� ����;
        ���� �Ľ�;
        ���� ����;

        ������ ����;
        ������ �Ĺ�;
        ������ �ֹ�;


        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            ���� = new ����(100, 20);
            ����.Name = "����";

            // �Ľ���
            �Ľ� = new ����(100, 20);
            �Ľ�.Name = "�Ľ�";

            // �ֹ���
            ���� = new ����(90, 10);
            ����.Name = "����";


            ���� = new ������(100, 200);
            �Ĺ� = new ������(100, 200);
            �ֹ� = new ������(100, 200);




            timer1.Enabled = true;
        }
        private void timer1_Tick(object sender, EventArgs e)
        {

            label1.Text = ����.HP.ToString();
            label2.Text = �Ľ�.HP.ToString();
            label3.Text = ����.HP.ToString();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            //�������["�Ľ�"].����(�������["����"]);

            �Ľ�.����(����);
            �Ľ�.����(�ֹ�);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            /*
            List<int> nums = new List<int>();
            List<string> names = new List<string>();

            nums.Add(10);
            nums.Add(21);
            nums.Add(33);


            names.Add("Ming");
            names.Add("Sick");
            names.Add("Yung");


            List<����> ����� = new List<����>();
            ���� ������ = new ����(100, 20);
            �����.Add(������);
            �����.Add(new ����(100, 20));


            Dictionary<string, ����> ������� = new Dictionary<string, ����>();

            �������.Add( "������", ������);

            if (������ == �������["������"])
            {

            }
            */

            /*

            // ������ �ٷ�� ��� 6��

            // CRUD
            // Create read update delete
            // for if
            int a;
            string n;

            // create
            List<int> aas = new List<int>();
            List<string> names = new List<string>();
            // read
            int num = aas[0];
            string name = names[0];
            //update
            aas[0] = 10;
            names[0] = "aa";
            //delete
            aas = null;
            names = null;
            // if
            if (aas.Contains(1))
            {

            }

            // 20�� ���� ������� ��
            for (int j = 0; j < 10; j++)
            {
                var r = aas[j];
                r = r + 1;
            }

            // ���� �� �ݺ����� ���°�
            // ���� �����͸� ������� �ϳ��� ���ư��鼭 � ������ �Ϸ���
            // �׷��� �ݺ����� ���������� �ƴ϶� ������ ��� �Է����� �ٲ�߰ڴ�

            // �ʺ�
            List<int> results = new List<int>();
            foreach (var �ϳ��������� in aas)
            {
                results.Add(�ϳ��������� + 1);
            }


            //for �ʰ�ް���
            // 2015���� ���� '�������'
            aas.ForEach((p) => { p = p + 1; });

            */

        }
    }


}