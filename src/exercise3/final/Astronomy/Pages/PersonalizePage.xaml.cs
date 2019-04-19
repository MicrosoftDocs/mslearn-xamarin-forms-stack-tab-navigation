using System;
using Xamarin.Forms;

namespace Astronomy
{
    public partial class PersonalizePage : ContentPage
    {
        public PersonalizePage ()
        {
            InitializeComponent();

            btnSave.Clicked += BtnSaveClicked;
            btnCancel.Clicked += BtnCancelClicked;

            string name = string.Empty;
            string icon = string.Empty;

            if (Application.Current.Properties.ContainsKey("Name"))
                name = Application.Current.Properties["Name"] as string;

            if (Application.Current.Properties.ContainsKey("Icon"))
                icon = Application.Current.Properties["Icon"] as string;

            entryName.Text = name;
            pickerIcon.SelectedItem = icon;
        }

        async void BtnCancelClicked(object sender, EventArgs e)
        {
            await this.Navigation.PopModalAsync();
        }

        async void BtnSaveClicked(object sender, EventArgs e)
        {
            Application.Current.Properties["Name"] = entryName.Text;
            Application.Current.Properties["Icon"] = pickerIcon.SelectedItem as string;

            await Application.Current.SavePropertiesAsync();

            await this.Navigation.PopModalAsync();
        }
    }
}