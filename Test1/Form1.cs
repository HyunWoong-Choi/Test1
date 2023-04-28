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

            // 할수있는 것이 무엇인가
            // 갯수를 알고 시작
            // 이거 외에 다른건 할수 없거든

            // 딱 6개 액션
            // Create  Read   Update  (Delete)   CRUD 데이터
            // if() foreach ( in )

            // 데이터 - 숫자, 글자, YESorNO
            // bool - Yes or NO
            // 숫자 - Int 정수, float 소수점(소수점을 저장하는 기술 이름)
            // 글자 - string


            // SomeNumber is integer.
            // SomeNumber: integer; // 파스칼 언어

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