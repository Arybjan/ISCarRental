namespace ISCarRental.Forms
{
    partial class MyRentalsForm1
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
            this.dgvMyRentals1 = new System.Windows.Forms.DataGridView();
            this.btnReturnCar = new System.Windows.Forms.Button();
            this.btnCencelRental = new System.Windows.Forms.Button();
            this.dgvMyRentals = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMyRentals1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMyRentals)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvMyRentals1
            // 
            this.dgvMyRentals1.BackgroundColor = System.Drawing.Color.Azure;
            this.dgvMyRentals1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMyRentals1.Location = new System.Drawing.Point(-4, 0);
            this.dgvMyRentals1.Name = "dgvMyRentals1";
            this.dgvMyRentals1.RowHeadersWidth = 51;
            this.dgvMyRentals1.RowTemplate.Height = 24;
            this.dgvMyRentals1.Size = new System.Drawing.Size(628, 453);
            this.dgvMyRentals1.TabIndex = 0;
            // 
            // btnReturnCar
            // 
            this.btnReturnCar.Location = new System.Drawing.Point(33, 459);
            this.btnReturnCar.Name = "btnReturnCar";
            this.btnReturnCar.Size = new System.Drawing.Size(131, 46);
            this.btnReturnCar.TabIndex = 1;
            this.btnReturnCar.Text = "Вернуть автомобиль";
            this.btnReturnCar.UseVisualStyleBackColor = true;
            this.btnReturnCar.Click += new System.EventHandler(this.btnReturnCar_Click);
            // 
            // btnCencelRental
            // 
            this.btnCencelRental.Location = new System.Drawing.Point(33, 511);
            this.btnCencelRental.Name = "btnCencelRental";
            this.btnCencelRental.Size = new System.Drawing.Size(149, 46);
            this.btnCencelRental.TabIndex = 2;
            this.btnCencelRental.Text = "Отменить заказ";
            this.btnCencelRental.UseVisualStyleBackColor = true;
            // 
            // dgvMyRentals
            // 
            this.dgvMyRentals.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMyRentals.Location = new System.Drawing.Point(694, 12);
            this.dgvMyRentals.Name = "dgvMyRentals";
            this.dgvMyRentals.RowHeadersWidth = 51;
            this.dgvMyRentals.RowTemplate.Height = 24;
            this.dgvMyRentals.Size = new System.Drawing.Size(240, 150);
            this.dgvMyRentals.TabIndex = 3;
            // 
            // MyRentalsForm1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1007, 610);
            this.Controls.Add(this.dgvMyRentals);
            this.Controls.Add(this.btnCencelRental);
            this.Controls.Add(this.btnReturnCar);
            this.Controls.Add(this.dgvMyRentals1);
            this.Name = "MyRentalsForm1";
            this.Text = "Мои заказы";
            this.Load += new System.EventHandler(this.MyRentalsForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvMyRentals1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMyRentals)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvMyRentals1;
        private System.Windows.Forms.Button btnReturnCar;
        private System.Windows.Forms.Button btnCencelRental;
        private System.Windows.Forms.DataGridView dgvMyRentals;
    }
}