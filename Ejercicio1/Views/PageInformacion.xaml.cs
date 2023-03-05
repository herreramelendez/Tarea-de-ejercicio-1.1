using Ejercicio1.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Ejercicio1.Viows
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class PageInformacion : ContentPage
    {
        public PageInformacion()
        {
            InitializeComponent();
        }

        private async void btninformacion_Clicked(object sender, EventArgs e)
        {
            var info = new Models.Informacion
            {
                nombres = txtnombre.Text,
                apellidos = txtapellidos.Text,
                correo = txtcorreo.Text,
                edad = cbEdad.SelectedItem.ToString()

            };


            var page = new Views.PageResultado
            {
                BindingContext = info
            };
            await Navigation.PushModalAsync(page);

        }
    }
}