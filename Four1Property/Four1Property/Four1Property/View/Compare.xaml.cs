using Acr.UserDialogs;
using Four1Property.Helper;
using Four1Property.Models;
using Four1Property.ViewModels;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Four1Property.View
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Compare : ContentPage
    {   
        public Compare(Property property1, Property property2)
        {
            InitializeComponent();
            if (Application.Current.Properties["Language"].ToString() == "Arabic")
            {
                this.FlowDirection = FlowDirection.RightToLeft;
                this.Title = "المقارنة";
            }
            else
            {
                this.FlowDirection = FlowDirection.LeftToRight;
                this.Title = "Compare";
            }
            if (property1.Equals(null) || property2.Equals(null))
            {
                if (Application.Current.Properties["Language"].ToString() == "Arabic")
                {
                    DisplayAlert("تنبيه", "يرحى اختيار اكثر من عقار واحد", "موافق");
                }
                else
                {
                    DisplayAlert("Alert", "PLease More Than One Properties", "OK");
                }
            }
            else
            {
                var Maingrid = new Grid
                {
                    RowDefinitions ={
                    new RowDefinition { Height = new GridLength(120, GridUnitType.Absolute) },
                    new RowDefinition { Height = new GridLength(1, GridUnitType.Star) },
                   
                },RowSpacing=0
                };
                //title grid start
                var titlegrid = new Grid
                {
                    ColumnDefinitions ={
                    new ColumnDefinition { Width = new GridLength(1, GridUnitType.Star) },
                    new ColumnDefinition { Width = new GridLength(1, GridUnitType.Star) },
                    new ColumnDefinition { Width = new GridLength(1, GridUnitType.Star) },
                },
                    BackgroundColor = Color.WhiteSmoke
                };
                var Detaillable = new Label { FontSize = 11, TextColor = Color.FromHex("#FF071D66"), VerticalOptions = LayoutOptions.Center, HorizontalOptions = LayoutOptions.Center };
                if (Application.Current.Properties["Language"].ToString() == "Arabic") { Detaillable.Text = "العقار"; } else { Detaillable.Text = "Property"; }
                var Property1lable = new Label { Text = property1.SID, FontSize = 11, TextColor = Color.FromHex("#FF071D66"), VerticalOptions = LayoutOptions.Center, HorizontalOptions = LayoutOptions.Center };
                var Property2lable = new Label { Text = property2.SID, FontSize = 11, TextColor = Color.FromHex("#FF071D66"), VerticalOptions = LayoutOptions.Center, HorizontalOptions = LayoutOptions.Center };
                var property1imglable = new Grid 
                {
                    RowDefinitions ={
                    new RowDefinition { Height = new GridLength(1, GridUnitType.Star) },
                    new RowDefinition { Height = new GridLength(30, GridUnitType.Absolute) },

                },
                    ColumnDefinitions ={
                    new ColumnDefinition { Width = new GridLength(1, GridUnitType.Star) },
                    new ColumnDefinition { Width = new GridLength(5, GridUnitType.Absolute) },
                },
                    RowSpacing = 0
                };
                var property2imglable = new Grid 
                {
                    RowDefinitions ={
                    new RowDefinition { Height = new GridLength(1, GridUnitType.Star) },
                    new RowDefinition { Height = new GridLength(30, GridUnitType.Absolute) },

                },
                    ColumnDefinitions ={
                    new ColumnDefinition { Width = new GridLength(1, GridUnitType.Star) },
                    new ColumnDefinition { Width = new GridLength(5, GridUnitType.Absolute) },
                },
                    RowSpacing = 0
                };
                var property1img = new Image 
                {
                    Source= property1.PhotosQ.UploadedTo,
                    Aspect = Aspect.AspectFit,
                };
                var property2img = new Image 
                {
                    Source= property2.PhotosQ.UploadedTo,
                    Aspect = Aspect.AspectFit,
                };
                var propety1delete = new Image 
                {
                Source= "Delete.png", Scale = 0.4, VerticalOptions= LayoutOptions.Start, HorizontalOptions = LayoutOptions.End
                };
                TapGestureRecognizer propety1deletec = new TapGestureRecognizer();
                propety1deletec.Tapped += async (sender, e) =>
                {
                   var  PID = property1.SID.Replace("ID: ", "");
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
                    userid = userid.Replace("\"", "");
                    var uri1 = string.Format(Constantce.URL + "/api/properties/GetCompare/?user={0}", userid);
                    HttpWebRequest request1 = WebRequest.Create(uri1) as HttpWebRequest;
                    using (HttpWebResponse response = request1.GetResponse() as HttpWebResponse)
                    {
                        StreamReader reader = new StreamReader(response.GetResponseStream());
                        string Data = reader.ReadToEnd();
                        ObservableCollection<Property> property = JsonConvert.DeserializeObject<ObservableCollection<Property>>(Data);
                        Property property11 = property.FirstOrDefault();
                        Property property22 = property.LastOrDefault();
                        if (property11 != null && property22 != null && property11.SID != property22.SID) { this.Navigation.PopAsync(); await Navigation.PushAsync(new Compare(property11, property22)); }
                        else
                        {
                            var existingPages = Navigation.NavigationStack.ToList();
                            await Navigation.PushAsync(new Home());
                            foreach (var page in existingPages)
                            {
                                Navigation.RemovePage(page);
                            }
                        }
                    }
                    await Task.Delay(500);
                    UserDialogs.Instance.HideLoading();
                };
                propety1delete.GestureRecognizers.Add(propety1deletec);
                var propety2delete = new Image 
                {
                Source= "Delete.png", Scale = 0.4, VerticalOptions= LayoutOptions.Start, HorizontalOptions = LayoutOptions.End
                };
                TapGestureRecognizer propety2deletec = new TapGestureRecognizer();
                propety2deletec.Tapped += async (sender, e) =>
                {
                    var PID = property2.SID.Replace("ID: ", "");
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
                    userid = userid.Replace("\"", "");
                    var uri1 = string.Format(Constantce.URL + "/api/properties/GetCompare/?user={0}", userid);
                    HttpWebRequest request1 = WebRequest.Create(uri1) as HttpWebRequest;
                    using (HttpWebResponse response = request1.GetResponse() as HttpWebResponse)
                    {
                        StreamReader reader = new StreamReader(response.GetResponseStream());
                        string Data = reader.ReadToEnd();
                        ObservableCollection<Property> property = JsonConvert.DeserializeObject<ObservableCollection<Property>>(Data);
                        Property property11 = property.FirstOrDefault();
                        Property property22 = property.LastOrDefault();
                        if (property11 != null && property22 != null && property11.SID != property22.SID) { this.Navigation.PopAsync(); await Navigation.PushAsync(new Compare(property11, property22)); }
                        else
                        {
                            var existingPages = Navigation.NavigationStack.ToList();
                            await Navigation.PushAsync(new Home());
                            foreach (var page in existingPages)
                            {
                                Navigation.RemovePage(page);
                            }
                        }
                    }
                    await Task.Delay(500);
                    UserDialogs.Instance.HideLoading();
                };
                propety2delete.GestureRecognizers.Add(propety2deletec);
                property1imglable.Children.Add(property1img,0,0);
                property1imglable.Children.Add(propety1delete, 0,0);
                property1imglable.Children.Add(Property1lable,0,1);
                property2imglable.Children.Add(property2img, 0,0);
                property2imglable.Children.Add(propety2delete, 0,0);
                property2imglable.Children.Add(Property2lable,0,1);
                titlegrid.Children.Add(Detaillable, 0, 0);
                titlegrid.Children.Add(property1imglable, 1, 0);
                titlegrid.Children.Add(property2imglable, 2, 0);
                //title grid end
                /////////////////////////////////////////////////////
                ////////////////////////////////////////////////////
                // comparision grid start
                var scrollview = new ScrollView {VerticalOptions= LayoutOptions.StartAndExpand };
                var comparegrid = new Grid
                {
                    RowDefinitions ={
                    new RowDefinition { Height = new GridLength(60, GridUnitType.Absolute) },//0
                    new RowDefinition { Height = new GridLength(60, GridUnitType.Absolute) },//1
                    new RowDefinition { Height = new GridLength(60, GridUnitType.Absolute) },//2
                    new RowDefinition { Height = new GridLength(60, GridUnitType.Absolute) },//3
                    new RowDefinition { Height = new GridLength(60, GridUnitType.Absolute) },//4
                    new RowDefinition { Height = new GridLength(60, GridUnitType.Absolute) },//5
                    new RowDefinition { Height = new GridLength(60, GridUnitType.Absolute) },//6
                    new RowDefinition { Height = new GridLength(60, GridUnitType.Absolute) },//7
                    new RowDefinition { Height = new GridLength(60, GridUnitType.Absolute) },//8
                    new RowDefinition { Height = new GridLength(60, GridUnitType.Absolute) },//9
                    new RowDefinition { Height = new GridLength(60, GridUnitType.Absolute) },//10
                    new RowDefinition { Height = new GridLength(60, GridUnitType.Absolute) },//11
                    new RowDefinition { Height = new GridLength(60, GridUnitType.Absolute) },//12
                    new RowDefinition { Height = new GridLength(60, GridUnitType.Absolute) },//13
                    new RowDefinition { Height = new GridLength(60, GridUnitType.Absolute) },//14
                    new RowDefinition { Height = new GridLength(60, GridUnitType.Absolute) },//15
                    new RowDefinition { Height = new GridLength(60, GridUnitType.Absolute) },//16
                    new RowDefinition { Height = new GridLength(60, GridUnitType.Absolute) },//17
                    new RowDefinition { Height = new GridLength(60, GridUnitType.Absolute) },//18
                }, VerticalOptions = LayoutOptions.StartAndExpand, RowSpacing = 0
                };
                //////Type
                var typegrid = new Grid
                {
                    ColumnDefinitions ={
                    new ColumnDefinition { Width = new GridLength(1, GridUnitType.Star) },
                    new ColumnDefinition { Width = new GridLength(1, GridUnitType.Star) },
                    new ColumnDefinition { Width = new GridLength(1, GridUnitType.Star) },
                },
                    BackgroundColor = Color.White,
                };
                var typelable = new Label { FontSize = 11, TextColor = Color.FromHex("#FF071D66"), VerticalOptions = LayoutOptions.Center, HorizontalOptions = LayoutOptions.Center };
                if (Application.Current.Properties["Language"].ToString() == "Arabic") { typelable.Text = "النوع"; } else { typelable.Text = "Type"; }
                var Property1type = new Label { Text = property1.OfType.Title, FontSize = 11, TextColor = Color.FromHex("#FF071D66"), VerticalOptions = LayoutOptions.Center, HorizontalOptions = LayoutOptions.Center };
                var Property2typpe = new Label { Text = property2.OfType.Title, FontSize = 11, TextColor = Color.FromHex("#FF071D66"), VerticalOptions = LayoutOptions.Center, HorizontalOptions = LayoutOptions.Center };
                if (Application.Current.Properties["Language"].ToString() == "Arabic") { Property1type.Text = property1.OfType.TitleAR; Property2typpe.Text = property2.OfType.TitleAR; } else { }
                typegrid.Children.Add(typelable, 0, 0);
                typegrid.Children.Add(Property1type, 1, 0);
                typegrid.Children.Add(Property2typpe, 2, 0);
                comparegrid.Children.Add(typegrid, 0, 0);
                ///////Price
                var pricegrid = new Grid
                {
                    ColumnDefinitions ={
                    new ColumnDefinition { Width = new GridLength(1, GridUnitType.Star) },
                    new ColumnDefinition { Width = new GridLength(1, GridUnitType.Star) },
                    new ColumnDefinition { Width = new GridLength(1, GridUnitType.Star) },
                },
                    BackgroundColor = Color.LightGray,
                };
                var Pricelable = new Label { FontSize = 11, TextColor = Color.FromHex("#FF071D66"), VerticalOptions = LayoutOptions.Center, HorizontalOptions = LayoutOptions.Center };
                if (Application.Current.Properties["Language"].ToString() == "Arabic") { Pricelable.Text = "السعر"; } else { Pricelable.Text = "Price"; }
                var Property1price = new Label { Text = property1.Price.ToString(), FontSize = 11, TextColor = Color.FromHex("#FF071D66"), VerticalOptions = LayoutOptions.Center, HorizontalOptions = LayoutOptions.Center };
                var Property2tprice = new Label { Text = property2.Price.ToString(), FontSize = 11, TextColor = Color.FromHex("#FF071D66"), VerticalOptions = LayoutOptions.Center, HorizontalOptions = LayoutOptions.Center };
                pricegrid.Children.Add(Pricelable, 0, 0);
                pricegrid.Children.Add(Property1price, 1, 0);
                pricegrid.Children.Add(Property2tprice, 2, 0);
                comparegrid.Children.Add(pricegrid, 0, 1);
                ///////
                ///////status
                var statusgrid = new Grid
                {
                    ColumnDefinitions ={
                    new ColumnDefinition { Width = new GridLength(1, GridUnitType.Star) },
                    new ColumnDefinition { Width = new GridLength(1, GridUnitType.Star) },
                    new ColumnDefinition { Width = new GridLength(1, GridUnitType.Star) },
                },
                    BackgroundColor = Color.White,
                };
                var statuslable = new Label { FontSize = 11, TextColor = Color.FromHex("#FF071D66"), VerticalOptions = LayoutOptions.Center, HorizontalOptions = LayoutOptions.Center };
                if (Application.Current.Properties["Language"].ToString() == "Arabic") { statuslable.Text = "الحالة"; } else { statuslable.Text = "Status"; }
                var Property1status = new Label { FontSize = 11, TextColor = Color.FromHex("#FF071D66"), VerticalOptions = LayoutOptions.Center, HorizontalOptions = LayoutOptions.Center };
                var Property2status = new Label { FontSize = 11, TextColor = Color.FromHex("#FF071D66"), VerticalOptions = LayoutOptions.Center, HorizontalOptions = LayoutOptions.Center };
                if (Application.Current.Properties["Language"].ToString() == "Arabic")
                {
                    if (property1.For == For.Sale) { Property1status.Text = "للبيع"; } else { Property1status.Text = "للايجار"; }
                    if (property1.For == For.Sale) { Property2status.Text = "للبيع"; } else { Property2status.Text = "للايجار"; }
                }
                else
                {
                    if (property1.For == For.Sale) { Property1status.Text = "Sale"; } else { Property1status.Text = "Rent"; }
                    if (property1.For == For.Sale) { Property2status.Text = "Sale"; } else { Property2status.Text = "Rent"; }
                }
                statusgrid.Children.Add(statuslable, 0, 0);
                statusgrid.Children.Add(Property1status, 1, 0);
                statusgrid.Children.Add(Property2status, 2, 0);
                comparegrid.Children.Add(statusgrid, 0, 2);
                ///////
                ///////Location
                var Locationgrid = new Grid
                {
                    ColumnDefinitions ={
                    new ColumnDefinition { Width = new GridLength(1, GridUnitType.Star) },
                    new ColumnDefinition { Width = new GridLength(1, GridUnitType.Star) },
                    new ColumnDefinition { Width = new GridLength(1, GridUnitType.Star) },
                },
                    BackgroundColor = Color.LightGray,
                };
                var Locationlable = new Label { FontSize = 11, TextColor = Color.FromHex("#FF071D66"), VerticalOptions = LayoutOptions.Center, HorizontalOptions = LayoutOptions.Center };
                if (Application.Current.Properties["Language"].ToString() == "Arabic") { Locationlable.Text = "الموقع"; } else { Locationlable.Text = "location"; }
                var Property1loc = new Label { FontSize = 11, TextColor = Color.FromHex("#FF071D66"), VerticalOptions = LayoutOptions.Center, HorizontalOptions = LayoutOptions.Center };
                var Property2loc = new Label { FontSize = 11, TextColor = Color.FromHex("#FF071D66"), VerticalOptions = LayoutOptions.Center, HorizontalOptions = LayoutOptions.Center };
                if (Application.Current.Properties["Language"].ToString() == "Arabic")
                {
                    Property1loc.Text = property1.Address.AreaNameAR + ", " + property1.Address.CityAR;
                    Property2loc.Text = property2.Address.AreaNameAR + ", " + property2.Address.CityAR;
                }
                else
                {
                    Property1loc.Text = property1.Address.AreaName + ", " + property1.Address.City;
                    Property2loc.Text = property2.Address.AreaName + ", " + property2.Address.City;
                }
                Locationgrid.Children.Add(Locationlable, 0, 0);
                Locationgrid.Children.Add(Property1loc, 1, 0);
                Locationgrid.Children.Add(Property2loc, 2, 0);
                comparegrid.Children.Add(Locationgrid, 0, 3);
                /////bed 
                var bedgrid = new Grid
                {
                    ColumnDefinitions ={
                    new ColumnDefinition { Width = new GridLength(1, GridUnitType.Star) },
                    new ColumnDefinition { Width = new GridLength(1, GridUnitType.Star) },
                    new ColumnDefinition { Width = new GridLength(1, GridUnitType.Star) },
                },
                    BackgroundColor = Color.White,
                };
                var bedlable = new Label { FontSize = 11, TextColor = Color.FromHex("#FF071D66"), VerticalOptions = LayoutOptions.Center, HorizontalOptions = LayoutOptions.Center }; ;
                if (Application.Current.Properties["Language"].ToString() == "Arabic") { bedlable.Text = "غرف النوم"; } else { bedlable.Text = "Bed Rooms"; }
                var Property1bed = new Label { Text = property1.Beds.ToString(), FontSize = 11, TextColor = Color.FromHex("#FF071D66"), VerticalOptions = LayoutOptions.Center, HorizontalOptions = LayoutOptions.Center };
                var Property2bed = new Label { Text = property2.Beds.ToString(), FontSize = 11, TextColor = Color.FromHex("#FF071D66"), VerticalOptions = LayoutOptions.Center, HorizontalOptions = LayoutOptions.Center };
                bedgrid.Children.Add(bedlable, 0, 0);
                bedgrid.Children.Add(Property1bed, 1, 0);
                bedgrid.Children.Add(Property2bed, 2, 0);
                comparegrid.Children.Add(bedgrid, 0, 4);
                ////
                /////bath 
                var bathgrid = new Grid
                {
                    ColumnDefinitions ={
                    new ColumnDefinition { Width = new GridLength(1, GridUnitType.Star) },
                    new ColumnDefinition { Width = new GridLength(1, GridUnitType.Star) },
                    new ColumnDefinition { Width = new GridLength(1, GridUnitType.Star) },
                },
                    BackgroundColor = Color.LightGray,
                };
                var bathlable = new Label { FontSize = 11, TextColor = Color.FromHex("#FF071D66"), VerticalOptions = LayoutOptions.Center, HorizontalOptions = LayoutOptions.Center }; ;
                if (Application.Current.Properties["Language"].ToString() == "Arabic") { bathlable.Text = "الحمامات"; } else { bathlable.Text = "Bath Rooms"; }
                var Property1bath = new Label { Text = property1.Baths.ToString(), FontSize = 11, TextColor = Color.FromHex("#FF071D66"), VerticalOptions = LayoutOptions.Center, HorizontalOptions = LayoutOptions.Center };
                var Property2bath = new Label { Text = property2.Baths.ToString(), FontSize = 11, TextColor = Color.FromHex("#FF071D66"), VerticalOptions = LayoutOptions.Center, HorizontalOptions = LayoutOptions.Center };
                bathgrid.Children.Add(bathlable, 0, 0);
                bathgrid.Children.Add(Property1bath, 1, 0);
                bathgrid.Children.Add(Property2bath, 2, 0);
                comparegrid.Children.Add(bathgrid, 0, 5);
                ////
                ///////green gray images
                var greenimage = new Image { Source = "circlegreen.png", Scale = 0.3, Aspect = Aspect.AspectFit, HorizontalOptions = LayoutOptions.Center, VerticalOptions = LayoutOptions.Center };
                var grayimage = new Image { Source = "circlegrey.png", Scale = 0.3, Aspect = Aspect.AspectFit, HorizontalOptions = LayoutOptions.Center, VerticalOptions = LayoutOptions.Center };
                /////
                ////carspace
                var cargrid = new Grid
                {
                    ColumnDefinitions ={
                    new ColumnDefinition { Width = new GridLength(1, GridUnitType.Star) },
                    new ColumnDefinition { Width = new GridLength(1, GridUnitType.Star) },
                    new ColumnDefinition { Width = new GridLength(1, GridUnitType.Star) },
                },
                    BackgroundColor = Color.White,
                };
                var carspacelable = new Label { FontSize = 11, TextColor = Color.FromHex("#FF071D66"), VerticalOptions = LayoutOptions.Center, HorizontalOptions = LayoutOptions.Center }; ;
                if (Application.Current.Properties["Language"].ToString() == "Arabic") { carspacelable.Text = "كراج سيارات"; } else { carspacelable.Text = "Car Spaces"; }
                cargrid.Children.Add(carspacelable, 0, 0);
                var cargreenimage1 = new Image { Source = "circlegreen.png", Scale = 0.3, Aspect = Aspect.AspectFit, HorizontalOptions = LayoutOptions.Center, VerticalOptions = LayoutOptions.Center , IsVisible = false};
                var cargrayimage1 = new Image { Source = "circlegrey.png", Scale = 0.3, Aspect = Aspect.AspectFit, HorizontalOptions = LayoutOptions.Center, VerticalOptions = LayoutOptions.Center , IsVisible= true };
               var cargreenimage2 = new Image { Source = "circlegreen.png", Scale = 0.3, Aspect = Aspect.AspectFit, HorizontalOptions = LayoutOptions.Center, VerticalOptions = LayoutOptions.Center , IsVisible = false};
                var cargrayimage2 = new Image { Source = "circlegrey.png", Scale = 0.3, Aspect = Aspect.AspectFit, HorizontalOptions = LayoutOptions.Center, VerticalOptions = LayoutOptions.Center , IsVisible= true };
                cargrid.Children.Add(cargreenimage1, 1, 0);
                cargrid.Children.Add(cargrayimage1, 1, 0);
                cargrid.Children.Add(cargreenimage2, 2, 0);
                cargrid.Children.Add(cargrayimage2, 2, 0);

                if (property1.CarSpaces == CarSpaces.Yes && property1.CarSpaces != null)
                { cargrayimage1.IsVisible = false; cargreenimage1.IsVisible = true; }
                
                if (property2.CarSpaces == CarSpaces.Yes && property2.CarSpaces != null)
                { cargrayimage2.IsVisible = false; cargreenimage2.IsVisible = true; }
                
                comparegrid.Children.Add(cargrid, 0, 6);

                /////
                ////Aircon
                var arecongrid = new Grid
                {
                    ColumnDefinitions ={
                    new ColumnDefinition { Width = new GridLength(1, GridUnitType.Star) },
                    new ColumnDefinition { Width = new GridLength(1, GridUnitType.Star) },
                    new ColumnDefinition { Width = new GridLength(1, GridUnitType.Star) },
                },
                    BackgroundColor = Color.LightGray,
                };
                var areconlable = new Label { FontSize = 11, TextColor = Color.FromHex("#FF071D66"), VerticalOptions = LayoutOptions.Center, HorizontalOptions = LayoutOptions.Center }; ;
                if (Application.Current.Properties["Language"].ToString() == "Arabic") { areconlable.Text = "تكيف"; } else { areconlable.Text = "Air Condition"; }
                arecongrid.Children.Add(areconlable, 0, 0);
                var areagreenimage1 = new Image { Source = "circlegreen.png", Scale = 0.3, Aspect = Aspect.AspectFit, HorizontalOptions = LayoutOptions.Center, VerticalOptions = LayoutOptions.Center, IsVisible = false };
                var areagrayimage1 = new Image { Source = "circlegrey.png", Scale = 0.3, Aspect = Aspect.AspectFit, HorizontalOptions = LayoutOptions.Center, VerticalOptions = LayoutOptions.Center, IsVisible = true };
                var areagreenimage2 = new Image { Source = "circlegreen.png", Scale = 0.3, Aspect = Aspect.AspectFit, HorizontalOptions = LayoutOptions.Center, VerticalOptions = LayoutOptions.Center, IsVisible = false };
                var areagrayimage2 = new Image { Source = "circlegrey.png", Scale = 0.3, Aspect = Aspect.AspectFit, HorizontalOptions = LayoutOptions.Center, VerticalOptions = LayoutOptions.Center, IsVisible = true };
                arecongrid.Children.Add(areagreenimage1, 1, 0);
                arecongrid.Children.Add(areagrayimage1, 1, 0);
                arecongrid.Children.Add(areagreenimage2, 2, 0);
                arecongrid.Children.Add(areagrayimage2, 2, 0);
                if (property1.AirConditioning == AirConditioning.Yes && property1.AirConditioning != null)
                { areagrayimage1.IsVisible = false; areagreenimage1.IsVisible = true; }
                
                if (property2.AirConditioning == AirConditioning.Yes && property2.AirConditioning != null)
                { areagrayimage2.IsVisible = false; areagreenimage2.IsVisible = true; }
                
                comparegrid.Children.Add(arecongrid, 0, 7);

                /////
                ////balconi
                var Balconigrid = new Grid
                {
                    ColumnDefinitions ={
                    new ColumnDefinition { Width = new GridLength(1, GridUnitType.Star) },
                    new ColumnDefinition { Width = new GridLength(1, GridUnitType.Star) },
                    new ColumnDefinition { Width = new GridLength(1, GridUnitType.Star) },
                },
                    BackgroundColor = Color.White,
                };
                var Balconilable = new Label { FontSize = 11, TextColor = Color.FromHex("#FF071D66"), VerticalOptions = LayoutOptions.Center, HorizontalOptions = LayoutOptions.Center }; ;
                if (Application.Current.Properties["Language"].ToString() == "Arabic") { Balconilable.Text = "بالكون"; } else { Balconilable.Text = "Balconi"; }
                Balconigrid.Children.Add(Balconilable, 0, 0);
                var Balcongreenimage1 = new Image { Source = "circlegreen.png", Scale = 0.3, Aspect = Aspect.AspectFit, HorizontalOptions = LayoutOptions.Center, VerticalOptions = LayoutOptions.Center, IsVisible = false };
                var Balcongrayimage1 = new Image { Source = "circlegrey.png", Scale = 0.3, Aspect = Aspect.AspectFit, HorizontalOptions = LayoutOptions.Center, VerticalOptions = LayoutOptions.Center, IsVisible = true };
                var Balcongreenimage2 = new Image { Source = "circlegreen.png", Scale = 0.3, Aspect = Aspect.AspectFit, HorizontalOptions = LayoutOptions.Center, VerticalOptions = LayoutOptions.Center, IsVisible = false };
                var Balcongrayimage2 = new Image { Source = "circlegrey.png", Scale = 0.3, Aspect = Aspect.AspectFit, HorizontalOptions = LayoutOptions.Center, VerticalOptions = LayoutOptions.Center, IsVisible = true };
                Balconigrid.Children.Add(Balcongreenimage1, 1, 0);
                Balconigrid.Children.Add(Balcongrayimage1, 1, 0);
                Balconigrid.Children.Add(Balcongreenimage2, 2, 0);
                Balconigrid.Children.Add(Balcongrayimage2, 2, 0);
                if (property1.Balcony == Balcony.Yes && property1.Balcony != null)
                { Balcongrayimage1.IsVisible = false; Balcongreenimage1.IsVisible = true; }
                
                if (property2.Balcony == Balcony.Yes && property2.Balcony != null)
                { Balcongrayimage2.IsVisible = false; Balcongreenimage2.IsVisible = true; }

                comparegrid.Children.Add(Balconigrid, 0, 8);

                ///// 
                ////Kitchen
                var kitchengrid = new Grid
                {
                    ColumnDefinitions ={
                    new ColumnDefinition { Width = new GridLength(1, GridUnitType.Star) },
                    new ColumnDefinition { Width = new GridLength(1, GridUnitType.Star) },
                    new ColumnDefinition { Width = new GridLength(1, GridUnitType.Star) },
                },
                    BackgroundColor = Color.LightGray,
                };
                var kitchenlable = new Label { FontSize = 11, TextColor = Color.FromHex("#FF071D66"), VerticalOptions = LayoutOptions.Center, HorizontalOptions = LayoutOptions.Center }; ;
                if (Application.Current.Properties["Language"].ToString() == "Arabic") { kitchenlable.Text = "مطبخ"; } else { kitchenlable.Text = "Kitchen"; }
                kitchengrid.Children.Add(kitchenlable, 0, 0);
                var kitchengreenimage1 = new Image { Source = "circlegreen.png", Scale = 0.3, Aspect = Aspect.AspectFit, HorizontalOptions = LayoutOptions.Center, VerticalOptions = LayoutOptions.Center, IsVisible = false };
                var kitchengrayimage1 = new Image { Source = "circlegrey.png", Scale = 0.3, Aspect = Aspect.AspectFit, HorizontalOptions = LayoutOptions.Center, VerticalOptions = LayoutOptions.Center, IsVisible = true };
                var kitchengreenimage2 = new Image { Source = "circlegreen.png", Scale = 0.3, Aspect = Aspect.AspectFit, HorizontalOptions = LayoutOptions.Center, VerticalOptions = LayoutOptions.Center, IsVisible = false };
                var kitchengrayimage2 = new Image { Source = "circlegrey.png", Scale = 0.3, Aspect = Aspect.AspectFit, HorizontalOptions = LayoutOptions.Center, VerticalOptions = LayoutOptions.Center, IsVisible = true };
                kitchengrid.Children.Add(kitchengreenimage1, 1, 0);
                kitchengrid.Children.Add(kitchengrayimage1, 1, 0);
                kitchengrid.Children.Add(kitchengreenimage2, 2, 0);
                kitchengrid.Children.Add(kitchengrayimage2, 2, 0);
                if (property1.Kitchens == Kitchen.Yes && property1.Kitchens != null)
                { kitchengrayimage1.IsVisible = false; kitchengreenimage1.IsVisible = true; }
                
                if (property2.Kitchens == Kitchen.Yes && property2.Kitchens != null)
                { kitchengrayimage2.IsVisible = false; kitchengreenimage2.IsVisible = true; }

                comparegrid.Children.Add(kitchengrid, 0, 9);
                ///// 
                ////Dryclean
                var Drycleangrid = new Grid
                {
                    ColumnDefinitions ={
                    new ColumnDefinition { Width = new GridLength(1, GridUnitType.Star) },
                    new ColumnDefinition { Width = new GridLength(1, GridUnitType.Star) },
                    new ColumnDefinition { Width = new GridLength(1, GridUnitType.Star) },
                },
                    BackgroundColor = Color.White,
                };
                var drcleanlable = new Label { FontSize = 11, TextColor = Color.FromHex("#FF071D66"), VerticalOptions = LayoutOptions.Center, HorizontalOptions = LayoutOptions.Center }; ;
                if (Application.Current.Properties["Language"].ToString() == "Arabic") { drcleanlable.Text = "مطبخ"; } else { drcleanlable.Text = "Kitchen"; }
                Drycleangrid.Children.Add(drcleanlable, 0, 0);
                var Drycleangreenimage1 = new Image { Source = "circlegreen.png", Scale = 0.3, Aspect = Aspect.AspectFit, HorizontalOptions = LayoutOptions.Center, VerticalOptions = LayoutOptions.Center, IsVisible = false };
                var Drycleangrayimage1 = new Image { Source = "circlegrey.png", Scale = 0.3, Aspect = Aspect.AspectFit, HorizontalOptions = LayoutOptions.Center, VerticalOptions = LayoutOptions.Center, IsVisible = true };
                var Drycleangreenimage2 = new Image { Source = "circlegreen.png", Scale = 0.3, Aspect = Aspect.AspectFit, HorizontalOptions = LayoutOptions.Center, VerticalOptions = LayoutOptions.Center, IsVisible = false };
                var Drycleangrayimage2 = new Image { Source = "circlegrey.png", Scale = 0.3, Aspect = Aspect.AspectFit, HorizontalOptions = LayoutOptions.Center, VerticalOptions = LayoutOptions.Center, IsVisible = true };
                Drycleangrid.Children.Add(Drycleangreenimage1, 1, 0);
                Drycleangrid.Children.Add(Drycleangrayimage1, 1, 0);
                Drycleangrid.Children.Add(Drycleangreenimage2, 2, 0);
                Drycleangrid.Children.Add(Drycleangrayimage2, 2, 0);
                if (property1.DryCleanRoom == DryCleanRoom.Yes && property1.DryCleanRoom != null)
                { Drycleangrayimage1.IsVisible = false; Drycleangreenimage1.IsVisible = true; }
                if (property2.DryCleanRoom == DryCleanRoom.Yes && property2.DryCleanRoom != null)
                { Drycleangrayimage2.IsVisible = false; Drycleangreenimage2.IsVisible = true; }
                comparegrid.Children.Add(Drycleangrid, 0, 10);
                /////
                ////furished
                var furishedgrid = new Grid
                {
                    ColumnDefinitions ={
                    new ColumnDefinition { Width = new GridLength(1, GridUnitType.Star) },
                    new ColumnDefinition { Width = new GridLength(1, GridUnitType.Star) },
                    new ColumnDefinition { Width = new GridLength(1, GridUnitType.Star) },
                },
                    BackgroundColor = Color.LightGray,
                };
                var furnishedlable = new Label { FontSize = 11, TextColor = Color.FromHex("#FF071D66"), VerticalOptions = LayoutOptions.Center, HorizontalOptions = LayoutOptions.Center }; ;
                if (Application.Current.Properties["Language"].ToString() == "Arabic") { furnishedlable.Text = "مفروش"; } else { furnishedlable.Text = "Furnished"; }
                furishedgrid.Children.Add(furnishedlable, 0, 0);
                var furishedgreenimage1 = new Image { Source = "circlegreen.png", Scale = 0.3, Aspect = Aspect.AspectFit, HorizontalOptions = LayoutOptions.Center, VerticalOptions = LayoutOptions.Center, IsVisible = false };
                var furishedgrayimage1 = new Image { Source = "circlegrey.png", Scale = 0.3, Aspect = Aspect.AspectFit, HorizontalOptions = LayoutOptions.Center, VerticalOptions = LayoutOptions.Center, IsVisible = true };
                var furishedgreenimage2 = new Image { Source = "circlegreen.png", Scale = 0.3, Aspect = Aspect.AspectFit, HorizontalOptions = LayoutOptions.Center, VerticalOptions = LayoutOptions.Center, IsVisible = false };
                var furishedgrayimage2 = new Image { Source = "circlegrey.png", Scale = 0.3, Aspect = Aspect.AspectFit, HorizontalOptions = LayoutOptions.Center, VerticalOptions = LayoutOptions.Center, IsVisible = true };
                furishedgrid.Children.Add(furishedgreenimage1, 1, 0);
                furishedgrid.Children.Add(furishedgrayimage1, 1, 0);
                furishedgrid.Children.Add(furishedgreenimage2, 2, 0);
                furishedgrid.Children.Add(furishedgrayimage2, 2, 0);
                if (property1.Furnished == Furnished.Yes && property1.Furnished != null)
                { furishedgrayimage1.IsVisible = false; furishedgreenimage1.IsVisible = true; }
                if (property2.Furnished == Furnished.Yes && property2.Furnished != null)
                { furishedgrayimage2.IsVisible = false; furishedgreenimage2.IsVisible = true; }
                comparegrid.Children.Add(furishedgrid, 0, 11);
                /////
                ////Gym
                var Gymgrid = new Grid
                {
                    ColumnDefinitions ={
                    new ColumnDefinition { Width = new GridLength(1, GridUnitType.Star) },
                    new ColumnDefinition { Width = new GridLength(1, GridUnitType.Star) },
                    new ColumnDefinition { Width = new GridLength(1, GridUnitType.Star) },
                },
                    BackgroundColor = Color.White,
                };
                var Gymlable = new Label { FontSize = 11, TextColor = Color.FromHex("#FF071D66"), VerticalOptions = LayoutOptions.Center, HorizontalOptions = LayoutOptions.Center }; ;
                if (Application.Current.Properties["Language"].ToString() == "Arabic") { Gymlable.Text = "نادي رياضي"; } else { Gymlable.Text = "Gym"; }
                Gymgrid.Children.Add(Gymlable, 0, 0);
                var Gymgreenimage1 = new Image { Source = "circlegreen.png", Scale = 0.3, Aspect = Aspect.AspectFit, HorizontalOptions = LayoutOptions.Center, VerticalOptions = LayoutOptions.Center, IsVisible = false };
                var Gymgrayimage1 = new Image { Source = "circlegrey.png", Scale = 0.3, Aspect = Aspect.AspectFit, HorizontalOptions = LayoutOptions.Center, VerticalOptions = LayoutOptions.Center, IsVisible = true };
                var Gymgreenimage2 = new Image { Source = "circlegreen.png", Scale = 0.3, Aspect = Aspect.AspectFit, HorizontalOptions = LayoutOptions.Center, VerticalOptions = LayoutOptions.Center, IsVisible = false };
                var Gymgrayimage2 = new Image { Source = "circlegrey.png", Scale = 0.3, Aspect = Aspect.AspectFit, HorizontalOptions = LayoutOptions.Center, VerticalOptions = LayoutOptions.Center, IsVisible = true };
                Gymgrid.Children.Add(Gymgreenimage1, 1, 0);
                Gymgrid.Children.Add(Gymgrayimage1, 1, 0);
                Gymgrid.Children.Add(Gymgreenimage2, 2, 0);
                Gymgrid.Children.Add(Gymgrayimage2, 2, 0);
                if (property1.Gym == Gym.Yes && property1.Gym != null)
                { Gymgrayimage1.IsVisible = false; Gymgreenimage1.IsVisible = true; }
                if (property2.Gym == Gym.Yes && property2.Gym != null)
                { Gymgrayimage2.IsVisible = false; Gymgreenimage2.IsVisible = true; }
                comparegrid.Children.Add(Gymgrid, 0, 12);
                /////
                ////poolz
                var poolgrid = new Grid
                {
                    ColumnDefinitions ={
                    new ColumnDefinition { Width = new GridLength(1, GridUnitType.Star) },
                    new ColumnDefinition { Width = new GridLength(1, GridUnitType.Star) },
                    new ColumnDefinition { Width = new GridLength(1, GridUnitType.Star) },
                },
                    BackgroundColor = Color.LightGray,
                };
                var poollable = new Label { FontSize = 11, TextColor = Color.FromHex("#FF071D66"), VerticalOptions = LayoutOptions.Center, HorizontalOptions = LayoutOptions.Center }; ;
                if (Application.Current.Properties["Language"].ToString() == "Arabic") { poollable.Text = "مسبح"; } else { poollable.Text = "Pool"; }
                poolgrid.Children.Add(poollable, 0, 0);
                var poolgreenimage1 = new Image { Source = "circlegreen.png", Scale = 0.3, Aspect = Aspect.AspectFit, HorizontalOptions = LayoutOptions.Center, VerticalOptions = LayoutOptions.Center, IsVisible = false };
                var poolgrayimage1 = new Image { Source = "circlegrey.png", Scale = 0.3, Aspect = Aspect.AspectFit, HorizontalOptions = LayoutOptions.Center, VerticalOptions = LayoutOptions.Center, IsVisible = true };
                var poolgreenimage2 = new Image { Source = "circlegreen.png", Scale = 0.3, Aspect = Aspect.AspectFit, HorizontalOptions = LayoutOptions.Center, VerticalOptions = LayoutOptions.Center, IsVisible = false };
                var poolgrayimage2 = new Image { Source = "circlegrey.png", Scale = 0.3, Aspect = Aspect.AspectFit, HorizontalOptions = LayoutOptions.Center, VerticalOptions = LayoutOptions.Center, IsVisible = true };
                poolgrid.Children.Add(poolgreenimage1, 1, 0);
                poolgrid.Children.Add(poolgrayimage1, 1, 0);
                poolgrid.Children.Add(poolgreenimage2, 2, 0);
                poolgrid.Children.Add(poolgrayimage2, 2, 0);
                if (property1.Pool == Pool.Yes && property1.Pool != null)
                { poolgrayimage1.IsVisible = false; poolgreenimage1.IsVisible = true; }
                if (property2.Pool == Pool.Yes && property2.Pool != null)
                { poolgrayimage2.IsVisible = false; poolgreenimage2.IsVisible = true; }
                comparegrid.Children.Add(poolgrid, 0, 13);
                /////
                ////MaidsRoom
                var MaidsRoomgrid = new Grid
                {
                    ColumnDefinitions ={
                    new ColumnDefinition { Width = new GridLength(1, GridUnitType.Star) },
                    new ColumnDefinition { Width = new GridLength(1, GridUnitType.Star) },
                    new ColumnDefinition { Width = new GridLength(1, GridUnitType.Star) },
                },
                    BackgroundColor = Color.White,
                };
                var MaidsRoomlable = new Label { FontSize = 11, TextColor = Color.FromHex("#FF071D66"), VerticalOptions = LayoutOptions.Center, HorizontalOptions = LayoutOptions.Center }; ;
                if (Application.Current.Properties["Language"].ToString() == "Arabic") { MaidsRoomlable.Text = "غرفة خدم"; } else { MaidsRoomlable.Text = "Maids Room"; }
                MaidsRoomgrid.Children.Add(MaidsRoomlable, 0, 0);
                var MaidsRoomgreenimage1 = new Image { Source = "circlegreen.png", Scale = 0.3, Aspect = Aspect.AspectFit, HorizontalOptions = LayoutOptions.Center, VerticalOptions = LayoutOptions.Center, IsVisible = false };
                var MaidsRoomgrayimage1 = new Image { Source = "circlegrey.png", Scale = 0.3, Aspect = Aspect.AspectFit, HorizontalOptions = LayoutOptions.Center, VerticalOptions = LayoutOptions.Center, IsVisible = true };
                var MaidsRoomgreenimage2 = new Image { Source = "circlegreen.png", Scale = 0.3, Aspect = Aspect.AspectFit, HorizontalOptions = LayoutOptions.Center, VerticalOptions = LayoutOptions.Center, IsVisible = false };
                var MaidsRoomgrayimage2 = new Image { Source = "circlegrey.png", Scale = 0.3, Aspect = Aspect.AspectFit, HorizontalOptions = LayoutOptions.Center, VerticalOptions = LayoutOptions.Center, IsVisible = true };
                MaidsRoomgrid.Children.Add(MaidsRoomgreenimage1, 1, 0);
                MaidsRoomgrid.Children.Add(MaidsRoomgrayimage1, 1, 0);
                MaidsRoomgrid.Children.Add(MaidsRoomgreenimage2, 2, 0);
                MaidsRoomgrid.Children.Add(MaidsRoomgrayimage2, 2, 0);
                if (property1.MaidsRoom == MaidsRoom.Yes && property1.MaidsRoom != null)
                { MaidsRoomgrayimage1.IsVisible = false; MaidsRoomgreenimage1.IsVisible = true; }
                if (property2.MaidsRoom == MaidsRoom.Yes && property2.MaidsRoom != null)
                { MaidsRoomgrayimage2.IsVisible = false; MaidsRoomgreenimage2.IsVisible = true; }
                comparegrid.Children.Add(MaidsRoomgrid, 0, 14);
                /////
                ////StorageRoom
                var StorageRoomgrid = new Grid
                {
                    ColumnDefinitions ={
                    new ColumnDefinition { Width = new GridLength(1, GridUnitType.Star) },
                    new ColumnDefinition { Width = new GridLength(1, GridUnitType.Star) },
                    new ColumnDefinition { Width = new GridLength(1, GridUnitType.Star) },
                },
                    BackgroundColor = Color.LightGray,
                };
                var StorageRoomlable = new Label { FontSize = 11, TextColor = Color.FromHex("#FF071D66"), VerticalOptions = LayoutOptions.Center, HorizontalOptions = LayoutOptions.Center }; ;
                if (Application.Current.Properties["Language"].ToString() == "Arabic") { StorageRoomlable.Text = "مخزن"; } else { StorageRoomlable.Text = "StorageRoom"; }
                StorageRoomgrid.Children.Add(StorageRoomlable, 0, 0);
                var StorageRoomgreenimage1 = new Image { Source = "circlegreen.png", Scale = 0.3, Aspect = Aspect.AspectFit, HorizontalOptions = LayoutOptions.Center, VerticalOptions = LayoutOptions.Center, IsVisible = false };
                var StorageRoomgrayimage1 = new Image { Source = "circlegrey.png", Scale = 0.3, Aspect = Aspect.AspectFit, HorizontalOptions = LayoutOptions.Center, VerticalOptions = LayoutOptions.Center, IsVisible = true };
                var StorageRoomgreenimage2 = new Image { Source = "circlegreen.png", Scale = 0.3, Aspect = Aspect.AspectFit, HorizontalOptions = LayoutOptions.Center, VerticalOptions = LayoutOptions.Center, IsVisible = false };
                var StorageRoomgrayimage2 = new Image { Source = "circlegrey.png", Scale = 0.3, Aspect = Aspect.AspectFit, HorizontalOptions = LayoutOptions.Center, VerticalOptions = LayoutOptions.Center, IsVisible = true };
                StorageRoomgrid.Children.Add(StorageRoomgreenimage1, 1, 0);
                StorageRoomgrid.Children.Add(StorageRoomgrayimage1, 1, 0);
                StorageRoomgrid.Children.Add(StorageRoomgreenimage2, 2, 0);
                StorageRoomgrid.Children.Add(StorageRoomgrayimage2, 2, 0);
                if (property1.StorageRoom == StorageRoom.Yes && property1.StorageRoom != null)
                { StorageRoomgrayimage1.IsVisible = false; StorageRoomgreenimage1.IsVisible = true; }
                if (property2.StorageRoom == StorageRoom.Yes && property2.StorageRoom != null)
                { StorageRoomgrayimage2.IsVisible = false; StorageRoomgreenimage2.IsVisible = true; }
                comparegrid.Children.Add(StorageRoomgrid, 0, 15);
                /////
                ////Garden
                var Gardengrid = new Grid
                {
                    ColumnDefinitions ={
                    new ColumnDefinition { Width = new GridLength(1, GridUnitType.Star) },
                    new ColumnDefinition { Width = new GridLength(1, GridUnitType.Star) },
                    new ColumnDefinition { Width = new GridLength(1, GridUnitType.Star) },
                },
                    BackgroundColor = Color.White,
                };
                var Gardenlable = new Label { FontSize = 11, TextColor = Color.FromHex("#FF071D66"), VerticalOptions = LayoutOptions.Center, HorizontalOptions = LayoutOptions.Center }; ;
                if (Application.Current.Properties["Language"].ToString() == "Arabic") { Gardenlable.Text = "حديقة"; } else { Gardenlable.Text = "Garden"; }
                Gardengrid.Children.Add(Gardenlable, 0, 0);
                var Gardengreenimage1 = new Image { Source = "circlegreen.png", Scale = 0.3, Aspect = Aspect.AspectFit, HorizontalOptions = LayoutOptions.Center, VerticalOptions = LayoutOptions.Center, IsVisible = false };
                var Gardengrayimage1 = new Image { Source = "circlegrey.png", Scale = 0.3, Aspect = Aspect.AspectFit, HorizontalOptions = LayoutOptions.Center, VerticalOptions = LayoutOptions.Center, IsVisible = true };
                var Gardengreenimage2 = new Image { Source = "circlegreen.png", Scale = 0.3, Aspect = Aspect.AspectFit, HorizontalOptions = LayoutOptions.Center, VerticalOptions = LayoutOptions.Center, IsVisible = false };
                var Gardengrayimage2 = new Image { Source = "circlegrey.png", Scale = 0.3, Aspect = Aspect.AspectFit, HorizontalOptions = LayoutOptions.Center, VerticalOptions = LayoutOptions.Center, IsVisible = true };
                Gardengrid.Children.Add(Gardengreenimage1, 1, 0);
                Gardengrid.Children.Add(Gardengrayimage1, 1, 0);
                Gardengrid.Children.Add(Gardengreenimage2, 2, 0);
                Gardengrid.Children.Add(Gardengrayimage2, 2, 0);
                if (property1.Gym == Gym.Yes && property1.Gym != null)
                { Gardengrayimage1.IsVisible = false; Gardengreenimage1.IsVisible = true; }
                if (property2.Gym == Gym.Yes && property2.Gym != null)
                { Gardengrayimage2.IsVisible = false; Gardengreenimage2.IsVisible = true; }
                comparegrid.Children.Add(Gardengrid, 0, 16);
                /////
                ////Featured
                var Featuredgrid = new Grid
                {
                    ColumnDefinitions ={
                    new ColumnDefinition { Width = new GridLength(1, GridUnitType.Star) },
                    new ColumnDefinition { Width = new GridLength(1, GridUnitType.Star) },
                    new ColumnDefinition { Width = new GridLength(1, GridUnitType.Star) },
                },
                    BackgroundColor = Color.LightGray,
                };
                var Featuredlable = new Label { FontSize = 11, TextColor = Color.FromHex("#FF071D66"), VerticalOptions = LayoutOptions.Center, HorizontalOptions = LayoutOptions.Center }; ;
                if (Application.Current.Properties["Language"].ToString() == "Arabic") { Featuredlable.Text = "مميز"; } else { Featuredlable.Text = "Featured"; }
                Featuredgrid.Children.Add(Featuredlable, 0, 0);
                var Featuredgreenimage1 = new Image { Source = "circlegreen.png", Scale = 0.3, Aspect = Aspect.AspectFit, HorizontalOptions = LayoutOptions.Center, VerticalOptions = LayoutOptions.Center, IsVisible = false };
                var Featuredgrayimage1 = new Image { Source = "circlegrey.png", Scale = 0.3, Aspect = Aspect.AspectFit, HorizontalOptions = LayoutOptions.Center, VerticalOptions = LayoutOptions.Center, IsVisible = true };
                var Featuredgreenimage2 = new Image { Source = "circlegreen.png", Scale = 0.3, Aspect = Aspect.AspectFit, HorizontalOptions = LayoutOptions.Center, VerticalOptions = LayoutOptions.Center, IsVisible = false };
                var Featuredgrayimage2 = new Image { Source = "circlegrey.png", Scale = 0.3, Aspect = Aspect.AspectFit, HorizontalOptions = LayoutOptions.Center, VerticalOptions = LayoutOptions.Center, IsVisible = true };
                Featuredgrid.Children.Add(Featuredgreenimage1, 1, 0);
                Featuredgrid.Children.Add(Featuredgrayimage1, 1, 0);
                Featuredgrid.Children.Add(Featuredgreenimage2, 2, 0);
                Featuredgrid.Children.Add(Featuredgrayimage2, 2, 0);
                if (property1.Featured == Featured.Yes && property1.Featured != null)
                { Featuredgrayimage1.IsVisible = false; Featuredgreenimage1.IsVisible = true; }
                if (property2.Featured == Featured.Yes && property2.Featured != null)
                { Featuredgrayimage2.IsVisible = false; Featuredgreenimage2.IsVisible = true; }
                comparegrid.Children.Add(Featuredgrid, 0, 17);
                /////
                ////Availability
                var Availabilitygrid = new Grid
                {
                    ColumnDefinitions ={
                    new ColumnDefinition { Width = new GridLength(1, GridUnitType.Star) },
                    new ColumnDefinition { Width = new GridLength(1, GridUnitType.Star) },
                    new ColumnDefinition { Width = new GridLength(1, GridUnitType.Star) },
                },
                    BackgroundColor = Color.White,
                };
                var Availabilitylable = new Label { FontSize = 11, TextColor = Color.FromHex("#FF071D66"), VerticalOptions = LayoutOptions.Center, HorizontalOptions = LayoutOptions.Center }; ;
                if (Application.Current.Properties["Language"].ToString() == "Arabic") { Availabilitylable.Text = "متاح"; } else { Availabilitylable.Text = "Available"; }
                Availabilitygrid.Children.Add(Availabilitylable, 0, 0);
                var Availabilitygreenimage1 = new Image { Source = "circlegreen.png", Scale = 0.3, Aspect = Aspect.AspectFit, HorizontalOptions = LayoutOptions.Center, VerticalOptions = LayoutOptions.Center, IsVisible = false };
                var Availabilitygrayimage1 = new Image { Source = "circlegrey.png", Scale = 0.3, Aspect = Aspect.AspectFit, HorizontalOptions = LayoutOptions.Center, VerticalOptions = LayoutOptions.Center, IsVisible = true };
                var Availabilitygreenimage2 = new Image { Source = "circlegreen.png", Scale = 0.3, Aspect = Aspect.AspectFit, HorizontalOptions = LayoutOptions.Center, VerticalOptions = LayoutOptions.Center, IsVisible = false };
                var Availabilitygrayimage2 = new Image { Source = "circlegrey.png", Scale = 0.3, Aspect = Aspect.AspectFit, HorizontalOptions = LayoutOptions.Center, VerticalOptions = LayoutOptions.Center, IsVisible = true };
                Availabilitygrid.Children.Add(Availabilitygreenimage1, 1, 0);
                Availabilitygrid.Children.Add(Availabilitygrayimage1, 1, 0);
                Availabilitygrid.Children.Add(Availabilitygreenimage2, 2, 0);
                Availabilitygrid.Children.Add(Availabilitygrayimage2, 2, 0);
                if (property1.Availability == Availability.Yes && property1.Availability != null)
                { Availabilitygrayimage1.IsVisible = false; Availabilitygreenimage1.IsVisible = true; }
                if (property2.Availability == Availability.Yes && property2.Availability != null)
                { Availabilitygrayimage2.IsVisible = false; Availabilitygreenimage2.IsVisible = true; }
                comparegrid.Children.Add(Availabilitygrid, 0, 18);
                /////
                Maingrid.Children.Add(titlegrid, 0, 0);
                Maingrid.Children.Add(scrollview, 0, 1);
                scrollview.Content = comparegrid;
                mainlayout.Children.Add(Maingrid);
                if (Application.Current.Properties["Language"].ToString() == "Arabic")
                {
                    DisplayAlert("تنبيه", "يمكنك مقارنة عقارين فقط لمقارنة اكثر من عقارين يرجى الذهاب الى الموقع ", "موافق");
                }
                else
                {
                    DisplayAlert("Alert", "To Compare More Than Two Properties Please Visit The Website", "OK");
                }
            }
        }

        protected override void OnAppearing()
        {
            base.OnAppearing();
            MessagingCenter.Send(this, "preventLandScape");
        }
    }
}