using System;
using System.ComponentModel;

namespace IndependienteStaFe.ViewModels
{
    public class RegisterViewModel : INotifyPropertyChanged
    {
        public Action DisplayInvalidLoginPrompt;
        public event PropertyChangedEventHandler PropertyChanged = delegate { };
    }
}
