using InformatorMVVM.Model;
using System;
using System.Linq;
using System.Windows;

namespace InformatorMVVM.View.Dialogs
{
    public partial class WydarzenieAddDialog : Window
    {
        private InformatorDbContext _dbContext;
        public WydarzenieAddDialog()
        {
            InitializeComponent();

            using (_dbContext = new InformatorDbContext())
            {
                // pobieranie kategorii i przypisanie do comboboxa wydarzenieKategoria
                wydarzenieKategoria.ItemsSource = _dbContext.Kategorie.ToList();

                // pobieranie wydarzen i przypisanie do comboboxa wydarzenieOrganizator
                wydarzenieOrganizator.ItemsSource = _dbContext.Organizatorzy.ToList();
            }


        }

        private void AddWydarzenie(object sender, RoutedEventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(wydarzenieNazwa.Text) &&
                !string.IsNullOrWhiteSpace(wydarzenieOpis.Text) &&
                !string.IsNullOrWhiteSpace(wydarzenieDataIGodzinaRozpoczecia.Text) &&
                !string.IsNullOrWhiteSpace(wydarzenieDataIGodzinaZakoncznia.Text) &&
                wydarzenieKategoria.SelectedItem != null &&
                wydarzenieOrganizator.SelectedItem != null)
            {
                using (_dbContext = new InformatorDbContext())
                {
                    var wydarzenie = new Wydarzenie
                    {
                        nazwa_wydarzenia = wydarzenieNazwa.Text,
                        opis = wydarzenieOpis.Text,
                        data_i_godzina_rozpoczecia = DateTime.Parse(wydarzenieDataIGodzinaRozpoczecia.Text),
                        data_i_godzina_zakonczenia = DateTime.Parse(wydarzenieDataIGodzinaZakoncznia.Text),
                        //nie możemy przypisać FKID bezpośrednio do właściwości id_kategorii lub id_organizatora,
                        //ponieważ są to obiekty typu Kategorie i Organizatorzy, a nie typu int.
                        id_kategorii = GetSelectedKategoria(),
                        id_organizatora = GetSelectedOrganizator()
                    };

                    _dbContext.Wydarzenie.Add(wydarzenie);
                    _dbContext.SaveChanges();
                }

                this.Close();
            }
            else
            {
                MessageBox.Show("Brakuje niektórych Danych");
            }
        }

        private Kategorie GetSelectedKategoria()
        {
            var selectedKategoria = (Kategorie)wydarzenieKategoria.SelectedItem;
            return _dbContext.Kategorie.SingleOrDefault(k => k.FKID == selectedKategoria.FKID);
        }

        private Organizatorzy GetSelectedOrganizator()
        {
            var selectedOrganizator = (Organizatorzy)wydarzenieOrganizator.SelectedItem;
            return _dbContext.Organizatorzy.SingleOrDefault(o => o.FKID == selectedOrganizator.FKID);
        }



    }
}
