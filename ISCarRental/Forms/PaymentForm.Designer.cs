namespace ISCarRental.Forms
{
    partial class PaymentForm
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
            this.panelCard = new System.Windows.Forms.Panel();
            this.btnPay = new System.Windows.Forms.Button();
            this.txtAmount = new System.Windows.Forms.TextBox();
            this.lblAmount = new System.Windows.Forms.Label();
            this.cmbPaymentMethod = new System.Windows.Forms.ComboBox();
            this.lblPaymentMethod = new System.Windows.Forms.Label();
            this.lblCurrentPaymentStatusValue = new System.Windows.Forms.Label();
            this.lblCurrentPaymentStatus = new System.Windows.Forms.Label();
            this.lblTotalPriceValue = new System.Windows.Forms.Label();
            this.lblTotalPrice = new System.Windows.Forms.Label();
            this.txtRentalId = new System.Windows.Forms.TextBox();
            this.lblRentalId = new System.Windows.Forms.Label();
            this.lblTitle = new System.Windows.Forms.Label();
            this.panelCard.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelCard
            // 
            this.panelCard.BackColor = System.Drawing.Color.White;
            this.panelCard.Controls.Add(this.btnPay);
            this.panelCard.Controls.Add(this.txtAmount);
            this.panelCard.Controls.Add(this.lblAmount);
            this.panelCard.Controls.Add(this.cmbPaymentMethod);
            this.panelCard.Controls.Add(this.lblPaymentMethod);
            this.panelCard.Controls.Add(this.lblCurrentPaymentStatusValue);
            this.panelCard.Controls.Add(this.lblCurrentPaymentStatus);
            this.panelCard.Controls.Add(this.lblTotalPriceValue);
            this.panelCard.Controls.Add(this.lblTotalPrice);
            this.panelCard.Controls.Add(this.txtRentalId);
            this.panelCard.Controls.Add(this.lblRentalId);
            this.panelCard.Controls.Add(this.lblTitle);
            this.panelCard.Location = new System.Drawing.Point(20, 20);
            this.panelCard.Name = "panelCard";
            this.panelCard.Size = new System.Drawing.Size(420, 460);
            this.panelCard.TabIndex = 0;
            // 
            // btnPay
            // 
            this.btnPay.BackColor = System.Drawing.Color.FromArgb(13, 110, 253);
            this.btnPay.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPay.FlatAppearance.BorderSize = 0;
            this.btnPay.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPay.Font = new System.Drawing.Font("Segoe UI", 10.5F, System.Drawing.FontStyle.Bold);
            this.btnPay.ForeColor = System.Drawing.Color.White;
            this.btnPay.Location = new System.Drawing.Point(30, 380);
            this.btnPay.Name = "btnPay";
            this.btnPay.Size = new System.Drawing.Size(360, 45);
            this.btnPay.TabIndex = 11;
            this.btnPay.Text = "Подтвердить оплату";
            this.btnPay.UseVisualStyleBackColor = false;
            this.btnPay.Click += new System.EventHandler(this.btnPay_Click);
            // 
            // txtAmount
            // 
            this.txtAmount.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtAmount.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.txtAmount.Location = new System.Drawing.Point(30, 325);
            this.txtAmount.Name = "txtAmount";
            this.txtAmount.Size = new System.Drawing.Size(360, 32);
            this.txtAmount.TabIndex = 10;
            // 
            // lblAmount
            // 
            this.lblAmount.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold);
            this.lblAmount.ForeColor = System.Drawing.Color.FromArgb(24, 30, 54);
            this.lblAmount.Location = new System.Drawing.Point(30, 295);
            this.lblAmount.Name = "lblAmount";
            this.lblAmount.Size = new System.Drawing.Size(120, 25);
            this.lblAmount.TabIndex = 9;
            this.lblAmount.Text = "Сумма";
            // 
            // cmbPaymentMethod
            // 
            this.cmbPaymentMethod.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbPaymentMethod.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.cmbPaymentMethod.FormattingEnabled = true;
            this.cmbPaymentMethod.Location = new System.Drawing.Point(30, 245);
            this.cmbPaymentMethod.Name = "cmbPaymentMethod";
            this.cmbPaymentMethod.Size = new System.Drawing.Size(360, 31);
            this.cmbPaymentMethod.TabIndex = 8;
            // 
            // lblPaymentMethod
            // 
            this.lblPaymentMethod.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold);
            this.lblPaymentMethod.ForeColor = System.Drawing.Color.FromArgb(24, 30, 54);
            this.lblPaymentMethod.Location = new System.Drawing.Point(30, 215);
            this.lblPaymentMethod.Name = "lblPaymentMethod";
            this.lblPaymentMethod.Size = new System.Drawing.Size(160, 25);
            this.lblPaymentMethod.TabIndex = 7;
            this.lblPaymentMethod.Text = "Метод оплаты";
            // 
            // lblCurrentPaymentStatusValue
            // 
            this.lblCurrentPaymentStatusValue.Font = new System.Drawing.Font("Segoe UI", 10.5F, System.Drawing.FontStyle.Bold);
            this.lblCurrentPaymentStatusValue.ForeColor = System.Drawing.Color.FromArgb(13, 110, 253);
            this.lblCurrentPaymentStatusValue.Location = new System.Drawing.Point(210, 170);
            this.lblCurrentPaymentStatusValue.Name = "lblCurrentPaymentStatusValue";
            this.lblCurrentPaymentStatusValue.Size = new System.Drawing.Size(180, 25);
            this.lblCurrentPaymentStatusValue.TabIndex = 6;
            this.lblCurrentPaymentStatusValue.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblCurrentPaymentStatus
            // 
            this.lblCurrentPaymentStatus.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.lblCurrentPaymentStatus.ForeColor = System.Drawing.Color.Gray;
            this.lblCurrentPaymentStatus.Location = new System.Drawing.Point(30, 170);
            this.lblCurrentPaymentStatus.Name = "lblCurrentPaymentStatus";
            this.lblCurrentPaymentStatus.Size = new System.Drawing.Size(170, 25);
            this.lblCurrentPaymentStatus.TabIndex = 5;
            this.lblCurrentPaymentStatus.Text = "Статус оплаты:";
            // 
            // lblTotalPriceValue
            // 
            this.lblTotalPriceValue.Font = new System.Drawing.Font("Segoe UI", 10.5F, System.Drawing.FontStyle.Bold);
            this.lblTotalPriceValue.ForeColor = System.Drawing.Color.FromArgb(25, 135, 84);
            this.lblTotalPriceValue.Location = new System.Drawing.Point(210, 135);
            this.lblTotalPriceValue.Name = "lblTotalPriceValue";
            this.lblTotalPriceValue.Size = new System.Drawing.Size(180, 25);
            this.lblTotalPriceValue.TabIndex = 4;
            this.lblTotalPriceValue.Text = "0.00";
            this.lblTotalPriceValue.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblTotalPrice
            // 
            this.lblTotalPrice.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.lblTotalPrice.ForeColor = System.Drawing.Color.Gray;
            this.lblTotalPrice.Location = new System.Drawing.Point(30, 135);
            this.lblTotalPrice.Name = "lblTotalPrice";
            this.lblTotalPrice.Size = new System.Drawing.Size(170, 25);
            this.lblTotalPrice.TabIndex = 3;
            this.lblTotalPrice.Text = "Итоговая сумма:";
            // 
            // txtRentalId
            // 
            this.txtRentalId.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtRentalId.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.txtRentalId.Location = new System.Drawing.Point(30, 92);
            this.txtRentalId.Name = "txtRentalId";
            this.txtRentalId.ReadOnly = true;
            this.txtRentalId.Size = new System.Drawing.Size(360, 32);
            this.txtRentalId.TabIndex = 2;
            // 
            // lblRentalId
            // 
            this.lblRentalId.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold);
            this.lblRentalId.ForeColor = System.Drawing.Color.FromArgb(24, 30, 54);
            this.lblRentalId.Location = new System.Drawing.Point(30, 62);
            this.lblRentalId.Name = "lblRentalId";
            this.lblRentalId.Size = new System.Drawing.Size(160, 25);
            this.lblRentalId.TabIndex = 1;
            this.lblRentalId.Text = "ID аренды";
            // 
            // lblTitle
            // 
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI Semibold", 18F, System.Drawing.FontStyle.Bold);
            this.lblTitle.ForeColor = System.Drawing.Color.FromArgb(24, 30, 54);
            this.lblTitle.Location = new System.Drawing.Point(25, 20);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(250, 35);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Оплата аренды";
            // 
            // PaymentForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(245, 247, 250);
            this.ClientSize = new System.Drawing.Size(460, 500);
            this.Controls.Add(this.panelCard);
            this.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "PaymentForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Оплата аренды";
            this.Load += new System.EventHandler(this.PaymentForm_Load);
            this.panelCard.ResumeLayout(false);
            this.panelCard.PerformLayout();
            this.ResumeLayout(false);
        }

        private System.Windows.Forms.Panel panelCard;
        private System.Windows.Forms.Button btnPay;
        private System.Windows.Forms.TextBox txtAmount;
        private System.Windows.Forms.Label lblAmount;
        private System.Windows.Forms.ComboBox cmbPaymentMethod;
        private System.Windows.Forms.Label lblPaymentMethod;
        private System.Windows.Forms.Label lblCurrentPaymentStatusValue;
        private System.Windows.Forms.Label lblCurrentPaymentStatus;
        private System.Windows.Forms.Label lblTotalPriceValue;
        private System.Windows.Forms.Label lblTotalPrice;
        private System.Windows.Forms.TextBox txtRentalId;
        private System.Windows.Forms.Label lblRentalId;
        private System.Windows.Forms.Label lblTitle;
    }
}