using System.Data.SqlClient;

namespace calculater
{
    public partial class Form1 : Form
    {
        string operate = "";
        decimal calculation = 0;

        SqlConnection con = new SqlConnection("Data Source = DESKTOP-SLAE5T6\\SQLEXPRESS;Initial catalog=bit3rdsem;user id= sa;password=kist@123");


        public void getvalue()
        {
            if (display.Text != "" && display.Text != "+" && display.Text != "-" && display.Text != "*" && display.Text != "÷")
            {
                calculation = Convert.ToDecimal(display.Text);

            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            if (display.Text == "+" || display.Text == "-" || display.Text == "*" || display.Text == "÷")
            {
                display.Text = "1";
            }
            else
            {
                display.Text = display.Text + "1";
            }

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
            decimal firstnum = calculation;
            decimal secondnum = Convert.ToDecimal(display.Text);
            switch (operate)
            {
                case "+":
                    calculation = (firstnum + secondnum);
                    display.Text = calculation.ToString();
                    break;
                case "-":
                    calculation = (firstnum - secondnum);

                    display.Text = calculation.ToString();
                    break;
                case "*":
                    calculation = (firstnum * secondnum);
                    display.Text = calculation.ToString();
                    break;
                case "÷":
                    calculation = (firstnum / secondnum);
                    display.Text = calculation.ToString();
                    break;
            }


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

        private void button17_Click_1(object sender, EventArgs e)
        {

        }


        private void button18_Click(object sender, EventArgs e)
        {
            //this.hide(); to hide other form at a time
            this.Hide();
            // adding new form 
            //Form3 object_name = new Form3();

            //tab.ShowDialog();
            //object_name.Show();
        }

        private void button17_Click_2(object sender, EventArgs e)
        {
            try
            {
                con.Open();
                string query = "Delete = 'ramesh',address = 'kathmandu',college = 'kist')";
                SqlCommand cmd = new SqlCommand(query, con);
                cmd.ExecuteNonQuery();

                //SqlCommand cmd = con.CreateCommand();
                //cmd.CommandText = query;
                //Cmd.ExecuteNonQuery();

                MessageBox.Show("saved successfully");
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("updateed successfully");
                con.Close();
            }

        }

        private void button18_Click_1(object sender, EventArgs e)
        {

        }
        
    }
}
