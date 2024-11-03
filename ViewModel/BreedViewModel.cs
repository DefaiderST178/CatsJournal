using CatsJournal.Model;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace CatsJournal.ViewModel
{

    public class BreedViewModel : INotifyPropertyChanged
    {
        private ObservableCollection<Breed> _breeds;
        public ObservableCollection<Breed> Breeds
        {
            get { return _breeds; }
            set { _breeds = value; OnPropertyChanged(); }
        }

        private Breed _selectedBreed;
        public Breed SelectedBreed
        {
            get { return _selectedBreed; }
            set { _selectedBreed = value; OnPropertyChanged(); }
        }

        public BreedViewModel()
        {
            // Получение данных из BreedRepo
            BreedRepo breedRepo = new BreedRepo();
            List<Breed> allBreeds = breedRepo.GetAllBreeds();
            Breeds = new ObservableCollection<Breed>(allBreeds);
        }

        public event PropertyChangedEventHandler PropertyChanged;

        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
