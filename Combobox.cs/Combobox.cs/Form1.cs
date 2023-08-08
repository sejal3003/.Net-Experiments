using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Combobox.cs
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "")
            {
                if (comboBox1.Items.Contains(textBox1.Text))
                {
                    MessageBox.Show("already it exists");
                }
                else
                {
                    //comboBox1.Items.Add("Solapur");
                    comboBox1.Items.Add(textBox1.Text);
                    textBox1.Clear();
                    textBox1.Focus();
                }

            }
            else
            {
                MessageBox.Show("Please enter the city");
            }


        }

        private void button2_Click(object sender, EventArgs e)
        {
            int count = comboBox1.Items.Count;
            MessageBox.Show("Items are :" + count);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            //comboBox1.Items.Remove(comboBox1.SelectedItem);
           // comboBox1.Items.Remove("Solapur");
            comboBox1.Items.RemoveAt(comboBox1.SelectedIndex);

        }

        private void button4_Click(object sender, EventArgs e)
        {
            comboBox1.Items.Clear();

        }

        private void button5_Click(object sender, EventArgs e)
        {
            comboBox1.Sorted = true;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            label3.Text = comboBox1.SelectedItem.ToString();
        }
    }
}
