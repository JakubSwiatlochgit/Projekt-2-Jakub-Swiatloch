using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using InformatorMVVM.Model;

namespace InformatorMVVM.ViewModel
{
    public class KategorieViewModel : INotifyPropertyChanged
    {
        private ObservableCollection<Kategorie> _kategorieList;
        public ObservableCollection<Kategorie> KategorieList
        {
            get => _kategorieList;
            set
            {
                _kategorieList = value;
                OnPropertyChanged(nameof(KategorieList));
            }
        }

        public event PropertyChangedEventHandler ?PropertyChanged;

        public KategorieViewModel()
        {
            LoadData();
        }

        public void LoadData()
        {
            using (var dbContext = new InformatorDbContext())
            {
                var kategorie = dbContext.Kategorie.ToList();
                KategorieList = new ObservableCollection<Kategorie>(kategorie);
            }
        }

        protected void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
