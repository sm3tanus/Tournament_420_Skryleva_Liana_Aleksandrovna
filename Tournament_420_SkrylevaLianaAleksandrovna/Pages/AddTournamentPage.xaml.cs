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
    /// Логика взаимодействия для AddTournamentPage.xaml
    /// </summary>
    public partial class AddTournamentPage : Page
    {
        public AddTournamentPage()
        {
            InitializeComponent();
        }
        int selectedFormat;

        private void addBt_Click(object sender, RoutedEventArgs e)
        {
            if (NameTb.Text.Length != 0 &&
                dateDp.SelectedDate != null &&
                selectedFormat != null &&
                countUserTb.Text.Length != 0 &&
                prizeTb.Text.Length != 0)
            {
                Tournament tournament = new Tournament();
                tournament.name = NameTb.Text;
                tournament.date = dateDp.SelectedDate;
                tournament.idFormat = selectedFormat;
                tournament.countUser = int.Parse(countUserTb.Text);
                tournament.prize = int.Parse(prizeTb.Text);
                if (minrangTb.Text.Length == 0) tournament.minRang = null;
                if (minrangTb.Text.Length != 0) tournament.minRang = int.Parse(minrangTb.Text);
                Connection.tournamentDB.Tournament.Add(tournament);
                Connection.tournamentDB.SaveChanges();
                NavigationService.Navigate(new ListTournaments());
            }
            else
            {
                MessageBox.Show("Не все данные заполнены!");
            }
        }

        private void FormatCb_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (FormatCb.SelectedIndex == 0) selectedFormat = 1;
            if (FormatCb.SelectedIndex == 1) selectedFormat = 2;
        }
    }
}
