using IndependienteStaFe.Helpers;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;


namespace IndependienteStaFe
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class AppShell : Xamarin.Forms.Shell
    {
        public AppShell()
        {
            InitializeComponent();

            Shell.SetNavBarIsVisible(this, false);

            if (Settings.IsLoggedIn == false)
            {
                // products.ContentTemplate = new DataTemplate { LoginPage };
            }

        }
    }
}