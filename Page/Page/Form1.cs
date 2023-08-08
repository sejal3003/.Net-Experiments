using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Page
{
    public partial class Form1 : Form
    {
        int n;
        int k = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            n = Convert.ToInt32(textBox1.Text);
            int f = 1;
            for (int i = 1; i <=n; i++)
            {
                f = f * i;

            }
            textBox2.Text = ($"{f}");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            n = int.Parse(textBox1.Text);
            for(int i = 1; i <= n; i++)
            {
                if (n % i == 0)
                {
                    k++;

                }
               
            }
            if (k == 2)
            {
                textBox2.Text = ("prime");
            }
            else
            {
                textBox2.Text = ("not prime");
            }
        }
            
            
        


        private void button3_Click(object sender, EventArgs e)
        {
            int n = int.Parse(textBox1.Text);
            int a = 0;
            int b = 1;
            int s;
            textBox2.Text = a + " " + b;
            for(int i = 1; i <= n - 2; i++)
            {
                s = a + b;
                textBox2.Text = textBox2.Text + " " + s;
                a = b;
                b = s;

            }
        }
    }
}
