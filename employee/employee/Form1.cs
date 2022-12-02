using System.Data;
using System.Data.SqlClient;

namespace employee
{
    public partial class Form1 : Form
    {
        private SqlConnection con = new SqlConnection(@"Data Source = DESKTOP-SLAE5T6\SQLEXPRESS;
                                                Initial Catalog=emp_details;
                                                Integrated Security=True");
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
             //to display record (connect db to design)
            string ConnectionString = (@"Data Source = DESKTOP-SLAE5T6\SQLEXPRESS;
                                                Initial Catalog=emp_details;
                                                Integrated Security=True");
            SqlConnection con = new SqlConnection(ConnectionString);

            con.Open();

            string Query = "select * from employee";
            SqlCommand cmd = new SqlCommand(Query, con);

            var reader = cmd.ExecuteReader();

            DataTable table = new DataTable();
            table.Load(reader);

            dataGridView1.DataSource = table;
            con.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            con.Open();
            string query = "Insert into employee " + "(name,address,salary)" + "values(@name,@address,@salary)";

            SqlCommand cmd = con.CreateCommand();
            cmd.CommandText = query;
            cmd.Parameters.AddWithValue("@name", txtUserName.Text);
            cmd.Parameters.AddWithValue("@address", txtUserAddr.Text);
            cmd.Parameters.AddWithValue("@salary", txtUserSalary.Text);

            cmd.ExecuteNonQuery();
            MessageBox.Show("saved successfully");
            con.Close();
            /* con.Open();
             string query = "Insert into employee values('" + txtUserName.Text
                 + "','" + txtUserAddr.Text + "','" + txtUserSalary.Text + "')";
             SqlCommand cmd = new SqlCommand(query, con);
             cmd.ExecuteNonQuery();
             MessageBox.Show("saved successfully");
             con.Close();
            */
        }

        private void button5_Click(object sender, EventArgs e)
        {
            //save record of buttons in datagridveiw
            con.Open();
            
            string query = "insert into employee (name, address, salary)  values('"+ txtUserName.Text +"', '"+ txtUserName.Text +"', '"+ txtUserName.Text +"')";
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandText = query;
            cmd.ExecuteNonQuery();
            MessageBox.Show("saved successfully");
            con.Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            
                con.Open();
            string query = "delete from employee where emp_id = '"+ UserID.Text +"'";
            SqlCommand cmd = new SqlCommand(query, con);
            cmd.ExecuteNonQuery();
            MessageBox.Show("Deleted successfully");
            con.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
           // wanna die
            con.Open();

            string query = "update employee set name='" + txtUserName.Text + "', address='" + txtUserAddr.Text + "' ,salary ='" + txtUserSalary.Text + "' where emp_id = '" + UserID.Text + "' ";
            SqlCommand cmd = new SqlCommand(query, con);
            cmd.ExecuteNonQuery();
            MessageBox.Show("Update successfully");
            con.Close();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {
           
        }
    }
}