using IndependienteStaFe.Models;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace IndependienteStaFe.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class NewsDetailPage : ContentPage
    {
        public NewsDetailPage(NewsDetail newsDetail)
        {
            InitializeComponent();
            name.Text = newsDetail.data[0].Name;
            //content.Text = newsDetail.data[0].Content;
            content.Source = new HtmlWebViewSource
            {
            Html = @newsDetail.data[0].Content
            };
            image.Source = newsDetail.data[0].Image;
            date.Text = newsDetail.data[0].Date;
        }
    }
}