using Acr.UserDialogs;
using Four1Property.Helper;
using Four1Property.Models;
using Newtonsoft.Json;
using Plugin.Connectivity;
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
    public partial class CommercialSearchFilters : ContentPage
    {
        HomeModel homeModel = new HomeModel();
        bool CategorySelected = false;
        public CommercialSearchFilters(HomeModel SearchMain)
        {
            InitializeComponent();
            homeModel = SearchMain;
        }
        protected override void OnAppearing()
        {
            base.OnAppearing();
            MessagingCenter.Send(this, "preventLandScape");
        }



        async void OnShowRoomClicked(object sender, EventArgs e)
        {
            try
            {
                Building.IsVisible = true;
                BuildingBlue.IsVisible = false;

                ShowRoom.IsVisible = false;
                ShowRoomBlue.IsVisible = true;

                Shops.IsVisible = true;
                ShopsBlue.IsVisible = false;



                Office.IsVisible = true;
                OfficeBlue.IsVisible = false;
                CategorySelected = true;
                homeModel.SubCategory = 5;

            }

            catch
            {
                await DisplayAlert("Error", "Check App permissions. ", "Ok");
                return;
            }
        }

        async void OnBuildingClicked(object sender, EventArgs e)
        {
            try
            {
                Building.IsVisible = false;
                BuildingBlue.IsVisible = true;

                ShowRoom.IsVisible = true;
                ShowRoomBlue.IsVisible = false;

                Shops.IsVisible = true;
                ShopsBlue.IsVisible = false;



                Office.IsVisible = true;
                OfficeBlue.IsVisible = false;
                CategorySelected = true;
                homeModel.SubCategory = 8;

            }

            catch
            {
                await DisplayAlert("Error", "Check App permissions. ", "Ok");
                return;
            }
        }

        async void OnShopsClicked(object sender, EventArgs e)
        {
            try
            {
                Building.IsVisible = true;
                BuildingBlue.IsVisible = false;

                ShowRoom.IsVisible = true;
                ShowRoomBlue.IsVisible = false;

                Shops.IsVisible = false;
                ShopsBlue.IsVisible = true;



                Office.IsVisible = true;
                OfficeBlue.IsVisible = false;
                CategorySelected = true;
                homeModel.SubCategory = 7;

            }

            catch
            {
                await DisplayAlert("Error", "Check App permissions. ", "Ok");
                return;
            }
        }
        async void OnOfficeClicked(object sender, EventArgs e)
        {
            try
            {
                Building.IsVisible = true;
                BuildingBlue.IsVisible = false;

                ShowRoom.IsVisible = true;
                ShowRoomBlue.IsVisible = false;

                Shops.IsVisible = true;
                ShopsBlue.IsVisible = false;


                Office.IsVisible = false;
                OfficeBlue.IsVisible = true;

                CategorySelected = true;

                homeModel.SubCategory = 6;

            }

            catch
            {
                await DisplayAlert("Error", "Check App permissions. ", "Ok");
                return;
            }
        }

        async private void ApplyFilter_Clicked(object sender, EventArgs e)
        {
            if (CrossConnectivity.Current.IsConnected)
            {

                if (CategorySelected == true)
                {

                    UserDialogs.Instance.ShowLoading();
                    await Task.Delay(500);
                    var uri = string.Format(Constantce.URL + "/api/properties/GetProperties?fort={0}&category={1}&Subcat={2}", homeModel.SaleOrRent, homeModel.Category, homeModel.SubCategory);
                    HttpWebRequest request = WebRequest.Create(uri) as HttpWebRequest;
                    using (HttpWebResponse response = request.GetResponse() as HttpWebResponse)
                    {
                        StreamReader reader = new StreamReader(response.GetResponseStream());
                        string Data = reader.ReadToEnd();
                        ObservableCollection<Property> property = JsonConvert.DeserializeObject<ObservableCollection<Property>>(Data);
                        await Navigation.PushAsync(new AcquaintanceList(property));
                    }
                    UserDialogs.Instance.HideLoading();

                }
                else
                {
                    await DisplayAlert("Alert", "PLease Select Category", "OK");
                }
            }
            else
            {
                await DisplayAlert("Alert", "Check Internet Connection", "OK");
            }
        }
    }
}