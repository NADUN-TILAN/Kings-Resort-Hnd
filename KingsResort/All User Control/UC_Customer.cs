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
    public partial class UC_Customer : UserControl
    {
        Customer customer;
        public UC_Customer()
        {
            InitializeComponent();
            customer = new Customer();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
        int customer_id;
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            customer_id = int.Parse(dataGridView1.SelectedRows[0].Cells[0].Value.ToString());
            txtFirstName.Text   = dataGridView1.SelectedRows[0].Cells[1].Value.ToString();
            txtLastName.Text    = dataGridView1.SelectedRows[0].Cells[2].Value.ToString();
            cmbSex.Text         = dataGridView1.SelectedRows[0].Cells[3].Value.ToString();
            txtEmail.Text       = dataGridView1.SelectedRows[0].Cells[4].Value.ToString();
            txtNo.Text          = dataGridView1.SelectedRows[0].Cells[5].Value.ToString();
            txtStreet.Text      = dataGridView1.SelectedRows[0].Cells[6].Value.ToString();
            txtCity.Text        = dataGridView1.SelectedRows[0].Cells[7].Value.ToString();
            txtCountry.Text     = dataGridView1.SelectedRows[0].Cells[8].Value.ToString();
            txtPhone1.Text      = dataGridView1.SelectedRows[0].Cells[9].Value.ToString();
        }

        private void UC_Customer_Load(object sender, EventArgs e)
        {
            var data = customer.FillData();
            dataGridView1.DataSource = data.Tables[0];
        }

        public void Refersh()
        {
            txtFirstName.Clear();
            txtLastName.Clear();
            cmbSex.SelectedIndex = -1;
            txtEmail.Clear();
            txtNo.Clear();
            txtStreet.Clear();
            txtCity.Clear();
            txtCountry.Clear();
            txtPhone1.Clear();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {

            if (txtFirstName.Text != "" && txtLastName.Text != "" && cmbSex.Text != "" && txtEmail.Text != "" &&
                txtNo.Text != "" && txtStreet.Text != "" && txtCity.Text != "" && txtCountry.Text != "" && txtPhone1.Text != "")
            {
                customer.FirstName = txtFirstName.Text;
                customer.LastName = txtLastName.Text;
                customer.Sex = cmbSex.Text;
                customer.Email = txtEmail.Text;
                customer.No = txtNo.Text;
                customer.Street = txtStreet.Text;
                customer.City = txtCity.Text;
                customer.Country = txtCountry.Text;
                customer.Phone = txtPhone1.Text;

                customer.AddCustomer();
                UC_Customer_Load(this, null);
                Refersh();
            }
            else
            {
                MessageBox.Show("Fill All Fields.", "Warning!!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void UC_Customer_Enter(object sender, EventArgs e)
        {
            UC_Customer_Load(this, null);
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (txtFirstName.Text != "" && txtLastName.Text != "" && cmbSex.Text != "" && txtEmail.Text != "" &&
                 txtNo.Text != "" && txtStreet.Text != "" && txtCity.Text != "" && txtCountry.Text != "" && txtPhone1.Text != "")
            {
                customer.CustomerId = customer_id;
                customer.FirstName = txtFirstName.Text;
                customer.LastName = txtLastName.Text;
                customer.Sex = cmbSex.Text;
                customer.Email = txtEmail.Text;
                customer.No = txtNo.Text;
                customer.Street = txtStreet.Text;
                customer.City = txtCity.Text;
                customer.Country = txtCountry.Text;
                customer.Phone = txtPhone1.Text;

                customer.Update();

                UC_Customer_Load(this, null);
                Refersh();
            }
            else
            {
                MessageBox.Show("No Customer Selected.", "Warning!!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (txtFirstName.Text != "" && txtLastName.Text != "" && cmbSex.Text != "" && txtEmail.Text != "" &&
                 txtNo.Text != "" && txtStreet.Text != "" && txtCity.Text != "" && txtCountry.Text != "" && txtPhone1.Text != "")
            {
                customer.CustomerId = customer_id;
                customer.FirstName = txtFirstName.Text;
                customer.LastName = txtLastName.Text;
                customer.Sex = cmbSex.Text;
                customer.Email = txtEmail.Text;
                customer.No = txtNo.Text;
                customer.Street = txtStreet.Text;
                customer.City = txtCity.Text;
                customer.Country = txtCountry.Text;
                customer.Phone = txtPhone1.Text;

                customer.Delete();

                UC_Customer_Load(this, null);
                Refersh();
            }
            else
            {
                MessageBox.Show("No Customer Selected.", "Warning!!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void UC_Customer_Click(object sender, EventArgs e)
        {
        }
    }
}
