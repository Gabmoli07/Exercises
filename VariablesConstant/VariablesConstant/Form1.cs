using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VariablesConstant
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string greeting = "Good morning.";

            string name;
            name = "Gabriel"; // value is assigned to hobby later

            // the two string variables and period are concatenated
            // and displayed
            lblOutput.Text = greeting + name + ".";


        }

        private void btnConstant_Click(object sender, EventArgs e)
        {

            const int speedLimit = 55;
            lblOutput.Text = "The inner city speed limit is " + speedLimit.ToString() + " miles an hour.";

        }

        const string OutputDescription = @"User input has been saved in a variable of data type";
        private void btnChart_Click(object sender, EventArgs e)
        {

            lblOutput.Text = "";

            string userInput = txtInput.Text;
            char input = ' ';
            try
            {
                input = char.Parse(userInput);
                lblOutput.Text = OutputDescription + " char :" +
                    Environment.NewLine + input.ToString();
            }
            catch (Exception ex)
            {
                lblOutput.Text = ex.Message;
            }
        }



        private void txtInput_TextChanged(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            lblOutput.Text = "";
            string userInpunt = txtInput.Text;
            lblOutput.Text = OutputDescription + " String " +
                Environment.NewLine + userInpunt;

        }

        private void btnBoolean_Click(object sender, EventArgs e)
        {
            lblOutput.Text = "";
            string userInput = txtInput.Text;
            bool input = true;
            try
            {
                input = bool.Parse(userInput);
                lblOutput.Text = OutputDescription + " bool :" +
                    Environment.NewLine + input.ToString();
            }
            catch (Exception ex)
            {
                lblOutput.Text = ex.Message;
            }
        }

        private void btnShort_Click(object sender, EventArgs e)
        {
            lblOutput.Text = "";

            string userInput = txtInput.Text;
            short input = 0;
            try
            {
                input = short.Parse(userInput);
                lblOutput.Text = OutputDescription + " short :" +
                    Environment.NewLine + input.ToString();
            }
            catch (Exception ex)
            {

                lblOutput.Text = ex.Message;
            }
        }

        private void btnInteger_Click(object sender, EventArgs e)
        {
            lblOutput.Text = "";

            string userInput = txtInput.Text;
            int input = 0;
            try
            {
                input = int.Parse(userInput);
                lblOutput.Text = OutputDescription + " int :" +
                    Environment.NewLine + input.ToString();
            }
            catch (Exception ex)
            {
                lblOutput.Text = ex.Message;
            }
        }
        private void btnLong_Click(object sender, EventArgs e)
        {

            lblOutput.Text = "";

            string userInput = txtInput.Text;
            long input = 0;
            try
            {
                input = long.Parse(userInput);
                lblOutput.Text = OutputDescription + " long " +
                    Environment.NewLine + input.ToString();
            }
            catch (Exception ex)
            {
                lblOutput.Text = ex.Message;
            }
        }
        private void btnFloat_Click(object sender, EventArgs e)
        {
            lblOutput.Text = "";

            string userInput = txtInput.Text;
            float input = 0;
            try
            {
                input = float.Parse(userInput);
                lblOutput.Text = OutputDescription + " float :" +
                    Environment.NewLine + input.ToString();
            }
            catch (Exception ex)
            {
                lblOutput.Text = ex.Message;
            }

        }

        private void btnDouble_Click(object sender, EventArgs e)
        {
            lblOutput.Text = "";

            string userInput = txtInput.Text;
            double input = 0;
            try
            {
                input = double.Parse(userInput);
                lblOutput.Text = OutputDescription + " double :" +
                    Environment.NewLine + input.ToString();
            }
            catch (Exception ex)
            {
                lblOutput.Text = ex.Message;
            }
        }

        private void btnDecimal_Click(object sender, EventArgs e)
        {
            lblOutput.Text = "";

            string userInput = txtInput.Text;
            decimal input = 0;
            try
            {
                input = decimal.Parse(userInput);
                lblOutput.Text = OutputDescription + " decimal :" +
                    Environment.NewLine + input.ToString();
            }
            catch (Exception ex)
            {
                lblOutput.Text = ex.Message;
            }
        }

        private void bntDivide_Click(object sender, EventArgs e)
        {
            const string description =
            @"User input has been saved in three different data types: float, double and decimal.
When they are divided by 3, and the resulting quotiens sometimes can be different:";
            lblOutput.Text = "";
            string userInput = txtInput.Text;
            float fInput = 0;
            double dblInput = 0;
            decimal decInput = 0;
            try
            {
                fInput = float.Parse(userInput);
                dblInput = double.Parse(userInput);
                decInput = decimal.Parse(userInput);
                lblOutput.Text = description +
                Environment.NewLine + userInput + " / 3 =" +
                (fInput / 3).ToString() + "using float variable;" +
                Environment.NewLine + userInput + " / 3 =" +
                (dblInput / 3).ToString() + "using double variable;" +
                Environment.NewLine + userInput + " / 3 =" +
                (decInput / 3).ToString() + "using decimal variable.";

            }
            catch (Exception ex)
            {
                lblOutput.Text = ex.Message;
            }
        }

        private void button14_Click(object sender, EventArgs e)
        {
            lblOutput.Text = "";
            txtInput.Clear();
        }

        private void button15_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnByte_Click(object sender, EventArgs e)
        {
            lblOutput.Text = "";

            string userInput = txtInput.Text;
            byte input = 0;
            try
            {
                input = byte.Parse(userInput);
                lblOutput.Text = OutputDescription + " byte :" +
                    Environment.NewLine + input.ToString();
            }
            catch (Exception ex)
            {
                lblOutput.Text = ex.Message;
            }
        }
    }
}