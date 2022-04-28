using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ToolbarAlignmentTester
{
    internal class NextPage : ContentPage
    {
        public NextPage()
        {
            Title = @"NextPage (I want the pop-up form to be full screen)
I just updated the RC1 version a few days ago, and the popup form is fullscreen. 

I use Android
But now I updated the RC2 version. I found that there was a problem with the method. When I called the pushmodalasync method, the pop-up page was not full screen. My Android application is carried out in a full screen way. There was no such problem before the RC2 version, but this problem suddenly appeared in the RC2 version, which makes me very depressed. I hope you take care of yourself and let me fill in the pit every time you update.";
            BackgroundColor = Colors.LimeGreen;
            ToolbarItems.Add(new ToolbarItem("Back", "", async () =>
            {
                await Application.Current.MainPage.Navigation.PopModalAsync();
            }, ToolbarItemOrder.Primary));

            Content = new Label { Text = "Can you see the top and the bottom area ?\r\n\r\n" + Title };
        }
    }
}
