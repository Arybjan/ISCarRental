using System;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Windows.Forms;

namespace ISCarRental.Forms
{
    public partial class CarsForm : Form
    {
        public CarsForm()
        {
            InitializeComponent();
        }

        private void CarsForm_Load(object sender, EventArgs e)
        {
            cmbStatusFilter.Items.Clear();
            cmbStatusFilter.Items.Add("Все");
            cmbStatusFilter.Items.Add("Свободно");
            cmbStatusFilter.Items.Add("Занято");
            cmbStatusFilter.SelectedIndex = 0;

            LoadCars();
        }

        private void LoadCars()
        {
            string searchText = txtSearch.Text.Trim();
            string selectedStatus = cmbStatusFilter.SelectedItem?.ToString() ?? "Все";

            string sql = @"
                SELECT Cars.id,
                       Cars.brand,
                       Cars.model,
                       Cars.year_of_m,
                       Cars.color,
                       Cars.mileage,
                       Cars.daily_price,
                       Cars.plate_number,
                       CarCategories.category_name AS category,
                       Locations.city AS location,
                       Cars.status
                FROM (Cars
                INNER JOIN CarCategories ON Cars.category_id = CarCategories.id)
                INNER JOIN Locations ON Cars.location_id = Locations.id
                WHERE 1=1";

            var parameters = new System.Collections.Generic.List<OleDbParameter>();

            if (!string.IsNullOrWhiteSpace(searchText))
            {
                sql += " AND (Cars.brand LIKE ? OR Cars.model LIKE ? OR Cars.plate_number LIKE ?)";
                parameters.Add(new OleDbParameter("@brand", "%" + searchText + "%"));
                parameters.Add(new OleDbParameter("@model", "%" + searchText + "%"));
                parameters.Add(new OleDbParameter("@plate", "%" + searchText + "%"));
            }

            if (selectedStatus != "Все")
            {
                sql += " AND Cars.status = ?";
                parameters.Add(new OleDbParameter("@status", selectedStatus));
            }

            sql += " ORDER BY Cars.brand, Cars.model";

            DataTable dt = Database.ExecuteQuery(sql, parameters.ToArray());
            dgvCars.DataSource = dt;

            StyleGrid(dgvCars);

            if (dgvCars.Columns.Contains("id"))
                dgvCars.Columns["id"].HeaderText = "ID";
            if (dgvCars.Columns.Contains("brand"))
                dgvCars.Columns["brand"].HeaderText = "Марка";
            if (dgvCars.Columns.Contains("model"))
                dgvCars.Columns["model"].HeaderText = "Модель";
            if (dgvCars.Columns.Contains("year_of_m"))
                dgvCars.Columns["year_of_m"].HeaderText = "Год";
            if (dgvCars.Columns.Contains("color"))
                dgvCars.Columns["color"].HeaderText = "Цвет";
            if (dgvCars.Columns.Contains("mileage"))
                dgvCars.Columns["mileage"].HeaderText = "Пробег";
            if (dgvCars.Columns.Contains("daily_price"))
                dgvCars.Columns["daily_price"].HeaderText = "Цена/день";
            if (dgvCars.Columns.Contains("plate_number"))
                dgvCars.Columns["plate_number"].HeaderText = "Гос. номер";
            if (dgvCars.Columns.Contains("category"))
                dgvCars.Columns["category"].HeaderText = "Категория";
            if (dgvCars.Columns.Contains("location"))
                dgvCars.Columns["location"].HeaderText = "Город";
            if (dgvCars.Columns.Contains("status"))
                dgvCars.Columns["status"].HeaderText = "Статус";

            PaintCarStatus();
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

        private void PaintCarStatus()
        {
            foreach (DataGridViewRow row in dgvCars.Rows)
            {
                if (row.Cells["status"].Value == null)
                    continue;

                string status = row.Cells["status"].Value.ToString();

                if (status == "Свободно")
                {
                    row.Cells["status"].Style.BackColor = Color.FromArgb(212, 237, 218);
                    row.Cells["status"].Style.ForeColor = Color.FromArgb(21, 87, 36);
                    row.Cells["status"].Style.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold);
                }
                else if (status == "Занято")
                {
                    row.Cells["status"].Style.BackColor = Color.FromArgb(255, 243, 205);
                    row.Cells["status"].Style.ForeColor = Color.FromArgb(133, 100, 4);
                    row.Cells["status"].Style.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold);
                }
            }
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            txtSearch.Clear();
            cmbStatusFilter.SelectedIndex = 0;
            LoadCars();
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            LoadCars();
        }

        private void cmbStatusFilter_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadCars();
        }
    }
}