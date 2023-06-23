using InformatorMVVM.Model;
using System;
using System.Linq;
using System.Windows;

namespace InformatorMVVM.View.Dialogs
{
    /// <summary>
    /// Logika interakcji dla klasy KategoriaAdd.xaml
    /// </summary>
    public partial class TabelaKontAddDialog : Window
    {
        private InformatorDbContext _dbContext;
        public TabelaKontAddDialog()
        {
            InitializeComponent();
        }

        private void AddKonto(object sender, RoutedEventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(tabelaKontEmail.Text) || 
                !string.IsNullOrWhiteSpace(tabelaKontHaslo.Text) ||
                !string.IsNullOrWhiteSpace(tabelaKontAdres.Text))
            {
                using (_dbContext = new InformatorDbContext())
                {
                    var konto = new Tabela_Kont
                    {
                        email = tabelaKontEmail.Text,
                        haslo = tabelaKontHaslo.Text,
                        adres = tabelaKontAdres.Text,

                    };

                    _dbContext.Tabela_Kont.Add(konto);
                    _dbContext.SaveChanges();
                }

                this.Close();
            }
            else
            {
                MessageBox.Show("Brakuje niektórych danych");
            }
        }
    }
}
