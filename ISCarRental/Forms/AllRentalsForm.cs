using System;
using System.Data;
using System.Data.OleDb;
using System.Windows.Forms;

namespace ISCarRental.Forms
{
    public partial class AllRentalsForm : Form
    {
        public AllRentalsForm()
        {
            InitializeComponent();
        }

        private void AllRentalsForm_Load(object sender, EventArgs e)
        {
            LoadRentals();
        }

        private void LoadRentals()
        {
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
                    INNER JOIN RentalsStatus ON Rentals.status_id = RentalsStatus.id";

            DataTable dt = Database.ExecuteQuery(sql);
            dgvAllRentals.DataSource = dt;
        

            if (dgvAllRentals.Columns.Contains("id"))
                dgvAllRentals.Columns["id"].HeaderText = "ID";

            if (dgvAllRentals.Columns.Contains("client_name"))
                dgvAllRentals.Columns["client_name"].HeaderText = "Клиент";

            if (dgvAllRentals.Columns.Contains("brand"))
                dgvAllRentals.Columns["brand"].HeaderText = "Марка";

            if (dgvAllRentals.Columns.Contains("model"))
                dgvAllRentals.Columns["model"].HeaderText = "Модель";

            if (dgvAllRentals.Columns.Contains("start_date"))
                dgvAllRentals.Columns["start_date"].HeaderText = "Дата начала";

            if (dgvAllRentals.Columns.Contains("end_date"))
                dgvAllRentals.Columns["end_date"].HeaderText = "Дата окончания";

            if (dgvAllRentals.Columns.Contains("total_price"))
                dgvAllRentals.Columns["total_price"].HeaderText = "Сумма";

            if (dgvAllRentals.Columns.Contains("rental_status"))
                dgvAllRentals.Columns["rental_status"].HeaderText = "Статус аренды";

            if (dgvAllRentals.Columns.Contains("payment_status"))
                dgvAllRentals.Columns["payment_status"].HeaderText = "Статус оплаты";

            dgvAllRentals.AllowUserToAddRows = false;
            dgvAllRentals.ReadOnly = true;
            dgvAllRentals.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvAllRentals.MultiSelect = false;
        }

        private void button1_Click(object sender, EventArgs e)
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

            PaymentForm form = new PaymentForm(rentalId);
            form.ShowDialog();

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
                    "SELECT cars_id FROM Rentals WHERE id = ?",
                    new OleDbParameter("@id", rentalId)
                );

                if (rentalDt.Rows.Count == 0)
                {
                    MessageBox.Show("Аренда не найдена.");
                    return;
                }

                int carId = Convert.ToInt32(rentalDt.Rows[0]["cars_id"]);

                Database.ExecuteNonQuery(
                    "UPDATE Rentals SET rental_status = ? WHERE id = ?",
                    new OleDbParameter("@rental_status", "Завершена"),
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