using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using Xamarin.Forms;

namespace Haibo.Views
{
    public partial class userSettings : ContentPage
    {
        public List<Setting> settings { get; set; }

        public userSettings()
        {
            InitializeComponent();

            //var account = this.FindByName<TextCell>("account");

            settings = new List<Setting>();

            settings.Add(new Setting { Id = Guid.NewGuid().ToString(), Name = "Account"});
            settings.Add(new Setting { Id = Guid.NewGuid().ToString(), Name = "Payment"});
            settings.Add(new Setting { Id = Guid.NewGuid().ToString(), Name = "Help"});
            settings.Add(new Setting { Id = Guid.NewGuid().ToString(), Name = "Billing" });
            settings.Add(new Setting { Id = Guid.NewGuid().ToString(), Name = "Log Out" });

            SettingsList.ItemsSource = settings;

        }

        async void OnItemSelected(object sender, SelectedItemChangedEventArgs args)
        {
            var settingSelected = args.SelectedItem as Setting;

            if (settingSelected == null)
                return;

            await DisplayAlert("Alert", "You pressed " + settingSelected.Name.ToString(), "OK");

            // await Navigation.PushAsync(new userEventDetailed(new ItemDetailViewModel(item)));

            await Navigation.PushAsync(new userHome());

            // Manually deselect item
            SettingsList.SelectedItem = null;
        }
    }
}
