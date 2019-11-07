using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Light
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void SwitchOnOff()
        {
            if (btnSwitchOn.Text == "Switch Off")

            {
                picLightOn.Visible = false;
                picLightOff.Visible = true;
                btnSwitchOn.Text = "Switch On";
            }
            else
            {

                picLightOn.Visible = true;
                picLightOff.Visible = false;
                btnSwitchOn.Text = "Switch Off";
            }
        }

        private void btnSwitchOn2_Click(object sender, EventArgs e)
        {
            SwitchOnOffVersion2();
        }

        private void picLightOff_Click(object sender, EventArgs e)
        {

        }

        private void btnSwitchOn_Click(object sender, EventArgs e)
        {
            SwitchOnOff();

        }

        private void SwitchOnOffVersion2()
        {
            if (btnSwitch2.Text == "Switch On")
            {

                picLight.Image = Light.Properties.Resources.lightOn;
                btnSwitch2.Text = "Swith Off";
            }
            else
            {
                picLight.Image = Light.Properties.Resources.lightOff;
                btnSwitch2.Text = "Switch On";
            }
        }

        private void btnTurnYellow_Click(object sender, EventArgs e)
        {
            turnYellow();
        }
        private void turnYellow()
        {
            this.BackColor = Color.Yellow;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
