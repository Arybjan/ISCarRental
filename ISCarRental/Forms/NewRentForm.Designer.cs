namespace ISCarRental.Forms
{
    partial class NewRentForm
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
            this.btnRent = new System.Windows.Forms.Button();
            this.lblTotalPriceValue = new System.Windows.Forms.Label();
            this.lblTotalPrice = new System.Windows.Forms.Label();
            this.dtpEndDate = new System.Windows.Forms.DateTimePicker();
            this.lblEndDate = new System.Windows.Forms.Label();
            this.dtpStartDate = new System.Windows.Forms.DateTimePicker();
            this.lblStartDate = new System.Windows.Forms.Label();
            this.cmbCars = new System.Windows.Forms.ComboBox();
            this.lblCar = new System.Windows.Forms.Label();
            this.lblTitle = new System.Windows.Forms.Label();
            this.panelCard.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelCard
            // 
            this.panelCard.BackColor = System.Drawing.Color.White;
            this.panelCard.Controls.Add(this.btnRent);
            this.panelCard.Controls.Add(this.lblTotalPriceValue);
            this.panelCard.Controls.Add(this.lblTotalPrice);
            this.panelCard.Controls.Add(this.dtpEndDate);
            this.panelCard.Controls.Add(this.lblEndDate);
            this.panelCard.Controls.Add(this.dtpStartDate);
            this.panelCard.Controls.Add(this.lblStartDate);
            this.panelCard.Controls.Add(this.cmbCars);
            this.panelCard.Controls.Add(this.lblCar);
            this.panelCard.Controls.Add(this.lblTitle);
            this.panelCard.Location = new System.Drawing.Point(20, 20);
            this.panelCard.Name = "panelCard";
            this.panelCard.Size = new System.Drawing.Size(500, 430);
            this.panelCard.TabIndex = 0;
            // 
            // btnRent
            // 
            this.btnRent.BackColor = System.Drawing.Color.FromArgb(13, 110, 253);
            this.btnRent.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRent.FlatAppearance.BorderSize = 0;
            this.btnRent.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRent.Font = new System.Drawing.Font("Segoe UI", 10.5F, System.Drawing.FontStyle.Bold);
            this.btnRent.ForeColor = System.Drawing.Color.White;
            this.btnRent.Location = new System.Drawing.Point(30, 355);
            this.btnRent.Name = "btnRent";
            this.btnRent.Size = new System.Drawing.Size(440, 45);
            this.btnRent.TabIndex = 9;
            this.btnRent.Text = "Оформить аренду";
            this.btnRent.UseVisualStyleBackColor = false;
            this.btnRent.Click += new System.EventHandler(this.btnRent_Click);
            // 
            // lblTotalPriceValue
            // 
            this.lblTotalPriceValue.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.lblTotalPriceValue.ForeColor = System.Drawing.Color.FromArgb(25, 135, 84);
            this.lblTotalPriceValue.Location = new System.Drawing.Point(250, 300);
            this.lblTotalPriceValue.Name = "lblTotalPriceValue";
            this.lblTotalPriceValue.Size = new System.Drawing.Size(220, 30);
            this.lblTotalPriceValue.TabIndex = 8;
            this.lblTotalPriceValue.Text = "0";
            this.lblTotalPriceValue.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblTotalPrice
            // 
            this.lblTotalPrice.Font = new System.Drawing.Font("Segoe UI Semibold", 11F, System.Drawing.FontStyle.Bold);
            this.lblTotalPrice.ForeColor = System.Drawing.Color.FromArgb(24, 30, 54);
            this.lblTotalPrice.Location = new System.Drawing.Point(30, 300);
            this.lblTotalPrice.Name = "lblTotalPrice";
            this.lblTotalPrice.Size = new System.Drawing.Size(180, 30);
            this.lblTotalPrice.TabIndex = 7;
            this.lblTotalPrice.Text = "Итоговая сумма:";
            // 
            // dtpEndDate
            // 
            this.dtpEndDate.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.dtpEndDate.Location = new System.Drawing.Point(30, 240);
            this.dtpEndDate.Name = "dtpEndDate";
            this.dtpEndDate.Size = new System.Drawing.Size(440, 31);
            this.dtpEndDate.TabIndex = 6;
            this.dtpEndDate.ValueChanged += new System.EventHandler(this.dtpEndDate_ValueChanged);
            // 
            // lblEndDate
            // 
            this.lblEndDate.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold);
            this.lblEndDate.ForeColor = System.Drawing.Color.FromArgb(24, 30, 54);
            this.lblEndDate.Location = new System.Drawing.Point(30, 210);
            this.lblEndDate.Name = "lblEndDate";
            this.lblEndDate.Size = new System.Drawing.Size(170, 25);
            this.lblEndDate.TabIndex = 5;
            this.lblEndDate.Text = "Дата окончания";
            // 
            // dtpStartDate
            // 
            this.dtpStartDate.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.dtpStartDate.Location = new System.Drawing.Point(30, 160);
            this.dtpStartDate.Name = "dtpStartDate";
            this.dtpStartDate.Size = new System.Drawing.Size(440, 31);
            this.dtpStartDate.TabIndex = 4;
            this.dtpStartDate.ValueChanged += new System.EventHandler(this.dtpStartDate_ValueChanged);
            // 
            // lblStartDate
            // 
            this.lblStartDate.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold);
            this.lblStartDate.ForeColor = System.Drawing.Color.FromArgb(24, 30, 54);
            this.lblStartDate.Location = new System.Drawing.Point(30, 130);
            this.lblStartDate.Name = "lblStartDate";
            this.lblStartDate.Size = new System.Drawing.Size(170, 25);
            this.lblStartDate.TabIndex = 3;
            this.lblStartDate.Text = "Дата начала";
            // 
            // cmbCars
            // 
            this.cmbCars.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCars.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.cmbCars.FormattingEnabled = true;
            this.cmbCars.Location = new System.Drawing.Point(30, 85);
            this.cmbCars.Name = "cmbCars";
            this.cmbCars.Size = new System.Drawing.Size(440, 31);
            this.cmbCars.TabIndex = 2;
            this.cmbCars.SelectedIndexChanged += new System.EventHandler(this.cmbCars_SelectedIndexChanged);
            // 
            // lblCar
            // 
            this.lblCar.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold);
            this.lblCar.ForeColor = System.Drawing.Color.FromArgb(24, 30, 54);
            this.lblCar.Location = new System.Drawing.Point(30, 55);
            this.lblCar.Name = "lblCar";
            this.lblCar.Size = new System.Drawing.Size(170, 25);
            this.lblCar.TabIndex = 1;
            this.lblCar.Text = "Автомобиль";
            // 
            // lblTitle
            // 
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI Semibold", 18F, System.Drawing.FontStyle.Bold);
            this.lblTitle.ForeColor = System.Drawing.Color.FromArgb(24, 30, 54);
            this.lblTitle.Location = new System.Drawing.Point(25, 15);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(250, 35);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Новая аренда";
            // 
            // NewRentForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(245, 247, 250);
            this.ClientSize = new System.Drawing.Size(540, 470);
            this.Controls.Add(this.panelCard);
            this.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "NewRentForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Новая аренда";
            this.Load += new System.EventHandler(this.NewRentForm_Load);
            this.panelCard.ResumeLayout(false);
            this.ResumeLayout(false);
        }

        private System.Windows.Forms.Panel panelCard;
        private System.Windows.Forms.Button btnRent;
        private System.Windows.Forms.Label lblTotalPriceValue;
        private System.Windows.Forms.Label lblTotalPrice;
        private System.Windows.Forms.DateTimePicker dtpEndDate;
        private System.Windows.Forms.Label lblEndDate;
        private System.Windows.Forms.DateTimePicker dtpStartDate;
        private System.Windows.Forms.Label lblStartDate;
        private System.Windows.Forms.ComboBox cmbCars;
        private System.Windows.Forms.Label lblCar;
        private System.Windows.Forms.Label lblTitle;
    }
}