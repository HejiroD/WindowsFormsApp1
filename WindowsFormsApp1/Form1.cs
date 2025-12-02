using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Button1_click(object sender, EventArgs e)
        {
            double a, b, c;
            bool rez1 = double.TryParse(textBox1.Text, out a);
            if (rez1 == false) 
            { 
                MessageBox.Show("Неверный формат числа" +textBox1.Text + "!");
                return; 
            }
           
            bool rez2 = double.TryParse(textBox2.Text, out b);
            if (rez2 == false) 
            { 
                MessageBox.Show("Неверный формат числа " +textBox2.Text + "!");
                return; 
            }
            c = (3* Math.Sin(a) + 6* b)/4;
            string cStr = c.ToString();
            label2.Text = cStr;
            return; 
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
