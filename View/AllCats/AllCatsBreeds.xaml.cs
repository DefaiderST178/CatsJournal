using CatsJournal.Model;
using CatsJournal.ViewModel;

namespace CatsJournal.View.AllCats;

public partial class AllCatsBreeds : ContentPage
{
	public AllCatsBreeds()
	{
		InitializeComponent();
        BreedViewModel breedViewModel = new BreedViewModel();
        BindingContext = breedViewModel;
    }
    private void OnItemSelected(object sender, SelectedItemChangedEventArgs e) // обработка нажатия элемента в списке
    {
        if (e.SelectedItem == null)
            return;

        var selectedBreed = e.SelectedItem as Breed;

        Navigation.PushAsync(new SelectedBreed(selectedBreed));

        breedsList.SelectedItem = null;
    }
}