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

namespace Parameters
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void ChangeColor()
        {
            this.BackColor = Color.Green;
            txtDisplay.Text = "Change Color method has been called.";

        }
        //private void ChangeColor(string colorName)
        //{
        //    switch (colorName.ToUpper())
        //    {
        //        case "GREEN":
        //            this.BackColor = Color.Green;
        //            break;
        //        case "ORANGE":
        //            this.BackColor = Color.Orange;
        //            break;
        //        case "VIOLET":
        //            this.BackColor = Color.Violet;
        //            break;
        //        case "RED":
        //            this.BackColor = Color.Red;
        //            break;
        //        case "YELLOW":
        //            this.BackColor = Color.Yellow;
        //            break;
        //        default:
        //            this.BackColor = Color.White;
        //            break;
        //    }
        //}

        private void btnChangeColor_Click(object sender, EventArgs e)
        {
            ChangeColor();
        }

        private void btnChangeColor2_Click(object sender, EventArgs e)
        {
            string strUser =
                Interaction.InputBox("Please type Green, orange, Violet, Red, or Yellow");
            ChangeColor(strUser);
        }
        private void GoodMorning(string name)
        {
            txtDisplay.Text = "Good morning! " + name + ".";
        }

        private void btnGoodMornig_Click(object sender, EventArgs e)
        {
            string strUser = Interaction.InputBox("What's your name?");
            GoodMorning(strUser);

        }

        private void TurnYellow(Control ctrlA, Control ctrlB)
        {
            ctrlA.BackColor = Color.Yellow;
            ctrlB.BackColor = Color.Yellow;
        }

        private void btnTurnYellow_Click(object sender, EventArgs e)
        {
            TurnYellow(btnChangeColor, txtDisplay);
        }

        private void DoubleIt(ref double someNumber)
        {

            someNumber *= 2;
        }
        double x = 3;

        private void btnPassing_Click(object sender, EventArgs e)
        {
            txtDisplay.Text = "Variable x has a value of " + x.ToString();
            DoubleIt(ref x);
            txtDisplay.AppendText(Environment.NewLine + "It becomes " +
                x.ToString() + " after it is passed to method DoubleIt as an argument.");
        }
        public void divide(double A, double B, out double C)
        {
            C = A / B;
        }

        private void btnPassing2_Click(object sender, EventArgs e)
        {
            txtDisplay.Text = "Variable x has a value of " + x.ToString();
            DoubleIt(ref x);
            txtDisplay.AppendText(Environment.NewLine + "It becomes " +
                x.ToString() + " after it is passed to method DoubleIt as an argument.");
        }

      

        private void btnPassing_Click_1(object sender, EventArgs e)
        {
            txtDisplay.Text = "Variable x has a value of " + x.ToString();
            DoubleIt(ref x);
            txtDisplay.AppendText(Environment.NewLine + "It becomes " +
                x.ToString() + " after it is passed to method DoubleIt as an argument.");
        }

        private void btnPassing2_Click_1(object sender, EventArgs e)
        {
            double x = 20, y = 10, z;
            divide(x, y, out z);
            txtDisplay.Text = x.ToString() + " / " + y.ToString() + " = " + z.ToString();
            x = 88;
            y = 100;
            divide(x, y, out z);
            txtDisplay.AppendText(Environment.NewLine + x.ToString() + " / " +
                y.ToString() + " = " + z.ToString());
        }
        private void EnjoyP ()
        {
            lblMessage.Text = "hello";
        }
        public static Color FromName(String name)
        {
            var color_props = typeof(Color).GetProperties();
            foreach (var c in color_props)
                if (name.Equals(c.Name, StringComparison.OrdinalIgnoreCase))
                    return (Color)c.GetValue(new Color(), null);
            return Color.Transparent;
        }
        private void ChangeColor(string clr)
        {
            this.BackColor = FromName(clr);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string strUser = Interaction.InputBox("What's your hobby?");
            myHobby(strUser);

        }
        private void myHobby (string hobby)
        {
            txtDisplay.Text = "I like" + hobby + ".";
        }
    }
    }



















































































