namespace FinalProject
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
            this.btnClear = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.lblEqual3 = new System.Windows.Forms.Label();
            this.lblEqual2 = new System.Windows.Forms.Label();
            this.lblF = new System.Windows.Forms.Label();
            this.lblType = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.lblFahrenheit = new System.Windows.Forms.Label();
            this.lblCelsius = new System.Windows.Forms.Label();
            this.lblKelvin = new System.Windows.Forms.Label();
            this.lblEqual = new System.Windows.Forms.Label();
            this.lblC = new System.Windows.Forms.Label();
            this.cboSelect = new System.Windows.Forms.ComboBox();
            this.lblK = new System.Windows.Forms.Label();
            this.txtInput = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnClear
            // 
            this.btnClear.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClear.Location = new System.Drawing.Point(476, 324);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(75, 23);
            this.btnClear.TabIndex = 29;
            this.btnClear.Text = "&Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnExit
            // 
            this.btnExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.Location = new System.Drawing.Point(475, 294);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 23);
            this.btnExit.TabIndex = 28;
            this.btnExit.Text = "E&xit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // lblEqual3
            // 
            this.lblEqual3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEqual3.Location = new System.Drawing.Point(191, 322);
            this.lblEqual3.Name = "lblEqual3";
            this.lblEqual3.Size = new System.Drawing.Size(104, 23);
            this.lblEqual3.TabIndex = 27;
            this.lblEqual3.Text = "=";
            // 
            // lblEqual2
            // 
            this.lblEqual2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEqual2.Location = new System.Drawing.Point(191, 272);
            this.lblEqual2.Name = "lblEqual2";
            this.lblEqual2.Size = new System.Drawing.Size(104, 23);
            this.lblEqual2.TabIndex = 26;
            this.lblEqual2.Text = "=";
            // 
            // lblF
            // 
            this.lblF.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblF.Location = new System.Drawing.Point(24, 221);
            this.lblF.Name = "lblF";
            this.lblF.Size = new System.Drawing.Size(123, 23);
            this.lblF.TabIndex = 25;
            this.lblF.Text = "Fahrenheit";
            // 
            // lblType
            // 
            this.lblType.AutoSize = true;
            this.lblType.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblType.Location = new System.Drawing.Point(24, 87);
            this.lblType.Name = "lblType";
            this.lblType.Size = new System.Drawing.Size(139, 20);
            this.lblType.TabIndex = 24;
            this.lblType.Text = "Type the degree";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Monotype Corsiva", 48F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName.Location = new System.Drawing.Point(4, -12);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(546, 79);
            this.lblName.TabIndex = 23;
            this.lblName.Text = "Temperature Converter";
            this.lblName.MouseEnter += new System.EventHandler(this.cboSelect_SelectedIndexChanged);
            // 
            // lblFahrenheit
            // 
            this.lblFahrenheit.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblFahrenheit.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFahrenheit.Location = new System.Drawing.Point(301, 221);
            this.lblFahrenheit.Name = "lblFahrenheit";
            this.lblFahrenheit.Size = new System.Drawing.Size(158, 23);
            this.lblFahrenheit.TabIndex = 22;
            // 
            // lblCelsius
            // 
            this.lblCelsius.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblCelsius.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCelsius.Location = new System.Drawing.Point(301, 272);
            this.lblCelsius.Name = "lblCelsius";
            this.lblCelsius.Size = new System.Drawing.Size(158, 23);
            this.lblCelsius.TabIndex = 21;
            // 
            // lblKelvin
            // 
            this.lblKelvin.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblKelvin.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblKelvin.Location = new System.Drawing.Point(301, 322);
            this.lblKelvin.Name = "lblKelvin";
            this.lblKelvin.Size = new System.Drawing.Size(158, 23);
            this.lblKelvin.TabIndex = 20;
            // 
            // lblEqual
            // 
            this.lblEqual.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEqual.Location = new System.Drawing.Point(191, 221);
            this.lblEqual.Name = "lblEqual";
            this.lblEqual.Size = new System.Drawing.Size(104, 23);
            this.lblEqual.TabIndex = 19;
            this.lblEqual.Text = "=";
            // 
            // lblC
            // 
            this.lblC.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblC.Location = new System.Drawing.Point(24, 272);
            this.lblC.Name = "lblC";
            this.lblC.Size = new System.Drawing.Size(123, 23);
            this.lblC.TabIndex = 18;
            this.lblC.Text = "Celsius";
            // 
            // cboSelect
            // 
            this.cboSelect.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboSelect.FormattingEnabled = true;
            this.cboSelect.Items.AddRange(new object[] {
            "Fahrenheit",
            "Celsius",
            "Kelvin"});
            this.cboSelect.Location = new System.Drawing.Point(28, 151);
            this.cboSelect.Name = "cboSelect";
            this.cboSelect.Size = new System.Drawing.Size(431, 24);
            this.cboSelect.TabIndex = 17;
            this.cboSelect.Text = "Choose Type";
            this.cboSelect.SelectedIndexChanged += new System.EventHandler(this.cboSelect_SelectedIndexChanged);
            // 
            // lblK
            // 
            this.lblK.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblK.Location = new System.Drawing.Point(24, 322);
            this.lblK.Name = "lblK";
            this.lblK.Size = new System.Drawing.Size(123, 23);
            this.lblK.TabIndex = 16;
            this.lblK.Text = "Kelvin";
            // 
            // txtInput
            // 
            this.txtInput.Location = new System.Drawing.Point(169, 87);
            this.txtInput.Multiline = true;
            this.txtInput.Name = "txtInput";
            this.txtInput.Size = new System.Drawing.Size(290, 20);
            this.txtInput.TabIndex = 15;
            this.txtInput.TextChanged += new System.EventHandler(this.cboSelect_SelectedIndexChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(579, 358);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.lblEqual3);
            this.Controls.Add(this.lblEqual2);
            this.Controls.Add(this.lblF);
            this.Controls.Add(this.lblType);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.lblFahrenheit);
            this.Controls.Add(this.lblCelsius);
            this.Controls.Add(this.lblKelvin);
            this.Controls.Add(this.lblEqual);
            this.Controls.Add(this.lblC);
            this.Controls.Add(this.cboSelect);
            this.Controls.Add(this.lblK);
            this.Controls.Add(this.txtInput);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Label lblEqual3;
        private System.Windows.Forms.Label lblEqual2;
        private System.Windows.Forms.Label lblF;
        private System.Windows.Forms.Label lblType;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblFahrenheit;
        private System.Windows.Forms.Label lblCelsius;
        private System.Windows.Forms.Label lblKelvin;
        private System.Windows.Forms.Label lblEqual;
        private System.Windows.Forms.Label lblC;
        private System.Windows.Forms.ComboBox cboSelect;
        private System.Windows.Forms.Label lblK;
        private System.Windows.Forms.TextBox txtInput;
    }
}

