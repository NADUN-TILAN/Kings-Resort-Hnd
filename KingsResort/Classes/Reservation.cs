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
    public class Reservation
    {
        public int ReservationId { get; set; }
        public string Date { get; set; }
        public string Time { get; set; }
        public string CheckIn { get; set; }
        public string CheckOut { get; set; }
        public int CustomerId { get; set; }
        public int RoomId { get; set; }

        DatabaseConnection dbConnect = new DatabaseConnection();
        string query;


        public void Add()
        {
            query = "insert into reservation (date, time, check_in, check_out, customer_id, room_id) ";
            query += " values ('" + Date + "', '" + Time + "', '" + CheckIn + "', '" + CheckOut + "', " + CustomerId + ", " + RoomId + "); ";
            query += " update room set status = 'Busy' where room_id = " + RoomId + "";
            dbConnect.Set(query, "Reservation added Successfully");
        }

        public void Update()
        {
            query = "update reservation set date = '" + Date + "', time = '" + Time + "', check_in = '" + CheckIn + "', check_out = '" + CheckOut + "', ";
            query += "customer_id = " + CustomerId + ", room_id = " + RoomId + "";
            query += " where reservation_id = " + ReservationId + "; update room inner join reservation on room.room_id = reservation.room_id set status = 'Busy'; ";
            //query += " update room inner join reservation on room.room_id <> reservation.room_id set room.status = 'Free'";
            //  query += " where room.room_id = reservation.room_id" ;

            dbConnect.Set(query, "Reservation Updated Sucessfully");
        }

        public void Delete()
        {
            query  = "delete from reservation where reservation_id = " + ReservationId + ";";
            query += "update room set status = 'Free' where room_id = "+RoomId+"  ";

            dbConnect.Set(query, "Reservation Deleted Successfully");
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

        public DataSet FillData()
        {
            query = "select * from reservation";
            DataSet data = dbConnect.Get(query);
            return data;
        }
    }
}
