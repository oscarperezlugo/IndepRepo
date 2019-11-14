using Acr.UserDialogs;
using IndependienteStaFe.Models;
using System;
using System.Threading.Tasks;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace IndependienteStaFe.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class GraciasxComprarPage : ContentPage
    {
        IUserDialogs Dialogs = UserDialogs.Instance;

        public GraciasxComprarPage(ProductInfo product)
        {
            InitializeComponent();
            image.Source = product.data[0].Image;
            name.Text = product.data[0].Name;

        }

        private async void EvetClicked(object sender, EventArgs e)
        {

            Dialogs.ShowLoading("Por Favor Espere...");
            await Task.Delay(2000);
            Dialogs.HideLoading();



            await Navigation.PopModalAsync(true);


        }
    }
}