using ISCarRental;
using System;
using System.Data;
using System.Data.OleDb;
using System.Windows.Forms;

namespace ISCarRental.Forms
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void LoginButton_Click(object sender, EventArgs e)
        {
            if (textBoxLogin.Text == "" || textBoxPassword.Text == "") // Если все поля не заполнены
            {
                MessageBox.Show("Пожалуйста, заполните все поля");
                return;

            }

            
            string sql = @"
                SELECT Users.id, Users.name, Accounts.role_id
                FROM Accounts
                INNER JOIN Users ON Accounts.user_id = Users.id
                WHERE Accounts.login=? AND Accounts.password=?";

            DataTable table = Database.ExecuteQuery(
                sql,
                new OleDbParameter("@login", textBoxLogin.Text),
                new OleDbParameter("@password", textBoxPassword.Text)
                );


            if (table.Rows.Count > 0)
            {
                int userId = Convert.ToInt32(table.Rows[0]["id"]);
                int roleId = Convert.ToInt32(table.Rows[0]["role_id"]);
                string userName = table.Rows[0]["name"].ToString();

                MainForm main = new MainForm(userId, roleId, userName);
                main.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Неверный логин или пароль");
            }
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {   
            RegisterForm reg = new RegisterForm();
            reg.Show();
        }
    }
}