
using System;
using System.Text;
using Microsoft.Data.SqlClient;
 namespace Database_Operation
{
    class DBConn
    {
        // Main Method
        static void Main()
        {
            Console.OutputEncoding = Encoding.UTF8;
            Connect();
            Console.ReadKey();
        }

        static void Connect()
        {
            string constr;
            SqlConnection conn;
            constr = @"Data Source=DESKTOP-DI70DQQ\SQLEXPRESS;Initial Catalog=Demodb;User ID=LoginMoi;Password=Dangdat24@;TrustServerCertificate=True;";
            conn = new SqlConnection(constr);
            conn.Open();
            Console.WriteLine("Mở kết nối!");
            // Đóng kết nối
            conn.Close();
        }
    }
}