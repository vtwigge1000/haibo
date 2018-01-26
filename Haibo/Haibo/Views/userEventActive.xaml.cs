using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace Haibo
{
    public partial class userEventActive : ContentPage
    {
        activeEventViewModel viewModel;

        public userEventActive()
        {
            InitializeComponent();


            viewModel = new activeEventViewModel();

            Label heading = this.FindByName<Label>("Heading");
            heading.SetBinding(Label.TextProperty, "Text");
            heading.BindingContext = viewModel.CurrentEvent;

            

            Label description = this.FindByName<Label>("Description");
            description.SetBinding(Label.TextProperty, "Description");
            description.BindingContext = viewModel.CurrentEvent;

            //BindingContext = viewModel = new ViewModels.activeEventViewModel();

            /*var eventHistory = new NavigationPage(new userEventHistory());
            eventHistory.Title = "History";

            //var active = new NavigationPage(new userEventActive());

            //Children.Add(this);
            Children.Add(eventHistory);*/
        }
    }
}
