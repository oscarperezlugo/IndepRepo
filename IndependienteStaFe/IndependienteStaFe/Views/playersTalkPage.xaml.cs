using IndependienteStaFe.Services;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace IndependienteStaFe.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class playersTalkPage : ContentPage
    {
        public playersTalkPage()
        {
            InitializeComponent();
            Repository repository = new Repository();
        }
    }
}