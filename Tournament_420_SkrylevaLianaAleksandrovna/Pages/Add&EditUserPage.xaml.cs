﻿using System;
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
        }

        private void addBt_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
