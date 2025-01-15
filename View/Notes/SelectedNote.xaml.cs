using Microsoft.Maui.Controls;

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

    private async void ShareBtn_Clicked(object sender, EventArgs e)
    {
        string textToShare = $"Прочитайте статью «{NoteTB.Text}» в мобильном приложении Кошачий журнал!";
        var image = this.FindByName<Image>("Image");
        try
        {
            await Share.RequestAsync(new ShareTextRequest
            {
                Text = textToShare,
                Title = "Поделиться статьей"
            });
        }
        catch (Exception ex)
        {
            await DisplayAlert("Ошибка", $"Не удалось поделиться текстом: {ex.Message}", "OK");
        }
    }
}