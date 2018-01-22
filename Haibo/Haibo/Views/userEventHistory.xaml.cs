using System;
using System.Collections.Generic;
using System.Threading.Tasks;

using Xamarin.Forms;

namespace Haibo.Views
{
    public partial class userEventHistory : ContentPage
    {

        EventsViewModel viewModel;


        public userEventHistory()
        {
            InitializeComponent();

            BindingContext = viewModel = new EventsViewModel();
        }

        async void OnItemSelected(object sender, SelectedItemChangedEventArgs args)
        {
            var eventItem = args.SelectedItem as Event;

            if (eventItem == null)
                return;

            // await Navigation.PushAsync(new userEventDetailed(new ItemDetailViewModel(item)));

            await Navigation.PushAsync(new userEventDetailed(new EventDetailedViewModel(eventItem)));

            // Manually deselect item
            EventsListView.SelectedItem = null;
        }

        protected override void OnAppearing()
        {
            base.OnAppearing();

            if (viewModel.Events.Count == 0)
                viewModel.LoadEventsCommand.Execute(null);
        }
    }
}
