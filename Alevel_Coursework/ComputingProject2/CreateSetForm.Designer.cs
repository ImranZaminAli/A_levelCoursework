namespace ComputingProject2
{
    partial class CreateSetForm
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
            this.ChooseFile = new System.Windows.Forms.Button();
            this.OpenFile = new System.Windows.Forms.OpenFileDialog();
            this.FileName = new System.Windows.Forms.Label();
            this.msg = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SetName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.Title1 = new System.Windows.Forms.TextBox();
            this.Title2 = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.Text1 = new System.Windows.Forms.RichTextBox();
            this.Text2 = new System.Windows.Forms.RichTextBox();
            this.Add = new System.Windows.Forms.Button();
            this.InsertBtn = new System.Windows.Forms.Button();
            this.ConfirmMsg = new System.Windows.Forms.Label();
            this.BackBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ChooseFile
            // 
            this.ChooseFile.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ChooseFile.Location = new System.Drawing.Point(14, 411);
            this.ChooseFile.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.ChooseFile.Name = "ChooseFile";
            this.ChooseFile.Size = new System.Drawing.Size(297, 86);
            this.ChooseFile.TabIndex = 0;
            this.ChooseFile.Text = "Choose File";
            this.ChooseFile.UseVisualStyleBackColor = true;
            this.ChooseFile.Click += new System.EventHandler(this.ChooseFile_Click);
            // 
            // FileName
            // 
            this.FileName.AutoSize = true;
            this.FileName.Font = new System.Drawing.Font("Microsoft Sans Serif", 6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FileName.Location = new System.Drawing.Point(166, 555);
            this.FileName.Name = "FileName";
            this.FileName.Size = new System.Drawing.Size(10, 15);
            this.FileName.TabIndex = 1;
            this.FileName.Text = ".";
            // 
            // msg
            // 
            this.msg.AutoSize = true;
            this.msg.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.msg.Location = new System.Drawing.Point(28, 282);
            this.msg.Name = "msg";
            this.msg.Size = new System.Drawing.Size(283, 75);
            this.msg.TabIndex = 2;
            this.msg.Text = "Import an .xlsx file\r\nUse first two colums for data\r\nLeve no empty cells";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(495, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(189, 40);
            this.label1.TabIndex = 3;
            this.label1.Text = "Create Set";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(387, 71);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(180, 29);
            this.label2.TabIndex = 5;
            this.label2.Text = "Enter set name:";
            // 
            // SetName
            // 
            this.SetName.Location = new System.Drawing.Point(561, 76);
            this.SetName.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.SetName.Name = "SetName";
            this.SetName.Size = new System.Drawing.Size(196, 26);
            this.SetName.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(51, 199);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(225, 32);
            this.label3.TabIndex = 7;
            this.label3.Text = "Import Excel File";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(14, 125);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(110, 29);
            this.label4.TabIndex = 8;
            this.label4.Text = "First title:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(518, 130);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(146, 29);
            this.label5.TabIndex = 9;
            this.label5.Text = "Second title:";
            // 
            // Title1
            // 
            this.Title1.Location = new System.Drawing.Point(114, 129);
            this.Title1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Title1.Name = "Title1";
            this.Title1.Size = new System.Drawing.Size(196, 26);
            this.Title1.TabIndex = 10;
            // 
            // Title2
            // 
            this.Title2.Location = new System.Drawing.Point(693, 130);
            this.Title2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Title2.Name = "Title2";
            this.Title2.Size = new System.Drawing.Size(196, 26);
            this.Title2.TabIndex = 11;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(484, 185);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(79, 29);
            this.label6.TabIndex = 12;
            this.label6.Text = "Text1:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(838, 185);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(79, 29);
            this.label7.TabIndex = 13;
            this.label7.Text = "Text2:";
            // 
            // Text1
            // 
            this.Text1.Location = new System.Drawing.Point(362, 220);
            this.Text1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Text1.Name = "Text1";
            this.Text1.Size = new System.Drawing.Size(309, 312);
            this.Text1.TabIndex = 14;
            this.Text1.Text = "";
            // 
            // Text2
            // 
            this.Text2.Location = new System.Drawing.Point(719, 220);
            this.Text2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Text2.Name = "Text2";
            this.Text2.Size = new System.Drawing.Size(309, 312);
            this.Text2.TabIndex = 15;
            this.Text2.Text = "";
            // 
            // Add
            // 
            this.Add.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Add.Location = new System.Drawing.Point(362, 541);
            this.Add.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Add.Name = "Add";
            this.Add.Size = new System.Drawing.Size(666, 62);
            this.Add.TabIndex = 16;
            this.Add.Text = "Add";
            this.Add.UseVisualStyleBackColor = true;
            this.Add.Click += new System.EventHandler(this.Add_Click);
            // 
            // InsertBtn
            // 
            this.InsertBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.InsertBtn.Location = new System.Drawing.Point(280, 626);
            this.InsertBtn.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.InsertBtn.Name = "InsertBtn";
            this.InsertBtn.Size = new System.Drawing.Size(413, 74);
            this.InsertBtn.TabIndex = 17;
            this.InsertBtn.Text = "Insert";
            this.InsertBtn.UseVisualStyleBackColor = true;
            this.InsertBtn.Click += new System.EventHandler(this.Insert_Click);
            // 
            // ConfirmMsg
            // 
            this.ConfirmMsg.AutoSize = true;
            this.ConfirmMsg.Location = new System.Drawing.Point(728, 660);
            this.ConfirmMsg.Name = "ConfirmMsg";
            this.ConfirmMsg.Size = new System.Drawing.Size(296, 20);
            this.ConfirmMsg.TabIndex = 18;
            this.ConfirmMsg.Text = "The data has been successfully inserted.";
            // 
            // BackBtn
            // 
            this.BackBtn.Location = new System.Drawing.Point(56, 26);
            this.BackBtn.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.BackBtn.Name = "BackBtn";
            this.BackBtn.Size = new System.Drawing.Size(84, 29);
            this.BackBtn.TabIndex = 19;
            this.BackBtn.Text = "Back";
            this.BackBtn.UseVisualStyleBackColor = true;
            this.BackBtn.Click += new System.EventHandler(this.BackBtn_Click);
            // 
            // CreateSetForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1060, 715);
            this.Controls.Add(this.BackBtn);
            this.Controls.Add(this.ConfirmMsg);
            this.Controls.Add(this.InsertBtn);
            this.Controls.Add(this.Add);
            this.Controls.Add(this.Text2);
            this.Controls.Add(this.Text1);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.Title2);
            this.Controls.Add(this.Title1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.SetName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.msg);
            this.Controls.Add(this.FileName);
            this.Controls.Add(this.ChooseFile);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "CreateSetForm";
            this.Text = "CreateSetForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button ChooseFile;
        private System.Windows.Forms.OpenFileDialog OpenFile;
        private System.Windows.Forms.Label FileName;
        private System.Windows.Forms.Label msg;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox SetName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox Title1;
        private System.Windows.Forms.TextBox Title2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.RichTextBox Text1;
        private System.Windows.Forms.RichTextBox Text2;
        private System.Windows.Forms.Button Add;
        private System.Windows.Forms.Button InsertBtn;
        private System.Windows.Forms.Label ConfirmMsg;
        private System.Windows.Forms.Button BackBtn;
    }
}