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

namespace StreamReaderProject
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnReadFile_Click(object sender, EventArgs e)
        {
            try
            {
                string someString;
                StreamReader inFile;
                inFile = File.OpenText(@"U:\data\attendance.txt");
                someString = inFile.ReadLine();
                txtDisplay.Text = someString + Environment.NewLine +
                    "The above line was returned by ReadLine method." +
                    Environment.NewLine;
                someString = inFile.Read().ToString();
                txtDisplay.AppendText(someString + Environment.NewLine +
                    "The above was retunerd by Read method." +
                    Environment.NewLine);
                someString = inFile.ReadToEnd();
                txtDisplay.AppendText(someString + Environment.NewLine +
                    "The above lines was returned by ReadToEnd methos.");
                inFile.Close();


            }
            catch (Exception ex)
            {
                txtDisplay.AppendText(ex.Message);
            }
        }

        private void btnReverse_Click(object sender, EventArgs e)
        {
            try
            {
                txtDisplay.Clear();
                StreamReader inFile = new StreamReader(@"U:\data\numberlist.txt");
                while (inFile.Peek() != -1)
                {
                    txtDisplay.Text = inFile.ReadLine() + Environment.NewLine + txtDisplay.Text;

                }
                inFile.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            try
            {
                txtDisplay.Clear();
                string line;
                StreamReader inFile = new StreamReader(@"U:\data\NYzipcode.txt");
                while (inFile.Peek() != -1)
                {
                    line = inFile.ReadLine();
                    if (line.ToUpper().Contains("Washington"))
                    {
                        txtDisplay.AppendText(line + Environment.NewLine);
                    }

                }
                if (txtDisplay.TextLength == 0)
                {
                    txtDisplay.Text = txtInput.Text + " is not found.";
                }
                inFile.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnWrite_Click(object sender, EventArgs e)
        {
            try
            {
                StreamWriter outFile = new StreamWriter(@"U:\data\New File.txt", false);
                outFile.Write(txtDisplay.Text);
                outFile.Close();
                txtDisplay.Text = "The file has been saved successfully.";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnWriterNumber_Click(object sender, EventArgs e)
        {
            StreamWriter outFile;
            outFile = File.AppendText(@"U:\data\ReverseHundred.txt");
            for (int x = 100; x >= 0; x--)
            {
                outFile.WriteLine(x.ToString());
            }
            outFile.Close();
            txtDisplay.Text = "File successfully saved.";
        }

        private void openFileToolStripMenuItem_click(object sender, EventArgs e)
        {

            StreamWriter outFile;
            outFile = File.AppendText(@"U:\data\ReverseHundred.txt");
            for (int x = 100; x >= 0; x--)
            {
                outFile.WriteLine(x.ToString());

            }
            outFile.Close();
            txtDisplay.Text = "File successfully saved.";
        }

        private void fileToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void saveFileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog sd = new SaveFileDialog();
            sd.Title = "Choose a path and type the file name.";
            sd.InitialDirectory = @"U\";
            sd.Filter =
                "Text files(*.txt)|*.txt|All files(*.*) | *.*";
            DialogResult x = sd.ShowDialog();
            if (x == DialogResult.OK)
            {
                try

                {
                    StreamWriter sw = new StreamWriter(sd.FileName);
                    sw.Write(txtDisplay.Text);
                    sw.Close();
                    MessageBox.Show(sd.FileName + " has been saved.");
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void openFileToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Title = "Select the text file to be oponed.";
            ofd.InitialDirectory = @"U:\";
            ofd.Filter = "Text files(*.txt)|*.txt|All files(*.*)|*.*";
            DialogResult f = ofd.ShowDialog();
                if (f == DialogResult.OK)
            {
                try
                {
                    StreamReader r = new StreamReader(ofd.FileName);
                    txtDisplay.Text = r.ReadToEnd();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }

        }
    }
}
