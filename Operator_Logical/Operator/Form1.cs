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

namespace Operator
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

        private void btnConjunction_Click(object sender, EventArgs e)
        {
            string strIncomeCondition = Interaction.InputBox(" Do you have a coupon? type Y for Yes");
            string strResidency = Interaction.InputBox("Are you legal residen in New York State?");
            if (strIncomeCondition.ToUpper() == "Y" && strResidency.ToUpper() == "Y")
            {
                txtDisplay.Text = "You are eligible for the state aid package. Please fill out this form.";

            }

           else
            {
                txtDisplay.Text = "Sorry, you are not eligible for the state package";
            }
        }

        private void btnDisjunction_Click(object sender, EventArgs e)
        {
            string strCoupon = Interaction.InputBox("Do you have a coupon? type Y for Yes");
            string strMembershipCard = Interaction.InputBox(" Do you have a membership card?");
            if (strCoupon.ToUpper() == "Y" || strMembershipCard.ToUpper() == "Y")
            {
                txtDisplay.Text = "Ypu get a 10 % discount. 18 dollars";
            }
            else {

                txtDisplay.Text = "20 dollars please.";
            }
        }

        private void btnNegation_Click(object sender, EventArgs e)
        {
            string strUser = Interaction.InputBox(" Is that recyclable? Y for Yes and other letters for No.");
            if (!(strUser.ToUpper() == "Y"))
            {
                txtDisplay.Text = "Throw it in the garbage can.";
            }
            else {
                txtDisplay.Text = "Put it in the recycle can";
            }
        }

        private void btnExclusive_Click(object sender, EventArgs e)
        {
            string strErader = Interaction.InputBox("Do you want a eReader? Y for Yes.");
            string strCellphone = Interaction.InputBox("Do you want a cellphone? Y for Yes.");

            if (strErader.ToUpper() == "Y" ^ strCellphone.ToUpper() == "Y")
            {
                txtDisplay.Text = "You get what you want";
            }
            else {
                txtDisplay.Text = "You get nothing.";            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int c = 600;
            while (c <= 700)
            {

                txtDisplay.Text += c.ToString() + Environment.NewLine;
                c -= 1;

            }
        }
    }
}
