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
    public partial class AlAnbar : PopupPage
    {
        public AlAnbar()
        {
            InitializeComponent();
            if (Application.Current.Properties["Language"].ToString() == "Arabic")
            {
                this.FlowDirection = FlowDirection.RightToLeft;
                UpText.Text = "الرجاء اختيار المنطقة";

                AlKaim.Text = "القيم";
                AlRutba.Text = "الرتبة";
                Anah.Text = "عانة";
                Falluja.Text = "الفلوجة";
                Haditha.Text = "حديثة";
                Heet.Text = "هيت";
                Ramadi.Text = "رمادي";
                Rawah.Text = "رواح";

            }
            else
            {
                this.FlowDirection = FlowDirection.LeftToRight;
                UpText.Text = "Please Select Area";

                AlKaim.Text = "Al - Ka'im";
                AlRutba.Text = "Al - Rutba";
                Anah.Text = "Anah";
                Falluja.Text = "Falluja";
                Haditha.Text = "Haditha";
                Heet.Text = "Hīt ";
                Ramadi.Text = "Ramadi ";
                Rawah.Text = "Rawah ";

            }
            if (Constantce.Area == "Al - Ka'im") { AlKaim.BackgroundColor = Color.FromHex("FF071D66"); AlKaim.TextColor = Color.White; }
            else if (Constantce.Area == "Al - Rutba") { AlRutba.BackgroundColor = Color.FromHex("FF071D66"); AlRutba.TextColor = Color.White; }
            else if (Constantce.Area == "Anah") { Anah.BackgroundColor = Color.FromHex("FF071D66"); Anah.TextColor = Color.White; }
            else if (Constantce.Area == "Falluja") { Falluja.BackgroundColor = Color.FromHex("FF071D66"); Falluja.TextColor = Color.White; }
            else if (Constantce.Area == "Haditha") { Haditha.BackgroundColor = Color.FromHex("FF071D66"); Haditha.TextColor = Color.White; }
            else if (Constantce.Area == "Hīt ") { Heet.BackgroundColor = Color.FromHex("FF071D66"); Heet.TextColor = Color.White; }
            else if (Constantce.Area == "Ramadi ") { Ramadi.BackgroundColor = Color.FromHex("FF071D66"); Ramadi.TextColor = Color.White; }
            else if (Constantce.Area == "Rawah ") { Rawah.BackgroundColor = Color.FromHex("FF071D66"); Rawah.TextColor = Color.White; }

        }
        async void AlKaim_Clicked(object sender, EventArgs e){if (AlKaim.BackgroundColor == Color.White){Constantce.Area = "Al - Ka'im"; Constantce.AreaLang = AlKaim.Text; AlKaim.TextColor = Color.White; AlKaim.BackgroundColor = Color.FromHex("FF071D66"); var existingPages = Navigation.NavigationStack.ToList(); Page page = existingPages.FirstOrDefault(); Navigation.InsertPageBefore(new Home(), page); Navigation.RemovePage(page); await PopupNavigation.Instance.PopAsync();}else {  Constantce.Area = "Area"; AlKaim.BackgroundColor = Color.White; AlKaim.TextColor = Color.FromHex("FF071D66"); }}
        async void AlRutba_Clicked(object sender, EventArgs e) { if (AlRutba.BackgroundColor == Color.White) { Constantce.Area = "Al - Rutba"; Constantce.AreaLang = AlRutba.Text; AlRutba.TextColor = Color.White; AlRutba.BackgroundColor = Color.FromHex("FF071D66"); var existingPages = Navigation.NavigationStack.ToList(); Page page = existingPages.FirstOrDefault(); Navigation.InsertPageBefore(new Home(), page); Navigation.RemovePage(page); await PopupNavigation.Instance.PopAsync(); } else {  Constantce.Area = "Area"; AlRutba.BackgroundColor = Color.White; AlRutba.TextColor = Color.FromHex("FF071D66"); } }
        async void Anah_Clicked(object sender, EventArgs e) { if (Anah.BackgroundColor == Color.White) { Constantce.Area = "Anah"; Constantce.AreaLang = Anah.Text; Anah.TextColor = Color.White; Anah.BackgroundColor = Color.FromHex("FF071D66"); var existingPages = Navigation.NavigationStack.ToList(); Page page = existingPages.FirstOrDefault(); Navigation.InsertPageBefore(new Home(), page); Navigation.RemovePage(page); await PopupNavigation.Instance.PopAsync(); } else {  Constantce.Area = "Area"; Anah.BackgroundColor = Color.White; Anah.TextColor = Color.FromHex("FF071D66"); } }
        async void Falluja_Clicked(object sender, EventArgs e) { if (Falluja.BackgroundColor == Color.White) { Constantce.Area = "Falluja"; Constantce.AreaLang = Falluja.Text; Falluja.TextColor = Color.White; Falluja.BackgroundColor = Color.FromHex("FF071D66"); var existingPages = Navigation.NavigationStack.ToList(); Page page = existingPages.FirstOrDefault(); Navigation.InsertPageBefore(new Home(), page); Navigation.RemovePage(page); await PopupNavigation.Instance.PopAsync(); } else {  Constantce.Area = "Area"; Falluja.BackgroundColor = Color.White; Falluja.TextColor = Color.FromHex("FF071D66"); } }
        async void Haditha_Clicked(object sender, EventArgs e) { if (Haditha.BackgroundColor == Color.White) { Constantce.Area = "Haditha"; Constantce.AreaLang = Haditha.Text; Haditha.TextColor = Color.White; Haditha.BackgroundColor = Color.FromHex("FF071D66"); var existingPages = Navigation.NavigationStack.ToList(); Page page = existingPages.FirstOrDefault(); Navigation.InsertPageBefore(new Home(), page); Navigation.RemovePage(page); await PopupNavigation.Instance.PopAsync(); } else {  Constantce.Area = "Area"; Haditha.BackgroundColor = Color.White; Haditha.TextColor = Color.FromHex("FF071D66"); } }
        async void Heet_Clicked(object sender, EventArgs e) { if (Heet.BackgroundColor == Color.White) { Constantce.Area = "Hīt "; Constantce.AreaLang = Heet.Text; Heet.TextColor = Color.White; Heet.BackgroundColor = Color.FromHex("FF071D66"); var existingPages = Navigation.NavigationStack.ToList(); Page page = existingPages.FirstOrDefault(); Navigation.InsertPageBefore(new Home(), page); Navigation.RemovePage(page); await PopupNavigation.Instance.PopAsync(); } else {  Constantce.Area = "Area"; Heet.BackgroundColor = Color.White; Heet.TextColor = Color.FromHex("FF071D66"); } }
        async void Ramadi_Clicked(object sender, EventArgs e) { if (Ramadi.BackgroundColor == Color.White) { Constantce.Area = "Ramadi "; Constantce.AreaLang = Ramadi.Text; Ramadi.TextColor = Color.White; Ramadi.BackgroundColor = Color.FromHex("FF071D66"); var existingPages = Navigation.NavigationStack.ToList(); Page page = existingPages.FirstOrDefault(); Navigation.InsertPageBefore(new Home(), page); Navigation.RemovePage(page); await PopupNavigation.Instance.PopAsync(); } else {  Constantce.Area = "Area"; Ramadi.BackgroundColor = Color.White; Ramadi.TextColor = Color.FromHex("FF071D66"); } }
        async void Rawah_Clicked(object sender, EventArgs e) { if (Rawah.BackgroundColor == Color.White) { Constantce.Area = "Rawah "; Constantce.AreaLang = Rawah.Text; Rawah.TextColor = Color.White; Rawah.BackgroundColor = Color.FromHex("FF071D66"); var existingPages = Navigation.NavigationStack.ToList(); Page page = existingPages.FirstOrDefault(); Navigation.InsertPageBefore(new Home(), page); Navigation.RemovePage(page); await PopupNavigation.Instance.PopAsync(); } else {  Constantce.Area = "Area"; Rawah.BackgroundColor = Color.White; Rawah.TextColor = Color.FromHex("FF071D66"); } }

    }
}