using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KingsResort.Classes
{
    public class Room
    {
        public int RoomId { get; set; }
        public string RoomNo { get; set; }
        public int Floor { get; set; }
        public string Type { get; set; }
        public double Amount { get; set; }

        DatabaseConnection dbConnect = new DatabaseConnection();
        string query;

        public void Add()
        {
            query = "insert into room (room_no, floor, type, amount) values ('"+RoomNo+"', "+Floor+", '"+Type+"', "+Amount+")";
            dbConnect.Set(query,"Room Added Successfully");
        }

        public void Update()
        {
            query = "update room set room_no = '"+RoomNo+"', floor = "+Floor+", type = '"+Type+"', amount = "+Amount+" where room_id = "+RoomId+"";
            dbConnect.Set(query,"Room Updated Successfully");
        }

        public void Delete()
        {
            query = "delete from room where room_id = "+RoomId+"";
            dbConnect.Set(query, "Room Deleted Successfully");
        }

        public DataSet FillData()
        {
            query = "select * from room order by amount";
            DataSet data = dbConnect.Get(query);
            return data;
        }
    }
}
