using InformatorMVVM.Model;
using System;
using System.Linq;
using System.Windows;

namespace InformatorMVVM.View.Dialogs
{
    /// <summary>
    /// Logika interakcji dla klasy WydarzenieAdd.xaml
    /// </summary>
    public partial class OrganizatorzyAddDialog : Window
    {
        private InformatorDbContext _dbContext;
        public OrganizatorzyAddDialog()
        {
            InitializeComponent();

            using (_dbContext = new InformatorDbContext())
            {
                // pobieranie listy uzytkownikow  do comboboxa organizatrUzytkownicy
                organizatorUzytkownik.ItemsSource = _dbContext.Organizatorzy.ToList();

                }


        }
        private void AddOrganizator(object sender, RoutedEventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(organizatorNazwa.Text) &&
                organizatorUzytkownik.SelectedItem != null )
            {
                using (_dbContext = new InformatorDbContext())
                {
                    var organizator = new Organizatorzy
                    {
                        nazwa_organizatora = organizatorNazwa.Text,
                        id_konta = GetSelectedUzytkownik()
                    };

                    _dbContext.Organizatorzy.Add(organizator);
                    _dbContext.SaveChanges();
                }

                this.Close();
            }
            else
            {
                MessageBox.Show("Brakuje niektórych Danych");
            }
        }

        private Tabela_Kont GetSelectedUzytkownik()
        {
            var selectedUzytkownik = (Tabela_Kont)organizatorUzytkownik.SelectedItem;
            return _dbContext.Tabela_Kont.SingleOrDefault(t => t.FKID == selectedUzytkownik.FKID);
        }



    }
}
