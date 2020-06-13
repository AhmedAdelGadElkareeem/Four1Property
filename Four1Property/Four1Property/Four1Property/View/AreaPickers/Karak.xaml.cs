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
    public partial class Karak : PopupPage
    {
        public Karak()
        {
            InitializeComponent();

            if (Application.Current.Properties["Language"].ToString() == "Arabic")
            {
                this.FlowDirection = FlowDirection.RightToLeft;
                UpText.Text = "الرجاء اختيار المنطقة";

                Abdaliyyeh.Text = "العبدليه";
                AbuTrabah.Text = "ابو ترابه";
                Ader.Text = "ادر";
                Adnaniyyeh.Text = "العدنانيه";
                Aina.Text = "العينا";
                Ainoon.Text = "عينون";
                Alyeh.Text = "العاليه";
                Amra.Text = "امرع";
                Ayy.Text = "عي";
                Azezieh.Text = "العزيزيه";
                Baqea.Text = "البقيع";
                Barada.Text = "بردى";
                Bathan.Text = "بذان";
                Battier.Text = "بتير";
                BlaidetAlmazraa.Text = "بليدة المزرعة";
                BlaidetHadiethah.Text = "بليدة الحديثة";
                Dabbakeh.Text = "الدباكه";
                Dabebeh.Text = "الدبه";
                Dahriyyeh.Text = "الظاهرية";
                Demnah.Text = "دمنه";
                Ejhara.Text = "اجحرا";
                Eraq.Text = "العراق";
                Faisaliyyeh.Text = "الفيصليه";
                Faqoe.Text = "فقوع";
                GhawrAlMazraa.Text = "غور المزرعة";
                GhawrashShafi.Text = "غور الصافي";
                GhawrAssal.Text = "غور عسال";
                GhawrDra.Text = "غور الذراع";
                GhawrFaifa.Text = "غور فيفا";
                GhawrHadiethah.Text = "غور الحديثة";
                Ghwair.Text = "الغوير";
                Gwiebeh.Text = "الغويبة";
                Hadbeh.Text = "الحدبه";
                Hamediyyeh.Text = "الحامديه";
                Hartheyyeh.Text = "الحارثيه";
                HashemiyyehJanoobiyyeh.Text = "الهاشميه الجنوبيه";
                Hmood.Text = "حمود";
                Houyeh.Text = "الحويه";
                Isawaiyyeh.Text = "العيسويه";
                Jada.Text = "الجدعا";
                Jadiedh.Text = "الجديده";
                Joza.Text = "جوزا";
                Jozeh.Text = "الجوزه";
                Jwair.Text = "جوير";
                Kaderiyyeh.Text = "القادرية";
                Kamnah.Text = "كمنه";
                Kathrabba.Text = "كثربا";
                Kerak.Text = "الكرك";
                Khaldiyyeh.Text = "الخالديه";
                Lajoon.Text = "اللجون";
                Mahmodeyeh.Text = "المحموديه";
                Majdoleen.Text = "مجدولين";
                Majra.Text = "مجرا";
                Mamooniyyeh.Text = "الماْمونيه";
                Mamorah.Text = "المعمورة";
                ManshiyyetAbuHammoor.Text = "منشية ابو حمور";
                ManshiyyetElMazar.Text = "منشية المزار";
                MazarJanoobee.Text = "المزار الجنوبي";
                Median.Text = "مدين";
                Merwed.Text = "مرود";
                Mesar.Text = "مسعر";
                Mghayyer.Text = "مغير";
                Mhiyy.Text = "محي";
                Mjaidel.Text = "مجيدل";
                Moomia.Text = "موميا";
                Mowjeb.Text = "الموجب";
                Mraighah.Text = "المريغه";
                Mshairfeh.Text = "المشيرفه";
                Mutah.Text = "مؤتة";
                Noaymeh.Text = "النعيمة";
                Omariyyeh.Text = "العمريه";
                Omqah.Text = "العمقه";
                Qasr.Text = "القصر";
                Qatraneh.Text = "القطرانة";
                Qraifleh.Text = "قريفله";
                Rabbah.Text = "الربه";
                Rakeen.Text = "راكين";
                Rashadeih.Text = "الرشايده";
                Rashdiyyeh.Text = "الراشديه";
                Rawdah.Text = "الروضه";
                Riha.Text = "ريحا";
                SadElSoltani.Text = "سد السلطاني";
                Sakka.Text = "سكا";
                Salhiyyeh.Text = "الصالحيه";
                Salmani.Text = "السلماني";
                Samra.Text = "سمرا";
                Serfa.Text = "صرفا";
                shahtoor.Text = "شحتور";
                Shariefeh.Text = "الشريفة";
                Sheehan.Text = "شيحان";
                Shehabiyyeh.Text = "الشهابيه";
                ShqairaElGharbiyyeh.Text = "شقيرا الغربيه";
                ShqairaElSharqiyyeh.Text = "شقيرا الشرقيه";
                Smakiyyeh.Text = "السماكيه";
                Sool.Text = "سول";
                Talbiyyeh.Text = "الطالبية";
                Tayybeh.Text = "الطيبه";
                Thaniyyeh.Text = "الثنيه";
                ThatRas.Text = "ذات راس";
                UmmElGhozlan.Text = "ام الغزلان";
                UmmElKhanazeer.Text = "ام الخنازير";
                UmmEllYanabie.Text = "ام الينابيع";
                UmmHamat.Text = "ام حماط";
                UmmRommaneh.Text = "ام رمانه";
                WadiAbyadh.Text = "الوادي الابيض";
                WadiIbinHamad.Text = "وادي ابن حماد";
                Waseiyeh.Text = "الوسيه";
                Yaroot.Text = "الياروت";
                Zaghairiyyeh.Text = "الزغريه";
                Zahoom.Text = "زحوم";
                Zahra.Text = "الزهراء";
            }
            else
            {
                this.FlowDirection = FlowDirection.LeftToRight;
                UpText.Text = "Please Select Area";

                Abdaliyyeh.Text = "Abdaliyyeh";
                AbuTrabah.Text = "Abu Trabah";
                Ader.Text = "Ader";
                Adnaniyyeh.Text = "Adnaniyyeh";
                Aina.Text = "Aina";
                Ainoon.Text = "Ainoon";
                Alyeh.Text = "Alyeh";
                Amra.Text = "Amra'";
                Ayy.Text = "Ayy";
                Azezieh.Text = "Azezieh";
                Baqea.Text = "Baqea";
                Barada.Text = "Barada";
                Bathan.Text = "Bathan";
                Battier.Text = "Battier";
                BlaidetAlmazraa.Text = "Blaidet Almazra'a";
                BlaidetHadiethah.Text = "Blaidet Hadiethah";
                Dabbakeh.Text = "Dabbakeh";
                Dabebeh.Text = "Dabbeh";
                Dahriyyeh.Text = "Dahriyyeh";
                Demnah.Text = "Demnah";
                Ejhara.Text = "Ejhara";
                Eraq.Text = "Eraq";
                Faisaliyyeh.Text = "Faisaliyyeh";
                Faqoe.Text = "Faqo'e";
                GhawrAlMazraa.Text = "Ghawr Al - Mazra'a";
                GhawrashShafi.Text = "Ghawr ash - Shafi";
                GhawrAssal.Text = "Ghawr Assal";
                GhawrDra.Text = "Ghawr Dra'";
                GhawrFaifa.Text = "Ghawr Faifa";
                GhawrHadiethah.Text = "Ghawr Hadiethah";
                Ghwair.Text = "Ghwair";
                Gwiebeh.Text = "Gwiebeh";
                Hadbeh.Text = "Hadbeh";
                Hamediyyeh.Text = "Hamediyyeh";
                Hartheyyeh.Text = "Hartheyyeh";
                HashemiyyehJanoobiyyeh.Text = "Hashemiyyeh Janoobiyyeh";
                Hmood.Text = "Hmood";
                Houyeh.Text = "Houyeh";
                Isawaiyyeh.Text = "Isawaiyyeh";
                Jada.Text = "Jada";
                Jadiedh.Text = "Jadiedh";
                Joza.Text = "Joza";
                Jozeh.Text = "Jozeh";
                Jwair.Text = "Jwair";
                Kaderiyyeh.Text = "Kaderiyyeh";
                Kamnah.Text = "Kamnah";
                Kathrabba.Text = "Kathrabba";
                Kerak.Text = "Kerak";
                Khaldiyyeh.Text = "Khaldiyyeh";
                Lajoon.Text = "Lajoon";
                Mahmodeyeh.Text = "Mahmodeyeh";
                Majdoleen.Text = "Majdoleen";
                Majra.Text = "Majra";
                Mamooniyyeh.Text = "Ma'mooniyyeh";
                Mamorah.Text = "Mamorah";
                ManshiyyetAbuHammoor.Text = "Manshiyyet Abu Hammoor";
                ManshiyyetElMazar.Text = "Manshiyyet El - Mazar";
                MazarJanoobee.Text = "Mazar Janoobee";
                Median.Text = "Median";
                Merwed.Text = "Merwed";
                Mesar.Text = "Mes'ar";
                Mghayyer.Text = "Mghayyer";
                Mhiyy.Text = "Mhiyy";
                Mjaidel.Text = "Mjaidel";
                Moomia.Text = "Moomia";
                Mowjeb.Text = "Mowjeb";
                Mraighah.Text = "Mraighah";
                Mshairfeh.Text = "Mshairfeh";
                Mutah.Text = "Mu'tah";
                Noaymeh.Text = "No'aymeh";
                Omariyyeh.Text = "Omariyyeh";
                Omqah.Text = "Omqah";
                Qasr.Text = "Qasr";
                Qatraneh.Text = "Qatraneh";
                Qraifleh.Text = "Qraifleh";
                Rabbah.Text = "Rabbah";
                Rakeen.Text = "Rakeen";
                Rashadeih.Text = "Rashadeih";
                Rashdiyyeh.Text = "Rashdiyyeh";
                Rawdah.Text = "Rawdah";
                Riha.Text = "Riha";
                SadElSoltani.Text = "Sad El - Soltani";
                Sakka.Text = "Sakka";
                Salhiyyeh.Text = "Salhiyyeh";
                Salmani.Text = "Salmani";
                Samra.Text = "Samra";
                Serfa.Text = "Serfa";
                shahtoor.Text = "shahtoor";
                Shariefeh.Text = "Shariefeh";
                Sheehan.Text = "Sheehan";
                Shehabiyyeh.Text = "Shehabiyyeh";
                ShqairaElGharbiyyeh.Text = "Shqaira El - Gharbiyyeh";
                ShqairaElSharqiyyeh.Text = "Shqaira El - Sharqiyyeh";
                Smakiyyeh.Text = "Smakiyyeh";
                Sool.Text = "Sool";
                Talbiyyeh.Text = "Talbiyyeh";
                Tayybeh.Text = "Tayybeh";
                Thaniyyeh.Text = "Thaniyyeh";
                ThatRas.Text = "That Ras";
                UmmElGhozlan.Text = "Umm El - Ghozlan";
                UmmElKhanazeer.Text = "Umm El - Khanazeer";
                UmmEllYanabie.Text = "Umm El - Yanabi'e";
                UmmHamat.Text = "Umm Hamat";
                UmmRommaneh.Text = "Umm Rommaneh";
                WadiAbyadh.Text = "Wadi Abyadh";
                WadiIbinHamad.Text = "Wadi Ibin Hamad";
                Waseiyeh.Text = "Waseiyeh";
                Yaroot.Text = "Yaroot";
                Zaghairiyyeh.Text = "Zaghairiyyeh";
                Zahoom.Text = "Zahoom";
                Zahra.Text = "Zahra";

            }
            if (Constantce.Area == "Abdaliyyeh") { Abdaliyyeh.BackgroundColor = Color.FromHex("#FF071D66"); Abdaliyyeh.TextColor = Color.White; }
            else if (Constantce.Area == "Abu Trabah") { AbuTrabah.BackgroundColor = Color.FromHex("#FF071D66"); AbuTrabah.TextColor = Color.White; }
            else if (Constantce.Area == "Ader") { Ader.BackgroundColor = Color.FromHex("#FF071D66"); Ader.TextColor = Color.White; }
            else if (Constantce.Area == "Adnaniyyeh") { Adnaniyyeh.BackgroundColor = Color.FromHex("#FF071D66"); Adnaniyyeh.TextColor = Color.White; }
            else if (Constantce.Area == "Aina") { Aina.BackgroundColor = Color.FromHex("#FF071D66"); Aina.TextColor = Color.White; }
            else if (Constantce.Area == "Ainoon") { Ainoon.BackgroundColor = Color.FromHex("#FF071D66"); Ainoon.TextColor = Color.White; }
            else if (Constantce.Area == "Alyeh") { Alyeh.BackgroundColor = Color.FromHex("#FF071D66"); Alyeh.TextColor = Color.White; }
            else if (Constantce.Area == "Amra'") { Amra.BackgroundColor = Color.FromHex("#FF071D66"); Amra.TextColor = Color.White; }
            else if (Constantce.Area == "Ayy") { Ayy.BackgroundColor = Color.FromHex("#FF071D66"); Ayy.TextColor = Color.White; }
            else if (Constantce.Area == "Azezieh") { Azezieh.BackgroundColor = Color.FromHex("#FF071D66"); Azezieh.TextColor = Color.White; }
            else if (Constantce.Area == "Baqea") { Baqea.BackgroundColor = Color.FromHex("#FF071D66"); Baqea.TextColor = Color.White; }
            else if (Constantce.Area == "Barada") { Barada.BackgroundColor = Color.FromHex("#FF071D66"); Barada.TextColor = Color.White; }
            else if (Constantce.Area == "Bathan") { Bathan.BackgroundColor = Color.FromHex("#FF071D66"); Bathan.TextColor = Color.White; }
            else if (Constantce.Area == "Battier") { Battier.BackgroundColor = Color.FromHex("#FF071D66"); Battier.TextColor = Color.White; }
            else if (Constantce.Area == "Blaidet Almazra'a") { BlaidetAlmazraa.BackgroundColor = Color.FromHex("#FF071D66"); BlaidetAlmazraa.TextColor = Color.White; }
            else if (Constantce.Area == "Blaidet Hadiethah") { BlaidetHadiethah.BackgroundColor = Color.FromHex("#FF071D66"); BlaidetHadiethah.TextColor = Color.White; }
            else if (Constantce.Area == "Dabbakeh") { Dabbakeh.BackgroundColor = Color.FromHex("#FF071D66"); Dabbakeh.TextColor = Color.White; }
            else if (Constantce.Area == "Dabbeh") { Dabebeh.BackgroundColor = Color.FromHex("#FF071D66"); Dabebeh.TextColor = Color.White; }
            else if (Constantce.Area == "Dahriyyeh") { Dahriyyeh.BackgroundColor = Color.FromHex("#FF071D66"); Dahriyyeh.TextColor = Color.White; }
            else if (Constantce.Area == "Demnah") { Demnah.BackgroundColor = Color.FromHex("#FF071D66"); Demnah.TextColor = Color.White; }
            else if (Constantce.Area == "Ejhara") { Ejhara.BackgroundColor = Color.FromHex("#FF071D66"); Ejhara.TextColor = Color.White; }
            else if (Constantce.Area == "Eraq") { Eraq.BackgroundColor = Color.FromHex("#FF071D66"); Eraq.TextColor = Color.White; }
            else if (Constantce.Area == "Faisaliyyeh") { Faisaliyyeh.BackgroundColor = Color.FromHex("#FF071D66"); Faisaliyyeh.TextColor = Color.White; }
            else if (Constantce.Area == "Faqo'e") { Faqoe.BackgroundColor = Color.FromHex("#FF071D66"); Faqoe.TextColor = Color.White; }
            else if (Constantce.Area == "Ghawr Al - Mazra'a") { GhawrAlMazraa.BackgroundColor = Color.FromHex("#FF071D66"); GhawrAlMazraa.TextColor = Color.White; }
            else if (Constantce.Area == "Ghawr ash - Shafi") { GhawrashShafi.BackgroundColor = Color.FromHex("#FF071D66"); GhawrashShafi.TextColor = Color.White; }
            else if (Constantce.Area == "Ghawr Assal") { GhawrAssal.BackgroundColor = Color.FromHex("#FF071D66"); GhawrAssal.TextColor = Color.White; }
            else if (Constantce.Area == "Ghawr Dra'") { GhawrDra.BackgroundColor = Color.FromHex("#FF071D66"); GhawrDra.TextColor = Color.White; }
            else if (Constantce.Area == "Ghawr Faifa") { GhawrFaifa.BackgroundColor = Color.FromHex("#FF071D66"); GhawrFaifa.TextColor = Color.White; }
            else if (Constantce.Area == "Ghawr Hadiethah") { GhawrHadiethah.BackgroundColor = Color.FromHex("#FF071D66"); GhawrHadiethah.TextColor = Color.White; }
            else if (Constantce.Area == "Ghwair") { Ghwair.BackgroundColor = Color.FromHex("#FF071D66"); Ghwair.TextColor = Color.White; }
            else if (Constantce.Area == "Gwiebeh") { Gwiebeh.BackgroundColor = Color.FromHex("#FF071D66"); Gwiebeh.TextColor = Color.White; }
            else if (Constantce.Area == "Hadbeh") { Hadbeh.BackgroundColor = Color.FromHex("#FF071D66"); Hadbeh.TextColor = Color.White; }
            else if (Constantce.Area == "Hamediyyeh") { Hamediyyeh.BackgroundColor = Color.FromHex("#FF071D66"); Hamediyyeh.TextColor = Color.White; }
            else if (Constantce.Area == "Hartheyyeh") { Hartheyyeh.BackgroundColor = Color.FromHex("#FF071D66"); Hartheyyeh.TextColor = Color.White; }
            else if (Constantce.Area == "Hashemiyyeh Janoobiyyeh") { HashemiyyehJanoobiyyeh.BackgroundColor = Color.FromHex("#FF071D66"); HashemiyyehJanoobiyyeh.TextColor = Color.White; }
            else if (Constantce.Area == "Hmood") { Hmood.BackgroundColor = Color.FromHex("#FF071D66"); Hmood.TextColor = Color.White; }
            else if (Constantce.Area == "Houyeh") { Houyeh.BackgroundColor = Color.FromHex("#FF071D66"); Houyeh.TextColor = Color.White; }
            else if (Constantce.Area == "Isawaiyyeh") { Isawaiyyeh.BackgroundColor = Color.FromHex("#FF071D66"); Isawaiyyeh.TextColor = Color.White; }
            else if (Constantce.Area == "Jada") { Jada.BackgroundColor = Color.FromHex("#FF071D66"); Jada.TextColor = Color.White; }
            else if (Constantce.Area == "Jadiedh") { Jadiedh.BackgroundColor = Color.FromHex("#FF071D66"); Jadiedh.TextColor = Color.White; }
            else if (Constantce.Area == "Joza") { Joza.BackgroundColor = Color.FromHex("#FF071D66"); Joza.TextColor = Color.White; }
            else if (Constantce.Area == "Jozeh") { Jozeh.BackgroundColor = Color.FromHex("#FF071D66"); Jozeh.TextColor = Color.White; }
            else if (Constantce.Area == "Jwair") { Jwair.BackgroundColor = Color.FromHex("#FF071D66"); Jwair.TextColor = Color.White; }
            else if (Constantce.Area == "Kaderiyyeh") { Kaderiyyeh.BackgroundColor = Color.FromHex("#FF071D66"); Kaderiyyeh.TextColor = Color.White; }
            else if (Constantce.Area == "Kamnah") { Kamnah.BackgroundColor = Color.FromHex("#FF071D66"); Kamnah.TextColor = Color.White; }
            else if (Constantce.Area == "Kathrabba") { Kathrabba.BackgroundColor = Color.FromHex("#FF071D66"); Kathrabba.TextColor = Color.White; }
            else if (Constantce.Area == "Kerak") { Kerak.BackgroundColor = Color.FromHex("#FF071D66"); Kerak.TextColor = Color.White; }
            else if (Constantce.Area == "Khaldiyyeh") { Khaldiyyeh.BackgroundColor = Color.FromHex("#FF071D66"); Khaldiyyeh.TextColor = Color.White; }
            else if (Constantce.Area == "Lajoon") { Lajoon.BackgroundColor = Color.FromHex("#FF071D66"); Lajoon.TextColor = Color.White; }
            else if (Constantce.Area == "Mahmodeyeh") { Mahmodeyeh.BackgroundColor = Color.FromHex("#FF071D66"); Mahmodeyeh.TextColor = Color.White; }
            else if (Constantce.Area == "Majdoleen") { Majdoleen.BackgroundColor = Color.FromHex("#FF071D66"); Majdoleen.TextColor = Color.White; }
            else if (Constantce.Area == "Majra") { Majra.BackgroundColor = Color.FromHex("#FF071D66"); Majra.TextColor = Color.White; }
            else if (Constantce.Area == "Ma'mooniyyeh") { Mamooniyyeh.BackgroundColor = Color.FromHex("#FF071D66"); Mamooniyyeh.TextColor = Color.White; }
            else if (Constantce.Area == "Mamorah") { Mamorah.BackgroundColor = Color.FromHex("#FF071D66"); Mamorah.TextColor = Color.White; }
            else if (Constantce.Area == "Manshiyyet Abu Hammoor") { ManshiyyetAbuHammoor.BackgroundColor = Color.FromHex("#FF071D66"); ManshiyyetAbuHammoor.TextColor = Color.White; }
            else if (Constantce.Area == "Manshiyyet El - Mazar") { ManshiyyetElMazar.BackgroundColor = Color.FromHex("#FF071D66"); ManshiyyetElMazar.TextColor = Color.White; }
            else if (Constantce.Area == "Mazar Janoobee") { MazarJanoobee.BackgroundColor = Color.FromHex("#FF071D66"); MazarJanoobee.TextColor = Color.White; }
            else if (Constantce.Area == "Median") { Median.BackgroundColor = Color.FromHex("#FF071D66"); Median.TextColor = Color.White; }
            else if (Constantce.Area == "Merwed") { Merwed.BackgroundColor = Color.FromHex("#FF071D66"); Merwed.TextColor = Color.White; }
            else if (Constantce.Area == "Mes'ar") { Mesar.BackgroundColor = Color.FromHex("#FF071D66"); Mesar.TextColor = Color.White; }
            else if (Constantce.Area == "Mghayyer") { Mghayyer.BackgroundColor = Color.FromHex("#FF071D66"); Mghayyer.TextColor = Color.White; }
            else if (Constantce.Area == "Mhiyy") { Mhiyy.BackgroundColor = Color.FromHex("#FF071D66"); Mhiyy.TextColor = Color.White; }
            else if (Constantce.Area == "Mjaidel") { Mjaidel.BackgroundColor = Color.FromHex("#FF071D66"); Mjaidel.TextColor = Color.White; }
            else if (Constantce.Area == "Moomia") { Moomia.BackgroundColor = Color.FromHex("#FF071D66"); Moomia.TextColor = Color.White; }
            else if (Constantce.Area == "Mowjeb") { Mowjeb.BackgroundColor = Color.FromHex("#FF071D66"); Mowjeb.TextColor = Color.White; }
            else if (Constantce.Area == "Mraighah") { Mraighah.BackgroundColor = Color.FromHex("#FF071D66"); Mraighah.TextColor = Color.White; }
            else if (Constantce.Area == "Mshairfeh") { Mshairfeh.BackgroundColor = Color.FromHex("#FF071D66"); Mshairfeh.TextColor = Color.White; }
            else if (Constantce.Area == "Mu'tah") { Mutah.BackgroundColor = Color.FromHex("#FF071D66"); Mutah.TextColor = Color.White; }
            else if (Constantce.Area == "No'aymeh") { Noaymeh.BackgroundColor = Color.FromHex("#FF071D66"); Noaymeh.TextColor = Color.White; }
            else if (Constantce.Area == "Omariyyeh") { Omariyyeh.BackgroundColor = Color.FromHex("#FF071D66"); Omariyyeh.TextColor = Color.White; }
            else if (Constantce.Area == "Omqah") { Omqah.BackgroundColor = Color.FromHex("#FF071D66"); Omqah.TextColor = Color.White; }
            else if (Constantce.Area == "Qasr") { Qasr.BackgroundColor = Color.FromHex("#FF071D66"); Qasr.TextColor = Color.White; }
            else if (Constantce.Area == "Qatraneh") { Qatraneh.BackgroundColor = Color.FromHex("#FF071D66"); Qatraneh.TextColor = Color.White; }
            else if (Constantce.Area == "Qraifleh") { Qraifleh.BackgroundColor = Color.FromHex("#FF071D66"); Qraifleh.TextColor = Color.White; }
            else if (Constantce.Area == "Rabbah") { Rabbah.BackgroundColor = Color.FromHex("#FF071D66"); Rabbah.TextColor = Color.White; }
            else if (Constantce.Area == "Rakeen") { Rakeen.BackgroundColor = Color.FromHex("#FF071D66"); Rakeen.TextColor = Color.White; }
            else if (Constantce.Area == "Rashadeih") { Rashadeih.BackgroundColor = Color.FromHex("#FF071D66"); Rashadeih.TextColor = Color.White; }
            else if (Constantce.Area == "Rashdiyyeh") { Rashdiyyeh.BackgroundColor = Color.FromHex("#FF071D66"); Rashdiyyeh.TextColor = Color.White; }
            else if (Constantce.Area == "Rawdah") { Rawdah.BackgroundColor = Color.FromHex("#FF071D66"); Rawdah.TextColor = Color.White; }
            else if (Constantce.Area == "Riha") { Riha.BackgroundColor = Color.FromHex("#FF071D66"); Riha.TextColor = Color.White; }
            else if (Constantce.Area == "Sad El - Soltani") { SadElSoltani.BackgroundColor = Color.FromHex("#FF071D66"); SadElSoltani.TextColor = Color.White; }
            else if (Constantce.Area == "Sakka") { Sakka.BackgroundColor = Color.FromHex("#FF071D66"); Sakka.TextColor = Color.White; }
            else if (Constantce.Area == "Salhiyyeh") { Salhiyyeh.BackgroundColor = Color.FromHex("#FF071D66"); Salhiyyeh.TextColor = Color.White; }
            else if (Constantce.Area == "Salmani") { Salmani.BackgroundColor = Color.FromHex("#FF071D66"); Salmani.TextColor = Color.White; }
            else if (Constantce.Area == "Samra") { Samra.BackgroundColor = Color.FromHex("#FF071D66"); Samra.TextColor = Color.White; }
            else if (Constantce.Area == "Serfa") { Serfa.BackgroundColor = Color.FromHex("#FF071D66"); Serfa.TextColor = Color.White; }
            else if (Constantce.Area == "shahtoor") { shahtoor.BackgroundColor = Color.FromHex("#FF071D66"); shahtoor.TextColor = Color.White; }
            else if (Constantce.Area == "Shariefeh") { Shariefeh.BackgroundColor = Color.FromHex("#FF071D66"); Shariefeh.TextColor = Color.White; }
            else if (Constantce.Area == "Sheehan") { Sheehan.BackgroundColor = Color.FromHex("#FF071D66"); Sheehan.TextColor = Color.White; }
            else if (Constantce.Area == "Shehabiyyeh") { Shehabiyyeh.BackgroundColor = Color.FromHex("#FF071D66"); Shehabiyyeh.TextColor = Color.White; }
            else if (Constantce.Area == "Shqaira El - Gharbiyyeh") { ShqairaElGharbiyyeh.BackgroundColor = Color.FromHex("#FF071D66"); ShqairaElGharbiyyeh.TextColor = Color.White; }
            else if (Constantce.Area == "Shqaira El - Sharqiyyeh") { ShqairaElSharqiyyeh.BackgroundColor = Color.FromHex("#FF071D66"); ShqairaElSharqiyyeh.TextColor = Color.White; }
            else if (Constantce.Area == "Smakiyyeh") { Smakiyyeh.BackgroundColor = Color.FromHex("#FF071D66"); Smakiyyeh.TextColor = Color.White; }
            else if (Constantce.Area == "Sool") { Sool.BackgroundColor = Color.FromHex("#FF071D66"); Sool.TextColor = Color.White; }
            else if (Constantce.Area == "Talbiyyeh") { Talbiyyeh.BackgroundColor = Color.FromHex("#FF071D66"); Talbiyyeh.TextColor = Color.White; }
            else if (Constantce.Area == "Tayybeh") { Tayybeh.BackgroundColor = Color.FromHex("#FF071D66"); Tayybeh.TextColor = Color.White; }
            else if (Constantce.Area == "Thaniyyeh") { Thaniyyeh.BackgroundColor = Color.FromHex("#FF071D66"); Thaniyyeh.TextColor = Color.White; }
            else if (Constantce.Area == "That Ras") { ThatRas.BackgroundColor = Color.FromHex("#FF071D66"); ThatRas.TextColor = Color.White; }
            else if (Constantce.Area == "Umm El - Ghozlan") { UmmElGhozlan.BackgroundColor = Color.FromHex("#FF071D66"); UmmElGhozlan.TextColor = Color.White; }
            else if (Constantce.Area == "Umm El - Khanazeer") { UmmElKhanazeer.BackgroundColor = Color.FromHex("#FF071D66"); UmmElKhanazeer.TextColor = Color.White; }
            else if (Constantce.Area == "Umm El - Yanabi'e") { UmmEllYanabie.BackgroundColor = Color.FromHex("#FF071D66"); UmmEllYanabie.TextColor = Color.White; }
            else if (Constantce.Area == "Umm Hamat") { UmmHamat.BackgroundColor = Color.FromHex("#FF071D66"); UmmHamat.TextColor = Color.White; }
            else if (Constantce.Area == "Umm Rommaneh") { UmmRommaneh.BackgroundColor = Color.FromHex("#FF071D66"); UmmRommaneh.TextColor = Color.White; }
            else if (Constantce.Area == "Wadi Abyadh") { WadiAbyadh.BackgroundColor = Color.FromHex("#FF071D66"); WadiAbyadh.TextColor = Color.White; }
            else if (Constantce.Area == "Wadi Ibin Hamad") { WadiIbinHamad.BackgroundColor = Color.FromHex("#FF071D66"); WadiIbinHamad.TextColor = Color.White; }
            else if (Constantce.Area == "Waseiyeh") { Waseiyeh.BackgroundColor = Color.FromHex("#FF071D66"); Waseiyeh.TextColor = Color.White; }
            else if (Constantce.Area == "Yaroot") { Yaroot.BackgroundColor = Color.FromHex("#FF071D66"); Yaroot.TextColor = Color.White; }
            else if (Constantce.Area == "Zaghairiyyeh") { Zaghairiyyeh.BackgroundColor = Color.FromHex("#FF071D66"); Zaghairiyyeh.TextColor = Color.White; }
            else if (Constantce.Area == "Zahoom") { Zahoom.BackgroundColor = Color.FromHex("#FF071D66"); Zahoom.TextColor = Color.White; }
            else if (Constantce.Area == "Zahra") { Zahra.BackgroundColor = Color.FromHex("#FF071D66"); Zahra.TextColor = Color.White; }





        }




        //******************************Start Alkarak Areas**********************************************************************

        async void Abdaliyyeh_Clicked(object sender, EventArgs e) { if (Abdaliyyeh.BackgroundColor == Color.White) { Constantce.Area = "Abdaliyyeh"; Constantce.AreaLang = Abdaliyyeh.Text; Abdaliyyeh.TextColor = Color.White; Abdaliyyeh.BackgroundColor = Color.FromHex("#FF071D66"); var existingPages = Navigation.NavigationStack.ToList();Page page = existingPages.FirstOrDefault();Navigation.InsertPageBefore(new Home(), page);Navigation.RemovePage(page);await PopupNavigation.Instance.PopAsync(); } else { Constantce.Area = "Area"; Abdaliyyeh.BackgroundColor = Color.White; Abdaliyyeh.TextColor = Color.FromHex("#FF071D66"); } }
        async void AbuTrabah_Clicked(object sender, EventArgs e) { if (AbuTrabah.BackgroundColor == Color.White) { Constantce.Area = "Abu Trabah"; Constantce.AreaLang = AbuTrabah.Text; AbuTrabah.TextColor = Color.White; AbuTrabah.BackgroundColor = Color.FromHex("#FF071D66"); var existingPages = Navigation.NavigationStack.ToList();Page page = existingPages.FirstOrDefault();Navigation.InsertPageBefore(new Home(), page);Navigation.RemovePage(page);await PopupNavigation.Instance.PopAsync(); } else { Constantce.Area = "Area"; AbuTrabah.BackgroundColor = Color.White; AbuTrabah.TextColor = Color.FromHex("#FF071D66"); } }
        async void Ader_Clicked(object sender, EventArgs e) { if (Ader.BackgroundColor == Color.White) { Constantce.Area = "Ader"; Constantce.AreaLang = Ader.Text; Ader.TextColor = Color.White; Ader.BackgroundColor = Color.FromHex("#FF071D66"); var existingPages = Navigation.NavigationStack.ToList();Page page = existingPages.FirstOrDefault();Navigation.InsertPageBefore(new Home(), page);Navigation.RemovePage(page);await PopupNavigation.Instance.PopAsync(); } else { Constantce.Area = "Area"; Ader.BackgroundColor = Color.White; Ader.TextColor = Color.FromHex("#FF071D66"); } }
        async void Adnaniyyeh_Clicked(object sender, EventArgs e) { if (Adnaniyyeh.BackgroundColor == Color.White) { Constantce.Area = "Adnaniyyeh"; Constantce.AreaLang = Adnaniyyeh.Text; Adnaniyyeh.TextColor = Color.White; Adnaniyyeh.BackgroundColor = Color.FromHex("#FF071D66"); var existingPages = Navigation.NavigationStack.ToList();Page page = existingPages.FirstOrDefault();Navigation.InsertPageBefore(new Home(), page);Navigation.RemovePage(page);await PopupNavigation.Instance.PopAsync(); } else { Constantce.Area = "Area"; Adnaniyyeh.BackgroundColor = Color.White; Adnaniyyeh.TextColor = Color.FromHex("#FF071D66"); } }
        async void Aina_Clicked(object sender, EventArgs e) { if (Aina.BackgroundColor == Color.White) { Constantce.Area = "Aina"; Constantce.AreaLang = Aina.Text; Aina.TextColor = Color.White; Aina.BackgroundColor = Color.FromHex("#FF071D66"); var existingPages = Navigation.NavigationStack.ToList();Page page = existingPages.FirstOrDefault();Navigation.InsertPageBefore(new Home(), page);Navigation.RemovePage(page);await PopupNavigation.Instance.PopAsync(); } else { Constantce.Area = "Area"; Aina.BackgroundColor = Color.White; Aina.TextColor = Color.FromHex("#FF071D66"); } }
        async void Ainoon_Clicked(object sender, EventArgs e) { if (Ainoon.BackgroundColor == Color.White) { Constantce.Area = "Ainoon"; Constantce.AreaLang = Ainoon.Text; Ainoon.TextColor = Color.White; Ainoon.BackgroundColor = Color.FromHex("#FF071D66"); var existingPages = Navigation.NavigationStack.ToList();Page page = existingPages.FirstOrDefault();Navigation.InsertPageBefore(new Home(), page);Navigation.RemovePage(page);await PopupNavigation.Instance.PopAsync(); } else { Constantce.Area = "Area"; Ainoon.BackgroundColor = Color.White; Ainoon.TextColor = Color.FromHex("#FF071D66"); } }
        async void Alyeh_Clicked(object sender, EventArgs e) { if (Alyeh.BackgroundColor == Color.White) { Constantce.Area = "Alyeh"; Constantce.AreaLang = Alyeh.Text; Alyeh.TextColor = Color.White; Alyeh.BackgroundColor = Color.FromHex("#FF071D66"); var existingPages = Navigation.NavigationStack.ToList();Page page = existingPages.FirstOrDefault();Navigation.InsertPageBefore(new Home(), page);Navigation.RemovePage(page);await PopupNavigation.Instance.PopAsync(); } else { Constantce.Area = "Area"; Alyeh.BackgroundColor = Color.White; Alyeh.TextColor = Color.FromHex("#FF071D66"); } }
        async void Amra_Clicked(object sender, EventArgs e){if (Amra.BackgroundColor == Color.White){Constantce.Area = "Amra'"; Constantce.AreaLang = Amra.Text; Amra.TextColor = Color.White; Amra.BackgroundColor = Color.FromHex("#FF071D66"); var existingPages = Navigation.NavigationStack.ToList(); await Navigation.PushAsync(new Home()); foreach (var page in existingPages) { Navigation.RemovePage(page); }await Task.Delay(80); await PopupNavigation.Instance.PopAsync();}else { Constantce.Area = "Area"; Amra.BackgroundColor = Color.White; Amra.TextColor = Color.FromHex("#FF071D66"); }}
        async void Ayy_Clicked(object sender, EventArgs e) { if (Ayy.BackgroundColor == Color.White) { Constantce.Area = "Ayy"; Constantce.AreaLang = Ayy.Text; Ayy.TextColor = Color.White; Ayy.BackgroundColor = Color.FromHex("#FF071D66"); var existingPages = Navigation.NavigationStack.ToList();Page page = existingPages.FirstOrDefault();Navigation.InsertPageBefore(new Home(), page);Navigation.RemovePage(page);await PopupNavigation.Instance.PopAsync(); } else { Constantce.Area = "Area"; Ayy.BackgroundColor = Color.White; Ayy.TextColor = Color.FromHex("#FF071D66"); } }
        async void Azezieh_Clicked(object sender, EventArgs e) { if (Azezieh.BackgroundColor == Color.White) { Constantce.Area = "Azezieh"; Constantce.AreaLang = Azezieh.Text; Azezieh.TextColor = Color.White; Azezieh.BackgroundColor = Color.FromHex("#FF071D66"); var existingPages = Navigation.NavigationStack.ToList();Page page = existingPages.FirstOrDefault();Navigation.InsertPageBefore(new Home(), page);Navigation.RemovePage(page);await PopupNavigation.Instance.PopAsync(); } else { Constantce.Area = "Area"; Azezieh.BackgroundColor = Color.White; Azezieh.TextColor = Color.FromHex("#FF071D66"); } }
        async void Baqea_Clicked(object sender, EventArgs e) { if (Baqea.BackgroundColor == Color.White) { Constantce.Area = "Baqea"; Constantce.AreaLang = Baqea.Text; Baqea.TextColor = Color.White; Baqea.BackgroundColor = Color.FromHex("#FF071D66"); var existingPages = Navigation.NavigationStack.ToList();Page page = existingPages.FirstOrDefault();Navigation.InsertPageBefore(new Home(), page);Navigation.RemovePage(page);await PopupNavigation.Instance.PopAsync(); } else { Constantce.Area = "Area"; Baqea.BackgroundColor = Color.White; Baqea.TextColor = Color.FromHex("#FF071D66"); } }
        async void Barada_Clicked(object sender, EventArgs e) { if (Barada.BackgroundColor == Color.White) { Constantce.Area = "Barada"; Constantce.AreaLang = Barada.Text; Barada.TextColor = Color.White; Barada.BackgroundColor = Color.FromHex("#FF071D66"); var existingPages = Navigation.NavigationStack.ToList();Page page = existingPages.FirstOrDefault();Navigation.InsertPageBefore(new Home(), page);Navigation.RemovePage(page);await PopupNavigation.Instance.PopAsync(); } else { Constantce.Area = "Area"; Barada.BackgroundColor = Color.White; Barada.TextColor = Color.FromHex("#FF071D66"); } }
        async void Bathan_Clicked(object sender, EventArgs e) { if (Bathan.BackgroundColor == Color.White) { Constantce.Area = "Bathan"; Constantce.AreaLang = Bathan.Text; Bathan.TextColor = Color.White; Bathan.BackgroundColor = Color.FromHex("#FF071D66"); var existingPages = Navigation.NavigationStack.ToList();Page page = existingPages.FirstOrDefault();Navigation.InsertPageBefore(new Home(), page);Navigation.RemovePage(page);await PopupNavigation.Instance.PopAsync(); } else { Constantce.Area = "Area"; Bathan.BackgroundColor = Color.White; Bathan.TextColor = Color.FromHex("#FF071D66"); } }
        async void Battier_Clicked(object sender, EventArgs e) { if (Battier.BackgroundColor == Color.White) { Constantce.Area = "Battier"; Constantce.AreaLang = Battier.Text; Battier.TextColor = Color.White; Battier.BackgroundColor = Color.FromHex("#FF071D66"); var existingPages = Navigation.NavigationStack.ToList();Page page = existingPages.FirstOrDefault();Navigation.InsertPageBefore(new Home(), page);Navigation.RemovePage(page);await PopupNavigation.Instance.PopAsync(); } else { Constantce.Area = "Area"; Battier.BackgroundColor = Color.White; Battier.TextColor = Color.FromHex("#FF071D66"); } }
        async void BlaidetAlmazraa_Clicked(object sender, EventArgs e){if (BlaidetAlmazraa.BackgroundColor == Color.White){Constantce.Area = "Blaidet Almazra'a"; Constantce.AreaLang = BlaidetAlmazraa.Text; BlaidetAlmazraa.TextColor = Color.White; BlaidetAlmazraa.BackgroundColor = Color.FromHex("#FF071D66"); var existingPages = Navigation.NavigationStack.ToList(); await Navigation.PushAsync(new Home()); foreach (var page in existingPages) { Navigation.RemovePage(page); }await Task.Delay(80); await PopupNavigation.Instance.PopAsync();}else { Constantce.Area = "Area"; BlaidetAlmazraa.BackgroundColor = Color.White; BlaidetAlmazraa.TextColor = Color.FromHex("#FF071D66"); }}
        async void BlaidetHadiethah_Clicked(object sender, EventArgs e) { if (BlaidetHadiethah.BackgroundColor == Color.White) { Constantce.Area = "Blaidet Hadiethah"; Constantce.AreaLang = BlaidetHadiethah.Text; BlaidetHadiethah.TextColor = Color.White; BlaidetHadiethah.BackgroundColor = Color.FromHex("#FF071D66"); var existingPages = Navigation.NavigationStack.ToList();Page page = existingPages.FirstOrDefault();Navigation.InsertPageBefore(new Home(), page);Navigation.RemovePage(page);await PopupNavigation.Instance.PopAsync(); } else { Constantce.Area = "Area"; BlaidetHadiethah.BackgroundColor = Color.White; BlaidetHadiethah.TextColor = Color.FromHex("#FF071D66"); } }
        async void Dabbakeh_Clicked(object sender, EventArgs e) { if (Dabbakeh.BackgroundColor == Color.White) { Constantce.Area = "Dabbakeh"; Constantce.AreaLang = Dabbakeh.Text; Dabbakeh.TextColor = Color.White; Dabbakeh.BackgroundColor = Color.FromHex("#FF071D66"); var existingPages = Navigation.NavigationStack.ToList();Page page = existingPages.FirstOrDefault();Navigation.InsertPageBefore(new Home(), page);Navigation.RemovePage(page);await PopupNavigation.Instance.PopAsync(); } else { Constantce.Area = "Area"; Dabbakeh.BackgroundColor = Color.White; Dabbakeh.TextColor = Color.FromHex("#FF071D66"); } }
        async void Dabebeh_Clicked(object sender, EventArgs e) { if (Dabebeh.BackgroundColor == Color.White) { Constantce.Area = "Dabbeh"; Constantce.AreaLang = Dabebeh.Text; Dabebeh.TextColor = Color.White; Dabebeh.BackgroundColor = Color.FromHex("#FF071D66"); var existingPages = Navigation.NavigationStack.ToList();Page page = existingPages.FirstOrDefault();Navigation.InsertPageBefore(new Home(), page);Navigation.RemovePage(page);await PopupNavigation.Instance.PopAsync(); } else { Constantce.Area = "Area"; Dabebeh.BackgroundColor = Color.White; Dabebeh.TextColor = Color.FromHex("#FF071D66"); } }
        async void Dahriyyeh_Clicked(object sender, EventArgs e) { if (Dahriyyeh.BackgroundColor == Color.White) { Constantce.Area = "Dahriyyeh"; Constantce.AreaLang = Dahriyyeh.Text; Dahriyyeh.TextColor = Color.White; Dahriyyeh.BackgroundColor = Color.FromHex("#FF071D66"); var existingPages = Navigation.NavigationStack.ToList();Page page = existingPages.FirstOrDefault();Navigation.InsertPageBefore(new Home(), page);Navigation.RemovePage(page);await PopupNavigation.Instance.PopAsync(); } else { Constantce.Area = "Area"; Dahriyyeh.BackgroundColor = Color.White; Dahriyyeh.TextColor = Color.FromHex("#FF071D66"); } }
        async void Demnah_Clicked(object sender, EventArgs e) { if (Demnah.BackgroundColor == Color.White) { Constantce.Area = "Demnah"; Constantce.AreaLang = Demnah.Text; Demnah.TextColor = Color.White; Demnah.BackgroundColor = Color.FromHex("#FF071D66"); var existingPages = Navigation.NavigationStack.ToList();Page page = existingPages.FirstOrDefault();Navigation.InsertPageBefore(new Home(), page);Navigation.RemovePage(page);await PopupNavigation.Instance.PopAsync(); } else { Constantce.Area = "Area"; Demnah.BackgroundColor = Color.White; Demnah.TextColor = Color.FromHex("#FF071D66"); } }
        async void Ejhara_Clicked(object sender, EventArgs e) { if (Ejhara.BackgroundColor == Color.White) { Constantce.Area = "Ejhara"; Constantce.AreaLang = Ejhara.Text; Ejhara.TextColor = Color.White; Ejhara.BackgroundColor = Color.FromHex("#FF071D66"); var existingPages = Navigation.NavigationStack.ToList();Page page = existingPages.FirstOrDefault();Navigation.InsertPageBefore(new Home(), page);Navigation.RemovePage(page);await PopupNavigation.Instance.PopAsync(); } else { Constantce.Area = "Area"; Ejhara.BackgroundColor = Color.White; Ejhara.TextColor = Color.FromHex("#FF071D66"); } }
        async void Eraq_Clicked(object sender, EventArgs e) { if (Eraq.BackgroundColor == Color.White) { Constantce.Area = "Eraq"; Constantce.AreaLang = Eraq.Text; Eraq.TextColor = Color.White; Eraq.BackgroundColor = Color.FromHex("#FF071D66"); var existingPages = Navigation.NavigationStack.ToList();Page page = existingPages.FirstOrDefault();Navigation.InsertPageBefore(new Home(), page);Navigation.RemovePage(page);await PopupNavigation.Instance.PopAsync(); } else { Constantce.Area = "Area"; Eraq.BackgroundColor = Color.White; Eraq.TextColor = Color.FromHex("#FF071D66"); } }
        async void Faisaliyyeh_Clicked(object sender, EventArgs e) { if (Faisaliyyeh.BackgroundColor == Color.White) { Constantce.Area = "Faisaliyyeh"; Constantce.AreaLang = Faisaliyyeh.Text; Faisaliyyeh.TextColor = Color.White; Faisaliyyeh.BackgroundColor = Color.FromHex("#FF071D66"); var existingPages = Navigation.NavigationStack.ToList();Page page = existingPages.FirstOrDefault();Navigation.InsertPageBefore(new Home(), page);Navigation.RemovePage(page);await PopupNavigation.Instance.PopAsync(); } else { Constantce.Area = "Area"; Faisaliyyeh.BackgroundColor = Color.White; Faisaliyyeh.TextColor = Color.FromHex("#FF071D66"); } }
        async void Faqoe_Clicked(object sender, EventArgs e){if (Faqoe.BackgroundColor == Color.White){Constantce.Area = "Faqo'e"; Constantce.AreaLang = Faqoe.Text; Faqoe.TextColor = Color.White; Faqoe.BackgroundColor = Color.FromHex("#FF071D66"); var existingPages = Navigation.NavigationStack.ToList(); await Navigation.PushAsync(new Home()); foreach (var page in existingPages) { Navigation.RemovePage(page); }await Task.Delay(80); await PopupNavigation.Instance.PopAsync();}else { Constantce.Area = "Area"; Faqoe.BackgroundColor = Color.White; Faqoe.TextColor = Color.FromHex("#FF071D66"); }}
        async void GhawrAlMazraa_Clicked(object sender, EventArgs e){if (GhawrAlMazraa.BackgroundColor == Color.White){Constantce.Area = "Ghawr Al - Mazra'a"; Constantce.AreaLang = GhawrAlMazraa.Text; GhawrAlMazraa.TextColor = Color.White; GhawrAlMazraa.BackgroundColor = Color.FromHex("#FF071D66"); var existingPages = Navigation.NavigationStack.ToList(); await Navigation.PushAsync(new Home()); foreach (var page in existingPages) { Navigation.RemovePage(page); }await Task.Delay(80); await PopupNavigation.Instance.PopAsync();}else { Constantce.Area = "Area"; GhawrAlMazraa.BackgroundColor = Color.White; GhawrAlMazraa.TextColor = Color.FromHex("#FF071D66"); }}
        async void GhawrashShafi_Clicked(object sender, EventArgs e) { if (GhawrashShafi.BackgroundColor == Color.White) { Constantce.Area = "Ghawr ash - Shafi"; Constantce.AreaLang = GhawrashShafi.Text; GhawrashShafi.TextColor = Color.White; GhawrashShafi.BackgroundColor = Color.FromHex("#FF071D66"); var existingPages = Navigation.NavigationStack.ToList();Page page = existingPages.FirstOrDefault();Navigation.InsertPageBefore(new Home(), page);Navigation.RemovePage(page);await PopupNavigation.Instance.PopAsync(); } else { Constantce.Area = "Area"; GhawrashShafi.BackgroundColor = Color.White; GhawrashShafi.TextColor = Color.FromHex("#FF071D66"); } }
        async void GhawrAssal_Clicked(object sender, EventArgs e) { if (GhawrAssal.BackgroundColor == Color.White) { Constantce.Area = "Ghawr Assal"; Constantce.AreaLang = GhawrAssal.Text; GhawrAssal.TextColor = Color.White; GhawrAssal.BackgroundColor = Color.FromHex("#FF071D66"); var existingPages = Navigation.NavigationStack.ToList();Page page = existingPages.FirstOrDefault();Navigation.InsertPageBefore(new Home(), page);Navigation.RemovePage(page);await PopupNavigation.Instance.PopAsync(); } else { Constantce.Area = "Area"; GhawrAssal.BackgroundColor = Color.White; GhawrAssal.TextColor = Color.FromHex("#FF071D66"); } }
        async void GhawrDra_Clicked(object sender, EventArgs e){if (GhawrDra.BackgroundColor == Color.White){Constantce.Area = "Ghawr Dra'"; Constantce.AreaLang = GhawrDra.Text; GhawrDra.TextColor = Color.White; GhawrDra.BackgroundColor = Color.FromHex("#FF071D66"); var existingPages = Navigation.NavigationStack.ToList(); await Navigation.PushAsync(new Home()); foreach (var page in existingPages) { Navigation.RemovePage(page); }await Task.Delay(80); await PopupNavigation.Instance.PopAsync();}else { Constantce.Area = "Area"; GhawrDra.BackgroundColor = Color.White; GhawrDra.TextColor = Color.FromHex("#FF071D66"); }}
        async void GhawrFaifa_Clicked(object sender, EventArgs e) { if (GhawrFaifa.BackgroundColor == Color.White) { Constantce.Area = "Ghawr Faifa"; Constantce.AreaLang = GhawrFaifa.Text; GhawrFaifa.TextColor = Color.White; GhawrFaifa.BackgroundColor = Color.FromHex("#FF071D66"); var existingPages = Navigation.NavigationStack.ToList();Page page = existingPages.FirstOrDefault();Navigation.InsertPageBefore(new Home(), page);Navigation.RemovePage(page);await PopupNavigation.Instance.PopAsync(); } else { Constantce.Area = "Area"; GhawrFaifa.BackgroundColor = Color.White; GhawrFaifa.TextColor = Color.FromHex("#FF071D66"); } }
        async void GhawrHadiethah_Clicked(object sender, EventArgs e) { if (GhawrHadiethah.BackgroundColor == Color.White) { Constantce.Area = "Ghawr Hadiethah"; Constantce.AreaLang = GhawrHadiethah.Text; GhawrHadiethah.TextColor = Color.White; GhawrHadiethah.BackgroundColor = Color.FromHex("#FF071D66"); var existingPages = Navigation.NavigationStack.ToList();Page page = existingPages.FirstOrDefault();Navigation.InsertPageBefore(new Home(), page);Navigation.RemovePage(page);await PopupNavigation.Instance.PopAsync(); } else { Constantce.Area = "Area"; GhawrHadiethah.BackgroundColor = Color.White; GhawrHadiethah.TextColor = Color.FromHex("#FF071D66"); } }
        async void Ghwair_Clicked(object sender, EventArgs e) { if (Ghwair.BackgroundColor == Color.White) { Constantce.Area = "Ghwair"; Constantce.AreaLang = Ghwair.Text; Ghwair.TextColor = Color.White; Ghwair.BackgroundColor = Color.FromHex("#FF071D66"); var existingPages = Navigation.NavigationStack.ToList();Page page = existingPages.FirstOrDefault();Navigation.InsertPageBefore(new Home(), page);Navigation.RemovePage(page);await PopupNavigation.Instance.PopAsync(); } else { Constantce.Area = "Area"; Ghwair.BackgroundColor = Color.White; Ghwair.TextColor = Color.FromHex("#FF071D66"); } }
        async void Gwiebeh_Clicked(object sender, EventArgs e) { if (Gwiebeh.BackgroundColor == Color.White) { Constantce.Area = "Gwiebeh"; Constantce.AreaLang = Gwiebeh.Text; Gwiebeh.TextColor = Color.White; Gwiebeh.BackgroundColor = Color.FromHex("#FF071D66"); var existingPages = Navigation.NavigationStack.ToList();Page page = existingPages.FirstOrDefault();Navigation.InsertPageBefore(new Home(), page);Navigation.RemovePage(page);await PopupNavigation.Instance.PopAsync(); } else { Constantce.Area = "Area"; Gwiebeh.BackgroundColor = Color.White; Gwiebeh.TextColor = Color.FromHex("#FF071D66"); } }
        async void Hadbeh_Clicked(object sender, EventArgs e) { if (Hadbeh.BackgroundColor == Color.White) { Constantce.Area = "Hadbeh"; Constantce.AreaLang = Hadbeh.Text; Hadbeh.TextColor = Color.White; Hadbeh.BackgroundColor = Color.FromHex("#FF071D66"); var existingPages = Navigation.NavigationStack.ToList();Page page = existingPages.FirstOrDefault();Navigation.InsertPageBefore(new Home(), page);Navigation.RemovePage(page);await PopupNavigation.Instance.PopAsync(); } else { Constantce.Area = "Area"; Hadbeh.BackgroundColor = Color.White; Hadbeh.TextColor = Color.FromHex("#FF071D66"); } }
        async void Hamediyyeh_Clicked(object sender, EventArgs e) { if (Hamediyyeh.BackgroundColor == Color.White) { Constantce.Area = "Hamediyyeh"; Constantce.AreaLang = Hamediyyeh.Text; Hamediyyeh.TextColor = Color.White; Hamediyyeh.BackgroundColor = Color.FromHex("#FF071D66"); var existingPages = Navigation.NavigationStack.ToList();Page page = existingPages.FirstOrDefault();Navigation.InsertPageBefore(new Home(), page);Navigation.RemovePage(page);await PopupNavigation.Instance.PopAsync(); } else { Constantce.Area = "Area"; Hamediyyeh.BackgroundColor = Color.White; Hamediyyeh.TextColor = Color.FromHex("#FF071D66"); } }
        async void Hartheyyeh_Clicked(object sender, EventArgs e) { if (Hartheyyeh.BackgroundColor == Color.White) { Constantce.Area = "Hartheyyeh"; Constantce.AreaLang = Hartheyyeh.Text; Hartheyyeh.TextColor = Color.White; Hartheyyeh.BackgroundColor = Color.FromHex("#FF071D66"); var existingPages = Navigation.NavigationStack.ToList();Page page = existingPages.FirstOrDefault();Navigation.InsertPageBefore(new Home(), page);Navigation.RemovePage(page);await PopupNavigation.Instance.PopAsync(); } else { Constantce.Area = "Area"; Hartheyyeh.BackgroundColor = Color.White; Hartheyyeh.TextColor = Color.FromHex("#FF071D66"); } }
        async void HashemiyyehJanoobiyyeh_Clicked(object sender, EventArgs e) { if (HashemiyyehJanoobiyyeh.BackgroundColor == Color.White) { Constantce.Area = "Hashemiyyeh Janoobiyyeh"; Constantce.AreaLang = HashemiyyehJanoobiyyeh.Text; HashemiyyehJanoobiyyeh.TextColor = Color.White; HashemiyyehJanoobiyyeh.BackgroundColor = Color.FromHex("#FF071D66"); var existingPages = Navigation.NavigationStack.ToList();Page page = existingPages.FirstOrDefault();Navigation.InsertPageBefore(new Home(), page);Navigation.RemovePage(page);await PopupNavigation.Instance.PopAsync(); } else { Constantce.Area = "Area"; HashemiyyehJanoobiyyeh.BackgroundColor = Color.White; HashemiyyehJanoobiyyeh.TextColor = Color.FromHex("#FF071D66"); } }
        async void Hmood_Clicked(object sender, EventArgs e) { if (Hmood.BackgroundColor == Color.White) { Constantce.Area = "Hmood"; Constantce.AreaLang = Hmood.Text; Hmood.TextColor = Color.White; Hmood.BackgroundColor = Color.FromHex("#FF071D66"); var existingPages = Navigation.NavigationStack.ToList();Page page = existingPages.FirstOrDefault();Navigation.InsertPageBefore(new Home(), page);Navigation.RemovePage(page);await PopupNavigation.Instance.PopAsync(); } else { Constantce.Area = "Area"; Hmood.BackgroundColor = Color.White; Hmood.TextColor = Color.FromHex("#FF071D66"); } }
        async void Houyeh_Clicked(object sender, EventArgs e) { if (Houyeh.BackgroundColor == Color.White) { Constantce.Area = "Houyeh"; Constantce.AreaLang = Houyeh.Text; Houyeh.TextColor = Color.White; Houyeh.BackgroundColor = Color.FromHex("#FF071D66"); var existingPages = Navigation.NavigationStack.ToList();Page page = existingPages.FirstOrDefault();Navigation.InsertPageBefore(new Home(), page);Navigation.RemovePage(page);await PopupNavigation.Instance.PopAsync(); } else { Constantce.Area = "Area"; Houyeh.BackgroundColor = Color.White; Houyeh.TextColor = Color.FromHex("#FF071D66"); } }
        async void Isawaiyyeh_Clicked(object sender, EventArgs e) { if (Isawaiyyeh.BackgroundColor == Color.White) { Constantce.Area = "Isawaiyyeh"; Constantce.AreaLang = Isawaiyyeh.Text; Isawaiyyeh.TextColor = Color.White; Isawaiyyeh.BackgroundColor = Color.FromHex("#FF071D66"); var existingPages = Navigation.NavigationStack.ToList();Page page = existingPages.FirstOrDefault();Navigation.InsertPageBefore(new Home(), page);Navigation.RemovePage(page);await PopupNavigation.Instance.PopAsync(); } else { Constantce.Area = "Area"; Isawaiyyeh.BackgroundColor = Color.White; Isawaiyyeh.TextColor = Color.FromHex("#FF071D66"); } }
        async void Jada_Clicked(object sender, EventArgs e) { if (Jada.BackgroundColor == Color.White) { Constantce.Area = "Jada"; Constantce.AreaLang = Jada.Text; Jada.TextColor = Color.White; Jada.BackgroundColor = Color.FromHex("#FF071D66"); var existingPages = Navigation.NavigationStack.ToList();Page page = existingPages.FirstOrDefault();Navigation.InsertPageBefore(new Home(), page);Navigation.RemovePage(page);await PopupNavigation.Instance.PopAsync(); } else { Constantce.Area = "Area"; Jada.BackgroundColor = Color.White; Jada.TextColor = Color.FromHex("#FF071D66"); } }
        async void Jadiedh_Clicked(object sender, EventArgs e) { if (Jadiedh.BackgroundColor == Color.White) { Constantce.Area = "Jadiedh"; Constantce.AreaLang = Jadiedh.Text; Jadiedh.TextColor = Color.White; Jadiedh.BackgroundColor = Color.FromHex("#FF071D66"); var existingPages = Navigation.NavigationStack.ToList();Page page = existingPages.FirstOrDefault();Navigation.InsertPageBefore(new Home(), page);Navigation.RemovePage(page);await PopupNavigation.Instance.PopAsync(); } else { Constantce.Area = "Area"; Jadiedh.BackgroundColor = Color.White; Jadiedh.TextColor = Color.FromHex("#FF071D66"); } }
        async void Joza_Clicked(object sender, EventArgs e) { if (Joza.BackgroundColor == Color.White) { Constantce.Area = "Joza"; Constantce.AreaLang = Joza.Text; Joza.TextColor = Color.White; Joza.BackgroundColor = Color.FromHex("#FF071D66"); var existingPages = Navigation.NavigationStack.ToList();Page page = existingPages.FirstOrDefault();Navigation.InsertPageBefore(new Home(), page);Navigation.RemovePage(page);await PopupNavigation.Instance.PopAsync(); } else { Constantce.Area = "Area"; Joza.BackgroundColor = Color.White; Joza.TextColor = Color.FromHex("#FF071D66"); } }
        async void Jozeh_Clicked(object sender, EventArgs e) { if (Jozeh.BackgroundColor == Color.White) { Constantce.Area = "Jozeh"; Constantce.AreaLang = Jozeh.Text; Jozeh.TextColor = Color.White; Jozeh.BackgroundColor = Color.FromHex("#FF071D66"); var existingPages = Navigation.NavigationStack.ToList();Page page = existingPages.FirstOrDefault();Navigation.InsertPageBefore(new Home(), page);Navigation.RemovePage(page);await PopupNavigation.Instance.PopAsync(); } else { Constantce.Area = "Area"; Jozeh.BackgroundColor = Color.White; Jozeh.TextColor = Color.FromHex("#FF071D66"); } }
        async void Jwair_Clicked(object sender, EventArgs e) { if (Jwair.BackgroundColor == Color.White) { Constantce.Area = "Jwair"; Constantce.AreaLang = Jwair.Text; Jwair.TextColor = Color.White; Jwair.BackgroundColor = Color.FromHex("#FF071D66"); var existingPages = Navigation.NavigationStack.ToList();Page page = existingPages.FirstOrDefault();Navigation.InsertPageBefore(new Home(), page);Navigation.RemovePage(page);await PopupNavigation.Instance.PopAsync(); } else { Constantce.Area = "Area"; Jwair.BackgroundColor = Color.White; Jwair.TextColor = Color.FromHex("#FF071D66"); } }
        async void Kaderiyyeh_Clicked(object sender, EventArgs e) { if (Kaderiyyeh.BackgroundColor == Color.White) { Constantce.Area = "Kaderiyyeh"; Constantce.AreaLang = Kaderiyyeh.Text; Kaderiyyeh.TextColor = Color.White; Kaderiyyeh.BackgroundColor = Color.FromHex("#FF071D66"); var existingPages = Navigation.NavigationStack.ToList();Page page = existingPages.FirstOrDefault();Navigation.InsertPageBefore(new Home(), page);Navigation.RemovePage(page);await PopupNavigation.Instance.PopAsync(); } else { Constantce.Area = "Area"; Kaderiyyeh.BackgroundColor = Color.White; Kaderiyyeh.TextColor = Color.FromHex("#FF071D66"); } }
        async void Kamnah_Clicked(object sender, EventArgs e) { if (Kamnah.BackgroundColor == Color.White) { Constantce.Area = "Kamnah"; Constantce.AreaLang = Kamnah.Text; Kamnah.TextColor = Color.White; Kamnah.BackgroundColor = Color.FromHex("#FF071D66"); var existingPages = Navigation.NavigationStack.ToList();Page page = existingPages.FirstOrDefault();Navigation.InsertPageBefore(new Home(), page);Navigation.RemovePage(page);await PopupNavigation.Instance.PopAsync(); } else { Constantce.Area = "Area"; Kamnah.BackgroundColor = Color.White; Kamnah.TextColor = Color.FromHex("#FF071D66"); } }
        async void Kathrabba_Clicked(object sender, EventArgs e) { if (Kathrabba.BackgroundColor == Color.White) { Constantce.Area = "Kathrabba"; Constantce.AreaLang = Kathrabba.Text; Kathrabba.TextColor = Color.White; Kathrabba.BackgroundColor = Color.FromHex("#FF071D66"); var existingPages = Navigation.NavigationStack.ToList();Page page = existingPages.FirstOrDefault();Navigation.InsertPageBefore(new Home(), page);Navigation.RemovePage(page);await PopupNavigation.Instance.PopAsync(); } else { Constantce.Area = "Area"; Kathrabba.BackgroundColor = Color.White; Kathrabba.TextColor = Color.FromHex("#FF071D66"); } }
        async void Kerak_Clicked(object sender, EventArgs e) { if (Kerak.BackgroundColor == Color.White) { Constantce.Area = "Kerak"; Constantce.AreaLang = Kerak.Text; Kerak.TextColor = Color.White; Kerak.BackgroundColor = Color.FromHex("#FF071D66"); var existingPages = Navigation.NavigationStack.ToList();Page page = existingPages.FirstOrDefault();Navigation.InsertPageBefore(new Home(), page);Navigation.RemovePage(page);await PopupNavigation.Instance.PopAsync(); } else { Constantce.Area = "Area"; Kerak.BackgroundColor = Color.White; Kerak.TextColor = Color.FromHex("#FF071D66"); } }
        async void Khaldiyyeh_Clicked(object sender, EventArgs e) { if (Khaldiyyeh.BackgroundColor == Color.White) { Constantce.Area = "Khaldiyyeh"; Constantce.AreaLang = Khaldiyyeh.Text; Khaldiyyeh.TextColor = Color.White; Khaldiyyeh.BackgroundColor = Color.FromHex("#FF071D66"); var existingPages = Navigation.NavigationStack.ToList();Page page = existingPages.FirstOrDefault();Navigation.InsertPageBefore(new Home(), page);Navigation.RemovePage(page);await PopupNavigation.Instance.PopAsync(); } else { Constantce.Area = "Area"; Khaldiyyeh.BackgroundColor = Color.White; Khaldiyyeh.TextColor = Color.FromHex("#FF071D66"); } }
        async void Lajoon_Clicked(object sender, EventArgs e) { if (Lajoon.BackgroundColor == Color.White) { Constantce.Area = "Lajoon"; Constantce.AreaLang = Lajoon.Text; Lajoon.TextColor = Color.White; Lajoon.BackgroundColor = Color.FromHex("#FF071D66"); var existingPages = Navigation.NavigationStack.ToList();Page page = existingPages.FirstOrDefault();Navigation.InsertPageBefore(new Home(), page);Navigation.RemovePage(page);await PopupNavigation.Instance.PopAsync(); } else { Constantce.Area = "Area"; Lajoon.BackgroundColor = Color.White; Lajoon.TextColor = Color.FromHex("#FF071D66"); } }
        async void Mahmodeyeh_Clicked(object sender, EventArgs e) { if (Mahmodeyeh.BackgroundColor == Color.White) { Constantce.Area = "Mahmodeyeh"; Constantce.AreaLang = Mahmodeyeh.Text; Mahmodeyeh.TextColor = Color.White; Mahmodeyeh.BackgroundColor = Color.FromHex("#FF071D66"); var existingPages = Navigation.NavigationStack.ToList();Page page = existingPages.FirstOrDefault();Navigation.InsertPageBefore(new Home(), page);Navigation.RemovePage(page);await PopupNavigation.Instance.PopAsync(); } else { Constantce.Area = "Area"; Mahmodeyeh.BackgroundColor = Color.White; Mahmodeyeh.TextColor = Color.FromHex("#FF071D66"); } }
        async void Majdoleen_Clicked(object sender, EventArgs e) { if (Majdoleen.BackgroundColor == Color.White) { Constantce.Area = "Majdoleen"; Constantce.AreaLang = Majdoleen.Text; Majdoleen.TextColor = Color.White; Majdoleen.BackgroundColor = Color.FromHex("#FF071D66"); var existingPages = Navigation.NavigationStack.ToList();Page page = existingPages.FirstOrDefault();Navigation.InsertPageBefore(new Home(), page);Navigation.RemovePage(page);await PopupNavigation.Instance.PopAsync(); } else { Constantce.Area = "Area"; Majdoleen.BackgroundColor = Color.White; Majdoleen.TextColor = Color.FromHex("#FF071D66"); } }
        async void Majra_Clicked(object sender, EventArgs e) { if (Majra.BackgroundColor == Color.White) { Constantce.Area = "Majra"; Constantce.AreaLang = Majra.Text; Majra.TextColor = Color.White; Majra.BackgroundColor = Color.FromHex("#FF071D66"); var existingPages = Navigation.NavigationStack.ToList();Page page = existingPages.FirstOrDefault();Navigation.InsertPageBefore(new Home(), page);Navigation.RemovePage(page);await PopupNavigation.Instance.PopAsync(); } else { Constantce.Area = "Area"; Majra.BackgroundColor = Color.White; Majra.TextColor = Color.FromHex("#FF071D66"); } }
        async void Mamooniyyeh_Clicked(object sender, EventArgs e){if (Mamooniyyeh.BackgroundColor == Color.White){Constantce.Area = "Ma'mooniyyeh"; Constantce.AreaLang = Mamooniyyeh.Text; Mamooniyyeh.TextColor = Color.White; Mamooniyyeh.BackgroundColor = Color.FromHex("#FF071D66"); var existingPages = Navigation.NavigationStack.ToList(); await Navigation.PushAsync(new Home()); foreach (var page in existingPages) { Navigation.RemovePage(page); }await Task.Delay(80); await PopupNavigation.Instance.PopAsync();}else { Constantce.Area = "Area"; Mamooniyyeh.BackgroundColor = Color.White; Mamooniyyeh.TextColor = Color.FromHex("#FF071D66"); }}
        async void Mamorah_Clicked(object sender, EventArgs e) { if (Mamorah.BackgroundColor == Color.White) { Constantce.Area = "Mamorah"; Constantce.AreaLang = Mamorah.Text; Mamorah.TextColor = Color.White; Mamorah.BackgroundColor = Color.FromHex("#FF071D66"); var existingPages = Navigation.NavigationStack.ToList();Page page = existingPages.FirstOrDefault();Navigation.InsertPageBefore(new Home(), page);Navigation.RemovePage(page);await PopupNavigation.Instance.PopAsync(); } else { Constantce.Area = "Area"; Mamorah.BackgroundColor = Color.White; Mamorah.TextColor = Color.FromHex("#FF071D66"); } }
        async void ManshiyyetAbuHammoor_Clicked(object sender, EventArgs e) { if (ManshiyyetAbuHammoor.BackgroundColor == Color.White) { Constantce.Area = "Manshiyyet Abu Hammoor"; Constantce.AreaLang = ManshiyyetAbuHammoor.Text; ManshiyyetAbuHammoor.TextColor = Color.White; ManshiyyetAbuHammoor.BackgroundColor = Color.FromHex("#FF071D66"); var existingPages = Navigation.NavigationStack.ToList();Page page = existingPages.FirstOrDefault();Navigation.InsertPageBefore(new Home(), page);Navigation.RemovePage(page);await PopupNavigation.Instance.PopAsync(); } else { Constantce.Area = "Area"; ManshiyyetAbuHammoor.BackgroundColor = Color.White; ManshiyyetAbuHammoor.TextColor = Color.FromHex("#FF071D66"); } }
        async void ManshiyyetElMazar_Clicked(object sender, EventArgs e) { if (ManshiyyetElMazar.BackgroundColor == Color.White) { Constantce.Area = "Manshiyyet El - Mazar"; Constantce.AreaLang = ManshiyyetElMazar.Text; ManshiyyetElMazar.TextColor = Color.White; ManshiyyetElMazar.BackgroundColor = Color.FromHex("#FF071D66"); var existingPages = Navigation.NavigationStack.ToList();Page page = existingPages.FirstOrDefault();Navigation.InsertPageBefore(new Home(), page);Navigation.RemovePage(page);await PopupNavigation.Instance.PopAsync(); } else { Constantce.Area = "Area"; ManshiyyetElMazar.BackgroundColor = Color.White; ManshiyyetElMazar.TextColor = Color.FromHex("#FF071D66"); } }
        async void MazarJanoobee_Clicked(object sender, EventArgs e) { if (MazarJanoobee.BackgroundColor == Color.White) { Constantce.Area = "Mazar Janoobee"; Constantce.AreaLang = MazarJanoobee.Text; MazarJanoobee.TextColor = Color.White; MazarJanoobee.BackgroundColor = Color.FromHex("#FF071D66"); var existingPages = Navigation.NavigationStack.ToList();Page page = existingPages.FirstOrDefault();Navigation.InsertPageBefore(new Home(), page);Navigation.RemovePage(page);await PopupNavigation.Instance.PopAsync(); } else { Constantce.Area = "Area"; MazarJanoobee.BackgroundColor = Color.White; MazarJanoobee.TextColor = Color.FromHex("#FF071D66"); } }
        async void Median_Clicked(object sender, EventArgs e) { if (Median.BackgroundColor == Color.White) { Constantce.Area = "Median"; Constantce.AreaLang = Median.Text; Median.TextColor = Color.White; Median.BackgroundColor = Color.FromHex("#FF071D66"); var existingPages = Navigation.NavigationStack.ToList();Page page = existingPages.FirstOrDefault();Navigation.InsertPageBefore(new Home(), page);Navigation.RemovePage(page);await PopupNavigation.Instance.PopAsync(); } else { Constantce.Area = "Area"; Median.BackgroundColor = Color.White; Median.TextColor = Color.FromHex("#FF071D66"); } }
        async void Merwed_Clicked(object sender, EventArgs e) { if (Merwed.BackgroundColor == Color.White) { Constantce.Area = "Merwed"; Constantce.AreaLang = Merwed.Text; Merwed.TextColor = Color.White; Merwed.BackgroundColor = Color.FromHex("#FF071D66"); var existingPages = Navigation.NavigationStack.ToList();Page page = existingPages.FirstOrDefault();Navigation.InsertPageBefore(new Home(), page);Navigation.RemovePage(page);await PopupNavigation.Instance.PopAsync(); } else { Constantce.Area = "Area"; Merwed.BackgroundColor = Color.White; Merwed.TextColor = Color.FromHex("#FF071D66"); } }
        async void Mesar_Clicked(object sender, EventArgs e){if (Mesar.BackgroundColor == Color.White){Constantce.Area = "Mes'ar"; Constantce.AreaLang = Mesar.Text; Mesar.TextColor = Color.White; Mesar.BackgroundColor = Color.FromHex("#FF071D66"); var existingPages = Navigation.NavigationStack.ToList(); await Navigation.PushAsync(new Home()); foreach (var page in existingPages) { Navigation.RemovePage(page); }await Task.Delay(80); await PopupNavigation.Instance.PopAsync();}else { Constantce.Area = "Area"; Mesar.BackgroundColor = Color.White; Mesar.TextColor = Color.FromHex("#FF071D66"); }}
        async void Mghayyer_Clicked(object sender, EventArgs e) { if (Mghayyer.BackgroundColor == Color.White) { Constantce.Area = "Mghayyer"; Constantce.AreaLang = Mghayyer.Text; Mghayyer.TextColor = Color.White; Mghayyer.BackgroundColor = Color.FromHex("#FF071D66"); var existingPages = Navigation.NavigationStack.ToList();Page page = existingPages.FirstOrDefault();Navigation.InsertPageBefore(new Home(), page);Navigation.RemovePage(page);await PopupNavigation.Instance.PopAsync(); } else { Constantce.Area = "Area"; Mghayyer.BackgroundColor = Color.White; Mghayyer.TextColor = Color.FromHex("#FF071D66"); } }
        async void Mhiyy_Clicked(object sender, EventArgs e) { if (Mhiyy.BackgroundColor == Color.White) { Constantce.Area = "Mhiyy"; Constantce.AreaLang = Mhiyy.Text; Mhiyy.TextColor = Color.White; Mhiyy.BackgroundColor = Color.FromHex("#FF071D66"); var existingPages = Navigation.NavigationStack.ToList();Page page = existingPages.FirstOrDefault();Navigation.InsertPageBefore(new Home(), page);Navigation.RemovePage(page);await PopupNavigation.Instance.PopAsync(); } else { Constantce.Area = "Area"; Mhiyy.BackgroundColor = Color.White; Mhiyy.TextColor = Color.FromHex("#FF071D66"); } }
        async void Mjaidel_Clicked(object sender, EventArgs e) { if (Mjaidel.BackgroundColor == Color.White) { Constantce.Area = "Mjaidel"; Constantce.AreaLang = Mjaidel.Text; Mjaidel.TextColor = Color.White; Mjaidel.BackgroundColor = Color.FromHex("#FF071D66"); var existingPages = Navigation.NavigationStack.ToList();Page page = existingPages.FirstOrDefault();Navigation.InsertPageBefore(new Home(), page);Navigation.RemovePage(page);await PopupNavigation.Instance.PopAsync(); } else { Constantce.Area = "Area"; Mjaidel.BackgroundColor = Color.White; Mjaidel.TextColor = Color.FromHex("#FF071D66"); } }
        async void Moomia_Clicked(object sender, EventArgs e) { if (Moomia.BackgroundColor == Color.White) { Constantce.Area = "Moomia"; Constantce.AreaLang = Moomia.Text; Moomia.TextColor = Color.White; Moomia.BackgroundColor = Color.FromHex("#FF071D66"); var existingPages = Navigation.NavigationStack.ToList();Page page = existingPages.FirstOrDefault();Navigation.InsertPageBefore(new Home(), page);Navigation.RemovePage(page);await PopupNavigation.Instance.PopAsync(); } else { Constantce.Area = "Area"; Moomia.BackgroundColor = Color.White; Moomia.TextColor = Color.FromHex("#FF071D66"); } }
        async void Mowjeb_Clicked(object sender, EventArgs e) { if (Mowjeb.BackgroundColor == Color.White) { Constantce.Area = "Mowjeb"; Constantce.AreaLang = Mowjeb.Text; Mowjeb.TextColor = Color.White; Mowjeb.BackgroundColor = Color.FromHex("#FF071D66"); var existingPages = Navigation.NavigationStack.ToList();Page page = existingPages.FirstOrDefault();Navigation.InsertPageBefore(new Home(), page);Navigation.RemovePage(page);await PopupNavigation.Instance.PopAsync(); } else { Constantce.Area = "Area"; Mowjeb.BackgroundColor = Color.White; Mowjeb.TextColor = Color.FromHex("#FF071D66"); } }
        async void Mraighah_Clicked(object sender, EventArgs e) { if (Mraighah.BackgroundColor == Color.White) { Constantce.Area = "Mraighah"; Constantce.AreaLang = Mraighah.Text; Mraighah.TextColor = Color.White; Mraighah.BackgroundColor = Color.FromHex("#FF071D66"); var existingPages = Navigation.NavigationStack.ToList();Page page = existingPages.FirstOrDefault();Navigation.InsertPageBefore(new Home(), page);Navigation.RemovePage(page);await PopupNavigation.Instance.PopAsync(); } else { Constantce.Area = "Area"; Mraighah.BackgroundColor = Color.White; Mraighah.TextColor = Color.FromHex("#FF071D66"); } }
        async void Mshairfeh_Clicked(object sender, EventArgs e) { if (Mshairfeh.BackgroundColor == Color.White) { Constantce.Area = "Mshairfeh"; Constantce.AreaLang = Mshairfeh.Text; Mshairfeh.TextColor = Color.White; Mshairfeh.BackgroundColor = Color.FromHex("#FF071D66"); var existingPages = Navigation.NavigationStack.ToList();Page page = existingPages.FirstOrDefault();Navigation.InsertPageBefore(new Home(), page);Navigation.RemovePage(page);await PopupNavigation.Instance.PopAsync(); } else { Constantce.Area = "Area"; Mshairfeh.BackgroundColor = Color.White; Mshairfeh.TextColor = Color.FromHex("#FF071D66"); } }
        async void Mutah_Clicked(object sender, EventArgs e){if (Mutah.BackgroundColor == Color.White){Constantce.Area = "Mu'tah"; Constantce.AreaLang = Mutah.Text; Mutah.TextColor = Color.White; Mutah.BackgroundColor = Color.FromHex("#FF071D66"); var existingPages = Navigation.NavigationStack.ToList(); await Navigation.PushAsync(new Home()); foreach (var page in existingPages) { Navigation.RemovePage(page); }await Task.Delay(80); await PopupNavigation.Instance.PopAsync();}else { Constantce.Area = "Area"; Mutah.BackgroundColor = Color.White; Mutah.TextColor = Color.FromHex("#FF071D66"); }}
        async void Noaymeh_Clicked(object sender, EventArgs e){if (Noaymeh.BackgroundColor == Color.White){Constantce.Area = "No'aymeh"; Constantce.AreaLang = Noaymeh.Text; Noaymeh.TextColor = Color.White; Noaymeh.BackgroundColor = Color.FromHex("#FF071D66"); var existingPages = Navigation.NavigationStack.ToList(); await Navigation.PushAsync(new Home()); foreach (var page in existingPages) { Navigation.RemovePage(page); }await Task.Delay(80); await PopupNavigation.Instance.PopAsync();}else { Constantce.Area = "Area"; Noaymeh.BackgroundColor = Color.White; Noaymeh.TextColor = Color.FromHex("#FF071D66"); }}
        async void Omariyyeh_Clicked(object sender, EventArgs e) { if (Omariyyeh.BackgroundColor == Color.White) { Constantce.Area = "Omariyyeh"; Constantce.AreaLang = Omariyyeh.Text; Omariyyeh.TextColor = Color.White; Omariyyeh.BackgroundColor = Color.FromHex("#FF071D66"); var existingPages = Navigation.NavigationStack.ToList();Page page = existingPages.FirstOrDefault();Navigation.InsertPageBefore(new Home(), page);Navigation.RemovePage(page);await PopupNavigation.Instance.PopAsync(); } else { Constantce.Area = "Area"; Omariyyeh.BackgroundColor = Color.White; Omariyyeh.TextColor = Color.FromHex("#FF071D66"); } }
        async void Omqah_Clicked(object sender, EventArgs e) { if (Omqah.BackgroundColor == Color.White) { Constantce.Area = "Omqah"; Constantce.AreaLang = Omqah.Text; Omqah.TextColor = Color.White; Omqah.BackgroundColor = Color.FromHex("#FF071D66"); var existingPages = Navigation.NavigationStack.ToList();Page page = existingPages.FirstOrDefault();Navigation.InsertPageBefore(new Home(), page);Navigation.RemovePage(page);await PopupNavigation.Instance.PopAsync(); } else { Constantce.Area = "Area"; Omqah.BackgroundColor = Color.White; Omqah.TextColor = Color.FromHex("#FF071D66"); } }
        async void Qasr_Clicked(object sender, EventArgs e) { if (Qasr.BackgroundColor == Color.White) { Constantce.Area = "Qasr"; Constantce.AreaLang = Qasr.Text; Qasr.TextColor = Color.White; Qasr.BackgroundColor = Color.FromHex("#FF071D66"); var existingPages = Navigation.NavigationStack.ToList();Page page = existingPages.FirstOrDefault();Navigation.InsertPageBefore(new Home(), page);Navigation.RemovePage(page);await PopupNavigation.Instance.PopAsync(); } else { Constantce.Area = "Area"; Qasr.BackgroundColor = Color.White; Qasr.TextColor = Color.FromHex("#FF071D66"); } }
        async void Qatraneh_Clicked(object sender, EventArgs e) { if (Qatraneh.BackgroundColor == Color.White) { Constantce.Area = "Qatraneh"; Constantce.AreaLang = Qatraneh.Text; Qatraneh.TextColor = Color.White; Qatraneh.BackgroundColor = Color.FromHex("#FF071D66"); var existingPages = Navigation.NavigationStack.ToList();Page page = existingPages.FirstOrDefault();Navigation.InsertPageBefore(new Home(), page);Navigation.RemovePage(page);await PopupNavigation.Instance.PopAsync(); } else { Constantce.Area = "Area"; Qatraneh.BackgroundColor = Color.White; Qatraneh.TextColor = Color.FromHex("#FF071D66"); } }
        async void Qraifleh_Clicked(object sender, EventArgs e) { if (Qraifleh.BackgroundColor == Color.White) { Constantce.Area = "Qraifleh"; Constantce.AreaLang = Qraifleh.Text; Qraifleh.TextColor = Color.White; Qraifleh.BackgroundColor = Color.FromHex("#FF071D66"); var existingPages = Navigation.NavigationStack.ToList();Page page = existingPages.FirstOrDefault();Navigation.InsertPageBefore(new Home(), page);Navigation.RemovePage(page);await PopupNavigation.Instance.PopAsync(); } else { Constantce.Area = "Area"; Qraifleh.BackgroundColor = Color.White; Qraifleh.TextColor = Color.FromHex("#FF071D66"); } }
        async void Rabbah_Clicked(object sender, EventArgs e) { if (Rabbah.BackgroundColor == Color.White) { Constantce.Area = "Rabbah"; Constantce.AreaLang = Rabbah.Text; Rabbah.TextColor = Color.White; Rabbah.BackgroundColor = Color.FromHex("#FF071D66"); var existingPages = Navigation.NavigationStack.ToList();Page page = existingPages.FirstOrDefault();Navigation.InsertPageBefore(new Home(), page);Navigation.RemovePage(page);await PopupNavigation.Instance.PopAsync(); } else { Constantce.Area = "Area"; Rabbah.BackgroundColor = Color.White; Rabbah.TextColor = Color.FromHex("#FF071D66"); } }
        async void Rakeen_Clicked(object sender, EventArgs e) { if (Rakeen.BackgroundColor == Color.White) { Constantce.Area = "Rakeen"; Constantce.AreaLang = Rakeen.Text; Rakeen.TextColor = Color.White; Rakeen.BackgroundColor = Color.FromHex("#FF071D66"); var existingPages = Navigation.NavigationStack.ToList();Page page = existingPages.FirstOrDefault();Navigation.InsertPageBefore(new Home(), page);Navigation.RemovePage(page);await PopupNavigation.Instance.PopAsync(); } else { Constantce.Area = "Area"; Rakeen.BackgroundColor = Color.White; Rakeen.TextColor = Color.FromHex("#FF071D66"); } }
        async void Rashadeih_Clicked(object sender, EventArgs e) { if (Rashadeih.BackgroundColor == Color.White) { Constantce.Area = "Rashadeih"; Constantce.AreaLang = Rashadeih.Text; Rashadeih.TextColor = Color.White; Rashadeih.BackgroundColor = Color.FromHex("#FF071D66"); var existingPages = Navigation.NavigationStack.ToList();Page page = existingPages.FirstOrDefault();Navigation.InsertPageBefore(new Home(), page);Navigation.RemovePage(page);await PopupNavigation.Instance.PopAsync(); } else { Constantce.Area = "Area"; Rashadeih.BackgroundColor = Color.White; Rashadeih.TextColor = Color.FromHex("#FF071D66"); } }
        async void Rashdiyyeh_Clicked(object sender, EventArgs e) { if (Rashdiyyeh.BackgroundColor == Color.White) { Constantce.Area = "Rashdiyyeh"; Constantce.AreaLang = Rashdiyyeh.Text; Rashdiyyeh.TextColor = Color.White; Rashdiyyeh.BackgroundColor = Color.FromHex("#FF071D66"); var existingPages = Navigation.NavigationStack.ToList();Page page = existingPages.FirstOrDefault();Navigation.InsertPageBefore(new Home(), page);Navigation.RemovePage(page);await PopupNavigation.Instance.PopAsync(); } else { Constantce.Area = "Area"; Rashdiyyeh.BackgroundColor = Color.White; Rashdiyyeh.TextColor = Color.FromHex("#FF071D66"); } }
        async void Rawdah_Clicked(object sender, EventArgs e) { if (Rawdah.BackgroundColor == Color.White) { Constantce.Area = "Rawdah"; Constantce.AreaLang = Rawdah.Text; Rawdah.TextColor = Color.White; Rawdah.BackgroundColor = Color.FromHex("#FF071D66"); var existingPages = Navigation.NavigationStack.ToList();Page page = existingPages.FirstOrDefault();Navigation.InsertPageBefore(new Home(), page);Navigation.RemovePage(page);await PopupNavigation.Instance.PopAsync(); } else { Constantce.Area = "Area"; Rawdah.BackgroundColor = Color.White; Rawdah.TextColor = Color.FromHex("#FF071D66"); } }
        async void Riha_Clicked(object sender, EventArgs e) { if (Riha.BackgroundColor == Color.White) { Constantce.Area = "Riha"; Constantce.AreaLang = Riha.Text; Riha.TextColor = Color.White; Riha.BackgroundColor = Color.FromHex("#FF071D66"); var existingPages = Navigation.NavigationStack.ToList();Page page = existingPages.FirstOrDefault();Navigation.InsertPageBefore(new Home(), page);Navigation.RemovePage(page);await PopupNavigation.Instance.PopAsync(); } else { Constantce.Area = "Area"; Riha.BackgroundColor = Color.White; Riha.TextColor = Color.FromHex("#FF071D66"); } }
        async void SadElSoltani_Clicked(object sender, EventArgs e) { if (SadElSoltani.BackgroundColor == Color.White) { Constantce.Area = "Sad El - Soltani"; Constantce.AreaLang = SadElSoltani.Text; SadElSoltani.TextColor = Color.White; SadElSoltani.BackgroundColor = Color.FromHex("#FF071D66"); var existingPages = Navigation.NavigationStack.ToList();Page page = existingPages.FirstOrDefault();Navigation.InsertPageBefore(new Home(), page);Navigation.RemovePage(page);await PopupNavigation.Instance.PopAsync(); } else { Constantce.Area = "Area"; SadElSoltani.BackgroundColor = Color.White; SadElSoltani.TextColor = Color.FromHex("#FF071D66"); } }
        async void Sakka_Clicked(object sender, EventArgs e) { if (Sakka.BackgroundColor == Color.White) { Constantce.Area = "Sakka"; Constantce.AreaLang = Sakka.Text; Sakka.TextColor = Color.White; Sakka.BackgroundColor = Color.FromHex("#FF071D66"); var existingPages = Navigation.NavigationStack.ToList();Page page = existingPages.FirstOrDefault();Navigation.InsertPageBefore(new Home(), page);Navigation.RemovePage(page);await PopupNavigation.Instance.PopAsync(); } else { Constantce.Area = "Area"; Sakka.BackgroundColor = Color.White; Sakka.TextColor = Color.FromHex("#FF071D66"); } }
        async void Salhiyyeh_Clicked(object sender, EventArgs e) { if (Salhiyyeh.BackgroundColor == Color.White) { Constantce.Area = "Salhiyyeh"; Constantce.AreaLang = Salhiyyeh.Text; Salhiyyeh.TextColor = Color.White; Salhiyyeh.BackgroundColor = Color.FromHex("#FF071D66"); var existingPages = Navigation.NavigationStack.ToList();Page page = existingPages.FirstOrDefault();Navigation.InsertPageBefore(new Home(), page);Navigation.RemovePage(page);await PopupNavigation.Instance.PopAsync(); } else { Constantce.Area = "Area"; Salhiyyeh.BackgroundColor = Color.White; Salhiyyeh.TextColor = Color.FromHex("#FF071D66"); } }
        async void Salmani_Clicked(object sender, EventArgs e) { if (Salmani.BackgroundColor == Color.White) { Constantce.Area = "Salmani"; Constantce.AreaLang = Salmani.Text; Salmani.TextColor = Color.White; Salmani.BackgroundColor = Color.FromHex("#FF071D66"); var existingPages = Navigation.NavigationStack.ToList();Page page = existingPages.FirstOrDefault();Navigation.InsertPageBefore(new Home(), page);Navigation.RemovePage(page);await PopupNavigation.Instance.PopAsync(); } else { Constantce.Area = "Area"; Salmani.BackgroundColor = Color.White; Salmani.TextColor = Color.FromHex("#FF071D66"); } }
        async void Samra_Clicked(object sender, EventArgs e) { if (Samra.BackgroundColor == Color.White) { Constantce.Area = "Samra"; Constantce.AreaLang = Samra.Text; Samra.TextColor = Color.White; Samra.BackgroundColor = Color.FromHex("#FF071D66"); var existingPages = Navigation.NavigationStack.ToList();Page page = existingPages.FirstOrDefault();Navigation.InsertPageBefore(new Home(), page);Navigation.RemovePage(page);await PopupNavigation.Instance.PopAsync(); } else { Constantce.Area = "Area"; Samra.BackgroundColor = Color.White; Samra.TextColor = Color.FromHex("#FF071D66"); } }
        async void Serfa_Clicked(object sender, EventArgs e) { if (Serfa.BackgroundColor == Color.White) { Constantce.Area = "Serfa"; Constantce.AreaLang = Serfa.Text; Serfa.TextColor = Color.White; Serfa.BackgroundColor = Color.FromHex("#FF071D66"); var existingPages = Navigation.NavigationStack.ToList();Page page = existingPages.FirstOrDefault();Navigation.InsertPageBefore(new Home(), page);Navigation.RemovePage(page);await PopupNavigation.Instance.PopAsync(); } else { Constantce.Area = "Area"; Serfa.BackgroundColor = Color.White; Serfa.TextColor = Color.FromHex("#FF071D66"); } }
        async void shahtoor_Clicked(object sender, EventArgs e) { if (shahtoor.BackgroundColor == Color.White) { Constantce.Area = "shahtoor"; Constantce.AreaLang = shahtoor.Text; shahtoor.TextColor = Color.White; shahtoor.BackgroundColor = Color.FromHex("#FF071D66"); var existingPages = Navigation.NavigationStack.ToList();Page page = existingPages.FirstOrDefault();Navigation.InsertPageBefore(new Home(), page);Navigation.RemovePage(page);await PopupNavigation.Instance.PopAsync(); } else { Constantce.Area = "Area"; shahtoor.BackgroundColor = Color.White; shahtoor.TextColor = Color.FromHex("#FF071D66"); } }
        async void Shariefeh_Clicked(object sender, EventArgs e) { if (Shariefeh.BackgroundColor == Color.White) { Constantce.Area = "Shariefeh"; Constantce.AreaLang = Shariefeh.Text; Shariefeh.TextColor = Color.White; Shariefeh.BackgroundColor = Color.FromHex("#FF071D66"); var existingPages = Navigation.NavigationStack.ToList();Page page = existingPages.FirstOrDefault();Navigation.InsertPageBefore(new Home(), page);Navigation.RemovePage(page);await PopupNavigation.Instance.PopAsync(); } else { Constantce.Area = "Area"; Shariefeh.BackgroundColor = Color.White; Shariefeh.TextColor = Color.FromHex("#FF071D66"); } }
        async void Sheehan_Clicked(object sender, EventArgs e) { if (Sheehan.BackgroundColor == Color.White) { Constantce.Area = "Sheehan"; Constantce.AreaLang = Sheehan.Text; Sheehan.TextColor = Color.White; Sheehan.BackgroundColor = Color.FromHex("#FF071D66"); var existingPages = Navigation.NavigationStack.ToList();Page page = existingPages.FirstOrDefault();Navigation.InsertPageBefore(new Home(), page);Navigation.RemovePage(page);await PopupNavigation.Instance.PopAsync(); } else { Constantce.Area = "Area"; Sheehan.BackgroundColor = Color.White; Sheehan.TextColor = Color.FromHex("#FF071D66"); } }
        async void Shehabiyyeh_Clicked(object sender, EventArgs e) { if (Shehabiyyeh.BackgroundColor == Color.White) { Constantce.Area = "Shehabiyyeh"; Constantce.AreaLang = Shehabiyyeh.Text; Shehabiyyeh.TextColor = Color.White; Shehabiyyeh.BackgroundColor = Color.FromHex("#FF071D66"); var existingPages = Navigation.NavigationStack.ToList();Page page = existingPages.FirstOrDefault();Navigation.InsertPageBefore(new Home(), page);Navigation.RemovePage(page);await PopupNavigation.Instance.PopAsync(); } else { Constantce.Area = "Area"; Shehabiyyeh.BackgroundColor = Color.White; Shehabiyyeh.TextColor = Color.FromHex("#FF071D66"); } }
        async void ShqairaElGharbiyyeh_Clicked(object sender, EventArgs e) { if (ShqairaElGharbiyyeh.BackgroundColor == Color.White) { Constantce.Area = "Shqaira El - Gharbiyyeh"; Constantce.AreaLang = ShqairaElGharbiyyeh.Text; ShqairaElGharbiyyeh.TextColor = Color.White; ShqairaElGharbiyyeh.BackgroundColor = Color.FromHex("#FF071D66"); var existingPages = Navigation.NavigationStack.ToList();Page page = existingPages.FirstOrDefault();Navigation.InsertPageBefore(new Home(), page);Navigation.RemovePage(page);await PopupNavigation.Instance.PopAsync(); } else { Constantce.Area = "Area"; ShqairaElGharbiyyeh.BackgroundColor = Color.White; ShqairaElGharbiyyeh.TextColor = Color.FromHex("#FF071D66"); } }
        async void ShqairaElSharqiyyeh_Clicked(object sender, EventArgs e) { if (ShqairaElSharqiyyeh.BackgroundColor == Color.White) { Constantce.Area = "Shqaira El - Sharqiyyeh"; Constantce.AreaLang = ShqairaElSharqiyyeh.Text; ShqairaElSharqiyyeh.TextColor = Color.White; ShqairaElSharqiyyeh.BackgroundColor = Color.FromHex("#FF071D66"); var existingPages = Navigation.NavigationStack.ToList();Page page = existingPages.FirstOrDefault();Navigation.InsertPageBefore(new Home(), page);Navigation.RemovePage(page);await PopupNavigation.Instance.PopAsync(); } else { Constantce.Area = "Area"; ShqairaElSharqiyyeh.BackgroundColor = Color.White; ShqairaElSharqiyyeh.TextColor = Color.FromHex("#FF071D66"); } }
        async void Smakiyyeh_Clicked(object sender, EventArgs e) { if (Smakiyyeh.BackgroundColor == Color.White) { Constantce.Area = "Smakiyyeh"; Constantce.AreaLang = Smakiyyeh.Text; Smakiyyeh.TextColor = Color.White; Smakiyyeh.BackgroundColor = Color.FromHex("#FF071D66"); var existingPages = Navigation.NavigationStack.ToList();Page page = existingPages.FirstOrDefault();Navigation.InsertPageBefore(new Home(), page);Navigation.RemovePage(page);await PopupNavigation.Instance.PopAsync(); } else { Constantce.Area = "Area"; Smakiyyeh.BackgroundColor = Color.White; Smakiyyeh.TextColor = Color.FromHex("#FF071D66"); } }
        async void Sool_Clicked(object sender, EventArgs e) { if (Sool.BackgroundColor == Color.White) { Constantce.Area = "Sool"; Constantce.AreaLang = Sool.Text; Sool.TextColor = Color.White; Sool.BackgroundColor = Color.FromHex("#FF071D66"); var existingPages = Navigation.NavigationStack.ToList();Page page = existingPages.FirstOrDefault();Navigation.InsertPageBefore(new Home(), page);Navigation.RemovePage(page);await PopupNavigation.Instance.PopAsync(); } else { Constantce.Area = "Area"; Sool.BackgroundColor = Color.White; Sool.TextColor = Color.FromHex("#FF071D66"); } }
        async void Talbiyyeh_Clicked(object sender, EventArgs e) { if (Talbiyyeh.BackgroundColor == Color.White) { Constantce.Area = "Talbiyyeh"; Constantce.AreaLang = Talbiyyeh.Text; Talbiyyeh.TextColor = Color.White; Talbiyyeh.BackgroundColor = Color.FromHex("#FF071D66"); var existingPages = Navigation.NavigationStack.ToList();Page page = existingPages.FirstOrDefault();Navigation.InsertPageBefore(new Home(), page);Navigation.RemovePage(page);await PopupNavigation.Instance.PopAsync(); } else { Constantce.Area = "Area"; Talbiyyeh.BackgroundColor = Color.White; Talbiyyeh.TextColor = Color.FromHex("#FF071D66"); } }
        async void Tayybeh_Clicked(object sender, EventArgs e) { if (Tayybeh.BackgroundColor == Color.White) { Constantce.Area = "Tayybeh"; Constantce.AreaLang = Tayybeh.Text; Tayybeh.TextColor = Color.White; Tayybeh.BackgroundColor = Color.FromHex("#FF071D66"); var existingPages = Navigation.NavigationStack.ToList();Page page = existingPages.FirstOrDefault();Navigation.InsertPageBefore(new Home(), page);Navigation.RemovePage(page);await PopupNavigation.Instance.PopAsync(); } else { Constantce.Area = "Area"; Tayybeh.BackgroundColor = Color.White; Tayybeh.TextColor = Color.FromHex("#FF071D66"); } }
        async void Thaniyyeh_Clicked(object sender, EventArgs e) { if (Thaniyyeh.BackgroundColor == Color.White) { Constantce.Area = "Thaniyyeh"; Constantce.AreaLang = Thaniyyeh.Text; Thaniyyeh.TextColor = Color.White; Thaniyyeh.BackgroundColor = Color.FromHex("#FF071D66"); var existingPages = Navigation.NavigationStack.ToList();Page page = existingPages.FirstOrDefault();Navigation.InsertPageBefore(new Home(), page);Navigation.RemovePage(page);await PopupNavigation.Instance.PopAsync(); } else { Constantce.Area = "Area"; Thaniyyeh.BackgroundColor = Color.White; Thaniyyeh.TextColor = Color.FromHex("#FF071D66"); } }
        async void ThatRas_Clicked(object sender, EventArgs e) { if (ThatRas.BackgroundColor == Color.White) { Constantce.Area = "That Ras"; Constantce.AreaLang = ThatRas.Text; ThatRas.TextColor = Color.White; ThatRas.BackgroundColor = Color.FromHex("#FF071D66"); var existingPages = Navigation.NavigationStack.ToList();Page page = existingPages.FirstOrDefault();Navigation.InsertPageBefore(new Home(), page);Navigation.RemovePage(page);await PopupNavigation.Instance.PopAsync(); } else { Constantce.Area = "Area"; ThatRas.BackgroundColor = Color.White; ThatRas.TextColor = Color.FromHex("#FF071D66"); } }
        async void UmmElGhozlan_Clicked(object sender, EventArgs e) { if (UmmElGhozlan.BackgroundColor == Color.White) { Constantce.Area = "Umm El - Ghozlan"; Constantce.AreaLang = UmmElGhozlan.Text; UmmElGhozlan.TextColor = Color.White; UmmElGhozlan.BackgroundColor = Color.FromHex("#FF071D66"); var existingPages = Navigation.NavigationStack.ToList();Page page = existingPages.FirstOrDefault();Navigation.InsertPageBefore(new Home(), page);Navigation.RemovePage(page);await PopupNavigation.Instance.PopAsync(); } else { Constantce.Area = "Area"; UmmElGhozlan.BackgroundColor = Color.White; UmmElGhozlan.TextColor = Color.FromHex("#FF071D66"); } }
        async void UmmElKhanazeer_Clicked(object sender, EventArgs e) { if (UmmElKhanazeer.BackgroundColor == Color.White) { Constantce.Area = "Umm El - Khanazeer"; Constantce.AreaLang = UmmElKhanazeer.Text; UmmElKhanazeer.TextColor = Color.White; UmmElKhanazeer.BackgroundColor = Color.FromHex("#FF071D66"); var existingPages = Navigation.NavigationStack.ToList();Page page = existingPages.FirstOrDefault();Navigation.InsertPageBefore(new Home(), page);Navigation.RemovePage(page);await PopupNavigation.Instance.PopAsync(); } else { Constantce.Area = "Area"; UmmElKhanazeer.BackgroundColor = Color.White; UmmElKhanazeer.TextColor = Color.FromHex("#FF071D66"); } }
        async void UmmEllYanabie_Clicked(object sender, EventArgs e){if (UmmEllYanabie.BackgroundColor == Color.White){Constantce.Area = "Umm El - Yanabi'e"; Constantce.AreaLang = UmmEllYanabie.Text; UmmEllYanabie.TextColor = Color.White; UmmEllYanabie.BackgroundColor = Color.FromHex("#FF071D66"); var existingPages = Navigation.NavigationStack.ToList(); await Navigation.PushAsync(new Home()); foreach (var page in existingPages) { Navigation.RemovePage(page); }await Task.Delay(80); await PopupNavigation.Instance.PopAsync();}else { Constantce.Area = "Area"; UmmEllYanabie.BackgroundColor = Color.White; UmmEllYanabie.TextColor = Color.FromHex("#FF071D66"); }}
        async void UmmHamat_Clicked(object sender, EventArgs e) { if (UmmHamat.BackgroundColor == Color.White) { Constantce.Area = "Umm Hamat"; Constantce.AreaLang = UmmHamat.Text; UmmHamat.TextColor = Color.White; UmmHamat.BackgroundColor = Color.FromHex("#FF071D66"); var existingPages = Navigation.NavigationStack.ToList();Page page = existingPages.FirstOrDefault();Navigation.InsertPageBefore(new Home(), page);Navigation.RemovePage(page);await PopupNavigation.Instance.PopAsync(); } else { Constantce.Area = "Area"; UmmHamat.BackgroundColor = Color.White; UmmHamat.TextColor = Color.FromHex("#FF071D66"); } }
        async void UmmRommaneh_Clicked(object sender, EventArgs e) { if (UmmRommaneh.BackgroundColor == Color.White) { Constantce.Area = "Umm Rommaneh"; Constantce.AreaLang = UmmRommaneh.Text; UmmRommaneh.TextColor = Color.White; UmmRommaneh.BackgroundColor = Color.FromHex("#FF071D66"); var existingPages = Navigation.NavigationStack.ToList();Page page = existingPages.FirstOrDefault();Navigation.InsertPageBefore(new Home(), page);Navigation.RemovePage(page);await PopupNavigation.Instance.PopAsync(); } else { Constantce.Area = "Area"; UmmRommaneh.BackgroundColor = Color.White; UmmRommaneh.TextColor = Color.FromHex("#FF071D66"); } }
        async void WadiAbyadh_Clicked(object sender, EventArgs e) { if (WadiAbyadh.BackgroundColor == Color.White) { Constantce.Area = "Wadi Abyadh"; Constantce.AreaLang = WadiAbyadh.Text; WadiAbyadh.TextColor = Color.White; WadiAbyadh.BackgroundColor = Color.FromHex("#FF071D66"); var existingPages = Navigation.NavigationStack.ToList();Page page = existingPages.FirstOrDefault();Navigation.InsertPageBefore(new Home(), page);Navigation.RemovePage(page);await PopupNavigation.Instance.PopAsync(); } else { Constantce.Area = "Area"; WadiAbyadh.BackgroundColor = Color.White; WadiAbyadh.TextColor = Color.FromHex("#FF071D66"); } }
        async void WadiIbinHamad_Clicked(object sender, EventArgs e) { if (WadiIbinHamad.BackgroundColor == Color.White) { Constantce.Area = "Wadi Ibin Hamad"; Constantce.AreaLang = WadiIbinHamad.Text; WadiIbinHamad.TextColor = Color.White; WadiIbinHamad.BackgroundColor = Color.FromHex("#FF071D66"); var existingPages = Navigation.NavigationStack.ToList();Page page = existingPages.FirstOrDefault();Navigation.InsertPageBefore(new Home(), page);Navigation.RemovePage(page);await PopupNavigation.Instance.PopAsync(); } else { Constantce.Area = "Area"; WadiIbinHamad.BackgroundColor = Color.White; WadiIbinHamad.TextColor = Color.FromHex("#FF071D66"); } }
        async void Waseiyeh_Clicked(object sender, EventArgs e) { if (Waseiyeh.BackgroundColor == Color.White) { Constantce.Area = "Waseiyeh"; Constantce.AreaLang = Waseiyeh.Text; Waseiyeh.TextColor = Color.White; Waseiyeh.BackgroundColor = Color.FromHex("#FF071D66"); var existingPages = Navigation.NavigationStack.ToList();Page page = existingPages.FirstOrDefault();Navigation.InsertPageBefore(new Home(), page);Navigation.RemovePage(page);await PopupNavigation.Instance.PopAsync(); } else { Constantce.Area = "Area"; Waseiyeh.BackgroundColor = Color.White; Waseiyeh.TextColor = Color.FromHex("#FF071D66"); } }
        async void Yaroot_Clicked(object sender, EventArgs e) { if (Yaroot.BackgroundColor == Color.White) { Constantce.Area = "Yaroot"; Constantce.AreaLang = Yaroot.Text; Yaroot.TextColor = Color.White; Yaroot.BackgroundColor = Color.FromHex("#FF071D66"); var existingPages = Navigation.NavigationStack.ToList();Page page = existingPages.FirstOrDefault();Navigation.InsertPageBefore(new Home(), page);Navigation.RemovePage(page);await PopupNavigation.Instance.PopAsync(); } else { Constantce.Area = "Area"; Yaroot.BackgroundColor = Color.White; Yaroot.TextColor = Color.FromHex("#FF071D66"); } }
        async void Zaghairiyyeh_Clicked(object sender, EventArgs e) { if (Zaghairiyyeh.BackgroundColor == Color.White) { Constantce.Area = "Zaghairiyyeh"; Constantce.AreaLang = Zaghairiyyeh.Text; Zaghairiyyeh.TextColor = Color.White; Zaghairiyyeh.BackgroundColor = Color.FromHex("#FF071D66"); var existingPages = Navigation.NavigationStack.ToList();Page page = existingPages.FirstOrDefault();Navigation.InsertPageBefore(new Home(), page);Navigation.RemovePage(page);await PopupNavigation.Instance.PopAsync(); } else { Constantce.Area = "Area"; Zaghairiyyeh.BackgroundColor = Color.White; Zaghairiyyeh.TextColor = Color.FromHex("#FF071D66"); } }
        async void Zahoom_Clicked(object sender, EventArgs e) { if (Zahoom.BackgroundColor == Color.White) { Constantce.Area = "Zahoom"; Constantce.AreaLang = Zahoom.Text; Zahoom.TextColor = Color.White; Zahoom.BackgroundColor = Color.FromHex("#FF071D66"); var existingPages = Navigation.NavigationStack.ToList();Page page = existingPages.FirstOrDefault();Navigation.InsertPageBefore(new Home(), page);Navigation.RemovePage(page);await PopupNavigation.Instance.PopAsync(); } else { Constantce.Area = "Area"; Zahoom.BackgroundColor = Color.White; Zahoom.TextColor = Color.FromHex("#FF071D66"); } }
        async void Zahra_Clicked(object sender, EventArgs e) { if (Zahra.BackgroundColor == Color.White) { Constantce.Area = "Zahra"; Constantce.AreaLang = Zahra.Text; Zahra.TextColor = Color.White; Zahra.BackgroundColor = Color.FromHex("#FF071D66"); var existingPages = Navigation.NavigationStack.ToList();Page page = existingPages.FirstOrDefault();Navigation.InsertPageBefore(new Home(), page);Navigation.RemovePage(page);await PopupNavigation.Instance.PopAsync(); } else { Constantce.Area = "Area"; Zahra.BackgroundColor = Color.White; Zahra.TextColor = Color.FromHex("#FF071D66"); } }

    }
}