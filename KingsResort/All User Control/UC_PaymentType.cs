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
    public partial class UC_PaymentType : UserControl
    {
        PaymentType payment_type;
        public UC_PaymentType()
        {
            InitializeComponent();
            payment_type = new PaymentType();
        }

        public void Clear()
        {
            txtPaymentType.Clear();
            txtDiscount.Clear();
        }
        private void UC_PaymentType_Load(object sender, EventArgs e)
        {
            var data = payment_type.FillData();
            dataGridView6.DataSource = data.Tables[0];
        }

        private void dataGridView6_Enter(object sender, EventArgs e)
        {
            UC_PaymentType_Load(this, null);
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {

            try
            {
                if (txtPaymentType.Text != "" && txtDiscount.Text != "")
                {
                    payment_type.Payment_Type = txtPaymentType.Text;
                    payment_type.Discount = double.Parse(txtDiscount.Text);

                    payment_type.Add();
                    Clear();
                    UC_PaymentType_Load(this, null);
                }
                else
                {
                    MessageBox.Show("Fill all the fields", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception)
            {
                    MessageBox.Show("Only numbers are allowed", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {

            try
            {
                if (txtPaymentType.Text != "" && txtDiscount.Text != "")
                {
                    payment_type.TypeId = type_id;
                    payment_type.Payment_Type = txtPaymentType.Text;
                    payment_type.Discount = double.Parse(txtDiscount.Text);

                    payment_type.Update();
                    Clear();
                    UC_PaymentType_Load(this, null);
                }
                else
                {
                    MessageBox.Show("No Record Selected", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception)
            {

                MessageBox.Show("Only numbers are allowed", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        int type_id;

        private void dataGridView6_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            type_id = int.Parse(dataGridView6.SelectedRows[0].Cells[0].Value.ToString());
            txtPaymentType.Text = dataGridView6.SelectedRows[0].Cells[1].Value.ToString();
            txtDiscount.Text = dataGridView6.SelectedRows[0].Cells[2].Value.ToString();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {

            try
            {
                if (txtPaymentType.Text != "" && txtDiscount.Text != "")
                {
                    payment_type.TypeId = type_id;
                    payment_type.Payment_Type = txtPaymentType.Text;
                    payment_type.Discount = double.Parse(txtDiscount.Text);

                    payment_type.Delete();
                    Clear();
                    UC_PaymentType_Load(this, null);
                }
                else
                {
                    MessageBox.Show("No Record Selected", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception)
            {

                MessageBox.Show("Only numbers are allowed", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
