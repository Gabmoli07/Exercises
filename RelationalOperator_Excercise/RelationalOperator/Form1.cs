using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.VisualBasic;

namespace RelationalOperator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnSingleAltrernative_Click(object sender, EventArgs e)
        {
            string userInput = Interaction.InputBox(
                "Do you want to turn the box green? Y for Yes, Other letter for No.");
            if (userInput.ToUpper() == "Y")
            {
                txtDisplay.BackColor = Color.Green;
            }
            else
            {
                txtDisplay.BackColor = Color.White;
            }

        }

        private void btnDualAlternative_Click(object sender, EventArgs e)
        {
            string userInput = Interaction.InputBox("Type G for green, other letters for orange.");
            if (userInput.ToUpper() == "G")
            {
                txtDisplay.BackColor = Color.Green;
            }
            else
            {
                txtDisplay.BackColor = Color.Orange;
            }
        }

        private void btnMultipleAlternative_Click(object sender, EventArgs e)
        {
            string userInput = Interaction.InputBox("Type G for green, O for orange, V for violet, R for red,"
                + "Y for Yellow, other letters for White");
            if (userInput.ToUpper() == "G")
            {
                txtDisplay.BackColor = Color.Green;
            }
            else if (userInput.ToUpper() == "O")
            {
                txtDisplay.BackColor = Color.Orange;
            }
            else if (userInput.ToUpper() == "V")
            {
                txtDisplay.BackColor = Color.Violet;
            }
            else if (userInput.ToUpper() == "R")
            {
                txtDisplay.BackColor = Color.Red;
            }
            else if (userInput.ToUpper() == "Y")
            {
                txtDisplay.BackColor = Color.Yellow;
            }
            else
            {
                txtDisplay.BackColor = Color.White;
            }

        }

        private void btnCoupon_Click(object sender, EventArgs e)
        {
            string userInput = Interaction.InputBox("Do you have a coupon? Y for Yes and other letter for No.");

            if (userInput.ToLower() == "y")
            {
                txtDisplay.Text = " You get 10% discount with coupon. $180 please.";
            }
            else
            {
                txtDisplay.Text = "$200 please.";
            }


        }

        private void btnTryParse_Click(object sender, EventArgs e)
        {
            byte bytX = 0;
            string userInput = Interaction.InputBox("Type something and see what the function Byte.TryParse do.");
            if (byte.TryParse(userInput, out bytX))
            {
                txtDisplay.Text = "Byte.TryParse function returns " + byte.TryParse(userInput, out bytX) +
                    " because \"" + userInput + "\" can be coverted into a Byte number. At the same time, " +
                    bytX + " is assigned to the variable bytX."; 
            }
            else
            {
                txtDisplay.Text = "Byte.TryParse function returns " + byte.TryParse(userInput, out bytX) +
                 " because \"" + userInput + "\" can't be coverted into a Byte number. At the same time, " +
                 bytX + " is assigned to the variable bytX.";
            }
        }

        private void btnDriverLicense_Click(object sender, EventArgs e)
        {
            byte bytAge = 0;
            string strAge = Interaction.InputBox("How old are you?" + Environment.NewLine +
                " If you are 18 tomorrow, you should answer 17.");
            if (byte.TryParse(strAge, out bytAge))
            {
                if (bytAge >= 18)
                {
                    txtDisplay.Text = "You may apply for a driver license.";
                }
                else if (bytAge >= 16)
                {
                    txtDisplay.Text = "You are too young to drive.";
                }
            }
            else
            {
                txtDisplay.Text = "Please enter a resonable integer number for age." +
                    strAge + " is not correct. Try again.";
            }
        }

        private void btnTicket_Click(object sender, EventArgs e)
        {
            string userInput = Interaction.InputBox("Type S for senior, C for child, other letter for anyone else.");

            if (userInput.ToUpper() == "S")
            {
                txtDisplay.Text = "Please pay 5$";
            }
            else if (userInput.ToUpper() == "C")
            {
                txtDisplay.Text = "Pass free";
            }
            else
            {
                txtDisplay.Text = "You have to pay 10%";
            }
        }

        private void btnVendingMachine_Click(object sender, EventArgs e)
        {
            
            string strSoda = Interaction.InputBox("Type 10  for Pepsi; 15  for Coca Cola; 18 for Snapple; 22 for Ginger Ale; 30 for Gatorade");
            if (strSoda == "10")
            {
                txtDisplay.Text = "You get a Pepsi.";
            }
            else if (strSoda == "15")
                {
                txtDisplay.Text = "You get a Coca Cola";
            }
            else if (strSoda == "18")
            {
                txtDisplay.Text = "You get a Snapple";
            }
            else if (strSoda == "22")
            {
                txtDisplay.Text = "You get a Ginger Ale";
            }
            else if (strSoda == "30")
            {
                txtDisplay.Text = "You get a Gatorade";
            }
            else
            {
                txtDisplay.Text = strSoda + " does not exist. Try again.";
            }

        }
    }
}
