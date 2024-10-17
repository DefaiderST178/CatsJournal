namespace CatsJournal.View.Cooperation;

public partial class SelectedCooperation : ContentPage
{
	public SelectedCooperation(Model.Cooperation selectedCooperation)
	{
		InitializeComponent();
        BindingContext = selectedCooperation;
    }
    private async void Back_Clicked(object sender, EventArgs e)
    {
        await Navigation.PopAsync(); // Переход на предыдущую страницу
    }
}