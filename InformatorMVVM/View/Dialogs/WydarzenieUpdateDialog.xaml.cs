using InformatorMVVM.Model;
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
using System.Windows.Shapes;

namespace InformatorMVVM.View.Dialogs
{
    public partial class WydarzenieUpdateDialog : Window
    {
        private InformatorDbContext _dbContext;
        public int Id { get; set; }

        public WydarzenieUpdateDialog(int id)
        {
            InitializeComponent();
            Id = id;
            LoadData();
        }

        private void LoadData()
        {
            using (_dbContext = new InformatorDbContext())
            {
                var wydarzenie = _dbContext.Wydarzenie.Where(w => w.FKID == Id).FirstOrDefault();
                wydarzenieKategoria.ItemsSource = _dbContext.Kategorie.ToList();
                wydarzenieOrganizator.ItemsSource = _dbContext.Organizatorzy.ToList();
                if (wydarzenie != null)
                {
                    wydarzenieNazwa.Text = wydarzenie.nazwa_wydarzenia;
                    wydarzenieOpis.Text = wydarzenie.opis;
                    wydarzenieDataIGodzinaRozpoczecia.Text = wydarzenie.data_i_godzina_rozpoczecia.ToString();
                    wydarzenieDataIGodzinaZakoncznia.Text = wydarzenie.data_i_godzina_zakonczenia.ToString();

                    wydarzenieKategoria.SelectedValue = wydarzenie.id_kategorii;
                    wydarzenieOrganizator.SelectedValue = wydarzenie.id_organizatora;
                }
            }
        }



        private void EditWydarzenie(object sender, RoutedEventArgs e)
        {
            if (wydarzenieNazwa.Text.Length != 0 && wydarzenieOpis.Text.Length != 0)
            {

                using (_dbContext = new InformatorDbContext())
                {
                    var wydarzenie = _dbContext.Wydarzenie.Find(Id);

                    if (wydarzenie != null)
                    {
                        wydarzenie.nazwa_wydarzenia = wydarzenieNazwa.Text;
                        wydarzenie.opis = wydarzenieOpis.Text;
                        wydarzenie.id_kategorii = (Kategorie)wydarzenieKategoria.SelectedItem;
                        wydarzenie.id_organizatora = (Organizatorzy)wydarzenieOrganizator.SelectedItem;

                        _dbContext.SaveChanges();   
                    }
                Close();
                }
            }
            else  MessageBox.Show("Missing some data");
        }
    }
}
