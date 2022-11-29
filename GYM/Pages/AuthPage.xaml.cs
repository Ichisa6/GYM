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
    /// Логика взаимодействия для AuthPage.xaml
    /// </summary>
    public partial class AuthPage : Page
    {
        public AuthPage()
        {
            InitializeComponent();
        }

        private void AuthBtn_Click(object sender, RoutedEventArgs e)
        {
            if (FNameTb.Text.Trim().Length <= 0 || MailTb.Text.Trim().Length <= 0)
            {
                MessageBox.Show("Заполните все поля!");
            }
            else
            {
                Navigation.AutorizateUser = DbConnect.db.Client.ToList().Find(x => x.FName == FNameTb.Text && x.Mail ==MailTb.Text);
                if (Navigation.AutorizateUser == null)
                {
                    MessageBox.Show("Такого пользователя не существует");
                }
                else
                {
                    Navigation.IsAutorizate = true;
                    Navigation.NextPage(new Nav("Список упражнений", new ServicePage()));
                    MessageBox.Show("Авторизация прошла успешно!");
                }
            }
        }

        private void RegBtn_Click(object sender, RoutedEventArgs e)
        {
            Navigation.NextPage(new Nav("Регистрация", new RegPage()));
        }
    }
}
