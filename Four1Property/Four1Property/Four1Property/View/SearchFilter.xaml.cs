using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Four1Property.View
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class SearchFilter : ContentPage
	{
		public SearchFilter ()
		{
			InitializeComponent ();
		}
        protected override void OnAppearing()
        {
            base.OnAppearing();
            MessagingCenter.Send(this, "preventLandScape");
        }
        async void OnForRentClicked(object sender, EventArgs e)
		{
			try
			{
				ForRent.IsVisible = false;
				ForRentBlue.IsVisible = true;
				ForSale.IsVisible = true;
				ForSaleBlue.IsVisible = false;
			}

			catch
			{
				await DisplayAlert("Error", "Rent button has been Clicked.", "Ok");
				return;
			}
		}

		async void OnForSaleClicked(object sender, EventArgs e)
		{
			try
			{
				ForRent.IsVisible = true;
				ForRentBlue.IsVisible = false;
				ForSale.IsVisible = false;
				ForSaleBlue.IsVisible = true;
			}

			catch
			{
				await DisplayAlert("Error", "Check App permissions. ", "Ok");
				return;
			}
		}

		async void OnLandClicked(object sender, EventArgs e)
		{
			try
			{
				Land.IsVisible = false;
				LandBlue.IsVisible = true;

				House.IsVisible = true;
				HouseBlue.IsVisible = false;

				Apartment.IsVisible = true;
				ApartmentBlue.IsVisible = false;

				Building.IsVisible = true;
				BuildingBlue.IsVisible = false;

				Office.IsVisible = true;
				OfficeBlue.IsVisible = false;

				Commercial.IsVisible = true;
				CommercialBlue.IsVisible = false;



			}

			catch
			{
				await DisplayAlert("Error", "Check App permissions. ", "Ok");
				return;
			}
		}

		async void OnHouseClicked(object sender, EventArgs e)
		{
			try
			{
				Land.IsVisible = true;
				LandBlue.IsVisible = false;

				House.IsVisible = false;
				HouseBlue.IsVisible = true;

				Apartment.IsVisible = true;
				ApartmentBlue.IsVisible = false;

				Building.IsVisible = true;
				BuildingBlue.IsVisible = false;

				Office.IsVisible = true;
				OfficeBlue.IsVisible = false;

				Commercial.IsVisible = true;
				CommercialBlue.IsVisible = false;

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
				Land.IsVisible = true;
				LandBlue.IsVisible = false;

				House.IsVisible = true;
				HouseBlue.IsVisible = false;

				Apartment.IsVisible = false;
				ApartmentBlue.IsVisible = true;

				Building.IsVisible = true;
				BuildingBlue.IsVisible = false;

				Office.IsVisible = true;
				OfficeBlue.IsVisible = false;

				Commercial.IsVisible = true;
				CommercialBlue.IsVisible = false;

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
				Land.IsVisible = true;
				LandBlue.IsVisible = false;

				House.IsVisible = true;
				HouseBlue.IsVisible = false;

				Apartment.IsVisible = true;
				ApartmentBlue.IsVisible = false;

				Building.IsVisible = false;
				BuildingBlue.IsVisible = true;

				Office.IsVisible = true;
				OfficeBlue.IsVisible = false;

				Commercial.IsVisible = true;
				CommercialBlue.IsVisible = false;

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
				Land.IsVisible = true;
				LandBlue.IsVisible = false;

				House.IsVisible = true;
				HouseBlue.IsVisible = false;

				Apartment.IsVisible = true;
				ApartmentBlue.IsVisible = false;

				Building.IsVisible = true;
				BuildingBlue.IsVisible = false;

				Office.IsVisible = false;
				OfficeBlue.IsVisible = true;

				Commercial.IsVisible = true;
				CommercialBlue.IsVisible = false;

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
				Land.IsVisible = true;
				LandBlue.IsVisible = false;

				House.IsVisible = true;
				HouseBlue.IsVisible = false;

				Apartment.IsVisible = true;
				ApartmentBlue.IsVisible = false;

				Building.IsVisible = true;
				BuildingBlue.IsVisible = false;

				Office.IsVisible = true;
				OfficeBlue.IsVisible = false;

				Commercial.IsVisible = false;
				CommercialBlue.IsVisible = true;

			}

			catch
			{
				await DisplayAlert("Error", "Check App permissions. ", "Ok");
				return;
			}
		}
	}
}