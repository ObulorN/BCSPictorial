using BCSPictorial.ViewModel;

namespace BCSPictorial
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new MainPage(new PictorialVM()); // AppShell();
        }
    }
}
