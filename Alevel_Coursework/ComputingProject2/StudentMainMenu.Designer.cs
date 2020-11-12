namespace ComputingProject2
{
    partial class StudentMainMenu
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
            this.Welcome = new System.Windows.Forms.Label();
            this.LearnBtn = new System.Windows.Forms.Button();
            this.CreateBtn = new System.Windows.Forms.Button();
            this.EditBtn = new System.Windows.Forms.Button();
            this.ConnBtn = new System.Windows.Forms.Button();
            this.TeacherConn = new System.Windows.Forms.Label();
            this.LogoutBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Welcome
            // 
            this.Welcome.AutoSize = true;
            this.Welcome.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Welcome.Location = new System.Drawing.Point(12, 49);
            this.Welcome.Name = "Welcome";
            this.Welcome.Size = new System.Drawing.Size(220, 29);
            this.Welcome.TabIndex = 0;
            this.Welcome.Text = "Welcome Message";
            // 
            // LearnBtn
            // 
            this.LearnBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LearnBtn.Location = new System.Drawing.Point(12, 94);
            this.LearnBtn.Name = "LearnBtn";
            this.LearnBtn.Size = new System.Drawing.Size(243, 55);
            this.LearnBtn.TabIndex = 1;
            this.LearnBtn.Text = "Learn";
            this.LearnBtn.UseVisualStyleBackColor = true;
            this.LearnBtn.Click += new System.EventHandler(this.LearnBtn_Click);
            // 
            // CreateBtn
            // 
            this.CreateBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CreateBtn.Location = new System.Drawing.Point(12, 164);
            this.CreateBtn.Name = "CreateBtn";
            this.CreateBtn.Size = new System.Drawing.Size(243, 55);
            this.CreateBtn.TabIndex = 2;
            this.CreateBtn.Text = "Create new set";
            this.CreateBtn.UseVisualStyleBackColor = true;
            this.CreateBtn.Click += new System.EventHandler(this.CreateBtn_Click);
            // 
            // EditBtn
            // 
            this.EditBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EditBtn.Location = new System.Drawing.Point(12, 234);
            this.EditBtn.Name = "EditBtn";
            this.EditBtn.Size = new System.Drawing.Size(243, 55);
            this.EditBtn.TabIndex = 3;
            this.EditBtn.Text = "Edit set";
            this.EditBtn.UseVisualStyleBackColor = true;
            this.EditBtn.Click += new System.EventHandler(this.EditBtn_Click);
            // 
            // ConnBtn
            // 
            this.ConnBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ConnBtn.Location = new System.Drawing.Point(12, 304);
            this.ConnBtn.Name = "ConnBtn";
            this.ConnBtn.Size = new System.Drawing.Size(243, 55);
            this.ConnBtn.TabIndex = 4;
            this.ConnBtn.Text = "Connections";
            this.ConnBtn.UseVisualStyleBackColor = true;
            this.ConnBtn.Click += new System.EventHandler(this.ConnBtn_Click);
            // 
            // TeacherConn
            // 
            this.TeacherConn.AutoSize = true;
            this.TeacherConn.Location = new System.Drawing.Point(209, 386);
            this.TeacherConn.Name = "TeacherConn";
            this.TeacherConn.Size = new System.Drawing.Size(46, 17);
            this.TeacherConn.TabIndex = 5;
            this.TeacherConn.Text = "label1";
            // 
            // LogoutBtn
            // 
            this.LogoutBtn.Location = new System.Drawing.Point(17, 12);
            this.LogoutBtn.Name = "LogoutBtn";
            this.LogoutBtn.Size = new System.Drawing.Size(75, 28);
            this.LogoutBtn.TabIndex = 6;
            this.LogoutBtn.Text = "Logout";
            this.LogoutBtn.UseVisualStyleBackColor = true;
            this.LogoutBtn.Click += new System.EventHandler(this.LogoutBtn_Click);
            // 
            // StudentMainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(267, 371);
            this.Controls.Add(this.LogoutBtn);
            this.Controls.Add(this.TeacherConn);
            this.Controls.Add(this.ConnBtn);
            this.Controls.Add(this.EditBtn);
            this.Controls.Add(this.CreateBtn);
            this.Controls.Add(this.LearnBtn);
            this.Controls.Add(this.Welcome);
            this.Name = "StudentMainMenu";
            this.Text = "MainMenu";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Welcome;
        private System.Windows.Forms.Button LearnBtn;
        private System.Windows.Forms.Button CreateBtn;
        private System.Windows.Forms.Button EditBtn;
        private System.Windows.Forms.Button ConnBtn;
        private System.Windows.Forms.Label TeacherConn;
        private System.Windows.Forms.Button LogoutBtn;
    }
}