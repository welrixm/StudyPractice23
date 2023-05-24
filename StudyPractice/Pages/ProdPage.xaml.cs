using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data.Entity.Infrastructure;
using System.IO;
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
using Microsoft.Win32;
using StudyPractice.Models;

namespace StudyPractice.Pages
{
    /// <summary>
    /// Логика взаимодействия для ProdPage.xaml
    /// </summary>
    public partial class ProdPage : Page
    {
        Product contextPtoduct;
        DbPropertyValues oldValues;
        public ProdPage(Product product)
        {
            InitializeComponent();
            CBProvider.ItemsSource = App.db.Provider.ToList();
            CBType.ItemsSource = App.db.ProductType.ToList();
            contextPtoduct = product;
            DataContext = contextPtoduct;
            if(contextPtoduct.Id != 0 )
            {
                oldValues = App.db.Entry(contextPtoduct).CurrentValues.Clone();
            }
        }

        private void Save_Click(object sender, RoutedEventArgs e)
        {

            string price = contextPtoduct.Price.ToString();
            string count = contextPtoduct.Count.ToString();
            if (string.IsNullOrEmpty(contextPtoduct.Name))
            {
                MessageBox.Show("Empty");
                return;
            }
            if (price.Length == 0)
            {
                MessageBox.Show("Empty");
                return;
            }
            if (count.Length == 0)
            {
                MessageBox.Show("Empty");
                return;
            }

            if (string.IsNullOrEmpty(contextPtoduct.Description))
            {
                MessageBox.Show("Empty");
                return;
            }
            if (contextPtoduct.Provider == null)
            {
                MessageBox.Show("select");
                return;
            }
            if (contextPtoduct.ProductType == null)
            {
                MessageBox.Show("select");
                return;
            }
            if (contextPtoduct.Id == 0)
            {
                App.db.Product.Add(contextPtoduct);

            }
            App.db.SaveChanges();
            NavigationService.GoBack();
        }

        private void Cancel_Click(object sender, RoutedEventArgs e)
        {
           if(oldValues != null)
            {
                App.db.Entry(contextPtoduct).CurrentValues.SetValues(oldValues);
            }  
           NavigationService.GoBack();
        }

        private void BDChange_Click(object sender, RoutedEventArgs e)
        {
            var dialog = new OpenFileDialog() { Multiselect = true};
           if(dialog.ShowDialog().GetValueOrDefault())
            {
                foreach ( var filename in dialog.FileNames)
                {
                    contextPtoduct.ProductPhoto.Add(new ProductPhoto()
                    {
                        Image = File.ReadAllBytes(dialog.FileName),
                        Product = contextPtoduct
                    });
                }
               
               
                Refresh();
                DataContext = null;
                DataContext = contextPtoduct;
            } 
        }
        private void Refresh()
        {
            LPhoto.ItemsSource = contextPtoduct.ProductPhoto.ToList();
        }
    }
}
