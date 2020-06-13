using System;

using Android.App;
using Android.Content.PM;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Android.OS;
using Xamarin.Forms;
using Four1Property.View;
using Acr.UserDialogs;
using Plugin.Permissions;
using Plugin.CurrentActivity;
using View;
using CarouselView.FormsPlugin.Android;

namespace Four1Property.Droid
{
    [Activity(Label = "Four1Property", Theme = "@style/MainTheme", ConfigurationChanges = ConfigChanges.ScreenSize | ConfigChanges.Orientation)]
    public class MainActivity : global::Xamarin.Forms.Platform.Android.FormsAppCompatActivity
    {
        readonly string[] Permissions =
        {
            Android.Manifest.Permission.AccessCoarseLocation,
            Android.Manifest.Permission.AccessFineLocation,
            Android.Manifest.Permission.ReadExternalStorage,
            Android.Manifest.Permission.WriteExternalStorage,
            Android.Manifest.Permission.AccessNetworkState,
            Android.Manifest.Permission.AccessNotificationPolicy,
            Android.Manifest.Permission.AccessWifiState,
            Android.Manifest.Permission.AccessLocationExtraCommands,
            Android.Manifest.Permission.Internet,
            Android.Manifest.Permission.Camera,

        };
        const int RequestID = 0;
        protected override void OnCreate(Bundle bundle)
        {
            TabLayoutResource = Resource.Layout.Tabbar;
            ToolbarResource = Resource.Layout.Toolbar;

            base.OnCreate(bundle);
            Forms.Init(this, bundle);
            FFImageLoading.Forms.Platform.CachedImageRenderer.Init(true);
            CarouselViewRenderer.Init();
            Xamarin.FormsMaps.Init(this, bundle);
            Xamarin.Essentials.Platform.Init(this, bundle);
            //Plugin.CurrentActivity.CrossCurrentActivity.Current.Init(this, bundle);
            Xamarin.FormsGoogleMaps.Init(this, bundle);
            Rg.Plugins.Popup.Popup.Init(this, bundle);
            
            LoadApplication(new App());
            RequestPermissions(Permissions, RequestID);
            ZXing.Net.Mobile.Forms.Android.Platform.Init();
            UserDialogs.Init(this);
            MessagingCenter.Subscribe<Compare>(this, "preventLandScape", sender =>
            {
                RequestedOrientation = ScreenOrientation.Portrait;
            });
            MessagingCenter.Subscribe<MapView>(this, "preventLandScape", sender =>
            {
                RequestedOrientation = ScreenOrientation.Portrait;
            });
            MessagingCenter.Subscribe<AcquaintanceList>(this, "preventLandScape", sender =>
            {
                RequestedOrientation = ScreenOrientation.Portrait;
            });

            MessagingCenter.Subscribe<Agents>(this, "preventLandScape", sender =>
            {
                RequestedOrientation = ScreenOrientation.Portrait;
            });
            MessagingCenter.Subscribe<Home>(this, "preventLandScape", sender =>
            {
                RequestedOrientation = ScreenOrientation.Portrait;
            });
            MessagingCenter.Subscribe<Login>(this, "preventLandScape", sender =>
            {
                RequestedOrientation = ScreenOrientation.Portrait;
            });
            MessagingCenter.Subscribe<Register>(this, "preventLandScape", sender =>
            {
                RequestedOrientation = ScreenOrientation.Portrait;
            });          
            MessagingCenter.Subscribe<UserProfile>(this, "preventLandScape", sender =>
            {
                RequestedOrientation = ScreenOrientation.Portrait;
            });
            MessagingCenter.Subscribe<Wishlist>(this, "preventLandScape", sender =>
            {
                RequestedOrientation = ScreenOrientation.Portrait;
            });
        }

        public  override void OnRequestPermissionsResult(int requestCode, string[] permissions, [GeneratedEnum] Permission[] grantResults)
        {
             Xamarin.Essentials.Platform.OnRequestPermissionsResult(requestCode, permissions, grantResults);
             PermissionsImplementation.Current.OnRequestPermissionsResult(requestCode, permissions, grantResults);
             PermissionsImplementation.Current.OnRequestPermissionsResult(requestCode, permissions, grantResults);
             ZXing.Net.Mobile.Forms.Android.PermissionsHandler.OnRequestPermissionsResult(requestCode, permissions, grantResults);
             base.OnRequestPermissionsResult(requestCode, permissions, grantResults);
        }

        
    }

}

