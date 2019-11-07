namespace Operator
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
            this.txtDisplay = new System.Windows.Forms.TextBox();
            this.btnExclusive = new System.Windows.Forms.Button();
            this.btnDisjunction = new System.Windows.Forms.Button();
            this.btnNegation = new System.Windows.Forms.Button();
            this.btnConjunction = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtDisplay
            // 
            this.txtDisplay.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDisplay.Location = new System.Drawing.Point(36, 12);
            this.txtDisplay.Multiline = true;
            this.txtDisplay.Name = "txtDisplay";
            this.txtDisplay.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtDisplay.Size = new System.Drawing.Size(545, 237);
            this.txtDisplay.TabIndex = 0;
            // 
            // btnExclusive
            // 
            this.btnExclusive.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExclusive.Location = new System.Drawing.Point(340, 346);
            this.btnExclusive.Name = "btnExclusive";
            this.btnExclusive.Size = new System.Drawing.Size(241, 29);
            this.btnExclusive.TabIndex = 1;
            this.btnExclusive.Text = "Logical Exclusive Disjuction";
            this.btnExclusive.UseVisualStyleBackColor = true;
            this.btnExclusive.Click += new System.EventHandler(this.btnExclusive_Click);
            // 
            // btnDisjunction
            // 
            this.btnDisjunction.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDisjunction.Location = new System.Drawing.Point(340, 270);
            this.btnDisjunction.Name = "btnDisjunction";
            this.btnDisjunction.Size = new System.Drawing.Size(241, 29);
            this.btnDisjunction.TabIndex = 2;
            this.btnDisjunction.Text = "Logical Disjunction";
            this.btnDisjunction.UseVisualStyleBackColor = true;
            this.btnDisjunction.Click += new System.EventHandler(this.btnDisjunction_Click);
            // 
            // btnNegation
            // 
            this.btnNegation.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNegation.Location = new System.Drawing.Point(36, 346);
            this.btnNegation.Name = "btnNegation";
            this.btnNegation.Size = new System.Drawing.Size(241, 29);
            this.btnNegation.TabIndex = 3;
            this.btnNegation.Text = "Logical Negation";
            this.btnNegation.UseVisualStyleBackColor = true;
            this.btnNegation.Click += new System.EventHandler(this.btnNegation_Click);
            // 
            // btnConjunction
            // 
            this.btnConjunction.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConjunction.Location = new System.Drawing.Point(36, 270);
            this.btnConjunction.Name = "btnConjunction";
            this.btnConjunction.Size = new System.Drawing.Size(241, 29);
            this.btnConjunction.TabIndex = 4;
            this.btnConjunction.Text = "Logical Conjuction";
            this.btnConjunction.UseVisualStyleBackColor = true;
            this.btnConjunction.Click += new System.EventHandler(this.btnConjunction_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(611, 409);
            this.Controls.Add(this.btnConjunction);
            this.Controls.Add(this.btnNegation);
            this.Controls.Add(this.btnDisjunction);
            this.Controls.Add(this.btnExclusive);
            this.Controls.Add(this.txtDisplay);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtDisplay;
        private System.Windows.Forms.Button btnExclusive;
        private System.Windows.Forms.Button btnDisjunction;
        private System.Windows.Forms.Button btnNegation;
        private System.Windows.Forms.Button btnConjunction;
    }
}

