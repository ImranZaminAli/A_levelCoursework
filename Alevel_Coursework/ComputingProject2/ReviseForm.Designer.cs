namespace ComputingProject2
{
    partial class ReviseForm
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
            this.BackwardsBtn = new System.Windows.Forms.Button();
            this.ForwardsBtn = new System.Windows.Forms.Button();
            this.FinishBtn = new System.Windows.Forms.Button();
            this.CardTxt = new System.Windows.Forms.RichTextBox();
            this.FlipBtn = new System.Windows.Forms.Button();
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
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(106, 18);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 26);
            this.label1.TabIndex = 1;
            this.label1.Text = "Revise";
            // 
            // BackwardsBtn
            // 
            this.BackwardsBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BackwardsBtn.Location = new System.Drawing.Point(29, 68);
            this.BackwardsBtn.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.BackwardsBtn.Name = "BackwardsBtn";
            this.BackwardsBtn.Size = new System.Drawing.Size(56, 28);
            this.BackwardsBtn.TabIndex = 2;
            this.BackwardsBtn.Text = "<---";
            this.BackwardsBtn.UseVisualStyleBackColor = true;
            this.BackwardsBtn.Click += new System.EventHandler(this.BackwardsBtn_Click);
            // 
            // ForwardsBtn
            // 
            this.ForwardsBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForwardsBtn.Location = new System.Drawing.Point(201, 68);
            this.ForwardsBtn.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.ForwardsBtn.Name = "ForwardsBtn";
            this.ForwardsBtn.Size = new System.Drawing.Size(56, 28);
            this.ForwardsBtn.TabIndex = 3;
            this.ForwardsBtn.Text = "--->";
            this.ForwardsBtn.UseVisualStyleBackColor = true;
            this.ForwardsBtn.Click += new System.EventHandler(this.ForwardsBtn_Click);
            // 
            // FinishBtn
            // 
            this.FinishBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FinishBtn.Location = new System.Drawing.Point(201, 203);
            this.FinishBtn.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.FinishBtn.Name = "FinishBtn";
            this.FinishBtn.Size = new System.Drawing.Size(56, 28);
            this.FinishBtn.TabIndex = 5;
            this.FinishBtn.Text = "Finish";
            this.FinishBtn.UseVisualStyleBackColor = true;
            this.FinishBtn.Click += new System.EventHandler(this.FinishBtn_Click);
            // 
            // CardTxt
            // 
            this.CardTxt.Location = new System.Drawing.Point(29, 101);
            this.CardTxt.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.CardTxt.Name = "CardTxt";
            this.CardTxt.Size = new System.Drawing.Size(229, 98);
            this.CardTxt.TabIndex = 6;
            this.CardTxt.Text = "";
            // 
            // FlipBtn
            // 
            this.FlipBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FlipBtn.Location = new System.Drawing.Point(118, 68);
            this.FlipBtn.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.FlipBtn.Name = "FlipBtn";
            this.FlipBtn.Size = new System.Drawing.Size(56, 28);
            this.FlipBtn.TabIndex = 7;
            this.FlipBtn.Text = "Flip";
            this.FlipBtn.UseVisualStyleBackColor = true;
            this.FlipBtn.Click += new System.EventHandler(this.FlipBtn_Click);
            // 
            // ReviseForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(271, 237);
            this.Controls.Add(this.FlipBtn);
            this.Controls.Add(this.CardTxt);
            this.Controls.Add(this.FinishBtn);
            this.Controls.Add(this.ForwardsBtn);
            this.Controls.Add(this.BackwardsBtn);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.BackBtn);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "ReviseForm";
            this.Text = "ReviseForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BackBtn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button BackwardsBtn;
        private System.Windows.Forms.Button ForwardsBtn;
        private System.Windows.Forms.Button FinishBtn;
        private System.Windows.Forms.RichTextBox CardTxt;
        private System.Windows.Forms.Button FlipBtn;
    }
}