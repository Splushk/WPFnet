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
using Zooha.Pages.UserPages;

namespace Zooha
{
    /// <summary>
    /// Логика взаимодействия для AdminPage.xaml
    /// </summary>
    public partial class AdminPage : Page
    {
        private NavigationService _navigationService;
        public AdminPage()
        {
            InitializeComponent();
            this.Loaded += AdminPage_Loaded;
        }
        private void AdminPage_Loaded(object sender, RoutedEventArgs e)
        {
            _navigationService = NavigationService.GetNavigationService(this);
        }
        private void Ordbtn_Click(object sender, RoutedEventArgs e)
        {
            _navigationService.Navigate(new OrdPage());
        }

        private void Catbtn_Click(object sender, RoutedEventArgs e)
        {
            _navigationService.Navigate(new CatPage());
        }

        private void Prodbtn_Click(object sender, RoutedEventArgs e)
        {
            _navigationService.Navigate(new ProdPage());
        }
    }
}
