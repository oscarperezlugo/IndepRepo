using Acr.UserDialogs;
using IndependienteStaFe.Models;
using IndependienteStaFe.Services;
using System;
using System.Threading.Tasks;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace IndependienteStaFe.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class RecuperarClavePage : ContentPage
    {
        IUserDialogs Dialogs = UserDialogs.Instance;
        Repository repository = new Repository();
        public RecuperarClavePage()
        {
            InitializeComponent();


        }

        public async void OnRecuperarClave(object sender, EventArgs e)
        {


            rememberPassword rPw = repository.PostRecuperarPw(rcIDtext.Text, rcEMailtext.Text).Result;

            Dialogs.ShowLoading(rPw.Message.ToString()); ;
            await Task.Delay(2000);
            Dialogs.HideLoading();
            LoginPage myHomePage = new LoginPage();
            NavigationPage.SetHasNavigationBar(myHomePage, false);
            await Navigation.PushModalAsync(myHomePage);

        }



        public async void OnCancelar(object sender, EventArgs e)
        {
            Dialogs.ShowLoading("Cancelando...");
            await Task.Delay(1000);
            Dialogs.HideLoading();

            LoginPage myHomePage = new LoginPage();
            NavigationPage.SetHasNavigationBar(myHomePage, false);
            await Navigation.PushModalAsync(myHomePage);


        }


    }
}