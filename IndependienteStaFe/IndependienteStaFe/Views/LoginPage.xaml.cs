using Acr.UserDialogs;
using Xamarin.Essentials;
using IndependienteStaFe.Helpers;
using IndependienteStaFe.Models;
using IndependienteStaFe.Services;
using IndependienteStaFe.ViewModels;
using System;
using System.Threading.Tasks;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace IndependienteStaFe.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class LoginPage : ContentPage
    {
        Repository repo = new Repository();
        public LoginPage()
        {
            var vm = new LoginViewModel();
            this.BindingContext = vm;




            InitializeComponent();

            usuario.Completed += (object sender, EventArgs e) =>
            {
                password.Focus();
            };

            password.Completed += (object sender, EventArgs e) =>
            {
                vm.SubmitCommand.Execute(null);
            };
        }

        public async void Button_Clicked(object sender, EventArgs e)
        {
            IUserDialogs Dialogs = UserDialogs.Instance;



            if (usuario.Text != null && password.Text != null)
            {
                User usuariologin = new User();
                usuariologin.id = usuario.Text;
                usuariologin.password = password.Text;

                Repository repositorio = new Repository();
                try
                {


                    Login userlogin = repositorio.ConnectUser(usuariologin).Result;
                    Dialogs.ShowLoading(userlogin.Message.ToString()); ;
                    await Task.Delay(2000);
                    Dialogs.HideLoading();                    
                    try
                    {
                        await SecureStorage.SetAsync("token", userlogin.jwt.ToString());
                    }
                    catch (Exception ex)
                    {
                        // Possible that device doesn't support secure storage on device.
                    }                    
                    UserPage myHomePage = new UserPage();
                    NavigationPage.SetHasNavigationBar(myHomePage, false);
                    await Navigation.PushModalAsync(myHomePage);
                }

                catch (Exception ex)
                {
                    await DisplayAlert("Login Error", ex.Message, "Intente de nuevo mas tarde");

                }
            }


            }


        public async void ClickedRecuperarClave(object sender, EventArgs e)
        {
            IUserDialogs Dialogs = UserDialogs.Instance;
            Dialogs.ShowLoading("Espere por favor...");
            await Task.Delay(1000);
            Dialogs.HideLoading();

            RecuperarClavePage myHomePage = new RecuperarClavePage();
            NavigationPage.SetHasNavigationBar(myHomePage, true);
            await Navigation.PushModalAsync(myHomePage);




        }

        public async void ClickedRegistrarse(object sender, EventArgs e)
        {
            IUserDialogs Dialogs = UserDialogs.Instance;
            Dialogs.ShowLoading("Espere por favor...");
            await Task.Delay(2000);
            Dialogs.HideLoading();

            RegisterPage myHomePage = new RegisterPage();
            NavigationPage.SetHasNavigationBar(myHomePage, true);
            await Navigation.PushModalAsync(myHomePage);




        }
    }
}