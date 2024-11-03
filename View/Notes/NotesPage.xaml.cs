using CatsJournal.Model;
using CatsJournal.ViewModel;

namespace CatsJournal.View.Notes;

public partial class NotesPage : ContentPage
{
	public NotesPage()
	{
		InitializeComponent();
        NoteViewModel noteViewModel = new NoteViewModel();
        BindingContext = noteViewModel;
    }

    private void notesList_ItemSelected(object sender, SelectedItemChangedEventArgs e)
    {
        if (e.SelectedItem == null)
            return;

        var selectedNote = e.SelectedItem as Note;

        Navigation.PushAsync(new SelectedNote(selectedNote));

        notesList.SelectedItem = null;
    }
}