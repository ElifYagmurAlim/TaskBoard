using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLibrary
{
    public class Database
    {
        //Her sorgu oluşturduğumuzda veritabanı ilişkilerinden yararlanacağız.
        public static SqlConnection GetConnection()
        {
            SqlConnection connection = new SqlConnection("Data Source=DESKTOP-1LIQG8I;Initial Catalog=Cards;Integrated Security=True");

            return connection;
        }
    }
}
