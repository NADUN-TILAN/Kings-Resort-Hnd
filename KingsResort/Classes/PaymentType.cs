using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KingsResort.Classes
{
    public class PaymentType
    {
        public int TypeId { get; set; }
        public string Payment_Type { get; set; }
        public double Discount { get; set; }

        DatabaseConnection dbConnect = new DatabaseConnection();
        string query;

        public DataSet FillData()
        {
            query = "select * from payment_type";
            DataSet data = dbConnect.Get(query);
            return data;
        }

        public void Add()
        {
            query = "insert into payment_type (payment_type, discount) values ('"+Payment_Type+"', "+Discount+") ";
            dbConnect.Set(query,"Payment Type Added Successfully");
        }
        public void Update()
        {
            query = "update payment_type set payment_type = '" + Payment_Type + "', discount = " + Discount + " where type_id = " + TypeId + "";
            dbConnect.Set(query, "Payment Type Updated Successfully");
        }

        public void Delete()
        {
            query = "delete from payment_type where type_id = " + TypeId + "";
            dbConnect.Set(query,"Payment Type Deleted Successfully");
        }
    }
}
