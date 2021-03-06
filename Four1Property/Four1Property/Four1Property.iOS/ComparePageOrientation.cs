﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Foundation;
using Four1Property.iOS;
using Four1Property.View;
using UIKit;
using Xamarin.Forms;
using Xamarin.Forms.Platform.iOS;

[assembly: ExportRenderer(typeof(Compare), typeof(ComparePageOrientation))]
namespace Four1Property.iOS
{
   
  public  class ComparePageOrientation : PageRenderer
    {
        public override void ViewWillDisappear(bool animated)
        {
            base.ViewWillDisappear(animated);
            UIDevice.CurrentDevice.SetValueForKey(NSNumber.FromNInt((int)(UIInterfaceOrientation.LandscapeLeft)), new NSString("orientation"));
        }
    }
}