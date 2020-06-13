using Four1Property.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Http;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using Newtonsoft.Json;
using System.Net;
using System.IO;
using Plugin.Connectivity;
using Acr.UserDialogs;
using System.Collections.ObjectModel;
using Four1Property.Helper;
using Rg.Plugins.Popup.Services;
using View;
using Plugin.Geolocator;

namespace Four1Property.View
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Home : ContentPage
    {
        bool TypeSelected = false;
        bool CategorySelected = false;
        string Countrys;
        string Citys;
        string Areas;
        double Longt = 0;
        double Latt = 0;
        HomeModel homeModel = new HomeModel();
        public Home()
        {
            InitializeComponent();
            NavigationPage.BarBackgroundColorProperty.Equals(Color.Transparent);
            Longt = Constantce.lon;
            Latt = Constantce.Lat;
            this.FlowDirection = FlowDirection.RightToLeft;
            if (Application.Current.Properties["Language"].ToString() == "Arabic")
            {
                this.FlowDirection = FlowDirection.RightToLeft;
                CurrentLocation.Text = "موقعك الحالي";
                if (Constantce.Country != "Country")
                {
                    CountryPicker.Text = Constantce.CountryLang;
                    CountryPicker.TextColor = Color.White;
                    CountryPicker.BackgroundColor = Color.FromHex("#FF071D66");
                    CityPicker.IsEnabled = true;
                }
                else
                {
                    CountryPicker.Text = "الدولة";
                    CountryPicker.BackgroundColor = Color.White;
                    CountryPicker.TextColor = Color.FromHex("#FF071D66");
                    CityPicker.IsEnabled = false;
                    AreaPicker.IsEnabled = false;

                }
                if (Constantce.City != "City")
                {
                    CityPicker.Text = Constantce.CityLang;
                    CityPicker.TextColor = Color.White;
                    CityPicker.BackgroundColor = Color.FromHex("#FF071D66");
                    AreaPicker.IsEnabled = true;
                }
                else
                {
                    CityPicker.Text = "المدينة";
                    CityPicker.BackgroundColor = Color.White;
                    CityPicker.TextColor = Color.FromHex("#FF071D66");
                }
                if (Constantce.Area != "Area")
                {
                    AreaPicker.Text = Constantce.AreaLang;
                    AreaPicker.TextColor = Color.White;
                    AreaPicker.BackgroundColor = Color.FromHex("#FF071D66");
                }
                else
                {
                    AreaPicker.Text = "المنطقة";
                    AreaPicker.BackgroundColor = Color.White;
                    AreaPicker.TextColor = Color.FromHex("#FF071D66");
                }
                OROne.Text = "أو اختر من خلال";
                ORTwo.Text = "أو حدد عن طريق";
                Citys = "المدينة";
                Countrys = "الدولة";
                Areas = "المنطقة";
                MapView.Text = " الخريطة";
                CommercialMain.Text = "تجاري";
                IndustrialMain.Text = "صناعي";
                ResidentialMain.Text = "سكني";
                LandMain.Text = "ارض";
                HouseButton.Text = "منزل";
                FlatButton.Text = "طابق";
                BuildingButton.Text = "بناء";
                ApartmentButton.Text = "شقة";
                UnFernishedButton.Text = "غير مفروش";
                FurnishedButton.Text = "مفروش";
                ShowRoomButton.Text = "معرض";
                ShopsButton.Text = "محل";
                BuildingComButton.Text = "بناء";
                OfficeButton.Text = "مكتب";
                CommercialButton.Text = "تجاري";
                ResidentialButton.Text = "سكني";
                IndustrialButton.Text = "صناعي";
                AgrecultureComButton.Text = "زراعي";
                HangerButton.Text = "هنجر";
                BuildingIndButton.Text = "بناء";
                ApplyFilter.Text = "بحث";
                Bed.Text = "غرف نوم";
                Bath.Text = "حمامات";
                AreaLand.Text = "المساحة";

                Sale.Source = "Choose1Arabic.png";
                Rent.Source = "Choose2Arabic.png";
                SaleBlue.Source = "Choose11Arabic.png";
                RentBlue.Source = "Choose22Arabic.png";
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
                    ToolbarItem Profile = new ToolbarItem { Order = ToolbarItemOrder.Secondary, Text = "Profile"};
                    ToolbarItem whsilist = new ToolbarItem { Order = ToolbarItemOrder.Secondary, Text = "Wishlist"};
                    ToolbarItem Compare = new ToolbarItem { Order = ToolbarItemOrder.Secondary, Text = "Compare" };
                    ToolbarItem About = new ToolbarItem { Order = ToolbarItemOrder.Secondary, Text = "About" };
                    ToolbarItem Agents = new ToolbarItem { Order = ToolbarItemOrder.Secondary, Text = "Agents"};
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
                
                this.FlowDirection = FlowDirection.LeftToRight;
                CurrentLocation.Text = "Your Current Location";
                if (Constantce.Country != "Country")
                {
                    CountryPicker.Text = Constantce.CountryLang;
                    CountryPicker.TextColor = Color.White;
                    CountryPicker.BackgroundColor = Color.FromHex("#FF071D66");
                    CityPicker.IsEnabled = true;
                }
                else
                {
                    CountryPicker.Text = "Country";
                    CountryPicker.BackgroundColor = Color.White;
                    CountryPicker.TextColor = Color.FromHex("#FF071D66");
                    CityPicker.IsEnabled = false;
                    AreaPicker.IsEnabled = false;

                }
                if (Constantce.City != "City")
                {
                    CityPicker.Text = Constantce.CityLang;
                    CityPicker.TextColor = Color.White;
                    CityPicker.BackgroundColor = Color.FromHex("#FF071D66");
                    AreaPicker.IsEnabled = true;
                }
                else
                {
                    CityPicker.Text = "City";
                    CityPicker.BackgroundColor = Color.White;
                    CityPicker.TextColor = Color.FromHex("#FF071D66");
                }
                if (Constantce.Area != "Area")
                {
                    AreaPicker.Text = Constantce.AreaLang;
                    AreaPicker.TextColor = Color.White;
                    AreaPicker.BackgroundColor = Color.FromHex("#FF071D66");
                }
                else
                {
                    AreaPicker.Text = "Area";
                    AreaPicker.BackgroundColor = Color.White;
                    AreaPicker.TextColor = Color.FromHex("#FF071D66");
                }
                OROne.Text = "Or Choose From";
                ORTwo.Text = "Or Locate From";
                MapView.Text = "Map";
                CommercialMain.Text = "        Commercial";
                IndustrialMain.Text = "        Idustrial";
                ResidentialMain.Text = "         Residential";
                LandMain.Text = "Land";
                HouseButton.Text = "House";
                FlatButton.Text = "Flat";
                BuildingButton.Text = "     Building";
                ApartmentButton.Text = "     Apartment";
                UnFernishedButton.Text = "         UnFurnished";
                FurnishedButton.Text = "      Furnished";
                ShowRoomButton.Text = "      Show Room";
                ShopsButton.Text = "Shop";
                BuildingComButton.Text = "Building";
                OfficeButton.Text = "Office";
                CommercialButton.Text = "         Commercial";
                ResidentialButton.Text = "         Residential";
                IndustrialButton.Text = "         Industrial";
                AgrecultureComButton.Text = "         Agreculture";
                HangerButton.Text = "Hangar";
                BuildingIndButton.Text = "Building";
                ApplyFilter.Text = "Apply Filter";
                Bath.Text = "Bath Rooms";
                Bed.Text = "Bed Rooms";
                AreaLand.Text = "Area";
                Citys = "City";
                Countrys = "Country";
                Areas = "Area";

            }
            if (Constantce.Country != "Country" && Constantce.City != "City" && Constantce.Area != "Area")
            {
                maincategory.IsVisible = false;
                MainButtons.IsVisible = true;
                //MenuEn.IsVisible = false;
                if (Application.Current.Properties["Language"].ToString() == "Arabic")
                { ArrowArabic.IsVisible = true; }
                else
                {
                    ArrowEnglish.IsVisible = true;
                }
            }
            else
            {
                maincategory.IsVisible = true;
                MainButtons.IsVisible = false;
                ArrowEnglish.IsVisible = false;
                ArrowArabic.IsVisible = false;
                //MenuEn.IsVisible = true;

            }

            if (Longt != 0 && Latt != 0)
            {
                maincategory.IsVisible = false;
                MainButtons.IsVisible = true;
                //MenuEn.IsVisible = false;

                if (Application.Current.Properties["Language"].ToString() == "Arabic")
                { ArrowArabic.IsVisible = true; }
                else
                {
                    ArrowEnglish.IsVisible = true;
                }
            }
            if (Constantce.saleorrent == "Rent")
            {
                RentBlue.IsVisible = true;
                Rent.IsVisible = false;
                int SaleType = (int)TypeSaleOrRent.rent;
                homeModel.SaleOrRent = SaleType;
                TypeSelected = true;
            }
            if (Constantce.saleorrent == "Sale")
            {
                SaleBlue.IsVisible = true;
                Sale.IsVisible = false;
                int SaleType = (int)TypeSaleOrRent.sale;
                homeModel.SaleOrRent = SaleType;
                TypeSelected = true;
            }

        }

        protected override void OnAppearing()
        {
            base.OnAppearing();
            MessagingCenter.Send(this, "preventLandScape");
            HomeButton.IsVisible = false;
            HomeButtonBlue.IsVisible = true;

            SearchButton.IsVisible = true;
            SearchButtonBlue.IsVisible = false;

            FavoriteButton.IsVisible = true;
            FavoriteButtonBlue.IsVisible = false;

            ProfileButton.IsVisible = true;
            ProfileButtonBlue.IsVisible = false;
        }
        //Rent OR Sale Start
        async void OnSaleClicked(object sender, EventArgs e)
        {
            try
            {
                Sale.IsVisible = false;
                SaleBlue.IsVisible = true;
                Rent.IsVisible = true;
                RentBlue.IsVisible = false;
                int SaleType = (int)TypeSaleOrRent.sale;
                Constantce.saleorrent = "Sale";
                homeModel.SaleOrRent = SaleType;
                TypeSelected = true;



                ResidentialSlider.MaximumValue = 1000000;
                CommercialSlider.MaximumValue = 1000000;
                LandSlider.MaximumValue = 1000000;
                IndustrialSlider.MaximumValue = 1000000;

                ResidentialSlider.MinimumValue = 0;
                CommercialSlider.MinimumValue = 0;
                LandSlider.MinimumValue = 0;
                IndustrialSlider.MinimumValue = 0;

                ResidentialSlider.LowerValue = 0;
                CommercialSlider.LowerValue = 0;
                LandSlider.LowerValue = 0;
                IndustrialSlider.LowerValue = 0;

                ResidentialSlider.StepValue = 100000;
                CommercialSlider.StepValue = 100000;
                LandSlider.StepValue = 100000;
                IndustrialSlider.StepValue = 100000;

            }

            catch
            {
                await DisplayAlert("Error", "Rent button has been Clicked.", "Ok");
                return;
            }
        }

        async void OnRentClicked(object sender, EventArgs e)
        {
            try
            {
                Sale.IsVisible = true;
                SaleBlue.IsVisible = false;
                Rent.IsVisible = false;
                RentBlue.IsVisible = true;
                int RentType = (int)TypeSaleOrRent.rent;
                Constantce.saleorrent = "Rent";
                homeModel.SaleOrRent = RentType;
                TypeSelected = true;


                ResidentialSlider.MaximumValue = 100000;
                CommercialSlider.MaximumValue = 100000;
                LandSlider.MaximumValue = 100000;
                IndustrialSlider.MaximumValue = 100000;

                ResidentialSlider.MinimumValue = 0;
                CommercialSlider.MinimumValue = 0;
                LandSlider.MinimumValue = 0;
                IndustrialSlider.MinimumValue = 0;

                ResidentialSlider.LowerValue = 0;
                CommercialSlider.LowerValue = 0;
                LandSlider.LowerValue = 0;
                IndustrialSlider.LowerValue = 0;

                ResidentialSlider.StepValue = 500;
                CommercialSlider.StepValue = 500;
                LandSlider.StepValue = 500;
                IndustrialSlider.StepValue = 500;


            }

            catch
            {
                await DisplayAlert("Error", "Check App permissions. ", "Ok");
                return;
            }
        }
        //Rent OR Sale End

        // Start Main Cat
        private async void CurrentLocation_Clicked(object sender, EventArgs e)
        {
            if (CurrentLocation.BackgroundColor == Color.White)
            {
                var location = CrossGeolocator.Current;
                if (location.IsGeolocationEnabled)

                {
                    CountryPicker.IsEnabled = false;
                    AreaPicker.IsEnabled = false;
                    CityPicker.IsEnabled = false;
                    Constantce.Country = "Country";
                    Constantce.City = "City";
                    Constantce.Area = "Area";
                    CountryPicker.Text = Countrys;
                    CityPicker.Text = Citys;
                    AreaPicker.Text = Areas;
                    if (Application.Current.Properties["Language"].ToString() == "Arabic")
                    { CountryPicker.Text = "الدولة"; }
                    else { CountryPicker.Text = Constantce.Country; }
                    CountryPicker.BackgroundColor = Color.White;
                    CountryPicker.TextColor = Color.FromHex("#FF071D66");
                    if (Application.Current.Properties["Language"].ToString() == "Arabic")
                    { CityPicker.Text = "المدينة"; }
                    else { CityPicker.Text = Constantce.City; }
                    CityPicker.BackgroundColor = Color.White;
                    CityPicker.TextColor = Color.FromHex("#FF071D66");
                    if (Application.Current.Properties["Language"].ToString() == "Arabic")
                    { AreaPicker.Text = "المنطقة"; }
                    else
                    { AreaPicker.Text = Constantce.Area; }
                    AreaPicker.BackgroundColor = Color.White;
                    AreaPicker.TextColor = Color.FromHex("#FF071D66");
                    maincategory.IsVisible = false;
                    MainButtons.IsVisible = true;
                    if (Application.Current.Properties["Language"].ToString() == "Arabic")
                    { ArrowArabic.IsVisible = true; }
                    else
                    {
                        ArrowEnglish.IsVisible = true;
                    }
                    CurrentLocation.BackgroundColor = Color.FromHex("#FF071D66");
                    CurrentLocation.BorderColor = Color.FromHex("#FF071D66");
                    CurrentLocation.TextColor = Color.White;

                    location.DesiredAccuracy = 50;
                    var position = await location.GetPositionAsync();
                    Longt = position.Longitude;
                    Latt = position.Latitude;

                }
                else
                {
                    if (Application.Current.Properties["Language"].ToString() == "Arabic")
                    {
                        await DisplayAlert("تنبيه", "يرجى تشغل تحديد الموقع", "موافق");
                    }
                    else
                    {
                        await DisplayAlert("Alert", "PLease Enable Location ", "OK");
                    }

                }


            }
            else
            {
                CurrentLocation.TextColor = Color.FromHex("#FF071D66");
                CurrentLocation.BackgroundColor = Color.White;
                CurrentLocation.BorderColor = Color.FromHex("#FF071D66");
                CountryPicker.IsEnabled = true;
                AreaPicker.IsEnabled = false;
                CityPicker.IsEnabled = false;
                CountryPicker.Text = Countrys;
                CityPicker.Text = Citys;
                AreaPicker.Text = Areas;
                MainButtons.IsVisible = false;
                maincategory.IsVisible = true;
            }

        }
        async void CountryPicker_Clicked(object sender, EventArgs e)
        {
            CountryPicker.IsEnabled = false;
            await PopupNavigation.Instance.PushAsync(new Country());
            CountryPicker.IsEnabled = true;


        }
        async void AreaPicker_Clicked(object sender, EventArgs e)
        {
            AreaPicker.IsEnabled = false;
            if (Constantce.Country == "Jordan")
            {
                if (Constantce.City == "Amman")
                {
                    await PopupNavigation.Instance.PushAsync(new Amman());
                }
                else if (Constantce.City == "Ajlun")
                {
                    await PopupNavigation.Instance.PushAsync(new Ajlun());
                }
                else if (Constantce.City == "AlAqabah")
                {
                    await PopupNavigation.Instance.PushAsync(new Aqaba());
                }
                else if (Constantce.City == "AlBalqa")
                {
                    await PopupNavigation.Instance.PushAsync(new Balqa());
                }
                else if (Constantce.City == "AlKarak")
                {
                    await PopupNavigation.Instance.PushAsync(new Karak());
                }
                else if (Constantce.City == "AlMafraq")
                {
                    await PopupNavigation.Instance.PushAsync(new Mafraq());
                }
                else if (Constantce.City == "AlTafilah")
                {
                    await PopupNavigation.Instance.PushAsync(new Tafilih());
                }
                else if (Constantce.City == "AzZarqa")
                {
                    await PopupNavigation.Instance.PushAsync(new Zarqa());
                }
                else if (Constantce.City == "Irbid")
                {
                    await PopupNavigation.Instance.PushAsync(new Irbid());
                }
                else if (Constantce.City == "Jarash")
                {
                    await PopupNavigation.Instance.PushAsync(new Jarash());
                }
                else if (Constantce.City == "Maan")
                {
                    await PopupNavigation.Instance.PushAsync(new Maan());
                }
                else if (Constantce.City == "Madaba")
                {
                    await PopupNavigation.Instance.PushAsync(new Madaba());
                }
            }
            else
            {
                if (Constantce.City == "Baghdad")
                {
                    await PopupNavigation.Instance.PushAsync(new Baghdad());
                }
                else if (Constantce.City == "Ninawa")
                {
                    await PopupNavigation.Instance.PushAsync(new Ninawa());
                }
                else if (Constantce.City == "AlBasrah")
                {
                    await PopupNavigation.Instance.PushAsync(new AlBasrah());
                }
                else if (Constantce.City == "Karbala")
                {
                    await PopupNavigation.Instance.PushAsync(new Karbala());
                }
                else if (Constantce.City == "AlNajaf")
                {
                    await PopupNavigation.Instance.PushAsync(new AlNajaf());
                }
                else if (Constantce.City == "AlMuthanna")
                {
                    await PopupNavigation.Instance.PushAsync(new AlMuthanna());
                }
                else if (Constantce.City == "AlAnbar")
                {
                    await PopupNavigation.Instance.PushAsync(new AlAnbar());
                }
                else if (Constantce.City == "SalahAlDdin")
                {
                    await PopupNavigation.Instance.PushAsync(new SalahAlDdin());
                }
                else if (Constantce.City == "Arbil")
                {
                    await PopupNavigation.Instance.PushAsync(new Arbil());
                }
                else if (Constantce.City == "Dahuk")
                {
                    await PopupNavigation.Instance.PushAsync(new Dahuk());
                }
                else if (Constantce.City == "AlSulaymaniyah")
                {
                    await PopupNavigation.Instance.PushAsync(new AlSulaymaniyah());
                }
                else if (Constantce.City == "Babil")
                {
                    await PopupNavigation.Instance.PushAsync(new Babil());
                }
                else if (Constantce.City == "Maysan")
                {
                    await PopupNavigation.Instance.PushAsync(new Maysan());
                }
                else if (Constantce.City == "Diqar")
                {
                    await PopupNavigation.Instance.PushAsync(new Diqar());
                }
                else if (Constantce.City == "Wasit")
                {
                    await PopupNavigation.Instance.PushAsync(new Wasit());
                }
                else if (Constantce.City == "AlTamin")
                {
                    await PopupNavigation.Instance.PushAsync(new AlTamin());
                }
                else if (Constantce.City == "Diyalla")
                {
                    await PopupNavigation.Instance.PushAsync(new Diyalla());
                }
                else if (Constantce.City == "AlQadsyiah")
                {
                    await PopupNavigation.Instance.PushAsync(new AlQadsyiah());
                }
            }
            AreaPicker.IsEnabled = true;
        }
        async void CityPicker_Clicked(object sender, EventArgs e)
        {
            CityPicker.IsEnabled = false;
            await PopupNavigation.Instance.PushAsync(new City());
            CityPicker.IsEnabled = true;
        }
        private void CommercialMain_Clicked(object sender, EventArgs e)
        {
            if (Application.Current.Properties["Language"].ToString() == "Arabic")
            { ArrowArabic.IsVisible = true; }
            else
            {
                ArrowEnglish.IsVisible = true;
            }
            MainButtons.IsVisible = false;
            commercialcat.IsVisible = true;
            homeModel.Category = "Commercial";

        }
        private void IndustrialMain_Clicked(object sender, EventArgs e)
        {
            MainButtons.IsVisible = false;
            if (Application.Current.Properties["Language"].ToString() == "Arabic")
            { ArrowArabic.IsVisible = true; }
            else { ArrowEnglish.IsVisible = true; }
            industrialcat.IsVisible = true;
            homeModel.Category = "Industrial";

        }
        private void ResidentialMain_Clicked(object sender, EventArgs e)
        {
            MainButtons.IsVisible = false;
            if (Application.Current.Properties["Language"].ToString() == "Arabic")
            { ArrowArabic.IsVisible = true; }
            else { ArrowEnglish.IsVisible = true; }
            resideintialcat.IsVisible = true;
            homeModel.Category = "Residential";

        }
        private void LandMain_Clicked(object sender, EventArgs e)
        {
            MainButtons.IsVisible = false;
            if (Application.Current.Properties["Language"].ToString() == "Arabic")
            { ArrowArabic.IsVisible = true; }
            else { ArrowEnglish.IsVisible = true; }
            landcat.IsVisible = true;
            homeModel.Category = "Land";

        }
        //Main Category
        //Back Arrow Start
        private void backmain_Tapped(object sender, EventArgs e)
        {
            if (Application.Current.Properties["Language"].ToString() == "Arabic")
            { ArrowArabic.IsVisible = false; }
            else
            { ArrowEnglish.IsVisible = false; }
            maincategory.IsVisible = true;
            resideintialcat.IsVisible = false;
            commercialcat.IsVisible = false;
            landcat.IsVisible = false;
            industrialcat.IsVisible = false;
            MainButtons.IsVisible = false;
            //MenuEn.IsVisible = true;
            Latt = 0;
            Longt = 0;
            Constantce.Area = "Area";
            Constantce.City = "City";
            Constantce.Country = "Country";
            Constantce.Lat = 0;
            Constantce.lon = 0;
            Constantce.APIName = "";
            if (Application.Current.Properties["Language"].ToString() == "Arabic")
            {
                AreaPicker.Text = "المنطقة";
                CityPicker.Text = "المدينة";
                CountryPicker.Text = "الدولة";

            }
            else
            {
                AreaPicker.Text = "Area";
                CityPicker.Text = "City";
                CountryPicker.Text = "Country";
            }
            CountryPicker.IsEnabled = true;
            CityPicker.IsEnabled = false;
            AreaPicker.IsEnabled = false;
            AreaPicker.BackgroundColor = Color.White;
            AreaPicker.TextColor = Color.FromHex("#FF071D66");
            CityPicker.BackgroundColor = Color.White;
            CityPicker.TextColor = Color.FromHex("#FF071D66");
            CountryPicker.BackgroundColor = Color.White;
            CountryPicker.TextColor = Color.FromHex("#FF071D66");
            CurrentLocation.BackgroundColor = Color.White;
            CurrentLocation.TextColor = Color.FromHex("#FF071D66");

            HouseButton.BackgroundColor = Color.White;
            HouseButton.TextColor = Color.FromHex("#FF071D66");
            HouseButton.BorderColor = Color.FromHex("#FF071D66");
            FlatButton.BackgroundColor = Color.White;
            FlatButton.TextColor = Color.FromHex("#FF071D66");
            FlatButton.BorderColor = Color.FromHex("#FF071D66");
            ApartmentButton.BackgroundColor = Color.White;
            ApartmentButton.TextColor = Color.FromHex("#FF071D66");
            ApartmentButton.BorderColor = Color.FromHex("#FF071D66");
            BuildingButton.BackgroundColor = Color.White;
            BuildingButton.TextColor = Color.FromHex("#FF071D66");
            BuildingButton.BorderColor = Color.FromHex("#FF071D66");
            ShowRoomButton.BackgroundColor = Color.White;
            ShowRoomButton.TextColor = Color.FromHex("#FF071D66");
            ShowRoomButton.BorderColor = Color.FromHex("#FF071D66");
            OfficeButton.BackgroundColor = Color.White;
            OfficeButton.TextColor = Color.FromHex("#FF071D66");
            OfficeButton.BorderColor = Color.FromHex("#FF071D66");
            ShopsButton.BackgroundColor = Color.White;
            ShopsButton.TextColor = Color.FromHex("#FF071D66");
            ShopsButton.BorderColor = Color.FromHex("#FF071D66");
            BuildingComButton.BackgroundColor = Color.White;
            BuildingComButton.TextColor = Color.FromHex("#FF071D66");
            BuildingComButton.BorderColor = Color.FromHex("#FF071D66");
            AgrecultureComButton.BackgroundColor = Color.White;
            AgrecultureComButton.TextColor = Color.FromHex("#FF071D66");
            AgrecultureComButton.BorderColor = Color.FromHex("#FF071D66");
            IndustrialButton.BackgroundColor = Color.White;
            IndustrialButton.TextColor = Color.FromHex("#FF071D66");
            IndustrialButton.BorderColor = Color.FromHex("#FF071D66");
            ResidentialButton.BackgroundColor = Color.White;
            ResidentialButton.TextColor = Color.FromHex("#FF071D66");
            ResidentialButton.BorderColor = Color.FromHex("#FF071D66");
            CommercialButton.BackgroundColor = Color.White;
            CommercialButton.TextColor = Color.FromHex("#FF071D66");
            CommercialButton.BorderColor = Color.FromHex("#FF071D66");
            HangerButton.BackgroundColor = Color.White;
            HangerButton.TextColor = Color.FromHex("#FF071D66");
            HangerButton.BorderColor = Color.FromHex("#FF071D66");
            BuildingIndButton.BackgroundColor = Color.White;
            BuildingIndButton.TextColor = Color.FromHex("#FF071D66");
            BuildingIndButton.BorderColor = Color.FromHex("#FF071D66");
            FurnishedButton.BackgroundColor = Color.White;
            FurnishedButton.TextColor = Color.FromHex("#FF071D66");
            FurnishedButton.BorderColor = Color.FromHex("#FF071D66");
            UnFernishedButton.BackgroundColor = Color.White;
            UnFernishedButton.TextColor = Color.FromHex("#FF071D66");
            UnFernishedButton.BorderColor = Color.FromHex("#FF071D66");
            HosueImage.Source = "House.png";
            FlatImage.Source = "flat.png";
            ApartmentImage.Source = "apartment.png";
            BuildingImage.Source = "Building.png";
            FienishedImage.Source = "firnished.png";
            UnFirnishedImage.Source = "unfirnished.png";
            ShowRoomImage.Source = "showroom.png";
            ShopsImage.Source = "shop.png";
            OfficeImage.Source = "office.png";
            BuildingComImage.Source = "Building.png";
            CommercialImage.Source = "commercial.png";
            ResidentialImage.Source = "residential.png";
            IndustrialImage.Source = "industrial.png";
            AgreculturImage.Source = "agriculturalLand.png";
            HangarImage.Source = "hangar.png";
            BildingIndImage.Source = "indbuilding.png";
            homeModel.SubCategory = 0;
            CategorySelected = false;
            bath1c.IsVisible = false;
            bath1u.IsVisible = true;
            bath2u.IsVisible = true;
            bath2c.IsVisible = false;
            bath3u.IsVisible = true;
            bath3c.IsVisible = false;
            bath4u.IsVisible = true;
            bath4c.IsVisible = false;
            Constantce.Bath = 0;
            bed1c.IsVisible = false;
            bed1u.IsVisible = true;
            bed2u.IsVisible = true;
            bed2c.IsVisible = false;
            bed3u.IsVisible = true;
            bed3c.IsVisible = false;
            bed4u.IsVisible = true;
            bed4c.IsVisible = false;
            Constantce.Bed = 0;

        }
        //Back Arrow End
        //residential buttons code
        private void HouseButton_Clicked(object sender, EventArgs e)
        {
            if (HouseButton.BackgroundColor == Color.FromHex("#FF071D66"))
            {
                HouseButton.BackgroundColor = Color.White;
                HouseButton.TextColor = Color.FromHex("#FF071D66");
                HouseButton.BorderColor = Color.FromHex("#FF071D66");
                FlatButton.BackgroundColor = Color.White;
                FlatButton.TextColor = Color.FromHex("#FF071D66");
                FlatButton.BorderColor = Color.FromHex("#FF071D66");
                ApartmentButton.BackgroundColor = Color.White;
                ApartmentButton.TextColor = Color.FromHex("#FF071D66");
                ApartmentButton.BorderColor = Color.FromHex("#FF071D66");
                BuildingButton.BackgroundColor = Color.White;
                BuildingButton.TextColor = Color.FromHex("#FF071D66");
                BuildingButton.BorderColor = Color.FromHex("#FF071D66");
                homeModel.SubCategory = 0;
                bed1c.IsVisible = false;
                bed1u.IsVisible = true;
                bed2u.IsVisible = true;
                bed2c.IsVisible = false;
                bed3u.IsVisible = true;
                bed3c.IsVisible = false;
                bed4u.IsVisible = true;
                bed4c.IsVisible = false;
                Constantce.Bed = 0;
                CategorySelected = false;
                HosueImage.Source = "House.png";
                FlatImage.Source = "flat.png";
                ApartmentImage.Source = "apartment.png";
                BuildingImage.Source = "Building.png";
                Constantce.APIName = "";

                bath1c.IsVisible = false;
                bath1u.IsVisible = true;
                bath2u.IsVisible = true;
                bath2c.IsVisible = false;
                bath3u.IsVisible = true;
                bath3c.IsVisible = false;
                bath4u.IsVisible = true;
                bath4c.IsVisible = false;
                Constantce.Bath = 0;



            }
            else
            {
                HouseButton.BackgroundColor = Color.FromHex("#FF071D66");
                HouseButton.TextColor = Color.White;
                HouseButton.BorderColor = Color.FromHex("#FF071D66");
                ApartmentButton.BackgroundColor = Color.White;
                ApartmentButton.TextColor = Color.FromHex("#FF071D66");
                ApartmentButton.BorderColor = Color.FromHex("#FF071D66");
                BuildingButton.BackgroundColor = Color.White;
                BuildingButton.TextColor = Color.FromHex("#FF071D66");
                BuildingButton.BorderColor = Color.FromHex("#FF071D66");
                FlatButton.BackgroundColor = Color.White;
                FlatButton.TextColor = Color.FromHex("#FF071D66");
                FlatButton.BorderColor = Color.FromHex("#FF071D66");
                bed1c.IsVisible = false;
                bed1u.IsVisible = true;
                bed2u.IsVisible = true;
                bed2c.IsVisible = false;
                bed3u.IsVisible = true;
                bed3c.IsVisible = false;
                bed4u.IsVisible = true;
                bed4c.IsVisible = false;
                Constantce.Bed = 0;
                bath1c.IsVisible = false;
                bath1u.IsVisible = true;
                bath2u.IsVisible = true;
                bath2c.IsVisible = false;
                bath3u.IsVisible = true;
                bath3c.IsVisible = false;
                bath4u.IsVisible = true;
                bath4c.IsVisible = false;
                Constantce.Bath = 0;
                homeModel.SubCategory = 4;
                CategorySelected = true;
                HosueImage.Source = "houseW.png";
                FlatImage.Source = "flat.png";
                ApartmentImage.Source = "apartment.png";
                BuildingImage.Source = "Building.png";
                Constantce.APIName = "House";



            }
        }

        private void FlatButton_Clicked(object sender, EventArgs e)
        {
            if (FlatButton.BackgroundColor == Color.FromHex("#FF071D66"))
            {
                bed1c.IsVisible = false;
                bed1u.IsVisible = true;
                bed2u.IsVisible = true;
                bed2c.IsVisible = false;
                bed3u.IsVisible = true;
                bed3c.IsVisible = false;
                bed4u.IsVisible = true;
                bed4c.IsVisible = false;
                Constantce.Bed = 0;
                bath1c.IsVisible = false;
                bath1u.IsVisible = true;
                bath2u.IsVisible = true;
                bath2c.IsVisible = false;
                bath3u.IsVisible = true;
                bath3c.IsVisible = false;
                bath4u.IsVisible = true;
                bath4c.IsVisible = false;
                Constantce.Bath = 0;
                HouseButton.BackgroundColor = Color.White;
                HouseButton.TextColor = Color.FromHex("#FF071D66");
                HouseButton.BorderColor = Color.FromHex("#FF071D66");
                FlatButton.BackgroundColor = Color.White;
                FlatButton.TextColor = Color.FromHex("#FF071D66");
                FlatButton.BorderColor = Color.FromHex("#FF071D66");
                ApartmentButton.BackgroundColor = Color.White;
                ApartmentButton.TextColor = Color.FromHex("#FF071D66");
                ApartmentButton.BorderColor = Color.FromHex("#FF071D66");
                BuildingButton.BackgroundColor = Color.White;
                BuildingButton.TextColor = Color.FromHex("#FF071D66");
                BuildingButton.BorderColor = Color.FromHex("#FF071D66");
                homeModel.SubCategory = 0;
                CategorySelected = false;
                HosueImage.Source = "House.png";
                FlatImage.Source = "flat.png";
                ApartmentImage.Source = "apartment.png";
                BuildingImage.Source = "Building.png";
                Constantce.APIName = "";




            }
            else

            {
                bath1c.IsVisible = false;
                bath1u.IsVisible = true;
                bath2u.IsVisible = true;
                bath2c.IsVisible = false;
                bath3u.IsVisible = true;
                bath3c.IsVisible = false;
                bath4u.IsVisible = true;
                bath4c.IsVisible = false;
                Constantce.Bath = 0;
                bed1c.IsVisible = false;
                bed1u.IsVisible = true;
                bed2u.IsVisible = true;
                bed2c.IsVisible = false;
                bed3u.IsVisible = true;
                bed3c.IsVisible = false;
                bed4u.IsVisible = true;
                bed4c.IsVisible = false;
                Constantce.Bed = 0;
                FlatButton.BackgroundColor = Color.FromHex("#FF071D66");
                FlatButton.TextColor = Color.White;
                FlatButton.BorderColor = Color.FromHex("#FF071D66");
                ApartmentButton.BackgroundColor = Color.White;
                ApartmentButton.TextColor = Color.FromHex("#FF071D66");
                BuildingButton.BackgroundColor = Color.White;
                BuildingButton.TextColor = Color.FromHex("#FF071D66");
                HouseButton.BackgroundColor = Color.White;
                HouseButton.TextColor = Color.FromHex("#FF071D66");
                homeModel.SubCategory = 2;
                CategorySelected = true;
                FlatImage.Source = "flatWhite.png";
                HosueImage.Source = "House.png";
                ApartmentImage.Source = "apartment.png";
                BuildingImage.Source = "Building.png";
                Constantce.APIName = "Flat";




            }
        }

        private void ApartmentButton_Clicked(object sender, EventArgs e)
        {
            if (ApartmentButton.BackgroundColor == Color.FromHex("#FF071D66"))
            {
                bed1c.IsVisible = false;
                bed1u.IsVisible = true;
                bed2u.IsVisible = true;
                bed2c.IsVisible = false;
                bed3u.IsVisible = true;
                bed3c.IsVisible = false;
                bed4u.IsVisible = true;
                bed4c.IsVisible = false;
                Constantce.Bed = 0;
                HouseButton.BackgroundColor = Color.White;
                HouseButton.TextColor = Color.FromHex("#FF071D66");
                HouseButton.BorderColor = Color.FromHex("#FF071D66");
                FlatButton.BackgroundColor = Color.White;
                FlatButton.TextColor = Color.FromHex("#FF071D66");
                FlatButton.BorderColor = Color.FromHex("#FF071D66");
                ApartmentButton.BackgroundColor = Color.White;
                ApartmentButton.TextColor = Color.FromHex("#FF071D66");
                ApartmentButton.BorderColor = Color.FromHex("#FF071D66");
                BuildingButton.BackgroundColor = Color.White;
                BuildingButton.TextColor = Color.FromHex("#FF071D66");
                BuildingButton.BorderColor = Color.FromHex("#FF071D66");
                homeModel.SubCategory = 0;
                CategorySelected = false;
                HosueImage.Source = "House.png";
                FlatImage.Source = "flat.png";
                ApartmentImage.Source = "apartment.png";
                BuildingImage.Source = "Building.png";
                Constantce.APIName = "";
                bath1c.IsVisible = false;
                bath1u.IsVisible = true;
                bath2u.IsVisible = true;
                bath2c.IsVisible = false;
                bath3u.IsVisible = true;
                bath3c.IsVisible = false;
                bath4u.IsVisible = true;
                bath4c.IsVisible = false;
                Constantce.Bath = 0;


            }
            else
            {
                bed1c.IsVisible = false;
                bed1u.IsVisible = true;
                bed2u.IsVisible = true;
                bed2c.IsVisible = false;
                bed3u.IsVisible = true;
                bed3c.IsVisible = false;
                bed4u.IsVisible = true;
                bed4c.IsVisible = false;
                Constantce.Bed = 0;
                ApartmentButton.BackgroundColor = Color.FromHex("#FF071D66");
                ApartmentButton.TextColor = Color.White;
                ApartmentButton.BorderColor = Color.FromHex("#FF071D66");
                FlatButton.BackgroundColor = Color.White;
                FlatButton.TextColor = Color.FromHex("#FF071D66");
                FlatButton.BorderColor = Color.FromHex("#FF071D66");
                BuildingButton.BackgroundColor = Color.White;
                BuildingButton.TextColor = Color.FromHex("#FF071D66");
                BuildingButton.BorderColor = Color.FromHex("#FF071D66");
                HouseButton.BackgroundColor = Color.White;
                HouseButton.TextColor = Color.FromHex("#FF071D66");
                HouseButton.BorderColor = Color.FromHex("#FF071D66");
                homeModel.SubCategory = 1;
                CategorySelected = true;
                ApartmentImage.Source = "apartmentWhite.png";
                HosueImage.Source = "House.png";
                FlatImage.Source = "flat.png";
                BuildingImage.Source = "Building.png";
                Constantce.APIName = "Apartment";
                bath1c.IsVisible = false;
                bath1u.IsVisible = true;
                bath2u.IsVisible = true;
                bath2c.IsVisible = false;
                bath3u.IsVisible = true;
                bath3c.IsVisible = false;
                bath4u.IsVisible = true;
                bath4c.IsVisible = false;
                Constantce.Bath = 0;

            }
        }

        private void BuildingButton_Clicked(object sender, EventArgs e)
        {
            if (BuildingButton.BackgroundColor == Color.FromHex("#FF071D66"))
            {
                bed1c.IsVisible = false;
                bed1u.IsVisible = true;
                bed2u.IsVisible = true;
                bed2c.IsVisible = false;
                bed3u.IsVisible = true;
                bed3c.IsVisible = false;
                bed4u.IsVisible = true;
                bed4c.IsVisible = false;
                Constantce.Bed = 0;
                HouseButton.BackgroundColor = Color.White;
                HouseButton.TextColor = Color.FromHex("#FF071D66");
                HouseButton.BorderColor = Color.FromHex("#FF071D66");
                FlatButton.BackgroundColor = Color.White;
                FlatButton.TextColor = Color.FromHex("#FF071D66");
                FlatButton.BorderColor = Color.FromHex("#FF071D66");
                ApartmentButton.BackgroundColor = Color.White;
                ApartmentButton.TextColor = Color.FromHex("#FF071D66");
                ApartmentButton.BorderColor = Color.FromHex("#FF071D66");
                BuildingButton.BackgroundColor = Color.White;
                BuildingButton.TextColor = Color.FromHex("#FF071D66");
                BuildingButton.BorderColor = Color.FromHex("#FF071D66");
                homeModel.SubCategory = 0;
                CategorySelected = false;
                HosueImage.Source = "House.png";
                FlatImage.Source = "flat.png";
                ApartmentImage.Source = "apartment.png";
                BuildingImage.Source = "Building.png";
                Constantce.APIName = "";
                bath1c.IsVisible = false;
                bath1u.IsVisible = true;
                bath2u.IsVisible = true;
                bath2c.IsVisible = false;
                bath3u.IsVisible = true;
                bath3c.IsVisible = false;
                bath4u.IsVisible = true;
                bath4c.IsVisible = false;
                Constantce.Bath = 0;


            }
            else
            {
                bed1c.IsVisible = false;
                bed1u.IsVisible = true;
                bed2u.IsVisible = true;
                bed2c.IsVisible = false;
                bed3u.IsVisible = true;
                bed3c.IsVisible = false;
                bed4u.IsVisible = true;
                bed4c.IsVisible = false;
                Constantce.Bed = 0;
                bath1c.IsVisible = false;
                bath1u.IsVisible = true;
                bath2u.IsVisible = true;
                bath2c.IsVisible = false;
                bath3u.IsVisible = true;
                bath3c.IsVisible = false;
                bath4u.IsVisible = true;
                bath4c.IsVisible = false;
                Constantce.Bath = 0;
                BuildingButton.BackgroundColor = Color.FromHex("#FF071D66");
                BuildingButton.TextColor = Color.White;
                BuildingButton.BorderColor = Color.FromHex("#FF071D66");
                ApartmentButton.BackgroundColor = Color.White;
                ApartmentButton.TextColor = Color.FromHex("#FF071D66");
                ApartmentButton.BorderColor = Color.FromHex("#FF071D66");
                FlatButton.BackgroundColor = Color.White;
                FlatButton.TextColor = Color.FromHex("#FF071D66");
                FlatButton.BorderColor = Color.FromHex("#FF071D66");
                HouseButton.BackgroundColor = Color.White;
                HouseButton.TextColor = Color.FromHex("#FF071D66");
                HouseButton.BorderColor = Color.FromHex("#FF071D66");
                homeModel.SubCategory = 3;
                CategorySelected = true;
                BuildingImage.Source = "buildingWhite.png";
                HosueImage.Source = "House.png";
                FlatImage.Source = "flat.png";
                ApartmentImage.Source = "apartment.png";
                Constantce.APIName = "BuildingResidintial";



            }
        }

        private void FurnishedButton_Clicked(object sender, EventArgs e)
        {
            if (FurnishedButton.BackgroundColor == Color.FromHex("#FF071D66"))
            {
                FurnishedButton.BackgroundColor = Color.White;
                FurnishedButton.TextColor = Color.FromHex("#FF071D66");
                FurnishedButton.BorderColor = Color.FromHex("#FF071D66");
                UnFernishedButton.BackgroundColor = Color.White;
                UnFernishedButton.TextColor = Color.FromHex("#FF071D66");
                UnFernishedButton.BorderColor = Color.FromHex("#FF071D66");
                FienishedImage.Source = "firnished.png";
                UnFirnishedImage.Source = "unfirnished.png";
            }
            else
            {
                FurnishedButton.BackgroundColor = Color.FromHex("#FF071D66");
                FurnishedButton.TextColor = Color.White;
                FurnishedButton.BorderColor = Color.FromHex("#FF071D66");
                UnFernishedButton.BackgroundColor = Color.White;
                UnFernishedButton.TextColor = Color.FromHex("#FF071D66");
                UnFernishedButton.BorderColor = Color.FromHex("#FF071D66");
                FienishedImage.Source = "firnishedWhite.png";
                UnFirnishedImage.Source = "unfirnished.png";
            }
        }

        private void UnFernishedButton_Clicked(object sender, EventArgs e)
        {
            if (UnFernishedButton.BackgroundColor == Color.FromHex("#FF071D66"))
            {
                UnFernishedButton.BackgroundColor = Color.White;
                UnFernishedButton.TextColor = Color.FromHex("#FF071D66");
                UnFernishedButton.BorderColor = Color.FromHex("#FF071D66");
                FurnishedButton.BackgroundColor = Color.White;
                FurnishedButton.TextColor = Color.FromHex("#FF071D66");
                FurnishedButton.BorderColor = Color.FromHex("#FF071D66");
                FienishedImage.Source = "firnished.png";
                UnFirnishedImage.Source = "unfirnished.png";
            }
            else
            {
                UnFernishedButton.BackgroundColor = Color.FromHex("#FF071D66");
                UnFernishedButton.TextColor = Color.White;
                UnFernishedButton.BorderColor = Color.FromHex("#FF071D66");
                FurnishedButton.BackgroundColor = Color.White;
                FurnishedButton.TextColor = Color.FromHex("#FF071D66");
                FurnishedButton.BorderColor = Color.FromHex("#FF071D66");
                UnFirnishedImage.Source = "unfirnishedWhite.png";
                FienishedImage.Source = "firnished.png";
            }
        }
        //end of buttons residential code



        //start of buttons commercial code
        private void ShowRoomButton_Clicked(object sender, EventArgs e)
        {
            if (ShowRoomButton.BackgroundColor == Color.FromHex("#FF071D66"))
            {
                ShowRoomButton.BackgroundColor = Color.White;
                ShowRoomButton.TextColor = Color.FromHex("#FF071D66");
                ShowRoomButton.BorderColor = Color.FromHex("#FF071D66");
                OfficeButton.BackgroundColor = Color.White;
                OfficeButton.TextColor = Color.FromHex("#FF071D66");
                OfficeButton.BorderColor = Color.FromHex("#FF071D66");
                ShopsButton.BackgroundColor = Color.White;
                ShopsButton.TextColor = Color.FromHex("#FF071D66");
                ShopsButton.BorderColor = Color.FromHex("#FF071D66");
                BuildingComButton.BackgroundColor = Color.White;
                BuildingComButton.TextColor = Color.FromHex("#FF071D66");
                BuildingComButton.BorderColor = Color.FromHex("#FF071D66");
                homeModel.SubCategory = 0;
                CategorySelected = false;
                ShowRoomImage.Source = "showroom.png";
                ShopsImage.Source = "shop.png";
                OfficeImage.Source = "office.png";
                BuildingComImage.Source = "Building.png";
                Constantce.APIName = "";


            }
            else
            {
                ShowRoomButton.BackgroundColor = Color.FromHex("#FF071D66");
                ShowRoomButton.TextColor = Color.White;
                ShowRoomButton.BorderColor = Color.FromHex("#FF071D66");
                OfficeButton.BackgroundColor = Color.White;
                OfficeButton.TextColor = Color.FromHex("#FF071D66");
                OfficeButton.BorderColor = Color.FromHex("#FF071D66");
                ShopsButton.BackgroundColor = Color.White;
                ShopsButton.TextColor = Color.FromHex("#FF071D66");
                ShopsButton.BorderColor = Color.FromHex("#FF071D66");
                BuildingComButton.BackgroundColor = Color.White;
                BuildingComButton.TextColor = Color.FromHex("#FF071D66");
                BuildingComButton.BorderColor = Color.FromHex("#FF071D66");
                homeModel.SubCategory = 5;
                CategorySelected = true;
                ShowRoomImage.Source = "showroomWhite.png";
                ShopsImage.Source = "shop.png";
                OfficeImage.Source = "office.png";
                BuildingComImage.Source = "Building.png";
                Constantce.APIName = "ShowRoom";

            }
        }

        private void OfficeButton_Clicked(object sender, EventArgs e)
        {
            if (OfficeButton.BackgroundColor == Color.FromHex("#FF071D66"))
            {
                OfficeButton.BackgroundColor = Color.White;
                OfficeButton.TextColor = Color.FromHex("#FF071D66");
                OfficeButton.BorderColor = Color.FromHex("#FF071D66");
                ShowRoomButton.BackgroundColor = Color.White;
                ShowRoomButton.TextColor = Color.FromHex("#FF071D66");
                ShowRoomButton.BorderColor = Color.FromHex("#FF071D66");
                ShopsButton.BackgroundColor = Color.White;
                ShopsButton.TextColor = Color.FromHex("#FF071D66");
                ShopsButton.BorderColor = Color.FromHex("#FF071D66");
                BuildingComButton.BackgroundColor = Color.White;
                BuildingComButton.TextColor = Color.FromHex("#FF071D66");
                BuildingComButton.BorderColor = Color.FromHex("#FF071D66");
                homeModel.SubCategory = 0;
                CategorySelected = false;
                ShowRoomImage.Source = "showroom.png";
                ShopsImage.Source = "shop.png";
                OfficeImage.Source = "office.png";
                BuildingComImage.Source = "Building.png";
                Constantce.APIName = "";


            }
            else
            {
                OfficeButton.BackgroundColor = Color.FromHex("#FF071D66");
                OfficeButton.TextColor = Color.White;
                OfficeButton.BorderColor = Color.FromHex("#FF071D66");
                ShowRoomButton.BackgroundColor = Color.White;
                ShowRoomButton.TextColor = Color.FromHex("#FF071D66");
                ShowRoomButton.BorderColor = Color.FromHex("#FF071D66");
                ShopsButton.BackgroundColor = Color.White;
                ShopsButton.TextColor = Color.FromHex("#FF071D66");
                ShopsButton.BorderColor = Color.FromHex("#FF071D66");
                BuildingComButton.BackgroundColor = Color.White;
                BuildingComButton.TextColor = Color.FromHex("#FF071D66");
                BuildingComButton.BorderColor = Color.FromHex("#FF071D66");
                homeModel.SubCategory = 6;
                CategorySelected = true;
                ShowRoomImage.Source = "showroom.png";
                ShopsImage.Source = "shop.png";
                OfficeImage.Source = "officeWhite.png";
                BuildingComImage.Source = "Building.png";
                Constantce.APIName = "Office";


            }
        }

        private void ShopsButton_Clicked(object sender, EventArgs e)
        {
            if (ShopsButton.BackgroundColor == Color.FromHex("#FF071D66"))
            {
                ShopsButton.BackgroundColor = Color.White;
                ShopsButton.TextColor = Color.FromHex("#FF071D66");
                ShopsButton.BorderColor = Color.FromHex("#FF071D66");
                OfficeButton.BackgroundColor = Color.White;
                OfficeButton.TextColor = Color.FromHex("#FF071D66");
                OfficeButton.BorderColor = Color.FromHex("#FF071D66");
                ShowRoomButton.BackgroundColor = Color.White;
                ShowRoomButton.TextColor = Color.FromHex("#FF071D66");
                ShowRoomButton.BorderColor = Color.FromHex("#FF071D66");
                BuildingComButton.BackgroundColor = Color.White;
                BuildingComButton.TextColor = Color.FromHex("#FF071D66");
                BuildingComButton.BorderColor = Color.FromHex("#FF071D66");
                homeModel.SubCategory = 0;
                CategorySelected = false;
                ShowRoomImage.Source = "showroom.png";
                ShopsImage.Source = "shop.png";
                OfficeImage.Source = "office.png";
                BuildingComImage.Source = "Building.png";
                Constantce.APIName = "";

            }
            else
            {
                ShopsButton.BackgroundColor = Color.FromHex("#FF071D66");
                ShopsButton.TextColor = Color.White;
                ShopsButton.BorderColor = Color.FromHex("#FF071D66");
                OfficeButton.BackgroundColor = Color.White;
                OfficeButton.TextColor = Color.FromHex("#FF071D66");
                OfficeButton.BorderColor = Color.FromHex("#FF071D66");
                ShowRoomButton.BackgroundColor = Color.White;
                ShowRoomButton.TextColor = Color.FromHex("#FF071D66");
                ShowRoomButton.BorderColor = Color.FromHex("#FF071D66");
                BuildingComButton.BackgroundColor = Color.White;
                BuildingComButton.TextColor = Color.FromHex("#FF071D66");
                BuildingComButton.BorderColor = Color.FromHex("#FF071D66");
                homeModel.SubCategory = 7;
                CategorySelected = true;
                ShowRoomImage.Source = "showroom.png";
                ShopsImage.Source = "shopWhite.png";
                OfficeImage.Source = "office.png";
                BuildingComImage.Source = "Building.png";
                Constantce.APIName = "Shops";


            }
        }

        private void BuildingComButton_Clicked(object sender, EventArgs e)
        {
            if (BuildingComButton.BackgroundColor == Color.FromHex("#FF071D66"))
            {
                BuildingComButton.BackgroundColor = Color.White;
                BuildingComButton.TextColor = Color.FromHex("#FF071D66");
                BuildingComButton.BorderColor = Color.FromHex("#FF071D66");
                OfficeButton.BackgroundColor = Color.White;
                OfficeButton.TextColor = Color.FromHex("#FF071D66");
                OfficeButton.BorderColor = Color.FromHex("#FF071D66");
                ShopsButton.BackgroundColor = Color.White;
                ShopsButton.TextColor = Color.FromHex("#FF071D66");
                ShopsButton.BorderColor = Color.FromHex("#FF071D66");
                ShowRoomButton.BackgroundColor = Color.White;
                ShowRoomButton.TextColor = Color.FromHex("#FF071D66");
                ShowRoomButton.BorderColor = Color.FromHex("#FF071D66");
                homeModel.SubCategory = 0;
                CategorySelected = false;
                ShowRoomImage.Source = "showroom.png";
                ShopsImage.Source = "shop.png";
                OfficeImage.Source = "office.png";
                BuildingComImage.Source = "Building.png";
                Constantce.APIName = "";


            }
            else
            {
                BuildingComButton.BackgroundColor = Color.FromHex("#FF071D66");
                BuildingComButton.TextColor = Color.White;
                BuildingComButton.BorderColor = Color.FromHex("#FF071D66");
                OfficeButton.BackgroundColor = Color.White;
                OfficeButton.TextColor = Color.FromHex("#FF071D66");
                OfficeButton.BorderColor = Color.FromHex("#FF071D66");
                ShopsButton.BackgroundColor = Color.White;
                ShopsButton.TextColor = Color.FromHex("#FF071D66");
                ShopsButton.BorderColor = Color.FromHex("#FF071D66");
                ShowRoomButton.BackgroundColor = Color.White;
                ShowRoomButton.TextColor = Color.FromHex("#FF071D66");
                ShowRoomButton.BorderColor = Color.FromHex("#FF071D66");
                homeModel.SubCategory = 8;
                CategorySelected = true;
                ShowRoomImage.Source = "showroom.png";
                ShopsImage.Source = "shop.png";
                OfficeImage.Source = "office.png";
                BuildingComImage.Source = "buildingWhite.png";
                Constantce.APIName = "BuildingComm";


            }
        }
        // end of commercial buttom code



        // start of Land buttom code
        private void CommercialButton_Clicked(object sender, EventArgs e)
        {
            if (CommercialButton.BackgroundColor == Color.FromHex("#FF071D66"))
            {
                CommercialButton.BackgroundColor = Color.White;
                CommercialButton.TextColor = Color.FromHex("#FF071D66");
                CommercialButton.BorderColor = Color.FromHex("#FF071D66");
                IndustrialButton.BackgroundColor = Color.White;
                IndustrialButton.TextColor = Color.FromHex("#FF071D66");
                IndustrialButton.BorderColor = Color.FromHex("#FF071D66");
                ResidentialButton.BackgroundColor = Color.White;
                ResidentialButton.TextColor = Color.FromHex("#FF071D66");
                ResidentialButton.BorderColor = Color.FromHex("#FF071D66");
                AgrecultureComButton.BackgroundColor = Color.White;
                AgrecultureComButton.TextColor = Color.FromHex("#FF071D66");
                AgrecultureComButton.BorderColor = Color.FromHex("#FF071D66");
                homeModel.SubCategory = 0;
                CategorySelected = false;
                CommercialImage.Source = "commercial.png";
                ResidentialImage.Source = "residential.png";
                IndustrialImage.Source = "industrial.png";
                AgreculturImage.Source = "agriculturalLand.png";
                Constantce.APIName = "";


            }
            else
            {
                CommercialButton.BackgroundColor = Color.FromHex("#FF071D66");
                CommercialButton.TextColor = Color.White;
                CommercialButton.BorderColor = Color.FromHex("#FF071D66");
                IndustrialButton.BackgroundColor = Color.White;
                IndustrialButton.TextColor = Color.FromHex("#FF071D66");
                IndustrialButton.BorderColor = Color.FromHex("#FF071D66");
                ResidentialButton.BackgroundColor = Color.White;
                ResidentialButton.TextColor = Color.FromHex("#FF071D66");
                ResidentialButton.BorderColor = Color.FromHex("#FF071D66");
                AgrecultureComButton.BackgroundColor = Color.White;
                AgrecultureComButton.TextColor = Color.FromHex("#FF071D66");
                AgrecultureComButton.BorderColor = Color.FromHex("#FF071D66");
                homeModel.SubCategory = 10;
                CategorySelected = true;
                CommercialImage.Source = "commercialWhite.png";
                ResidentialImage.Source = "residential.png";
                IndustrialImage.Source = "industrial.png";
                AgreculturImage.Source = "agriculturalLand.png";
                Constantce.APIName = "CommercialLand";



            }
        }

        private void IndustrialButton_Clicked(object sender, EventArgs e)
        {
            if (IndustrialButton.BackgroundColor == Color.FromHex("#FF071D66"))
            {
                IndustrialButton.BackgroundColor = Color.White;
                IndustrialButton.TextColor = Color.FromHex("#FF071D66");
                IndustrialButton.BorderColor = Color.FromHex("#FF071D66");
                CommercialButton.BackgroundColor = Color.White;
                CommercialButton.TextColor = Color.FromHex("#FF071D66");
                CommercialButton.BorderColor = Color.FromHex("#FF071D66");
                ResidentialButton.BackgroundColor = Color.White;
                ResidentialButton.TextColor = Color.FromHex("#FF071D66");
                ResidentialButton.BorderColor = Color.FromHex("#FF071D66");
                AgrecultureComButton.BackgroundColor = Color.White;
                AgrecultureComButton.TextColor = Color.FromHex("#FF071D66");
                AgrecultureComButton.BorderColor = Color.FromHex("#FF071D66");
                homeModel.SubCategory = 0;
                CategorySelected = false;
                CommercialImage.Source = "commercial.png";
                ResidentialImage.Source = "residential.png";
                IndustrialImage.Source = "industrial.png";
                AgreculturImage.Source = "agriculturalLand.png";
                Constantce.APIName = "";


            }
            else
            {
                IndustrialButton.BackgroundColor = Color.FromHex("#FF071D66");
                IndustrialButton.TextColor = Color.White;
                IndustrialButton.BorderColor = Color.FromHex("#FF071D66");
                CommercialButton.BackgroundColor = Color.White;
                CommercialButton.TextColor = Color.FromHex("#FF071D66");
                CommercialButton.BorderColor = Color.FromHex("#FF071D66");
                ResidentialButton.BackgroundColor = Color.White;
                ResidentialButton.TextColor = Color.FromHex("#FF071D66");
                ResidentialButton.BorderColor = Color.FromHex("#FF071D66");
                AgrecultureComButton.BackgroundColor = Color.White;
                AgrecultureComButton.TextColor = Color.FromHex("#FF071D66");
                AgrecultureComButton.BorderColor = Color.FromHex("#FF071D66");
                homeModel.SubCategory = 9;
                CategorySelected = true;
                CommercialImage.Source = "commercial.png";
                ResidentialImage.Source = "residential.png";
                IndustrialImage.Source = "industrialWhite.png";
                AgreculturImage.Source = "agriculturalLand.png";
                Constantce.APIName = "IndustrialLand";


            }
        }

        private void ResidentialButton_Clicked(object sender, EventArgs e)
        {
            if (ResidentialButton.BackgroundColor == Color.FromHex("#FF071D66"))
            {
                ResidentialButton.BackgroundColor = Color.White;
                ResidentialButton.TextColor = Color.FromHex("#FF071D66");
                ResidentialButton.BorderColor = Color.FromHex("#FF071D66");
                IndustrialButton.BackgroundColor = Color.White;
                IndustrialButton.TextColor = Color.FromHex("#FF071D66");
                IndustrialButton.BorderColor = Color.FromHex("#FF071D66");
                AgrecultureComButton.BackgroundColor = Color.White;
                AgrecultureComButton.TextColor = Color.FromHex("#FF071D66");
                AgrecultureComButton.BorderColor = Color.FromHex("#FF071D66");
                CommercialButton.BackgroundColor = Color.White;
                CommercialButton.TextColor = Color.FromHex("#FF071D66");
                CommercialButton.BorderColor = Color.FromHex("#FF071D66");
                homeModel.SubCategory = 0;
                CategorySelected = false;
                CommercialImage.Source = "commercial.png";
                ResidentialImage.Source = "residential.png";
                IndustrialImage.Source = "industrial.png";
                AgreculturImage.Source = "agriculturalLand.png";
                Constantce.APIName = "";


            }
            else
            {
                ResidentialButton.BackgroundColor = Color.FromHex("#FF071D66");
                ResidentialButton.TextColor = Color.White;
                ResidentialButton.BorderColor = Color.FromHex("#FF071D66");
                IndustrialButton.BackgroundColor = Color.White;
                IndustrialButton.TextColor = Color.FromHex("#FF071D66");
                IndustrialButton.BorderColor = Color.FromHex("#FF071D66");
                CommercialButton.BackgroundColor = Color.White;
                CommercialButton.TextColor = Color.FromHex("#FF071D66");
                CommercialButton.BorderColor = Color.FromHex("#FF071D66");
                AgrecultureComButton.BackgroundColor = Color.White;
                AgrecultureComButton.TextColor = Color.FromHex("#FF071D66");
                AgrecultureComButton.BorderColor = Color.FromHex("#FF071D66");
                homeModel.SubCategory = 11;
                CategorySelected = true;
                CommercialImage.Source = "commercial.png";
                ResidentialImage.Source = "residentialWhite.png";
                IndustrialImage.Source = "industrial.png";
                AgreculturImage.Source = "agriculturalLand.png";
                Constantce.APIName = "ResidentialLand";

            }
        }

        private void AgrecultureComButton_Clicked(object sender, EventArgs e)
        {
            if (AgrecultureComButton.BackgroundColor == Color.FromHex("#FF071D66"))
            {
                AgrecultureComButton.BackgroundColor = Color.White;
                AgrecultureComButton.TextColor = Color.FromHex("#FF071D66");
                AgrecultureComButton.BorderColor = Color.FromHex("#FF071D66");
                IndustrialButton.BackgroundColor = Color.White;
                IndustrialButton.TextColor = Color.FromHex("#FF071D66");
                IndustrialButton.BorderColor = Color.FromHex("#FF071D66");
                ResidentialButton.BackgroundColor = Color.White;
                ResidentialButton.TextColor = Color.FromHex("#FF071D66");
                ResidentialButton.BorderColor = Color.FromHex("#FF071D66");
                CommercialButton.BackgroundColor = Color.White;
                CommercialButton.TextColor = Color.FromHex("#FF071D66");
                CommercialButton.BorderColor = Color.FromHex("#FF071D66");
                homeModel.SubCategory = 0;
                CategorySelected = false;
                CommercialImage.Source = "commercial.png";
                ResidentialImage.Source = "residential.png";
                IndustrialImage.Source = "industrial.png";
                AgreculturImage.Source = "agriculturalLand.png";
                Constantce.APIName = "";



            }
            else
            {
                AgrecultureComButton.BackgroundColor = Color.FromHex("#FF071D66");
                AgrecultureComButton.TextColor = Color.White;
                AgrecultureComButton.BorderColor = Color.FromHex("#FF071D66");
                IndustrialButton.BackgroundColor = Color.White;
                IndustrialButton.TextColor = Color.FromHex("#FF071D66");
                IndustrialButton.BorderColor = Color.FromHex("#FF071D66");
                ResidentialButton.BackgroundColor = Color.White;
                ResidentialButton.TextColor = Color.FromHex("#FF071D66");
                ResidentialButton.BorderColor = Color.FromHex("#FF071D66");
                CommercialButton.BackgroundColor = Color.White;
                CommercialButton.TextColor = Color.FromHex("#FF071D66");
                CommercialButton.BorderColor = Color.FromHex("#FF071D66");
                homeModel.SubCategory = 12;
                CategorySelected = true;
                CommercialImage.Source = "commercial.png";
                ResidentialImage.Source = "residential.png";
                IndustrialImage.Source = "industrial.png";
                AgreculturImage.Source = "agriculturalLandWhite.png";
                Constantce.APIName = "AgreculturLand";

            }
        }
        //end of Land buttons code


        //start of industrial buttons code
        private void HangerButton_Clicked(object sender, EventArgs e)
        {
            if (HangerButton.BackgroundColor == Color.FromHex("#FF071D66"))
            {
                HangerButton.BackgroundColor = Color.White;
                HangerButton.TextColor = Color.FromHex("#FF071D66");
                HangerButton.BorderColor = Color.FromHex("#FF071D66");
                BuildingIndButton.BackgroundColor = Color.White;
                BuildingIndButton.TextColor = Color.FromHex("#FF071D66");
                BuildingIndButton.BorderColor = Color.FromHex("#FF071D66");
                homeModel.SubCategory = 0;
                CategorySelected = false;
                HangarImage.Source = "hangar.png";
                BildingIndImage.Source = "indbuilding.png";
                Constantce.APIName = "";
            }
            else
            {
                HangerButton.BackgroundColor = Color.FromHex("#FF071D66");
                HangerButton.TextColor = Color.White;
                HangerButton.BorderColor = Color.FromHex("#FF071D66");
                BuildingIndButton.BackgroundColor = Color.White;
                BuildingIndButton.TextColor = Color.FromHex("#FF071D66");
                BuildingIndButton.BorderColor = Color.FromHex("#FF071D66");
                homeModel.SubCategory = 13;
                CategorySelected = true;
                HangarImage.Source = "hangarWhite.png";
                BildingIndImage.Source = "indbuilding.png";
                Constantce.APIName = "HangarInd";

            }
        }

        private void BuildingIndButton_Clicked(object sender, EventArgs e)
        {
            if (BuildingIndButton.BackgroundColor == Color.FromHex("#FF071D66"))
            {
                BuildingIndButton.BackgroundColor = Color.White;
                BuildingIndButton.TextColor = Color.FromHex("#FF071D66");
                BuildingIndButton.BorderColor = Color.FromHex("#FF071D66");
                HangerButton.BackgroundColor = Color.White;
                HangerButton.TextColor = Color.FromHex("#FF071D66");
                HangerButton.BorderColor = Color.FromHex("#FF071D66");
                homeModel.SubCategory = 0;
                CategorySelected = false;
                HangarImage.Source = "hangar.png";
                BildingIndImage.Source = "indbuilding.png";
                Constantce.APIName = "";

            }
            else
            {
                BuildingIndButton.BackgroundColor = Color.FromHex("#FF071D66");
                BuildingIndButton.TextColor = Color.White;
                BuildingIndButton.BorderColor = Color.FromHex("#FF071D66");
                HangerButton.BackgroundColor = Color.White;
                HangerButton.TextColor = Color.FromHex("#FF071D66");
                HangerButton.BorderColor = Color.FromHex("#FF071D66");
                homeModel.SubCategory = 14;
                CategorySelected = true;
                HangarImage.Source = "hangar.png";
                BildingIndImage.Source = "indbuildingWhite.png";
                Constantce.APIName = "BuildingInd";

            }
        }
        //end of industrial buttons code


        // Apply Button
        async private void ApplyFilter_Clicked(object sender, EventArgs e)
        {
            int pid = 0;
            if (CrossConnectivity.Current.IsConnected)
            {
                if (TypeSelected == true)
                {
                    if (CategorySelected == true)
                    {
                        UserDialogs.Instance.ShowLoading();
                        await Task.Delay(100);
                        Constantce.homeModelC = homeModel;
                        ObservableCollection<Property> property = new ObservableCollection<Property>();
                        ObservableCollection<Ad> ads = new ObservableCollection<Ad>();
                        var uri = string.Format(Constantce.URL + "/api/properties/" + Constantce.APIName + "?fort={0}&category={1}&Subcat={2}&lon={3}&lat={4}&id={5}&bed={6}&bath={7}", homeModel.SaleOrRent, homeModel.Category, homeModel.SubCategory, Longt, Latt, pid, Constantce.Bed, Constantce.Bath);
                        HttpWebRequest request = WebRequest.Create(uri) as HttpWebRequest;
                        using (HttpWebResponse response = request.GetResponse() as HttpWebResponse)
                        {
                            StreamReader reader = new StreamReader(response.GetResponseStream());
                            string Data = reader.ReadToEnd();
                             property = JsonConvert.DeserializeObject<ObservableCollection<Property>>(Data);
                        }
                        var uri1 = string.Format(Constantce.URL + "/api/properties/GetAds");
                        HttpWebRequest request1 = WebRequest.Create(uri1) as HttpWebRequest;
                        using (HttpWebResponse response = request1.GetResponse() as HttpWebResponse)
                        {
                            StreamReader reader = new StreamReader(response.GetResponseStream());
                            string Data = reader.ReadToEnd();
                             ads = JsonConvert.DeserializeObject<ObservableCollection<Ad>>(Data);
                        }
                        await Navigation.PushAsync(new Tapped(property,homeModel,Longt,Latt,ads));
                        UserDialogs.Instance.HideLoading();
                    }

                    else
                    {
                        if (Application.Current.Properties["Language"].ToString() == "Arabic")
                        {
                            await DisplayAlert("تنبيه", "يرجى اختيار الفئة", "موافق");

                        }
                        else
                        {
                            await DisplayAlert("Alert", "PLease Select Category", "OK");

                        }
                    }
                }
                else
                {
                    if (Application.Current.Properties["Language"].ToString() == "Arabic")
                    {
                        await DisplayAlert("تنبيه", "يرحى اختيار للبيع ام للايجار", "موافق");
                    }
                    else
                    {
                        await DisplayAlert("Alert", "PLease Select Rent OR Sale", "OK");

                    }
                }
            }
            else
            {
                if (Application.Current.Properties["Language"].ToString() == "Arabic")
                {
                    await DisplayAlert("تنبيه", "يرجى التاكد من الانترنت", "موافق");
                }
                else
                {
                    await DisplayAlert("Alert", "Check Internet Connection", "OK");

                }
            }
        }
        //End Apply Button


        // Nav Bar Start
        void OnHomeButtonClicked(object sender, EventArgs e)
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

            }
            catch(Exception ex)
            {
                string er = ex.Message;
                //await DisplayAlert("Error", "Check App permissions. ", "Ok");
                //return;
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

            catch(Exception ex)
            {
                string er = ex.Message;
                //await DisplayAlert("Error", "Check App permissions. ", "Ok");
               // return;
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
            catch(Exception ex)
            {
                string er = ex.Message;
                //await DisplayAlert("Error", "Check App permissions. ", "Ok");
                //return;
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
            catch(Exception ex)
            {
                string er = ex.Message;
                //await DisplayAlert("Error", "Check App permissions. ", "Ok");
                //UserDialogs.Instance.HideLoading();
               //return;
            }
        }
        //Nav Bar End

        private async void MapView_Clicked(object sender, EventArgs e)
        {
            MapView.IsEnabled = false;
            await PopupNavigation.Instance.PushAsync(new LocationMap());
            MapView.IsEnabled = true;

        }

        //number of beds start
        private void bed1unchecked(object sender, EventArgs e)
        {
            bed1c.IsVisible = true;
            bed1u.IsVisible = false;
            bed2u.IsVisible = true;
            bed2c.IsVisible = false;
            bed3u.IsVisible = true;
            bed3c.IsVisible = false;
            bed4u.IsVisible = true;
            bed4c.IsVisible = false;
            Constantce.Bed = 1;
        }
        private void bed1checked(object sender, EventArgs e)
        {
            bed1c.IsVisible = false;
            bed1u.IsVisible = true;
            bed2u.IsVisible = true;
            bed2c.IsVisible = false;
            bed3u.IsVisible = true;
            bed3c.IsVisible = false;
            bed4u.IsVisible = true;
            bed4c.IsVisible = false;
            Constantce.Bed = 0;
        }
        private void bed2unchecked(object sender, EventArgs e)
        {
            bed1c.IsVisible = false;
            bed1u.IsVisible = true;
            bed2u.IsVisible = false;
            bed2c.IsVisible = true;
            bed3u.IsVisible = true;
            bed3c.IsVisible = false;
            bed4u.IsVisible = true;
            bed4c.IsVisible = false;
            Constantce.Bed = 2;
        }
        private void bed2checked(object sender, EventArgs e)
        {
            bed1c.IsVisible = false;
            bed1u.IsVisible = true;
            bed2u.IsVisible = true;
            bed2c.IsVisible = false;
            bed3u.IsVisible = true;
            bed3c.IsVisible = false;
            bed4u.IsVisible = true;
            bed4c.IsVisible = false;
            Constantce.Bed = 0;
        }
        private void bed3unchecked(object sender, EventArgs e)
        {
            bed1c.IsVisible = false;
            bed1u.IsVisible = true;
            bed2u.IsVisible = true;
            bed2c.IsVisible = false;
            bed3u.IsVisible = false;
            bed3c.IsVisible = true;
            bed4u.IsVisible = true;
            bed4c.IsVisible = false;
            Constantce.Bed = 3;
        }
        private void bed3checked(object sender, EventArgs e)
        {
            bed1c.IsVisible = false;
            bed1u.IsVisible = true;
            bed2u.IsVisible = true;
            bed2c.IsVisible = false;
            bed3u.IsVisible = true;
            bed3c.IsVisible = false;
            bed4u.IsVisible = true;
            bed4c.IsVisible = false;
            Constantce.Bed = 0;
        }
        private void bed4unchecked(object sender, EventArgs e)
        {
            bed1c.IsVisible = false;
            bed1u.IsVisible = true;
            bed2u.IsVisible = true;
            bed2c.IsVisible = false;
            bed3u.IsVisible = true;
            bed3c.IsVisible = false;
            bed4u.IsVisible = false;
            bed4c.IsVisible = true;
            Constantce.Bed = 4;
        }
        private void bed4checked(object sender, EventArgs e)
        {
            bed1c.IsVisible = false;
            bed1u.IsVisible = true;
            bed2u.IsVisible = true;
            bed2c.IsVisible = false;
            bed3u.IsVisible = true;
            bed3c.IsVisible = false;
            bed4u.IsVisible = true;
            bed4c.IsVisible = false;
            Constantce.Bed = 0;
        }
        //number of beds end

        //number of baths start
        private void bath1unchecked(object sender, EventArgs e)
        {
            bath1c.IsVisible = true;
            bath1u.IsVisible = false;
            bath2u.IsVisible = true;
            bath2c.IsVisible = false;
            bath3u.IsVisible = true;
            bath3c.IsVisible = false;
            bath4u.IsVisible = true;
            bath4c.IsVisible = false;
            Constantce.Bath = 1;
        }
        private void bath1checked(object sender, EventArgs e)
        {
            bath1c.IsVisible = false;
            bath1u.IsVisible = true;
            bath2u.IsVisible = true;
            bath2c.IsVisible = false;
            bath3u.IsVisible = true;
            bath3c.IsVisible = false;
            bath4u.IsVisible = true;
            bath4c.IsVisible = false;
            Constantce.Bath = 0;
        }
        private void bath2unchecked(object sender, EventArgs e)
        {
            bath1c.IsVisible = false;
            bath1u.IsVisible = true;
            bath2u.IsVisible = false;
            bath2c.IsVisible = true;
            bath3u.IsVisible = true;
            bath3c.IsVisible = false;
            bath4u.IsVisible = true;
            bath4c.IsVisible = false;
            Constantce.Bath = 2;
        }
        private void bath2checked(object sender, EventArgs e)
        {
            bath1c.IsVisible = false;
            bath1u.IsVisible = true;
            bath2u.IsVisible = true;
            bath2c.IsVisible = false;
            bath3u.IsVisible = true;
            bath3c.IsVisible = false;
            bath4u.IsVisible = true;
            bath4c.IsVisible = false;
            Constantce.Bath = 0;
        }
        private void bath3unchecked(object sender, EventArgs e)
        {
            bath1c.IsVisible = false;
            bath1u.IsVisible = true;
            bath2u.IsVisible = true;
            bath2c.IsVisible = false;
            bath3u.IsVisible = false;
            bath3c.IsVisible = true;
            bath4u.IsVisible = true;
            bath4c.IsVisible = false;
            Constantce.Bath = 3;
        }
        private void bath3checked(object sender, EventArgs e)
        {
            bath1c.IsVisible = false;
            bath1u.IsVisible = true;
            bath2u.IsVisible = true;
            bath2c.IsVisible = false;
            bath3u.IsVisible = true;
            bath3c.IsVisible = false;
            bath4u.IsVisible = true;
            bath4c.IsVisible = false;
            Constantce.Bath = 0;
        }
        private void bath4unchecked(object sender, EventArgs e)
        {
            bath1c.IsVisible = false;
            bath1u.IsVisible = true;
            bath2u.IsVisible = true;
            bath2c.IsVisible = false;
            bath3u.IsVisible = true;
            bath3c.IsVisible = false;
            bath4u.IsVisible = false;
            bath4c.IsVisible = true;
            Constantce.Bath = 4;
        }
        private void bath4checked(object sender, EventArgs e)
        {
            bath1c.IsVisible = false;
            bath1u.IsVisible = true;
            bath2u.IsVisible = true;
            bath2c.IsVisible = false;
            bath3u.IsVisible = true;
            bath3c.IsVisible = false;
            bath4u.IsVisible = true;
            bath4c.IsVisible = false;
            Constantce.Bath = 0;
        }
        //number of baths end

        //land area raadio buttons start
        private void area1unchecked(object sender, EventArgs e)
        {
            area1c.IsVisible = true;
            area1u.IsVisible = false;
            area2u.IsVisible = true;
            area2c.IsVisible = false;
            area3u.IsVisible = true;
            area3c.IsVisible = false;
            area4u.IsVisible = true;
            area4c.IsVisible = false;
            area5u.IsVisible = true;
            area5c.IsVisible = false;
            Constantce.Arealand = 1;
        }
        private void area1checked(object sender, EventArgs e)
        {
            area1c.IsVisible = false;
            area1u.IsVisible = true;
            area2u.IsVisible = true;
            area2c.IsVisible = false;
            area3u.IsVisible = true;
            area3c.IsVisible = false;
            area4u.IsVisible = true;
            area4c.IsVisible = false;
            area5u.IsVisible = true;
            area5c.IsVisible = false;
            Constantce.Arealand = 0;
        }
        private void area2unchecked(object sender, EventArgs e)
        {
            area1c.IsVisible = false;
            area1u.IsVisible = true;
            area2u.IsVisible = false;
            area2c.IsVisible = true;
            area3u.IsVisible = true;
            area3c.IsVisible = false;
            area4u.IsVisible = true;
            area4c.IsVisible = false;
            area5u.IsVisible = true;
            area5c.IsVisible = false;
            Constantce.Arealand = 2;
        }
        private void area2checked(object sender, EventArgs e)
        {
            area1c.IsVisible = false;
            area1u.IsVisible = true;
            area2u.IsVisible = true;
            area2c.IsVisible = false;
            area3u.IsVisible = true;
            area3c.IsVisible = false;
            area4u.IsVisible = true;
            area4c.IsVisible = false;
            area5u.IsVisible = true;
            area5c.IsVisible = false;
            Constantce.Arealand = 0;
        }
        private void area3unchecked(object sender, EventArgs e)
        {
            area1c.IsVisible = false;
            area1u.IsVisible = true;
            area2u.IsVisible = true;
            area2c.IsVisible = false;
            area3u.IsVisible = false;
            area3c.IsVisible = true;
            area4u.IsVisible = true;
            area4c.IsVisible = false;
            area5u.IsVisible = true;
            area5c.IsVisible = false;
            Constantce.Arealand = 3;
        }
        private void area3checked(object sender, EventArgs e)
        {
            area1c.IsVisible = false;
            area1u.IsVisible = true;
            area2u.IsVisible = true;
            area2c.IsVisible = false;
            area3u.IsVisible = true;
            area3c.IsVisible = false;
            area4u.IsVisible = true;
            area4c.IsVisible = false;
            area5u.IsVisible = true;
            area5c.IsVisible = false;
            Constantce.Arealand = 0;
        }
        private void area4unchecked(object sender, EventArgs e)
        {
            area1c.IsVisible = false;
            area1u.IsVisible = true;
            area2u.IsVisible = true;
            area2c.IsVisible = false;
            area3u.IsVisible = true;
            area3c.IsVisible = false;
            area4u.IsVisible = false;
            area4c.IsVisible = true;
            area5u.IsVisible = true;
            area5c.IsVisible = false;
            Constantce.Arealand = 4;
        }
        private void area4checked(object sender, EventArgs e)
        {
            area1c.IsVisible = false;
            area1u.IsVisible = true;
            area2u.IsVisible = true;
            area2c.IsVisible = false;
            area3u.IsVisible = true;
            area3c.IsVisible = false;
            area4u.IsVisible = true;
            area4c.IsVisible = false;
            area5u.IsVisible = true;
            area5c.IsVisible = false;
            Constantce.Arealand = 0;
        }
        private void area5unchecked(object sender, EventArgs e)
        {
            area1c.IsVisible = false;
            area1u.IsVisible = true;
            area2u.IsVisible = true;
            area2c.IsVisible = false;
            area3u.IsVisible = true;
            area3c.IsVisible = false;
            area4u.IsVisible = true;
            area4c.IsVisible = false;
            area5u.IsVisible = false;
            area5c.IsVisible = true;
            Constantce.Arealand = 5;
        }
        private void area5checked(object sender, EventArgs e)
        {
            area1c.IsVisible = false;
            area1u.IsVisible = true;
            area2u.IsVisible = true;
            area2c.IsVisible = false;
            area3u.IsVisible = true;
            area3c.IsVisible = false;
            area4u.IsVisible = true;
            area4c.IsVisible = false;
            area5u.IsVisible = true;
            area5c.IsVisible = false;
            Constantce.Arealand = 0;
        }

        private async void Menu_Activated(object sender, EventArgs e)
        {
           
            await PopupNavigation.Instance.PushAsync(new MenuPop());
        }
        //land area radio buttons end 
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