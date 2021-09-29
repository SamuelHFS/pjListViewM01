using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace ListViewM01
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new ListView03xaml();
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
