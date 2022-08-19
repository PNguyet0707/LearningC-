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

namespace Binding_Data
{
    /// <summary>
    /// Interaction logic for Window1.xaml
    /// </summary>
    public partial class UpdateForm : Window
    {
        public UpdateForm()
        {
            InitializeComponent();
        }

        public void UpdateTv(int id, string ten, string diachi)
        {
            CConnection con = new CConnection();
            var command = con.ConnectDatabase();
            command.Connection.Open();
            var queryString = "update member  set ten_mem = @TenTv,dia_chi = @DiaChi  where ma_mem = @MaTv";
            command.CommandText = queryString;



            command.Parameters.AddWithValue("MaTv", id);
            command.Parameters.AddWithValue("TenTv", ten);
            command.Parameters.AddWithValue("Diachi", diachi);

            command.ExecuteNonQuery();

        }


        private void btn_Update_Click(object sender, RoutedEventArgs e)
        {
            Button btn = sender as Button;
            DataView dv = updateTv.ItemsSource as DataView;
            DataRowView drv = btn.DataContext as DataRowView;
            var id = (int)drv[0];
            var ten = (string)drv[1];
            var diachi = (string)drv[2];
            UpdateTv(id, ten, diachi);
            MessageBox.Show("Update thành công ");



        }

    }
}
