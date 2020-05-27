using System;
using HolaMundo.Views;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace HolaMundo
{
    public partial class App : Application
    {
        public static MasterDetailPage MenuPrincipal;


        public App()
        {
            InitializeComponent();

            /*
            TabbedPage tabbedPage = new TabbedPage();
            tabbedPage.Children.Add(new NumeroGigantePage(1));
            tabbedPage.Children.Add(new NumeroGigantePage(2));
            tabbedPage.Children.Add(new NumeroGigantePage(3));
            tabbedPage.Children.Add(new NumeroGigantePage(4));
            tabbedPage.Children.Add(new NumeroGigantePage(5));
            */

            /*
            MasterDetailPage masterDetailPage = new MasterDetailPage();

            masterDetailPage.Master = new MenuBasico();
            masterDetailPage.Detail = new SeleccionarAnimal();

            MenuPrincipal = masterDetailPage;

            MainPage = masterDetailPage;
            */

            MainPage = new NavigationPage(new ListadoNumerosBindable());

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
