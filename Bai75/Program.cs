using System;
using Microsoft.Data.SqlClient;
namespace Database_Operation
{
    class UpdateStatement
    {
        // Main Method
        static void Main()
        {
            Update();
            Console.ReadKey();
        }
        static void Update()
        {
            string constr;
            SqlConnection conn;
            string connectionString = "Server=DESKTOP-DI70DQQ\\SQLEXPRESS;Database=Demodb;User Id=LoginMoi;Password=Dangdat24@;TrustServerCertificate=True;";
            conn = new SqlConnection(connectionString);
            conn.Open();
            SqlCommand cmd;
            SqlDataAdapter adap = new SqlDataAdapter();
            string sql = "";
            sql = "update demo set articleName='django' where articleID=3";
            cmd = new SqlCommand(sql, conn);
            adap.InsertCommand = new SqlCommand(sql, conn);
            adap.InsertCommand.ExecuteNonQuery();
            // Đóng các đối tượng
            cmd.Dispose();
            conn.Close();
        }
    }
}