using ISCarRental;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ISCarRental.Forms
{
    public partial class MyRentalsForm : Form
    {
        int userId;
        public MyRentalsForm(int id)
        {
            InitializeComponent();
            userId = id;

            dgvMyRentals.AllowUserToAddRows = false;
            dgvMyRentals.ReadOnly = true;
            dgvMyRentals.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        }

        private void LoadMyRentals()
        {
            string sql = @"
                SELECT Rentals.id AS rent_id,
                       Rentals.cars_id AS cars_id,
                       Cars.brand AS Brand,
                       Cars.model AS Model,
                       Rentals.start_date AS StartDate,
                       Rentals.end_date AS EndDate,
                       Rentals.total_price AS Price
                FROM (Rentals 
                INNER JOIN Cars ON Rentals.cars_id = Cars.id)
                WHERE Rentals.client_id = ?";

            DataTable table = Database.ExecuteQuery(
                sql,
                new OleDbParameter("@user", userId)
            );

            dgvMyRentals.DataSource = table;

            dgvMyRentals.Columns["rent_id"].HeaderText = "ID аренды";
            dgvMyRentals.Columns["cars_id"].HeaderText = "ID автомобиля";
            dgvMyRentals.Columns["Brand"].HeaderText = "Бренд";
            dgvMyRentals.Columns["Model"].HeaderText = "Модель";
            dgvMyRentals.Columns["StartDate"].HeaderText = "Дата начала";
            dgvMyRentals.Columns["EndDate"].HeaderText = "Дата окончания";
            dgvMyRentals.Columns["Price"].HeaderText = "Стоимость в день";
        }

        private void MyRentalsForm_Load(object sender, EventArgs e)
        {
            LoadMyRentals();
        }

        private void btnReturnCar_Click(object sender, EventArgs e)
        {
            if (dgvMyRentals.CurrentRow == null)
            {
                MessageBox.Show("Выберите аренду");
                return;
            }

            int rentId = Convert.ToInt32(dgvMyRentals.CurrentRow.Cells["rent_id"].Value);

            string sql = "DELETE FROM Rentals WHERE id=?";

            Database.ExecuteNonQuery(
                sql,
                new OleDbParameter("@id", rentId)
            );

            MessageBox.Show("Автомобиль возвращён");

            LoadMyRentals();
        }

        private void btnCencel_Click(object sender, EventArgs e)
        {
            if (dgvMyRentals.CurrentRow == null)
            {
                MessageBox.Show("Выберите аренду");
                return;
            }

            int rentId = Convert.ToInt32(dgvMyRentals.CurrentRow.Cells["rent_id"].Value);
            int carId = Convert.ToInt32(dgvMyRentals.CurrentRow.Cells["cars_id"].Value);

            // Удаляем аренду
            string sqlDeleteRent = "DELETE FROM Rentals WHERE id=?";

            Database.ExecuteNonQuery(
                sqlDeleteRent,
                new OleDbParameter("@id", rentId)
            );

            // Обновляем статус автомобиля на "Свободно"
            string sqlUpdateCar = "UPDATE Cars SET status='Свободно' WHERE id=?";

            Database.ExecuteNonQuery(
                sqlUpdateCar,
                new OleDbParameter("@id", carId)
            );

            MessageBox.Show("Зказ отменен!");

            LoadMyRentals();
        }
    }
}
