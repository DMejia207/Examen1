using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Essentials;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Examen1.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class PagePrincipal : ContentPage
    {
        public PagePrincipal()
        {
            InitializeComponent();
        }

        private async void btnguardar_Clicked(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtnombre.Text))
            {
                await DisplayAlert("Alerta", "Ingrese un Nombre.", "OK");
                txtnombre.Focus();

            }
            else

             if (string.IsNullOrEmpty(txtphone.Text))
            {
                await DisplayAlert("Alerta", "Ingrese un Numero de Telefono.", "OK");
                txtphone.Focus();

            }
            else

            if (string.IsNullOrEmpty(txtnota.Text))
            {
                await DisplayAlert("Alerta", "Ingrese una Nota.", "OK");
                txtnota.Focus();

            }
            else
            {
                var infor = new Models.Contactos
                {
                    nombres = txtnombre.Text,
                    apellidos = txtapellidos.Text,
                    phone = txtphone.Text,
                    nota = txtnota.Text,
                    pais = cbpais.SelectedItem.ToString(),
                    edad = cbedad.SelectedItem.ToString()
                };

                if (await App.DBlog.SaveListaa(infor) > 0)
                    await DisplayAlert("Alerta", "Usuario Ingresado con Exito", "OK");
                else
                    await DisplayAlert("Aviso", "Error", "OK");

                var page = new Views.PageCargInfo();
                page.BindingContext = infor;
                await Navigation.PushAsync(page);

                
            }
        }
      }
 }
