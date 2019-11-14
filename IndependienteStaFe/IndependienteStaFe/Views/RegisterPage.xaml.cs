using Acr.UserDialogs;
using IndependienteStaFe.Helpers;
using IndependienteStaFe.Models;
using IndependienteStaFe.Services;
using System;
using System.Threading.Tasks;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace IndependienteStaFe.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class RegisterPage : CarouselPage
    {
        IUserDialogs Dialogs = UserDialogs.Instance;
        public RegisterPage()
        {
            InitializeComponent();

            Repository repo = new Repository();

            var termconds = "";// repo.getTermConds();
            var poldatos = repo.getPolDatos();

            Ciudades listciudades = repo.getCiudades();

            fechaNacimiento.MaximumDate = DateTime.Parse(DateTime.Now.Month.ToString() + "-" + DateTime.Now.Day.ToString() + "-" + (DateTime.Now.Year - 18).ToString());

            foreach (var item in listciudades.data)
            {

                ciudad.Items.Add(item.Name);
                ciudad.Items.IndexOf(item.id.ToString());

            }

            //lbltermconds.Source = new HtmlWebViewSource
            //{
                // Html = termconds.data[0].Name.ToString() + "<br/>" + termconds.data[0].Content
              //  Html = ""
            //};

            //lblpoldatos.Source = new HtmlWebViewSource
            //{
            //    Html = @poldatos.data[0].Content
            //};


        }
        public async void OnClickedFinalizar(object sender, EventArgs args)
        {
            if (nombre.Text != null && password.Text != null && correo.Text != null && password.Text != null && telefono.Text != null && password.Text.Equals(passwordconf.Text))
            {
                //MD5HashX2 pwtohash = new MD5HashX2();

                User usuario = new User();
                usuario.name = nombre.Text;
                usuario.lastname = apellido.Text;
                usuario.id = userid.Text;
                usuario.email = correo.Text;
                usuario.password = password.Text;
                usuario.city = ciudad.SelectedIndex.ToString();
                usuario.address = address.Text;
                usuario.cellnumber = telefono.Text;
                usuario.gender = lstViewGeneros.SelectedItem.ToString();
                usuario.birdhdate = fechaNacimiento.Date;
                usuario.datapolicy = true;
                usuario.termsandconditions = true;


                Repository repository = new Repository();

                try
                {

                    userCreate user = repository.postUserCreate(usuario).Result;
                    Dialogs.ShowLoading(user.Message.ToString()); ;
                    await Task.Delay(2000);
                    Dialogs.HideLoading();
                    UserPage myHomePage = new UserPage();
                    NavigationPage.SetHasNavigationBar(myHomePage, false);
                    await Navigation.PushModalAsync(myHomePage);
                }

                catch (Exception ex)
                {
                    await DisplayAlert("Registrarse Error", ex.Message, "Gracias");

                }

            }


            else
            {
                await DisplayAlert("Registrarse", "Verifique la Información", "Gracias");
            }

        }


        public void OnClickedNext1(object sender, EventArgs e)
        {
            CurrentPage = page2;

        }

        public void OnClickedNext2(object sender, EventArgs e)
        {
            CurrentPage = page3;

        }

        public void OnClickedNext3(object sender, EventArgs e)
        {
            CurrentPage = page4;

        }
        public void OnClickedBack(object sender, EventArgs e)
        {
            CurrentPage = page1;

        }

        public void OnClickedBack1(object sender, EventArgs e)
        {
            CurrentPage = page2;

        }

        private void FechaNacimiento_DateSelected(object sender, DateChangedEventArgs e)
        {

        }
    }
}