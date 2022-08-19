
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;

namespace ConnectedSql_Parameter
{
    internal class Program
    {
        static void Main(string[] args)
        {
            InputEncoding = Encoding.Unicode;
            OutputEncoding = Encoding.Unicode;

            var conString = "Data Source=DESKTOP-COBOVKQ;Initial Catalog =BtFa11;Integrated Security=True";
            var connection = new SqlConnection(conString);

            var queryString = "Select* from dmkh where ten_kh = @TenKh";
            var updateString = "Update dmct set ten_ct = @TenCt where ma_ct = 1";
            SqlCommand command1 = new SqlCommand(updateString, connection);
            SqlCommand command = new SqlCommand(queryString, connection);
            Write("Nhập mã chương trình cần update ");
            var ma = ReadLine();

            Write(" Nhập tên khách hàng cần tìm: ");
            var ten = ReadLine();

            command.Parameters.AddWithValue("TenKh", ten);

            connection.Open();

            var reader = command.ExecuteReader(CommandBehavior.CloseConnection);
            if(reader.HasRows)
            {
                while(reader.Read())
                {
                    var maKh = reader["ma_kh"];
                    var tenKh = reader["ten_kh"];
                    var diachi = reader["dia_chi"];

                    WriteLine("Thông tin khách hàng: " + maKh + " - " + tenKh + " - " + diachi);
                }
            }
            else
            {
                WriteLine("Thông tin khách hàng không được tìm thấy");
            }



        }
    }
}
