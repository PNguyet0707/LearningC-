using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Configuration;
using static System.Console;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;

namespace bai3
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            InputEncoding = Encoding.Unicode;
            OutputEncoding = Encoding.Unicode;

            //connection.Open();
            //var reader = command.ExecuteReader(CommandBehavior.CloseConnection);
            //int[] listMa = new int[7];
            //string[] listHoten = new string[7];
            //string[] listDiaChi = new string[7];
            //var i = 0;
            //if (reader.HasRows)
            //{
            //    while (reader.Read())
            //    {
            //        listMa[i] = reader.GetInt32(0);
            //        listHoten[i] = reader.GetString(1);
            //        listDiaChi[i] = reader.GetString(3);
            //        i++;
            //    }
            //}
            //for (int j = 0; j < 7; j++)
            //{
            //    WriteLine(listMa[j] + "-" + listHoten[j] + "-" + listDiaChi[j]);
            //}
            //connection.Close();
            //ListViewKhachHang.ItemsSource = listHoten;


           

        }

        private void BtnXem_Click(object sender, RoutedEventArgs e)
        {
            var conString = "Data Source=DESKTOP-COBOVKQ;Initial Catalog =BtFa11;Integrated Security=True";
            var connection = new SqlConnection(conString);
            var database = comboBox2.Text;
            string queryString = "";
            if(database == "dmkh")
            {
                queryString = "Select * from dmkh";

            }
            else
            {
                 queryString = "Select * from dmct";

            }
            var command = new SqlCommand(queryString, connection);
            connection.Open();
            //Create a SqlDataAdapter for the Khach Hang table.
            SqlDataAdapter adapter = new SqlDataAdapter();
            command.CommandType = CommandType.Text;

            // A table mapping names the DataTable.
            adapter.TableMappings.Add("Table", "data");
            // Set the SqlDataAdapter's SelectCommand.
            adapter.SelectCommand = command;

            // Fill the DataSet.
            DataSet dataSet = new DataSet("data");
            adapter.Fill(dataSet);
            ListViewKhachHang.DataContext = dataSet.Tables[0].DefaultView;
            //MessageBox.Show();
        }

       
    }
}
   
