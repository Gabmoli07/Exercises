namespace Queue
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
            this.rtbQueue = new System.Windows.Forms.RichTextBox();
            this.rtbStack = new System.Windows.Forms.RichTextBox();
            this.btnPeek = new System.Windows.Forms.Button();
            this.btnDequeue = new System.Windows.Forms.Button();
            this.btnEnqueue = new System.Windows.Forms.Button();
            this.btnPeekStack = new System.Windows.Forms.Button();
            this.btnPop = new System.Windows.Forms.Button();
            this.btnPush = new System.Windows.Forms.Button();
            this.txtQueue = new System.Windows.Forms.TextBox();
            this.txtStack = new System.Windows.Forms.TextBox();
            this.lblDisplay = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // rtbQueue
            // 
            this.rtbQueue.Font = new System.Drawing.Font("Modern No. 20", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rtbQueue.Location = new System.Drawing.Point(28, 22);
            this.rtbQueue.Name = "rtbQueue";
            this.rtbQueue.Size = new System.Drawing.Size(536, 100);
            this.rtbQueue.TabIndex = 0;
            this.rtbQueue.Text = "";
            // 
            // rtbStack
            // 
            this.rtbStack.Font = new System.Drawing.Font("Modern No. 20", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rtbStack.Location = new System.Drawing.Point(28, 239);
            this.rtbStack.Name = "rtbStack";
            this.rtbStack.Size = new System.Drawing.Size(536, 100);
            this.rtbStack.TabIndex = 1;
            this.rtbStack.Text = "";
            // 
            // btnPeek
            // 
            this.btnPeek.Font = new System.Drawing.Font("Modern No. 20", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPeek.Location = new System.Drawing.Point(406, 194);
            this.btnPeek.Name = "btnPeek";
            this.btnPeek.Size = new System.Drawing.Size(126, 33);
            this.btnPeek.TabIndex = 2;
            this.btnPeek.Text = "Peek";
            this.btnPeek.UseVisualStyleBackColor = true;
            this.btnPeek.Click += new System.EventHandler(this.btnPeek_Click);
            // 
            // btnDequeue
            // 
            this.btnDequeue.Font = new System.Drawing.Font("Modern No. 20", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDequeue.Location = new System.Drawing.Point(215, 194);
            this.btnDequeue.Name = "btnDequeue";
            this.btnDequeue.Size = new System.Drawing.Size(126, 33);
            this.btnDequeue.TabIndex = 3;
            this.btnDequeue.Text = "Dequeue";
            this.btnDequeue.UseVisualStyleBackColor = true;
            this.btnDequeue.Click += new System.EventHandler(this.btnDequeue_Click);
            // 
            // btnEnqueue
            // 
            this.btnEnqueue.Font = new System.Drawing.Font("Modern No. 20", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEnqueue.Location = new System.Drawing.Point(28, 194);
            this.btnEnqueue.Name = "btnEnqueue";
            this.btnEnqueue.Size = new System.Drawing.Size(126, 33);
            this.btnEnqueue.TabIndex = 4;
            this.btnEnqueue.Text = "Enqueue";
            this.btnEnqueue.UseVisualStyleBackColor = true;
            this.btnEnqueue.Click += new System.EventHandler(this.btnEnqueue_Click);
            // 
            // btnPeekStack
            // 
            this.btnPeekStack.Font = new System.Drawing.Font("Modern No. 20", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPeekStack.Location = new System.Drawing.Point(406, 379);
            this.btnPeekStack.Name = "btnPeekStack";
            this.btnPeekStack.Size = new System.Drawing.Size(126, 33);
            this.btnPeekStack.TabIndex = 5;
            this.btnPeekStack.Text = "Peek";
            this.btnPeekStack.UseVisualStyleBackColor = true;
            this.btnPeekStack.Click += new System.EventHandler(this.button4_Click);
            // 
            // btnPop
            // 
            this.btnPop.Font = new System.Drawing.Font("Modern No. 20", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPop.Location = new System.Drawing.Point(215, 379);
            this.btnPop.Name = "btnPop";
            this.btnPop.Size = new System.Drawing.Size(126, 33);
            this.btnPop.TabIndex = 6;
            this.btnPop.Text = "Pop";
            this.btnPop.UseVisualStyleBackColor = true;
            this.btnPop.Click += new System.EventHandler(this.btnPop_Click);
            // 
            // btnPush
            // 
            this.btnPush.Font = new System.Drawing.Font("Modern No. 20", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPush.Location = new System.Drawing.Point(28, 379);
            this.btnPush.Name = "btnPush";
            this.btnPush.Size = new System.Drawing.Size(126, 33);
            this.btnPush.TabIndex = 7;
            this.btnPush.Text = "Push";
            this.btnPush.UseVisualStyleBackColor = true;
            this.btnPush.Click += new System.EventHandler(this.btnPush_Click);
            // 
            // txtQueue
            // 
            this.txtQueue.Font = new System.Drawing.Font("Modern No. 20", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtQueue.Location = new System.Drawing.Point(28, 139);
            this.txtQueue.Name = "txtQueue";
            this.txtQueue.Size = new System.Drawing.Size(536, 28);
            this.txtQueue.TabIndex = 8;
            // 
            // txtStack
            // 
            this.txtStack.Font = new System.Drawing.Font("Modern No. 20", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtStack.Location = new System.Drawing.Point(28, 345);
            this.txtStack.Name = "txtStack";
            this.txtStack.Size = new System.Drawing.Size(536, 28);
            this.txtStack.TabIndex = 9;
            this.txtStack.TextChanged += new System.EventHandler(this.txtStack_TextChanged);
            // 
            // lblDisplay
            // 
            this.lblDisplay.AutoSize = true;
            this.lblDisplay.Font = new System.Drawing.Font("Modern No. 20", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDisplay.Location = new System.Drawing.Point(32, 170);
            this.lblDisplay.Name = "lblDisplay";
            this.lblDisplay.Size = new System.Drawing.Size(86, 21);
            this.lblDisplay.TabIndex = 10;
            this.lblDisplay.Text = "Message ";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(591, 424);
            this.Controls.Add(this.lblDisplay);
            this.Controls.Add(this.txtStack);
            this.Controls.Add(this.txtQueue);
            this.Controls.Add(this.btnPush);
            this.Controls.Add(this.btnPop);
            this.Controls.Add(this.btnPeekStack);
            this.Controls.Add(this.btnEnqueue);
            this.Controls.Add(this.btnDequeue);
            this.Controls.Add(this.btnPeek);
            this.Controls.Add(this.rtbStack);
            this.Controls.Add(this.rtbQueue);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox rtbQueue;
        private System.Windows.Forms.RichTextBox rtbStack;
        private System.Windows.Forms.Button btnPeek;
        private System.Windows.Forms.Button btnDequeue;
        private System.Windows.Forms.Button btnEnqueue;
        private System.Windows.Forms.Button btnPeekStack;
        private System.Windows.Forms.Button btnPop;
        private System.Windows.Forms.Button btnPush;
        private System.Windows.Forms.TextBox txtQueue;
        private System.Windows.Forms.TextBox txtStack;
        private System.Windows.Forms.Label lblDisplay;
    }
}

