using InformatorMVVM.Model;
using InformatorMVVM.View.Dialogs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
namespace InformatorMVVM.View
{
    public partial class AppWindow : Window
    {
        Pages.Wydarzenie wydarzeniePages = new Pages.Wydarzenie();
        Pages.Kategorie kategoriePages = new Pages.Kategorie();
        Pages.Organizatorzy organizatorzyPages = new Pages.Organizatorzy();
        Pages.TabelaKont tabelaKontPages = new Pages.TabelaKont();
        public AppWindow()
        {

            InitializeComponent();
            InformatorDbContext dbContext = new InformatorDbContext();


            this.contentControl.Content = new Pages.SZBD();

        }

        private void ShowWydarzenie(object sender, RoutedEventArgs e)
        {
            this.contentControl.Content = wydarzeniePages;
        }

        private void ShowOrganizatorzy(object sender, RoutedEventArgs e)
        {
            this.contentControl.Content = organizatorzyPages;
        }

        private void ShowKategorie(object sender, RoutedEventArgs e)
        {
            this.contentControl.Content = kategoriePages;

        }

        private void ShowUzytkownicy(object sender, RoutedEventArgs e)
        {

        }

        private void ShowRezerwacje(object sender, RoutedEventArgs e)
        {

        }

        private void ShowOcenyUzytkownikow(object sender, RoutedEventArgs e)
        {

        }

        private void ShowTabelaKont(object sender, RoutedEventArgs e)
        {
            this.contentControl.Content = tabelaKontPages;
        }

        private void ShowWydarzenieAdd(object sender, RoutedEventArgs e)
        {
            WydarzenieAddDialog wydarzenieAddDialog = new WydarzenieAddDialog();
            wydarzenieAddDialog.ShowDialog();
            refreshPages();
        }

        private void ShowOrganizatorAdd(object sender, RoutedEventArgs e)
        {
            OrganizatorzyAddDialog organizatorAddDialog = new OrganizatorzyAddDialog();
            organizatorAddDialog.ShowDialog();
            refreshPages();
        }

        private void ShowKategoriaAdd(object sender, RoutedEventArgs e)
        {
            KategoriaAddDialog kategoriaAddDialog = new KategoriaAddDialog();
            kategoriaAddDialog.ShowDialog();
            refreshPages();
        }

        private void ShowUzytkownikAdd(object sender, RoutedEventArgs e)
        {

        }

        private void ShowRezerwacjaAdd(object sender, RoutedEventArgs e)
        {

        }

        private void ShowOcenyUzytkownikowAdd(object sender, RoutedEventArgs e)
        {

        }

        private void ShowTabelaKontAdd(object sender, RoutedEventArgs e)
        {
            TabelaKontAddDialog tabelaKontAddDialog = new TabelaKontAddDialog();
            tabelaKontAddDialog.ShowDialog();
            refreshPages();
        }

        public void refreshPages()
        {
            wydarzeniePages.refreshData();
            kategoriePages.refreshData();
            organizatorzyPages.refreshData();
            tabelaKontPages.refreshData();
            //categoriesPage.refreshData();
            //ordersPage.refreshData();
        }
    }
}
