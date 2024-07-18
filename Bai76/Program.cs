using System;
using Microsoft.Data.SqlClient;
namespace Database_Operation
{
    class DeleteStatement
    {
        // Main Method
        static void Main()
        {
            Delete();
            Console.ReadKey();
        }
        static void Delete()
        {
            string constr;
            SqlConnection conn;
            string connectionString = "Server=DESKTOP-DI70DQQ\\SQLEXPRESS;Database=Demodb;User Id=LoginMoi;Password=Dangdat24@;TrustServerCertificate=True;";
            conn = new SqlConnection(connectionString);
            conn.Open();
            SqlCommand cmd;
            // data adapter object is use to 
            // insert, update or delete commands
            SqlDataAdapter adap = new SqlDataAdapter();
            string sql = "";
            sql = "delete from demo where articleID=3";
            cmd = new SqlCommand(sql, conn);
            adap.InsertCommand = new SqlCommand(sql, conn);
            adap.InsertCommand.ExecuteNonQuery();

            // closing all the objects
            cmd.Dispose();
            conn.Close();
        }
    }
}