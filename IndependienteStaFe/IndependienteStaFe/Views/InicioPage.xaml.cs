using Acr.UserDialogs;
using IndependienteStaFe.Models;
using IndependienteStaFe.Services;
using IndependienteStaFe.ViewModels;
using IndependienteStaFe.ViewModels.Base;
using System;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Essentials;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace IndependienteStaFe.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class InicioPage : ContentPage
    {
        public ICommand Command { get; private set; }
        public partial class CustomerNavigationPage : NavigationPage
        {

            public CustomerNavigationPage() : base(new ListnewsPage()) { BarBackgroundColor = Color.FromHex("FFFF"); }

        }

        IUserDialogs Dialogs = UserDialogs.Instance;
        Repository repo = new Repository();
        private int counter = 60;
        DateTime endTime = new DateTime();
        string token = "";
        Game partido = new Game();
        string cTimer;
        System.Timers.Timer timer;


        public InicioPage()
        {
            InitializeComponent();
            BindingContext = new CountdownViewModel();
            var current = Connectivity.NetworkAccess;
            var profiles = Connectivity.ConnectionProfiles;
            News news = new News();

           

            if (current == NetworkAccess.Internet)
            {
                string limit = "4";
                if (App.Current.Properties.ContainsKey("token"))
                {
                    token = App.Current.Properties["token"].ToString();
                }
                news = repo.getNews(token, limit).Result;
                imagen.Source = news.data[0].Image;
                noticiad.Text = news.data[0].Name.ToString();
                var videos = repo.getVideos();
                imagen0.Source = videos.data[0].Image;
                imagen1.Source = videos.data[1].Image;
                imagen2.Source = videos.data[2].Image;
                imagen3.Source = videos.data[3].Image;
                Texto0.Text = videos.data[0].Name;
                Texto1.Text = videos.data[1].Name;
                Texto2.Text = videos.data[2].Name;
                Texto3.Text = videos.data[3].Name;
                Lista.ItemsSource = news.data;                
                var game = repo.getPartidos("3").Result;
                visitante.Source = game.data[0].VisitorShield;
                local.Source = game.data[0].LocalShield;
                localn.Text = game.data[0].LocalTeamName;
                visita.Text = game.data[0].VisitorTeamName;
                dategame.Text = game.data[0].DateGame;
                sitio.Text = game.data[0].Stadium;
                gamenamex.Text = game.data[0].GameName;
                fecha1.Text = videos.data[0].Date;
                fecha2.Text = videos.data[1].Date;
                fecha3.Text = videos.data[2].Date;
                fecha4.Text = videos.data[3].Date;

                //countdown.Text = StartCountDownTimer();

            }
            else
            {
                Lista.ItemsSource = news.data;

            }


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

        public async void Noticias_Clicked(object sender, EventArgs e)
        {
            Dialogs.ShowLoading("Espere por favor...");
            await Task.Delay(2000);
            Dialogs.HideLoading();

            ListnewsPage myHomePage = new ListnewsPage();
            NavigationPage.SetHasNavigationBar(myHomePage, true);
            await Navigation.PushModalAsync(myHomePage);
        }

        public async void Videos_Clicked(object sender, EventArgs e)
        {
            Dialogs.ShowLoading("Espere por favor...");
            await Task.Delay(2000);
            Dialogs.HideLoading();

            ListvideosPage myHomePage = new ListvideosPage();
            NavigationPage.SetHasNavigationBar(myHomePage, true);
            await Navigation.PushModalAsync(myHomePage);
        }

        private void VideoClicked(object sender, EventArgs e)
        {
            var videos = repo.getVideos();
        
            VideoPage myHomePage = new VideoPage(videos.data[0]);
            NavigationPage.SetHasNavigationBar(myHomePage, false);
            Navigation.PushModalAsync(myHomePage);

        }

        private void VideoClicked1(object sender, EventArgs e)
        {
            var videos = repo.getVideos();

            VideoPage myHomePage = new VideoPage(videos.data[1]);
            NavigationPage.SetHasNavigationBar(myHomePage, false);
            Navigation.PushModalAsync(myHomePage);

        }

        private void VideoClicked2(object sender, EventArgs e)
        {
            var videos = repo.getVideos();

            VideoPage myHomePage = new VideoPage(videos.data[2]);
            NavigationPage.SetHasNavigationBar(myHomePage, false);
            Navigation.PushModalAsync(myHomePage);

        }

        private void VideoClicked3(object sender, EventArgs e)
        {
            var videos = repo.getVideos();

            VideoPage myHomePage = new VideoPage(videos.data[3]);
            NavigationPage.SetHasNavigationBar(myHomePage, false);
            Navigation.PushModalAsync(myHomePage);

        }

        public async void Register_Clicked(object sender, EventArgs e)
        {
            Dialogs.ShowLoading("Espere por favor...");
            await Task.Delay(6000);
            Dialogs.HideLoading();

            RegisterPage myHomePage = new RegisterPage();
            NavigationPage.SetHasNavigationBar(myHomePage, true);
            await Navigation.PushModalAsync(myHomePage);
        }
        public async void Membership_Clicked(object sender, EventArgs e)
        {
            Dialogs.ShowLoading("Espere por favor...");
            await Task.Delay(2000);
            Dialogs.HideLoading();

            MembemshipPage myHomePage = new MembemshipPage();
            NavigationPage.SetHasNavigationBar(myHomePage, true);
            await Navigation.PushModalAsync(myHomePage);
        }
        private void EvetClicked(object s, SelectedItemChangedEventArgs e)
        {

            var obj = (News.Data)e.SelectedItem;
            string param = obj.NewsId.ToString();
            NewsDetail newsdetail = repo.getNewsDetail(param).Result;


            NewsDetailPage myHomePage = new NewsDetailPage(newsdetail);
            NavigationPage.SetHasNavigationBar(myHomePage, false);
            Navigation.PushModalAsync(myHomePage);

        }

        private void EvetClicked2(object sender, EventArgs e)
        {
            var param = repo.getNews("","1").Result;
            var news = repo.getNewsDetail(param.data[0].NewsId).Result;

       


            NewsDetailPage myHomePage = new NewsDetailPage(news);
            NavigationPage.SetHasNavigationBar(myHomePage, false);
            Navigation.PushModalAsync(myHomePage);

        }

        protected override async void OnAppearing()
        {
            base.OnAppearing();
            var vm = BindingContext as BaseViewModel;
            await vm?.LoadAsync();
        }

        protected override async void OnDisappearing()
        {
            base.OnDisappearing();
            var vm = BindingContext as BaseViewModel;
            await vm?.UnloadAsync();
        }


        //public string StartCountDownTimer()
        //{
        //    endTime = Convert.ToDateTime(partido.data[0].DateGame);
        //    timer = new System.Timers.Timer();
        //    timer.Interval = 1000;
        //    timer.Elapsed += t_Tick;
        //     TimeSpan ts = endTime - DateTime.Now;
        //     cTimer = ts.ToString("d' Días 'h' Horas 'm' Minutos 's' Segundos'");
        //     timer.Start();
        //     if ((ts.TotalMilliseconds < 0) || (ts.TotalMilliseconds < 1000))
        //     {
        //         timer.Stop();
        //      }
        //     return cTimer;
        // }

        // void t_Tick(object sender, EventArgs e)
        // {
        //     TimeSpan ts = endTime - DateTime.Now;
        //      cTimer = ts.ToString("'d' Días 'h' Horas 'm' Minutos 's' Segundos'");
        //      counter--;
        //      if (counter == 0)
        //         timer.Stop();
        //  if ((ts.TotalMilliseconds < 0) || (ts.TotalMilliseconds < 1000))
        // {
        //     timer.Stop();
        //  }
        // }
    }
}