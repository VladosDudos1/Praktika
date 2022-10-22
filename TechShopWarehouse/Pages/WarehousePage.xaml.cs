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
        private List<Warehouse_Device> wdList { get; set; }
        public WarehousePage()
        {
            InitializeComponent();

            wdList = BaseConnection.connection.Warehouse_Device.ToList();
            lvItems.ItemsSource = wdList;

            DataContext = this;
        }

        
    }
}
