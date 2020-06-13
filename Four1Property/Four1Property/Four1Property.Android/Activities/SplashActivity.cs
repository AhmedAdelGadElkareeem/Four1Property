using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.Content.PM;
using Android.OS;
using Android.Runtime;
using Android.Support.V7.App;
using Android.Views;
using Android.Widget;

namespace Four1Property.Droid.Activities
{
	[Activity(Label = "1111Property", Icon = "@drawable/Logo1", Theme = "@style/SplashTheme", MainLauncher = true, ConfigurationChanges = ConfigChanges.ScreenSize | ConfigChanges.Orientation)]
	public class SplashActivity : AppCompatActivity
	{

		protected override void OnCreate(Bundle savedInstanceState)
		{
			base.OnCreate(savedInstanceState);
			StartActivity(typeof(MainActivity));
			Finish();

			//// Disable activity slide-in animation
			//OverridePendingTransition(0, 0);
		}
	}
}