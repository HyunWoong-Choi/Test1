using System.Security.Cryptography.X509Certificates;
using System.Xml.Linq;

namespace Test1
{
    public partial class Form1 : Form
    {
        Dictionary<string, 전사> 전사사전;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            전사사전 = new Dictionary<string, 전사>();

            전사사전.Add("융전사", new 전사(100, 20));
            전사사전.Add("식전사", new 전사(100, 20));
            전사사전.Add("밍전사", new 전사(100, 20));


            timer1.Enabled = true;
        }




        private void timer1_Tick(object sender, EventArgs e)
        {

            label3.Text = 전사사전["융전사"].HP.ToString();
            label2.Text = 전사사전["식전사"].HP.ToString();
            label1.Text = 전사사전["밍전사"].HP.ToString();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            전사사전["식전사"].공격(전사사전["밍전사"]);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            /*
            List<전사> 전사들 = new List<전사>();
            전사 밍전사 = new 전사(100, 20);
            전사들.Add(밍전사);
            전사들.Add(new 전사(100, 20));


            Dictionary<string, 전사> 전사사전 = new Dictionary<string, 전사>();
            전사사전.Add( "밍전사", 밍전사);

            if (밍전사 == 전사사전["밍전사"])
            {

            }
            */

            /*

            // 데이터 다루는 방법 6개

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

            // 20년 동안 개고생을 함
            for (int j = 0; j < 10; j++)
            {
                var r = aas[j];
                r = r + 1;
            }

            // 나는 왜 반복문을 적는가
            // 같은 데이터를 대상으로 하나씩 돌아가면서 어떤 연산을 하려고
            // 그러면 반복문이 숫자증가가 아니라 데이터 덩어리 입력으로 바꿔야겠다

            // 초보
            List<int> results = new List<int>();
            foreach (var 하나씩뽑은값 in aas)
            {
                results.Add(하나씩뽑은값 + 1);
            }


            //for 초고급과정
            // 2015년쯤 부터 '만들어짐'
            aas.ForEach((p) => { p = p + 1; });

            */

        }
    }


}