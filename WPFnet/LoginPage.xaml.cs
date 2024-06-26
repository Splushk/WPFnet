﻿using System;
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

namespace Zooha
{
    /// <summary>
    /// Логика взаимодействия для LoginPage.xaml
    /// </summary>

    public partial class LoginPage : Page
    {
        private NavigationService _navigationService;

        public LoginPage()
        {
            InitializeComponent();
            this.Loaded += LoginPage_Loaded;
        }

        private void LoginPage_Loaded(object sender, RoutedEventArgs e)
        {
            _navigationService = NavigationService.GetNavigationService(this);
        }



        private void Logbtn_Click_1(object sender, RoutedEventArgs e)
        {

            string username = loginTxt.Text;
            string password = passwordTxt.Password;

            if (username == "admin" && password == "password")
            {
                _navigationService.Navigate(new AdminPage());
            }
            else
            {
                MessageBox.Show("Неверное имя пользователя или пароль");
            }


        }
    }
}

