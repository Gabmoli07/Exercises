namespace Abstract
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
            this.btnPayRise2 = new System.Windows.Forms.Button();
            this.btnManger = new System.Windows.Forms.Button();
            this.btnProduction = new System.Windows.Forms.Button();
            this.btnPayRise = new System.Windows.Forms.Button();
            this.lblName = new System.Windows.Forms.Label();
            this.rtbDisplay = new System.Windows.Forms.RichTextBox();
            this.txtInput = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnPayRise2
            // 
            this.btnPayRise2.Location = new System.Drawing.Point(137, 102);
            this.btnPayRise2.Name = "btnPayRise2";
            this.btnPayRise2.Size = new System.Drawing.Size(116, 45);
            this.btnPayRise2.TabIndex = 0;
            this.btnPayRise2.Text = "PayRise";
            this.btnPayRise2.UseVisualStyleBackColor = true;
            // 
            // btnManger
            // 
            this.btnManger.Location = new System.Drawing.Point(3, 102);
            this.btnManger.Name = "btnManger";
            this.btnManger.Size = new System.Drawing.Size(116, 45);
            this.btnManger.TabIndex = 1;
            this.btnManger.Text = "Mager John";
            this.btnManger.UseVisualStyleBackColor = true;
            // 
            // btnProduction
            // 
            this.btnProduction.Location = new System.Drawing.Point(3, 16);
            this.btnProduction.Name = "btnProduction";
            this.btnProduction.Size = new System.Drawing.Size(116, 45);
            this.btnProduction.TabIndex = 2;
            this.btnProduction.Text = "Production\r\nWorker Ted";
            this.btnProduction.UseVisualStyleBackColor = true;
            // 
            // btnPayRise
            // 
            this.btnPayRise.Location = new System.Drawing.Point(137, 16);
            this.btnPayRise.Name = "btnPayRise";
            this.btnPayRise.Size = new System.Drawing.Size(116, 45);
            this.btnPayRise.TabIndex = 3;
            this.btnPayRise.Text = "PayRise";
            this.btnPayRise.UseVisualStyleBackColor = true;
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(304, 48);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(75, 13);
            this.lblName.TabIndex = 4;
            this.lblName.Text = "Percent raised";
            this.lblName.Click += new System.EventHandler(this.label1_Click);
            // 
            // rtbDisplay
            // 
            this.rtbDisplay.Location = new System.Drawing.Point(19, 218);
            this.rtbDisplay.Name = "rtbDisplay";
            this.rtbDisplay.Size = new System.Drawing.Size(446, 130);
            this.rtbDisplay.TabIndex = 6;
            this.rtbDisplay.Text = "";
            // 
            // txtInput
            // 
            this.txtInput.Location = new System.Drawing.Point(307, 83);
            this.txtInput.Name = "txtInput";
            this.txtInput.Size = new System.Drawing.Size(100, 20);
            this.txtInput.TabIndex = 7;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(517, 382);
            this.Controls.Add(this.txtInput);
            this.Controls.Add(this.rtbDisplay);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.btnPayRise);
            this.Controls.Add(this.btnProduction);
            this.Controls.Add(this.btnManger);
            this.Controls.Add(this.btnPayRise2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnPayRise2;
        private System.Windows.Forms.Button btnManger;
        private System.Windows.Forms.Button btnProduction;
        private System.Windows.Forms.Button btnPayRise;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.RichTextBox rtbDisplay;
        private System.Windows.Forms.TextBox txtInput;
    }
}

