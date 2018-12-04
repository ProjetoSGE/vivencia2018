using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication1.Classes.Base
{
     public class Connection
    {
        public MySqlConnection Create()
        {
            string connectionString = "server=Localhost; database=SGEdb; uid=root; password=6122162001; SslMode=none";
            MySqlConnection connection = new MySqlConnection(connectionString);
            connection.Open();
            return connection;
        }
    }
}
