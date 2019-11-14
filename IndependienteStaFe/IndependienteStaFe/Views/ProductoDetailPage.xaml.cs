using Acr.UserDialogs;
using IndependienteStaFe.Models;
using System;
using System.Threading.Tasks;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace IndependienteStaFe.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ProductoDetailPage : ContentPage
    {
        ProductInfo productGracias = new ProductInfo();
        IUserDialogs Dialogs = UserDialogs.Instance;

        public ProductoDetailPage(ProductInfo product)
        {
            InitializeComponent();
            image.Source = product.data[0].Image;
            name.Text = product.data[0].Name;
            value.Text = product.data[0].Value;
            typepay.Text = product.data[0].TypePay;

            productGracias = product;

        }
        private async void BackEvetClicked(object sender, EventArgs e)
        {

            Dialogs.ShowLoading("Por Favor Espere...");
            await Task.Delay(2000);
            Dialogs.HideLoading();



            await Navigation.PopModalAsync(true);
        }

        private async void EvetClicked(object sender, EventArgs e)
        {

            Dialogs.ShowLoading("Por Favor Espere...");
            await Task.Delay(2000);
            Dialogs.HideLoading();

            GraciasxComprarPage myHomePage = new GraciasxComprarPage(productGracias);
            NavigationPage.SetHasNavigationBar(myHomePage, false);
            await Navigation.PushModalAsync(myHomePage);

        }
    }
}