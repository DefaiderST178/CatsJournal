namespace CatsJournal
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new AppShell(); // Боковая свертываемая панель для навигации
        }
    }
}
