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
    public partial class Amman : PopupPage
    {
        public Amman()
        {

            InitializeComponent();
            if (Application.Current.Properties["Language"].ToString() == "Arabic")
            {
                this.FlowDirection = FlowDirection.RightToLeft;
                UpText.Text = "الرجاء اختيار المنطقة";

                AbuEssoos.Text = "ابو السوس";
                AbuHlaileefah.Text = "ابو حليليفة";
                AbuNaqlah.Text = "ابو نقلة";
                Adbayan.Text = "ادبيان";
                Damki.Text = "الدامخي";
                Dair.Text = "الدير";
                Dabbeh.Text = "الدبة";
                DhaibehGharbiyyeh.Text = "الذهيبة الغربية";
                DhaibehSharqiyyeh.Text = "الذهيبه الشرقيه";
                Tharah.Text = "الذرة";
                Adasiyyeh.Text = "العدسية";
                Ajajreh.Text = "العجاجرة";
                ElAal.Text = "العال";
                Almaniyyeh.Text = "الالمانية";
                Amireah.Text = "العامرية";
                Ewailiyyeh.Text = "العويلية";
                Bahath.Text = "البحاث";
                Bassa.Text = "البصة";
                Buhairat.Text = "البحيرات";
                Fahs.Text = "الفحص";
                Rabyyeh.Text = "الفالج; الرابية";
                Hamdeih.Text = "الحامدية";
                Hashimeyyah.Text = "الهاشمية";
                Hatmeia.Text = "الحاتمية";
                Hunaifiyyeh.Text = "الحنيفية";
                Jizeh.Text = "الجيزة";
                Jubeiha.Text = "الجبيهة";
                Jnab.Text = "الجناب";
                Kaldeh.Text = "الخالدية";
                Khrayyem.Text = "الخريم";
                Ktafeh.Text = "الكتيفه";
                Laseen.Text = "اللسين";
                Majedeah.Text = "الماجدية";
                AlManshiyah.Text = "المنشية";
                Mansoorah.Text = "المنصورة";
                Mastabah.Text = "المصطبه";
                Msaitbah.Text = "المصيطبة";
                Mushakar.Text = "المشقر";
                Mshairfah.Text = "المشيرفة";
                Mowaqqar.Text = "الموقر";
                Quwaysimah.Text = "القويسمة";
                Yahoon.Text = "الياهون";
                JabalAmman.Text = "عمان";
                Naqera.Text = "النقيرة";
                Nair.Text = "النعير";
                Rajaha.Text = "الرجاحة";
                AlRama.Text = "الرامة";
                Ramil.Text = "الرميل";
                Rawdhah.Text = "الروضة";
                AskanAbuNushayr.Text = "اسكان أبو نصير";
                Samek.Text = "السامك";
                Thograh.Text = "الثغرة";
                Thrayya.Text = "الثريا";
                Tabaqa.Text = "الطبقة";
                Zmaileh.Text = "الزميله";
                Zmailat.Text = "الزميلات";
                BadrJadeda.Text = "بدر الجديدة";
                Balas.Text = "بلعاس";
                BassetNaoor.Text = "بصة ناعور";
                Dabah.Text = "ضبعه";
                Ghazaleh.Text = "غزالة";
                HammamElShmoot.Text = "حمام الشموط";
                HammamElTallaq.Text = "حمام الطلاق";
                Hesban.Text = "حسبان";
                EraqElamir.Text = "عراق الامير";
                Jomail.Text = "جميل";
                KarmetHesban.Text = "كرمة حسبان";
                KanElZabib.Text = "خان الزبيب";
                KhraibetEssooq.Text = "خربیه السوق-جاوا-اليادودة";
                MagaierMohanna.Text = "مغاير مهنا";
                ManshiyyetHesban.Text = "منشية حسبان";
                MarjalHamam.Text = "مرج الحمام";
                Masooh.Text = "ماسوح";
                Naour.Text = "ناعور";
                RaudetHussenNamuthajeh.Text = "روضة الحسين النموذجية";
                RojomEqab.Text = "رجم عقاب";
                RojomShamiGharbi.Text = "رجم الشامي الغربي";
                RojomShamiSharqi.Text = "رجم الشامي الشرقي";
                RojomFhaid.Text = "رجم فهيد";
                Sahab.Text = "سحاب";
                SailHesban.Text = "سيل حسبان";
                Salem.Text = "سالم";
                Salyeh.Text = "سالية";
                ShafaBadran.Text = "شفا بدران";
                Sweileh.Text = "صويلح";
                Khilda.Text = "تلاع العلي-خلدا-ام السماق";
                ToarHashash.Text = "طور الحشاش";
                Torky.Text = "تركي";
                Elayyan.Text = "عليان";
                UmmElAsaker.Text = "ام العساكر";
                UmElBerak.Text = "ام البرك";
                UmmElBasatien.Text = "ام البساتين";
                UmElKindam.Text = "أم الكندم";
                UmmRsas.Text = "ام الرصاص";
                UmmEssommaq.Text = "ام السماق";
                UmmBotmah.Text = "ام بطمة";
                UmmNjasa.Text = "ام نجاصة";
                Muqabalayn.Text = "ام قصير-المقابلين";
                WadiEshta.Text = "وادي الشتاء";
                WadiEssier.Text = "وادي السير";
                Zbood.Text = "زبود";

            }
            else
            {
                this.FlowDirection = FlowDirection.LeftToRight;
                UpText.Text = "Please Select Area";

                AbuEssoos.Text = "Abu Essoos";
                AbuHlaileefah.Text = "Abu Hlaileefah";
                AbuNaqlah.Text = "Abu Naqlah";
                Adbayan.Text = "Adbayan";
                Damki.Text = "Damki";
                Dair.Text = "Dair";
                Dabbeh.Text = "Dabbeh";
                DhaibehGharbiyyeh.Text = "Dhaibeh Gharbiyyeh";
                DhaibehSharqiyyeh.Text = "Dhaibeh Sharqiyyeh";
                Tharah.Text = "Tharah";
                Adasiyyeh.Text = "Adasiyyeh";
                Ajajreh.Text = "Ajajreh";
                ElAal.Text = "El-A'al";
                Almaniyyeh.Text = "Almaniyyeh";
                Amireah.Text = "Amireah";
                Ewailiyyeh.Text = "Ewailiyyeh";
                Bahath.Text = "Bahath";
                Bassa.Text = "Bassa";
                Buhairat.Text = "Buhairat";
                Fahs.Text = "Fahs";
                Rabyyeh.Text = "Rabyyeh";
                Hamdeih.Text = "Hamdeih";
                Hashimeyyah.Text = "Hashimeyyah";
                Hatmeia.Text = "Hatmeia";
                Hunaifiyyeh.Text = "Hunaifiyyeh";
                Jizeh.Text = "Jizeh";
                Jubeiha.Text = "Jubeiha";
                Jnab.Text = "Jnab";
                Kaldeh.Text = "Kaldeh";
                Khrayyem.Text = "Khrayyem";
                Ktafeh.Text = "Ktafeh";
                Laseen.Text = "Laseen";
                Majedeah.Text = "Majedeah, Zabarah";
                AlManshiyah.Text = "Al-Manshiyah";
                AlManshiyah.Text = "Al-Manshiyah";
                Mansoorah.Text = "Mansoorah";
                Mastabah.Text = "Mastabah";
                Msaitbah.Text = "Msaitbah";
                Mushakar.Text = "Mushakar";
                Mshairfah.Text = "Mshairfah";
                Mowaqqar.Text = "Mowaqqar";
                Quwaysimah.Text = "Quwaysimah";
                Yahoon.Text = "Yahoon";
                JabalAmman.Text = "Amman";
                Naqera.Text = "Naqera";
                Nair.Text = "N'air";
                Rajaha.Text = "Rajaha";
                AlRama.Text = "Al Rama";
                Ramil.Text = "Ramil";
                Rawdhah.Text = "Rawdhah";
                AskanAbuNushayr.Text = "Askan Abu Nushayr";
                Samek.Text = "Samek";
                Thograh.Text = "Thograh";
                Thrayya.Text = "Thrayya";
                Tabaqa.Text = "Tabaqa";
                Zmaileh.Text = "Zmaileh";
                Zmailat.Text = "Zmailat";
                BadrJadeda.Text = "Badr Jadeda";
                Balas.Text = "Bal'as";
                BassetNaoor.Text = "Basset Na'oor";
                Dabah.Text = "Dab'ah";
                Ghazaleh.Text = "Ghazaleh";
                HammamElShmoot.Text = "Hammam El-Shmoot";
                HammamElTallaq.Text = "Hammam El-Tallaq";
                Hesban.Text = "Hesban";
                EraqElamir.Text = "Eraq Elamir";
                Jomail.Text = "Jomail";
                KarmetHesban.Text = "Karmet Hesban";
                KanElZabib.Text = "Kan El-Zabib";
                KhraibetEssooq.Text = "Khraibet";
                MagaierMohanna.Text = "Magaier Mohanna";
                ManshiyyetHesban.Text = "Manshiyyet Hesban";
                MarjalHamam.Text = "Marj al-Hamam";
                Masooh.Text = "Masooh";
                Naour.Text = "Naour";
                RaudetHussenNamuthajeh.Text = "Raudet Hussen Namuthajeh";
                RojomEqab.Text = "Rojom Eqab";
                RojomShamiGharbi.Text = "Rojom Shami Gharbi";
                RojomShamiSharqi.Text = "Rojom Shami Sharqi";
                RojomFhaid.Text = "Rojom Fhaid";
                Sahab.Text = "Sahab";
                SailHesban.Text = "Sail Hesban";
                Salem.Text = "Salem";
                Salyeh.Text = "Salyeh";
                ShafaBadran.Text = "Shafa Badran";
                Sweileh.Text = "Sweileh";
                Khilda.Text = "Khilda-Umm Essommaq";
                ToarHashash.Text = "Toar Hashash";
                Torky.Text = "Torky";
                Elayyan.Text = "Elayyan";
                UmmElAsaker.Text = "Umm El-Asaker";
                UmElBerak.Text = "Um El-Berak";
                UmmElBasatien.Text = "Umm El-Basatien";
                UmElKindam.Text = "Um El-Kindam";
                UmmRsas.Text = "Umm Rsas";
                UmmEssommaq.Text = "Umm Essommaq";
                UmmBotmah.Text = "Umm Botmah";
                UmmNjasa.Text = "Umm Njasa";
                Muqabalayn.Text = "Muqabalayn";
                WadiEshta.Text = "Wadi Eshta";
                WadiEssier.Text = "Wadi Essier";
                Zbood.Text = "Zbood";

            }
            if (Constantce.Area == "Abu Essoos") { AbuEssoos.BackgroundColor = Color.FromHex("#FF071D66"); AbuEssoos.TextColor = Color.White; }
            else if (Constantce.Area == "Abu Hlaileefah") { AbuHlaileefah.BackgroundColor = Color.FromHex("#FF071D66"); AbuHlaileefah.TextColor = Color.White; }
            else if (Constantce.Area == "Abu Naqlah") { AbuNaqlah.BackgroundColor = Color.FromHex("#FF071D66"); AbuNaqlah.TextColor = Color.White; }
            else if (Constantce.Area == "Adasiyyeh") { Adasiyyeh.BackgroundColor = Color.FromHex("#FF071D66"); Adasiyyeh.TextColor = Color.White; }
            else if (Constantce.Area == "Adbayan") { Adbayan.BackgroundColor = Color.FromHex("#FF071D66"); Adbayan.TextColor = Color.White; }
            else if (Constantce.Area == "Ajajreh") { Ajajreh.BackgroundColor = Color.FromHex("#FF071D66"); Ajajreh.TextColor = Color.White; }
            else if (Constantce.Area == "Al Rama") { AlRama.BackgroundColor = Color.FromHex("#FF071D66"); AlRama.TextColor = Color.White; }
            else if (Constantce.Area == "Almaniyyeh") { Almaniyyeh.BackgroundColor = Color.FromHex("#FF071D66"); Almaniyyeh.TextColor = Color.White; }
            else if (Constantce.Area == "Al - Manshiyah") { AlManshiyah.BackgroundColor = Color.FromHex("#FF071D66"); AlManshiyah.TextColor = Color.White; }
            else if (Constantce.Area == "Amireah") { Amireah.BackgroundColor = Color.FromHex("#FF071D66"); Amireah.TextColor = Color.White; }
            else if (Constantce.Area == "Amman") { JabalAmman.BackgroundColor = Color.FromHex("#FF071D66"); JabalAmman.TextColor = Color.White; }
            else if (Constantce.Area == "Askan Abu Nushayr") { AskanAbuNushayr.BackgroundColor = Color.FromHex("#FF071D66"); AskanAbuNushayr.TextColor = Color.White; }
            else if (Constantce.Area == "Badr Jadeda") { BadrJadeda.BackgroundColor = Color.FromHex("#FF071D66"); BadrJadeda.TextColor = Color.White; }
            else if (Constantce.Area == "Bahath") { Bahath.BackgroundColor = Color.FromHex("#FF071D66"); Bahath.TextColor = Color.White; }
            else if (Constantce.Area == "Bal'as") { Balas.BackgroundColor = Color.FromHex("#FF071D66"); Balas.TextColor = Color.White; }
            else if (Constantce.Area == "Bassa") { Bassa.BackgroundColor = Color.FromHex("#FF071D66"); Bassa.TextColor = Color.White; }
            else if (Constantce.Area == "Basset Na'oor") { BassetNaoor.BackgroundColor = Color.FromHex("#FF071D66"); BassetNaoor.TextColor = Color.White; }
            else if (Constantce.Area == "Buhairat, Mansheat Elsuareah") { Buhairat.BackgroundColor = Color.FromHex("#FF071D66"); Buhairat.TextColor = Color.White; }
            else if (Constantce.Area == "Dab'ah") { Dabah.BackgroundColor = Color.FromHex("#FF071D66"); Dabah.TextColor = Color.White; }
            else if (Constantce.Area == "Dabbeh") { Dabbeh.BackgroundColor = Color.FromHex("#FF071D66"); Dabbeh.TextColor = Color.White; }
            else if (Constantce.Area == "Dair") { Dair.BackgroundColor = Color.FromHex("#FF071D66"); Dair.TextColor = Color.White; }
            else if (Constantce.Area == "Damki") { Damki.BackgroundColor = Color.FromHex("#FF071D66"); Damki.TextColor = Color.White; }
            else if (Constantce.Area == "Dhaibeh Gharbiyyeh") { DhaibehGharbiyyeh.BackgroundColor = Color.FromHex("#FF071D66"); DhaibehGharbiyyeh.TextColor = Color.White; }
            else if (Constantce.Area == "Dhaibeh Sharqiyyeh") { DhaibehSharqiyyeh.BackgroundColor = Color.FromHex("#FF071D66"); DhaibehSharqiyyeh.TextColor = Color.White; }
            else if (Constantce.Area == "El - A'al") { ElAal.BackgroundColor = Color.FromHex("#FF071D66"); ElAal.TextColor = Color.White; }
            else if (Constantce.Area == "Elayyan") { Elayyan.BackgroundColor = Color.FromHex("#FF071D66"); Elayyan.TextColor = Color.White; }
            else if (Constantce.Area == "Eraq Elamir") { EraqElamir.BackgroundColor = Color.FromHex("#FF071D66"); EraqElamir.TextColor = Color.White; }
            else if (Constantce.Area == "Ewailiyyeh") { Ewailiyyeh.BackgroundColor = Color.FromHex("#FF071D66"); Ewailiyyeh.TextColor = Color.White; }
            else if (Constantce.Area == "Fahs") { Fahs.BackgroundColor = Color.FromHex("#FF071D66"); Fahs.TextColor = Color.White; }
            else if (Constantce.Area == "Ghazaleh") { Ghazaleh.BackgroundColor = Color.FromHex("#FF071D66"); Ghazaleh.TextColor = Color.White; }
            else if (Constantce.Area == "Hamdeih") { Hamdeih.BackgroundColor = Color.FromHex("#FF071D66"); Hamdeih.TextColor = Color.White; }
            else if (Constantce.Area == "Hammam El - Shmoot") { HammamElShmoot.BackgroundColor = Color.FromHex("#FF071D66"); HammamElShmoot.TextColor = Color.White; }
            else if (Constantce.Area == "Hammam El - Tallaq") { HammamElTallaq.BackgroundColor = Color.FromHex("#FF071D66"); HammamElTallaq.TextColor = Color.White; }
            else if (Constantce.Area == "Hashimeyyah") { Hashimeyyah.BackgroundColor = Color.FromHex("#FF071D66"); Hashimeyyah.TextColor = Color.White; }
            else if (Constantce.Area == "Hatmeia") { Hatmeia.BackgroundColor = Color.FromHex("#FF071D66"); Hatmeia.TextColor = Color.White; }
            else if (Constantce.Area == "Hesban") { Hesban.BackgroundColor = Color.FromHex("#FF071D66"); Hesban.TextColor = Color.White; }
            else if (Constantce.Area == "Hunaifiyyeh") { Hunaifiyyeh.BackgroundColor = Color.FromHex("#FF071D66"); Hunaifiyyeh.TextColor = Color.White; }
            else if (Constantce.Area == "Jizeh") { Jizeh.BackgroundColor = Color.FromHex("#FF071D66"); Jizeh.TextColor = Color.White; }
            else if (Constantce.Area == "Jnab") { Jnab.BackgroundColor = Color.FromHex("#FF071D66"); Jnab.TextColor = Color.White; }
            else if (Constantce.Area == "Jomail") { Jomail.BackgroundColor = Color.FromHex("#FF071D66"); Jomail.TextColor = Color.White; }
            else if (Constantce.Area == "Jubeiha") { Jubeiha.BackgroundColor = Color.FromHex("#FF071D66"); Jubeiha.TextColor = Color.White; }
            else if (Constantce.Area == "Kaldeh") { Kaldeh.BackgroundColor = Color.FromHex("#FF071D66"); Kaldeh.TextColor = Color.White; }
            else if (Constantce.Area == "Kan El - Zabib") { KanElZabib.BackgroundColor = Color.FromHex("#FF071D66"); KanElZabib.TextColor = Color.White; }
            else if (Constantce.Area == "Karmet Hesban") { KarmetHesban.BackgroundColor = Color.FromHex("#FF071D66"); KarmetHesban.TextColor = Color.White; }
            else if (Constantce.Area == "Khilda") { Khilda.BackgroundColor = Color.FromHex("#FF071D66"); Khilda.TextColor = Color.White; }
            else if (Constantce.Area == "Khraibet Essooq") { KhraibetEssooq.BackgroundColor = Color.FromHex("#FF071D66"); KhraibetEssooq.TextColor = Color.White; }
            else if (Constantce.Area == "Khrayyem") { Khrayyem.BackgroundColor = Color.FromHex("#FF071D66"); Khrayyem.TextColor = Color.White; }
            else if (Constantce.Area == "Ktafeh") { Ktafeh.BackgroundColor = Color.FromHex("#FF071D66"); Ktafeh.TextColor = Color.White; }
            else if (Constantce.Area == "Laseen") { Laseen.BackgroundColor = Color.FromHex("#FF071D66"); Laseen.TextColor = Color.White; }
            else if (Constantce.Area == "Magaier Mohanna") { MagaierMohanna.BackgroundColor = Color.FromHex("#FF071D66"); MagaierMohanna.TextColor = Color.White; }
            else if (Constantce.Area == "Majedeah, Zabarah") { Majedeah.BackgroundColor = Color.FromHex("#FF071D66"); Majedeah.TextColor = Color.White; }
            else if (Constantce.Area == "Manshiyyet Hesban") { ManshiyyetHesban.BackgroundColor = Color.FromHex("#FF071D66"); ManshiyyetHesban.TextColor = Color.White; }
            else if (Constantce.Area == "Mansoorah") { Mansoorah.BackgroundColor = Color.FromHex("#FF071D66"); Mansoorah.TextColor = Color.White; }
            else if (Constantce.Area == "Marj al - Hamam") { MarjalHamam.BackgroundColor = Color.FromHex("#FF071D66"); MarjalHamam.TextColor = Color.White; }
            else if (Constantce.Area == "Masooh") { Masooh.BackgroundColor = Color.FromHex("#FF071D66"); Masooh.TextColor = Color.White; }
            else if (Constantce.Area == "Mastabah") { Mastabah.BackgroundColor = Color.FromHex("#FF071D66"); Mastabah.TextColor = Color.White; }
            else if (Constantce.Area == "Mowaqqar") { Mowaqqar.BackgroundColor = Color.FromHex("#FF071D66"); Mowaqqar.TextColor = Color.White; }
            else if (Constantce.Area == "Msaitbah") { Msaitbah.BackgroundColor = Color.FromHex("#FF071D66"); Msaitbah.TextColor = Color.White; }
            else if (Constantce.Area == "Mshairfah") { Mshairfah.BackgroundColor = Color.FromHex("#FF071D66"); Mshairfah.TextColor = Color.White; }
            else if (Constantce.Area == "Muqabalayn") { Muqabalayn.BackgroundColor = Color.FromHex("#FF071D66"); Muqabalayn.TextColor = Color.White; }
            else if (Constantce.Area == "Mushakar") { Mushakar.BackgroundColor = Color.FromHex("#FF071D66"); Mushakar.TextColor = Color.White; }
            else if (Constantce.Area == "N'air") { Nair.BackgroundColor = Color.FromHex("#FF071D66"); Nair.TextColor = Color.White; }
            else if (Constantce.Area == "Naour") { Naour.BackgroundColor = Color.FromHex("#FF071D66"); Naour.TextColor = Color.White; }
            else if (Constantce.Area == "Naqera") { Naqera.BackgroundColor = Color.FromHex("#FF071D66"); Naqera.TextColor = Color.White; }
            else if (Constantce.Area == "Quwaysimah - Jweideh - Abu Alanda - Rajeeb") { Quwaysimah.BackgroundColor = Color.FromHex("#FF071D66"); Quwaysimah.TextColor = Color.White; }
            else if (Constantce.Area == "Rabyyeh") { Rabyyeh.BackgroundColor = Color.FromHex("#FF071D66"); Rabyyeh.TextColor = Color.White; }
            else if (Constantce.Area == "Rajaha") { Rajaha.BackgroundColor = Color.FromHex("#FF071D66"); Rajaha.TextColor = Color.White; }
            else if (Constantce.Area == "Ramil") { Ramil.BackgroundColor = Color.FromHex("#FF071D66"); Ramil.TextColor = Color.White; }
            else if (Constantce.Area == "Raudet Hussen Namuthajeh") { RaudetHussenNamuthajeh.BackgroundColor = Color.FromHex("#FF071D66"); RaudetHussenNamuthajeh.TextColor = Color.White; }
            else if (Constantce.Area == "Rawdhah") { Rawdhah.BackgroundColor = Color.FromHex("#FF071D66"); Rawdhah.TextColor = Color.White; }
            else if (Constantce.Area == "Rojom Eqab") { RojomEqab.BackgroundColor = Color.FromHex("#FF071D66"); RojomEqab.TextColor = Color.White; }
            else if (Constantce.Area == "Rojom Fhaid") { RojomFhaid.BackgroundColor = Color.FromHex("#FF071D66"); RojomFhaid.TextColor = Color.White; }
            else if (Constantce.Area == "Rojom Shami Gharbi") { RojomShamiGharbi.BackgroundColor = Color.FromHex("#FF071D66"); RojomShamiGharbi.TextColor = Color.White; }
            else if (Constantce.Area == "Rojom Shami Sharqi") { RojomShamiSharqi.BackgroundColor = Color.FromHex("#FF071D66"); RojomShamiSharqi.TextColor = Color.White; }
            else if (Constantce.Area == "Sahab") { Sahab.BackgroundColor = Color.FromHex("#FF071D66"); Sahab.TextColor = Color.White; }
            else if (Constantce.Area == "Sail Hesban") { SailHesban.BackgroundColor = Color.FromHex("#FF071D66"); SailHesban.TextColor = Color.White; }
            else if (Constantce.Area == "Salem") { Salem.BackgroundColor = Color.FromHex("#FF071D66"); Salem.TextColor = Color.White; }
            else if (Constantce.Area == "Salyeh") { Salyeh.BackgroundColor = Color.FromHex("#FF071D66"); Salyeh.TextColor = Color.White; }
            else if (Constantce.Area == "Samek") { Samek.BackgroundColor = Color.FromHex("#FF071D66"); Samek.TextColor = Color.White; }
            else if (Constantce.Area == "Shafa Badran") { ShafaBadran.BackgroundColor = Color.FromHex("#FF071D66"); ShafaBadran.TextColor = Color.White; }
            else if (Constantce.Area == "Sweileh") { Sweileh.BackgroundColor = Color.FromHex("#FF071D66"); Sweileh.TextColor = Color.White; }
            else if (Constantce.Area == "Tabaqa") { Tabaqa.BackgroundColor = Color.FromHex("#FF071D66"); Tabaqa.TextColor = Color.White; }
            else if (Constantce.Area == "Tharah") { Tharah.BackgroundColor = Color.FromHex("#FF071D66"); Tharah.TextColor = Color.White; }
            else if (Constantce.Area == "Thograh") { Thograh.BackgroundColor = Color.FromHex("#FF071D66"); Thograh.TextColor = Color.White; }
            else if (Constantce.Area == "Thrayya") { Thrayya.BackgroundColor = Color.FromHex("#FF071D66"); Thrayya.TextColor = Color.White; }
            else if (Constantce.Area == "Toar Hashash") { ToarHashash.BackgroundColor = Color.FromHex("#FF071D66"); ToarHashash.TextColor = Color.White; }
            else if (Constantce.Area == "Torky") { Torky.BackgroundColor = Color.FromHex("#FF071D66"); Torky.TextColor = Color.White; }
            else if (Constantce.Area == "Um El - Berak") { UmElBerak.BackgroundColor = Color.FromHex("#FF071D66"); UmElBerak.TextColor = Color.White; }
            else if (Constantce.Area == "Um El - Kindam") { UmElKindam.BackgroundColor = Color.FromHex("#FF071D66"); UmElKindam.TextColor = Color.White; }
            else if (Constantce.Area == "Umm Botmah") { UmmBotmah.BackgroundColor = Color.FromHex("#FF071D66"); UmmBotmah.TextColor = Color.White; }
            else if (Constantce.Area == "Umm El - Asaker") { UmmElAsaker.BackgroundColor = Color.FromHex("#FF071D66"); UmmElAsaker.TextColor = Color.White; }
            else if (Constantce.Area == "Umm El - Basatien") { UmmElBasatien.BackgroundColor = Color.FromHex("#FF071D66"); UmmElBasatien.TextColor = Color.White; }
            else if (Constantce.Area == "Umm Essommaq") { UmmEssommaq.BackgroundColor = Color.FromHex("#FF071D66"); UmmEssommaq.TextColor = Color.White; }
            else if (Constantce.Area == "Umm Njasa") { UmmNjasa.BackgroundColor = Color.FromHex("#FF071D66"); UmmNjasa.TextColor = Color.White; }
            else if (Constantce.Area == "Umm Rsas") { UmmRsas.BackgroundColor = Color.FromHex("#FF071D66"); UmmRsas.TextColor = Color.White; }
            else if (Constantce.Area == "Wadi Eshta") { WadiEshta.BackgroundColor = Color.FromHex("#FF071D66"); WadiEshta.TextColor = Color.White; }
            else if (Constantce.Area == "Wadi Essier") { WadiEssier.BackgroundColor = Color.FromHex("#FF071D66"); WadiEssier.TextColor = Color.White; }
            else if (Constantce.Area == "Yahoon") { Yahoon.BackgroundColor = Color.FromHex("#FF071D66"); Yahoon.TextColor = Color.White; }
            else if (Constantce.Area == "Zbood") { Zbood.BackgroundColor = Color.FromHex("#FF071D66"); Zbood.TextColor = Color.White; }
            else if (Constantce.Area == "Zmailat") { Zmailat.BackgroundColor = Color.FromHex("#FF071D66"); Zmailat.TextColor = Color.White; }
            else if (Constantce.Area == "Zmaileh") { Zmaileh.BackgroundColor = Color.FromHex("#FF071D66"); Zmaileh.TextColor = Color.White; }

        }
        async void AbuEssoos_Clicked(object sender, EventArgs e) { if (AbuEssoos.BackgroundColor == Color.White) { Constantce.Area = "Abu Essoos"; Constantce.AreaLang = AbuEssoos.Text; AbuEssoos.TextColor = Color.White; AbuEssoos.BackgroundColor = Color.FromHex("#FF071D66"); var existingPages = Navigation.NavigationStack.ToList(); Page page = existingPages.FirstOrDefault(); Navigation.InsertPageBefore(new Home(), page); Navigation.RemovePage(page); await PopupNavigation.Instance.PopAsync(); } else { Constantce.Area = "Area"; AbuEssoos.BackgroundColor = Color.White; AbuEssoos.TextColor = Color.FromHex("#FF071D66"); } }
        async void AbuHlaileefah_Clicked(object sender, EventArgs e) { if (AbuHlaileefah.BackgroundColor == Color.White) { Constantce.Area = "Abu Hlaileefah"; Constantce.AreaLang = AbuHlaileefah.Text; AbuHlaileefah.TextColor = Color.White; AbuHlaileefah.BackgroundColor = Color.FromHex("#FF071D66"); var existingPages = Navigation.NavigationStack.ToList(); Page page = existingPages.FirstOrDefault(); Navigation.InsertPageBefore(new Home(), page); Navigation.RemovePage(page); await PopupNavigation.Instance.PopAsync(); } else { Constantce.Area = "Area"; AbuHlaileefah.BackgroundColor = Color.White; AbuHlaileefah.TextColor = Color.FromHex("#FF071D66"); } }
        async void AbuNaqlah_Clicked(object sender, EventArgs e) { if (AbuNaqlah.BackgroundColor == Color.White) { Constantce.Area = "Abu Naqlah"; Constantce.AreaLang = AbuNaqlah.Text; AbuNaqlah.TextColor = Color.White; AbuNaqlah.BackgroundColor = Color.FromHex("#FF071D66"); var existingPages = Navigation.NavigationStack.ToList(); Page page = existingPages.FirstOrDefault(); Navigation.InsertPageBefore(new Home(), page); Navigation.RemovePage(page); await PopupNavigation.Instance.PopAsync(); } else { Constantce.Area = "Area"; AbuNaqlah.BackgroundColor = Color.White; AbuNaqlah.TextColor = Color.FromHex("#FF071D66"); } }
        async void Adasiyyeh_Clicked(object sender, EventArgs e) { if (Adasiyyeh.BackgroundColor == Color.White) { Constantce.Area = "Adasiyyeh"; Constantce.AreaLang = Adasiyyeh.Text; Adasiyyeh.TextColor = Color.White; Adasiyyeh.BackgroundColor = Color.FromHex("#FF071D66"); var existingPages = Navigation.NavigationStack.ToList(); Page page = existingPages.FirstOrDefault(); Navigation.InsertPageBefore(new Home(), page); Navigation.RemovePage(page); await PopupNavigation.Instance.PopAsync(); } else { Constantce.Area = "Area"; Adasiyyeh.BackgroundColor = Color.White; Adasiyyeh.TextColor = Color.FromHex("#FF071D66"); } }
        async void Adbayan_Clicked(object sender, EventArgs e) { if (Adbayan.BackgroundColor == Color.White) { Constantce.Area = "Adbayan"; Constantce.AreaLang = Adbayan.Text; Adbayan.TextColor = Color.White; Adbayan.BackgroundColor = Color.FromHex("#FF071D66"); var existingPages = Navigation.NavigationStack.ToList(); Page page = existingPages.FirstOrDefault(); Navigation.InsertPageBefore(new Home(), page); Navigation.RemovePage(page); await PopupNavigation.Instance.PopAsync(); } else { Constantce.Area = "Area"; Adbayan.BackgroundColor = Color.White; Adbayan.TextColor = Color.FromHex("#FF071D66"); } }
        async void Ajajreh_Clicked(object sender, EventArgs e) { if (Ajajreh.BackgroundColor == Color.White) { Constantce.Area = "Ajajreh"; Constantce.AreaLang = Ajajreh.Text; Ajajreh.TextColor = Color.White; Ajajreh.BackgroundColor = Color.FromHex("#FF071D66"); var existingPages = Navigation.NavigationStack.ToList(); Page page = existingPages.FirstOrDefault(); Navigation.InsertPageBefore(new Home(), page); Navigation.RemovePage(page); await PopupNavigation.Instance.PopAsync(); } else { Constantce.Area = "Area"; Ajajreh.BackgroundColor = Color.White; Ajajreh.TextColor = Color.FromHex("#FF071D66"); } }
        async void AlRama_Clicked(object sender, EventArgs e) { if (AlRama.BackgroundColor == Color.White) { Constantce.Area = "Al Rama"; Constantce.AreaLang = AlRama.Text; AlRama.TextColor = Color.White; AlRama.BackgroundColor = Color.FromHex("#FF071D66"); var existingPages = Navigation.NavigationStack.ToList(); Page page = existingPages.FirstOrDefault(); Navigation.InsertPageBefore(new Home(), page); Navigation.RemovePage(page); await PopupNavigation.Instance.PopAsync(); } else { Constantce.Area = "Area"; AlRama.BackgroundColor = Color.White; AlRama.TextColor = Color.FromHex("#FF071D66"); } }
        async void Almaniyyeh_Clicked(object sender, EventArgs e) { if (Almaniyyeh.BackgroundColor == Color.White) { Constantce.Area = "Almaniyyeh"; Constantce.AreaLang = Almaniyyeh.Text; Almaniyyeh.TextColor = Color.White; Almaniyyeh.BackgroundColor = Color.FromHex("#FF071D66"); var existingPages = Navigation.NavigationStack.ToList(); Page page = existingPages.FirstOrDefault(); Navigation.InsertPageBefore(new Home(), page); Navigation.RemovePage(page); await PopupNavigation.Instance.PopAsync(); } else { Constantce.Area = "Area"; Almaniyyeh.BackgroundColor = Color.White; Almaniyyeh.TextColor = Color.FromHex("#FF071D66"); } }
        async void AlManshiyah_Clicked(object sender, EventArgs e) { if (AlManshiyah.BackgroundColor == Color.White) { Constantce.Area = "Al - Manshiyah"; Constantce.AreaLang = AlManshiyah.Text; AlManshiyah.TextColor = Color.White; AlManshiyah.BackgroundColor = Color.FromHex("#FF071D66"); var existingPages = Navigation.NavigationStack.ToList(); Page page = existingPages.FirstOrDefault(); Navigation.InsertPageBefore(new Home(), page); Navigation.RemovePage(page); await PopupNavigation.Instance.PopAsync(); } else { Constantce.Area = "Area"; AlManshiyah.BackgroundColor = Color.White; AlManshiyah.TextColor = Color.FromHex("#FF071D66"); } }
        async void Amireah_Clicked(object sender, EventArgs e) { if (Amireah.BackgroundColor == Color.White) { Constantce.Area = "Amireah"; Constantce.AreaLang = Amireah.Text; Amireah.TextColor = Color.White; Amireah.BackgroundColor = Color.FromHex("#FF071D66"); var existingPages = Navigation.NavigationStack.ToList(); Page page = existingPages.FirstOrDefault(); Navigation.InsertPageBefore(new Home(), page); Navigation.RemovePage(page); await PopupNavigation.Instance.PopAsync(); } else { Constantce.Area = "Area"; Amireah.BackgroundColor = Color.White; Amireah.TextColor = Color.FromHex("#FF071D66"); } }
        async void Amman_Clicked(object sender, EventArgs e) { if (JabalAmman.BackgroundColor == Color.White) { Constantce.Area = "Amman"; Constantce.AreaLang = JabalAmman.Text; JabalAmman.TextColor = Color.White; JabalAmman.BackgroundColor = Color.FromHex("#FF071D66"); var existingPages = Navigation.NavigationStack.ToList(); Page page = existingPages.FirstOrDefault(); Navigation.InsertPageBefore(new Home(), page); Navigation.RemovePage(page); await PopupNavigation.Instance.PopAsync(); } else { Constantce.Area = "Area"; JabalAmman.BackgroundColor = Color.White; JabalAmman.TextColor = Color.FromHex("#FF071D66"); } }
        async void AskanAbuNushayr_Clicked(object sender, EventArgs e) { if (AskanAbuNushayr.BackgroundColor == Color.White) { Constantce.Area = "Askan Abu Nushayr"; Constantce.AreaLang = AskanAbuNushayr.Text; AskanAbuNushayr.TextColor = Color.White; AskanAbuNushayr.BackgroundColor = Color.FromHex("#FF071D66"); var existingPages = Navigation.NavigationStack.ToList(); Page page = existingPages.FirstOrDefault(); Navigation.InsertPageBefore(new Home(), page); Navigation.RemovePage(page); await PopupNavigation.Instance.PopAsync(); } else { Constantce.Area = "Area"; AskanAbuNushayr.BackgroundColor = Color.White; AskanAbuNushayr.TextColor = Color.FromHex("#FF071D66"); } }
        async void BadrJadeda_Clicked(object sender, EventArgs e) { if (BadrJadeda.BackgroundColor == Color.White) { Constantce.Area = "Badr Jadeda"; Constantce.AreaLang = BadrJadeda.Text; BadrJadeda.TextColor = Color.White; BadrJadeda.BackgroundColor = Color.FromHex("#FF071D66"); var existingPages = Navigation.NavigationStack.ToList(); Page page = existingPages.FirstOrDefault(); Navigation.InsertPageBefore(new Home(), page); Navigation.RemovePage(page); await PopupNavigation.Instance.PopAsync(); } else { Constantce.Area = "Area"; BadrJadeda.BackgroundColor = Color.White; BadrJadeda.TextColor = Color.FromHex("#FF071D66"); } }
        async void Bahath_Clicked(object sender, EventArgs e) { if (Bahath.BackgroundColor == Color.White) { Constantce.Area = "Bahath"; Constantce.AreaLang = Bahath.Text; Bahath.TextColor = Color.White; Bahath.BackgroundColor = Color.FromHex("#FF071D66"); var existingPages = Navigation.NavigationStack.ToList(); Page page = existingPages.FirstOrDefault(); Navigation.InsertPageBefore(new Home(), page); Navigation.RemovePage(page); await PopupNavigation.Instance.PopAsync(); } else { Constantce.Area = "Area"; Bahath.BackgroundColor = Color.White; Bahath.TextColor = Color.FromHex("#FF071D66"); } }
        async void Balas_Clicked(object sender, EventArgs e) { if (Balas.BackgroundColor == Color.White) { Constantce.Area = "Bal'as"; Constantce.AreaLang = Balas.Text; Balas.TextColor = Color.White; Balas.BackgroundColor = Color.FromHex("#FF071D66"); var existingPages = Navigation.NavigationStack.ToList(); Page page = existingPages.FirstOrDefault(); Navigation.InsertPageBefore(new Home(), page); Navigation.RemovePage(page); await PopupNavigation.Instance.PopAsync(); } else { Constantce.Area = "Area"; Balas.BackgroundColor = Color.White; Balas.TextColor = Color.FromHex("#FF071D66"); } }
        async void Bassa_Clicked(object sender, EventArgs e) { if (Bassa.BackgroundColor == Color.White) { Constantce.Area = "Bassa"; Constantce.AreaLang = Bassa.Text; Bassa.TextColor = Color.White; Bassa.BackgroundColor = Color.FromHex("#FF071D66"); var existingPages = Navigation.NavigationStack.ToList(); Page page = existingPages.FirstOrDefault(); Navigation.InsertPageBefore(new Home(), page); Navigation.RemovePage(page); await PopupNavigation.Instance.PopAsync(); } else { Constantce.Area = "Area"; Bassa.BackgroundColor = Color.White; Bassa.TextColor = Color.FromHex("#FF071D66"); } }
        async void BassetNaoor_Clicked(object sender, EventArgs e) { if (BassetNaoor.BackgroundColor == Color.White) { Constantce.Area = "Basset Na'oor"; Constantce.AreaLang = BassetNaoor.Text; BassetNaoor.TextColor = Color.White; BassetNaoor.BackgroundColor = Color.FromHex("#FF071D66"); var existingPages = Navigation.NavigationStack.ToList(); Page page = existingPages.FirstOrDefault(); Navigation.InsertPageBefore(new Home(), page); Navigation.RemovePage(page); await PopupNavigation.Instance.PopAsync(); } else { Constantce.Area = "Area"; BassetNaoor.BackgroundColor = Color.White; BassetNaoor.TextColor = Color.FromHex("#FF071D66"); } }
        async void Buhairat_Clicked(object sender, EventArgs e) { if (Buhairat.BackgroundColor == Color.White) { Constantce.Area = "Buhairat, Mansheat Elsuareah"; Constantce.AreaLang = Buhairat.Text; Buhairat.TextColor = Color.White; Buhairat.BackgroundColor = Color.FromHex("#FF071D66"); var existingPages = Navigation.NavigationStack.ToList(); Page page = existingPages.FirstOrDefault(); Navigation.InsertPageBefore(new Home(), page); Navigation.RemovePage(page); await PopupNavigation.Instance.PopAsync(); } else { Constantce.Area = "Area"; Buhairat.BackgroundColor = Color.White; Buhairat.TextColor = Color.FromHex("#FF071D66"); } }
        async void Dabah_Clicked(object sender, EventArgs e) { if (Dabah.BackgroundColor == Color.White) { Constantce.Area = "Dab'ah"; Constantce.AreaLang = Dabah.Text; Dabah.TextColor = Color.White; Dabah.BackgroundColor = Color.FromHex("#FF071D66"); var existingPages = Navigation.NavigationStack.ToList(); Page page = existingPages.FirstOrDefault(); Navigation.InsertPageBefore(new Home(), page); Navigation.RemovePage(page); await PopupNavigation.Instance.PopAsync(); } else { Constantce.Area = "Area"; Dabah.BackgroundColor = Color.White; Dabah.TextColor = Color.FromHex("#FF071D66"); } }
        async void Dabbeh_Clicked(object sender, EventArgs e) { if (Dabbeh.BackgroundColor == Color.White) { Constantce.Area = "Dabbeh"; Constantce.AreaLang = Dabbeh.Text; Dabbeh.TextColor = Color.White; Dabbeh.BackgroundColor = Color.FromHex("#FF071D66"); var existingPages = Navigation.NavigationStack.ToList(); Page page = existingPages.FirstOrDefault(); Navigation.InsertPageBefore(new Home(), page); Navigation.RemovePage(page); await PopupNavigation.Instance.PopAsync(); } else { Constantce.Area = "Area"; Dabbeh.BackgroundColor = Color.White; Dabbeh.TextColor = Color.FromHex("#FF071D66"); } }
        async void Dair_Clicked(object sender, EventArgs e) { if (Dair.BackgroundColor == Color.White) { Constantce.Area = "Dair"; Constantce.AreaLang = Dair.Text; Dair.TextColor = Color.White; Dair.BackgroundColor = Color.FromHex("#FF071D66"); var existingPages = Navigation.NavigationStack.ToList(); Page page = existingPages.FirstOrDefault(); Navigation.InsertPageBefore(new Home(), page); Navigation.RemovePage(page); await PopupNavigation.Instance.PopAsync(); } else { Constantce.Area = "Area"; Dair.BackgroundColor = Color.White; Dair.TextColor = Color.FromHex("#FF071D66"); } }
        async void Damki_Clicked(object sender, EventArgs e) { if (Damki.BackgroundColor == Color.White) { Constantce.Area = "Damki"; Constantce.AreaLang = Damki.Text; Damki.TextColor = Color.White; Damki.BackgroundColor = Color.FromHex("#FF071D66"); var existingPages = Navigation.NavigationStack.ToList(); Page page = existingPages.FirstOrDefault(); Navigation.InsertPageBefore(new Home(), page); Navigation.RemovePage(page); await PopupNavigation.Instance.PopAsync(); } else { Constantce.Area = "Area"; Damki.BackgroundColor = Color.White; Damki.TextColor = Color.FromHex("#FF071D66"); } }
        async void DhaibehGharbiyyeh_Clicked(object sender, EventArgs e) { if (DhaibehGharbiyyeh.BackgroundColor == Color.White) { Constantce.Area = "Dhaibeh Gharbiyyeh"; Constantce.AreaLang = DhaibehGharbiyyeh.Text; DhaibehGharbiyyeh.TextColor = Color.White; DhaibehGharbiyyeh.BackgroundColor = Color.FromHex("#FF071D66"); var existingPages = Navigation.NavigationStack.ToList(); Page page = existingPages.FirstOrDefault(); Navigation.InsertPageBefore(new Home(), page); Navigation.RemovePage(page); await PopupNavigation.Instance.PopAsync(); } else { Constantce.Area = "Area"; DhaibehGharbiyyeh.BackgroundColor = Color.White; DhaibehGharbiyyeh.TextColor = Color.FromHex("#FF071D66"); } }
        async void DhaibehSharqiyyeh_Clicked(object sender, EventArgs e) { if (DhaibehSharqiyyeh.BackgroundColor == Color.White) { Constantce.Area = "Dhaibeh Sharqiyyeh"; Constantce.AreaLang = DhaibehSharqiyyeh.Text; DhaibehSharqiyyeh.TextColor = Color.White; DhaibehSharqiyyeh.BackgroundColor = Color.FromHex("#FF071D66"); var existingPages = Navigation.NavigationStack.ToList(); Page page = existingPages.FirstOrDefault(); Navigation.InsertPageBefore(new Home(), page); Navigation.RemovePage(page); await PopupNavigation.Instance.PopAsync(); } else { Constantce.Area = "Area"; DhaibehSharqiyyeh.BackgroundColor = Color.White; DhaibehSharqiyyeh.TextColor = Color.FromHex("#FF071D66"); } }
        async void ElAal_Clicked(object sender, EventArgs e) { if (ElAal.BackgroundColor == Color.White) { Constantce.Area = "El - A'al"; Constantce.AreaLang = ElAal.Text; ElAal.TextColor = Color.White; ElAal.BackgroundColor = Color.FromHex("#FF071D66"); var existingPages = Navigation.NavigationStack.ToList(); Page page = existingPages.FirstOrDefault(); Navigation.InsertPageBefore(new Home(), page); Navigation.RemovePage(page); await PopupNavigation.Instance.PopAsync(); } else { Constantce.Area = "Area"; ElAal.BackgroundColor = Color.White; ElAal.TextColor = Color.FromHex("#FF071D66"); } }
        async void Elayyan_Clicked(object sender, EventArgs e) { if (Elayyan.BackgroundColor == Color.White) { Constantce.Area = "Elayyan"; Constantce.AreaLang = Elayyan.Text; Elayyan.TextColor = Color.White; Elayyan.BackgroundColor = Color.FromHex("#FF071D66"); var existingPages = Navigation.NavigationStack.ToList(); Page page = existingPages.FirstOrDefault(); Navigation.InsertPageBefore(new Home(), page); Navigation.RemovePage(page); await PopupNavigation.Instance.PopAsync(); } else { Constantce.Area = "Area"; Elayyan.BackgroundColor = Color.White; Elayyan.TextColor = Color.FromHex("#FF071D66"); } }
        async void EraqElamir_Clicked(object sender, EventArgs e) { if (EraqElamir.BackgroundColor == Color.White) { Constantce.Area = "Eraq Elamir"; Constantce.AreaLang = EraqElamir.Text; EraqElamir.TextColor = Color.White; EraqElamir.BackgroundColor = Color.FromHex("#FF071D66"); var existingPages = Navigation.NavigationStack.ToList(); Page page = existingPages.FirstOrDefault(); Navigation.InsertPageBefore(new Home(), page); Navigation.RemovePage(page); await PopupNavigation.Instance.PopAsync(); } else { Constantce.Area = "Area"; EraqElamir.BackgroundColor = Color.White; EraqElamir.TextColor = Color.FromHex("#FF071D66"); } }
        async void Ewailiyyeh_Clicked(object sender, EventArgs e) { if (Ewailiyyeh.BackgroundColor == Color.White) { Constantce.Area = "Ewailiyyeh"; Constantce.AreaLang = Ewailiyyeh.Text; Ewailiyyeh.TextColor = Color.White; Ewailiyyeh.BackgroundColor = Color.FromHex("#FF071D66"); var existingPages = Navigation.NavigationStack.ToList(); Page page = existingPages.FirstOrDefault(); Navigation.InsertPageBefore(new Home(), page); Navigation.RemovePage(page); await PopupNavigation.Instance.PopAsync(); } else { Constantce.Area = "Area"; Ewailiyyeh.BackgroundColor = Color.White; Ewailiyyeh.TextColor = Color.FromHex("#FF071D66"); } }
        async void Fahs_Clicked(object sender, EventArgs e) { if (Fahs.BackgroundColor == Color.White) { Constantce.Area = "Fahs"; Constantce.AreaLang = Fahs.Text; Fahs.TextColor = Color.White; Fahs.BackgroundColor = Color.FromHex("#FF071D66"); var existingPages = Navigation.NavigationStack.ToList(); Page page = existingPages.FirstOrDefault(); Navigation.InsertPageBefore(new Home(), page); Navigation.RemovePage(page); await PopupNavigation.Instance.PopAsync(); } else { Constantce.Area = "Area"; Fahs.BackgroundColor = Color.White; Fahs.TextColor = Color.FromHex("#FF071D66"); } }
        async void Ghazaleh_Clicked(object sender, EventArgs e) { if (Ghazaleh.BackgroundColor == Color.White) { Constantce.Area = "Ghazaleh"; Constantce.AreaLang = Ghazaleh.Text; Ghazaleh.TextColor = Color.White; Ghazaleh.BackgroundColor = Color.FromHex("#FF071D66"); var existingPages = Navigation.NavigationStack.ToList(); Page page = existingPages.FirstOrDefault(); Navigation.InsertPageBefore(new Home(), page); Navigation.RemovePage(page); await PopupNavigation.Instance.PopAsync(); } else { Constantce.Area = "Area"; Ghazaleh.BackgroundColor = Color.White; Ghazaleh.TextColor = Color.FromHex("#FF071D66"); } }
        async void Hamdeih_Clicked(object sender, EventArgs e) { if (Hamdeih.BackgroundColor == Color.White) { Constantce.Area = "Hamdeih"; Constantce.AreaLang = Hamdeih.Text; Hamdeih.TextColor = Color.White; Hamdeih.BackgroundColor = Color.FromHex("#FF071D66"); var existingPages = Navigation.NavigationStack.ToList(); Page page = existingPages.FirstOrDefault(); Navigation.InsertPageBefore(new Home(), page); Navigation.RemovePage(page); await PopupNavigation.Instance.PopAsync(); } else { Constantce.Area = "Area"; Hamdeih.BackgroundColor = Color.White; Hamdeih.TextColor = Color.FromHex("#FF071D66"); } }
        async void HammamElShmoot_Clicked(object sender, EventArgs e) { if (HammamElShmoot.BackgroundColor == Color.White) { Constantce.Area = "Hammam El - Shmoot"; Constantce.AreaLang = HammamElShmoot.Text; HammamElShmoot.TextColor = Color.White; HammamElShmoot.BackgroundColor = Color.FromHex("#FF071D66"); var existingPages = Navigation.NavigationStack.ToList(); Page page = existingPages.FirstOrDefault(); Navigation.InsertPageBefore(new Home(), page); Navigation.RemovePage(page); await PopupNavigation.Instance.PopAsync(); } else { Constantce.Area = "Area"; HammamElShmoot.BackgroundColor = Color.White; HammamElShmoot.TextColor = Color.FromHex("#FF071D66"); } }
        async void HammamElTallaq_Clicked(object sender, EventArgs e) { if (HammamElTallaq.BackgroundColor == Color.White) { Constantce.Area = "Hammam El - Tallaq"; Constantce.AreaLang = HammamElTallaq.Text; HammamElTallaq.TextColor = Color.White; HammamElTallaq.BackgroundColor = Color.FromHex("#FF071D66"); var existingPages = Navigation.NavigationStack.ToList(); Page page = existingPages.FirstOrDefault(); Navigation.InsertPageBefore(new Home(), page); Navigation.RemovePage(page); await PopupNavigation.Instance.PopAsync(); } else { Constantce.Area = "Area"; HammamElTallaq.BackgroundColor = Color.White; HammamElTallaq.TextColor = Color.FromHex("#FF071D66"); } }
        async void Hashimeyyah_Clicked(object sender, EventArgs e) { if (Hashimeyyah.BackgroundColor == Color.White) { Constantce.Area = "Hashimeyyah"; Constantce.AreaLang = Hashimeyyah.Text; Hashimeyyah.TextColor = Color.White; Hashimeyyah.BackgroundColor = Color.FromHex("#FF071D66"); var existingPages = Navigation.NavigationStack.ToList(); Page page = existingPages.FirstOrDefault(); Navigation.InsertPageBefore(new Home(), page); Navigation.RemovePage(page); await PopupNavigation.Instance.PopAsync(); } else { Constantce.Area = "Area"; Hashimeyyah.BackgroundColor = Color.White; Hashimeyyah.TextColor = Color.FromHex("#FF071D66"); } }
        async void Hatmeia_Clicked(object sender, EventArgs e) { if (Hatmeia.BackgroundColor == Color.White) { Constantce.Area = "Hatmeia"; Constantce.AreaLang = Hatmeia.Text; Hatmeia.TextColor = Color.White; Hatmeia.BackgroundColor = Color.FromHex("#FF071D66"); var existingPages = Navigation.NavigationStack.ToList(); Page page = existingPages.FirstOrDefault(); Navigation.InsertPageBefore(new Home(), page); Navigation.RemovePage(page); await PopupNavigation.Instance.PopAsync(); } else { Constantce.Area = "Area"; Hatmeia.BackgroundColor = Color.White; Hatmeia.TextColor = Color.FromHex("#FF071D66"); } }
        async void Hesban_Clicked(object sender, EventArgs e) { if (Hesban.BackgroundColor == Color.White) { Constantce.Area = "Hesban"; Constantce.AreaLang = Hesban.Text; Hesban.TextColor = Color.White; Hesban.BackgroundColor = Color.FromHex("#FF071D66"); var existingPages = Navigation.NavigationStack.ToList(); Page page = existingPages.FirstOrDefault(); Navigation.InsertPageBefore(new Home(), page); Navigation.RemovePage(page); await PopupNavigation.Instance.PopAsync(); } else { Constantce.Area = "Area"; Hesban.BackgroundColor = Color.White; Hesban.TextColor = Color.FromHex("#FF071D66"); } }
        async void Hunaifiyyeh_Clicked(object sender, EventArgs e) { if (Hunaifiyyeh.BackgroundColor == Color.White) { Constantce.Area = "Hunaifiyyeh"; Constantce.AreaLang = Hunaifiyyeh.Text; Hunaifiyyeh.TextColor = Color.White; Hunaifiyyeh.BackgroundColor = Color.FromHex("#FF071D66"); var existingPages = Navigation.NavigationStack.ToList(); Page page = existingPages.FirstOrDefault(); Navigation.InsertPageBefore(new Home(), page); Navigation.RemovePage(page); await PopupNavigation.Instance.PopAsync(); } else { Constantce.Area = "Area"; Hunaifiyyeh.BackgroundColor = Color.White; Hunaifiyyeh.TextColor = Color.FromHex("#FF071D66"); } }
        async void Jizeh_Clicked(object sender, EventArgs e) { if (Jizeh.BackgroundColor == Color.White) { Constantce.Area = "Jizeh"; Constantce.AreaLang = Jizeh.Text; Jizeh.TextColor = Color.White; Jizeh.BackgroundColor = Color.FromHex("#FF071D66"); var existingPages = Navigation.NavigationStack.ToList(); Page page = existingPages.FirstOrDefault(); Navigation.InsertPageBefore(new Home(), page); Navigation.RemovePage(page); await PopupNavigation.Instance.PopAsync(); } else { Constantce.Area = "Area"; Jizeh.BackgroundColor = Color.White; Jizeh.TextColor = Color.FromHex("#FF071D66"); } }
        async void Jnab_Clicked(object sender, EventArgs e) { if (Jnab.BackgroundColor == Color.White) { Constantce.Area = "Jnab"; Constantce.AreaLang = Jnab.Text; Jnab.TextColor = Color.White; Jnab.BackgroundColor = Color.FromHex("#FF071D66"); var existingPages = Navigation.NavigationStack.ToList(); Page page = existingPages.FirstOrDefault(); Navigation.InsertPageBefore(new Home(), page); Navigation.RemovePage(page); await PopupNavigation.Instance.PopAsync(); } else { Constantce.Area = "Area"; Jnab.BackgroundColor = Color.White; Jnab.TextColor = Color.FromHex("#FF071D66"); } }
        async void Jomail_Clicked(object sender, EventArgs e) { if (Jomail.BackgroundColor == Color.White) { Constantce.Area = "Jomail"; Constantce.AreaLang = Jomail.Text; Jomail.TextColor = Color.White; Jomail.BackgroundColor = Color.FromHex("#FF071D66"); var existingPages = Navigation.NavigationStack.ToList(); Page page = existingPages.FirstOrDefault(); Navigation.InsertPageBefore(new Home(), page); Navigation.RemovePage(page); await PopupNavigation.Instance.PopAsync(); } else { Constantce.Area = "Area"; Jomail.BackgroundColor = Color.White; Jomail.TextColor = Color.FromHex("#FF071D66"); } }
        async void Jubeiha_Clicked(object sender, EventArgs e) { if (Jubeiha.BackgroundColor == Color.White) { Constantce.Area = "Jubeiha"; Constantce.AreaLang = Jubeiha.Text; Jubeiha.TextColor = Color.White; Jubeiha.BackgroundColor = Color.FromHex("#FF071D66"); var existingPages = Navigation.NavigationStack.ToList(); Page page = existingPages.FirstOrDefault(); Navigation.InsertPageBefore(new Home(), page); Navigation.RemovePage(page); await PopupNavigation.Instance.PopAsync(); } else { Constantce.Area = "Area"; Jubeiha.BackgroundColor = Color.White; Jubeiha.TextColor = Color.FromHex("#FF071D66"); } }
        async void Kaldeh_Clicked(object sender, EventArgs e) { if (Kaldeh.BackgroundColor == Color.White) { Constantce.Area = "Kaldeh"; Constantce.AreaLang = Kaldeh.Text; Kaldeh.TextColor = Color.White; Kaldeh.BackgroundColor = Color.FromHex("#FF071D66"); var existingPages = Navigation.NavigationStack.ToList(); Page page = existingPages.FirstOrDefault(); Navigation.InsertPageBefore(new Home(), page); Navigation.RemovePage(page); await PopupNavigation.Instance.PopAsync(); } else { Constantce.Area = "Area"; Kaldeh.BackgroundColor = Color.White; Kaldeh.TextColor = Color.FromHex("#FF071D66"); } }
        async void KanElZabib_Clicked(object sender, EventArgs e) { if (KanElZabib.BackgroundColor == Color.White) { Constantce.Area = "Kan El - Zabib"; Constantce.AreaLang = KanElZabib.Text; KanElZabib.TextColor = Color.White; KanElZabib.BackgroundColor = Color.FromHex("#FF071D66"); var existingPages = Navigation.NavigationStack.ToList(); Page page = existingPages.FirstOrDefault(); Navigation.InsertPageBefore(new Home(), page); Navigation.RemovePage(page); await PopupNavigation.Instance.PopAsync(); } else { Constantce.Area = "Area"; KanElZabib.BackgroundColor = Color.White; KanElZabib.TextColor = Color.FromHex("#FF071D66"); } }
        async void KarmetHesban_Clicked(object sender, EventArgs e) { if (KarmetHesban.BackgroundColor == Color.White) { Constantce.Area = "Karmet Hesban"; Constantce.AreaLang = KarmetHesban.Text; KarmetHesban.TextColor = Color.White; KarmetHesban.BackgroundColor = Color.FromHex("#FF071D66"); var existingPages = Navigation.NavigationStack.ToList(); Page page = existingPages.FirstOrDefault(); Navigation.InsertPageBefore(new Home(), page); Navigation.RemovePage(page); await PopupNavigation.Instance.PopAsync(); } else { Constantce.Area = "Area"; KarmetHesban.BackgroundColor = Color.White; KarmetHesban.TextColor = Color.FromHex("#FF071D66"); } }
        async void Khilda_Clicked(object sender, EventArgs e) { if (Khilda.BackgroundColor == Color.White) { Constantce.Area = "Khilda - Umm Essommaq"; Constantce.AreaLang = Khilda.Text; Khilda.TextColor = Color.White; Khilda.BackgroundColor = Color.FromHex("#FF071D66"); var existingPages = Navigation.NavigationStack.ToList(); Page page = existingPages.FirstOrDefault(); Navigation.InsertPageBefore(new Home(), page); Navigation.RemovePage(page); await PopupNavigation.Instance.PopAsync(); } else { Constantce.Area = "Area"; Khilda.BackgroundColor = Color.White; Khilda.TextColor = Color.FromHex("#FF071D66"); } }
        async void KhraibetEssooq_Clicked(object sender, EventArgs e) { if (KhraibetEssooq.BackgroundColor == Color.White) { Constantce.Area = "Khraibet Essooq - Jawa - Yadoodeh"; Constantce.AreaLang = KhraibetEssooq.Text; KhraibetEssooq.TextColor = Color.White; KhraibetEssooq.BackgroundColor = Color.FromHex("#FF071D66"); var existingPages = Navigation.NavigationStack.ToList(); Page page = existingPages.FirstOrDefault(); Navigation.InsertPageBefore(new Home(), page); Navigation.RemovePage(page); await PopupNavigation.Instance.PopAsync(); } else { Constantce.Area = "Area"; KhraibetEssooq.BackgroundColor = Color.White; KhraibetEssooq.TextColor = Color.FromHex("#FF071D66"); } }
        async void Khrayyem_Clicked(object sender, EventArgs e) { if (Khrayyem.BackgroundColor == Color.White) { Constantce.Area = "Khrayyem"; Constantce.AreaLang = Khrayyem.Text; Khrayyem.TextColor = Color.White; Khrayyem.BackgroundColor = Color.FromHex("#FF071D66"); var existingPages = Navigation.NavigationStack.ToList(); Page page = existingPages.FirstOrDefault(); Navigation.InsertPageBefore(new Home(), page); Navigation.RemovePage(page); await PopupNavigation.Instance.PopAsync(); } else { Constantce.Area = "Area"; Khrayyem.BackgroundColor = Color.White; Khrayyem.TextColor = Color.FromHex("#FF071D66"); } }
        async void Ktafeh_Clicked(object sender, EventArgs e) { if (Ktafeh.BackgroundColor == Color.White) { Constantce.Area = "Ktafeh"; Constantce.AreaLang = Ktafeh.Text; Ktafeh.TextColor = Color.White; Ktafeh.BackgroundColor = Color.FromHex("#FF071D66"); var existingPages = Navigation.NavigationStack.ToList(); Page page = existingPages.FirstOrDefault(); Navigation.InsertPageBefore(new Home(), page); Navigation.RemovePage(page); await PopupNavigation.Instance.PopAsync(); } else { Constantce.Area = "Area"; Ktafeh.BackgroundColor = Color.White; Ktafeh.TextColor = Color.FromHex("#FF071D66"); } }
        async void Laseen_Clicked(object sender, EventArgs e) { if (Laseen.BackgroundColor == Color.White) { Constantce.Area = "Laseen"; Constantce.AreaLang = Laseen.Text; Laseen.TextColor = Color.White; Laseen.BackgroundColor = Color.FromHex("#FF071D66"); var existingPages = Navigation.NavigationStack.ToList(); Page page = existingPages.FirstOrDefault(); Navigation.InsertPageBefore(new Home(), page); Navigation.RemovePage(page); await PopupNavigation.Instance.PopAsync(); } else { Constantce.Area = "Area"; Laseen.BackgroundColor = Color.White; Laseen.TextColor = Color.FromHex("#FF071D66"); } }
        async void MagaierMohanna_Clicked(object sender, EventArgs e) { if (MagaierMohanna.BackgroundColor == Color.White) { Constantce.Area = "Magaier Mohanna"; Constantce.AreaLang = MagaierMohanna.Text; MagaierMohanna.TextColor = Color.White; MagaierMohanna.BackgroundColor = Color.FromHex("#FF071D66"); var existingPages = Navigation.NavigationStack.ToList(); Page page = existingPages.FirstOrDefault(); Navigation.InsertPageBefore(new Home(), page); Navigation.RemovePage(page); await PopupNavigation.Instance.PopAsync(); } else { Constantce.Area = "Area"; MagaierMohanna.BackgroundColor = Color.White; MagaierMohanna.TextColor = Color.FromHex("#FF071D66"); } }
        async void Majedeah_Clicked(object sender, EventArgs e) { if (Majedeah.BackgroundColor == Color.White) { Constantce.Area = "Majedeah, Zabarah"; Constantce.AreaLang = Majedeah.Text; Majedeah.TextColor = Color.White; Majedeah.BackgroundColor = Color.FromHex("#FF071D66"); var existingPages = Navigation.NavigationStack.ToList(); Page page = existingPages.FirstOrDefault(); Navigation.InsertPageBefore(new Home(), page); Navigation.RemovePage(page); await PopupNavigation.Instance.PopAsync(); } else { Constantce.Area = "Area"; Majedeah.BackgroundColor = Color.White; Majedeah.TextColor = Color.FromHex("#FF071D66"); } }
        async void ManshiyyetHesban_Clicked(object sender, EventArgs e) { if (ManshiyyetHesban.BackgroundColor == Color.White) { Constantce.Area = "Manshiyyet Hesban"; Constantce.AreaLang = ManshiyyetHesban.Text; ManshiyyetHesban.TextColor = Color.White; ManshiyyetHesban.BackgroundColor = Color.FromHex("#FF071D66"); var existingPages = Navigation.NavigationStack.ToList(); Page page = existingPages.FirstOrDefault(); Navigation.InsertPageBefore(new Home(), page); Navigation.RemovePage(page); await PopupNavigation.Instance.PopAsync(); } else { Constantce.Area = "Area"; ManshiyyetHesban.BackgroundColor = Color.White; ManshiyyetHesban.TextColor = Color.FromHex("#FF071D66"); } }
        async void Mansoorah_Clicked(object sender, EventArgs e) { if (Mansoorah.BackgroundColor == Color.White) { Constantce.Area = "Mansoorah"; Constantce.AreaLang = Mansoorah.Text; Mansoorah.TextColor = Color.White; Mansoorah.BackgroundColor = Color.FromHex("#FF071D66"); var existingPages = Navigation.NavigationStack.ToList(); Page page = existingPages.FirstOrDefault(); Navigation.InsertPageBefore(new Home(), page); Navigation.RemovePage(page); await PopupNavigation.Instance.PopAsync(); } else { Constantce.Area = "Area"; Mansoorah.BackgroundColor = Color.White; Mansoorah.TextColor = Color.FromHex("#FF071D66"); } }
        async void MarjalHamam_Clicked(object sender, EventArgs e) { if (MarjalHamam.BackgroundColor == Color.White) { Constantce.Area = "Marj al - Hamam"; Constantce.AreaLang = MarjalHamam.Text; MarjalHamam.TextColor = Color.White; MarjalHamam.BackgroundColor = Color.FromHex("#FF071D66"); var existingPages = Navigation.NavigationStack.ToList(); Page page = existingPages.FirstOrDefault(); Navigation.InsertPageBefore(new Home(), page); Navigation.RemovePage(page); await PopupNavigation.Instance.PopAsync(); } else { Constantce.Area = "Area"; MarjalHamam.BackgroundColor = Color.White; MarjalHamam.TextColor = Color.FromHex("#FF071D66"); } }
        async void Masooh_Clicked(object sender, EventArgs e) { if (Masooh.BackgroundColor == Color.White) { Constantce.Area = "Masooh"; Constantce.AreaLang = Masooh.Text; Masooh.TextColor = Color.White; Masooh.BackgroundColor = Color.FromHex("#FF071D66"); var existingPages = Navigation.NavigationStack.ToList(); Page page = existingPages.FirstOrDefault(); Navigation.InsertPageBefore(new Home(), page); Navigation.RemovePage(page); await PopupNavigation.Instance.PopAsync(); } else { Constantce.Area = "Area"; Masooh.BackgroundColor = Color.White; Masooh.TextColor = Color.FromHex("#FF071D66"); } }
        async void Mastabah_Clicked(object sender, EventArgs e) { if (Mastabah.BackgroundColor == Color.White) { Constantce.Area = "Mastabah"; Constantce.AreaLang = Mastabah.Text; Mastabah.TextColor = Color.White; Mastabah.BackgroundColor = Color.FromHex("#FF071D66"); var existingPages = Navigation.NavigationStack.ToList(); Page page = existingPages.FirstOrDefault(); Navigation.InsertPageBefore(new Home(), page); Navigation.RemovePage(page); await PopupNavigation.Instance.PopAsync(); } else { Constantce.Area = "Area"; Mastabah.BackgroundColor = Color.White; Mastabah.TextColor = Color.FromHex("#FF071D66"); } }
        async void Mowaqqar_Clicked(object sender, EventArgs e) { if (Mowaqqar.BackgroundColor == Color.White) { Constantce.Area = "Mowaqqar"; Constantce.AreaLang = Mowaqqar.Text; Mowaqqar.TextColor = Color.White; Mowaqqar.BackgroundColor = Color.FromHex("#FF071D66"); var existingPages = Navigation.NavigationStack.ToList(); Page page = existingPages.FirstOrDefault(); Navigation.InsertPageBefore(new Home(), page); Navigation.RemovePage(page); await PopupNavigation.Instance.PopAsync(); } else { Constantce.Area = "Area"; Mowaqqar.BackgroundColor = Color.White; Mowaqqar.TextColor = Color.FromHex("#FF071D66"); } }
        async void Msaitbah_Clicked(object sender, EventArgs e) { if (Msaitbah.BackgroundColor == Color.White) { Constantce.Area = "Msaitbah"; Constantce.AreaLang = Msaitbah.Text; Msaitbah.TextColor = Color.White; Msaitbah.BackgroundColor = Color.FromHex("#FF071D66"); var existingPages = Navigation.NavigationStack.ToList(); Page page = existingPages.FirstOrDefault(); Navigation.InsertPageBefore(new Home(), page); Navigation.RemovePage(page); await PopupNavigation.Instance.PopAsync(); } else { Constantce.Area = "Area"; Msaitbah.BackgroundColor = Color.White; Msaitbah.TextColor = Color.FromHex("#FF071D66"); } }
        async void Mshairfah_Clicked(object sender, EventArgs e) { if (Mshairfah.BackgroundColor == Color.White) { Constantce.Area = "Mshairfah"; Constantce.AreaLang = Mshairfah.Text; Mshairfah.TextColor = Color.White; Mshairfah.BackgroundColor = Color.FromHex("#FF071D66"); var existingPages = Navigation.NavigationStack.ToList(); Page page = existingPages.FirstOrDefault(); Navigation.InsertPageBefore(new Home(), page); Navigation.RemovePage(page); await PopupNavigation.Instance.PopAsync(); } else { Constantce.Area = "Area"; Mshairfah.BackgroundColor = Color.White; Mshairfah.TextColor = Color.FromHex("#FF071D66"); } }
        async void Muqabalayn_Clicked(object sender, EventArgs e) { if (Muqabalayn.BackgroundColor == Color.White) { Constantce.Area = "Muqabalayn"; Constantce.AreaLang = Muqabalayn.Text; Muqabalayn.TextColor = Color.White; Muqabalayn.BackgroundColor = Color.FromHex("#FF071D66"); var existingPages = Navigation.NavigationStack.ToList(); Page page = existingPages.FirstOrDefault(); Navigation.InsertPageBefore(new Home(), page); Navigation.RemovePage(page); await PopupNavigation.Instance.PopAsync(); } else { Constantce.Area = "Area"; Muqabalayn.BackgroundColor = Color.White; Muqabalayn.TextColor = Color.FromHex("#FF071D66"); } }
        async void Mushakar_Clicked(object sender, EventArgs e) { if (Mushakar.BackgroundColor == Color.White) { Constantce.Area = "Mushakar"; Constantce.AreaLang = Mushakar.Text; Mushakar.TextColor = Color.White; Mushakar.BackgroundColor = Color.FromHex("#FF071D66"); var existingPages = Navigation.NavigationStack.ToList(); Page page = existingPages.FirstOrDefault(); Navigation.InsertPageBefore(new Home(), page); Navigation.RemovePage(page); await PopupNavigation.Instance.PopAsync(); } else { Constantce.Area = "Area"; Mushakar.BackgroundColor = Color.White; Mushakar.TextColor = Color.FromHex("#FF071D66"); } }
        async void Nair_Clicked(object sender, EventArgs e) { if (Nair.BackgroundColor == Color.White) { Constantce.Area = "N'air"; Constantce.AreaLang = Nair.Text; Nair.TextColor = Color.White; Nair.BackgroundColor = Color.FromHex("#FF071D66"); var existingPages = Navigation.NavigationStack.ToList(); Page page = existingPages.FirstOrDefault(); Navigation.InsertPageBefore(new Home(), page); Navigation.RemovePage(page); await PopupNavigation.Instance.PopAsync(); } else { Constantce.Area = "Area"; Nair.BackgroundColor = Color.White; Nair.TextColor = Color.FromHex("#FF071D66"); } }
        async void Naour_Clicked(object sender, EventArgs e) { if (Naour.BackgroundColor == Color.White) { Constantce.Area = "Naour"; Constantce.AreaLang = Naour.Text; Naour.TextColor = Color.White; Naour.BackgroundColor = Color.FromHex("#FF071D66"); var existingPages = Navigation.NavigationStack.ToList(); Page page = existingPages.FirstOrDefault(); Navigation.InsertPageBefore(new Home(), page); Navigation.RemovePage(page); await PopupNavigation.Instance.PopAsync(); } else { Constantce.Area = "Area"; Naour.BackgroundColor = Color.White; Naour.TextColor = Color.FromHex("#FF071D66"); } }
        async void Naqera_Clicked(object sender, EventArgs e) { if (Naqera.BackgroundColor == Color.White) { Constantce.Area = "Naqera"; Constantce.AreaLang = Naqera.Text; Naqera.TextColor = Color.White; Naqera.BackgroundColor = Color.FromHex("#FF071D66"); var existingPages = Navigation.NavigationStack.ToList(); Page page = existingPages.FirstOrDefault(); Navigation.InsertPageBefore(new Home(), page); Navigation.RemovePage(page); await PopupNavigation.Instance.PopAsync(); } else { Constantce.Area = "Area"; Naqera.BackgroundColor = Color.White; Naqera.TextColor = Color.FromHex("#FF071D66"); } }
        async void Quwaysimah_Clicked(object sender, EventArgs e) { if (Quwaysimah.BackgroundColor == Color.White) { Constantce.Area = "Quwaysimah - Jweideh - Abu Alanda - Rajeeb"; Constantce.AreaLang = Quwaysimah.Text; Quwaysimah.TextColor = Color.White; Quwaysimah.BackgroundColor = Color.FromHex("#FF071D66"); var existingPages = Navigation.NavigationStack.ToList(); Page page = existingPages.FirstOrDefault(); Navigation.InsertPageBefore(new Home(), page); Navigation.RemovePage(page); await PopupNavigation.Instance.PopAsync(); } else { Constantce.Area = "Area"; Quwaysimah.BackgroundColor = Color.White; Quwaysimah.TextColor = Color.FromHex("#FF071D66"); } }
        async void Rabyyeh_Clicked(object sender, EventArgs e) { if (Rabyyeh.BackgroundColor == Color.White) { Constantce.Area = "Rabyyeh"; Constantce.AreaLang = Rabyyeh.Text; Rabyyeh.TextColor = Color.White; Rabyyeh.BackgroundColor = Color.FromHex("#FF071D66"); var existingPages = Navigation.NavigationStack.ToList(); Page page = existingPages.FirstOrDefault(); Navigation.InsertPageBefore(new Home(), page); Navigation.RemovePage(page); await PopupNavigation.Instance.PopAsync(); } else { Constantce.Area = "Area"; Rabyyeh.BackgroundColor = Color.White; Rabyyeh.TextColor = Color.FromHex("#FF071D66"); } }
        async void Rajaha_Clicked(object sender, EventArgs e) { if (Rajaha.BackgroundColor == Color.White) { Constantce.Area = "Rajaha"; Constantce.AreaLang = Rajaha.Text; Rajaha.TextColor = Color.White; Rajaha.BackgroundColor = Color.FromHex("#FF071D66"); var existingPages = Navigation.NavigationStack.ToList(); Page page = existingPages.FirstOrDefault(); Navigation.InsertPageBefore(new Home(), page); Navigation.RemovePage(page); await PopupNavigation.Instance.PopAsync(); } else { Constantce.Area = "Area"; Rajaha.BackgroundColor = Color.White; Rajaha.TextColor = Color.FromHex("#FF071D66"); } }
        async void Ramil_Clicked(object sender, EventArgs e) { if (Ramil.BackgroundColor == Color.White) { Constantce.Area = "Ramil"; Constantce.AreaLang = Ramil.Text; Ramil.TextColor = Color.White; Ramil.BackgroundColor = Color.FromHex("#FF071D66"); var existingPages = Navigation.NavigationStack.ToList(); Page page = existingPages.FirstOrDefault(); Navigation.InsertPageBefore(new Home(), page); Navigation.RemovePage(page); await PopupNavigation.Instance.PopAsync(); } else { Constantce.Area = "Area"; Ramil.BackgroundColor = Color.White; Ramil.TextColor = Color.FromHex("#FF071D66"); } }
        async void RaudetHussenNamuthajeh_Clicked(object sender, EventArgs e) { if (RaudetHussenNamuthajeh.BackgroundColor == Color.White) { Constantce.Area = "Raudet Hussen Namuthajeh"; Constantce.AreaLang = RaudetHussenNamuthajeh.Text; RaudetHussenNamuthajeh.TextColor = Color.White; RaudetHussenNamuthajeh.BackgroundColor = Color.FromHex("#FF071D66"); var existingPages = Navigation.NavigationStack.ToList(); Page page = existingPages.FirstOrDefault(); Navigation.InsertPageBefore(new Home(), page); Navigation.RemovePage(page); await PopupNavigation.Instance.PopAsync(); } else { Constantce.Area = "Area"; RaudetHussenNamuthajeh.BackgroundColor = Color.White; RaudetHussenNamuthajeh.TextColor = Color.FromHex("#FF071D66"); } }
        async void Rawdhah_Clicked(object sender, EventArgs e) { if (Rawdhah.BackgroundColor == Color.White) { Constantce.Area = "Rawdhah"; Constantce.AreaLang = Rawdhah.Text; Rawdhah.TextColor = Color.White; Rawdhah.BackgroundColor = Color.FromHex("#FF071D66"); var existingPages = Navigation.NavigationStack.ToList(); Page page = existingPages.FirstOrDefault(); Navigation.InsertPageBefore(new Home(), page); Navigation.RemovePage(page); await PopupNavigation.Instance.PopAsync(); } else { Constantce.Area = "Area"; Rawdhah.BackgroundColor = Color.White; Rawdhah.TextColor = Color.FromHex("#FF071D66"); } }
        async void RojomEqab_Clicked(object sender, EventArgs e) { if (RojomEqab.BackgroundColor == Color.White) { Constantce.Area = "Rojom Eqab"; Constantce.AreaLang = RojomEqab.Text; RojomEqab.TextColor = Color.White; RojomEqab.BackgroundColor = Color.FromHex("#FF071D66"); var existingPages = Navigation.NavigationStack.ToList(); Page page = existingPages.FirstOrDefault(); Navigation.InsertPageBefore(new Home(), page); Navigation.RemovePage(page); await PopupNavigation.Instance.PopAsync(); } else { Constantce.Area = "Area"; RojomEqab.BackgroundColor = Color.White; RojomEqab.TextColor = Color.FromHex("#FF071D66"); } }
        async void RojomFhaid_Clicked(object sender, EventArgs e) { if (RojomFhaid.BackgroundColor == Color.White) { Constantce.Area = "Rojom Fhaid"; Constantce.AreaLang = RojomFhaid.Text; RojomFhaid.TextColor = Color.White; RojomFhaid.BackgroundColor = Color.FromHex("#FF071D66"); var existingPages = Navigation.NavigationStack.ToList(); Page page = existingPages.FirstOrDefault(); Navigation.InsertPageBefore(new Home(), page); Navigation.RemovePage(page); await PopupNavigation.Instance.PopAsync(); } else { Constantce.Area = "Area"; RojomFhaid.BackgroundColor = Color.White; RojomFhaid.TextColor = Color.FromHex("#FF071D66"); } }
        async void RojomShamiGharbi_Clicked(object sender, EventArgs e) { if (RojomShamiGharbi.BackgroundColor == Color.White) { Constantce.Area = "Rojom Shami Gharbi"; Constantce.AreaLang = RojomShamiGharbi.Text; RojomShamiGharbi.TextColor = Color.White; RojomShamiGharbi.BackgroundColor = Color.FromHex("#FF071D66"); var existingPages = Navigation.NavigationStack.ToList(); Page page = existingPages.FirstOrDefault(); Navigation.InsertPageBefore(new Home(), page); Navigation.RemovePage(page); await PopupNavigation.Instance.PopAsync(); } else { Constantce.Area = "Area"; RojomShamiGharbi.BackgroundColor = Color.White; RojomShamiGharbi.TextColor = Color.FromHex("#FF071D66"); } }
        async void RojomShamiSharqi_Clicked(object sender, EventArgs e) { if (RojomShamiSharqi.BackgroundColor == Color.White) { Constantce.Area = "Rojom Shami Sharqi"; Constantce.AreaLang = RojomShamiSharqi.Text; RojomShamiSharqi.TextColor = Color.White; RojomShamiSharqi.BackgroundColor = Color.FromHex("#FF071D66"); var existingPages = Navigation.NavigationStack.ToList(); Page page = existingPages.FirstOrDefault(); Navigation.InsertPageBefore(new Home(), page); Navigation.RemovePage(page); await PopupNavigation.Instance.PopAsync(); } else { Constantce.Area = "Area"; RojomShamiSharqi.BackgroundColor = Color.White; RojomShamiSharqi.TextColor = Color.FromHex("#FF071D66"); } }
        async void Sahab_Clicked(object sender, EventArgs e) { if (Sahab.BackgroundColor == Color.White) { Constantce.Area = "Sahab"; Constantce.AreaLang = Sahab.Text; Sahab.TextColor = Color.White; Sahab.BackgroundColor = Color.FromHex("#FF071D66"); var existingPages = Navigation.NavigationStack.ToList(); Page page = existingPages.FirstOrDefault(); Navigation.InsertPageBefore(new Home(), page); Navigation.RemovePage(page); await PopupNavigation.Instance.PopAsync(); } else { Constantce.Area = "Area"; Sahab.BackgroundColor = Color.White; Sahab.TextColor = Color.FromHex("#FF071D66"); } }
        async void SailHesban_Clicked(object sender, EventArgs e) { if (SailHesban.BackgroundColor == Color.White) { Constantce.Area = "Sail Hesban"; Constantce.AreaLang = SailHesban.Text; SailHesban.TextColor = Color.White; SailHesban.BackgroundColor = Color.FromHex("#FF071D66"); var existingPages = Navigation.NavigationStack.ToList(); Page page = existingPages.FirstOrDefault(); Navigation.InsertPageBefore(new Home(), page); Navigation.RemovePage(page); await PopupNavigation.Instance.PopAsync(); } else { Constantce.Area = "Area"; SailHesban.BackgroundColor = Color.White; SailHesban.TextColor = Color.FromHex("#FF071D66"); } }
        async void Salem_Clicked(object sender, EventArgs e) { if (Salem.BackgroundColor == Color.White) { Constantce.Area = "Salem"; Constantce.AreaLang = Salem.Text; Salem.TextColor = Color.White; Salem.BackgroundColor = Color.FromHex("#FF071D66"); var existingPages = Navigation.NavigationStack.ToList(); Page page = existingPages.FirstOrDefault(); Navigation.InsertPageBefore(new Home(), page); Navigation.RemovePage(page); await PopupNavigation.Instance.PopAsync(); } else { Constantce.Area = "Area"; Salem.BackgroundColor = Color.White; Salem.TextColor = Color.FromHex("#FF071D66"); } }
        async void Salyeh_Clicked(object sender, EventArgs e) { if (Salyeh.BackgroundColor == Color.White) { Constantce.Area = "Salyeh"; Constantce.AreaLang = Salyeh.Text; Salyeh.TextColor = Color.White; Salyeh.BackgroundColor = Color.FromHex("#FF071D66"); var existingPages = Navigation.NavigationStack.ToList(); Page page = existingPages.FirstOrDefault(); Navigation.InsertPageBefore(new Home(), page); Navigation.RemovePage(page); await PopupNavigation.Instance.PopAsync(); } else { Constantce.Area = "Area"; Salyeh.BackgroundColor = Color.White; Salyeh.TextColor = Color.FromHex("#FF071D66"); } }
        async void Samek_Clicked(object sender, EventArgs e) { if (Samek.BackgroundColor == Color.White) { Constantce.Area = "Samek"; Constantce.AreaLang = Samek.Text; Samek.TextColor = Color.White; Samek.BackgroundColor = Color.FromHex("#FF071D66"); var existingPages = Navigation.NavigationStack.ToList(); Page page = existingPages.FirstOrDefault(); Navigation.InsertPageBefore(new Home(), page); Navigation.RemovePage(page); await PopupNavigation.Instance.PopAsync(); } else { Constantce.Area = "Area"; Samek.BackgroundColor = Color.White; Samek.TextColor = Color.FromHex("#FF071D66"); } }
        async void ShafaBadran_Clicked(object sender, EventArgs e) { if (ShafaBadran.BackgroundColor == Color.White) { Constantce.Area = "Shafa Badran"; Constantce.AreaLang = ShafaBadran.Text; ShafaBadran.TextColor = Color.White; ShafaBadran.BackgroundColor = Color.FromHex("#FF071D66"); var existingPages = Navigation.NavigationStack.ToList(); Page page = existingPages.FirstOrDefault(); Navigation.InsertPageBefore(new Home(), page); Navigation.RemovePage(page); await PopupNavigation.Instance.PopAsync(); } else { Constantce.Area = "Area"; ShafaBadran.BackgroundColor = Color.White; ShafaBadran.TextColor = Color.FromHex("#FF071D66"); } }
        async void Sweileh_Clicked(object sender, EventArgs e) { if (Sweileh.BackgroundColor == Color.White) { Constantce.Area = "Sweileh"; Constantce.AreaLang = Sweileh.Text; Sweileh.TextColor = Color.White; Sweileh.BackgroundColor = Color.FromHex("#FF071D66"); var existingPages = Navigation.NavigationStack.ToList(); Page page = existingPages.FirstOrDefault(); Navigation.InsertPageBefore(new Home(), page); Navigation.RemovePage(page); await PopupNavigation.Instance.PopAsync(); } else { Constantce.Area = "Area"; Sweileh.BackgroundColor = Color.White; Sweileh.TextColor = Color.FromHex("#FF071D66"); } }
        async void Tabaqa_Clicked(object sender, EventArgs e) { if (Tabaqa.BackgroundColor == Color.White) { Constantce.Area = "Tabaqa"; Constantce.AreaLang = Tabaqa.Text; Tabaqa.TextColor = Color.White; Tabaqa.BackgroundColor = Color.FromHex("#FF071D66"); var existingPages = Navigation.NavigationStack.ToList(); Page page = existingPages.FirstOrDefault(); Navigation.InsertPageBefore(new Home(), page); Navigation.RemovePage(page); await PopupNavigation.Instance.PopAsync(); } else { Constantce.Area = "Area"; Tabaqa.BackgroundColor = Color.White; Tabaqa.TextColor = Color.FromHex("#FF071D66"); } }
        async void Tharah_Clicked(object sender, EventArgs e) { if (Tharah.BackgroundColor == Color.White) { Constantce.Area = "Tharah"; Constantce.AreaLang = Tharah.Text; Tharah.TextColor = Color.White; Tharah.BackgroundColor = Color.FromHex("#FF071D66"); var existingPages = Navigation.NavigationStack.ToList(); Page page = existingPages.FirstOrDefault(); Navigation.InsertPageBefore(new Home(), page); Navigation.RemovePage(page); await PopupNavigation.Instance.PopAsync(); } else { Constantce.Area = "Area"; Tharah.BackgroundColor = Color.White; Tharah.TextColor = Color.FromHex("#FF071D66"); } }
        async void Thograh_Clicked(object sender, EventArgs e) { if (Thograh.BackgroundColor == Color.White) { Constantce.Area = "Thograh"; Constantce.AreaLang = Thograh.Text; Thograh.TextColor = Color.White; Thograh.BackgroundColor = Color.FromHex("#FF071D66"); var existingPages = Navigation.NavigationStack.ToList(); Page page = existingPages.FirstOrDefault(); Navigation.InsertPageBefore(new Home(), page); Navigation.RemovePage(page); await PopupNavigation.Instance.PopAsync(); } else { Constantce.Area = "Area"; Thograh.BackgroundColor = Color.White; Thograh.TextColor = Color.FromHex("#FF071D66"); } }
        async void Thrayya_Clicked(object sender, EventArgs e) { if (Thrayya.BackgroundColor == Color.White) { Constantce.Area = "Thrayya"; Constantce.AreaLang = Thrayya.Text; Thrayya.TextColor = Color.White; Thrayya.BackgroundColor = Color.FromHex("#FF071D66"); var existingPages = Navigation.NavigationStack.ToList(); Page page = existingPages.FirstOrDefault(); Navigation.InsertPageBefore(new Home(), page); Navigation.RemovePage(page); await PopupNavigation.Instance.PopAsync(); } else { Constantce.Area = "Area"; Thrayya.BackgroundColor = Color.White; Thrayya.TextColor = Color.FromHex("#FF071D66"); } }
        async void ToarHashash_Clicked(object sender, EventArgs e) { if (ToarHashash.BackgroundColor == Color.White) { Constantce.Area = "Toar Hashash"; Constantce.AreaLang = ToarHashash.Text; ToarHashash.TextColor = Color.White; ToarHashash.BackgroundColor = Color.FromHex("#FF071D66"); var existingPages = Navigation.NavigationStack.ToList(); Page page = existingPages.FirstOrDefault(); Navigation.InsertPageBefore(new Home(), page); Navigation.RemovePage(page); await PopupNavigation.Instance.PopAsync(); } else { Constantce.Area = "Area"; ToarHashash.BackgroundColor = Color.White; ToarHashash.TextColor = Color.FromHex("#FF071D66"); } }
        async void Torky_Clicked(object sender, EventArgs e) { if (Torky.BackgroundColor == Color.White) { Constantce.Area = "Torky"; Constantce.AreaLang = Torky.Text; Torky.TextColor = Color.White; Torky.BackgroundColor = Color.FromHex("#FF071D66"); var existingPages = Navigation.NavigationStack.ToList(); Page page = existingPages.FirstOrDefault(); Navigation.InsertPageBefore(new Home(), page); Navigation.RemovePage(page); await PopupNavigation.Instance.PopAsync(); } else { Constantce.Area = "Area"; Torky.BackgroundColor = Color.White; Torky.TextColor = Color.FromHex("#FF071D66"); } }
        async void UmElBerak_Clicked(object sender, EventArgs e) { if (UmElBerak.BackgroundColor == Color.White) { Constantce.Area = "Um El - Berak"; Constantce.AreaLang = UmElBerak.Text; UmElBerak.TextColor = Color.White; UmElBerak.BackgroundColor = Color.FromHex("#FF071D66"); var existingPages = Navigation.NavigationStack.ToList(); Page page = existingPages.FirstOrDefault(); Navigation.InsertPageBefore(new Home(), page); Navigation.RemovePage(page); await PopupNavigation.Instance.PopAsync(); } else { Constantce.Area = "Area"; UmElBerak.BackgroundColor = Color.White; UmElBerak.TextColor = Color.FromHex("#FF071D66"); } }
        async void UmElKindam_Clicked(object sender, EventArgs e) { if (UmElKindam.BackgroundColor == Color.White) { Constantce.Area = "Um El - Kindam"; Constantce.AreaLang = UmElKindam.Text; UmElKindam.TextColor = Color.White; UmElKindam.BackgroundColor = Color.FromHex("#FF071D66"); var existingPages = Navigation.NavigationStack.ToList(); Page page = existingPages.FirstOrDefault(); Navigation.InsertPageBefore(new Home(), page); Navigation.RemovePage(page); await PopupNavigation.Instance.PopAsync(); } else { Constantce.Area = "Area"; UmElKindam.BackgroundColor = Color.White; UmElKindam.TextColor = Color.FromHex("#FF071D66"); } }
        async void UmmBotmah_Clicked(object sender, EventArgs e) { if (UmmBotmah.BackgroundColor == Color.White) { Constantce.Area = "Umm Botmah"; Constantce.AreaLang = UmmBotmah.Text; UmmBotmah.TextColor = Color.White; UmmBotmah.BackgroundColor = Color.FromHex("#FF071D66"); var existingPages = Navigation.NavigationStack.ToList(); Page page = existingPages.FirstOrDefault(); Navigation.InsertPageBefore(new Home(), page); Navigation.RemovePage(page); await PopupNavigation.Instance.PopAsync(); } else { Constantce.Area = "Area"; UmmBotmah.BackgroundColor = Color.White; UmmBotmah.TextColor = Color.FromHex("#FF071D66"); } }
        async void UmmElAsaker_Clicked(object sender, EventArgs e) { if (UmmElAsaker.BackgroundColor == Color.White) { Constantce.Area = "Umm El - Asaker"; Constantce.AreaLang = UmmElAsaker.Text; UmmElAsaker.TextColor = Color.White; UmmElAsaker.BackgroundColor = Color.FromHex("#FF071D66"); var existingPages = Navigation.NavigationStack.ToList(); Page page = existingPages.FirstOrDefault(); Navigation.InsertPageBefore(new Home(), page); Navigation.RemovePage(page); await PopupNavigation.Instance.PopAsync(); } else { Constantce.Area = "Area"; UmmElAsaker.BackgroundColor = Color.White; UmmElAsaker.TextColor = Color.FromHex("#FF071D66"); } }
        async void UmmElBasatien_Clicked(object sender, EventArgs e) { if (UmmElBasatien.BackgroundColor == Color.White) { Constantce.Area = "Umm El - Basatien"; Constantce.AreaLang = UmmElBasatien.Text; UmmElBasatien.TextColor = Color.White; UmmElBasatien.BackgroundColor = Color.FromHex("#FF071D66"); var existingPages = Navigation.NavigationStack.ToList(); Page page = existingPages.FirstOrDefault(); Navigation.InsertPageBefore(new Home(), page); Navigation.RemovePage(page); await PopupNavigation.Instance.PopAsync(); } else { Constantce.Area = "Area"; UmmElBasatien.BackgroundColor = Color.White; UmmElBasatien.TextColor = Color.FromHex("#FF071D66"); } }
        async void UmmEssommaq_Clicked(object sender, EventArgs e) { if (UmmEssommaq.BackgroundColor == Color.White) { Constantce.Area = "Umm Essommaq"; Constantce.AreaLang = UmmEssommaq.Text; UmmEssommaq.TextColor = Color.White; UmmEssommaq.BackgroundColor = Color.FromHex("#FF071D66"); var existingPages = Navigation.NavigationStack.ToList(); Page page = existingPages.FirstOrDefault(); Navigation.InsertPageBefore(new Home(), page); Navigation.RemovePage(page); await PopupNavigation.Instance.PopAsync(); } else { Constantce.Area = "Area"; UmmEssommaq.BackgroundColor = Color.White; UmmEssommaq.TextColor = Color.FromHex("#FF071D66"); } }
        async void UmmNjasa_Clicked(object sender, EventArgs e) { if (UmmNjasa.BackgroundColor == Color.White) { Constantce.Area = "Umm Njasa"; Constantce.AreaLang = UmmNjasa.Text; UmmNjasa.TextColor = Color.White; UmmNjasa.BackgroundColor = Color.FromHex("#FF071D66"); var existingPages = Navigation.NavigationStack.ToList(); Page page = existingPages.FirstOrDefault(); Navigation.InsertPageBefore(new Home(), page); Navigation.RemovePage(page); await PopupNavigation.Instance.PopAsync(); } else { Constantce.Area = "Area"; UmmNjasa.BackgroundColor = Color.White; UmmNjasa.TextColor = Color.FromHex("#FF071D66"); } }
        async void UmmRsas_Clicked(object sender, EventArgs e) { if (UmmRsas.BackgroundColor == Color.White) { Constantce.Area = "Umm Rsas"; Constantce.AreaLang = UmmRsas.Text; UmmRsas.TextColor = Color.White; UmmRsas.BackgroundColor = Color.FromHex("#FF071D66"); var existingPages = Navigation.NavigationStack.ToList(); Page page = existingPages.FirstOrDefault(); Navigation.InsertPageBefore(new Home(), page); Navigation.RemovePage(page); await PopupNavigation.Instance.PopAsync(); } else { Constantce.Area = "Area"; UmmRsas.BackgroundColor = Color.White; UmmRsas.TextColor = Color.FromHex("#FF071D66"); } }
        async void WadiEshta_Clicked(object sender, EventArgs e) { if (WadiEshta.BackgroundColor == Color.White) { Constantce.Area = "Wadi Eshta"; Constantce.AreaLang = WadiEshta.Text; WadiEshta.TextColor = Color.White; WadiEshta.BackgroundColor = Color.FromHex("#FF071D66"); var existingPages = Navigation.NavigationStack.ToList(); Page page = existingPages.FirstOrDefault(); Navigation.InsertPageBefore(new Home(), page); Navigation.RemovePage(page); await PopupNavigation.Instance.PopAsync(); } else { Constantce.Area = "Area"; WadiEshta.BackgroundColor = Color.White; WadiEshta.TextColor = Color.FromHex("#FF071D66"); } }
        async void WadiEssier_Clicked(object sender, EventArgs e) { if (WadiEssier.BackgroundColor == Color.White) { Constantce.Area = "Wadi Essier"; Constantce.AreaLang = WadiEssier.Text; WadiEssier.TextColor = Color.White; WadiEssier.BackgroundColor = Color.FromHex("#FF071D66"); var existingPages = Navigation.NavigationStack.ToList(); Page page = existingPages.FirstOrDefault(); Navigation.InsertPageBefore(new Home(), page); Navigation.RemovePage(page); await PopupNavigation.Instance.PopAsync(); } else { Constantce.Area = "Area"; WadiEssier.BackgroundColor = Color.White; WadiEssier.TextColor = Color.FromHex("#FF071D66"); } }
        async void Yahoon_Clicked(object sender, EventArgs e) { if (Yahoon.BackgroundColor == Color.White) { Constantce.Area = "Yahoon"; Constantce.AreaLang = Yahoon.Text; Yahoon.TextColor = Color.White; Yahoon.BackgroundColor = Color.FromHex("#FF071D66"); var existingPages = Navigation.NavigationStack.ToList(); Page page = existingPages.FirstOrDefault(); Navigation.InsertPageBefore(new Home(), page); Navigation.RemovePage(page); await PopupNavigation.Instance.PopAsync(); } else { Constantce.Area = "Area"; Yahoon.BackgroundColor = Color.White; Yahoon.TextColor = Color.FromHex("#FF071D66"); } }
        async void Zbood_Clicked(object sender, EventArgs e) { if (Zbood.BackgroundColor == Color.White) { Constantce.Area = "Zbood"; Constantce.AreaLang = Zbood.Text; Zbood.TextColor = Color.White; Zbood.BackgroundColor = Color.FromHex("#FF071D66"); var existingPages = Navigation.NavigationStack.ToList(); Page page = existingPages.FirstOrDefault(); Navigation.InsertPageBefore(new Home(), page); Navigation.RemovePage(page); await PopupNavigation.Instance.PopAsync(); } else { Constantce.Area = "Area"; Zbood.BackgroundColor = Color.White; Zbood.TextColor = Color.FromHex("#FF071D66"); } }
        async void Zmailat_Clicked(object sender, EventArgs e) { if (Zmailat.BackgroundColor == Color.White) { Constantce.Area = "Zmailat"; Constantce.AreaLang = Zmailat.Text; Zmailat.TextColor = Color.White; Zmailat.BackgroundColor = Color.FromHex("#FF071D66"); var existingPages = Navigation.NavigationStack.ToList(); Page page = existingPages.FirstOrDefault(); Navigation.InsertPageBefore(new Home(), page); Navigation.RemovePage(page); await PopupNavigation.Instance.PopAsync(); } else { Constantce.Area = "Area"; Zmailat.BackgroundColor = Color.White; Zmailat.TextColor = Color.FromHex("#FF071D66"); } }
        async void Zmaileh_Clicked(object sender, EventArgs e) { if (Zmaileh.BackgroundColor == Color.White) { Constantce.Area = "Zmaileh"; Constantce.AreaLang = Zmaileh.Text; Zmaileh.TextColor = Color.White; Zmaileh.BackgroundColor = Color.FromHex("#FF071D66"); var existingPages = Navigation.NavigationStack.ToList(); Page page = existingPages.FirstOrDefault(); Navigation.InsertPageBefore(new Home(), page); Navigation.RemovePage(page); await PopupNavigation.Instance.PopAsync(); } else { Constantce.Area = "Area"; Zmaileh.BackgroundColor = Color.White; Zmaileh.TextColor = Color.FromHex("#FF071D66"); } }


    }
}