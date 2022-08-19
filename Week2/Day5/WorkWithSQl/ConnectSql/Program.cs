using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using System.Data.SqlClient;
using static System.Console;
using System.Data;
namespace ConnectSql
{
    internal class Program
    {
        
        static void Main(string[] args)
        {
            InputEncoding = Encoding.Unicode;
            OutputEncoding = Encoding.Unicode;

            var conString = "Data Source=DESKTOP-COBOVKQ;Initial Catalog =BtFa11;Integrated Security=True";
            var connection = new SqlConnection(conString);
            var queryString = "Select count(*) from dmct";
            var updateString = "Update dmct set ma_ct=10 where ma_ct=8";
            var deleteString = "delete from dmct where ma_ct = 1; ";
            //var deleteString = "Delete  dmct  where ma_ct=10";


            var insertString = "insert into dmct values(14,N'Quản lý phòng gym','QLBT',N'Đăk Lăk','2022/1/21','16:00','ct06','2013/6/20','16:00','ct6')";
            var command = new SqlCommand(insertString, connection);
            //var command2 = new SqlCommand(queryString, connection);
            //var command3 = new SqlCommand(updateString, connection);
            //var command4 = new SqlCommand(deleteString, connection);
            connection.Open();
            var count = (int)command.ExecuteNonQuery();
            //var countdong = (int)command2.ExecuteScalar();
            //var countUpdate = (int)command3.ExecuteNonQuery();
            //var countDelete = (int)command4.ExecuteNonQuery();
            WriteLine("Số lượng dòng dữ liệu được insert  " + count);
            //WriteLine("Số lượng dòng dữ liệu trong bảng là   " + countdong);
            //WriteLine("Số lượng dòng dữ liệu được update    " + countUpdate);
            ////WriteLine("Số lượng dòng dữ liệu bị xóa là " + countDelete);

            // Làm việc với tham số 


            connection.Close();
            
        }
    }
}
