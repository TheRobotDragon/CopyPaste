namespace CopyPaste
{
    partial class MainForm
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
            this.BtnSend = new System.Windows.Forms.Button();
            this.BtnRetrieve = new System.Windows.Forms.Button();
            this.tbText = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // BtnSend
            // 
            this.BtnSend.Location = new System.Drawing.Point(2, 1);
            this.BtnSend.Name = "BtnSend";
            this.BtnSend.Size = new System.Drawing.Size(144, 23);
            this.BtnSend.TabIndex = 0;
            this.BtnSend.Text = "Send";
            this.BtnSend.UseVisualStyleBackColor = true;
            this.BtnSend.Click += new System.EventHandler(this.BtnSend_Click);
            // 
            // BtnRetrieve
            // 
            this.BtnRetrieve.Location = new System.Drawing.Point(152, 1);
            this.BtnRetrieve.Name = "BtnRetrieve";
            this.BtnRetrieve.Size = new System.Drawing.Size(128, 23);
            this.BtnRetrieve.TabIndex = 1;
            this.BtnRetrieve.Text = "Retrieve";
            this.BtnRetrieve.UseVisualStyleBackColor = true;
            this.BtnRetrieve.Click += new System.EventHandler(this.BtnRetrieve_Click);
            // 
            // tbText
            // 
            this.tbText.Location = new System.Drawing.Point(2, 30);
            this.tbText.Multiline = true;
            this.tbText.Name = "tbText";
            this.tbText.Size = new System.Drawing.Size(278, 227);
            this.tbText.TabIndex = 2;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.tbText);
            this.Controls.Add(this.BtnRetrieve);
            this.Controls.Add(this.BtnSend);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "MainForm";
            this.Text = "CopyPaste";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnSend;
        private System.Windows.Forms.Button BtnRetrieve;
        private System.Windows.Forms.TextBox tbText;
    }
}

