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
    /// Логика взаимодействия для ListApplications.xaml
    /// </summary>
    public partial class ListApplications : Page
    {
        public ListApplications()
        {
            InitializeComponent();
            if (App.authUser.idRole != 6) AddBt.Visibility = Visibility.Hidden;
            ListUsers.ItemsSource = Connection.tournamentDB.Participant.Where(i => i.idRole != 6).ToList();
        }

        private void AddBt_Click(object sender, RoutedEventArgs e)
        {
            if (App.authUser.idRole == 6) NavigationService.Navigate(new Add_EditUserPage());
        }

        private void ListUsers_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (App.authUser.idRole == 6) NavigationService.Navigate(new Add_EditUserPage());
        }
        private void ExitBt_Click(object sender, RoutedEventArgs e)
        {
            if (App.authUser.idRole == 6) NavigationService.Navigate(new MainPageForOrganzator());

        }
    }
}
