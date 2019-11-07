namespace List
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
            this.btnList = new System.Windows.Forms.Button();
            this.btnlistInitialization = new System.Windows.Forms.Button();
            this.btnInt = new System.Windows.Forms.Button();
            this.btnSequentialSearch = new System.Windows.Forms.Button();
            this.btnIndex = new System.Windows.Forms.Button();
            this.txtInput = new System.Windows.Forms.TextBox();
            this.rtbDisplay = new System.Windows.Forms.RichTextBox();
            this.lbl1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnList
            // 
            this.btnList.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnList.Location = new System.Drawing.Point(24, 55);
            this.btnList.Name = "btnList";
            this.btnList.Size = new System.Drawing.Size(188, 41);
            this.btnList.TabIndex = 0;
            this.btnList.Text = "List";
            this.btnList.UseVisualStyleBackColor = true;
            this.btnList.Click += new System.EventHandler(this.btnList_Click);
            // 
            // btnlistInitialization
            // 
            this.btnlistInitialization.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnlistInitialization.Location = new System.Drawing.Point(24, 111);
            this.btnlistInitialization.Name = "btnlistInitialization";
            this.btnlistInitialization.Size = new System.Drawing.Size(188, 41);
            this.btnlistInitialization.TabIndex = 1;
            this.btnlistInitialization.Text = "List with initialization";
            this.btnlistInitialization.UseVisualStyleBackColor = true;
            this.btnlistInitialization.Click += new System.EventHandler(this.btnlistInitialization_Click);
            // 
            // btnInt
            // 
            this.btnInt.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInt.Location = new System.Drawing.Point(24, 159);
            this.btnInt.Name = "btnInt";
            this.btnInt.Size = new System.Drawing.Size(188, 41);
            this.btnInt.TabIndex = 2;
            this.btnInt.Text = "List <int>";
            this.btnInt.UseVisualStyleBackColor = true;
            // 
            // btnSequentialSearch
            // 
            this.btnSequentialSearch.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSequentialSearch.Location = new System.Drawing.Point(345, 55);
            this.btnSequentialSearch.Name = "btnSequentialSearch";
            this.btnSequentialSearch.Size = new System.Drawing.Size(188, 41);
            this.btnSequentialSearch.TabIndex = 3;
            this.btnSequentialSearch.Text = "Sequential Search";
            this.btnSequentialSearch.UseVisualStyleBackColor = true;
            // 
            // btnIndex
            // 
            this.btnIndex.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIndex.Location = new System.Drawing.Point(345, 111);
            this.btnIndex.Name = "btnIndex";
            this.btnIndex.Size = new System.Drawing.Size(188, 41);
            this.btnIndex.TabIndex = 4;
            this.btnIndex.Text = "(IndexOf) Search";
            this.btnIndex.UseVisualStyleBackColor = true;
            this.btnIndex.Click += new System.EventHandler(this.btnIndex_Click);
            // 
            // txtInput
            // 
            this.txtInput.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtInput.Location = new System.Drawing.Point(345, 9);
            this.txtInput.Name = "txtInput";
            this.txtInput.Size = new System.Drawing.Size(188, 25);
            this.txtInput.TabIndex = 5;
            // 
            // rtbDisplay
            // 
            this.rtbDisplay.Location = new System.Drawing.Point(12, 211);
            this.rtbDisplay.Name = "rtbDisplay";
            this.rtbDisplay.Size = new System.Drawing.Size(576, 195);
            this.rtbDisplay.TabIndex = 6;
            this.rtbDisplay.Text = "";
            // 
            // lbl1
            // 
            this.lbl1.AutoSize = true;
            this.lbl1.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl1.Location = new System.Drawing.Point(29, 12);
            this.lbl1.Name = "lbl1";
            this.lbl1.Size = new System.Drawing.Size(310, 18);
            this.lbl1.TabIndex = 7;
            this.lbl1.Text = "What do you want to find in thw Zodiac list?";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(611, 418);
            this.Controls.Add(this.lbl1);
            this.Controls.Add(this.rtbDisplay);
            this.Controls.Add(this.txtInput);
            this.Controls.Add(this.btnIndex);
            this.Controls.Add(this.btnSequentialSearch);
            this.Controls.Add(this.btnInt);
            this.Controls.Add(this.btnlistInitialization);
            this.Controls.Add(this.btnList);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnList;
        private System.Windows.Forms.Button btnlistInitialization;
        private System.Windows.Forms.Button btnInt;
        private System.Windows.Forms.Button btnSequentialSearch;
        private System.Windows.Forms.Button btnIndex;
        private System.Windows.Forms.TextBox txtInput;
        private System.Windows.Forms.RichTextBox rtbDisplay;
        private System.Windows.Forms.Label lbl1;
    }
}

