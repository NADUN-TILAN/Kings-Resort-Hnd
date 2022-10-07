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
    public partial class UC_Room : UserControl
    {
        Room room;
        public UC_Room()
        {
            InitializeComponent();
            room = new Room();
        }

        public void Reset()
        {
            txtRoomNo.Clear();
            txtRoomType.Clear();
            txtRate.Clear();
            txtFloor.Clear();
        }
        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtRoomNo.Text != "" && txtFloor.Text != "" && txtRoomType.Text != "" && txtRate.Text != "")
                {
                    room.RoomNo = txtRoomNo.Text;
                    room.Floor = int.Parse(txtFloor.Text.ToString());
                    room.Type = txtRoomType.Text;
                    room.Amount = int.Parse(txtRate.Text.ToString());

                    room.Add();
                    UC_Room_Load(this, null);
                    Reset();
                }
                else
                {
                    MessageBox.Show("Fill all the fields", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception)
            {
                    MessageBox.Show("Only numbers can be entered in floor and amount fields", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

        }

        private void UC_Room_Load(object sender, EventArgs e)
        {
            var data = room.FillData();
            dataGridView2.DataSource = data.Tables[0];
        }

        int room_id;
        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            room_id            = int.Parse(dataGridView2.SelectedRows[0].Cells[0].Value.ToString());
            txtRoomNo.Text     = dataGridView2.SelectedRows[0].Cells[1].Value.ToString();
            txtFloor.Text      = dataGridView2.SelectedRows[0].Cells[2].Value.ToString();
            txtRoomType.Text   = dataGridView2.SelectedRows[0].Cells[3].Value.ToString();
            txtRate.Text       = dataGridView2.SelectedRows[0].Cells[4].Value.ToString();
        }

        private void dataGridView2_Enter(object sender, EventArgs e)
        {
            UC_Room_Load(this, null);
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtRoomNo.Text != "" && txtFloor.Text != "" && txtRoomType.Text != "" && txtRate.Text != "")
                {
                    room.RoomId = room_id;
                    room.RoomNo = txtRoomNo.Text;
                    room.Floor = int.Parse(txtFloor.Text.ToString());
                    room.Type = txtRoomType.Text;
                    room.Amount = int.Parse(txtRate.Text.ToString());

                    room.Update();
                    UC_Room_Load(this, null);
                    Reset();
                }
                else
                {
                    MessageBox.Show("No Room Selected", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception)
            {
                    MessageBox.Show("Only numbers can be entered in floor and amount fields", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {

            try
            {
                if (txtRoomNo.Text != "" && txtFloor.Text != "" && txtRoomType.Text != "" && txtRate.Text != "")
                {
                    room.RoomId = room_id;
                    room.RoomNo = txtRoomNo.Text;
                    room.Floor = int.Parse(txtFloor.Text.ToString());
                    room.Type = txtRoomType.Text;
                    room.Amount = int.Parse(txtRate.Text.ToString());

                    room.Delete();
                    UC_Room_Load(this, null);
                    Reset();
                }
                else
                {
                    MessageBox.Show("No Room Selected", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Only numbers can be entered in floor and amount fields", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

        }
    }
}
