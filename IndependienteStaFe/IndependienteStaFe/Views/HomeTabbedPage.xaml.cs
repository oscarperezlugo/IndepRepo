using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace IndependienteStaFe.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class HomeTabbedPage : TabbedPage
    {
        public HomeTabbedPage()
        {
            InitializeComponent();

            if (Application.Current.Properties.ContainsKey("MenuName"))
            {
                var menuName = Application.Current.Properties["MenuName"].ToString();
                if (menuName == "Noticias")
                {
                    this.CurrentPage = Children[1];
                }
            }
        }
        public void Logout_Clicked(object sender, EventArgs e)
        {
            Application.Current.MainPage = new LoginPage();

        }
    }
}