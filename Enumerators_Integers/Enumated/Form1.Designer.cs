namespace Enumated
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnMajors = new System.Windows.Forms.Button();
            this.btnEnumerators = new System.Windows.Forms.Button();
            this.btnVariable = new System.Windows.Forms.Button();
            this.rtbDisplay = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // btnMajors
            // 
            this.btnMajors.Font = new System.Drawing.Font("Century", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMajors.Location = new System.Drawing.Point(32, 45);
            this.btnMajors.Name = "btnMajors";
            this.btnMajors.Size = new System.Drawing.Size(137, 59);
            this.btnMajors.TabIndex = 0;
            this.btnMajors.Text = "Majors";
            this.btnMajors.UseVisualStyleBackColor = true;
            this.btnMajors.Click += new System.EventHandler(this.btnMajors_Click);
            // 
            // btnEnumerators
            // 
            this.btnEnumerators.Font = new System.Drawing.Font("Century", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEnumerators.Location = new System.Drawing.Point(196, 45);
            this.btnEnumerators.Name = "btnEnumerators";
            this.btnEnumerators.Size = new System.Drawing.Size(137, 59);
            this.btnEnumerators.TabIndex = 1;
            this.btnEnumerators.Text = "Enumarators\r\nand Integers";
            this.btnEnumerators.UseVisualStyleBackColor = true;
            this.btnEnumerators.Click += new System.EventHandler(this.btnEnumerators_Click);
            // 
            // btnVariable
            // 
            this.btnVariable.Font = new System.Drawing.Font("Century", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVariable.Location = new System.Drawing.Point(357, 45);
            this.btnVariable.Name = "btnVariable";
            this.btnVariable.Size = new System.Drawing.Size(137, 59);
            this.btnVariable.TabIndex = 2;
            this.btnVariable.Text = "enum variable";
            this.btnVariable.UseVisualStyleBackColor = true;
            this.btnVariable.Click += new System.EventHandler(this.btnVariable_Click);
            // 
            // rtbDisplay
            // 
            this.rtbDisplay.Location = new System.Drawing.Point(25, 160);
            this.rtbDisplay.Name = "rtbDisplay";
            this.rtbDisplay.Size = new System.Drawing.Size(469, 140);
            this.rtbDisplay.TabIndex = 3;
            this.rtbDisplay.Text = "";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(518, 326);
            this.Controls.Add(this.rtbDisplay);
            this.Controls.Add(this.btnVariable);
            this.Controls.Add(this.btnEnumerators);
            this.Controls.Add(this.btnMajors);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnMajors;
        private System.Windows.Forms.Button btnEnumerators;
        private System.Windows.Forms.Button btnVariable;
        private System.Windows.Forms.RichTextBox rtbDisplay;
    }
}

