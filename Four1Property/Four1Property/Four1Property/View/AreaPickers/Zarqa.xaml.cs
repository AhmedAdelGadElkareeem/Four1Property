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
    public partial class Zarqa : PopupPage
    {
        public Zarqa()
        {
            InitializeComponent();
            if (Application.Current.Properties["Language"].ToString() == "Arabic")
            {
                this.FlowDirection = FlowDirection.RightToLeft;
                UpText.Text = "الرجاء اختيار المنطقة";

                AbuEzzieganAZR.Text = "ابو الزيغان";
                AbuSaiahAZR.Text = "ابو صياح";
                AinElBaidhaAZR.Text = "عين البيضاء";
                AinElHawayaAZR.Text = "عين الحوايا";
                AinElNemrehAZR.Text = "عين النمره";
                AinSaberAZR.Text = "عين صابر";
                AlookAZR.Text = "العالوك";
                AzraqCampAZR.Text = "مخيم الأزرق; المخيزن الغربيه";
                AzraqJanoobiAZR.Text = "الازرق الجنوبي";
                AzraqShamaliAZR.Text = "الازرق الشمالي";
                BierainAZR.Text = "بيرين";
                BierehAZR.Text = "البيرة";
                DabanAZR.Text = "ضبعان";
                DhaythemAZR.Text = "الدهيثم";
                DhlailAZR.Text = "الضليل";
                DoqarahAZR.Text = "دوقره";
                EmiratCampAZR.Text = "مخيم الإمارات; مريجيب الفهود";
                EwailiyyehAZR.Text = "العويلية";
                GhraisehAZR.Text = "غريسه";
                HasabAZR.Text = "الحصب";
                HashimiyyaAZR.Text = "الهاشمية";
                KaedatSelahJawMoafaqSaltiAZR.Text = "قاعدة سلاح الجو";
                KamshahAZR.Text = "الكمشة";
                KhallehAZR.Text = "الخلة";
                KhouAZR.Text = "خو";
                MadenatAlSharqAZR.Text = "مدينة الشرق";
                MakethatAZR.Text = "الماخذات";
                MaqamIsaAZR.Text = "مقام عيسى";
                MasarrahGharbiyyehAZR.Text = "المسرة الغربية";
                MasarrahSharqiyyehAZR.Text = "المسرة الشرقية";
                MazarieElHallabatAZR.Text = "مزارع الحلابات";
                MekmanAZR.Text = "المكمان";
                MerhebAZR.Text = "مرحب";
                NaseryahAZR.Text = "الناصرية";
                OmariAZR.Text = "العمري";
                QaserHallabatElGharbiAZR.Text = "قصر الحلابات الغربي";
                QaserHallabatElSharqiAZR.Text = "قصر الحلابات الشرقي";
                QnayyehAZR.Text = "القنية";
                RahayalAZR.Text = "الرحيل";
                ReyadAZR.Text = "الرياض";
                RojomEshoakAZR.Text = "رجم الشوك";
                RukbanAZR.Text = "الركبان";
                RusseifaAZR.Text = "الرصيفة";
                SaharahAZR.Text = "السحارة";
                SarrootAZR.Text = "صروت";
                SayehDiabAZR.Text = "سايح ذياب";
                SokhnehAZR.Text = "السخنة";
                TafehAZR.Text = "الطافح";
                TawahienAdwanAZR.Text = "طواحين العدوان";
                UmmElByarAZR.Text = "ام البيار";
                UmmElFatierAZR.Text = "ام الفطاير";
                UmmEssalleehAZR.Text = "ام الصليح";
                UmmKhashibehAZR.Text = "ام خشيبة";
                UmmRommanehAZR.Text = "ام رمانه";
                WadiEsswanAZR.Text = "وادي الصوان";
                ZarqaAZR.Text = "الزرقاء";

            }
            else
            {
                this.FlowDirection = FlowDirection.LeftToRight;
                UpText.Text = "Please Select Area";

                AbuEzzieganAZR.Text = "Abu Ezziegan";
                AbuSaiahAZR.Text = "Abu Saiah";
                AinElBaidhaAZR.Text = "Ain El - Baidha";
                AinElHawayaAZR.Text = "Ain El - Hawaya";
                AinElNemrehAZR.Text = "Ain El - Nemreh";
                AinSaberAZR.Text = "Ain Saber";
                AlookAZR.Text = "Alook";
                AzraqCampAZR.Text = "Azraq Camp";
                AzraqJanoobiAZR.Text = "Azraq Janoobi";
                AzraqShamaliAZR.Text = "Azraq Shamali";
                BierainAZR.Text = "Bierain";
                BierehAZR.Text = "Biereh";
                DabanAZR.Text = "Dab'an";
                DhaythemAZR.Text = "Dhaythem";
                DhlailAZR.Text = "Dhlail";
                DoqarahAZR.Text = "Doqarah";
                EmiratCampAZR.Text = "Emirat Camp";
                EwailiyyehAZR.Text = "Ewailiyyeh";
                GhraisehAZR.Text = "Ghraiseh";
                HasabAZR.Text = "Hasab";
                HashimiyyaAZR.Text = "Hashimiyya";
                KaedatSelahJawMoafaqSaltiAZR.Text = "Kaedat Selah Jaw Moafaq Salti";
                KamshahAZR.Text = "Kamshah";
                KhallehAZR.Text = "Khalleh";
                KhouAZR.Text = "Khou";
                MadenatAlSharqAZR.Text = "Madenat Al - Sharq";
                MakethatAZR.Text = "Makethat";
                MaqamIsaAZR.Text = "Maqam Isa";
                MasarrahGharbiyyehAZR.Text = "Masarrah Gharbiyyeh";
                MasarrahSharqiyyehAZR.Text = "Masarrah Sharqiyyeh";
                MazarieElHallabatAZR.Text = "Mazari'e El-Hallabat";
                MekmanAZR.Text = "Mekman";
                MerhebAZR.Text = "Merheb";
                NaseryahAZR.Text = "Naseryah";
                OmariAZR.Text = "Omari";
                QaserHallabatElGharbiAZR.Text = "Qaser Hallabat El-Gharbi";
                QaserHallabatElSharqiAZR.Text = "Qaser Hallabat El-Sharqi";
                QnayyehAZR.Text = "Qnayyeh";
                RahayalAZR.Text = "Rahayal";
                ReyadAZR.Text = "Reyad";
                RojomEshoakAZR.Text = "Rojom Eshoak";
                RukbanAZR.Text = "Rukban";
                RusseifaAZR.Text = "Russeifa";
                SaharahAZR.Text = "Saharah";
                SarrootAZR.Text = "Sarroot";
                SayehDiabAZR.Text = "Sayeh Diab";
                SokhnehAZR.Text = "Sokhneh";
                TafehAZR.Text = "Tafeh";
                TawahienAdwanAZR.Text = "Tawahien Adwan";
                UmmElByarAZR.Text = "Umm El - Byar";
                UmmElFatierAZR.Text = "Umm El - Fat'ier";
                UmmEssalleehAZR.Text = "Umm Essalleeh";
                UmmKhashibehAZR.Text = "Umm Khashibeh";
                UmmRommanehAZR.Text = "Umm Rommaneh";
                WadiEsswanAZR.Text = "Wadi Esswan";
                ZarqaAZR.Text = "Zarqa";


            }

            if (Constantce.Area == "Abu Ezziegan") { AbuEzzieganAZR.BackgroundColor = Color.FromHex("FF071D66"); AbuEzzieganAZR.TextColor = Color.White; }
            else if (Constantce.Area == "Abu Saiah") { AbuSaiahAZR.BackgroundColor = Color.FromHex("FF071D66"); AbuSaiahAZR.TextColor = Color.White; }
            else if (Constantce.Area == "Ain El - Baidha") { AinElBaidhaAZR.BackgroundColor = Color.FromHex("FF071D66"); AinElBaidhaAZR.TextColor = Color.White; }
            else if (Constantce.Area == "Ain El - Hawaya") { AinElHawayaAZR.BackgroundColor = Color.FromHex("FF071D66"); AinElHawayaAZR.TextColor = Color.White; }
            else if (Constantce.Area == "Ain El - Nemreh") { AinElNemrehAZR.BackgroundColor = Color.FromHex("FF071D66"); AinElNemrehAZR.TextColor = Color.White; }
            else if (Constantce.Area == "Ain Saber") { AinSaberAZR.BackgroundColor = Color.FromHex("FF071D66"); AinSaberAZR.TextColor = Color.White; }
            else if (Constantce.Area == "Alook") { AlookAZR.BackgroundColor = Color.FromHex("FF071D66"); AlookAZR.TextColor = Color.White; }
            else if (Constantce.Area == "Azraq Camp") { AzraqCampAZR.BackgroundColor = Color.FromHex("FF071D66"); AzraqCampAZR.TextColor = Color.White; }
            else if (Constantce.Area == "Azraq Janoobi") { AzraqJanoobiAZR.BackgroundColor = Color.FromHex("FF071D66"); AzraqJanoobiAZR.TextColor = Color.White; }
            else if (Constantce.Area == "Azraq Shamali") { AzraqShamaliAZR.BackgroundColor = Color.FromHex("FF071D66"); AzraqShamaliAZR.TextColor = Color.White; }
            else if (Constantce.Area == "Bierain") { BierainAZR.BackgroundColor = Color.FromHex("FF071D66"); BierainAZR.TextColor = Color.White; }
            else if (Constantce.Area == "Biereh") { BierehAZR.BackgroundColor = Color.FromHex("FF071D66"); BierehAZR.TextColor = Color.White; }
            else if (Constantce.Area == "Dab'an") { DabanAZR.BackgroundColor = Color.FromHex("FF071D66"); DabanAZR.TextColor = Color.White; }
            else if (Constantce.Area == "Dhaythem") { DhaythemAZR.BackgroundColor = Color.FromHex("FF071D66"); DhaythemAZR.TextColor = Color.White; }
            else if (Constantce.Area == "Dhlail") { DhlailAZR.BackgroundColor = Color.FromHex("FF071D66"); DhlailAZR.TextColor = Color.White; }
            else if (Constantce.Area == "Doqarah") { DoqarahAZR.BackgroundColor = Color.FromHex("FF071D66"); DoqarahAZR.TextColor = Color.White; }
            else if (Constantce.Area == "Emirat Camp") { EmiratCampAZR.BackgroundColor = Color.FromHex("FF071D66"); EmiratCampAZR.TextColor = Color.White; }
            else if (Constantce.Area == "Ewailiyyeh") { EwailiyyehAZR.BackgroundColor = Color.FromHex("FF071D66"); EwailiyyehAZR.TextColor = Color.White; }
            else if (Constantce.Area == "Ghraiseh") { GhraisehAZR.BackgroundColor = Color.FromHex("FF071D66"); GhraisehAZR.TextColor = Color.White; }
            else if (Constantce.Area == "Hasab") { HasabAZR.BackgroundColor = Color.FromHex("FF071D66"); HasabAZR.TextColor = Color.White; }
            else if (Constantce.Area == "Hashimiyya") { HashimiyyaAZR.BackgroundColor = Color.FromHex("FF071D66"); HashimiyyaAZR.TextColor = Color.White; }
            else if (Constantce.Area == "Kaedat Selah Jaw Moafaq Salti") { KaedatSelahJawMoafaqSaltiAZR.BackgroundColor = Color.FromHex("FF071D66"); KaedatSelahJawMoafaqSaltiAZR.TextColor = Color.White; }
            else if (Constantce.Area == "Kamshah") { KamshahAZR.BackgroundColor = Color.FromHex("FF071D66"); KamshahAZR.TextColor = Color.White; }
            else if (Constantce.Area == "Khalleh") { KhallehAZR.BackgroundColor = Color.FromHex("FF071D66"); KhallehAZR.TextColor = Color.White; }
            else if (Constantce.Area == "Khou") { KhouAZR.BackgroundColor = Color.FromHex("FF071D66"); KhouAZR.TextColor = Color.White; }
            else if (Constantce.Area == "Madenat Al - Sharq") { MadenatAlSharqAZR.BackgroundColor = Color.FromHex("FF071D66"); MadenatAlSharqAZR.TextColor = Color.White; }
            else if (Constantce.Area == "Makethat") { MakethatAZR.BackgroundColor = Color.FromHex("FF071D66"); MakethatAZR.TextColor = Color.White; }
            else if (Constantce.Area == "Maqam Isa") { MaqamIsaAZR.BackgroundColor = Color.FromHex("FF071D66"); MaqamIsaAZR.TextColor = Color.White; }
            else if (Constantce.Area == "Masarrah Gharbiyyeh") { MasarrahGharbiyyehAZR.BackgroundColor = Color.FromHex("FF071D66"); MasarrahGharbiyyehAZR.TextColor = Color.White; }
            else if (Constantce.Area == "Masarrah Sharqiyyeh") { MasarrahSharqiyyehAZR.BackgroundColor = Color.FromHex("FF071D66"); MasarrahSharqiyyehAZR.TextColor = Color.White; }
            else if (Constantce.Area == "Mazari'e El-Hallabat") { MazarieElHallabatAZR.BackgroundColor = Color.FromHex("FF071D66"); MazarieElHallabatAZR.TextColor = Color.White; }
            else if (Constantce.Area == "Mekman") { MekmanAZR.BackgroundColor = Color.FromHex("FF071D66"); MekmanAZR.TextColor = Color.White; }
            else if (Constantce.Area == "Merheb") { MerhebAZR.BackgroundColor = Color.FromHex("FF071D66"); MerhebAZR.TextColor = Color.White; }
            else if (Constantce.Area == "Naseryah") { NaseryahAZR.BackgroundColor = Color.FromHex("FF071D66"); NaseryahAZR.TextColor = Color.White; }
            else if (Constantce.Area == "Omari") { OmariAZR.BackgroundColor = Color.FromHex("FF071D66"); OmariAZR.TextColor = Color.White; }
            else if (Constantce.Area == "Qaser Hallabat El-Gharbi") { QaserHallabatElGharbiAZR.BackgroundColor = Color.FromHex("FF071D66"); QaserHallabatElGharbiAZR.TextColor = Color.White; }
            else if (Constantce.Area == "Qaser Hallabat El-Sharqi") { QaserHallabatElSharqiAZR.BackgroundColor = Color.FromHex("FF071D66"); QaserHallabatElSharqiAZR.TextColor = Color.White; }
            else if (Constantce.Area == "Qnayyeh") { QnayyehAZR.BackgroundColor = Color.FromHex("FF071D66"); QnayyehAZR.TextColor = Color.White; }
            else if (Constantce.Area == "Rahayal") { RahayalAZR.BackgroundColor = Color.FromHex("FF071D66"); RahayalAZR.TextColor = Color.White; }
            else if (Constantce.Area == "Reyad") { ReyadAZR.BackgroundColor = Color.FromHex("FF071D66"); ReyadAZR.TextColor = Color.White; }
            else if (Constantce.Area == "Rojom Eshoak") { RojomEshoakAZR.BackgroundColor = Color.FromHex("FF071D66"); RojomEshoakAZR.TextColor = Color.White; }
            else if (Constantce.Area == "Rukban") { RukbanAZR.BackgroundColor = Color.FromHex("FF071D66"); RukbanAZR.TextColor = Color.White; }
            else if (Constantce.Area == "Russeelse ifa") { RusseifaAZR.BackgroundColor = Color.FromHex("FF071D66"); RusseifaAZR.TextColor = Color.White; }
            else if (Constantce.Area == "Saharah") { SaharahAZR.BackgroundColor = Color.FromHex("FF071D66"); SaharahAZR.TextColor = Color.White; }
            else if (Constantce.Area == "Sarroot") { SarrootAZR.BackgroundColor = Color.FromHex("FF071D66"); SarrootAZR.TextColor = Color.White; }
            else if (Constantce.Area == "Sayeh Diab") { SayehDiabAZR.BackgroundColor = Color.FromHex("FF071D66"); SayehDiabAZR.TextColor = Color.White; }
            else if (Constantce.Area == "Sokhneh") { SokhnehAZR.BackgroundColor = Color.FromHex("FF071D66"); SokhnehAZR.TextColor = Color.White; }
            else if (Constantce.Area == "Tafeh") { TafehAZR.BackgroundColor = Color.FromHex("FF071D66"); TafehAZR.TextColor = Color.White; }
            else if (Constantce.Area == "Tawahien Adwan") { TawahienAdwanAZR.BackgroundColor = Color.FromHex("FF071D66"); TawahienAdwanAZR.TextColor = Color.White; }
            else if (Constantce.Area == "Umm El - Byar") { UmmElByarAZR.BackgroundColor = Color.FromHex("FF071D66"); UmmElByarAZR.TextColor = Color.White; }
            else if (Constantce.Area == "Umm El - Fat'ier") { UmmElFatierAZR.BackgroundColor = Color.FromHex("FF071D66"); UmmElFatierAZR.TextColor = Color.White; }
            else if (Constantce.Area == "Umm Essalleeh") { UmmEssalleehAZR.BackgroundColor = Color.FromHex("FF071D66"); UmmEssalleehAZR.TextColor = Color.White; }
            else if (Constantce.Area == "Umm Khashibeh") { UmmKhashibehAZR.BackgroundColor = Color.FromHex("FF071D66"); UmmKhashibehAZR.TextColor = Color.White; }
            else if (Constantce.Area == "Umm Rommaneh") { UmmRommanehAZR.BackgroundColor = Color.FromHex("FF071D66"); UmmRommanehAZR.TextColor = Color.White; }
            else if (Constantce.Area == "Wadi Esswan") { WadiEsswanAZR.BackgroundColor = Color.FromHex("FF071D66"); WadiEsswanAZR.TextColor = Color.White; }
            else if (Constantce.Area == "Zarqa") { ZarqaAZR.BackgroundColor = Color.FromHex("FF071D66"); ZarqaAZR.TextColor = Color.White; }


        }

        //******************************End zarqa Areas**********************************************************************
        async void AbuEzzieganAZR_Clicked(object sender, EventArgs e)
        {
            if (AbuEzzieganAZR.BackgroundColor == Color.White)
            {
                Constantce.Area = "Abu Ezziegan"; Constantce.AreaLang = AbuEzzieganAZR.Text; AbuEzzieganAZR.TextColor = Color.White; AbuEzzieganAZR.BackgroundColor = Color.FromHex("#FF071D66"); var existingPages = Navigation.NavigationStack.ToList(); await Navigation.PushAsync(new Home()); foreach (var page in existingPages) { Navigation.RemovePage(page); }
                await Task.Delay(80); await PopupNavigation.Instance.PopAsync();
            }
            else { Constantce.Area = "Area"; AbuEzzieganAZR.BackgroundColor = Color.White; AbuEzzieganAZR.TextColor = Color.FromHex("#FF071D66"); }
        }
        async void AbuSaiahAZR_Clicked(object sender, EventArgs e)
        {
            if (AbuSaiahAZR.BackgroundColor == Color.White)
            {
                Constantce.Area = "Abu Saiah"; Constantce.AreaLang = AbuSaiahAZR.Text; AbuSaiahAZR.TextColor = Color.White; AbuSaiahAZR.BackgroundColor = Color.FromHex("#FF071D66"); var existingPages = Navigation.NavigationStack.ToList(); await Navigation.PushAsync(new Home()); foreach (var page in existingPages) { Navigation.RemovePage(page); }
                await Task.Delay(80); await PopupNavigation.Instance.PopAsync();
            }
            else { Constantce.Area = "Area"; AbuSaiahAZR.BackgroundColor = Color.White; AbuSaiahAZR.TextColor = Color.FromHex("#FF071D66"); }
        }
        async void AinElBaidhaAZR_Clicked(object sender, EventArgs e)
        {
            if (AinElBaidhaAZR.BackgroundColor == Color.White)
            {
                Constantce.Area = "Ain El - Baidha"; Constantce.AreaLang = AinElBaidhaAZR.Text; AinElBaidhaAZR.TextColor = Color.White; AinElBaidhaAZR.BackgroundColor = Color.FromHex("#FF071D66"); var existingPages = Navigation.NavigationStack.ToList(); await Navigation.PushAsync(new Home()); foreach (var page in existingPages) { Navigation.RemovePage(page); }
                await Task.Delay(80); await PopupNavigation.Instance.PopAsync();
            }
            else { Constantce.Area = "Area"; AinElBaidhaAZR.BackgroundColor = Color.White; AinElBaidhaAZR.TextColor = Color.FromHex("#FF071D66"); }
        }
        async void AinElHawayaAZR_Clicked(object sender, EventArgs e)
        {
            if (AinElHawayaAZR.BackgroundColor == Color.White)
            {
                Constantce.Area = "Ain El - Hawaya"; Constantce.AreaLang = AinElHawayaAZR.Text; AinElHawayaAZR.TextColor = Color.White; AinElHawayaAZR.BackgroundColor = Color.FromHex("#FF071D66"); var existingPages = Navigation.NavigationStack.ToList(); await Navigation.PushAsync(new Home()); foreach (var page in existingPages) { Navigation.RemovePage(page); }
                await Task.Delay(80); await PopupNavigation.Instance.PopAsync();
            }
            else { Constantce.Area = "Area"; AinElHawayaAZR.BackgroundColor = Color.White; AinElHawayaAZR.TextColor = Color.FromHex("#FF071D66"); }
        }
        async void AinElNemrehAZR_Clicked(object sender, EventArgs e)
        {
            if (AinElNemrehAZR.BackgroundColor == Color.White)
            {
                Constantce.Area = "Ain El - Nemreh"; Constantce.AreaLang = AinElNemrehAZR.Text; AinElNemrehAZR.TextColor = Color.White; AinElNemrehAZR.BackgroundColor = Color.FromHex("#FF071D66"); var existingPages = Navigation.NavigationStack.ToList(); await Navigation.PushAsync(new Home()); foreach (var page in existingPages) { Navigation.RemovePage(page); }
                await Task.Delay(80); await PopupNavigation.Instance.PopAsync();
            }
            else { Constantce.Area = "Area"; AinElNemrehAZR.BackgroundColor = Color.White; AinElNemrehAZR.TextColor = Color.FromHex("#FF071D66"); }
        }
        async void AinSaberAZR_Clicked(object sender, EventArgs e)
        {
            if (AinSaberAZR.BackgroundColor == Color.White)
            {
                Constantce.Area = "Ain Saber"; Constantce.AreaLang = AinSaberAZR.Text; AinSaberAZR.TextColor = Color.White; AinSaberAZR.BackgroundColor = Color.FromHex("#FF071D66"); var existingPages = Navigation.NavigationStack.ToList(); await Navigation.PushAsync(new Home()); foreach (var page in existingPages) { Navigation.RemovePage(page); }
                await Task.Delay(80); await PopupNavigation.Instance.PopAsync();
            }
            else { Constantce.Area = "Area"; AinSaberAZR.BackgroundColor = Color.White; AinSaberAZR.TextColor = Color.FromHex("#FF071D66"); }
        }
        async void AlookAZR_Clicked(object sender, EventArgs e)
        {
            if (AlookAZR.BackgroundColor == Color.White)
            {
                Constantce.Area = "Alook"; Constantce.AreaLang = AlookAZR.Text; AlookAZR.TextColor = Color.White; AlookAZR.BackgroundColor = Color.FromHex("#FF071D66"); var existingPages = Navigation.NavigationStack.ToList(); await Navigation.PushAsync(new Home()); foreach (var page in existingPages) { Navigation.RemovePage(page); }
                await Task.Delay(80); await PopupNavigation.Instance.PopAsync();
            }
            else { Constantce.Area = "Area"; AlookAZR.BackgroundColor = Color.White; AlookAZR.TextColor = Color.FromHex("#FF071D66"); }
        }
        async void AzraqCampAZR_Clicked(object sender, EventArgs e)
        {
            if (AzraqCampAZR.BackgroundColor == Color.White)
            {
                Constantce.Area = "Azraq Camp"; Constantce.AreaLang = AzraqCampAZR.Text; AzraqCampAZR.TextColor = Color.White; AzraqCampAZR.BackgroundColor = Color.FromHex("#FF071D66"); var existingPages = Navigation.NavigationStack.ToList(); await Navigation.PushAsync(new Home()); foreach (var page in existingPages) { Navigation.RemovePage(page); }
                await Task.Delay(80); await PopupNavigation.Instance.PopAsync();
            }
            else { Constantce.Area = "Area"; AzraqCampAZR.BackgroundColor = Color.White; AzraqCampAZR.TextColor = Color.FromHex("#FF071D66"); }
        }
        async void AzraqJanoobiAZR_Clicked(object sender, EventArgs e)
        {
            if (AzraqJanoobiAZR.BackgroundColor == Color.White)
            {
                Constantce.Area = "Azraq Janoobi"; Constantce.AreaLang = AzraqJanoobiAZR.Text; AzraqJanoobiAZR.TextColor = Color.White; AzraqJanoobiAZR.BackgroundColor = Color.FromHex("#FF071D66"); var existingPages = Navigation.NavigationStack.ToList(); await Navigation.PushAsync(new Home()); foreach (var page in existingPages) { Navigation.RemovePage(page); }
                await Task.Delay(80); await PopupNavigation.Instance.PopAsync();
            }
            else { Constantce.Area = "Area"; AzraqJanoobiAZR.BackgroundColor = Color.White; AzraqJanoobiAZR.TextColor = Color.FromHex("#FF071D66"); }
        }
        async void AzraqShamaliAZR_Clicked(object sender, EventArgs e)
        {
            if (AzraqShamaliAZR.BackgroundColor == Color.White)
            {
                Constantce.Area = "Azraq Shamali"; Constantce.AreaLang = AzraqShamaliAZR.Text; AzraqShamaliAZR.TextColor = Color.White; AzraqShamaliAZR.BackgroundColor = Color.FromHex("#FF071D66"); var existingPages = Navigation.NavigationStack.ToList(); await Navigation.PushAsync(new Home()); foreach (var page in existingPages) { Navigation.RemovePage(page); }
                await Task.Delay(80); await PopupNavigation.Instance.PopAsync();
            }
            else { Constantce.Area = "Area"; AzraqShamaliAZR.BackgroundColor = Color.White; AzraqShamaliAZR.TextColor = Color.FromHex("#FF071D66"); }
        }
        async void BierainAZR_Clicked(object sender, EventArgs e)
        {
            if (BierainAZR.BackgroundColor == Color.White)
            {
                Constantce.Area = "Bierain"; Constantce.AreaLang = BierainAZR.Text; BierainAZR.TextColor = Color.White; BierainAZR.BackgroundColor = Color.FromHex("#FF071D66"); var existingPages = Navigation.NavigationStack.ToList(); await Navigation.PushAsync(new Home()); foreach (var page in existingPages) { Navigation.RemovePage(page); }
                await Task.Delay(80); await PopupNavigation.Instance.PopAsync();
            }
            else { Constantce.Area = "Area"; BierainAZR.BackgroundColor = Color.White; BierainAZR.TextColor = Color.FromHex("#FF071D66"); }
        }
        async void BierehAZR_Clicked(object sender, EventArgs e)
        {
            if (BierehAZR.BackgroundColor == Color.White)
            {
                Constantce.Area = "Biereh"; Constantce.AreaLang = BierehAZR.Text; BierehAZR.TextColor = Color.White; BierehAZR.BackgroundColor = Color.FromHex("#FF071D66"); var existingPages = Navigation.NavigationStack.ToList(); await Navigation.PushAsync(new Home()); foreach (var page in existingPages) { Navigation.RemovePage(page); }
                await Task.Delay(80); await PopupNavigation.Instance.PopAsync();
            }
            else { Constantce.Area = "Area"; BierehAZR.BackgroundColor = Color.White; BierehAZR.TextColor = Color.FromHex("#FF071D66"); }
        }
        async void DabanAZR_Clicked(object sender, EventArgs e)
        {
            if (DabanAZR.BackgroundColor == Color.White)
            {
                Constantce.Area = "Dab'an"; Constantce.AreaLang = DabanAZR.Text; DabanAZR.TextColor = Color.White; DabanAZR.BackgroundColor = Color.FromHex("#FF071D66"); var existingPages = Navigation.NavigationStack.ToList(); await Navigation.PushAsync(new Home()); foreach (var page in existingPages) { Navigation.RemovePage(page); }
                await Task.Delay(80); await PopupNavigation.Instance.PopAsync();
            }
            else { Constantce.Area = "Area"; DabanAZR.BackgroundColor = Color.White; DabanAZR.TextColor = Color.FromHex("#FF071D66"); }
        }
        async void DhaythemAZR_Clicked(object sender, EventArgs e)
        {
            if (DhaythemAZR.BackgroundColor == Color.White)
            {
                Constantce.Area = "Dhaythem"; Constantce.AreaLang = DhaythemAZR.Text; DhaythemAZR.TextColor = Color.White; DhaythemAZR.BackgroundColor = Color.FromHex("#FF071D66"); var existingPages = Navigation.NavigationStack.ToList(); await Navigation.PushAsync(new Home()); foreach (var page in existingPages) { Navigation.RemovePage(page); }
                await Task.Delay(80); await PopupNavigation.Instance.PopAsync();
            }
            else { Constantce.Area = "Area"; DhaythemAZR.BackgroundColor = Color.White; DhaythemAZR.TextColor = Color.FromHex("#FF071D66"); }
        }
        async void DhlailAZR_Clicked(object sender, EventArgs e)
        {
            if (DhlailAZR.BackgroundColor == Color.White)
            {
                Constantce.Area = "Dhlail"; Constantce.AreaLang = DhlailAZR.Text; DhlailAZR.TextColor = Color.White; DhlailAZR.BackgroundColor = Color.FromHex("#FF071D66"); var existingPages = Navigation.NavigationStack.ToList(); await Navigation.PushAsync(new Home()); foreach (var page in existingPages) { Navigation.RemovePage(page); }
                await Task.Delay(80); await PopupNavigation.Instance.PopAsync();
            }
            else { Constantce.Area = "Area"; DhlailAZR.BackgroundColor = Color.White; DhlailAZR.TextColor = Color.FromHex("#FF071D66"); }
        }
        async void DoqarahAZR_Clicked(object sender, EventArgs e)
        {
            if (DoqarahAZR.BackgroundColor == Color.White)
            {
                Constantce.Area = "Doqarah"; Constantce.AreaLang = DoqarahAZR.Text; DoqarahAZR.TextColor = Color.White; DoqarahAZR.BackgroundColor = Color.FromHex("#FF071D66"); var existingPages = Navigation.NavigationStack.ToList(); await Navigation.PushAsync(new Home()); foreach (var page in existingPages) { Navigation.RemovePage(page); }
                await Task.Delay(80); await PopupNavigation.Instance.PopAsync();
            }
            else { Constantce.Area = "Area"; DoqarahAZR.BackgroundColor = Color.White; DoqarahAZR.TextColor = Color.FromHex("#FF071D66"); }
        }
        async void EmiratCampAZR_Clicked(object sender, EventArgs e)
        {
            if (EmiratCampAZR.BackgroundColor == Color.White)
            {
                Constantce.Area = "Emirat Camp"; Constantce.AreaLang = EmiratCampAZR.Text; EmiratCampAZR.TextColor = Color.White; EmiratCampAZR.BackgroundColor = Color.FromHex("#FF071D66"); var existingPages = Navigation.NavigationStack.ToList(); await Navigation.PushAsync(new Home()); foreach (var page in existingPages) { Navigation.RemovePage(page); }
                await Task.Delay(80); await PopupNavigation.Instance.PopAsync();
            }
            else { Constantce.Area = "Area"; EmiratCampAZR.BackgroundColor = Color.White; EmiratCampAZR.TextColor = Color.FromHex("#FF071D66"); }
        }
        async void EwailiyyehAZR_Clicked(object sender, EventArgs e)
        {
            if (EwailiyyehAZR.BackgroundColor == Color.White)
            {
                Constantce.Area = "Ewailiyyeh"; Constantce.AreaLang = EwailiyyehAZR.Text; EwailiyyehAZR.TextColor = Color.White; EwailiyyehAZR.BackgroundColor = Color.FromHex("#FF071D66"); var existingPages = Navigation.NavigationStack.ToList(); await Navigation.PushAsync(new Home()); foreach (var page in existingPages) { Navigation.RemovePage(page); }
                await Task.Delay(80); await PopupNavigation.Instance.PopAsync();
            }
            else { Constantce.Area = "Area"; EwailiyyehAZR.BackgroundColor = Color.White; EwailiyyehAZR.TextColor = Color.FromHex("#FF071D66"); }
        }
        async void GhraisehAZR_Clicked(object sender, EventArgs e)
        {
            if (GhraisehAZR.BackgroundColor == Color.White)
            {
                Constantce.Area = "Ghraiseh"; Constantce.AreaLang = GhraisehAZR.Text; GhraisehAZR.TextColor = Color.White; GhraisehAZR.BackgroundColor = Color.FromHex("#FF071D66"); var existingPages = Navigation.NavigationStack.ToList(); await Navigation.PushAsync(new Home()); foreach (var page in existingPages) { Navigation.RemovePage(page); }
                await Task.Delay(80); await PopupNavigation.Instance.PopAsync();
            }
            else { Constantce.Area = "Area"; GhraisehAZR.BackgroundColor = Color.White; GhraisehAZR.TextColor = Color.FromHex("#FF071D66"); }
        }
        async void HasabAZR_Clicked(object sender, EventArgs e)
        {
            if (HasabAZR.BackgroundColor == Color.White)
            {
                Constantce.Area = "Hasab"; Constantce.AreaLang = HasabAZR.Text; HasabAZR.TextColor = Color.White; HasabAZR.BackgroundColor = Color.FromHex("#FF071D66"); var existingPages = Navigation.NavigationStack.ToList(); await Navigation.PushAsync(new Home()); foreach (var page in existingPages) { Navigation.RemovePage(page); }
                await Task.Delay(80); await PopupNavigation.Instance.PopAsync();
            }
            else { Constantce.Area = "Area"; HasabAZR.BackgroundColor = Color.White; HasabAZR.TextColor = Color.FromHex("#FF071D66"); }
        }
        async void HashimiyyaAZR_Clicked(object sender, EventArgs e)
        {
            if (HashimiyyaAZR.BackgroundColor == Color.White)
            {
                Constantce.Area = "Hashimiyya"; Constantce.AreaLang = HashimiyyaAZR.Text; HashimiyyaAZR.TextColor = Color.White; HashimiyyaAZR.BackgroundColor = Color.FromHex("#FF071D66"); var existingPages = Navigation.NavigationStack.ToList(); await Navigation.PushAsync(new Home()); foreach (var page in existingPages) { Navigation.RemovePage(page); }
                await Task.Delay(80); await PopupNavigation.Instance.PopAsync();
            }
            else { Constantce.Area = "Area"; HashimiyyaAZR.BackgroundColor = Color.White; HashimiyyaAZR.TextColor = Color.FromHex("#FF071D66"); }
        }
        async void KaedatSelahJawMoafaqSaltiAZR_Clicked(object sender, EventArgs e)
        {
            if (KaedatSelahJawMoafaqSaltiAZR.BackgroundColor == Color.White)
            {
                Constantce.Area = "Kaedat Selah Jaw Moafaq Salti"; Constantce.AreaLang = KaedatSelahJawMoafaqSaltiAZR.Text; KaedatSelahJawMoafaqSaltiAZR.TextColor = Color.White; KaedatSelahJawMoafaqSaltiAZR.BackgroundColor = Color.FromHex("#FF071D66"); var existingPages = Navigation.NavigationStack.ToList(); await Navigation.PushAsync(new Home()); foreach (var page in existingPages) { Navigation.RemovePage(page); }
                await Task.Delay(80); await PopupNavigation.Instance.PopAsync();
            }
            else { Constantce.Area = "Area"; KaedatSelahJawMoafaqSaltiAZR.BackgroundColor = Color.White; KaedatSelahJawMoafaqSaltiAZR.TextColor = Color.FromHex("#FF071D66"); }
        }
        async void KamshahAZR_Clicked(object sender, EventArgs e)
        {
            if (KamshahAZR.BackgroundColor == Color.White)
            {
                Constantce.Area = "Kamshah"; Constantce.AreaLang = KamshahAZR.Text; KamshahAZR.TextColor = Color.White; KamshahAZR.BackgroundColor = Color.FromHex("#FF071D66"); var existingPages = Navigation.NavigationStack.ToList(); await Navigation.PushAsync(new Home()); foreach (var page in existingPages) { Navigation.RemovePage(page); }
                await Task.Delay(80); await PopupNavigation.Instance.PopAsync();
            }
            else { Constantce.Area = "Area"; KamshahAZR.BackgroundColor = Color.White; KamshahAZR.TextColor = Color.FromHex("#FF071D66"); }
        }
        async void KhallehAZR_Clicked(object sender, EventArgs e)
        {
            if (KhallehAZR.BackgroundColor == Color.White)
            {
                Constantce.Area = "Khalleh"; Constantce.AreaLang = KhallehAZR.Text; KhallehAZR.TextColor = Color.White; KhallehAZR.BackgroundColor = Color.FromHex("#FF071D66"); var existingPages = Navigation.NavigationStack.ToList(); await Navigation.PushAsync(new Home()); foreach (var page in existingPages) { Navigation.RemovePage(page); }
                await Task.Delay(80); await PopupNavigation.Instance.PopAsync();
            }
            else { Constantce.Area = "Area"; KhallehAZR.BackgroundColor = Color.White; KhallehAZR.TextColor = Color.FromHex("#FF071D66"); }
        }
        async void KhouAZR_Clicked(object sender, EventArgs e)
        {
            if (KhouAZR.BackgroundColor == Color.White)
            {
                Constantce.Area = "Khou"; Constantce.AreaLang = KhouAZR.Text; KhouAZR.TextColor = Color.White; KhouAZR.BackgroundColor = Color.FromHex("#FF071D66"); var existingPages = Navigation.NavigationStack.ToList(); await Navigation.PushAsync(new Home()); foreach (var page in existingPages) { Navigation.RemovePage(page); }
                await Task.Delay(80); await PopupNavigation.Instance.PopAsync();
            }
            else { Constantce.Area = "Area"; KhouAZR.BackgroundColor = Color.White; KhouAZR.TextColor = Color.FromHex("#FF071D66"); }
        }
        async void MadenatAlSharqAZR_Clicked(object sender, EventArgs e)
        {
            if (MadenatAlSharqAZR.BackgroundColor == Color.White)
            {
                Constantce.Area = "Madenat Al - Sharq"; Constantce.AreaLang = MadenatAlSharqAZR.Text; MadenatAlSharqAZR.TextColor = Color.White; MadenatAlSharqAZR.BackgroundColor = Color.FromHex("#FF071D66"); var existingPages = Navigation.NavigationStack.ToList(); await Navigation.PushAsync(new Home()); foreach (var page in existingPages) { Navigation.RemovePage(page); }
                await Task.Delay(80); await PopupNavigation.Instance.PopAsync();
            }
            else { Constantce.Area = "Area"; MadenatAlSharqAZR.BackgroundColor = Color.White; MadenatAlSharqAZR.TextColor = Color.FromHex("#FF071D66"); }
        }
        async void MakethatAZR_Clicked(object sender, EventArgs e)
        {
            if (MakethatAZR.BackgroundColor == Color.White)
            {
                Constantce.Area = "Makethat"; Constantce.AreaLang = MakethatAZR.Text; MakethatAZR.TextColor = Color.White; MakethatAZR.BackgroundColor = Color.FromHex("#FF071D66"); var existingPages = Navigation.NavigationStack.ToList(); await Navigation.PushAsync(new Home()); foreach (var page in existingPages) { Navigation.RemovePage(page); }
                await Task.Delay(80); await PopupNavigation.Instance.PopAsync();
            }
            else { Constantce.Area = "Area"; MakethatAZR.BackgroundColor = Color.White; MakethatAZR.TextColor = Color.FromHex("#FF071D66"); }
        }
        async void MaqamIsaAZR_Clicked(object sender, EventArgs e)
        {
            if (MaqamIsaAZR.BackgroundColor == Color.White)
            {
                Constantce.Area = "Maqam Isa"; Constantce.AreaLang = MaqamIsaAZR.Text; MaqamIsaAZR.TextColor = Color.White; MaqamIsaAZR.BackgroundColor = Color.FromHex("#FF071D66"); var existingPages = Navigation.NavigationStack.ToList(); await Navigation.PushAsync(new Home()); foreach (var page in existingPages) { Navigation.RemovePage(page); }
                await Task.Delay(80); await PopupNavigation.Instance.PopAsync();
            }
            else { Constantce.Area = "Area"; MaqamIsaAZR.BackgroundColor = Color.White; MaqamIsaAZR.TextColor = Color.FromHex("#FF071D66"); }
        }
        async void MasarrahGharbiyyehAZR_Clicked(object sender, EventArgs e)
        {
            if (MasarrahGharbiyyehAZR.BackgroundColor == Color.White)
            {
                Constantce.Area = "Masarrah Gharbiyyeh"; Constantce.AreaLang = MasarrahGharbiyyehAZR.Text; MasarrahGharbiyyehAZR.TextColor = Color.White; MasarrahGharbiyyehAZR.BackgroundColor = Color.FromHex("#FF071D66"); var existingPages = Navigation.NavigationStack.ToList(); await Navigation.PushAsync(new Home()); foreach (var page in existingPages) { Navigation.RemovePage(page); }
                await Task.Delay(80); await PopupNavigation.Instance.PopAsync();
            }
            else { Constantce.Area = "Area"; MasarrahGharbiyyehAZR.BackgroundColor = Color.White; MasarrahGharbiyyehAZR.TextColor = Color.FromHex("#FF071D66"); }
        }
        async void MasarrahSharqiyyehAZR_Clicked(object sender, EventArgs e)
        {
            if (MasarrahSharqiyyehAZR.BackgroundColor == Color.White)
            {
                Constantce.Area = "Masarrah Sharqiyyeh"; Constantce.AreaLang = MasarrahSharqiyyehAZR.Text; MasarrahSharqiyyehAZR.TextColor = Color.White; MasarrahSharqiyyehAZR.BackgroundColor = Color.FromHex("#FF071D66"); var existingPages = Navigation.NavigationStack.ToList(); await Navigation.PushAsync(new Home()); foreach (var page in existingPages) { Navigation.RemovePage(page); }
                await Task.Delay(80); await PopupNavigation.Instance.PopAsync();
            }
            else { Constantce.Area = "Area"; MasarrahSharqiyyehAZR.BackgroundColor = Color.White; MasarrahSharqiyyehAZR.TextColor = Color.FromHex("#FF071D66"); }
        }
        async void MazarieElHallabatAZR_Clicked(object sender, EventArgs e)
        {
            if (MazarieElHallabatAZR.BackgroundColor == Color.White)
            {
                Constantce.Area = "Mazari'e El-Hallabat"; Constantce.AreaLang = MazarieElHallabatAZR.Text; MazarieElHallabatAZR.TextColor = Color.White; MazarieElHallabatAZR.BackgroundColor = Color.FromHex("#FF071D66"); var existingPages = Navigation.NavigationStack.ToList(); await Navigation.PushAsync(new Home()); foreach (var page in existingPages) { Navigation.RemovePage(page); }
                await Task.Delay(80); await PopupNavigation.Instance.PopAsync();
            }
            else { Constantce.Area = "Area"; MazarieElHallabatAZR.BackgroundColor = Color.White; MazarieElHallabatAZR.TextColor = Color.FromHex("#FF071D66"); }
        }
        async void MekmanAZR_Clicked(object sender, EventArgs e)
        {
            if (MekmanAZR.BackgroundColor == Color.White)
            {
                Constantce.Area = "Mekman"; Constantce.AreaLang = MekmanAZR.Text; MekmanAZR.TextColor = Color.White; MekmanAZR.BackgroundColor = Color.FromHex("#FF071D66"); var existingPages = Navigation.NavigationStack.ToList(); await Navigation.PushAsync(new Home()); foreach (var page in existingPages) { Navigation.RemovePage(page); }
                await Task.Delay(80); await PopupNavigation.Instance.PopAsync();
            }
            else { Constantce.Area = "Area"; MekmanAZR.BackgroundColor = Color.White; MekmanAZR.TextColor = Color.FromHex("#FF071D66"); }
        }
        async void MerhebAZR_Clicked(object sender, EventArgs e)
        {
            if (MerhebAZR.BackgroundColor == Color.White)
            {
                Constantce.Area = "Merheb"; Constantce.AreaLang = MerhebAZR.Text; MerhebAZR.TextColor = Color.White; MerhebAZR.BackgroundColor = Color.FromHex("#FF071D66"); var existingPages = Navigation.NavigationStack.ToList(); await Navigation.PushAsync(new Home()); foreach (var page in existingPages) { Navigation.RemovePage(page); }
                await Task.Delay(80); await PopupNavigation.Instance.PopAsync();
            }
            else { Constantce.Area = "Area"; MerhebAZR.BackgroundColor = Color.White; MerhebAZR.TextColor = Color.FromHex("#FF071D66"); }
        }
        async void NaseryahAZR_Clicked(object sender, EventArgs e)
        {
            if (NaseryahAZR.BackgroundColor == Color.White)
            {
                Constantce.Area = "Naseryah"; Constantce.AreaLang = NaseryahAZR.Text; NaseryahAZR.TextColor = Color.White; NaseryahAZR.BackgroundColor = Color.FromHex("#FF071D66"); var existingPages = Navigation.NavigationStack.ToList(); await Navigation.PushAsync(new Home()); foreach (var page in existingPages) { Navigation.RemovePage(page); }
                await Task.Delay(80); await PopupNavigation.Instance.PopAsync();
            }
            else { Constantce.Area = "Area"; NaseryahAZR.BackgroundColor = Color.White; NaseryahAZR.TextColor = Color.FromHex("#FF071D66"); }
        }
        async void OmariAZR_Clicked(object sender, EventArgs e)
        {
            if (OmariAZR.BackgroundColor == Color.White)
            {
                Constantce.Area = "Omari"; Constantce.AreaLang = OmariAZR.Text; OmariAZR.TextColor = Color.White; OmariAZR.BackgroundColor = Color.FromHex("#FF071D66"); var existingPages = Navigation.NavigationStack.ToList(); await Navigation.PushAsync(new Home()); foreach (var page in existingPages) { Navigation.RemovePage(page); }
                await Task.Delay(80); await PopupNavigation.Instance.PopAsync();
            }
            else { Constantce.Area = "Area"; OmariAZR.BackgroundColor = Color.White; OmariAZR.TextColor = Color.FromHex("#FF071D66"); }
        }
        async void QaserHallabatElGharbiAZR_Clicked(object sender, EventArgs e)
        {
            if (QaserHallabatElGharbiAZR.BackgroundColor == Color.White)
            {
                Constantce.Area = "Qaser Hallabat El-Gharbi"; Constantce.AreaLang = QaserHallabatElGharbiAZR.Text; QaserHallabatElGharbiAZR.TextColor = Color.White; QaserHallabatElGharbiAZR.BackgroundColor = Color.FromHex("#FF071D66"); var existingPages = Navigation.NavigationStack.ToList(); await Navigation.PushAsync(new Home()); foreach (var page in existingPages) { Navigation.RemovePage(page); }
                await Task.Delay(80); await PopupNavigation.Instance.PopAsync();
            }
            else { Constantce.Area = "Area"; QaserHallabatElGharbiAZR.BackgroundColor = Color.White; QaserHallabatElGharbiAZR.TextColor = Color.FromHex("#FF071D66"); }
        }
        async void QaserHallabatElSharqiAZR_Clicked(object sender, EventArgs e)
        {
            if (QaserHallabatElSharqiAZR.BackgroundColor == Color.White)
            {
                Constantce.Area = "Qaser Hallabat El-Sharqi"; Constantce.AreaLang = QaserHallabatElSharqiAZR.Text; QaserHallabatElSharqiAZR.TextColor = Color.White; QaserHallabatElSharqiAZR.BackgroundColor = Color.FromHex("#FF071D66"); var existingPages = Navigation.NavigationStack.ToList(); await Navigation.PushAsync(new Home()); foreach (var page in existingPages) { Navigation.RemovePage(page); }
                await Task.Delay(80); await PopupNavigation.Instance.PopAsync();
            }
            else { Constantce.Area = "Area"; QaserHallabatElSharqiAZR.BackgroundColor = Color.White; QaserHallabatElSharqiAZR.TextColor = Color.FromHex("#FF071D66"); }
        }
        async void QnayyehAZR_Clicked(object sender, EventArgs e)
        {
            if (QnayyehAZR.BackgroundColor == Color.White)
            {
                Constantce.Area = "Qnayyeh"; Constantce.AreaLang = QnayyehAZR.Text; QnayyehAZR.TextColor = Color.White; QnayyehAZR.BackgroundColor = Color.FromHex("#FF071D66"); var existingPages = Navigation.NavigationStack.ToList(); await Navigation.PushAsync(new Home()); foreach (var page in existingPages) { Navigation.RemovePage(page); }
                await Task.Delay(80); await PopupNavigation.Instance.PopAsync();
            }
            else { Constantce.Area = "Area"; QnayyehAZR.BackgroundColor = Color.White; QnayyehAZR.TextColor = Color.FromHex("#FF071D66"); }
        }
        async void RahayalAZR_Clicked(object sender, EventArgs e)
        {
            if (RahayalAZR.BackgroundColor == Color.White)
            {
                Constantce.Area = "Rahayal"; Constantce.AreaLang = RahayalAZR.Text; RahayalAZR.TextColor = Color.White; RahayalAZR.BackgroundColor = Color.FromHex("#FF071D66"); var existingPages = Navigation.NavigationStack.ToList(); await Navigation.PushAsync(new Home()); foreach (var page in existingPages) { Navigation.RemovePage(page); }
                await Task.Delay(80); await PopupNavigation.Instance.PopAsync();
            }
            else { Constantce.Area = "Area"; RahayalAZR.BackgroundColor = Color.White; RahayalAZR.TextColor = Color.FromHex("#FF071D66"); }
        }
        async void ReyadAZR_Clicked(object sender, EventArgs e)
        {
            if (ReyadAZR.BackgroundColor == Color.White)
            {
                Constantce.Area = "Reyad"; Constantce.AreaLang = ReyadAZR.Text; ReyadAZR.TextColor = Color.White; ReyadAZR.BackgroundColor = Color.FromHex("#FF071D66"); var existingPages = Navigation.NavigationStack.ToList(); await Navigation.PushAsync(new Home()); foreach (var page in existingPages) { Navigation.RemovePage(page); }
                await Task.Delay(80); await PopupNavigation.Instance.PopAsync();
            }
            else { Constantce.Area = "Area"; ReyadAZR.BackgroundColor = Color.White; ReyadAZR.TextColor = Color.FromHex("#FF071D66"); }
        }
        async void RojomEshoakAZR_Clicked(object sender, EventArgs e)
        {
            if (RojomEshoakAZR.BackgroundColor == Color.White)
            {
                Constantce.Area = "Rojom Eshoak"; Constantce.AreaLang = RojomEshoakAZR.Text; RojomEshoakAZR.TextColor = Color.White; RojomEshoakAZR.BackgroundColor = Color.FromHex("#FF071D66"); var existingPages = Navigation.NavigationStack.ToList(); await Navigation.PushAsync(new Home()); foreach (var page in existingPages) { Navigation.RemovePage(page); }
                await Task.Delay(80); await PopupNavigation.Instance.PopAsync();
            }
            else { Constantce.Area = "Area"; RojomEshoakAZR.BackgroundColor = Color.White; RojomEshoakAZR.TextColor = Color.FromHex("#FF071D66"); }
        }
        async void RukbanAZR_Clicked(object sender, EventArgs e)
        {
            if (RukbanAZR.BackgroundColor == Color.White)
            {
                Constantce.Area = "Rukban"; Constantce.AreaLang = RukbanAZR.Text; RukbanAZR.TextColor = Color.White; RukbanAZR.BackgroundColor = Color.FromHex("#FF071D66"); var existingPages = Navigation.NavigationStack.ToList(); await Navigation.PushAsync(new Home()); foreach (var page in existingPages) { Navigation.RemovePage(page); }
                await Task.Delay(80); await PopupNavigation.Instance.PopAsync();
            }
            else { Constantce.Area = "Area"; RukbanAZR.BackgroundColor = Color.White; RukbanAZR.TextColor = Color.FromHex("#FF071D66"); }
        }
        async void RusseifaAZR_Clicked(object sender, EventArgs e)
        {
            if (RusseifaAZR.BackgroundColor == Color.White)
            {
                Constantce.Area = "Russeifa"; Constantce.AreaLang = RusseifaAZR.Text; RusseifaAZR.TextColor = Color.White; RusseifaAZR.BackgroundColor = Color.FromHex("#FF071D66"); var existingPages = Navigation.NavigationStack.ToList(); await Navigation.PushAsync(new Home()); foreach (var page in existingPages) { Navigation.RemovePage(page); }
                await Task.Delay(80); await PopupNavigation.Instance.PopAsync();
            }
            else { Constantce.Area = "Area"; RusseifaAZR.BackgroundColor = Color.White; RusseifaAZR.TextColor = Color.FromHex("#FF071D66"); }
        }
        async void SaharahAZR_Clicked(object sender, EventArgs e)
        {
            if (SaharahAZR.BackgroundColor == Color.White)
            {
                Constantce.Area = "Saharah"; Constantce.AreaLang = SaharahAZR.Text; SaharahAZR.TextColor = Color.White; SaharahAZR.BackgroundColor = Color.FromHex("#FF071D66"); var existingPages = Navigation.NavigationStack.ToList(); await Navigation.PushAsync(new Home()); foreach (var page in existingPages) { Navigation.RemovePage(page); }
                await Task.Delay(80); await PopupNavigation.Instance.PopAsync();
            }
            else { Constantce.Area = "Area"; SaharahAZR.BackgroundColor = Color.White; SaharahAZR.TextColor = Color.FromHex("#FF071D66"); }
        }
        async void SarrootAZR_Clicked(object sender, EventArgs e)
        {
            if (SarrootAZR.BackgroundColor == Color.White)
            {
                Constantce.Area = "Sarroot"; Constantce.AreaLang = SarrootAZR.Text; SarrootAZR.TextColor = Color.White; SarrootAZR.BackgroundColor = Color.FromHex("#FF071D66"); var existingPages = Navigation.NavigationStack.ToList(); await Navigation.PushAsync(new Home()); foreach (var page in existingPages) { Navigation.RemovePage(page); }
                await Task.Delay(80); await PopupNavigation.Instance.PopAsync();
            }
            else { Constantce.Area = "Area"; SarrootAZR.BackgroundColor = Color.White; SarrootAZR.TextColor = Color.FromHex("#FF071D66"); }
        }
        async void SayehDiabAZR_Clicked(object sender, EventArgs e)
        {
            if (SayehDiabAZR.BackgroundColor == Color.White)
            {
                Constantce.Area = "Sayeh Diab"; Constantce.AreaLang = SayehDiabAZR.Text; SayehDiabAZR.TextColor = Color.White; SayehDiabAZR.BackgroundColor = Color.FromHex("#FF071D66"); var existingPages = Navigation.NavigationStack.ToList(); await Navigation.PushAsync(new Home()); foreach (var page in existingPages) { Navigation.RemovePage(page); }
                await Task.Delay(80); await PopupNavigation.Instance.PopAsync();
            }
            else { Constantce.Area = "Area"; SayehDiabAZR.BackgroundColor = Color.White; SayehDiabAZR.TextColor = Color.FromHex("#FF071D66"); }
        }
        async void SokhnehAZR_Clicked(object sender, EventArgs e)
        {
            if (SokhnehAZR.BackgroundColor == Color.White)
            {
                Constantce.Area = "Sokhneh"; Constantce.AreaLang = SokhnehAZR.Text; SokhnehAZR.TextColor = Color.White; SokhnehAZR.BackgroundColor = Color.FromHex("#FF071D66"); var existingPages = Navigation.NavigationStack.ToList(); await Navigation.PushAsync(new Home()); foreach (var page in existingPages) { Navigation.RemovePage(page); }
                await Task.Delay(80); await PopupNavigation.Instance.PopAsync();
            }
            else { Constantce.Area = "Area"; SokhnehAZR.BackgroundColor = Color.White; SokhnehAZR.TextColor = Color.FromHex("#FF071D66"); }
        }
        async void TafehAZR_Clicked(object sender, EventArgs e)
        {
            if (TafehAZR.BackgroundColor == Color.White)
            {
                Constantce.Area = "Tafeh"; Constantce.AreaLang = TafehAZR.Text; TafehAZR.TextColor = Color.White; TafehAZR.BackgroundColor = Color.FromHex("#FF071D66"); var existingPages = Navigation.NavigationStack.ToList(); await Navigation.PushAsync(new Home()); foreach (var page in existingPages) { Navigation.RemovePage(page); }
                await Task.Delay(80); await PopupNavigation.Instance.PopAsync();
            }
            else { Constantce.Area = "Area"; TafehAZR.BackgroundColor = Color.White; TafehAZR.TextColor = Color.FromHex("#FF071D66"); }
        }
        async void TawahienAdwanAZR_Clicked(object sender, EventArgs e)
        {
            if (TawahienAdwanAZR.BackgroundColor == Color.White)
            {
                Constantce.Area = "Tawahien Adwan"; Constantce.AreaLang = TawahienAdwanAZR.Text; TawahienAdwanAZR.TextColor = Color.White; TawahienAdwanAZR.BackgroundColor = Color.FromHex("#FF071D66"); var existingPages = Navigation.NavigationStack.ToList(); await Navigation.PushAsync(new Home()); foreach (var page in existingPages) { Navigation.RemovePage(page); }
                await Task.Delay(80); await PopupNavigation.Instance.PopAsync();
            }
            else { Constantce.Area = "Area"; TawahienAdwanAZR.BackgroundColor = Color.White; TawahienAdwanAZR.TextColor = Color.FromHex("#FF071D66"); }
        }
        async void UmmElByarAZR_Clicked(object sender, EventArgs e)
        {
            if (UmmElByarAZR.BackgroundColor == Color.White)
            {
                Constantce.Area = "Umm El - Byar"; Constantce.AreaLang = UmmElByarAZR.Text; UmmElByarAZR.TextColor = Color.White; UmmElByarAZR.BackgroundColor = Color.FromHex("#FF071D66"); var existingPages = Navigation.NavigationStack.ToList(); await Navigation.PushAsync(new Home()); foreach (var page in existingPages) { Navigation.RemovePage(page); }
                await Task.Delay(80); await PopupNavigation.Instance.PopAsync();
            }
            else { Constantce.Area = "Area"; UmmElByarAZR.BackgroundColor = Color.White; UmmElByarAZR.TextColor = Color.FromHex("#FF071D66"); }
        }
        async void UmmElFatierAZR_Clicked(object sender, EventArgs e)
        {
            if (UmmElFatierAZR.BackgroundColor == Color.White)
            {
                Constantce.Area = "Umm El - Fat'ier"; Constantce.AreaLang = UmmElFatierAZR.Text; UmmElFatierAZR.TextColor = Color.White; UmmElFatierAZR.BackgroundColor = Color.FromHex("#FF071D66"); var existingPages = Navigation.NavigationStack.ToList(); await Navigation.PushAsync(new Home()); foreach (var page in existingPages) { Navigation.RemovePage(page); }
                await Task.Delay(80); await PopupNavigation.Instance.PopAsync();
            }
            else { Constantce.Area = "Area"; UmmElFatierAZR.BackgroundColor = Color.White; UmmElFatierAZR.TextColor = Color.FromHex("#FF071D66"); }
        }
        async void UmmEssalleehAZR_Clicked(object sender, EventArgs e)
        {
            if (UmmEssalleehAZR.BackgroundColor == Color.White)
            {
                Constantce.Area = "Umm Essalleeh"; Constantce.AreaLang = UmmEssalleehAZR.Text; UmmEssalleehAZR.TextColor = Color.White; UmmEssalleehAZR.BackgroundColor = Color.FromHex("#FF071D66"); var existingPages = Navigation.NavigationStack.ToList(); await Navigation.PushAsync(new Home()); foreach (var page in existingPages) { Navigation.RemovePage(page); }
                await Task.Delay(80); await PopupNavigation.Instance.PopAsync();
            }
            else { Constantce.Area = "Area"; UmmEssalleehAZR.BackgroundColor = Color.White; UmmEssalleehAZR.TextColor = Color.FromHex("#FF071D66"); }
        }
        async void UmmKhashibehAZR_Clicked(object sender, EventArgs e)
        {
            if (UmmKhashibehAZR.BackgroundColor == Color.White)
            {
                Constantce.Area = "Umm Khashibeh"; Constantce.AreaLang = UmmKhashibehAZR.Text; UmmKhashibehAZR.TextColor = Color.White; UmmKhashibehAZR.BackgroundColor = Color.FromHex("#FF071D66"); var existingPages = Navigation.NavigationStack.ToList(); await Navigation.PushAsync(new Home()); foreach (var page in existingPages) { Navigation.RemovePage(page); }
                await Task.Delay(80); await PopupNavigation.Instance.PopAsync();
            }
            else { Constantce.Area = "Area"; UmmKhashibehAZR.BackgroundColor = Color.White; UmmKhashibehAZR.TextColor = Color.FromHex("#FF071D66"); }
        }
        async void UmmRommanehAZR_Clicked(object sender, EventArgs e)
        {
            if (UmmRommanehAZR.BackgroundColor == Color.White)
            {
                Constantce.Area = "Umm Rommaneh"; Constantce.AreaLang = UmmRommanehAZR.Text; UmmRommanehAZR.TextColor = Color.White; UmmRommanehAZR.BackgroundColor = Color.FromHex("#FF071D66"); var existingPages = Navigation.NavigationStack.ToList(); await Navigation.PushAsync(new Home()); foreach (var page in existingPages) { Navigation.RemovePage(page); }
                await Task.Delay(80); await PopupNavigation.Instance.PopAsync();
            }
            else { Constantce.Area = "Area"; UmmRommanehAZR.BackgroundColor = Color.White; UmmRommanehAZR.TextColor = Color.FromHex("#FF071D66"); }
        }
        async void WadiEsswanAZR_Clicked(object sender, EventArgs e)
        {
            if (WadiEsswanAZR.BackgroundColor == Color.White)
            {
                Constantce.Area = "Wadi Esswan"; Constantce.AreaLang = WadiEsswanAZR.Text; WadiEsswanAZR.TextColor = Color.White; WadiEsswanAZR.BackgroundColor = Color.FromHex("#FF071D66"); var existingPages = Navigation.NavigationStack.ToList(); await Navigation.PushAsync(new Home()); foreach (var page in existingPages) { Navigation.RemovePage(page); }
                await Task.Delay(80); await PopupNavigation.Instance.PopAsync();
            }
            else { Constantce.Area = "Area"; WadiEsswanAZR.BackgroundColor = Color.White; WadiEsswanAZR.TextColor = Color.FromHex("#FF071D66"); }
        }
        async void ZarqaAZR_Clicked(object sender, EventArgs e)
        {
            if (ZarqaAZR.BackgroundColor == Color.White)
            {
                Constantce.Area = "Zarqa"; Constantce.AreaLang = ZarqaAZR.Text; ZarqaAZR.TextColor = Color.White; ZarqaAZR.BackgroundColor = Color.FromHex("#FF071D66"); var existingPages = Navigation.NavigationStack.ToList(); await Navigation.PushAsync(new Home()); foreach (var page in existingPages) { Navigation.RemovePage(page); }
                await Task.Delay(80); await PopupNavigation.Instance.PopAsync();
            }
            else { Constantce.Area = "Area"; ZarqaAZR.BackgroundColor = Color.White; ZarqaAZR.TextColor = Color.FromHex("#FF071D66"); }
        }
        //******************************End zarqa Areas**********************************************************************


    }
}