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
using Tournament_420_SkrylevaLianaAleksandrovna.DB;

namespace Tournament_420_SkrylevaLianaAleksandrovna.Pages
{
    /// <summary>
    /// Логика взаимодействия для AuthorizationPage.xaml
    /// </summary>
    public partial class AuthorizationPage : Page
    {
        public AuthorizationPage()
        {
            InitializeComponent();
        }

        private void EnterBt_Click(object sender, RoutedEventArgs e)
        {
            if (LoginTb.Text.Length!= 0 && PasswordTb.Password.Length !=0)
            {
                List<Participant> participants = Connection.tournamentDB.Participant.ToList();
                App.authUser = participants.FirstOrDefault(i => i.login == LoginTb.Text && i.password == int.Parse(PasswordTb.Password));
                if (App.authUser != null)
                {
                    if (App.authUser.idRole == 6)
                    {
                        NavigationService.Navigate(new MainPageForOrganzator());
                    }
                    else
                    {
                        NavigationService.Navigate(new ListTournaments());
                    }
                    
                }
                else
                {
                    MessageBox.Show("Пользователя не существует! Попробуйте еще раз.");
                }
            }
            else
            {
                MessageBox.Show("Введите данные!");
            }
        }

        private void ExitBt_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new MainPage());
        }
    }
}
