using CatsJournal.Model;

namespace CatsJournal.View.Tests;

public partial class TestsPage : ContentPage
{
	public TestsPage()
	{
		InitializeComponent();
        BindingContext = QuestRepo.AllQuest;
    }

    private void TestList_ItemSelected(object sender, SelectedItemChangedEventArgs e)
    {
        if (e.SelectedItem == null)
            return;

        var selectedQuest = e.SelectedItem as Quest;

        Navigation.PushAsync(new SelectedTest(selectedQuest));

        TestList.SelectedItem = null;
    }
}