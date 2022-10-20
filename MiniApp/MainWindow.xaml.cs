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

namespace MiniApp
{
    public partial class MainWindow : Window
    {
        int count = 0;
        /// <summary>
        /// Указание количества балабоб
        /// </summary>
        public MainWindow()
        {
            InitializeComponent();
            count = Convert.ToInt32(BaseConnection.connection.Warehouse_Device.ToList()[0].Count);
            balabobs.Text = "Balabobs: " + count;
        }

        /// <summary>
        /// Покупка балабобы, уменьшение на складе
        /// </summary>
        private void btnBuy_Click(object sender, RoutedEventArgs e)
        {
            if (count != 0)
            {
                count--;
                balabobs.Text = "Balabobs: " + count;
                BaseConnection.connection.Warehouse_Device.ToList()[0].Count -= 1;

                BaseConnection.connection.SaveChanges();
            }
            else
            {
                MessageBox.Show("Абибка балабобы", "Абибка", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }
    }
}
