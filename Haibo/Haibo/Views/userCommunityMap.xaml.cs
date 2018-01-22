using System;
using System.Collections.Generic;

using Xamarin.Forms;
using Xamarin.Forms.Maps;

using Plugin.Geolocator;



namespace Haibo.Views
{
    public partial class userCommunityMap : ContentPage
    {
        public userCommunityMap()
        {
            InitializeComponent();
            setUpMap();
        }

        async public void setUpMap()
        {
            var locator = CrossGeolocator.Current;

            var position = await locator.GetPositionAsync(TimeSpan.FromSeconds(10000), null, true);

            var map = new Map(
           MapSpan.FromCenterAndRadius(
                   new Position(position.Latitude, position.Longitude), Distance.FromMiles(0.3)))
            {
                IsShowingUser = true,
                HorizontalOptions = LayoutOptions.FillAndExpand,
                VerticalOptions = LayoutOptions.FillAndExpand
            };


            var stack = new StackLayout { Spacing = 0 };
            stack.Children.Add(map);
            Content = stack;

        }
    }
}
