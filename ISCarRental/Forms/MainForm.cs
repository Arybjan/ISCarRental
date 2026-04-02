using System;
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
            lblWelcome.Text = $"Добро пожаловать, {_userName}";

            ApplyButtonStyle(btnCars, Color.FromArgb(37, 43, 72));
            ApplyButtonStyle(btnMyRentals, Color.FromArgb(37, 43, 72));
            ApplyButtonStyle(btnNewRent, Color.FromArgb(37, 43, 72));
            ApplyButtonStyle(btnAllRentals, Color.FromArgb(37, 43, 72));
            ApplyButtonStyle(btnExit, Color.FromArgb(220, 53, 69));

            if (_roleId != 1)
            {
                btnAllRentals.Visible = false;
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

        private void btnCars_Click(object sender, EventArgs e)
        {
            using (CarsForm form = new CarsForm())
            {
                form.ShowDialog();
            }
        }

        private void btnMyRentals_Click(object sender, EventArgs e)
        {
            using (MyRentalsForm form = new MyRentalsForm(_userId))
            {
                form.ShowDialog();
            }
        }

        private void btnNewRent_Click(object sender, EventArgs e)
        {
            using (NewRentForm form = new NewRentForm(_userId))
            {
                form.ShowDialog();
            }
        }

        private void btnAllRentals_Click(object sender, EventArgs e)
        {
            using (AllRentalsForm form = new AllRentalsForm())
            {
                form.ShowDialog();
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}