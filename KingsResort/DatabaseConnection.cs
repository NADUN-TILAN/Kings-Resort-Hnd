using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Data;
using System.Windows.Forms;
namespace KingsResort
{
    public class DatabaseConnection
    {
        protected MySqlConnection GetConnection()
        {
            MySqlConnection connect = new MySqlConnection();
            connect.ConnectionString = "data source=127.0.0.1;port=3306;username=root;password=;database=kings_resort; convert zero datetime=True";
            return connect;
        }

        public DataSet Get(string query)
        {
            MySqlConnection connect = GetConnection();
            MySqlCommand cmd = new MySqlCommand();
            cmd.Connection = connect;
            cmd.CommandText = query;
            MySqlDataAdapter da = new MySqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            da.Fill(ds);
            return ds;
        }

        public void Set(string query, string message)
        {
            MySqlConnection connect = GetConnection();
            MySqlCommand cmd = new MySqlCommand();
            cmd.Connection = connect;
            connect.Open();
            cmd.CommandText = query;
            cmd.ExecuteNonQuery();
            connect.Close();

            MessageBox.Show("'" + message + "'", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        public MySqlDataReader Combo(string query)
        {
            MySqlConnection connect = GetConnection();
            MySqlCommand cmd = new MySqlCommand();
            cmd.Connection = connect;
            connect.Open();
            cmd = new MySqlCommand(query, connect);
            MySqlDataReader sdr = cmd.ExecuteReader();
            return sdr;
        }

        public int GetId(string query)
        {
            MySqlConnection connect = GetConnection();
            MySqlCommand cmd = new MySqlCommand();
            cmd.Connection = connect;
            connect.Open();
            cmd.CommandText = query;
            cmd.ExecuteNonQuery();
            int getId = int.Parse(cmd.LastInsertedId.ToString());
            connect.Close();
            return getId;
        }
    }
}
