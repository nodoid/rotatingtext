using System;

using Xamarin.Forms;

namespace rotatetext
{
    public class NextPage : ContentPage
    {
        public NextPage()
        {
            Content = new StackLayout
            { 
                Children =
                {
                    new Label { Text = "Hello ContentPage" }
                }
            };
        }
    }
}


