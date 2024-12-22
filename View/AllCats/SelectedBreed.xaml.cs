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
        await Navigation.PopAsync(); // ������� �� ���������� ��������
    }

    private async void ShareBtn_Clicked(object sender, EventArgs e)
    {
        string textToShare = $"������: {BreedTB.Text}\n��������: {DescriptionTB.Text}";
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