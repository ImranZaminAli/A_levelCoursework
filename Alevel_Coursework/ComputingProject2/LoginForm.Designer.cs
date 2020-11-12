namespace ComputingProject2
{
    partial class LoginForm
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
            this.EmailTxt = new System.Windows.Forms.Label();
            this.Pass = new System.Windows.Forms.Label();
            this.Email = new System.Windows.Forms.TextBox();
            this.Password = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // EmailTxt
            // 
            this.EmailTxt.AutoSize = true;
            this.EmailTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EmailTxt.Location = new System.Drawing.Point(30, 30);
            this.EmailTxt.Name = "EmailTxt";
            this.EmailTxt.Size = new System.Drawing.Size(80, 29);
            this.EmailTxt.TabIndex = 1;
            this.EmailTxt.Text = "Email:";
            // 
            // Pass
            // 
            this.Pass.AutoSize = true;
            this.Pass.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Pass.Location = new System.Drawing.Point(30, 90);
            this.Pass.Name = "Pass";
            this.Pass.Size = new System.Drawing.Size(126, 29);
            this.Pass.TabIndex = 2;
            this.Pass.Text = "Password:";
            // 
            // Email
            // 
            this.Email.Location = new System.Drawing.Point(167, 30);
            this.Email.Name = "Email";
            this.Email.Size = new System.Drawing.Size(129, 22);
            this.Email.TabIndex = 3;
            // 
            // Password
            // 
            this.Password.Location = new System.Drawing.Point(167, 90);
            this.Password.Name = "Password";
            this.Password.Size = new System.Drawing.Size(129, 22);
            this.Password.TabIndex = 4;
            this.Password.UseSystemPasswordChar = true;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(30, 150);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(266, 57);
            this.button1.TabIndex = 5;
            this.button1.Text = "Login";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(330, 235);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.Password);
            this.Controls.Add(this.Email);
            this.Controls.Add(this.Pass);
            this.Controls.Add(this.EmailTxt);
            this.Name = "LoginForm";
            this.Text = "Login";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label EmailTxt;
        private System.Windows.Forms.Label Pass;
        private System.Windows.Forms.TextBox Email;
        private System.Windows.Forms.TextBox Password;
        private System.Windows.Forms.Button button1;
    }
}