namespace Thread2
{
    partial class SumingForm
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.labelWrite = new System.Windows.Forms.Label();
            this.buttonSum = new System.Windows.Forms.Button();
            this.labelResult = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox1.Location = new System.Drawing.Point(131, 32);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(137, 26);
            this.textBox1.TabIndex = 0;
            // 
            // textBox2
            // 
            this.textBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox2.Location = new System.Drawing.Point(131, 162);
            this.textBox2.Name = "textBox2";
            this.textBox2.ReadOnly = true;
            this.textBox2.Size = new System.Drawing.Size(141, 26);
            this.textBox2.TabIndex = 1;
            // 
            // labelWrite
            // 
            this.labelWrite.AutoSize = true;
            this.labelWrite.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelWrite.Location = new System.Drawing.Point(12, 32);
            this.labelWrite.Name = "labelWrite";
            this.labelWrite.Size = new System.Drawing.Size(112, 20);
            this.labelWrite.TabIndex = 2;
            this.labelWrite.Text = "Write number :";
            // 
            // buttonSum
            // 
            this.buttonSum.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonSum.Location = new System.Drawing.Point(168, 92);
            this.buttonSum.Name = "buttonSum";
            this.buttonSum.Size = new System.Drawing.Size(100, 31);
            this.buttonSum.TabIndex = 3;
            this.buttonSum.Text = "Sum";
            this.buttonSum.UseVisualStyleBackColor = true;
            this.buttonSum.Click += new System.EventHandler(this.buttonSum_Click);
            // 
            // labelResult
            // 
            this.labelResult.AutoSize = true;
            this.labelResult.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelResult.Location = new System.Drawing.Point(12, 168);
            this.labelResult.Name = "labelResult";
            this.labelResult.Size = new System.Drawing.Size(63, 20);
            this.labelResult.TabIndex = 4;
            this.labelResult.Text = "Result :";
            // 
            // SumingForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(293, 217);
            this.Controls.Add(this.labelResult);
            this.Controls.Add(this.buttonSum);
            this.Controls.Add(this.labelWrite);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "SumingForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Suming";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label labelWrite;
        private System.Windows.Forms.Button buttonSum;
        private System.Windows.Forms.Label labelResult;
    }
}

