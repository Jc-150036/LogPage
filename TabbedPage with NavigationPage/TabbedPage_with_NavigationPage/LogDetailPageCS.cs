using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Xamarin.Forms;

namespace TabbedPage_with_NavigationPage
{
    public class LogDetailPageCS : ContentPage
    {
        public LogDetailPageCS()
        {
            Title = "Log詳細";
            Content = new StackLayout
            {
                Children = {
                    new Label {
                        Text = "Welcome to Log詳細Page!",
                        HorizontalOptions = LayoutOptions.Center,
                        VerticalOptions = LayoutOptions.CenterAndExpand
                    },
                }
            };
        }
    }
}
