using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Xamarin.Forms;

namespace TabbedPage_with_NavigationPage
{
    public class RecordListPageCS : ContentPage //view C#で作った view contentPageに直した
    {
        public RecordListPageCS()
        {

            Title = "記録";
            Content = new StackLayout
            {
                Children = {
                    new Label { Text = "Welcome to RecordListPage!" ,
                    HorizontalOptions = LayoutOptions.Center,
                    VerticalOptions = LayoutOptions.CenterAndExpand
                    },
                }
            };
        }
    }
}

