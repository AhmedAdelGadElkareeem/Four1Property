using Four1Property.View;
using Four1Property.ViewModels;
using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using Four1Property.Models;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using Four1Property.Helper;
using Acr.UserDialogs;
using System.Threading.Tasks;
using System.Net;
using Rg.Plugins.Popup.Services;
using View;
using System.IO;
using Newtonsoft.Json;
using CarouselView.FormsPlugin.Abstractions;

namespace Four1Property.View
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class AcquaintanceList : ContentPage
    {
        int index = 3;
        int adnumber = Constantce.adnumber;
        bool isLoading;
        string PID = "";
        HomeModel LoadModel = new HomeModel();
        double Longt;
        double Latt;
        ObservableCollection<Property> _properties { get; set; }
        ObservableCollection<PropertyModel> propertyListModel = new ObservableCollection<PropertyModel>();
        ObservableCollection<Ad> adds = new ObservableCollection<Ad>();
        public AcquaintanceList(ObservableCollection<Property> properties, HomeModel homeModel, double lon, double lat,ObservableCollection<Ad>ads)
        {
            InitializeComponent();
            adds = ads;
            LoadModel = homeModel;
            Longt = lon;
            Latt = lat;
            
            if (Application.Current.Properties["Language"].ToString() == "Arabic")
            {
                if (properties.Count == 0)
                {
                    //listView.IsVisible = false;
                    NoProperty.Text = "لا يوجد اي عقار";
                    NoProperty.TextColor = Color.FromHex("#FF071D66");
                    NoProperty.IsVisible = true;
                }
                this.Title = "قائمة عرض";
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
                    //listView.IsVisible = false;
                    NoProperty.Text = "No Properties Found";
                    NoProperty.TextColor = Color.FromHex("#FF071D66");
                    NoProperty.IsVisible = true;
                }
                this.Title = "List View";
                this.FlowDirection = FlowDirection.LeftToRight;

            }
            _properties = new ObservableCollection<Property>();
            _properties = properties;
            BindingContext = new AcquaintanceListDataViewModels();
            int x = 1;
            foreach (var item in properties)
            {
                PropertyModel propertyModel = new PropertyModel();
                propertyModel.Address = item.Address;
                propertyModel.SID = item.SID;
                string SIDT = propertyModel.SID.Replace("ID: ", "");
                SIDT = SIDT.Replace(" ", "");
                if (Application.Current.Properties["Language"].ToString() == "Arabic")
                {
                    if (Application.Current.Properties["WishP"].ToString().Contains(SIDT))
                    {
                        propertyModel.Wishtext = "حذف من المفضلة";
                        propertyModel.Wishtcolor = "White";
                        propertyModel.Wishcolor = "wishiconblue.png";
                    }
                    else
                    {
                        propertyModel.Wishtext = "اضافة الى المفضلة";
                        propertyModel.Wishcolor = "wishicongray.png";
                        propertyModel.Wishtcolor = "#FF071D66";
                    }
                    if (Application.Current.Properties["ComP"].ToString().Contains(SIDT))
                    {
                        propertyModel.Coomtext = "حذف من المقارنة";
                        propertyModel.Coomtcolor = "White";
                        propertyModel.Coomcolor = "compareiconblue.png";
                    }
                    else
                    {
                        propertyModel.Coomtext = "اضافة الى المقارنة";
                        propertyModel.Coomcolor = "compareicongray.png";
                        propertyModel.Coomtcolor = "#FF071D66";
                    }
                }
                else
                {
                    if (Application.Current.Properties["WishP"].ToString().Contains(propertyModel.SID))
                    {
                        propertyModel.Wishtext = "Remove From Wishlist";
                        propertyModel.Wishtcolor = "White";
                        propertyModel.Wishcolor = "wishiconblue.png";
                    }
                    else
                    {
                        propertyModel.Wishtext = "Add To Wishlist";
                        propertyModel.Wishcolor = "wishicongray.png";
                        propertyModel.Wishtcolor = "#FF071D66";
                    }
                    if (Application.Current.Properties["ComP"].ToString().Contains(propertyModel.SID))
                    {
                        propertyModel.Coomtext = "Remove From Compare";
                        propertyModel.Coomtcolor = "White";
                        propertyModel.Coomcolor = "compareiconblue.png";
                    }
                    else
                    {
                        propertyModel.Coomtext = "Add To Compare";
                        propertyModel.Coomcolor = "compareicongray.png";
                        propertyModel.Coomtcolor = "#FF071D66";
                    }

                }


                if (Application.Current.Properties["Language"].ToString() == "Arabic")
                {
                    propertyModel.AddressLAng = item.Address.CityAR;
                    propertyModel.LeftArrow = "rightarrow.png";
                    propertyModel.RightArrow = "leftarrow.png";
                    propertyModel.Title = "ID: " + item.SID + "  ";
                    propertyModel.SID = "ID: " + item.SID + "  ";
                }
                else
                {
                    propertyModel.AddressLAng = item.Address.City;
                    propertyModel.RightArrow = "rightarrow.png";
                    propertyModel.LeftArrow = "leftarrow.png";
                    propertyModel.Title = "ID: " + item.SID + "  ";
                    propertyModel.SID = "ID: " + item.SID + "  ";

                }
                propertyModel.AddressID = item.AddressID;
                propertyModel.For = item.For;
                propertyModel.ID = item.ID;
                if (item.Photos.FirstOrDefault()?.UploadedTo == null)
                {
                    propertyModel.Photo = "defultprop.png";
                }
                else
                {
                    propertyModel.Photo = item.Photos.FirstOrDefault()?.UploadedTo;
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
                if (Application.Current.Properties["Token"].ToString() != "Null" && Application.Current.Properties["Token"].ToString() != "Guest")
                {
                    propertyModel.LogedIN = true;
                }
                else
                {
                    propertyModel.LogedIN = false;
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
                if (propertyModel.AllPhotos.Count == 0) { 
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
                if (x == 3) { propertyModel.Ad = true; x = 1; } else { x = x + 1; }
                propertyListModel.Add(propertyModel);

                var maingrid = new Grid { };
                if (propertyModel.LogedIN == true)
                {
                    maingrid = new Grid
                    {
                        RowDefinitions =
        {
          new RowDefinition { Height = new GridLength(1, GridUnitType.Star) },
          new RowDefinition { Height =  new GridLength(0.4, GridUnitType.Star) },
          new RowDefinition { Height = new GridLength(0.2, GridUnitType.Star) },
          new RowDefinition { Height = new GridLength(1, GridUnitType.Absolute) },
          new RowDefinition { Height = new GridLength(0.4, GridUnitType.Star) },
          new RowDefinition { Height = new GridLength(0, GridUnitType.Absolute) }
        },
                        BackgroundColor = Color.White,
                        HeightRequest = 500,
                        RowSpacing = 0,

                    };
                }
                else
                {
                    maingrid = new Grid
                    {
                        RowDefinitions =
        {
          new RowDefinition { Height = new GridLength(1, GridUnitType.Star) },
          new RowDefinition { Height =  new GridLength(0.4, GridUnitType.Star) },
          new RowDefinition { Height = new GridLength(0.2, GridUnitType.Star) },
          new RowDefinition { Height = new GridLength(0.1, GridUnitType.Star) },
          new RowDefinition { Height = new GridLength(5, GridUnitType.Absolute) },
          new RowDefinition { Height = new GridLength(5, GridUnitType.Absolute) }
        },
                        BackgroundColor = Color.White,
                        HeightRequest = 400,
                        RowSpacing = 0,

                    };
                }
                var image = new Image
                {
                    Source = propertyModel.AllPhotos.FirstOrDefault().UploadedTo,
                    Aspect = Aspect.Fill,
                };


                ObservableCollection<Image> images = new ObservableCollection<Image>();
                foreach (var ee in propertyModel.AllPhotos)
                {
                    image = new Image
                    {
                        Source = ee.UploadedTo,
                        Aspect = Aspect.Fill,
                    };
                    images.Add(image);
                }
                CarouselViewControl myCarousel = new CarouselViewControl
                {
                    ItemsSource = images,
                    ItemTemplate = new DataTemplate(typeof(Image)),
                    IndicatorsTintColor = Color.DarkGray,
                    CurrentPageIndicatorTintColor = Color.FromHex("#071d66"),
                    IndicatorsShape = IndicatorsShape.Circle,
                    ShowIndicators = true,
                    ShowArrows = true,
                    IsSwipeEnabled = true,
                    Orientation = CarouselViewOrientation.Horizontal,
                    ArrowsBackgroundColor = Color.FromHex("#071d66"),
                    VerticalOptions = LayoutOptions.Fill,
                    HorizontalOptions = LayoutOptions.Fill,

                };

                var rategrid = new Grid
                {
                    RowDefinitions =
                    {
                         new RowDefinition { Height = new GridLength(1, GridUnitType.Star) },
                    },
                    HorizontalOptions = LayoutOptions.End,
                    VerticalOptions = LayoutOptions.Start,
                };
                var rateimage = new Image
                {
                    Source = "Rate.png",
                    Aspect = Aspect.AspectFit,
                };
                var rlablegrid = new Grid
                {
                    RowDefinitions =
        {
          new RowDefinition { Height = new GridLength(0.4, GridUnitType.Star) },
          new RowDefinition { Height =  new GridLength(1, GridUnitType.Star) },
                    },
                };
                var ratelable = new Label
                {
                    Text = propertyModel.Review,
                    FontSize = 8,
                };
                rategrid.Children.Add(rateimage);
                rategrid.Children.Add(ratelable);

                var pricegrid = new Grid
                {
                    RowDefinitions =
        {
          new RowDefinition { Height = new GridLength(20, GridUnitType.Absolute) },
          new RowDefinition { Height = new GridLength(40, GridUnitType.Absolute) },
          new RowDefinition { Height = new GridLength(5, GridUnitType.Star) },
        },
                    ColumnDefinitions =
        {
          new ColumnDefinition { Width = new GridLength(15, GridUnitType.Absolute) },
          new ColumnDefinition { Width = new GridLength(105, GridUnitType.Absolute) },
          new ColumnDefinition { Width = new GridLength(105, GridUnitType.Absolute) },
          new ColumnDefinition { Width = new GridLength(1, GridUnitType.Star) },
        },
                    ColumnSpacing = 0,
                };
                var pricebox = new BoxView
                {
                    BackgroundColor = Color.FromHex("#FF071D66"),
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
                    BackgroundColor = Color.FromHex(propertyModel.Color)
                };
                var saleorrentlable = new Label
                {
                    Text = propertyModel.StatusLang,
                    TextColor = Color.White,
                    FontSize = 11,
                    VerticalOptions = LayoutOptions.Center,
                    HorizontalOptions = LayoutOptions.Center,
                };
                var idgrid = new Grid
                {
                    RowDefinitions =
        {
          new RowDefinition { Height = new GridLength(15, GridUnitType.Absolute) },
          new RowDefinition { Height = new GridLength(1, GridUnitType.Star) },
        },
                    VerticalOptions = LayoutOptions.End,
                    HorizontalOptions = LayoutOptions.End,
                };
                var idlable = new Label
                {
                    Text = propertyModel.SID,
                    TextColor = Color.FromHex("#FF071D66"),
                    FontSize = 11,
                    VerticalOptions = LayoutOptions.Center,
                };
                idgrid.Children.Add(idlable, 0, 1);
                pricegrid.Children.Add(pricebox, 1, 1);
                pricegrid.Children.Add(pricelable, 1, 1);
                pricegrid.Children.Add(saleorrentbox, 2, 1);
                pricegrid.Children.Add(saleorrentlable, 2, 1);
                pricegrid.Children.Add(idgrid, 3, 1);
                rategrid.Children.Add(pricegrid, 0, 1);
                var pricerategrid = new Grid
                {
                    RowDefinitions =
        {
          new RowDefinition { Height = new GridLength(1, GridUnitType.Star) },
          new RowDefinition { Height = new GridLength(40, GridUnitType.Absolute) },
        },
                };
                pricerategrid.Children.Add(rategrid, 0, 0);
                pricerategrid.Children.Add(pricegrid, 0, 1);

                var pnggrid = new Grid
                {
                    RowDefinitions =
        {
          new RowDefinition { Height = new GridLength(40, GridUnitType.Absolute) },
          new RowDefinition { Height = new GridLength(1, GridUnitType.Star) },
        },
                    ColumnDefinitions =
                    {
                        new ColumnDefinition{ Width= new GridLength(70, GridUnitType.Absolute) },
                        new ColumnDefinition{ Width= new GridLength(70, GridUnitType.Absolute) },
                        new ColumnDefinition{ Width= new GridLength(70, GridUnitType.Absolute) },
                        new ColumnDefinition{ Width= new GridLength(70, GridUnitType.Absolute) },
                        new ColumnDefinition{ Width= new GridLength(70, GridUnitType.Absolute) },
                    },
                    ColumnSpacing = 4,
                    RowSpacing = 0

                };
                var areagrid = new Grid
                {
                    ColumnDefinitions = {
                       new ColumnDefinition{ Width= new GridLength(1, GridUnitType.Star) },
                       new ColumnDefinition{ Width= new GridLength(1, GridUnitType.Star) },
                    },

                };
                var areaimage = new Image
                {
                    Source = "area.png",
                    IsVisible = propertyModel.Area.Value,
                    Scale = 0.6,
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

                };
                var bedimage = new Image
                {
                    Source = "bedroom.png",
                    IsVisible = propertyModel.Bed.Value,
                    Scale = 0.6,
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

                };
                var bathimage = new Image
                {
                    Source = "bathroom.png",
                    IsVisible = propertyModel.Bath.Value,
                    Scale = 0.6,
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
                var livinggrid = new Grid
                {
                    ColumnDefinitions = {
                       new ColumnDefinition{ Width= new GridLength(1, GridUnitType.Star) },
                       new ColumnDefinition{ Width= new GridLength(1, GridUnitType.Star) },
                    },

                };
                var livingimage = new Image
                {
                    Source = "livingroom.png",
                    IsVisible = propertyModel.Living.Value,
                    Scale = 0.6,
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

                };
                var floorimage = new Image
                {
                    Source = "floor.png",
                    IsVisible = propertyModel.Floor.Value,
                    Scale = 0.6,
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
                pnggrid.Children.Add(areagrid, 0, 1);
                pnggrid.Children.Add(bedgrid, 1, 1);
                pnggrid.Children.Add(bathgrid, 2, 1);
                pnggrid.Children.Add(livinggrid, 3, 1);
                pnggrid.Children.Add(floorgrid, 4, 1);
                var addressgrid = new Grid
                {
                    ColumnDefinitions = {
                       new ColumnDefinition{ Width= new GridLength(30, GridUnitType.Absolute) },
                       new ColumnDefinition{ Width= new GridLength(1, GridUnitType.Star) },
                    },

                };
                var addressimage = new Image
                {
                    Source = "TextLocation.png",
                    HorizontalOptions = LayoutOptions.End
                };
                var addresslable = new Label
                {
                    Text = propertyModel.AddressLAng,
                    TextColor = Color.FromHex("#FF071D66"),
                    FontSize = 10,
                    HorizontalOptions = LayoutOptions.Start,
                    VerticalOptions = LayoutOptions.Center,
                };
                addressgrid.Children.Add(addressimage, 0, 0);
                addressgrid.Children.Add(addresslable, 1, 0);
                var wishgrid = new Grid
                {
                    RowDefinitions =
        {
          new RowDefinition { Height = new GridLength(1, GridUnitType.Star) },
          new RowDefinition { Height = new GridLength(5, GridUnitType.Absolute) },
          new RowDefinition { Height = new GridLength(25, GridUnitType.Absolute) },
        },
                    ColumnDefinitions =
        {
          new ColumnDefinition { Width = new GridLength(10, GridUnitType.Absolute) },
          new ColumnDefinition { Width = new GridLength(1, GridUnitType.Star) },
                    },
                    IsVisible = propertyModel.LogedIN.Value,
                };
                var wishimage = new Image
                {
                    Source = propertyModel.Wishcolor,
                    VerticalOptions = LayoutOptions.Center,
                    HorizontalOptions = LayoutOptions.Center,
                    Scale = 1
                };
                var wishlable = new Label
                {
                    Text = propertyModel.Wishtext,
                    VerticalOptions = LayoutOptions.Center,
                    HorizontalOptions = LayoutOptions.Center,
                    TextColor = Color.FromHex("#FF071D66"),
                    FontSize = 11,
                };
                wishgrid.Children.Add(wishimage, 1, 0);
                wishgrid.Children.Add(wishlable, 1, 2);
                TapGestureRecognizer wishtap = new TapGestureRecognizer();
                wishtap.Tapped += async (sender, e) =>
                 {
                     PID = propertyModel.SID.Replace("ID: ", "");
                     PID = PID.Replace(" ", "");
                     UserDialogs.Instance.ShowLoading();
                     var uri = "";
                     string addordelete = "";
                     await Task.Delay(500);
                     string userid = Application.Current.Properties["Token"].ToString().Replace("\"", "");
                     if (Application.Current.Properties["WishP"].ToString().Contains(PID))
                     {
                         uri = string.Format(Constantce.URL + "/api/properties/RemoveToWish?userid={0}&propertyid={1}", userid, PID);
                     }
                     else
                     {
                         uri = string.Format(Constantce.URL + "/api/properties/AddToWish?userid={0}&propertyid={1}", userid, PID);
                     }
                     HttpWebRequest request = WebRequest.Create(uri) as HttpWebRequest;
                     using (HttpWebResponse response = request.GetResponse() as HttpWebResponse)
                     {
                         StreamReader reader = new StreamReader(response.GetResponseStream());
                         string Data = reader.ReadToEnd();
                         addordelete = Data.Replace("\"", "");
                     }
                     if (addordelete == "Added")
                     {
                         Application.Current.Properties["WishP"] = Application.Current.Properties["WishP"] + "," + PID;

                     }
                     else
                     {
                         string x2 = "," + PID;
                         string list = Application.Current.Properties["WishP"].ToString();
                         list = list.Replace(x2, "");
                         Application.Current.Properties["WishP"] = list;
                     }
                     this.Navigation.PopAsync();
                     await Navigation.PushAsync(new Tapped(_properties, homeModel, Longt, Latt,ads));
                     await Task.Delay(500);
                     UserDialogs.Instance.HideLoading();
                 };
                wishgrid.GestureRecognizers.Add(wishtap);
                var coomgrid = new Grid
                {
                    RowDefinitions =
        {
          new RowDefinition { Height = new GridLength(1, GridUnitType.Star) },
          new RowDefinition { Height = new GridLength(5, GridUnitType.Absolute) },
          new RowDefinition { Height = new GridLength(25, GridUnitType.Absolute) },
        },
                    ColumnDefinitions =
        {
          new ColumnDefinition { Width = new GridLength(10, GridUnitType.Absolute) },
          new ColumnDefinition { Width = new GridLength(1, GridUnitType.Star) },
                    },
                    IsVisible = propertyModel.LogedIN.Value,
                };
                var coomimage = new Image
                {
                    Source = propertyModel.Coomcolor,
                    VerticalOptions = LayoutOptions.Center,
                    HorizontalOptions = LayoutOptions.Center,
                    Scale = 1
                };
                var coomlable = new Label
                {
                    Text = propertyModel.Coomtext,
                    VerticalOptions = LayoutOptions.Center,
                    HorizontalOptions = LayoutOptions.Center,
                    TextColor = Color.FromHex("#FF071D66"),
                    FontSize = 11,
                };
                coomgrid.Children.Add(coomimage, 1, 0);
                coomgrid.Children.Add(coomlable, 1, 2);
                TapGestureRecognizer coomtap = new TapGestureRecognizer();
                coomtap.Tapped += async (sender, e) =>
                 {
                     PID = propertyModel.SID.Replace("ID: ", "");
                     PID = PID.Replace(" ", "");
                     UserDialogs.Instance.ShowLoading();
                     var uri = "";
                     string addordelete = "";
                     await Task.Delay(500);
                     string userid = Application.Current.Properties["Token"].ToString().Replace("\"", "");
                     if (Application.Current.Properties["ComP"].ToString().Contains(PID))
                     {
                         uri = string.Format(Constantce.URL + "/api/properties/RemoveToCompare?userid={0}&propertyid={1}", userid, PID);
                     }
                     else
                     {
                         uri = string.Format(Constantce.URL + "/api/properties/AddToCompare?userid={0}&propertyid={1}", userid, PID);
                     }
                     HttpWebRequest request = WebRequest.Create(uri) as HttpWebRequest;
                     using (HttpWebResponse response = request.GetResponse() as HttpWebResponse)
                     {
                         StreamReader reader = new StreamReader(response.GetResponseStream());
                         string Data = reader.ReadToEnd();
                         addordelete = Data.Replace("\"", "");
                     }
                     if (addordelete == "Added")
                     {
                         Application.Current.Properties["ComP"] = Application.Current.Properties["ComP"] + "," + PID;

                     }
                     else
                     {
                         string x2 = "," + PID;
                         string list = Application.Current.Properties["ComP"].ToString();
                         list = list.Replace(x2, "");
                         Application.Current.Properties["ComP"] = list;
                     }
                     this.Navigation.PopAsync();
                     await Navigation.PushAsync(new Tapped(_properties, homeModel, Longt, Latt,ads));
                     await Task.Delay(500);
                     UserDialogs.Instance.HideLoading();
                 };
                coomgrid.GestureRecognizers.Add(coomtap);
                var coomwishgrid = new Grid
                {
                    RowDefinitions =
        {
          new RowDefinition { Height = new GridLength(1, GridUnitType.Star) },
          new RowDefinition { Height = new GridLength(.4, GridUnitType.Star) },
        },
                    ColumnDefinitions =
        {
          new ColumnDefinition { Width = new GridLength(10, GridUnitType.Absolute) },
          new ColumnDefinition { Width = new GridLength(1, GridUnitType.Star) },
          new ColumnDefinition { Width = new GridLength(10, GridUnitType.Absolute) },
          new ColumnDefinition { Width = new GridLength(1, GridUnitType.Star) },
          new ColumnDefinition { Width = new GridLength(10, GridUnitType.Absolute) },
                    },
                };
                coomwishgrid.Children.Add(coomgrid, 1, 0);
                coomwishgrid.Children.Add(wishgrid, 3, 0);


                maingrid.Children.Add(myCarousel, 0, 0);
                maingrid.Children.Add(pricerategrid, 0, 0);
                maingrid.Children.Add(pnggrid, 0, 1);
                maingrid.Children.Add(addressgrid, 0, 2);
                maingrid.Children.Add(coomwishgrid, 0, 4);
                TapGestureRecognizer gridTap = new TapGestureRecognizer();
                gridTap.Tapped += (sender, e) =>
                {
                    Navigation.PushAsync(new PropertyProfile(propertyModel));
                };
                maingrid.GestureRecognizers.Add(gridTap);

                ListLayout.Children.Add(maingrid);
                if (propertyModel.Ad == true)
                {
                    var grid = new Grid
                    {
                        HeightRequest = 80,
                        ColumnDefinitions = {
                       new ColumnDefinition{ Width= new GridLength(30, GridUnitType.Absolute) },
                       new ColumnDefinition{ Width= new GridLength(1, GridUnitType.Star) },
                       new ColumnDefinition{ Width= new GridLength(30, GridUnitType.Absolute) },
                    },
                    };
                    var imagead = new Image { Source = "ad.png ", Aspect = Aspect.Fill };
                    if (adds.Count != 0)
                    {
                        var ad = ads.FirstOrDefault();
                        if (ad.AdsPhoto != null) { imagead.Source = ad.AdsPhoto.UploadedTo; }
                        else if (ad.AdsPhoto2 != null) { imagead.Source = ad.AdsPhoto2.UploadedTo; }
                        ads.Remove(ad);
                        adds = ads;
                    }
                    grid.Children.Add(imagead, 1, 0);
                    ListLayout.Children.Add(grid);
                }
            }
            //listView.ItemsSource = propertyListModel;


        }

        protected override void OnAppearing()
        {
            base.OnAppearing();
            MessagingCenter.Send(this, "preventLandScape");
        }
        private async Task LoadItems()
        {
            var x = 1;
            int pid = propertyListModel.Count();
            ObservableCollection<PropertyModel> Vehicle2 = new ObservableCollection<PropertyModel>();
            isLoading = true;
            var uri = string.Format(Constantce.URL + "/api/properties/" + Constantce.APIName + "?fort={0}&category={1}&Subcat={2}&lon={3}&lat={4}&id={5}&bed={6}&bath={7}", Constantce.homeModelC.SaleOrRent, Constantce.homeModelC.Category, Constantce.homeModelC.SubCategory, Longt, Latt, pid, Constantce.Bed, Constantce.Bath);
            HttpWebRequest request = WebRequest.Create(uri) as HttpWebRequest;
            using (HttpWebResponse response = request.GetResponse() as HttpWebResponse)
            {
                StreamReader reader = new StreamReader(response.GetResponseStream());
                string Data = reader.ReadToEnd();
                ObservableCollection<PropertyModel> property = JsonConvert.DeserializeObject<ObservableCollection<PropertyModel>>(Data);
                Vehicle2 = property;
            }
            Constantce.listkength = Vehicle2.Count();
            //simulator delayed load
            foreach (var item in Vehicle2)
            {
                PropertyModel propertyModel = new PropertyModel();
                propertyModel.Address = item.Address;
                propertyModel.SID = item.SID;
                string SIDT = propertyModel.SID.Replace("ID: ", "");
                SIDT = SIDT.Replace(" ", "");
                if (Application.Current.Properties["Language"].ToString() == "Arabic")
                {
                    if (Application.Current.Properties["WishP"].ToString().Contains(SIDT))
                    {
                        propertyModel.Wishtext = "حذف من المفضلة";
                        propertyModel.Wishtcolor = "White";
                        propertyModel.Wishcolor = "wishiconblue.png";
                    }
                    else
                    {
                        propertyModel.Wishtext = "اضافة الى المفضلة";
                        propertyModel.Wishcolor = "wishicongray.png";
                        propertyModel.Wishtcolor = "#FF071D66";
                    }
                    if (Application.Current.Properties["ComP"].ToString().Contains(SIDT))
                    {
                        propertyModel.Coomtext = "حذف من المقارنة";
                        propertyModel.Coomtcolor = "White";
                        propertyModel.Coomcolor = "compareiconblue.png";
                    }
                    else
                    {
                        propertyModel.Coomtext = "اضافة الى المقارنة";
                        propertyModel.Coomcolor = "compareicongray.png";
                        propertyModel.Coomtcolor = "#FF071D66";
                    }
                }
                else
                {
                    if (Application.Current.Properties["WishP"].ToString().Contains(propertyModel.SID))
                    {
                        propertyModel.Wishtext = "Remove From Wishlist";
                        propertyModel.Wishtcolor = "White";
                        propertyModel.Wishcolor = "wishiconblue.png";
                    }
                    else
                    {
                        propertyModel.Wishtext = "Add To Wishlist";
                        propertyModel.Wishcolor = "wishicongray.png";
                        propertyModel.Wishtcolor = "#FF071D66";
                    }
                    if (Application.Current.Properties["ComP"].ToString().Contains(propertyModel.SID))
                    {
                        propertyModel.Coomtext = "Remove From Compare";
                        propertyModel.Coomtcolor = "White";
                        propertyModel.Coomcolor = "compareiconblue.png";
                    }
                    else
                    {
                        propertyModel.Coomtext = "Add To Compare";
                        propertyModel.Coomcolor = "compareicongray.png";
                        propertyModel.Coomtcolor = "#FF071D66";
                    }

                }


                if (Application.Current.Properties["Language"].ToString() == "Arabic")
                {
                    propertyModel.AddressLAng = item.Address.CityAR;
                    propertyModel.LeftArrow = "rightarrow.png";
                    propertyModel.RightArrow = "leftarrow.png";
                    propertyModel.Title = "ID: " + item.SID + "  ";
                    propertyModel.SID = "ID: " + item.SID + "  ";
                }
                else
                {
                    propertyModel.AddressLAng = item.Address.City;
                    propertyModel.RightArrow = "rightarrow.png";
                    propertyModel.LeftArrow = "leftarrow.png";
                    propertyModel.Title = "ID: " + item.SID + "  ";
                    propertyModel.SID = "ID: " + item.SID + "  ";

                }
                propertyModel.AddressID = item.AddressID;
                propertyModel.For = item.For;
                propertyModel.ID = item.ID;
                if (item.Photos.FirstOrDefault()?.UploadedTo == null)
                {
                    propertyModel.Photo = "defultprop.png";
                }
                else
                {
                    propertyModel.Photo = item.Photos.FirstOrDefault()?.UploadedTo;
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
                if (Application.Current.Properties["Token"].ToString() != "Null" && Application.Current.Properties["Token"].ToString() != "Guest")
                {
                    propertyModel.LogedIN = true;
                }
                else
                {
                    propertyModel.LogedIN = false;
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
                if (propertyModel.AllPhotos.Count == 0)
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
                if (x == 3) { propertyModel.Ad = true; x = 1; } else { x = x + 1; }
                propertyListModel.Add(propertyModel);

                var maingrid = new Grid { };
                if (propertyModel.LogedIN == true)
                {
                    maingrid = new Grid
                    {
                        RowDefinitions =
        {
          new RowDefinition { Height = new GridLength(1, GridUnitType.Star) },
          new RowDefinition { Height =  new GridLength(0.4, GridUnitType.Star) },
          new RowDefinition { Height = new GridLength(0.2, GridUnitType.Star) },
          new RowDefinition { Height = new GridLength(1, GridUnitType.Absolute) },
          new RowDefinition { Height = new GridLength(0.4, GridUnitType.Star) },
          new RowDefinition { Height = new GridLength(0, GridUnitType.Absolute) }
        },
                        BackgroundColor = Color.White,
                        HeightRequest = 500,
                        RowSpacing = 0,

                    };
                }
                else
                {
                    maingrid = new Grid
                    {
                        RowDefinitions =
        {
          new RowDefinition { Height = new GridLength(1, GridUnitType.Star) },
          new RowDefinition { Height =  new GridLength(0.4, GridUnitType.Star) },
          new RowDefinition { Height = new GridLength(0.2, GridUnitType.Star) },
          new RowDefinition { Height = new GridLength(0.1, GridUnitType.Star) },
          new RowDefinition { Height = new GridLength(5, GridUnitType.Absolute) },
          new RowDefinition { Height = new GridLength(5, GridUnitType.Absolute) }
        },
                        BackgroundColor = Color.White,
                        HeightRequest = 400,
                        RowSpacing = 0,

                    };
                }
                var image = new Image
                {
                    Source = propertyModel.AllPhotos.FirstOrDefault().UploadedTo,
                    Aspect = Aspect.Fill,
                };


                ObservableCollection<Image> images = new ObservableCollection<Image>();
                foreach (var ee in propertyModel.AllPhotos)
                {
                    image = new Image
                    {
                        Source = ee.UploadedTo,
                        Aspect = Aspect.Fill,
                    };
                    images.Add(image);
                }
                CarouselViewControl myCarousel = new CarouselViewControl
                {
                    ItemsSource = images,
                    ItemTemplate = new DataTemplate(typeof(Image)),
                    IndicatorsTintColor = Color.DarkGray,
                    CurrentPageIndicatorTintColor = Color.FromHex("#071d66"),
                    IndicatorsShape = IndicatorsShape.Circle,
                    ShowIndicators = true,
                    ShowArrows = true,
                    IsSwipeEnabled = true,
                    Orientation = CarouselViewOrientation.Horizontal,
                    ArrowsBackgroundColor = Color.FromHex("#071d66"),
                    VerticalOptions = LayoutOptions.Fill,
                    HorizontalOptions = LayoutOptions.Fill,

                };

                var rategrid = new Grid
                {
                    RowDefinitions =
                    {
                         new RowDefinition { Height = new GridLength(1, GridUnitType.Star) },
                    },
                    HorizontalOptions = LayoutOptions.End,
                    VerticalOptions = LayoutOptions.Start,
                };
                var rateimage = new Image
                {
                    Source = "Rate.png",
                    Aspect = Aspect.AspectFit,
                };
                var rlablegrid = new Grid
                {
                    RowDefinitions =
        {
          new RowDefinition { Height = new GridLength(0.4, GridUnitType.Star) },
          new RowDefinition { Height =  new GridLength(1, GridUnitType.Star) },
                    },
                };
                var ratelable = new Label
                {
                    Text = propertyModel.Review,
                    FontSize = 8,
                };
                rategrid.Children.Add(rateimage);
                rategrid.Children.Add(ratelable);

                var pricegrid = new Grid
                {
                    RowDefinitions =
        {
          new RowDefinition { Height = new GridLength(20, GridUnitType.Absolute) },
          new RowDefinition { Height = new GridLength(40, GridUnitType.Absolute) },
          new RowDefinition { Height = new GridLength(5, GridUnitType.Star) },
        },
                    ColumnDefinitions =
        {
          new ColumnDefinition { Width = new GridLength(15, GridUnitType.Absolute) },
          new ColumnDefinition { Width = new GridLength(105, GridUnitType.Absolute) },
          new ColumnDefinition { Width = new GridLength(105, GridUnitType.Absolute) },
          new ColumnDefinition { Width = new GridLength(1, GridUnitType.Star) },
        },
                    ColumnSpacing = 0,
                };
                var pricebox = new BoxView
                {
                    BackgroundColor = Color.FromHex("#FF071D66"),
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
                    BackgroundColor = Color.FromHex(propertyModel.Color)
                };
                var saleorrentlable = new Label
                {
                    Text = propertyModel.StatusLang,
                    TextColor = Color.White,
                    FontSize = 11,
                    VerticalOptions = LayoutOptions.Center,
                    HorizontalOptions = LayoutOptions.Center,
                };
                var idgrid = new Grid
                {
                    RowDefinitions =
        {
          new RowDefinition { Height = new GridLength(15, GridUnitType.Absolute) },
          new RowDefinition { Height = new GridLength(1, GridUnitType.Star) },
        },
                    VerticalOptions = LayoutOptions.End,
                    HorizontalOptions = LayoutOptions.End,
                };
                var idlable = new Label
                {
                    Text = propertyModel.SID,
                    TextColor = Color.FromHex("#FF071D66"),
                    FontSize = 11,
                    VerticalOptions = LayoutOptions.Center,
                };
                idgrid.Children.Add(idlable, 0, 1);
                pricegrid.Children.Add(pricebox, 1, 1);
                pricegrid.Children.Add(pricelable, 1, 1);
                pricegrid.Children.Add(saleorrentbox, 2, 1);
                pricegrid.Children.Add(saleorrentlable, 2, 1);
                pricegrid.Children.Add(idgrid, 3, 1);
                rategrid.Children.Add(pricegrid, 0, 1);
                var pricerategrid = new Grid
                {
                    RowDefinitions =
        {
          new RowDefinition { Height = new GridLength(1, GridUnitType.Star) },
          new RowDefinition { Height = new GridLength(40, GridUnitType.Absolute) },
        },
                };
                pricerategrid.Children.Add(rategrid, 0, 0);
                pricerategrid.Children.Add(pricegrid, 0, 1);

                var pnggrid = new Grid
                {
                    RowDefinitions =
        {
          new RowDefinition { Height = new GridLength(40, GridUnitType.Absolute) },
          new RowDefinition { Height = new GridLength(1, GridUnitType.Star) },
        },
                    ColumnDefinitions =
                    {
                        new ColumnDefinition{ Width= new GridLength(70, GridUnitType.Absolute) },
                        new ColumnDefinition{ Width= new GridLength(70, GridUnitType.Absolute) },
                        new ColumnDefinition{ Width= new GridLength(70, GridUnitType.Absolute) },
                        new ColumnDefinition{ Width= new GridLength(70, GridUnitType.Absolute) },
                        new ColumnDefinition{ Width= new GridLength(70, GridUnitType.Absolute) },
                    },
                    ColumnSpacing = 4,
                    RowSpacing = 0

                };
                var areagrid = new Grid
                {
                    ColumnDefinitions = {
                       new ColumnDefinition{ Width= new GridLength(1, GridUnitType.Star) },
                       new ColumnDefinition{ Width= new GridLength(1, GridUnitType.Star) },
                    },

                };
                var areaimage = new Image
                {
                    Source = "area.png",
                    IsVisible = propertyModel.Area.Value,
                    Scale = 0.6,
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

                };
                var bedimage = new Image
                {
                    Source = "bedroom.png",
                    IsVisible = propertyModel.Bed.Value,
                    Scale = 0.6,
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

                };
                var bathimage = new Image
                {
                    Source = "bathroom.png",
                    IsVisible = propertyModel.Bath.Value,
                    Scale = 0.6,
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
                var livinggrid = new Grid
                {
                    ColumnDefinitions = {
                       new ColumnDefinition{ Width= new GridLength(1, GridUnitType.Star) },
                       new ColumnDefinition{ Width= new GridLength(1, GridUnitType.Star) },
                    },

                };
                var livingimage = new Image
                {
                    Source = "livingroom.png",
                    IsVisible = propertyModel.Living.Value,
                    Scale = 0.6,
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

                };
                var floorimage = new Image
                {
                    Source = "floor.png",
                    IsVisible = propertyModel.Floor.Value,
                    Scale = 0.6,
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
                pnggrid.Children.Add(areagrid, 0, 1);
                pnggrid.Children.Add(bedgrid, 1, 1);
                pnggrid.Children.Add(bathgrid, 2, 1);
                pnggrid.Children.Add(livinggrid, 3, 1);
                pnggrid.Children.Add(floorgrid, 4, 1);
                var addressgrid = new Grid
                {
                    ColumnDefinitions = {
                       new ColumnDefinition{ Width= new GridLength(30, GridUnitType.Absolute) },
                       new ColumnDefinition{ Width= new GridLength(1, GridUnitType.Star) },
                    },

                };
                var addressimage = new Image
                {
                    Source = "TextLocation.png",
                    HorizontalOptions = LayoutOptions.End
                };
                var addresslable = new Label
                {
                    Text = propertyModel.AddressLAng,
                    TextColor = Color.FromHex("#FF071D66"),
                    FontSize = 10,
                    HorizontalOptions = LayoutOptions.Start,
                    VerticalOptions = LayoutOptions.Center,
                };
                addressgrid.Children.Add(addressimage, 0, 0);
                addressgrid.Children.Add(addresslable, 1, 0);
                var wishgrid = new Grid
                {
                    RowDefinitions =
        {
          new RowDefinition { Height = new GridLength(1, GridUnitType.Star) },
          new RowDefinition { Height = new GridLength(5, GridUnitType.Absolute) },
          new RowDefinition { Height = new GridLength(25, GridUnitType.Absolute) },
        },
                    ColumnDefinitions =
        {
          new ColumnDefinition { Width = new GridLength(10, GridUnitType.Absolute) },
          new ColumnDefinition { Width = new GridLength(1, GridUnitType.Star) },
                    },
                    IsVisible = propertyModel.LogedIN.Value,
                };
                var wishimage = new Image
                {
                    Source = propertyModel.Wishcolor,
                    VerticalOptions = LayoutOptions.Center,
                    HorizontalOptions = LayoutOptions.Center,
                    Scale = 1
                };
                var wishlable = new Label
                {
                    Text = propertyModel.Wishtext,
                    VerticalOptions = LayoutOptions.Center,
                    HorizontalOptions = LayoutOptions.Center,
                    TextColor = Color.FromHex("#FF071D66"),
                    FontSize = 11,
                };
                wishgrid.Children.Add(wishimage, 1, 0);
                wishgrid.Children.Add(wishlable, 1, 2);
                TapGestureRecognizer wishtap = new TapGestureRecognizer();
                wishtap.Tapped += async (sender, e) =>
                {
                    PID = propertyModel.SID.Replace("ID: ", "");
                    PID = PID.Replace(" ", "");
                    UserDialogs.Instance.ShowLoading();
                    var uri1 = "";
                    string addordelete = "";
                    await Task.Delay(500);
                    string userid = Application.Current.Properties["Token"].ToString().Replace("\"", "");
                    if (Application.Current.Properties["WishP"].ToString().Contains(PID))
                    {
                        uri1 = string.Format(Constantce.URL + "/api/properties/RemoveToWish?userid={0}&propertyid={1}", userid, PID);
                    }
                    else
                    {
                        uri1 = string.Format(Constantce.URL + "/api/properties/AddToWish?userid={0}&propertyid={1}", userid, PID);
                    }
                    HttpWebRequest request1 = WebRequest.Create(uri1) as HttpWebRequest;
                    using (HttpWebResponse response = request1.GetResponse() as HttpWebResponse)
                    {
                        StreamReader reader = new StreamReader(response.GetResponseStream());
                        string Data = reader.ReadToEnd();
                        addordelete = Data.Replace("\"", "");
                    }
                    if (addordelete == "Added")
                    {
                        Application.Current.Properties["WishP"] = Application.Current.Properties["WishP"] + "," + PID;

                    }
                    else
                    {
                        string x2 = "," + PID;
                        string list = Application.Current.Properties["WishP"].ToString();
                        list = list.Replace(x2, "");
                        Application.Current.Properties["WishP"] = list;
                    }
                    this.Navigation.PopAsync();
                    await Navigation.PushAsync(new Tapped(_properties, Constantce.homeModelC, Longt, Latt,adds));
                    await Task.Delay(500);
                    UserDialogs.Instance.HideLoading();
                }; wishgrid.GestureRecognizers.Add(wishtap);
                var coomgrid = new Grid
                {
                    RowDefinitions =
        {
          new RowDefinition { Height = new GridLength(1, GridUnitType.Star) },
          new RowDefinition { Height = new GridLength(5, GridUnitType.Absolute) },
          new RowDefinition { Height = new GridLength(25, GridUnitType.Absolute) },
        },
                    ColumnDefinitions =
        {
          new ColumnDefinition { Width = new GridLength(10, GridUnitType.Absolute) },
          new ColumnDefinition { Width = new GridLength(1, GridUnitType.Star) },
                    },
                    IsVisible = propertyModel.LogedIN.Value,
                };
                var coomimage = new Image
                {
                    Source = propertyModel.Coomcolor,
                    VerticalOptions = LayoutOptions.Center,
                    HorizontalOptions = LayoutOptions.Center,
                    Scale = 1
                };
                var coomlable = new Label
                {
                    Text = propertyModel.Coomtext,
                    VerticalOptions = LayoutOptions.Center,
                    HorizontalOptions = LayoutOptions.Center,
                    TextColor = Color.FromHex("#FF071D66"),
                    FontSize = 11,
                };
                coomgrid.Children.Add(coomimage, 1, 0);
                coomgrid.Children.Add(coomlable, 1, 2);
                TapGestureRecognizer coomtap = new TapGestureRecognizer();
                coomtap.Tapped += async (sender, e) =>
                {
                    PID = propertyModel.SID.Replace("ID: ", "");
                    PID = PID.Replace(" ", "");
                    UserDialogs.Instance.ShowLoading();
                    var uri2 = "";
                    string addordelete = "";
                    await Task.Delay(500);
                    string userid = Application.Current.Properties["Token"].ToString().Replace("\"", "");
                    if (Application.Current.Properties["ComP"].ToString().Contains(PID))
                    {
                        uri2 = string.Format(Constantce.URL + "/api/properties/RemoveToCompare?userid={0}&propertyid={1}", userid, PID);
                    }
                    else
                    {
                        uri2 = string.Format(Constantce.URL + "/api/properties/AddToCompare?userid={0}&propertyid={1}", userid, PID);
                    }
                    HttpWebRequest request2 = WebRequest.Create(uri2) as HttpWebRequest;
                    using (HttpWebResponse response = request2.GetResponse() as HttpWebResponse)
                    {
                        StreamReader reader = new StreamReader(response.GetResponseStream());
                        string Data = reader.ReadToEnd();
                        addordelete = Data.Replace("\"", "");
                    }
                    if (addordelete == "Added")
                    {
                        Application.Current.Properties["ComP"] = Application.Current.Properties["ComP"] + "," + PID;

                    }
                    else
                    {
                        string x2 = "," + PID;
                        string list = Application.Current.Properties["ComP"].ToString();
                        list = list.Replace(x2, "");
                        Application.Current.Properties["ComP"] = list;
                    }
                    this.Navigation.PopAsync();
                    await Navigation.PushAsync(new Tapped(_properties, Constantce.homeModelC, Longt, Latt,adds));
                    await Task.Delay(500);
                    UserDialogs.Instance.HideLoading();
                };
                coomgrid.GestureRecognizers.Add(coomtap);
                var coomwishgrid = new Grid
                {
                    RowDefinitions =
        {
          new RowDefinition { Height = new GridLength(1, GridUnitType.Star) },
          new RowDefinition { Height = new GridLength(.4, GridUnitType.Star) },
        },
                    ColumnDefinitions =
        {
          new ColumnDefinition { Width = new GridLength(10, GridUnitType.Absolute) },
          new ColumnDefinition { Width = new GridLength(1, GridUnitType.Star) },
          new ColumnDefinition { Width = new GridLength(10, GridUnitType.Absolute) },
          new ColumnDefinition { Width = new GridLength(1, GridUnitType.Star) },
          new ColumnDefinition { Width = new GridLength(10, GridUnitType.Absolute) },
                    },
                };
                coomwishgrid.Children.Add(coomgrid, 1, 0);
                coomwishgrid.Children.Add(wishgrid, 3, 0);


                maingrid.Children.Add(myCarousel, 0, 0);
                maingrid.Children.Add(pricerategrid, 0, 0);
                maingrid.Children.Add(pnggrid, 0, 1);
                maingrid.Children.Add(addressgrid, 0, 2);
                maingrid.Children.Add(coomwishgrid, 0, 4);
                TapGestureRecognizer gridTap = new TapGestureRecognizer();
                gridTap.Tapped += (sender, e) =>
                {
                    Navigation.PushAsync(new PropertyProfile(propertyModel));
                };
                maingrid.GestureRecognizers.Add(gridTap);

                ListLayout.Children.Add(maingrid);
                if (propertyModel.Ad == true)
                {
                    var grid = new Grid
                    {
                        HeightRequest = 80,
                        ColumnDefinitions = {
                       new ColumnDefinition{ Width= new GridLength(30, GridUnitType.Absolute) },
                       new ColumnDefinition{ Width= new GridLength(1, GridUnitType.Star) },
                       new ColumnDefinition{ Width= new GridLength(30, GridUnitType.Absolute) },
                    },
                    };
                    var imagead = new Image { Source = "ad.png ", Aspect = Aspect.Fill };
                    if (adds.Count != 0) { 
                    var ad = adds.FirstOrDefault();
                    if (ad.AdsPhoto != null) { imagead.Source = ad.AdsPhoto.UploadedTo; }
                    else if (ad.AdsPhoto2 != null) { imagead.Source = ad.AdsPhoto2.UploadedTo; }
                    adds.Remove(ad);
                    }
                    grid.Children.Add(imagead, 1, 0);
                    ListLayout.Children.Add(grid);
                }
            }
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

            catch
            {
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

        private void ListView_ItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            try
            {
                var selection = e.SelectedItem as PropertyModel;
                Navigation.PushAsync(new PropertyProfile(selection));
                //listView.SelectedItem = null;
            }
            catch (Exception ex)
            {
                System.Diagnostics.Debug.Write(ex.Message);
            }
        }

        private async void ListView_ItemAppearing(object sender, ItemVisibilityEventArgs e)
        {
            var selection = e.Item as PropertyModel;
            PID = selection.SID.Replace("ID: ", "");
            PID = PID.Replace(" ", "");

            if (propertyListModel.Count >= 10)
                if (e.Item == propertyListModel.LastOrDefault())
                {
                    await LoadItems();
                }

            return;
        }
        private async void Menu_Activated(object sender, EventArgs e)
        {

            await PopupNavigation.Instance.PushAsync(new MenuPop());
        }

        private void TapGestureRecognizer_Tapped(object sender, EventArgs e)
        {

        }

       

        private void ListView_ItemDisappearing(object sender, ItemVisibilityEventArgs e)
        {

        }

        private async void ScrollView_Scrolled(object sender, Xamarin.Forms.ScrolledEventArgs e)
        {
            if (Constantce.listkength==10) { 
            double scrollingSpace = Scrolllay.ContentSize.Height - Scrolllay.Height - 100.0;
            var height = Scrolllay.ContentSize.Height;
            var hheight = Scrolllay.ContentSize.Height / 3;
            if (propertyListModel.Count >= 10)
            {
                if (scrollingSpace <= e.ScrollY)
                {
                    LoadItems();
                    return;
                }
            }
            }
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