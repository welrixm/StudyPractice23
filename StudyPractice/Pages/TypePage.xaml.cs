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
    /// Логика взаимодействия для TypePage.xaml
    /// </summary>
    public partial class TypePage : Page
    {
        public TypePage()
        {
            InitializeComponent();
        }

        private void BAdd_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new TypeEditPage(new ProductType()));
        }

        private void BEdit_Click(object sender, RoutedEventArgs e)
        {
            var selectedType = DGType.SelectedItem as ProductType;
            if (selectedType == null)
            {
                MessageBox.Show("Select");
                return;
            }
            NavigationService.Navigate(new TypeEditPage(selectedType));
        }

        private void Page_Loaded(object sender, RoutedEventArgs e)
        {
            DGType.ItemsSource = App.db.ProductType.ToList();
        }
    }
}
