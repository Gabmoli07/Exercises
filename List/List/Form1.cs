using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;


namespace List
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        List<string> zodiacList = new List<string>();

        private void btnList_Click(object sender, EventArgs e)
        {
            List<string> teamMembers = new List<string>();
            teamMembers.Add("John");
            teamMembers.Add("Mary");
            teamMembers.Add("Tim");
            teamMembers.Add("Margaret");
            foreach(string X in teamMembers)
            {

                rtbDisplay.AppendText(X + Environment.NewLine);

            }
        }

        private void btnlistInitialization_Click(object sender, EventArgs e)
        {
            List<string> teamMember = new List<string>() { "John", "Mary", "Tim", "Margaret" };
            foreach (string X in teamMember)
            {
                rtbDisplay.AppendText(X + Environment.NewLine);
            }
            teamMember.Add("Edward");

            teamMember.Insert(1, "Peter");

            teamMember.Remove("Tim");
            rtbDisplay.AppendText("Edward added, Peter Inserted and Tim removed" + Environment.NewLine);
            for (int x = 0; x < teamMember.Count(); x++)
            {
                rtbDisplay.AppendText(teamMember[x] + Environment.NewLine);
            }

            teamMember.Sort();
            rtbDisplay.AppendText("After sorting: " + Environment.NewLine);
            for (int x = 0; x < teamMember.Count(); x++)
            {
                rtbDisplay.AppendText(teamMember[x] + Environment.NewLine);
            }
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            string zodiac =
                System.IO.File.ReadAllText(@"U;\data\zodiac.txt");
            string[] x = zodiac.Split(',');
            zodiacList = x.ToList<string>();
        }

        private void btnIndex_Click(object sender, EventArgs e)
        {
            rtbDisplay.Clear();
            foreach (string x in zodiacList)
            {
                if (x.ToUpper().Contains(txtInput.Text.ToUpper())) ;
                rtbDisplay.AppendText(x + Environment.NewLine);
            }
          if (rtbDisplay.TextLength!= 0)
            {
                rtbDisplay.Text = txtInput.Text + " is found: "
                    + Environment.NewLine + rtbDisplay.Text;

            }
          else
            {

                rtbDisplay.Text = txtInput.Text + " is not found: ";
            }
        }
    }
}
