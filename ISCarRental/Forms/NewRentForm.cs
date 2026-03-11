using System;
using System.Data;
using System.Data.OleDb;
using System.Windows.Forms;

namespace ISCarRental.Forms
{
    public partial class NewRentForm : Form
    {
        int userId;

        public NewRentForm(int id)
        {
            InitializeComponent();
            userId = id;
        }

        private void NewRentForm_Load(object sender, EventArgs e)
        {
            LoadCars();
        }

        private void LoadCars()
        {
            string sql = @"
                SELECT id, brand, model, daily_price
                FROM Cars
                WHERE status = 'Свободно'";

            dgvCars.DataSource = Database.ExecuteQuery(sql);
        }

        private void btnRent_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgvCars.CurrentRow == null)
                {
                    MessageBox.Show("Выберите автомобиль");
                    return;
                }

                int carId = Convert.ToInt32(dgvCars.CurrentRow.Cells["id"].Value);

                DateTime start = dtStart.Value.Date;
                DateTime end = dtEnd.Value.Date;

                if (end <= start)
                {
                    MessageBox.Show("Дата окончания должна быть позже даты начала");
                    return;
                }

                int days = (end - start).Days;
                if (days == 0) days = 1;

                decimal price = Convert.ToDecimal(dgvCars.CurrentRow.Cells["daily_price"].Value);
                decimal total = price * days;

                // Сначала нужно получить ID статуса аренды
                int statusId = GetDefaultRentalStatusId();

                if (statusId == 0)
                {
                    MessageBox.Show("Ошибка: не найден статус аренды");
                    return;
                }

                // Исправленный SQL запрос с добавлением status_id
                string sql = @"INSERT INTO Rentals
                               ([cars_id], [client_id], [start_date], [end_date], [total_price], [status_id])
                               VALUES (?, ?, ?, ?, ?, ?)";

                Database.ExecuteNonQuery(
                    sql,
                    new OleDbParameter("@car", carId),
                    new OleDbParameter("@client", userId),
                    new OleDbParameter("@start", start),
                    new OleDbParameter("@end", end),
                    new OleDbParameter("@price", total),
                    new OleDbParameter("@status", statusId) // Добавлен параметр для статуса
                );

                string updateCar = "UPDATE Cars SET status='Занято' WHERE id=?";

                Database.ExecuteNonQuery(
                    updateCar,
                    new OleDbParameter("@id", carId)
                );

                MessageBox.Show("Аренда успешно оформлена");

                LoadCars();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка: " + ex.Message);
            }
        }

        // Метод для получения ID статуса по умолчанию
        private int GetDefaultRentalStatusId ()
        {
            try
            {
                // Предполагаем, что в таблице RentalsStatus есть статус "Активен" или аналогичный
                string sql = "SELECT id FROM RentalsStatus WHERE status_name = 'Активен'";

                DataTable dt = Database.ExecuteQuery(sql);

                if (dt.Rows.Count > 0)
                {
                    return Convert.ToInt32(dt.Rows[0]["id"]);
                }

                // Если не нашли по имени, берем первый доступный статус
                sql = "SELECT TOP 1 id FROM RentalsStatus";
                dt = Database.ExecuteQuery(sql);

                if (dt.Rows.Count > 0)
                {
                    return Convert.ToInt32(dt.Rows[0]["id"]);
                }

                return 0;
            }
            catch
            {
                return 0;
            }
        }
    }
}