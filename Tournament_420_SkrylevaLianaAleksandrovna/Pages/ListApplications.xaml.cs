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
            ListUsers.ItemsSource = Connection.tournamentDB.Participant.Where(i => i.idRole != 6).ToList();
        }

        private void AddBt_Click(object sender, RoutedEventArgs e)
        {

        }

        private void ListUsers_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            
        }
    }
}
