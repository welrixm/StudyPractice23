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
    /// Логика взаимодействия для LoginPage.xaml
    /// </summary>
    public partial class LoginPage : Page
    {
        public LoginPage()
        {
            InitializeComponent();
        }

        private void BTest_Click(object sender, RoutedEventArgs e)
        {
            var login = TbLogin.Text;
            var password = TbPassword.Text;
            var employee = App.db.User.FirstOrDefault(emp => emp.Login == login && emp.Password == password);
            if (employee == null)
            {

                MessageBox.Show("Error");
            }
            else
            {
                MessageBox.Show("Yes");
                NavigationService.Navigate(new MarketPage());
            }
           
        }
    }
}
