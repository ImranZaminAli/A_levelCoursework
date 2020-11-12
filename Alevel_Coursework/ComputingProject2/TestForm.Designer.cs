namespace ComputingProject2
{
    partial class TestForm
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
            this.Prompt = new System.Windows.Forms.RichTextBox();
            this.SubmitBtn = new System.Windows.Forms.Button();
            this.NextBtn = new System.Windows.Forms.Button();
            this.OverrideBtn = new System.Windows.Forms.Button();
            this.NotificationTxt = new System.Windows.Forms.Label();
            this.Input = new System.Windows.Forms.RichTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.FinishBtn = new System.Windows.Forms.Button();
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
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(228, 17);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 31);
            this.label1.TabIndex = 1;
            this.label1.Text = "Test";
            // 
            // Prompt
            // 
            this.Prompt.Location = new System.Drawing.Point(11, 106);
            this.Prompt.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Prompt.Name = "Prompt";
            this.Prompt.Size = new System.Drawing.Size(226, 139);
            this.Prompt.TabIndex = 2;
            this.Prompt.Text = "";
            // 
            // SubmitBtn
            // 
            this.SubmitBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SubmitBtn.Location = new System.Drawing.Point(207, 256);
            this.SubmitBtn.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.SubmitBtn.Name = "SubmitBtn";
            this.SubmitBtn.Size = new System.Drawing.Size(90, 41);
            this.SubmitBtn.TabIndex = 3;
            this.SubmitBtn.Text = "Submit";
            this.SubmitBtn.UseVisualStyleBackColor = true;
            this.SubmitBtn.Click += new System.EventHandler(this.SubmitBtn_Click);
            // 
            // NextBtn
            // 
            this.NextBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NextBtn.Location = new System.Drawing.Point(9, 256);
            this.NextBtn.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.NextBtn.Name = "NextBtn";
            this.NextBtn.Size = new System.Drawing.Size(90, 41);
            this.NextBtn.TabIndex = 4;
            this.NextBtn.Text = "Next";
            this.NextBtn.UseVisualStyleBackColor = true;
            this.NextBtn.Click += new System.EventHandler(this.NextBtn_Click);
            // 
            // OverrideBtn
            // 
            this.OverrideBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OverrideBtn.Location = new System.Drawing.Point(405, 256);
            this.OverrideBtn.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.OverrideBtn.Name = "OverrideBtn";
            this.OverrideBtn.Size = new System.Drawing.Size(90, 41);
            this.OverrideBtn.TabIndex = 5;
            this.OverrideBtn.Text = "I was right";
            this.OverrideBtn.UseVisualStyleBackColor = true;
            this.OverrideBtn.Click += new System.EventHandler(this.OverrideBtn_Click);
            // 
            // NotificationTxt
            // 
            this.NotificationTxt.AutoSize = true;
            this.NotificationTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NotificationTxt.Location = new System.Drawing.Point(192, 317);
            this.NotificationTxt.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.NotificationTxt.Name = "NotificationTxt";
            this.NotificationTxt.Size = new System.Drawing.Size(126, 24);
            this.NotificationTxt.TabIndex = 6;
            this.NotificationTxt.Text = "correct/wrong";
            // 
            // Input
            // 
            this.Input.Location = new System.Drawing.Point(270, 106);
            this.Input.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Input.Name = "Input";
            this.Input.Size = new System.Drawing.Size(226, 139);
            this.Input.TabIndex = 7;
            this.Input.Text = "";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(90, 69);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 24);
            this.label3.TabIndex = 8;
            this.label3.Text = "Prompt";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(351, 69);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(74, 24);
            this.label4.TabIndex = 9;
            this.label4.Text = "Answer";
            // 
            // FinishBtn
            // 
            this.FinishBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FinishBtn.Location = new System.Drawing.Point(9, 323);
            this.FinishBtn.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.FinishBtn.Name = "FinishBtn";
            this.FinishBtn.Size = new System.Drawing.Size(90, 33);
            this.FinishBtn.TabIndex = 10;
            this.FinishBtn.Text = "Finish";
            this.FinishBtn.UseVisualStyleBackColor = true;
            this.FinishBtn.Click += new System.EventHandler(this.FinishBtn_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(383, 306);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(145, 24);
            this.label2.TabIndex = 11;
            this.label2.Text = "Use this if you mistyped or if what \r\nyou said means the same thing.";
            // 
            // TestForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(559, 366);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.FinishBtn);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Input);
            this.Controls.Add(this.NotificationTxt);
            this.Controls.Add(this.OverrideBtn);
            this.Controls.Add(this.NextBtn);
            this.Controls.Add(this.SubmitBtn);
            this.Controls.Add(this.Prompt);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.BackBtn);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "TestForm";
            this.Text = "TestForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BackBtn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RichTextBox Prompt;
        private System.Windows.Forms.Button SubmitBtn;
        private System.Windows.Forms.Button NextBtn;
        private System.Windows.Forms.Button OverrideBtn;
        private System.Windows.Forms.Label NotificationTxt;
        private System.Windows.Forms.RichTextBox Input;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button FinishBtn;
        private System.Windows.Forms.Label label2;
    }
}