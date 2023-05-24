using StudyPractice.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity.Infrastructure;
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
    /// Логика взаимодействия для TypeEditPage.xaml
    /// </summary>
    public partial class TypeEditPage : Page
    {
        ProductType contextType;
        DbPropertyValues oldValues;
        public TypeEditPage(ProductType productType)
        {
            InitializeComponent();
            contextType = productType;
            DataContext = contextType;
            if (contextType.Id != 0)
            {
                oldValues = App.db.Entry(contextType).CurrentValues.Clone();
            }
        }

        private void Save_Click(object sender, RoutedEventArgs e)
        {
            if (string.IsNullOrEmpty(contextType.Name))
            {
                MessageBox.Show("Empty");
                return;
            }
            if (contextType.Id == 0)
            {
                App.db.ProductType.Add(contextType);

            }
            App.db.SaveChanges();
            NavigationService.GoBack();
        }

        private void Cancel_Click(object sender, RoutedEventArgs e)
        {
            if (oldValues != null)
            {
                App.db.Entry(contextType).CurrentValues.SetValues(oldValues);
            }
            NavigationService.GoBack();
        }
    }
}
