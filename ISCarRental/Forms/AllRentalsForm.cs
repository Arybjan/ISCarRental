using System;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Windows.Forms;

namespace ISCarRental.Forms
{
    public partial class AllRentalsForm : Form
    {
        private const int STATUS_ACTIVE = 1;
        private const int STATUS_FINISHED = 2;
        private const int STATUS_CANCELED = 3;

        public AllRentalsForm()
        {
            InitializeComponent();
        }

        private void AllRentalsForm_Load(object sender, EventArgs e)
        {
            cmbRentalStatusFilter.Items.Clear();
            cmbRentalStatusFilter.Items.Add("Все");
            cmbRentalStatusFilter.Items.Add("Активна");
            cmbRentalStatusFilter.Items.Add("Завершена");
            cmbRentalStatusFilter.Items.Add("Отменена");
            cmbRentalStatusFilter.SelectedIndex = 0;

            cmbPaymentStatusFilter.Items.Clear();
            cmbPaymentStatusFilter.Items.Add("Все");
            cmbPaymentStatusFilter.Items.Add("Не оплачено");
            cmbPaymentStatusFilter.Items.Add("Частично оплачено");
            cmbPaymentStatusFilter.Items.Add("Оплачено");
            cmbPaymentStatusFilter.SelectedIndex = 0;

            LoadRentals();
        }

        private void LoadRentals()
        {
            string searchText = txtSearch.Text.Trim();
            string rentalStatus = cmbRentalStatusFilter.SelectedItem?.ToString() ?? "Все";
            string paymentStatus = cmbPaymentStatusFilter.SelectedItem?.ToString() ?? "Все";

            string sql = @"
                SELECT Rentals.id,
                       Users.name AS client_name,
                       Cars.brand,
                       Cars.model,
                       Rentals.start_date,
                       Rentals.end_date,
                       Rentals.total_price,
                       RentalsStatus.status_name AS rental_status,
                       Rentals.payment_status
                FROM ((Rentals
                INNER JOIN Users ON Rentals.client_id = Users.id)
                INNER JOIN Cars ON Rentals.cars_id = Cars.id)
                INNER JOIN RentalsStatus ON Rentals.status_id = RentalsStatus.id
                WHERE 1=1";

            var parameters = new System.Collections.Generic.List<OleDbParameter>();

            if (!string.IsNullOrWhiteSpace(searchText))
            {
                sql += " AND (Users.name LIKE ? OR Cars.brand LIKE ? OR Cars.model LIKE ?)";
                parameters.Add(new OleDbParameter("@client_name", "%" + searchText + "%"));
                parameters.Add(new OleDbParameter("@brand", "%" + searchText + "%"));
                parameters.Add(new OleDbParameter("@model", "%" + searchText + "%"));
            }

            if (rentalStatus != "Все")
            {
                sql += " AND RentalsStatus.status_name = ?";
                parameters.Add(new OleDbParameter("@rental_status", rentalStatus));
            }

            if (paymentStatus != "Все")
            {
                sql += " AND Rentals.payment_status = ?";
                parameters.Add(new OleDbParameter("@payment_status", paymentStatus));
            }

            sql += " ORDER BY Rentals.id DESC";

            DataTable dt = Database.ExecuteQuery(sql, parameters.ToArray());
            dgvAllRentals.DataSource = dt;

            StyleGrid(dgvAllRentals);

            dgvAllRentals.Columns["id"].HeaderText = "ID";
            dgvAllRentals.Columns["client_name"].HeaderText = "Клиент";
            dgvAllRentals.Columns["brand"].HeaderText = "Марка";
            dgvAllRentals.Columns["model"].HeaderText = "Модель";
            dgvAllRentals.Columns["start_date"].HeaderText = "Дата начала";
            dgvAllRentals.Columns["end_date"].HeaderText = "Дата окончания";
            dgvAllRentals.Columns["total_price"].HeaderText = "Итоговая сумма";
            dgvAllRentals.Columns["rental_status"].HeaderText = "Статус аренды";
            dgvAllRentals.Columns["payment_status"].HeaderText = "Статус оплаты";

            PaintRentalStatuses();
            PaintPaymentStatuses();
        }

        private void StyleGrid(DataGridView dgv)
        {
            dgv.AllowUserToAddRows = false;
            dgv.ReadOnly = true;
            dgv.MultiSelect = false;
            dgv.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgv.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgv.RowHeadersVisible = false;
            dgv.BackgroundColor = Color.White;
            dgv.BorderStyle = BorderStyle.None;
            dgv.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dgv.GridColor = Color.FromArgb(230, 230, 230);
            dgv.RowTemplate.Height = 34;
            dgv.DefaultCellStyle.Font = new Font("Segoe UI", 10F);
            dgv.DefaultCellStyle.SelectionBackColor = Color.FromArgb(13, 110, 253);
            dgv.DefaultCellStyle.SelectionForeColor = Color.White;
            dgv.DefaultCellStyle.BackColor = Color.White;
            dgv.DefaultCellStyle.ForeColor = Color.FromArgb(33, 37, 41);
            dgv.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(248, 249, 250);

            dgv.EnableHeadersVisualStyles = false;
            dgv.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dgv.ColumnHeadersHeight = 42;
            dgv.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(24, 30, 54);
            dgv.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            dgv.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            dgv.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
        }

