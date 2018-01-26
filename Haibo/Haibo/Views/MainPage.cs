using System;

using Xamarin.Forms;

namespace Haibo
{
    public class MainPage : TabbedPage
    {
        public MainPage()
        {
            Page homePage, eventCurrPage, communityPage, settingsPage = null;
            NavigationPage.SetHasNavigationBar(this, false);

            switch (Device.RuntimePlatform)
            {
                case Device.iOS:
                    homePage = new NavigationPage(new Views.userHome())
                    {
                        Icon = "ic_home.png"
                    };

                    eventCurrPage = new NavigationPage(new Views.userEventTab())
                    {
                        Icon = "ic_notifications.png"
                    };

                    communityPage = new NavigationPage(new Views.userCommunityTab())
                    {
                        Icon = "ic_speaker_notes.png"
                    };

                    settingsPage = new NavigationPage(new Views.userSettings())
                    {
                        Icon = "ic_settings.png"
                    };
                    break;
                default:
                    homePage = new Views.userHome()
                    {
                        Icon = "ic_home.png"
            };
                    eventCurrPage = new Views.userEventTab()
                    {
                        Icon = "ic_notifications.png"
                    };

                    communityPage = new Views.userCommunityTab()
                    {
                        Icon = "ic_speaker_notes.png"
                    };

                    settingsPage = new Views.userSettings()
                    {
                        Icon = "ic_settings.png"
                    };
                    break;
            }

            Children.Add(homePage);
            Children.Add(eventCurrPage);
            Children.Add(communityPage);
            Children.Add(settingsPage);
            
        }

        

        protected override void OnCurrentPageChanged()
        {
            base.OnCurrentPageChanged();
        }
    }
}
