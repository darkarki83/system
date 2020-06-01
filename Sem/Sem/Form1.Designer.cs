namespace Sem
{
    partial class Form1
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
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.buttonCreate = new System.Windows.Forms.Button();
            this.NumberPlace = new System.Windows.Forms.Label();
            this.NewThread = new System.Windows.Forms.Label();
            this.WaitThread = new System.Windows.Forms.Label();
            this.WorkThread = new System.Windows.Forms.Label();
            this.columnName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnStat = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.listViewWork = new System.Windows.Forms.ListView();
            this.listViewWait = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.listViewNew = new System.Windows.Forms.ListView();
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.SuspendLayout();
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.numericUpDown1.Location = new System.Drawing.Point(154, 299);
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
            this.numericUpDown1.TabIndex = 18;
            this.numericUpDown1.Value = new decimal(new int[] {
            3,
            0,
            0,
            0});
            // 
            // buttonCreate
            // 
            this.buttonCreate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.buttonCreate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonCreate.Location = new System.Drawing.Point(431, 287);
            this.buttonCreate.Name = "buttonCreate";
            this.buttonCreate.Size = new System.Drawing.Size(136, 33);
            this.buttonCreate.TabIndex = 17;
            this.buttonCreate.Text = "Create Thread";
            this.buttonCreate.UseVisualStyleBackColor = true;
            this.buttonCreate.Click += new System.EventHandler(this.buttonCreate_Click);
            // 
            // NumberPlace
            // 
            this.NumberPlace.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.NumberPlace.AutoSize = true;
            this.NumberPlace.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.NumberPlace.Location = new System.Drawing.Point(93, 261);
            this.NumberPlace.Name = "NumberPlace";
            this.NumberPlace.Size = new System.Drawing.Size(261, 16);
            this.NumberPlace.TabIndex = 16;
            this.NumberPlace.Text = " Number of places in the semaphore ";
            // 
            // NewThread
            // 
            this.NewThread.AutoSize = true;
            this.NewThread.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.NewThread.Location = new System.Drawing.Point(572, 54);
            this.NewThread.Name = "NewThread";
            this.NewThread.Size = new System.Drawing.Size(100, 16);
            this.NewThread.TabIndex = 12;
            this.NewThread.Text = "New Threads";
            // 
            // WaitThread
            // 
            this.WaitThread.AutoSize = true;
            this.WaitThread.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.WaitThread.Location = new System.Drawing.Point(326, 54);
            this.WaitThread.Name = "WaitThread";
            this.WaitThread.Size = new System.Drawing.Size(101, 16);
            this.WaitThread.TabIndex = 11;
            this.WaitThread.Text = "Wait Threads";
            // 
            // WorkThread
            // 
            this.WorkThread.AutoSize = true;
            this.WorkThread.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.WorkThread.Location = new System.Drawing.Point(62, 54);
            this.WorkThread.Name = "WorkThread";
            this.WorkThread.Size = new System.Drawing.Size(106, 16);
            this.WorkThread.TabIndex = 10;
            this.WorkThread.Text = "Work Threads";
            // 
            // columnName
            // 
            this.columnName.Text = "Name";
            this.columnName.Width = 120;
            // 
            // columnStat
            // 
            this.columnStat.Text = "Stat";
            this.columnStat.Width = 82;
            // 
            // listViewWork
            // 
            this.listViewWork.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnName,
            this.columnStat});
            this.listViewWork.HideSelection = false;
            this.listViewWork.Location = new System.Drawing.Point(21, 89);
            this.listViewWork.MultiSelect = false;
            this.listViewWork.Name = "listViewWork";
            this.listViewWork.Size = new System.Drawing.Size(206, 142);
            this.listViewWork.TabIndex = 19;
            this.listViewWork.UseCompatibleStateImageBehavior = false;
            this.listViewWork.View = System.Windows.Forms.View.Details;
            this.listViewWork.DoubleClick += new System.EventHandler(this.listViewWork_DoubleClick);
            // 
            // listViewWait
            // 
            this.listViewWait.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2});
            this.listViewWait.HideSelection = false;
            this.listViewWait.Location = new System.Drawing.Point(271, 89);
            this.listViewWait.MultiSelect = false;
            this.listViewWait.Name = "listViewWait";
            this.listViewWait.Size = new System.Drawing.Size(206, 142);
            this.listViewWait.TabIndex = 20;
            this.listViewWait.UseCompatibleStateImageBehavior = false;
            this.listViewWait.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Name";
            this.columnHeader1.Width = 120;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Stat";
            this.columnHeader2.Width = 82;
            // 
            // listViewNew
            // 
            this.listViewNew.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader3,
            this.columnHeader4});
            this.listViewNew.HideSelection = false;
            this.listViewNew.Location = new System.Drawing.Point(522, 89);
            this.listViewNew.MultiSelect = false;
            this.listViewNew.Name = "listViewNew";
            this.listViewNew.Size = new System.Drawing.Size(206, 142);
            this.listViewNew.TabIndex = 21;
            this.listViewNew.UseCompatibleStateImageBehavior = false;
            this.listViewNew.View = System.Windows.Forms.View.Details;
            this.listViewNew.DoubleClick += new System.EventHandler(this.listViewNew_DoubleClick);
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Name";
            this.columnHeader3.Width = 120;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Stat";
            this.columnHeader4.Width = 82;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(760, 373);
            this.Controls.Add(this.listViewNew);
            this.Controls.Add(this.listViewWait);
            this.Controls.Add(this.listViewWork);
            this.Controls.Add(this.numericUpDown1);
            this.Controls.Add(this.buttonCreate);
            this.Controls.Add(this.NumberPlace);
            this.Controls.Add(this.NewThread);
            this.Controls.Add(this.WaitThread);
            this.Controls.Add(this.WorkThread);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.Button buttonCreate;
        private System.Windows.Forms.Label NumberPlace;
        private System.Windows.Forms.Label NewThread;
        private System.Windows.Forms.Label WaitThread;
        private System.Windows.Forms.Label WorkThread;
        private System.Windows.Forms.ColumnHeader columnName;
        private System.Windows.Forms.ColumnHeader columnStat;
        private System.Windows.Forms.ListView listViewWork;
        private System.Windows.Forms.ListView listViewWait;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ListView listViewNew;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
    }
}

