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


namespace WPF_With_SQL 
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




        }

        DataSet dataSet = new DataSet("data");
        public SqlCommand ConnectDatabase ()
        {
            var conString = "Data Source=DESKTOP-COBOVKQ;Initial Catalog =BtFa11;Integrated Security=True";
            var connection = new SqlConnection(conString);
            var command = new SqlCommand();
            command.Connection = connection;
           
            return command;
        }
        public void DisplayListview ()
        {
            string queryString = "Select * from member";
            //var command = ConnectDatabase();
            CConnection con = new CConnection();
            var command = con.ConnectDatabase();
            command.Connection.Open();
            command.CommandText = queryString;
            //Create a SqlDataAdapter for the Khach Hang table.
            SqlDataAdapter adapter = new SqlDataAdapter();
            command.CommandType = CommandType.Text;

            // A table mapping names the DataTable.
            adapter.TableMappings.Add("Table", "data");
            // Set the SqlDataAdapter's SelectCommand.
            adapter.SelectCommand = command;

            // Fill the DataSet.
            adapter.Fill(dataSet);
            ListViewKhachHang.DataContext = dataSet.Tables[0].DefaultView;
        }

        public void DeleteKh(int id )
        {
            CConnection con = new CConnection();
            var command = con.ConnectDatabase();
            command.Connection.Open();
            var queryString = "delete from member  where ma_mem = @MaTv";
            command.CommandText = queryString;

          
            command.Parameters.AddWithValue("MaTv", id);
            command.ExecuteNonQuery();
            
        }

        
        private void BtnXem_Click(object sender, RoutedEventArgs e)
        {
           DisplayListview();
        }

        private void BtnXoa_Click(object sender, RoutedEventArgs e)
        {
            Button btn = sender as Button;
            DataView dv = ListViewKhachHang.ItemsSource as DataView;
            DataRowView drv = btn.DataContext as DataRowView;
            var id =(int) drv[0];
            DeleteKh(id);
            dv.Table.Rows.Remove(drv.Row);




        }

        private void BtnSua_Click(object sender, RoutedEventArgs e)
        {
            Button btn = sender as Button;
            DataView dv = ListViewKhachHang.ItemsSource as DataView;
            DataRowView drv = btn.DataContext as DataRowView;
            
            UpdateKhForm updateKhForm = new UpdateKhForm();
            updateKhForm.DataContext = drv;
            updateKhForm.ShowDialog();
        }

        private void BtnThem_Click(object sender, RoutedEventArgs e)
        {
            
            InsertKhForm insertKhForm = new InsertKhForm();
            insertKhForm.ShowDialog();

        }
    }
}

