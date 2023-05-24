using StudyPractice.Models;
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
    /// Логика взаимодействия для ProviderPage.xaml
    /// </summary>
    public partial class ProviderPage : Page
    {
        public ProviderPage()
        {
            InitializeComponent();
        }

        private void BAdd_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new ProviderEditPage(new Provider()));
        }

        private void BEdit_Click(object sender, RoutedEventArgs e)
        {
            var selectedProv = DGProvider.SelectedItem as Provider;
            if (selectedProv == null)
            {
                MessageBox.Show("Select");
                return;
            }
            NavigationService.Navigate(new ProviderEditPage(selectedProv));
        }

        private void Page_Loaded(object sender, RoutedEventArgs e)
        {
            DGProvider.ItemsSource = App.db.Provider.ToList();
        }
    }
}
