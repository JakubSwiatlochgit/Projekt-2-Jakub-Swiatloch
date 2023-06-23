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
using InformatorMVVM.Model;
using InformatorMVVM.View.Dialogs;
using InformatorMVVM.ViewModel;
using Microsoft.EntityFrameworkCore;

namespace InformatorMVVM.View.Pages
{
    /// <summary>
    /// Logika interakcji dla klasy Kategorie.xaml
    /// </summary>
    public partial class Kategorie : UserControl
    {
        public Kategorie()
        {
            InitializeComponent();
            DataContext = new KategorieViewModel();
        }

        private void EditData(object sender, RoutedEventArgs e)
        {
            Button b = sender as Button;

            KategoriaUpdateDialog editDialog = new KategoriaUpdateDialog(Convert.ToInt32(b.CommandParameter));
            editDialog.ShowDialog();
            refreshData();
        }

        private void DeleteData(object sender, RoutedEventArgs e)
        {
            Button b = sender as Button;
            using (var dbContext = new InformatorDbContext())
            {
                var kategoria = dbContext.Kategorie.Where(w => w.FKID == Convert.ToInt32(b.CommandParameter)).FirstOrDefault();
                if (kategoria != null)
                {
                    dbContext.Kategorie.Remove(kategoria);
                    dbContext.SaveChanges();
                    MessageBox.Show($"Pomyslnie usunieto kategorie: \n{kategoria.nazwa_kategorii}");
                }

            }
            refreshData();
        }

        public void refreshData()
        {

            using (var dbContext = new InformatorDbContext())
            {
                TableData.ItemsSource = null;
                TableData.Items.Clear();
                TableData.ItemsSource = dbContext.Kategorie.ToList();

            }

        }
    }
}
