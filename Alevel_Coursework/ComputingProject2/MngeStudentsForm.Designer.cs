namespace ComputingProject2
{
    partial class MngeStudentsForm
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
            this.RequestsBtn = new System.Windows.Forms.Button();
            this.KeyLbl = new System.Windows.Forms.Label();
            this.RemoveBtn = new System.Windows.Forms.Button();
            this.CopyKeyBtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
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
            // RequestsBtn
            // 
            this.RequestsBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RequestsBtn.Location = new System.Drawing.Point(9, 130);
            this.RequestsBtn.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.RequestsBtn.Name = "RequestsBtn";
            this.RequestsBtn.Size = new System.Drawing.Size(146, 41);
            this.RequestsBtn.TabIndex = 1;
            this.RequestsBtn.Text = "View Requests";
            this.RequestsBtn.UseVisualStyleBackColor = true;
            this.RequestsBtn.Click += new System.EventHandler(this.RequestsBtn_Click);
            // 
            // KeyLbl
            // 
            this.KeyLbl.AutoSize = true;
            this.KeyLbl.Location = new System.Drawing.Point(9, 224);
            this.KeyLbl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.KeyLbl.Name = "KeyLbl";
            this.KeyLbl.Size = new System.Drawing.Size(91, 13);
            this.KeyLbl.TabIndex = 2;
            this.KeyLbl.Text = "############";
            // 
            // RemoveBtn
            // 
            this.RemoveBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RemoveBtn.Location = new System.Drawing.Point(9, 76);
            this.RemoveBtn.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.RemoveBtn.Name = "RemoveBtn";
            this.RemoveBtn.Size = new System.Drawing.Size(146, 41);
            this.RemoveBtn.TabIndex = 3;
            this.RemoveBtn.Text = "Remove Students";
            this.RemoveBtn.UseVisualStyleBackColor = true;
            this.RemoveBtn.Click += new System.EventHandler(this.RemoveBtn_Click);
            // 
            // CopyKeyBtn
            // 
            this.CopyKeyBtn.Location = new System.Drawing.Point(75, 189);
            this.CopyKeyBtn.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.CopyKeyBtn.Name = "CopyKeyBtn";
            this.CopyKeyBtn.Size = new System.Drawing.Size(60, 20);
            this.CopyKeyBtn.TabIndex = 4;
            this.CopyKeyBtn.Text = "Copy Key";
            this.CopyKeyBtn.UseVisualStyleBackColor = true;
            this.CopyKeyBtn.Click += new System.EventHandler(this.CopyKeyBtn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(9, 39);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(157, 24);
            this.label1.TabIndex = 5;
            this.label1.Text = "Manage Students";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 193);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Your key is:";
            // 
            // MngeStudentsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(168, 251);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.CopyKeyBtn);
            this.Controls.Add(this.RemoveBtn);
            this.Controls.Add(this.KeyLbl);
            this.Controls.Add(this.RequestsBtn);
            this.Controls.Add(this.BackBtn);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "MngeStudentsForm";
            this.Text = "MngeStudentsForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BackBtn;
        private System.Windows.Forms.Button RequestsBtn;
        private System.Windows.Forms.Label KeyLbl;
        private System.Windows.Forms.Button RemoveBtn;
        private System.Windows.Forms.Button CopyKeyBtn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}