using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Xamarin.Forms;

namespace TabbedPage_with_NavigationPage //content C#で作った
{
    public class MainPageCS : TabbedPage
    {
        public MainPageCS()
        {
            var navigationPage = new NavigationPage(new GraphPageCS ());
            navigationPage.Icon = "ic_home.png";
            navigationPage.Title = "ボディー統計";

            var navigationPage2 = new NavigationPage(new RecordListPageCS ());
            navigationPage2.Icon = "ic_home.png";
            navigationPage2.Title = "記録";

            var navigationPage3 = new NavigationPage(new RMPageCS ());
            navigationPage3.Icon = "ic_home.png";
            navigationPage3.Title = "RM計算";

            Children.Add(navigationPage);
            Children.Add(navigationPage2);
            Children.Add(navigationPage3);
        }
    }
}


