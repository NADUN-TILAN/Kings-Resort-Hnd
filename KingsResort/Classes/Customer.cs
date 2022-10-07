using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KingsResort.Classes
{
    public class Customer
    {
        public int CustomerId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Sex { get; set; }
        public string Email { get; set; }
        public string No { get; set; }
        public string Street { get; set; }
        public string City { get; set; }
        public string Country { get; set; }
        public string Phone { get; set; }
        //public string Phone2 { get; set; }

        DatabaseConnection dbConnect = new DatabaseConnection();
        string query;


        public void AddCustomer() {
            query  = "insert into customer (first_name, last_name, sex, email, no, street, city, country, phone)";
            query += " values('"+FirstName+"', '"+LastName+"', '"+Sex+"', '"+Email+"', '"+No+"', '"+Street+"', '"+City+"','"+Country+"', '"+Phone+"')";
            dbConnect.Set(query, "Customer Added Successfully");
        }

        public void Update()
        {
            query  = "update customer set first_name = '" + FirstName + "', last_name = '" + LastName + "', sex = '" + Sex + "', email = '" + Email + "', ";
            query += " no = '"+No+"', street = '"+Street+"', city = '"+City+"', country = '"+Country+"', phone = '"+Phone+"' where customer_id = "+ CustomerId +" ";
            dbConnect.Set(query, "Customer Updated Successfully");
        }

        public void Delete()
        {
            query = "delete from customer where customer_id = "+CustomerId+"";
            dbConnect.Set(query, "Customer Deleted Successfully");
        }
        public DataSet FillData()
        {
            query  = "select * from customer";
            DataSet data = dbConnect.Get(query);
            return data;
        }
    }
}
