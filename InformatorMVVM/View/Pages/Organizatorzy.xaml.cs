using InformatorMVVM.Model;
using InformatorMVVM.ViewModel;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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
using InformatorMVVM.View;
using InformatorMVVM.View.Dialogs;

namespace InformatorMVVM.View.Pages
{
    /// <summary>
    /// Logika interakcji dla klasy Wydarzenie.xaml
    /// </summary>
    public partial class Organizatorzy : UserControl
    {

        public Organizatorzy()
        {
            InitializeComponent();
            DataContext = new OrganizatorzyViewModel();
        }

        private void EditData(object sender, RoutedEventArgs e)
        {
            Button b = sender as Button;

            OrganizatorzyUpdateDialog editDialog = new OrganizatorzyUpdateDialog(Convert.ToInt32(b.CommandParameter));
            editDialog.ShowDialog();
            refreshData();
        }

        private void DeleteData(object sender, RoutedEventArgs e)
        {
            Button b = sender as Button;
            using (var dbContext = new InformatorDbContext()) {
                var organizator = dbContext.Organizatorzy.Where(w => w.FKID == Convert.ToInt32(b.CommandParameter)).FirstOrDefault();
                if (organizator != null)
                {
                    dbContext.Organizatorzy.Remove(organizator);
                    dbContext.SaveChanges();
                    MessageBox.Show($"Pomyslnie usunieto wydarzenie: \n{organizator.nazwa_organizatora}");
                }
                else
                    MessageBox.Show($"Cos poszlo nie tak podczas usuwania wydarzenia: \n{organizator.nazwa_organizatora}");
            }
            refreshData();
        }
        

        public void refreshData()
        {
            
            using (var dbContext = new InformatorDbContext())
            {
                TableData.ItemsSource = null;
                TableData.Items.Clear();
                TableData.ItemsSource = dbContext.Organizatorzy.Include(w => w.id_konta).ToList();

            }
            
        }
    }
}
