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
    /// Логика добавления товара на склад, склада
    /// </summary>
    public partial class WarehousePage : Page
    {
        private static List<Warehouse> wares { get; set; }
        private static List<Device> device { get; set; }
        public WarehousePage()
        {
            InitializeComponent();

            DataContext = this;
        }

        /// <summary>
        /// Проверка на наличие в базе объектов и создание новых 
        /// </summary>
        private void btnAddClick(object sender, RoutedEventArgs e)
        {
            wares = new List<Warehouse>(BaseConnection.connection.Warehouse.ToList());
            device = new List<Device>(BaseConnection.connection.Device.ToList());
            var w = wares.Where(a => a.InnerNumber == int.Parse(tbWarehouse.Text)).FirstOrDefault();
            var d = device.Where(a => a.DeviceName == tbName.Text).FirstOrDefault();

            var warehouse = new Warehouse();
            var addDevice = new Device();
            var wd = new Warehouse_Device();

            if(w != null)
            {
                BaseConnection.connection.Device.Add(addDevice);
            }
            if (d != null)
            {
                BaseConnection.connection.Warehouse.Add(warehouse);
            }
            else
            {
                BaseConnection.connection.Device.Add(addDevice);
                BaseConnection.connection.Warehouse.Add(warehouse);
            }


            BaseConnection.connection.Warehouse_Device.Add(wd);
            BaseConnection.connection.SaveChanges();
        }
    }
}
