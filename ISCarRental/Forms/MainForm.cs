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
    public partial class MainForm : Form
    {
        // Поля для хранения информации о пользователе
        int userId; 
        int roleId;
        string userName;
        public MainForm(int id, int role, string username)
        {
            InitializeComponent();
            userId = id;
            roleId = role;
            userName = username;
        }

        private void btnViewCars_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Кнопка нажата");
            //this .Hide();
            CarsForm carsForm = new CarsForm();
            carsForm.Show();
        }

        private void btnNewRental_Click(object sender, EventArgs e)
        {
            NewRentForm rentForm = new NewRentForm(userId);
            rentForm.Show();
            
        }

        private void btnMyRentals_Click(object sender, EventArgs e)
        {
            string sql = "SELECT COUNT(*) FROM Rentals WHERE client_id=?";

            DataTable table = Database.ExecuteQuery(
                sql,
                new OleDbParameter("@id", userId)
            );

            int count = Convert.ToInt32(table.Rows[0][0]);

            if (count == 0)
            {
                MessageBox.Show(
                    "У вас пока нет активных аренд.\nВы можете оформить новую аренду в разделе 'Новая аренда'.",
                    "Информация"
                );
                return;
            }

            MyRentalsForm rentalsForm = new MyRentalsForm(userId);
            rentalsForm.Show();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            labelUser.Text = $"Пользователь: {userName}";
            labelRole.Text = $"Роль: {(roleId == 1 ? "Администратор" : "Клиент")}";

            if (roleId != 1) // Если не админ
            {
                btnManageUsers.Enabled = false; // Отключаем кнопку просмотра всех пользователей
                btnManageUsers.Visible = false; // Скрываем кнопку управления пользователями

                btnAllRentals.Enabled = false; // Отключаем кнопку просмотра всех аренд
                btnAllRentals.Visible = false; // Скрываем кнопку просмотра всех аренд

                btnAdminCar.Enabled = false; // Отключаем кнопку управления автомобилями
                btnAdminCar.Visible = false; // Скрываем кнопку управления автомобилями
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show(
                "Вы уверены что хотите выйти?",
                "Выход",
                MessageBoxButtons.YesNo
                ); // Сообщение о выходее

            if (result == DialogResult.Yes)
            {
                LoginForm login = new LoginForm();
                login.Show();

                this.Close();
            }

        }

        private void btnAdminCar_Click(object sender, EventArgs e)
        {
            AdminCarsForm adminCarsForm = new AdminCarsForm();
            adminCarsForm.Show();

            //this .Hide();
        }

        private void btnAllRentals_Click(object sender, EventArgs e)
        {
            AllRentalsForm rentalsForm = new AllRentalsForm(); 
            rentalsForm.Show();
        }

        private void btnManageUsers_Click(object sender, EventArgs e)
        {
            AllUsersForm usersForm = new AllUsersForm();   
            usersForm.Show();
        }
    }
}
