using System.Security.Cryptography.X509Certificates;
using System.Xml.Linq;

namespace Test1
{
    public partial class Form1 : Form
    {
        전사 버섯;
        전사 식식;
        전사 내꺼;

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            내꺼 = new 전사(100, 20);
            내꺼.Name = "내꺼";

            // 식식이
            식식 = new 전사(100, 20);
            식식.Name = "식식";

            // 밍밍이
            버섯 = new 전사(90, 10);
            버섯.Name = "버섯";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            label1.Text = 내꺼.HP.ToString();
            label2.Text = 식식.HP.ToString();
            label3.Text = 버섯.HP.ToString();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            식식.공격(버섯);
        }
    }



}