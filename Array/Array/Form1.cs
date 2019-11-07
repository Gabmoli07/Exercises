using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Array
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        string[] ZodiacSign = new string[12];
        string[] ZodiacDate = new string[12];

        string[] monthName = new string[3];
        private void Form1_Load(object sender, EventArgs e)
        {
            monthlySales[0] = 2300;
            monthlySales[1] = 1938;
            monthlySales[2] = 2399;
            monthName[0] = "January";
            monthName[1] = "February";
            monthName[2] = "March";

            ZodiacSign[0] = "Aries The Ram";
            ZodiacDate[0] = "Mar. 21 apr. 19";
            ZodiacSign[1] = "Taurus The Bull";
            ZodiacDate[1] = "apr. 30 May 20";
            ZodiacSign[2] = "Gemini The twins";
            ZodiacDate[2] = "May 21 June 21";
            ZodiacSign[3] = "Cancer The Crab";
            ZodiacDate[3] = "June 22 July 22";
            ZodiacSign[4] = "Leo The Lion";
            ZodiacDate[4] = "July 23 Aug. 22";
            ZodiacSign[5] = "Virgo The Virgin";
            ZodiacDate[5] = "Agu.23 Sep. 22";
            ZodiacSign[6] = "Libra The Balance";
            ZodiacDate[6] = "Sep. 23 Oct 23";
            ZodiacSign[7] = "Scorpio The Scorpion";
            ZodiacDate[7] = "Oct 24 Nove. 21";
            ZodiacSign[8] = "Sagittarius The Archer";
            ZodiacDate[8] = "Nov. 22 Dec. 21";
            ZodiacSign[9] = "Apricorn The Goat";
            ZodiacDate[9] = "Dec. 22 Jan. 19";
            ZodiacSign[10] = "Aquarius The Water Bearer";
            ZodiacDate[10] = "Jan. 20 Feb 18";
            ZodiacSign[11] = "Pisces The Fishes";
            ZodiacDate[11] = "Feb. 19 Mar. 20";
            foreach (string x in ZodiacSign)
            {

                cboZodiac.Items.Add(x);
            }

            cboZodiac.SelectedIndex = 0;
        }

        private void btnArray_Click(object sender, EventArgs e)
        {
            string[] teamMembers = new string[5];
            teamMembers[0]= "Jane";
            teamMembers[1]= "Jack";
            teamMembers[2]= "Timothy";
            teamMembers[3]= "Mary";
            teamMembers[4]= "Elizabeth";

            for (int x = 0; x < 5; x++)
            {
                rtbDisplay.AppendText(teamMembers[x] +
                    Environment.NewLine);
            }
            for (int x = 4; x >= 0; x--)
            {
                rtbDisplay.AppendText(teamMembers[x] +
                    Environment.NewLine);
            }
        }

        double[] monthlySales = new double[3];

        private void btnSearch_Click(object sender, EventArgs e)
        {
            rtbDisplay.Clear();
            rtbDisplay.Text = "Monthly Sales under 2000 are listed below:"
                + Environment.NewLine;
            double y;
            for (int x = 0; x < monthlySales.Length; x++)
            {
                y = monthlySales[x];
                if (y < 2000)
                {
                    rtbDisplay.AppendText(y.ToString() + Environment.NewLine);
                }

            }
        }

        private void btnArrayInitialized_Click(object sender, EventArgs e)
        {
            rtbDisplay.Clear();
            string[] phones = new string[] { "iPhone", "Samsung", "Nokia Lumia" };
           for(int x = 0; x < 3; x++)
            {
                rtbDisplay.AppendText(phones[x] + Environment.NewLine);

            }
           foreach (string x in phones)
            {
                rtbDisplay.AppendText(x + Environment.NewLine);

            }
            int y = 0;
            while (y < phones.Length)
            {
                rtbDisplay.AppendText(y + Environment.NewLine);
                y++;
            }


        }

        private void btnArrayMath_Click(object sender, EventArgs e)
        {
            rtbDisplay.Clear();
            foreach (double x in monthlySales)
            {
                rtbDisplay.AppendText(x.ToString() + Environment.NewLine);
            }
            double total = 0, average, largest, smallest;

            foreach (double x in monthlySales)
            {
                total += x;

            }
            {
                average = total / monthlySales.Length;
                largest = monthlySales[0];
                for (int x = 1; x < monthlySales.Length; x++)
                {
                    if (monthlySales[x]> largest)
                        {
                        largest = monthlySales[x];
                    }
                }
                smallest = monthlySales[0];
                for (int x = 1; x < monthlySales.Length; x++)
                {
                    if (monthlySales[x] < smallest)
                    {
                        smallest = monthlySales[x];
                    }
                }
                rtbDisplay.AppendText("Total Sales: " +
                    total.ToString() + Environment.NewLine +
                    "Average Sales: " + average.ToString() + Environment.NewLine +
                    "largest Sales: " + largest.ToString() + Environment.NewLine +
                    "smallest sales: " + smallest.ToString());
           }
        }

        private void btnResizing_Click(object sender, EventArgs e)
        {
            System.Array.Resize(ref monthlySales, 6);
            monthlySales[3] = 3913;
            monthlySales[4] = 2878;
            monthlySales[5] = 3110;
            foreach (double x in monthlySales)
            {
                rtbDisplay.AppendText(x + Environment.NewLine);
                
            }
        }

        private void btnSorting_Click(object sender, EventArgs e)
        {
            rtbDisplay.Text = "Before sorting: " + Environment.NewLine;
            foreach (double x in monthlySales)
                rtbDisplay.AppendText(x + Environment.NewLine);
            System.Array.Sort(monthlySales);
            rtbDisplay.AppendText(" After sorting: " + Environment.NewLine);
            foreach (double x in monthlySales)
                rtbDisplay.AppendText(x + Environment.NewLine);
        }

        private void btnAccesing_Click(object sender, EventArgs e)
        {
            rtbDisplay.Text = "The 3rd Zodiac sign is: " + ZodiacSign[2];

            ZodiacSign[6] = "Libra the Scale";

            foreach (string x in ZodiacSign)
            {
                rtbDisplay.AppendText(Environment.NewLine + x);

            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            int x = cboZodiac.SelectedIndex;
            rtbDisplay.Text = ZodiacDate[x];
        }

        private void button3_Click(object sender, EventArgs e)
        {
            System.Array.Resize(ref ZodiacSign, 13);

            for (int x =11; x >= 5; x--);
        }
    }
}