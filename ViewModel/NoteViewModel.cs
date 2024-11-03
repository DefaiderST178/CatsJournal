using CatsJournal.Model;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace CatsJournal.ViewModel
{
    public class NoteViewModel : INotifyPropertyChanged
    {
        private ObservableCollection<Note> _notes;
        public ObservableCollection<Note> Notes
        {
            get { return _notes; }
            set { _notes = value; OnPropertyChanged(); }
        }

        private Note _selectedNote;
        public Note SelectedNote
        {
            get { return _selectedNote; }
            set { _selectedNote = value; OnPropertyChanged(); }
        }

        public NoteViewModel()
        {
            NoteRepo noteRepo = new NoteRepo();
            List<Note> allNotes = noteRepo.GetAllBreeds();
            Notes = new ObservableCollection<Note>(allNotes);
        }

        public event PropertyChangedEventHandler PropertyChanged;

        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
