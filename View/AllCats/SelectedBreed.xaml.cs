namespace CatsJournal.View.AllCats;

public partial class SelectedBreed : ContentPage
{
	public SelectedBreed(Model.Breed selectedBreed)
	{
		InitializeComponent();
        BindingContext = selectedBreed;
    }

    private async void Back_Clicked(object sender, EventArgs e)
    {
        await Navigation.PopAsync(); // Переход на предыдущую страницу
    }
}