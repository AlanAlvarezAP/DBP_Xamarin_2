﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using Xamarin.Forms.PlatformConfiguration.iOSSpecific;

namespace App8
{
    public partial class MainPage : ContentPage
    {

        public MainPage()
        {
            InitializeComponent();
        }

        private void Func_Lenguaje(object sender, EventArgs e)
        {
            if (Op_Lenguaje.SelectedItem?.ToString() == "Otro")
            {
                Lenguaje_Lenguaje.IsVisible = true;
            }
            else
            {
                Lenguaje_Lenguaje.IsVisible = false;
            }
        }

        private void Func_Idiom(object sender, EventArgs e)
        {
            if (Op_Idioma.SelectedItem?.ToString() == "Otro")
            {
                Idiom_Idiom.IsVisible = true;
            }
            else
            {
                Idiom_Idiom.IsVisible = false;
            }
        }

        private async void Enviar_Clicked(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(entryNombre.Text) || string.IsNullOrWhiteSpace(entryEdad.Text) || string.IsNullOrWhiteSpace(entryOcupacion.Text))
            {
                await DisplayAlert("Campos Obligatorios", "Por favor complete todos los campos obligatorios.", "OK");
                return;
            }
            var nombre = entryNombre.Text;
            var edad = entryEdad.Text;
            var ocupacion = entryOcupacion.Text;
            var fechaNacimiento = datePicker.Date.ToString("dd/MM/yyyy");
            var lenguajeProgramacion = Op_Lenguaje.SelectedItem?.ToString();
            var otroLenguaje = Lenguaje_Lenguaje.Text;
            var idioma = Op_Idioma.SelectedItem?.ToString();
            var otroIdioma = Idiom_Idiom.Text;


            var mensaje = $"Nombre: {nombre}\n" +
                          $"Edad: {edad}\n" +
                          $"Ocupación: {ocupacion}\n" +
                          $"Fecha de Nacimiento: {fechaNacimiento}\n" +
                          $"Lenguaje de Programación: {(lenguajeProgramacion == "Otro" ? otroLenguaje : lenguajeProgramacion)}\n" +
                          $"Idioma: {(idioma == "Otro" ? otroIdioma : idioma)}";

            await Navigation.PushAsync(new CV(mensaje));
        }

    }
}
