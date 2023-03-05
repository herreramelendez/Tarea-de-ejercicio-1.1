using System;
using Xamarin.Forms;
using Xamarin.Forms.PlatformConfiguration.macOSSpecific;
using Xamarin.Forms.Xaml;

namespace Ejercicio1
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new Xamarin.Forms.NavigationPage(new Viows.PageInformacion());
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
