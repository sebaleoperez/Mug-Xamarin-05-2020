using System;
using System.Collections.Generic;
using HolaMundo.Model;
using HolaMundo.Services;
using HolaMundo.ViewModel;
using Xamarin.Forms;

namespace HolaMundo.Views
{
    public partial class StarWars : ContentPage
    {
        public StarWars()
        {
            InitializeComponent();
        }

        protected async override void OnAppearing()
        {
            base.OnAppearing();

            await ((StarWarsViewModel)this.BindingContext).LoadViewModel();
        }
    }
}
