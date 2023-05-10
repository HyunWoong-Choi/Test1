using System.Security.Cryptography.X509Certificates;
using System.Xml.Linq;
using Test1.Control3;

namespace Test1.View4
{
    public partial class Form1 : Form
    {
        Control_Combat ccm;


        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            ccm = new Control_Combat();

            timer1.Enabled = true;
        }


        private void timer1_Tick(object sender, EventArgs e)
        {
            label1.Text = ccm.ci.마법사들["밍법사"].HP.ToString();
        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            ccm.Perform(textBox1.Text);
        }

    }


}