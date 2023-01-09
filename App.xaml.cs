using IE307.N11.Services;
using Xamarin.Forms;

namespace IE307.N11
{
    public partial class App : Application
    {

        public App()
        {
            InitializeComponent();
            // Init Data
            DataSample.Init();
            SettingsService.Init();
            //
            MainPage = new AppShell();
        }

        protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}
