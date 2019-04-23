using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Astronomy
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new Astronomy.MainPage();
        }

        protected override void OnSleep()
        {
            // Handle when your app sleeps
        }

        protected override void OnResume()
        {
            // Handle when your app resumes
        }
    }
}
