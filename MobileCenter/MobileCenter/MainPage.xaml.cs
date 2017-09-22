using Microsoft.Azure.Mobile.Analytics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace MobileCenter
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
            Analytics.TrackEvent("lllllllllllllllllllllllllllllllllllllllllllllllll");
        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            Analytics.TrackEvent("lllllllllllllllllllllllllllllllllllllllllllllllll");
        }
    }
}
