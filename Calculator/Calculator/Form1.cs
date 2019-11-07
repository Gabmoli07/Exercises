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
        double number1 = 0; // variable for first operand
        double number2 = 0; // variable for second operand
        private void btnAdd_Click(object sender, EventArgs e)
        {
           


        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (double.TryParse(txtNum1.Text, out number1) &&
                double.TryParse(txtNum2.Text, out number2))
            {
                lblSolution.Text = (number1 * number2).ToString();
                lblOperator.Text = "*";
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (double.TryParse(txtNum1.Text, out number1) &&
                double.TryParse(txtNum2.Text, out number2))
            {
                lblSolution.Text = (number1 % number2).ToString();
                lblOperator.Text = "%";
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            txtNum1.Clear();
            txtNum2.Clear();
            lblOperator.Text = "";
            lblSolution.Text = "";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (double.TryParse(txtNum1.Text, out number1) &&
                double.TryParse(txtNum2.Text, out number2))
            {
                lblSolution.Text = (number1 - number2).ToString();
                lblOperator.Text = "-";
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (double.TryParse(txtNum1.Text, out number1) &&
                double.TryParse(txtNum2.Text, out number2))
            {
                lblSolution.Text = (number1 / number2).ToString();
                lblOperator.Text = "/";
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (double.TryParse(txtNum1.Text, out number1) &&
                double.TryParse(txtNum2.Text, out number2))
            {
                lblSolution.Text = Math.Pow(number1, number2).ToString();
                lblOperator.Text = "^";
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void lblEqual_Click(object sender, EventArgs e)
        {

        }

        private void lblSolution_Click(object sender, EventArgs e)
        {

        }

        private void btnAdd_Click_1(object sender, EventArgs e)
        {
            if (double.TryParse(txtNum1.Text, out number1) &&
                double.TryParse(txtNum2.Text, out number2))
            {
                lblSolution.Text = (number1 + number2).ToString();
                lblOperator.Text = "+";
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
        int x = 0;
        private void timer1_Tick(object sender, EventArgs e)
        {
            switch (x % 2)
            {
                case 0:
                    picASA.Image = Properties.Resources.ASAlogo0911;
                    break;
                case 1:
                    picASA.Image = Properties.Resources.n;
                    break;

            }
            x = x + 1;
        }


    }
}
