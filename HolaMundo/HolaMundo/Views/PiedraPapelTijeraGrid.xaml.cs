using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace HolaMundo.Views
{
    public partial class PiedraPapelTijeraGrid : ContentPage
    {
        Random random = new Random();

        public PiedraPapelTijeraGrid()
        {
            InitializeComponent();
        }

        void Button_Clicked(System.Object sender, System.EventArgs e)
        {
            Button button = (Button)sender;

            int eleccionComputadora = random.Next(1, 4);
            // si eleccion es 1 => piedra
            // si eleccion es 2 => papel
            // si eleccion es 3 => tijera

            if (eleccionComputadora == 1) LabelUltimaEleccion.Text = "Piedra";
            else if (eleccionComputadora == 1) LabelUltimaEleccion.Text = "Papel";
            else LabelUltimaEleccion.Text = "Tijera";

            if (button.Text == "Piedra")
            {
                if (eleccionComputadora == 2)
                {
                    DisplayAlert("Resultado", "Perdiste", "OK");
                    LabelPuntosComputadora.Text = (Convert.ToInt16(LabelPuntosComputadora.Text) + 1).ToString();
                }
                else if (eleccionComputadora == 3)
                {
                    DisplayAlert("Resultado", "Ganaste", "OK");
                    LabelMiPuntaje.Text = (Convert.ToInt16(LabelMiPuntaje.Text) + 1).ToString();
                }
                else
                    DisplayAlert("Resultado", "Empate", "OK");
            }
            else if (button.Text == "Papel")
            {
                if (eleccionComputadora == 3)
                {
                    DisplayAlert("Resultado", "Perdiste", "OK");
                    LabelPuntosComputadora.Text = (Convert.ToInt16(LabelPuntosComputadora.Text) + 1).ToString();
                }
                else if (eleccionComputadora == 1)
                {
                    DisplayAlert("Resultado", "Ganaste", "OK");
                    LabelMiPuntaje.Text = (Convert.ToInt16(LabelMiPuntaje.Text) + 1).ToString();
                }
                else
                    DisplayAlert("Resultado", "Empate", "OK");
            }
            else
            {
                // Tijera
                if (eleccionComputadora == 1)
                {
                    DisplayAlert("Resultado", "Perdiste", "OK");
                    LabelPuntosComputadora.Text = (Convert.ToInt16(LabelPuntosComputadora.Text) + 1).ToString();
                }
                else if (eleccionComputadora == 2)
                {
                    DisplayAlert("Resultado", "Ganaste", "OK");
                    LabelMiPuntaje.Text = (Convert.ToInt16(LabelMiPuntaje.Text) + 1).ToString();
                }
                else
                    DisplayAlert("Resultado", "Empate", "OK");
            }
        }
    }
}
