using System;
using Microsoft.Data.SqlClient;
namespace Database_Operation
{
    class InsertStatement
    {
        static void Main()
        {
            Insert();
            Console.ReadKey();
        }

        static void Insert()
        {
            string constr;
            SqlConnection conn;
            string connectionString = "Server=DESKTOP-DI70DQQ\\SQLEXPRESS;Database=Demodb;User Id=LoginMoi;Password=Dangdat24@;TrustServerCertificate=True;";
            conn = new SqlConnection(connectionString);
            conn.Open();
            SqlCommand cmd;
            SqlDataAdapter adap = new SqlDataAdapter();
            string sql = "";
            sql = "insert into demo values(4, 'Python')";
            cmd = new SqlCommand(sql, conn);
            adap.InsertCommand = new SqlCommand(sql, conn);
            adap.InsertCommand.ExecuteNonQuery();
            cmd.Dispose();
            conn.Close();
            Console.WriteLine("sql");
        }
    }
}