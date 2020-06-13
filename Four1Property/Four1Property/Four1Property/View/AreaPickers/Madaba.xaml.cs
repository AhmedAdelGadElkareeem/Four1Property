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
    public partial class Madaba : PopupPage
    {
        public Madaba()
        {
            InitializeComponent();


            if (Application.Current.Properties["Language"].ToString() == "Arabic")
            {
                this.FlowDirection = FlowDirection.RightToLeft;
                UpText.Text = "الرجاء اختيار المنطقة";

                AbuRdainehMAD.Text = "ابو ردينة";
                AinEddiebMAD.Text = "عين الذيب";
                AlaqiMAD.Text = "العلاقي";
                AlBaqayMAD.Text = "البقيع; القباعي";
                AlGhadeerMAD.Text = "الغدير";
                AlyehMAD.Text = "العالية";
                AnnahdaUmZabarahMAD.Text = "النهضه; ام زباره";
                AraerMAD.Text = "عراعر";
                AreedhMAD.Text = "العريض";
                ArieshMAD.Text = "العريش";
                AtroozMAD.Text = "عطروز";
                AzzahraMAD.Text = "الزهراء";
                BalotahMAD.Text = "بلوطه";
                BarzahMAD.Text = "برزه";
                DairMAD.Text = "الدير";
                DalieletElHamaydehMAD.Text = "دليلة الحمايدة";
                DhaibehGharbiyyehMAD.Text = "الذهيبه الغربية";
                DhaibehSharqiyyehMAD.Text = "الذهيبة الشرقية";
                DiebanMAD.Text = "ذيبان";
                FaisaliahMAD.Text = "الفيصلية";
                FalhaMAD.Text = "فلحه";
                FayhaaMAD.Text = "الفيحاء";
                GhernatahMAD.Text = "غرناطه";
                HamamatMaeenMAD.Text = "حمامات ماعين";
                HashemiyyehUmHsasMAD.Text = "الهاشمية; ام حصاص";
                HayyadhMAD.Text = "الحياض";
                HeialaleyehFalhaMAD.Text = "الهلالية; الفالحه";
                HenoandSakranehMAD.Text = "الحنو والسكرانة";
                HiedanMAD.Text = "الهيدان";
                HwayyetElBalounehMAD.Text = "حوية البلاونه";
                JadedahMAD.Text = "الجديدة";
                JarwanAmerahMAD.Text = "الجروان; العامره";
                JrainahMAD.Text = "جرينه";
                JubailMAD.Text = "الجبيل";
                KaldiyyehMAD.Text = "الخالدية";
                KhaldeyyehAbuEzqalMAD.Text = "الخالدية; ابو ازقل";
                KhatabiyyehMAD.Text = "الخطابية";
                LebMAD.Text = "لب";
                LibbehMAD.Text = "اللبة";
                LusenandRabtMAD.Text = "اللسن والربط";
                MadabaMAD.Text = "مادبا";
                MaeenMAD.Text = "ماعين";
                MakawerMAD.Text = "مكاور";
                MamoneiaMAD.Text = "المأمونية";
                ManshiyyehMAD.Text = "المنشية";
                ManshiyyetMaeenMAD.Text = "منشية ماعين";
                MathloothehMAD.Text = "المثلوثه";
                MeqadBenNasrallahMAD.Text = "مقعد بن نصرالله";
                MesherfehMAD.Text = "المشرفة";
                MkhaitMAD.Text = "المخيط";
                MlaihMAD.Text = "مليح";
                MuhamadehMAD.Text = "المحمدية";
                MunsafMekherahMAD.Text = "المنسف; المخرعه";
                NamyehMAD.Text = "النامية";
                NasiebMAD.Text = "النصيب";
                NozhetElWalehMAD.Text = "نزهة الوالة";
                OyoonMoosaMAD.Text = "عيون موسى";
                QasmeiaMAD.Text = "القاسمية";
                QbaibehMAD.Text = "القبيبه";
                QrayyatMAD.Text = "القريات";
                RashdeiaMAD.Text = "الراشدية";
                RehaneihUmShajarahMAD.Text = "الريحانه; ام شجره";
                SafaMAD.Text = "الصفا";
                ShqaiqMAD.Text = "الشقيق";
                SyaghahMAD.Text = "صياغة";
                UmmShjairehGharbiyyehMAD.Text = "ام شجيرة الغربية";
                UmmShjairehSharqiyyehMAD.Text = "ام شجيره الشرقية";
                WadiElMujebMAD.Text = "وادي الموجب";
                WahMrejmetElHamedMAD.Text = "الواحة; مريجمة الحامد";
                WalehMAD.Text = "الواله";
                WasiyyehMAD.Text = "الوسية";
                ZarqaMaeenMAD.Text = "زرقاء ماعين";
                ZaynaMAD.Text = "الزينه";


            }
            else
            {
                this.FlowDirection = FlowDirection.LeftToRight;
                UpText.Text = "Please Select Area";

                AbuRdainehMAD.Text = "Abu Rdaineh";
                AinEddiebMAD.Text = "Ain Eddieb";
                AlaqiMAD.Text = "Alaqi";
                AlBaqayMAD.Text = "Al - Baqay'";
                AlGhadeerMAD.Text = "Al - Ghadeer";
                AlyehMAD.Text = "Alyeh";
                AnnahdaUmZabarahMAD.Text = "Annahda Um Zabarah";
                AraerMAD.Text = "Ara'er";
                AreedhMAD.Text = "Areedh";
                ArieshMAD.Text = "Ariesh";
                AtroozMAD.Text = "Atrooz";
                AzzahraMAD.Text = "Azzahra'";
                BalotahMAD.Text = "Balotah";
                BarzahMAD.Text = "Barzah";
                DairMAD.Text = "Dair";
                DalieletElHamaydehMAD.Text = "Dalielet El - Hamaydeh";
                DhaibehGharbiyyehMAD.Text = "Dhaibeh Gharbiyyeh";
                DhaibehSharqiyyehMAD.Text = "Dhaibeh Sharqiyyeh";
                DiebanMAD.Text = "Dieban";
                FaisaliahMAD.Text = "Faisaliah";
                FalhaMAD.Text = "Falha";
                FayhaaMAD.Text = "Fayha'a";
                GhernatahMAD.Text = "Ghernatah";
                HamamatMaeenMAD.Text = "Hamamat Maeen";
                HashemiyyehUmHsasMAD.Text = "Hashemiyyeh Um Hsas";
                HayyadhMAD.Text = "Hayyadh";
                HeialaleyehFalhaMAD.Text = "Heialaleyeh Falha";
                HenoandSakranehMAD.Text = "Heno and Sakraneh";
                HiedanMAD.Text = "Hiedan";
                HwayyetElBalounehMAD.Text = "Hwayyet El - Balouneh";
                JadedahMAD.Text = "Jadedah";
                JarwanAmerahMAD.Text = "Jarwan Amerah";
                JrainahMAD.Text = "Jrainah";
                JubailMAD.Text = "Jubail";
                KaldiyyehMAD.Text = "Kaldiyyeh";
                KhaldeyyehAbuEzqalMAD.Text = "Khaldeyyeh Abu Ezqal";
                KhatabiyyehMAD.Text = "Khatabiyyeh";
                LebMAD.Text = "Leb";
                LibbehMAD.Text = "Libbeh";
                LusenandRabtMAD.Text = "Lusen and Rabt";
                MadabaMAD.Text = "Madaba";
                MaeenMAD.Text = "Maeen";
                MakawerMAD.Text = "Makawer";
                MamoneiaMAD.Text = "Ma'moneia";
                ManshiyyehMAD.Text = "Manshiyyeh";
                ManshiyyetMaeenMAD.Text = "Manshiyyet Maeen";
                MathloothehMAD.Text = "Mathlootheh";
                MeqadBenNasrallahMAD.Text = "Meq'ad Ben Nasrallah";
                MesherfehMAD.Text = "Mesherfeh";
                MkhaitMAD.Text = "Mkhait";
                MlaihMAD.Text = "Mlaih";
                MuhamadehMAD.Text = "Muhamadeh";
                MunsafMekherahMAD.Text = "Munsaf Mekher'ah";
                NamyehMAD.Text = "Namyeh";
                NasiebMAD.Text = "Nasieb";
                NozhetElWalehMAD.Text = "Nozhet El - Waleh";
                OyoonMoosaMAD.Text = "Oyoon Moosa";
                QasmeiaMAD.Text = "Qasmeia";
                QbaibehMAD.Text = "Qbaibeh";
                QrayyatMAD.Text = "Qrayyat";
                RashdeiaMAD.Text = "Rashdeia";
                RehaneihUmShajarahMAD.Text = "Rehaneih Um Shajarah";
                SafaMAD.Text = "Safa";
                ShqaiqMAD.Text = "Shqaiq";
                SyaghahMAD.Text = "Syaghah";
                UmmShjairehGharbiyyehMAD.Text = "Umm Shjaireh Gharbiyyeh";
                UmmShjairehSharqiyyehMAD.Text = "Umm Shjaireh Sharqiyyeh";
                WadiElMujebMAD.Text = "Wadi El - Mujeb";
                WahMrejmetElHamedMAD.Text = "Wah Mrejmet El-Hamed";
                WalehMAD.Text = "Waleh";
                WasiyyehMAD.Text = "Wasiyyeh";
                ZarqaMaeenMAD.Text = "Zarqa' Maeen";
                ZaynaMAD.Text = "Zayna";

            }
            if (Constantce.Area == "Abu Rdaineh")
            {
                AbuRdainehMAD.BackgroundColor = Color.FromHex("#FF071D66"); AbuRdainehMAD.TextColor = Color.White;
            }
            else if (Constantce.Area == "Ain Eddieb")
            {
                AinEddiebMAD.BackgroundColor = Color.FromHex("#FF071D66"); AinEddiebMAD.TextColor = Color.White;
            }
            else if (Constantce.Area == "Alaqi")
            {
                AlaqiMAD.BackgroundColor = Color.FromHex("#FF071D66"); AlaqiMAD.TextColor = Color.White;
            }
            else if (Constantce.Area == "Al - Baqay'") { AlBaqayMAD.BackgroundColor = Color.FromHex("#FF071D66"); AlBaqayMAD.TextColor = Color.White; }
            else if (Constantce.Area == "Al - Ghadeer")
            {
                AlGhadeerMAD.BackgroundColor = Color.FromHex("#FF071D66"); AlGhadeerMAD.TextColor = Color.White;
            }
            else if (Constantce.Area == "Alyeh")
            {
                AlyehMAD.BackgroundColor = Color.FromHex("#FF071D66"); AlyehMAD.TextColor = Color.White;
            }
            else if (Constantce.Area == "Annahda Um Zabarah")
            {
                AnnahdaUmZabarahMAD.BackgroundColor = Color.FromHex("#FF071D66"); AnnahdaUmZabarahMAD.TextColor = Color.White;
            }
            else if (Constantce.Area == "Ara'er") { AraerMAD.BackgroundColor = Color.FromHex("#FF071D66"); AraerMAD.TextColor = Color.White; }
            else if (Constantce.Area == "Areedh")
            {
                AreedhMAD.BackgroundColor = Color.FromHex("#FF071D66"); AreedhMAD.TextColor = Color.White;
            }
            else if (Constantce.Area == "Ariesh")
            {
                ArieshMAD.BackgroundColor = Color.FromHex("#FF071D66"); ArieshMAD.TextColor = Color.White;
            }
            else if (Constantce.Area == "Atrooz")
            {
                AtroozMAD.BackgroundColor = Color.FromHex("#FF071D66"); AtroozMAD.TextColor = Color.White;
            }
            else if (Constantce.Area == "Azzahra'") { AzzahraMAD.BackgroundColor = Color.FromHex("#FF071D66"); AzzahraMAD.TextColor = Color.White; }
            else if (Constantce.Area == "Balotah")
            {
                BalotahMAD.BackgroundColor = Color.FromHex("#FF071D66"); BalotahMAD.TextColor = Color.White;
            }
            else if (Constantce.Area == "Barzah")
            {
                BarzahMAD.BackgroundColor = Color.FromHex("#FF071D66"); BarzahMAD.TextColor = Color.White;
            }
            else if (Constantce.Area == "Dair")
            {
                DairMAD.BackgroundColor = Color.FromHex("#FF071D66"); DairMAD.TextColor = Color.White;
            }
            else if (Constantce.Area == "Dalielet El - Hamaydeh")
            {
                DalieletElHamaydehMAD.BackgroundColor = Color.FromHex("#FF071D66"); DalieletElHamaydehMAD.TextColor = Color.White;
            }
            else if (Constantce.Area == "Dhaibeh Gharbiyyeh")
            {
                DhaibehGharbiyyehMAD.BackgroundColor = Color.FromHex("#FF071D66"); DhaibehGharbiyyehMAD.TextColor = Color.White;
            }
            else if (Constantce.Area == "Dhaibeh Sharqiyyeh")
            {
                DhaibehSharqiyyehMAD.BackgroundColor = Color.FromHex("#FF071D66"); DhaibehSharqiyyehMAD.TextColor = Color.White;
            }
            else if (Constantce.Area == "Dieban")
            {
                DiebanMAD.BackgroundColor = Color.FromHex("#FF071D66"); DiebanMAD.TextColor = Color.White;
            }
            else if (Constantce.Area == "Faisaliah")
            {
                FaisaliahMAD.BackgroundColor = Color.FromHex("#FF071D66"); FaisaliahMAD.TextColor = Color.White;
            }
            else if (Constantce.Area == "Falha")
            {
                FalhaMAD.BackgroundColor = Color.FromHex("#FF071D66"); FalhaMAD.TextColor = Color.White;
            }
            else if (Constantce.Area == "Fayha'a") { FayhaaMAD.BackgroundColor = Color.FromHex("#FF071D66"); FayhaaMAD.TextColor = Color.White; }
            else if (Constantce.Area == "Ghernatah")
            {
                GhernatahMAD.BackgroundColor = Color.FromHex("#FF071D66"); GhernatahMAD.TextColor = Color.White;
            }
            else if (Constantce.Area == "Hamamat Maeen")
            {
                HamamatMaeenMAD.BackgroundColor = Color.FromHex("#FF071D66"); HamamatMaeenMAD.TextColor = Color.White;
            }
            else if (Constantce.Area == "Hashemiyyeh Um Hsas")
            {
                HashemiyyehUmHsasMAD.BackgroundColor = Color.FromHex("#FF071D66"); HashemiyyehUmHsasMAD.TextColor = Color.White;
            }
            else if (Constantce.Area == "Hayyadh")
            {
                HayyadhMAD.BackgroundColor = Color.FromHex("#FF071D66"); HayyadhMAD.TextColor = Color.White;
            }
            else if (Constantce.Area == "Heialaleyeh Falha")
            {
                HeialaleyehFalhaMAD.BackgroundColor = Color.FromHex("#FF071D66"); HeialaleyehFalhaMAD.TextColor = Color.White;
            }
            else if (Constantce.Area == "Heno and Sakraneh")
            {
                HenoandSakranehMAD.BackgroundColor = Color.FromHex("#FF071D66"); HenoandSakranehMAD.TextColor = Color.White;
            }
            else if (Constantce.Area == "Hiedan")
            {
                HiedanMAD.BackgroundColor = Color.FromHex("#FF071D66"); HiedanMAD.TextColor = Color.White;
            }
            else if (Constantce.Area == "Hwayyet El - Balouneh")
            {
                HwayyetElBalounehMAD.BackgroundColor = Color.FromHex("#FF071D66"); HwayyetElBalounehMAD.TextColor = Color.White;
            }
            else if (Constantce.Area == "Jadedah")
            {
                JadedahMAD.BackgroundColor = Color.FromHex("#FF071D66"); JadedahMAD.TextColor = Color.White;
            }
            else if (Constantce.Area == "Jarwan Amerah")
            {
                JarwanAmerahMAD.BackgroundColor = Color.FromHex("#FF071D66"); JarwanAmerahMAD.TextColor = Color.White;
            }
            else if (Constantce.Area == "Jrainah")
            {
                JrainahMAD.BackgroundColor = Color.FromHex("#FF071D66"); JrainahMAD.TextColor = Color.White;
            }
            else if (Constantce.Area == "Jubail")
            {
                JubailMAD.BackgroundColor = Color.FromHex("#FF071D66"); JubailMAD.TextColor = Color.White;
            }
            else if (Constantce.Area == "Kaldiyyeh")
            {
                KaldiyyehMAD.BackgroundColor = Color.FromHex("#FF071D66"); KaldiyyehMAD.TextColor = Color.White;
            }
            else if (Constantce.Area == "Khaldeyyeh Abu Ezqal")
            {
                KhaldeyyehAbuEzqalMAD.BackgroundColor = Color.FromHex("#FF071D66"); KhaldeyyehAbuEzqalMAD.TextColor = Color.White;
            }
            else if (Constantce.Area == "Khatabiyyeh")
            {
                KhatabiyyehMAD.BackgroundColor = Color.FromHex("#FF071D66"); KhatabiyyehMAD.TextColor = Color.White;
            }
            else if (Constantce.Area == "Leb")
            {
                LebMAD.BackgroundColor = Color.FromHex("#FF071D66"); LebMAD.TextColor = Color.White;
            }
            else if (Constantce.Area == "Libbeh")
            {
                LibbehMAD.BackgroundColor = Color.FromHex("#FF071D66"); LibbehMAD.TextColor = Color.White;
            }
            else if (Constantce.Area == "Lusen and Rabt")
            {
                LusenandRabtMAD.BackgroundColor = Color.FromHex("#FF071D66"); LusenandRabtMAD.TextColor = Color.White;
            }
            else if (Constantce.Area == "Madaba")
            {
                MadabaMAD.BackgroundColor = Color.FromHex("#FF071D66"); MadabaMAD.TextColor = Color.White;
            }
            else if (Constantce.Area == "Maeen")
            {
                MaeenMAD.BackgroundColor = Color.FromHex("#FF071D66"); MaeenMAD.TextColor = Color.White;
            }
            else if (Constantce.Area == "Makawer")
            {
                MakawerMAD.BackgroundColor = Color.FromHex("#FF071D66"); MakawerMAD.TextColor = Color.White;
            }
            else if (Constantce.Area == "Ma'moneia") { MamoneiaMAD.BackgroundColor = Color.FromHex("#FF071D66"); MamoneiaMAD.TextColor = Color.White; }
            else if (Constantce.Area == "Manshiyyeh")
            {
                ManshiyyehMAD.BackgroundColor = Color.FromHex("#FF071D66"); ManshiyyehMAD.TextColor = Color.White;
            }
            else if (Constantce.Area == "Manshiyyet Maeen")
            {
                ManshiyyetMaeenMAD.BackgroundColor = Color.FromHex("#FF071D66"); ManshiyyetMaeenMAD.TextColor = Color.White;
            }
            else if (Constantce.Area == "Mathlootheh")
            {
                MathloothehMAD.BackgroundColor = Color.FromHex("#FF071D66"); MathloothehMAD.TextColor = Color.White;
            }
            else if (Constantce.Area == "Meq'ad Ben Nasrallah") { MeqadBenNasrallahMAD.BackgroundColor = Color.FromHex("#FF071D66"); MeqadBenNasrallahMAD.TextColor = Color.White; }
            else if (Constantce.Area == "Mesherfeh")
            {
                MesherfehMAD.BackgroundColor = Color.FromHex("#FF071D66"); MesherfehMAD.TextColor = Color.White;
            }
            else if (Constantce.Area == "Mkhait")
            {
                MkhaitMAD.BackgroundColor = Color.FromHex("#FF071D66"); MkhaitMAD.TextColor = Color.White;
            }
            else if (Constantce.Area == "Mlaih")
            {
                MlaihMAD.BackgroundColor = Color.FromHex("#FF071D66"); MlaihMAD.TextColor = Color.White;
            }
            else if (Constantce.Area == "Muhamadeh")
            {
                MuhamadehMAD.BackgroundColor = Color.FromHex("#FF071D66"); MuhamadehMAD.TextColor = Color.White;
            }
            else if (Constantce.Area == "Munsaf Mekher'ah") { MunsafMekherahMAD.BackgroundColor = Color.FromHex("#FF071D66"); MunsafMekherahMAD.TextColor = Color.White; }
            else if (Constantce.Area == "Namyeh")
            {
                NamyehMAD.BackgroundColor = Color.FromHex("#FF071D66"); NamyehMAD.TextColor = Color.White;
            }
            else if (Constantce.Area == "Nasieb")
            {
                NasiebMAD.BackgroundColor = Color.FromHex("#FF071D66"); NasiebMAD.TextColor = Color.White;
            }
            else if (Constantce.Area == "Nozhet El - Waleh")
            {
                NozhetElWalehMAD.BackgroundColor = Color.FromHex("#FF071D66"); NozhetElWalehMAD.TextColor = Color.White;
            }
            else if (Constantce.Area == "Oyoon Moosa")
            {
                OyoonMoosaMAD.BackgroundColor = Color.FromHex("#FF071D66"); OyoonMoosaMAD.TextColor = Color.White;
            }
            else if (Constantce.Area == "Qasmeia")
            {
                QasmeiaMAD.BackgroundColor = Color.FromHex("#FF071D66"); QasmeiaMAD.TextColor = Color.White;
            }
            else if (Constantce.Area == "Qbaibeh")
            {
                QbaibehMAD.BackgroundColor = Color.FromHex("#FF071D66"); QbaibehMAD.TextColor = Color.White;
            }
            else if (Constantce.Area == "Qrayyat")
            {
                QrayyatMAD.BackgroundColor = Color.FromHex("#FF071D66"); QrayyatMAD.TextColor = Color.White;
            }
            else if (Constantce.Area == "Rashdeia")
            {
                RashdeiaMAD.BackgroundColor = Color.FromHex("#FF071D66"); RashdeiaMAD.TextColor = Color.White;
            }
            else if (Constantce.Area == "Rehaneih Um Shajarah")
            {
                RehaneihUmShajarahMAD.BackgroundColor = Color.FromHex("#FF071D66"); RehaneihUmShajarahMAD.TextColor = Color.White;
            }
            else if (Constantce.Area == "Safa")
            {
                SafaMAD.BackgroundColor = Color.FromHex("#FF071D66"); SafaMAD.TextColor = Color.White;
            }
            else if (Constantce.Area == "Shqaiq")
            {
                ShqaiqMAD.BackgroundColor = Color.FromHex("#FF071D66"); ShqaiqMAD.TextColor = Color.White;
            }
            else if (Constantce.Area == "Syaghah")
            {
                SyaghahMAD.BackgroundColor = Color.FromHex("#FF071D66"); SyaghahMAD.TextColor = Color.White;
            }
            else if (Constantce.Area == "Umm Shjaireh Gharbiyyeh") { UmmShjairehGharbiyyehMAD.BackgroundColor = Color.FromHex("#FF071D66"); UmmShjairehGharbiyyehMAD.TextColor = Color.White; }
            else if (Constantce.Area == "Umm Shjaireh Sharqiyyeh") { UmmShjairehSharqiyyehMAD.BackgroundColor = Color.FromHex("#FF071D66"); UmmShjairehSharqiyyehMAD.TextColor = Color.White; }
            else if (Constantce.Area == "Wadi El - Mujeb") { WadiElMujebMAD.BackgroundColor = Color.FromHex("#FF071D66"); WadiElMujebMAD.TextColor = Color.White; }
            else if (Constantce.Area == "Wah Mrejmet El-Hamed") { WahMrejmetElHamedMAD.BackgroundColor = Color.FromHex("#FF071D66"); WahMrejmetElHamedMAD.TextColor = Color.White; }
            else if (Constantce.Area == "Waleh") { WalehMAD.BackgroundColor = Color.FromHex("#FF071D66"); WalehMAD.TextColor = Color.White; }
            else if (Constantce.Area == "Wasiyyeh") { WasiyyehMAD.BackgroundColor = Color.FromHex("#FF071D66"); WasiyyehMAD.TextColor = Color.White; }
            else if (Constantce.Area == "Zarqa' Maeen") { ZarqaMaeenMAD.BackgroundColor = Color.FromHex("#FF071D66"); ZarqaMaeenMAD.TextColor = Color.White; }
            else if (Constantce.Area == "Zayna") { ZaynaMAD.BackgroundColor = Color.FromHex("#FF071D66"); ZaynaMAD.TextColor = Color.White; }


            MadabaArea.IsVisible = true;
        }



        async void AbuRdainehMAD_Clicked(object sender, EventArgs e)
        {
            if (AbuRdainehMAD.BackgroundColor == Color.White)
            {
                Constantce.Area = "Abu Rdaineh"; Constantce.AreaLang = AbuRdainehMAD.Text; AbuRdainehMAD.TextColor = Color.White; AbuRdainehMAD.BackgroundColor = Color.FromHex("#FF071D66"); var existingPages = Navigation.NavigationStack.ToList(); await Navigation.PushAsync(new Home()); foreach (var page in existingPages) { Navigation.RemovePage(page); }
                await Task.Delay(80); await PopupNavigation.Instance.PopAsync();
            }
            else {  Constantce.Area = "Area"; AbuRdainehMAD.BackgroundColor = Color.White; AbuRdainehMAD.TextColor = Color.FromHex("#FF071D66"); }
        }
        async void AinEddiebMAD_Clicked(object sender, EventArgs e)
        {
            if (AinEddiebMAD.BackgroundColor == Color.White)
            {
                Constantce.Area = "Ain Eddieb"; Constantce.AreaLang = AinEddiebMAD.Text; AinEddiebMAD.TextColor = Color.White; AinEddiebMAD.BackgroundColor = Color.FromHex("#FF071D66"); var existingPages = Navigation.NavigationStack.ToList(); await Navigation.PushAsync(new Home()); foreach (var page in existingPages) { Navigation.RemovePage(page); }
                await Task.Delay(80); await PopupNavigation.Instance.PopAsync();
            }
            else {  Constantce.Area = "Area"; AinEddiebMAD.BackgroundColor = Color.White; AinEddiebMAD.TextColor = Color.FromHex("#FF071D66"); }
        }
        async void AlaqiMAD_Clicked(object sender, EventArgs e)
        {
            if (AlaqiMAD.BackgroundColor == Color.White)
            {
                Constantce.Area = "Alaqi"; Constantce.AreaLang = AlaqiMAD.Text; AlaqiMAD.TextColor = Color.White; AlaqiMAD.BackgroundColor = Color.FromHex("#FF071D66"); var existingPages = Navigation.NavigationStack.ToList(); await Navigation.PushAsync(new Home()); foreach (var page in existingPages) { Navigation.RemovePage(page); }
                await Task.Delay(80); await PopupNavigation.Instance.PopAsync();
            }
            else {  Constantce.Area = "Area"; AlaqiMAD.BackgroundColor = Color.White; AlaqiMAD.TextColor = Color.FromHex("#FF071D66"); }
        }
        async void AlBaqayMAD_Clicked(object sender, EventArgs e)
        {
            if (AlBaqayMAD.BackgroundColor == Color.White)
            {
                Constantce.Area = "Al - Baqay'"; Constantce.AreaLang = AlBaqayMAD.Text; AlBaqayMAD.TextColor = Color.White; AlBaqayMAD.BackgroundColor = Color.FromHex("#FF071D66"); var existingPages = Navigation.NavigationStack.ToList(); await Navigation.PushAsync(new Home()); foreach (var page in existingPages) { Navigation.RemovePage(page); }
                await Task.Delay(80); await PopupNavigation.Instance.PopAsync();
            }
            else {  Constantce.Area = "Area"; AlBaqayMAD.BackgroundColor = Color.White; AlBaqayMAD.TextColor = Color.FromHex("#FF071D66"); }
        }
        async void AlGhadeerMAD_Clicked(object sender, EventArgs e)
        {
            if (AlGhadeerMAD.BackgroundColor == Color.White)
            {
                Constantce.Area = "Al - Ghadeer"; Constantce.AreaLang = AlGhadeerMAD.Text; AlGhadeerMAD.TextColor = Color.White; AlGhadeerMAD.BackgroundColor = Color.FromHex("#FF071D66"); var existingPages = Navigation.NavigationStack.ToList(); await Navigation.PushAsync(new Home()); foreach (var page in existingPages) { Navigation.RemovePage(page); }
                await Task.Delay(80); await PopupNavigation.Instance.PopAsync();
            }
            else {  Constantce.Area = "Area"; AlGhadeerMAD.BackgroundColor = Color.White; AlGhadeerMAD.TextColor = Color.FromHex("#FF071D66"); }
        }
        async void AlyehMAD_Clicked(object sender, EventArgs e)
        {
            if (AlyehMAD.BackgroundColor == Color.White)
            {
                Constantce.Area = "Alyeh"; Constantce.AreaLang = AlyehMAD.Text; AlyehMAD.TextColor = Color.White; AlyehMAD.BackgroundColor = Color.FromHex("#FF071D66"); var existingPages = Navigation.NavigationStack.ToList(); await Navigation.PushAsync(new Home()); foreach (var page in existingPages) { Navigation.RemovePage(page); }
                await Task.Delay(80); await PopupNavigation.Instance.PopAsync();
            }
            else {  Constantce.Area = "Area"; AlyehMAD.BackgroundColor = Color.White; AlyehMAD.TextColor = Color.FromHex("#FF071D66"); }
        }
        async void AnnahdaUmZabarahMAD_Clicked(object sender, EventArgs e)
        {
            if (AnnahdaUmZabarahMAD.BackgroundColor == Color.White)
            {
                Constantce.Area = "Annahda Um Zabarah"; Constantce.AreaLang = AnnahdaUmZabarahMAD.Text; AnnahdaUmZabarahMAD.TextColor = Color.White; AnnahdaUmZabarahMAD.BackgroundColor = Color.FromHex("#FF071D66"); var existingPages = Navigation.NavigationStack.ToList(); await Navigation.PushAsync(new Home()); foreach (var page in existingPages) { Navigation.RemovePage(page); }
                await Task.Delay(80); await PopupNavigation.Instance.PopAsync();
            }
            else {  Constantce.Area = "Area"; AnnahdaUmZabarahMAD.BackgroundColor = Color.White; AnnahdaUmZabarahMAD.TextColor = Color.FromHex("#FF071D66"); }
        }
        async void AraerMAD_Clicked(object sender, EventArgs e)
        {
            if (AraerMAD.BackgroundColor == Color.White)
            {
                Constantce.Area = "Ara'er"; Constantce.AreaLang = AraerMAD.Text; AraerMAD.TextColor = Color.White; AraerMAD.BackgroundColor = Color.FromHex("#FF071D66"); var existingPages = Navigation.NavigationStack.ToList(); await Navigation.PushAsync(new Home()); foreach (var page in existingPages) { Navigation.RemovePage(page); }
                await Task.Delay(80); await PopupNavigation.Instance.PopAsync();
            }
            else {  Constantce.Area = "Area"; AraerMAD.BackgroundColor = Color.White; AraerMAD.TextColor = Color.FromHex("#FF071D66"); }
        }
        async void AreedhMAD_Clicked(object sender, EventArgs e)
        {
            if (AreedhMAD.BackgroundColor == Color.White)
            {
                Constantce.Area = "Areedh"; Constantce.AreaLang = AreedhMAD.Text; AreedhMAD.TextColor = Color.White; AreedhMAD.BackgroundColor = Color.FromHex("#FF071D66"); var existingPages = Navigation.NavigationStack.ToList(); await Navigation.PushAsync(new Home()); foreach (var page in existingPages) { Navigation.RemovePage(page); }
                await Task.Delay(80); await PopupNavigation.Instance.PopAsync();
            }
            else {  Constantce.Area = "Area"; AreedhMAD.BackgroundColor = Color.White; AreedhMAD.TextColor = Color.FromHex("#FF071D66"); }
        }
        async void ArieshMAD_Clicked(object sender, EventArgs e)
        {
            if (ArieshMAD.BackgroundColor == Color.White)
            {
                Constantce.Area = "Ariesh"; Constantce.AreaLang = ArieshMAD.Text; ArieshMAD.TextColor = Color.White; ArieshMAD.BackgroundColor = Color.FromHex("#FF071D66"); var existingPages = Navigation.NavigationStack.ToList(); await Navigation.PushAsync(new Home()); foreach (var page in existingPages) { Navigation.RemovePage(page); }
                await Task.Delay(80); await PopupNavigation.Instance.PopAsync();
            }
            else {  Constantce.Area = "Area"; ArieshMAD.BackgroundColor = Color.White; ArieshMAD.TextColor = Color.FromHex("#FF071D66"); }
        }
        async void AtroozMAD_Clicked(object sender, EventArgs e)
        {
            if (AtroozMAD.BackgroundColor == Color.White)
            {
                Constantce.Area = "Atrooz"; Constantce.AreaLang = AtroozMAD.Text; AtroozMAD.TextColor = Color.White; AtroozMAD.BackgroundColor = Color.FromHex("#FF071D66"); var existingPages = Navigation.NavigationStack.ToList(); await Navigation.PushAsync(new Home()); foreach (var page in existingPages) { Navigation.RemovePage(page); }
                await Task.Delay(80); await PopupNavigation.Instance.PopAsync();
            }
            else {  Constantce.Area = "Area"; AtroozMAD.BackgroundColor = Color.White; AtroozMAD.TextColor = Color.FromHex("#FF071D66"); }
        }
        async void AzzahraMAD_Clicked(object sender, EventArgs e)
        {
            if (AzzahraMAD.BackgroundColor == Color.White)
            {
                Constantce.Area = "Azzahra'"; Constantce.AreaLang = AzzahraMAD.Text; AzzahraMAD.TextColor = Color.White; AzzahraMAD.BackgroundColor = Color.FromHex("#FF071D66"); var existingPages = Navigation.NavigationStack.ToList(); await Navigation.PushAsync(new Home()); foreach (var page in existingPages) { Navigation.RemovePage(page); }
                await Task.Delay(80); await PopupNavigation.Instance.PopAsync();
            }
            else {  Constantce.Area = "Area"; AzzahraMAD.BackgroundColor = Color.White; AzzahraMAD.TextColor = Color.FromHex("#FF071D66"); }
        }
        async void BalotahMAD_Clicked(object sender, EventArgs e)
        {
            if (BalotahMAD.BackgroundColor == Color.White)
            {
                Constantce.Area = "Balotah"; Constantce.AreaLang = BalotahMAD.Text; BalotahMAD.TextColor = Color.White; BalotahMAD.BackgroundColor = Color.FromHex("#FF071D66"); var existingPages = Navigation.NavigationStack.ToList(); await Navigation.PushAsync(new Home()); foreach (var page in existingPages) { Navigation.RemovePage(page); }
                await Task.Delay(80); await PopupNavigation.Instance.PopAsync();
            }
            else {  Constantce.Area = "Area"; BalotahMAD.BackgroundColor = Color.White; BalotahMAD.TextColor = Color.FromHex("#FF071D66"); }
        }
        async void BarzahMAD_Clicked(object sender, EventArgs e)
        {
            if (BarzahMAD.BackgroundColor == Color.White)
            {
                Constantce.Area = "Barzah"; Constantce.AreaLang = BarzahMAD.Text; BarzahMAD.TextColor = Color.White; BarzahMAD.BackgroundColor = Color.FromHex("#FF071D66"); var existingPages = Navigation.NavigationStack.ToList(); await Navigation.PushAsync(new Home()); foreach (var page in existingPages) { Navigation.RemovePage(page); }
                await Task.Delay(80); await PopupNavigation.Instance.PopAsync();
            }
            else {  Constantce.Area = "Area"; BarzahMAD.BackgroundColor = Color.White; BarzahMAD.TextColor = Color.FromHex("#FF071D66"); }
        }
        async void DairMAD_Clicked(object sender, EventArgs e)
        {
            if (DairMAD.BackgroundColor == Color.White)
            {
                Constantce.Area = "Dair"; Constantce.AreaLang = DairMAD.Text; DairMAD.TextColor = Color.White; DairMAD.BackgroundColor = Color.FromHex("#FF071D66"); var existingPages = Navigation.NavigationStack.ToList(); await Navigation.PushAsync(new Home()); foreach (var page in existingPages) { Navigation.RemovePage(page); }
                await Task.Delay(80); await PopupNavigation.Instance.PopAsync();
            }
            else {  Constantce.Area = "Area"; DairMAD.BackgroundColor = Color.White; DairMAD.TextColor = Color.FromHex("#FF071D66"); }
        }
        async void DalieletElHamaydehMAD_Clicked(object sender, EventArgs e)
        {
            if (DalieletElHamaydehMAD.BackgroundColor == Color.White)
            {
                Constantce.Area = "Dalielet El - Hamaydeh"; Constantce.AreaLang = DalieletElHamaydehMAD.Text; DalieletElHamaydehMAD.TextColor = Color.White; DalieletElHamaydehMAD.BackgroundColor = Color.FromHex("#FF071D66"); var existingPages = Navigation.NavigationStack.ToList(); await Navigation.PushAsync(new Home()); foreach (var page in existingPages) { Navigation.RemovePage(page); }
                await Task.Delay(80); await PopupNavigation.Instance.PopAsync();
            }
            else {  Constantce.Area = "Area"; DalieletElHamaydehMAD.BackgroundColor = Color.White; DalieletElHamaydehMAD.TextColor = Color.FromHex("#FF071D66"); }
        }
        async void DhaibehGharbiyyehMAD_Clicked(object sender, EventArgs e)
        {
            if (DhaibehGharbiyyehMAD.BackgroundColor == Color.White)
            {
                Constantce.Area = "Dhaibeh Gharbiyyeh"; Constantce.AreaLang = DhaibehGharbiyyehMAD.Text; DhaibehGharbiyyehMAD.TextColor = Color.White; DhaibehGharbiyyehMAD.BackgroundColor = Color.FromHex("#FF071D66"); var existingPages = Navigation.NavigationStack.ToList(); await Navigation.PushAsync(new Home()); foreach (var page in existingPages) { Navigation.RemovePage(page); }
                await Task.Delay(80); await PopupNavigation.Instance.PopAsync();
            }
            else {  Constantce.Area = "Area"; DhaibehGharbiyyehMAD.BackgroundColor = Color.White; DhaibehGharbiyyehMAD.TextColor = Color.FromHex("#FF071D66"); }
        }
        async void DhaibehSharqiyyehMAD_Clicked(object sender, EventArgs e)
        {
            if (DhaibehSharqiyyehMAD.BackgroundColor == Color.White)
            {
                Constantce.Area = "Dhaibeh Sharqiyyeh"; Constantce.AreaLang = DhaibehSharqiyyehMAD.Text; DhaibehSharqiyyehMAD.TextColor = Color.White; DhaibehSharqiyyehMAD.BackgroundColor = Color.FromHex("#FF071D66"); var existingPages = Navigation.NavigationStack.ToList(); await Navigation.PushAsync(new Home()); foreach (var page in existingPages) { Navigation.RemovePage(page); }
                await Task.Delay(80); await PopupNavigation.Instance.PopAsync();
            }
            else {  Constantce.Area = "Area"; DhaibehSharqiyyehMAD.BackgroundColor = Color.White; DhaibehSharqiyyehMAD.TextColor = Color.FromHex("#FF071D66"); }
        }
        async void DiebanMAD_Clicked(object sender, EventArgs e)
        {
            if (DiebanMAD.BackgroundColor == Color.White)
            {
                Constantce.Area = "Dieban"; Constantce.AreaLang = DiebanMAD.Text; DiebanMAD.TextColor = Color.White; DiebanMAD.BackgroundColor = Color.FromHex("#FF071D66"); var existingPages = Navigation.NavigationStack.ToList(); await Navigation.PushAsync(new Home()); foreach (var page in existingPages) { Navigation.RemovePage(page); }
                await Task.Delay(80); await PopupNavigation.Instance.PopAsync();
            }
            else {  Constantce.Area = "Area"; DiebanMAD.BackgroundColor = Color.White; DiebanMAD.TextColor = Color.FromHex("#FF071D66"); }
        }
        async void FaisaliahMAD_Clicked(object sender, EventArgs e)
        {
            if (FaisaliahMAD.BackgroundColor == Color.White)
            {
                Constantce.Area = "Faisaliah"; Constantce.AreaLang = FaisaliahMAD.Text; FaisaliahMAD.TextColor = Color.White; FaisaliahMAD.BackgroundColor = Color.FromHex("#FF071D66"); var existingPages = Navigation.NavigationStack.ToList(); await Navigation.PushAsync(new Home()); foreach (var page in existingPages) { Navigation.RemovePage(page); }
                await Task.Delay(80); await PopupNavigation.Instance.PopAsync();
            }
            else {  Constantce.Area = "Area"; FaisaliahMAD.BackgroundColor = Color.White; FaisaliahMAD.TextColor = Color.FromHex("#FF071D66"); }
        }
        async void FalhaMAD_Clicked(object sender, EventArgs e)
        {
            if (FalhaMAD.BackgroundColor == Color.White)
            {
                Constantce.Area = "Falha"; Constantce.AreaLang = FalhaMAD.Text; FalhaMAD.TextColor = Color.White; FalhaMAD.BackgroundColor = Color.FromHex("#FF071D66"); var existingPages = Navigation.NavigationStack.ToList(); await Navigation.PushAsync(new Home()); foreach (var page in existingPages) { Navigation.RemovePage(page); }
                await Task.Delay(80); await PopupNavigation.Instance.PopAsync();
            }
            else {  Constantce.Area = "Area"; FalhaMAD.BackgroundColor = Color.White; FalhaMAD.TextColor = Color.FromHex("#FF071D66"); }
        }
        async void FayhaaMAD_Clicked(object sender, EventArgs e)
        {
            if (FayhaaMAD.BackgroundColor == Color.White)
            {
                Constantce.Area = "Fayha'a"; Constantce.AreaLang = FayhaaMAD.Text; FayhaaMAD.TextColor = Color.White; FayhaaMAD.BackgroundColor = Color.FromHex("#FF071D66"); var existingPages = Navigation.NavigationStack.ToList(); await Navigation.PushAsync(new Home()); foreach (var page in existingPages) { Navigation.RemovePage(page); }
                await Task.Delay(80); await PopupNavigation.Instance.PopAsync();
            }
            else {  Constantce.Area = "Area"; FayhaaMAD.BackgroundColor = Color.White; FayhaaMAD.TextColor = Color.FromHex("#FF071D66"); }
        }
        async void GhernatahMAD_Clicked(object sender, EventArgs e)
        {
            if (GhernatahMAD.BackgroundColor == Color.White)
            {
                Constantce.Area = "Ghernatah"; Constantce.AreaLang = GhernatahMAD.Text; GhernatahMAD.TextColor = Color.White; GhernatahMAD.BackgroundColor = Color.FromHex("#FF071D66"); var existingPages = Navigation.NavigationStack.ToList(); await Navigation.PushAsync(new Home()); foreach (var page in existingPages) { Navigation.RemovePage(page); }
                await Task.Delay(80); await PopupNavigation.Instance.PopAsync();
            }
            else {  Constantce.Area = "Area"; GhernatahMAD.BackgroundColor = Color.White; GhernatahMAD.TextColor = Color.FromHex("#FF071D66"); }
        }
        async void HamamatMaeenMAD_Clicked(object sender, EventArgs e)
        {
            if (HamamatMaeenMAD.BackgroundColor == Color.White)
            {
                Constantce.Area = "Hamamat Maeen"; Constantce.AreaLang = HamamatMaeenMAD.Text; HamamatMaeenMAD.TextColor = Color.White; HamamatMaeenMAD.BackgroundColor = Color.FromHex("#FF071D66"); var existingPages = Navigation.NavigationStack.ToList(); await Navigation.PushAsync(new Home()); foreach (var page in existingPages) { Navigation.RemovePage(page); }
                await Task.Delay(80); await PopupNavigation.Instance.PopAsync();
            }
            else {  Constantce.Area = "Area"; HamamatMaeenMAD.BackgroundColor = Color.White; HamamatMaeenMAD.TextColor = Color.FromHex("#FF071D66"); }
        }
        async void HashemiyyehUmHsasMAD_Clicked(object sender, EventArgs e)
        {
            if (HashemiyyehUmHsasMAD.BackgroundColor == Color.White)
            {
                Constantce.Area = "Hashemiyyeh Um Hsas"; Constantce.AreaLang = HashemiyyehUmHsasMAD.Text; HashemiyyehUmHsasMAD.TextColor = Color.White; HashemiyyehUmHsasMAD.BackgroundColor = Color.FromHex("#FF071D66"); var existingPages = Navigation.NavigationStack.ToList(); await Navigation.PushAsync(new Home()); foreach (var page in existingPages) { Navigation.RemovePage(page); }
                await Task.Delay(80); await PopupNavigation.Instance.PopAsync();
            }
            else {  Constantce.Area = "Area"; HashemiyyehUmHsasMAD.BackgroundColor = Color.White; HashemiyyehUmHsasMAD.TextColor = Color.FromHex("#FF071D66"); }
        }
        async void HayyadhMAD_Clicked(object sender, EventArgs e)
        {
            if (HayyadhMAD.BackgroundColor == Color.White)
            {
                Constantce.Area = "Hayyadh"; Constantce.AreaLang = HayyadhMAD.Text; HayyadhMAD.TextColor = Color.White; HayyadhMAD.BackgroundColor = Color.FromHex("#FF071D66"); var existingPages = Navigation.NavigationStack.ToList(); await Navigation.PushAsync(new Home()); foreach (var page in existingPages) { Navigation.RemovePage(page); }
                await Task.Delay(80); await PopupNavigation.Instance.PopAsync();
            }
            else {  Constantce.Area = "Area"; HayyadhMAD.BackgroundColor = Color.White; HayyadhMAD.TextColor = Color.FromHex("#FF071D66"); }
        }
        async void HeialaleyehFalhaMAD_Clicked(object sender, EventArgs e)
        {
            if (HeialaleyehFalhaMAD.BackgroundColor == Color.White)
            {
                Constantce.Area = "Heialaleyeh Falha"; Constantce.AreaLang = HeialaleyehFalhaMAD.Text; HeialaleyehFalhaMAD.TextColor = Color.White; HeialaleyehFalhaMAD.BackgroundColor = Color.FromHex("#FF071D66"); var existingPages = Navigation.NavigationStack.ToList(); await Navigation.PushAsync(new Home()); foreach (var page in existingPages) { Navigation.RemovePage(page); }
                await Task.Delay(80); await PopupNavigation.Instance.PopAsync();
            }
            else {  Constantce.Area = "Area"; HeialaleyehFalhaMAD.BackgroundColor = Color.White; HeialaleyehFalhaMAD.TextColor = Color.FromHex("#FF071D66"); }
        }
        async void HenoandSakranehMAD_Clicked(object sender, EventArgs e)
        {
            if (HenoandSakranehMAD.BackgroundColor == Color.White)
            {
                Constantce.Area = "Heno and Sakraneh"; Constantce.AreaLang = HenoandSakranehMAD.Text; HenoandSakranehMAD.TextColor = Color.White; HenoandSakranehMAD.BackgroundColor = Color.FromHex("#FF071D66"); var existingPages = Navigation.NavigationStack.ToList(); await Navigation.PushAsync(new Home()); foreach (var page in existingPages) { Navigation.RemovePage(page); }
                await Task.Delay(80); await PopupNavigation.Instance.PopAsync();
            }
            else {  Constantce.Area = "Area"; HenoandSakranehMAD.BackgroundColor = Color.White; HenoandSakranehMAD.TextColor = Color.FromHex("#FF071D66"); }
        }
        async void HiedanMAD_Clicked(object sender, EventArgs e)
        {
            if (HiedanMAD.BackgroundColor == Color.White)
            {
                Constantce.Area = "Hiedan"; Constantce.AreaLang = HiedanMAD.Text; HiedanMAD.TextColor = Color.White; HiedanMAD.BackgroundColor = Color.FromHex("#FF071D66"); var existingPages = Navigation.NavigationStack.ToList(); await Navigation.PushAsync(new Home()); foreach (var page in existingPages) { Navigation.RemovePage(page); }
                await Task.Delay(80); await PopupNavigation.Instance.PopAsync();
            }
            else {  Constantce.Area = "Area"; HiedanMAD.BackgroundColor = Color.White; HiedanMAD.TextColor = Color.FromHex("#FF071D66"); }
        }
        async void HwayyetElBalounehMAD_Clicked(object sender, EventArgs e)
        {
            if (HwayyetElBalounehMAD.BackgroundColor == Color.White)
            {
                Constantce.Area = "Hwayyet El - Balouneh"; Constantce.AreaLang = HwayyetElBalounehMAD.Text; HwayyetElBalounehMAD.TextColor = Color.White; HwayyetElBalounehMAD.BackgroundColor = Color.FromHex("#FF071D66"); var existingPages = Navigation.NavigationStack.ToList(); await Navigation.PushAsync(new Home()); foreach (var page in existingPages) { Navigation.RemovePage(page); }
                await Task.Delay(80); await PopupNavigation.Instance.PopAsync();
            }
            else {  Constantce.Area = "Area"; HwayyetElBalounehMAD.BackgroundColor = Color.White; HwayyetElBalounehMAD.TextColor = Color.FromHex("#FF071D66"); }
        }
        async void JadedahMAD_Clicked(object sender, EventArgs e)
        {
            if (JadedahMAD.BackgroundColor == Color.White)
            {
                Constantce.Area = "Jadedah"; Constantce.AreaLang = JadedahMAD.Text; JadedahMAD.TextColor = Color.White; JadedahMAD.BackgroundColor = Color.FromHex("#FF071D66"); var existingPages = Navigation.NavigationStack.ToList(); await Navigation.PushAsync(new Home()); foreach (var page in existingPages) { Navigation.RemovePage(page); }
                await Task.Delay(80); await PopupNavigation.Instance.PopAsync();
            }
            else {  Constantce.Area = "Area"; JadedahMAD.BackgroundColor = Color.White; JadedahMAD.TextColor = Color.FromHex("#FF071D66"); }
        }
        async void JarwanAmerahMAD_Clicked(object sender, EventArgs e)
        {
            if (JarwanAmerahMAD.BackgroundColor == Color.White)
            {
                Constantce.Area = "Jarwan Amerah"; Constantce.AreaLang = JarwanAmerahMAD.Text; JarwanAmerahMAD.TextColor = Color.White; JarwanAmerahMAD.BackgroundColor = Color.FromHex("#FF071D66"); var existingPages = Navigation.NavigationStack.ToList(); await Navigation.PushAsync(new Home()); foreach (var page in existingPages) { Navigation.RemovePage(page); }
                await Task.Delay(80); await PopupNavigation.Instance.PopAsync();
            }
            else {  Constantce.Area = "Area"; JarwanAmerahMAD.BackgroundColor = Color.White; JarwanAmerahMAD.TextColor = Color.FromHex("#FF071D66"); }
        }
        async void JrainahMAD_Clicked(object sender, EventArgs e)
        {
            if (JrainahMAD.BackgroundColor == Color.White)
            {
                Constantce.Area = "Jrainah"; Constantce.AreaLang = JrainahMAD.Text; JrainahMAD.TextColor = Color.White; JrainahMAD.BackgroundColor = Color.FromHex("#FF071D66"); var existingPages = Navigation.NavigationStack.ToList(); await Navigation.PushAsync(new Home()); foreach (var page in existingPages) { Navigation.RemovePage(page); }
                await Task.Delay(80); await PopupNavigation.Instance.PopAsync();
            }
            else {  Constantce.Area = "Area"; JrainahMAD.BackgroundColor = Color.White; JrainahMAD.TextColor = Color.FromHex("#FF071D66"); }
        }
        async void JubailMAD_Clicked(object sender, EventArgs e)
        {
            if (JubailMAD.BackgroundColor == Color.White)
            {
                Constantce.Area = "Jubail"; Constantce.AreaLang = JubailMAD.Text; JubailMAD.TextColor = Color.White; JubailMAD.BackgroundColor = Color.FromHex("#FF071D66"); var existingPages = Navigation.NavigationStack.ToList(); await Navigation.PushAsync(new Home()); foreach (var page in existingPages) { Navigation.RemovePage(page); }
                await Task.Delay(80); await PopupNavigation.Instance.PopAsync();
            }
            else {  Constantce.Area = "Area"; JubailMAD.BackgroundColor = Color.White; JubailMAD.TextColor = Color.FromHex("#FF071D66"); }
        }
        async void KaldiyyehMAD_Clicked(object sender, EventArgs e)
        {
            if (KaldiyyehMAD.BackgroundColor == Color.White)
            {
                Constantce.Area = "Kaldiyyeh"; Constantce.AreaLang = KaldiyyehMAD.Text; KaldiyyehMAD.TextColor = Color.White; KaldiyyehMAD.BackgroundColor = Color.FromHex("#FF071D66"); var existingPages = Navigation.NavigationStack.ToList(); await Navigation.PushAsync(new Home()); foreach (var page in existingPages) { Navigation.RemovePage(page); }
                await Task.Delay(80); await PopupNavigation.Instance.PopAsync();
            }
            else {  Constantce.Area = "Area"; KaldiyyehMAD.BackgroundColor = Color.White; KaldiyyehMAD.TextColor = Color.FromHex("#FF071D66"); }
        }
        async void KhaldeyyehAbuEzqalMAD_Clicked(object sender, EventArgs e)
        {
            if (KhaldeyyehAbuEzqalMAD.BackgroundColor == Color.White)
            {
                Constantce.Area = "Khaldeyyeh Abu Ezqal"; Constantce.AreaLang = KhaldeyyehAbuEzqalMAD.Text; KhaldeyyehAbuEzqalMAD.TextColor = Color.White; KhaldeyyehAbuEzqalMAD.BackgroundColor = Color.FromHex("#FF071D66"); var existingPages = Navigation.NavigationStack.ToList(); await Navigation.PushAsync(new Home()); foreach (var page in existingPages) { Navigation.RemovePage(page); }
                await Task.Delay(80); await PopupNavigation.Instance.PopAsync();
            }
            else {  Constantce.Area = "Area"; KhaldeyyehAbuEzqalMAD.BackgroundColor = Color.White; KhaldeyyehAbuEzqalMAD.TextColor = Color.FromHex("#FF071D66"); }
        }
        async void KhatabiyyehMAD_Clicked(object sender, EventArgs e)
        {
            if (KhatabiyyehMAD.BackgroundColor == Color.White)
            {
                Constantce.Area = "Khatabiyyeh"; Constantce.AreaLang = KhatabiyyehMAD.Text; KhatabiyyehMAD.TextColor = Color.White; KhatabiyyehMAD.BackgroundColor = Color.FromHex("#FF071D66"); var existingPages = Navigation.NavigationStack.ToList(); await Navigation.PushAsync(new Home()); foreach (var page in existingPages) { Navigation.RemovePage(page); }
                await Task.Delay(80); await PopupNavigation.Instance.PopAsync();
            }
            else {  Constantce.Area = "Area"; KhatabiyyehMAD.BackgroundColor = Color.White; KhatabiyyehMAD.TextColor = Color.FromHex("#FF071D66"); }
        }
        async void LebMAD_Clicked(object sender, EventArgs e)
        {
            if (LebMAD.BackgroundColor == Color.White)
            {
                Constantce.Area = "Leb"; Constantce.AreaLang = LebMAD.Text; LebMAD.TextColor = Color.White; LebMAD.BackgroundColor = Color.FromHex("#FF071D66"); var existingPages = Navigation.NavigationStack.ToList(); await Navigation.PushAsync(new Home()); foreach (var page in existingPages) { Navigation.RemovePage(page); }
                await Task.Delay(80); await PopupNavigation.Instance.PopAsync();
            }
            else {  Constantce.Area = "Area"; LebMAD.BackgroundColor = Color.White; LebMAD.TextColor = Color.FromHex("#FF071D66"); }
        }
        async void LibbehMAD_Clicked(object sender, EventArgs e)
        {
            if (LibbehMAD.BackgroundColor == Color.White)
            {
                Constantce.Area = "Libbeh"; Constantce.AreaLang = LibbehMAD.Text; LibbehMAD.TextColor = Color.White; LibbehMAD.BackgroundColor = Color.FromHex("#FF071D66"); var existingPages = Navigation.NavigationStack.ToList(); await Navigation.PushAsync(new Home()); foreach (var page in existingPages) { Navigation.RemovePage(page); }
                await Task.Delay(80); await PopupNavigation.Instance.PopAsync();
            }
            else {  Constantce.Area = "Area"; LibbehMAD.BackgroundColor = Color.White; LibbehMAD.TextColor = Color.FromHex("#FF071D66"); }
        }
        async void LusenandRabtMAD_Clicked(object sender, EventArgs e)
        {
            if (LusenandRabtMAD.BackgroundColor == Color.White)
            {
                Constantce.Area = "Lusen and Rabt"; Constantce.AreaLang = LusenandRabtMAD.Text; LusenandRabtMAD.TextColor = Color.White; LusenandRabtMAD.BackgroundColor = Color.FromHex("#FF071D66"); var existingPages = Navigation.NavigationStack.ToList(); await Navigation.PushAsync(new Home()); foreach (var page in existingPages) { Navigation.RemovePage(page); }
                await Task.Delay(80); await PopupNavigation.Instance.PopAsync();
            }
            else {  Constantce.Area = "Area"; LusenandRabtMAD.BackgroundColor = Color.White; LusenandRabtMAD.TextColor = Color.FromHex("#FF071D66"); }
        }
        async void MadabaMAD_Clicked(object sender, EventArgs e)
        {
            if (MadabaMAD.BackgroundColor == Color.White)
            {
                Constantce.Area = "Madaba"; Constantce.AreaLang = MadabaMAD.Text; MadabaMAD.TextColor = Color.White; MadabaMAD.BackgroundColor = Color.FromHex("#FF071D66"); var existingPages = Navigation.NavigationStack.ToList(); await Navigation.PushAsync(new Home()); foreach (var page in existingPages) { Navigation.RemovePage(page); }
                await Task.Delay(80); await PopupNavigation.Instance.PopAsync();
            }
            else {  Constantce.Area = "Area"; MadabaMAD.BackgroundColor = Color.White; MadabaMAD.TextColor = Color.FromHex("#FF071D66"); }
        }
        async void MaeenMAD_Clicked(object sender, EventArgs e)
        {
            if (MaeenMAD.BackgroundColor == Color.White)
            {
                Constantce.Area = "Maeen"; Constantce.AreaLang = MaeenMAD.Text; MaeenMAD.TextColor = Color.White; MaeenMAD.BackgroundColor = Color.FromHex("#FF071D66"); var existingPages = Navigation.NavigationStack.ToList(); await Navigation.PushAsync(new Home()); foreach (var page in existingPages) { Navigation.RemovePage(page); }
                await Task.Delay(80); await PopupNavigation.Instance.PopAsync();
            }
            else {  Constantce.Area = "Area"; MaeenMAD.BackgroundColor = Color.White; MaeenMAD.TextColor = Color.FromHex("#FF071D66"); }
        }
        async void MakawerMAD_Clicked(object sender, EventArgs e)
        {
            if (MakawerMAD.BackgroundColor == Color.White)
            {
                Constantce.Area = "Makawer"; Constantce.AreaLang = MakawerMAD.Text; MakawerMAD.TextColor = Color.White; MakawerMAD.BackgroundColor = Color.FromHex("#FF071D66"); var existingPages = Navigation.NavigationStack.ToList(); await Navigation.PushAsync(new Home()); foreach (var page in existingPages) { Navigation.RemovePage(page); }
                await Task.Delay(80); await PopupNavigation.Instance.PopAsync();
            }
            else {  Constantce.Area = "Area"; MakawerMAD.BackgroundColor = Color.White; MakawerMAD.TextColor = Color.FromHex("#FF071D66"); }
        }
        async void MamoneiaMAD_Clicked(object sender, EventArgs e)
        {
            if (MamoneiaMAD.BackgroundColor == Color.White)
            {
                Constantce.Area = "Ma'moneia"; Constantce.AreaLang = MamoneiaMAD.Text; MamoneiaMAD.TextColor = Color.White; MamoneiaMAD.BackgroundColor = Color.FromHex("#FF071D66"); var existingPages = Navigation.NavigationStack.ToList(); await Navigation.PushAsync(new Home()); foreach (var page in existingPages) { Navigation.RemovePage(page); }
                await Task.Delay(80); await PopupNavigation.Instance.PopAsync();
            }
            else {  Constantce.Area = "Area"; MamoneiaMAD.BackgroundColor = Color.White; MamoneiaMAD.TextColor = Color.FromHex("#FF071D66"); }
        }
        async void ManshiyyehMAD_Clicked(object sender, EventArgs e)
        {
            if (ManshiyyehMAD.BackgroundColor == Color.White)
            {
                Constantce.Area = "Manshiyyeh"; Constantce.AreaLang = ManshiyyehMAD.Text; ManshiyyehMAD.TextColor = Color.White; ManshiyyehMAD.BackgroundColor = Color.FromHex("#FF071D66"); var existingPages = Navigation.NavigationStack.ToList(); await Navigation.PushAsync(new Home()); foreach (var page in existingPages) { Navigation.RemovePage(page); }
                await Task.Delay(80); await PopupNavigation.Instance.PopAsync();
            }
            else {  Constantce.Area = "Area"; ManshiyyehMAD.BackgroundColor = Color.White; ManshiyyehMAD.TextColor = Color.FromHex("#FF071D66"); }
        }
        async void ManshiyyetMaeenMAD_Clicked(object sender, EventArgs e)
        {
            if (ManshiyyetMaeenMAD.BackgroundColor == Color.White)
            {
                Constantce.Area = "Manshiyyet Maeen"; Constantce.AreaLang = ManshiyyetMaeenMAD.Text; ManshiyyetMaeenMAD.TextColor = Color.White; ManshiyyetMaeenMAD.BackgroundColor = Color.FromHex("#FF071D66"); var existingPages = Navigation.NavigationStack.ToList(); await Navigation.PushAsync(new Home()); foreach (var page in existingPages) { Navigation.RemovePage(page); }
                await Task.Delay(80); await PopupNavigation.Instance.PopAsync();
            }
            else {  Constantce.Area = "Area"; ManshiyyetMaeenMAD.BackgroundColor = Color.White; ManshiyyetMaeenMAD.TextColor = Color.FromHex("#FF071D66"); }
        }
        async void MathloothehMAD_Clicked(object sender, EventArgs e)
        {
            if (MathloothehMAD.BackgroundColor == Color.White)
            {
                Constantce.Area = "Mathlootheh"; Constantce.AreaLang = MathloothehMAD.Text; MathloothehMAD.TextColor = Color.White; MathloothehMAD.BackgroundColor = Color.FromHex("#FF071D66"); var existingPages = Navigation.NavigationStack.ToList(); await Navigation.PushAsync(new Home()); foreach (var page in existingPages) { Navigation.RemovePage(page); }
                await Task.Delay(80); await PopupNavigation.Instance.PopAsync();
            }
            else {  Constantce.Area = "Area"; MathloothehMAD.BackgroundColor = Color.White; MathloothehMAD.TextColor = Color.FromHex("#FF071D66"); }
        }
        async void MeqadBenNasrallahMAD_Clicked(object sender, EventArgs e)
        {
            if (MeqadBenNasrallahMAD.BackgroundColor == Color.White)
            {
                Constantce.Area = "Meq'ad Ben Nasrallah"; Constantce.AreaLang = MeqadBenNasrallahMAD.Text; MeqadBenNasrallahMAD.TextColor = Color.White; MeqadBenNasrallahMAD.BackgroundColor = Color.FromHex("#FF071D66"); var existingPages = Navigation.NavigationStack.ToList(); await Navigation.PushAsync(new Home()); foreach (var page in existingPages) { Navigation.RemovePage(page); }
                await Task.Delay(80); await PopupNavigation.Instance.PopAsync();
            }
            else {  Constantce.Area = "Area"; MeqadBenNasrallahMAD.BackgroundColor = Color.White; MeqadBenNasrallahMAD.TextColor = Color.FromHex("#FF071D66"); }
        }
        async void MesherfehMAD_Clicked(object sender, EventArgs e)
        {
            if (MesherfehMAD.BackgroundColor == Color.White)
            {
                Constantce.Area = "Mesherfeh"; Constantce.AreaLang = MesherfehMAD.Text; MesherfehMAD.TextColor = Color.White; MesherfehMAD.BackgroundColor = Color.FromHex("#FF071D66"); var existingPages = Navigation.NavigationStack.ToList(); await Navigation.PushAsync(new Home()); foreach (var page in existingPages) { Navigation.RemovePage(page); }
                await Task.Delay(80); await PopupNavigation.Instance.PopAsync();
            }
            else {  Constantce.Area = "Area"; MesherfehMAD.BackgroundColor = Color.White; MesherfehMAD.TextColor = Color.FromHex("#FF071D66"); }
        }
        async void MkhaitMAD_Clicked(object sender, EventArgs e)
        {
            if (MkhaitMAD.BackgroundColor == Color.White)
            {
                Constantce.Area = "Mkhait"; Constantce.AreaLang = MkhaitMAD.Text; MkhaitMAD.TextColor = Color.White; MkhaitMAD.BackgroundColor = Color.FromHex("#FF071D66"); var existingPages = Navigation.NavigationStack.ToList(); await Navigation.PushAsync(new Home()); foreach (var page in existingPages) { Navigation.RemovePage(page); }
                await Task.Delay(80); await PopupNavigation.Instance.PopAsync();
            }
            else {  Constantce.Area = "Area"; MkhaitMAD.BackgroundColor = Color.White; MkhaitMAD.TextColor = Color.FromHex("#FF071D66"); }
        }
        async void MlaihMAD_Clicked(object sender, EventArgs e)
        {
            if (MlaihMAD.BackgroundColor == Color.White)
            {
                Constantce.Area = "Mlaih"; Constantce.AreaLang = MlaihMAD.Text; MlaihMAD.TextColor = Color.White; MlaihMAD.BackgroundColor = Color.FromHex("#FF071D66"); var existingPages = Navigation.NavigationStack.ToList(); await Navigation.PushAsync(new Home()); foreach (var page in existingPages) { Navigation.RemovePage(page); }
                await Task.Delay(80); await PopupNavigation.Instance.PopAsync();
            }
            else {  Constantce.Area = "Area"; MlaihMAD.BackgroundColor = Color.White; MlaihMAD.TextColor = Color.FromHex("#FF071D66"); }
        }
        async void MuhamadehMAD_Clicked(object sender, EventArgs e)
        {
            if (MuhamadehMAD.BackgroundColor == Color.White)
            {
                Constantce.Area = "Muhamadeh"; Constantce.AreaLang = MuhamadehMAD.Text; MuhamadehMAD.TextColor = Color.White; MuhamadehMAD.BackgroundColor = Color.FromHex("#FF071D66"); var existingPages = Navigation.NavigationStack.ToList(); await Navigation.PushAsync(new Home()); foreach (var page in existingPages) { Navigation.RemovePage(page); }
                await Task.Delay(80); await PopupNavigation.Instance.PopAsync();
            }
            else {  Constantce.Area = "Area"; MuhamadehMAD.BackgroundColor = Color.White; MuhamadehMAD.TextColor = Color.FromHex("#FF071D66"); }
        }
        async void MunsafMekherahMAD_Clicked(object sender, EventArgs e)
        {
            if (MunsafMekherahMAD.BackgroundColor == Color.White)
            {
                Constantce.Area = "Munsaf Mekher'ah"; Constantce.AreaLang = MunsafMekherahMAD.Text; MunsafMekherahMAD.TextColor = Color.White; MunsafMekherahMAD.BackgroundColor = Color.FromHex("#FF071D66"); var existingPages = Navigation.NavigationStack.ToList(); await Navigation.PushAsync(new Home()); foreach (var page in existingPages) { Navigation.RemovePage(page); }
                await Task.Delay(80); await PopupNavigation.Instance.PopAsync();
            }
            else {  Constantce.Area = "Area"; MunsafMekherahMAD.BackgroundColor = Color.White; MunsafMekherahMAD.TextColor = Color.FromHex("#FF071D66"); }
        }
        async void NamyehMAD_Clicked(object sender, EventArgs e)
        {
            if (NamyehMAD.BackgroundColor == Color.White)
            {
                Constantce.Area = "Namyeh"; Constantce.AreaLang = NamyehMAD.Text; NamyehMAD.TextColor = Color.White; NamyehMAD.BackgroundColor = Color.FromHex("#FF071D66"); var existingPages = Navigation.NavigationStack.ToList(); await Navigation.PushAsync(new Home()); foreach (var page in existingPages) { Navigation.RemovePage(page); }
                await Task.Delay(80); await PopupNavigation.Instance.PopAsync();
            }
            else {  Constantce.Area = "Area"; NamyehMAD.BackgroundColor = Color.White; NamyehMAD.TextColor = Color.FromHex("#FF071D66"); }
        }
        async void NasiebMAD_Clicked(object sender, EventArgs e)
        {
            if (NasiebMAD.BackgroundColor == Color.White)
            {
                Constantce.Area = "Nasieb"; Constantce.AreaLang = NasiebMAD.Text; NasiebMAD.TextColor = Color.White; NasiebMAD.BackgroundColor = Color.FromHex("#FF071D66"); var existingPages = Navigation.NavigationStack.ToList(); await Navigation.PushAsync(new Home()); foreach (var page in existingPages) { Navigation.RemovePage(page); }
                await Task.Delay(80); await PopupNavigation.Instance.PopAsync();
            }
            else {  Constantce.Area = "Area"; NasiebMAD.BackgroundColor = Color.White; NasiebMAD.TextColor = Color.FromHex("#FF071D66"); }
        }
        async void NozhetElWalehMAD_Clicked(object sender, EventArgs e)
        {
            if (NozhetElWalehMAD.BackgroundColor == Color.White)
            {
                Constantce.Area = "Nozhet El - Waleh"; Constantce.AreaLang = NozhetElWalehMAD.Text; NozhetElWalehMAD.TextColor = Color.White; NozhetElWalehMAD.BackgroundColor = Color.FromHex("#FF071D66"); var existingPages = Navigation.NavigationStack.ToList(); await Navigation.PushAsync(new Home()); foreach (var page in existingPages) { Navigation.RemovePage(page); }
                await Task.Delay(80); await PopupNavigation.Instance.PopAsync();
            }
            else {  Constantce.Area = "Area"; NozhetElWalehMAD.BackgroundColor = Color.White; NozhetElWalehMAD.TextColor = Color.FromHex("#FF071D66"); }
        }
        async void OyoonMoosaMAD_Clicked(object sender, EventArgs e)
        {
            if (OyoonMoosaMAD.BackgroundColor == Color.White)
            {
                Constantce.Area = "Oyoon Moosa"; Constantce.AreaLang = OyoonMoosaMAD.Text; OyoonMoosaMAD.TextColor = Color.White; OyoonMoosaMAD.BackgroundColor = Color.FromHex("#FF071D66"); var existingPages = Navigation.NavigationStack.ToList(); await Navigation.PushAsync(new Home()); foreach (var page in existingPages) { Navigation.RemovePage(page); }
                await Task.Delay(80); await PopupNavigation.Instance.PopAsync();
            }
            else {  Constantce.Area = "Area"; OyoonMoosaMAD.BackgroundColor = Color.White; OyoonMoosaMAD.TextColor = Color.FromHex("#FF071D66"); }
        }
        async void QasmeiaMAD_Clicked(object sender, EventArgs e)
        {
            if (QasmeiaMAD.BackgroundColor == Color.White)
            {
                Constantce.Area = "Qasmeia"; Constantce.AreaLang = QasmeiaMAD.Text; QasmeiaMAD.TextColor = Color.White; QasmeiaMAD.BackgroundColor = Color.FromHex("#FF071D66"); var existingPages = Navigation.NavigationStack.ToList(); await Navigation.PushAsync(new Home()); foreach (var page in existingPages) { Navigation.RemovePage(page); }
                await Task.Delay(80); await PopupNavigation.Instance.PopAsync();
            }
            else {  Constantce.Area = "Area"; QasmeiaMAD.BackgroundColor = Color.White; QasmeiaMAD.TextColor = Color.FromHex("#FF071D66"); }
        }
        async void QbaibehMAD_Clicked(object sender, EventArgs e)
        {
            if (QbaibehMAD.BackgroundColor == Color.White)
            {
                Constantce.Area = "Qbaibeh"; Constantce.AreaLang = QbaibehMAD.Text; QbaibehMAD.TextColor = Color.White; QbaibehMAD.BackgroundColor = Color.FromHex("#FF071D66"); var existingPages = Navigation.NavigationStack.ToList(); await Navigation.PushAsync(new Home()); foreach (var page in existingPages) { Navigation.RemovePage(page); }
                await Task.Delay(80); await PopupNavigation.Instance.PopAsync();
            }
            else {  Constantce.Area = "Area"; QbaibehMAD.BackgroundColor = Color.White; QbaibehMAD.TextColor = Color.FromHex("#FF071D66"); }
        }
        async void QrayyatMAD_Clicked(object sender, EventArgs e)
        {
            if (QrayyatMAD.BackgroundColor == Color.White)
            {
                Constantce.Area = "Qrayyat"; Constantce.AreaLang = QrayyatMAD.Text; QrayyatMAD.TextColor = Color.White; QrayyatMAD.BackgroundColor = Color.FromHex("#FF071D66"); var existingPages = Navigation.NavigationStack.ToList(); await Navigation.PushAsync(new Home()); foreach (var page in existingPages) { Navigation.RemovePage(page); }
                await Task.Delay(80); await PopupNavigation.Instance.PopAsync();
            }
            else {  Constantce.Area = "Area"; QrayyatMAD.BackgroundColor = Color.White; QrayyatMAD.TextColor = Color.FromHex("#FF071D66"); }
        }
        async void RashdeiaMAD_Clicked(object sender, EventArgs e)
        {
            if (RashdeiaMAD.BackgroundColor == Color.White)
            {
                Constantce.Area = "Rashdeia"; Constantce.AreaLang = RashdeiaMAD.Text; RashdeiaMAD.TextColor = Color.White; RashdeiaMAD.BackgroundColor = Color.FromHex("#FF071D66"); var existingPages = Navigation.NavigationStack.ToList(); await Navigation.PushAsync(new Home()); foreach (var page in existingPages) { Navigation.RemovePage(page); }
                await Task.Delay(80); await PopupNavigation.Instance.PopAsync();
            }
            else {  Constantce.Area = "Area"; RashdeiaMAD.BackgroundColor = Color.White; RashdeiaMAD.TextColor = Color.FromHex("#FF071D66"); }
        }
        async void RehaneihUmShajarahMAD_Clicked(object sender, EventArgs e)
        {
            if (RehaneihUmShajarahMAD.BackgroundColor == Color.White)
            {
                Constantce.Area = "Rehaneih Um Shajarah"; Constantce.AreaLang = RehaneihUmShajarahMAD.Text; RehaneihUmShajarahMAD.TextColor = Color.White; RehaneihUmShajarahMAD.BackgroundColor = Color.FromHex("#FF071D66"); var existingPages = Navigation.NavigationStack.ToList(); await Navigation.PushAsync(new Home()); foreach (var page in existingPages) { Navigation.RemovePage(page); }
                await Task.Delay(80); await PopupNavigation.Instance.PopAsync();
            }
            else {  Constantce.Area = "Area"; RehaneihUmShajarahMAD.BackgroundColor = Color.White; RehaneihUmShajarahMAD.TextColor = Color.FromHex("#FF071D66"); }
        }
        async void SafaMAD_Clicked(object sender, EventArgs e)
        {
            if (SafaMAD.BackgroundColor == Color.White)
            {
                Constantce.Area = "Safa"; Constantce.AreaLang = SafaMAD.Text; SafaMAD.TextColor = Color.White; SafaMAD.BackgroundColor = Color.FromHex("#FF071D66"); var existingPages = Navigation.NavigationStack.ToList(); await Navigation.PushAsync(new Home()); foreach (var page in existingPages) { Navigation.RemovePage(page); }
                await Task.Delay(80); await PopupNavigation.Instance.PopAsync();
            }
            else {  Constantce.Area = "Area"; SafaMAD.BackgroundColor = Color.White; SafaMAD.TextColor = Color.FromHex("#FF071D66"); }
        }
        async void ShqaiqMAD_Clicked(object sender, EventArgs e)
        {
            if (ShqaiqMAD.BackgroundColor == Color.White)
            {
                Constantce.Area = "Shqaiq"; Constantce.AreaLang = ShqaiqMAD.Text; ShqaiqMAD.TextColor = Color.White; ShqaiqMAD.BackgroundColor = Color.FromHex("#FF071D66"); var existingPages = Navigation.NavigationStack.ToList(); await Navigation.PushAsync(new Home()); foreach (var page in existingPages) { Navigation.RemovePage(page); }
                await Task.Delay(80); await PopupNavigation.Instance.PopAsync();
            }
            else {  Constantce.Area = "Area"; ShqaiqMAD.BackgroundColor = Color.White; ShqaiqMAD.TextColor = Color.FromHex("#FF071D66"); }
        }
        async void SyaghahMAD_Clicked(object sender, EventArgs e)
        {
            if (SyaghahMAD.BackgroundColor == Color.White)
            {
                Constantce.Area = "Syaghah"; Constantce.AreaLang = SyaghahMAD.Text; SyaghahMAD.TextColor = Color.White; SyaghahMAD.BackgroundColor = Color.FromHex("#FF071D66"); var existingPages = Navigation.NavigationStack.ToList(); await Navigation.PushAsync(new Home()); foreach (var page in existingPages) { Navigation.RemovePage(page); }
                await Task.Delay(80); await PopupNavigation.Instance.PopAsync();
            }
            else {  Constantce.Area = "Area"; SyaghahMAD.BackgroundColor = Color.White; SyaghahMAD.TextColor = Color.FromHex("#FF071D66"); }
        }
        async void UmmShjairehGharbiyyehMAD_Clicked(object sender, EventArgs e)
        {
            if (UmmShjairehGharbiyyehMAD.BackgroundColor == Color.White)
            {
                Constantce.Area = "Umm Shjaireh Gharbiyyeh"; Constantce.AreaLang = UmmShjairehGharbiyyehMAD.Text; UmmShjairehGharbiyyehMAD.TextColor = Color.White; UmmShjairehGharbiyyehMAD.BackgroundColor = Color.FromHex("#FF071D66"); var existingPages = Navigation.NavigationStack.ToList(); await Navigation.PushAsync(new Home()); foreach (var page in existingPages) { Navigation.RemovePage(page); }
                await Task.Delay(80); await PopupNavigation.Instance.PopAsync();
            }
            else {  Constantce.Area = "Area"; UmmShjairehGharbiyyehMAD.BackgroundColor = Color.White; UmmShjairehGharbiyyehMAD.TextColor = Color.FromHex("#FF071D66"); }
        }
        async void UmmShjairehSharqiyyehMAD_Clicked(object sender, EventArgs e)
        {
            if (UmmShjairehSharqiyyehMAD.BackgroundColor == Color.White)
            {
                Constantce.Area = "Umm Shjaireh Sharqiyyeh"; Constantce.AreaLang = UmmShjairehSharqiyyehMAD.Text; UmmShjairehSharqiyyehMAD.TextColor = Color.White; UmmShjairehSharqiyyehMAD.BackgroundColor = Color.FromHex("#FF071D66"); var existingPages = Navigation.NavigationStack.ToList(); await Navigation.PushAsync(new Home()); foreach (var page in existingPages) { Navigation.RemovePage(page); }
                await Task.Delay(80); await PopupNavigation.Instance.PopAsync();
            }
            else {  Constantce.Area = "Area"; UmmShjairehSharqiyyehMAD.BackgroundColor = Color.White; UmmShjairehSharqiyyehMAD.TextColor = Color.FromHex("#FF071D66"); }
        }
        async void WadiElMujebMAD_Clicked(object sender, EventArgs e)
        {
            if (WadiElMujebMAD.BackgroundColor == Color.White)
            {
                Constantce.Area = "Wadi El - Mujeb"; Constantce.AreaLang = WadiElMujebMAD.Text; WadiElMujebMAD.TextColor = Color.White; WadiElMujebMAD.BackgroundColor = Color.FromHex("#FF071D66"); var existingPages = Navigation.NavigationStack.ToList(); await Navigation.PushAsync(new Home()); foreach (var page in existingPages) { Navigation.RemovePage(page); }
                await Task.Delay(80); await PopupNavigation.Instance.PopAsync();
            }
            else {  Constantce.Area = "Area"; WadiElMujebMAD.BackgroundColor = Color.White; WadiElMujebMAD.TextColor = Color.FromHex("#FF071D66"); }
        }
        async void WahMrejmetElHamedMAD_Clicked(object sender, EventArgs e)
        {
            if (WahMrejmetElHamedMAD.BackgroundColor == Color.White)
            {
                Constantce.Area = "Wah Mrejmet El-Hamed"; Constantce.AreaLang = WahMrejmetElHamedMAD.Text; WahMrejmetElHamedMAD.TextColor = Color.White; WahMrejmetElHamedMAD.BackgroundColor = Color.FromHex("#FF071D66"); var existingPages = Navigation.NavigationStack.ToList(); await Navigation.PushAsync(new Home()); foreach (var page in existingPages) { Navigation.RemovePage(page); }
                await Task.Delay(80); await PopupNavigation.Instance.PopAsync();
            }
            else {  Constantce.Area = "Area"; WahMrejmetElHamedMAD.BackgroundColor = Color.White; WahMrejmetElHamedMAD.TextColor = Color.FromHex("#FF071D66"); }
        }
        async void WalehMAD_Clicked(object sender, EventArgs e)
        {
            if (WalehMAD.BackgroundColor == Color.White)
            {
                Constantce.Area = "Waleh"; Constantce.AreaLang = WalehMAD.Text; WalehMAD.TextColor = Color.White; WalehMAD.BackgroundColor = Color.FromHex("#FF071D66"); var existingPages = Navigation.NavigationStack.ToList(); await Navigation.PushAsync(new Home()); foreach (var page in existingPages) { Navigation.RemovePage(page); }
                await Task.Delay(80); await PopupNavigation.Instance.PopAsync();
            }
            else {  Constantce.Area = "Area"; WalehMAD.BackgroundColor = Color.White; WalehMAD.TextColor = Color.FromHex("#FF071D66"); }
        }
        async void WasiyyehMAD_Clicked(object sender, EventArgs e)
        {
            if (WasiyyehMAD.BackgroundColor == Color.White)
            {
                Constantce.Area = "Wasiyyeh"; Constantce.AreaLang = WasiyyehMAD.Text; WasiyyehMAD.TextColor = Color.White; WasiyyehMAD.BackgroundColor = Color.FromHex("#FF071D66"); var existingPages = Navigation.NavigationStack.ToList(); await Navigation.PushAsync(new Home()); foreach (var page in existingPages) { Navigation.RemovePage(page); }
                await Task.Delay(80); await PopupNavigation.Instance.PopAsync();
            }
            else {  Constantce.Area = "Area"; WasiyyehMAD.BackgroundColor = Color.White; WasiyyehMAD.TextColor = Color.FromHex("#FF071D66"); }
        }
        async void ZarqaMaeenMAD_Clicked(object sender, EventArgs e)
        {
            if (ZarqaMaeenMAD.BackgroundColor == Color.White)
            {
                Constantce.Area = "Zarqa' Maeen"; Constantce.AreaLang = ZarqaMaeenMAD.Text; ZarqaMaeenMAD.TextColor = Color.White; ZarqaMaeenMAD.BackgroundColor = Color.FromHex("#FF071D66"); var existingPages = Navigation.NavigationStack.ToList(); await Navigation.PushAsync(new Home()); foreach (var page in existingPages) { Navigation.RemovePage(page); }
                await Task.Delay(80); await PopupNavigation.Instance.PopAsync();
            }
            else {  Constantce.Area = "Area"; ZarqaMaeenMAD.BackgroundColor = Color.White; ZarqaMaeenMAD.TextColor = Color.FromHex("#FF071D66"); }
        }
        async void ZaynaMAD_Clicked(object sender, EventArgs e)
        {
            if (ZaynaMAD.BackgroundColor == Color.White)
            {
                Constantce.Area = "Zayna"; Constantce.AreaLang = ZaynaMAD.Text; ZaynaMAD.TextColor = Color.White; ZaynaMAD.BackgroundColor = Color.FromHex("#FF071D66"); var existingPages = Navigation.NavigationStack.ToList(); await Navigation.PushAsync(new Home()); foreach (var page in existingPages) { Navigation.RemovePage(page); }
                await Task.Delay(80); await PopupNavigation.Instance.PopAsync();
            }
            else {  Constantce.Area = "Area"; ZaynaMAD.BackgroundColor = Color.White; ZaynaMAD.TextColor = Color.FromHex("#FF071D66"); }
        }


        //******************************End madba Areas**********************************************************************




    }
}