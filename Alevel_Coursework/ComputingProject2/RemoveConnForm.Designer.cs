namespace ComputingProject2
{
    partial class RemoveConnForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.BackBtn = new System.Windows.Forms.Button();
            this.SelectRequest = new System.Windows.Forms.ComboBox();
            this.SelectRequestBtn = new System.Windows.Forms.Button();
            this.DeleteRequestBtn = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.DeleteFriendBtn = new System.Windows.Forms.Button();
            this.SelectFriendBtn = new System.Windows.Forms.Button();
            this.SelectFriend = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(40, 54);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(156, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Remove Request";
            // 
            // BackBtn
            // 
            this.BackBtn.Location = new System.Drawing.Point(9, 10);
            this.BackBtn.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.BackBtn.Name = "BackBtn";
            this.BackBtn.Size = new System.Drawing.Size(56, 19);
            this.BackBtn.TabIndex = 1;
            this.BackBtn.Text = "Back";
            this.BackBtn.UseVisualStyleBackColor = true;
            this.BackBtn.Click += new System.EventHandler(this.BackBtn_Click);
            // 
            // SelectRequest
            // 
            this.SelectRequest.FormattingEnabled = true;
            this.SelectRequest.Location = new System.Drawing.Point(20, 95);
            this.SelectRequest.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.SelectRequest.Name = "SelectRequest";
            this.SelectRequest.Size = new System.Drawing.Size(110, 21);
            this.SelectRequest.TabIndex = 2;
            // 
            // SelectRequestBtn
            // 
            this.SelectRequestBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SelectRequestBtn.Location = new System.Drawing.Point(134, 93);
            this.SelectRequestBtn.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.SelectRequestBtn.Name = "SelectRequestBtn";
            this.SelectRequestBtn.Size = new System.Drawing.Size(70, 24);
            this.SelectRequestBtn.TabIndex = 3;
            this.SelectRequestBtn.Text = "Select";
            this.SelectRequestBtn.UseVisualStyleBackColor = true;
            this.SelectRequestBtn.Click += new System.EventHandler(this.SelectRequestBtn_Click);
            // 
            // DeleteRequestBtn
            // 
            this.DeleteRequestBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DeleteRequestBtn.Location = new System.Drawing.Point(52, 133);
            this.DeleteRequestBtn.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.DeleteRequestBtn.Name = "DeleteRequestBtn";
            this.DeleteRequestBtn.Size = new System.Drawing.Size(111, 29);
            this.DeleteRequestBtn.TabIndex = 5;
            this.DeleteRequestBtn.Text = "Delete";
            this.DeleteRequestBtn.UseVisualStyleBackColor = true;
            this.DeleteRequestBtn.Click += new System.EventHandler(this.DeleteRequestBtn_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(278, 50);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(141, 24);
            this.label2.TabIndex = 6;
            this.label2.Text = "Remove Friend";
            // 
            // DeleteFriendBtn
            // 
            this.DeleteFriendBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DeleteFriendBtn.Location = new System.Drawing.Point(287, 132);
            this.DeleteFriendBtn.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.DeleteFriendBtn.Name = "DeleteFriendBtn";
            this.DeleteFriendBtn.Size = new System.Drawing.Size(111, 29);
            this.DeleteFriendBtn.TabIndex = 9;
            this.DeleteFriendBtn.Text = "Delete";
            this.DeleteFriendBtn.UseVisualStyleBackColor = true;
            this.DeleteFriendBtn.Click += new System.EventHandler(this.DeleteFriendBtn_Click);
            // 
            // SelectFriendBtn
            // 
            this.SelectFriendBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SelectFriendBtn.Location = new System.Drawing.Point(368, 91);
            this.SelectFriendBtn.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.SelectFriendBtn.Name = "SelectFriendBtn";
            this.SelectFriendBtn.Size = new System.Drawing.Size(70, 24);
            this.SelectFriendBtn.TabIndex = 8;
            this.SelectFriendBtn.Text = "Select";
            this.SelectFriendBtn.UseVisualStyleBackColor = true;
            this.SelectFriendBtn.Click += new System.EventHandler(this.SelectFriendBtn_Click);
            // 
            // SelectFriend
            // 
            this.SelectFriend.FormattingEnabled = true;
            this.SelectFriend.Location = new System.Drawing.Point(254, 94);
            this.SelectFriend.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.SelectFriend.Name = "SelectFriend";
            this.SelectFriend.Size = new System.Drawing.Size(110, 21);
            this.SelectFriend.TabIndex = 7;
            // 
            // RemoveConnForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(459, 183);
            this.Controls.Add(this.DeleteFriendBtn);
            this.Controls.Add(this.SelectFriendBtn);
            this.Controls.Add(this.SelectFriend);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.DeleteRequestBtn);
            this.Controls.Add(this.SelectRequestBtn);
            this.Controls.Add(this.SelectRequest);
            this.Controls.Add(this.BackBtn);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "RemoveConnForm";
            this.Text = "MngReqForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button BackBtn;
        private System.Windows.Forms.ComboBox SelectRequest;
        private System.Windows.Forms.Button SelectRequestBtn;
        private System.Windows.Forms.Button DeleteRequestBtn;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button DeleteFriendBtn;
        private System.Windows.Forms.Button SelectFriendBtn;
        private System.Windows.Forms.ComboBox SelectFriend;
    }
}