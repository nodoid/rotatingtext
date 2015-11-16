using System;

using Xamarin.Forms;

namespace rotatetext
{
    public class TextSpinClass
    {
        public string LineOfText { get; set; }

        public Color ColorOfText { get; set; }
    }

    public class App : Application
    {
        public App()
        {
            // The root page of your application
            MainPage = new NavigationPage(new TextScrollPage());
        }

        protected override void OnStart()
        {
            // Handle when your app starts
        }

        protected override void OnSleep()
        {
            // Handle when your app sleeps
        }

        protected override void OnResume()
        {
            // Handle when your app resumes
        }
    }
}

