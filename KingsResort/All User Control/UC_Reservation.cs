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
    public partial class UC_Reservation : UserControl
    {
        Reservation reservation;
        string query;
        public UC_Reservation()
        {
            InitializeComponent();
            reservation = new Reservation();
        }

        int reservation_id;
        private void dataGridView3_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            reservation_id     = int.Parse(dataGridView3.SelectedRows[0].Cells[0].Value.ToString());
            txtDate.Text       = dataGridView3.SelectedRows[0].Cells[1].Value.ToString();
            txtTime.Text       = dataGridView3.SelectedRows[0].Cells[2].Value.ToString();
            txtCheckIn.Text    = dataGridView3.SelectedRows[0].Cells[3].Value.ToString();
            txtCheckOut.Text   = dataGridView3.SelectedRows[0].Cells[4].Value.ToString();
            txtCustomerId.Text = dataGridView3.SelectedRows[0].Cells[5].Value.ToString();
            txtRoomId.Text     = dataGridView3.SelectedRows[0].Cells[6].Value.ToString();

            txtCustomerId.Enabled = false;
            txtRoomId.Enabled = false;
        }

        public void Reset()
        {
            txtCustomerId.SelectedIndex = -1;
            txtRoomId.SelectedIndex = -1;
            txtDate.ResetText();
            txtTime.ResetText();
            txtCheckIn.ResetText();
            txtCheckOut.ResetText();
        }

        private void UC_Reservation_Load(object sender, EventArgs e)
        {
            txtCustomerId.Items.Clear();
            txtRoomId.Items.Clear();

            query = "select customer_id from customer";
            reservation.setComboBox(query,txtCustomerId);

            query = "select room_id from room where status = 'Free'";
           reservation.setComboBox(query,txtRoomId);

            var data = reservation.FillData();
            dataGridView3.DataSource = data.Tables[0];

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (txtCustomerId.Text != "" && txtRoomId.Text != "" && txtDate.Text != "" && txtTime.Text != "" && txtCheckIn.Text != "" && txtCheckOut.Text != "")
            {
                reservation.CustomerId = int.Parse(txtCustomerId.Text);
                reservation.RoomId     = int.Parse(txtRoomId.Text);
                reservation.Date       = txtDate.Text;
                reservation.Time       = txtTime.Text;
                reservation.CheckIn    = txtCheckIn.Text;
                reservation.CheckOut   = txtCheckOut.Text;

                reservation.Add();
                Reset();
                UC_Reservation_Load(this, null);
            }
            else
            {

                MessageBox.Show("Fill all the fields","Warning",MessageBoxButtons.OK,MessageBoxIcon.Warning);
            }
        }

        private void UC_Reservation_Enter(object sender, EventArgs e)
        {
            UC_Reservation_Load(this, null);
        }

        private void txtCustomerId_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void txtRoomId_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void UC_Reservation_MouseClick(object sender, MouseEventArgs e)
        {

        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (txtCustomerId.Text != "" && txtRoomId.Text != "" && txtDate.Text != "" && txtTime.Text != "" && txtCheckIn.Text != "" && txtCheckOut.Text != "")
            {
                reservation.ReservationId = reservation_id;
                reservation.CustomerId = int.Parse(txtCustomerId.Text);
                reservation.RoomId = int.Parse(txtRoomId.Text);
                reservation.Date = txtDate.Text;
                reservation.Time = txtTime.Text;
                reservation.CheckIn = txtCheckIn.Text;
                reservation.CheckOut = txtCheckOut.Text;

                reservation.Update();
                txtRoomId.ResetText();
                Reset();
                UC_Reservation_Load(this, null);
                txtRoomId.Enabled = true;
                txtCustomerId.Enabled = true;
            }
            else
            {

                MessageBox.Show("No field selected", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (txtCustomerId.Text != "" && txtRoomId.Text != "" && txtDate.Text != "" && txtTime.Text != "" && txtCheckIn.Text != "" && txtCheckOut.Text != "")
            {
                reservation.ReservationId = reservation_id;
                reservation.CustomerId = int.Parse(txtCustomerId.Text);
                reservation.RoomId = int.Parse(txtRoomId.Text);
                reservation.Date = txtDate.Text;
                reservation.Time = txtTime.Text;
                reservation.CheckIn = txtCheckIn.Text;
                reservation.CheckOut = txtCheckOut.Text;

                txtRoomId.ResetText();
                reservation.Delete();

                Reset();
                UC_Reservation_Load(this, null);
            }
            else
            {

                MessageBox.Show("No field selected", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
