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
            var queryString = "Select * from dmkh";
            var command = new SqlCommand(queryString, connection);
            connection.Open();
            var reader = command.ExecuteReader(CommandBehavior.CloseConnection);
            int[] listMa = new int[7];
            string[] listHoten = new string[7];
            string[] listDiaChi = new string[7];
            var i = 0;
            if (reader.HasRows)
            {
                while(reader.Read())
                {
                    listMa[i] = reader.GetInt32(0);
                    listHoten[i] = reader.GetString(1);
                    listDiaChi[i] = reader.GetString(3);
                    i++;
                }
            }
            for (int j = 0; j < 7; j++)
            {
                WriteLine(listMa[j] + "-" + listHoten[j] + "-" + listDiaChi[j]);
            }
            connection.Close();

        }
    }
}
