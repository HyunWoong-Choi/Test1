using System.Windows.Forms.VisualStyles;

namespace Test1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            label1.Text = "Test";

            // �Ҽ��ִ� ���� �����ΰ�
            // ������ �˰� ����
            // �̰� �ܿ� �ٸ��� �Ҽ� ���ŵ�

            // �� 6�� �׼�
            // Create  Read   Update  (Delete)   CRUD ������
            // if() foreach ( in )

            // ������ - ����, ����, YESorNO
            // bool - Yes or NO
            // ���� - Int ����, float �Ҽ���(�Ҽ����� �����ϴ� ��� �̸�)
            // ���� - string


            // SomeNumber is integer.
            // SomeNumber: integer; // �Ľ�Į ���

            bool isNumber = true;
            int SomeNumber = 3;

            int SomeNumber2 = SomeNumber;

            string SomeLetters = "hello";

            if (true)
            {
                SomeNumber = SomeNumber2;
            }

            var PotatoGram = 4;
            var Potato2Gram = 2;
            var Potato3Gram = 1;

            string[] Potatos = { "4", "2"};

            foreach ( var P in Potatos)
            {
                var value = P; // value = 4, 2, 1
            }

        }
    }
}