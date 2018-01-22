using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace Haibo.Views
{
    public partial class userEventActive : TabbedPage
    {
        public userEventActive()
        {
            InitializeComponent();

            var eventHistory = new NavigationPage(new userEventHistory());
            eventHistory.Title = "History";

            //var active = new NavigationPage(new userEventActive());

            //Children.Add(this);
            Children.Add(eventHistory);
        }
    }
}
