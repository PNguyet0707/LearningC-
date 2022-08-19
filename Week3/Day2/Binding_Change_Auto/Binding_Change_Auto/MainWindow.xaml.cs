using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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

namespace Binding_Change_Auto
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        ObservableCollection<Nsd> dsuser = new ObservableCollection<Nsd>();
        public MainWindow()
        {
            InitializeComponent();
            dsuser.Add(new Nsd() { Id = 1, Name = "Phan Nguyet", Password = "1170" });
            dsuser.Add(new Nsd(2, "NSD1", ""));
            lstNsd.ItemsSource = dsuser;
        }

        private void mnuClose_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void btnThem_Click(object sender, RoutedEventArgs e)
        {
            //MessageBox.Show("Thêm user");
            Nsd nsd = lstNsd.SelectedItem as Nsd;
            FormNsd frm = new FormNsd();
            frm.DataContext = nsd;
            if (frm.ShowDialog() != true)
                return;

            nsd.Name = frm.txtName.Text;
            nsd.Password = frm.txtPass.Password;
        }
    }
}
