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
using Wydarzenie = InformatorMVVM.Model.Wydarzenie;

namespace InformatorMVVM.ViewModel
{
    public class WydarzenieViewModel : INotifyPropertyChanged
    {

        private ObservableCollection<Model.Wydarzenie> _wydarzenieList;
        public ObservableCollection<Model.Wydarzenie> WydarzeniaList
        {
            get => _wydarzenieList;
            set
            {
                _wydarzenieList = value;
                OnPropertyChanged(nameof(_wydarzenieList));
            }
        }

        public event PropertyChangedEventHandler ?PropertyChanged;

        public WydarzenieViewModel()
        {
            LoadData();
        }
        //wczytanie danych z bazy i inicjalizacja danych 
        public void LoadData()
        {
            using (var dbContext = new InformatorDbContext())
            {
                var wydarzenia = dbContext.Wydarzenie.Include(w => w.id_kategorii).Include(w => w.id_organizatora).ToList();
                WydarzeniaList = new ObservableCollection<Wydarzenie>(wydarzenia);
            }
        }


        private Wydarzenie model;

        public Model.Kategorie id_kategorii
        {
            get => model.id_kategorii;
            set
            {
                model.id_kategorii = value;
                OnPropertyChanged(nameof(id_kategorii));
            }
        }
        public Model.Organizatorzy id_organizatora
        {
            get => model.id_organizatora;
            set
            {
                model.id_organizatora = value;
                OnPropertyChanged(nameof(id_organizatora));
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
