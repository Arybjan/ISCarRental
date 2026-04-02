using System;
using System.Data;
using System.Data.OleDb;
using System.Windows.Forms;

namespace ISCarRental.Forms
{
    public partial class PaymentForm : Form
    {
        private int _rentalId;

        public PaymentForm(int rentalId)
        {
            InitializeComponent();
            _rentalId = rentalId;
        }

        private void PaymentForm_Load(object sender, EventArgs e)
        {
            LoadPaymentMethods();
            txtRentalId.Text = _rentalId.ToString();
        }

        private void LoadPaymentMethods()
        {
            string sql = "SELECT id, method_name FROM PaymentMethods";
            DataTable dt = Database.ExecuteQuery(sql);

            cmbPaymentMethod.DataSource = dt;
            cmbPaymentMethod.DisplayMember = "method_name";
            cmbPaymentMethod.ValueMember = "id";
        }

        private void btnPay_Click(object sender, EventArgs e)
        {
            try
            {
                int rentalId = _rentalId;
                int paymentMethodId = Convert.ToInt32(cmbPaymentMethod.SelectedValue);
                decimal amount = Convert.ToDecimal(txtAmount.Text);

                if (amount <= 0)
                {
                    MessageBox.Show("Сумма должна быть больше 0");
                    return;
                }

                Database.ExecuteNonQuery(
                    "INSERT INTO Payments (rental_id, payment_method_id, payment_date, amount, payment_status, comment) VALUES (?, ?, ?, ?, ?, ?)",
                    new OleDbParameter("@rental_id", rentalId),
                    new OleDbParameter("@payment_method_id", paymentMethodId),
                    new OleDbParameter("@payment_date", DateTime.Now),
                    new OleDbParameter("@amount", amount),
                    new OleDbParameter("@payment_status", "Оплачено"),
                    new OleDbParameter("@comment", "")
                );

                UpdateRentalPaymentStatus(rentalId);

                MessageBox.Show("Оплата успешно выполнена!");
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка при оплате: " + ex.Message);
            }
        }

        private void UpdateRentalPaymentStatus(int rentalId)
        {
            DataTable rentalDt = Database.ExecuteQuery(
                "SELECT total_price FROM Rentals WHERE id = ?",
                new OleDbParameter("@id", rentalId)
            );

            if (rentalDt.Rows.Count == 0)
            {
                MessageBox.Show("Аренда не найдена.");
                return;
            }

            decimal totalPrice = Convert.ToDecimal(rentalDt.Rows[0]["total_price"]);

            DataTable paidDt = Database.ExecuteQuery(
                "SELECT SUM(amount) AS total_paid FROM Payments WHERE rental_id = ?",
                new OleDbParameter("@rental_id", rentalId)
            );

            decimal totalPaid = 0;

            if (paidDt.Rows.Count > 0 && paidDt.Rows[0]["total_paid"] != DBNull.Value)
            {
                totalPaid = Convert.ToDecimal(paidDt.Rows[0]["total_paid"]);
            }

            string status;

            if (totalPaid == 0)
                status = "Не оплачено";
            else if (totalPaid < totalPrice)
                status = "Частично оплачено";
            else
                status = "Оплачено";

            Database.ExecuteNonQuery(
                "UPDATE Rentals SET payment_status = ? WHERE id = ?",
                new OleDbParameter("@payment_status", status),
                new OleDbParameter("@id", rentalId)
            );
        }
    }
}