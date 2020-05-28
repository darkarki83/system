namespace Simafor
{
    partial class FormSimafor
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
            this.WorkThread = new System.Windows.Forms.Label();
            this.WaitThread = new System.Windows.Forms.Label();
            this.NewThread = new System.Windows.Forms.Label();
            this.listBoxWork = new System.Windows.Forms.ListBox();
            this.listBoxWait = new System.Windows.Forms.ListBox();
            this.listBoxNew = new System.Windows.Forms.ListBox();
            this.NumberPlace = new System.Windows.Forms.Label();
            this.buttonCreate = new System.Windows.Forms.Button();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.SuspendLayout();
            // 
            // WorkThread
            // 
            this.WorkThread.AutoSize = true;
            this.WorkThread.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.WorkThread.Location = new System.Drawing.Point(28, 34);
            this.WorkThread.Name = "WorkThread";
            this.WorkThread.Size = new System.Drawing.Size(106, 16);
            this.WorkThread.TabIndex = 0;
            this.WorkThread.Text = "Work Threads";
            // 
            // WaitThread
            // 
            this.WaitThread.AutoSize = true;
            this.WaitThread.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.WaitThread.Location = new System.Drawing.Point(245, 33);
            this.WaitThread.Name = "WaitThread";
            this.WaitThread.Size = new System.Drawing.Size(101, 16);
            this.WaitThread.TabIndex = 1;
            this.WaitThread.Text = "Wait Threads";
            // 
            // NewThread
            // 
            this.NewThread.AutoSize = true;
            this.NewThread.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.NewThread.Location = new System.Drawing.Point(457, 34);
            this.NewThread.Name = "NewThread";
            this.NewThread.Size = new System.Drawing.Size(100, 16);
            this.NewThread.TabIndex = 2;
            this.NewThread.Text = "New Threads";
            // 
            // listBoxWork
            // 
            this.listBoxWork.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.listBoxWork.FormattingEnabled = true;
            this.listBoxWork.ItemHeight = 20;
            this.listBoxWork.Location = new System.Drawing.Point(12, 69);
            this.listBoxWork.Name = "listBoxWork";
            this.listBoxWork.Size = new System.Drawing.Size(190, 104);
            this.listBoxWork.TabIndex = 3;
            this.listBoxWork.Click += new System.EventHandler(this.listBoxWork_Click);
            // 
            // listBoxWait
            // 
            this.listBoxWait.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.listBoxWait.FormattingEnabled = true;
            this.listBoxWait.ItemHeight = 20;
            this.listBoxWait.Location = new System.Drawing.Point(232, 69);
            this.listBoxWait.Name = "listBoxWait";
            this.listBoxWait.Size = new System.Drawing.Size(190, 104);
            this.listBoxWait.TabIndex = 4;
            this.listBoxWait.Click += new System.EventHandler(this.listBoxWait_Click);
            // 
            // listBoxNew
            // 
            this.listBoxNew.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.listBoxNew.FormattingEnabled = true;
            this.listBoxNew.ItemHeight = 20;
            this.listBoxNew.Location = new System.Drawing.Point(444, 69);
            this.listBoxNew.Name = "listBoxNew";
            this.listBoxNew.Size = new System.Drawing.Size(190, 104);
            this.listBoxNew.TabIndex = 5;
            this.listBoxNew.Click += new System.EventHandler(this.listBoxNew_Click);
            this.listBoxNew.DoubleClick += new System.EventHandler(this.listBoxNew_DoubleClick);
            // 
            // NumberPlace
            // 
            this.NumberPlace.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.NumberPlace.AutoSize = true;
            this.NumberPlace.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.NumberPlace.Location = new System.Drawing.Point(31, 242);
            this.NumberPlace.Name = "NumberPlace";
            this.NumberPlace.Size = new System.Drawing.Size(261, 16);
            this.NumberPlace.TabIndex = 6;
            this.NumberPlace.Text = " Number of places in the semaphore ";
            // 
            // buttonCreate
            // 
            this.buttonCreate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.buttonCreate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonCreate.Location = new System.Drawing.Point(369, 268);
            this.buttonCreate.Name = "buttonCreate";
            this.buttonCreate.Size = new System.Drawing.Size(136, 33);
            this.buttonCreate.TabIndex = 8;
            this.buttonCreate.Text = "Create Thread";
            this.buttonCreate.UseVisualStyleBackColor = true;
            this.buttonCreate.Click += new System.EventHandler(this.buttonCreate_Click);
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.numericUpDown1.Location = new System.Drawing.Point(92, 279);
            this.numericUpDown1.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.numericUpDown1.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(127, 22);
            this.numericUpDown1.TabIndex = 9;
            this.numericUpDown1.Value = new decimal(new int[] {
            3,
            0,
            0,
            0});
            this.numericUpDown1.ValueChanged += new System.EventHandler(this.numericUpDown1_ValueChanged);
            // 
            // FormSimafor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(646, 321);
            this.Controls.Add(this.numericUpDown1);
            this.Controls.Add(this.buttonCreate);
            this.Controls.Add(this.NumberPlace);
            this.Controls.Add(this.listBoxNew);
            this.Controls.Add(this.listBoxWait);
            this.Controls.Add(this.listBoxWork);
            this.Controls.Add(this.NewThread);
            this.Controls.Add(this.WaitThread);
            this.Controls.Add(this.WorkThread);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormSimafor";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Simafor";
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label WorkThread;
        private System.Windows.Forms.Label WaitThread;
        private System.Windows.Forms.Label NewThread;
        private System.Windows.Forms.ListBox listBoxWork;
        private System.Windows.Forms.ListBox listBoxWait;
        private System.Windows.Forms.ListBox listBoxNew;
        private System.Windows.Forms.Label NumberPlace;
        private System.Windows.Forms.Button buttonCreate;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
    }
}

