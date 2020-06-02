using System;
using System.ComponentModel;
using System.Threading.Tasks;
using System.Windows.Input;
using HolaMundo.Views;
using Xamarin.Forms;

namespace HolaMundo.ViewModels
{
    public class LoginViewModel : INotifyPropertyChanged
    {
        public LoginViewModel()
        {
            LoginCommand = new Command(() => Login());
        }

        private string username;
        public string Username
        {
            get => username;
            set
            {
                username = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(Username)));
            }
        }

        private string password;
        public string Password
        {
            get => password;
            set
            {
                password = value; 
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(Password)));
            }
        }

        private ICommand loginCommand;
        public ICommand LoginCommand
        {
            get => loginCommand;
            set
            {
                loginCommand = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(LoginCommand)));
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;

        private async Task Login()
        {
            if (Username == "usuario" && Password == "12345")
            {
                App.Current.MainPage.DisplayAlert("Login", "Usuario Valido", "OK");
                //await Navigation.PushAsync(new PiedraPapelTijeraGrid());
                App.Current.MainPage = new NavigationPage(new PiedraPapelTijeraGrid());
            }
            else
            {
                await App.Current.MainPage.DisplayAlert("Login", "Usuario Invalido", "OK");
            }
        }
    }
}
