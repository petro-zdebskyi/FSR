namespace FSR.DesktopUI.Forms
{
    partial class InfoForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(InfoForm));
            this.lblZeroStatus = new System.Windows.Forms.Label();
            this.lblOneStatus = new System.Windows.Forms.Label();
            this.lblTwoStatus = new System.Windows.Forms.Label();
            this.btnClose = new System.Windows.Forms.Button();
            this.lblFirstColumn = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblZeroStatus
            // 
            this.lblZeroStatus.AutoSize = true;
            this.lblZeroStatus.Location = new System.Drawing.Point(12, 9);
            this.lblZeroStatus.Name = "lblZeroStatus";
            this.lblZeroStatus.Size = new System.Drawing.Size(159, 13);
            this.lblZeroStatus.TabIndex = 0;
            this.lblZeroStatus.Text = "Seat status 0  - free (dark green)";
            // 
            // lblOneStatus
            // 
            this.lblOneStatus.AutoSize = true;
            this.lblOneStatus.Location = new System.Drawing.Point(12, 44);
            this.lblOneStatus.Name = "lblOneStatus";
            this.lblOneStatus.Size = new System.Drawing.Size(177, 13);
            this.lblOneStatus.TabIndex = 1;
            this.lblOneStatus.Text = "Seat status 1 - reserved (light green)";
            // 
            // lblTwoStatus
            // 
            this.lblTwoStatus.AutoSize = true;
            this.lblTwoStatus.Location = new System.Drawing.Point(12, 84);
            this.lblTwoStatus.Name = "lblTwoStatus";
            this.lblTwoStatus.Size = new System.Drawing.Size(157, 13);
            this.lblTwoStatus.TabIndex = 2;
            this.lblTwoStatus.Text = "Seat state 2 - cancelled (yellow)";
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(197, 168);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(75, 23);
            this.btnClose.TabIndex = 3;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // lblFirstColumn
            // 
            this.lblFirstColumn.AutoSize = true;
            this.lblFirstColumn.Location = new System.Drawing.Point(12, 123);
            this.lblFirstColumn.Name = "lblFirstColumn";
            this.lblFirstColumn.Size = new System.Drawing.Size(203, 13);
            this.lblFirstColumn.TabIndex = 4;
            this.lblFirstColumn.Text = "ID of reservation - first column in main grid";
            // 
            // InfoForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 203);
            this.Controls.Add(this.lblFirstColumn);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.lblTwoStatus);
            this.Controls.Add(this.lblOneStatus);
            this.Controls.Add(this.lblZeroStatus);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "InfoForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Info";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblZeroStatus;
        private System.Windows.Forms.Label lblOneStatus;
        private System.Windows.Forms.Label lblTwoStatus;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Label lblFirstColumn;
    }
}