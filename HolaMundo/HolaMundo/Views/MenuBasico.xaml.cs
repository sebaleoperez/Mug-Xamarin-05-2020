using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace HolaMundo.Views
{
    public partial class MenuBasico : ContentPage
    {
        public MenuBasico()
        {
            InitializeComponent();

        }

        void TapGestureRecognizer_Tapped(System.Object sender, System.EventArgs e)
        {
            Label label = (Label)sender;

            if (label.Text == "Perros")
                App.MenuPrincipal.Detail = new Perros();
            else
                App.MenuPrincipal.Detail = new Gatos();

            App.MenuPrincipal.IsPresented = false;
        }
    }
}
