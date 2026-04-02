namespace ISCarRental.Forms
{
    partial class MyRentalsForm
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();

            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.panelTop = new System.Windows.Forms.Panel();
            this.cmbPaymentStatusFilter = new System.Windows.Forms.ComboBox();
            this.lblPaymentStatus = new System.Windows.Forms.Label();
            this.cmbRentalStatusFilter = new System.Windows.Forms.ComboBox();
            this.lblRentalStatus = new System.Windows.Forms.Label();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.lblSearch = new System.Windows.Forms.Label();
            this.btnReturnCar = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnPay = new System.Windows.Forms.Button();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.lblTitle = new System.Windows.Forms.Label();
            this.panelGrid = new System.Windows.Forms.Panel();
            this.dgvMyRentals = new System.Windows.Forms.DataGridView();
            this.panelTop.SuspendLayout();
            this.panelGrid.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMyRentals)).BeginInit();
            this.SuspendLayout();
            // 
            // panelTop
            // 
            this.panelTop.BackColor = System.Drawing.Color.White;
            this.panelTop.Controls.Add(this.cmbPaymentStatusFilter);
            this.panelTop.Controls.Add(this.lblPaymentStatus);
            this.panelTop.Controls.Add(this.cmbRentalStatusFilter);
            this.panelTop.Controls.Add(this.lblRentalStatus);
            this.panelTop.Controls.Add(this.txtSearch);
            this.panelTop.Controls.Add(this.lblSearch);
            this.panelTop.Controls.Add(this.btnReturnCar);
            this.panelTop.Controls.Add(this.btnCancel);
            this.panelTop.Controls.Add(this.btnPay);
            this.panelTop.Controls.Add(this.btnRefresh);
            this.panelTop.Controls.Add(this.lblTitle);
            this.panelTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTop.Location = new System.Drawing.Point(0, 0);
            this.panelTop.Name = "panelTop";
            this.panelTop.Size = new System.Drawing.Size(1380, 145);
            this.panelTop.TabIndex = 0;
            // 
            // cmbPaymentStatusFilter
            // 
            this.cmbPaymentStatusFilter.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbPaymentStatusFilter.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cmbPaymentStatusFilter.FormattingEnabled = true;
            this.cmbPaymentStatusFilter.Location = new System.Drawing.Point(760, 88);
            this.cmbPaymentStatusFilter.Name = "cmbPaymentStatusFilter";
            this.cmbPaymentStatusFilter.Size = new System.Drawing.Size(190, 31);
            this.cmbPaymentStatusFilter.TabIndex = 10;
            this.cmbPaymentStatusFilter.SelectedIndexChanged += new System.EventHandler(this.cmbPaymentStatusFilter_SelectedIndexChanged);
            // 
            // lblPaymentStatus
            // 
            this.lblPaymentStatus.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold);
            this.lblPaymentStatus.ForeColor = System.Drawing.Color.FromArgb(24, 30, 54);
            this.lblPaymentStatus.Location = new System.Drawing.Point(570, 89);
            this.lblPaymentStatus.Name = "lblPaymentStatus";
            this.lblPaymentStatus.Size = new System.Drawing.Size(175, 28);
            this.lblPaymentStatus.TabIndex = 9;
            this.lblPaymentStatus.Text = "Статус оплаты:";
            // 
            // cmbRentalStatusFilter
            // 
            this.cmbRentalStatusFilter.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbRentalStatusFilter.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cmbRentalStatusFilter.FormattingEnabled = true;
            this.cmbRentalStatusFilter.Location = new System.Drawing.Point(355, 88);
            this.cmbRentalStatusFilter.Name = "cmbRentalStatusFilter";
            this.cmbRentalStatusFilter.Size = new System.Drawing.Size(190, 31);
            this.cmbRentalStatusFilter.TabIndex = 8;
            this.cmbRentalStatusFilter.SelectedIndexChanged += new System.EventHandler(this.cmbRentalStatusFilter_SelectedIndexChanged);
            // 
            // lblRentalStatus
            // 
            this.lblRentalStatus.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold);
            this.lblRentalStatus.ForeColor = System.Drawing.Color.FromArgb(24, 30, 54);
            this.lblRentalStatus.Location = new System.Drawing.Point(180, 89);
            this.lblRentalStatus.Name = "lblRentalStatus";
            this.lblRentalStatus.Size = new System.Drawing.Size(160, 28);
            this.lblRentalStatus.TabIndex = 7;
            this.lblRentalStatus.Text = "Статус аренды:";
            // 
            // txtSearch
            // 
            this.txtSearch.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtSearch.Location = new System.Drawing.Point(355, 42);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(330, 30);
            this.txtSearch.TabIndex = 6;
            this.txtSearch.TextChanged += new System.EventHandler(this.txtSearch_TextChanged);
            // 
            // lblSearch
            // 
            this.lblSearch.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold);
            this.lblSearch.ForeColor = System.Drawing.Color.FromArgb(24, 30, 54);
            this.lblSearch.Location = new System.Drawing.Point(180, 43);
            this.lblSearch.Name = "lblSearch";
            this.lblSearch.Size = new System.Drawing.Size(160, 28);
            this.lblSearch.TabIndex = 5;
            this.lblSearch.Text = "Поиск:";
            // 
            // btnReturnCar
            // 
            this.btnReturnCar.BackColor = System.Drawing.Color.FromArgb(25, 135, 84);
            this.btnReturnCar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnReturnCar.FlatAppearance.BorderSize = 0;
            this.btnReturnCar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReturnCar.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnReturnCar.ForeColor = System.Drawing.Color.White;
            this.btnReturnCar.Location = new System.Drawing.Point(1200, 84);
            this.btnReturnCar.Name = "btnReturnCar";
            this.btnReturnCar.Size = new System.Drawing.Size(150, 40);
            this.btnReturnCar.TabIndex = 4;
            this.btnReturnCar.Text = "Вернуть авто";
            this.btnReturnCar.UseVisualStyleBackColor = false;
            this.btnReturnCar.Click += new System.EventHandler(this.btnReturnCar_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.Color.FromArgb(220, 53, 69);
            this.btnCancel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCancel.FlatAppearance.BorderSize = 0;
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancel.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnCancel.ForeColor = System.Drawing.Color.White;
            this.btnCancel.Location = new System.Drawing.Point(1040, 84);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(145, 40);
            this.btnCancel.TabIndex = 3;
            this.btnCancel.Text = "Отменить";
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnPay
            // 
            this.btnPay.BackColor = System.Drawing.Color.FromArgb(13, 110, 253);
            this.btnPay.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPay.FlatAppearance.BorderSize = 0;
            this.btnPay.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPay.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnPay.ForeColor = System.Drawing.Color.White;
            this.btnPay.Location = new System.Drawing.Point(1200, 34);
            this.btnPay.Name = "btnPay";
            this.btnPay.Size = new System.Drawing.Size(150, 40);
            this.btnPay.TabIndex = 2;
            this.btnPay.Text = "Оплатить";
            this.btnPay.UseVisualStyleBackColor = false;
            this.btnPay.Click += new System.EventHandler(this.btnPay_Click);
            // 
            // btnRefresh
            // 
            this.btnRefresh.BackColor = System.Drawing.Color.FromArgb(108, 117, 125);
            this.btnRefresh.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRefresh.FlatAppearance.BorderSize = 0;
            this.btnRefresh.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRefresh.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnRefresh.ForeColor = System.Drawing.Color.White;
            this.btnRefresh.Location = new System.Drawing.Point(1040, 34);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(145, 40);
            this.btnRefresh.TabIndex = 1;
            this.btnRefresh.Text = "Сбросить";
            this.btnRefresh.UseVisualStyleBackColor = false;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // lblTitle
            // 
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI Semibold", 18F, System.Drawing.FontStyle.Bold);
            this.lblTitle.ForeColor = System.Drawing.Color.FromArgb(24, 30, 54);
            this.lblTitle.Location = new System.Drawing.Point(20, 45);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(145, 40);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Мои аренды";
            // 
            // panelGrid
            // 
            this.panelGrid.BackColor = System.Drawing.Color.White;
            this.panelGrid.Controls.Add(this.dgvMyRentals);
            this.panelGrid.Location = new System.Drawing.Point(20, 165);
            this.panelGrid.Name = "panelGrid";
            this.panelGrid.Size = new System.Drawing.Size(1340, 555);
            this.panelGrid.TabIndex = 1;
            // 
            // dgvMyRentals
            // 
            this.dgvMyRentals.BackgroundColor = System.Drawing.Color.White;
            this.dgvMyRentals.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvMyRentals.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMyRentals.Location = new System.Drawing.Point(15, 15);
            this.dgvMyRentals.Name = "dgvMyRentals";
            this.dgvMyRentals.RowHeadersWidth = 51;
            this.dgvMyRentals.RowTemplate.Height = 28;
            this.dgvMyRentals.Size = new System.Drawing.Size(1310, 525);
            this.dgvMyRentals.TabIndex = 0;
            // 
            // MyRentalsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(245, 247, 250);
            this.ClientSize = new System.Drawing.Size(1380, 740);
            this.Controls.Add(this.panelGrid);
            this.Controls.Add(this.panelTop);
            this.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "MyRentalsForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Мои аренды";
            this.Load += new System.EventHandler(this.MyRentalsForm_Load);
            this.panelTop.ResumeLayout(false);
            this.panelTop.PerformLayout();
            this.panelGrid.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvMyRentals)).EndInit();
            this.ResumeLayout(false);
        }

        private System.Windows.Forms.Panel panelTop;
        private System.Windows.Forms.ComboBox cmbPaymentStatusFilter;
        private System.Windows.Forms.Label lblPaymentStatus;
        private System.Windows.Forms.ComboBox cmbRentalStatusFilter;
        private System.Windows.Forms.Label lblRentalStatus;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Label lblSearch;
        private System.Windows.Forms.Button btnReturnCar;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnPay;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Panel panelGrid;
        private System.Windows.Forms.DataGridView dgvMyRentals;
    }
}