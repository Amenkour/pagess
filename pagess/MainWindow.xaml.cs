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

namespace pagess
{
    /// <summary>
    /// Interaktionslogik für MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Clickp1(object sender, RoutedEventArgs e)
        {
            Mm.Content = new Page2();

        }
        private void Button_Clickp2(object sender, RoutedEventArgs e)
        {
            Mm.Content = new Page1();

        }



        private void Main_Navigated(object sender, NavigationEventArgs e)
        {

        }
    }
}
