using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Q1
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
            try
            {
                int num1 = int.Parse(txt1number.Text);
                int num2 = int.Parse(txt2number.Text);

                int sum = num1 + num2;

                lblanswer.Text = "Answer is: " + sum.ToString();
            }
            catch
            {
                MessageBox.Show("Please Enter valid numbers.");
            
            }
        }
    }
}
