namespace Light
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
            this.btnSwitchOn = new System.Windows.Forms.Button();
            this.btnSwitch2 = new System.Windows.Forms.Button();
            this.btnTurnYellow = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.picLightOff = new System.Windows.Forms.PictureBox();
            this.picLightOn = new System.Windows.Forms.PictureBox();
            this.picLight = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.picLightOff)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picLightOn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picLight)).BeginInit();
            this.SuspendLayout();
            // 
            // btnSwitchOn
            // 
            this.btnSwitchOn.Location = new System.Drawing.Point(12, 185);
            this.btnSwitchOn.Name = "btnSwitchOn";
            this.btnSwitchOn.Size = new System.Drawing.Size(75, 23);
            this.btnSwitchOn.TabIndex = 0;
            this.btnSwitchOn.Text = "Switch On";
            this.btnSwitchOn.UseVisualStyleBackColor = true;
            this.btnSwitchOn.Click += new System.EventHandler(this.btnSwitchOn_Click);
            // 
            // btnSwitch2
            // 
            this.btnSwitch2.Location = new System.Drawing.Point(197, 185);
            this.btnSwitch2.Name = "btnSwitch2";
            this.btnSwitch2.Size = new System.Drawing.Size(75, 23);
            this.btnSwitch2.TabIndex = 1;
            this.btnSwitch2.Text = "Switch OFF";
            this.btnSwitch2.UseVisualStyleBackColor = true;
            this.btnSwitch2.Click += new System.EventHandler(this.btnSwitchOn2_Click);
            // 
            // btnTurnYellow
            // 
            this.btnTurnYellow.Location = new System.Drawing.Point(12, 227);
            this.btnTurnYellow.Name = "btnTurnYellow";
            this.btnTurnYellow.Size = new System.Drawing.Size(75, 23);
            this.btnTurnYellow.TabIndex = 2;
            this.btnTurnYellow.Text = "Turn Yellow";
            this.btnTurnYellow.UseVisualStyleBackColor = true;
            this.btnTurnYellow.Click += new System.EventHandler(this.btnTurnYellow_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(197, 227);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 23);
            this.btnExit.TabIndex = 3;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // picLightOff
            // 
            this.picLightOff.Image = global::Light.Properties.Resources.download;
            this.picLightOff.Location = new System.Drawing.Point(9, 34);
            this.picLightOff.Name = "picLightOff";
            this.picLightOff.Size = new System.Drawing.Size(78, 113);
            this.picLightOff.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picLightOff.TabIndex = 5;
            this.picLightOff.TabStop = false;
            this.picLightOff.Click += new System.EventHandler(this.picLightOff_Click);
            // 
            // picLightOn
            // 
            this.picLightOn.Image = global::Light.Properties.Resources.lightOn;
            this.picLightOn.Location = new System.Drawing.Point(105, 34);
            this.picLightOn.Name = "picLightOn";
            this.picLightOn.Size = new System.Drawing.Size(90, 113);
            this.picLightOn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picLightOn.TabIndex = 4;
            this.picLightOn.TabStop = false;
            // 
            // picLight
            // 
            this.picLight.Image = global::Light.Properties.Resources.download;
            this.picLight.Location = new System.Drawing.Point(197, 34);
            this.picLight.Name = "picLight";
            this.picLight.Size = new System.Drawing.Size(85, 113);
            this.picLight.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picLight.TabIndex = 6;
            this.picLight.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Controls.Add(this.picLight);
            this.Controls.Add(this.picLightOff);
            this.Controls.Add(this.picLightOn);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnTurnYellow);
            this.Controls.Add(this.btnSwitch2);
            this.Controls.Add(this.btnSwitchOn);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.picLightOff)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picLightOn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picLight)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnSwitchOn;
        private System.Windows.Forms.Button btnSwitch2;
        private System.Windows.Forms.Button btnTurnYellow;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.PictureBox picLightOn;
        private System.Windows.Forms.PictureBox picLightOff;
        private System.Windows.Forms.PictureBox picLight;
    }
}

