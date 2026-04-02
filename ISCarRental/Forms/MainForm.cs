using System;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Windows.Forms;

namespace ISCarRental.Forms
{
    public partial class MainForm : Form
    {
        private readonly int _userId;
        private readonly int _roleId;
        private readonly string _userName;

        public MainForm(int userId, int roleId, string userName)
        {
            InitializeComponent();
            _userId = userId;
            _roleId = roleId;
            _userName = userName;
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            ApplyButtonStyle(btnCars, Color.FromArgb(37, 43, 72));
            ApplyButtonStyle(btnMyRentals, Color.FromArgb(37, 43, 72));
            ApplyButtonStyle(btnNewRent, Color.FromArgb(37, 43, 72));
            ApplyButtonStyle(btnAllRentals, Color.FromArgb(37, 43, 72));
            ApplyButtonStyle(btnExit, Color.FromArgb(220, 53, 69));

            lblWelcome.Text = $"Добро пожаловать, {_userName}";

            if (_roleId != 1)
            {
                btnAllRentals.Visible = false;
            }

            if (_roleId == 1)
            {
                LoadAdminStats();
            }
            else
            {
                LoadUserStats();
            }

            if (_roleId == 1)
            {
                lblSubtitle.Text = "Статистика всей системы";
            }
            else
            {
                lblSubtitle.Text = "Ваша личная статистика";
            }
        }

        private void ApplyButtonStyle(Button button, Color backColor)
        {
            button.BackColor = backColor;
            button.ForeColor = Color.White;
            button.FlatStyle = FlatStyle.Flat;
            button.FlatAppearance.BorderSize = 0;
            button.Cursor = Cursors.Hand;
        }

        private void LoadDashboardStats()
        {
            try
            {
                lblFreeCarsValue.Text = GetCount(
                    "SELECT COUNT(*) FROM Cars WHERE status = ?",
                    new OleDbParameter("@status", "Свободно")
                ).ToString();

                lblActiveRentalsValue.Text = GetCount(
                    @"SELECT COUNT(*) 
                      FROM Rentals 
                      INNER JOIN RentalsStatus ON Rentals.status_id = RentalsStatus.id
                      WHERE RentalsStatus.status_name = ?",
                    new OleDbParameter("@status_name", "Активна")
                ).ToString();

                lblUnpaidRentalsValue.Text = GetCount(
                    "SELECT COUNT(*) FROM Rentals WHERE payment_status = ?",
                    new OleDbParameter("@payment_status", "Не оплачено")
                ).ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка при загрузке статистики: " + ex.Message);
            }
        }

        private int GetCount(string sql, params OleDbParameter[] parameters)
        {
            object result = Database.ExecuteScalar(sql, parameters);

            if (result == null || result == DBNull.Value)
                return 0;

            return Convert.ToInt32(result);
        }

        private void btnCars_Click(object sender, EventArgs e)
        {
            using (CarsForm form = new CarsForm())
            {
                form.ShowDialog();
            }

            LoadDashboardStats();
        }

        private void btnMyRentals_Click(object sender, EventArgs e)
        {
            using (MyRentalsForm form = new MyRentalsForm(_userId))
            {
                form.ShowDialog();
            }

            LoadDashboardStats();
        }

        private void btnNewRent_Click(object sender, EventArgs e)
        {
            using (NewRentForm form = new NewRentForm(_userId))
            {
                form.ShowDialog();
            }

            LoadDashboardStats();
        }

        private void btnAllRentals_Click(object sender, EventArgs e)
        {
            using (AllRentalsForm form = new AllRentalsForm())
            {
                form.ShowDialog();
            }

            LoadDashboardStats();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void LoadAdminStats()
        {
            lblFreeCarsValue.Text = GetCount(
                "SELECT COUNT(*) FROM Cars WHERE status = ?",
                new OleDbParameter("@status", "Свободно")
            ).ToString();

            lblActiveRentalsValue.Text = GetCount(
                @"SELECT COUNT(*) 
          FROM Rentals 
          INNER JOIN RentalsStatus ON Rentals.status_id = RentalsStatus.id
          WHERE RentalsStatus.status_name = ?",
                new OleDbParameter("@status_name", "Активна")
            ).ToString();

            lblUnpaidRentalsValue.Text = GetCount(
                "SELECT COUNT(*) FROM Rentals WHERE payment_status = ?",
                new OleDbParameter("@payment_status", "Не оплачено")
            ).ToString();
        }

        private void LoadUserStats()
        {
            lblFreeCarsValue.Text = GetCount(
                "SELECT COUNT(*) FROM Cars WHERE status = ?",
                new OleDbParameter("@status", "Свободно")
            ).ToString();

            lblActiveRentalsValue.Text = GetCount(
                @"SELECT COUNT(*) 
          FROM Rentals 
          INNER JOIN RentalsStatus ON Rentals.status_id = RentalsStatus.id
          WHERE RentalsStatus.status_name = ? AND Rentals.client_id = ?",
                new OleDbParameter("@status_name", "Активна"),
                new OleDbParameter("@client_id", _userId)
            ).ToString();

            lblUnpaidRentalsValue.Text = GetCount(
                @"SELECT COUNT(*) 
          FROM Rentals 
          WHERE payment_status = ? AND client_id = ?",
                new OleDbParameter("@payment_status", "Не оплачено"),
                new OleDbParameter("@client_id", _userId)
            ).ToString();
        }
    }
}