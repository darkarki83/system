namespace Client
{
    partial class ClientForm
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
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.labelMessage = new System.Windows.Forms.Label();
            this.buttonSend = new System.Windows.Forms.Button();
            this.labelName = new System.Windows.Forms.Label();
            this.textBoxMassage = new System.Windows.Forms.TextBox();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.labelToMe = new System.Windows.Forms.Label();
            this.buttonDownload = new System.Windows.Forms.Button();
            this.buttonClier = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBoxName
            // 
            this.textBoxName.Location = new System.Drawing.Point(83, 24);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(285, 20);
            this.textBoxName.TabIndex = 13;
            // 
            // labelMessage
            // 
            this.labelMessage.AutoSize = true;
            this.labelMessage.Location = new System.Drawing.Point(9, 72);
            this.labelMessage.Name = "labelMessage";
            this.labelMessage.Size = new System.Drawing.Size(53, 13);
            this.labelMessage.TabIndex = 12;
            this.labelMessage.Text = "Message:";
            // 
            // buttonSend
            // 
            this.buttonSend.Location = new System.Drawing.Point(293, 103);
            this.buttonSend.Name = "buttonSend";
            this.buttonSend.Size = new System.Drawing.Size(75, 23);
            this.buttonSend.TabIndex = 7;
            this.buttonSend.Text = "Send";
            this.buttonSend.UseVisualStyleBackColor = true;
            this.buttonSend.Click += new System.EventHandler(this.buttonSend_Click);
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.Location = new System.Drawing.Point(15, 28);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(57, 13);
            this.labelName.TabIndex = 14;
            this.labelName.Text = "To Whom:";
            // 
            // textBoxMassage
            // 
            this.textBoxMassage.Location = new System.Drawing.Point(83, 68);
            this.textBoxMassage.Name = "textBoxMassage";
            this.textBoxMassage.Size = new System.Drawing.Size(285, 20);
            this.textBoxMassage.TabIndex = 15;
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(12, 166);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(356, 251);
            this.listBox1.TabIndex = 16;
            // 
            // labelToMe
            // 
            this.labelToMe.AutoSize = true;
            this.labelToMe.Location = new System.Drawing.Point(15, 139);
            this.labelToMe.Name = "labelToMe";
            this.labelToMe.Size = new System.Drawing.Size(79, 13);
            this.labelToMe.TabIndex = 17;
            this.labelToMe.Text = "Massage to me";
            // 
            // buttonDownload
            // 
            this.buttonDownload.Location = new System.Drawing.Point(284, 435);
            this.buttonDownload.Name = "buttonDownload";
            this.buttonDownload.Size = new System.Drawing.Size(84, 23);
            this.buttonDownload.TabIndex = 18;
            this.buttonDownload.Text = "Download";
            this.buttonDownload.UseVisualStyleBackColor = true;
            this.buttonDownload.Click += new System.EventHandler(this.buttonDownload_Click);
            // 
            // buttonClier
            // 
            this.buttonClier.Location = new System.Drawing.Point(12, 435);
            this.buttonClier.Name = "buttonClier";
            this.buttonClier.Size = new System.Drawing.Size(85, 23);
            this.buttonClier.TabIndex = 19;
            this.buttonClier.Text = "Clier";
            this.buttonClier.UseVisualStyleBackColor = true;
            // 
            // ClientForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(386, 470);
            this.Controls.Add(this.buttonClier);
            this.Controls.Add(this.buttonDownload);
            this.Controls.Add(this.labelToMe);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.textBoxMassage);
            this.Controls.Add(this.labelName);
            this.Controls.Add(this.textBoxName);
            this.Controls.Add(this.labelMessage);
            this.Controls.Add(this.buttonSend);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.Name = "ClientForm";
            this.Text = "Client";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxName;
        private System.Windows.Forms.Label labelMessage;
        private System.Windows.Forms.Button buttonSend;
        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.TextBox textBoxMassage;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Label labelToMe;
        private System.Windows.Forms.Button buttonDownload;
        private System.Windows.Forms.Button buttonClier;
    }
}

