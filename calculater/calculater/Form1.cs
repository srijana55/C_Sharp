namespace calculater
{
    public partial class Form1 : Form
    {
        string operate = "";
        decimal calculation = 0;
        
        public Form1()
        {
            InitializeComponent();
        }
        public void getvalue()
        {
            if (display.Text != "" && display.Text != "+" && display.Text != "-" && display.Text != "*" && display.Text != "÷")
            {
                calculation = Convert.ToDecimal(display.Text);    
               
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            
           display.Text = display.Text + "1";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            display.Text = display.Text + "2";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            display.Text = display.Text + "3";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            getvalue();
            display.Text = display.Text + "0";
        }

        private void button5_Click(object sender, EventArgs e)
        {

            display.Clear();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            getvalue();
            operate = "+";
            display.Text = "+";
            

        }

        private void button7_Click(object sender, EventArgs e)
        {
            
            display.Text = display.Text + "=";
        }

        private void button8_Click(object sender, EventArgs e)
        {
            getvalue();
            operate = "-";
            display.Text = "-";


        }

        private void button9_Click(object sender, EventArgs e)
        {
            display.Text = display.Text + "4";
        }

        private void button10_Click(object sender, EventArgs e)
        {
            display.Text = display.Text + "5";
        }

        private void button11_Click(object sender, EventArgs e)
        {
            
            display.Text = display.Text + "6";
        }

        private void button13_Click(object sender, EventArgs e)
        {
            getvalue();
            
            operate = "*";
            display.Text = "*";
        }

        private void button14_Click(object sender, EventArgs e)
        {
            string data = display.Text;
            display.Text = data + "7";
        }

        private void button15_Click(object sender, EventArgs e)
        {
            string data = display.Text;
            display.Text = data + "8";
        }

        private void button16_Click(object sender, EventArgs e)
        {
            string data = display.Text;
            display.Text = data + "9";
        }

        private void button17_Click(object sender, EventArgs e)
        {
            getvalue();

            operate = "÷";
            display.Text = "÷";

        }
    }
}