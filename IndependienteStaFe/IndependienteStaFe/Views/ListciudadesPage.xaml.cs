using IndependienteStaFe.Services;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace IndependienteStaFe.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ListciudadesPage : ContentPage
    {
        public ListciudadesPage()
        {
            InitializeComponent();

            Repository repo = new Repository();

            var ciudades = repo.getCiudades();

            Lista.ItemsSource = ciudades.data;
        }
    }
}