using System;

using Xamarin.Forms;

namespace ImageSample
{
    public class App : Application
    {
        public App()
        {
            //MainPage = new ImagePage();
            //MainPage = new Image_AspectAll_LayoutDefaultPage();
            MainPage = new Image_AspectAll_LayoutFillPage();
            return;
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

