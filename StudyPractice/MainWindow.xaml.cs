using StudyPractice.Pages;
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

namespace StudyPractice
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            MainFrame.Navigate(new LoginPage());
        }

        private void BTest_Click(object sender, RoutedEventArgs e)
        {

            

            //try
            //{
            //    var searchText = int.Parse(TbSearch.Text);
            //    var employee = App.db.User.FirstOrDefault(x => x.Id == searchText);
            //    if (employee == null)
            //    {
            //        MessageBox.Show("Employee not found");
            //    }
            //    else
            //    {
            //        MessageBox.Show(employee.Name);
            //    }
            //}
            //catch(ArgumentException argEx)
            //{
            //    MessageBox.Show(argEx.Message);
            //}
            //catch (FormatException argEx)
            //{
            //    MessageBox.Show("Вы ввели неверные данные");
            //}
            //catch (Exception ex)
            //{
            //    MessageBox.Show("Error");
            //}
            //finally
            //{
            //    MessageBox.Show("Поиск прошел успешно");
            //}
            
           
        }

        //private void Button_Click(object sender, RoutedEventArgs e)
        //{
        //    MessageBox.Show(Tb.Text);
        //}
    }
}
