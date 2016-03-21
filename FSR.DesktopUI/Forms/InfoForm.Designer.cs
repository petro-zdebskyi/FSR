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
            this.SuspendLayout();
            // 
            // lblZeroStatus
            // 
            this.lblZeroStatus.AutoSize = true;
            this.lblZeroStatus.Location = new System.Drawing.Point(12, 29);
            this.lblZeroStatus.Name = "lblZeroStatus";
            this.lblZeroStatus.Size = new System.Drawing.Size(211, 13);
            this.lblZeroStatus.TabIndex = 0;
            this.lblZeroStatus.Text = "Статус місця 0  - Вільно (темно зелений)";
            // 
            // lblOneStatus
            // 
            this.lblOneStatus.AutoSize = true;
            this.lblOneStatus.Location = new System.Drawing.Point(12, 71);
            this.lblOneStatus.Name = "lblOneStatus";
            this.lblOneStatus.Size = new System.Drawing.Size(254, 13);
            this.lblOneStatus.TabIndex = 1;
            this.lblOneStatus.Text = "Статус місця 1 - Зарезервовано (світло зелений)";
            // 
            // lblTwoStatus
            // 
            this.lblTwoStatus.AutoSize = true;
            this.lblTwoStatus.Location = new System.Drawing.Point(12, 118);
            this.lblTwoStatus.Name = "lblTwoStatus";
            this.lblTwoStatus.Size = new System.Drawing.Size(265, 13);
            this.lblTwoStatus.TabIndex = 2;
            this.lblTwoStatus.Text = "Статус місця 2 - Скасовано резервування (жовтий)";
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(197, 168);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(75, 23);
            this.btnClose.TabIndex = 3;
            this.btnClose.Text = "Закрити";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // InfoForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 203);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.lblTwoStatus);
            this.Controls.Add(this.lblOneStatus);
            this.Controls.Add(this.lblZeroStatus);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "InfoForm";
            this.Text = "Довідка";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblZeroStatus;
        private System.Windows.Forms.Label lblOneStatus;
        private System.Windows.Forms.Label lblTwoStatus;
        private System.Windows.Forms.Button btnClose;
    }
}