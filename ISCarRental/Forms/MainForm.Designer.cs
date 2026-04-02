namespace ISCarRental.Forms
{
    partial class MainForm
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
            this.panelSidebar = new System.Windows.Forms.Panel();
            this.lblLogo = new System.Windows.Forms.Label();
            this.btnCars = new System.Windows.Forms.Button();
            this.btnMyRentals = new System.Windows.Forms.Button();
            this.btnNewRent = new System.Windows.Forms.Button();
            this.btnAllRentals = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.panelTop = new System.Windows.Forms.Panel();
            this.lblTitle = new System.Windows.Forms.Label();
            this.panelContent = new System.Windows.Forms.Panel();
            this.cardUnpaidRentals = new System.Windows.Forms.Panel();
            this.lblUnpaidRentalsValue = new System.Windows.Forms.Label();
            this.lblUnpaidRentalsTitle = new System.Windows.Forms.Label();
            this.cardActiveRentals = new System.Windows.Forms.Panel();
            this.lblActiveRentalsValue = new System.Windows.Forms.Label();
            this.lblActiveRentalsTitle = new System.Windows.Forms.Label();
            this.cardFreeCars = new System.Windows.Forms.Panel();
            this.lblFreeCarsValue = new System.Windows.Forms.Label();
            this.lblFreeCarsTitle = new System.Windows.Forms.Label();
            this.lblSubtitle = new System.Windows.Forms.Label();
            this.lblWelcome = new System.Windows.Forms.Label();
            this.panelSidebar.SuspendLayout();
            this.panelTop.SuspendLayout();
            this.panelContent.SuspendLayout();
            this.cardUnpaidRentals.SuspendLayout();
            this.cardActiveRentals.SuspendLayout();
            this.cardFreeCars.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelSidebar
            // 
            this.panelSidebar.BackColor = System.Drawing.Color.FromArgb(24, 30, 54);
            this.panelSidebar.Controls.Add(this.btnExit);
            this.panelSidebar.Controls.Add(this.btnAllRentals);
            this.panelSidebar.Controls.Add(this.btnNewRent);
            this.panelSidebar.Controls.Add(this.btnMyRentals);
            this.panelSidebar.Controls.Add(this.btnCars);
            this.panelSidebar.Controls.Add(this.lblLogo);
            this.panelSidebar.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelSidebar.Location = new System.Drawing.Point(0, 0);
            this.panelSidebar.Name = "panelSidebar";
            this.panelSidebar.Size = new System.Drawing.Size(250, 720);
            this.panelSidebar.TabIndex = 0;
            // 
            // lblLogo
            // 
            this.lblLogo.Font = new System.Drawing.Font("Segoe UI Semibold", 18F, System.Drawing.FontStyle.Bold);
            this.lblLogo.ForeColor = System.Drawing.Color.White;
            this.lblLogo.Location = new System.Drawing.Point(20, 30);
            this.lblLogo.Name = "lblLogo";
            this.lblLogo.Size = new System.Drawing.Size(210, 60);
            this.lblLogo.TabIndex = 0;
            this.lblLogo.Text = "ISCarRental";
            this.lblLogo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btnCars
            // 
            this.btnCars.Location = new System.Drawing.Point(20, 130);
            this.btnCars.Name = "btnCars";
            this.btnCars.Size = new System.Drawing.Size(210, 48);
            this.btnCars.TabIndex = 1;
            this.btnCars.Text = "Каталог авто";
            this.btnCars.UseVisualStyleBackColor = true;
            this.btnCars.Click += new System.EventHandler(this.btnCars_Click);
            // 
            // btnMyRentals
            // 
            this.btnMyRentals.Location = new System.Drawing.Point(20, 190);
            this.btnMyRentals.Name = "btnMyRentals";
            this.btnMyRentals.Size = new System.Drawing.Size(210, 48);
            this.btnMyRentals.TabIndex = 2;
            this.btnMyRentals.Text = "Мои аренды";
            this.btnMyRentals.UseVisualStyleBackColor = true;
            this.btnMyRentals.Click += new System.EventHandler(this.btnMyRentals_Click);
            // 
            // btnNewRent
            // 
            this.btnNewRent.Location = new System.Drawing.Point(20, 250);
            this.btnNewRent.Name = "btnNewRent";
            this.btnNewRent.Size = new System.Drawing.Size(210, 48);
            this.btnNewRent.TabIndex = 3;
            this.btnNewRent.Text = "Новая аренда";
            this.btnNewRent.UseVisualStyleBackColor = true;
            this.btnNewRent.Click += new System.EventHandler(this.btnNewRent_Click);
            // 
            // btnAllRentals
            // 
            this.btnAllRentals.Location = new System.Drawing.Point(20, 310);
            this.btnAllRentals.Name = "btnAllRentals";
            this.btnAllRentals.Size = new System.Drawing.Size(210, 48);
            this.btnAllRentals.TabIndex = 4;
            this.btnAllRentals.Text = "Все аренды";
            this.btnAllRentals.UseVisualStyleBackColor = true;
            this.btnAllRentals.Click += new System.EventHandler(this.btnAllRentals_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(20, 650);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(210, 45);
            this.btnExit.TabIndex = 5;
            this.btnExit.Text = "Выход";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // panelTop
            // 
            this.panelTop.BackColor = System.Drawing.Color.White;
            this.panelTop.Controls.Add(this.lblTitle);
            this.panelTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTop.Location = new System.Drawing.Point(250, 0);
            this.panelTop.Name = "panelTop";
            this.panelTop.Size = new System.Drawing.Size(1030, 80);
            this.panelTop.TabIndex = 1;
            // 
            // lblTitle
            // 
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI Semibold", 20F, System.Drawing.FontStyle.Bold);
            this.lblTitle.ForeColor = System.Drawing.Color.FromArgb(24, 30, 54);
            this.lblTitle.Location = new System.Drawing.Point(30, 20);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(500, 40);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Панель управления";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // panelContent
            // 
            this.panelContent.BackColor = System.Drawing.Color.FromArgb(245, 247, 250);
            this.panelContent.Controls.Add(this.cardUnpaidRentals);
            this.panelContent.Controls.Add(this.cardActiveRentals);
            this.panelContent.Controls.Add(this.cardFreeCars);
            this.panelContent.Controls.Add(this.lblSubtitle);
            this.panelContent.Controls.Add(this.lblWelcome);
            this.panelContent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelContent.Location = new System.Drawing.Point(250, 80);
            this.panelContent.Name = "panelContent";
            this.panelContent.Size = new System.Drawing.Size(1030, 640);
            this.panelContent.TabIndex = 2;
            // 
            // cardUnpaidRentals
            // 
            this.cardUnpaidRentals.BackColor = System.Drawing.Color.White;
            this.cardUnpaidRentals.Controls.Add(this.lblUnpaidRentalsValue);
            this.cardUnpaidRentals.Controls.Add(this.lblUnpaidRentalsTitle);
            this.cardUnpaidRentals.Location = new System.Drawing.Point(688, 150);
            this.cardUnpaidRentals.Name = "cardUnpaidRentals";
            this.cardUnpaidRentals.Size = new System.Drawing.Size(290, 170);
            this.cardUnpaidRentals.TabIndex = 4;
            // 
            // lblUnpaidRentalsValue
            // 
            this.lblUnpaidRentalsValue.Font = new System.Drawing.Font("Segoe UI", 30F, System.Drawing.FontStyle.Bold);
            this.lblUnpaidRentalsValue.ForeColor = System.Drawing.Color.FromArgb(220, 53, 69);
            this.lblUnpaidRentalsValue.Location = new System.Drawing.Point(20, 75);
            this.lblUnpaidRentalsValue.Name = "lblUnpaidRentalsValue";
            this.lblUnpaidRentalsValue.Size = new System.Drawing.Size(245, 60);
            this.lblUnpaidRentalsValue.TabIndex = 1;
            this.lblUnpaidRentalsValue.Text = "0";
            this.lblUnpaidRentalsValue.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblUnpaidRentalsTitle
            // 
            this.lblUnpaidRentalsTitle.Font = new System.Drawing.Font("Segoe UI Semibold", 15F, System.Drawing.FontStyle.Bold);
            this.lblUnpaidRentalsTitle.ForeColor = System.Drawing.Color.FromArgb(24, 30, 54);
            this.lblUnpaidRentalsTitle.Location = new System.Drawing.Point(20, 20);
            this.lblUnpaidRentalsTitle.Name = "lblUnpaidRentalsTitle";
            this.lblUnpaidRentalsTitle.Size = new System.Drawing.Size(245, 35);
            this.lblUnpaidRentalsTitle.TabIndex = 0;
            this.lblUnpaidRentalsTitle.Text = "Не оплачено";
            this.lblUnpaidRentalsTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // cardActiveRentals
            // 
            this.cardActiveRentals.BackColor = System.Drawing.Color.White;
            this.cardActiveRentals.Controls.Add(this.lblActiveRentalsValue);
            this.cardActiveRentals.Controls.Add(this.lblActiveRentalsTitle);
            this.cardActiveRentals.Location = new System.Drawing.Point(365, 150);
            this.cardActiveRentals.Name = "cardActiveRentals";
            this.cardActiveRentals.Size = new System.Drawing.Size(290, 170);
            this.cardActiveRentals.TabIndex = 3;
            // 
            // lblActiveRentalsValue
            // 
            this.lblActiveRentalsValue.Font = new System.Drawing.Font("Segoe UI", 30F, System.Drawing.FontStyle.Bold);
            this.lblActiveRentalsValue.ForeColor = System.Drawing.Color.FromArgb(255, 193, 7);
            this.lblActiveRentalsValue.Location = new System.Drawing.Point(20, 75);
            this.lblActiveRentalsValue.Name = "lblActiveRentalsValue";
            this.lblActiveRentalsValue.Size = new System.Drawing.Size(245, 60);
            this.lblActiveRentalsValue.TabIndex = 1;
            this.lblActiveRentalsValue.Text = "0";
            this.lblActiveRentalsValue.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblActiveRentalsTitle
            // 
            this.lblActiveRentalsTitle.Font = new System.Drawing.Font("Segoe UI Semibold", 15F, System.Drawing.FontStyle.Bold);
            this.lblActiveRentalsTitle.ForeColor = System.Drawing.Color.FromArgb(24, 30, 54);
            this.lblActiveRentalsTitle.Location = new System.Drawing.Point(20, 20);
            this.lblActiveRentalsTitle.Name = "lblActiveRentalsTitle";
            this.lblActiveRentalsTitle.Size = new System.Drawing.Size(245, 35);
            this.lblActiveRentalsTitle.TabIndex = 0;
            this.lblActiveRentalsTitle.Text = "Активные аренды";
            this.lblActiveRentalsTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // cardFreeCars
            // 
            this.cardFreeCars.BackColor = System.Drawing.Color.White;
            this.cardFreeCars.Controls.Add(this.lblFreeCarsValue);
            this.cardFreeCars.Controls.Add(this.lblFreeCarsTitle);
            this.cardFreeCars.Location = new System.Drawing.Point(42, 150);
            this.cardFreeCars.Name = "cardFreeCars";
            this.cardFreeCars.Size = new System.Drawing.Size(290, 170);
            this.cardFreeCars.TabIndex = 2;
            // 
            // lblFreeCarsValue
            // 
            this.lblFreeCarsValue.Font = new System.Drawing.Font("Segoe UI", 30F, System.Drawing.FontStyle.Bold);
            this.lblFreeCarsValue.ForeColor = System.Drawing.Color.FromArgb(25, 135, 84);
            this.lblFreeCarsValue.Location = new System.Drawing.Point(20, 75);
            this.lblFreeCarsValue.Name = "lblFreeCarsValue";
            this.lblFreeCarsValue.Size = new System.Drawing.Size(245, 60);
            this.lblFreeCarsValue.TabIndex = 1;
            this.lblFreeCarsValue.Text = "0";
            this.lblFreeCarsValue.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblFreeCarsTitle
            // 
            this.lblFreeCarsTitle.Font = new System.Drawing.Font("Segoe UI Semibold", 15F, System.Drawing.FontStyle.Bold);
            this.lblFreeCarsTitle.ForeColor = System.Drawing.Color.FromArgb(24, 30, 54);
            this.lblFreeCarsTitle.Location = new System.Drawing.Point(20, 20);
            this.lblFreeCarsTitle.Name = "lblFreeCarsTitle";
            this.lblFreeCarsTitle.Size = new System.Drawing.Size(245, 35);
            this.lblFreeCarsTitle.TabIndex = 0;
            this.lblFreeCarsTitle.Text = "Свободные авто";
            this.lblFreeCarsTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblSubtitle
            // 
            this.lblSubtitle.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.lblSubtitle.ForeColor = System.Drawing.Color.Gray;
            this.lblSubtitle.Location = new System.Drawing.Point(38, 85);
            this.lblSubtitle.Name = "lblSubtitle";
            this.lblSubtitle.Size = new System.Drawing.Size(700, 25);
            this.lblSubtitle.TabIndex = 1;
            this.lblSubtitle.Text = "Статистика по автомобилям, арендам и оплатам";
            // 
            // lblWelcome
            // 
            this.lblWelcome.Font = new System.Drawing.Font("Segoe UI Semibold", 24F, System.Drawing.FontStyle.Bold);
            this.lblWelcome.ForeColor = System.Drawing.Color.FromArgb(24, 30, 54);
            this.lblWelcome.Location = new System.Drawing.Point(35, 30);
            this.lblWelcome.Name = "lblWelcome";
            this.lblWelcome.Size = new System.Drawing.Size(520, 50);
            this.lblWelcome.TabIndex = 0;
            this.lblWelcome.Text = "Добро пожаловать";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(245, 247, 250);
            this.ClientSize = new System.Drawing.Size(1280, 720);
            this.Controls.Add(this.panelContent);
            this.Controls.Add(this.panelTop);
            this.Controls.Add(this.panelSidebar);
            this.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ISCarRental CRM";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.panelSidebar.ResumeLayout(false);
            this.panelTop.ResumeLayout(false);
            this.panelContent.ResumeLayout(false);
            this.cardUnpaidRentals.ResumeLayout(false);
            this.cardActiveRentals.ResumeLayout(false);
            this.cardFreeCars.ResumeLayout(false);
            this.ResumeLayout(false);
        }

        private System.Windows.Forms.Panel panelSidebar;
        private System.Windows.Forms.Label lblLogo;
        private System.Windows.Forms.Button btnCars;
        private System.Windows.Forms.Button btnMyRentals;
        private System.Windows.Forms.Button btnNewRent;
        private System.Windows.Forms.Button btnAllRentals;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Panel panelTop;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Panel panelContent;
        private System.Windows.Forms.Label lblSubtitle;
        private System.Windows.Forms.Label lblWelcome;
        private System.Windows.Forms.Panel cardFreeCars;
        private System.Windows.Forms.Label lblFreeCarsValue;
        private System.Windows.Forms.Label lblFreeCarsTitle;
        private System.Windows.Forms.Panel cardActiveRentals;
        private System.Windows.Forms.Label lblActiveRentalsValue;
        private System.Windows.Forms.Label lblActiveRentalsTitle;
        private System.Windows.Forms.Panel cardUnpaidRentals;
        private System.Windows.Forms.Label lblUnpaidRentalsValue;
        private System.Windows.Forms.Label lblUnpaidRentalsTitle;
    }
}