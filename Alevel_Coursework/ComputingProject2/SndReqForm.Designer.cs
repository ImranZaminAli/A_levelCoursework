namespace ComputingProject2
{
    partial class SndReqForm
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
            this.IdTxt = new System.Windows.Forms.Label();
            this.RecIdIn = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.RecNameTxt = new System.Windows.Forms.Label();
            this.SelectBtn = new System.Windows.Forms.Button();
            this.ConfirmBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // BackBtn
            // 
            this.BackBtn.Location = new System.Drawing.Point(9, 10);
            this.BackBtn.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.BackBtn.Name = "BackBtn";
            this.BackBtn.Size = new System.Drawing.Size(56, 19);
            this.BackBtn.TabIndex = 0;
            this.BackBtn.Text = "Back";
            this.BackBtn.UseVisualStyleBackColor = true;
            this.BackBtn.Click += new System.EventHandler(this.BackBtn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(69, 37);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(112, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Send Request";
            // 
            // IdTxt
            // 
            this.IdTxt.AutoSize = true;
            this.IdTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IdTxt.Location = new System.Drawing.Point(254, 10);
            this.IdTxt.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.IdTxt.Name = "IdTxt";
            this.IdTxt.Size = new System.Drawing.Size(0, 13);
            this.IdTxt.TabIndex = 2;
            // 
            // RecIdIn
            // 
            this.RecIdIn.Location = new System.Drawing.Point(99, 71);
            this.RecIdIn.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.RecIdIn.Name = "RecIdIn";
            this.RecIdIn.Size = new System.Drawing.Size(58, 20);
            this.RecIdIn.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 74);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(88, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Enter receiver Id:\r\n";
            // 
            // RecNameTxt
            // 
            this.RecNameTxt.AutoSize = true;
            this.RecNameTxt.Location = new System.Drawing.Point(15, 112);
            this.RecNameTxt.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.RecNameTxt.Name = "RecNameTxt";
            this.RecNameTxt.Size = new System.Drawing.Size(50, 13);
            this.RecNameTxt.TabIndex = 5;
            this.RecNameTxt.Text = "id : name";
            // 
            // SelectBtn
            // 
            this.SelectBtn.Location = new System.Drawing.Point(167, 71);
            this.SelectBtn.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.SelectBtn.Name = "SelectBtn";
            this.SelectBtn.Size = new System.Drawing.Size(56, 19);
            this.SelectBtn.TabIndex = 6;
            this.SelectBtn.Text = "Select";
            this.SelectBtn.UseVisualStyleBackColor = true;
            this.SelectBtn.Click += new System.EventHandler(this.SelectBtn_Click);
            // 
            // ConfirmBtn
            // 
            this.ConfirmBtn.Location = new System.Drawing.Point(167, 109);
            this.ConfirmBtn.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.ConfirmBtn.Name = "ConfirmBtn";
            this.ConfirmBtn.Size = new System.Drawing.Size(56, 19);
            this.ConfirmBtn.TabIndex = 7;
            this.ConfirmBtn.Text = "Confirm";
            this.ConfirmBtn.UseVisualStyleBackColor = true;
            this.ConfirmBtn.Click += new System.EventHandler(this.ConfirmBtn_Click);
            // 
            // SndReqForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(239, 150);
            this.Controls.Add(this.ConfirmBtn);
            this.Controls.Add(this.SelectBtn);
            this.Controls.Add(this.RecNameTxt);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.RecIdIn);
            this.Controls.Add(this.IdTxt);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.BackBtn);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "SndReqForm";
            this.Text = "SndReqForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BackBtn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label IdTxt;
        private System.Windows.Forms.TextBox RecIdIn;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label RecNameTxt;
        private System.Windows.Forms.Button SelectBtn;
        private System.Windows.Forms.Button ConfirmBtn;
    }
}