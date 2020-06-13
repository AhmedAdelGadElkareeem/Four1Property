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
    public partial class Diyalla : PopupPage
    {
        public Diyalla()
        {
            InitializeComponent();
            if (Application.Current.Properties["Language"].ToString() == "Arabic")
            {
                this.FlowDirection = FlowDirection.RightToLeft;
                UpText.Text = "الرجاء اختيار المنطقة";

                AlKhalis.Text = "الخالص";
                AlMuqdadiya.Text = "المقدادية";
                Baladrooz.Text = "بلدروز";
                Baquba.Text = "بعقوبا";
                Khanaqin.Text = "خناقين";
                Kifri.Text = "كفر";

            }
            else
            {
                this.FlowDirection = FlowDirection.LeftToRight;
                AlKhalis.Text = "Al - Khalis ";
                UpText.Text = "Please Select Area";

                AlMuqdadiya.Text = "Al - Muqdadiya ";
                Baladrooz.Text = "Baladrooz ";
                Baquba.Text = "Ba'quba ";
                Khanaqin.Text = "Khanaqin ";
                Kifri.Text = "Kifri ";

            }
            if (Constantce.Area == "Al - Khalis ") { AlKhalis.BackgroundColor = Color.FromHex("FF071D66"); AlKhalis.TextColor = Color.White; }
            else if (Constantce.Area == "Al - Muqdadiya ") { AlMuqdadiya.BackgroundColor = Color.FromHex("FF071D66"); AlMuqdadiya.TextColor = Color.White; }
            else if (Constantce.Area == "Baladrooz ") { Baladrooz.BackgroundColor = Color.FromHex("FF071D66"); Baladrooz.TextColor = Color.White; }
            else if (Constantce.Area == "Ba'quba ") { Baquba.BackgroundColor = Color.FromHex("FF071D66"); Baquba.TextColor = Color.White; }
            else if (Constantce.Area == "Khanaqin ") { Khanaqin.BackgroundColor = Color.FromHex("FF071D66"); Khanaqin.TextColor = Color.White; }
            else if (Constantce.Area == "Kifri ") { Kifri.BackgroundColor = Color.FromHex("FF071D66"); Kifri.TextColor = Color.White; }

        }
        async void AlKhalis_Clicked(object sender, EventArgs e) { if (AlKhalis.BackgroundColor == Color.White) { Constantce.Area = "Al - Khalis "; Constantce.AreaLang = AlKhalis.Text; AlKhalis.TextColor = Color.White; AlKhalis.BackgroundColor = Color.FromHex("FF071D66"); var existingPages = Navigation.NavigationStack.ToList(); Page page = existingPages.FirstOrDefault(); Navigation.InsertPageBefore(new Home(), page); Navigation.RemovePage(page); await PopupNavigation.Instance.PopAsync(); } else { Constantce.Area = "Area"; AlKhalis.BackgroundColor = Color.White; AlKhalis.TextColor = Color.FromHex("FF071D66"); } }
        async void AlMuqdadiya_Clicked(object sender, EventArgs e) { if (AlMuqdadiya.BackgroundColor == Color.White) { Constantce.Area = "Al - Muqdadiya "; Constantce.AreaLang = AlMuqdadiya.Text; AlMuqdadiya.TextColor = Color.White; AlMuqdadiya.BackgroundColor = Color.FromHex("FF071D66"); var existingPages = Navigation.NavigationStack.ToList(); Page page = existingPages.FirstOrDefault(); Navigation.InsertPageBefore(new Home(), page); Navigation.RemovePage(page); await PopupNavigation.Instance.PopAsync(); } else { Constantce.Area = "Area"; AlMuqdadiya.BackgroundColor = Color.White; AlMuqdadiya.TextColor = Color.FromHex("FF071D66"); } }
        async void Baladrooz_Clicked(object sender, EventArgs e) { if (Baladrooz.BackgroundColor == Color.White) { Constantce.Area = "Baladrooz "; Constantce.AreaLang = Baladrooz.Text; Baladrooz.TextColor = Color.White; Baladrooz.BackgroundColor = Color.FromHex("FF071D66"); var existingPages = Navigation.NavigationStack.ToList(); Page page = existingPages.FirstOrDefault(); Navigation.InsertPageBefore(new Home(), page); Navigation.RemovePage(page); await PopupNavigation.Instance.PopAsync(); } else { Constantce.Area = "Area"; Baladrooz.BackgroundColor = Color.White; Baladrooz.TextColor = Color.FromHex("FF071D66"); } }
        async void Baquba_Clicked(object sender, EventArgs e) { if (Baquba.BackgroundColor == Color.White) { Constantce.Area = "Ba'quba "; Constantce.AreaLang = Baquba.Text; Baquba.TextColor = Color.White; Baquba.BackgroundColor = Color.FromHex("FF071D66"); var existingPages = Navigation.NavigationStack.ToList(); Page page = existingPages.FirstOrDefault(); Navigation.InsertPageBefore(new Home(), page); Navigation.RemovePage(page); await PopupNavigation.Instance.PopAsync(); } else { Constantce.Area = "Area"; Baquba.BackgroundColor = Color.White; Baquba.TextColor = Color.FromHex("FF071D66"); } }
        async void Khanaqin_Clicked(object sender, EventArgs e) { if (Khanaqin.BackgroundColor == Color.White) { Constantce.Area = "Khanaqin "; Constantce.AreaLang = Khanaqin.Text; Khanaqin.TextColor = Color.White; Khanaqin.BackgroundColor = Color.FromHex("FF071D66"); var existingPages = Navigation.NavigationStack.ToList(); Page page = existingPages.FirstOrDefault(); Navigation.InsertPageBefore(new Home(), page); Navigation.RemovePage(page); await PopupNavigation.Instance.PopAsync(); } else { Constantce.Area = "Area"; Khanaqin.BackgroundColor = Color.White; Khanaqin.TextColor = Color.FromHex("FF071D66"); } }
        async void Kifri_Clicked(object sender, EventArgs e) { if (Kifri.BackgroundColor == Color.White) { Constantce.Area = "Kifri "; Constantce.AreaLang = Kifri.Text; Kifri.TextColor = Color.White; Kifri.BackgroundColor = Color.FromHex("FF071D66"); var existingPages = Navigation.NavigationStack.ToList(); Page page = existingPages.FirstOrDefault(); Navigation.InsertPageBefore(new Home(), page); Navigation.RemovePage(page); await PopupNavigation.Instance.PopAsync(); } else { Constantce.Area = "Area"; Kifri.BackgroundColor = Color.White; Kifri.TextColor = Color.FromHex("FF071D66"); } }

    }
}