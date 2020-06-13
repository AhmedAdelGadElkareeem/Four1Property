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
    public partial class AlQadsyiah : PopupPage
    {
        public AlQadsyiah()
        {
            InitializeComponent();
            if (Application.Current.Properties["Language"].ToString() == "Arabic")
            {
                this.FlowDirection = FlowDirection.RightToLeft;
                UpText.Text = "الرجاء اختيار المنطقة";

                Afaq.Text = "آفاق";
                AlShamiya.Text = "الشامية";
                Diwaniya.Text = "ديوانية";
                Hamza.Text = "حمزة";


            }
            else
            {
                this.FlowDirection = FlowDirection.LeftToRight;
                UpText.Text = "Please Select Area";

                Afaq.Text = "Afaq ";
                AlShamiya.Text = "Al - Shamiya";
                Diwaniya.Text = "Diwaniya";
                Hamza.Text = "Hamza";

            }
            if (Constantce.Area == "Afaq ") { Afaq.BackgroundColor = Color.FromHex("FF071D66"); Afaq.TextColor = Color.White; }
            else if (Constantce.Area == "Al - Shamiya") { AlShamiya.BackgroundColor = Color.FromHex("FF071D66"); AlShamiya.TextColor = Color.White; }
            else if (Constantce.Area == "Diwaniya") { Diwaniya.BackgroundColor = Color.FromHex("FF071D66"); Diwaniya.TextColor = Color.White; }
            else if (Constantce.Area == "Hamza") { Hamza.BackgroundColor = Color.FromHex("FF071D66"); Hamza.TextColor = Color.White; }

        }
        async void Afaq_Clicked(object sender, EventArgs e) { if (Afaq.BackgroundColor == Color.White) { Constantce.Area = "Afaq "; Constantce.AreaLang = Afaq.Text; Afaq.TextColor = Color.White; Afaq.BackgroundColor = Color.FromHex("FF071D66"); var existingPages = Navigation.NavigationStack.ToList(); Page page = existingPages.FirstOrDefault(); Navigation.InsertPageBefore(new Home(), page); Navigation.RemovePage(page); await PopupNavigation.Instance.PopAsync(); } else { Constantce.Area = "Area"; Afaq.BackgroundColor = Color.White; Afaq.TextColor = Color.FromHex("FF071D66"); } }
        async void AlShamiya_Clicked(object sender, EventArgs e) { if (AlShamiya.BackgroundColor == Color.White) { Constantce.Area = "Al - Shamiya"; Constantce.AreaLang = AlShamiya.Text; AlShamiya.TextColor = Color.White; AlShamiya.BackgroundColor = Color.FromHex("FF071D66"); var existingPages = Navigation.NavigationStack.ToList(); Page page = existingPages.FirstOrDefault(); Navigation.InsertPageBefore(new Home(), page); Navigation.RemovePage(page); await PopupNavigation.Instance.PopAsync(); } else { Constantce.Area = "Area"; AlShamiya.BackgroundColor = Color.White; AlShamiya.TextColor = Color.FromHex("FF071D66"); } }
        async void Diwaniya_Clicked(object sender, EventArgs e) { if (Diwaniya.BackgroundColor == Color.White) { Constantce.Area = "Diwaniya"; Constantce.AreaLang = Diwaniya.Text; Diwaniya.TextColor = Color.White; Diwaniya.BackgroundColor = Color.FromHex("FF071D66"); var existingPages = Navigation.NavigationStack.ToList(); Page page = existingPages.FirstOrDefault(); Navigation.InsertPageBefore(new Home(), page); Navigation.RemovePage(page); await PopupNavigation.Instance.PopAsync(); } else { Constantce.Area = "Area"; Diwaniya.BackgroundColor = Color.White; Diwaniya.TextColor = Color.FromHex("FF071D66"); } }
        async void Hamza_Clicked(object sender, EventArgs e) { if (Hamza.BackgroundColor == Color.White) { Constantce.Area = "Hamza"; Constantce.AreaLang = Hamza.Text; Hamza.TextColor = Color.White; Hamza.BackgroundColor = Color.FromHex("FF071D66"); var existingPages = Navigation.NavigationStack.ToList(); Page page = existingPages.FirstOrDefault(); Navigation.InsertPageBefore(new Home(), page); Navigation.RemovePage(page); await PopupNavigation.Instance.PopAsync(); } else { Constantce.Area = "Area"; Hamza.BackgroundColor = Color.White; Hamza.TextColor = Color.FromHex("FF071D66"); } }

    }
}