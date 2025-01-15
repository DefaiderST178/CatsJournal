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
        await Navigation.PopAsync(); // ������� �� ���������� ��������
    }

    private async void OpenMapBtn_Clicked(object sender, EventArgs e)
    {
        // ������� �� �����
        var addressLabel = this.FindByName<Label>("AddressLabel");
        string address = addressLabel?.Text ?? "";

        if (!string.IsNullOrWhiteSpace(address))
        {
            // ��������� URL ��� �������� �����
            string mapUrl = $"https://www.google.com/maps/search/?api=1&query={Uri.EscapeDataString(address)}";

            // ��������� �����
            try
            {
                await Launcher.OpenAsync(mapUrl);
            }
            catch (Exception ex)
            {
                await DisplayAlert("������", $"�� ������� ������� �����: {ex.Message}", "��");
            }
        }
        else
        {
            await DisplayAlert("������", "����� �� ������.", "��");
        }
    }
}