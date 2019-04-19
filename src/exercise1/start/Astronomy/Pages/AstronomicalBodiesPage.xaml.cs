using Xamarin.Forms;

namespace Astronomy.Pages
{
    public partial class AstronomicalBodiesPage : ContentPage
    {
        public AstronomicalBodiesPage()
        {
            InitializeComponent();

            btnEarth.Clicked += (s, e) => Navigation.PushAsync(new AstronomicalBodyPage(SolarSystemData.Earth));
            btnMoon.Clicked += (s, e) => Navigation.PushAsync(new AstronomicalBodyPage(SolarSystemData.Moon));
            btnSun.Clicked += (s, e) => Navigation.PushAsync(new AstronomicalBodyPage(SolarSystemData.Sun));
            btnComet.Clicked += (s, e) => Navigation.PushAsync(new AstronomicalBodyPage(SolarSystemData.HalleysComet));
        }
    }
}