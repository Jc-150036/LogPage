using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Xamarin.Forms;

namespace TabbedPage_with_NavigationPage
{
    public class LogPageCS : ContentPage
    {
        public LogPageCS()
        {
            Title = "Log";
            Content = new StackLayout
            {
                Children = {
                    new Label {
                        Text = "Welcome to LogPa!",
                        HorizontalOptions = LayoutOptions.Center,
                        VerticalOptions = LayoutOptions.CenterAndExpand
                    },
                }
            };
        }
    }
}


