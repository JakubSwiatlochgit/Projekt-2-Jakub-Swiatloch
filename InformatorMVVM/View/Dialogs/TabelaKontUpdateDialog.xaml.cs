using InformatorMVVM.Model;
using System.Linq;
using System.Windows;

namespace InformatorMVVM.View.Dialogs
{
    public partial class TabelaKontUpdateDialog : Window
    {
        private InformatorDbContext _dbContext;
        public int Id { get; set; }

        public TabelaKontUpdateDialog(int id)
        {
            InitializeComponent();
            Id = id;
            LoadData();
        }

        private void LoadData()
        {
            using (_dbContext = new InformatorDbContext())
            {
                // Pobierz dane konta na podstawie Id
                var konto = _dbContext.Tabela_Kont.FirstOrDefault(k => k.FKID == Id);

                // Jeśli znaleziono dane to , ustaw dane w kontrolkach
                if (konto != null)
                {
                    
                    tabelaKontEmail.Text = konto.email;
                    tabelaKontHaslo.Text = konto.haslo;
                    tabelaKontAdres.Text = konto.adres;
                }
            }
        }

        private void EditTabelaKont(object sender, RoutedEventArgs e)
        {
            if (tabelaKontEmail.Text.Length != 0 && tabelaKontHaslo.Text.Length != 0 && tabelaKontAdres.Text.Length != 0)
            {
                using (_dbContext = new InformatorDbContext())
                {
                    // Pobierz dane konta na podstawie Id
                    var konto = _dbContext.Tabela_Kont.FirstOrDefault(k => k.FKID == Id);

                    // Jeśli znaleziono konto, zaktualizuj jego dane
                    if (konto != null)
                    {
                        konto.email= tabelaKontEmail.Text;
                        konto.haslo = tabelaKontHaslo.Text;
                        konto.adres = tabelaKontAdres.Text;
                        _dbContext.SaveChanges();
                    }
                }
                Close();
            }
            else
            {
                MessageBox.Show("Wpisz nazwę kategorii.");
            }
        }
    }
}
