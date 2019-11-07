namespace Parameters
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
            this.btnChangeColor = new System.Windows.Forms.Button();
            this.btnTurnYellow = new System.Windows.Forms.Button();
            this.btnChangeColor2 = new System.Windows.Forms.Button();
            this.btnGoodMornig = new System.Windows.Forms.Button();
            this.btnPassing = new System.Windows.Forms.Button();
            this.btnPassing2 = new System.Windows.Forms.Button();
            this.txtDisplay = new System.Windows.Forms.TextBox();
            this.lblMessage = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnChangeColor
            // 
            this.btnChangeColor.Location = new System.Drawing.Point(59, 52);
            this.btnChangeColor.Name = "btnChangeColor";
            this.btnChangeColor.Size = new System.Drawing.Size(137, 42);
            this.btnChangeColor.TabIndex = 0;
            this.btnChangeColor.Text = "Change Color \r\nNo Parameter";
            this.btnChangeColor.UseVisualStyleBackColor = true;
            this.btnChangeColor.Click += new System.EventHandler(this.btnChangeColor_Click);
            // 
            // btnTurnYellow
            // 
            this.btnTurnYellow.Location = new System.Drawing.Point(217, 52);
            this.btnTurnYellow.Name = "btnTurnYellow";
            this.btnTurnYellow.Size = new System.Drawing.Size(137, 42);
            this.btnTurnYellow.TabIndex = 1;
            this.btnTurnYellow.Text = "Turn Yellow";
            this.btnTurnYellow.UseVisualStyleBackColor = true;
            this.btnTurnYellow.Click += new System.EventHandler(this.btnTurnYellow_Click);
            // 
            // btnChangeColor2
            // 
            this.btnChangeColor2.Location = new System.Drawing.Point(59, 118);
            this.btnChangeColor2.Name = "btnChangeColor2";
            this.btnChangeColor2.Size = new System.Drawing.Size(137, 42);
            this.btnChangeColor2.TabIndex = 2;
            this.btnChangeColor2.Text = "Change Color \r\nWith a Parameter";
            this.btnChangeColor2.UseVisualStyleBackColor = true;
            this.btnChangeColor2.Click += new System.EventHandler(this.btnChangeColor2_Click);
            // 
            // btnGoodMornig
            // 
            this.btnGoodMornig.Location = new System.Drawing.Point(59, 179);
            this.btnGoodMornig.Name = "btnGoodMornig";
            this.btnGoodMornig.Size = new System.Drawing.Size(137, 42);
            this.btnGoodMornig.TabIndex = 3;
            this.btnGoodMornig.Text = "Good Morning";
            this.btnGoodMornig.UseVisualStyleBackColor = true;
            this.btnGoodMornig.Click += new System.EventHandler(this.btnGoodMornig_Click);
            // 
            // btnPassing
            // 
            this.btnPassing.Location = new System.Drawing.Point(217, 118);
            this.btnPassing.Name = "btnPassing";
            this.btnPassing.Size = new System.Drawing.Size(137, 42);
            this.btnPassing.TabIndex = 4;
            this.btnPassing.Text = "Passing value \r\nAs reference";
            this.btnPassing.UseVisualStyleBackColor = true;
            this.btnPassing.Click += new System.EventHandler(this.btnPassing_Click_1);
            // 
            // btnPassing2
            // 
            this.btnPassing2.Location = new System.Drawing.Point(217, 179);
            this.btnPassing2.Name = "btnPassing2";
            this.btnPassing2.Size = new System.Drawing.Size(137, 42);
            this.btnPassing2.TabIndex = 5;
            this.btnPassing2.Text = "Passing value \r\nFor Output";
            this.btnPassing2.UseVisualStyleBackColor = true;
            this.btnPassing2.Click += new System.EventHandler(this.btnPassing2_Click_1);
            // 
            // txtDisplay
            // 
            this.txtDisplay.Location = new System.Drawing.Point(59, 252);
            this.txtDisplay.Multiline = true;
            this.txtDisplay.Name = "txtDisplay";
            this.txtDisplay.Size = new System.Drawing.Size(295, 99);
            this.txtDisplay.TabIndex = 6;
            // 
            // lblMessage
            // 
            this.lblMessage.AutoSize = true;
            this.lblMessage.Location = new System.Drawing.Point(170, 10);
            this.lblMessage.Name = "lblMessage";
            this.lblMessage.Size = new System.Drawing.Size(35, 13);
            this.lblMessage.TabIndex = 8;
            this.lblMessage.Text = "label1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.ClientSize = new System.Drawing.Size(380, 363);
            this.Controls.Add(this.lblMessage);
            this.Controls.Add(this.txtDisplay);
            this.Controls.Add(this.btnPassing2);
            this.Controls.Add(this.btnPassing);
            this.Controls.Add(this.btnGoodMornig);
            this.Controls.Add(this.btnChangeColor2);
            this.Controls.Add(this.btnTurnYellow);
            this.Controls.Add(this.btnChangeColor);
            this.Name = "Form1";
            this.Text = " ";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnChangeColor;
        private System.Windows.Forms.Button btnTurnYellow;
        private System.Windows.Forms.Button btnChangeColor2;
        private System.Windows.Forms.Button btnGoodMornig;
        private System.Windows.Forms.Button btnPassing;
        private System.Windows.Forms.Button btnPassing2;
        private System.Windows.Forms.TextBox txtDisplay;
        private System.Windows.Forms.Label lblMessage;
    }
}

