using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using Xamarin.Forms.Maps;
using Four1Property.ViewModels;
using Plugin.Geolocator;
using Plugin.Permissions;
using Plugin.Permissions.Abstractions;
using System.Collections.ObjectModel;
using Four1Property.Models;
using System.IO;
using Rg.Plugins.Popup.Services;
using View;
using Acr.UserDialogs;
using Four1Property.Helper;
using System.Net;
using Newtonsoft.Json;
using CarouselView.FormsPlugin.Abstractions;

namespace Four1Property.View
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class MapView : ContentPage
    {
        ObservableCollection<Property> propertiesSend = new ObservableCollection<Property>();
        CarouselViewControl myCarousel = new CarouselViewControl { };
        ObservableCollection<PropertyModel> propertyListModel = new ObservableCollection<PropertyModel>();
        ObservableCollection<Grid> grids = new ObservableCollection<Grid>();
        bool isLoading;
        string PID = "";
        public MapView(ObservableCollection<Property> properties, HomeModel homeModel)
        {

            InitializeComponent();
            if (Application.Current.Properties["Language"].ToString() == "Arabic")
            {

                if (properties.Count == 0)
                {
                    NoProperty.Text = "لا يوجد اي عقار";
                    NoProperty.TextColor = Color.FromHex("#FF071D66");
                    NoProperty.IsVisible = true;
                }
                this.Title = "خريطة عرض";
                this.FlowDirection = FlowDirection.RightToLeft;
                if (Application.Current.Properties["Token"].ToString() != "Null" && Application.Current.Properties["Token"].ToString() != "Guest")
                {
                    ToolbarItem Profile = new ToolbarItem { Order = ToolbarItemOrder.Secondary, Text = "ملفي" };
                    ToolbarItem whsilist = new ToolbarItem { Order = ToolbarItemOrder.Secondary, Text = "المفضلة" };
                    ToolbarItem Compare = new ToolbarItem { Order = ToolbarItemOrder.Secondary, Text = "المقارنات" };
                    ToolbarItem Agents = new ToolbarItem { Order = ToolbarItemOrder.Secondary, Text = "العملاء" };
                    ToolbarItem About = new ToolbarItem { Order = ToolbarItemOrder.Secondary, Text = "عنا" };
                    ToolbarItem Logout = new ToolbarItem { Order = ToolbarItemOrder.Secondary, Text = "تسجيل الخروج" };
                    Profile.Clicked += Profile_Clicked;
                    whsilist.Clicked += Wishlist_Clicked;
                    Logout.Clicked += LogOut_Clicked;
                    Compare.Clicked += Compare_Clicked;
                    About.Clicked += About_Clicked;
                    Agents.Clicked += Agents_Clicked;
                    this.ToolbarItems.Add(Profile);
                    this.ToolbarItems.Add(whsilist);
                    this.ToolbarItems.Add(Compare);
                    this.ToolbarItems.Add(Agents);
                    this.ToolbarItems.Add(About);
                    this.ToolbarItems.Add(Logout);
                }
                else
                {
                    ToolbarItem LoginORregister = new ToolbarItem { Order = ToolbarItemOrder.Secondary, Text = "تسجيل الدخول" };
                    ToolbarItem Agents = new ToolbarItem { Order = ToolbarItemOrder.Secondary, Text = "العملاء" };
                    ToolbarItem About = new ToolbarItem { Order = ToolbarItemOrder.Secondary, Text = "عنا" };
                    LoginORregister.Clicked += LoginorRegister_Clicked;
                    About.Clicked += About_Clicked;
                    Agents.Clicked += Agents_Clicked;
                    this.ToolbarItems.Add(Agents);
                    this.ToolbarItems.Add(About);
                    this.ToolbarItems.Add(LoginORregister);


                }
                
            }
            else
            {
                if (Application.Current.Properties["Token"].ToString() != "Null" && Application.Current.Properties["Token"].ToString() != "Guest")
                {
                    ToolbarItem Profile = new ToolbarItem { Order = ToolbarItemOrder.Secondary, Text = "Profile" };
                    ToolbarItem whsilist = new ToolbarItem { Order = ToolbarItemOrder.Secondary, Text = "Wishlist" };
                    ToolbarItem Compare = new ToolbarItem { Order = ToolbarItemOrder.Secondary, Text = "Compare" };
                    ToolbarItem About = new ToolbarItem { Order = ToolbarItemOrder.Secondary, Text = "About" };
                    ToolbarItem Agents = new ToolbarItem { Order = ToolbarItemOrder.Secondary, Text = "Agents" };
                    ToolbarItem Logout = new ToolbarItem { Order = ToolbarItemOrder.Secondary, Text = "Logout" };
                    Profile.Clicked += Profile_Clicked;
                    whsilist.Clicked += Wishlist_Clicked;
                    Logout.Clicked += LogOut_Clicked;
                    About.Clicked += About_Clicked;
                    Agents.Clicked += Agents_Clicked;
                    Compare.Clicked += Compare_Clicked;
                    this.ToolbarItems.Add(Profile);
                    this.ToolbarItems.Add(whsilist);
                    this.ToolbarItems.Add(Compare);
                    this.ToolbarItems.Add(Agents);
                    this.ToolbarItems.Add(About);
                    this.ToolbarItems.Add(Logout);
                }
                else
                {
                    ToolbarItem About = new ToolbarItem { Order = ToolbarItemOrder.Secondary, Text = "About" };
                    ToolbarItem Agents = new ToolbarItem { Order = ToolbarItemOrder.Secondary, Text = "Agents" };
                    ToolbarItem LoginORregister = new ToolbarItem { Order = ToolbarItemOrder.Secondary, Text = "Login" };
                    LoginORregister.Clicked += LoginorRegister_Clicked;
                    About.Clicked += About_Clicked;
                    Agents.Clicked += Agents_Clicked;
                    this.ToolbarItems.Add(Agents);
                    this.ToolbarItems.Add(About);
                    this.ToolbarItems.Add(LoginORregister);

                }
               
                if (properties.Count == 0)
                {
                    NoProperty.Text = "No Properties Found";
                    NoProperty.TextColor = Color.FromHex("#FF071D66");
                    NoProperty.IsVisible = true;
                }
                this.Title = "Map View";
                this.FlowDirection = FlowDirection.LeftToRight;

            }
            propertiesSend = properties;
            BindingContext = new AcquaintanceListDataViewModels();
             myCarousel = new CarouselViewControl
            {
                ItemTemplate = new DataTemplate(typeof(Grid)),
                IndicatorsTintColor = Color.DarkGray,
                ShowArrows = true,
                IsSwipeEnabled = true,
                Orientation = CarouselViewOrientation.Horizontal,
                ArrowsBackgroundColor = Color.FromHex("#071d66"),
                VerticalOptions = LayoutOptions.Fill,
                HorizontalOptions = LayoutOptions.Fill,

            };
            if(properties.Count > 0)
            {

                foreach (var item in properties)
                {
                    PropertyModel propertyModel = new PropertyModel();
                    propertyModel.Address = item.Address;
                    if (Application.Current.Properties["Language"].ToString() == "Arabic")
                    {
                        propertyModel.AddressLAng = item.Address.CityAR;
                        propertyModel.LeftArrow = "rightarrow.png";
                        propertyModel.RightArrow = "leftarrow.png";
                        propertyModel.SID = "ID: " + item.SID + "  ";
                    }
                    else
                    {
                        propertyModel.AddressLAng = item.Address.City;
                        propertyModel.RightArrow = "rightarrow.png";
                        propertyModel.LeftArrow = "leftarrow.png";
                        propertyModel.SID = "ID: " + item.SID + "  ";

                    }
                    propertyModel.AddressID = item.AddressID;
                    propertyModel.For = item.For;
                    propertyModel.ID = item.ID;
                    propertyModel.IDName = item.IDName;

                    if (item.PhotoQ.UploadedTo == null)
                    {
                        propertyModel.Photo = "@drawable/defultprop";
                    }
                    else
                    {
                        propertyModel.Photo = item.PhotoQ.UploadedTo;
                    }
                    propertyModel.Price = item.Price;
                    if (item.Reviews.FirstOrDefault()?.Rating.ToString() == null)
                    {
                        propertyModel.Review = "N/A";
                    }
                    else
                    {
                        propertyModel.Review = item.Reviews.FirstOrDefault()?.Rating.ToString();
                    }
                    propertyModel.Title = item.Title;
                    if (propertyModel.For == For.Rent)
                    {
                        if (Application.Current.Properties["Language"].ToString() == "Arabic")
                        {
                            propertyModel.StatusLang = "للايجار";
                        }
                        else
                        {
                            propertyModel.StatusLang = "Rent";
                        }
                        propertyModel.Color = "#F08C00";
                    }
                    else
                    {
                        if (Application.Current.Properties["Language"].ToString() == "Arabic")
                        {
                            propertyModel.StatusLang = "للبيع";
                        }
                        else
                        {
                            propertyModel.StatusLang = "Sale";
                        }
                        propertyModel.Color = "#66A80F";
                    }
                    item.Photos.Clear();
                    propertyModel.AllPhotos = item.Photos;
                    propertyModel.OfType = item.OfType;
                    propertyModel.Baths = item.Baths;
                    propertyModel.CarSpaces = item.CarSpaces;
                    propertyModel.LandArea = item.LandArea;
                    propertyModel.Beds = item.Beds;
                    propertyModel.LivingRooms = item.LivingRooms;
                    propertyModel.Status = item.Status;
                    propertyModel.Kitchens = item.Kitchens;
                    propertyModel.NumberOfRooms = item.NumberOfRooms;
                    propertyModel.Seller = item.Seller;
                    propertyModel.SellerAR = item.SellerAR;
                    propertyModel.AirConditioning = item.AirConditioning;
                    propertyModel.Balcony = item.Balcony;
                    propertyModel.Kitchens = item.Kitchens;
                    propertyModel.DryCleanRoom = item.DryCleanRoom;
                    propertyModel.Furnished = item.Furnished;
                    propertyModel.CoveredAreaMeasurement = item.CoveredAreaMeasurement;
                    propertyModel.FloorNo = item.FloorNo;
                    propertyModel.NumberOfRooms = item.NumberOfRooms;
                    propertyModel.NumberOfRooms = item.NumberOfRooms;
                    propertyModel.Gym = item.Gym;
                    propertyModel.Pool = item.Pool;
                    propertyModel.Build = item.Build;
                    propertyModel.BuildingArea = item.BuildingArea;
                    propertyModel.MaidsRoom = item.MaidsRoom;
                    propertyModel.StorageRoom = item.StorageRoom;
                    propertyModel.Phone = item.Phone;
                    propertyModel.IDName = item.IDName;
                    propertyModel.PhotoQ = item.PhotoQ;
                    propertyModel.PhotoQ1 = item.PhotoQ1;
                    propertyModel.PhotoQ2 = item.PhotoQ2;
                    propertyModel.PhotoQ3 = item.PhotoQ3;
                    propertyModel.PhotoQ4 = item.PhotoQ4;
                    propertyModel.PhotoQ5 = item.PhotoQ5;
                    propertyModel.PhotoQ6 = item.PhotoQ6;
                    propertyModel.PhotoQ7 = item.PhotoQ7;
                    propertyModel.PhotoQ8 = item.PhotoQ8;
                    propertyModel.PhotoQ9 = item.PhotoQ9;
                    propertyModel.PhotoQ10 = item.PhotoQ10;
                    propertyModel.PhotoQ11 = item.PhotoQ11;
                    propertyModel.PhotoQ12 = item.PhotoQ12;
                    propertyModel.Ad = false;
                    if (propertyModel.AllPhotos.Count.Equals(0))
                    {

                        propertyModel.AllPhotos.Add(propertyModel.PhotoQ);
                        if (propertyModel.PhotoQ1 != null) { propertyModel.AllPhotos.Add(propertyModel.PhotoQ1); }
                        if (propertyModel.PhotoQ2 != null) { propertyModel.AllPhotos.Add(propertyModel.PhotoQ2); }
                        if (propertyModel.PhotoQ3 != null) { propertyModel.AllPhotos.Add(propertyModel.PhotoQ3); }
                        if (propertyModel.PhotoQ4 != null) { propertyModel.AllPhotos.Add(propertyModel.PhotoQ4); }
                        if (propertyModel.PhotoQ5 != null) { propertyModel.AllPhotos.Add(propertyModel.PhotoQ5); }
                        if (propertyModel.PhotoQ6 != null) { propertyModel.AllPhotos.Add(propertyModel.PhotoQ6); }
                        if (propertyModel.PhotoQ7 != null) { propertyModel.AllPhotos.Add(propertyModel.PhotoQ7); }
                        if (propertyModel.PhotoQ8 != null) { propertyModel.AllPhotos.Add(propertyModel.PhotoQ8); }
                        if (propertyModel.PhotoQ9 != null) { propertyModel.AllPhotos.Add(propertyModel.PhotoQ9); }
                        if (propertyModel.PhotoQ10 != null) { propertyModel.AllPhotos.Add(propertyModel.PhotoQ10); }
                        if (propertyModel.PhotoQ11 != null) { propertyModel.AllPhotos.Add(propertyModel.PhotoQ11); }
                        if (propertyModel.PhotoQ12 != null) { propertyModel.AllPhotos.Add(propertyModel.PhotoQ12); }
                    }
                    if (propertyModel.AllPhotos.Count == 1) { propertyModel.ArrowPhoto = false; } else { propertyModel.ArrowPhoto = true; }
                    if (propertyModel.Beds == 0 || propertyModel.Beds == null) { propertyModel.Bed = false; } else { propertyModel.Bed = true; }
                    if (propertyModel.Baths == 0 || propertyModel.Baths == null) { propertyModel.Bath = false; } else { propertyModel.Bath = true; }
                    if (propertyModel.FloorNo == 0 || propertyModel.FloorNo == null) { propertyModel.Floor = false; } else { propertyModel.Floor = true; }
                    if (propertyModel.LivingRooms == 0 || propertyModel.LivingRooms == null) { propertyModel.Living = false; } else { propertyModel.Living = true; }
                    if (propertyModel.LandArea == 0 || propertyModel.LandArea == null) { propertyModel.Area = false; } else { propertyModel.Area = true; }
                    var maingrid = new Grid
                    {
                        ColumnDefinitions =
                    {
                         new ColumnDefinition { Width = new GridLength(0.6, GridUnitType.Star) },
                         new ColumnDefinition { Width = new GridLength(1, GridUnitType.Star) },
                    },
                        BackgroundColor = Color.White,
                        ColumnSpacing = 0
                    };
                    var pimage = new Image
                    {
                        Source = propertyModel.Photo,
                        Aspect = Aspect.Fill
                    };
                    var rategrid = new Grid
                    {
                        ColumnDefinitions =
                    {
                         new ColumnDefinition { Width = new GridLength(1, GridUnitType.Star) },
                         new ColumnDefinition { Width = new GridLength(0.25, GridUnitType.Star) },
                    },
                        RowDefinitions =
                    {
                         new RowDefinition { Height = new GridLength(0.3, GridUnitType.Star) },
                         new RowDefinition { Height = new GridLength(1, GridUnitType.Star) },
                    },
                    };
                    var rateimage = new Image
                    {
                        Source = "Rate.png",
                        Aspect = Aspect.AspectFill,
                    };
                    var ratelable = new Label
                    {
                        VerticalOptions = LayoutOptions.End,
                        HorizontalOptions = LayoutOptions.Center,
                        Text = propertyModel.Review,
                        FontSize = 10,
                        TextColor = Color.FromHex("#FF071D66")
                    };
                    rategrid.Children.Add(rateimage, 1, 0);
                    rategrid.Children.Add(ratelable, 1, 0);


                    var submaingrid = new Grid
                    {
                        RowDefinitions =
                    {
                         new RowDefinition { Height = new GridLength(40, GridUnitType.Absolute) },
                         new RowDefinition { Height = new GridLength(30, GridUnitType.Absolute) },
                         new RowDefinition { Height = new GridLength(30, GridUnitType.Absolute) },
                         new RowDefinition { Height = new GridLength(40, GridUnitType.Absolute) },
                         new RowDefinition { Height = new GridLength(40, GridUnitType.Absolute) },
                    },
                        ColumnSpacing = 0

                    };
                    var priceidgrid = new Grid
                    {
                        ColumnDefinitions =
                    {
                         new ColumnDefinition { Width = new GridLength(4, GridUnitType.Absolute) },
                         new ColumnDefinition { Width = new GridLength(60, GridUnitType.Absolute) },
                         new ColumnDefinition { Width = new GridLength(60, GridUnitType.Absolute) },
                         new ColumnDefinition { Width = new GridLength(1, GridUnitType.Star) },
                    },
                        VerticalOptions = LayoutOptions.Start,
                        HorizontalOptions = LayoutOptions.Start,
                        ColumnSpacing = 0
                    };
                    var pricebox = new BoxView
                    {
                        BackgroundColor = Color.FromHex("#FF071D66"),
                        VerticalOptions = LayoutOptions.Center,
                    };
                    var pricelable = new Label
                    {
                        Text = propertyModel.Price.ToString(),
                        TextColor = Color.White,
                        FontSize = 11,
                        VerticalOptions = LayoutOptions.Center,
                        HorizontalOptions = LayoutOptions.Center,
                    };
                    var saleorrentbox = new BoxView
                    {
                        BackgroundColor = Color.FromHex(propertyModel.Color),
                        VerticalOptions = LayoutOptions.Center,
                    };
                    var saleorrentlable = new Label
                    {
                        Text = propertyModel.StatusLang,
                        TextColor = Color.White,
                        FontSize = 11,
                        VerticalOptions = LayoutOptions.Center,
                        HorizontalOptions = LayoutOptions.Center,
                    };
                    var pidgrid = new Grid
                    {
                        ColumnDefinitions =
                    {
                         new ColumnDefinition { Width = new GridLength(1, GridUnitType.Star) },
                         new ColumnDefinition { Width = new GridLength(40, GridUnitType.Absolute) },
                    },

                        ColumnSpacing = 0

                    };
                    var idlable = new Label
                    {
                        Text = propertyModel.SID,
                        TextColor = Color.FromHex("#FF071D66"),
                        FontSize = 8,
                        VerticalOptions = LayoutOptions.Start,
                        HorizontalOptions = LayoutOptions.End,

                    };
                    pidgrid.Children.Add(idlable, 1, 0);

                    priceidgrid.Children.Add(pricebox, 1, 0);
                    priceidgrid.Children.Add(pricelable, 1, 0);
                    priceidgrid.Children.Add(saleorrentbox, 2, 0);
                    priceidgrid.Children.Add(saleorrentlable, 2, 0);
                    priceidgrid.Children.Add(pidgrid, 3, 0);

                    var pnggrid1 = new Grid
                    {
                        ColumnDefinitions =
                    {
                         new ColumnDefinition { Width = new GridLength(60, GridUnitType.Absolute) },
                         new ColumnDefinition { Width = new GridLength(60, GridUnitType.Absolute) },
                         new ColumnDefinition { Width = new GridLength(60, GridUnitType.Absolute) },
                    },
                        VerticalOptions = LayoutOptions.Start,
                        ColumnSpacing = 2,
                    };
                    var areagrid = new Grid
                    {
                        ColumnDefinitions = {
                       new ColumnDefinition{ Width= new GridLength(1, GridUnitType.Star) },
                       new ColumnDefinition{ Width= new GridLength(1, GridUnitType.Star) },
                    },
                        ColumnSpacing = 0

                    };
                    var areaimage = new Image
                    {
                        Source = "area.png",
                        IsVisible = propertyModel.Area.Value,
                        Scale = 0.5,
                        HorizontalOptions = LayoutOptions.Start
                    };
                    var arealable = new Label
                    {
                        Text = propertyModel.LandArea.ToString(),
                        TextColor = Color.FromHex("#FF071D66"),
                        FontSize = 8,
                        HorizontalOptions = LayoutOptions.Start,
                        VerticalOptions = LayoutOptions.Center,
                    };
                    areagrid.Children.Add(areaimage, 0, 0);
                    areagrid.Children.Add(arealable, 1, 0);
                    var bedgrid = new Grid
                    {
                        ColumnDefinitions = {
                       new ColumnDefinition{ Width= new GridLength(1, GridUnitType.Star) },
                       new ColumnDefinition{ Width= new GridLength(1, GridUnitType.Star) },
                    },
                        ColumnSpacing = 0
                    };
                    var bedimage = new Image
                    {
                        Source = "bedroom.png",
                        IsVisible = propertyModel.Bed.Value,
                        Scale = 0.5,
                        HorizontalOptions = LayoutOptions.Start
                    };
                    var bedlable = new Label
                    {
                        Text = propertyModel.Beds.ToString(),
                        TextColor = Color.FromHex("#FF071D66"),
                        FontSize = 8,
                        HorizontalOptions = LayoutOptions.Start,
                        VerticalOptions = LayoutOptions.Center,

                    };
                    bedgrid.Children.Add(bedimage, 0, 0);
                    bedgrid.Children.Add(bedlable, 1, 0);
                    var bathgrid = new Grid
                    {
                        ColumnDefinitions = {
                       new ColumnDefinition{ Width= new GridLength(1, GridUnitType.Star) },
                       new ColumnDefinition{ Width= new GridLength(1, GridUnitType.Star) },
                    },
                        ColumnSpacing = 0

                    };
                    var bathimage = new Image
                    {
                        Source = "bathroom.png",
                        IsVisible = propertyModel.Bath.Value,
                        Scale = 0.5,
                        HorizontalOptions = LayoutOptions.Start
                    };
                    var bathlable = new Label
                    {
                        Text = propertyModel.Baths.ToString(),
                        TextColor = Color.FromHex("#FF071D66"),
                        FontSize = 8,
                        HorizontalOptions = LayoutOptions.Start,
                        VerticalOptions = LayoutOptions.Center,
                    };
                    bathgrid.Children.Add(bathimage, 0, 0);
                    bathgrid.Children.Add(bathlable, 1, 0);
                    pnggrid1.Children.Add(areagrid, 0, 0);
                    pnggrid1.Children.Add(bedgrid, 1, 0);
                    pnggrid1.Children.Add(bathgrid, 2, 0);

                    var pnggrid2 = new Grid
                    {
                        ColumnDefinitions =
                    {
                         new ColumnDefinition { Width = new GridLength(60, GridUnitType.Absolute) },
                         new ColumnDefinition { Width = new GridLength(60, GridUnitType.Absolute) },
                    },
                        VerticalOptions = LayoutOptions.Start,
                        ColumnSpacing = 2,
                    };
                    var livinggrid = new Grid
                    {
                        ColumnDefinitions = {
                       new ColumnDefinition{ Width= new GridLength(1, GridUnitType.Star) },
                       new ColumnDefinition{ Width= new GridLength(1, GridUnitType.Star) },
                    },
                        ColumnSpacing = 0

                    };
                    var livingimage = new Image
                    {
                        Source = "livingroom.png",
                        IsVisible = propertyModel.Living.Value,
                        Scale = 0.5,
                        HorizontalOptions = LayoutOptions.Start
                    };
                    var livinglable = new Label
                    {
                        Text = propertyModel.LivingRooms.ToString(),
                        TextColor = Color.FromHex("#FF071D66"),
                        FontSize = 8,
                        HorizontalOptions = LayoutOptions.Start,
                        VerticalOptions = LayoutOptions.Center,
                    };
                    livinggrid.Children.Add(livingimage, 0, 0);
                    livinggrid.Children.Add(livinglable, 1, 0);
                    var floorgrid = new Grid
                    {
                        ColumnDefinitions = {
                       new ColumnDefinition{ Width= new GridLength(1, GridUnitType.Star) },
                       new ColumnDefinition{ Width= new GridLength(1, GridUnitType.Star) },
                    },
                        ColumnSpacing = 0

                    };
                    var floorimage = new Image
                    {
                        Source = "floor.png",
                        IsVisible = propertyModel.Floor.Value,
                        Scale = 0.5,
                        HorizontalOptions = LayoutOptions.Start
                    };
                    var floorlable = new Label
                    {
                        Text = propertyModel.FloorNo.ToString(),
                        TextColor = Color.FromHex("#FF071D66"),
                        FontSize = 8,
                        HorizontalOptions = LayoutOptions.Start,
                        VerticalOptions = LayoutOptions.Center,
                    };
                    floorgrid.Children.Add(floorimage, 0, 0);
                    floorgrid.Children.Add(floorlable, 1, 0);
                    pnggrid2.Children.Add(livinggrid, 0, 0);
                    pnggrid2.Children.Add(floorgrid, 1, 0);


                    var addressgrid = new Grid
                    {
                        ColumnDefinitions = {
                       new ColumnDefinition{ Width= new GridLength(5, GridUnitType.Absolute) },
                       new ColumnDefinition{ Width= new GridLength(0.03, GridUnitType.Star) },
                       new ColumnDefinition{ Width= new GridLength(1, GridUnitType.Star) },
                    },
                        ColumnSpacing = 2,

                    };
                    var addressimage = new Image
                    {
                        Source = "TextLocation.png",
                    };
                    var addresslable = new Label
                    {
                        Text = propertyModel.AddressLAng,
                        TextColor = Color.FromHex("#FF071D66"),
                        FontSize = 10,
                        VerticalOptions = LayoutOptions.Center,
                        HorizontalOptions = LayoutOptions.Start,
                    };
                    addressgrid.Children.Add(addressimage, 1, 0);
                    addressgrid.Children.Add(addresslable, 2, 0);

                    submaingrid.Children.Add(priceidgrid, 0, 0);
                    submaingrid.Children.Add(pnggrid1, 0, 1);
                    submaingrid.Children.Add(pnggrid2, 0, 2);
                    submaingrid.Children.Add(addressgrid, 0, 3);

                    maingrid.Children.Add(pimage, 0, 0);
                    maingrid.Children.Add(rategrid, 0, 0);
                    maingrid.Children.Add(submaingrid, 1, 0);
                    propertyListModel.Add(propertyModel);
                    TapGestureRecognizer gridTap = new TapGestureRecognizer();
                    gridTap.Tapped += (sender, e) =>
                    {
                        Navigation.PushAsync(new PropertyProfile(propertyModel));
                    };
                    maingrid.GestureRecognizers.Add(gridTap);
                    grids.Add(maingrid);
                }
                myCarousel.ItemsSource = grids;
                ListLayout.Children.Add(myCarousel);
                GetCurrentLOcation();

                foreach (var item in properties)
                {
                    PropertyModel propertyModel = new PropertyModel();
                    propertyModel.Address = item.Address;
                    if (Application.Current.Properties["Language"].ToString() == "Arabic")
                    {
                        propertyModel.AddressLAng = item.Address.CityAR;
                        propertyModel.LeftArrow = "rightarrow.png";
                        propertyModel.RightArrow = "leftarrow.png";
                        propertyModel.SID = "ID: " + item.SID + "  ";
                    }
                    else
                    {
                        propertyModel.AddressLAng = item.Address.City;
                        propertyModel.RightArrow = "rightarrow.png";
                        propertyModel.LeftArrow = "leftarrow.png";
                        propertyModel.SID = "ID: " + item.SID + "  ";

                    }
                    propertyModel.AddressID = item.AddressID;
                    propertyModel.For = item.For;
                    propertyModel.ID = item.ID;
                    propertyModel.IDName = item.IDName;

                    if (item.PhotoQ.UploadedTo == null)
                    {
                        propertyModel.Photo = "@drawable/defultprop";
                    }
                    else
                    {
                        propertyModel.Photo = item.PhotoQ.UploadedTo;
                    }
                    propertyModel.Price = item.Price;
                    if (item.Reviews.FirstOrDefault()?.Rating.ToString() == null)
                    {
                        propertyModel.Review = "N/A";
                    }
                    else
                    {
                        propertyModel.Review = item.Reviews.FirstOrDefault()?.Rating.ToString();
                    }
                    propertyModel.Title = item.Title;
                    if (propertyModel.For == For.Rent)
                    {
                        if (Application.Current.Properties["Language"].ToString() == "Arabic")
                        {
                            propertyModel.StatusLang = "للايجار";
                        }
                        else
                        {
                            propertyModel.StatusLang = "Rent";
                        }
                        propertyModel.Color = "#F08C00";
                    }
                    else
                    {
                        if (Application.Current.Properties["Language"].ToString() == "Arabic")
                        {
                            propertyModel.StatusLang = "للبيع";
                        }
                        else
                        {
                            propertyModel.StatusLang = "Sale";
                        }
                        propertyModel.Color = "#66A80F";
                    }
                    item.Photos.Clear();
                    propertyModel.AllPhotos = item.Photos;
                    propertyModel.OfType = item.OfType;
                    propertyModel.Baths = item.Baths;
                    propertyModel.CarSpaces = item.CarSpaces;
                    propertyModel.LandArea = item.LandArea;
                    propertyModel.Beds = item.Beds;
                    propertyModel.LivingRooms = item.LivingRooms;
                    propertyModel.Status = item.Status;
                    propertyModel.Kitchens = item.Kitchens;
                    propertyModel.NumberOfRooms = item.NumberOfRooms;
                    propertyModel.Seller = item.Seller;
                    propertyModel.SellerAR = item.SellerAR;
                    propertyModel.AirConditioning = item.AirConditioning;
                    propertyModel.Balcony = item.Balcony;
                    propertyModel.Kitchens = item.Kitchens;
                    propertyModel.DryCleanRoom = item.DryCleanRoom;
                    propertyModel.Furnished = item.Furnished;
                    propertyModel.CoveredAreaMeasurement = item.CoveredAreaMeasurement;
                    propertyModel.FloorNo = item.FloorNo;
                    propertyModel.NumberOfRooms = item.NumberOfRooms;
                    propertyModel.NumberOfRooms = item.NumberOfRooms;
                    propertyModel.Gym = item.Gym;
                    propertyModel.Pool = item.Pool;
                    propertyModel.Build = item.Build;
                    propertyModel.BuildingArea = item.BuildingArea;
                    propertyModel.MaidsRoom = item.MaidsRoom;
                    propertyModel.StorageRoom = item.StorageRoom;
                    propertyModel.Phone = item.Phone;
                    propertyModel.IDName = item.IDName;
                    propertyModel.PhotoQ = item.PhotoQ;
                    propertyModel.PhotoQ1 = item.PhotoQ1;
                    propertyModel.PhotoQ2 = item.PhotoQ2;
                    propertyModel.PhotoQ3 = item.PhotoQ3;
                    propertyModel.PhotoQ4 = item.PhotoQ4;
                    propertyModel.PhotoQ5 = item.PhotoQ5;
                    propertyModel.PhotoQ6 = item.PhotoQ6;
                    propertyModel.PhotoQ7 = item.PhotoQ7;
                    propertyModel.PhotoQ8 = item.PhotoQ8;
                    propertyModel.PhotoQ9 = item.PhotoQ9;
                    propertyModel.PhotoQ10 = item.PhotoQ10;
                    propertyModel.PhotoQ11 = item.PhotoQ11;
                    propertyModel.PhotoQ12 = item.PhotoQ12;
                    propertyModel.Ad = false;
                    if (propertyModel.AllPhotos.Count.Equals(0))
                    {
                        propertyModel.AllPhotos.Add(propertyModel.PhotoQ);
                        if (propertyModel.PhotoQ1 != null) { propertyModel.AllPhotos.Add(propertyModel.PhotoQ1); }
                        if (propertyModel.PhotoQ2 != null) { propertyModel.AllPhotos.Add(propertyModel.PhotoQ2); }
                        if (propertyModel.PhotoQ3 != null) { propertyModel.AllPhotos.Add(propertyModel.PhotoQ3); }
                        if (propertyModel.PhotoQ4 != null) { propertyModel.AllPhotos.Add(propertyModel.PhotoQ4); }
                        if (propertyModel.PhotoQ5 != null) { propertyModel.AllPhotos.Add(propertyModel.PhotoQ5); }
                        if (propertyModel.PhotoQ6 != null) { propertyModel.AllPhotos.Add(propertyModel.PhotoQ6); }
                        if (propertyModel.PhotoQ7 != null) { propertyModel.AllPhotos.Add(propertyModel.PhotoQ7); }
                        if (propertyModel.PhotoQ8 != null) { propertyModel.AllPhotos.Add(propertyModel.PhotoQ8); }
                        if (propertyModel.PhotoQ9 != null) { propertyModel.AllPhotos.Add(propertyModel.PhotoQ9); }
                        if (propertyModel.PhotoQ10 != null) { propertyModel.AllPhotos.Add(propertyModel.PhotoQ10); }
                        if (propertyModel.PhotoQ11 != null) { propertyModel.AllPhotos.Add(propertyModel.PhotoQ11); }
                        if (propertyModel.PhotoQ12 != null) { propertyModel.AllPhotos.Add(propertyModel.PhotoQ12); }
                    }
                    if (propertyModel.AllPhotos.Count == 1) { propertyModel.ArrowPhoto = false; } else { propertyModel.ArrowPhoto = true; }
                    if (propertyModel.Beds == 0 || propertyModel.Beds == null) { propertyModel.Bed = false; } else { propertyModel.Bed = true; }
                    if (propertyModel.Baths == 0 || propertyModel.Baths == null) { propertyModel.Bath = false; } else { propertyModel.Bath = true; }
                    if (propertyModel.FloorNo == 0 || propertyModel.FloorNo == null) { propertyModel.Floor = false; } else { propertyModel.Floor = true; }
                    if (propertyModel.LivingRooms == 0 || propertyModel.LivingRooms == null) { propertyModel.Living = false; } else { propertyModel.Living = true; }
                    if (propertyModel.LandArea == 0 || propertyModel.LandArea == null) { propertyModel.Area = false; } else { propertyModel.Area = true; }

                    Pin pin = new Pin
                    {

                        Type = PinType.Place,
                        Position = new Position(item.Address.Latitude, item.Address.Longitude),

                        Label = item.ID.ToString(),
                        Address = item.Address.AreaName + item.Address.Country,


                    };

                    pin.InfoWindowClicked += (sender, args) =>
                    {
                        Navigation.PushAsync(new PropertyProfile(propertyModel));
                    };
                    MyMap.Pins.Add(pin);
                }
                myCarousel.PropertyChanged += (sender, args) =>
                {
                    int i = 0;
                    foreach (var item in propertyListModel)
                    {
                        if (myCarousel.Position == i)
                        {
                            MyMap.MoveToRegion(MapSpan.FromCenterAndRadius(new Position(item.Address.Latitude, item.Address.Longitude), Distance.FromKilometers(0.2)));

                        }
                        i++;
                    }
                };
                myCarousel.Scrolled += (sender, args) =>
                {
                    if (Constantce.Mapkength == 10)
                    {

                        int position = myCarousel.Position;
                        int total = myCarousel.ItemsSource.GetCount();
                        if (total >= 10)
                        {
                            if (position == total - 1)
                            {
                                LoadItems();
                                return;
                            }
                        }
                    }
                };
            }
        }

        public async void GetCurrentLOcation()
        {

            //Permission permission = Permission.Location;
            //var PermissionStatus = await CrossPermissions.Current.CheckPermissionStatusAsync(permission);
            //if (PermissionStatus == PermissionStatus.Denied)
            //{
            //    if (Device.RuntimePlatform == Device.iOS)
            //    {
            //        var checkDialog = await DisplayAlert("Permission!", "Please Enable Location", "Settings", "Maybe Later");
            //        if (checkDialog)
            //        {
            //            CrossPermissions.Current.OpenAppSettings();
            //        }

            //    }
            //    else if (Device.RuntimePlatform == Device.Android)
            //    {
            //       
            //        if (checkDialog)
            //        {
            //            CrossPermissions.Current.OpenAppSettings();
            //        }
            //    }
            //}
            //else { 
            try
            {

                var locator = CrossGeolocator.Current;
                if (locator.IsGeolocationAvailable && locator.IsGeolocationEnabled)
                {
                    var position = await locator.GetPositionAsync(TimeSpan.FromHours(10));

                    double lon;
                    double lat;

                    lon = position.Longitude;
                    lat = position.Latitude;
                    MyMap.MoveToRegion(MapSpan.FromCenterAndRadius(new Position(lat, lon), Distance.FromKilometers(0.5)));
                }
                else
                {
                    var checkDialog = await DisplayAlert("Permission!", "Please Enable Location", "Settings", "Maybe Later");
                    if (checkDialog)
                    {
                        CrossPermissions.Current.OpenAppSettings();
                    }
                }

            }
            catch (OperationCanceledException o)
            {
                System.Diagnostics.Debug.WriteLine(o.Message);
            }
            catch (Exception ex)
            {
                System.Diagnostics.Debug.WriteLine(ex.Message);
            }
        }



        protected override void OnAppearing()
        {
            base.OnAppearing();

            MessagingCenter.Send(this, "preventLandScape");
        }
        private async Task LoadItems()
        {
            int pid = myCarousel.ItemsSource.GetCount();
            ObservableCollection<PropertyModel> Vehicle2 = new ObservableCollection<PropertyModel>();
            isLoading = true;
            var uri = string.Format(Constantce.URL + "/api/properties/" + Constantce.APIName + "?fort={0}&category={1}&Subcat={2}&lon={3}&lat={4}&id={5}&bed={6}&bath={7}", Constantce.homeModelC.SaleOrRent, Constantce.homeModelC.Category, Constantce.homeModelC.SubCategory, Constantce.lon, Constantce.Lat, pid, Constantce.Bed, Constantce.Bath);
            HttpWebRequest request = WebRequest.Create(uri) as HttpWebRequest;
            using (HttpWebResponse response = request.GetResponse() as HttpWebResponse)
            {
                StreamReader reader = new StreamReader(response.GetResponseStream());
                string Data = reader.ReadToEnd();
                ObservableCollection<PropertyModel> property = JsonConvert.DeserializeObject<ObservableCollection<PropertyModel>>(Data);
                Vehicle2 = property;
            }
            Constantce.Mapkength = Vehicle2.Count();
            //simulator delayed load
            foreach (var item in Vehicle2)
            {
                PropertyModel propertyModel = new PropertyModel();
                propertyModel.Address = item.Address;
                if (Application.Current.Properties["Language"].ToString() == "Arabic")
                {
                    propertyModel.AddressLAng = item.Address.CityAR;
                    propertyModel.LeftArrow = "rightarrow.png";
                    propertyModel.RightArrow = "leftarrow.png";
                    propertyModel.SID = "ID: " + item.SID + "  ";
                }
                else
                {
                    propertyModel.AddressLAng = item.Address.City;
                    propertyModel.RightArrow = "rightarrow.png";
                    propertyModel.LeftArrow = "leftarrow.png";
                    propertyModel.SID = "ID: " + item.SID + "  ";

                }
                propertyModel.AddressID = item.AddressID;
                propertyModel.For = item.For;
                propertyModel.ID = item.ID;
                propertyModel.IDName = item.IDName;

                if (item.PhotoQ.UploadedTo == null)
                {
                    propertyModel.Photo = "@drawable/defultprop";
                }
                else
                {
                    propertyModel.Photo = item.PhotoQ.UploadedTo;
                }
                propertyModel.Price = item.Price;
                if (item.Reviews.FirstOrDefault()?.Rating.ToString() == null)
                {
                    propertyModel.Review = "N/A";
                }
                else
                {
                    propertyModel.Review = item.Reviews.FirstOrDefault()?.Rating.ToString();
                }
                propertyModel.Title = item.Title;
                if (propertyModel.For == For.Rent)
                {
                    if (Application.Current.Properties["Language"].ToString() == "Arabic")
                    {
                        propertyModel.StatusLang = "للايجار";
                    }
                    else
                    {
                        propertyModel.StatusLang = "Rent";
                    }
                    propertyModel.Color = "#F08C00";
                }
                else
                {
                    if (Application.Current.Properties["Language"].ToString() == "Arabic")
                    {
                        propertyModel.StatusLang = "للبيع";
                    }
                    else
                    {
                        propertyModel.StatusLang = "Sale";
                    }
                    propertyModel.Color = "#66A80F";
                }

                propertyModel.AllPhotos = item.Photos;
                propertyModel.OfType = item.OfType;
                propertyModel.Baths = item.Baths;
                propertyModel.CarSpaces = item.CarSpaces;
                propertyModel.LandArea = item.LandArea;
                propertyModel.Beds = item.Beds;
                propertyModel.LivingRooms = item.LivingRooms;
                propertyModel.Status = item.Status;
                propertyModel.Kitchens = item.Kitchens;
                propertyModel.NumberOfRooms = item.NumberOfRooms;
                propertyModel.Seller = item.Seller;
                propertyModel.SellerAR = item.SellerAR;
                propertyModel.AirConditioning = item.AirConditioning;
                propertyModel.Balcony = item.Balcony;
                propertyModel.Kitchens = item.Kitchens;
                propertyModel.DryCleanRoom = item.DryCleanRoom;
                propertyModel.Furnished = item.Furnished;
                propertyModel.CoveredAreaMeasurement = item.CoveredAreaMeasurement;
                propertyModel.FloorNo = item.FloorNo;
                propertyModel.NumberOfRooms = item.NumberOfRooms;
                propertyModel.NumberOfRooms = item.NumberOfRooms;
                propertyModel.Gym = item.Gym;
                propertyModel.Pool = item.Pool;
                propertyModel.Build = item.Build;
                propertyModel.BuildingArea = item.BuildingArea;
                propertyModel.MaidsRoom = item.MaidsRoom;
                propertyModel.StorageRoom = item.StorageRoom;
                propertyModel.Phone = item.Phone;
                propertyModel.IDName = item.IDName;
                propertyModel.PhotoQ = item.PhotoQ;
                propertyModel.PhotoQ1 = item.PhotoQ1;
                propertyModel.PhotoQ2 = item.PhotoQ2;
                propertyModel.PhotoQ3 = item.PhotoQ3;
                propertyModel.PhotoQ4 = item.PhotoQ4;
                propertyModel.PhotoQ5 = item.PhotoQ5;
                propertyModel.PhotoQ6 = item.PhotoQ6;
                propertyModel.PhotoQ7 = item.PhotoQ7;
                propertyModel.PhotoQ8 = item.PhotoQ8;
                propertyModel.PhotoQ9 = item.PhotoQ9;
                propertyModel.PhotoQ10 = item.PhotoQ10;
                propertyModel.PhotoQ11 = item.PhotoQ11;
                propertyModel.PhotoQ12 = item.PhotoQ12;
                propertyModel.Ad = false;
                propertyModel.AllPhotos.Add(propertyModel.PhotoQ);
                if (propertyModel.PhotoQ1 != null) { propertyModel.AllPhotos.Add(propertyModel.PhotoQ1); }
                if (propertyModel.PhotoQ2 != null) { propertyModel.AllPhotos.Add(propertyModel.PhotoQ2); }
                if (propertyModel.PhotoQ3 != null) { propertyModel.AllPhotos.Add(propertyModel.PhotoQ3); }
                if (propertyModel.PhotoQ4 != null) { propertyModel.AllPhotos.Add(propertyModel.PhotoQ4); }
                if (propertyModel.PhotoQ5 != null) { propertyModel.AllPhotos.Add(propertyModel.PhotoQ5); }
                if (propertyModel.PhotoQ6 != null) { propertyModel.AllPhotos.Add(propertyModel.PhotoQ6); }
                if (propertyModel.PhotoQ7 != null) { propertyModel.AllPhotos.Add(propertyModel.PhotoQ7); }
                if (propertyModel.PhotoQ8 != null) { propertyModel.AllPhotos.Add(propertyModel.PhotoQ8); }
                if (propertyModel.PhotoQ9 != null) { propertyModel.AllPhotos.Add(propertyModel.PhotoQ9); }
                if (propertyModel.PhotoQ10 != null) { propertyModel.AllPhotos.Add(propertyModel.PhotoQ10); }
                if (propertyModel.PhotoQ11 != null) { propertyModel.AllPhotos.Add(propertyModel.PhotoQ11); }
                if (propertyModel.PhotoQ12 != null) { propertyModel.AllPhotos.Add(propertyModel.PhotoQ12); }

                if (propertyModel.AllPhotos.Count == 1) { propertyModel.ArrowPhoto = false; } else { propertyModel.ArrowPhoto = true; }
                if (propertyModel.Beds == 0 || propertyModel.Beds == null) { propertyModel.Bed = false; } else { propertyModel.Bed = true; }
                if (propertyModel.Baths == 0 || propertyModel.Baths == null) { propertyModel.Bath = false; } else { propertyModel.Bath = true; }
                if (propertyModel.FloorNo == 0 || propertyModel.FloorNo == null) { propertyModel.Floor = false; } else { propertyModel.Floor = true; }
                if (propertyModel.LivingRooms == 0 || propertyModel.LivingRooms == null) { propertyModel.Living = false; } else { propertyModel.Living = true; }
                if (propertyModel.LandArea == 0 || propertyModel.LandArea == null) { propertyModel.Area = false; } else { propertyModel.Area = true; }
                var maingrid = new Grid
                {
                    ColumnDefinitions =
                    {
                         new ColumnDefinition { Width = new GridLength(0.6, GridUnitType.Star) },
                         new ColumnDefinition { Width = new GridLength(1, GridUnitType.Star) },
                    },
                    BackgroundColor = Color.White,
                    ColumnSpacing = 0
                };
                var pimage = new Image
                {
                    Source = propertyModel.Photo,
                    Aspect = Aspect.Fill
                };
                var rategrid = new Grid
                {
                    ColumnDefinitions =
                    {
                         new ColumnDefinition { Width = new GridLength(1, GridUnitType.Star) },
                         new ColumnDefinition { Width = new GridLength(0.25, GridUnitType.Star) },
                    },
                    RowDefinitions =
                    {
                         new RowDefinition { Height = new GridLength(0.3, GridUnitType.Star) },
                         new RowDefinition { Height = new GridLength(1, GridUnitType.Star) },
                    },
                };
                var rateimage = new Image
                {
                    Source = "Rate.png",
                    Aspect = Aspect.AspectFill,
                };
                var ratelable = new Label
                {
                    VerticalOptions = LayoutOptions.End,
                    HorizontalOptions = LayoutOptions.Center,
                    Text = propertyModel.Review,
                    FontSize = 10,
                    TextColor = Color.FromHex("#FF071D66")
                };
                rategrid.Children.Add(rateimage, 1, 0);
                rategrid.Children.Add(ratelable, 1, 0);


                var submaingrid = new Grid
                {
                    RowDefinitions =
                    {
                         new RowDefinition { Height = new GridLength(40, GridUnitType.Absolute) },
                         new RowDefinition { Height = new GridLength(30, GridUnitType.Absolute) },
                         new RowDefinition { Height = new GridLength(30, GridUnitType.Absolute) },
                         new RowDefinition { Height = new GridLength(40, GridUnitType.Absolute) },
                         new RowDefinition { Height = new GridLength(40, GridUnitType.Absolute) },
                    },
                    ColumnSpacing = 0

                };
                var priceidgrid = new Grid
                {
                    ColumnDefinitions =
                    {
                         new ColumnDefinition { Width = new GridLength(4, GridUnitType.Absolute) },
                         new ColumnDefinition { Width = new GridLength(60, GridUnitType.Absolute) },
                         new ColumnDefinition { Width = new GridLength(60, GridUnitType.Absolute) },
                         new ColumnDefinition { Width = new GridLength(1, GridUnitType.Star) },
                    },
                    VerticalOptions = LayoutOptions.Start,
                    HorizontalOptions = LayoutOptions.Start,
                    ColumnSpacing = 0
                };
                var pricebox = new BoxView
                {
                    BackgroundColor = Color.FromHex("#FF071D66"),
                    VerticalOptions = LayoutOptions.Center,
                };
                var pricelable = new Label
                {
                    Text = propertyModel.Price.ToString(),
                    TextColor = Color.White,
                    FontSize = 11,
                    VerticalOptions = LayoutOptions.Center,
                    HorizontalOptions = LayoutOptions.Center,
                };
                var saleorrentbox = new BoxView
                {
                    BackgroundColor = Color.FromHex(propertyModel.Color),
                    VerticalOptions = LayoutOptions.Center,
                };
                var saleorrentlable = new Label
                {
                    Text = propertyModel.StatusLang,
                    TextColor = Color.White,
                    FontSize = 11,
                    VerticalOptions = LayoutOptions.Center,
                    HorizontalOptions = LayoutOptions.Center,
                };
                var pidgrid = new Grid
                {
                    ColumnDefinitions =
                    {
                         new ColumnDefinition { Width = new GridLength(1, GridUnitType.Star) },
                         new ColumnDefinition { Width = new GridLength(40, GridUnitType.Absolute) },
                    },

                    ColumnSpacing = 0

                };
                var idlable = new Label
                {
                    Text = propertyModel.SID,
                    TextColor = Color.FromHex("#FF071D66"),
                    FontSize = 8,
                    VerticalOptions = LayoutOptions.Start,
                    HorizontalOptions = LayoutOptions.End,

                };
                pidgrid.Children.Add(idlable, 1, 0);

                priceidgrid.Children.Add(pricebox, 1, 0);
                priceidgrid.Children.Add(pricelable, 1, 0);
                priceidgrid.Children.Add(saleorrentbox, 2, 0);
                priceidgrid.Children.Add(saleorrentlable, 2, 0);
                priceidgrid.Children.Add(pidgrid, 3, 0);

                var pnggrid1 = new Grid
                {
                    ColumnDefinitions =
                    {
                         new ColumnDefinition { Width = new GridLength(60, GridUnitType.Absolute) },
                         new ColumnDefinition { Width = new GridLength(60, GridUnitType.Absolute) },
                         new ColumnDefinition { Width = new GridLength(60, GridUnitType.Absolute) },
                    },
                    VerticalOptions = LayoutOptions.Start,
                    ColumnSpacing = 2,
                };
                var areagrid = new Grid
                {
                    ColumnDefinitions = {
                       new ColumnDefinition{ Width= new GridLength(1, GridUnitType.Star) },
                       new ColumnDefinition{ Width= new GridLength(1, GridUnitType.Star) },
                    },
                    ColumnSpacing = 0

                };
                var areaimage = new Image
                {
                    Source = "area.png",
                    IsVisible = propertyModel.Area.Value,
                    Scale = 0.5,
                    HorizontalOptions = LayoutOptions.Start
                };
                var arealable = new Label
                {
                    Text = propertyModel.LandArea.ToString(),
                    TextColor = Color.FromHex("#FF071D66"),
                    FontSize = 8,
                    HorizontalOptions = LayoutOptions.Start,
                    VerticalOptions = LayoutOptions.Center,
                };
                areagrid.Children.Add(areaimage, 0, 0);
                areagrid.Children.Add(arealable, 1, 0);
                var bedgrid = new Grid
                {
                    ColumnDefinitions = {
                       new ColumnDefinition{ Width= new GridLength(1, GridUnitType.Star) },
                       new ColumnDefinition{ Width= new GridLength(1, GridUnitType.Star) },
                    },
                    ColumnSpacing = 0
                };
                var bedimage = new Image
                {
                    Source = "bedroom.png",
                    IsVisible = propertyModel.Bed.Value,
                    Scale = 0.5,
                    HorizontalOptions = LayoutOptions.Start
                };
                var bedlable = new Label
                {
                    Text = propertyModel.Beds.ToString(),
                    TextColor = Color.FromHex("#FF071D66"),
                    FontSize = 8,
                    HorizontalOptions = LayoutOptions.Start,
                    VerticalOptions = LayoutOptions.Center,

                };
                bedgrid.Children.Add(bedimage, 0, 0);
                bedgrid.Children.Add(bedlable, 1, 0);
                var bathgrid = new Grid
                {
                    ColumnDefinitions = {
                       new ColumnDefinition{ Width= new GridLength(1, GridUnitType.Star) },
                       new ColumnDefinition{ Width= new GridLength(1, GridUnitType.Star) },
                    },
                    ColumnSpacing = 0

                };
                var bathimage = new Image
                {
                    Source = "bathroom.png",
                    IsVisible = propertyModel.Bath.Value,
                    Scale = 0.5,
                    HorizontalOptions = LayoutOptions.Start
                };
                var bathlable = new Label
                {
                    Text = propertyModel.Baths.ToString(),
                    TextColor = Color.FromHex("#FF071D66"),
                    FontSize = 8,
                    HorizontalOptions = LayoutOptions.Start,
                    VerticalOptions = LayoutOptions.Center,
                };
                bathgrid.Children.Add(bathimage, 0, 0);
                bathgrid.Children.Add(bathlable, 1, 0);
                pnggrid1.Children.Add(areagrid, 0, 0);
                pnggrid1.Children.Add(bedgrid, 1, 0);
                pnggrid1.Children.Add(bathgrid, 2, 0);

                var pnggrid2 = new Grid
                {
                    ColumnDefinitions =
                    {
                         new ColumnDefinition { Width = new GridLength(60, GridUnitType.Absolute) },
                         new ColumnDefinition { Width = new GridLength(60, GridUnitType.Absolute) },
                    },
                    VerticalOptions = LayoutOptions.Start,
                    ColumnSpacing = 2,
                };
                var livinggrid = new Grid
                {
                    ColumnDefinitions = {
                       new ColumnDefinition{ Width= new GridLength(1, GridUnitType.Star) },
                       new ColumnDefinition{ Width= new GridLength(1, GridUnitType.Star) },
                    },
                    ColumnSpacing = 0

                };
                var livingimage = new Image
                {
                    Source = "livingroom.png",
                    IsVisible = propertyModel.Living.Value,
                    Scale = 0.5,
                    HorizontalOptions = LayoutOptions.Start
                };
                var livinglable = new Label
                {
                    Text = propertyModel.LivingRooms.ToString(),
                    TextColor = Color.FromHex("#FF071D66"),
                    FontSize = 8,
                    HorizontalOptions = LayoutOptions.Start,
                    VerticalOptions = LayoutOptions.Center,
                };
                livinggrid.Children.Add(livingimage, 0, 0);
                livinggrid.Children.Add(livinglable, 1, 0);
                var floorgrid = new Grid
                {
                    ColumnDefinitions = {
                       new ColumnDefinition{ Width= new GridLength(1, GridUnitType.Star) },
                       new ColumnDefinition{ Width= new GridLength(1, GridUnitType.Star) },
                    },
                    ColumnSpacing = 0

                };
                var floorimage = new Image
                {
                    Source = "floor.png",
                    IsVisible = propertyModel.Floor.Value,
                    Scale = 0.5,
                    HorizontalOptions = LayoutOptions.Start
                };
                var floorlable = new Label
                {
                    Text = propertyModel.FloorNo.ToString(),
                    TextColor = Color.FromHex("#FF071D66"),
                    FontSize = 8,
                    HorizontalOptions = LayoutOptions.Start,
                    VerticalOptions = LayoutOptions.Center,
                };
                floorgrid.Children.Add(floorimage, 0, 0);
                floorgrid.Children.Add(floorlable, 1, 0);
                pnggrid2.Children.Add(livinggrid, 0, 0);
                pnggrid2.Children.Add(floorgrid, 1, 0);


                var addressgrid = new Grid
                {
                    ColumnDefinitions = {
                       new ColumnDefinition{ Width= new GridLength(5, GridUnitType.Absolute) },
                       new ColumnDefinition{ Width= new GridLength(0.03, GridUnitType.Star) },
                       new ColumnDefinition{ Width= new GridLength(1, GridUnitType.Star) },
                    },
                    ColumnSpacing = 2,

                };
                var addressimage = new Image
                {
                    Source = "TextLocation.png",
                };
                var addresslable = new Label
                {
                    Text = propertyModel.AddressLAng,
                    TextColor = Color.FromHex("#FF071D66"),
                    FontSize = 10,
                    VerticalOptions = LayoutOptions.Center,
                    HorizontalOptions = LayoutOptions.Start,
                };
                addressgrid.Children.Add(addressimage, 1, 0);
                addressgrid.Children.Add(addresslable, 2, 0);

                submaingrid.Children.Add(priceidgrid, 0, 0);
                submaingrid.Children.Add(pnggrid1, 0, 1);
                submaingrid.Children.Add(pnggrid2, 0, 2);
                submaingrid.Children.Add(addressgrid, 0, 3);

                maingrid.Children.Add(pimage, 0, 0);
                maingrid.Children.Add(rategrid, 0, 0);
                maingrid.Children.Add(submaingrid, 1, 0);
                TapGestureRecognizer gridTap = new TapGestureRecognizer();
                gridTap.Tapped += (sender, e) =>
                {
                    Navigation.PushAsync(new PropertyProfile(propertyModel));
                };
                maingrid.GestureRecognizers.Add(gridTap);
                grids.Add(maingrid);
                propertyListModel.Add(propertyModel);

            }
            foreach (var e in Vehicle2)
            {

                Pin pin = new Pin
                {

                    Type = PinType.Place,
                    Position = new Position(e.Address.Latitude, e.Address.Longitude),

                    Label = e.ID.ToString(),
                    Address = e.Address.AreaName + e.Address.Country,


                };
                MyMap.Pins.Add(pin);
            }
            int i = pid;
            
            myCarousel.ItemsSource = grids;
        }

        async void OnHomeButtonClicked(object sender, EventArgs e)
        {

            try
            {
                HomeButton.IsVisible = false;
                HomeButtonBlue.IsVisible = true;

                SearchButton.IsVisible = true;
                SearchButtonBlue.IsVisible = false;

                FavoriteButton.IsVisible = true;
                FavoriteButtonBlue.IsVisible = false;

                ProfileButton.IsVisible = true;
                ProfileButtonBlue.IsVisible = false;
                var existingPages = Navigation.NavigationStack.ToList();
                await Navigation.PushAsync(new Home());
                foreach (var page in existingPages)
                {
                    Navigation.RemovePage(page);
                }
            }
            catch(Exception ex)
            {
                string er = ex.Message;
                await DisplayAlert("Error", "Check App permissions. ", "Ok");
                return;
            }
        }
        async void OnSearchButtonClicked(object sender, EventArgs e)
        {
            try
            {

                HomeButton.IsVisible = true;
                HomeButtonBlue.IsVisible = false;

                SearchButton.IsVisible = false;
                SearchButtonBlue.IsVisible = true;

                FavoriteButton.IsVisible = true;
                FavoriteButtonBlue.IsVisible = false;

                ProfileButton.IsVisible = true;
                ProfileButtonBlue.IsVisible = false;
                await PopupNavigation.Instance.PushAsync(new SearchByID());
                SearchButton.IsVisible = true;
                SearchButtonBlue.IsVisible = false;
            }

            catch
            {
                await DisplayAlert("Error", "Check App permissions. ", "Ok");
                return;
            }
        }
        async void OnProfileButtonClicked(object sender, EventArgs e)
        {
            try
            {
                HomeButton.IsVisible = true;
                HomeButtonBlue.IsVisible = false;

                SearchButton.IsVisible = true;
                SearchButtonBlue.IsVisible = false;

                FavoriteButton.IsVisible = true;
                FavoriteButtonBlue.IsVisible = false;

                ProfileButton.IsVisible = false;
                ProfileButtonBlue.IsVisible = true;
                UserDialogs.Instance.ShowLoading();
                await Task.Delay(500);
                var uri = string.Format(Constantce.URL + "/api/properties/GetAgents");
                HttpWebRequest request = WebRequest.Create(uri) as HttpWebRequest;
                using (HttpWebResponse response = request.GetResponse() as HttpWebResponse)
                {
                    StreamReader reader = new StreamReader(response.GetResponseStream());
                    string Data = reader.ReadToEnd();
                    ObservableCollection<Agent> agent = JsonConvert.DeserializeObject<ObservableCollection<Agent>>(Data);
                    await Navigation.PushAsync(new Agents(agent));
                }
                UserDialogs.Instance.HideLoading();
                // await Navigation.PushAsync(new Register());

            }

            catch
            {
                await DisplayAlert("Error", "Check App permissions. ", "Ok");
                return;
            }
        }
        async void OnFavoriteButtonClicked(object sender, EventArgs e)
        {
            try
            {
                HomeButton.IsVisible = true;
                HomeButtonBlue.IsVisible = false;

                SearchButton.IsVisible = true;
                SearchButtonBlue.IsVisible = false;

                FavoriteButton.IsVisible = false;
                FavoriteButtonBlue.IsVisible = true;

                ProfileButton.IsVisible = true;
                ProfileButtonBlue.IsVisible = false;
                Constantce.Country = "Country";
                Constantce.City = "City";
                Constantce.Area = "Area";
                Constantce.CountryLang = "";
                Constantce.CityLang = "";
                Constantce.AreaLang = "";
                Constantce.saleorrent = "saleorrent";
                //await Navigation.PushAsync(new whishList());
                if (Application.Current.Properties["Language"].ToString() == "Arabic")
                {
                    Application.Current.Properties["Language"] = "English";
                    await Application.Current.SavePropertiesAsync();
                    var existingPages = Navigation.NavigationStack.ToList();
                    await Navigation.PushAsync(new Home());
                    foreach (var page in existingPages)
                    {
                        Navigation.RemovePage(page);
                    }

                }
                else
                {
                    Application.Current.Properties["Language"] = "Arabic";
                    await Application.Current.SavePropertiesAsync();
                    var existingPages = Navigation.NavigationStack.ToList();
                    await Navigation.PushAsync(new Home());
                    foreach (var page in existingPages)
                    {
                        Navigation.RemovePage(page);
                    }
                }



            }

            catch
            {
                await DisplayAlert("Error", "Check App permissions. ", "Ok");
                return;
            }
        }
        private void ListView_PropertyChanged(object sender, System.ComponentModel.PropertyChangedEventArgs e)
        {

        }
        private async void Menu_Activated(object sender, EventArgs e)
        {

            await PopupNavigation.Instance.PushAsync(new MenuPop());
        }
        private async void LoginorRegister_Clicked(object sender, EventArgs e)
        {
            Application.Current.Properties["Token"] = "Null";
            Application.Current.Properties["UEmail"] = "Null";
            var existingPages = Navigation.NavigationStack.ToList();
            await Navigation.PushAsync(new Login());
            foreach (var page in existingPages)
            {
                Navigation.RemovePage(page);
            }
        }
        private async void Profile_Clicked(object sender, EventArgs e)
        {
            UserDialogs.Instance.ShowLoading();
            await Task.Delay(500);
            string userid = Application.Current.Properties["Token"].ToString();
            userid = userid.Replace("\"", "");
            var uri = string.Format(Constantce.URL + "/api/properties/GetProfile/?user={0}", userid);
            HttpWebRequest request = WebRequest.Create(uri) as HttpWebRequest;
            using (HttpWebResponse response = request.GetResponse() as HttpWebResponse)
            {
                StreamReader reader = new StreamReader(response.GetResponseStream());
                string Data = reader.ReadToEnd();
                ObservableCollection<Property> property = JsonConvert.DeserializeObject<ObservableCollection<Property>>(Data);
                await Navigation.PushAsync(new UserProfile(property));
            }
            UserDialogs.Instance.HideLoading();
        }
        private async void Wishlist_Clicked(object sender, EventArgs e)
        {
            UserDialogs.Instance.ShowLoading();
            await Task.Delay(500);
            string userid = Application.Current.Properties["Token"].ToString();
            userid = userid.Replace("\"", "");
            var uri = string.Format(Constantce.URL + "/api/properties/GetWishList/?user={0}", userid);
            HttpWebRequest request = WebRequest.Create(uri) as HttpWebRequest;
            using (HttpWebResponse response = request.GetResponse() as HttpWebResponse)
            {
                StreamReader reader = new StreamReader(response.GetResponseStream());
                string Data = reader.ReadToEnd();
                ObservableCollection<Property> property = JsonConvert.DeserializeObject<ObservableCollection<Property>>(Data);
                await Navigation.PushAsync(new Wishlist(property));
            }
            UserDialogs.Instance.HideLoading();
        }
        private async void Agents_Clicked(object sender, EventArgs e)
        {
            try
            {

                UserDialogs.Instance.ShowLoading();
                await Task.Delay(500);
                var uri = string.Format(Constantce.URL + "/api/properties/GetAgents");
                HttpWebRequest request = WebRequest.Create(uri) as HttpWebRequest;
                using (HttpWebResponse response = request.GetResponse() as HttpWebResponse)
                {
                    StreamReader reader = new StreamReader(response.GetResponseStream());
                    string Data = reader.ReadToEnd();
                    ObservableCollection<Agent> agent = JsonConvert.DeserializeObject<ObservableCollection<Agent>>(Data);

                    await Navigation.PushAsync(new Agents(agent));
                }
                UserDialogs.Instance.HideLoading();
                // await Navigation.PushAsync(new Register());

            }

            catch
            {
                await DisplayAlert("Error", "Check App permissions. ", "Ok");
                return;
            }
        }
        private void About_Clicked(object sender, EventArgs e)
        {

        }
        private async void Compare_Clicked(object sender, EventArgs e)
        {
            UserDialogs.Instance.ShowLoading();
            await Task.Delay(500);
            string userid = Application.Current.Properties["Token"].ToString();
            userid = userid.Replace("\"", "");
            var uri = string.Format(Constantce.URL + "/api/properties/GetCompare/?user={0}", userid);
            HttpWebRequest request = WebRequest.Create(uri) as HttpWebRequest;
            using (HttpWebResponse response = request.GetResponse() as HttpWebResponse)
            {
                StreamReader reader = new StreamReader(response.GetResponseStream());
                string Data = reader.ReadToEnd();
                ObservableCollection<Property> property = JsonConvert.DeserializeObject<ObservableCollection<Property>>(Data);
                Property property1 = property.FirstOrDefault();
                Property property2 = property.LastOrDefault();
                if (property1 != null && property2 != null && property1.SID != property2.SID) { await Navigation.PushAsync(new Compare(property1, property2)); }
                else
                {
                    if (Application.Current.Properties["Language"].ToString() == "Arabic")
                    {
                        DisplayAlert("تنبيه", "يجب عليك اضافة عقارين او اكثر", "موافق");

                    }
                    else
                    {
                        DisplayAlert("Alert", "you have to select tow or more properties", "OK");
                    }
                }
            }
            UserDialogs.Instance.HideLoading();
        }
        private async void LogOut_Clicked(object sender, EventArgs e)
        {
            Application.Current.Properties["Token"] = "Null";
            Application.Current.Properties["UEmail"] = "Null";
            Application.Current.Properties["WishP"] = "Null";
            Application.Current.Properties["ComP"] = "Null";
            var existingPages = Navigation.NavigationStack.ToList();
            await Navigation.PushAsync(new Login());
            foreach (var page in existingPages)
            {
                Navigation.RemovePage(page);
            }
        }
    }
}

