using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using InformatorMVVM.Model;

namespace InformatorMVVM.ViewModel
{
    public class TabelaKontViewModel : INotifyPropertyChanged
    {
        private ObservableCollection<Tabela_Kont> _tabelaKontList;
        public ObservableCollection<Tabela_Kont> TabelaKontList
        {
            get => _tabelaKontList;
            set
            {
                _tabelaKontList = value;
                OnPropertyChanged(nameof(TabelaKontList));
            }
        }

        public event PropertyChangedEventHandler ?PropertyChanged;

        public TabelaKontViewModel()
        {
            LoadData();
        }

        public void LoadData()
        {
            using (var dbContext = new InformatorDbContext())
            {
                var tabelaKont = dbContext.Tabela_Kont.ToList();
                TabelaKontList = new ObservableCollection<Tabela_Kont>(tabelaKont);
            }
        }

        protected void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
