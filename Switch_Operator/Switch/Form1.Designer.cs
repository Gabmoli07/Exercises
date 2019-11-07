namespace Switch
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
            this.btnPrize = new System.Windows.Forms.Button();
            this.btnDriver = new System.Windows.Forms.Button();
            this.btnVending = new System.Windows.Forms.Button();
            this.btnEligibility = new System.Windows.Forms.Button();
            this.btnWhere = new System.Windows.Forms.Button();
            this.btnMultiple = new System.Windows.Forms.Button();
            this.lblCountries = new System.Windows.Forms.Label();
            this.cboCountry = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // txtDisplay
            // 
            this.txtDisplay.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDisplay.Location = new System.Drawing.Point(12, 23);
            this.txtDisplay.Multiline = true;
            this.txtDisplay.Name = "txtDisplay";
            this.txtDisplay.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtDisplay.Size = new System.Drawing.Size(586, 191);
            this.txtDisplay.TabIndex = 0;
            // 
            // btnPrize
            // 
            this.btnPrize.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPrize.Location = new System.Drawing.Point(403, 308);
            this.btnPrize.Name = "btnPrize";
            this.btnPrize.Size = new System.Drawing.Size(195, 48);
            this.btnPrize.TabIndex = 2;
            this.btnPrize.Text = "Prize";
            this.btnPrize.UseVisualStyleBackColor = true;
            this.btnPrize.Click += new System.EventHandler(this.btnPrize_Click);
            // 
            // btnDriver
            // 
            this.btnDriver.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDriver.Location = new System.Drawing.Point(202, 308);
            this.btnDriver.Name = "btnDriver";
            this.btnDriver.Size = new System.Drawing.Size(195, 48);
            this.btnDriver.TabIndex = 3;
            this.btnDriver.Text = "Driver License\r\nswitch statement";
            this.btnDriver.UseVisualStyleBackColor = true;
            this.btnDriver.Click += new System.EventHandler(this.btnDriver_Click);
            // 
            // btnVending
            // 
            this.btnVending.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVending.Location = new System.Drawing.Point(12, 308);
            this.btnVending.Name = "btnVending";
            this.btnVending.Size = new System.Drawing.Size(184, 48);
            this.btnVending.TabIndex = 4;
            this.btnVending.Text = "Vending Machine\r\nswitch statement";
            this.btnVending.UseVisualStyleBackColor = true;
            this.btnVending.Click += new System.EventHandler(this.btnVending_Click);
            // 
            // btnEligibility
            // 
            this.btnEligibility.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEligibility.Location = new System.Drawing.Point(403, 231);
            this.btnEligibility.Name = "btnEligibility";
            this.btnEligibility.Size = new System.Drawing.Size(195, 48);
            this.btnEligibility.TabIndex = 5;
            this.btnEligibility.Text = "Voting Eligibitity";
            this.btnEligibility.UseVisualStyleBackColor = true;
            this.btnEligibility.Click += new System.EventHandler(this.btnEligibility_Click);
            // 
            // btnWhere
            // 
            this.btnWhere.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnWhere.Location = new System.Drawing.Point(202, 231);
            this.btnWhere.Name = "btnWhere";
            this.btnWhere.Size = new System.Drawing.Size(195, 48);
            this.btnWhere.TabIndex = 6;
            this.btnWhere.Text = "Where\r\nTo Eat";
            this.btnWhere.UseVisualStyleBackColor = true;
            this.btnWhere.Click += new System.EventHandler(this.btnWhere_Click);
            // 
            // btnMultiple
            // 
            this.btnMultiple.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMultiple.Location = new System.Drawing.Point(12, 231);
            this.btnMultiple.Name = "btnMultiple";
            this.btnMultiple.Size = new System.Drawing.Size(184, 48);
            this.btnMultiple.TabIndex = 7;
            this.btnMultiple.Text = "Multiple Alternative\r\nswitch statement";
            this.btnMultiple.UseVisualStyleBackColor = true;
            this.btnMultiple.Click += new System.EventHandler(this.btnMultiple_Click);
            // 
            // lblCountries
            // 
            this.lblCountries.AutoSize = true;
            this.lblCountries.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCountries.Location = new System.Drawing.Point(6, 380);
            this.lblCountries.Name = "lblCountries";
            this.lblCountries.Size = new System.Drawing.Size(162, 13);
            this.lblCountries.TabIndex = 8;
            this.lblCountries.Text = "Countries and their capitals";
            // 
            // cboCountry
            // 
            this.cboCountry.FormattingEnabled = true;
            this.cboCountry.Items.AddRange(new object[] {
            "Venezuela",
            "United State",
            "Germany",
            "Croatia",
            "China",
            "Russia"});
            this.cboCountry.Location = new System.Drawing.Point(174, 377);
            this.cboCountry.Name = "cboCountry";
            this.cboCountry.Size = new System.Drawing.Size(424, 21);
            this.cboCountry.TabIndex = 9;
            this.cboCountry.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(628, 420);
            this.Controls.Add(this.cboCountry);
            this.Controls.Add(this.lblCountries);
            this.Controls.Add(this.btnMultiple);
            this.Controls.Add(this.btnWhere);
            this.Controls.Add(this.btnEligibility);
            this.Controls.Add(this.btnVending);
            this.Controls.Add(this.btnDriver);
            this.Controls.Add(this.btnPrize);
            this.Controls.Add(this.txtDisplay);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtDisplay;
        private System.Windows.Forms.Button btnPrize;
        private System.Windows.Forms.Button btnDriver;
        private System.Windows.Forms.Button btnVending;
        private System.Windows.Forms.Button btnEligibility;
        private System.Windows.Forms.Button btnWhere;
        private System.Windows.Forms.Button btnMultiple;
        private System.Windows.Forms.Label lblCountries;
        private System.Windows.Forms.ComboBox cboCountry;
    }
}

