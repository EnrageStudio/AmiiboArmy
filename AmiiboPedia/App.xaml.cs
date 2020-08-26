using AmiiboPedia.Views.Onboarding;
using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace AmiiboPedia
{
    public partial class App : Application
    {
        public static string BaseImageUrl { get; } = "https://cdn.syncfusion.com/essential-ui-kit-for-xamarin.forms/common/uikitimages/";
        public App()
        {
            InitializeComponent();
            NavigationPage navigationPage = new NavigationPage(new MainPage());
            navigationPage.BarBackgroundColor = Color.Black;
            navigationPage.BarTextColor = Color.White;
            MainPage = navigationPage;
        }

        protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}
