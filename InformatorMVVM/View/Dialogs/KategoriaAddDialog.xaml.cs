using InformatorMVVM.Model;
using System;
using System.Linq;
using System.Windows;

namespace InformatorMVVM.View.Dialogs
{
    /// <summary>
    /// Logika interakcji dla klasy KategoriaAdd.xaml
    /// </summary>
    public partial class KategoriaAddDialog : Window
    {
        private InformatorDbContext _dbContext;
        public KategoriaAddDialog()
        {
            InitializeComponent();
        }

        private void AddKategoria(object sender, RoutedEventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(kategorieNazwa.Text))
            {
                using (_dbContext = new InformatorDbContext())
                {
                    var kategoria = new Kategorie
                    {
                        nazwa_kategorii = kategorieNazwa.Text,
                        
                    };

                    _dbContext.Kategorie.Add(kategoria);
                    _dbContext.SaveChanges();
                }

                this.Close();
            }
            else
            {
                MessageBox.Show("Brakuje Nazwy Kategorii");
            }
        }
    }
}
