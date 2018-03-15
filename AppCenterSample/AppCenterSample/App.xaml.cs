using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.AppCenter;
using Microsoft.AppCenter.Analytics;
using Microsoft.AppCenter.Crashes;

using Xamarin.Forms;

namespace AppCenterSample
{
	public partial class App : Application
	{
		public App ()
		{
			InitializeComponent();

			MainPage = new AppCenterSample.MainPage();
		}

		protected override void OnStart ()
		{
            AppCenter.Start("android=77083321-275b-43ce-8c3d-e8aec5a400c9;" + "uwp={Your UWP App secret here};" + "ios={Your iOS App secret here}", typeof(Analytics), typeof(Crashes));
        }

		protected override void OnSleep ()
		{
			// Handle when your app sleeps
		}

		protected override void OnResume ()
		{
			// Handle when your app resumes
		}
	}
}
