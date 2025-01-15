namespace CatsJournal.View.Tests;

public partial class SelectedTest : ContentPage
{
    public string breed1 { get; set; }  
    public string breed2 { get; set; }
    public string breed3 { get; set; }
    public string breed4 { get; set; }
    public string answerBreed { get; set; }
    public SelectedTest(Model.Quest selectedQuest)
	{
		InitializeComponent();
        BindingContext = selectedQuest;
        breed1 = selectedQuest.Breeds[0];
        breed2 = selectedQuest.Breeds[1];
        breed3 = selectedQuest.Breeds[2];
        breed4 = selectedQuest.Breeds[3];
        answerBreed = selectedQuest.Answer;
    }
    private void ChooseBtn1_Clicked(object sender, EventArgs e) // Выбор породы 1
    {
        if (breed1 == answerBreed)
        {
            ResultTB.Text = "Вы угадали это " + answerBreed;
        }
        else
        {
            ResultTB.Text = "Вы не угадали это " + breed1;
        }
    }

    private void ChooseBtn2_Clicked(object sender, EventArgs e) // Выбор породы 2
    {
        if (breed2 == answerBreed)
        {
            ResultTB.Text = "Вы угадали это " + answerBreed;
        }
        else
        {
            ResultTB.Text = "Вы не угадали это " + breed2;
        }
    }

    private void ChooseBtn3_Clicked(object sender, EventArgs e) // Выбор породы 3
    {
        if (breed3 == answerBreed)
        {
            ResultTB.Text = "Вы угадали это " + answerBreed;
        }
        else
        {
            ResultTB.Text = "Вы не угадали это " + breed3;
        }
    }

    private void ChooseBtn4_Clicked(object sender, EventArgs e) // Выбор породы 4
    {
        if (breed4 == answerBreed)
        {
            ResultTB.Text = "Вы угадали это " + answerBreed;
        }
        else
        {
            ResultTB.Text = "Вы не угадали это " + breed4;
        }
    }

    private async void Back_Clicked(object sender, EventArgs e)
    {
        await Navigation.PopAsync();
    }
}