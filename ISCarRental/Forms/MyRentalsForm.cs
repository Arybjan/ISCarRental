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
        }

        private void LoadMyRentals()
        {
            string sql = @"
                SELECT Rentals.id AS rent_id,
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

            if (table.Rows.Count == 0)
            {
                dgvMyRentals.DataSource = null;
                MessageBox.Show("У вас пока нет арендованных автомобилей.");
            }
            else
            {
                dgvMyRentals.DataSource = table;
            }
        }

        private void MyRentalsForm_Load(object sender, EventArgs e)
        {
            LoadMyRentals();
        }
    }
}
