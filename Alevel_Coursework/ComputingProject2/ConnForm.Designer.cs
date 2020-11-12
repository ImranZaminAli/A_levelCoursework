namespace ComputingProject2
{
    partial class ConnForm
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
            this.SndReqBtn = new System.Windows.Forms.Button();
            this.ViewReqBtn = new System.Windows.Forms.Button();
            this.RemoveConnBtn = new System.Windows.Forms.Button();
            this.ConnTeachBtn = new System.Windows.Forms.Button();
            this.BackBtn = new System.Windows.Forms.Button();
            this.IdTxt = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(11, 34);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(190, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Manage Connections";
            // 
            // SndReqBtn
            // 
            this.SndReqBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SndReqBtn.Location = new System.Drawing.Point(15, 73);
            this.SndReqBtn.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.SndReqBtn.Name = "SndReqBtn";
            this.SndReqBtn.Size = new System.Drawing.Size(180, 41);
            this.SndReqBtn.TabIndex = 1;
            this.SndReqBtn.Text = "Send Request";
            this.SndReqBtn.UseVisualStyleBackColor = true;
            this.SndReqBtn.Click += new System.EventHandler(this.SndReqBtn_Click);
            // 
            // ViewReqBtn
            // 
            this.ViewReqBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ViewReqBtn.Location = new System.Drawing.Point(15, 130);
            this.ViewReqBtn.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.ViewReqBtn.Name = "ViewReqBtn";
            this.ViewReqBtn.Size = new System.Drawing.Size(180, 41);
            this.ViewReqBtn.TabIndex = 2;
            this.ViewReqBtn.Text = "View Requests";
            this.ViewReqBtn.UseVisualStyleBackColor = true;
            this.ViewReqBtn.Click += new System.EventHandler(this.ViewReqBtn_Click);
            // 
            // RemoveConnBtn
            // 
            this.RemoveConnBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RemoveConnBtn.Location = new System.Drawing.Point(15, 187);
            this.RemoveConnBtn.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.RemoveConnBtn.Name = "RemoveConnBtn";
            this.RemoveConnBtn.Size = new System.Drawing.Size(180, 41);
            this.RemoveConnBtn.TabIndex = 3;
            this.RemoveConnBtn.Text = "Remove Connections";
            this.RemoveConnBtn.UseVisualStyleBackColor = true;
            this.RemoveConnBtn.Click += new System.EventHandler(this.RemoveConnBtn_Click);
            // 
            // ConnTeachBtn
            // 
            this.ConnTeachBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ConnTeachBtn.Location = new System.Drawing.Point(15, 244);
            this.ConnTeachBtn.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.ConnTeachBtn.Name = "ConnTeachBtn";
            this.ConnTeachBtn.Size = new System.Drawing.Size(180, 41);
            this.ConnTeachBtn.TabIndex = 4;
            this.ConnTeachBtn.Text = "Connect to teacher";
            this.ConnTeachBtn.UseVisualStyleBackColor = true;
            this.ConnTeachBtn.Click += new System.EventHandler(this.ConnTeachBtn_Click);
            // 
            // BackBtn
            // 
            this.BackBtn.Location = new System.Drawing.Point(9, 5);
            this.BackBtn.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.BackBtn.Name = "BackBtn";
            this.BackBtn.Size = new System.Drawing.Size(42, 19);
            this.BackBtn.TabIndex = 5;
            this.BackBtn.Text = "Back";
            this.BackBtn.UseVisualStyleBackColor = true;
            this.BackBtn.Click += new System.EventHandler(this.BackBtn_Click);
            // 
            // IdTxt
            // 
            this.IdTxt.AutoSize = true;
            this.IdTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IdTxt.Location = new System.Drawing.Point(107, 8);
            this.IdTxt.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.IdTxt.Name = "IdTxt";
            this.IdTxt.Size = new System.Drawing.Size(84, 13);
            this.IdTxt.TabIndex = 6;
            this.IdTxt.Text = "Your id is: ##";
            // 
            // ConnForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(212, 297);
            this.Controls.Add(this.IdTxt);
            this.Controls.Add(this.BackBtn);
            this.Controls.Add(this.ConnTeachBtn);
            this.Controls.Add(this.RemoveConnBtn);
            this.Controls.Add(this.ViewReqBtn);
            this.Controls.Add(this.SndReqBtn);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "ConnForm";
            this.Text = " ";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button SndReqBtn;
        private System.Windows.Forms.Button ViewReqBtn;
        private System.Windows.Forms.Button RemoveConnBtn;
        private System.Windows.Forms.Button ConnTeachBtn;
        private System.Windows.Forms.Button BackBtn;
        private System.Windows.Forms.Label IdTxt;
    }
}