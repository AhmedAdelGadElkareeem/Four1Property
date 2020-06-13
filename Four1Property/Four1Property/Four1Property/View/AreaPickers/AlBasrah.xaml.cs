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
    public partial class AlBasrah : PopupPage
    {
        public AlBasrah()
        {
            InitializeComponent();
            if (Application.Current.Properties["Language"].ToString() == "Arabic")
            {
                this.FlowDirection = FlowDirection.RightToLeft;
                UpText.Text = "الرجاء اختيار المنطقة";

                Akre.Text = "عكرة";
                AlBaaj.Text = "البعاج";
                AlHamdaniya.Text = "الحمدانية";
                Hatra.Text = "حطرا";
                Mosul.Text = "موصل";
                Shekhan.Text = "عين صفني";
                Sinjar.Text = "سنجار";
                TelAfar.Text = "تل عفار";
                TelKeppe.Text = "تل كبي";

            }
            else
            {
                this.FlowDirection = FlowDirection.LeftToRight;
                UpText.Text = "Please Select Area";

                Akre.Text = "Akre ";
                AlBaaj.Text = "Al - Ba'aj";
                AlHamdaniya.Text = "Al - Hamdaniya ";
                Hatra.Text = "Hatra ";
                Mosul.Text = "Mosul";
                Shekhan.Text = "Shekhan ";
                Sinjar.Text = "Sinjar";
                TelAfar.Text = "Tel Afar";
                TelKeppe.Text = "Tel Keppe ";

            }
            if (Constantce.Area == "Akre ") { Akre.BackgroundColor = Color.FromHex("FF071D66"); Akre.TextColor = Color.White; }
            else if (Constantce.Area == "Al - Ba'aj") { AlBaaj.BackgroundColor = Color.FromHex("FF071D66"); AlBaaj.TextColor = Color.White; }
            else if (Constantce.Area == "Al - Hamdaniya ") { AlHamdaniya.BackgroundColor = Color.FromHex("FF071D66"); AlHamdaniya.TextColor = Color.White; }
            else if (Constantce.Area == "Hatra ") { Hatra.BackgroundColor = Color.FromHex("FF071D66"); Hatra.TextColor = Color.White; }
            else if (Constantce.Area == "Mosul") { Mosul.BackgroundColor = Color.FromHex("FF071D66"); Mosul.TextColor = Color.White; }
            else if (Constantce.Area == "Shekhan ") { Shekhan.BackgroundColor = Color.FromHex("FF071D66"); Shekhan.TextColor = Color.White; }
            else if (Constantce.Area == "Sinjar") { Sinjar.BackgroundColor = Color.FromHex("FF071D66"); Sinjar.TextColor = Color.White; }
            else if (Constantce.Area == "Tel Afar") { TelAfar.BackgroundColor = Color.FromHex("FF071D66"); TelAfar.TextColor = Color.White; }
            else if (Constantce.Area == "Tel Keppe ") { TelKeppe.BackgroundColor = Color.FromHex("FF071D66"); TelKeppe.TextColor = Color.White; }


        }
        async void Akre_Clicked(object sender, EventArgs e) { if (Akre.BackgroundColor == Color.White) { Constantce.Area = "Akre "; Constantce.AreaLang = Akre.Text; Akre.TextColor = Color.White; Akre.BackgroundColor = Color.FromHex("FF071D66"); var existingPages = Navigation.NavigationStack.ToList(); Page page = existingPages.FirstOrDefault(); Navigation.InsertPageBefore(new Home(), page); Navigation.RemovePage(page); await PopupNavigation.Instance.PopAsync(); } else { Constantce.Area = "Area"; Akre.BackgroundColor = Color.White; Akre.TextColor = Color.FromHex("FF071D66"); } }
        async void AlBaaj_Clicked(object sender, EventArgs e) { if (AlBaaj.BackgroundColor == Color.White) { Constantce.Area = "Al - Ba'aj"; Constantce.AreaLang = AlBaaj.Text; AlBaaj.TextColor = Color.White; AlBaaj.BackgroundColor = Color.FromHex("FF071D66"); var existingPages = Navigation.NavigationStack.ToList(); Page page = existingPages.FirstOrDefault(); Navigation.InsertPageBefore(new Home(), page); Navigation.RemovePage(page); await PopupNavigation.Instance.PopAsync(); } else { Constantce.Area = "Area"; AlBaaj.BackgroundColor = Color.White; AlBaaj.TextColor = Color.FromHex("FF071D66"); } }
        async void AlHamdaniya_Clicked(object sender, EventArgs e) { if (AlHamdaniya.BackgroundColor == Color.White) { Constantce.Area = "Al - Hamdaniya "; Constantce.AreaLang = AlHamdaniya.Text; AlHamdaniya.TextColor = Color.White; AlHamdaniya.BackgroundColor = Color.FromHex("FF071D66"); var existingPages = Navigation.NavigationStack.ToList(); Page page = existingPages.FirstOrDefault(); Navigation.InsertPageBefore(new Home(), page); Navigation.RemovePage(page); await PopupNavigation.Instance.PopAsync(); } else { Constantce.Area = "Area"; AlHamdaniya.BackgroundColor = Color.White; AlHamdaniya.TextColor = Color.FromHex("FF071D66"); } }
        async void Hatra_Clicked(object sender, EventArgs e) { if (Hatra.BackgroundColor == Color.White) { Constantce.Area = "Hatra "; Constantce.AreaLang = Hatra.Text; Hatra.TextColor = Color.White; Hatra.BackgroundColor = Color.FromHex("FF071D66"); var existingPages = Navigation.NavigationStack.ToList(); Page page = existingPages.FirstOrDefault(); Navigation.InsertPageBefore(new Home(), page); Navigation.RemovePage(page); await PopupNavigation.Instance.PopAsync(); } else { Constantce.Area = "Area"; Hatra.BackgroundColor = Color.White; Hatra.TextColor = Color.FromHex("FF071D66"); } }
        async void Mosul_Clicked(object sender, EventArgs e) { if (Mosul.BackgroundColor == Color.White) { Constantce.Area = "Mosul"; Constantce.AreaLang = Mosul.Text; Mosul.TextColor = Color.White; Mosul.BackgroundColor = Color.FromHex("FF071D66"); var existingPages = Navigation.NavigationStack.ToList(); Page page = existingPages.FirstOrDefault(); Navigation.InsertPageBefore(new Home(), page); Navigation.RemovePage(page); await PopupNavigation.Instance.PopAsync(); } else { Constantce.Area = "Area"; Mosul.BackgroundColor = Color.White; Mosul.TextColor = Color.FromHex("FF071D66"); } }
        async void Shekhan_Clicked(object sender, EventArgs e) { if (Shekhan.BackgroundColor == Color.White) { Constantce.Area = "Shekhan "; Constantce.AreaLang = Shekhan.Text; Shekhan.TextColor = Color.White; Shekhan.BackgroundColor = Color.FromHex("FF071D66"); var existingPages = Navigation.NavigationStack.ToList(); Page page = existingPages.FirstOrDefault(); Navigation.InsertPageBefore(new Home(), page); Navigation.RemovePage(page); await PopupNavigation.Instance.PopAsync(); } else { Constantce.Area = "Area"; Shekhan.BackgroundColor = Color.White; Shekhan.TextColor = Color.FromHex("FF071D66"); } }
        async void Sinjar_Clicked(object sender, EventArgs e) { if (Sinjar.BackgroundColor == Color.White) { Constantce.Area = "Sinjar"; Constantce.AreaLang = Sinjar.Text; Sinjar.TextColor = Color.White; Sinjar.BackgroundColor = Color.FromHex("FF071D66"); var existingPages = Navigation.NavigationStack.ToList(); Page page = existingPages.FirstOrDefault(); Navigation.InsertPageBefore(new Home(), page); Navigation.RemovePage(page); await PopupNavigation.Instance.PopAsync(); } else { Constantce.Area = "Area"; Sinjar.BackgroundColor = Color.White; Sinjar.TextColor = Color.FromHex("FF071D66"); } }
        async void TelAfar_Clicked(object sender, EventArgs e) { if (TelAfar.BackgroundColor == Color.White) { Constantce.Area = "Tel Afar"; Constantce.AreaLang = TelAfar.Text; TelAfar.TextColor = Color.White; TelAfar.BackgroundColor = Color.FromHex("FF071D66"); var existingPages = Navigation.NavigationStack.ToList(); Page page = existingPages.FirstOrDefault(); Navigation.InsertPageBefore(new Home(), page); Navigation.RemovePage(page); await PopupNavigation.Instance.PopAsync(); } else { Constantce.Area = "Area"; TelAfar.BackgroundColor = Color.White; TelAfar.TextColor = Color.FromHex("FF071D66"); } }
        async void TelKeppe_Clicked(object sender, EventArgs e) { if (TelKeppe.BackgroundColor == Color.White) { Constantce.Area = "Tel Keppe "; Constantce.AreaLang = TelKeppe.Text; TelKeppe.TextColor = Color.White; TelKeppe.BackgroundColor = Color.FromHex("FF071D66"); var existingPages = Navigation.NavigationStack.ToList(); Page page = existingPages.FirstOrDefault(); Navigation.InsertPageBefore(new Home(), page); Navigation.RemovePage(page); await PopupNavigation.Instance.PopAsync(); } else { Constantce.Area = "Area"; TelKeppe.BackgroundColor = Color.White; TelKeppe.TextColor = Color.FromHex("FF071D66"); } }

    }
}