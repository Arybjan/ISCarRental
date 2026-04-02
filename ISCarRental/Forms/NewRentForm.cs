using System;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Windows.Forms;

namespace ISCarRental.Forms
{
    public partial class NewRentForm : Form
    {
        private readonly int _clientId;
        private const int STATUS_ACTIVE = 1;

        public NewRentForm(int clientId)
        {
            InitializeComponent();
            _clientId = clientId;
        }

        private void NewRentForm_Load(object sender, EventArgs e)
        {
            btnRent.BackColor = Color.FromArgb(13, 110, 253);
            btnRent.ForeColor = Color.White;
            btnRent.FlatStyle = FlatStyle.Flat;
            btnRent.FlatAppearance.BorderSize = 0;

            LoadAvailableCars();
            dtpStartDate.Value = DateTime.Today;
            dtpEndDate.Value = DateTime.Today.AddDays(1);
            lblTotalPriceValue.Text = "0";
        }

        private void LoadAvailableCars()
        {
            string sql = @"
                SELECT id,
                       brand,
                       model,
                       daily_price,
                       color,
                       year_of_m,
                       plate_number
                FROM Cars
                WHERE status = ?
                ORDER BY brand, model";

            DataTable dt = Database.ExecuteQuery(
                sql,
                new OleDbParameter("@status", "Свободно")
            );

            cmbCars.DataSource = dt;
            cmbCars.DisplayMember = "model";
            cmbCars.ValueMember = "id";

            if (dt.Rows.Count == 0)
            {
                MessageBox.Show("Нет свободных автомобилей.");
                btnRent.Enabled = false;
            }
            else
            {
                btnRent.Enabled = true;
            }
        }

        private decimal GetSelectedCarDailyPrice()
        {
            if (cmbCars.SelectedItem is DataRowView rowView)
            {
                return Convert.ToDecimal(rowView["daily_price"]);
            }

            return 0m;
        }

        private void UpdateTotalPrice()
        {
            if (cmbCars.SelectedItem == null)
            {
                lblTotalPriceValue.Text = "0";
                return;
            }

            DateTime startDate = dtpStartDate.Value.Date;
            DateTime endDate = dtpEndDate.Value.Date;

            int days = (endDate - startDate).Days;

            if (days <= 0)
            {
                lblTotalPriceValue.Text = "0";
                return;
            }

            decimal dailyPrice = GetSelectedCarDailyPrice();
            decimal totalPrice = dailyPrice * days;

            lblTotalPriceValue.Text = totalPrice.ToString("0.##");
        }

        private void cmbCars_SelectedIndexChanged(object sender, EventArgs e)
        {
            UpdateTotalPrice();
        }

        private void dtpStartDate_ValueChanged(object sender, EventArgs e)
        {
            UpdateTotalPrice();
        }

        private void dtpEndDate_ValueChanged(object sender, EventArgs e)
        {
            UpdateTotalPrice();
        }

        private void btnRent_Click(object sender, EventArgs e)
        {
            try
            {
                if (cmbCars.SelectedValue == null)
                {
                    MessageBox.Show("Выберите автомобиль.");
                    return;
                }

                int carId = Convert.ToInt32(cmbCars.SelectedValue);
                DateTime startDate = dtpStartDate.Value.Date;
                DateTime endDate = dtpEndDate.Value.Date;

                if (endDate <= startDate)
                {
                    MessageBox.Show("Дата окончания должна быть больше даты начала.");
                    return;
                }

                int days = (endDate - startDate).Days;
                decimal dailyPrice = GetSelectedCarDailyPrice();
                decimal totalPrice = dailyPrice * days;

                if (totalPrice <= 0)
                {
                    MessageBox.Show("Некорректная сумма аренды.");
                    return;
                }

                DataTable carCheck = Database.ExecuteQuery(
                    "SELECT status FROM Cars WHERE id = ?",
                    new OleDbParameter("@id", carId)
                );

                if (carCheck.Rows.Count == 0)
                {
                    MessageBox.Show("Автомобиль не найден.");
                    return;
                }

                string currentCarStatus = carCheck.Rows[0]["status"].ToString();

                if (currentCarStatus != "Свободно")
                {
                    MessageBox.Show("Этот автомобиль уже недоступен для аренды.");
                    LoadAvailableCars();
                    return;
                }

                Database.ExecuteNonQuery(
                    @"INSERT INTO Rentals 
                      (cars_id, client_id, start_date, end_date, total_price, status_id, payment_status)
                      VALUES (?, ?, ?, ?, ?, ?, ?)",
                    new OleDbParameter("@cars_id", carId),
                    new OleDbParameter("@client_id", _clientId),
                    new OleDbParameter("@start_date", startDate),
                    new OleDbParameter("@end_date", endDate),
                    new OleDbParameter("@total_price", totalPrice),
                    new OleDbParameter("@status_id", STATUS_ACTIVE),
                    new OleDbParameter("@payment_status", "Не оплачено")
                );

                Database.ExecuteNonQuery(
                    "UPDATE Cars SET status = ? WHERE id = ?",
                    new OleDbParameter("@status", "Занято"),
                    new OleDbParameter("@id", carId)
                );

                MessageBox.Show("Аренда успешно оформлена.");
                DialogResult = DialogResult.OK;
                Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка при оформлении аренды: " + ex.Message);
            }
        }
    }
}