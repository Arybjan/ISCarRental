using System;
using System.Data;
using System.Data.OleDb;
using System.Windows.Forms;

namespace ISCarRental.Forms
{
    public partial class AdminCarsForm : Form
    {
        public AdminCarsForm()
        {
            InitializeComponent();
        }

        private void AdminCarsForm_Load(object sender, EventArgs e)
        {
            LoadCategories();
            LoadLocations();
            LoadCars();
            LoadStatuses();
    
            dgvCars.AllowUserToAddRows = false;

            dgvCars.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvCars.MultiSelect = false;
        }

        // Загрузка автомобилей
        private void LoadCars()
        {
            string sql = @"SELECT Cars.id,
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
                INNER JOIN Locations ON Cars.location_id = Locations.id";

            DataTable table = Database.ExecuteQuery(sql);

            dgvCars.DataSource = table;

            dgvCars.Columns["id"].Visible = false;

            dgvCars.Columns["brand"].HeaderText = "Бренд";
            dgvCars.Columns["model"].HeaderText = "Модель";
            dgvCars.Columns["year_of_m"].HeaderText = "Год";
            dgvCars.Columns["color"].HeaderText = "Цвет";
            dgvCars.Columns["mileage"].HeaderText = "Пробег";
            dgvCars.Columns["daily_price"].HeaderText = "Цена / день";
            dgvCars.Columns["plate_number"].HeaderText = "Гос номер";
            dgvCars.Columns["category"].HeaderText = "Категория";
            dgvCars.Columns["location"].HeaderText = "Локация";
            dgvCars.Columns["status"].HeaderText = "Статус";
        }

        // Загрузка категорий
        private void LoadCategories()
        {
            string sql = "SELECT id, category_name FROM CarCategories";

            DataTable table = Database.ExecuteQuery(sql);

            cmbCategory.DataSource = table;
            cmbCategory.DisplayMember = "category_name";
            cmbCategory.ValueMember = "id";
        }

        // Загрузка локаций
        private void LoadLocations()
        {
            string sql = "SELECT id, city FROM Locations";

            DataTable table = Database.ExecuteQuery(sql);

            cmbLocation.DataSource = table;
            cmbLocation.DisplayMember = "city";
            cmbLocation.ValueMember = "id";
        }

        // Загрузка статусов
        private void LoadStatuses()
        {   
            cmbStatus.Items.Clear();
            cmbStatus.Items.Add("Свободно");
            cmbStatus.Items.Add("Занято");
            cmbStatus.Items.Add("На ремонте");
        }

        // Клик по строке
        private void dgvCars_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvCars.CurrentRow == null) return;

            txtBrand.Text = dgvCars.CurrentRow.Cells["brand"].Value.ToString();
            txtModel.Text = dgvCars.CurrentRow.Cells["model"].Value.ToString();
            numYear.Value = Convert.ToDecimal(dgvCars.CurrentRow.Cells["year_of_m"].Value);
            txtColor.Text = dgvCars.CurrentRow.Cells["color"].Value.ToString();
            numMileage.Value = Convert.ToDecimal(dgvCars.CurrentRow.Cells["mileage"].Value);
            numPrice.Value = Convert.ToDecimal(dgvCars.CurrentRow.Cells["daily_price"].Value);
            txtPlate.Text = dgvCars.CurrentRow.Cells["plate_number"].Value.ToString();

            cmbCategory.Text = dgvCars.CurrentRow.Cells["category"].Value.ToString();
            cmbLocation.Text = dgvCars.CurrentRow.Cells["location"].Value.ToString();
            cmbStatus.Text = dgvCars.CurrentRow.Cells["status"].Value.ToString();
        }

        // Добавить автомобиль
        private void btnAddCar_Click(object sender, EventArgs e)
        {
            string sql = @"INSERT INTO Cars
            (brand, model, year_of_m, color, mileage, daily_price, plate_number, category_id, location_id, status)
            VALUES (?, ?, ?, ?, ?, ?, ?, ?, ?, ?)";

            Database.ExecuteNonQuery(
                sql,
                new OleDbParameter("@brand", txtBrand.Text),
                new OleDbParameter("@model", txtModel.Text),
                new OleDbParameter("@year", numYear.Value),
                new OleDbParameter("@color", txtColor.Text),
                new OleDbParameter("@mileage", numMileage.Value),
                new OleDbParameter("@price", numPrice.Value),
                new OleDbParameter("@plate", txtPlate.Text),
                new OleDbParameter("@category", cmbCategory.SelectedValue),
                new OleDbParameter("@location", cmbLocation.SelectedValue),
                new OleDbParameter("@status", cmbStatus.Text)
            );

            MessageBox.Show("Автомобиль добавлен");

            LoadCars();
        }

        // Обновить автомобиль
        private void btnUpdateCar_Click(object sender, EventArgs e)
        {
            if (dgvCars.CurrentRow == null) return;

            int id = Convert.ToInt32(dgvCars.CurrentRow.Cells["id"].Value);

            string sql = @"UPDATE Cars
            SET brand=?, model=?, year_of_m=?, color=?, mileage=?, daily_price=?, plate_number=?, category_id=?, location_id=?, status=?
            WHERE id=?";

            Database.ExecuteNonQuery(
                sql,
                new OleDbParameter("@brand", txtBrand.Text),
                new OleDbParameter("@model", txtModel.Text),
                new OleDbParameter("@year", numYear.Value),
                new OleDbParameter("@color", txtColor.Text),
                new OleDbParameter("@mileage", numMileage.Value),
                new OleDbParameter("@price", numPrice.Value),
                new OleDbParameter("@plate", txtPlate.Text),
                new OleDbParameter("@category", cmbCategory.SelectedValue),
                new OleDbParameter("@location", cmbLocation.SelectedValue),
                new OleDbParameter("@status", cmbStatus.Text),
                new OleDbParameter("@id", id)
            );

            MessageBox.Show("Автомобиль обновлён");

            LoadCars();
        }

        // Удалить автомобиль
        private void btnDeleteCar_Click(object sender, EventArgs e)
        {
            if (dgvCars.CurrentRow == null)
            {
                MessageBox.Show("Выберите автомобиль");
                return;
            }

            int id = Convert.ToInt32(dgvCars.CurrentRow.Cells["id"].Value);

            DialogResult result = MessageBox.Show(
                "Удалить автомобиль?",
                "Подтверждение",
                MessageBoxButtons.YesNo
            );

            if (result == DialogResult.No) return;

            string sql = "DELETE FROM Cars WHERE id=?";

            Database.ExecuteNonQuery(
                sql,
                new OleDbParameter("@id", id)
            );

            MessageBox.Show("Автомобиль удалён");

            LoadCars();
        }

        // Обновить таблицу
        private void btnRefresh_Click(object sender, EventArgs e)
        {
            LoadCars();
        }
    }
}