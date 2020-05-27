using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace HolaMundo.Views
{
    public partial class ListadoNumerosBindable : ContentPage
    {
        public ListadoNumerosBindable()
        {
            InitializeComponent();

            List<Cancion> elementos = new List<Cancion>();

            elementos.Add(new Cancion()
            {
                Nombre = "Rapsodia Bohemia",
                Artista = "Queen",
                Album = "Una noche en la opera",
                Puntaje = "*****"
            });
            elementos.Add(new Cancion()
            {
                Nombre = "Rapsodia Bohemia",
                Artista = "Queen",
                Album = "Una noche en la opera",
                Puntaje = "*****"
            });
            elementos.Add(new Cancion()
            {
                Nombre = "Rapsodia Bohemia",
                Artista = "Queen",
                Album = "Una noche en la opera",
                Puntaje = "*****"
            });
            elementos.Add(new Cancion()
            {
                Nombre = "Rapsodia Bohemia",
                Artista = "Queen",
                Album = "Una noche en la opera",
                Puntaje = "*****"
            });
            elementos.Add(new Cancion()
            {
                Nombre = "Rapsodia Bohemia",
                Artista = "Queen",
                Album = "Una noche en la opera",
                Puntaje = "*****"
            });


            ContextoGeneral contextoGeneral = new ContextoGeneral();
            contextoGeneral.ListaCanciones = elementos;

            this.BindingContext = contextoGeneral;
        }
    }

    public class Cancion
    {
        public string Nombre { get; set; }
        public string Artista { get; set; }
        public string Album { get; set; }
        public string Puntaje { get; set; }
    }

    public class ContextoGeneral
    {
        public List<Cancion> ListaCanciones { get; set; }
    }
}