        private void PaintRentalStatuses()
        {
            foreach (DataGridViewRow row in dgvAllRentals.Rows)
            {
                if (row.Cells["rental_status"].Value == null)
                    continue;

                string status = row.Cells["rental_status"].Value.ToString();

                if (status == "Активна")
                {
                    row.Cells["rental_status"].Style.BackColor = Color.FromArgb(255, 243, 205);
                    row.Cells["rental_status"].Style.ForeColor = Color.FromArgb(133, 100, 4);
                }
                else if (status == "Завершена")
                {
                    row.Cells["rental_status"].Style.BackColor = Color.FromArgb(212, 237, 218);
                    row.Cells["rental_status"].Style.ForeColor = Color.FromArgb(21, 87, 36);
                }
                else if (status == "Отменена")
                {
                    row.Cells["rental_status"].Style.BackColor = Color.FromArgb(248, 215, 218);
                    row.Cells["rental_status"].Style.ForeColor = Color.FromArgb(114, 28, 36);
                }

                row.Cells["rental_status"].Style.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold);
            }
        }

        private void PaintPaymentStatuses()
        {
            foreach (DataGridViewRow row in dgvAllRentals.Rows)
            {
                if (row.Cells["payment_status"].Value == null)
                    continue;

                string status = row.Cells["payment_status"].Value.ToString();

                if (status == "Не оплачено")
                {
                    row.Cells["payment_status"].Style.BackColor = Color.FromArgb(248, 215, 218);
                    row.Cells["payment_status"].Style.ForeColor = Color.FromArgb(114, 28, 36);
                }
                else if (status == "Частично оплачено")
                {
                    row.Cells["payment_status"].Style.BackColor = Color.FromArgb(255, 243, 205);
                    row.Cells["payment_status"].Style.ForeColor = Color.FromArgb(133, 100, 4);
                }
                else if (status == "Оплачено")
                {
                    row.Cells["payment_status"].Style.BackColor = Color.FromArgb(212, 237, 218);
                    row.Cells["payment_status"].Style.ForeColor = Color.FromArgb(21, 87, 36);
                }

                row.Cells["payment_status"].Style.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold);
            }
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            txtSearch.Clear();
            cmbRentalStatusFilter.SelectedIndex = 0;
            cmbPaymentStatusFilter.SelectedIndex = 0;
            LoadRentals();
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            LoadRentals();
        }

        private void cmbRentalStatusFilter_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadRentals();
        }

        private void cmbPaymentStatusFilter_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadRentals();
        }

        private void btnPay_Click(object sender, EventArgs e)
        {
            if (dgvAllRentals.CurrentRow == null)
            {
                MessageBox.Show("Выберите аренду.");
                return;
            }

            int rentalId = Convert.ToInt32(dgvAllRentals.CurrentRow.Cells["id"].Value);

            using (PaymentForm form = new PaymentForm(rentalId))
            {
                form.ShowDialog();
            }

            LoadRentals();
        }

        private void btnFinishRental_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgvAllRentals.CurrentRow == null)
                {
                    MessageBox.Show("Выберите аренду.");
                    return;
                }

                int rentalId = Convert.ToInt32(dgvAllRentals.CurrentRow.Cells["id"].Value);

                DataTable rentalDt = Database.ExecuteQuery(
                    "SELECT cars_id, status_id FROM Rentals WHERE id = ?",
                    new OleDbParameter("@id", rentalId)
                );

                if (rentalDt.Rows.Count == 0)
                {
                    MessageBox.Show("Аренда не найдена.");
                    return;
                }

                int carId = Convert.ToInt32(rentalDt.Rows[0]["cars_id"]);
                int currentStatusId = Convert.ToInt32(rentalDt.Rows[0]["status_id"]);

                if (currentStatusId == STATUS_FINISHED)
                {
                    MessageBox.Show("Аренда уже завершена.");
                    return;
                }

                if (currentStatusId == STATUS_CANCELED)
                {
                    MessageBox.Show("Отмененную аренду нельзя завершить.");
                    return;
                }

                Database.ExecuteNonQuery(
                    "UPDATE Rentals SET status_id = ? WHERE id = ?",
                    new OleDbParameter("@status_id", STATUS_FINISHED),
                    new OleDbParameter("@id", rentalId)
                );

                Database.ExecuteNonQuery(
                    "UPDATE Cars SET status = ? WHERE id = ?",
                    new OleDbParameter("@status", "Свободно"),
                    new OleDbParameter("@id", carId)
                );

                MessageBox.Show("Аренда завершена.");
                LoadRentals();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка при завершении аренды: " + ex.Message);
            }
        }
    }
}