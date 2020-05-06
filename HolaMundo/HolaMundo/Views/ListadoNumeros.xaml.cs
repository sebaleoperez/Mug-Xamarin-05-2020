using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace HolaMundo.Views
{
    public partial class ListadoNumeros : ContentPage
    {
        public ListadoNumeros()
        {
            InitializeComponent();
        }

        protected override void OnAppearing()
        {
            base.OnAppearing();

            Entry entry = new Entry();
            entry.Keyboard = Keyboard.Numeric;
            entry.Placeholder = "Ingrese un numero";

            Button boton = new Button();
            boton.Text = "Aceptar";

            ScrollView scrollNumeros = new ScrollView();

            StackLayout stackNumeros = new StackLayout();

            scrollNumeros.Content = stackNumeros;

            boton.Clicked += (sender, args) =>
            {
                stackNumeros.Children.Clear();

                for (int i = 0; i < Convert.ToInt16(entry.Text); i++)
                {
                    stackNumeros.Children.Add(new Label()
                    {
                        Text = i.ToString()
                    });
                }
            };

            stackPrincipal.Children.Add(entry);
            stackPrincipal.Children.Add(boton);
            stackPrincipal.Children.Add(scrollNumeros);
        }
    }
}
