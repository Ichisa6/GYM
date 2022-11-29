using GYM.Components;
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

namespace GYM.Pages
{
    /// <summary>
    /// Логика взаимодействия для ServicePage.xaml
    /// </summary>
    public partial class ServicePage : Page
    {
        public ServicePage()
        {
            InitializeComponent();
            ServiceList.ItemsSource = DbConnect.db.Service.ToList();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if (Navigation.AutorizateUser == null)
                Navigation.AutorizateUser.Lvl = 0;
            DbConnect.db.SaveChanges();
            var boof = (sender as Button).DataContext as Service;
            Navigation.AutorizateUser.Lvl += boof.LVL;
            if (Navigation.AutorizateUser.Lvl >= 15)
                Navigation.AutorizateUser.Rank_id = 2;
            DbConnect.db.SaveChanges();
            MessageBox.Show($"{Navigation.AutorizateUser.LName} {Navigation.AutorizateUser.Lvl}");
        }

        private void ServiceList_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }
    }
}
