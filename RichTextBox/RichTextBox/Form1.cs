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

namespace RichTextBox
{
    
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        bool isFirstTime = true;
        private void saveAsTextDocumentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog sFile = new SaveFileDialog();
            sFile.Title = "Navigate to the right folder and type the name of the file to be saved.";
            sFile.InitialDirectory = @"U:\data";
            sFile.Filter = "Text files(*.txt)|*.txt|All file (*.*)|*.*";
            DialogResult dResult = sFile.ShowDialog();
            try
            {
                if (dResult == DialogResult.OK)
                {
                    StreamWriter outFile = new StreamWriter(sFile.FileName);
                    outFile.Write(rtbEditor.Text);
                    outFile.Close();
                    currentPath = sFile.FileName;
                    this.Text = currentPath;
                    MessageBox.Show(sFile.FileName + " is saved.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        string currentPath = "";
        private void openTextFileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog oFile = new OpenFileDialog();
            oFile.Title = "Choose the file to be opened.";
            oFile.InitialDirectory = @"U:\data";
            oFile.Filter =
            "Text files(*.txt)|*.txt|All file (*.*)|*.*";
            if (oFile.ShowDialog() == DialogResult.OK)
            {
                currentPath = oFile.FileName;
                StreamReader infile = new StreamReader(currentPath);
                rtbEditor.Text = infile.ReadToEnd();
                this.Text = currentPath;
            }
        }

        private void openRTFDocumentToolStripMenuItem_Click(object sender, EventArgs e)
        {

            OpenFileDialog oFile = new OpenFileDialog();
            oFile.Title = "Choose a RTF file to be oponed.";
            oFile.InitialDirectory = @"U:\data";
            oFile.Filter =
                "RTF file(*.rtf)|*.rtf|All file (*.*)|*.*";
            if (oFile.ShowDialog() == DialogResult.OK && oFile.FileName.Length > 0)
            {
                try
                {
                    rtbEditor.LoadFile(oFile.FileName);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                currentPath = oFile.FileName;
                this.Text = currentPath;
            }
        }

        private void saveAsRTFDocumentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog sFile = new SaveFileDialog();
            sFile.Title = "Click the Save Button save yout file in rtf format.";
            sFile.DefaultExt = "rtf";
            sFile.Filter = "RTF files(*.rtf)|*.rtf|All Files(*.*)|*.*";
            DialogResult dResult = sFile.ShowDialog();
            try
            {
                if (dResult == DialogResult.OK && sFile.FileName.Length > 0)
                {
                    rtbEditor.SaveFile(sFile.FileName);
                    currentPath = sFile.FileName;
                    this.Text = currentPath;
                    MessageBox.Show(sFile.FileName + " is saved.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Welcome wform = new Welcome();
            wform.ShowDialog();
        }

        
        private void openFileInANewWindowToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
                Form1 anotherWindow = new Form1();
                anotherWindow.isFirstTime = false;
                anotherWindow.Show();
            
        }

        private void closeFileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            {
                DialogResult x = MessageBox.Show("Do you want to save the content?",
                "File saving confirmation", MessageBoxButtons.YesNo);
                if (x == DialogResult.Yes)
                {
                    if (currentPath != "")
                    {
                        rtbEditor.SaveFile(currentPath);
                    }
                    else
                    {
                        SaveFileDialog sFile = new SaveFileDialog();
                        sFile.Title = "Click the Save button to save your file in rtf format.";
                        sFile.InitialDirectory = @"U:\Data";
                        sFile.DefaultExt = "rtf";
                        sFile.Filter = "RTF file(*.rtf)|*.rtf|All Files(*.*)|*.*";
                        DialogResult dResult = sFile.ShowDialog();
                        try
                        {
                            if (dResult == DialogResult.OK && sFile.FileName.Length > 0)
                            {
                                rtbEditor.SaveFile(sFile.FileName);
                                MessageBox.Show(sFile.FileName + " is saved.");
                            }
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show(ex.Message);
                        }
                    }
                }
                rtbEditor.Clear();
                this.Text = "Super Editor";
            }
        }

        private void btnNormal_Click(object sender, EventArgs e)
        {
            Font new1, old1;
            old1 = rtbEditor.SelectionFont;
            new1 = new Font(old1, FontStyle.Regular);
            rtbEditor.SelectionFont = new1;
            rtbEditor.Focus();
        }

        private void btnBold_Click(object sender, EventArgs e)
        {
            Font new1, old1;
            old1 = rtbEditor.SelectionFont;
            if (old1.Bold)

                new1 = new Font(old1, old1.Style & ~FontStyle.Bold);


            else

                new1 = new Font(old1, old1.Style | FontStyle.Bold);

            rtbEditor.SelectionFont = new1;
            rtbEditor.Focus();
        }


        private void btnItalic_Click(object sender, EventArgs e)
        {
            Font new1, old1;
            old1 = rtbEditor.SelectionFont;
            if (old1.Italic)
                new1 = new Font(old1, old1.Style & ~FontStyle.Italic);
            else
                new1 = new Font(old1, old1.Style | FontStyle.Italic);

            rtbEditor.SelectionFont = new1;
            rtbEditor.Focus();
        }

        private void btnUnder_Click(object sender, EventArgs e)
        {
            Font new1, old1;
            old1 = rtbEditor.SelectionFont;
            if (old1.Underline)

                new1 = new Font(old1, old1.Style & ~FontStyle.Underline);


            else

                new1 = new Font(old1, old1.Style | FontStyle.Underline);

            rtbEditor.SelectionFont = new1;
            rtbEditor.Focus();

        }


        private void cboSize_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            int x = int.Parse(cboSize.SelectedItem.ToString());
            if (rtbEditor.SelectionLength > 0)
            {
                Font currentFont = rtbEditor.SelectionFont;
                rtbEditor.SelectionFont = new Font(currentFont.FontFamily, x, currentFont.Style);
                rtbEditor.Focus();
            }
        }

        private void Form1_Load_1(object sender, EventArgs e)
        {
            if (isFirstTime)
            {


                Welcome wform = new Welcome();
                wform.ShowDialog();
            }
        }
    }
}