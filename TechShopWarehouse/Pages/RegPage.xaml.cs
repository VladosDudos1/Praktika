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
    /// Логика регистрации пользователя, проверка на наличие пользователя в бд
    /// </summary>
    public partial class RegPage : Page
    {

        private static List<User> users { get; set; }
        public RegPage()
        {
            InitializeComponent();

            DataContext = this;
        }
        /// <summary>
        /// Вернуться к авторизации
        /// </summary>
        private void authBtn_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.GoBack();
        }

        /// <summary>
        /// Зарегистрироваться
        /// </summary>
        private void enterBtn_Click(object sender, RoutedEventArgs e)
        {
            users = new List<User>(BaseConnection.connection.User.ToList());
            var k = users.Where(a => a.Login == LoginTB.Text && a.Password == PasswordTB.Password).FirstOrDefault();
            if (k == null)
            {
                var user = new User();
                user.Login = LoginTB.Text;
                user.Password = PasswordTB.Password;
                user.Post = 3;
                user.Name = NameTB.Text;
                BaseConnection.connection.User.Add(user);

                BaseConnection.connection.SaveChanges();

                NavigationService.GoBack();
            }
            else
            {
                MessageBox.Show("Юзер существует или данные введены некорректно", "Ошибка", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }
    }
}
