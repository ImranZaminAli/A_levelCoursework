namespace ComputingProject2
{
    partial class LearnForm
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
            this.ChooseSet = new System.Windows.Forms.ComboBox();
            this.ReviseBtn = new System.Windows.Forms.Button();
            this.TestBtn = new System.Windows.Forms.Button();
            this.Titles = new System.Windows.Forms.Label();
            this.SwapBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // BackBtn
            // 
            this.BackBtn.Location = new System.Drawing.Point(13, 14);
            this.BackBtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.BackBtn.Name = "BackBtn";
            this.BackBtn.Size = new System.Drawing.Size(60, 23);
            this.BackBtn.TabIndex = 0;
            this.BackBtn.Text = "Back";
            this.BackBtn.UseVisualStyleBackColor = true;
            this.BackBtn.Click += new System.EventHandler(this.BackBtn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(100, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 32);
            this.label1.TabIndex = 1;
            this.label1.Text = "Learn";
            // 
            // ChooseSet
            // 
            this.ChooseSet.FormattingEnabled = true;
            this.ChooseSet.Location = new System.Drawing.Point(13, 106);
            this.ChooseSet.Margin = new System.Windows.Forms.Padding(4);
            this.ChooseSet.Name = "ChooseSet";
            this.ChooseSet.Size = new System.Drawing.Size(160, 24);
            this.ChooseSet.TabIndex = 2;
            this.ChooseSet.SelectedIndexChanged += new System.EventHandler(this.ChooseSet_SelectedIndexChanged);
            // 
            // ReviseBtn
            // 
            this.ReviseBtn.Location = new System.Drawing.Point(191, 78);
            this.ReviseBtn.Margin = new System.Windows.Forms.Padding(4);
            this.ReviseBtn.Name = "ReviseBtn";
            this.ReviseBtn.Size = new System.Drawing.Size(100, 28);
            this.ReviseBtn.TabIndex = 3;
            this.ReviseBtn.Text = "Revise";
            this.ReviseBtn.UseVisualStyleBackColor = true;
            this.ReviseBtn.Click += new System.EventHandler(this.ReviseBtn_Click);
            // 
            // TestBtn
            // 
            this.TestBtn.Location = new System.Drawing.Point(191, 133);
            this.TestBtn.Margin = new System.Windows.Forms.Padding(4);
            this.TestBtn.Name = "TestBtn";
            this.TestBtn.Size = new System.Drawing.Size(100, 28);
            this.TestBtn.TabIndex = 4;
            this.TestBtn.Text = "Test";
            this.TestBtn.UseVisualStyleBackColor = true;
            this.TestBtn.Click += new System.EventHandler(this.TestBtn_Click);
            // 
            // Titles
            // 
            this.Titles.AutoSize = true;
            this.Titles.Location = new System.Drawing.Point(13, 194);
            this.Titles.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Titles.Name = "Titles";
            this.Titles.Size = new System.Drawing.Size(98, 17);
            this.Titles.TabIndex = 5;
            this.Titles.Text = "Title1 to Title2";
            // 
            // SwapBtn
            // 
            this.SwapBtn.Location = new System.Drawing.Point(145, 188);
            this.SwapBtn.Margin = new System.Windows.Forms.Padding(4);
            this.SwapBtn.Name = "SwapBtn";
            this.SwapBtn.Size = new System.Drawing.Size(100, 28);
            this.SwapBtn.TabIndex = 6;
            this.SwapBtn.Text = "Swap";
            this.SwapBtn.UseVisualStyleBackColor = true;
            this.SwapBtn.Click += new System.EventHandler(this.SwapBtn_Click);
            // 
            // LearnForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(311, 234);
            this.Controls.Add(this.SwapBtn);
            this.Controls.Add(this.Titles);
            this.Controls.Add(this.TestBtn);
            this.Controls.Add(this.ReviseBtn);
            this.Controls.Add(this.ChooseSet);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.BackBtn);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "LearnForm";
            this.Text = "LearnForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BackBtn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox ChooseSet;
        private System.Windows.Forms.Button ReviseBtn;
        private System.Windows.Forms.Button TestBtn;
        private System.Windows.Forms.Label Titles;
        private System.Windows.Forms.Button SwapBtn;
    }
}