using System;
using System.Collections.Generic;
using CoreGraphics;
using CustomRenderer;
using Four1Property.Helper;
using Four1Property.iOS;
using MapKit;
using UIKit;
using Xamarin.Forms;
using Xamarin.Forms.Maps;
using Xamarin.Forms.Maps.iOS;
using Xamarin.Forms.Platform.iOS;

[assembly: ExportRenderer(typeof(CustomMap), typeof(CustomMapRenderer))]
namespace Four1Property.iOS
{
    public class CustomMapRenderer : MapRenderer
    {
        UIView customPinView;
        List<CustomPin> customPins;

        //protected override void OnElementChanged(ElementChangedEventArgs<View> e)
        //{
        //    base.OnElementChanged(e);

        //    if (e.OldElement != null)
        //    {
        //        var nativeMap = Control as MKMapView;
        //        nativeMap.GetViewForAnnotation = null;
        //        nativeMap.CalloutAccessoryControlTapped -= OnCalloutAccessoryControlTapped;
        //        nativeMap.DidSelectAnnotationView -= OnDidSelectAnnotationView;
        //        nativeMap.DidDeselectAnnotationView -= OnDidDeselectAnnotationView;
        //    }

        //    if (e.NewElement != null)
        //    {
        //        var formsMap = (CustomMap)e.NewElement;
        //        var nativeMap = Control as MKMapView;
        //        customPins = formsMap.CustomPins;

        //        nativeMap.GetViewForAnnotation = GetViewForAnnotation;
        //        nativeMap.CalloutAccessoryControlTapped += OnCalloutAccessoryControlTapped;
        //        nativeMap.DidSelectAnnotationView += OnDidSelectAnnotationView;
        //        nativeMap.DidDeselectAnnotationView += OnDidDeselectAnnotationView;
        //    }
        //}

        protected override MKAnnotationView GetViewForAnnotation(MKMapView mapView, IMKAnnotation annotation)
        {
            try
            {
                MKAnnotationView annotationView = new MKAnnotationView();
                if (annotation != null)
                {
                    var customPin = GetCustomPin(annotation);
                    if (customPin == null)
                    {
                        return null;
                    }

                    annotationView = mapView.DequeueReusableAnnotation(customPin.Name);
                    if (annotationView == null)
                    {
                        annotationView = new CustomMKAnnotationView(annotation, customPin.Name);
                        if (Constantce.homeModelC.SaleOrRent.Equals(0))
                        {
                            annotationView.Image = UIImage.FromFile("markericon.png");
                        }
                        else if (Constantce.homeModelC.SaleOrRent.Equals(1))
                        {
                            annotationView.Image = UIImage.FromFile("marker1.png");
                        }
                        annotationView.CalloutOffset = new CGPoint(0, 0);
                        annotationView.LeftCalloutAccessoryView = new UIImageView(UIImage.FromFile("monkey.png"));
                        annotationView.RightCalloutAccessoryView = UIButton.FromType(UIButtonType.DetailDisclosure);
                        ((CustomMKAnnotationView)annotationView).Name = customPin.Name;
                        ((CustomMKAnnotationView)annotationView).Url = customPin.Url;
                    }
                    annotationView.CanShowCallout = true;

                    return annotationView;

                }
                else
                    return null;

                
            }
            catch (Exception ex)
            {
                string er = ex.Message;
                return null;
            }
            
        }

        void OnCalloutAccessoryControlTapped(object sender, MKMapViewAccessoryTappedEventArgs e)
        {
            CustomMKAnnotationView customView = e.View as CustomMKAnnotationView;
            if (!string.IsNullOrWhiteSpace(customView.Url))
            {
                UIApplication.SharedApplication.OpenUrl(new Foundation.NSUrl(customView.Url));
            }
        }

        void OnDidSelectAnnotationView(object sender, MKAnnotationViewEventArgs e)
        {
            CustomMKAnnotationView customView = e.View as CustomMKAnnotationView;
            customPinView = new UIView();

            if (customView.Name.Equals("Xamarin"))
            {
                customPinView.Frame = new CGRect(0, 0, 200, 84);
                var image = new UIImageView(new CGRect(0, 0, 200, 84));
                image.Image = UIImage.FromFile("xamarin.png");
                customPinView.AddSubview(image);
                customPinView.Center = new CGPoint(0, -(e.View.Frame.Height + 75));
                e.View.AddSubview(customPinView);
            }
        }

        void OnDidDeselectAnnotationView(object sender, MKAnnotationViewEventArgs e)
        {
            if (!e.View.Selected)
            {
                customPinView.RemoveFromSuperview();
                customPinView.Dispose();
                customPinView = null;
            }
        }

        CustomPin GetCustomPin(IMKAnnotation annotation)
        {
            try
            {
                if(annotation != null)
                {
                    /*var position = new Position(annotation.Coordinate.Latitude, annotation.Coordinate.Longitude);
                    foreach (var pin in customPins)
                    {
                        if (pin.Position == position)
                        {
                            return pin;
                        }
                        else
                        {
                            return null;
                        }
                    }*/
                    var pin = new CustomPin()
                    {
                        Position = new Position(annotation.Coordinate.Latitude, annotation.Coordinate.Longitude),
                        Label= "Test",
                        Address = "Test",
                        Name="Test"
                    };
                    return pin;
                }
                else
                {
                    return null;
                }
            }
            catch (Exception ex)
            {
                string er = ex.Message;
                return null;
            }
        }
    }
}