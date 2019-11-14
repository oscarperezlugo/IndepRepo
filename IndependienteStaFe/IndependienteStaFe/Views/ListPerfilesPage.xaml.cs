using IndependienteStaFe.Services;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace IndependienteStaFe.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ListPerfilesPage : ContentPage
    {
        public ListPerfilesPage()
        {
            InitializeComponent();

            Repository repo = new Repository();

            var perfiles = repo.getPerfiles();

            Lista.ItemsSource = perfiles.data;
        }
    }
}