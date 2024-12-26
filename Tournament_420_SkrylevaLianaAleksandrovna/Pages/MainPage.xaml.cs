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
    /// Логика взаимодействия для MainPage.xaml
    /// </summary>
    public partial class MainPage : Page
    {
        public MainPage()
        {
            InitializeComponent();
            ListTournaments.ItemsSource = Connection.tournamentDB.Tournament.ToList();
            
        }

        private void FilterStatus_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            List<Tournament> filter;
            if (FilterStatus.SelectedIndex == 0)
            {
               filter  = Connection.tournamentDB.Tournament.Where(i => i.date == DateTime.Now).ToList();
               ListTournaments.ItemsSource = filter;
            }
            if (FilterStatus.SelectedIndex == 1)
            {
                filter = Connection.tournamentDB.Tournament.Where(i => i.date < DateTime.Now).ToList();
                ListTournaments.ItemsSource = filter;
            }
            if (FilterStatus.SelectedIndex == 2)
            {
                filter = Connection.tournamentDB.Tournament.Where(i => i.date > DateTime.Now).ToList();
                ListTournaments.ItemsSource = filter;
            }
        }

        private void AuthBt_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new AuthorizationPage());
        }

        private void resetBt_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new MainPage());

        }
    }
}
