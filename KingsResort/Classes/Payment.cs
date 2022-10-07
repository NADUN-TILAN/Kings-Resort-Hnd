using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KingsResort.Classes
{
    public class Payment
    {
        public int PaymentId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Status { get; set; }
        public int PaymentTypeId { get; set; }
        public int ReservationId { get; set; }
        public double Amount { get; set; }

        DatabaseConnection dbConnect = new DatabaseConnection();
        string query;


        public void Add()
        {
            query = "insert into payment (first_name, last_name, status, amount, payment_type_id, reservation_id)";
            query += " values('"+FirstName+"', '"+LastName+"', 'Paid', "+Amount+", "+PaymentTypeId+", "+ReservationId+")";
            dbConnect.Set(query,"Payment Recieved Successfully");
        }
        public DataSet FillData(string query)
        {
            DataSet data = dbConnect.Get(query);
            return data;
        }
        public void setComboBox(string query, ComboBox combo)
        {

            MySqlDataReader sdr = dbConnect.Combo(query);
            while (sdr.Read())
            {
                for (int i = 0; i < sdr.FieldCount; i++)
                {
                    combo.Items.Add(sdr.GetString(i));
                }
            }
            sdr.Close();
        }
    }
}
