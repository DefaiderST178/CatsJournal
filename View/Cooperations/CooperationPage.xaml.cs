using CatsJournal.Model;
using CatsJournal.View.Cooperation;

namespace CatsJournal.View.Cooperation;

public partial class CooperationPage : ContentPage
{
	public CooperationPage()
	{
		InitializeComponent();
        BindingContext = CooperationRepo.AllCooperation;
    }

    private void coopList_ItemSelected(object sender, SelectedItemChangedEventArgs e)
    {
        if (e.SelectedItem == null)
            return;

        var selectedCooperation = e.SelectedItem as Model.Cooperation;

        Navigation.PushAsync(new SelectedCooperation(selectedCooperation));

        coopList.SelectedItem = null;
    }
}