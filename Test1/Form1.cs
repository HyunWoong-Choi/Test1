using System.Security.Cryptography.X509Certificates;

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
            List<int> IDs = new List<int>();

            // Ʋ �ȿ� ���� ä��
            // �л� �����͸� ä��
            IDs.Add(1);
            IDs.Add(2);

            var SelectedID = (from ID in IDs
                             where ID >= 5
                             where ID <= 8 // �� ������ �����͸�
                             select ID).Take(3);                // �����ؼ� ������


            label1.Text = String.Join(", ", SelectedID); // ���� ���� ���ñ�

        }




        /*
         * ���� ����°�, ���� �� �����ϴ°�(���� = ), ���� ���� �д°� ( = ����)
         * 
         * if, foreach
         * (else ��������, for ��������) - �ٵ� �� �����ϰ� �ᵵ �Ǳ���
         * 
         * 
         * class : ������(+ó��)����. ������ ������ �ѹ��� �����ϴ� �뵵 
         * 
         *  -> ����, �д°�, ���� : ����....
         *  -> �Լ� (+�����ε� +FP)
         * 
         * 
         */

    }
}