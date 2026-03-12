namespace ISCarRental.Forms
{
    partial class AllUsersForm
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
            this.dgvAllUsers = new System.Windows.Forms.DataGridView();
            this.btnViewUsers = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAllUsers)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvAllUsers
            // 
            this.dgvAllUsers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAllUsers.Location = new System.Drawing.Point(12, 12);
            this.dgvAllUsers.Name = "dgvAllUsers";
            this.dgvAllUsers.RowHeadersWidth = 51;
            this.dgvAllUsers.RowTemplate.Height = 24;
            this.dgvAllUsers.Size = new System.Drawing.Size(1046, 384);
            this.dgvAllUsers.TabIndex = 0;
            // 
            // btnViewUsers
            // 
            this.btnViewUsers.Location = new System.Drawing.Point(849, 452);
            this.btnViewUsers.Name = "btnViewUsers";
            this.btnViewUsers.Size = new System.Drawing.Size(75, 23);
            this.btnViewUsers.TabIndex = 1;
            this.btnViewUsers.Text = "Вывод";
            this.btnViewUsers.UseVisualStyleBackColor = true;
            this.btnViewUsers.Click += new System.EventHandler(this.btnViewUsers_Click);
            // 
            // AllUsersForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1070, 509);
            this.Controls.Add(this.btnViewUsers);
            this.Controls.Add(this.dgvAllUsers);
            this.Name = "AllUsersForm";
            this.Text = "AllUsers";
            ((System.ComponentModel.ISupportInitialize)(this.dgvAllUsers)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvAllUsers;
        private System.Windows.Forms.Button btnViewUsers;
    }
}