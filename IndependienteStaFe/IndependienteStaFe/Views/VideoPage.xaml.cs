using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using IndependienteStaFe.Models;
using IndependienteStaFe.Services;
using Xamarin.Essentials;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace IndependienteStaFe.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class VideoPage : ContentPage
    {
        public VideoPage(Videos.Data videoDetail)
        {
            InitializeComponent();
            

            video.Source = videoDetail.Url;

        }
    }
}