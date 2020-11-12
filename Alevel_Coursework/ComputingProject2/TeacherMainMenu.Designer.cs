namespace ComputingProject2
{
    partial class TeacherMainMenu
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
            this.WelcomeMsgTxt = new System.Windows.Forms.Label();
            this.CreateBtn = new System.Windows.Forms.Button();
            this.EditBtn = new System.Windows.Forms.Button();
            this.ManageBtn = new System.Windows.Forms.Button();
            this.LogoutBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // WelcomeMsgTxt
            // 
            this.WelcomeMsgTxt.AutoSize = true;
            this.WelcomeMsgTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.WelcomeMsgTxt.Location = new System.Drawing.Point(26, 57);
            this.WelcomeMsgTxt.Name = "WelcomeMsgTxt";
            this.WelcomeMsgTxt.Size = new System.Drawing.Size(255, 32);
            this.WelcomeMsgTxt.TabIndex = 0;
            this.WelcomeMsgTxt.Text = "Welcome message";
            // 
            // CreateBtn
            // 
            this.CreateBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CreateBtn.Location = new System.Drawing.Point(14, 105);
            this.CreateBtn.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.CreateBtn.Name = "CreateBtn";
            this.CreateBtn.Size = new System.Drawing.Size(273, 69);
            this.CreateBtn.TabIndex = 1;
            this.CreateBtn.Text = "Create New Set";
            this.CreateBtn.UseVisualStyleBackColor = true;
            this.CreateBtn.Click += new System.EventHandler(this.CreateBtn_Click);
            // 
            // EditBtn
            // 
            this.EditBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EditBtn.Location = new System.Drawing.Point(14, 192);
            this.EditBtn.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.EditBtn.Name = "EditBtn";
            this.EditBtn.Size = new System.Drawing.Size(273, 69);
            this.EditBtn.TabIndex = 2;
            this.EditBtn.Text = "Edit Set";
            this.EditBtn.UseVisualStyleBackColor = true;
            this.EditBtn.Click += new System.EventHandler(this.EditBtn_Click);
            // 
            // ManageBtn
            // 
            this.ManageBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ManageBtn.Location = new System.Drawing.Point(14, 280);
            this.ManageBtn.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.ManageBtn.Name = "ManageBtn";
            this.ManageBtn.Size = new System.Drawing.Size(273, 69);
            this.ManageBtn.TabIndex = 3;
            this.ManageBtn.Text = "Manage Students";
            this.ManageBtn.UseVisualStyleBackColor = true;
            this.ManageBtn.Click += new System.EventHandler(this.ManageBtn_Click);
            // 
            // LogoutBtn
            // 
            this.LogoutBtn.Location = new System.Drawing.Point(14, 15);
            this.LogoutBtn.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.LogoutBtn.Name = "LogoutBtn";
            this.LogoutBtn.Size = new System.Drawing.Size(84, 32);
            this.LogoutBtn.TabIndex = 4;
            this.LogoutBtn.Text = "Logout";
            this.LogoutBtn.UseVisualStyleBackColor = true;
            this.LogoutBtn.Click += new System.EventHandler(this.LogoutBtn_Click);
            // 
            // TeacherMainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(300, 365);
            this.Controls.Add(this.LogoutBtn);
            this.Controls.Add(this.ManageBtn);
            this.Controls.Add(this.EditBtn);
            this.Controls.Add(this.CreateBtn);
            this.Controls.Add(this.WelcomeMsgTxt);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "TeacherMainMenu";
            this.Text = "TeacherMainMenu";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label WelcomeMsgTxt;
        private System.Windows.Forms.Button CreateBtn;
        private System.Windows.Forms.Button EditBtn;
        private System.Windows.Forms.Button ManageBtn;
        private System.Windows.Forms.Button LogoutBtn;
    }
}