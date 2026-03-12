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
    public partial class AllRentalsForm : Form
    {
        public AllRentalsForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DataTable table = Database.ExecuteQuery("SELECT * FROM Rentals");

            dgvAllUsers.DataSource = table;

            dgvAllUsers.Columns["id"].HeaderText = "ID";
            dgvAllUsers.Columns["cars_id"].HeaderText = "ID машины";
            dgvAllUsers.Columns["client_id"].HeaderText = "ID клиента";
            dgvAllUsers.Columns["start_date"].HeaderText = "Дата начало";
            dgvAllUsers.Columns["end_date"].HeaderText = "Дата завершения";
            dgvAllUsers.Columns["status_id"].HeaderText = "ID статуса";
        }
    }
}
