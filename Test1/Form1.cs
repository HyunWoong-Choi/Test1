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

            // 틀 안에 값을 채워
            // 학생 데이터를 채움
            IDs.Add(1);
            IDs.Add(2);

            var SelectedID = (from ID in IDs
                             where ID >= 5
                             where ID <= 8 // 어떠어떤 조건인 데이터를
                             select ID).Take(3);                // 선택해서 가져와


            label1.Text = String.Join(", ", SelectedID); // 과연 뭐가 나올까

        }




        /*
         * 변수 만드는거, 변수 값 수정하는거(변수 = ), 변수 값을 읽는거 ( = 변수)
         * 
         * if, foreach
         * (else 쓰지마셈, for 쓰지마셈) - 근데 걍 무시하고 써도 되긴함
         * 
         * 
         * class : 데이터(+처리)묶음. 데이터 묶음을 한번에 생성하는 용도 
         * 
         *  -> 수정, 읽는거, 삭제 : 못함....
         *  -> 함수 (+오버로딩 +FP)
         * 
         * 
         */

    }
}