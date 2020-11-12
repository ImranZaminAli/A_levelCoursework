namespace ComputingProject2
{
    partial class EditSetForm
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
            this.ChooseSet = new System.Windows.Forms.ComboBox();
            this.SelectSetBtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.Text1 = new System.Windows.Forms.RichTextBox();
            this.Text2 = new System.Windows.Forms.RichTextBox();
            this.Title1 = new System.Windows.Forms.TextBox();
            this.Title2 = new System.Windows.Forms.TextBox();
            this.ForwardsBtn = new System.Windows.Forms.Button();
            this.BackwardsBtn = new System.Windows.Forms.Button();
            this.NewCardBtn = new System.Windows.Forms.Button();
            this.SaveCardsBtn = new System.Windows.Forms.Button();
            this.DeleteCardBtn = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.SaveTitleBtn = new System.Windows.Forms.Button();
            this.DeleteSetBtn = new System.Windows.Forms.Button();
            this.PointerVal = new System.Windows.Forms.Label();
            this.PointerInput = new System.Windows.Forms.TextBox();
            this.JumpBtn = new System.Windows.Forms.Button();
            this.BackBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ChooseSet
            // 
            this.ChooseSet.FormattingEnabled = true;
            this.ChooseSet.Location = new System.Drawing.Point(194, 73);
            this.ChooseSet.Name = "ChooseSet";
            this.ChooseSet.Size = new System.Drawing.Size(183, 24);
            this.ChooseSet.TabIndex = 0;
            // 
            // SelectSetBtn
            // 
            this.SelectSetBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SelectSetBtn.Location = new System.Drawing.Point(383, 67);
            this.SelectSetBtn.Name = "SelectSetBtn";
            this.SelectSetBtn.Size = new System.Drawing.Size(100, 35);
            this.SelectSetBtn.TabIndex = 1;
            this.SelectSetBtn.Text = "Load";
            this.SelectSetBtn.UseVisualStyleBackColor = true;
            this.SelectSetBtn.Click += new System.EventHandler(this.SelectSetBtn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(330, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(115, 32);
            this.label1.TabIndex = 2;
            this.label1.Text = "Edit Set";
            // 
            // Text1
            // 
            this.Text1.Location = new System.Drawing.Point(25, 170);
            this.Text1.Name = "Text1";
            this.Text1.Size = new System.Drawing.Size(300, 250);
            this.Text1.TabIndex = 3;
            this.Text1.Text = "";
            // 
            // Text2
            // 
            this.Text2.Location = new System.Drawing.Point(445, 170);
            this.Text2.Name = "Text2";
            this.Text2.Size = new System.Drawing.Size(300, 250);
            this.Text2.TabIndex = 4;
            this.Text2.Text = "";
            // 
            // Title1
            // 
            this.Title1.Location = new System.Drawing.Point(25, 125);
            this.Title1.Name = "Title1";
            this.Title1.Size = new System.Drawing.Size(299, 22);
            this.Title1.TabIndex = 5;
            // 
            // Title2
            // 
            this.Title2.Location = new System.Drawing.Point(445, 125);
            this.Title2.Name = "Title2";
            this.Title2.Size = new System.Drawing.Size(300, 22);
            this.Title2.TabIndex = 6;
            // 
            // ForwardsBtn
            // 
            this.ForwardsBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForwardsBtn.Location = new System.Drawing.Point(665, 67);
            this.ForwardsBtn.Name = "ForwardsBtn";
            this.ForwardsBtn.Size = new System.Drawing.Size(80, 34);
            this.ForwardsBtn.TabIndex = 7;
            this.ForwardsBtn.Text = "---->";
            this.ForwardsBtn.UseVisualStyleBackColor = true;
            this.ForwardsBtn.Click += new System.EventHandler(this.ForwardsBtn_Click);
            // 
            // BackwardsBtn
            // 
            this.BackwardsBtn.Location = new System.Drawing.Point(25, 67);
            this.BackwardsBtn.Name = "BackwardsBtn";
            this.BackwardsBtn.Size = new System.Drawing.Size(81, 34);
            this.BackwardsBtn.TabIndex = 8;
            this.BackwardsBtn.Text = "<----";
            this.BackwardsBtn.UseVisualStyleBackColor = true;
            this.BackwardsBtn.Click += new System.EventHandler(this.BackwardsBtn_Click);
            // 
            // NewCardBtn
            // 
            this.NewCardBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NewCardBtn.Location = new System.Drawing.Point(577, 503);
            this.NewCardBtn.Name = "NewCardBtn";
            this.NewCardBtn.Size = new System.Drawing.Size(168, 42);
            this.NewCardBtn.TabIndex = 9;
            this.NewCardBtn.Text = "Add New Card";
            this.NewCardBtn.UseVisualStyleBackColor = true;
            this.NewCardBtn.Click += new System.EventHandler(this.NewCardBtn_Click);
            // 
            // SaveCardsBtn
            // 
            this.SaveCardsBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SaveCardsBtn.Location = new System.Drawing.Point(295, 454);
            this.SaveCardsBtn.Name = "SaveCardsBtn";
            this.SaveCardsBtn.Size = new System.Drawing.Size(182, 75);
            this.SaveCardsBtn.TabIndex = 10;
            this.SaveCardsBtn.Text = "Save";
            this.SaveCardsBtn.UseVisualStyleBackColor = true;
            this.SaveCardsBtn.Click += new System.EventHandler(this.SaveCardsBtn_Click);
            // 
            // DeleteCardBtn
            // 
            this.DeleteCardBtn.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.DeleteCardBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DeleteCardBtn.Location = new System.Drawing.Point(25, 503);
            this.DeleteCardBtn.Name = "DeleteCardBtn";
            this.DeleteCardBtn.Size = new System.Drawing.Size(168, 42);
            this.DeleteCardBtn.TabIndex = 11;
            this.DeleteCardBtn.Text = "Delete Current Card";
            this.DeleteCardBtn.UseVisualStyleBackColor = true;
            this.DeleteCardBtn.Click += new System.EventHandler(this.DeleteCardBtn_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(538, 454);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(207, 45);
            this.label2.TabIndex = 12;
            this.label2.Text = "Delete the text in the textboxes and \r\nenter the information you want in the \r\nne" +
    "w flashcard\r\n";
            // 
            // SaveTitleBtn
            // 
            this.SaveTitleBtn.Location = new System.Drawing.Point(338, 125);
            this.SaveTitleBtn.Name = "SaveTitleBtn";
            this.SaveTitleBtn.Size = new System.Drawing.Size(91, 23);
            this.SaveTitleBtn.TabIndex = 13;
            this.SaveTitleBtn.Text = "Save Titles";
            this.SaveTitleBtn.UseVisualStyleBackColor = true;
            this.SaveTitleBtn.Click += new System.EventHandler(this.SaveTitleBtn_Click);
            // 
            // DeleteSetBtn
            // 
            this.DeleteSetBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DeleteSetBtn.Location = new System.Drawing.Point(505, 67);
            this.DeleteSetBtn.Name = "DeleteSetBtn";
            this.DeleteSetBtn.Size = new System.Drawing.Size(100, 35);
            this.DeleteSetBtn.TabIndex = 14;
            this.DeleteSetBtn.Text = "Delete Set";
            this.DeleteSetBtn.UseVisualStyleBackColor = true;
            this.DeleteSetBtn.Click += new System.EventHandler(this.DeleteSetBtn_Click);
            // 
            // PointerVal
            // 
            this.PointerVal.AutoSize = true;
            this.PointerVal.Location = new System.Drawing.Point(346, 219);
            this.PointerVal.Name = "PointerVal";
            this.PointerVal.Size = new System.Drawing.Size(72, 17);
            this.PointerVal.TabIndex = 15;
            this.PointerVal.Text = "pointerVal";
            // 
            // PointerInput
            // 
            this.PointerInput.Location = new System.Drawing.Point(339, 266);
            this.PointerInput.Name = "PointerInput";
            this.PointerInput.Size = new System.Drawing.Size(100, 22);
            this.PointerInput.TabIndex = 16;
            // 
            // JumpBtn
            // 
            this.JumpBtn.Location = new System.Drawing.Point(354, 327);
            this.JumpBtn.Name = "JumpBtn";
            this.JumpBtn.Size = new System.Drawing.Size(75, 26);
            this.JumpBtn.TabIndex = 17;
            this.JumpBtn.Text = "Jump to";
            this.JumpBtn.UseVisualStyleBackColor = true;
            this.JumpBtn.Click += new System.EventHandler(this.JumpBtn_Click);
            // 
            // BackBtn
            // 
            this.BackBtn.Location = new System.Drawing.Point(25, 13);
            this.BackBtn.Name = "BackBtn";
            this.BackBtn.Size = new System.Drawing.Size(75, 23);
            this.BackBtn.TabIndex = 18;
            this.BackBtn.Text = "Back";
            this.BackBtn.UseVisualStyleBackColor = true;
            this.BackBtn.Click += new System.EventHandler(this.BackBtn_Click);
            // 
            // EditSetForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 557);
            this.Controls.Add(this.BackBtn);
            this.Controls.Add(this.JumpBtn);
            this.Controls.Add(this.PointerInput);
            this.Controls.Add(this.PointerVal);
            this.Controls.Add(this.DeleteSetBtn);
            this.Controls.Add(this.SaveTitleBtn);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.DeleteCardBtn);
            this.Controls.Add(this.SaveCardsBtn);
            this.Controls.Add(this.NewCardBtn);
            this.Controls.Add(this.BackwardsBtn);
            this.Controls.Add(this.ForwardsBtn);
            this.Controls.Add(this.Title2);
            this.Controls.Add(this.Title1);
            this.Controls.Add(this.Text2);
            this.Controls.Add(this.Text1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.SelectSetBtn);
            this.Controls.Add(this.ChooseSet);
            this.Name = "EditSetForm";
            this.Text = "EditSetForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox ChooseSet;
        private System.Windows.Forms.Button SelectSetBtn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RichTextBox Text1;
        private System.Windows.Forms.RichTextBox Text2;
        private System.Windows.Forms.TextBox Title1;
        private System.Windows.Forms.TextBox Title2;
        private System.Windows.Forms.Button ForwardsBtn;
        private System.Windows.Forms.Button BackwardsBtn;
        private System.Windows.Forms.Button NewCardBtn;
        private System.Windows.Forms.Button SaveCardsBtn;
        private System.Windows.Forms.Button DeleteCardBtn;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button SaveTitleBtn;
        private System.Windows.Forms.Button DeleteSetBtn;
        private System.Windows.Forms.Label PointerVal;
        private System.Windows.Forms.TextBox PointerInput;
        private System.Windows.Forms.Button JumpBtn;
        private System.Windows.Forms.Button BackBtn;
    }
}