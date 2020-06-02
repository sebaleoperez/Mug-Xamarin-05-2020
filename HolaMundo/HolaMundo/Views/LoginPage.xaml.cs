using System;
using System.Collections.Generic;
using HolaMundo.ViewModels;
using Xamarin.Forms;

namespace HolaMundo.Views
{
    public partial class LoginPage : ContentPage
    {
        public LoginPage()
        {
            InitializeComponent();

            BindingContext = new LoginViewModel();
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
    }
}
