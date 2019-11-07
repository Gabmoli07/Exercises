using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Enumated
{

    enum Majors
    {
        InformationTechnology, English, Psycology, Literature, Philosophy, Physics, Chemistry, Music
    }

    enum emPloyeeType
    {
        Production, RnD, sales,
        management, maintance
    }
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnMajors_Click(object sender, EventArgs e)
        {
            rtbDisplay.Text = @"We offer the following majors:
" + Majors.Chemistry + @"
" + Majors.English + @"
" + Majors.InformationTechnology + @"
" + Majors.Literature + @"
" + Majors.Music + @"
" + Majors.Philosophy + ".";

        }

        private void btnEnumerators_Click(object sender, EventArgs e)
        {
            rtbDisplay.Text = @"Enumarators are stored in computer memory as integer:
";
                foreach (Majors x in Enum.GetValues(typeof(Majors)))
            {
                rtbDisplay.AppendText(x.ToString() + " is stored as " +
                    (int)x + Environment.NewLine);
            }
        }

        private void btnVariable_Click(object sender, EventArgs e)
        {
            emPloyeeType workRole = emPloyeeType.maintance;
            Employee newHireA = new Employee("John", workRole);
            rtbDisplay.Text = newHireA.Name + " worked in the area of" + newHireA.TypeOfWork + ".";
            workRole = emPloyeeType.management;
            newHireA.TypeOfWork = workRole;
            rtbDisplay.Text += @"
He now works at " + newHireA.TypeOfWork;
        }
    }
}
