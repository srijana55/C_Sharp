using System.Data.SqlClient;

namespace SqlDatabase
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        SqlConnection con = new SqlConnection(@"Data Source = DESKTOP-SLAE5T6\SQLEXPRESS;
                                                Initial Catalog=bit3sem;
                                                user id=sa;password=kist@123;");

        private void button1_Click(object sender, EventArgs e)
        {
            con.Open();
            string query = "Insert into Student values('new','new','123','NIST')";
            SqlCommand cmd = new SqlCommand(query, con);
            cmd.ExecuteNonQuery();
            MessageBox.Show("saved successfully");
            con.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                con.Open();
                string query = "update Student set name='Sandip', address='Kathmandu' ,contact ='9852145254',college='KIST' where id = 6";
                SqlCommand cmd = new SqlCommand(query, con);
                cmd.ExecuteNonQuery();



                MessageBox.Show("Update Successfully");
                con.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show("Update Failed!");
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                con.Open();
                string query = "delete from Student where id = 6";
                SqlCommand cmd = new SqlCommand(query, con);
                cmd.ExecuteNonQuery();



                MessageBox.Show("Removed Successfully");
                con.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show("Removed Failed!");
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.Add("1", "sita", "ktm");
        }
    }
}