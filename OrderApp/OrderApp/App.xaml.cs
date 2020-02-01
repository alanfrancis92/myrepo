using System;
using OrderApp.View;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace OrderApp
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();
            
            MainPage = new NavigationPage(new CatalogView())
            {
                BarTextColor = Color.White,
                BarBackgroundColor = Color.FromHex("#212121")
            };
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
