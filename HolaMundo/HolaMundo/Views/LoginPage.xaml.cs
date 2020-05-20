using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace HolaMundo.Views
{
    public partial class LoginPage : ContentPage
    {
        public LoginPage()
        {
            InitializeComponent();
        }

        protected override void OnAppearing()
        {
            base.OnAppearing();

            stackLayoutPrincipal.Children.Add(new Label()
            {
                Text = "Agregado desde el codigo",
                VerticalOptions = LayoutOptions.Center
            });
        }

        async void Button_Clicked(System.Object sender, System.EventArgs e)
        {
            if (entryUsuario.Text == "usuario" && entryClave.Text == "12345")
            {
                await DisplayAlert("Login", "Usuario Valido", "OK");
                //await Navigation.PushAsync(new PiedraPapelTijeraGrid());
                App.Current.MainPage = new NavigationPage(new PiedraPapelTijeraGrid());
            }
            else
            {
                await DisplayAlert("Login", "Usuario Invalido", "OK"); 
            }
        }
    }
}
