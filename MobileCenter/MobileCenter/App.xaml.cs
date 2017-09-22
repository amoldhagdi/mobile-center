using Microsoft.Azure.Mobile.Analytics;
using Microsoft.Azure.Mobile.Crashes;
using Microsoft.Azure.Mobile.Push;
using Xamarin.Forms;

namespace MobileCenter
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new MobileCenter.MainPage();
        }

        protected override void OnStart()
        {
            try
            {
                Microsoft.Azure.Mobile.MobileCenter.Start("android=" + StaticConstants.AndroidAppKey + ";" +
                         "ios=" + StaticConstants.IOSAppKey + ";",
                         typeof(Analytics), typeof(Crashes), typeof(Push));
            }
            catch (System.Exception ex)
            {

            }
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
