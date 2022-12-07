using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator
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

        private void button1_Click(object sender, EventArgs e)
        {
            Button btnTmp = (Button)sender;
            textBox1.Text += btnTmp.Text;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button21_Click(object sender, EventArgs e)
        {

        }

        private void button20_Click(object sender, EventArgs e)
        {
            string[] plusSplit = textBox1.Text.Split('+');
            double result = 0;

            for (int i=0; i<plusSplit.Length; i++)
            {
                Console.WriteLine(plusSplit[i]);
                result += Convert.ToDouble(plusSplit[i]);
            }

            label1.Text = Convert.ToString(result);
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
