using Acr.UserDialogs;
using System;
using System.Threading.Tasks;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace IndependienteStaFe.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class UpdateMembershipPage : ContentPage
    {
        IUserDialogs Dialogs = UserDialogs.Instance;
        public UpdateMembershipPage()
        {
            InitializeComponent();
        }

        public async void OnCancelar(object sender, EventArgs e)
        {
            Dialogs.ShowLoading("Cancelando...");
            await Task.Delay(1000);
            Dialogs.HideLoading();

            InicioPage myHomePage = new InicioPage();


            NavigationPage.SetHasNavigationBar(myHomePage, false);



            await Navigation.PushModalAsync(myHomePage);


        }

        public async void OnActualizar(object sender, EventArgs e)
        {
            Dialogs.ShowLoading("Cancelando...");
            await Task.Delay(1000);
            Dialogs.HideLoading();

            InicioPage myHomePage = new InicioPage();


            NavigationPage.SetHasNavigationBar(myHomePage, false);



            await Navigation.PushModalAsync(myHomePage);


        }
    }
}