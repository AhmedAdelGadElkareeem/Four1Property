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
	public partial class LandFilters : ContentPage
	{
        HomeModel homeModel = new HomeModel();
        bool CategorySelected = false;
        public LandFilters(HomeModel SearchMain)
        {
            InitializeComponent();
            homeModel = SearchMain;
        }
        protected override void OnAppearing()
        {
            base.OnAppearing();
            MessagingCenter.Send(this, "preventLandScape");
        }



        async void OnResidentialClicked(object sender, EventArgs e)
        {
            try
            {
                Commercial.IsVisible = true;
                CommercialBlue.IsVisible = false;

                Residential.IsVisible = false;
                ResidentialBlue.IsVisible = true;

                Industrial.IsVisible = true;
                IndustrialBlue.IsVisible = false;



                Agriculture.IsVisible = true;
                AgricultureBlue.IsVisible = false;
                CategorySelected = true;
                homeModel.SubCategory = 13;
            }

            catch
            {
                await DisplayAlert("Error", "Check App permissions. ", "Ok");
                return;
            }
        }

        async void OnIndustrialClicked(object sender, EventArgs e)
        {
            try
            {
                Commercial.IsVisible = true;
                CommercialBlue.IsVisible = false;

                Residential.IsVisible = true;
                ResidentialBlue.IsVisible = false;

                Industrial.IsVisible = false;
                IndustrialBlue.IsVisible = true;



                Agriculture.IsVisible = true;
                AgricultureBlue.IsVisible = false;
                CategorySelected = true;
                homeModel.SubCategory = 11;

            }

            catch
            {
                await DisplayAlert("Error", "Check App permissions. ", "Ok");
                return;
            }
        }

        async void OnCommercialClicked(object sender, EventArgs e)
        {
            try
            {
                Commercial.IsVisible = false;
                CommercialBlue.IsVisible = true;

                Residential.IsVisible = true;
                ResidentialBlue.IsVisible = false;

                Industrial.IsVisible = true;
                IndustrialBlue.IsVisible = false;



                Agriculture.IsVisible = true;
                AgricultureBlue.IsVisible = false;
                CategorySelected = true;
                homeModel.SubCategory = 12;

            }

            catch
            {
                await DisplayAlert("Error", "Check App permissions. ", "Ok");
                return;
            }
        }
        async void OnAgricultureClicked(object sender, EventArgs e)
        {
            try
            {
                Commercial.IsVisible = true;
                CommercialBlue.IsVisible = false;

                Residential.IsVisible = true;
                ResidentialBlue.IsVisible = false;

                Industrial.IsVisible = true;
                IndustrialBlue.IsVisible = false;



                Agriculture.IsVisible = false;
                AgricultureBlue.IsVisible = true;

                CategorySelected = true;

                homeModel.SubCategory = 14;

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
