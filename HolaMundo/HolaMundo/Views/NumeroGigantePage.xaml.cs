using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace HolaMundo.Views
{
    public partial class NumeroGigantePage : ContentPage
    {
        public NumeroGigantePage(int numero)
        {
            InitializeComponent();

            lblNumero.Text = numero.ToString();
            this.Title = numero.ToString();
        }
    }
}
