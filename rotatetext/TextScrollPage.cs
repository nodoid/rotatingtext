using System;

using Xamarin.Forms;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace rotatetext
{
    public class TextScrollPage : ContentPage
    {
        Label lblText;
        List<TextSpinClass> textList;
        int position = 0;

        public TextScrollPage()
        {
            if (Device.OS == TargetPlatform.iOS)
                Padding = new Thickness(0, 20, 0, 0);

            NavigationPage.SetHasNavigationBar(this, false);

            textList = new List<TextSpinClass>
            {
                new TextSpinClass { LineOfText = "MAN - BSN", ColorOfText = Color.Blue },
                new TextSpinClass { LineOfText = "21:30", ColorOfText = Color.Blue },
                new TextSpinClass { LineOfText = "NOW BOARDING", ColorOfText = Color.Green }
            };

            var btnNewPage = new Button
            {
                Text = "New page",
                Command = new Command(async () => await Navigation.PushAsync(new NextPage()))
            };

            lblText = new Label();

            var stack = new StackLayout
            {
                Orientation = StackOrientation.Vertical,
                Children =
                {
                    new StackLayout
                    {
                        VerticalOptions = LayoutOptions.Start,
                        HorizontalOptions = LayoutOptions.CenterAndExpand,
                        Children = { lblText }
                    },
                    new StackLayout
                    {
                        VerticalOptions = LayoutOptions.CenterAndExpand,
                        HorizontalOptions = LayoutOptions.CenterAndExpand,
                        Children = { btnNewPage }
                    }
                }
                    
            };
            Content = stack;

            Device.StartTimer(TimeSpan.FromSeconds(3), () =>
                {
                    lblText.Text = textList[position].LineOfText;
                    lblText.TextColor = textList[position].ColorOfText;
                    position++;
                    if (position == textList.Count)
                        position = 0;
                    return true;
                });
        }
    }
}


