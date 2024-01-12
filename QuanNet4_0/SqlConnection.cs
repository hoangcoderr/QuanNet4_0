using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
namespace QuanNet4_0
{
    internal class SqlConnection
    {


        public static void sqlConnect(MySqlConnection mySqlConnection)
        {
            
            try
            {
                mySqlConnection.Open();
                Console.WriteLine("Connected to database");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: "+ex.Message, "Failed");
            }
        }
        public static void sqlClose(MySqlConnection mySqlConnection)
        {
            try
            {
                mySqlConnection.Close();
                Console.WriteLine("Disonnected");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex.Message, "Failed");
            }
        }
    }

}
