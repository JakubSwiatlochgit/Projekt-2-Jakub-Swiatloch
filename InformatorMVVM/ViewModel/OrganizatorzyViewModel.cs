using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Collections.Specialized;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using InformatorMVVM.Model;
using InformatorMVVM.View.Pages;
using Microsoft.EntityFrameworkCore;
using Organizatorzy = InformatorMVVM.Model.Organizatorzy;

namespace InformatorMVVM.ViewModel
{
    public class OrganizatorzyViewModel : INotifyPropertyChanged
    {

        private ObservableCollection<Model.Organizatorzy> _organizatorzyList;
        public ObservableCollection<Model.Organizatorzy> OrganizatorzyList
        {
            get => _organizatorzyList;
            set
            {
                _organizatorzyList = value;
                OnPropertyChanged(nameof(_organizatorzyList));
            }
        }

        public event PropertyChangedEventHandler ?PropertyChanged;

        public OrganizatorzyViewModel()
        {
            LoadData();
        }

        public void LoadData()
        {
            using (var dbContext = new InformatorDbContext())
            {
                var organizator = dbContext.Organizatorzy.ToList();
                OrganizatorzyList = new ObservableCollection<Organizatorzy>(organizator);
            }
        }


        private Organizatorzy model;


        public Model.Tabela_Kont id_konta
        {
            get => model.id_konta;
            set
            {
                model.id_konta = value;
                OnPropertyChanged(nameof(id_konta));
            }
        }
             
        protected void OnPropertyChanged(string propertyName)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
            }
        }
    }
}
