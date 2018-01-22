using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace Haibo.Views
{
    public partial class userEventDetailed : ContentPage
    {
        EventDetailedViewModel viewModel;
        
        public userEventDetailed()
        {
            InitializeComponent();

            var eventItem = new Event
            {
                Text = "Item 1",
                Description = "This is an item description."
            };

            viewModel = new EventDetailedViewModel(eventItem);
            BindingContext = viewModel;
        }

        public userEventDetailed(EventDetailedViewModel viewModel)
        {
            InitializeComponent();

            BindingContext = this.viewModel = viewModel;
        }
    }
}
