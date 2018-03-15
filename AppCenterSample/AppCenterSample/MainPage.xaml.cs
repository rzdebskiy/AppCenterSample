using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using Microsoft.AppCenter.Crashes;
using Microsoft.AppCenter.Analytics;

namespace AppCenterSample
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        async void btnCrash_Clicked(object sender, EventArgs e)
        {
            var crash = await DisplayAlert("The app will close", "A crash report will be sent when you reopen the app", "Crash app", "Cancel");
            if (crash)
            {
                Crashes.GenerateTestCrash();
            }
        }

        void btnSendError_Clicked(object sender, EventArgs e)
        {
            var properties = new Dictionary<string, string> { { "Category", "Music" }, { "Wifi", "On" } };
            Crashes.TrackError(new Exception("Something went wrong"), properties);
            DisplayAlert(null, "Error sent.", null, "OK");
        }

        void btnEvent_Clicked(object sender, EventArgs e)
        {
            Analytics.TrackEvent("Sample event", new Dictionary<string, string> { { "Color", "Yellow" } });
            DisplayAlert(null, "Event sent.", null, "OK");
        }
    }

}

