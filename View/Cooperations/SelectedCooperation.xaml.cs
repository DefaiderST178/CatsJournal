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

    private async void OpenMapBtn_Clicked(object sender, EventArgs e)
    {
        // открыть на карте
        var addressLabel = this.FindByName<Label>("AddressLabel");
        string address = addressLabel?.Text ?? "";

        if (!string.IsNullOrWhiteSpace(address))
        {
            // Формируем URL для открытия карты
            string mapUrl = $"https://www.google.com/maps/search/?api=1&query={Uri.EscapeDataString(address)}";

            // Запускаем карту
            try
            {
                await Launcher.OpenAsync(mapUrl);
            }
            catch (Exception ex)
            {
                await DisplayAlert("Ошибка", $"Не удалось открыть карту: {ex.Message}", "ОК");
            }
        }
        else
        {
            await DisplayAlert("Ошибка", "Адрес не найден.", "ОК");
        }
    }
}