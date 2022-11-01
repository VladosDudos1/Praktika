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
using System.Windows.Shapes;

namespace TechShopWarehouse
{
    /// <summary>
    /// Логика взаимодействия для ФвьштЦштвщц.xaml
    /// </summary>
    public partial class AdminWindow : Window
    {
        private Warehouse_Device wareD = new Warehouse_Device();
        public List<ReturnStatus> rs { get; set; }
        public AdminWindow(Warehouse_Device wd)
        {
            InitializeComponent();
            wareD = wd;
            rs = BaseConnection.connection.ReturnStatus.ToList();
            statusCB.SelectedIndex = (int)wareD.RetStatus-1;

            DataContext = this;
        }

        private void statusCB_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (statusCB.SelectedItem == null)
            {

            }
        }

        private void buttonSaveClose_Click(object sender, RoutedEventArgs e)
        {
            if (statusCB.SelectedItem != null)
            {
                wareD.RetStatus = (statusCB.SelectedItem as ReturnStatus).Id;
                BaseConnection.connection.SaveChanges();
                this.Close();
            }
        }
    }
}
