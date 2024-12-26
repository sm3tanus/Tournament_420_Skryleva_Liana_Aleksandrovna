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
    /// Логика взаимодействия для ListTournaments.xaml
    /// </summary>
    public partial class ListTournaments : Page
    {
        public ListTournaments()
        {
            InitializeComponent();
            if (App.authUser.idRole != 6) AddBt.Visibility = Visibility.Hidden;
            ListTournamentsLv.ItemsSource = Connection.tournamentDB.Tournament.ToList();

        }

        private void FilterStatus_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            List<Tournament> filter;
            if (FilterStatus.SelectedIndex == 0)
            {
                filter = Connection.tournamentDB.Tournament.Where(i => i.date == DateTime.Now).ToList();
                ListTournamentsLv.ItemsSource = filter;
            }
            if (FilterStatus.SelectedIndex == 1)
            {
                filter = Connection.tournamentDB.Tournament.Where(i => i.date < DateTime.Now).ToList();
                ListTournamentsLv.ItemsSource = filter;
            }
            if (FilterStatus.SelectedIndex == 2)
            {
                filter = Connection.tournamentDB.Tournament.Where(i => i.date > DateTime.Now).ToList();
                ListTournamentsLv.ItemsSource = filter;
            }
        }

        private void AddBt_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new AddTournamentPage());
        }
        private void resetBt_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new MainPage());

        }

        private void ExitBt_Click(object sender, RoutedEventArgs e)
        {
            if (App.authUser.idRole == 6) NavigationService.Navigate(new MainPageForOrganzator());
           
        }

        private void ListTournamentsLv_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (App.authUser.idRole != 6)
            {
                App.authUser.idTournament = (ListTournamentsLv.SelectedItem as Tournament).id;
            }
        }
    }
}
