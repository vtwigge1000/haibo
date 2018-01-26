using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace Haibo.Views
{
    public partial class userEventTab : TabbedPage
    {
        public userEventTab()
        {
            InitializeComponent();

            var eventActive = new NavigationPage(new userEventActive());
            eventActive.Title = "Active";

            var eventHistory = new NavigationPage(new userEventHistory());
            eventHistory.Title = "History";

            

            //var active = new NavigationPage(new userEventActive());

            Children.Add(eventActive);
            Children.Add(eventHistory);
        }
    }
}
