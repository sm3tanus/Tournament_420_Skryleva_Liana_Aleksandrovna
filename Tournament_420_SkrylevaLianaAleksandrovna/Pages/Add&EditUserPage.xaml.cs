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
    /// Логика взаимодействия для Add_EditUserPage.xaml
    /// </summary>
    public partial class Add_EditUserPage : Page
    {
        public Add_EditUserPage()
        {
            InitializeComponent();
            RoleCb.ItemsSource = Connection.tournamentDB.Role.Where(i => i.id != 6).ToList();
            partyCb.ItemsSource = Connection.tournamentDB.Party.ToList();
            tournCb.ItemsSource = Connection.tournamentDB.Tournament.ToList();

        }

        private void addBt_Click(object sender, RoutedEventArgs e)
        {
            try {
                if (role != null &&
                   rangTb.Text.Length != 0 &&
                   loginTb.Text.Length != 0 &&
                   passwordTb.Text.Length != 0 &&
                   fioTb.Text.Length != 0 &&
                   nickTb.Text.Length != 0)
                {
                    Participant participant = new Participant();
                    participant.idRole = role.id;
                    participant.rang = int.Parse(rangTb.Text);
                    if (tournament == null) participant.idParty = null;
                    if (tournament != null) participant.idParty = party.id;

                    if (tournament == null) participant.idTournament = null;
                    if (tournament != null) participant.idTournament = tournament.id;
                    participant.status = status;
                    participant.played = playedCheck.IsChecked;
                    participant.login = loginTb.Text;
                    participant.password = int.Parse(passwordTb.Text);
                    participant.fio = fioTb.Text;
                    participant.nick = nickTb.Text;

                    Connection.tournamentDB.Participant.Add(participant);
                    Connection.tournamentDB.SaveChanges();
                    NavigationService.Navigate(new ListApplications());
                }
                else
                {
                    MessageBox.Show("Заполните поля!");
                }
            } catch { }
           
            
        }
        Role role = new Role();

        private void RoleCb_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            role = RoleCb.SelectedItem as Role;
            MessageBox.Show(role.id.ToString());
        }
        Party party = new Party();
        private void partyCb_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            party = partyCb.SelectedItem as Party;
            MessageBox.Show(party.id.ToString());

        }
        Tournament tournament = new Tournament();
        private void tournCb_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            tournament = tournCb.SelectedItem as Tournament;
            MessageBox.Show(tournament.id.ToString());

        }
        bool status;
        private void statusCb_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (statusCb.SelectedIndex == 0) status = true;
            if (statusCb.SelectedIndex == 2) status = false;

        }
    }
}
