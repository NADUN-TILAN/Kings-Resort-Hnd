using KingsResort.All_User_Control;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KingsResort
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            UC_Customer customer = new UC_Customer();
            addUserControl(customer);
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {

        }
        private void addUserControl(UserControl userControl)
        {
            userControl.Dock = DockStyle.Fill;
            panel2.Controls.Clear();
            panel2.Controls.Add(userControl);
            userControl.BringToFront();
        }
        private void customerDetailsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UC_Customer customer = new UC_Customer();
            addUserControl(customer);
        }

        private void roomDetailsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UC_Room room = new UC_Room();
            addUserControl(room);
        }

        private void reservationDetailsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UC_Reservation reservation = new UC_Reservation();
            addUserControl(reservation);
        }

        private void paymentDetailsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UC_Payment payment = new UC_Payment();
            addUserControl(payment);
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void paymentTypeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UC_PaymentType payment_type = new UC_PaymentType();
            addUserControl(payment_type);
        }
    }
}
