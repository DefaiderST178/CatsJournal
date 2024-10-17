using CatsJournal.Model;

namespace CatsJournal.View.AllCats;

public partial class AllCatsBreeds : ContentPage
{
	public AllCatsBreeds()
	{
		InitializeComponent();
        BindingContext = BreedRepo.AllBreeds;
    }
    private void OnItemSelected(object sender, SelectedItemChangedEventArgs e) // ��������� ������� �������� � ������
    {
        if (e.SelectedItem == null)
            return;

        var selectedBreed = e.SelectedItem as Breed;

        Navigation.PushAsync(new SelectedBreed(selectedBreed));

        breedsList.SelectedItem = null;
    }
}