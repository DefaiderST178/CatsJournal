using CatsJournal.Model;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace CatsJournal.ViewModel
{
    public class CooperationViewModel : INotifyPropertyChanged
    {
        private ObservableCollection<Cooperation> _cooperations;
        public ObservableCollection<Cooperation> Cooperations
        {
            get { return _cooperations; }
            set { _cooperations = value; OnPropertyChanged(); }
        }

        private Cooperation _selectedCooperation;
        public Cooperation SelectedCooperation
        {
            get { return _selectedCooperation; }
            set { _selectedCooperation = value; OnPropertyChanged(); }
        }

        public CooperationViewModel()
        {
            // Получение данных из BreedRepo
            CooperationRepo cooperationRepo = new CooperationRepo();
            List<Cooperation> allCooperations = cooperationRepo.GetAllBreeds();
            Cooperations = new ObservableCollection<Cooperation>(allCooperations);
        }

        public event PropertyChangedEventHandler PropertyChanged;

        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
