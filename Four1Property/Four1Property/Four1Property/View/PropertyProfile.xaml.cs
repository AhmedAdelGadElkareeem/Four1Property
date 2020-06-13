using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using Xamarin.Forms.Maps;
using Four1Property.Models;
using Plugin.Messaging;
using Xamarin.Essentials;
using Plugin.Share;
using System.Linq;
using Rg.Plugins.Popup.Services;
using View;
using Acr.UserDialogs;
using Four1Property.Helper;
using System.Threading.Tasks;
using System.Net;
using System.IO;
using System.Collections.ObjectModel;
using Newtonsoft.Json;
using CustomRenderer;

namespace Four1Property.View
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class PropertyProfile : ContentPage
    {
        public double lon;
        public double lat;
        public string email;
        public string PhoneNumber;
        public string AddressString;
        public string Country;
        public string propertyid;
        public PropertyProfile(PropertyModel property)
        {
            propertyid = property.SID.Replace("ID:","");
            propertyid = propertyid.Replace(" ","");
            InitializeComponent();
            if (Application.Current.Properties["Language"].ToString() == "Arabic")
            {
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
                
                Share.Text = "مشاركة";
                this.Title = "عقار";
                this.FlowDirection = FlowDirection.RightToLeft;
                PropertyLocation.Text = "الموقع ";
                StreetView.Text = "اظهار الشارع";
                GetDirection.Text = "الذهاب الى الوجهة";
                AirConText.Text = "تكيف";
                BalconyText.Text = "بلكون";
                BuiltinKitchenText.Text = "مطبخ ";
                DryCleantext.Text = "غرفة غسيل";
                MaidsRoomText.Text = "غرفة خدم";
                FurnishedText.Text = "مفروش";
                GymText.Text = "نادي رياضة";
                ElevatorText.Text = "مصعد";
                PoolText.Text = "مسبح";
                PropertyTypeText.Text = "نوع العقار";
                PriceText.Text = "السعر";
                GardenText.Text = "حديقة";
                FloorText.Text = "الطابق";
                RoomsText.Text = "غرف المعيشة";
                BedRoomsText.Text = "غرف النوم";
                BathroomsText.Text = "الحممامات";
                StorageRoomText.Text = "مخزن";
                CarSpacesText.Text = "كراج";
                LandareaText.Text = "مساحة الارض";
                BuildAreaText.Text = "مساحة البناء";
                BuildDateText.Text = "تاريخ البناء";
                property.RightArrow = "leftarrow.png";
                property.LeftArrow = "rightarrow.png";
                PropertyDetails.Source = "PropertyDetailsArabic.png";
                PropertyInformation.Source = "PropertyInformationArabic.png";
                if (property.SellerAR != null || property.SellerAR != " ")
                {
                    AgentName.Text = property.SellerAR;
                }
                else { AgentName.Text = "غير متوفر"; }
                property.AddressLAng = property.Address.CityAR;

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
                    
                this.Title = "Property";
                this.FlowDirection = FlowDirection.LeftToRight;
                PropertyLocation.Text = "Location";
                StreetView.Text = "Street View";
                GetDirection.Text = "Get Dirictions";
                AirConText.Text = "Air Condition";
                BalconyText.Text = "Balcony";
                BuiltinKitchenText.Text = "Kitchen";
                DryCleantext.Text = "Dry Clean Room";
                MaidsRoomText.Text = "Maids Room";
                FurnishedText.Text = "Fully Furnished";
                GymText.Text = "Gym";
                StorageRoomText.Text = "Storage room";
                PoolText.Text = "Pool";
                PropertyTypeText.Text = "Property Type";
                PriceText.Text = "Price";
                LandareaText.Text = "Land Area";
                FloorText.Text = "Floor";
                RoomsText.Text = "living Rooms";
                BedRoomsText.Text = "Bed Rooms";
                BathroomsText.Text = "Bath Rooms";
                BuildAreaText.Text = "Build Area";
                BuildDateText.Text = "Build Date";
                CarSpacesText.Text = "Car Spaces";
                ElevatorText.Text = "Elevator";
                GardenText.Text = "Garden";
                property.RightArrow = "rightarrow.png";
                PropertyDetails.Source = "PropertyDetails.png";
                PropertyInformation.Source = "PropertyInformation.png";
                property.LeftArrow = "leftarrow.png";
                if (property.Seller != null || property.Seller != " ")
                {
                    AgentName.Text = property.Seller;
                }
                else { AgentName.Text = "Not Available"; }
                property.AddressLAng = property.Address.City;

            }
            
            if (Application.Current.Properties["Language"].ToString() == "Arabic")
            {
                property.Title = property.OfType.ToString();
                if (property.Title == "Commercial") { property.Title = "ID: " + property.SID; }
                else if (property.Title == "Residential") { property.Title = "ID: " + property.SID; }
                else if (property.Title == "Industrial") { property.Title = "ID: " + property.SID; }
                else { property.Title =  property.SID; }
            }
            else
            {
                property.Title = property.SID;
                
                property.TypeLang = property.OfType.Title;
            }
            if (property.For == For.Rent)
            {
                if (Application.Current.Properties["Language"].ToString() == "Arabic")
                {
                    property.StatusLang = "للايجار";
                }
                else
                {
                    property.StatusLang = "Rent";
                }
                property.Color = "#F08C00";
            }
            else
            {
                if (Application.Current.Properties["Language"].ToString() == "Arabic")
                {
                    property.StatusLang = "للبيع";
                }
                else
                {
                    property.StatusLang = "Sale";
                }
                property.Color = "#66A80F";
            }
            Country = property.Address.Country;
            ProfileView.BindingContext = property;
            lon = property.Address.Longitude;
            lat = property.Address.Latitude;
            PhoneNumber = property.Phone;
            if (property.AllPhotos.Count == 0) { property.AllPhotos.Add(property.PhotosQ); }
            

            if (property.AllPhotos.Count == 1) { property.ArrowPhoto = false; } else { property.ArrowPhoto = true; }
            email = property.AgentID;
            MyMap.MoveToRegion(MapSpan.FromCenterAndRadius(new Position(lat, lon), Distance.FromKilometers(0.2)));
            if (Application.Current.Properties["Language"].ToString() == "Arabic")
            {
                AddressString = property.Address.AreaNameAR + property.Address.CountryAR;
            }
            else
            {
                AddressString = property.Address.AreaName + property.Address.Country;
            }
            property.Address.Name = AddressString;
            if (property.For == For.Sale)
            {
                Constantce.homeModelC.SaleOrRent = 0;
            }
            else if (property.For == For.Rent)
                {
                    Constantce.homeModelC.SaleOrRent = 1;
                }
            
            CustomPin Pin = new CustomPin()
            {
                Type = PinType.Place,
                Position = new Position(property.Address.Latitude, property.Address.Longitude),
                Label = property.Title,
                Address = AddressString
            };
            if (property.AirConditioning == AirConditioning.Yes)
            {
                AirCon.Source = "circlegreen.png";
            }
            else
            {
                AirCon.Source = "circlegrey.png";

            }
            if (property.Balcony == Models.Balcony.Yes)
            {
                Balcony.Source = "circlegreen.png";

            }
            else
            {
                Balcony.Source = "circlegrey.png";

            }
            if (property.Kitchens == Models.Kitchen.Yes)
            {
                BinKitchen.Source = "circlegreen.png";

            }
            else
            {
                BinKitchen.Source = "circlegrey.png";
            }
            if (property.DryCleanRoom == DryCleanRoom.Yes)
            {
                DryClean.Source = "circlegreen.png";

            }
            else
            {
                DryClean.Source = "circlegrey.png";

            }
            if (property.Furnished == Furnished.Yes)
            {
                FullyFur.Source = "circlegreen.png";

            }
            else
            {
                FullyFur.Source = "circlegrey.png";

            }
            if (property.Gym == Models.Gym.Yes)
            {
                Gym.Source = "circlegreen.png";
            }
            else
            {
                Gym.Source = "circlegrey.png";

            }
            if (property.Pool == Models.Pool.Yes)
            {
                Pool.Source = "circlegreen.png";

            }
            else
            {
                Pool.Source = "circlegrey.png";

            }
            if (property.StorageRoom == StorageRoom.Yes)
            {
                Elevator.Source = "circlegreen.png";

            }
            else
            {
                Elevator.Source = "circlegrey.png";

            }
            if (property.DryCleanRoom == DryCleanRoom.Yes)
            {
                Garden.Source = "circlegreen.png";

            }
            else
            {
                Garden.Source = "circlegrey.png";

            }
            if (property.MaidsRoom == MaidsRoom.Yes)
            {
                Maids.Source = "circlegreen.png";

            }
            else
            {
                Maids.Source = "circlegrey.png";

            }
            if (property.StorageRoom == StorageRoom.Yes)
            {
                Storage.Source = "circlegreen.png";

            }
            else
            {
                Storage.Source = "circlegrey.png";

            }
            if (property.CarSpaces == Models.CarSpaces.Yes)
            {
                CarSpaces.Source = "circlegreen.png";

            }
            else
            {
                CarSpaces.Source = "circlegrey.png";

            }
            MyMap.Pins.Add(Pin);
        }
        protected override void OnAppearing()
        {
            base.OnAppearing();
            MessagingCenter.Send(this, "preventLandScape");
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

        private async void Details(object sender, EventArgs e)
        {
            if (DetalisArea.IsVisible == true)
            {
                if (Application.Current.Properties["Language"].ToString() == "Arabic")
                {
                    PropertyDetails.Source = "PropertyDetailsArabic.png";

                }
                else
                {
                    PropertyDetails.Source = "PropertyDetails.png";

                }
                DetalisArea.IsVisible = false;
            }
            else
            {

                if (Application.Current.Properties["Language"].ToString() == "Arabic")
                {
                    PropertyDetails.Source = "PropertyDetailsArabicBlue.png";

                }
                else
                {
                    PropertyDetails.Source = "PropertyDetailsBlue.png";

                }
                DetalisArea.IsVisible = true;
                await Task.Delay(100);
                ProfileView.ScrollToAsync(800, 800, false);

            }

        }

        private void Information(object sender, EventArgs e)
        {
            if (InfoArea.IsVisible == true)
            {
                if (Application.Current.Properties["Language"].ToString() == "Arabic")
                {
                    PropertyInformation.Source = "PropertyInformationArabic.png";

                }
                else
                {
                    PropertyInformation.Source = "PropertyInformation.png";

                }
                InfoArea.IsVisible = false;

            }
            else
            {
                if (Application.Current.Properties["Language"].ToString() == "Arabic")
                {
                    PropertyInformation.Source = "PropertyInformationArabicBlue.png";

                }
                else
                {
                    PropertyInformation.Source = "PropertyInformationBlue.png";

                }
                InfoArea.IsVisible = true;

            }



            ////string number = "0799710919";
            ////PhoneDialer.Open(number);
        }

        private async void StreetView_Clicked(object sender, EventArgs e)
        {
#if __ANDROID__
            var streetViewUri = Android.Net.Uri.Parse("google.streetview:cbll=" + lon + "," + lat + "&cbp=1,90,,0,1.0&mz=20");
            var streetViewIntent = new Android.Content.Intent(Android.Content.Intent.ActionView, streetViewUri);
            Forms.Context.StartActivity(streetViewIntent);
#endif

#if __IOS__
            await Launcher.OpenAsync($"comgooglemaps://?q={lat},{lon}()");
#endif

        }
        private async void GetDirection_Clicked(object sender, EventArgs e)
        {
#if __ANDROID__

            var GetDirectionUri = Android.Net.Uri.Parse("google.navigation:q=" + lat + "," + lon);
            var GetDirectionIntent = new Android.Content.Intent(Android.Content.Intent.ActionView, GetDirectionUri);
            Forms.Context.StartActivity(GetDirectionIntent);
#endif
#if __IOS__
            await Launcher.OpenAsync($"comgooglemaps://?q={lat},{lon}()");
#endif
        }
        private void Email_Tapped(object sender, EventArgs e)
        {

            Device.OpenUri(new Uri("mailto:" + email));
        }
        private async void Whatsapp_Tapped(object sender, EventArgs e)
        {
            if (Country == "Jordan"|| Country =="Iraq") { 

                if (PhoneNumber != "" || PhoneNumber != " " || PhoneNumber != null)
            {
                if (Country == "Jordan")
                {
                    if (!PhoneNumber.StartsWith("00962") || !PhoneNumber.StartsWith("+962"))
                    {
                        if (PhoneNumber.StartsWith("+964"))
                        {
                            PhoneNumber = PhoneNumber.Remove(0, 1);
                            PhoneNumber = "+962" + PhoneNumber.Substring(1);
                        }
                    }
                }
                else if (Country == "Iraq")
                {
                    if (!PhoneNumber.StartsWith("00964") || !PhoneNumber.StartsWith("+964"))
                    {
                        PhoneNumber = PhoneNumber.Remove(0, 1);
                        PhoneNumber = "+964" + PhoneNumber.Substring(1);
                    }
                }
                try
                {
                    Device.OpenUri(new Uri("whatsapp://send?phone=" + PhoneNumber));
                }
                catch (Exception ex)
                {
                    await DisplayAlert("Not Installed", "Whatsapp Not Installed", "ok");
                    await DisplayAlert("", ex.Message, "ok");
                }
                }
            }
            else
            {
                if (Application.Current.Properties["Language"].ToString() == "Arabic")
                {
                    await DisplayAlert("غير معرف", "الرقم غير معرف لدى واتساب", "ok");
                }
                else
                {
                    await DisplayAlert("Not Supported", "Number is not Supported on Whatsapp", "ok");
                }
            }
        }
        private void Phone_Tapped(object sender, EventArgs e)
        {
            //Device.OpenUri(new Uri("tel:" + PhoneNumber));
            //Launcher.CanOpenAsync(new Uri("tel:" + PhoneNumber));
            try
            {
                PhoneDialer.Open(PhoneNumber);
            }
            catch (ArgumentNullException anEx)
            {
                // Number was null or white space
            }
            catch (FeatureNotSupportedException ex)
            {
                // Phone Dialer is not supported on this device.
            }
            catch (Exception ex)
            {
                // Other error has occurred.
            }
        }

        private void ToolbarItem_Activated(object sender, EventArgs e)
        {
            string link = "https://property1111.com/FrontEnd/index?searchID=" + propertyid;

            /*
                CrossShare.Current.Share(new Plugin.Share.Abstractions.ShareMessage()
                {
                    Url = link, Text= "", Title="",
                });
             */

            Xamarin.Essentials.Share.RequestAsync(new ShareTextRequest()
            {
                Uri = link,
                Text = "",
                Title = "",
            });
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

        private void TapGestureRecognizer_Tapped(object sender, EventArgs e)
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