namespace RichTextBox
{
    partial class Welcome
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
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.lblEditor = new System.Windows.Forms.Label();
            this.lblCreated = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 2000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // lblEditor
            // 
            this.lblEditor.Font = new System.Drawing.Font("Monotype Corsiva", 21.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEditor.Location = new System.Drawing.Point(51, 68);
            this.lblEditor.Name = "lblEditor";
            this.lblEditor.Size = new System.Drawing.Size(171, 41);
            this.lblEditor.TabIndex = 0;
            this.lblEditor.Text = "Super Editor";
            this.lblEditor.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblEditor.Click += new System.EventHandler(this.label1_Click);
            // 
            // lblCreated
            // 
            this.lblCreated.Font = new System.Drawing.Font("Monotype Corsiva", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCreated.Location = new System.Drawing.Point(31, 126);
            this.lblCreated.Name = "lblCreated";
            this.lblCreated.Size = new System.Drawing.Size(208, 86);
            this.lblCreated.TabIndex = 1;
            this.lblCreated.Text = "Created by ASA Software\r\nCopyright 2018\r\n";
            this.lblCreated.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Welcome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Controls.Add(this.lblCreated);
            this.Controls.Add(this.lblEditor);
            this.Name = "Welcome";
            this.Text = "Welcome";
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label lblEditor;
        private System.Windows.Forms.Label lblCreated;
        private System.Windows.Forms.Timer timer1;
    }
}