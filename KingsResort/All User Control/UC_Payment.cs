using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using KingsResort.Classes;

namespace KingsResort.All_User_Control
{
    public partial class UC_Payment : UserControl
    {
        Payment payment;
        string query;
        public UC_Payment()
        {
            InitializeComponent();
            payment = new Payment();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void UC_Payment_Load(object sender, EventArgs e)
        {
            txtReservationId.Items.Clear();
            txtPaymentType.Items.Clear();

            query = "SELECT reservation.reservation_id FROM reservation HAVING reservation.reservation_id NOT IN ";
            query += "(SELECT reservation.reservation_id FROM reservation INNER JOIN payment ON payment.reservation_id = reservation.reservation_id) ";
            payment.setComboBox(query,txtReservationId);

            query = "select payment_type from payment_type";
            payment.setComboBox(query,txtPaymentType);

            var data = payment.FillData("select * from payment");
            dataGridView4.DataSource = data.Tables[0];

        }

        double fullAmount;
        private void txtReservationId_SelectedIndexChanged(object sender, EventArgs e)
        {
            query = "SELECT customer.first_name, customer.last_name, check_in, check_out FROM customer ";
            query += " INNER JOIN reservation ON customer.customer_id = reservation.customer_id ";
            query += " where reservation.reservation_id = "+txtReservationId.Text+"";
            var data = payment.FillData(query);

            txtFirstName.Text = data.Tables[0].Rows[0][0].ToString();
            txtLastName.Text = data.Tables[0].Rows[0][1].ToString();

            DateTime checkOut = Convert.ToDateTime(data.Tables[0].Rows[0][3]);
            DateTime checkIn = Convert.ToDateTime(data.Tables[0].Rows[0][2]);

            float date = (checkOut - checkIn).Days;

            query = "select room.amount from room inner join reservation on ";
            query +=" room.room_id = reservation.room_id where reservation.reservation_id = "+txtReservationId.Text+"";

            data = payment.FillData(query);

            double amount = double.Parse(data.Tables[0].Rows[0][0].ToString());

            fullAmount = (date * amount);
            txtFullAmount.Text = "Rs. " + fullAmount.ToString();

        }

        private void btnPaymentType_Click(object sender, EventArgs e)
        {

        }
        double Discount;
        int payment_type_id;
        private void txtPaymentType_SelectedIndexChanged(object sender, EventArgs e)
        {
            query = "select discount,payment_type,type_id from payment_type where payment_type = '" + txtPaymentType.Text + "'";
            var data = payment.FillData(query);

            payment_type_id = int.Parse(data.Tables[0].Rows[0][2].ToString());
            string payment_type = data.Tables[0].Rows[0][1].ToString();
            double discount = double.Parse(data.Tables[0].Rows[0][0].ToString());

            if (txtPaymentType.Text == payment_type)
            {
                Discount = fullAmount * (discount / 100);
                txtDiscount.Text = Discount.ToString();
            }

            double amount = fullAmount - Discount;
            txtAmount.Text = amount.ToString();
            
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (txtReservationId.Text != "" && txtPaymentType.Text != "")
            {
                payment.FirstName = txtFirstName.Text;
                payment.LastName = txtLastName.Text;
                payment.Amount = double.Parse(txtAmount.Text);
                payment.PaymentTypeId = payment_type_id;
                payment.ReservationId = int.Parse(txtReservationId.Text);

                payment.Add();
                txtReservationId.ResetText();
                txtPaymentType.ResetText();
                UC_Payment_Load(this, null);
                Clear();
            }
            else
            {
                MessageBox.Show("Check the fields","Message",MessageBoxButtons.OK,MessageBoxIcon.Warning);
            }

        }

        public void Clear()
        {
            txtReservationId.SelectedIndex = -1;
            txtFirstName.Clear();
            txtLastName.Clear();
            txtFullAmount.Clear();
            txtPaymentType.SelectedIndex = -1;
            txtDiscount.Clear();
            txtAmount.Clear();
        }

        private void UC_Payment_Enter(object sender, EventArgs e)
        {
            UC_Payment_Load(this, null);
        }
    }
}
