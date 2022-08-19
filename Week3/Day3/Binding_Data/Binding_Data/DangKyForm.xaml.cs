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
    /// Interaction logic for InsertKh.xaml
    /// </summary>
    public partial class DangKyForm : Window
    {
        public DangKyForm()
        {
            InitializeComponent();
        }

        public void InsertTv(int id, string ten, string diachi, string dob, string taikhoan, string pass)
        {
            CConnection con = new CConnection();
            var command = con.ConnectDatabase();
            command.Connection.Open();
            var queryString = "insert into  member  values(@MaTv, @TenTv,@DiaChi, @NgaySinh, @TaiKhoan,@MatKhau )";
            command.CommandText = queryString;



            command.Parameters.AddWithValue("MaTv", id);
            command.Parameters.AddWithValue("TenTv", ten);
            command.Parameters.AddWithValue("Diachi", diachi);
            command.Parameters.AddWithValue("NgaySinh", dob);
            command.Parameters.AddWithValue("TaiKhoan", taikhoan);
            command.Parameters.AddWithValue("MatKhau", pass);


            command.ExecuteNonQuery();

        }


        private void BtnInsertTv_Click(object sender, RoutedEventArgs e)
        {
            //Button btn = sender as Button;
            //DataView dv = Insertmem.ItemsSource as DataView;
            //DataRowView drv = btn.DataContext as DataRowView;
            int id = Convert.ToInt32(Inid.Text);
            var ten = Inname.Text;
            var diachi = Indiachi.Text;
            var dob = Inns.Text;
            var taikhoan = Intk.Text;
            var matkhau = Inpass.Text;
            InsertTv(id, ten, diachi, dob, taikhoan, matkhau);
            MessageBox.Show("Register  thành công ");



        }
    }
}
