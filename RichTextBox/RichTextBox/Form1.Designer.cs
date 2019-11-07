namespace RichTextBox
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
            this.btnUnder = new System.Windows.Forms.Button();
            this.btnItalic = new System.Windows.Forms.Button();
            this.btnBold = new System.Windows.Forms.Button();
            this.btnNormal = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openTextFileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openRTFDocumentToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveAsTextDocumentToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveAsRTFDocumentToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openFileInANewWindowToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.closeFileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cboSize = new System.Windows.Forms.ComboBox();
            this.rtbEditor = new System.Windows.Forms.RichTextBox();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnUnder
            // 
            this.btnUnder.Location = new System.Drawing.Point(414, 38);
            this.btnUnder.Name = "btnUnder";
            this.btnUnder.Size = new System.Drawing.Size(75, 23);
            this.btnUnder.TabIndex = 0;
            this.btnUnder.Text = "UnderLine";
            this.btnUnder.UseVisualStyleBackColor = true;
            this.btnUnder.Click += new System.EventHandler(this.btnUnder_Click);
            // 
            // btnItalic
            // 
            this.btnItalic.Location = new System.Drawing.Point(312, 38);
            this.btnItalic.Name = "btnItalic";
            this.btnItalic.Size = new System.Drawing.Size(75, 23);
            this.btnItalic.TabIndex = 1;
            this.btnItalic.Text = "Italic";
            this.btnItalic.UseVisualStyleBackColor = true;
            this.btnItalic.Click += new System.EventHandler(this.btnItalic_Click);
            // 
            // btnBold
            // 
            this.btnBold.Location = new System.Drawing.Point(220, 38);
            this.btnBold.Name = "btnBold";
            this.btnBold.Size = new System.Drawing.Size(75, 23);
            this.btnBold.TabIndex = 2;
            this.btnBold.Text = "Bold";
            this.btnBold.UseVisualStyleBackColor = true;
            this.btnBold.Click += new System.EventHandler(this.btnBold_Click);
            // 
            // btnNormal
            // 
            this.btnNormal.Location = new System.Drawing.Point(127, 38);
            this.btnNormal.Name = "btnNormal";
            this.btnNormal.Size = new System.Drawing.Size(75, 23);
            this.btnNormal.TabIndex = 3;
            this.btnNormal.Text = "Normal";
            this.btnNormal.UseVisualStyleBackColor = true;
            this.btnNormal.Click += new System.EventHandler(this.btnNormal_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.aboutToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(523, 24);
            this.menuStrip1.TabIndex = 4;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openTextFileToolStripMenuItem,
            this.openRTFDocumentToolStripMenuItem,
            this.saveAsTextDocumentToolStripMenuItem,
            this.saveAsRTFDocumentToolStripMenuItem,
            this.openFileInANewWindowToolStripMenuItem,
            this.closeFileToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // openTextFileToolStripMenuItem
            // 
            this.openTextFileToolStripMenuItem.Name = "openTextFileToolStripMenuItem";
            this.openTextFileToolStripMenuItem.Size = new System.Drawing.Size(194, 22);
            this.openTextFileToolStripMenuItem.Text = "Open Text File";
            this.openTextFileToolStripMenuItem.Click += new System.EventHandler(this.openTextFileToolStripMenuItem_Click);
            // 
            // openRTFDocumentToolStripMenuItem
            // 
            this.openRTFDocumentToolStripMenuItem.Name = "openRTFDocumentToolStripMenuItem";
            this.openRTFDocumentToolStripMenuItem.Size = new System.Drawing.Size(194, 22);
            this.openRTFDocumentToolStripMenuItem.Text = "Open RTF Document";
            this.openRTFDocumentToolStripMenuItem.Click += new System.EventHandler(this.openRTFDocumentToolStripMenuItem_Click);
            // 
            // saveAsTextDocumentToolStripMenuItem
            // 
            this.saveAsTextDocumentToolStripMenuItem.Name = "saveAsTextDocumentToolStripMenuItem";
            this.saveAsTextDocumentToolStripMenuItem.Size = new System.Drawing.Size(194, 22);
            this.saveAsTextDocumentToolStripMenuItem.Text = "Save as Text File";
            this.saveAsTextDocumentToolStripMenuItem.Click += new System.EventHandler(this.saveAsTextDocumentToolStripMenuItem_Click);
            // 
            // saveAsRTFDocumentToolStripMenuItem
            // 
            this.saveAsRTFDocumentToolStripMenuItem.Name = "saveAsRTFDocumentToolStripMenuItem";
            this.saveAsRTFDocumentToolStripMenuItem.Size = new System.Drawing.Size(194, 22);
            this.saveAsRTFDocumentToolStripMenuItem.Text = "Save as RTF Document";
            this.saveAsRTFDocumentToolStripMenuItem.Click += new System.EventHandler(this.saveAsRTFDocumentToolStripMenuItem_Click);
            // 
            // openFileInANewWindowToolStripMenuItem
            // 
            this.openFileInANewWindowToolStripMenuItem.Name = "openFileInANewWindowToolStripMenuItem";
            this.openFileInANewWindowToolStripMenuItem.Size = new System.Drawing.Size(194, 22);
            this.openFileInANewWindowToolStripMenuItem.Text = "Open a  New Window";
            this.openFileInANewWindowToolStripMenuItem.Click += new System.EventHandler(this.openFileInANewWindowToolStripMenuItem_Click);
            // 
            // closeFileToolStripMenuItem
            // 
            this.closeFileToolStripMenuItem.Name = "closeFileToolStripMenuItem";
            this.closeFileToolStripMenuItem.Size = new System.Drawing.Size(194, 22);
            this.closeFileToolStripMenuItem.Text = "Close File";
            this.closeFileToolStripMenuItem.Click += new System.EventHandler(this.closeFileToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(194, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(52, 20);
            this.aboutToolStripMenuItem.Text = "About";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // cboSize
            // 
            this.cboSize.FormattingEnabled = true;
            this.cboSize.Items.AddRange(new object[] {
            "8",
            "10",
            "12",
            "14",
            "16",
            "18",
            "20",
            "22",
            "24",
            "26"});
            this.cboSize.Location = new System.Drawing.Point(0, 40);
            this.cboSize.Name = "cboSize";
            this.cboSize.Size = new System.Drawing.Size(121, 21);
            this.cboSize.TabIndex = 6;
            this.cboSize.SelectedIndexChanged += new System.EventHandler(this.cboSize_SelectedIndexChanged_1);
            // 
            // rtbEditor
            // 
            this.rtbEditor.Location = new System.Drawing.Point(12, 132);
            this.rtbEditor.Name = "rtbEditor";
            this.rtbEditor.Size = new System.Drawing.Size(477, 96);
            this.rtbEditor.TabIndex = 7;
            this.rtbEditor.Text = "";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(523, 262);
            this.Controls.Add(this.rtbEditor);
            this.Controls.Add(this.cboSize);
            this.Controls.Add(this.btnNormal);
            this.Controls.Add(this.btnBold);
            this.Controls.Add(this.btnItalic);
            this.Controls.Add(this.btnUnder);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load_1);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnUnder;
        private System.Windows.Forms.Button btnItalic;
        private System.Windows.Forms.Button btnBold;
        private System.Windows.Forms.Button btnNormal;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openTextFileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openRTFDocumentToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveAsTextDocumentToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveAsRTFDocumentToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openFileInANewWindowToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem closeFileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ComboBox cboSize;
        private System.Windows.Forms.RichTextBox rtbEditor;
    }
}

