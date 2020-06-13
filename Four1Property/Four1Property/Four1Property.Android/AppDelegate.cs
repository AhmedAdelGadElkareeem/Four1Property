using System;
using System.Collections.Generic;
using System.Linq;

using Foundation;
using Four1Property.View;
using UIKit;

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
            LoadApplication(new App());

            return base.FinishedLaunching(app, options);
        }
        public override UIInterfaceOrientationMask GetSupportedInterfaceOrientations(UIApplication application, UIWindow forWindow)
        {
            var mainPage = Xamarin.Forms.Application.Current.MainPage;
            var Orientation = UIInterfaceOrientationMask.Portrait;
            if (mainPage.Navigation.NavigationStack.Last() is Compare)
            {
                Orientation = UIInterfaceOrientationMask.Landscape ;   
            }
           else if (mainPage.Navigation.NavigationStack.Last() is MapView)
            {
                Orientation= UIInterfaceOrientationMask.Portrait;
            }
            return Orientation;
        }
    }
}
