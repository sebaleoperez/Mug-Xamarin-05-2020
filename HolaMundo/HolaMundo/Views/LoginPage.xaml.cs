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

        void Button_Clicked(System.Object sender, System.EventArgs e)
        {
            if (entryUsuario.Text == "usuario" && entryClave.Text == "12345")
            {
                DisplayAlert("Login", "Usuario Valido", "OK");
            }
            else
            {
                DisplayAlert("Login", "Usuario Invalido", "OK");
            }
        }
    }
}
