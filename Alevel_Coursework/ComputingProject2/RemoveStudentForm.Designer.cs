namespace ComputingProject2
{
    partial class RemoveStudentForm
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
            this.Students = new System.Windows.Forms.ComboBox();
            this.SelectBtn = new System.Windows.Forms.Button();
            this.DeleteBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Back
            // 
            this.Back.Location = new System.Drawing.Point(10, 11);
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
            this.label1.Location = new System.Drawing.Point(46, 51);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(159, 24);
            this.label1.TabIndex = 1;
            this.label1.Text = "Remove Students";
            // 
            // Students
            // 
            this.Students.FormattingEnabled = true;
            this.Students.Location = new System.Drawing.Point(21, 89);
            this.Students.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Students.Name = "Students";
            this.Students.Size = new System.Drawing.Size(102, 21);
            this.Students.TabIndex = 2;
            // 
            // SelectBtn
            // 
            this.SelectBtn.Location = new System.Drawing.Point(142, 90);
            this.SelectBtn.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.SelectBtn.Name = "SelectBtn";
            this.SelectBtn.Size = new System.Drawing.Size(56, 19);
            this.SelectBtn.TabIndex = 3;
            this.SelectBtn.Text = "Select";
            this.SelectBtn.UseVisualStyleBackColor = true;
            this.SelectBtn.Click += new System.EventHandler(this.SelectBtn_Click);
            // 
            // DeleteBtn
            // 
            this.DeleteBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DeleteBtn.Location = new System.Drawing.Point(70, 136);
            this.DeleteBtn.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.DeleteBtn.Name = "DeleteBtn";
            this.DeleteBtn.Size = new System.Drawing.Size(74, 27);
            this.DeleteBtn.TabIndex = 4;
            this.DeleteBtn.Text = "Delete";
            this.DeleteBtn.UseVisualStyleBackColor = true;
            this.DeleteBtn.Click += new System.EventHandler(this.DeleteBtn_Click);
            // 
            // RemoveStudentForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(230, 176);
            this.Controls.Add(this.DeleteBtn);
            this.Controls.Add(this.SelectBtn);
            this.Controls.Add(this.Students);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Back);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "RemoveStudentForm";
            this.Text = "RemoveStudentForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Back;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox Students;
        private System.Windows.Forms.Button SelectBtn;
        private System.Windows.Forms.Button DeleteBtn;
    }
}