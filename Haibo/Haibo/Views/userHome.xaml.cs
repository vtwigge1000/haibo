using System;
using System.Collections.Generic;

using Xamarin.Forms;
using Xamarin.Forms.Maps;

using Plugin.Geolocator;

namespace Haibo.Views
{
    public partial class userHome : ContentPage
    {
        public userHome()
        {
            InitializeComponent();
            setUpMap();
        }

        async public void setUpMap()
        {
            var locator = CrossGeolocator.Current;

            var position = await locator.GetPositionAsync(TimeSpan.FromSeconds(10000), null, true);
           

            var map = this.FindByName<Map>("HomeMap");
            map.MoveToRegion(MapSpan.FromCenterAndRadius(
                  new Position(position.Latitude, position.Longitude), Distance.FromKilometers(0.8)));
            map.IsShowingUser = true;
            map.HorizontalOptions = LayoutOptions.FillAndExpand;
            map.VerticalOptions = LayoutOptions.FillAndExpand;

          

           /* Button sosButton = new Button();
            sosButton.Text = "SOS";
            sosButton.TextColor = Color.White;
            sosButton.BackgroundColor = Color.FromHex("#00A3CC");
            sosButton.BorderRadius = 5;
            sosButton.Opacity = 1;
            sosButton.HeightRequest = 50;
            sosButton.HorizontalOptions = LayoutOptions.CenterAndExpand;
            sosButton.VerticalOptions = LayoutOptions.End;
            sosButton.Margin = 50;*/

            Grid grid = this.FindByName<Grid>("gridHome");
            Content = grid;
        }
        
    }
}
