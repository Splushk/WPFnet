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
using System.Data.Entity;
using Zooha.Data;
using System.Runtime.Remoting.Contexts;

namespace Zooha.Pages.UserPages
{
    /// <summary>
    /// Логика взаимодействия для OrdPage.xaml
    /// </summary>
    public partial class OrdPage : Page
    {
        zoomirEntities context = new zoomirEntities();
        CollectionViewSource ordersViewSource;
        CollectionViewSource ordersViewSource1;


        public OrdPage()
        {
            InitializeComponent();
            ordersDataGrid.SelectionChanged += ordersDataGrid_SelectionChanged;
            ordersViewSource = ((CollectionViewSource)(FindResource("ordersViewSource")));
            ordersViewSource1 = ((CollectionViewSource)(FindResource("ordersViewSource1")));
            DataContext = this;
            this.Loaded += Page_loaded;
        }

        private void Page_loaded(object sender, RoutedEventArgs e)
        {
            context.Orders.Load();


            ordersViewSource.Source = context.Orders.Local;
        }
        private void ordersDataGrid_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            CollectionViewSource ordersViewSource1 = (CollectionViewSource)FindResource("ordersViewSource1");

        }
    }


}
