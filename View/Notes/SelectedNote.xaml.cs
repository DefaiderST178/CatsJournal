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
        string textToShare = $"���������� ������ �{NoteTB.Text}� � ��������� ���������� ������� ������!";
        var image = this.FindByName<Image>("Image");
        try
        {
            await Share.RequestAsync(new ShareTextRequest
            {
                Text = textToShare,
                Title = "���������� �������"
            });
        }
        catch (Exception ex)
        {
            await DisplayAlert("������", $"�� ������� ���������� �������: {ex.Message}", "OK");
        }
    }
}