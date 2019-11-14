using IndependienteStaFe.Services;
using IndependienteStaFe.Models;
using IndependienteStaFe.ViewModels;
using IndependienteStaFe.ViewModels.Base;
using Xamarin.Essentials;
using Xamarin.Forms;
using System;
using System.Threading.Tasks;
using Acr.UserDialogs;
using Xamarin.Forms.Xaml;

namespace IndependienteStaFe.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ListvideosPage : ContentPage
    {
        IUserDialogs Dialogs = UserDialogs.Instance;
        Repository repo = new Repository();
        public ListvideosPage()
        {
            InitializeComponent();
            Repository repo = new Repository();
            var videos = repo.getVideos();

            imagen.Source = videos.data[0].Image;
            videon.Text = videos.data[0].Name;
            videod.Text = videos.data[0].Date;

            Lista.ItemsSource = videos.data;

            
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

        public async void Home_Clicked(object sender, EventArgs e)
        {
            Application.Current.MainPage = new AppShell();
        }
        private void VideoClicked(object s, SelectedItemChangedEventArgs e)
        {

            var obj = (Videos.Data)e.SelectedItem;
            string param = obj.VideoId.ToString();
            var videos = repo.getVideoDetail(param).Result;
          
            VideoPage myHomePage = new VideoPage(obj);
            NavigationPage.SetHasNavigationBar(myHomePage, false);
            Navigation.PushModalAsync(myHomePage);

        }
        private void VideoClicked2(object sender,EventArgs e)
        {


            var param = repo.getVideos();
            var videos = repo.getVideoDetail(param.data[0].VideoId).Result;

            VideoPage myHomePage = new VideoPage(videos.data[0]);
            NavigationPage.SetHasNavigationBar(myHomePage, false);
            Navigation.PushModalAsync(myHomePage);

        }

    }
    
}
   