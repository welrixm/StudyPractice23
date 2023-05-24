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

namespace StudyPractice.Pages
{
    /// <summary>
    /// Логика взаимодействия для MarketPage.xaml
    /// </summary>
    public partial class MarketPage : Page
    {
        public MarketPage()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            MainFrane.Navigate(new ProductPage());
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            MainFrane.Navigate(new OrdersPage());
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            MainFrane.Navigate(new ProviderPage());
        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            MainFrane.Navigate(new TypePage());
        }
    }
}
