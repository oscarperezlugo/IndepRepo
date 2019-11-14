using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Acr.UserDialogs;
using IndependienteStaFe.Services;
using IndependienteStaFe.Models;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace IndependienteStaFe.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class UserPage : ContentPage
    {
        public UserPage()
        {
            InitializeComponent();
            IUserDialogs Dialogs = UserDialogs.Instance;
            Repository repositorio = new Repository();
            userInfo userdef = repositorio.postUserInfo().Result;
            userPuntos userdet = repositorio.getGetUserPoints().Result;

            Nombre.Text = userdef.data.Name.ToString();
            Apellido.Text = userdef.data.LastName.ToString();
            Correo.Text = userdef.data.Email.ToString();
            Telefono.Text = userdef.data.CellNumber.ToString();
            Puntos.Text = userdet.Points.ToString();


        }
        private void RegClicked(object sender, EventArgs e)
        {
            Application.Current.MainPage = new AppShell();
        }

    }
}