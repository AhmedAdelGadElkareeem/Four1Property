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
    public partial class Maan : PopupPage
    {
        public Maan()
        {
            InitializeComponent();




            if (Application.Current.Properties["Language"].ToString() == "Arabic")
            {
                this.FlowDirection = FlowDirection.RightToLeft;
                UpText.Text = "الرجاء اختيار المنطقة";

                AbuElLissanMAN.Text = "ابو اللسن";
                AbuMakhtoobMAN.Text = "ابو مخطوب";
                AinAmmoonMAN.Text = "عين امون";
                AlJafrMAN.Text = "الجفر";
                AlJarbaKbierehMAN.Text = "الجرباء الكبيرة";
                AlJarbaSghierehMAN.Text = "الجرباء الصغيرة";
                AlJayyehMAN.Text = "الجايه";
                AlJhairMAN.Text = "الجهير";
                AlMadarejMAN.Text = "المديرج";
                AlManshiyyehMAN.Text = "المنشية";
                AlMansoorahMAN.Text = "المنصوره";
                AlMaqariyyehMAN.Text = "المقارعيه";
                AlModawwarahMAN.Text = "المدورة";
                AlMohammadiyyehMAN.Text = "المحمدية";
                AlMothallathMAN.Text = "المثلث";
                AlMraighahMAN.Text = "المريغة";
                AlQasemeahMAN.Text = "القاسمية";
                AlTahoonehMAN.Text = "الطاحونة";
                AlTaybahMAN.Text = "الطيبة";
                AlThugraMAN.Text = "الثغرة";
                AnNaqabElGharbiMAN.Text = "النقب الغربي";
                AnNaqabMAN.Text = "النقب";
                ArRajefMAN.Text = "الراجف";
                ArRasseesMAN.Text = "الرسيس";
                AshariMAN.Text = "الاشعري";
                AshShadeiahMAN.Text = "الشيدية";
                AshShobakMAN.Text = "الشوبك";
                AsSadakahMAN.Text = "الصدقة";
                AthrohMAN.Text = "اذرح";
                AuhadahMAN.Text = "اوهيده";
                AzZaitonehMAN.Text = "الزيتونه";
                AzZobeiriyyehMAN.Text = "الزبيرية";
                BaidaMAN.Text = "البيضا";
                BairAbuElAlaqMAN.Text = "بير ابو العلق";
                BastaMAN.Text = "بسطه";
                BatnElGhoolMAN.Text = "بطن الغول";
                BeirAbuDnnehMAN.Text = "بير ابو دنه";
                BeirElBietarMAN.Text = "بير البيطار";
                BeirElDabbaghatMAN.Text = "بئر الدباغات";
                BeirKhadadMAN.Text = "بير خداد";
                DabitElKaramMAN.Text = "دبة الكرم";
                DlaghahMAN.Text = "دلاغه";
                EnaizehMAN.Text = "عنيزة";
                EtmaiyahMAN.Text = "الطميعة";
                FaisaleahMAN.Text = "الفيصلية";
                FaisalehUmdhaibieMAN.Text = "الفيصلية";
                FardakhMAN.Text = "الفرذخ";
                HaddadahMAN.Text = "الحداده";
                HaiadMAN.Text = "الحياض";
                HashemiyyehMAN.Text = "الهاشمية";
                HawalehMAN.Text = "حواله";
                HayyMAN.Text = "الحي";
                HuseiniyaMAN.Text = "الحسينية";
                IelMAN.Text = "ايل";
                KhirbatUmEttelianMAN.Text = "خربة ام الطليان";
                MaanMAN.Text = "معان";
                MahatetJerdanehMAN.Text = "محطة الجرذانة";
                QurainMAN.Text = "قرين";
                RaudetElAmirQaMAN.Text = "القاع";
                SatehMaanMAN.Text = "سطح معان";
                ShammakhMAN.Text = "شماخ";
                SwaimrehMAN.Text = "سويمره";
                TasanMAN.Text = "طاسان";
                TharwahMAN.Text = "الذروه";
                UmmSehoonMAN.Text = "ام صيحون";
                WadiMoosaMAN.Text = "وادي موسى";


            }
            else
            {
                this.FlowDirection = FlowDirection.LeftToRight;
                UpText.Text = "Please Select Area";

                AbuElLissanMAN.Text = "Abu El - Lissan";
                AbuMakhtoobMAN.Text = "Abu Makhtoob";
                AinAmmoonMAN.Text = "Ain Ammoon";
                AlJafrMAN.Text = "Al - Jafr";
                AlJarbaKbierehMAN.Text = "Al - Jarba Kbiereh";
                AlJarbaSghierehMAN.Text = "Al - Jarba Sghiereh";
                AlJayyehMAN.Text = "Al - Jayyeh";
                AlJhairMAN.Text = "Al - Jhair";
                AlMadarejMAN.Text = "Al - Madarej";
                AlManshiyyehMAN.Text = "Al - Manshiyyeh";
                AlMansoorahMAN.Text = "Al - Mansoorah";
                AlMaqariyyehMAN.Text = "Al - Maqari'yyeh";
                AlModawwarahMAN.Text = "Al - Modawwarah";
                AlMohammadiyyehMAN.Text = "Al - Mohammadiyyeh";
                AlMothallathMAN.Text = "Al - Mothallath";
                AlMraighahMAN.Text = "Al - Mraighah";
                AlQasemeahMAN.Text = "Al - Qasemeah";
                AlTahoonehMAN.Text = "Al - Tahooneh";
                AlTaybahMAN.Text = "Al - Taybah";
                AlThugraMAN.Text = "Al - Thugra";
                AnNaqabElGharbiMAN.Text = "An - Naqab El - Gharbi";
                AnNaqabMAN.Text = "An - Naqab";
                ArRajefMAN.Text = "Ar - Rajef";
                ArRasseesMAN.Text = "Ar - Rassees";
                AshariMAN.Text = "Ashari";
                AshShadeiahMAN.Text = "Ash - Shadeiah";
                AshShobakMAN.Text = "Ash - Shobak";
                AsSadakahMAN.Text = "As - Sadakah";
                AthrohMAN.Text = "Athroh";
                AuhadahMAN.Text = "Auhadah";
                AzZaitonehMAN.Text = "Az - Zaitoneh";
                AzZobeiriyyehMAN.Text = "Az - Zobeiriyyeh";
                BaidaMAN.Text = "Baida";
                BairAbuElAlaqMAN.Text = "Bair Abu El-Alaq";
                BastaMAN.Text = "Basta";
                BatnElGhoolMAN.Text = "Batn El - Ghool";
                BeirAbuDnnehMAN.Text = "Beir Abu Dnneh";
                BeirElBietarMAN.Text = "Beir El - Bietar";
                BeirElDabbaghatMAN.Text = "Beir El - Dabbaghat";
                BeirKhadadMAN.Text = "Beir Khadad";
                DabitElKaramMAN.Text = "Dabit El - Karam";
                DlaghahMAN.Text = "Dlaghah";
                EnaizehMAN.Text = "Enaizeh";
                EtmaiyahMAN.Text = "Etmaiyah";
                FaisaleahMAN.Text = "Faisaleah";
                FaisalehUmdhaibieMAN.Text = "Faisaleh Um - dhaibie'";
                FardakhMAN.Text = "Fardakh";
                HaddadahMAN.Text = "Haddadah";
                HaiadMAN.Text = "Haiad";
                HashemiyyehMAN.Text = "Hashemiyyeh";
                HawalehMAN.Text = "Hawaleh";
                HayyMAN.Text = "Hayy";
                HuseiniyaMAN.Text = "Huseiniya";
                IelMAN.Text = "Iel";
                KhirbatUmEttelianMAN.Text = "Khirbat Um Ettelian";
                MaanMAN.Text = "Ma'an";
                MahatetJerdanehMAN.Text = "Mahatet Jerdaneh";
                QurainMAN.Text = "Qurain";
                RaudetElAmirQaMAN.Text = "Raudet El - Amir Qa";
                SatehMaanMAN.Text = "Sateh Ma'an";
                ShammakhMAN.Text = "Shammakh";
                SwaimrehMAN.Text = "Swaimreh";
                TasanMAN.Text = "Tasan";
                TharwahMAN.Text = "Tharwah";
                UmmSehoonMAN.Text = "Umm Sehoon";
                WadiMoosaMAN.Text = "Wadi Moosa";

            }
            if (Constantce.Area == "Abu El - Lissan")
            {
                AbuElLissanMAN.BackgroundColor = Color.FromHex("#FF071D66"); AbuElLissanMAN.TextColor = Color.White;
            }
            else if (Constantce.Area == "Abu Makhtoob")
            {
                AbuMakhtoobMAN.BackgroundColor = Color.FromHex("#FF071D66"); AbuMakhtoobMAN.TextColor = Color.White;
            }
            else if (Constantce.Area == "Ain Ammoon")
            {
                AinAmmoonMAN.BackgroundColor = Color.FromHex("#FF071D66"); AinAmmoonMAN.TextColor = Color.White;
            }
            else if (Constantce.Area == "Al - Jafr")
            {
                AlJafrMAN.BackgroundColor = Color.FromHex("#FF071D66"); AlJafrMAN.TextColor = Color.White;
            }
            else if (Constantce.Area == "Al - Jarba Kbiereh")
            {
                AlJarbaKbierehMAN.BackgroundColor = Color.FromHex("#FF071D66"); AlJarbaKbierehMAN.TextColor = Color.White;
            }
            else if (Constantce.Area == "Al - Jarba Sghiereh")
            {
                AlJarbaSghierehMAN.BackgroundColor = Color.FromHex("#FF071D66"); AlJarbaSghierehMAN.TextColor = Color.White;
            }
            else if (Constantce.Area == "Al - Jayyeh")
            {
                AlJayyehMAN.BackgroundColor = Color.FromHex("#FF071D66"); AlJayyehMAN.TextColor = Color.White;
            }
            else if (Constantce.Area == "Al - Jhair")
            {
                AlJhairMAN.BackgroundColor = Color.FromHex("#FF071D66"); AlJhairMAN.TextColor = Color.White;
            }
            else if (Constantce.Area == "Al - Madarej")
            {
                AlMadarejMAN.BackgroundColor = Color.FromHex("#FF071D66"); AlMadarejMAN.TextColor = Color.White;
            }
            else if (Constantce.Area == "Al - Manshiyyeh")
            {
                AlManshiyyehMAN.BackgroundColor = Color.FromHex("#FF071D66"); AlManshiyyehMAN.TextColor = Color.White;
            }
            else if (Constantce.Area == "Al - Mansoorah")
            {
                AlMansoorahMAN.BackgroundColor = Color.FromHex("#FF071D66"); AlMansoorahMAN.TextColor = Color.White;
            }
            else if (Constantce.Area == "Al - Maqari'yyeh") { AlMaqariyyehMAN.BackgroundColor = Color.FromHex("#FF071D66"); AlMaqariyyehMAN.TextColor = Color.White; }
            else if (Constantce.Area == "Al - Modawwarah") { AlModawwarahMAN.BackgroundColor = Color.FromHex("#FF071D66"); AlModawwarahMAN.TextColor = Color.White; }
            else if (Constantce.Area == "Al - Mohammadiyyeh")
            {
                AlMohammadiyyehMAN.BackgroundColor = Color.FromHex("#FF071D66"); AlMohammadiyyehMAN.TextColor = Color.White;
            }
            else if (Constantce.Area == "Al - Mothallath")
            {
                AlMothallathMAN.BackgroundColor = Color.FromHex("#FF071D66"); AlMothallathMAN.TextColor = Color.White;
            }
            else if (Constantce.Area == "Al - Mraighah")
            {
                AlMraighahMAN.BackgroundColor = Color.FromHex("#FF071D66"); AlMraighahMAN.TextColor = Color.White;
            }
            else if (Constantce.Area == "Al - Qasemeah")
            {
                AlQasemeahMAN.BackgroundColor = Color.FromHex("#FF071D66"); AlQasemeahMAN.TextColor = Color.White;
            }
            else if (Constantce.Area == "Al - Tahooneh")
            {
                AlTahoonehMAN.BackgroundColor = Color.FromHex("#FF071D66"); AlTahoonehMAN.TextColor = Color.White;
            }
            else if (Constantce.Area == "Al - Taybah")
            {
                AlTaybahMAN.BackgroundColor = Color.FromHex("#FF071D66"); AlTaybahMAN.TextColor = Color.White;
            }
            else if (Constantce.Area == "Al - Thugra")
            {
                AlThugraMAN.BackgroundColor = Color.FromHex("#FF071D66"); AlThugraMAN.TextColor = Color.White;
            }
            else if (Constantce.Area == "An - Naqab El - Gharbi")
            {
                AnNaqabElGharbiMAN.BackgroundColor = Color.FromHex("#FF071D66"); AnNaqabElGharbiMAN.TextColor = Color.White;
            }
            else if (Constantce.Area == "An - Naqab")
            {
                AnNaqabMAN.BackgroundColor = Color.FromHex("#FF071D66"); AnNaqabMAN.TextColor = Color.White;
            }
            else if (Constantce.Area == "Ar - Rajef")
            {
                ArRajefMAN.BackgroundColor = Color.FromHex("#FF071D66"); ArRajefMAN.TextColor = Color.White;
            }
            else if (Constantce.Area == "Ar - Rassees") { ArRasseesMAN.BackgroundColor = Color.FromHex("#FF071D66"); ArRasseesMAN.TextColor = Color.White; }
            else if (Constantce.Area == "Ashari") { AshariMAN.BackgroundColor = Color.FromHex("#FF071D66"); AshariMAN.TextColor = Color.White; }
            else if (Constantce.Area == "Ash - Shadeiah") { AshShadeiahMAN.BackgroundColor = Color.FromHex("#FF071D66"); AshShadeiahMAN.TextColor = Color.White; }
            else if (Constantce.Area == "Ash - Shobak")
            {
                AshShobakMAN.BackgroundColor = Color.FromHex("#FF071D66"); AshShobakMAN.TextColor = Color.White;
            }
            else if (Constantce.Area == "As - Sadakah")
            {
                AsSadakahMAN.BackgroundColor = Color.FromHex("#FF071D66"); AsSadakahMAN.TextColor = Color.White;
            }
            else if (Constantce.Area == "Athroh")
            {
                AthrohMAN.BackgroundColor = Color.FromHex("#FF071D66"); AthrohMAN.TextColor = Color.White;
            }
            else if (Constantce.Area == "Auhadah")
            {
                AuhadahMAN.BackgroundColor = Color.FromHex("#FF071D66"); AuhadahMAN.TextColor = Color.White;
            }
            else if (Constantce.Area == "Az - Zaitoneh")
            {
                AzZaitonehMAN.BackgroundColor = Color.FromHex("#FF071D66"); AzZaitonehMAN.TextColor = Color.White;
            }
            else if (Constantce.Area == "Az - Zobeiriyyeh")
            {
                AzZobeiriyyehMAN.BackgroundColor = Color.FromHex("#FF071D66"); AzZobeiriyyehMAN.TextColor = Color.White;
            }
            else if (Constantce.Area == "Baida")
            {
                BaidaMAN.BackgroundColor = Color.FromHex("#FF071D66"); BaidaMAN.TextColor = Color.White;
            }
            else if (Constantce.Area == "Bair Abu El-Alaq")
            {
                BairAbuElAlaqMAN.BackgroundColor = Color.FromHex("#FF071D66"); BairAbuElAlaqMAN.TextColor = Color.White;
            }
            else if (Constantce.Area == "Basta")
            {
                BastaMAN.BackgroundColor = Color.FromHex("#FF071D66"); BastaMAN.TextColor = Color.White;
            }
            else if (Constantce.Area == "Batn El - Ghool")
            {
                BatnElGhoolMAN.BackgroundColor = Color.FromHex("#FF071D66"); BatnElGhoolMAN.TextColor = Color.White;
            }
            else if (Constantce.Area == "Beir Abu Dnneh")
            {
                BeirAbuDnnehMAN.BackgroundColor = Color.FromHex("#FF071D66"); BeirAbuDnnehMAN.TextColor = Color.White;
            }
            else if (Constantce.Area == "Beir El - Bietar")
            {
                BeirElBietarMAN.BackgroundColor = Color.FromHex("#FF071D66"); BeirElBietarMAN.TextColor = Color.White;
            }
            else if (Constantce.Area == "Beir El - Dabbaghat")
            {
                BeirElDabbaghatMAN.BackgroundColor = Color.FromHex("#FF071D66"); BeirElDabbaghatMAN.TextColor = Color.White;
            }
            else if (Constantce.Area == "Beir Khadad")
            {
                BeirKhadadMAN.BackgroundColor = Color.FromHex("#FF071D66"); BeirKhadadMAN.TextColor = Color.White;
            }
            else if (Constantce.Area == "Dabit El - Karam")
            {
                DabitElKaramMAN.BackgroundColor = Color.FromHex("#FF071D66"); DabitElKaramMAN.TextColor = Color.White;
            }
            else if (Constantce.Area == "Dlaghah")
            {
                DlaghahMAN.BackgroundColor = Color.FromHex("#FF071D66"); DlaghahMAN.TextColor = Color.White;
            }
            else if (Constantce.Area == "Enaizeh")
            {
                EnaizehMAN.BackgroundColor = Color.FromHex("#FF071D66"); EnaizehMAN.TextColor = Color.White;
            }
            else if (Constantce.Area == "Etmaiyah")
            {
                EtmaiyahMAN.BackgroundColor = Color.FromHex("#FF071D66"); EtmaiyahMAN.TextColor = Color.White;
            }
            else if (Constantce.Area == "Faisaleah")
            {
                FaisaleahMAN.BackgroundColor = Color.FromHex("#FF071D66"); FaisaleahMAN.TextColor = Color.White;
            }
            else if (Constantce.Area == "Faisaleh Um - dhaibie'") { FaisalehUmdhaibieMAN.BackgroundColor = Color.FromHex("#FF071D66"); FaisalehUmdhaibieMAN.TextColor = Color.White; }
            else if (Constantce.Area == "Fardakh")
            {
                FardakhMAN.BackgroundColor = Color.FromHex("#FF071D66"); FardakhMAN.TextColor = Color.White;
            }
            else if (Constantce.Area == "Haddadah")
            {
                HaddadahMAN.BackgroundColor = Color.FromHex("#FF071D66"); HaddadahMAN.TextColor = Color.White;
            }
            else if (Constantce.Area == "Haiad")
            {
                HaiadMAN.BackgroundColor = Color.FromHex("#FF071D66"); HaiadMAN.TextColor = Color.White;
            }
            else if (Constantce.Area == "Hashemiyyeh")
            {
                HashemiyyehMAN.BackgroundColor = Color.FromHex("#FF071D66"); HashemiyyehMAN.TextColor = Color.White;
            }
            else if (Constantce.Area == "Hawaleh")
            {
                HawalehMAN.BackgroundColor = Color.FromHex("#FF071D66"); HawalehMAN.TextColor = Color.White;
            }
            else if (Constantce.Area == "Hayy")
            {
                HayyMAN.BackgroundColor = Color.FromHex("#FF071D66"); HayyMAN.TextColor = Color.White;
            }
            else if (Constantce.Area == "Huseiniya")
            {
                HuseiniyaMAN.BackgroundColor = Color.FromHex("#FF071D66"); HuseiniyaMAN.TextColor = Color.White;
            }
            else if (Constantce.Area == "Iel")
            {
                IelMAN.BackgroundColor = Color.FromHex("#FF071D66"); IelMAN.TextColor = Color.White;
            }
            else if (Constantce.Area == "Khirbat Um Ettelian")
            {
                KhirbatUmEttelianMAN.BackgroundColor = Color.FromHex("#FF071D66"); KhirbatUmEttelianMAN.TextColor = Color.White;
            }
            else if (Constantce.Area == "Ma'an") { MaanMAN.BackgroundColor = Color.FromHex("#FF071D66"); MaanMAN.TextColor = Color.White; }
            else if (Constantce.Area == "Mahatet Jerdaneh")
            {
                MahatetJerdanehMAN.BackgroundColor = Color.FromHex("#FF071D66"); MahatetJerdanehMAN.TextColor = Color.White;
            }
            else if (Constantce.Area == "Qurain")
            {
                QurainMAN.BackgroundColor = Color.FromHex("#FF071D66"); QurainMAN.TextColor = Color.White;
            }
            else if (Constantce.Area == "Raudet El - Amir Qa")
            {
                RaudetElAmirQaMAN.BackgroundColor = Color.FromHex("#FF071D66"); RaudetElAmirQaMAN.TextColor = Color.White;
            }
            else if (Constantce.Area == "Sateh Ma'an") { SatehMaanMAN.BackgroundColor = Color.FromHex("#FF071D66"); SatehMaanMAN.TextColor = Color.White; }
            else if (Constantce.Area == "Shammakh")
            {
                ShammakhMAN.BackgroundColor = Color.FromHex("#FF071D66"); ShammakhMAN.TextColor = Color.White;
            }
            else if (Constantce.Area == "Swaimreh")
            {
                SwaimrehMAN.BackgroundColor = Color.FromHex("#FF071D66"); SwaimrehMAN.TextColor = Color.White;
            }
            else if (Constantce.Area == "Tasan") { TasanMAN.BackgroundColor = Color.FromHex("#FF071D66"); TasanMAN.TextColor = Color.White; }
            else if (Constantce.Area == "Tharwah") { TharwahMAN.BackgroundColor = Color.FromHex("#FF071D66"); TharwahMAN.TextColor = Color.White; }
            else if (Constantce.Area == "Umm Sehoon") { UmmSehoonMAN.BackgroundColor = Color.FromHex("#FF071D66"); UmmSehoonMAN.TextColor = Color.White; }
            else if (Constantce.Area == "Wadi Moosa") { WadiMoosaMAN.BackgroundColor = Color.FromHex("#FF071D66"); WadiMoosaMAN.TextColor = Color.White; }

            MaanArea.IsVisible = true;
        }



        async void AbuElLissanMAN_Clicked(object sender, EventArgs e)
        {
            if (AbuElLissanMAN.BackgroundColor == Color.White)
            {
                Constantce.Area = "Abu El - Lissan"; Constantce.AreaLang = AbuElLissanMAN.Text; AbuElLissanMAN.TextColor = Color.White; AbuElLissanMAN.BackgroundColor = Color.FromHex("#FF071D66"); var existingPages = Navigation.NavigationStack.ToList(); await Navigation.PushAsync(new Home()); foreach (var page in existingPages) { Navigation.RemovePage(page); }
                await Task.Delay(80); await PopupNavigation.Instance.PopAsync();
            }
            else { Constantce.City = "City"; Constantce.Area = "Area"; AbuElLissanMAN.BackgroundColor = Color.White; AbuElLissanMAN.TextColor = Color.FromHex("#FF071D66"); }
        }
        async void AbuMakhtoobMAN_Clicked(object sender, EventArgs e)
        {
            if (AbuMakhtoobMAN.BackgroundColor == Color.White)
            {
                Constantce.Area = "Abu Makhtoob"; Constantce.AreaLang = AbuMakhtoobMAN.Text; AbuMakhtoobMAN.TextColor = Color.White; AbuMakhtoobMAN.BackgroundColor = Color.FromHex("#FF071D66"); var existingPages = Navigation.NavigationStack.ToList(); await Navigation.PushAsync(new Home()); foreach (var page in existingPages) { Navigation.RemovePage(page); }
                await Task.Delay(80); await PopupNavigation.Instance.PopAsync();
            }
            else { Constantce.City = "City"; Constantce.Area = "Area"; AbuMakhtoobMAN.BackgroundColor = Color.White; AbuMakhtoobMAN.TextColor = Color.FromHex("#FF071D66"); }
        }
        async void AinAmmoonMAN_Clicked(object sender, EventArgs e)
        {
            if (AinAmmoonMAN.BackgroundColor == Color.White)
            {
                Constantce.Area = "Ain Ammoon"; Constantce.AreaLang = AinAmmoonMAN.Text; AinAmmoonMAN.TextColor = Color.White; AinAmmoonMAN.BackgroundColor = Color.FromHex("#FF071D66"); var existingPages = Navigation.NavigationStack.ToList(); await Navigation.PushAsync(new Home()); foreach (var page in existingPages) { Navigation.RemovePage(page); }
                await Task.Delay(80); await PopupNavigation.Instance.PopAsync();
            }
            else { Constantce.City = "City"; Constantce.Area = "Area"; AinAmmoonMAN.BackgroundColor = Color.White; AinAmmoonMAN.TextColor = Color.FromHex("#FF071D66"); }
        }
        async void AlJafrMAN_Clicked(object sender, EventArgs e)
        {
            if (AlJafrMAN.BackgroundColor == Color.White)
            {
                Constantce.Area = "Al - Jafr"; Constantce.AreaLang = AlJafrMAN.Text; AlJafrMAN.TextColor = Color.White; AlJafrMAN.BackgroundColor = Color.FromHex("#FF071D66"); var existingPages = Navigation.NavigationStack.ToList(); await Navigation.PushAsync(new Home()); foreach (var page in existingPages) { Navigation.RemovePage(page); }
                await Task.Delay(80); await PopupNavigation.Instance.PopAsync();
            }
            else { Constantce.City = "City"; Constantce.Area = "Area"; AlJafrMAN.BackgroundColor = Color.White; AlJafrMAN.TextColor = Color.FromHex("#FF071D66"); }
        }
        async void AlJarbaKbierehMAN_Clicked(object sender, EventArgs e)
        {
            if (AlJarbaKbierehMAN.BackgroundColor == Color.White)
            {
                Constantce.Area = "Al - Jarba Kbiereh"; Constantce.AreaLang = AlJarbaKbierehMAN.Text; AlJarbaKbierehMAN.TextColor = Color.White; AlJarbaKbierehMAN.BackgroundColor = Color.FromHex("#FF071D66"); var existingPages = Navigation.NavigationStack.ToList(); await Navigation.PushAsync(new Home()); foreach (var page in existingPages) { Navigation.RemovePage(page); }
                await Task.Delay(80); await PopupNavigation.Instance.PopAsync();
            }
            else { Constantce.City = "City"; Constantce.Area = "Area"; AlJarbaKbierehMAN.BackgroundColor = Color.White; AlJarbaKbierehMAN.TextColor = Color.FromHex("#FF071D66"); }
        }
        async void AlJarbaSghierehMAN_Clicked(object sender, EventArgs e)
        {
            if (AlJarbaSghierehMAN.BackgroundColor == Color.White)
            {
                Constantce.Area = "Al - Jarba Sghiereh"; Constantce.AreaLang = AlJarbaSghierehMAN.Text; AlJarbaSghierehMAN.TextColor = Color.White; AlJarbaSghierehMAN.BackgroundColor = Color.FromHex("#FF071D66"); var existingPages = Navigation.NavigationStack.ToList(); await Navigation.PushAsync(new Home()); foreach (var page in existingPages) { Navigation.RemovePage(page); }
                await Task.Delay(80); await PopupNavigation.Instance.PopAsync();
            }
            else { Constantce.City = "City"; Constantce.Area = "Area"; AlJarbaSghierehMAN.BackgroundColor = Color.White; AlJarbaSghierehMAN.TextColor = Color.FromHex("#FF071D66"); }
        }
        async void AlJayyehMAN_Clicked(object sender, EventArgs e)
        {
            if (AlJayyehMAN.BackgroundColor == Color.White)
            {
                Constantce.Area = "Al - Jayyeh"; Constantce.AreaLang = AlJayyehMAN.Text; AlJayyehMAN.TextColor = Color.White; AlJayyehMAN.BackgroundColor = Color.FromHex("#FF071D66"); var existingPages = Navigation.NavigationStack.ToList(); await Navigation.PushAsync(new Home()); foreach (var page in existingPages) { Navigation.RemovePage(page); }
                await Task.Delay(80); await PopupNavigation.Instance.PopAsync();
            }
            else { Constantce.City = "City"; Constantce.Area = "Area"; AlJayyehMAN.BackgroundColor = Color.White; AlJayyehMAN.TextColor = Color.FromHex("#FF071D66"); }
        }
        async void AlJhairMAN_Clicked(object sender, EventArgs e)
        {
            if (AlJhairMAN.BackgroundColor == Color.White)
            {
                Constantce.Area = "Al - Jhair"; Constantce.AreaLang = AlJhairMAN.Text; AlJhairMAN.TextColor = Color.White; AlJhairMAN.BackgroundColor = Color.FromHex("#FF071D66"); var existingPages = Navigation.NavigationStack.ToList(); await Navigation.PushAsync(new Home()); foreach (var page in existingPages) { Navigation.RemovePage(page); }
                await Task.Delay(80); await PopupNavigation.Instance.PopAsync();
            }
            else { Constantce.City = "City"; Constantce.Area = "Area"; AlJhairMAN.BackgroundColor = Color.White; AlJhairMAN.TextColor = Color.FromHex("#FF071D66"); }
        }
        async void AlMadarejMAN_Clicked(object sender, EventArgs e)
        {
            if (AlMadarejMAN.BackgroundColor == Color.White)
            {
                Constantce.Area = "Al - Madarej"; Constantce.AreaLang = AlMadarejMAN.Text; AlMadarejMAN.TextColor = Color.White; AlMadarejMAN.BackgroundColor = Color.FromHex("#FF071D66"); var existingPages = Navigation.NavigationStack.ToList(); await Navigation.PushAsync(new Home()); foreach (var page in existingPages) { Navigation.RemovePage(page); }
                await Task.Delay(80); await PopupNavigation.Instance.PopAsync();
            }
            else { Constantce.City = "City"; Constantce.Area = "Area"; AlMadarejMAN.BackgroundColor = Color.White; AlMadarejMAN.TextColor = Color.FromHex("#FF071D66"); }
        }
        async void AlManshiyyehMAN_Clicked(object sender, EventArgs e)
        {
            if (AlManshiyyehMAN.BackgroundColor == Color.White)
            {
                Constantce.Area = "Al - Manshiyyeh"; Constantce.AreaLang = AlManshiyyehMAN.Text; AlManshiyyehMAN.TextColor = Color.White; AlManshiyyehMAN.BackgroundColor = Color.FromHex("#FF071D66"); var existingPages = Navigation.NavigationStack.ToList(); await Navigation.PushAsync(new Home()); foreach (var page in existingPages) { Navigation.RemovePage(page); }
                await Task.Delay(80); await PopupNavigation.Instance.PopAsync();
            }
            else { Constantce.City = "City"; Constantce.Area = "Area"; AlManshiyyehMAN.BackgroundColor = Color.White; AlManshiyyehMAN.TextColor = Color.FromHex("#FF071D66"); }
        }
        async void AlMansoorahMAN_Clicked(object sender, EventArgs e)
        {
            if (AlMansoorahMAN.BackgroundColor == Color.White)
            {
                Constantce.Area = "Al - Mansoorah"; Constantce.AreaLang = AlMansoorahMAN.Text; AlMansoorahMAN.TextColor = Color.White; AlMansoorahMAN.BackgroundColor = Color.FromHex("#FF071D66"); var existingPages = Navigation.NavigationStack.ToList(); await Navigation.PushAsync(new Home()); foreach (var page in existingPages) { Navigation.RemovePage(page); }
                await Task.Delay(80); await PopupNavigation.Instance.PopAsync();
            }
            else { Constantce.City = "City"; Constantce.Area = "Area"; AlMansoorahMAN.BackgroundColor = Color.White; AlMansoorahMAN.TextColor = Color.FromHex("#FF071D66"); }
        }
        async void AlMaqariyyehMAN_Clicked(object sender, EventArgs e)
        {
            if (AlMaqariyyehMAN.BackgroundColor == Color.White)
            {
                Constantce.Area = "Al - Maqari'yyeh"; Constantce.AreaLang = AlMaqariyyehMAN.Text; AlMaqariyyehMAN.TextColor = Color.White; AlMaqariyyehMAN.BackgroundColor = Color.FromHex("#FF071D66"); var existingPages = Navigation.NavigationStack.ToList(); await Navigation.PushAsync(new Home()); foreach (var page in existingPages) { Navigation.RemovePage(page); }
                await Task.Delay(80); await PopupNavigation.Instance.PopAsync();
            }
            else { Constantce.City = "City"; Constantce.Area = "Area"; AlMaqariyyehMAN.BackgroundColor = Color.White; AlMaqariyyehMAN.TextColor = Color.FromHex("#FF071D66"); }
        }
        async void AlModawwarahMAN_Clicked(object sender, EventArgs e)
        {
            if (AlModawwarahMAN.BackgroundColor == Color.White)
            {
                Constantce.Area = "Al - Modawwarah"; Constantce.AreaLang = AlModawwarahMAN.Text; AlModawwarahMAN.TextColor = Color.White; AlModawwarahMAN.BackgroundColor = Color.FromHex("#FF071D66"); var existingPages = Navigation.NavigationStack.ToList(); await Navigation.PushAsync(new Home()); foreach (var page in existingPages) { Navigation.RemovePage(page); }
                await Task.Delay(80); await PopupNavigation.Instance.PopAsync();
            }
            else { Constantce.City = "City"; Constantce.Area = "Area"; AlModawwarahMAN.BackgroundColor = Color.White; AlModawwarahMAN.TextColor = Color.FromHex("#FF071D66"); }
        }
        async void AlMohammadiyyehMAN_Clicked(object sender, EventArgs e)
        {
            if (AlMohammadiyyehMAN.BackgroundColor == Color.White)
            {
                Constantce.Area = "Al - Mohammadiyyeh"; Constantce.AreaLang = AlMohammadiyyehMAN.Text; AlMohammadiyyehMAN.TextColor = Color.White; AlMohammadiyyehMAN.BackgroundColor = Color.FromHex("#FF071D66"); var existingPages = Navigation.NavigationStack.ToList(); await Navigation.PushAsync(new Home()); foreach (var page in existingPages) { Navigation.RemovePage(page); }
                await Task.Delay(80); await PopupNavigation.Instance.PopAsync();
            }
            else { Constantce.City = "City"; Constantce.Area = "Area"; AlMohammadiyyehMAN.BackgroundColor = Color.White; AlMohammadiyyehMAN.TextColor = Color.FromHex("#FF071D66"); }
        }
        async void AlMothallathMAN_Clicked(object sender, EventArgs e)
        {
            if (AlMothallathMAN.BackgroundColor == Color.White)
            {
                Constantce.Area = "Al - Mothallath"; Constantce.AreaLang = AlMothallathMAN.Text; AlMothallathMAN.TextColor = Color.White; AlMothallathMAN.BackgroundColor = Color.FromHex("#FF071D66"); var existingPages = Navigation.NavigationStack.ToList(); await Navigation.PushAsync(new Home()); foreach (var page in existingPages) { Navigation.RemovePage(page); }
                await Task.Delay(80); await PopupNavigation.Instance.PopAsync();
            }
            else { Constantce.City = "City"; Constantce.Area = "Area"; AlMothallathMAN.BackgroundColor = Color.White; AlMothallathMAN.TextColor = Color.FromHex("#FF071D66"); }
        }
        async void AlMraighahMAN_Clicked(object sender, EventArgs e)
        {
            if (AlMraighahMAN.BackgroundColor == Color.White)
            {
                Constantce.Area = "Al - Mraighah"; Constantce.AreaLang = AlMraighahMAN.Text; AlMraighahMAN.TextColor = Color.White; AlMraighahMAN.BackgroundColor = Color.FromHex("#FF071D66"); var existingPages = Navigation.NavigationStack.ToList(); await Navigation.PushAsync(new Home()); foreach (var page in existingPages) { Navigation.RemovePage(page); }
                await Task.Delay(80); await PopupNavigation.Instance.PopAsync();
            }
            else { Constantce.City = "City"; Constantce.Area = "Area"; AlMraighahMAN.BackgroundColor = Color.White; AlMraighahMAN.TextColor = Color.FromHex("#FF071D66"); }
        }
        async void AlQasemeahMAN_Clicked(object sender, EventArgs e)
        {
            if (AlQasemeahMAN.BackgroundColor == Color.White)
            {
                Constantce.Area = "Al - Qasemeah"; Constantce.AreaLang = AlQasemeahMAN.Text; AlQasemeahMAN.TextColor = Color.White; AlQasemeahMAN.BackgroundColor = Color.FromHex("#FF071D66"); var existingPages = Navigation.NavigationStack.ToList(); await Navigation.PushAsync(new Home()); foreach (var page in existingPages) { Navigation.RemovePage(page); }
                await Task.Delay(80); await PopupNavigation.Instance.PopAsync();
            }
            else { Constantce.City = "City"; Constantce.Area = "Area"; AlQasemeahMAN.BackgroundColor = Color.White; AlQasemeahMAN.TextColor = Color.FromHex("#FF071D66"); }
        }
        async void AlTahoonehMAN_Clicked(object sender, EventArgs e)
        {
            if (AlTahoonehMAN.BackgroundColor == Color.White)
            {
                Constantce.Area = "Al - Tahooneh"; Constantce.AreaLang = AlTahoonehMAN.Text; AlTahoonehMAN.TextColor = Color.White; AlTahoonehMAN.BackgroundColor = Color.FromHex("#FF071D66"); var existingPages = Navigation.NavigationStack.ToList(); await Navigation.PushAsync(new Home()); foreach (var page in existingPages) { Navigation.RemovePage(page); }
                await Task.Delay(80); await PopupNavigation.Instance.PopAsync();
            }
            else { Constantce.City = "City"; Constantce.Area = "Area"; AlTahoonehMAN.BackgroundColor = Color.White; AlTahoonehMAN.TextColor = Color.FromHex("#FF071D66"); }
        }
        async void AlTaybahMAN_Clicked(object sender, EventArgs e)
        {
            if (AlTaybahMAN.BackgroundColor == Color.White)
            {
                Constantce.Area = "Al - Taybah"; Constantce.AreaLang = AlTaybahMAN.Text; AlTaybahMAN.TextColor = Color.White; AlTaybahMAN.BackgroundColor = Color.FromHex("#FF071D66"); var existingPages = Navigation.NavigationStack.ToList(); await Navigation.PushAsync(new Home()); foreach (var page in existingPages) { Navigation.RemovePage(page); }
                await Task.Delay(80); await PopupNavigation.Instance.PopAsync();
            }
            else { Constantce.City = "City"; Constantce.Area = "Area"; AlTaybahMAN.BackgroundColor = Color.White; AlTaybahMAN.TextColor = Color.FromHex("#FF071D66"); }
        }
        async void AlThugraMAN_Clicked(object sender, EventArgs e)
        {
            if (AlThugraMAN.BackgroundColor == Color.White)
            {
                Constantce.Area = "Al - Thugra"; Constantce.AreaLang = AlThugraMAN.Text; AlThugraMAN.TextColor = Color.White; AlThugraMAN.BackgroundColor = Color.FromHex("#FF071D66"); var existingPages = Navigation.NavigationStack.ToList(); await Navigation.PushAsync(new Home()); foreach (var page in existingPages) { Navigation.RemovePage(page); }
                await Task.Delay(80); await PopupNavigation.Instance.PopAsync();
            }
            else { Constantce.City = "City"; Constantce.Area = "Area"; AlThugraMAN.BackgroundColor = Color.White; AlThugraMAN.TextColor = Color.FromHex("#FF071D66"); }
        }
        async void AnNaqabElGharbiMAN_Clicked(object sender, EventArgs e)
        {
            if (AnNaqabElGharbiMAN.BackgroundColor == Color.White)
            {
                Constantce.Area = "An - Naqab El - Gharbi"; Constantce.AreaLang = AnNaqabElGharbiMAN.Text; AnNaqabElGharbiMAN.TextColor = Color.White; AnNaqabElGharbiMAN.BackgroundColor = Color.FromHex("#FF071D66"); var existingPages = Navigation.NavigationStack.ToList(); await Navigation.PushAsync(new Home()); foreach (var page in existingPages) { Navigation.RemovePage(page); }
                await Task.Delay(80); await PopupNavigation.Instance.PopAsync();
            }
            else { Constantce.City = "City"; Constantce.Area = "Area"; AnNaqabElGharbiMAN.BackgroundColor = Color.White; AnNaqabElGharbiMAN.TextColor = Color.FromHex("#FF071D66"); }
        }
        async void AnNaqabMAN_Clicked(object sender, EventArgs e)
        {
            if (AnNaqabMAN.BackgroundColor == Color.White)
            {
                Constantce.Area = "An - Naqab"; Constantce.AreaLang = AnNaqabMAN.Text; AnNaqabMAN.TextColor = Color.White; AnNaqabMAN.BackgroundColor = Color.FromHex("#FF071D66"); var existingPages = Navigation.NavigationStack.ToList(); await Navigation.PushAsync(new Home()); foreach (var page in existingPages) { Navigation.RemovePage(page); }
                await Task.Delay(80); await PopupNavigation.Instance.PopAsync();
            }
            else { Constantce.City = "City"; Constantce.Area = "Area"; AnNaqabMAN.BackgroundColor = Color.White; AnNaqabMAN.TextColor = Color.FromHex("#FF071D66"); }
        }
        async void ArRajefMAN_Clicked(object sender, EventArgs e)
        {
            if (ArRajefMAN.BackgroundColor == Color.White)
            {
                Constantce.Area = "Ar - Rajef"; Constantce.AreaLang = ArRajefMAN.Text; ArRajefMAN.TextColor = Color.White; ArRajefMAN.BackgroundColor = Color.FromHex("#FF071D66"); var existingPages = Navigation.NavigationStack.ToList(); await Navigation.PushAsync(new Home()); foreach (var page in existingPages) { Navigation.RemovePage(page); }
                await Task.Delay(80); await PopupNavigation.Instance.PopAsync();
            }
            else { Constantce.City = "City"; Constantce.Area = "Area"; ArRajefMAN.BackgroundColor = Color.White; ArRajefMAN.TextColor = Color.FromHex("#FF071D66"); }
        }
        async void ArRasseesMAN_Clicked(object sender, EventArgs e)
        {
            if (ArRasseesMAN.BackgroundColor == Color.White)
            {
                Constantce.Area = "Ar - Rassees"; Constantce.AreaLang = ArRasseesMAN.Text; ArRasseesMAN.TextColor = Color.White; ArRasseesMAN.BackgroundColor = Color.FromHex("#FF071D66"); var existingPages = Navigation.NavigationStack.ToList(); await Navigation.PushAsync(new Home()); foreach (var page in existingPages) { Navigation.RemovePage(page); }
                await Task.Delay(80); await PopupNavigation.Instance.PopAsync();
            }
            else { Constantce.City = "City"; Constantce.Area = "Area"; ArRasseesMAN.BackgroundColor = Color.White; ArRasseesMAN.TextColor = Color.FromHex("#FF071D66"); }
        }
        async void AshariMAN_Clicked(object sender, EventArgs e)
        {
            if (AshariMAN.BackgroundColor == Color.White)
            {
                Constantce.Area = "Ashari"; Constantce.AreaLang = AshariMAN.Text; AshariMAN.TextColor = Color.White; AshariMAN.BackgroundColor = Color.FromHex("#FF071D66"); var existingPages = Navigation.NavigationStack.ToList(); await Navigation.PushAsync(new Home()); foreach (var page in existingPages) { Navigation.RemovePage(page); }
                await Task.Delay(80); await PopupNavigation.Instance.PopAsync();
            }
            else { Constantce.City = "City"; Constantce.Area = "Area"; AshariMAN.BackgroundColor = Color.White; AshariMAN.TextColor = Color.FromHex("#FF071D66"); }
        }
        async void AshShadeiahMAN_Clicked(object sender, EventArgs e)
        {
            if (AshShadeiahMAN.BackgroundColor == Color.White)
            {
                Constantce.Area = "Ash - Shadeiah"; Constantce.AreaLang = AshShadeiahMAN.Text; AshShadeiahMAN.TextColor = Color.White; AshShadeiahMAN.BackgroundColor = Color.FromHex("#FF071D66"); var existingPages = Navigation.NavigationStack.ToList(); await Navigation.PushAsync(new Home()); foreach (var page in existingPages) { Navigation.RemovePage(page); }
                await Task.Delay(80); await PopupNavigation.Instance.PopAsync();
            }
            else { Constantce.City = "City"; Constantce.Area = "Area"; AshShadeiahMAN.BackgroundColor = Color.White; AshShadeiahMAN.TextColor = Color.FromHex("#FF071D66"); }
        }
        async void AshShobakMAN_Clicked(object sender, EventArgs e)
        {
            if (AshShobakMAN.BackgroundColor == Color.White)
            {
                Constantce.Area = "Ash - Shobak"; Constantce.AreaLang = AshShobakMAN.Text; AshShobakMAN.TextColor = Color.White; AshShobakMAN.BackgroundColor = Color.FromHex("#FF071D66"); var existingPages = Navigation.NavigationStack.ToList(); await Navigation.PushAsync(new Home()); foreach (var page in existingPages) { Navigation.RemovePage(page); }
                await Task.Delay(80); await PopupNavigation.Instance.PopAsync();
            }
            else { Constantce.City = "City"; Constantce.Area = "Area"; AshShobakMAN.BackgroundColor = Color.White; AshShobakMAN.TextColor = Color.FromHex("#FF071D66"); }
        }
        async void AsSadakahMAN_Clicked(object sender, EventArgs e)
        {
            if (AsSadakahMAN.BackgroundColor == Color.White)
            {
                Constantce.Area = "As - Sadakah"; Constantce.AreaLang = AsSadakahMAN.Text; AsSadakahMAN.TextColor = Color.White; AsSadakahMAN.BackgroundColor = Color.FromHex("#FF071D66"); var existingPages = Navigation.NavigationStack.ToList(); await Navigation.PushAsync(new Home()); foreach (var page in existingPages) { Navigation.RemovePage(page); }
                await Task.Delay(80); await PopupNavigation.Instance.PopAsync();
            }
            else { Constantce.City = "City"; Constantce.Area = "Area"; AsSadakahMAN.BackgroundColor = Color.White; AsSadakahMAN.TextColor = Color.FromHex("#FF071D66"); }
        }
        async void AthrohMAN_Clicked(object sender, EventArgs e)
        {
            if (AthrohMAN.BackgroundColor == Color.White)
            {
                Constantce.Area = "Athroh"; Constantce.AreaLang = AthrohMAN.Text; AthrohMAN.TextColor = Color.White; AthrohMAN.BackgroundColor = Color.FromHex("#FF071D66"); var existingPages = Navigation.NavigationStack.ToList(); await Navigation.PushAsync(new Home()); foreach (var page in existingPages) { Navigation.RemovePage(page); }
                await Task.Delay(80); await PopupNavigation.Instance.PopAsync();
            }
            else { Constantce.City = "City"; Constantce.Area = "Area"; AthrohMAN.BackgroundColor = Color.White; AthrohMAN.TextColor = Color.FromHex("#FF071D66"); }
        }
        async void AuhadahMAN_Clicked(object sender, EventArgs e)
        {
            if (AuhadahMAN.BackgroundColor == Color.White)
            {
                Constantce.Area = "Auhadah"; Constantce.AreaLang = AuhadahMAN.Text; AuhadahMAN.TextColor = Color.White; AuhadahMAN.BackgroundColor = Color.FromHex("#FF071D66"); var existingPages = Navigation.NavigationStack.ToList(); await Navigation.PushAsync(new Home()); foreach (var page in existingPages) { Navigation.RemovePage(page); }
                await Task.Delay(80); await PopupNavigation.Instance.PopAsync();
            }
            else { Constantce.City = "City"; Constantce.Area = "Area"; AuhadahMAN.BackgroundColor = Color.White; AuhadahMAN.TextColor = Color.FromHex("#FF071D66"); }
        }
        async void AzZaitonehMAN_Clicked(object sender, EventArgs e)
        {
            if (AzZaitonehMAN.BackgroundColor == Color.White)
            {
                Constantce.Area = "Az - Zaitoneh"; Constantce.AreaLang = AzZaitonehMAN.Text; AzZaitonehMAN.TextColor = Color.White; AzZaitonehMAN.BackgroundColor = Color.FromHex("#FF071D66"); var existingPages = Navigation.NavigationStack.ToList(); await Navigation.PushAsync(new Home()); foreach (var page in existingPages) { Navigation.RemovePage(page); }
                await Task.Delay(80); await PopupNavigation.Instance.PopAsync();
            }
            else { Constantce.City = "City"; Constantce.Area = "Area"; AzZaitonehMAN.BackgroundColor = Color.White; AzZaitonehMAN.TextColor = Color.FromHex("#FF071D66"); }
        }
        async void AzZobeiriyyehMAN_Clicked(object sender, EventArgs e)
        {
            if (AzZobeiriyyehMAN.BackgroundColor == Color.White)
            {
                Constantce.Area = "Az - Zobeiriyyeh"; Constantce.AreaLang = AzZobeiriyyehMAN.Text; AzZobeiriyyehMAN.TextColor = Color.White; AzZobeiriyyehMAN.BackgroundColor = Color.FromHex("#FF071D66"); var existingPages = Navigation.NavigationStack.ToList(); await Navigation.PushAsync(new Home()); foreach (var page in existingPages) { Navigation.RemovePage(page); }
                await Task.Delay(80); await PopupNavigation.Instance.PopAsync();
            }
            else { Constantce.City = "City"; Constantce.Area = "Area"; AzZobeiriyyehMAN.BackgroundColor = Color.White; AzZobeiriyyehMAN.TextColor = Color.FromHex("#FF071D66"); }
        }
        async void BaidaMAN_Clicked(object sender, EventArgs e)
        {
            if (BaidaMAN.BackgroundColor == Color.White)
            {
                Constantce.Area = "Baida"; Constantce.AreaLang = BaidaMAN.Text; BaidaMAN.TextColor = Color.White; BaidaMAN.BackgroundColor = Color.FromHex("#FF071D66"); var existingPages = Navigation.NavigationStack.ToList(); await Navigation.PushAsync(new Home()); foreach (var page in existingPages) { Navigation.RemovePage(page); }
                await Task.Delay(80); await PopupNavigation.Instance.PopAsync();
            }
            else { Constantce.City = "City"; Constantce.Area = "Area"; BaidaMAN.BackgroundColor = Color.White; BaidaMAN.TextColor = Color.FromHex("#FF071D66"); }
        }
        async void BairAbuElAlaqMAN_Clicked(object sender, EventArgs e)
        {
            if (BairAbuElAlaqMAN.BackgroundColor == Color.White)
            {
                Constantce.Area = "Bair Abu El-Alaq"; Constantce.AreaLang = BairAbuElAlaqMAN.Text; BairAbuElAlaqMAN.TextColor = Color.White; BairAbuElAlaqMAN.BackgroundColor = Color.FromHex("#FF071D66"); var existingPages = Navigation.NavigationStack.ToList(); await Navigation.PushAsync(new Home()); foreach (var page in existingPages) { Navigation.RemovePage(page); }
                await Task.Delay(80); await PopupNavigation.Instance.PopAsync();
            }
            else { Constantce.City = "City"; Constantce.Area = "Area"; BairAbuElAlaqMAN.BackgroundColor = Color.White; BairAbuElAlaqMAN.TextColor = Color.FromHex("#FF071D66"); }
        }
        async void BastaMAN_Clicked(object sender, EventArgs e)
        {
            if (BastaMAN.BackgroundColor == Color.White)
            {
                Constantce.Area = "Basta"; Constantce.AreaLang = BastaMAN.Text; BastaMAN.TextColor = Color.White; BastaMAN.BackgroundColor = Color.FromHex("#FF071D66"); var existingPages = Navigation.NavigationStack.ToList(); await Navigation.PushAsync(new Home()); foreach (var page in existingPages) { Navigation.RemovePage(page); }
                await Task.Delay(80); await PopupNavigation.Instance.PopAsync();
            }
            else { Constantce.City = "City"; Constantce.Area = "Area"; BastaMAN.BackgroundColor = Color.White; BastaMAN.TextColor = Color.FromHex("#FF071D66"); }
        }
        async void BatnElGhoolMAN_Clicked(object sender, EventArgs e)
        {
            if (BatnElGhoolMAN.BackgroundColor == Color.White)
            {
                Constantce.Area = "Batn El - Ghool"; Constantce.AreaLang = BatnElGhoolMAN.Text; BatnElGhoolMAN.TextColor = Color.White; BatnElGhoolMAN.BackgroundColor = Color.FromHex("#FF071D66"); var existingPages = Navigation.NavigationStack.ToList(); await Navigation.PushAsync(new Home()); foreach (var page in existingPages) { Navigation.RemovePage(page); }
                await Task.Delay(80); await PopupNavigation.Instance.PopAsync();
            }
            else { Constantce.City = "City"; Constantce.Area = "Area"; BatnElGhoolMAN.BackgroundColor = Color.White; BatnElGhoolMAN.TextColor = Color.FromHex("#FF071D66"); }
        }
        async void BeirAbuDnnehMAN_Clicked(object sender, EventArgs e)
        {
            if (BeirAbuDnnehMAN.BackgroundColor == Color.White)
            {
                Constantce.Area = "Beir Abu Dnneh"; Constantce.AreaLang = BeirAbuDnnehMAN.Text; BeirAbuDnnehMAN.TextColor = Color.White; BeirAbuDnnehMAN.BackgroundColor = Color.FromHex("#FF071D66"); var existingPages = Navigation.NavigationStack.ToList(); await Navigation.PushAsync(new Home()); foreach (var page in existingPages) { Navigation.RemovePage(page); }
                await Task.Delay(80); await PopupNavigation.Instance.PopAsync();
            }
            else { Constantce.City = "City"; Constantce.Area = "Area"; BeirAbuDnnehMAN.BackgroundColor = Color.White; BeirAbuDnnehMAN.TextColor = Color.FromHex("#FF071D66"); }
        }
        async void BeirElBietarMAN_Clicked(object sender, EventArgs e)
        {
            if (BeirElBietarMAN.BackgroundColor == Color.White)
            {
                Constantce.Area = "Beir El - Bietar"; Constantce.AreaLang = BeirElBietarMAN.Text; BeirElBietarMAN.TextColor = Color.White; BeirElBietarMAN.BackgroundColor = Color.FromHex("#FF071D66"); var existingPages = Navigation.NavigationStack.ToList(); await Navigation.PushAsync(new Home()); foreach (var page in existingPages) { Navigation.RemovePage(page); }
                await Task.Delay(80); await PopupNavigation.Instance.PopAsync();
            }
            else { Constantce.City = "City"; Constantce.Area = "Area"; BeirElBietarMAN.BackgroundColor = Color.White; BeirElBietarMAN.TextColor = Color.FromHex("#FF071D66"); }
        }
        async void BeirElDabbaghatMAN_Clicked(object sender, EventArgs e)
        {
            if (BeirElDabbaghatMAN.BackgroundColor == Color.White)
            {
                Constantce.Area = "Beir El - Dabbaghat"; Constantce.AreaLang = BeirElDabbaghatMAN.Text; BeirElDabbaghatMAN.TextColor = Color.White; BeirElDabbaghatMAN.BackgroundColor = Color.FromHex("#FF071D66"); var existingPages = Navigation.NavigationStack.ToList(); await Navigation.PushAsync(new Home()); foreach (var page in existingPages) { Navigation.RemovePage(page); }
                await Task.Delay(80); await PopupNavigation.Instance.PopAsync();
            }
            else { Constantce.City = "City"; Constantce.Area = "Area"; BeirElDabbaghatMAN.BackgroundColor = Color.White; BeirElDabbaghatMAN.TextColor = Color.FromHex("#FF071D66"); }
        }
        async void BeirKhadadMAN_Clicked(object sender, EventArgs e)
        {
            if (BeirKhadadMAN.BackgroundColor == Color.White)
            {
                Constantce.Area = "Beir Khadad"; Constantce.AreaLang = BeirKhadadMAN.Text; BeirKhadadMAN.TextColor = Color.White; BeirKhadadMAN.BackgroundColor = Color.FromHex("#FF071D66"); var existingPages = Navigation.NavigationStack.ToList(); await Navigation.PushAsync(new Home()); foreach (var page in existingPages) { Navigation.RemovePage(page); }
                await Task.Delay(80); await PopupNavigation.Instance.PopAsync();
            }
            else { Constantce.City = "City"; Constantce.Area = "Area"; BeirKhadadMAN.BackgroundColor = Color.White; BeirKhadadMAN.TextColor = Color.FromHex("#FF071D66"); }
        }
        async void DabitElKaramMAN_Clicked(object sender, EventArgs e)
        {
            if (DabitElKaramMAN.BackgroundColor == Color.White)
            {
                Constantce.Area = "Dabit El - Karam"; Constantce.AreaLang = DabitElKaramMAN.Text; DabitElKaramMAN.TextColor = Color.White; DabitElKaramMAN.BackgroundColor = Color.FromHex("#FF071D66"); var existingPages = Navigation.NavigationStack.ToList(); await Navigation.PushAsync(new Home()); foreach (var page in existingPages) { Navigation.RemovePage(page); }
                await Task.Delay(80); await PopupNavigation.Instance.PopAsync();
            }
            else { Constantce.City = "City"; Constantce.Area = "Area"; DabitElKaramMAN.BackgroundColor = Color.White; DabitElKaramMAN.TextColor = Color.FromHex("#FF071D66"); }
        }
        async void DlaghahMAN_Clicked(object sender, EventArgs e)
        {
            if (DlaghahMAN.BackgroundColor == Color.White)
            {
                Constantce.Area = "Dlaghah"; Constantce.AreaLang = DlaghahMAN.Text; DlaghahMAN.TextColor = Color.White; DlaghahMAN.BackgroundColor = Color.FromHex("#FF071D66"); var existingPages = Navigation.NavigationStack.ToList(); await Navigation.PushAsync(new Home()); foreach (var page in existingPages) { Navigation.RemovePage(page); }
                await Task.Delay(80); await PopupNavigation.Instance.PopAsync();
            }
            else { Constantce.City = "City"; Constantce.Area = "Area"; DlaghahMAN.BackgroundColor = Color.White; DlaghahMAN.TextColor = Color.FromHex("#FF071D66"); }
        }
        async void EnaizehMAN_Clicked(object sender, EventArgs e)
        {
            if (EnaizehMAN.BackgroundColor == Color.White)
            {
                Constantce.Area = "Enaizeh"; Constantce.AreaLang = EnaizehMAN.Text; EnaizehMAN.TextColor = Color.White; EnaizehMAN.BackgroundColor = Color.FromHex("#FF071D66"); var existingPages = Navigation.NavigationStack.ToList(); await Navigation.PushAsync(new Home()); foreach (var page in existingPages) { Navigation.RemovePage(page); }
                await Task.Delay(80); await PopupNavigation.Instance.PopAsync();
            }
            else { Constantce.City = "City"; Constantce.Area = "Area"; EnaizehMAN.BackgroundColor = Color.White; EnaizehMAN.TextColor = Color.FromHex("#FF071D66"); }
        }
        async void EtmaiyahMAN_Clicked(object sender, EventArgs e)
        {
            if (EtmaiyahMAN.BackgroundColor == Color.White)
            {
                Constantce.Area = "Etmaiyah"; Constantce.AreaLang = EtmaiyahMAN.Text; EtmaiyahMAN.TextColor = Color.White; EtmaiyahMAN.BackgroundColor = Color.FromHex("#FF071D66"); var existingPages = Navigation.NavigationStack.ToList(); await Navigation.PushAsync(new Home()); foreach (var page in existingPages) { Navigation.RemovePage(page); }
                await Task.Delay(80); await PopupNavigation.Instance.PopAsync();
            }
            else { Constantce.City = "City"; Constantce.Area = "Area"; EtmaiyahMAN.BackgroundColor = Color.White; EtmaiyahMAN.TextColor = Color.FromHex("#FF071D66"); }
        }
        async void FaisaleahMAN_Clicked(object sender, EventArgs e)
        {
            if (FaisaleahMAN.BackgroundColor == Color.White)
            {
                Constantce.Area = "Faisaleah"; Constantce.AreaLang = FaisaleahMAN.Text; FaisaleahMAN.TextColor = Color.White; FaisaleahMAN.BackgroundColor = Color.FromHex("#FF071D66"); var existingPages = Navigation.NavigationStack.ToList(); await Navigation.PushAsync(new Home()); foreach (var page in existingPages) { Navigation.RemovePage(page); }
                await Task.Delay(80); await PopupNavigation.Instance.PopAsync();
            }
            else { Constantce.City = "City"; Constantce.Area = "Area"; FaisaleahMAN.BackgroundColor = Color.White; FaisaleahMAN.TextColor = Color.FromHex("#FF071D66"); }
        }
        async void FaisalehUmdhaibieMAN_Clicked(object sender, EventArgs e)
        {
            if (FaisalehUmdhaibieMAN.BackgroundColor == Color.White)
            {
                Constantce.Area = "Faisaleh Um - dhaibie'"; Constantce.AreaLang = FaisalehUmdhaibieMAN.Text; FaisalehUmdhaibieMAN.TextColor = Color.White; FaisalehUmdhaibieMAN.BackgroundColor = Color.FromHex("#FF071D66"); var existingPages = Navigation.NavigationStack.ToList(); await Navigation.PushAsync(new Home()); foreach (var page in existingPages) { Navigation.RemovePage(page); }
                await Task.Delay(80); await PopupNavigation.Instance.PopAsync();
            }
            else { Constantce.City = "City"; Constantce.Area = "Area"; FaisalehUmdhaibieMAN.BackgroundColor = Color.White; FaisalehUmdhaibieMAN.TextColor = Color.FromHex("#FF071D66"); }
        }
        async void FardakhMAN_Clicked(object sender, EventArgs e)
        {
            if (FardakhMAN.BackgroundColor == Color.White)
            {
                Constantce.Area = "Fardakh"; Constantce.AreaLang = FardakhMAN.Text; FardakhMAN.TextColor = Color.White; FardakhMAN.BackgroundColor = Color.FromHex("#FF071D66"); var existingPages = Navigation.NavigationStack.ToList(); await Navigation.PushAsync(new Home()); foreach (var page in existingPages) { Navigation.RemovePage(page); }
                await Task.Delay(80); await PopupNavigation.Instance.PopAsync();
            }
            else { Constantce.City = "City"; Constantce.Area = "Area"; FardakhMAN.BackgroundColor = Color.White; FardakhMAN.TextColor = Color.FromHex("#FF071D66"); }
        }
        async void HaddadahMAN_Clicked(object sender, EventArgs e)
        {
            if (HaddadahMAN.BackgroundColor == Color.White)
            {
                Constantce.Area = "Haddadah"; Constantce.AreaLang = HaddadahMAN.Text; HaddadahMAN.TextColor = Color.White; HaddadahMAN.BackgroundColor = Color.FromHex("#FF071D66"); var existingPages = Navigation.NavigationStack.ToList(); await Navigation.PushAsync(new Home()); foreach (var page in existingPages) { Navigation.RemovePage(page); }
                await Task.Delay(80); await PopupNavigation.Instance.PopAsync();
            }
            else { Constantce.City = "City"; Constantce.Area = "Area"; HaddadahMAN.BackgroundColor = Color.White; HaddadahMAN.TextColor = Color.FromHex("#FF071D66"); }
        }
        async void HaiadMAN_Clicked(object sender, EventArgs e)
        {
            if (HaiadMAN.BackgroundColor == Color.White)
            {
                Constantce.Area = "Haiad"; Constantce.AreaLang = HaiadMAN.Text; HaiadMAN.TextColor = Color.White; HaiadMAN.BackgroundColor = Color.FromHex("#FF071D66"); var existingPages = Navigation.NavigationStack.ToList(); await Navigation.PushAsync(new Home()); foreach (var page in existingPages) { Navigation.RemovePage(page); }
                await Task.Delay(80); await PopupNavigation.Instance.PopAsync();
            }
            else { Constantce.City = "City"; Constantce.Area = "Area"; HaiadMAN.BackgroundColor = Color.White; HaiadMAN.TextColor = Color.FromHex("#FF071D66"); }
        }
        async void HashemiyyehMAN_Clicked(object sender, EventArgs e)
        {
            if (HashemiyyehMAN.BackgroundColor == Color.White)
            {
                Constantce.Area = "Hashemiyyeh"; Constantce.AreaLang = HashemiyyehMAN.Text; HashemiyyehMAN.TextColor = Color.White; HashemiyyehMAN.BackgroundColor = Color.FromHex("#FF071D66"); var existingPages = Navigation.NavigationStack.ToList(); await Navigation.PushAsync(new Home()); foreach (var page in existingPages) { Navigation.RemovePage(page); }
                await Task.Delay(80); await PopupNavigation.Instance.PopAsync();
            }
            else { Constantce.City = "City"; Constantce.Area = "Area"; HashemiyyehMAN.BackgroundColor = Color.White; HashemiyyehMAN.TextColor = Color.FromHex("#FF071D66"); }
        }
        async void HawalehMAN_Clicked(object sender, EventArgs e)
        {
            if (HawalehMAN.BackgroundColor == Color.White)
            {
                Constantce.Area = "Hawaleh"; Constantce.AreaLang = HawalehMAN.Text; HawalehMAN.TextColor = Color.White; HawalehMAN.BackgroundColor = Color.FromHex("#FF071D66"); var existingPages = Navigation.NavigationStack.ToList(); await Navigation.PushAsync(new Home()); foreach (var page in existingPages) { Navigation.RemovePage(page); }
                await Task.Delay(80); await PopupNavigation.Instance.PopAsync();
            }
            else { Constantce.City = "City"; Constantce.Area = "Area"; HawalehMAN.BackgroundColor = Color.White; HawalehMAN.TextColor = Color.FromHex("#FF071D66"); }
        }
        async void HayyMAN_Clicked(object sender, EventArgs e)
        {
            if (HayyMAN.BackgroundColor == Color.White)
            {
                Constantce.Area = "Hayy"; Constantce.AreaLang = HayyMAN.Text; HayyMAN.TextColor = Color.White; HayyMAN.BackgroundColor = Color.FromHex("#FF071D66"); var existingPages = Navigation.NavigationStack.ToList(); await Navigation.PushAsync(new Home()); foreach (var page in existingPages) { Navigation.RemovePage(page); }
                await Task.Delay(80); await PopupNavigation.Instance.PopAsync();
            }
            else { Constantce.City = "City"; Constantce.Area = "Area"; HayyMAN.BackgroundColor = Color.White; HayyMAN.TextColor = Color.FromHex("#FF071D66"); }
        }
        async void HuseiniyaMAN_Clicked(object sender, EventArgs e)
        {
            if (HuseiniyaMAN.BackgroundColor == Color.White)
            {
                Constantce.Area = "Huseiniya"; Constantce.AreaLang = HuseiniyaMAN.Text; HuseiniyaMAN.TextColor = Color.White; HuseiniyaMAN.BackgroundColor = Color.FromHex("#FF071D66"); var existingPages = Navigation.NavigationStack.ToList(); await Navigation.PushAsync(new Home()); foreach (var page in existingPages) { Navigation.RemovePage(page); }
                await Task.Delay(80); await PopupNavigation.Instance.PopAsync();
            }
            else { Constantce.City = "City"; Constantce.Area = "Area"; HuseiniyaMAN.BackgroundColor = Color.White; HuseiniyaMAN.TextColor = Color.FromHex("#FF071D66"); }
        }
        async void IelMAN_Clicked(object sender, EventArgs e)
        {
            if (IelMAN.BackgroundColor == Color.White)
            {
                Constantce.Area = "Iel"; Constantce.AreaLang = IelMAN.Text; IelMAN.TextColor = Color.White; IelMAN.BackgroundColor = Color.FromHex("#FF071D66"); var existingPages = Navigation.NavigationStack.ToList(); await Navigation.PushAsync(new Home()); foreach (var page in existingPages) { Navigation.RemovePage(page); }
                await Task.Delay(80); await PopupNavigation.Instance.PopAsync();
            }
            else { Constantce.City = "City"; Constantce.Area = "Area"; IelMAN.BackgroundColor = Color.White; IelMAN.TextColor = Color.FromHex("#FF071D66"); }
        }
        async void KhirbatUmEttelianMAN_Clicked(object sender, EventArgs e)
        {
            if (KhirbatUmEttelianMAN.BackgroundColor == Color.White)
            {
                Constantce.Area = "Khirbat Um Ettelian"; Constantce.AreaLang = KhirbatUmEttelianMAN.Text; KhirbatUmEttelianMAN.TextColor = Color.White; KhirbatUmEttelianMAN.BackgroundColor = Color.FromHex("#FF071D66"); var existingPages = Navigation.NavigationStack.ToList(); await Navigation.PushAsync(new Home()); foreach (var page in existingPages) { Navigation.RemovePage(page); }
                await Task.Delay(80); await PopupNavigation.Instance.PopAsync();
            }
            else { Constantce.City = "City"; Constantce.Area = "Area"; KhirbatUmEttelianMAN.BackgroundColor = Color.White; KhirbatUmEttelianMAN.TextColor = Color.FromHex("#FF071D66"); }
        }
        async void MaanMAN_Clicked(object sender, EventArgs e)
        {
            if (MaanMAN.BackgroundColor == Color.White)
            {
                Constantce.Area = "Ma'an"; Constantce.AreaLang = MaanMAN.Text; MaanMAN.TextColor = Color.White; MaanMAN.BackgroundColor = Color.FromHex("#FF071D66"); var existingPages = Navigation.NavigationStack.ToList(); await Navigation.PushAsync(new Home()); foreach (var page in existingPages) { Navigation.RemovePage(page); }
                await Task.Delay(80); await PopupNavigation.Instance.PopAsync();
            }
            else { Constantce.City = "City"; Constantce.Area = "Area"; MaanMAN.BackgroundColor = Color.White; MaanMAN.TextColor = Color.FromHex("#FF071D66"); }
        }
        async void MahatetJerdanehMAN_Clicked(object sender, EventArgs e)
        {
            if (MahatetJerdanehMAN.BackgroundColor == Color.White)
            {
                Constantce.Area = "Mahatet Jerdaneh"; Constantce.AreaLang = MahatetJerdanehMAN.Text; MahatetJerdanehMAN.TextColor = Color.White; MahatetJerdanehMAN.BackgroundColor = Color.FromHex("#FF071D66"); var existingPages = Navigation.NavigationStack.ToList(); await Navigation.PushAsync(new Home()); foreach (var page in existingPages) { Navigation.RemovePage(page); }
                await Task.Delay(80); await PopupNavigation.Instance.PopAsync();
            }
            else { Constantce.City = "City"; Constantce.Area = "Area"; MahatetJerdanehMAN.BackgroundColor = Color.White; MahatetJerdanehMAN.TextColor = Color.FromHex("#FF071D66"); }
        }
        async void QurainMAN_Clicked(object sender, EventArgs e)
        {
            if (QurainMAN.BackgroundColor == Color.White)
            {
                Constantce.Area = "Qurain"; Constantce.AreaLang = QurainMAN.Text; QurainMAN.TextColor = Color.White; QurainMAN.BackgroundColor = Color.FromHex("#FF071D66"); var existingPages = Navigation.NavigationStack.ToList(); await Navigation.PushAsync(new Home()); foreach (var page in existingPages) { Navigation.RemovePage(page); }
                await Task.Delay(80); await PopupNavigation.Instance.PopAsync();
            }
            else { Constantce.City = "City"; Constantce.Area = "Area"; QurainMAN.BackgroundColor = Color.White; QurainMAN.TextColor = Color.FromHex("#FF071D66"); }
        }
        async void RaudetElAmirQaMAN_Clicked(object sender, EventArgs e)
        {
            if (RaudetElAmirQaMAN.BackgroundColor == Color.White)
            {
                Constantce.Area = "Raudet El - Amir Qa"; Constantce.AreaLang = RaudetElAmirQaMAN.Text; RaudetElAmirQaMAN.TextColor = Color.White; RaudetElAmirQaMAN.BackgroundColor = Color.FromHex("#FF071D66"); var existingPages = Navigation.NavigationStack.ToList(); await Navigation.PushAsync(new Home()); foreach (var page in existingPages) { Navigation.RemovePage(page); }
                await Task.Delay(80); await PopupNavigation.Instance.PopAsync();
            }
            else { Constantce.City = "City"; Constantce.Area = "Area"; RaudetElAmirQaMAN.BackgroundColor = Color.White; RaudetElAmirQaMAN.TextColor = Color.FromHex("#FF071D66"); }
        }
        async void SatehMaanMAN_Clicked(object sender, EventArgs e)
        {
            if (SatehMaanMAN.BackgroundColor == Color.White)
            {
                Constantce.Area = "Sateh Ma'an"; Constantce.AreaLang = SatehMaanMAN.Text; SatehMaanMAN.TextColor = Color.White; SatehMaanMAN.BackgroundColor = Color.FromHex("#FF071D66"); var existingPages = Navigation.NavigationStack.ToList(); await Navigation.PushAsync(new Home()); foreach (var page in existingPages) { Navigation.RemovePage(page); }
                await Task.Delay(80); await PopupNavigation.Instance.PopAsync();
            }
            else { Constantce.City = "City"; Constantce.Area = "Area"; SatehMaanMAN.BackgroundColor = Color.White; SatehMaanMAN.TextColor = Color.FromHex("#FF071D66"); }
        }
        async void ShammakhMAN_Clicked(object sender, EventArgs e)
        {
            if (ShammakhMAN.BackgroundColor == Color.White)
            {
                Constantce.Area = "Shammakh"; Constantce.AreaLang = ShammakhMAN.Text; ShammakhMAN.TextColor = Color.White; ShammakhMAN.BackgroundColor = Color.FromHex("#FF071D66"); var existingPages = Navigation.NavigationStack.ToList(); await Navigation.PushAsync(new Home()); foreach (var page in existingPages) { Navigation.RemovePage(page); }
                await Task.Delay(80); await PopupNavigation.Instance.PopAsync();
            }
            else { Constantce.City = "City"; Constantce.Area = "Area"; ShammakhMAN.BackgroundColor = Color.White; ShammakhMAN.TextColor = Color.FromHex("#FF071D66"); }
        }
        async void SwaimrehMAN_Clicked(object sender, EventArgs e)
        {
            if (SwaimrehMAN.BackgroundColor == Color.White)
            {
                Constantce.Area = "Swaimreh"; Constantce.AreaLang = SwaimrehMAN.Text; SwaimrehMAN.TextColor = Color.White; SwaimrehMAN.BackgroundColor = Color.FromHex("#FF071D66"); var existingPages = Navigation.NavigationStack.ToList(); await Navigation.PushAsync(new Home()); foreach (var page in existingPages) { Navigation.RemovePage(page); }
                await Task.Delay(80); await PopupNavigation.Instance.PopAsync();
            }
            else { Constantce.City = "City"; Constantce.Area = "Area"; SwaimrehMAN.BackgroundColor = Color.White; SwaimrehMAN.TextColor = Color.FromHex("#FF071D66"); }
        }
        async void TasanMAN_Clicked(object sender, EventArgs e)
        {
            if (TasanMAN.BackgroundColor == Color.White)
            {
                Constantce.Area = "Tasan"; Constantce.AreaLang = TasanMAN.Text; TasanMAN.TextColor = Color.White; TasanMAN.BackgroundColor = Color.FromHex("#FF071D66"); var existingPages = Navigation.NavigationStack.ToList(); await Navigation.PushAsync(new Home()); foreach (var page in existingPages) { Navigation.RemovePage(page); }
                await Task.Delay(80); await PopupNavigation.Instance.PopAsync();
            }
            else { Constantce.City = "City"; Constantce.Area = "Area"; TasanMAN.BackgroundColor = Color.White; TasanMAN.TextColor = Color.FromHex("#FF071D66"); }
        }
        async void TharwahMAN_Clicked(object sender, EventArgs e)
        {
            if (TharwahMAN.BackgroundColor == Color.White)
            {
                Constantce.Area = "Tharwah"; Constantce.AreaLang = TharwahMAN.Text; TharwahMAN.TextColor = Color.White; TharwahMAN.BackgroundColor = Color.FromHex("#FF071D66"); var existingPages = Navigation.NavigationStack.ToList(); await Navigation.PushAsync(new Home()); foreach (var page in existingPages) { Navigation.RemovePage(page); }
                await Task.Delay(80); await PopupNavigation.Instance.PopAsync();
            }
            else { Constantce.City = "City"; Constantce.Area = "Area"; TharwahMAN.BackgroundColor = Color.White; TharwahMAN.TextColor = Color.FromHex("#FF071D66"); }
        }
        async void UmmSehoonMAN_Clicked(object sender, EventArgs e)
        {
            if (UmmSehoonMAN.BackgroundColor == Color.White)
            {
                Constantce.Area = "Umm Sehoon"; Constantce.AreaLang = UmmSehoonMAN.Text; UmmSehoonMAN.TextColor = Color.White; UmmSehoonMAN.BackgroundColor = Color.FromHex("#FF071D66"); var existingPages = Navigation.NavigationStack.ToList(); await Navigation.PushAsync(new Home()); foreach (var page in existingPages) { Navigation.RemovePage(page); }
                await Task.Delay(80); await PopupNavigation.Instance.PopAsync();
            }
            else { Constantce.City = "City"; Constantce.Area = "Area"; UmmSehoonMAN.BackgroundColor = Color.White; UmmSehoonMAN.TextColor = Color.FromHex("#FF071D66"); }
        }
        async void WadiMoosaMAN_Clicked(object sender, EventArgs e)
        {
            if (WadiMoosaMAN.BackgroundColor == Color.White)
            {
                Constantce.Area = "Wadi Moosa"; Constantce.AreaLang = WadiMoosaMAN.Text; WadiMoosaMAN.TextColor = Color.White; WadiMoosaMAN.BackgroundColor = Color.FromHex("#FF071D66"); var existingPages = Navigation.NavigationStack.ToList(); await Navigation.PushAsync(new Home()); foreach (var page in existingPages) { Navigation.RemovePage(page); }
                await Task.Delay(80); await PopupNavigation.Instance.PopAsync();
            }
            else { Constantce.City = "City"; Constantce.Area = "Area"; WadiMoosaMAN.BackgroundColor = Color.White; WadiMoosaMAN.TextColor = Color.FromHex("#FF071D66"); }
        }


        //******************************End maan Areas**********************************************************************

    }
}