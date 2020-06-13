using Four1Property.Helper;
using Four1Property.View;
using Rg.Plugins.Popup.Pages;
using Rg.Plugins.Popup.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using Xamarin.Essentials;
using Xamarin.Forms;
using Xamarin.Forms.GoogleMaps;
using Xamarin.Forms.Xaml;

namespace View
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class LocationMap : PopupPage
    {
        public LocationMap()
        {
            InitializeComponent();
            if (Application.Current.Properties["Language"].ToString() == "Arabic")
            {
                this.FlowDirection = FlowDirection.RightToLeft;
                Select.Text = "اختيار";
                UpText.Text = "الرجاء اختيار الموقع";
            }
            else
            {
                this.FlowDirection = FlowDirection.LeftToRight;
                Select.Text = "Select";
                UpText.Text = "Plese select location";
            }
        }

        protected async override void OnAppearing()
        {
            try
            {
                base.OnAppearing();
                var request = new GeolocationRequest(GeolocationAccuracy.High);
                var location = await Geolocation.GetLocationAsync(request);
                if(location != null)
                {
                    Pin pin = new Pin
                    {
                        Type = PinType.Place,
                        Position = new Position(location.Latitude, location.Longitude),
                        Label = "Drag ME",
                        IsDraggable = true,
                    };
                    pin.Icon = BitmapDescriptorFactory.FromView(new ContentView()
                    {
                        WidthRequest = 40,
                        HeightRequest = 40,
                        BackgroundColor = Color.Blue,
                        Content = new Image()
                        {
                            Source = ImageSource.FromFile("markericon.png")
                        }
                    });
                    myMap.MoveToRegion(MapSpan.FromCenterAndRadius(new Position(location.Latitude, location.Longitude), Distance.FromKilometers(0.5)));
                    myMap.Pins.Add(pin);
                }
               
            }
            catch (Exception)
            {
                Acr.UserDialogs.UserDialogs.Instance.Toast("Enable Location from setting to get your location");
                Pin pin = new Pin
                {
                    Type = PinType.Place,
                    Position = new Position(31.9454, 35.9284),
                    Label = "Drag ME",
                    IsDraggable = true,
                };
                pin.Icon = BitmapDescriptorFactory.FromView(new ContentView()
                {
                    WidthRequest = 40,
                    HeightRequest = 40,
                    BackgroundColor = Color.Blue,
                    Content = new Image()
                    {
                        Source = ImageSource.FromFile("markericon.png")
                    }
                });
                myMap.MoveToRegion(MapSpan.FromCenterAndRadius(new Position(31.9454, 35.9284), Distance.FromKilometers(0.5)));
                myMap.Pins.Add(pin);
            }
            
        }
        private void MyMap_MapClicked(object sender, MapClickedEventArgs e)
        {
            myMap.Pins.Clear();
            Pin pin1 = new Pin()
            {
                Position = new Position(e.Point.Latitude, e.Point.Longitude),
                Address = "",
                Label = "",
            };
            pin1.Icon = BitmapDescriptorFactory.FromView(new ContentView()
            {
                WidthRequest = 40,
                HeightRequest = 40,
                BackgroundColor = Color.Blue,
                Content = new Image()
                {
                    Source = ImageSource.FromFile("markericon.png")
                }
            });
            myMap.Pins.Add(pin1);
            Constantce.Lat = e.Point.Latitude;
            Constantce.lon = e.Point.Longitude;
        }
        private void myMap_PinDragEnd(object sender , PinDragEventArgs e)
        {
            myMap.Pins.Clear();
            Pin pin1 = new Pin()
            {
                Position = new Position(e.Pin.Position.Latitude, e.Pin.Position.Longitude),
                Address = "",
                Label = "",
            };
            pin1.Icon = BitmapDescriptorFactory.FromView(new ContentView()
            {
                WidthRequest = 40,
                HeightRequest = 40,
                BackgroundColor = Color.Blue,
                Content = new Image()
                {
                    Source = ImageSource.FromFile("markericon.png")
                }
            });
            myMap.Pins.Add(pin1);
        }
        private async void Select_Clicked(object sender, EventArgs e)
        {
            var existingPages = Navigation.NavigationStack.ToList();
            Page page = existingPages.FirstOrDefault();

            Navigation.InsertPageBefore(new Home(), page);
            Navigation.RemovePage(page);
            await PopupNavigation.Instance.PopAsync();
        }
    }
}