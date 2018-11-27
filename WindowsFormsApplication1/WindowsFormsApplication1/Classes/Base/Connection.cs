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
            string connectionString = "server=Localhost; database=CatiorosDB; uid=nsf; password=nsf@2018; SslMode=none";
            MySqlConnection connection = new MySqlConnection(connectionString);
            connection.Open();
            return connection;
        }
    }
}
