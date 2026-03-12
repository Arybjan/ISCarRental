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
    public partial class AllUsersForm : Form
    {
        public AllUsersForm()
        {
            InitializeComponent();
        }

        private void btnViewUsers_Click(object sender, EventArgs e)
        {
            DataTable table = Database.ExecuteQuery("SELECT * FROM Users");

            dgvAllUsers.DataSource = table;

            dgvAllUsers.Columns["id"].HeaderText = "ID";
            dgvAllUsers.Columns["name"].HeaderText = "Имя";
            dgvAllUsers.Columns["surname"].HeaderText = "Фамилия";
            dgvAllUsers.Columns["phone"].HeaderText = "Номер телефона";
            dgvAllUsers.Columns["date_of_birth"].HeaderText = "Дата рождения";
            dgvAllUsers.Columns["passport_id"].HeaderText = "ID паспорта";
        }
    }
    
}
