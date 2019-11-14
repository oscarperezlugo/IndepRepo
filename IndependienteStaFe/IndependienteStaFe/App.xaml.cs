using IndependienteStaFe.Services;
using Xamarin.Essentials;
using IndependienteStaFe.Views;
using Xamarin.Forms;

namespace IndependienteStaFe
{
    public partial class App : Application
    {
        public static bool IsUserLoggedIn { get; set; }

        public App()
        {
            InitializeComponent();

            DependencyService.Register<Repository>();
             //MainPage = new MainPage();

            MainPage = new AppShell();

            ///OneSignal.Current.StartInit("{Insert Your OneSignal ID}").EndInit();


        }

        protected override void OnStart()
        {
            
            // Handle when your app starts
            Xamarin.Forms.Application.Current.Properties.Clear();
        }

        protected override void OnSleep()
        {
            SecureStorage.Remove("token");

            // Handle when your app sleeps
        }

        protected override void OnResume()
        {
            // Handle when your app resumes
        }
    }
}
