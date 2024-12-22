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

    private async void ShareBtn_Clicked(object sender, EventArgs e)
    {
        string textToShare = $"Порода: {BreedTB.Text}\nОписание: {DescriptionTB.Text}";
        try
        {
            await Share.RequestAsync(new ShareTextRequest
            {
                Text = textToShare,
                Title = "Поделиться текстом"
            });
        }
        catch (Exception ex)
        {
            await DisplayAlert("Ошибка", $"Не удалось поделиться текстом: {ex.Message}", "OK");
        }
    }
}