using System;
using System.Data;
using System.Data.OleDb;
using System.Windows.Forms;

namespace ISCarRental.Forms
{
    public partial class MyRentalsForm1 : Form
    {
        private int _clientId;

        public MyRentalsForm1(int clientId)
        {
            InitializeComponent();
            _clientId = clientId;
        }

        private void MyRentalsForm_Load(object sender, EventArgs e)
        {
            LoadRentals();
        }

        private void LoadRentals()
        {
            string sql = @"
    SELECT Rentals.id,
           Cars.brand,
           Cars.model,
           Rentals.start_date,
           Rentals.end_date,
           Rentals.total_price,
           RentalsStatus.status_name AS rental_status,
           Rentals.payment_status
    FROM ((Rentals
    INNER JOIN Cars ON Rentals.cars_id = Cars.id)
    INNER JOIN RentalsStatus ON Rentals.status_id = RentalsStatus.id)
    WHERE Rentals.client_id = ?";

            DataTable dt = Database.ExecuteQuery(
                sql,
                new System.Data.OleDb.OleDbParameter("@client_id", _clientId)
            );

            dgvMyRentals1.DataSource = dt;
        }

            //if (dgvMyRentals.Columns.Contains("id"))
            //    dgvMyRentals.Columns["id"].HeaderText = "ID";

            //if (dgvMyRentals.Columns.Contains("brand"))
            //    dgvMyRentals.Columns["brand"].HeaderText = "Марка";

            //if (dgvMyRentals.Columns.Contains("model"))
            //    dgvMyRentals.Columns["model"].HeaderText = "Модель";

            //if (dgvMyRentals.Columns.Contains("start_date"))
            //    dgvMyRentals.Columns["start_date"].HeaderText = "Дата начала";

            //if (dgvMyRentals.Columns.Contains("end_date"))
            //    dgvMyRentals.Columns["end_date"].HeaderText = "Дата окончания";

            //if (dgvMyRentals.Columns.Contains("total_price"))
            //    dgvMyRentals.Columns["total_price"].HeaderText = "Сумма";

            //if (dgvMyRentals.Columns.Contains("rental_status"))
            //    dgvMyRentals.Columns["rental_status"].HeaderText = "Статус аренды";

            //if (dgvMyRentals.Columns.Contains("payment_status"))
            //    dgvMyRentals.Columns["payment_status"].HeaderText = "Статус оплаты";

            //dgvMyRentals.AllowUserToAddRows = false;
            //dgvMyRentals.ReadOnly = true;
            //dgvMyRentals.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            //dgvMyRentals.MultiSelect = false;
        //}

        private void btnPay_Click(object sender, EventArgs e)
        {
            if (dgvMyRentals1.CurrentRow == null)
            {
                MessageBox.Show("Выберите аренду.");
                return;
            }

            int rentalId = Convert.ToInt32(dgvMyRentals1.CurrentRow.Cells["id"].Value);

            PaymentForm form = new PaymentForm(rentalId);
            form.ShowDialog();

            LoadRentals();
        }

        private void btnCencel_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgvMyRentals1.CurrentRow == null)
                {
                    MessageBox.Show("Выберите аренду.");
                    return;
                }

                int rentalId = Convert.ToInt32(dgvMyRentals1.CurrentRow.Cells["id"].Value);

                DataTable rentalDt = Database.ExecuteQuery(
                    "SELECT cars_id, rental_status FROM Rentals WHERE id = ?",
                    new OleDbParameter("@id", rentalId)
                );

                if (rentalDt.Rows.Count == 0)
                {
                    MessageBox.Show("Аренда не найдена.");
                    return;
                }

                string currentStatus = rentalDt.Rows[0]["rental_status"].ToString();
                int carId = Convert.ToInt32(rentalDt.Rows[0]["cars_id"]);

                if (currentStatus == "Завершена")
                {
                    MessageBox.Show("Эта аренда уже завершена.");
                    return;
                }

                Database.ExecuteNonQuery(
                    "UPDATE Rentals SET rental_status = ? WHERE id = ?",
                    new OleDbParameter("@rental_status", "Отменена"),
                    new OleDbParameter("@id", rentalId)
                );

                Database.ExecuteNonQuery(
                    "UPDATE Cars SET status = ? WHERE id = ?",
                    new OleDbParameter("@status", "Свободно"),
                    new OleDbParameter("@id", carId)
                );

                MessageBox.Show("Аренда отменена.");
                LoadRentals();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка при отмене аренды: " + ex.Message);
            }
        }

        private void btnReturnCar_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgvMyRentals1.CurrentRow == null)
                {
                    MessageBox.Show("Выберите аренду.");
                    return;
                }

                int rentalId = Convert.ToInt32(dgvMyRentals1.CurrentRow.Cells["id"].Value);

                DataTable rentalDt = Database.ExecuteQuery(
                    "SELECT cars_id, rental_status FROM Rentals WHERE id = ?",
                    new OleDbParameter("@id", rentalId)
                );

                if (rentalDt.Rows.Count == 0)
                {
                    MessageBox.Show("Аренда не найдена.");
                    return;
                }

                string currentStatus = rentalDt.Rows[0]["rental_status"].ToString();
                int carId = Convert.ToInt32(rentalDt.Rows[0]["cars_id"]);

                if (currentStatus == "Отменена")
                {
                    MessageBox.Show("Эта аренда уже отменена.");
                    return;
                }

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

                MessageBox.Show("Автомобиль возвращен.");
                LoadRentals();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка при возврате автомобиля: " + ex.Message);
            }
        }
    }
}