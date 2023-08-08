using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace data
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            
           
            SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-9VBDNG0\SEJAL;Initial Catalog=mylogin;Integrated Security=True");
            conn.Open();
            SqlCommand cmd = conn.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "insert into login values(@username,@password)";
            cmd.Parameters.AddWithValue("@username",(textBox1.Text));
            cmd.Parameters.AddWithValue("@password", (textBox2.Text));
            cmd.ExecuteNonQuery();
            conn.Close();
            MessageBox.Show("inserted successfully");



        }

        private void button2_Click(object sender, EventArgs e)
        {
            SqlConnection conn= new SqlConnection(@"Data Source=DESKTOP-9VBDNG0\SEJAL;Initial Catalog=mylogin;Integrated Security=True");
            conn.Open();
            SqlCommand cmd = conn.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "update login set username=@username,password=@password where username=@username";
            cmd.Parameters.AddWithValue("@username", (textBox1.Text));
            cmd.Parameters.AddWithValue("@password", (textBox2.Text));
            cmd.ExecuteNonQuery();
            conn.Close();
            MessageBox.Show("updated successfully");


        }

        private void button3_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-9VBDNG0\SEJAL;Initial Catalog=mylogin;Integrated Security=True");
            SqlCommand cmd = conn.CreateCommand();
            conn.Open();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "Select* from login ";
            cmd.ExecuteNonQuery();
            
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            conn.Close();
        }


        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.dataGridView1.Rows[e.RowIndex];
                textBox1.Text = row.Cells["username"].Value.ToString();
                textBox2.Text = row.Cells["password"].Value.ToString();


            }
        }

        private void button4_Click(object sender, EventArgs e)
        {

            SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-9VBDNG0\SEJAL;Initial Catalog=mylogin;Integrated Security=True");
            SqlCommand cmd = conn.CreateCommand();
            conn.Open();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "delete from login ";
            cmd.ExecuteNonQuery();
            conn.Close();
            MessageBox.Show("Deleted successfully");
        }
    }
}
