using IndependienteStaFe.Models;
using IndependienteStaFe.Services;
using Xamarin.Forms;

namespace IndependienteStaFe.ViewModels
{
    public class ListProductViewModel : BindableObject
    {
        Repository repo = new Repository();
        string token = "";
        Product productselected = new Product();
        public Command ItemTappedCommand
        {
            get
            {
                return new Command((data) =>
                {

                });
            }
        }
    }
}
