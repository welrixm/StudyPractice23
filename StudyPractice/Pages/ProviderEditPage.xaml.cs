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
    /// Логика взаимодействия для ProviderEditPage.xaml
    /// </summary>
    public partial class ProviderEditPage : Page
    {
        Provider contextPtov;
        DbPropertyValues oldValues;
        public ProviderEditPage(Provider provider)
        {
            InitializeComponent();
            contextPtov = provider;
            DataContext = contextPtov;
            if (contextPtov.Id != 0)
            {
                oldValues = App.db.Entry(contextPtov).CurrentValues.Clone();
            }
        }

        private void Save_Click(object sender, RoutedEventArgs e)
        {
            if (string.IsNullOrEmpty(contextPtov.Name))
            {
                MessageBox.Show("Empty");
                return;
            }
            if (contextPtov.Id == 0)
            {
                App.db.Provider.Add(contextPtov);

            }
            App.db.SaveChanges();
            NavigationService.GoBack();
        }

        private void Cancel_Click(object sender, RoutedEventArgs e)
        {
            if (oldValues != null)
            {
                App.db.Entry(contextPtov).CurrentValues.SetValues(oldValues);
            }
            NavigationService.GoBack();
        }
    }
}
