using ISCarRental;
using System;
using System.Data;
using System.Data.OleDb;
using System.Windows.Forms;
using System.Xml.Linq;


namespace ISCarRental.Forms
{
    public partial class RegisterForm : Form
    {
            public RegisterForm()
            {
                InitializeComponent();
            }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            if (textBoxName.Text == "" || textBoxlogin.Text == "" || textBoxpassword.Text == "")
            {
                MessageBox.Show("Заполните все обязательные поля");
                return;
            }

            string sqlUser = "INSERT INTO Users ([name], [surname], [phone], [date_of_birth], [passport_id]) VALUES (?, ?, ?, ?, ?)";

            Database.ExecuteNonQuery(
                sqlUser,
                new OleDbParameter("@name", textBoxName.Text),
                new OleDbParameter("@surname", textBoxSurname.Text),
                new OleDbParameter("@phone", textBoxPhone.Text),
                new OleDbParameter("@date_of_birth", textBoxDate.Text),
                new OleDbParameter("@passport_id", textBoxPassport.Text)
            );

            DataTable table = Database.ExecuteQuery("SELECT MAX(id) FROM Users");
            int userId = Convert.ToInt32(table.Rows[0][0]);

            string sqlAccount = "INSERT INTO Accounts ([login], [password], [user_id], [role_id]) VALUES (?, ?, ?, ?)";

            Database.ExecuteNonQuery(
                sqlAccount,
                new OleDbParameter("@login", textBoxlogin.Text),
                new OleDbParameter("@password", textBoxpassword.Text),
                new OleDbParameter("@user_id", userId),
                new OleDbParameter("@role_id", 2)
            );

            MessageBox.Show("Регистрация успешна");
        }
    }
 }
