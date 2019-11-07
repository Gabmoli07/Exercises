using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FinalProject
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void cboSelect_SelectedIndexChanged(object sender, EventArgs e)
        {
            double UserInput;

            if (double.TryParse(txtInput.Text, out UserInput)) // Create a variable in double for showing reasonable values
            {
                // Each value have to start by 0 
                // Declare in double for showing reasonable values
                double F = 0; 
                double C = 0;
                double K = 0;
                switch (cboSelect.Text)

                {

                    case "Fahrenheit": // User selected Fahrenheit 

                        F = UserInput;
                        // The value assign is convert to Celsius and Kelvin
                        C = (F - 32) * 5 / 9;

                        K = C + 273.15;
                        break;

                    case "Celsius": //User selected Celsius

                        C = UserInput;

                        // The value assign is convert to Fahrenheit and Kelvin
                        F = C * 1.8 + 32;

                        K = C = 273.15;
                        break;

                    case "Kelvin": //User selected Kelvin


                        K = UserInput;
                        // The value assign is convert to Fahrenheit and Celcius
                        C = K - 273.15;

                        F = C * 1.8 + 32;
                        break;

                }
                // In Chemical Kelvin can not be negative, that's why we have to put this line 
                if (K < 0)

                {

                    lblCelsius.Text = "0.00";
                    lblFahrenheit.Text = "0.00";
                    lblKelvin.Text = "0.00";
                    MessageBox.Show("Temperature can not be 0 K, the absolute zero.");
                    txtInput.Focus();
                    txtInput.Select();
                    return;
                }

                // To don't make the values longer, with these lines the values are going to be two digits after decimal point
                lblFahrenheit.Text = F.ToString("N2");
                lblCelsius.Text = C.ToString("N2");
                lblKelvin.Text = K.ToString("N2");
            }

            else
            {
                // If path is false, they are will be cleaned by clearing outputs
                lblCelsius.Text = "";
                lblKelvin.Text = "";
                lblFahrenheit.Text = "";
                txtInput.Focus(); //This line is for the user input to make easier to clean
                txtInput.SelectAll(); //If the user put current entry do not overwriting

            }


            }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close(); // Line to close the GUI 
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            //these lines are for cleaning the results that we got 
            txtInput.Clear();
            lblCelsius.Text = "";
            lblFahrenheit.Text = "";
            lblKelvin.Text = "";
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
    }
