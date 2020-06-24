namespace Thread4
{
    partial class CatalogForm
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
            this.labelFolder = new System.Windows.Forms.Label();
            this.labelFiles = new System.Windows.Forms.Label();
            this.labelSize = new System.Windows.Forms.Label();
            this.textFolder = new System.Windows.Forms.TextBox();
            this.textFiles = new System.Windows.Forms.TextBox();
            this.textSize = new System.Windows.Forms.TextBox();
            this.label1Gb = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // labelFolder
            // 
            this.labelFolder.AutoSize = true;
            this.labelFolder.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelFolder.Location = new System.Drawing.Point(39, 49);
            this.labelFolder.Name = "labelFolder";
            this.labelFolder.Size = new System.Drawing.Size(60, 16);
            this.labelFolder.TabIndex = 0;
            this.labelFolder.Text = "Folders :";
            // 
            // labelFiles
            // 
            this.labelFiles.AutoSize = true;
            this.labelFiles.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelFiles.Location = new System.Drawing.Point(39, 100);
            this.labelFiles.Name = "labelFiles";
            this.labelFiles.Size = new System.Drawing.Size(43, 16);
            this.labelFiles.TabIndex = 1;
            this.labelFiles.Text = "Files :";
            // 
            // labelSize
            // 
            this.labelSize.AutoSize = true;
            this.labelSize.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelSize.Location = new System.Drawing.Point(42, 151);
            this.labelSize.Name = "labelSize";
            this.labelSize.Size = new System.Drawing.Size(40, 16);
            this.labelSize.TabIndex = 2;
            this.labelSize.Text = "Size :";
            // 
            // textFolder
            // 
            this.textFolder.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textFolder.Location = new System.Drawing.Point(143, 42);
            this.textFolder.Name = "textFolder";
            this.textFolder.ReadOnly = true;
            this.textFolder.Size = new System.Drawing.Size(156, 22);
            this.textFolder.TabIndex = 3;
            // 
            // textFiles
            // 
            this.textFiles.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textFiles.Location = new System.Drawing.Point(143, 94);
            this.textFiles.Name = "textFiles";
            this.textFiles.ReadOnly = true;
            this.textFiles.Size = new System.Drawing.Size(156, 22);
            this.textFiles.TabIndex = 4;
            // 
            // textSize
            // 
            this.textSize.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textSize.Location = new System.Drawing.Point(143, 146);
            this.textSize.Name = "textSize";
            this.textSize.ReadOnly = true;
            this.textSize.Size = new System.Drawing.Size(92, 22);
            this.textSize.TabIndex = 5;
            // 
            // label1Gb
            // 
            this.label1Gb.AutoSize = true;
            this.label1Gb.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1Gb.Location = new System.Drawing.Point(273, 152);
            this.label1Gb.Name = "label1Gb";
            this.label1Gb.Size = new System.Drawing.Size(26, 16);
            this.label1Gb.TabIndex = 6;
            this.label1Gb.Text = "Gb";
            // 
            // CatalogForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(336, 194);
            this.Controls.Add(this.label1Gb);
            this.Controls.Add(this.textSize);
            this.Controls.Add(this.textFiles);
            this.Controls.Add(this.textFolder);
            this.Controls.Add(this.labelSize);
            this.Controls.Add(this.labelFiles);
            this.Controls.Add(this.labelFolder);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "CatalogForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CatalogForm";
            this.Load += new System.EventHandler(this.CatalogForm_Load_1);
            this.Enter += new System.EventHandler(this.CatalogForm_Enter_1);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelFolder;
        private System.Windows.Forms.Label labelFiles;
        private System.Windows.Forms.Label labelSize;
        private System.Windows.Forms.TextBox textFolder;
        private System.Windows.Forms.TextBox textFiles;
        private System.Windows.Forms.TextBox textSize;
        private System.Windows.Forms.Label label1Gb;
    }
}