using System;
using System.Collections.Generic;
using System.Linq;
using CarouselView.FormsPlugin.iOS;
using CoreLocation;
using FFImageLoading.Forms.Platform;
using Foundation;
using Four1Property.View;
using UIKit;
using View;
using XLabs.Ioc;

namespace Four1Property.iOS
{
    // The UIApplicationDelegate for the application. This class is responsible for launching the 
    // User Interface of the application, as well as listening (and optionally responding) to 
    // application events from iOS.
    [Register("AppDelegate")]
    public partial class AppDelegate : global::Xamarin.Forms.Platform.iOS.FormsApplicationDelegate
    {
        //
        // This method is invoked when the application has loaded and is ready to run. In this 
        // method you should instantiate the window, load the UI into it and then make the window
        // visible.
        //
        // You have 17 seconds to return from this method, or iOS will terminate your application.
        //
        public override bool FinishedLaunching(UIApplication app, NSDictionary options)
        {
            global::Xamarin.Forms.Forms.Init();
            if (!Resolver.IsSet)
            {
                SetIoc();
            }
            //global::XLabs.Forms.XFormsAppiOS.Init();
            Rg.Plugins.Popup.Popup.Init();
            Xamarin.FormsMaps.Init();
            CachedImageRenderer.Init();
            CarouselViewRenderer.Init();
            Xamarin.FormsGoogleMaps.Init("AIzaSyB21fWQ5BtY71q3a6BxMHA27Mbh9rbj_Pk");
            XLabs.Forms.XFormsAppiOS.Init();
            CarouselView.FormsPlugin.iOS.CarouselViewRenderer.Init();
            LoadApplication(new App());
            ZXing.Net.Mobile.Forms.iOS.Platform.Init();
            CLLocationManager locMgr = new CLLocationManager();
            if (UIDevice.CurrentDevice.CheckSystemVersion(8, 0))
            {
                locMgr.RequestAlwaysAuthorization();
            }
            if (UIDevice.CurrentDevice.CheckSystemVersion(9, 0))
            {
                locMgr.AllowsBackgroundLocationUpdates = true;
            }

            return base.FinishedLaunching(app, options);
        }
        private void SetIoc()
        {
            var resolverContainer = new SimpleContainer();
            Resolver.SetResolver(resolverContainer.GetResolver());
        }
        public override UIInterfaceOrientationMask GetSupportedInterfaceOrientations(UIApplication application, UIWindow forWindow)
        {
            var mainPage = Xamarin.Forms.Application.Current.MainPage;
            var Orientation = UIInterfaceOrientationMask.Portrait;
            if (mainPage.Navigation.NavigationStack.Last() is Compare)
            {
                Orientation = UIInterfaceOrientationMask.Portrait;
            }
            else if (mainPage.Navigation.NavigationStack.Last() is MapView)
            {
                Orientation = UIInterfaceOrientationMask.Portrait;
            }else if (mainPage.Navigation.NavigationStack.Last() is Home)
            {
                Orientation = UIInterfaceOrientationMask.Portrait;
            }
            else if (mainPage.Navigation.NavigationStack.Last() is Login)
            {
                Orientation = UIInterfaceOrientationMask.Portrait;
            }
            else if (mainPage.Navigation.NavigationStack.Last() is Register)
            {
                Orientation = UIInterfaceOrientationMask.Portrait;
            }
            else if (mainPage.Navigation.NavigationStack.Last() is Wishlist)
            {
                Orientation = UIInterfaceOrientationMask.Portrait;
            }
            else if (mainPage.Navigation.NavigationStack.Last() is AcquaintanceList)
            {
                Orientation = UIInterfaceOrientationMask.Portrait;
            }
            else if (mainPage.Navigation.NavigationStack.Last() is MapView)
            {
                Orientation = UIInterfaceOrientationMask.Portrait;
            }
            else if (mainPage.Navigation.NavigationStack.Last() is PropertyProfile)
            {
                Orientation = UIInterfaceOrientationMask.Portrait;
            }
            else if (mainPage.Navigation.NavigationStack.Last() is UserProfile)
            {
                Orientation = UIInterfaceOrientationMask.Portrait;
            }
            return Orientation;
        }
    }
}
