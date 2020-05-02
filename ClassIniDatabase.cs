using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace Klassni_rukovodilel_
{
    class ClassIniDatabase
    {
        SqlConnection connection = new SqlConnection(@"Data Source=DESKTOP-QJJ19PD\SQLEXPRESS;Initial Catalog=KlassRuk;Integrated Security=True"); //это строка подключения базы данных

        public void openConnection()

        {

            if (connection.State == System.Data.ConnectionState.Closed)

                connection.Open();

        }

        public void closeConnection()

        {

            if (connection.State == System.Data.ConnectionState.Open)

                connection.Close();

        }

        public SqlConnection GetConnection()

        {

            return connection;

        }
    }
}
