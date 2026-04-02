using System;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Windows.Forms;

namespace ISCarRental.Forms
{
    public partial class PaymentForm : Form
    {
        private readonly int _rentalId;

        public PaymentForm(int rentalId)
        {
            InitializeComponent();
            _rentalId = rentalId;
        }

        private void PaymentForm_Load(object sender, EventArgs e)
        {
            btnPay.BackColor = Color.FromArgb(13, 110, 253);
            btnPay.ForeColor = Color.White;
            btnPay.FlatStyle = FlatStyle.Flat;
            btnPay.FlatAppearance.BorderSize = 0;

            txtRentalId.Text = _rentalId.ToString();

            LoadPaymentMethods();
            LoadRentalInfo();
        }

        private void LoadPaymentMethods()
        {
            string sql = "SELECT id, method_name FROM PaymentMethods ORDER BY id";
            DataTable dt = Database.ExecuteQuery(sql);

            cmbPaymentMethod.DataSource = dt;
            cmbPaymentMethod.DisplayMember = "method_name";
            cmbPaymentMethod.ValueMember = "id";
            cmbPaymentMethod.SelectedIndex = -1;
        }

        private void LoadRentalInfo()
        {
            string sql = @"
                SELECT total_price, payment_status
                FROM Rentals
                WHERE id = ?";

            DataTable dt = Database.ExecuteQuery(
                sql,
                CreateIntParameter("@id", _rentalId)
            );

            if (dt.Rows.Count == 0)
            {
                MessageBox.Show("Аренда не найдена.");
                Close();
                return;
            }

            lblTotalPriceValue.Text = Convert.ToDecimal(dt.Rows[0]["total_price"]).ToString("0.##");
            lblCurrentPaymentStatusValue.Text = dt.Rows[0]["payment_status"].ToString();
        }

        private void btnPay_Click(object sender, EventArgs e)
        {
            try
            {
                if (cmbPaymentMethod.SelectedValue == null)
                {
                    MessageBox.Show("Выберите метод оплаты.");
                    return;
                }

                if (!decimal.TryParse(txtAmount.Text.Trim(), out decimal amount))
                {
                    MessageBox.Show("Введите корректную сумму.");
                    return;
                }

                if (amount <= 0)
                {
                    MessageBox.Show("Сумма должна быть больше нуля.");
                    return;
                }

                int paymentMethodId;
                try
                {
                    paymentMethodId = Convert.ToInt32(cmbPaymentMethod.SelectedValue);
                }
                catch
                {
                    MessageBox.Show("Ошибка выбора метода оплаты.");
                    return;
                }

                string insertSql = @"
                    INSERT INTO Payments
                    (rental_id, amount, payment_date, payment_method_id, [status])
                    VALUES (?, ?, ?, ?, ?)";

                Database.ExecuteNonQuery(
                    insertSql,
                    CreateIntParameter("@rental_id", _rentalId),
                    CreateCurrencyParameter("@amount", amount),
                    CreateDateParameter("@payment_date", DateTime.Now),
                    CreateIntParameter("@payment_method_id", paymentMethodId),
                    CreateTextParameter("@status", "Оплачено")
                );

                UpdateRentalPaymentStatus(_rentalId);

                MessageBox.Show("Оплата успешно добавлена.");
                DialogResult = DialogResult.OK;
                Close();
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
                CreateIntParameter("@id", rentalId)
            );

            if (rentalDt.Rows.Count == 0)
                return;

            decimal totalPrice = Convert.ToDecimal(rentalDt.Rows[0]["total_price"]);

            DataTable paidDt = Database.ExecuteQuery(
                "SELECT SUM(amount) AS total_paid FROM Payments WHERE rental_id = ?",
                CreateIntParameter("@rental_id", rentalId)
            );

            decimal totalPaid = 0m;

            if (paidDt.Rows.Count > 0 && paidDt.Rows[0]["total_paid"] != DBNull.Value)
                totalPaid = Convert.ToDecimal(paidDt.Rows[0]["total_paid"]);

            string paymentStatus;

            if (totalPaid == 0)
                paymentStatus = "Не оплачено";
            else if (totalPaid < totalPrice)
                paymentStatus = "Частично оплачено";
            else
                paymentStatus = "Оплачено";

            Database.ExecuteNonQuery(
                "UPDATE Rentals SET payment_status = ? WHERE id = ?",
                CreateTextParameter("@payment_status", paymentStatus),
                CreateIntParameter("@id", rentalId)
            );
        }

        private OleDbParameter CreateIntParameter(string name, int value)
        {
            return new OleDbParameter(name, OleDbType.Integer) { Value = value };
        }

        private OleDbParameter CreateCurrencyParameter(string name, decimal value)
        {
            return new OleDbParameter(name, OleDbType.Currency) { Value = value };
        }

        private OleDbParameter CreateDateParameter(string name, DateTime value)
        {
            return new OleDbParameter(name, OleDbType.Date) { Value = value };
        }

        private OleDbParameter CreateTextParameter(string name, string value)
        {
            return new OleDbParameter(name, OleDbType.VarWChar) { Value = value };
        }
    }
}