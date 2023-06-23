using InformatorMVVM.Model;
using InformatorMVVM.View.Pages;
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
    public partial class OrganizatorzyUpdateDialog : Window
    {
        private InformatorDbContext _dbContext;
        public int Id { get; set; }

        public OrganizatorzyUpdateDialog(int id)
        {
            InitializeComponent();
            Id = id;
            LoadData();
        }

        private void LoadData()
        {
            using (_dbContext = new InformatorDbContext())
            {
                var organizator = _dbContext.Organizatorzy.Where(w => w.FKID == Id).FirstOrDefault();
                organizatorUzytkownik.ItemsSource = _dbContext.Tabela_Kont.ToList();
                if (organizator != null)
                {
                    organizatorNazwa.Text = organizator.nazwa_organizatora;
                    organizatorUzytkownik.SelectedValue = organizator.id_konta;
                }
            }
        }

        private void EditOrganizator(object sender, RoutedEventArgs e)
        {
            if (organizatorNazwa.Text.Length != 0)
            {
                using (_dbContext = new InformatorDbContext())
                {
                    var organizator = _dbContext.Organizatorzy.FirstOrDefault(w => w.FKID == Id);
                    if (organizator != null)
                    {
                        organizator.nazwa_organizatora = organizatorNazwa.Text;
                        organizator.id_konta = organizatorUzytkownik.SelectedItem as Tabela_Kont;

                        _dbContext.SaveChanges();
                    }
                    Close();
                }
            }
            else
            {
                MessageBox.Show("Missing some data");
            }
        }


    }
}
