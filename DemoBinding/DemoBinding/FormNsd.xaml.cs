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
using System.Windows.Shapes;

namespace DemoBinding
{
    /// <summary>
    /// Interaction logic for Window1.xaml
    /// </summary>
    public partial class FormNsd : Window
    {
        public FormNsd()
        {
            InitializeComponent();
        }

        private void btnNhan_Click(object sender, RoutedEventArgs e)
        {
            string text = string.Format("Người dùng: {0}\nMật khẩu: {1}", txtName.Text, txtPass.Password);
            MessageBox.Show(text);
            DialogResult = true;

        }
        private void btnHuy_Click(object sender, RoutedEventArgs e)
        {
            DialogResult = false;
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            Nsd nsd = DataContext as Nsd;
            txtPass.Password = nsd.Password;
        }
    }
}
