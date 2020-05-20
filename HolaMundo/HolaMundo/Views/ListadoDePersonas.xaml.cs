using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace HolaMundo.Views
{
    public partial class ListadoDePersonas : ContentPage
    {
        public ListadoDePersonas()
        {
            InitializeComponent();
        }

        void listaPersonas_ItemTapped(System.Object sender, Xamarin.Forms.ItemTappedEventArgs e)
        {
            Navigation.PushAsync(new NumeroGigantePage(Convert.ToInt16(e.Item.ToString())));
        }

        void Button_Clicked(System.Object sender, System.EventArgs e)
        {
            int numero = Convert.ToInt16(entryNumero.Text);

            List<string> numeros = new List<string>();

            for (int i = 1; i <= numero; i++)
                numeros.Add(i.ToString());

            listaPersonas.ItemsSource = numeros;
        }
    }
}
