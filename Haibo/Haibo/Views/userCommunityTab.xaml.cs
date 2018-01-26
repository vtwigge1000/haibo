using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace Haibo.Views
{
    public partial class userCommunityTab : TabbedPage
    {
        public userCommunityTab()
        {
            InitializeComponent();
            
            var commMap = new NavigationPage(new userCommunityMap());
            commMap.Title = "Map";
           

            var commChat = new NavigationPage(new userCommunityChat());
            commChat.Title = "Chat";



            //var active = new NavigationPage(new userEventActive());

            Children.Add(commMap);
            Children.Add(commChat);
        }
    }
}
