namespace ISCarRental.Forms
{
    partial class AllRentalsForm
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
            this.dgvAllRentals = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.dgvRentals = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAllRentals)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRentals)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvAllRentals
            // 
            this.dgvAllRentals.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAllRentals.Location = new System.Drawing.Point(12, 12);
            this.dgvAllRentals.Name = "dgvAllRentals";
            this.dgvAllRentals.RowHeadersWidth = 51;
            this.dgvAllRentals.RowTemplate.Height = 24;
            this.dgvAllRentals.Size = new System.Drawing.Size(392, 365);
            this.dgvAllRentals.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(745, 426);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "Вывод";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // dgvRentals
            // 
            this.dgvRentals.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvRentals.Location = new System.Drawing.Point(506, 12);
            this.dgvRentals.Name = "dgvRentals";
            this.dgvRentals.RowHeadersWidth = 51;
            this.dgvRentals.RowTemplate.Height = 24;
            this.dgvRentals.Size = new System.Drawing.Size(314, 365);
            this.dgvRentals.TabIndex = 2;
            // 
            // AllRentalsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(938, 517);
            this.Controls.Add(this.dgvRentals);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dgvAllRentals);
            this.Name = "AllRentalsForm";
            this.Text = "AllRentalsForm";
            ((System.ComponentModel.ISupportInitialize)(this.dgvAllRentals)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRentals)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvAllRentals;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView dgvRentals;
    }
}