using Astronomy.Pages;
using Xamarin.Forms;

namespace Astronomy
{
    public partial class MainPage : TabbedPage
    {
        public MainPage()
        {
            InitializeComponent();

            this.Children.Add(new SunrisePage());
            this.Children.Add(new MoonPhasePage());
            this.Children.Add(new AboutPage());
        }
    }
}
