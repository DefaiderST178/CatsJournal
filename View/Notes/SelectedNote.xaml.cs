namespace CatsJournal.View.Notes;

public partial class SelectedNote : ContentPage
{
	public SelectedNote(Model.Note selectedNote)
	{
		InitializeComponent();
		BindingContext = selectedNote;
	}

    private async void Back_Clicked(object sender, EventArgs e)
    {
		await Navigation.PopAsync();
    }
}