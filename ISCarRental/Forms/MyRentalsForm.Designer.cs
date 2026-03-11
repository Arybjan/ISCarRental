namespace ISCarRental.Forms
{
    partial class MyRentalsForm
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
            this.dgvMyRentals = new System.Windows.Forms.DataGridView();
            this.btnReturnCar = new System.Windows.Forms.Button();
            this.btnCencelRental = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMyRentals)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvMyRentals
            // 
            this.dgvMyRentals.BackgroundColor = System.Drawing.Color.Azure;
            this.dgvMyRentals.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMyRentals.Location = new System.Drawing.Point(-4, 0);
            this.dgvMyRentals.Name = "dgvMyRentals";
            this.dgvMyRentals.RowHeadersWidth = 51;
            this.dgvMyRentals.RowTemplate.Height = 24;
            this.dgvMyRentals.Size = new System.Drawing.Size(420, 453);
            this.dgvMyRentals.TabIndex = 0;
            // 
            // btnReturnCar
            // 
            this.btnReturnCar.Location = new System.Drawing.Point(673, 230);
            this.btnReturnCar.Name = "btnReturnCar";
            this.btnReturnCar.Size = new System.Drawing.Size(75, 23);
            this.btnReturnCar.TabIndex = 1;
            this.btnReturnCar.Text = "Вернуть автомобиль";
            this.btnReturnCar.UseVisualStyleBackColor = true;
            this.btnReturnCar.Click += new System.EventHandler(this.btnReturnCar_Click);
            // 
            // btnCencelRental
            // 
            this.btnCencelRental.Location = new System.Drawing.Point(673, 282);
            this.btnCencelRental.Name = "btnCencelRental";
            this.btnCencelRental.Size = new System.Drawing.Size(93, 23);
            this.btnCencelRental.TabIndex = 2;
            this.btnCencelRental.Text = "Отменить";
            this.btnCencelRental.UseVisualStyleBackColor = true;
            this.btnCencelRental.Click += new System.EventHandler(this.btnCencel_Click);
            // 
            // MyRentalsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnCencelRental);
            this.Controls.Add(this.btnReturnCar);
            this.Controls.Add(this.dgvMyRentals);
            this.Name = "MyRentalsForm";
            this.Text = "MyRentalsForm";
            this.Load += new System.EventHandler(this.MyRentalsForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvMyRentals)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvMyRentals;
        private System.Windows.Forms.Button btnReturnCar;
        private System.Windows.Forms.Button btnCencelRental;
    }
}