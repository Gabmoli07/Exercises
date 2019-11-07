namespace Calculator
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnMult = new System.Windows.Forms.Button();
            this.btnModulus = new System.Windows.Forms.Button();
            this.btnSub = new System.Windows.Forms.Button();
            this.btnDivide = new System.Windows.Forms.Button();
            this.btnExponent = new System.Windows.Forms.Button();
            this.bntExit = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.txtNum1 = new System.Windows.Forms.TextBox();
            this.txtNum2 = new System.Windows.Forms.TextBox();
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblNum1 = new System.Windows.Forms.Label();
            this.lblOperator = new System.Windows.Forms.Label();
            this.lblEqual = new System.Windows.Forms.Label();
            this.lblNum2 = new System.Windows.Forms.Label();
            this.lblSolution = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.picASA = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.picASA)).BeginInit();
            this.SuspendLayout();
            // 
            // btnAdd
            // 
            this.btnAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.Location = new System.Drawing.Point(27, 159);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(82, 77);
            this.btnAdd.TabIndex = 7;
            this.btnAdd.Text = "&+";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click_1);
            // 
            // btnMult
            // 
            this.btnMult.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMult.Location = new System.Drawing.Point(154, 159);
            this.btnMult.Name = "btnMult";
            this.btnMult.Size = new System.Drawing.Size(82, 77);
            this.btnMult.TabIndex = 8;
            this.btnMult.Text = "*";
            this.btnMult.UseVisualStyleBackColor = true;
            this.btnMult.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnModulus
            // 
            this.btnModulus.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnModulus.Location = new System.Drawing.Point(268, 159);
            this.btnModulus.Name = "btnModulus";
            this.btnModulus.Size = new System.Drawing.Size(82, 77);
            this.btnModulus.TabIndex = 9;
            this.btnModulus.Text = "%";
            this.btnModulus.UseVisualStyleBackColor = true;
            this.btnModulus.Click += new System.EventHandler(this.button3_Click);
            // 
            // btnSub
            // 
            this.btnSub.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSub.Location = new System.Drawing.Point(27, 261);
            this.btnSub.Name = "btnSub";
            this.btnSub.Size = new System.Drawing.Size(82, 77);
            this.btnSub.TabIndex = 11;
            this.btnSub.Text = "-";
            this.btnSub.UseVisualStyleBackColor = true;
            this.btnSub.Click += new System.EventHandler(this.button4_Click);
            // 
            // btnDivide
            // 
            this.btnDivide.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDivide.Location = new System.Drawing.Point(154, 261);
            this.btnDivide.Name = "btnDivide";
            this.btnDivide.Size = new System.Drawing.Size(82, 77);
            this.btnDivide.TabIndex = 13;
            this.btnDivide.Text = "/";
            this.btnDivide.UseVisualStyleBackColor = true;
            this.btnDivide.Click += new System.EventHandler(this.button5_Click);
            // 
            // btnExponent
            // 
            this.btnExponent.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExponent.Location = new System.Drawing.Point(268, 261);
            this.btnExponent.Name = "btnExponent";
            this.btnExponent.Size = new System.Drawing.Size(82, 77);
            this.btnExponent.TabIndex = 14;
            this.btnExponent.Text = "^";
            this.btnExponent.UseVisualStyleBackColor = true;
            this.btnExponent.Click += new System.EventHandler(this.button6_Click);
            // 
            // bntExit
            // 
            this.bntExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bntExit.Location = new System.Drawing.Point(527, 272);
            this.bntExit.Name = "bntExit";
            this.bntExit.Size = new System.Drawing.Size(138, 53);
            this.bntExit.TabIndex = 15;
            this.bntExit.Text = "&Exit";
            this.bntExit.UseVisualStyleBackColor = true;
            this.bntExit.Click += new System.EventHandler(this.button8_Click);
            // 
            // btnClear
            // 
            this.btnClear.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClear.Location = new System.Drawing.Point(527, 171);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(138, 53);
            this.btnClear.TabIndex = 10;
            this.btnClear.Text = "&Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.button7_Click);
            // 
            // txtNum1
            // 
            this.txtNum1.Location = new System.Drawing.Point(11, 95);
            this.txtNum1.Name = "txtNum1";
            this.txtNum1.Size = new System.Drawing.Size(116, 21);
            this.txtNum1.TabIndex = 0;
            this.txtNum1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // txtNum2
            // 
            this.txtNum2.Location = new System.Drawing.Point(208, 95);
            this.txtNum2.Name = "txtNum2";
            this.txtNum2.Size = new System.Drawing.Size(116, 21);
            this.txtNum2.TabIndex = 2;
            // 
            // lblTitle
            // 
            this.lblTitle.BackColor = System.Drawing.Color.DarkViolet;
            this.lblTitle.Font = new System.Drawing.Font("Monotype Corsiva", 36F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.Color.White;
            this.lblTitle.Location = new System.Drawing.Point(12, 9);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(489, 66);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "ASA Super Calculator";
            this.lblTitle.Click += new System.EventHandler(this.label1_Click);
            // 
            // lblNum1
            // 
            this.lblNum1.AutoSize = true;
            this.lblNum1.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNum1.Location = new System.Drawing.Point(19, 120);
            this.lblNum1.Name = "lblNum1";
            this.lblNum1.Size = new System.Drawing.Size(79, 15);
            this.lblNum1.TabIndex = 5;
            this.lblNum1.Text = "First Number";
            // 
            // lblOperator
            // 
            this.lblOperator.BackColor = System.Drawing.Color.BlueViolet;
            this.lblOperator.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOperator.ForeColor = System.Drawing.Color.White;
            this.lblOperator.Location = new System.Drawing.Point(133, 91);
            this.lblOperator.Name = "lblOperator";
            this.lblOperator.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblOperator.Size = new System.Drawing.Size(69, 25);
            this.lblOperator.TabIndex = 1;
            this.lblOperator.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblOperator.UseWaitCursor = true;
            this.lblOperator.Click += new System.EventHandler(this.label3_Click);
            // 
            // lblEqual
            // 
            this.lblEqual.BackColor = System.Drawing.Color.BlueViolet;
            this.lblEqual.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEqual.ForeColor = System.Drawing.Color.White;
            this.lblEqual.Location = new System.Drawing.Point(328, 95);
            this.lblEqual.Name = "lblEqual";
            this.lblEqual.Size = new System.Drawing.Size(41, 21);
            this.lblEqual.TabIndex = 3;
            this.lblEqual.Text = "=";
            this.lblEqual.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblEqual.Click += new System.EventHandler(this.lblEqual_Click);
            // 
            // lblNum2
            // 
            this.lblNum2.AutoSize = true;
            this.lblNum2.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNum2.Location = new System.Drawing.Point(208, 120);
            this.lblNum2.Name = "lblNum2";
            this.lblNum2.Size = new System.Drawing.Size(97, 15);
            this.lblNum2.TabIndex = 6;
            this.lblNum2.Text = "Second Number";
            this.lblNum2.Click += new System.EventHandler(this.label5_Click);
            // 
            // lblSolution
            // 
            this.lblSolution.BackColor = System.Drawing.Color.BlueViolet;
            this.lblSolution.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSolution.ForeColor = System.Drawing.Color.White;
            this.lblSolution.Location = new System.Drawing.Point(384, 91);
            this.lblSolution.Name = "lblSolution";
            this.lblSolution.Size = new System.Drawing.Size(108, 29);
            this.lblSolution.TabIndex = 4;
            this.lblSolution.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblSolution.UseWaitCursor = true;
            this.lblSolution.Click += new System.EventHandler(this.lblSolution_Click);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 2000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // picASA
            // 
            this.picASA.Image = global::Calculator.Properties.Resources.n;
            this.picASA.Location = new System.Drawing.Point(507, 9);
            this.picASA.Name = "picASA";
            this.picASA.Size = new System.Drawing.Size(180, 123);
            this.picASA.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picASA.TabIndex = 16;
            this.picASA.TabStop = false;
            this.picASA.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(699, 378);
            this.Controls.Add(this.picASA);
            this.Controls.Add(this.lblSolution);
            this.Controls.Add(this.lblNum2);
            this.Controls.Add(this.lblEqual);
            this.Controls.Add(this.lblOperator);
            this.Controls.Add(this.lblNum1);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.txtNum2);
            this.Controls.Add(this.txtNum1);
            this.Controls.Add(this.bntExit);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnExponent);
            this.Controls.Add(this.btnDivide);
            this.Controls.Add(this.btnSub);
            this.Controls.Add(this.btnModulus);
            this.Controls.Add(this.btnMult);
            this.Controls.Add(this.btnAdd);
            this.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picASA)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.Button btnAdd;
        public System.Windows.Forms.Button btnMult;
        public System.Windows.Forms.Button btnModulus;
        public System.Windows.Forms.Button btnSub;
        public System.Windows.Forms.Button btnDivide;
        public System.Windows.Forms.Button btnExponent;
        public System.Windows.Forms.Button bntExit;
        public System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.TextBox txtNum1;
        private System.Windows.Forms.TextBox txtNum2;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblNum1;
        private System.Windows.Forms.Label lblOperator;
        private System.Windows.Forms.Label lblEqual;
        private System.Windows.Forms.Label lblNum2;
        private System.Windows.Forms.PictureBox picASA;
        public System.Windows.Forms.Label lblSolution;
        private System.Windows.Forms.Timer timer1;
    }
}

