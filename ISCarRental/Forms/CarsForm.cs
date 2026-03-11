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
    public partial class CarsForm : Form
    {
        public CarsForm()
        {
            InitializeComponent();
            dgvCars.AllowUserToAddRows = false;
            dgvCars.ReadOnly = true;
            dgvCars.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

        }

        private void LoadCars()
        {

            DataTable table = Database.ExecuteQuery("SELECT * FROM Cars");

            dgvCars.DataSource = table;

            dgvCars.Columns["id"].HeaderText = "ID";
            dgvCars.Columns["brand"].HeaderText = "Бренд";
            dgvCars.Columns["model"].HeaderText = "Модель";
            dgvCars.Columns["year_of_m"].HeaderText = "Год производства";
            dgvCars.Columns["color"].HeaderText = "Цвет";
            dgvCars.Columns["mileage"].HeaderText = "Пробег";
            dgvCars.Columns["daily_price"].HeaderText = "Стоимость в день";
            dgvCars.Columns["plate_number"].HeaderText = "Гос. номер";
            dgvCars.Columns["category_id"].HeaderText = "Категория";
            dgvCars.Columns["location_id"].HeaderText = "Локация";
            dgvCars.Columns["status"].HeaderText = "Статус";
        }

        private void CarsForm_Load(object sender, EventArgs e)
        {


            cmbFilter.Items.Add("Все");
            cmbFilter.Items.Add("Свободно");
            cmbFilter.Items.Add("Занято");

            cmbFilter.SelectedIndex = 0;

            LoadCars();
        }


        private void btnSearch_Click(object sender, EventArgs e)
        {
        
            string search = txtSearch.Text;
            string status = cmbFilter.Text;

            string sql = "SELECT * FROM Cars WHERE (id LIKE ? OR brand LIKE ? OR model LIKE ?)";

            if (status != "Все")
            {
                sql += " AND status=?";
                DataTable table = Database.ExecuteQuery(
                    sql,
                    new OleDbParameter("@p1", "%" + search + "%"),
                    new OleDbParameter("@p2", "%" + search + "%"),
                    new OleDbParameter("@p3", "%" + search + "%"),
                    new OleDbParameter("@p4", status)
                );

                dgvCars.DataSource = table;
            }
            else
            {
                DataTable table = Database.ExecuteQuery(
                    sql,
                    new OleDbParameter("@p1", "%" + search + "%"),
                    new OleDbParameter("@p2", "%" + search + "%"),
                    new OleDbParameter("@p3", "%" + search + "%")
                );

                dgvCars.DataSource = table;
            }
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            btnSearch_Click(sender, e);
        }
    }
}
