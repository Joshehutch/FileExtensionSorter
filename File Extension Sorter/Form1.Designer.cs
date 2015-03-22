namespace File_Extension_Sorter
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
            this.SorceBrowse = new System.Windows.Forms.Button();
            this.SourcePath = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.DestPath = new System.Windows.Forms.TextBox();
            this.DestBrowse = new System.Windows.Forms.Button();
            this.Start = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.TotalFileCounter = new System.Windows.Forms.Label();
            this.CurrentFileCounter = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // SorceBrowse
            // 
            this.SorceBrowse.Location = new System.Drawing.Point(374, 10);
            this.SorceBrowse.Name = "SorceBrowse";
            this.SorceBrowse.Size = new System.Drawing.Size(75, 23);
            this.SorceBrowse.TabIndex = 0;
            this.SorceBrowse.Text = "Browse";
            this.SorceBrowse.UseVisualStyleBackColor = true;
            this.SorceBrowse.Click += new System.EventHandler(this.SorceBrowse_Click);
            // 
            // SourcePath
            // 
            this.SourcePath.Location = new System.Drawing.Point(63, 12);
            this.SourcePath.Name = "SourcePath";
            this.SourcePath.Size = new System.Drawing.Size(311, 20);
            this.SourcePath.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Source";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Location = new System.Drawing.Point(3, 49);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Destination";
            // 
            // DestPath
            // 
            this.DestPath.Location = new System.Drawing.Point(63, 47);
            this.DestPath.Name = "DestPath";
            this.DestPath.Size = new System.Drawing.Size(311, 20);
            this.DestPath.TabIndex = 4;
            // 
            // DestBrowse
            // 
            this.DestBrowse.Location = new System.Drawing.Point(374, 45);
            this.DestBrowse.Name = "DestBrowse";
            this.DestBrowse.Size = new System.Drawing.Size(75, 23);
            this.DestBrowse.TabIndex = 3;
            this.DestBrowse.Text = "Browse";
            this.DestBrowse.UseVisualStyleBackColor = true;
            this.DestBrowse.Click += new System.EventHandler(this.DestBrowse_Click);
            // 
            // Start
            // 
            this.Start.Location = new System.Drawing.Point(455, 9);
            this.Start.Name = "Start";
            this.Start.Size = new System.Drawing.Size(62, 57);
            this.Start.TabIndex = 6;
            this.Start.Text = "Start";
            this.Start.UseVisualStyleBackColor = true;
            this.Start.Click += new System.EventHandler(this.Start_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(553, 5);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Total Files";
            // 
            // TotalFileCounter
            // 
            this.TotalFileCounter.AutoSize = true;
            this.TotalFileCounter.Location = new System.Drawing.Point(568, 19);
            this.TotalFileCounter.Name = "TotalFileCounter";
            this.TotalFileCounter.Size = new System.Drawing.Size(0, 13);
            this.TotalFileCounter.TabIndex = 8;
            // 
            // CurrentFileCounter
            // 
            this.CurrentFileCounter.AutoSize = true;
            this.CurrentFileCounter.Location = new System.Drawing.Point(568, 59);
            this.CurrentFileCounter.Name = "CurrentFileCounter";
            this.CurrentFileCounter.Size = new System.Drawing.Size(0, 13);
            this.CurrentFileCounter.TabIndex = 10;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(553, 45);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(60, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Current File";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(630, 79);
            this.Controls.Add(this.CurrentFileCounter);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.TotalFileCounter);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Start);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.DestPath);
            this.Controls.Add(this.DestBrowse);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.SourcePath);
            this.Controls.Add(this.SorceBrowse);
            this.Name = "Form1";
            this.Text = "File Extension Sorter";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button SorceBrowse;
        private System.Windows.Forms.TextBox SourcePath;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox DestPath;
        private System.Windows.Forms.Button DestBrowse;
        private System.Windows.Forms.Button Start;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label TotalFileCounter;
        private System.Windows.Forms.Label CurrentFileCounter;
        private System.Windows.Forms.Label label5;
    }
}

