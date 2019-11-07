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


namespace Switch
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnWhere_Click(object sender, EventArgs e)
        {
            string strWhere = Interaction.InputBox(@"What kind of food do you like
1 for Jamaican food;
2 for Chinese food;
3 for mexican food;
4 for American food.");

            switch (strWhere.ToUpper())
            {
                case "1":
                    txtDisplay.Text = "Go to Golden Crust for Jamaican Food";
                    break;
                case "2":
                    txtDisplay.Text = "Go to Simply Ming for Chinese food";
                    break;
                case "3":
                    txtDisplay.Text = "Go to Yummy Taco for Mexican food";
                    break;
                case "4":
                    txtDisplay.Text = "Go to McDonald for American food";
                    break;
                default:
                    txtDisplay.Text = "Sorry, I don't understand your answer";
                    break;
            }
            txtDisplay.AppendText(@"
Enjoy your dinner.");

        }

        private void btnPrize_Click(object sender, EventArgs e)
        {
            string strPrize = Interaction.InputBox(@"Please write any numbre from 0 to 100
There are so many PRIZES

Six inch cell phone
Nine inch tablet
64 GB flash drive
Mouse pad");
            int intNumber = 0;
            if (int.TryParse(strPrize, out intNumber) == false)
            {
                txtDisplay.Text = strPrize + "is not a number. Check it up please.";
                return;

            }

            switch (intNumber)
            {
                case 96:
                    txtDisplay.Text = "You won a first prize: a 6 inch smartphone.";
                    break;
                case 23:
                    txtDisplay.Text = "You won a second prize: a Nine inch tablet.";
                    break;
                case 39:
                    txtDisplay.Text = "You won a second prize: a Nine inch tablet.";
                    break;
                case 87:
                    txtDisplay.Text = "You won a second prize: a Nine inch tablet.";
                    break;
                default:
                    txtDisplay.Text = "You won a mouse pad";
                    break;
            }
            if (intNumber >= 60 && intNumber <= 70)
            {
                txtDisplay.Text = "You won a third prize: a 64GB flash";

            }

        }

        private void btnMultiple_Click(object sender, EventArgs e)
        {
            string strUser = Interaction.InputBox(@"Type
G for green
O for orange
V for violet
R for red
Y for yellow");

            switch (strUser)
            { 

                case "G":
                txtDisplay.BackColor = Color.Green;
                break;
            case "O":
                txtDisplay.BackColor = Color.Orange;
                break;
            case "V":
                txtDisplay.BackColor = Color.Violet;
                break;
            case "R":
                txtDisplay.BackColor = Color.Red;
                break;
            case "Y":
                txtDisplay.BackColor = Color.Yellow;
                break;
            default:
                txtDisplay.BackColor = Color.White;
                break;
            }
        }

        private void btnEligibility_Click(object sender, EventArgs e)
        {
            string strAge = Interaction.InputBox("How old are you");
            byte bytAge = 0;
            if (byte.TryParse(strAge, out bytAge) == false)
            {
                txtDisplay.Text = "Invalid age. Try again.";
                return;

            }
            if (bytAge >= 18)
            {
                string voterRegistration = Interaction.InputBox("Have you registered for election?" + "Y for Yes and other letters for No. ");
                if (voterRegistration.ToUpper() == "Y")
                {
                    txtDisplay.Text = "You have to register before you can vote.";
                }
                else
                {
                    txtDisplay.Text = "You have to register before you can vote";
                }
            }
            else
            {
                txtDisplay.Text = "You are too young to vote now";
            }

        }

        private void btnVending_Click(object sender, EventArgs e)
        {
            string strAnswer = Interaction.InputBox(@"Type
10 for Pepsi
15 for Coca Cola
18 for Snapple
22 for Ginger Ale
30 for Gatorade");
            switch (strAnswer)
            {

                case "10":
                    txtDisplay.Text = "Here is a Pepsi!";
                    break;
                case "15":
                    txtDisplay.Text = "Here is a Coca Cola!";
                    break;
                case "18":
                    txtDisplay.Text = "Here is a Snapple!";
                    break;
                case "22":
                    txtDisplay.Text = "Here is a Ginger Ale!";
                    break;
                case "30":
                    txtDisplay.Text = "Here is a Gatorade!";
                    break;
                default:
                    txtDisplay.Text = strAnswer + " is a wrong entry, Try again!";
                    break;
            }
        }

        private void btnDriver_Click(object sender, EventArgs e)
        {
            byte byteAge = 0;
            string strAge = Interaction.InputBox("How old are you?" +
                Environment.NewLine + "If you are 18 tomorrow, you should answer 17.");
            if (byte.TryParse(strAge, out byteAge) == false)
            {
                txtDisplay.Text = "Please enter a reasonable integer number for age. " +
                    strAge + " is not correct. Try again.";
                return;
            }
            if (byteAge >= 18)
            {
                txtDisplay.Text = "You should apply for a driver license";
            }
            else if (byteAge == 16 && byteAge == 17)
            {
                txtDisplay.Text = "You may apply for a driving permit, and drive under supervision.";
            }
            else if (byteAge <= 16)
            {
                txtDisplay.Text = "You are too young to drive.";
            }
            else if (byteAge >= 65)
            {
                txtDisplay.Text = "You are so old for a driving permit";
            }
            
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string Country = cboCountry.Text;

            switch (Country)
            {
                case "Venezuela":

                    txtDisplay.Text = "Caracas";
                    break;
                case "United State":
                    txtDisplay.Text = "Washington";
                    break;
            }
        }

    }
}
