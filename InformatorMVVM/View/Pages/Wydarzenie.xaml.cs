using InformatorMVVM.Model;
using InformatorMVVM.ViewModel;
using Microsoft.EntityFrameworkCore;
using System;
using System.Linq;
using System.Windows;
using System.Windows.Controls;
using InformatorMVVM.View.Dialogs;
namespace InformatorMVVM.View.Pages
{
    public partial class Wydarzenie : UserControl
    {
        public Wydarzenie()
        {
            InitializeComponent();
            DataContext = new WydarzenieViewModel();
        }

        private void EditData(object sender, RoutedEventArgs e)
        {
            Button b = sender as Button;

            WydarzenieUpdateDialog editDialog = new WydarzenieUpdateDialog(Convert.ToInt32(b.CommandParameter));
            editDialog.ShowDialog();
            refreshData();
        }
        private void DeleteData(object sender, RoutedEventArgs e)
        {
            Button b = sender as Button;
            using (var dbContext = new InformatorDbContext()) {
                var wydarzenie = dbContext.Wydarzenie.Where(w => w.FKID == Convert.ToInt32(b.CommandParameter)).FirstOrDefault();
                if (wydarzenie != null)
                {
                    dbContext.Wydarzenie.Remove(wydarzenie);
                    dbContext.SaveChanges();
                    MessageBox.Show($"Pomyslnie usunieto wydarzenie: \n{wydarzenie.nazwa_wydarzenia}");
                }
                else
                    MessageBox.Show($"Cos poszlo nie tak podczas usuwania wydarzenia: \n{wydarzenie.nazwa_wydarzenia}");
            }
            refreshData();
        }
        public void refreshData()
        {
            using (var dbContext = new InformatorDbContext())
            {
                TableData.ItemsSource = null;
                TableData.Items.Clear();
                TableData.ItemsSource = dbContext.Wydarzenie.Include(w => w.id_kategorii).Include(w => w.id_organizatora).ToList();
            }
            
        }
    }
}
