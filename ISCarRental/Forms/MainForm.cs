using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ISCarRental.Forms
{
    public partial class MainForm : Form
    {
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
                btnAllRentals.Enabled = false; // Отключаем кнопку просмотра всех аренд
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show(
                "Вы уверены что хотите выйти?",
                "Выход",
                MessageBoxButtons.YesNo
                );

            if (result == DialogResult.Yes)
            {
                LoginForm login = new LoginForm();
                login.Show();

                this.Close();
            }

        }
    }
}
