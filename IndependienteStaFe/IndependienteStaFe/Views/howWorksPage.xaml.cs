using Xamarin.Forms;
using System;
using System.Threading.Tasks;
using Acr.UserDialogs;
using Xamarin.Forms.Xaml;

namespace IndependienteStaFe.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class howWorksPage : ContentPage
    {
        IUserDialogs Dialogs = UserDialogs.Instance;
        public howWorksPage()
        {
            InitializeComponent();
            //Repository repository = new Repository();

            //var how =repository.getHowWorks();
            //howitworks.Source = how.data[0].Content;

            //howitworks.Source = new HtmlWebViewSource
            //{
            //Html = how.data[0].Name.ToString() + "<br/>" + how.data[0].Content
            //};
            
        }
        public async void Button_Clicked(object sender, EventArgs e)
        {
            Dialogs.ShowLoading("Espere por favor...");
            await Task.Delay(2000);
            Dialogs.HideLoading();

            LoginPage myHomePage = new LoginPage();
            NavigationPage.SetHasNavigationBar(myHomePage, true);
            await Navigation.PushModalAsync(myHomePage);
        }

        public void Home_Clicked(object sender, EventArgs e)
        {
            Application.Current.MainPage = new AppShell();

        }
    }
    
}