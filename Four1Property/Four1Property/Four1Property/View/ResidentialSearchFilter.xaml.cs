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
    public partial class ResidentialSearchFilter : ContentPage
    {
        HomeModel homeModel = new HomeModel();
        bool CategorySelected = false;
        public ResidentialSearchFilter(HomeModel SearchMain)
        {
            InitializeComponent();
            homeModel = SearchMain;
        }
        protected override void OnAppearing()
        {
            base.OnAppearing();
            MessagingCenter.Send(this, "preventLandScape");
        }



        async void OnHouseClicked(object sender, EventArgs e)
        {
            try
            {
                Building.IsVisible = true;
                BuildingBlue.IsVisible = false;

                House.IsVisible = false;
                HouseBlue.IsVisible = true;

                Apartment.IsVisible = true;
                ApartmentBlue.IsVisible = false;



                Flat.IsVisible = true;
                FlatBlue.IsVisible = false;
                CategorySelected = true;
                homeModel.SubCategory = 4;

            }

            catch
            {
                await DisplayAlert("Error", "Check App permissions. ", "Ok");
                return;
            }
        }

        async void OnApartmentClicked(object sender, EventArgs e)
        {
            try
            {
                Building.IsVisible = true;
                BuildingBlue.IsVisible = false;

                House.IsVisible = true;
                HouseBlue.IsVisible = false;

                Apartment.IsVisible = false;
                ApartmentBlue.IsVisible = true;



                Flat.IsVisible = true;
                FlatBlue.IsVisible = false;
                CategorySelected = true;
                homeModel.SubCategory = 1;

            }

            catch
            {
                await DisplayAlert("Error", "Check App permissions. ", "Ok");
                return;
            }
        }

        async void OnFlatClicked(object sender, EventArgs e)
        {
            try
            {
                Building.IsVisible = true;
                BuildingBlue.IsVisible = false;

                House.IsVisible = true;
                HouseBlue.IsVisible = false;

                Apartment.IsVisible = true;
                ApartmentBlue.IsVisible = false;



                Flat.IsVisible = false;
                FlatBlue.IsVisible = true;
                CategorySelected = true;
                homeModel.SubCategory = 2;

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

                House.IsVisible = true;
                HouseBlue.IsVisible = false;

                Apartment.IsVisible = true;
                ApartmentBlue.IsVisible = false;



                Flat.IsVisible = true;
                FlatBlue.IsVisible = false;
                CategorySelected = true;
                homeModel.SubCategory = 3;



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
                        var uri = string.Format(Constantce.URL + "/api/properties/GetProperties?fort={0}&category={1}&Subcat={2}", homeModel.SaleOrRent, homeModel.Category ,homeModel.SubCategory);
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

        private void Furnished_Tapped(object sender, EventArgs e)
        {
            fer.IsVisible = false;
            ferselected.IsVisible = true;
            Unfer.IsVisible = true;
            Unferselected.IsVisible = false;
        }
        private void UnFurnished_Tapped(object sender, EventArgs e)
        {
            Unfer.IsVisible = false;
            Unferselected.IsVisible = true;
            fer.IsVisible = true;
            ferselected.IsVisible = false;
        }
    }
}