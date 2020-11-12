namespace ComputingProject2
{
    partial class ViewReqForm
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
            this.BackBtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SenderDetailsTxt = new System.Windows.Forms.Label();
            this.AcceptBtn = new System.Windows.Forms.Button();
            this.RejectBtn = new System.Windows.Forms.Button();
            this.ViewRequests = new System.Windows.Forms.ComboBox();
            this.SelectBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // BackBtn
            // 
            this.BackBtn.Location = new System.Drawing.Point(12, 12);
            this.BackBtn.Name = "BackBtn";
            this.BackBtn.Size = new System.Drawing.Size(75, 23);
            this.BackBtn.TabIndex = 0;
            this.BackBtn.Text = "Back";
            this.BackBtn.UseVisualStyleBackColor = true;
            this.BackBtn.Click += new System.EventHandler(this.BackBtn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(50, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(174, 29);
            this.label1.TabIndex = 1;
            this.label1.Text = "View Requests";
            // 
            // SenderDetailsTxt
            // 
            this.SenderDetailsTxt.AutoSize = true;
            this.SenderDetailsTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SenderDetailsTxt.Location = new System.Drawing.Point(59, 153);
            this.SenderDetailsTxt.Name = "SenderDetailsTxt";
            this.SenderDetailsTxt.Size = new System.Drawing.Size(92, 25);
            this.SenderDetailsTxt.TabIndex = 4;
            this.SenderDetailsTxt.Text = "id : name";
            // 
            // AcceptBtn
            // 
            this.AcceptBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AcceptBtn.Location = new System.Drawing.Point(22, 198);
            this.AcceptBtn.Name = "AcceptBtn";
            this.AcceptBtn.Size = new System.Drawing.Size(90, 40);
            this.AcceptBtn.TabIndex = 5;
            this.AcceptBtn.Text = "Accept";
            this.AcceptBtn.UseVisualStyleBackColor = true;
            this.AcceptBtn.Click += new System.EventHandler(this.AcceptBtn_Click);
            // 
            // RejectBtn
            // 
            this.RejectBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RejectBtn.Location = new System.Drawing.Point(180, 198);
            this.RejectBtn.Name = "RejectBtn";
            this.RejectBtn.Size = new System.Drawing.Size(90, 40);
            this.RejectBtn.TabIndex = 6;
            this.RejectBtn.Text = "Reject";
            this.RejectBtn.UseVisualStyleBackColor = true;
            this.RejectBtn.Click += new System.EventHandler(this.RejectBtn_Click);
            // 
            // ViewRequests
            // 
            this.ViewRequests.FormattingEnabled = true;
            this.ViewRequests.Location = new System.Drawing.Point(22, 104);
            this.ViewRequests.Name = "ViewRequests";
            this.ViewRequests.Size = new System.Drawing.Size(129, 24);
            this.ViewRequests.TabIndex = 7;
            // 
            // SelectBtn
            // 
            this.SelectBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SelectBtn.Location = new System.Drawing.Point(180, 93);
            this.SelectBtn.Name = "SelectBtn";
            this.SelectBtn.Size = new System.Drawing.Size(90, 40);
            this.SelectBtn.TabIndex = 8;
            this.SelectBtn.Text = "Select";
            this.SelectBtn.UseVisualStyleBackColor = true;
            this.SelectBtn.Click += new System.EventHandler(this.SelectBtn_Click);
            // 
            // ViewReqForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(291, 254);
            this.Controls.Add(this.SelectBtn);
            this.Controls.Add(this.ViewRequests);
            this.Controls.Add(this.RejectBtn);
            this.Controls.Add(this.AcceptBtn);
            this.Controls.Add(this.SenderDetailsTxt);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.BackBtn);
            this.Name = "ViewReqForm";
            this.Text = "ViewReqForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BackBtn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label SenderDetailsTxt;
        private System.Windows.Forms.Button AcceptBtn;
        private System.Windows.Forms.Button RejectBtn;
        private System.Windows.Forms.ComboBox ViewRequests;
        private System.Windows.Forms.Button SelectBtn;
    }
}