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
    public partial class Ajlun : PopupPage
    {
        public Ajlun()
        {
            InitializeComponent();
            if (Application.Current.Properties["Language"].ToString() == "Arabic")
            {
                this.FlowDirection = FlowDirection.RightToLeft;
                UpText.Text = "الرجاء اختيار المنطقة";
                AinJanna.Text = "عين جنا";
                Ajloun.Text = "عجلون";
                Anjara.Text = "عنجرة";
                Asiem.Text = "عصيم";
                Ballas.Text = "بلاص";
                Baoon.Text = "باعون";
                Berkeh.Text = "البركة";
                BierEddalyeh.Text = "بئر الدالية";
                DeirElBarak.Text = "دير البرك";
                DeirSmadiyyehJanoobi.Text = "دير الصماديه الجنوبي";
                DeirSmadiyyehShamali.Text = "دير الصمادية الشمالي";
                Ebbien.Text = "عبين";
                Ebellien.Text = "عبلين";
                Fakhreh.Text = "الفاخره";
                GabalAghder.Text = "الجبل الاخضر";
                Halawah.Text = "حلاوه";
                Hanash.Text = "الحنش";
                Harth.Text = "الحرث";
                Hashemiyyeh.Text = "الهاشمية";
                KabElMalol.Text = "كعب الملول";
                KerbetEssooq.Text = "خربة السوق";
                KeshiebehElFoqa.Text = "الخشيبة الفوقا";
                KfarEddorrah.Text = "كفر الدره";
                KheletSalem.Text = "خلة سالم";
                KheletWardeh.Text = "خلة وردة";
                Kufrinjah.Text = "كفرنجة";
                Lasteb.Text = "لستب";
                Mehnah.Text = "محنا";
                Merjam.Text = "المرجم";
                Oasarah.Text = "اوصره";
                Oqdeh.Text = "العقدة";
                Orjan.Text = "عرجان";
                Rajeb.Text = "راجب";
                RasMoneef.Text = "رأس منيف";
                Rasoon.Text = "راسون";
                Safienh.Text = "السفينة";
                Sakhneh.Text = "الساخنه";
                Sakhrah.Text = "صخره";
                Samta.Text = "سامتا";
                Senaar.Text = "صنعار";
                Shkarah.Text = "الشكاره";
                Shtafaina.Text = "اشتفينا";
                Sofsafah.Text = "الصفصافه";
                Sowwan.Text = "الصوان";
                Tayyarah.Text = "الطياره";
                ThagretZebaid.Text = "ثغرة زبيد";
                UmmElKhashab.Text = "ام الخشب";
                UmmElYanabie.Text = "ام الينابيع";
                UmmErramel.Text = "ام الرمل";
                Wahadneh.Text = "الوهادنه";
                Zarraah.Text = "الزراعه";
                Zatarah.Text = "الزعتره";


            }
            else
            {
                this.FlowDirection = FlowDirection.LeftToRight;
                UpText.Text = "Please Select Area";

                AinJanna.Text = "Ain Janna";
                Ajloun.Text = "Ajloun";
                Anjara.Text = "Anjara";
                Asiem.Text = "Asiem";
                Ballas.Text = "Ballas";
                Baoon.Text = "Ba'oon";
                Berkeh.Text = "Berkeh";
                BierEddalyeh.Text = "Bier Eddalyeh";
                DeirElBarak.Text = "Deir El - Barak";
                DeirSmadiyyehJanoobi.Text = "Deir Smadiyyeh Janoobi";
                DeirSmadiyyehShamali.Text = "Deir Smadiyyeh Shamali";
                Ebbien.Text = "Ebbien";
                Ebellien.Text = "Ebellien";
                Fakhreh.Text = "Fakhreh";
                GabalAghder.Text = "Gabal Aghder";
                Halawah.Text = "Halawah";
                Hanash.Text = "Hanash";
                Harth.Text = "Harth";
                Hashemiyyeh.Text = "Hashemiyyeh";
                KabElMalol.Text = "Ka'b El-Malol";
                KerbetEssooq.Text = "Kerbet Essooq";
                KeshiebehElFoqa.Text = "Keshiebeh El - Foqa";
                KfarEddorrah.Text = "Kfar Eddorrah";
                KheletSalem.Text = "Khelet Salem";
                KheletWardeh.Text = "Khelet Wardeh";
                Kufrinjah.Text = "Kufrinjah";
                Lasteb.Text = "Lasteb";
                Mehnah.Text = "Mehnah";
                Merjam.Text = "Merjam";
                Oasarah.Text = "Oasarah";
                Oqdeh.Text = "Oqdeh";
                Orjan.Text = "Orjan";
                Rajeb.Text = "Rajeb";
                RasMoneef.Text = "Ras Moneef";
                Rasoon.Text = "Rasoon";
                Safienh.Text = "Safienh";
                Sakhneh.Text = "Sakhneh";
                Sakhrah.Text = "Sakhrah";
                Samta.Text = "Samta";
                Senaar.Text = "Sena'ar";
                Shkarah.Text = "Shkarah";
                Shtafaina.Text = "Shtafaina";
                Sofsafah.Text = "Sofsafah";
                Sowwan.Text = "Sowwan";
                Tayyarah.Text = "Tayyarah";
                ThagretZebaid.Text = "Thagret Zebaid";
                UmmElKhashab.Text = "Umm El - Khashab";
                UmmElYanabie.Text = "Umm El - Yanabie";
                UmmErramel.Text = "Umm Erramel";
                Wahadneh.Text = "Wahadneh";
                Zarraah.Text = "Zarra'ah";
                Zatarah.Text = "Za'tarah";

            }
            if (Constantce.Area == "Ain Janna") { AinJanna.BackgroundColor = Color.FromHex("#FF071D66"); AinJanna.TextColor = Color.White; }
            else if (Constantce.Area == "Ajloun") { Ajloun.BackgroundColor = Color.FromHex("#FF071D66"); Ajloun.TextColor = Color.White; }
            else if (Constantce.Area == "Anjara") { Anjara.BackgroundColor = Color.FromHex("#FF071D66"); Anjara.TextColor = Color.White; }
            else if (Constantce.Area == "Asiem") { Asiem.BackgroundColor = Color.FromHex("#FF071D66"); Asiem.TextColor = Color.White; }
            else if (Constantce.Area == "Ballas") { Ballas.BackgroundColor = Color.FromHex("#FF071D66"); Ballas.TextColor = Color.White; }
            else if (Constantce.Area == "Ba'oon") { Baoon.BackgroundColor = Color.FromHex("#FF071D66"); Baoon.TextColor = Color.White; }
            else if (Constantce.Area == "Berkeh") { Berkeh.BackgroundColor = Color.FromHex("#FF071D66"); Berkeh.TextColor = Color.White; }
            else if (Constantce.Area == "Bier Eddalyeh") { BierEddalyeh.BackgroundColor = Color.FromHex("#FF071D66"); BierEddalyeh.TextColor = Color.White; }
            else if (Constantce.Area == "Deir El - Barak") { DeirElBarak.BackgroundColor = Color.FromHex("#FF071D66"); DeirElBarak.TextColor = Color.White; }
            else if (Constantce.Area == "Deir Smadiyyeh Janoobi") { DeirSmadiyyehJanoobi.BackgroundColor = Color.FromHex("#FF071D66"); DeirSmadiyyehJanoobi.TextColor = Color.White; }
            else if (Constantce.Area == "Deir Smadiyyeh Shamali") { DeirSmadiyyehShamali.BackgroundColor = Color.FromHex("#FF071D66"); DeirSmadiyyehShamali.TextColor = Color.White; }
            else if (Constantce.Area == "Ebbien") { Ebbien.BackgroundColor = Color.FromHex("#FF071D66"); Ebbien.TextColor = Color.White; }
            else if (Constantce.Area == "Ebellien") { Ebellien.BackgroundColor = Color.FromHex("#FF071D66"); Ebellien.TextColor = Color.White; }
            else if (Constantce.Area == "Fakhreh") { Fakhreh.BackgroundColor = Color.FromHex("#FF071D66"); Fakhreh.TextColor = Color.White; }
            else if (Constantce.Area == "Gabal Aghder") { GabalAghder.BackgroundColor = Color.FromHex("#FF071D66"); GabalAghder.TextColor = Color.White; }
            else if (Constantce.Area == "Halawah") { Halawah.BackgroundColor = Color.FromHex("#FF071D66"); Halawah.TextColor = Color.White; }
            else if (Constantce.Area == "Hanash") { Hanash.BackgroundColor = Color.FromHex("#FF071D66"); Hanash.TextColor = Color.White; }
            else if (Constantce.Area == "Harth") { Harth.BackgroundColor = Color.FromHex("#FF071D66"); Harth.TextColor = Color.White; }
            else if (Constantce.Area == "Hashemiyyeh") { Hashemiyyeh.BackgroundColor = Color.FromHex("#FF071D66"); Hashemiyyeh.TextColor = Color.White; }
            else if (Constantce.Area == "Ka'b El-Malol") { KabElMalol.BackgroundColor = Color.FromHex("#FF071D66"); KabElMalol.TextColor = Color.White; }
            else if (Constantce.Area == "Kerbet Essooq") { KerbetEssooq.BackgroundColor = Color.FromHex("#FF071D66"); KerbetEssooq.TextColor = Color.White; }
            else if (Constantce.Area == "Keshiebeh El - Foqa") { KeshiebehElFoqa.BackgroundColor = Color.FromHex("#FF071D66"); KeshiebehElFoqa.TextColor = Color.White; }
            else if (Constantce.Area == "Kfar Eddorrah") { KfarEddorrah.BackgroundColor = Color.FromHex("#FF071D66"); KfarEddorrah.TextColor = Color.White; }
            else if (Constantce.Area == "Khelet Salem") { KheletSalem.BackgroundColor = Color.FromHex("#FF071D66"); KheletSalem.TextColor = Color.White; }
            else if (Constantce.Area == "Khelet Wardeh") { KheletWardeh.BackgroundColor = Color.FromHex("#FF071D66"); KheletWardeh.TextColor = Color.White; }
            else if (Constantce.Area == "Kufrinjah") { Kufrinjah.BackgroundColor = Color.FromHex("#FF071D66"); Kufrinjah.TextColor = Color.White; }
            else if (Constantce.Area == "Lasteb") { Lasteb.BackgroundColor = Color.FromHex("#FF071D66"); Lasteb.TextColor = Color.White; }
            else if (Constantce.Area == "Mehnah") { Mehnah.BackgroundColor = Color.FromHex("#FF071D66"); Mehnah.TextColor = Color.White; }
            else if (Constantce.Area == "Merjam") { Merjam.BackgroundColor = Color.FromHex("#FF071D66"); Merjam.TextColor = Color.White; }
            else if (Constantce.Area == "Oasarah") { Oasarah.BackgroundColor = Color.FromHex("#FF071D66"); Oasarah.TextColor = Color.White; }
            else if (Constantce.Area == "Oqdeh") { Oqdeh.BackgroundColor = Color.FromHex("#FF071D66"); Oqdeh.TextColor = Color.White; }
            else if (Constantce.Area == "Orjan") { Orjan.BackgroundColor = Color.FromHex("#FF071D66"); Orjan.TextColor = Color.White; }
            else if (Constantce.Area == "Rajeb") { Rajeb.BackgroundColor = Color.FromHex("#FF071D66"); Rajeb.TextColor = Color.White; }
            else if (Constantce.Area == "Ras Moneef") { RasMoneef.BackgroundColor = Color.FromHex("#FF071D66"); RasMoneef.TextColor = Color.White; }
            else if (Constantce.Area == "Rasoon") { Rasoon.BackgroundColor = Color.FromHex("#FF071D66"); Rasoon.TextColor = Color.White; }
            else if (Constantce.Area == "Safienh") { Safienh.BackgroundColor = Color.FromHex("#FF071D66"); Safienh.TextColor = Color.White; }
            else if (Constantce.Area == "Sakhneh") { Sakhneh.BackgroundColor = Color.FromHex("#FF071D66"); Sakhneh.TextColor = Color.White; }
            else if (Constantce.Area == "Sakhrah") { Sakhrah.BackgroundColor = Color.FromHex("#FF071D66"); Sakhrah.TextColor = Color.White; }
            else if (Constantce.Area == "Samta") { Samta.BackgroundColor = Color.FromHex("#FF071D66"); Samta.TextColor = Color.White; }
            else if (Constantce.Area == "Sena'ar") { Senaar.BackgroundColor = Color.FromHex("#FF071D66"); Senaar.TextColor = Color.White; }
            else if (Constantce.Area == "Shkarah") { Shkarah.BackgroundColor = Color.FromHex("#FF071D66"); Shkarah.TextColor = Color.White; }
            else if (Constantce.Area == "Shtafaina") { Shtafaina.BackgroundColor = Color.FromHex("#FF071D66"); Shtafaina.TextColor = Color.White; }
            else if (Constantce.Area == "Sofsafah") { Sofsafah.BackgroundColor = Color.FromHex("#FF071D66"); Sofsafah.TextColor = Color.White; }
            else if (Constantce.Area == "Sowwan") { Sowwan.BackgroundColor = Color.FromHex("#FF071D66"); Sowwan.TextColor = Color.White; }
            else if (Constantce.Area == "Tayyarah") { Tayyarah.BackgroundColor = Color.FromHex("#FF071D66"); Tayyarah.TextColor = Color.White; }
            else if (Constantce.Area == "Thagret Zebaid") { ThagretZebaid.BackgroundColor = Color.FromHex("#FF071D66"); ThagretZebaid.TextColor = Color.White; }
            else if (Constantce.Area == "Umm El - Khashab") { UmmElKhashab.BackgroundColor = Color.FromHex("#FF071D66"); UmmElKhashab.TextColor = Color.White; }
            else if (Constantce.Area == "Umm El - Yanabie") { UmmElYanabie.BackgroundColor = Color.FromHex("#FF071D66"); UmmElYanabie.TextColor = Color.White; }
            else if (Constantce.Area == "Umm Erramel") { UmmErramel.BackgroundColor = Color.FromHex("#FF071D66"); UmmErramel.TextColor = Color.White; }
            else if (Constantce.Area == "Wahadneh") { Wahadneh.BackgroundColor = Color.FromHex("#FF071D66"); Wahadneh.TextColor = Color.White; }
            else if (Constantce.Area == "Zarra'ah") { Zarraah.BackgroundColor = Color.FromHex("#FF071D66"); Zarraah.TextColor = Color.White; }
            else if (Constantce.Area == "Za'tarah") { Zatarah.BackgroundColor = Color.FromHex("#FF071D66"); Zatarah.TextColor = Color.White; }


        }


        async void AinJanna_Clicked(object sender, EventArgs e) { if (AinJanna.BackgroundColor == Color.White) { Constantce.Area = "Ain Janna"; Constantce.AreaLang = AinJanna.Text; AinJanna.TextColor = Color.White; AinJanna.BackgroundColor = Color.FromHex("#FF071D66"); var existingPages = Navigation.NavigationStack.ToList();Page page = existingPages.FirstOrDefault();Navigation.InsertPageBefore(new Home(), page);Navigation.RemovePage(page);await PopupNavigation.Instance.PopAsync(); } else { Constantce.Area = "Area"; AinJanna.BackgroundColor = Color.White; AinJanna.TextColor = Color.FromHex("#FF071D66"); } }
        async void Ajloun_Clicked(object sender, EventArgs e) { if (Ajloun.BackgroundColor == Color.White) { Constantce.Area = "Ajloun"; Constantce.AreaLang = Ajloun.Text; Ajloun.TextColor = Color.White; Ajloun.BackgroundColor = Color.FromHex("#FF071D66"); var existingPages = Navigation.NavigationStack.ToList();Page page = existingPages.FirstOrDefault();Navigation.InsertPageBefore(new Home(), page);Navigation.RemovePage(page);await PopupNavigation.Instance.PopAsync(); } else { Constantce.Area = "Area"; Ajloun.BackgroundColor = Color.White; Ajloun.TextColor = Color.FromHex("#FF071D66"); } }
        async void Anjara_Clicked(object sender, EventArgs e) { if (Anjara.BackgroundColor == Color.White) { Constantce.Area = "Anjara"; Constantce.AreaLang = Anjara.Text; Anjara.TextColor = Color.White; Anjara.BackgroundColor = Color.FromHex("#FF071D66"); var existingPages = Navigation.NavigationStack.ToList();Page page = existingPages.FirstOrDefault();Navigation.InsertPageBefore(new Home(), page);Navigation.RemovePage(page);await PopupNavigation.Instance.PopAsync(); } else { Constantce.Area = "Area"; Anjara.BackgroundColor = Color.White; Anjara.TextColor = Color.FromHex("#FF071D66"); } }
        async void Asiem_Clicked(object sender, EventArgs e) { if (Asiem.BackgroundColor == Color.White) { Constantce.Area = "Asiem"; Constantce.AreaLang = Asiem.Text; Asiem.TextColor = Color.White; Asiem.BackgroundColor = Color.FromHex("#FF071D66"); var existingPages = Navigation.NavigationStack.ToList();Page page = existingPages.FirstOrDefault();Navigation.InsertPageBefore(new Home(), page);Navigation.RemovePage(page);await PopupNavigation.Instance.PopAsync(); } else { Constantce.Area = "Area"; Asiem.BackgroundColor = Color.White; Asiem.TextColor = Color.FromHex("#FF071D66"); } }
        async void Ballas_Clicked(object sender, EventArgs e) { if (Ballas.BackgroundColor == Color.White) { Constantce.Area = "Ballas"; Constantce.AreaLang = Ballas.Text; Ballas.TextColor = Color.White; Ballas.BackgroundColor = Color.FromHex("#FF071D66"); var existingPages = Navigation.NavigationStack.ToList();Page page = existingPages.FirstOrDefault();Navigation.InsertPageBefore(new Home(), page);Navigation.RemovePage(page);await PopupNavigation.Instance.PopAsync(); } else { Constantce.Area = "Area"; Ballas.BackgroundColor = Color.White; Ballas.TextColor = Color.FromHex("#FF071D66"); } }
        async void Baoon_Clicked(object sender, EventArgs e) { if (Baoon.BackgroundColor == Color.White) { Constantce.Area = "Ba'oon"; Constantce.AreaLang = Baoon.Text; Baoon.TextColor = Color.White; Baoon.BackgroundColor = Color.FromHex("#FF071D66"); var existingPages = Navigation.NavigationStack.ToList();Page page = existingPages.FirstOrDefault();Navigation.InsertPageBefore(new Home(), page);Navigation.RemovePage(page);await PopupNavigation.Instance.PopAsync(); } else { Constantce.Area = "Area"; Baoon.BackgroundColor = Color.White; Baoon.TextColor = Color.FromHex("#FF071D66"); } }
        async void Berkeh_Clicked(object sender, EventArgs e) { if (Berkeh.BackgroundColor == Color.White) { Constantce.Area = "Berkeh"; Constantce.AreaLang = Berkeh.Text; Berkeh.TextColor = Color.White; Berkeh.BackgroundColor = Color.FromHex("#FF071D66"); var existingPages = Navigation.NavigationStack.ToList();Page page = existingPages.FirstOrDefault();Navigation.InsertPageBefore(new Home(), page);Navigation.RemovePage(page);await PopupNavigation.Instance.PopAsync(); } else { Constantce.Area = "Area"; Berkeh.BackgroundColor = Color.White; Berkeh.TextColor = Color.FromHex("#FF071D66"); } }
        async void BierEddalyeh_Clicked(object sender, EventArgs e) { if (BierEddalyeh.BackgroundColor == Color.White) { Constantce.Area = "Bier Eddalyeh"; Constantce.AreaLang = BierEddalyeh.Text; BierEddalyeh.TextColor = Color.White; BierEddalyeh.BackgroundColor = Color.FromHex("#FF071D66"); var existingPages = Navigation.NavigationStack.ToList();Page page = existingPages.FirstOrDefault();Navigation.InsertPageBefore(new Home(), page);Navigation.RemovePage(page);await PopupNavigation.Instance.PopAsync(); } else { Constantce.Area = "Area"; BierEddalyeh.BackgroundColor = Color.White; BierEddalyeh.TextColor = Color.FromHex("#FF071D66"); } }
        async void DeirElBarak_Clicked(object sender, EventArgs e) { if (DeirElBarak.BackgroundColor == Color.White) { Constantce.Area = "Deir El - Barak"; Constantce.AreaLang = DeirElBarak.Text; DeirElBarak.TextColor = Color.White; DeirElBarak.BackgroundColor = Color.FromHex("#FF071D66"); var existingPages = Navigation.NavigationStack.ToList();Page page = existingPages.FirstOrDefault();Navigation.InsertPageBefore(new Home(), page);Navigation.RemovePage(page);await PopupNavigation.Instance.PopAsync(); } else { Constantce.Area = "Area"; DeirElBarak.BackgroundColor = Color.White; DeirElBarak.TextColor = Color.FromHex("#FF071D66"); } }
        async void DeirSmadiyyehJanoobi_Clicked(object sender, EventArgs e) { if (DeirSmadiyyehJanoobi.BackgroundColor == Color.White) { Constantce.Area = "Deir Smadiyyeh Janoobi"; Constantce.AreaLang = DeirSmadiyyehJanoobi.Text; DeirSmadiyyehJanoobi.TextColor = Color.White; DeirSmadiyyehJanoobi.BackgroundColor = Color.FromHex("#FF071D66"); var existingPages = Navigation.NavigationStack.ToList();Page page = existingPages.FirstOrDefault();Navigation.InsertPageBefore(new Home(), page);Navigation.RemovePage(page);await PopupNavigation.Instance.PopAsync(); } else { Constantce.Area = "Area"; DeirSmadiyyehJanoobi.BackgroundColor = Color.White; DeirSmadiyyehJanoobi.TextColor = Color.FromHex("#FF071D66"); } }
        async void DeirSmadiyyehShamali_Clicked(object sender, EventArgs e) { if (DeirSmadiyyehShamali.BackgroundColor == Color.White) { Constantce.Area = "Deir Smadiyyeh Shamali"; Constantce.AreaLang = DeirSmadiyyehShamali.Text; DeirSmadiyyehShamali.TextColor = Color.White; DeirSmadiyyehShamali.BackgroundColor = Color.FromHex("#FF071D66"); var existingPages = Navigation.NavigationStack.ToList();Page page = existingPages.FirstOrDefault();Navigation.InsertPageBefore(new Home(), page);Navigation.RemovePage(page);await PopupNavigation.Instance.PopAsync(); } else { Constantce.Area = "Area"; DeirSmadiyyehShamali.BackgroundColor = Color.White; DeirSmadiyyehShamali.TextColor = Color.FromHex("#FF071D66"); } }
        async void Ebbien_Clicked(object sender, EventArgs e) { if (Ebbien.BackgroundColor == Color.White) { Constantce.Area = "Ebbien"; Constantce.AreaLang = Ebbien.Text; Ebbien.TextColor = Color.White; Ebbien.BackgroundColor = Color.FromHex("#FF071D66"); var existingPages = Navigation.NavigationStack.ToList();Page page = existingPages.FirstOrDefault();Navigation.InsertPageBefore(new Home(), page);Navigation.RemovePage(page);await PopupNavigation.Instance.PopAsync(); } else { Constantce.Area = "Area"; Ebbien.BackgroundColor = Color.White; Ebbien.TextColor = Color.FromHex("#FF071D66"); } }
        async void Ebellien_Clicked(object sender, EventArgs e) { if (Ebellien.BackgroundColor == Color.White) { Constantce.Area = "Ebellien"; Constantce.AreaLang = Ebellien.Text; Ebellien.TextColor = Color.White; Ebellien.BackgroundColor = Color.FromHex("#FF071D66"); var existingPages = Navigation.NavigationStack.ToList();Page page = existingPages.FirstOrDefault();Navigation.InsertPageBefore(new Home(), page);Navigation.RemovePage(page);await PopupNavigation.Instance.PopAsync(); } else { Constantce.Area = "Area"; Ebellien.BackgroundColor = Color.White; Ebellien.TextColor = Color.FromHex("#FF071D66"); } }
        async void Fakhreh_Clicked(object sender, EventArgs e) { if (Fakhreh.BackgroundColor == Color.White) { Constantce.Area = "Fakhreh"; Constantce.AreaLang = Fakhreh.Text; Fakhreh.TextColor = Color.White; Fakhreh.BackgroundColor = Color.FromHex("#FF071D66"); var existingPages = Navigation.NavigationStack.ToList();Page page = existingPages.FirstOrDefault();Navigation.InsertPageBefore(new Home(), page);Navigation.RemovePage(page);await PopupNavigation.Instance.PopAsync(); } else { Constantce.Area = "Area"; Fakhreh.BackgroundColor = Color.White; Fakhreh.TextColor = Color.FromHex("#FF071D66"); } }
        async void GabalAghder_Clicked(object sender, EventArgs e) { if (GabalAghder.BackgroundColor == Color.White) { Constantce.Area = "Gabal Aghder"; Constantce.AreaLang = GabalAghder.Text; GabalAghder.TextColor = Color.White; GabalAghder.BackgroundColor = Color.FromHex("#FF071D66"); var existingPages = Navigation.NavigationStack.ToList();Page page = existingPages.FirstOrDefault();Navigation.InsertPageBefore(new Home(), page);Navigation.RemovePage(page);await PopupNavigation.Instance.PopAsync(); } else { Constantce.Area = "Area"; GabalAghder.BackgroundColor = Color.White; GabalAghder.TextColor = Color.FromHex("#FF071D66"); } }
        async void Halawah_Clicked(object sender, EventArgs e) { if (Halawah.BackgroundColor == Color.White) { Constantce.Area = "Halawah"; Constantce.AreaLang = Halawah.Text; Halawah.TextColor = Color.White; Halawah.BackgroundColor = Color.FromHex("#FF071D66"); var existingPages = Navigation.NavigationStack.ToList();Page page = existingPages.FirstOrDefault();Navigation.InsertPageBefore(new Home(), page);Navigation.RemovePage(page);await PopupNavigation.Instance.PopAsync(); } else { Constantce.Area = "Area"; Halawah.BackgroundColor = Color.White; Halawah.TextColor = Color.FromHex("#FF071D66"); } }
        async void Hanash_Clicked(object sender, EventArgs e) { if (Hanash.BackgroundColor == Color.White) { Constantce.Area = "Hanash"; Constantce.AreaLang = Hanash.Text; Hanash.TextColor = Color.White; Hanash.BackgroundColor = Color.FromHex("#FF071D66"); var existingPages = Navigation.NavigationStack.ToList();Page page = existingPages.FirstOrDefault();Navigation.InsertPageBefore(new Home(), page);Navigation.RemovePage(page);await PopupNavigation.Instance.PopAsync(); } else { Constantce.Area = "Area"; Hanash.BackgroundColor = Color.White; Hanash.TextColor = Color.FromHex("#FF071D66"); } }
        async void Harth_Clicked(object sender, EventArgs e) { if (Harth.BackgroundColor == Color.White) { Constantce.Area = "Harth"; Constantce.AreaLang = Harth.Text; Harth.TextColor = Color.White; Harth.BackgroundColor = Color.FromHex("#FF071D66"); var existingPages = Navigation.NavigationStack.ToList();Page page = existingPages.FirstOrDefault();Navigation.InsertPageBefore(new Home(), page);Navigation.RemovePage(page);await PopupNavigation.Instance.PopAsync(); } else { Constantce.Area = "Area"; Harth.BackgroundColor = Color.White; Harth.TextColor = Color.FromHex("#FF071D66"); } }
        async void Hashemiyyeh_Clicked(object sender, EventArgs e) { if (Hashemiyyeh.BackgroundColor == Color.White) { Constantce.Area = "Hashemiyyeh"; Constantce.AreaLang = Hashemiyyeh.Text; Hashemiyyeh.TextColor = Color.White; Hashemiyyeh.BackgroundColor = Color.FromHex("#FF071D66"); var existingPages = Navigation.NavigationStack.ToList();Page page = existingPages.FirstOrDefault();Navigation.InsertPageBefore(new Home(), page);Navigation.RemovePage(page);await PopupNavigation.Instance.PopAsync(); } else { Constantce.Area = "Area"; Hashemiyyeh.BackgroundColor = Color.White; Hashemiyyeh.TextColor = Color.FromHex("#FF071D66"); } }
        async void KabElMalol_Clicked(object sender, EventArgs e) { if (KabElMalol.BackgroundColor == Color.White) { Constantce.Area = "Ka'b El-Malol"; Constantce.AreaLang = KabElMalol.Text; KabElMalol.TextColor = Color.White; KabElMalol.BackgroundColor = Color.FromHex("#FF071D66"); var existingPages = Navigation.NavigationStack.ToList();Page page = existingPages.FirstOrDefault();Navigation.InsertPageBefore(new Home(), page);Navigation.RemovePage(page);await PopupNavigation.Instance.PopAsync(); } else { Constantce.Area = "Area"; KabElMalol.BackgroundColor = Color.White; KabElMalol.TextColor = Color.FromHex("#FF071D66"); } }
        async void KerbetEssooq_Clicked(object sender, EventArgs e) { if (KerbetEssooq.BackgroundColor == Color.White) { Constantce.Area = "Kerbet Essooq"; Constantce.AreaLang = KerbetEssooq.Text; KerbetEssooq.TextColor = Color.White; KerbetEssooq.BackgroundColor = Color.FromHex("#FF071D66"); var existingPages = Navigation.NavigationStack.ToList();Page page = existingPages.FirstOrDefault();Navigation.InsertPageBefore(new Home(), page);Navigation.RemovePage(page);await PopupNavigation.Instance.PopAsync(); } else { Constantce.Area = "Area"; KerbetEssooq.BackgroundColor = Color.White; KerbetEssooq.TextColor = Color.FromHex("#FF071D66"); } }
        async void KeshiebehElFoqa_Clicked(object sender, EventArgs e) { if (KeshiebehElFoqa.BackgroundColor == Color.White) { Constantce.Area = "Keshiebeh El - Foqa"; Constantce.AreaLang = KeshiebehElFoqa.Text; KeshiebehElFoqa.TextColor = Color.White; KeshiebehElFoqa.BackgroundColor = Color.FromHex("#FF071D66"); var existingPages = Navigation.NavigationStack.ToList();Page page = existingPages.FirstOrDefault();Navigation.InsertPageBefore(new Home(), page);Navigation.RemovePage(page);await PopupNavigation.Instance.PopAsync(); } else { Constantce.Area = "Area"; KeshiebehElFoqa.BackgroundColor = Color.White; KeshiebehElFoqa.TextColor = Color.FromHex("#FF071D66"); } }
        async void KfarEddorrah_Clicked(object sender, EventArgs e) { if (KfarEddorrah.BackgroundColor == Color.White) { Constantce.Area = "Kfar Eddorrah"; Constantce.AreaLang = KfarEddorrah.Text; KfarEddorrah.TextColor = Color.White; KfarEddorrah.BackgroundColor = Color.FromHex("#FF071D66"); var existingPages = Navigation.NavigationStack.ToList();Page page = existingPages.FirstOrDefault();Navigation.InsertPageBefore(new Home(), page);Navigation.RemovePage(page);await PopupNavigation.Instance.PopAsync(); } else { Constantce.Area = "Area"; KfarEddorrah.BackgroundColor = Color.White; KfarEddorrah.TextColor = Color.FromHex("#FF071D66"); } }
        async void KheletSalem_Clicked(object sender, EventArgs e) { if (KheletSalem.BackgroundColor == Color.White) { Constantce.Area = "Khelet Salem"; Constantce.AreaLang = KheletSalem.Text; KheletSalem.TextColor = Color.White; KheletSalem.BackgroundColor = Color.FromHex("#FF071D66"); var existingPages = Navigation.NavigationStack.ToList();Page page = existingPages.FirstOrDefault();Navigation.InsertPageBefore(new Home(), page);Navigation.RemovePage(page);await PopupNavigation.Instance.PopAsync(); } else { Constantce.Area = "Area"; KheletSalem.BackgroundColor = Color.White; KheletSalem.TextColor = Color.FromHex("#FF071D66"); } }
        async void KheletWardeh_Clicked(object sender, EventArgs e) { if (KheletWardeh.BackgroundColor == Color.White) { Constantce.Area = "Khelet Wardeh"; Constantce.AreaLang = KheletWardeh.Text; KheletWardeh.TextColor = Color.White; KheletWardeh.BackgroundColor = Color.FromHex("#FF071D66"); var existingPages = Navigation.NavigationStack.ToList();Page page = existingPages.FirstOrDefault();Navigation.InsertPageBefore(new Home(), page);Navigation.RemovePage(page);await PopupNavigation.Instance.PopAsync(); } else { Constantce.Area = "Area"; KheletWardeh.BackgroundColor = Color.White; KheletWardeh.TextColor = Color.FromHex("#FF071D66"); } }
        async void Kufrinjah_Clicked(object sender, EventArgs e) { if (Kufrinjah.BackgroundColor == Color.White) { Constantce.Area = "Kufrinjah"; Constantce.AreaLang = Kufrinjah.Text; Kufrinjah.TextColor = Color.White; Kufrinjah.BackgroundColor = Color.FromHex("#FF071D66"); var existingPages = Navigation.NavigationStack.ToList();Page page = existingPages.FirstOrDefault();Navigation.InsertPageBefore(new Home(), page);Navigation.RemovePage(page);await PopupNavigation.Instance.PopAsync(); } else { Constantce.Area = "Area"; Kufrinjah.BackgroundColor = Color.White; Kufrinjah.TextColor = Color.FromHex("#FF071D66"); } }
        async void Lasteb_Clicked(object sender, EventArgs e) { if (Lasteb.BackgroundColor == Color.White) { Constantce.Area = "Lasteb"; Constantce.AreaLang = Lasteb.Text; Lasteb.TextColor = Color.White; Lasteb.BackgroundColor = Color.FromHex("#FF071D66"); var existingPages = Navigation.NavigationStack.ToList();Page page = existingPages.FirstOrDefault();Navigation.InsertPageBefore(new Home(), page);Navigation.RemovePage(page);await PopupNavigation.Instance.PopAsync(); } else { Constantce.Area = "Area"; Lasteb.BackgroundColor = Color.White; Lasteb.TextColor = Color.FromHex("#FF071D66"); } }
        async void Mehnah_Clicked(object sender, EventArgs e) { if (Mehnah.BackgroundColor == Color.White) { Constantce.Area = "Mehnah"; Constantce.AreaLang = Mehnah.Text; Mehnah.TextColor = Color.White; Mehnah.BackgroundColor = Color.FromHex("#FF071D66"); var existingPages = Navigation.NavigationStack.ToList();Page page = existingPages.FirstOrDefault();Navigation.InsertPageBefore(new Home(), page);Navigation.RemovePage(page);await PopupNavigation.Instance.PopAsync(); } else { Constantce.Area = "Area"; Mehnah.BackgroundColor = Color.White; Mehnah.TextColor = Color.FromHex("#FF071D66"); } }
        async void Merjam_Clicked(object sender, EventArgs e) { if (Merjam.BackgroundColor == Color.White) { Constantce.Area = "Merjam"; Constantce.AreaLang = Merjam.Text; Merjam.TextColor = Color.White; Merjam.BackgroundColor = Color.FromHex("#FF071D66"); var existingPages = Navigation.NavigationStack.ToList();Page page = existingPages.FirstOrDefault();Navigation.InsertPageBefore(new Home(), page);Navigation.RemovePage(page);await PopupNavigation.Instance.PopAsync(); } else { Constantce.Area = "Area"; Merjam.BackgroundColor = Color.White; Merjam.TextColor = Color.FromHex("#FF071D66"); } }
        async void Oasarah_Clicked(object sender, EventArgs e) { if (Oasarah.BackgroundColor == Color.White) { Constantce.Area = "Oasarah"; Constantce.AreaLang = Oasarah.Text; Oasarah.TextColor = Color.White; Oasarah.BackgroundColor = Color.FromHex("#FF071D66"); var existingPages = Navigation.NavigationStack.ToList();Page page = existingPages.FirstOrDefault();Navigation.InsertPageBefore(new Home(), page);Navigation.RemovePage(page);await PopupNavigation.Instance.PopAsync(); } else { Constantce.Area = "Area"; Oasarah.BackgroundColor = Color.White; Oasarah.TextColor = Color.FromHex("#FF071D66"); } }
        async void Oqdeh_Clicked(object sender, EventArgs e) { if (Oqdeh.BackgroundColor == Color.White) { Constantce.Area = "Oqdeh"; Constantce.AreaLang = Oqdeh.Text; Oqdeh.TextColor = Color.White; Oqdeh.BackgroundColor = Color.FromHex("#FF071D66"); var existingPages = Navigation.NavigationStack.ToList();Page page = existingPages.FirstOrDefault();Navigation.InsertPageBefore(new Home(), page);Navigation.RemovePage(page);await PopupNavigation.Instance.PopAsync(); } else { Constantce.Area = "Area"; Oqdeh.BackgroundColor = Color.White; Oqdeh.TextColor = Color.FromHex("#FF071D66"); } }
        async void Orjan_Clicked(object sender, EventArgs e) { if (Orjan.BackgroundColor == Color.White) { Constantce.Area = "Orjan"; Constantce.AreaLang = Orjan.Text; Orjan.TextColor = Color.White; Orjan.BackgroundColor = Color.FromHex("#FF071D66"); var existingPages = Navigation.NavigationStack.ToList();Page page = existingPages.FirstOrDefault();Navigation.InsertPageBefore(new Home(), page);Navigation.RemovePage(page);await PopupNavigation.Instance.PopAsync(); } else { Constantce.Area = "Area"; Orjan.BackgroundColor = Color.White; Orjan.TextColor = Color.FromHex("#FF071D66"); } }
        async void Rajeb_Clicked(object sender, EventArgs e) { if (Rajeb.BackgroundColor == Color.White) { Constantce.Area = "Rajeb"; Constantce.AreaLang = Rajeb.Text; Rajeb.TextColor = Color.White; Rajeb.BackgroundColor = Color.FromHex("#FF071D66"); var existingPages = Navigation.NavigationStack.ToList();Page page = existingPages.FirstOrDefault();Navigation.InsertPageBefore(new Home(), page);Navigation.RemovePage(page);await PopupNavigation.Instance.PopAsync(); } else { Constantce.Area = "Area"; Rajeb.BackgroundColor = Color.White; Rajeb.TextColor = Color.FromHex("#FF071D66"); } }
        async void RasMoneef_Clicked(object sender, EventArgs e) { if (RasMoneef.BackgroundColor == Color.White) { Constantce.Area = "Ras Moneef"; Constantce.AreaLang = RasMoneef.Text; RasMoneef.TextColor = Color.White; RasMoneef.BackgroundColor = Color.FromHex("#FF071D66"); var existingPages = Navigation.NavigationStack.ToList();Page page = existingPages.FirstOrDefault();Navigation.InsertPageBefore(new Home(), page);Navigation.RemovePage(page);await PopupNavigation.Instance.PopAsync(); } else { Constantce.Area = "Area"; RasMoneef.BackgroundColor = Color.White; RasMoneef.TextColor = Color.FromHex("#FF071D66"); } }
        async void Rasoon_Clicked(object sender, EventArgs e) { if (Rasoon.BackgroundColor == Color.White) { Constantce.Area = "Rasoon"; Constantce.AreaLang = Rasoon.Text; Rasoon.TextColor = Color.White; Rasoon.BackgroundColor = Color.FromHex("#FF071D66"); var existingPages = Navigation.NavigationStack.ToList();Page page = existingPages.FirstOrDefault();Navigation.InsertPageBefore(new Home(), page);Navigation.RemovePage(page);await PopupNavigation.Instance.PopAsync(); } else { Constantce.Area = "Area"; Rasoon.BackgroundColor = Color.White; Rasoon.TextColor = Color.FromHex("#FF071D66"); } }
        async void Safienh_Clicked(object sender, EventArgs e) { if (Safienh.BackgroundColor == Color.White) { Constantce.Area = "Safienh"; Constantce.AreaLang = Safienh.Text; Safienh.TextColor = Color.White; Safienh.BackgroundColor = Color.FromHex("#FF071D66"); var existingPages = Navigation.NavigationStack.ToList();Page page = existingPages.FirstOrDefault();Navigation.InsertPageBefore(new Home(), page);Navigation.RemovePage(page);await PopupNavigation.Instance.PopAsync(); } else { Constantce.Area = "Area"; Safienh.BackgroundColor = Color.White; Safienh.TextColor = Color.FromHex("#FF071D66"); } }
        async void Sakhneh_Clicked(object sender, EventArgs e) { if (Sakhneh.BackgroundColor == Color.White) { Constantce.Area = "Sakhneh"; Constantce.AreaLang = Sakhneh.Text; Sakhneh.TextColor = Color.White; Sakhneh.BackgroundColor = Color.FromHex("#FF071D66"); var existingPages = Navigation.NavigationStack.ToList();Page page = existingPages.FirstOrDefault();Navigation.InsertPageBefore(new Home(), page);Navigation.RemovePage(page);await PopupNavigation.Instance.PopAsync(); } else { Constantce.Area = "Area"; Sakhneh.BackgroundColor = Color.White; Sakhneh.TextColor = Color.FromHex("#FF071D66"); } }
        async void Sakhrah_Clicked(object sender, EventArgs e) { if (Sakhrah.BackgroundColor == Color.White) { Constantce.Area = "Sakhrah"; Constantce.AreaLang = Sakhrah.Text; Sakhrah.TextColor = Color.White; Sakhrah.BackgroundColor = Color.FromHex("#FF071D66"); var existingPages = Navigation.NavigationStack.ToList();Page page = existingPages.FirstOrDefault();Navigation.InsertPageBefore(new Home(), page);Navigation.RemovePage(page);await PopupNavigation.Instance.PopAsync(); } else { Constantce.Area = "Area"; Sakhrah.BackgroundColor = Color.White; Sakhrah.TextColor = Color.FromHex("#FF071D66"); } }
        async void Samta_Clicked(object sender, EventArgs e) { if (Samta.BackgroundColor == Color.White) { Constantce.Area = "Samta"; Constantce.AreaLang = Samta.Text; Samta.TextColor = Color.White; Samta.BackgroundColor = Color.FromHex("#FF071D66"); var existingPages = Navigation.NavigationStack.ToList();Page page = existingPages.FirstOrDefault();Navigation.InsertPageBefore(new Home(), page);Navigation.RemovePage(page);await PopupNavigation.Instance.PopAsync(); } else { Constantce.Area = "Area"; Samta.BackgroundColor = Color.White; Samta.TextColor = Color.FromHex("#FF071D66"); } }
        async void Senaar_Clicked(object sender, EventArgs e) { if (Senaar.BackgroundColor == Color.White) { Constantce.Area = "Sena'ar"; Constantce.AreaLang = Senaar.Text; Senaar.TextColor = Color.White; Senaar.BackgroundColor = Color.FromHex("#FF071D66"); var existingPages = Navigation.NavigationStack.ToList();Page page = existingPages.FirstOrDefault();Navigation.InsertPageBefore(new Home(), page);Navigation.RemovePage(page);await PopupNavigation.Instance.PopAsync(); } else { Constantce.Area = "Area"; Senaar.BackgroundColor = Color.White; Senaar.TextColor = Color.FromHex("#FF071D66"); } }
        async void Shkarah_Clicked(object sender, EventArgs e) { if (Shkarah.BackgroundColor == Color.White) { Constantce.Area = "Shkarah"; Constantce.AreaLang = Shkarah.Text; Shkarah.TextColor = Color.White; Shkarah.BackgroundColor = Color.FromHex("#FF071D66"); var existingPages = Navigation.NavigationStack.ToList();Page page = existingPages.FirstOrDefault();Navigation.InsertPageBefore(new Home(), page);Navigation.RemovePage(page);await PopupNavigation.Instance.PopAsync(); } else { Constantce.Area = "Area"; Shkarah.BackgroundColor = Color.White; Shkarah.TextColor = Color.FromHex("#FF071D66"); } }
        async void Shtafaina_Clicked(object sender, EventArgs e) { if (Shtafaina.BackgroundColor == Color.White) { Constantce.Area = "Shtafaina"; Constantce.AreaLang = Shtafaina.Text; Shtafaina.TextColor = Color.White; Shtafaina.BackgroundColor = Color.FromHex("#FF071D66"); var existingPages = Navigation.NavigationStack.ToList();Page page = existingPages.FirstOrDefault();Navigation.InsertPageBefore(new Home(), page);Navigation.RemovePage(page);await PopupNavigation.Instance.PopAsync(); } else { Constantce.Area = "Area"; Shtafaina.BackgroundColor = Color.White; Shtafaina.TextColor = Color.FromHex("#FF071D66"); } }
        async void Sofsafah_Clicked(object sender, EventArgs e) { if (Sofsafah.BackgroundColor == Color.White) { Constantce.Area = "Sofsafah"; Constantce.AreaLang = Sofsafah.Text; Sofsafah.TextColor = Color.White; Sofsafah.BackgroundColor = Color.FromHex("#FF071D66"); var existingPages = Navigation.NavigationStack.ToList();Page page = existingPages.FirstOrDefault();Navigation.InsertPageBefore(new Home(), page);Navigation.RemovePage(page);await PopupNavigation.Instance.PopAsync(); } else { Constantce.Area = "Area"; Sofsafah.BackgroundColor = Color.White; Sofsafah.TextColor = Color.FromHex("#FF071D66"); } }
        async void Sowwan_Clicked(object sender, EventArgs e) { if (Sowwan.BackgroundColor == Color.White) { Constantce.Area = "Sowwan"; Constantce.AreaLang = Sowwan.Text; Sowwan.TextColor = Color.White; Sowwan.BackgroundColor = Color.FromHex("#FF071D66"); var existingPages = Navigation.NavigationStack.ToList();Page page = existingPages.FirstOrDefault();Navigation.InsertPageBefore(new Home(), page);Navigation.RemovePage(page);await PopupNavigation.Instance.PopAsync(); } else { Constantce.Area = "Area"; Sowwan.BackgroundColor = Color.White; Sowwan.TextColor = Color.FromHex("#FF071D66"); } }
        async void Tayyarah_Clicked(object sender, EventArgs e) { if (Tayyarah.BackgroundColor == Color.White) { Constantce.Area = "Tayyarah"; Constantce.AreaLang = Tayyarah.Text; Tayyarah.TextColor = Color.White; Tayyarah.BackgroundColor = Color.FromHex("#FF071D66"); var existingPages = Navigation.NavigationStack.ToList();Page page = existingPages.FirstOrDefault();Navigation.InsertPageBefore(new Home(), page);Navigation.RemovePage(page);await PopupNavigation.Instance.PopAsync(); } else { Constantce.Area = "Area"; Tayyarah.BackgroundColor = Color.White; Tayyarah.TextColor = Color.FromHex("#FF071D66"); } }
        async void ThagretZebaid_Clicked(object sender, EventArgs e) { if (ThagretZebaid.BackgroundColor == Color.White) { Constantce.Area = "Thagret Zebaid"; Constantce.AreaLang = ThagretZebaid.Text; ThagretZebaid.TextColor = Color.White; ThagretZebaid.BackgroundColor = Color.FromHex("#FF071D66"); var existingPages = Navigation.NavigationStack.ToList();Page page = existingPages.FirstOrDefault();Navigation.InsertPageBefore(new Home(), page);Navigation.RemovePage(page);await PopupNavigation.Instance.PopAsync(); } else { Constantce.Area = "Area"; ThagretZebaid.BackgroundColor = Color.White; ThagretZebaid.TextColor = Color.FromHex("#FF071D66"); } }
        async void UmmElKhashab_Clicked(object sender, EventArgs e) { if (UmmElKhashab.BackgroundColor == Color.White) { Constantce.Area = "Umm El - Khashab"; Constantce.AreaLang = UmmElKhashab.Text; UmmElKhashab.TextColor = Color.White; UmmElKhashab.BackgroundColor = Color.FromHex("#FF071D66"); var existingPages = Navigation.NavigationStack.ToList();Page page = existingPages.FirstOrDefault();Navigation.InsertPageBefore(new Home(), page);Navigation.RemovePage(page);await PopupNavigation.Instance.PopAsync(); } else { Constantce.Area = "Area"; UmmElKhashab.BackgroundColor = Color.White; UmmElKhashab.TextColor = Color.FromHex("#FF071D66"); } }
        async void UmmElYanabie_Clicked(object sender, EventArgs e) { if (UmmElYanabie.BackgroundColor == Color.White) { Constantce.Area = "Umm El - Yanabie"; Constantce.AreaLang = UmmElYanabie.Text; UmmElYanabie.TextColor = Color.White; UmmElYanabie.BackgroundColor = Color.FromHex("#FF071D66"); var existingPages = Navigation.NavigationStack.ToList();Page page = existingPages.FirstOrDefault();Navigation.InsertPageBefore(new Home(), page);Navigation.RemovePage(page);await PopupNavigation.Instance.PopAsync(); } else { Constantce.Area = "Area"; UmmElYanabie.BackgroundColor = Color.White; UmmElYanabie.TextColor = Color.FromHex("#FF071D66"); } }
        async void UmmErramel_Clicked(object sender, EventArgs e) { if (UmmErramel.BackgroundColor == Color.White) { Constantce.Area = "Umm Erramel"; Constantce.AreaLang = UmmErramel.Text; UmmErramel.TextColor = Color.White; UmmErramel.BackgroundColor = Color.FromHex("#FF071D66"); var existingPages = Navigation.NavigationStack.ToList();Page page = existingPages.FirstOrDefault();Navigation.InsertPageBefore(new Home(), page);Navigation.RemovePage(page);await PopupNavigation.Instance.PopAsync(); } else { Constantce.Area = "Area"; UmmErramel.BackgroundColor = Color.White; UmmErramel.TextColor = Color.FromHex("#FF071D66"); } }
        async void Wahadneh_Clicked(object sender, EventArgs e) { if (Wahadneh.BackgroundColor == Color.White) { Constantce.Area = "Wahadneh"; Constantce.AreaLang = Wahadneh.Text; Wahadneh.TextColor = Color.White; Wahadneh.BackgroundColor = Color.FromHex("#FF071D66"); var existingPages = Navigation.NavigationStack.ToList();Page page = existingPages.FirstOrDefault();Navigation.InsertPageBefore(new Home(), page);Navigation.RemovePage(page);await PopupNavigation.Instance.PopAsync(); } else { Constantce.Area = "Area"; Wahadneh.BackgroundColor = Color.White; Wahadneh.TextColor = Color.FromHex("#FF071D66"); } }
        async void Zarraah_Clicked(object sender, EventArgs e) { if (Zarraah.BackgroundColor == Color.White) { Constantce.Area = "Zarra'ah"; Constantce.AreaLang = Zarraah.Text; Zarraah.TextColor = Color.White; Zarraah.BackgroundColor = Color.FromHex("#FF071D66"); var existingPages = Navigation.NavigationStack.ToList();Page page = existingPages.FirstOrDefault();Navigation.InsertPageBefore(new Home(), page);Navigation.RemovePage(page);await PopupNavigation.Instance.PopAsync(); } else { Constantce.Area = "Area"; Zarraah.BackgroundColor = Color.White; Zarraah.TextColor = Color.FromHex("#FF071D66"); } }
        async void Zatarah_Clicked(object sender, EventArgs e) { if (Zatarah.BackgroundColor == Color.White) { Constantce.Area = "Za'tarah"; Constantce.AreaLang = Zatarah.Text; Zatarah.TextColor = Color.White; Zatarah.BackgroundColor = Color.FromHex("#FF071D66"); var existingPages = Navigation.NavigationStack.ToList();Page page = existingPages.FirstOrDefault();Navigation.InsertPageBefore(new Home(), page);Navigation.RemovePage(page);await PopupNavigation.Instance.PopAsync(); } else { Constantce.Area = "Area"; Zatarah.BackgroundColor = Color.White; Zatarah.TextColor = Color.FromHex("#FF071D66"); } }

    }
}