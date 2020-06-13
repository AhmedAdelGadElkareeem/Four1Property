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
    public partial class Baghdad : PopupPage
    {
        public Baghdad()
        {
            InitializeComponent();
            if (Application.Current.Properties["Language"].ToString() == "Arabic")
            {
                this.FlowDirection = FlowDirection.RightToLeft;
                UpText.Text = "الرجاء اختيار المنطقة";

                Rusafa.Text = "رصافة";
                Adhamiyah.Text = "الاعظمية";
                SadrCity.Text = "الصدر";
                Nissan.Text = "بغداد الجديدة";
                Karadah.Text = "الكرادة";
                AlZafraniya.Text = "الزعفرانية";
                Karkh.Text = "كرخ";
                Kadhimyah.Text = "كاظمية";
                Mansour.Text = "المنصور";
                AlRashid.Text = "الرشيد";
                AbuGhraib.Text = "أبو غريب";
                AlIstiqlal.Text = "الاستقلال";
                AlMadain.Text = "المدائن";
                Mahmudiya.Text = "محمودية";
                Taji.Text = "تاجي";
                AlTarmia.Text = "الطرمية";



            }
            else
            {
                this.FlowDirection = FlowDirection.LeftToRight;
                UpText.Text = "Please Select Area";

                Rusafa.Text = "Rusafa";
                Adhamiyah.Text = "Adhamiyah";
                SadrCity.Text = "Sadr City";
                Nissan.Text = "9 Nissan";
                Karadah.Text = "Karadah";
                AlZafraniya.Text = "Al - Za'franiya";
                Karkh.Text = "Karkh";
                Kadhimyah.Text = "Kadhimyah";
                Mansour.Text = "Mansour";
                AlRashid.Text = "Al Rashid";
                AbuGhraib.Text = "Abu Ghraib";
                AlIstiqlal.Text = "Al Istiqlal ";
                AlMadain.Text = "Al - Mada'in ";
                Mahmudiya.Text = "Mahmudiya";
                Taji.Text = "Taji ";
                AlTarmia.Text = "Al Tarmia ";



            }
            if (Constantce.Area == "Rusafa") { Rusafa.BackgroundColor = Color.FromHex("FF071D66"); Rusafa.TextColor = Color.White; }
            else if (Constantce.Area == "Adhamiyah") { Adhamiyah.BackgroundColor = Color.FromHex("FF071D66"); Adhamiyah.TextColor = Color.White; }
            else if (Constantce.Area == "Sadr City") { SadrCity.BackgroundColor = Color.FromHex("FF071D66"); SadrCity.TextColor = Color.White; }
            else if (Constantce.Area == "9 Nissan") { Nissan.BackgroundColor = Color.FromHex("FF071D66"); Nissan.TextColor = Color.White; }
            else if (Constantce.Area == "Karadah") { Karadah.BackgroundColor = Color.FromHex("FF071D66"); Karadah.TextColor = Color.White; }
            else if (Constantce.Area == "Al - Za'franiya") { AlZafraniya.BackgroundColor = Color.FromHex("FF071D66"); AlZafraniya.TextColor = Color.White; }
            else if (Constantce.Area == "Karkh") { Karkh.BackgroundColor = Color.FromHex("FF071D66"); Karkh.TextColor = Color.White; }
            else if (Constantce.Area == "Kadhimyah") { Kadhimyah.BackgroundColor = Color.FromHex("FF071D66"); Kadhimyah.TextColor = Color.White; }
            else if (Constantce.Area == "Mansour") { Mansour.BackgroundColor = Color.FromHex("FF071D66"); Mansour.TextColor = Color.White; }
            else if (Constantce.Area == "Al Rashid") { AlRashid.BackgroundColor = Color.FromHex("FF071D66"); AlRashid.TextColor = Color.White; }
            else if (Constantce.Area == "Abu Ghraib") { AbuGhraib.BackgroundColor = Color.FromHex("FF071D66"); AbuGhraib.TextColor = Color.White; }
            else if (Constantce.Area == "Al Istiqlal ") { AlIstiqlal.BackgroundColor = Color.FromHex("FF071D66"); AlIstiqlal.TextColor = Color.White; }
            else if (Constantce.Area == "Al - Mada'in ") { AlMadain.BackgroundColor = Color.FromHex("FF071D66"); AlMadain.TextColor = Color.White; }
            else if (Constantce.Area == "Mahmudiya") { Mahmudiya.BackgroundColor = Color.FromHex("FF071D66"); Mahmudiya.TextColor = Color.White; }
            else if (Constantce.Area == "Taji ") { Taji.BackgroundColor = Color.FromHex("FF071D66"); Taji.TextColor = Color.White; }
            else if (Constantce.Area == "Al Tarmia ") { AlTarmia.BackgroundColor = Color.FromHex("FF071D66"); AlTarmia.TextColor = Color.White; }


        }
        async void Rusafa_Clicked(object sender, EventArgs e) { if (Rusafa.BackgroundColor == Color.White) { Constantce.Area = "Rusafa"; Constantce.AreaLang = Rusafa.Text; Rusafa.TextColor = Color.White; Rusafa.BackgroundColor = Color.FromHex("FF071D66"); var existingPages = Navigation.NavigationStack.ToList(); Page page = existingPages.FirstOrDefault(); Navigation.InsertPageBefore(new Home(), page); Navigation.RemovePage(page); await PopupNavigation.Instance.PopAsync(); } else {  Constantce.Area = "Area"; Rusafa.BackgroundColor = Color.White; Rusafa.TextColor = Color.FromHex("FF071D66"); } }
        async void Adhamiyah_Clicked(object sender, EventArgs e) { if (Adhamiyah.BackgroundColor == Color.White) { Constantce.Area = "Adhamiyah"; Constantce.AreaLang = Adhamiyah.Text; Adhamiyah.TextColor = Color.White; Adhamiyah.BackgroundColor = Color.FromHex("FF071D66"); var existingPages = Navigation.NavigationStack.ToList(); Page page = existingPages.FirstOrDefault(); Navigation.InsertPageBefore(new Home(), page); Navigation.RemovePage(page); await PopupNavigation.Instance.PopAsync(); } else {  Constantce.Area = "Area"; Adhamiyah.BackgroundColor = Color.White; Adhamiyah.TextColor = Color.FromHex("FF071D66"); } }
        async void SadrCity_Clicked(object sender, EventArgs e) { if (SadrCity.BackgroundColor == Color.White) { Constantce.Area = "Sadr City"; Constantce.AreaLang = SadrCity.Text; SadrCity.TextColor = Color.White; SadrCity.BackgroundColor = Color.FromHex("FF071D66"); var existingPages = Navigation.NavigationStack.ToList(); Page page = existingPages.FirstOrDefault(); Navigation.InsertPageBefore(new Home(), page); Navigation.RemovePage(page); await PopupNavigation.Instance.PopAsync(); } else {  Constantce.Area = "Area"; SadrCity.BackgroundColor = Color.White; SadrCity.TextColor = Color.FromHex("FF071D66"); } }
        async void Nissan_Clicked(object sender, EventArgs e) { if (Nissan.BackgroundColor == Color.White) { Constantce.Area = "9 Nissan"; Constantce.AreaLang = Nissan.Text; Nissan.TextColor = Color.White; Nissan.BackgroundColor = Color.FromHex("FF071D66"); var existingPages = Navigation.NavigationStack.ToList(); Page page = existingPages.FirstOrDefault(); Navigation.InsertPageBefore(new Home(), page); Navigation.RemovePage(page); await PopupNavigation.Instance.PopAsync(); } else {  Constantce.Area = "Area"; Nissan.BackgroundColor = Color.White; Nissan.TextColor = Color.FromHex("FF071D66"); } }
        async void Karadah_Clicked(object sender, EventArgs e) { if (Karadah.BackgroundColor == Color.White) { Constantce.Area = "Karadah"; Constantce.AreaLang = Karadah.Text; Karadah.TextColor = Color.White; Karadah.BackgroundColor = Color.FromHex("FF071D66"); var existingPages = Navigation.NavigationStack.ToList(); Page page = existingPages.FirstOrDefault(); Navigation.InsertPageBefore(new Home(), page); Navigation.RemovePage(page); await PopupNavigation.Instance.PopAsync(); } else {  Constantce.Area = "Area"; Karadah.BackgroundColor = Color.White; Karadah.TextColor = Color.FromHex("FF071D66"); } }
        async void AlZafraniya_Clicked(object sender, EventArgs e) { if (AlZafraniya.BackgroundColor == Color.White) { Constantce.Area = "Al - Za'franiya"; Constantce.AreaLang = AlZafraniya.Text; AlZafraniya.TextColor = Color.White; AlZafraniya.BackgroundColor = Color.FromHex("FF071D66"); var existingPages = Navigation.NavigationStack.ToList(); Page page = existingPages.FirstOrDefault(); Navigation.InsertPageBefore(new Home(), page); Navigation.RemovePage(page); await PopupNavigation.Instance.PopAsync(); } else {  Constantce.Area = "Area"; AlZafraniya.BackgroundColor = Color.White; AlZafraniya.TextColor = Color.FromHex("FF071D66"); } }
        async void Karkh_Clicked(object sender, EventArgs e) { if (Karkh.BackgroundColor == Color.White) { Constantce.Area = "Karkh"; Constantce.AreaLang = Karkh.Text; Karkh.TextColor = Color.White; Karkh.BackgroundColor = Color.FromHex("FF071D66"); var existingPages = Navigation.NavigationStack.ToList(); Page page = existingPages.FirstOrDefault(); Navigation.InsertPageBefore(new Home(), page); Navigation.RemovePage(page); await PopupNavigation.Instance.PopAsync(); } else {  Constantce.Area = "Area"; Karkh.BackgroundColor = Color.White; Karkh.TextColor = Color.FromHex("FF071D66"); } }
        async void Kadhimyah_Clicked(object sender, EventArgs e) { if (Kadhimyah.BackgroundColor == Color.White) { Constantce.Area = "Kadhimyah"; Constantce.AreaLang = Kadhimyah.Text; Kadhimyah.TextColor = Color.White; Kadhimyah.BackgroundColor = Color.FromHex("FF071D66"); var existingPages = Navigation.NavigationStack.ToList(); Page page = existingPages.FirstOrDefault(); Navigation.InsertPageBefore(new Home(), page); Navigation.RemovePage(page); await PopupNavigation.Instance.PopAsync(); } else {  Constantce.Area = "Area"; Kadhimyah.BackgroundColor = Color.White; Kadhimyah.TextColor = Color.FromHex("FF071D66"); } }
        async void Mansour_Clicked(object sender, EventArgs e) { if (Mansour.BackgroundColor == Color.White) { Constantce.Area = "Mansour"; Constantce.AreaLang = Mansour.Text; Mansour.TextColor = Color.White; Mansour.BackgroundColor = Color.FromHex("FF071D66"); var existingPages = Navigation.NavigationStack.ToList(); Page page = existingPages.FirstOrDefault(); Navigation.InsertPageBefore(new Home(), page); Navigation.RemovePage(page); await PopupNavigation.Instance.PopAsync(); } else {  Constantce.Area = "Area"; Mansour.BackgroundColor = Color.White; Mansour.TextColor = Color.FromHex("FF071D66"); } }
        async void AlRashid_Clicked(object sender, EventArgs e) { if (AlRashid.BackgroundColor == Color.White) { Constantce.Area = "Al Rashid"; Constantce.AreaLang = AlRashid.Text; AlRashid.TextColor = Color.White; AlRashid.BackgroundColor = Color.FromHex("FF071D66"); var existingPages = Navigation.NavigationStack.ToList(); Page page = existingPages.FirstOrDefault(); Navigation.InsertPageBefore(new Home(), page); Navigation.RemovePage(page); await PopupNavigation.Instance.PopAsync(); } else {  Constantce.Area = "Area"; AlRashid.BackgroundColor = Color.White; AlRashid.TextColor = Color.FromHex("FF071D66"); } }
        async void AbuGhraib_Clicked(object sender, EventArgs e) { if (AbuGhraib.BackgroundColor == Color.White) { Constantce.Area = "Abu Ghraib"; Constantce.AreaLang = AbuGhraib.Text; AbuGhraib.TextColor = Color.White; AbuGhraib.BackgroundColor = Color.FromHex("FF071D66"); var existingPages = Navigation.NavigationStack.ToList(); Page page = existingPages.FirstOrDefault(); Navigation.InsertPageBefore(new Home(), page); Navigation.RemovePage(page); await PopupNavigation.Instance.PopAsync(); } else {  Constantce.Area = "Area"; AbuGhraib.BackgroundColor = Color.White; AbuGhraib.TextColor = Color.FromHex("FF071D66"); } }
        async void AlIstiqlal_Clicked(object sender, EventArgs e) { if (AlIstiqlal.BackgroundColor == Color.White) { Constantce.Area = "Al Istiqlal "; Constantce.AreaLang = AlIstiqlal.Text; AlIstiqlal.TextColor = Color.White; AlIstiqlal.BackgroundColor = Color.FromHex("FF071D66"); var existingPages = Navigation.NavigationStack.ToList(); Page page = existingPages.FirstOrDefault(); Navigation.InsertPageBefore(new Home(), page); Navigation.RemovePage(page); await PopupNavigation.Instance.PopAsync(); } else {  Constantce.Area = "Area"; AlIstiqlal.BackgroundColor = Color.White; AlIstiqlal.TextColor = Color.FromHex("FF071D66"); } }
        async void AlMadain_Clicked(object sender, EventArgs e) { if (AlMadain.BackgroundColor == Color.White) { Constantce.Area = "Al - Mada'in "; Constantce.AreaLang = AlMadain.Text; AlMadain.TextColor = Color.White; AlMadain.BackgroundColor = Color.FromHex("FF071D66"); var existingPages = Navigation.NavigationStack.ToList(); Page page = existingPages.FirstOrDefault(); Navigation.InsertPageBefore(new Home(), page); Navigation.RemovePage(page); await PopupNavigation.Instance.PopAsync(); } else {  Constantce.Area = "Area"; AlMadain.BackgroundColor = Color.White; AlMadain.TextColor = Color.FromHex("FF071D66"); } }
        async void Mahmudiya_Clicked(object sender, EventArgs e) { if (Mahmudiya.BackgroundColor == Color.White) { Constantce.Area = "Mahmudiya"; Constantce.AreaLang = Mahmudiya.Text; Mahmudiya.TextColor = Color.White; Mahmudiya.BackgroundColor = Color.FromHex("FF071D66"); var existingPages = Navigation.NavigationStack.ToList(); Page page = existingPages.FirstOrDefault(); Navigation.InsertPageBefore(new Home(), page); Navigation.RemovePage(page); await PopupNavigation.Instance.PopAsync(); } else {  Constantce.Area = "Area"; Mahmudiya.BackgroundColor = Color.White; Mahmudiya.TextColor = Color.FromHex("FF071D66"); } }
        async void Taji_Clicked(object sender, EventArgs e) { if (Taji.BackgroundColor == Color.White) { Constantce.Area = "Taji "; Constantce.AreaLang = Taji.Text; Taji.TextColor = Color.White; Taji.BackgroundColor = Color.FromHex("FF071D66"); var existingPages = Navigation.NavigationStack.ToList(); Page page = existingPages.FirstOrDefault(); Navigation.InsertPageBefore(new Home(), page); Navigation.RemovePage(page); await PopupNavigation.Instance.PopAsync(); } else {  Constantce.Area = "Area"; Taji.BackgroundColor = Color.White; Taji.TextColor = Color.FromHex("FF071D66"); } }
        async void AlTarmia_Clicked(object sender, EventArgs e) { if (AlTarmia.BackgroundColor == Color.White) { Constantce.Area = "Al Tarmia "; Constantce.AreaLang = AlTarmia.Text; AlTarmia.TextColor = Color.White; AlTarmia.BackgroundColor = Color.FromHex("FF071D66"); var existingPages = Navigation.NavigationStack.ToList(); Page page = existingPages.FirstOrDefault(); Navigation.InsertPageBefore(new Home(), page); Navigation.RemovePage(page); await PopupNavigation.Instance.PopAsync(); } else {  Constantce.Area = "Area"; AlTarmia.BackgroundColor = Color.White; AlTarmia.TextColor = Color.FromHex("FF071D66"); } }


    }
}