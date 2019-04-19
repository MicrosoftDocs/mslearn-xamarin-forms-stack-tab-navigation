using Astronomy.Pages;
using Xamarin.Forms;

namespace Astronomy
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();

            NavigationPage.SetBackButtonTitle(this, "Menu");

            btnSunrise.Clicked += (s, e) => Navigation.PushAsync(new SunrisePage());
            btnMoonPhase.Clicked += (s, e) => Navigation.PushAsync(new MoonPhasePage());
            btnSpaceInfo.Clicked += (s, e) => Navigation.PushAsync(new AstronomicalBodiesPage());
            btnAbout.Clicked += (s, e) => Navigation.PushAsync(new AboutPage());
            btnPersonalize.Clicked += (s, e) => Navigation.PushModalAsync(new PersonalizePage());
        }

        protected override void OnAppearing()
        {
            base.OnAppearing();

            string name = string.Empty;
            string icon = string.Empty;

            if (Application.Current.Properties.ContainsKey("Name"))
                name = Application.Current.Properties["Name"] as string;

            if (Application.Current.Properties.ContainsKey("Icon"))
                icon = Application.Current.Properties["Icon"] as string;

            lblWelcome.Text = $"Welcome Captain {name} {icon} - let's explore!";
        }
    }
}
