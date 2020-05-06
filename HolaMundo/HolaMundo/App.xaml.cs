using System;
using HolaMundo.Views;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace HolaMundo
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new ListadoNumeros();
        }

        protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}
