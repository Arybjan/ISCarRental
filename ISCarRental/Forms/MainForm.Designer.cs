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
            this.lblWelcome = new System.Windows.Forms.Label();
            this.lblSubtitle = new System.Windows.Forms.Label();
            this.cardCars = new System.Windows.Forms.Panel();
            this.lblCardCarsTitle = new System.Windows.Forms.Label();
            this.lblCardCarsText = new System.Windows.Forms.Label();
            this.cardRent = new System.Windows.Forms.Panel();
            this.lblCardRentTitle = new System.Windows.Forms.Label();
            this.lblCardRentText = new System.Windows.Forms.Label();
            this.cardMyRentals = new System.Windows.Forms.Panel();
            this.lblCardMyRentalsTitle = new System.Windows.Forms.Label();
            this.lblCardMyRentalsText = new System.Windows.Forms.Label();
            this.panelSidebar.SuspendLayout();
            this.panelTop.SuspendLayout();
            this.panelContent.SuspendLayout();
            this.cardCars.SuspendLayout();
            this.cardRent.SuspendLayout();
            this.cardMyRentals.SuspendLayout();
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
            this.btnCars.BackColor = System.Drawing.Color.FromArgb(37, 43, 72);
            this.btnCars.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCars.FlatAppearance.BorderSize = 0;
            this.btnCars.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCars.Font = new System.Drawing.Font("Segoe UI", 10.5F, System.Drawing.FontStyle.Bold);
            this.btnCars.ForeColor = System.Drawing.Color.White;
            this.btnCars.Location = new System.Drawing.Point(20, 130);
            this.btnCars.Name = "btnCars";
            this.btnCars.Size = new System.Drawing.Size(210, 48);
            this.btnCars.TabIndex = 1;
            this.btnCars.Text = "Каталог авто";
            this.btnCars.UseVisualStyleBackColor = false;
            this.btnCars.Click += new System.EventHandler(this.btnCars_Click);
            // 
            // btnMyRentals
            // 
            this.btnMyRentals.BackColor = System.Drawing.Color.FromArgb(37, 43, 72);
            this.btnMyRentals.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMyRentals.FlatAppearance.BorderSize = 0;
            this.btnMyRentals.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMyRentals.Font = new System.Drawing.Font("Segoe UI", 10.5F, System.Drawing.FontStyle.Bold);
            this.btnMyRentals.ForeColor = System.Drawing.Color.White;
            this.btnMyRentals.Location = new System.Drawing.Point(20, 190);
            this.btnMyRentals.Name = "btnMyRentals";
            this.btnMyRentals.Size = new System.Drawing.Size(210, 48);
            this.btnMyRentals.TabIndex = 2;
            this.btnMyRentals.Text = "Мои аренды";
            this.btnMyRentals.UseVisualStyleBackColor = false;
            this.btnMyRentals.Click += new System.EventHandler(this.btnMyRentals_Click);
            // 
            // btnNewRent
            // 
            this.btnNewRent.BackColor = System.Drawing.Color.FromArgb(37, 43, 72);
            this.btnNewRent.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnNewRent.FlatAppearance.BorderSize = 0;
            this.btnNewRent.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNewRent.Font = new System.Drawing.Font("Segoe UI", 10.5F, System.Drawing.FontStyle.Bold);
            this.btnNewRent.ForeColor = System.Drawing.Color.White;
            this.btnNewRent.Location = new System.Drawing.Point(20, 250);
            this.btnNewRent.Name = "btnNewRent";
            this.btnNewRent.Size = new System.Drawing.Size(210, 48);
            this.btnNewRent.TabIndex = 3;
            this.btnNewRent.Text = "Новая аренда";
            this.btnNewRent.UseVisualStyleBackColor = false;
            this.btnNewRent.Click += new System.EventHandler(this.btnNewRent_Click);
            // 
            // btnAllRentals
            // 
            this.btnAllRentals.BackColor = System.Drawing.Color.FromArgb(37, 43, 72);
            this.btnAllRentals.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAllRentals.FlatAppearance.BorderSize = 0;
            this.btnAllRentals.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAllRentals.Font = new System.Drawing.Font("Segoe UI", 10.5F, System.Drawing.FontStyle.Bold);
            this.btnAllRentals.ForeColor = System.Drawing.Color.White;
            this.btnAllRentals.Location = new System.Drawing.Point(20, 310);
            this.btnAllRentals.Name = "btnAllRentals";
            this.btnAllRentals.Size = new System.Drawing.Size(210, 48);
            this.btnAllRentals.TabIndex = 4;
            this.btnAllRentals.Text = "Все аренды";
            this.btnAllRentals.UseVisualStyleBackColor = false;
            this.btnAllRentals.Click += new System.EventHandler(this.btnAllRentals_Click);
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.FromArgb(220, 53, 69);
            this.btnExit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnExit.FlatAppearance.BorderSize = 0;
            this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExit.Font = new System.Drawing.Font("Segoe UI", 10.5F, System.Drawing.FontStyle.Bold);
            this.btnExit.ForeColor = System.Drawing.Color.White;
            this.btnExit.Location = new System.Drawing.Point(20, 650);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(210, 45);
            this.btnExit.TabIndex = 5;
            this.btnExit.Text = "Выход";
            this.btnExit.UseVisualStyleBackColor = false;
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
            this.panelContent.Controls.Add(this.cardMyRentals);
            this.panelContent.Controls.Add(this.cardRent);
            this.panelContent.Controls.Add(this.cardCars);
            this.panelContent.Controls.Add(this.lblSubtitle);
            this.panelContent.Controls.Add(this.lblWelcome);
            this.panelContent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelContent.Location = new System.Drawing.Point(250, 80);
            this.panelContent.Name = "panelContent";
            this.panelContent.Size = new System.Drawing.Size(1030, 640);
            this.panelContent.TabIndex = 2;
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
            // lblSubtitle
            // 
            this.lblSubtitle.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.lblSubtitle.ForeColor = System.Drawing.Color.Gray;
            this.lblSubtitle.Location = new System.Drawing.Point(38, 85);
            this.lblSubtitle.Name = "lblSubtitle";
            this.lblSubtitle.Size = new System.Drawing.Size(600, 25);
            this.lblSubtitle.TabIndex = 1;
            this.lblSubtitle.Text = "Управляйте автомобилями, арендами и оплатами в одном месте";
            // 
            // cardCars
            // 
            this.cardCars.BackColor = System.Drawing.Color.White;
            this.cardCars.Controls.Add(this.lblCardCarsText);
            this.cardCars.Controls.Add(this.lblCardCarsTitle);
            this.cardCars.Location = new System.Drawing.Point(42, 150);
            this.cardCars.Name = "cardCars";
            this.cardCars.Size = new System.Drawing.Size(290, 170);
            this.cardCars.TabIndex = 2;
            // 
            // lblCardCarsTitle
            // 
            this.lblCardCarsTitle.Font = new System.Drawing.Font("Segoe UI Semibold", 16F, System.Drawing.FontStyle.Bold);
            this.lblCardCarsTitle.ForeColor = System.Drawing.Color.FromArgb(24, 30, 54);
            this.lblCardCarsTitle.Location = new System.Drawing.Point(20, 20);
            this.lblCardCarsTitle.Name = "lblCardCarsTitle";
            this.lblCardCarsTitle.Size = new System.Drawing.Size(240, 35);
            this.lblCardCarsTitle.TabIndex = 0;
            this.lblCardCarsTitle.Text = "Каталог авто";
            // 
            // lblCardCarsText
            // 
            this.lblCardCarsText.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.lblCardCarsText.ForeColor = System.Drawing.Color.Gray;
            this.lblCardCarsText.Location = new System.Drawing.Point(20, 65);
            this.lblCardCarsText.Name = "lblCardCarsText";
            this.lblCardCarsText.Size = new System.Drawing.Size(245, 70);
            this.lblCardCarsText.TabIndex = 1;
            this.lblCardCarsText.Text = "Просмотр доступных автомобилей, цен, категорий и местоположения";
            // 
            // cardRent
            // 
            this.cardRent.BackColor = System.Drawing.Color.White;
            this.cardRent.Controls.Add(this.lblCardRentText);
            this.cardRent.Controls.Add(this.lblCardRentTitle);
            this.cardRent.Location = new System.Drawing.Point(365, 150);
            this.cardRent.Name = "cardRent";
            this.cardRent.Size = new System.Drawing.Size(290, 170);
            this.cardRent.TabIndex = 3;
            // 
            // lblCardRentTitle
            // 
            this.lblCardRentTitle.Font = new System.Drawing.Font("Segoe UI Semibold", 16F, System.Drawing.FontStyle.Bold);
            this.lblCardRentTitle.ForeColor = System.Drawing.Color.FromArgb(24, 30, 54);
            this.lblCardRentTitle.Location = new System.Drawing.Point(20, 20);
            this.lblCardRentTitle.Name = "lblCardRentTitle";
            this.lblCardRentTitle.Size = new System.Drawing.Size(240, 35);
            this.lblCardRentTitle.TabIndex = 0;
            this.lblCardRentTitle.Text = "Новая аренда";
            // 
            // lblCardRentText
            // 
            this.lblCardRentText.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.lblCardRentText.ForeColor = System.Drawing.Color.Gray;
            this.lblCardRentText.Location = new System.Drawing.Point(20, 65);
            this.lblCardRentText.Name = "lblCardRentText";
            this.lblCardRentText.Size = new System.Drawing.Size(245, 70);
            this.lblCardRentText.TabIndex = 1;
            this.lblCardRentText.Text = "Оформляйте аренду, рассчитывайте стоимость и фиксируйте статус оплаты";
            // 
            // cardMyRentals
            // 
            this.cardMyRentals.BackColor = System.Drawing.Color.White;
            this.cardMyRentals.Controls.Add(this.lblCardMyRentalsText);
            this.cardMyRentals.Controls.Add(this.lblCardMyRentalsTitle);
            this.cardMyRentals.Location = new System.Drawing.Point(688, 150);
            this.cardMyRentals.Name = "cardMyRentals";
            this.cardMyRentals.Size = new System.Drawing.Size(290, 170);
            this.cardMyRentals.TabIndex = 4;
            // 
            // lblCardMyRentalsTitle
            // 
            this.lblCardMyRentalsTitle.Font = new System.Drawing.Font("Segoe UI Semibold", 16F, System.Drawing.FontStyle.Bold);
            this.lblCardMyRentalsTitle.ForeColor = System.Drawing.Color.FromArgb(24, 30, 54);
            this.lblCardMyRentalsTitle.Location = new System.Drawing.Point(20, 20);
            this.lblCardMyRentalsTitle.Name = "lblCardMyRentalsTitle";
            this.lblCardMyRentalsTitle.Size = new System.Drawing.Size(240, 35);
            this.lblCardMyRentalsTitle.TabIndex = 0;
            this.lblCardMyRentalsTitle.Text = "Мои аренды";
            // 
            // lblCardMyRentalsText
            // 
            this.lblCardMyRentalsText.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.lblCardMyRentalsText.ForeColor = System.Drawing.Color.Gray;
            this.lblCardMyRentalsText.Location = new System.Drawing.Point(20, 65);
            this.lblCardMyRentalsText.Name = "lblCardMyRentalsText";
            this.lblCardMyRentalsText.Size = new System.Drawing.Size(245, 70);
            this.lblCardMyRentalsText.TabIndex = 1;
            this.lblCardMyRentalsText.Text = "Отслеживайте свои активные, завершенные и отмененные аренды";
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
            this.cardCars.ResumeLayout(false);
            this.cardRent.ResumeLayout(false);
            this.cardMyRentals.ResumeLayout(false);
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
        private System.Windows.Forms.Label lblWelcome;
        private System.Windows.Forms.Label lblSubtitle;
        private System.Windows.Forms.Panel cardCars;
        private System.Windows.Forms.Label lblCardCarsTitle;
        private System.Windows.Forms.Label lblCardCarsText;
        private System.Windows.Forms.Panel cardRent;
        private System.Windows.Forms.Label lblCardRentTitle;
        private System.Windows.Forms.Label lblCardRentText;
        private System.Windows.Forms.Panel cardMyRentals;
        private System.Windows.Forms.Label lblCardMyRentalsTitle;
        private System.Windows.Forms.Label lblCardMyRentalsText;
    }
}