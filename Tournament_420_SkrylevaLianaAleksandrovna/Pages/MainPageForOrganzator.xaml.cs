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

namespace Tournament_420_SkrylevaLianaAleksandrovna.Pages
{
    /// <summary>
    /// Логика взаимодействия для MainPageForOrganzator.xaml
    /// </summary>
    public partial class MainPageForOrganzator : Page
    {
        public MainPageForOrganzator()
        {
            InitializeComponent();
        }

        private void TournBt_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new ListTournaments());
        }

        private void ParcBt_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new ListApplications());
        }

        private void ExitBt_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new MainPageForOrganzator());
        }
    }
}
