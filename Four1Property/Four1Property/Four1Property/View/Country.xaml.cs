using Four1Property.Helper;
using Four1Property.View;
using Rg.Plugins.Popup.Pages;
using Rg.Plugins.Popup.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace View
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Country : PopupPage
    {
        public Country()
        {
            InitializeComponent();
            

            if (Application.Current.Properties["Language"].ToString() == "Arabic")
            {
                this.FlowDirection = FlowDirection.RightToLeft;
                Jordan.Text = "الاردن";
                Iraq.Text = "العراق";
                UpText.Text = "الرجاء اختيار الدولة";
            }
            else
            {
                this.FlowDirection = FlowDirection.LeftToRight;
                Jordan.Text = "Jordan";
                Iraq.Text = "Iraq";
                UpText.Text = "Please Select Country";
            }
            if (Constantce.Country == "Jordan")
            {
                Jordan.TextColor = Color.White;
                Jordan.BackgroundColor = Color.FromHex("FF071D66");
            }
            else if (Constantce.Country == "Iraq")
            {
                Iraq.TextColor = Color.White;
                Iraq.BackgroundColor = Color.FromHex("FF071D66");
            }
        }

        async void Jordan_Clicked(object sender, EventArgs e)
        {
            if (Jordan.BackgroundColor == Color.White)
            {
                Constantce.Country = "Jordan";
                Constantce.City = "City";
                Constantce.Area = "Area";
                Constantce.CountryLang = Jordan.Text;

                Jordan.TextColor = Color.White;
                Jordan.BackgroundColor = Color.FromHex("FF071D66");
                var existingPages = Navigation.NavigationStack.ToList();
                Page page = existingPages.FirstOrDefault();

                Navigation.InsertPageBefore(new Home(), page);
                Navigation.RemovePage(page);
                await PopupNavigation.Instance.PopAsync();
            }
            else
            {
                Constantce.Country = "Country";
                Constantce.City = "City";
                Constantce.Area = "Area";
                Jordan.BackgroundColor = Color.White;
                Jordan.TextColor = Color.FromHex("FF071D66");
            }


        }

        async void Iraq_Clicked(object sender, EventArgs e)
        {
            if (Iraq.BackgroundColor == Color.White)
            {
                Constantce.Country = "Iraq";
                Constantce.City = "City";
                Constantce.Area = "Area";
                Constantce.CountryLang = Iraq.Text;

                Iraq.TextColor = Color.White;
                Iraq.BackgroundColor = Color.FromHex("FF071D66");
                var existingPages = Navigation.NavigationStack.ToList();
                Page page = existingPages.FirstOrDefault();

                Navigation.InsertPageBefore(new Home(), page);
                Navigation.RemovePage(page);
                await PopupNavigation.Instance.PopAsync();
            }
            else
            {
                Constantce.Country = "Country";
                Constantce.City = "City";
                Constantce.Area = "Area";
                Iraq.BackgroundColor = Color.White;
                Iraq.TextColor = Color.FromHex("FF071D66");
            }
        }

    }
}