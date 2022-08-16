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

namespace TestBindingListView
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent(); this.InitializeComponent();

            // Initialize a new string array
            string[] colors = {
                "Crimson",
                "Green",
                "Blue",
                "Yellow",
                "Black",
                "Olive",
                "Magenta",
                "Orange",
                "Pink",
            };

            // Data bind the list view with array items
            ListView1.ItemsSource = colors;
        }


        private void ListView1_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            
        }

    }
}
