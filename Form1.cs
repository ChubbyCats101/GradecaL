namespace Gradecal
{
    public partial class Form1 : Form
    {
        int arrayIndex = 0;
        string[] arrID = new string[100];
        string[] arrName = new string[100];
        string[] arrScore = new string[100];
        public Form1()
        {
            InitializeComponent();
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string inputID = TBid1.Text;
            string inputName = TBnm1.Text;
            string inputScore = TBsc1.Text;

            arrID[arrayIndex] = inputID;
            arrName[arrayIndex] = inputName;
            arrScore[arrayIndex] = inputScore;
            arrayIndex++;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}