namespace FSR.DesktopUI.Forms
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.dgvSeatStatuses = new System.Windows.Forms.DataGridView();
            this.btnPriceList = new System.Windows.Forms.Button();
            this.btnFindById = new System.Windows.Forms.Button();
            this.txtFindById = new System.Windows.Forms.TextBox();
            this.btnReserve = new System.Windows.Forms.Button();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.btnCancelReserve = new System.Windows.Forms.Button();
            this.btnInfo = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSeatStatuses)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvSeatStatuses
            // 
            this.dgvSeatStatuses.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvSeatStatuses.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSeatStatuses.Location = new System.Drawing.Point(12, 41);
            this.dgvSeatStatuses.Name = "dgvSeatStatuses";
            this.dgvSeatStatuses.Size = new System.Drawing.Size(1160, 514);
            this.dgvSeatStatuses.TabIndex = 0;
            this.dgvSeatStatuses.DataBindingComplete += new System.Windows.Forms.DataGridViewBindingCompleteEventHandler(this.dtgSeatStatus_DataBindingComplete);
            this.dgvSeatStatuses.SelectionChanged += new System.EventHandler(this.dgvSeatStatuses_SelectionChanged);
            // 
            // btnPriceList
            // 
            this.btnPriceList.Location = new System.Drawing.Point(12, 12);
            this.btnPriceList.Name = "btnPriceList";
            this.btnPriceList.Size = new System.Drawing.Size(99, 23);
            this.btnPriceList.TabIndex = 1;
            this.btnPriceList.Text = "Price list";
            this.btnPriceList.UseVisualStyleBackColor = true;
            this.btnPriceList.Click += new System.EventHandler(this.btnPriceList_Click);
            // 
            // btnFindById
            // 
            this.btnFindById.Location = new System.Drawing.Point(1097, 12);
            this.btnFindById.Name = "btnFindById";
            this.btnFindById.Size = new System.Drawing.Size(75, 23);
            this.btnFindById.TabIndex = 2;
            this.btnFindById.Text = "Find";
            this.btnFindById.UseVisualStyleBackColor = true;
            this.btnFindById.Click += new System.EventHandler(this.btnFindById_Click);
            // 
            // txtFindById
            // 
            this.txtFindById.Location = new System.Drawing.Point(991, 14);
            this.txtFindById.Name = "txtFindById";
            this.txtFindById.Size = new System.Drawing.Size(100, 20);
            this.txtFindById.TabIndex = 3;
            // 
            // btnReserve
            // 
            this.btnReserve.Location = new System.Drawing.Point(117, 12);
            this.btnReserve.Name = "btnReserve";
            this.btnReserve.Size = new System.Drawing.Size(99, 23);
            this.btnReserve.TabIndex = 4;
            this.btnReserve.Text = "Reserve";
            this.btnReserve.UseVisualStyleBackColor = true;
            this.btnReserve.Click += new System.EventHandler(this.btnReserve_Click);
            // 
            // btnRefresh
            // 
            this.btnRefresh.Location = new System.Drawing.Point(327, 12);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(99, 23);
            this.btnRefresh.TabIndex = 5;
            this.btnRefresh.Text = "Refresh";
            this.btnRefresh.UseVisualStyleBackColor = true;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // btnCancelReserve
            // 
            this.btnCancelReserve.Location = new System.Drawing.Point(222, 12);
            this.btnCancelReserve.Name = "btnCancelReserve";
            this.btnCancelReserve.Size = new System.Drawing.Size(99, 23);
            this.btnCancelReserve.TabIndex = 6;
            this.btnCancelReserve.Text = "Cancellation";
            this.btnCancelReserve.UseVisualStyleBackColor = true;
            this.btnCancelReserve.Click += new System.EventHandler(this.btnCancelReserve_Click);
            // 
            // btnInfo
            // 
            this.btnInfo.Location = new System.Drawing.Point(433, 12);
            this.btnInfo.Name = "btnInfo";
            this.btnInfo.Size = new System.Drawing.Size(75, 23);
            this.btnInfo.TabIndex = 7;
            this.btnInfo.Text = "Info";
            this.btnInfo.UseVisualStyleBackColor = true;
            this.btnInfo.Click += new System.EventHandler(this.btnInfo_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1184, 567);
            this.Controls.Add(this.btnInfo);
            this.Controls.Add(this.btnCancelReserve);
            this.Controls.Add(this.btnRefresh);
            this.Controls.Add(this.btnReserve);
            this.Controls.Add(this.txtFindById);
            this.Controls.Add(this.btnFindById);
            this.Controls.Add(this.btnPriceList);
            this.Controls.Add(this.dgvSeatStatuses);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FSR";
            ((System.ComponentModel.ISupportInitialize)(this.dgvSeatStatuses)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnPriceList;
        private System.Windows.Forms.Button btnFindById;
        private System.Windows.Forms.TextBox txtFindById;
        private System.Windows.Forms.Button btnReserve;
        public System.Windows.Forms.DataGridView dgvSeatStatuses;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.Button btnCancelReserve;
        private System.Windows.Forms.Button btnInfo;
    }
}

