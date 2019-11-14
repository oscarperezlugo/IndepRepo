using IndependienteStaFe.Services;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace IndependienteStaFe.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ListNewHorizontal : ContentView
    {
        Repository repo = new Repository();
        public ListNewHorizontal()
        {
            InitializeComponent();
            //var news = repo.getNews();
            // MessagesListView.ItemsSource = news.data;

            var padding = (MessagesListView.Width - MessagesListView.Height) / 20;

            MessagesListView.HeightRequest = MessagesLayoutFrame.Width;
            MessagesLayoutFrameInner.WidthRequest = MessagesLayoutFrame.Width;
            MessagesLayoutFrameInner.Padding = new Thickness(0);
            MessagesLayoutFrame.Padding = new Thickness(0);
            MessagesLayoutFrame.IsClippedToBounds = true;
            Xamarin.Forms.AbsoluteLayout.SetLayoutBounds(MessagesLayoutFrameInner, new Rectangle(0, 0 - padding, AbsoluteLayout.AutoSize, MessagesListView.Height - padding));
            MessagesLayoutFrameInner.IsClippedToBounds = true;
            // */
        }



    }
}