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

namespace Listbox_Bts
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        bool SelectedRM;
        bool SelectedJin;
        bool SelectedSuga;
        bool SelectedJhope;
        bool SelectedJimin;
        bool SelectedV;
        bool SelectedJK;

        public MainWindow()
        {
            InitializeComponent();
            SelectedRM = false;
            SelectedJin = false;
            SelectedSuga = false;
            SelectedJhope = false;
            SelectedJimin = false;
            SelectedV = false;
            SelectedJK = false;
        }


        private void HandleUnchecked(object sender, RoutedEventArgs e)
        {
            if (sender.Equals(chkRm))
                SelectedRM = false;
            if (sender.Equals(chkJin))
                SelectedJin = false;
            if (sender.Equals(chkSuga))
                SelectedSuga = false;
            if (sender.Equals(chkJHope))
                SelectedJhope = false;
            if (sender.Equals(chkJiMin))
                SelectedJimin = false;
            if (sender.Equals(chkV))
                SelectedV = false;
            if (sender.Equals(chkJk))
                SelectedJK = false;

        }
        private void HandleChecked(object sender, RoutedEventArgs e)
        {


            if (sender.Equals(chkRm))
                SelectedRM = true;
            if (sender.Equals(chkJin))
                SelectedJin = true;
            if (sender.Equals(chkSuga))
                SelectedSuga = true;
            if (sender.Equals(chkJHope))
                SelectedJhope = true;
            if (sender.Equals(chkJiMin))
                SelectedJimin = true;
            if (sender.Equals(chkV))
                SelectedV = true;
            if (sender.Equals(chkJk))
                SelectedJK = true;





        }

        private void DislayCustomerChoices(object sender, RoutedEventArgs e)
        {
            String choices = " Bạn đã chọn: ";
            bool selected = false;
            //
            if (SelectedRM)
            {
                choices += "Kim Nam Joon";
                selected = true;
            }
            //
            if (SelectedJin)
            {
                choices += " Kim Seok Jin";
                selected = true;
            }
            //
            if (SelectedSuga)
            {
               
                choices += " Min Yun Gi;  ";
                selected = true;
            }
            //
            if (SelectedJhope)
            {
                choices += "Jung Ho Seok ;";
                selected = true;
            }
            if (SelectedJimin)
            {
                choices += "Park Jimin;";
                selected = true;
            }
            if (SelectedV)
            {
                choices += "Kim Tae Hyung ;";
                selected = true;

            }
            if (SelectedJK)
            {
                choices += "Joen Jung Kook;";
                selected = true;
            }
            //
            if (!selected) choices = "Bạn chưa chọn member nào ";
            //
            MessageBox.Show(choices);
        }
    }

}
    
