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





namespace Login_Form
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-9VBDNG0\SEJAL;Initial Catalog=logindemo;Integrated Security=True;Pooling=False");
            conn.Open();
            SqlCommand cmd = new SqlCommand("insert into demo values(@Id,@Name,@Age)", conn);
            cmd.Parameters.AddWithValue("@Id", int.Parse(textBox1.Text));
            cmd.Parameters.AddWithValue("@Name",(textBox2.Text));
            cmd.Parameters.AddWithValue("@Age", int.Parse(textBox3.Text));
            cmd.ExecuteNonQuery();
            conn.Close();
            MessageBox.Show("successfully inserted");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-9VBDNG0\SEJAL;Initial Catalog=logindemo;Integrated Security=True;Pooling=False");
            conn.Open();
            SqlCommand cmd = new SqlCommand("update demo set Name=@Name,Age=@age where Id=@Id ", conn);
            cmd.Parameters.AddWithValue("@Id", int.Parse(textBox1.Text));
            cmd.Parameters.AddWithValue("@Name", (textBox2.Text));
            cmd.Parameters.AddWithValue("@Age", int.Parse(textBox3.Text));
            cmd.ExecuteNonQuery();
            conn.Close();
            MessageBox.Show("successfully updated ");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-9VBDNG0\SEJAL;Initial Catalog=logindemo;Integrated Security=True;Pooling=False");
            conn.Open();
            SqlCommand cmd = new SqlCommand("Delete from demo where Id=@Id ", conn);
            cmd.Parameters.AddWithValue("@Id", int.Parse(textBox1.Text));
            cmd.ExecuteNonQuery();
            conn.Close();
            MessageBox.Show("successfully Deleted ");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
        }
        // show the Gridview
        private void button5_Click(object sender, EventArgs e)
        {
            /*SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-9VBDNG0\SEJAL;Initial Catalog=logindemo;Integrated Security=True;Pooling=False");
            conn.Open();
            SqlCommand cmd = new SqlCommand("Select* from demo where Id=@Id", conn);
            cmd.Parameters.AddWithValue("@Id", int.Parse(textBox1.Text));
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            conn.Close();*/
            SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-9VBDNG0\SEJAL;Initial Catalog=logindemo;Integrated Security=True;Pooling=False");
            conn.Open();
            SqlCommand cmd = new SqlCommand("select* from demo ", conn);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            conn.Close();





        }
        // Gridview data to textboxs
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                /*textBox1.Text = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
                textBox2.Text = dataGridView1.SelectedRows[0].Cells[1].Value.ToString();
                textBox3.Text = dataGridView1.SelectedRows[0].Cells[2].Value.ToString();*/
                    DataGridViewRow row = this.dataGridView1.Rows[e.RowIndex];
                    textBox1.Text = row.Cells["Id"].Value.ToString();
                    textBox2.Text = row.Cells["Name"].Value.ToString();
                    textBox3.Text = row.Cells["Age"].Value.ToString();

            }

            }
        }
    }
    
    


