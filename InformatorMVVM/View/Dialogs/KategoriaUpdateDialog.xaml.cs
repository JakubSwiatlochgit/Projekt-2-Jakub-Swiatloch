using InformatorMVVM.Model;
using System.Linq;
using System.Windows;

namespace InformatorMVVM.View.Dialogs
{
    public partial class KategoriaUpdateDialog : Window
    {
        private InformatorDbContext _dbContext;
        public int Id { get; set; }

        public KategoriaUpdateDialog(int id)
        {
            InitializeComponent();
            Id = id;
            LoadData();
        }

        private void LoadData()
        {
            using (_dbContext = new InformatorDbContext())
            {
                // Pobierz dane kategorii na podstawie Id
                var kategoria = _dbContext.Kategorie.FirstOrDefault(k => k.FKID == Id);

                // Jeśli znaleziono kategorię, ustaw dane w kontrolkach
                if (kategoria != null)
                {
                    kategoriaNazwa.Text = kategoria.nazwa_kategorii;
                }
            }
        }

        private void EditKategoria(object sender, RoutedEventArgs e)
        {
            if (kategoriaNazwa.Text.Length != 0)
            {
                using (_dbContext = new InformatorDbContext())
                {
                    // Pobierz dane kategorii na podstawie Id
                    var kategoria = _dbContext.Kategorie.FirstOrDefault(k => k.FKID == Id);

                    // Jeśli znaleziono kategorię, zaktualizuj jej nazwę
                    if (kategoria != null)
                    {
                        kategoria.nazwa_kategorii = kategoriaNazwa.Text;
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
