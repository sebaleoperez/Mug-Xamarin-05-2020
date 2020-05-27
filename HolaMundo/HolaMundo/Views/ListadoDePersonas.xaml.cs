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
            //Navigation.PushAsync(new NumeroGigantePage(Convert.ToInt16(e.Item.ToString())));
        }

        void Button_Clicked(System.Object sender, System.EventArgs e)
        {
            int numero = Convert.ToInt16(entryNumero.Text);

            List<Persona> personas = new List<Persona>();

            for (int i = 1; i <= numero; i++)
            {
                personas.Add(new Persona() {
                    Nombre = "Persona " + i.ToString(),
                    Rol = "Personaje de la lista",
                    Imagen = "https://upload.wikimedia.org/wikipedia/commons/thumb/7/7e/Musso_Udinese.png/245px-Musso_Udinese.png"
                });
            }
                
            listaPersonas.ItemsSource = personas;
        }
    }

    public class Persona
    {
        public string Nombre { get; set; }
        public ImageSource Imagen { get; set; }
        public string Rol { get; set; }
    }
}
