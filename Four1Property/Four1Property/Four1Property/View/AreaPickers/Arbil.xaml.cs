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
    public partial class Arbil : PopupPage
    {
        public Arbil()
        {
            InitializeComponent();
            if (Application.Current.Properties["Language"].ToString() == "Arabic")
            {
                this.FlowDirection = FlowDirection.RightToLeft;
                UpText.Text = "الرجاء اختيار المنطقة";
                Erbil.Text = "أربيل";
                Koisanjaq.Text = "كويسانجاق";
                Shaqlawa.Text = "شقلاوة";
                Soran.Text = "سوران";
                Makhmur.Text = "مخمور";
                Mergasur.Text = "مرقاسور";
                Choman.Text = "شومان";

            }
            else
            {
                this.FlowDirection = FlowDirection.LeftToRight;
                UpText.Text = "Please Select Area";

                Erbil.Text = "Erbil";
                Koisanjaq.Text = "Koisanjaq";
                Shaqlawa.Text = "Shaqlawa";
                Soran.Text = "Soran ";
                Makhmur.Text = "Makhmur";
                Mergasur.Text = "Mergasur ";
                Choman.Text = "Choman ";

            }
            if (Constantce.Area == "Erbil") { Erbil.BackgroundColor = Color.FromHex("FF071D66"); Erbil.TextColor = Color.White; }
            else if (Constantce.Area == "Koisanjaq") { Koisanjaq.BackgroundColor = Color.FromHex("FF071D66"); Koisanjaq.TextColor = Color.White; }
            else if (Constantce.Area == "Shaqlawa") { Shaqlawa.BackgroundColor = Color.FromHex("FF071D66"); Shaqlawa.TextColor = Color.White; }
            else if (Constantce.Area == "Soran ") { Soran.BackgroundColor = Color.FromHex("FF071D66"); Soran.TextColor = Color.White; }
            else if (Constantce.Area == "Makhmur") { Makhmur.BackgroundColor = Color.FromHex("FF071D66"); Makhmur.TextColor = Color.White; }
            else if (Constantce.Area == "Mergasur ") { Mergasur.BackgroundColor = Color.FromHex("FF071D66"); Mergasur.TextColor = Color.White; }
            else if (Constantce.Area == "Choman ") { Choman.BackgroundColor = Color.FromHex("FF071D66"); Choman.TextColor = Color.White; }

        }
        async void Erbil_Clicked(object sender, EventArgs e) { if (Erbil.BackgroundColor == Color.White) { Constantce.Area = "Erbil"; Constantce.AreaLang = Erbil.Text; Erbil.TextColor = Color.White; Erbil.BackgroundColor = Color.FromHex("FF071D66"); var existingPages = Navigation.NavigationStack.ToList(); await Navigation.PushAsync(new Home()); foreach (var page in existingPages) { Navigation.RemovePage(page); } await Task.Delay(80); await PopupNavigation.Instance.PopAsync(); } else { Constantce.Area = "Area"; Erbil.BackgroundColor = Color.White; Erbil.TextColor = Color.FromHex("FF071D66"); } }
        async void Koisanjaq_Clicked(object sender, EventArgs e) { if (Koisanjaq.BackgroundColor == Color.White) { Constantce.Area = "Koisanjaq"; Constantce.AreaLang = Koisanjaq.Text; Koisanjaq.TextColor = Color.White; Koisanjaq.BackgroundColor = Color.FromHex("FF071D66"); var existingPages = Navigation.NavigationStack.ToList(); await Navigation.PushAsync(new Home()); foreach (var page in existingPages) { Navigation.RemovePage(page); } await Task.Delay(80); await PopupNavigation.Instance.PopAsync(); } else { Constantce.Area = "Area"; Koisanjaq.BackgroundColor = Color.White; Koisanjaq.TextColor = Color.FromHex("FF071D66"); } }
        async void Shaqlawa_Clicked(object sender, EventArgs e) { if (Shaqlawa.BackgroundColor == Color.White) { Constantce.Area = "Shaqlawa"; Constantce.AreaLang = Shaqlawa.Text; Shaqlawa.TextColor = Color.White; Shaqlawa.BackgroundColor = Color.FromHex("FF071D66"); var existingPages = Navigation.NavigationStack.ToList(); await Navigation.PushAsync(new Home()); foreach (var page in existingPages) { Navigation.RemovePage(page); } await Task.Delay(80); await PopupNavigation.Instance.PopAsync(); } else { Constantce.Area = "Area"; Shaqlawa.BackgroundColor = Color.White; Shaqlawa.TextColor = Color.FromHex("FF071D66"); } }
        async void Soran_Clicked(object sender, EventArgs e) { if (Soran.BackgroundColor == Color.White) { Constantce.Area = "Soran "; Constantce.AreaLang = Soran.Text; Soran.TextColor = Color.White; Soran.BackgroundColor = Color.FromHex("FF071D66"); var existingPages = Navigation.NavigationStack.ToList(); await Navigation.PushAsync(new Home()); foreach (var page in existingPages) { Navigation.RemovePage(page); } await Task.Delay(80); await PopupNavigation.Instance.PopAsync(); } else { Constantce.Area = "Area"; Soran.BackgroundColor = Color.White; Soran.TextColor = Color.FromHex("FF071D66"); } }
        async void Makhmur_Clicked(object sender, EventArgs e) { if (Makhmur.BackgroundColor == Color.White) { Constantce.Area = "Makhmur"; Constantce.AreaLang = Makhmur.Text; Makhmur.TextColor = Color.White; Makhmur.BackgroundColor = Color.FromHex("FF071D66"); var existingPages = Navigation.NavigationStack.ToList(); await Navigation.PushAsync(new Home()); foreach (var page in existingPages) { Navigation.RemovePage(page); } await Task.Delay(80); await PopupNavigation.Instance.PopAsync(); } else { Constantce.Area = "Area"; Makhmur.BackgroundColor = Color.White; Makhmur.TextColor = Color.FromHex("FF071D66"); } }
        async void Mergasur_Clicked(object sender, EventArgs e) { if (Mergasur.BackgroundColor == Color.White) { Constantce.Area = "Mergasur "; Constantce.AreaLang = Mergasur.Text; Mergasur.TextColor = Color.White; Mergasur.BackgroundColor = Color.FromHex("FF071D66"); var existingPages = Navigation.NavigationStack.ToList(); await Navigation.PushAsync(new Home()); foreach (var page in existingPages) { Navigation.RemovePage(page); } await Task.Delay(80); await PopupNavigation.Instance.PopAsync(); } else { Constantce.Area = "Area"; Mergasur.BackgroundColor = Color.White; Mergasur.TextColor = Color.FromHex("FF071D66"); } }
        async void Choman_Clicked(object sender, EventArgs e) { if (Choman.BackgroundColor == Color.White) { Constantce.Area = "Choman "; Constantce.AreaLang = Choman.Text; Choman.TextColor = Color.White; Choman.BackgroundColor = Color.FromHex("FF071D66"); var existingPages = Navigation.NavigationStack.ToList(); await Navigation.PushAsync(new Home()); foreach (var page in existingPages) { Navigation.RemovePage(page); } await Task.Delay(80); await PopupNavigation.Instance.PopAsync(); } else { Constantce.Area = "Area"; Choman.BackgroundColor = Color.White; Choman.TextColor = Color.FromHex("FF071D66"); } }

    }
}