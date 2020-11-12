namespace ComputingProject2
{
    partial class MessageForm
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
            this.Msg = new System.Windows.Forms.Label();
            this.Close = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Msg
            // 
            this.Msg.AutoSize = true;
            this.Msg.Location = new System.Drawing.Point(123, 17);
            this.Msg.Name = "Msg";
            this.Msg.Size = new System.Drawing.Size(74, 20);
            this.Msg.TabIndex = 0;
            this.Msg.Text = "Message";
            // 
            // Close
            // 
            this.Close.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Close.Location = new System.Drawing.Point(101, 62);
            this.Close.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Close.Name = "Close";
            this.Close.Size = new System.Drawing.Size(110, 35);
            this.Close.TabIndex = 1;
            this.Close.Text = "OK";
            this.Close.UseVisualStyleBackColor = true;
            this.Close.Click += new System.EventHandler(this.Close_Click);
            // 
            // MessageForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(317, 116);
            this.Controls.Add(this.Close);
            this.Controls.Add(this.Msg);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "MessageForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Message";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Msg;
        private System.Windows.Forms.Button Close;
    }
}