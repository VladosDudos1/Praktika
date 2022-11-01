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

namespace TechShopWarehouse
{
    /// <summary>
    /// Логика авторизации пользователя, проверка на наличие пользователя в бд
    /// </summary>
    public partial class AuthPage : Page
    {
        private static List<User> users { get; set; }
        public AuthPage()
        {
            InitializeComponent();
            LoginTB.Text = Properties.Settings.Default.Login;

            DataContext = this;
        }
        private void regBtn_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new RegPage());
        }
        private void enterBtn_Click(object sender, RoutedEventArgs e)
        {
            users = new List<User>(BaseConnection.connection.User.ToList());
            var k = users.Where(a => a.Login == LoginTB.Text && a.Password == PasswordTB.Password).FirstOrDefault();
            if (k != null)
            {
                Properties.Settings.Default.Login = LoginTB.Text.Trim();
                Properties.Settings.Default.Save();
                NavigationService.Navigate(new WarehousePage());

                DataManager.role = Convert.ToInt32(k.Post);
            }
            else
            {
                MessageBox.Show("Юзер не существует", "Ошибка", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }
    }
}
