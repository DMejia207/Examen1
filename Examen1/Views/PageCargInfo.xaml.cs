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
    public partial class PageCargInfo : ContentPage
    {
        public PageCargInfo()
        {
            InitializeComponent();
        }

        protected async override void OnAppearing()
        {
            base.OnAppearing();

            try
            {
                var location = await Geolocation.GetLocationAsync();

                if (location != null)
                {
                    txtlatitud.Text = Convert.ToString(location.Latitude);
                    txtlongitud.Text = Convert.ToString(location.Longitude);

                    Console.WriteLine($"Latitude: {location.Latitude}, Longitude: {location.Longitude}, Altitude: {location.Altitude}");
                }
            }
            catch (Exception ex)
            {
            }
        }

            private void ToolbarItem_Clicked(object sender, EventArgs e)
        {
            var pagenum = new Views.PageNumGuardados();
            Navigation.PushAsync(pagenum);
        }

    }
}