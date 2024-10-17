using CatsJournal.Model;

namespace CatsJournal.View.Notes;

public partial class NotesPage : ContentPage
{
	public NotesPage()
	{
		InitializeComponent();
        BindingContext = NoteRepo.AllNotes;
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