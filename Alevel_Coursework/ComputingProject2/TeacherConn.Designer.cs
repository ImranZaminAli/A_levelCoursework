namespace ComputingProject2
{
    partial class TeacherConn
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
            this.Back = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.KeyIn = new System.Windows.Forms.TextBox();
            this.SelectBtn = new System.Windows.Forms.Button();
            this.TeachNameTxt = new System.Windows.Forms.Label();
            this.ConfirmBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Back
            // 
            this.Back.Location = new System.Drawing.Point(9, 10);
            this.Back.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Back.Name = "Back";
            this.Back.Size = new System.Drawing.Size(56, 19);
            this.Back.TabIndex = 0;
            this.Back.Text = "Back";
            this.Back.UseVisualStyleBackColor = true;
            this.Back.Click += new System.EventHandler(this.Back_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(20, 41);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(184, 24);
            this.label1.TabIndex = 1;
            this.label1.Text = "Connect to a teacher";
            // 
            // KeyIn
            // 
            this.KeyIn.Location = new System.Drawing.Point(24, 88);
            this.KeyIn.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.KeyIn.Name = "KeyIn";
            this.KeyIn.Size = new System.Drawing.Size(114, 20);
            this.KeyIn.TabIndex = 2;
            // 
            // SelectBtn
            // 
            this.SelectBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SelectBtn.Location = new System.Drawing.Point(142, 84);
            this.SelectBtn.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.SelectBtn.Name = "SelectBtn";
            this.SelectBtn.Size = new System.Drawing.Size(79, 29);
            this.SelectBtn.TabIndex = 3;
            this.SelectBtn.Text = "Select";
            this.SelectBtn.UseVisualStyleBackColor = true;
            this.SelectBtn.Click += new System.EventHandler(this.SelectBtn_Click);
            // 
            // TeachNameTxt
            // 
            this.TeachNameTxt.AutoSize = true;
            this.TeachNameTxt.Location = new System.Drawing.Point(22, 141);
            this.TeachNameTxt.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.TeachNameTxt.Name = "TeachNameTxt";
            this.TeachNameTxt.Size = new System.Drawing.Size(50, 13);
            this.TeachNameTxt.TabIndex = 4;
            this.TeachNameTxt.Text = "id : name";
            // 
            // ConfirmBtn
            // 
            this.ConfirmBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ConfirmBtn.Location = new System.Drawing.Point(146, 131);
            this.ConfirmBtn.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.ConfirmBtn.Name = "ConfirmBtn";
            this.ConfirmBtn.Size = new System.Drawing.Size(75, 29);
            this.ConfirmBtn.TabIndex = 5;
            this.ConfirmBtn.Text = "Confirm";
            this.ConfirmBtn.UseVisualStyleBackColor = true;
            this.ConfirmBtn.Click += new System.EventHandler(this.ConfirmBtn_Click);
            // 
            // TeacherConn
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(230, 175);
            this.Controls.Add(this.ConfirmBtn);
            this.Controls.Add(this.TeachNameTxt);
            this.Controls.Add(this.SelectBtn);
            this.Controls.Add(this.KeyIn);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Back);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "TeacherConn";
            this.Text = "TeacherConn";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Back;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox KeyIn;
        private System.Windows.Forms.Button SelectBtn;
        private System.Windows.Forms.Label TeachNameTxt;
        private System.Windows.Forms.Button ConfirmBtn;
    }
}