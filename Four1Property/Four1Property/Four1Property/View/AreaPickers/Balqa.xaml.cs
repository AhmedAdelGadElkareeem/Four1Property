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
    public partial class Balqa : PopupPage
    {
        public Balqa()
        {
            InitializeComponent();

            if (Application.Current.Properties["Language"].ToString() == "Arabic")
            {
                this.FlowDirection = FlowDirection.RightToLeft;
                UpText.Text = "الرجاء اختيار المنطقة";

                AbuEzzighan.Text = "ابو الزيغان";
                AbuHamed.Text = "ابو حامد";
                Debab.Text = "الدباب";
                Dhraissat.Text = "الضريسات";
                AinalBasha.Text = "عين الباشا";
                Azab.Text = "العزب";
                Balaooneh.Text = "البلاونة";
                BaqaaCamp.Text = "البقعة";
                Bwaib.Text = "البويب";
                Fuheis.Text = "الفحيص";
                Haqawah.Text = "الحقاوه";
                Heno.Text = "الحنو";
                Jaidiyyeh.Text = "الجعيدية";
                Kafrain.Text = "الكفرين";
                Karamah.Text = "الكرامة";
                Allan.Text = "علان";
                Msherfah.Text = "المشيرفة";
                Waseah.Text = "الوسية";
                Yazeediyyeh.Text = "اليزيدية";
                Ramah.Text = "الرامة";
                Roudhah.Text = "الروضة";
                Rmemen.Text = "الرميمين";
                Romman.Text = "الرمان";
                Rwaihah.Text = "الرويحة";
                ShewahiElGharbi.Text = "الشويحي الغربي";
                Sokhna.Text = "الشونة الجديدة; السكنه";
                ShoonahJanoobiyah.Text = "الشونة الجنوبية";
                Sahlooliyyeh.Text = "السحلولية";
                Saleehi.Text = "السليحي";
                Salt.Text = "السلط";
                Sbaihi.Text = "الصبيحي";
                TwalJanoobi.Text = "الطوال الجنوبي";
                TwalShamali.Text = "الطوال الشمالي";
                BayyoodahGharbiyyeh.Text = "بيوضه الغربيه";
                BayyoodahShamaliyyeh.Text = "بيوضه الشماليه";
                BayyoodahSharqiyyeh.Text = "بيوضه الشرقية";
                Damia.Text = "داميا";
                DeirAlla.Text = "دير علا";
                Dherar.Text = "ضرار";
                GhourKebed.Text = "غور كبد";
                Ira.Text = "عيرا";
                Jarriesh.Text = "جريش";
                JoafetElKafrain.Text = "جوفة الكفرين";
                Khashfeh.Text = "خشفه";
                Khazma.Text = "خزمة";
                Mahes.Text = "ماحص";
                Maisarah.Text = "ميسرا";
                MaisaratFannosh.Text = "ميسرة فنوش";
                Maddi.Text = "معدي";
                Moobes.Text = "موبص";
                MuthallathElArdhah.Text = "مثلث العارضة";
                MuthallathElMasri.Text = "مثلث المصري";
                KaretAbuNsair.Text = "قرية ابو نصير";
                Qsaib.Text = "قصيب";
                Safoot.Text = "صافوط";
                Salhoob.Text = "سلحوب";
                Siehan.Text = "سيحان";
                Soomia.Text = "سوميا";
                Swaimeh.Text = "سويمة";
                Elaiqoon.Text = "عليقون";
                UmmEdananier.Text = "ام الدنانير";
                UmmJauzeh.Text = "ام جوزة";
                UmmKarubah.Text = "ام خروبه";
                UmmNjasah.Text = "ام نجاصة";
                UmmSendyaneh.Text = "ام سنديانه";
                WadiElhoor.Text = "وادي الحور";
                WadiEnnaqah.Text = "وادي الناقه";
                WadiEssahn.Text = "وادي الصحن";
                Yarqha.Text = "يرقا";
                DhahretErramel.Text = "ظهرة الرمل";
                Zayy.Text = "زي";


            }
            else
            {
                this.FlowDirection = FlowDirection.LeftToRight;
                UpText.Text = "Please Select Area";

                AbuEzzighan.Text = "Abu Ezzighan";
                AbuHamed.Text = "Abu Hamed";
                Debab.Text = "Debab";
                Dhraissat.Text = "Dhraissat";
                AinalBasha.Text = "Ain al Basha";
                Azab.Text = "Azab";
                Balaooneh.Text = "Balaooneh";
                BaqaaCamp.Text = "Baqa'a Camp";
                Bwaib.Text = "Bwaib";
                Fuheis.Text = "Fuheis";
                Haqawah.Text = "Haqawah";
                Heno.Text = "Heno";
                Jaidiyyeh.Text = "Jaidiyyeh";
                Kafrain.Text = "Kafrain";
                Karamah.Text = "Karamah";
                Allan.Text = "Allan";
                Msherfah.Text = "Msherfah";
                Waseah.Text = "Waseah";
                Yazeediyyeh.Text = "Yazeediyyeh";
                Ramah.Text = "Ramah";
                Roudhah.Text = "Roudhah";
                Rmemen.Text = "Rmemen";
                Romman.Text = "Romman";
                Rwaihah.Text = "Rwaihah";
                ShewahiElGharbi.Text = "Shewahi El - Gharbi";
                Sokhna.Text = "Shoonah Jadideh, Sokhna";
                ShoonahJanoobiyah.Text = "Shoonah Janoobiyah";
                Sahlooliyyeh.Text = "Sahlooliyyeh";
                Saleehi.Text = "Saleehi";
                Salt.Text = "Salt";
                Sbaihi.Text = "Sbaihi";
                TwalJanoobi.Text = "Twal Janoobi";
                TwalShamali.Text = "Twal Shamali";
                BayyoodahGharbiyyeh.Text = "Bayyoodah Gharbiyyeh";
                BayyoodahShamaliyyeh.Text = "Bayyoodah Shamaliyyeh";
                BayyoodahSharqiyyeh.Text = "Bayyoodah Sharqiyyeh";
                Damia.Text = "Damia";
                DeirAlla.Text = "Deir Alla";
                Dherar.Text = "Dherar";
                GhourKebed.Text = "Ghour Kebed";
                Ira.Text = "Ira";
                Jarriesh.Text = "Jarriesh";
                JoafetElKafrain.Text = "Joafet El - Kafrain";
                Khashfeh.Text = "Khashfeh";
                Khazma.Text = "Khazma";
                Mahes.Text = "Mahes";
                Maisarah.Text = "Maisarah";
                MaisaratFannosh.Text = "Maisarat Fannosh";
                Maddi.Text = "M'addi";
                Moobes.Text = "Moobes";
                MuthallathElArdhah.Text = "Muthallath El - Ardhah";
                MuthallathElMasri.Text = "Muthallath El - Masri";
                KaretAbuNsair.Text = "Karet Abu Nsair";
                Qsaib.Text = "Qsaib";
                Safoot.Text = "Safoot";
                Salhoob.Text = "Salhoob";
                Siehan.Text = "Siehan";
                Soomia.Text = "Soomia";
                Swaimeh.Text = "Swaimeh";
                Elaiqoon.Text = "Elaiqoon";
                UmmEdananier.Text = "Umm Edananier";
                UmmJauzeh.Text = "Umm Jauzeh";
                UmmKarubah.Text = "Umm Karubah";
                UmmNjasah.Text = "Umm Njasah";
                UmmSendyaneh.Text = "Umm Sendyaneh";
                WadiElhoor.Text = "Wadi Elhoor";
                WadiEnnaqah.Text = "Wadi Ennaqah";
                WadiEssahn.Text = "Wadi Essahn";
                Yarqha.Text = "Yarqha";
                DhahretErramel.Text = "Dhahret Erramel";
                Zayy.Text = "Zayy";

            }
            if (Constantce.Area == "Abu Ezzighan") { AbuEzzighan.BackgroundColor = Color.FromHex("#FF071D66"); AbuEzzighan.TextColor = Color.White; }
            else if (Constantce.Area == "Abu Hamed") { AbuHamed.BackgroundColor = Color.FromHex("#FF071D66"); AbuHamed.TextColor = Color.White; }
            else if (Constantce.Area == "Debab") { Debab.BackgroundColor = Color.FromHex("#FF071D66"); Debab.TextColor = Color.White; }
            else if (Constantce.Area == "Dhraissat") { Dhraissat.BackgroundColor = Color.FromHex("#FF071D66"); Dhraissat.TextColor = Color.White; }
            else if (Constantce.Area == "Ain al Basha") { AinalBasha.BackgroundColor = Color.FromHex("#FF071D66"); AinalBasha.TextColor = Color.White; }
            else if (Constantce.Area == "Azab") { Azab.BackgroundColor = Color.FromHex("#FF071D66"); Azab.TextColor = Color.White; }
            else if (Constantce.Area == "Balaooneh") { Balaooneh.BackgroundColor = Color.FromHex("#FF071D66"); Balaooneh.TextColor = Color.White; }
            else if (Constantce.Area == "Baqa'a Camp") { BaqaaCamp.BackgroundColor = Color.FromHex("#FF071D66"); BaqaaCamp.TextColor = Color.White; }
            else if (Constantce.Area == "Bwaib") { Bwaib.BackgroundColor = Color.FromHex("#FF071D66"); Bwaib.TextColor = Color.White; }
            else if (Constantce.Area == "Fuheis") { Fuheis.BackgroundColor = Color.FromHex("#FF071D66"); Fuheis.TextColor = Color.White; }
            else if (Constantce.Area == "Haqawah") { Haqawah.BackgroundColor = Color.FromHex("#FF071D66"); Haqawah.TextColor = Color.White; }
            else if (Constantce.Area == "Heno") { Heno.BackgroundColor = Color.FromHex("#FF071D66"); Heno.TextColor = Color.White; }
            else if (Constantce.Area == "Jaidiyyeh") { Jaidiyyeh.BackgroundColor = Color.FromHex("#FF071D66"); Jaidiyyeh.TextColor = Color.White; }
            else if (Constantce.Area == "Kafrain") { Kafrain.BackgroundColor = Color.FromHex("#FF071D66"); Kafrain.TextColor = Color.White; }
            else if (Constantce.Area == "Karamah") { Karamah.BackgroundColor = Color.FromHex("#FF071D66"); Karamah.TextColor = Color.White; }
            else if (Constantce.Area == "Allan") { Allan.BackgroundColor = Color.FromHex("#FF071D66"); Allan.TextColor = Color.White; }
            else if (Constantce.Area == "Msherfah") { Msherfah.BackgroundColor = Color.FromHex("#FF071D66"); Msherfah.TextColor = Color.White; }
            else if (Constantce.Area == "Waseah") { Waseah.BackgroundColor = Color.FromHex("#FF071D66"); Waseah.TextColor = Color.White; }
            else if (Constantce.Area == "Yazeediyyeh") { Yazeediyyeh.BackgroundColor = Color.FromHex("#FF071D66"); Yazeediyyeh.TextColor = Color.White; }
            else if (Constantce.Area == "Ramah") { Ramah.BackgroundColor = Color.FromHex("#FF071D66"); Ramah.TextColor = Color.White; }
            else if (Constantce.Area == "Roudhah") { Roudhah.BackgroundColor = Color.FromHex("#FF071D66"); Roudhah.TextColor = Color.White; }
            else if (Constantce.Area == "Rmemen") { Rmemen.BackgroundColor = Color.FromHex("#FF071D66"); Rmemen.TextColor = Color.White; }
            else if (Constantce.Area == "Romman") { Romman.BackgroundColor = Color.FromHex("#FF071D66"); Romman.TextColor = Color.White; }
            else if (Constantce.Area == "Rwaihah") { Rwaihah.BackgroundColor = Color.FromHex("#FF071D66"); Rwaihah.TextColor = Color.White; }
            else if (Constantce.Area == "Shewahi El - Gharbi") { ShewahiElGharbi.BackgroundColor = Color.FromHex("#FF071D66"); ShewahiElGharbi.TextColor = Color.White; }
            else if (Constantce.Area == "Shoonah Jadideh, Sokhna") { Sokhna.BackgroundColor = Color.FromHex("#FF071D66"); Sokhna.TextColor = Color.White; }
            else if (Constantce.Area == "Shoonah Janoobiyah") { ShoonahJanoobiyah.BackgroundColor = Color.FromHex("#FF071D66"); ShoonahJanoobiyah.TextColor = Color.White; }
            else if (Constantce.Area == "Sahlooliyyeh") { Sahlooliyyeh.BackgroundColor = Color.FromHex("#FF071D66"); Sahlooliyyeh.TextColor = Color.White; }
            else if (Constantce.Area == "Saleehi") { Saleehi.BackgroundColor = Color.FromHex("#FF071D66"); Saleehi.TextColor = Color.White; }
            else if (Constantce.Area == "Salt") { Salt.BackgroundColor = Color.FromHex("#FF071D66"); Salt.TextColor = Color.White; }
            else if (Constantce.Area == "Sbaihi") { Sbaihi.BackgroundColor = Color.FromHex("#FF071D66"); Sbaihi.TextColor = Color.White; }
            else if (Constantce.Area == "Twal Janoobi") { TwalJanoobi.BackgroundColor = Color.FromHex("#FF071D66"); TwalJanoobi.TextColor = Color.White; }
            else if (Constantce.Area == "Twal Shamali") { TwalShamali.BackgroundColor = Color.FromHex("#FF071D66"); TwalShamali.TextColor = Color.White; }
            else if (Constantce.Area == "Bayyoodah Gharbiyyeh") { BayyoodahGharbiyyeh.BackgroundColor = Color.FromHex("#FF071D66"); BayyoodahGharbiyyeh.TextColor = Color.White; }
            else if (Constantce.Area == "Bayyoodah Shamaliyyeh") { BayyoodahShamaliyyeh.BackgroundColor = Color.FromHex("#FF071D66"); BayyoodahShamaliyyeh.TextColor = Color.White; }
            else if (Constantce.Area == "Bayyoodah Sharqiyyeh") { BayyoodahSharqiyyeh.BackgroundColor = Color.FromHex("#FF071D66"); BayyoodahSharqiyyeh.TextColor = Color.White; }
            else if (Constantce.Area == "Damia") { Damia.BackgroundColor = Color.FromHex("#FF071D66"); Damia.TextColor = Color.White; }
            else if (Constantce.Area == "Deir Alla") { DeirAlla.BackgroundColor = Color.FromHex("#FF071D66"); DeirAlla.TextColor = Color.White; }
            else if (Constantce.Area == "Dherar") { Dherar.BackgroundColor = Color.FromHex("#FF071D66"); Dherar.TextColor = Color.White; }
            else if (Constantce.Area == "Ghour Kebed") { GhourKebed.BackgroundColor = Color.FromHex("#FF071D66"); GhourKebed.TextColor = Color.White; }
            else if (Constantce.Area == "Ira") { Ira.BackgroundColor = Color.FromHex("#FF071D66"); Ira.TextColor = Color.White; }
            else if (Constantce.Area == "Jarriesh") { Jarriesh.BackgroundColor = Color.FromHex("#FF071D66"); Jarriesh.TextColor = Color.White; }
            else if (Constantce.Area == "Joafet El - Kafrain") { JoafetElKafrain.BackgroundColor = Color.FromHex("#FF071D66"); JoafetElKafrain.TextColor = Color.White; }
            else if (Constantce.Area == "Khashfeh") { Khashfeh.BackgroundColor = Color.FromHex("#FF071D66"); Khashfeh.TextColor = Color.White; }
            else if (Constantce.Area == "Khazma") { Khazma.BackgroundColor = Color.FromHex("#FF071D66"); Khazma.TextColor = Color.White; }
            else if (Constantce.Area == "Mahes") { Mahes.BackgroundColor = Color.FromHex("#FF071D66"); Mahes.TextColor = Color.White; }
            else if (Constantce.Area == "Maisarah") { Maisarah.BackgroundColor = Color.FromHex("#FF071D66"); Maisarah.TextColor = Color.White; }
            else if (Constantce.Area == "Maisarat Fannosh") { MaisaratFannosh.BackgroundColor = Color.FromHex("#FF071D66"); MaisaratFannosh.TextColor = Color.White; }
            else if (Constantce.Area == "M'addi") { Maddi.BackgroundColor = Color.FromHex("#FF071D66"); Maddi.TextColor = Color.White; }
            else if (Constantce.Area == "Moobes") { Moobes.BackgroundColor = Color.FromHex("#FF071D66"); Moobes.TextColor = Color.White; }
            else if (Constantce.Area == "Muthallath El - Ardhah") { MuthallathElArdhah.BackgroundColor = Color.FromHex("#FF071D66"); MuthallathElArdhah.TextColor = Color.White; }
            else if (Constantce.Area == "Muthallath El - Masri") { MuthallathElMasri.BackgroundColor = Color.FromHex("#FF071D66"); MuthallathElMasri.TextColor = Color.White; }
            else if (Constantce.Area == "Karet Abu Nsair") { KaretAbuNsair.BackgroundColor = Color.FromHex("#FF071D66"); KaretAbuNsair.TextColor = Color.White; }
            else if (Constantce.Area == "Qsaib") { Qsaib.BackgroundColor = Color.FromHex("#FF071D66"); Qsaib.TextColor = Color.White; }
            else if (Constantce.Area == "Safoot") { Safoot.BackgroundColor = Color.FromHex("#FF071D66"); Safoot.TextColor = Color.White; }
            else if (Constantce.Area == "Salhoob") { Salhoob.BackgroundColor = Color.FromHex("#FF071D66"); Salhoob.TextColor = Color.White; }
            else if (Constantce.Area == "Siehan") { Siehan.BackgroundColor = Color.FromHex("#FF071D66"); Siehan.TextColor = Color.White; }
            else if (Constantce.Area == "Soomia") { Soomia.BackgroundColor = Color.FromHex("#FF071D66"); Soomia.TextColor = Color.White; }
            else if (Constantce.Area == "Swaimeh") { Swaimeh.BackgroundColor = Color.FromHex("#FF071D66"); Swaimeh.TextColor = Color.White; }
            else if (Constantce.Area == "Elaiqoon") { Elaiqoon.BackgroundColor = Color.FromHex("#FF071D66"); Elaiqoon.TextColor = Color.White; }
            else if (Constantce.Area == "Umm Edananier") { UmmEdananier.BackgroundColor = Color.FromHex("#FF071D66"); UmmEdananier.TextColor = Color.White; }
            else if (Constantce.Area == "Umm Jauzeh") { UmmJauzeh.BackgroundColor = Color.FromHex("#FF071D66"); UmmJauzeh.TextColor = Color.White; }
            else if (Constantce.Area == "Umm Karubah") { UmmKarubah.BackgroundColor = Color.FromHex("#FF071D66"); UmmKarubah.TextColor = Color.White; }
            else if (Constantce.Area == "Umm Njasah") { UmmNjasah.BackgroundColor = Color.FromHex("#FF071D66"); UmmNjasah.TextColor = Color.White; }
            else if (Constantce.Area == "Umm Sendyaneh") { UmmSendyaneh.BackgroundColor = Color.FromHex("#FF071D66"); UmmSendyaneh.TextColor = Color.White; }
            else if (Constantce.Area == "Wadi Elhoor") { WadiElhoor.BackgroundColor = Color.FromHex("#FF071D66"); WadiElhoor.TextColor = Color.White; }
            else if (Constantce.Area == "Wadi Ennaqah") { WadiEnnaqah.BackgroundColor = Color.FromHex("#FF071D66"); WadiEnnaqah.TextColor = Color.White; }
            else if (Constantce.Area == "Wadi Essahn") { WadiEssahn.BackgroundColor = Color.FromHex("#FF071D66"); WadiEssahn.TextColor = Color.White; }
            else if (Constantce.Area == "Yarqha") { Yarqha.BackgroundColor = Color.FromHex("#FF071D66"); Yarqha.TextColor = Color.White; }
            else if (Constantce.Area == "Dhahret Erramel") { DhahretErramel.BackgroundColor = Color.FromHex("#FF071D66"); DhahretErramel.TextColor = Color.White; }
            else if (Constantce.Area == "Zayy") { Zayy.BackgroundColor = Color.FromHex("#FF071D66"); Zayy.TextColor = Color.White; }







        }

        //******************************start Balqa Areas**********************************************************************
        async void AbuEzzighan_Clicked(object sender, EventArgs e) { if (AbuEzzighan.BackgroundColor == Color.White) { Constantce.Area = "Abu Ezzighan"; Constantce.AreaLang = AbuEzzighan.Text; AbuEzzighan.TextColor = Color.White; AbuEzzighan.BackgroundColor = Color.FromHex("#FF071D66"); var existingPages = Navigation.NavigationStack.ToList();Page page = existingPages.FirstOrDefault();Navigation.InsertPageBefore(new Home(), page);Navigation.RemovePage(page);await PopupNavigation.Instance.PopAsync(); } else { Constantce.Area = "Area"; AbuEzzighan.BackgroundColor = Color.White; AbuEzzighan.TextColor = Color.FromHex("#FF071D66"); } }
        async void AbuHamed_Clicked(object sender, EventArgs e) { if (AbuHamed.BackgroundColor == Color.White) { Constantce.Area = "Abu Hamed"; Constantce.AreaLang = AbuHamed.Text; AbuHamed.TextColor = Color.White; AbuHamed.BackgroundColor = Color.FromHex("#FF071D66"); var existingPages = Navigation.NavigationStack.ToList();Page page = existingPages.FirstOrDefault();Navigation.InsertPageBefore(new Home(), page);Navigation.RemovePage(page);await PopupNavigation.Instance.PopAsync(); } else { Constantce.Area = "Area"; AbuHamed.BackgroundColor = Color.White; AbuHamed.TextColor = Color.FromHex("#FF071D66"); } }
        async void Debab_Clicked(object sender, EventArgs e) { if (Debab.BackgroundColor == Color.White) { Constantce.Area = "Debab"; Constantce.AreaLang = Debab.Text; Debab.TextColor = Color.White; Debab.BackgroundColor = Color.FromHex("#FF071D66"); var existingPages = Navigation.NavigationStack.ToList();Page page = existingPages.FirstOrDefault();Navigation.InsertPageBefore(new Home(), page);Navigation.RemovePage(page);await PopupNavigation.Instance.PopAsync(); } else { Constantce.Area = "Area"; Debab.BackgroundColor = Color.White; Debab.TextColor = Color.FromHex("#FF071D66"); } }
        async void Dhraissat_Clicked(object sender, EventArgs e) { if (Dhraissat.BackgroundColor == Color.White) { Constantce.Area = "Dhraissat"; Constantce.AreaLang = Dhraissat.Text; Dhraissat.TextColor = Color.White; Dhraissat.BackgroundColor = Color.FromHex("#FF071D66"); var existingPages = Navigation.NavigationStack.ToList();Page page = existingPages.FirstOrDefault();Navigation.InsertPageBefore(new Home(), page);Navigation.RemovePage(page);await PopupNavigation.Instance.PopAsync(); } else { Constantce.Area = "Area"; Dhraissat.BackgroundColor = Color.White; Dhraissat.TextColor = Color.FromHex("#FF071D66"); } }
        async void AinalBasha_Clicked(object sender, EventArgs e) { if (AinalBasha.BackgroundColor == Color.White) { Constantce.Area = "Ain al Basha"; Constantce.AreaLang = AinalBasha.Text; AinalBasha.TextColor = Color.White; AinalBasha.BackgroundColor = Color.FromHex("#FF071D66"); var existingPages = Navigation.NavigationStack.ToList();Page page = existingPages.FirstOrDefault();Navigation.InsertPageBefore(new Home(), page);Navigation.RemovePage(page);await PopupNavigation.Instance.PopAsync(); } else { Constantce.Area = "Area"; AinalBasha.BackgroundColor = Color.White; AinalBasha.TextColor = Color.FromHex("#FF071D66"); } }
        async void Azab_Clicked(object sender, EventArgs e) { if (Azab.BackgroundColor == Color.White) { Constantce.Area = "Azab"; Constantce.AreaLang = Azab.Text; Azab.TextColor = Color.White; Azab.BackgroundColor = Color.FromHex("#FF071D66"); var existingPages = Navigation.NavigationStack.ToList();Page page = existingPages.FirstOrDefault();Navigation.InsertPageBefore(new Home(), page);Navigation.RemovePage(page);await PopupNavigation.Instance.PopAsync(); } else { Constantce.Area = "Area"; Azab.BackgroundColor = Color.White; Azab.TextColor = Color.FromHex("#FF071D66"); } }
        async void Balaooneh_Clicked(object sender, EventArgs e) { if (Balaooneh.BackgroundColor == Color.White) { Constantce.Area = "Balaooneh"; Constantce.AreaLang = Balaooneh.Text; Balaooneh.TextColor = Color.White; Balaooneh.BackgroundColor = Color.FromHex("#FF071D66"); var existingPages = Navigation.NavigationStack.ToList();Page page = existingPages.FirstOrDefault();Navigation.InsertPageBefore(new Home(), page);Navigation.RemovePage(page);await PopupNavigation.Instance.PopAsync(); } else { Constantce.Area = "Area"; Balaooneh.BackgroundColor = Color.White; Balaooneh.TextColor = Color.FromHex("#FF071D66"); } }
        async void BaqaaCamp_Clicked(object sender, EventArgs e) { if (BaqaaCamp.BackgroundColor == Color.White) { Constantce.Area = "Baqa'a Camp"; Constantce.AreaLang = BaqaaCamp.Text; BaqaaCamp.TextColor = Color.White; BaqaaCamp.BackgroundColor = Color.FromHex("#FF071D66"); var existingPages = Navigation.NavigationStack.ToList();Page page = existingPages.FirstOrDefault();Navigation.InsertPageBefore(new Home(), page);Navigation.RemovePage(page);await PopupNavigation.Instance.PopAsync(); } else { Constantce.Area = "Area"; BaqaaCamp.BackgroundColor = Color.White; BaqaaCamp.TextColor = Color.FromHex("#FF071D66"); } }
        async void Bwaib_Clicked(object sender, EventArgs e) { if (Bwaib.BackgroundColor == Color.White) { Constantce.Area = "Bwaib"; Constantce.AreaLang = Bwaib.Text; Bwaib.TextColor = Color.White; Bwaib.BackgroundColor = Color.FromHex("#FF071D66"); var existingPages = Navigation.NavigationStack.ToList();Page page = existingPages.FirstOrDefault();Navigation.InsertPageBefore(new Home(), page);Navigation.RemovePage(page);await PopupNavigation.Instance.PopAsync(); } else { Constantce.Area = "Area"; Bwaib.BackgroundColor = Color.White; Bwaib.TextColor = Color.FromHex("#FF071D66"); } }
        async void Fuheis_Clicked(object sender, EventArgs e) { if (Fuheis.BackgroundColor == Color.White) { Constantce.Area = "Fuheis"; Constantce.AreaLang = Fuheis.Text; Fuheis.TextColor = Color.White; Fuheis.BackgroundColor = Color.FromHex("#FF071D66"); var existingPages = Navigation.NavigationStack.ToList();Page page = existingPages.FirstOrDefault();Navigation.InsertPageBefore(new Home(), page);Navigation.RemovePage(page);await PopupNavigation.Instance.PopAsync(); } else { Constantce.Area = "Area"; Fuheis.BackgroundColor = Color.White; Fuheis.TextColor = Color.FromHex("#FF071D66"); } }
        async void Haqawah_Clicked(object sender, EventArgs e) { if (Haqawah.BackgroundColor == Color.White) { Constantce.Area = "Haqawah"; Constantce.AreaLang = Haqawah.Text; Haqawah.TextColor = Color.White; Haqawah.BackgroundColor = Color.FromHex("#FF071D66"); var existingPages = Navigation.NavigationStack.ToList();Page page = existingPages.FirstOrDefault();Navigation.InsertPageBefore(new Home(), page);Navigation.RemovePage(page);await PopupNavigation.Instance.PopAsync(); } else { Constantce.Area = "Area"; Haqawah.BackgroundColor = Color.White; Haqawah.TextColor = Color.FromHex("#FF071D66"); } }
        async void Heno_Clicked(object sender, EventArgs e) { if (Heno.BackgroundColor == Color.White) { Constantce.Area = "Heno"; Constantce.AreaLang = Heno.Text; Heno.TextColor = Color.White; Heno.BackgroundColor = Color.FromHex("#FF071D66"); var existingPages = Navigation.NavigationStack.ToList();Page page = existingPages.FirstOrDefault();Navigation.InsertPageBefore(new Home(), page);Navigation.RemovePage(page);await PopupNavigation.Instance.PopAsync(); } else { Constantce.Area = "Area"; Heno.BackgroundColor = Color.White; Heno.TextColor = Color.FromHex("#FF071D66"); } }
        async void Jaidiyyeh_Clicked(object sender, EventArgs e) { if (Jaidiyyeh.BackgroundColor == Color.White) { Constantce.Area = "Jaidiyyeh"; Constantce.AreaLang = Jaidiyyeh.Text; Jaidiyyeh.TextColor = Color.White; Jaidiyyeh.BackgroundColor = Color.FromHex("#FF071D66"); var existingPages = Navigation.NavigationStack.ToList();Page page = existingPages.FirstOrDefault();Navigation.InsertPageBefore(new Home(), page);Navigation.RemovePage(page);await PopupNavigation.Instance.PopAsync(); } else { Constantce.Area = "Area"; Jaidiyyeh.BackgroundColor = Color.White; Jaidiyyeh.TextColor = Color.FromHex("#FF071D66"); } }
        async void Kafrain_Clicked(object sender, EventArgs e) { if (Kafrain.BackgroundColor == Color.White) { Constantce.Area = "Kafrain"; Constantce.AreaLang = Kafrain.Text; Kafrain.TextColor = Color.White; Kafrain.BackgroundColor = Color.FromHex("#FF071D66"); var existingPages = Navigation.NavigationStack.ToList();Page page = existingPages.FirstOrDefault();Navigation.InsertPageBefore(new Home(), page);Navigation.RemovePage(page);await PopupNavigation.Instance.PopAsync(); } else { Constantce.Area = "Area"; Kafrain.BackgroundColor = Color.White; Kafrain.TextColor = Color.FromHex("#FF071D66"); } }
        async void Karamah_Clicked(object sender, EventArgs e) { if (Karamah.BackgroundColor == Color.White) { Constantce.Area = "Karamah"; Constantce.AreaLang = Karamah.Text; Karamah.TextColor = Color.White; Karamah.BackgroundColor = Color.FromHex("#FF071D66"); var existingPages = Navigation.NavigationStack.ToList();Page page = existingPages.FirstOrDefault();Navigation.InsertPageBefore(new Home(), page);Navigation.RemovePage(page);await PopupNavigation.Instance.PopAsync(); } else { Constantce.Area = "Area"; Karamah.BackgroundColor = Color.White; Karamah.TextColor = Color.FromHex("#FF071D66"); } }
        async void Allan_Clicked(object sender, EventArgs e) { if (Allan.BackgroundColor == Color.White) { Constantce.Area = "Allan"; Constantce.AreaLang = Allan.Text; Allan.TextColor = Color.White; Allan.BackgroundColor = Color.FromHex("#FF071D66"); var existingPages = Navigation.NavigationStack.ToList();Page page = existingPages.FirstOrDefault();Navigation.InsertPageBefore(new Home(), page);Navigation.RemovePage(page);await PopupNavigation.Instance.PopAsync(); } else { Constantce.Area = "Area"; Allan.BackgroundColor = Color.White; Allan.TextColor = Color.FromHex("#FF071D66"); } }
        async void Msherfah_Clicked(object sender, EventArgs e) { if (Msherfah.BackgroundColor == Color.White) { Constantce.Area = "Msherfah"; Constantce.AreaLang = Msherfah.Text; Msherfah.TextColor = Color.White; Msherfah.BackgroundColor = Color.FromHex("#FF071D66"); var existingPages = Navigation.NavigationStack.ToList();Page page = existingPages.FirstOrDefault();Navigation.InsertPageBefore(new Home(), page);Navigation.RemovePage(page);await PopupNavigation.Instance.PopAsync(); } else { Constantce.Area = "Area"; Msherfah.BackgroundColor = Color.White; Msherfah.TextColor = Color.FromHex("#FF071D66"); } }
        async void Waseah_Clicked(object sender, EventArgs e) { if (Waseah.BackgroundColor == Color.White) { Constantce.Area = "Waseah"; Constantce.AreaLang = Waseah.Text; Waseah.TextColor = Color.White; Waseah.BackgroundColor = Color.FromHex("#FF071D66"); var existingPages = Navigation.NavigationStack.ToList();Page page = existingPages.FirstOrDefault();Navigation.InsertPageBefore(new Home(), page);Navigation.RemovePage(page);await PopupNavigation.Instance.PopAsync(); } else { Constantce.Area = "Area"; Waseah.BackgroundColor = Color.White; Waseah.TextColor = Color.FromHex("#FF071D66"); } }
        async void Yazeediyyeh_Clicked(object sender, EventArgs e) { if (Yazeediyyeh.BackgroundColor == Color.White) { Constantce.Area = "Yazeediyyeh"; Constantce.AreaLang = Yazeediyyeh.Text; Yazeediyyeh.TextColor = Color.White; Yazeediyyeh.BackgroundColor = Color.FromHex("#FF071D66"); var existingPages = Navigation.NavigationStack.ToList();Page page = existingPages.FirstOrDefault();Navigation.InsertPageBefore(new Home(), page);Navigation.RemovePage(page);await PopupNavigation.Instance.PopAsync(); } else { Constantce.Area = "Area"; Yazeediyyeh.BackgroundColor = Color.White; Yazeediyyeh.TextColor = Color.FromHex("#FF071D66"); } }
        async void Ramah_Clicked(object sender, EventArgs e) { if (Ramah.BackgroundColor == Color.White) { Constantce.Area = "Ramah"; Constantce.AreaLang = Ramah.Text; Ramah.TextColor = Color.White; Ramah.BackgroundColor = Color.FromHex("#FF071D66"); var existingPages = Navigation.NavigationStack.ToList();Page page = existingPages.FirstOrDefault();Navigation.InsertPageBefore(new Home(), page);Navigation.RemovePage(page);await PopupNavigation.Instance.PopAsync(); } else { Constantce.Area = "Area"; Ramah.BackgroundColor = Color.White; Ramah.TextColor = Color.FromHex("#FF071D66"); } }
        async void Roudhah_Clicked(object sender, EventArgs e) { if (Roudhah.BackgroundColor == Color.White) { Constantce.Area = "Roudhah"; Constantce.AreaLang = Roudhah.Text; Roudhah.TextColor = Color.White; Roudhah.BackgroundColor = Color.FromHex("#FF071D66"); var existingPages = Navigation.NavigationStack.ToList();Page page = existingPages.FirstOrDefault();Navigation.InsertPageBefore(new Home(), page);Navigation.RemovePage(page);await PopupNavigation.Instance.PopAsync(); } else { Constantce.Area = "Area"; Roudhah.BackgroundColor = Color.White; Roudhah.TextColor = Color.FromHex("#FF071D66"); } }
        async void Rmemen_Clicked(object sender, EventArgs e) { if (Rmemen.BackgroundColor == Color.White) { Constantce.Area = "Rmemen"; Constantce.AreaLang = Rmemen.Text; Rmemen.TextColor = Color.White; Rmemen.BackgroundColor = Color.FromHex("#FF071D66"); var existingPages = Navigation.NavigationStack.ToList();Page page = existingPages.FirstOrDefault();Navigation.InsertPageBefore(new Home(), page);Navigation.RemovePage(page);await PopupNavigation.Instance.PopAsync(); } else { Constantce.Area = "Area"; Rmemen.BackgroundColor = Color.White; Rmemen.TextColor = Color.FromHex("#FF071D66"); } }
        async void Romman_Clicked(object sender, EventArgs e) { if (Romman.BackgroundColor == Color.White) { Constantce.Area = "Romman"; Constantce.AreaLang = Romman.Text; Romman.TextColor = Color.White; Romman.BackgroundColor = Color.FromHex("#FF071D66"); var existingPages = Navigation.NavigationStack.ToList();Page page = existingPages.FirstOrDefault();Navigation.InsertPageBefore(new Home(), page);Navigation.RemovePage(page);await PopupNavigation.Instance.PopAsync(); } else { Constantce.Area = "Area"; Romman.BackgroundColor = Color.White; Romman.TextColor = Color.FromHex("#FF071D66"); } }
        async void Rwaihah_Clicked(object sender, EventArgs e) { if (Rwaihah.BackgroundColor == Color.White) { Constantce.Area = "Rwaihah"; Constantce.AreaLang = Rwaihah.Text; Rwaihah.TextColor = Color.White; Rwaihah.BackgroundColor = Color.FromHex("#FF071D66"); var existingPages = Navigation.NavigationStack.ToList();Page page = existingPages.FirstOrDefault();Navigation.InsertPageBefore(new Home(), page);Navigation.RemovePage(page);await PopupNavigation.Instance.PopAsync(); } else { Constantce.Area = "Area"; Rwaihah.BackgroundColor = Color.White; Rwaihah.TextColor = Color.FromHex("#FF071D66"); } }
        async void ShewahiElGharbi_Clicked(object sender, EventArgs e) { if (ShewahiElGharbi.BackgroundColor == Color.White) { Constantce.Area = "Shewahi El - Gharbi"; Constantce.AreaLang = ShewahiElGharbi.Text; ShewahiElGharbi.TextColor = Color.White; ShewahiElGharbi.BackgroundColor = Color.FromHex("#FF071D66"); var existingPages = Navigation.NavigationStack.ToList();Page page = existingPages.FirstOrDefault();Navigation.InsertPageBefore(new Home(), page);Navigation.RemovePage(page);await PopupNavigation.Instance.PopAsync(); } else { Constantce.Area = "Area"; ShewahiElGharbi.BackgroundColor = Color.White; ShewahiElGharbi.TextColor = Color.FromHex("#FF071D66"); } }
        async void Sokhna_Clicked(object sender, EventArgs e) { if (Sokhna.BackgroundColor == Color.White) { Constantce.Area = "Shoonah Jadideh, Sokhna"; Constantce.AreaLang = Sokhna.Text; Sokhna.TextColor = Color.White; Sokhna.BackgroundColor = Color.FromHex("#FF071D66"); var existingPages = Navigation.NavigationStack.ToList();Page page = existingPages.FirstOrDefault();Navigation.InsertPageBefore(new Home(), page);Navigation.RemovePage(page);await PopupNavigation.Instance.PopAsync(); } else { Constantce.Area = "Area"; Sokhna.BackgroundColor = Color.White; Sokhna.TextColor = Color.FromHex("#FF071D66"); } }
        async void ShoonahJanoobiyah_Clicked(object sender, EventArgs e) { if (ShoonahJanoobiyah.BackgroundColor == Color.White) { Constantce.Area = "Shoonah Janoobiyah"; Constantce.AreaLang = ShoonahJanoobiyah.Text; ShoonahJanoobiyah.TextColor = Color.White; ShoonahJanoobiyah.BackgroundColor = Color.FromHex("#FF071D66"); var existingPages = Navigation.NavigationStack.ToList();Page page = existingPages.FirstOrDefault();Navigation.InsertPageBefore(new Home(), page);Navigation.RemovePage(page);await PopupNavigation.Instance.PopAsync(); } else { Constantce.Area = "Area"; ShoonahJanoobiyah.BackgroundColor = Color.White; ShoonahJanoobiyah.TextColor = Color.FromHex("#FF071D66"); } }
        async void Sahlooliyyeh_Clicked(object sender, EventArgs e) { if (Sahlooliyyeh.BackgroundColor == Color.White) { Constantce.Area = "Sahlooliyyeh"; Constantce.AreaLang = Sahlooliyyeh.Text; Sahlooliyyeh.TextColor = Color.White; Sahlooliyyeh.BackgroundColor = Color.FromHex("#FF071D66"); var existingPages = Navigation.NavigationStack.ToList();Page page = existingPages.FirstOrDefault();Navigation.InsertPageBefore(new Home(), page);Navigation.RemovePage(page);await PopupNavigation.Instance.PopAsync(); } else { Constantce.Area = "Area"; Sahlooliyyeh.BackgroundColor = Color.White; Sahlooliyyeh.TextColor = Color.FromHex("#FF071D66"); } }
        async void Saleehi_Clicked(object sender, EventArgs e) { if (Saleehi.BackgroundColor == Color.White) { Constantce.Area = "Saleehi"; Constantce.AreaLang = Saleehi.Text; Saleehi.TextColor = Color.White; Saleehi.BackgroundColor = Color.FromHex("#FF071D66"); var existingPages = Navigation.NavigationStack.ToList();Page page = existingPages.FirstOrDefault();Navigation.InsertPageBefore(new Home(), page);Navigation.RemovePage(page);await PopupNavigation.Instance.PopAsync(); } else { Constantce.Area = "Area"; Saleehi.BackgroundColor = Color.White; Saleehi.TextColor = Color.FromHex("#FF071D66"); } }
        async void Salt_Clicked(object sender, EventArgs e) { if (Salt.BackgroundColor == Color.White) { Constantce.Area = "Salt"; Constantce.AreaLang = Salt.Text; Salt.TextColor = Color.White; Salt.BackgroundColor = Color.FromHex("#FF071D66"); var existingPages = Navigation.NavigationStack.ToList();Page page = existingPages.FirstOrDefault();Navigation.InsertPageBefore(new Home(), page);Navigation.RemovePage(page);await PopupNavigation.Instance.PopAsync(); } else { Constantce.Area = "Area"; Salt.BackgroundColor = Color.White; Salt.TextColor = Color.FromHex("#FF071D66"); } }
        async void Sbaihi_Clicked(object sender, EventArgs e) { if (Sbaihi.BackgroundColor == Color.White) { Constantce.Area = "Sbaihi"; Constantce.AreaLang = Sbaihi.Text; Sbaihi.TextColor = Color.White; Sbaihi.BackgroundColor = Color.FromHex("#FF071D66"); var existingPages = Navigation.NavigationStack.ToList();Page page = existingPages.FirstOrDefault();Navigation.InsertPageBefore(new Home(), page);Navigation.RemovePage(page);await PopupNavigation.Instance.PopAsync(); } else { Constantce.Area = "Area"; Sbaihi.BackgroundColor = Color.White; Sbaihi.TextColor = Color.FromHex("#FF071D66"); } }
        async void TwalJanoobi_Clicked(object sender, EventArgs e) { if (TwalJanoobi.BackgroundColor == Color.White) { Constantce.Area = "Twal Janoobi"; Constantce.AreaLang = TwalJanoobi.Text; TwalJanoobi.TextColor = Color.White; TwalJanoobi.BackgroundColor = Color.FromHex("#FF071D66"); var existingPages = Navigation.NavigationStack.ToList();Page page = existingPages.FirstOrDefault();Navigation.InsertPageBefore(new Home(), page);Navigation.RemovePage(page);await PopupNavigation.Instance.PopAsync(); } else { Constantce.Area = "Area"; TwalJanoobi.BackgroundColor = Color.White; TwalJanoobi.TextColor = Color.FromHex("#FF071D66"); } }
        async void TwalShamali_Clicked(object sender, EventArgs e) { if (TwalShamali.BackgroundColor == Color.White) { Constantce.Area = "Twal Shamali"; Constantce.AreaLang = TwalShamali.Text; TwalShamali.TextColor = Color.White; TwalShamali.BackgroundColor = Color.FromHex("#FF071D66"); var existingPages = Navigation.NavigationStack.ToList();Page page = existingPages.FirstOrDefault();Navigation.InsertPageBefore(new Home(), page);Navigation.RemovePage(page);await PopupNavigation.Instance.PopAsync(); } else { Constantce.Area = "Area"; TwalShamali.BackgroundColor = Color.White; TwalShamali.TextColor = Color.FromHex("#FF071D66"); } }
        async void BayyoodahGharbiyyeh_Clicked(object sender, EventArgs e) { if (BayyoodahGharbiyyeh.BackgroundColor == Color.White) { Constantce.Area = "Bayyoodah Gharbiyyeh"; Constantce.AreaLang = BayyoodahGharbiyyeh.Text; BayyoodahGharbiyyeh.TextColor = Color.White; BayyoodahGharbiyyeh.BackgroundColor = Color.FromHex("#FF071D66"); var existingPages = Navigation.NavigationStack.ToList();Page page = existingPages.FirstOrDefault();Navigation.InsertPageBefore(new Home(), page);Navigation.RemovePage(page);await PopupNavigation.Instance.PopAsync(); } else { Constantce.Area = "Area"; BayyoodahGharbiyyeh.BackgroundColor = Color.White; BayyoodahGharbiyyeh.TextColor = Color.FromHex("#FF071D66"); } }
        async void BayyoodahShamaliyyeh_Clicked(object sender, EventArgs e) { if (BayyoodahShamaliyyeh.BackgroundColor == Color.White) { Constantce.Area = "Bayyoodah Shamaliyyeh"; Constantce.AreaLang = BayyoodahShamaliyyeh.Text; BayyoodahShamaliyyeh.TextColor = Color.White; BayyoodahShamaliyyeh.BackgroundColor = Color.FromHex("#FF071D66"); var existingPages = Navigation.NavigationStack.ToList();Page page = existingPages.FirstOrDefault();Navigation.InsertPageBefore(new Home(), page);Navigation.RemovePage(page);await PopupNavigation.Instance.PopAsync(); } else { Constantce.Area = "Area"; BayyoodahShamaliyyeh.BackgroundColor = Color.White; BayyoodahShamaliyyeh.TextColor = Color.FromHex("#FF071D66"); } }
        async void BayyoodahSharqiyyeh_Clicked(object sender, EventArgs e) { if (BayyoodahSharqiyyeh.BackgroundColor == Color.White) { Constantce.Area = "Bayyoodah Sharqiyyeh"; Constantce.AreaLang = BayyoodahSharqiyyeh.Text; BayyoodahSharqiyyeh.TextColor = Color.White; BayyoodahSharqiyyeh.BackgroundColor = Color.FromHex("#FF071D66"); var existingPages = Navigation.NavigationStack.ToList();Page page = existingPages.FirstOrDefault();Navigation.InsertPageBefore(new Home(), page);Navigation.RemovePage(page);await PopupNavigation.Instance.PopAsync(); } else { Constantce.Area = "Area"; BayyoodahSharqiyyeh.BackgroundColor = Color.White; BayyoodahSharqiyyeh.TextColor = Color.FromHex("#FF071D66"); } }
        async void Damia_Clicked(object sender, EventArgs e) { if (Damia.BackgroundColor == Color.White) { Constantce.Area = "Damia"; Constantce.AreaLang = Damia.Text; Damia.TextColor = Color.White; Damia.BackgroundColor = Color.FromHex("#FF071D66"); var existingPages = Navigation.NavigationStack.ToList();Page page = existingPages.FirstOrDefault();Navigation.InsertPageBefore(new Home(), page);Navigation.RemovePage(page);await PopupNavigation.Instance.PopAsync(); } else { Constantce.Area = "Area"; Damia.BackgroundColor = Color.White; Damia.TextColor = Color.FromHex("#FF071D66"); } }
        async void DeirAlla_Clicked(object sender, EventArgs e) { if (DeirAlla.BackgroundColor == Color.White) { Constantce.Area = "Deir Alla"; Constantce.AreaLang = DeirAlla.Text; DeirAlla.TextColor = Color.White; DeirAlla.BackgroundColor = Color.FromHex("#FF071D66"); var existingPages = Navigation.NavigationStack.ToList();Page page = existingPages.FirstOrDefault();Navigation.InsertPageBefore(new Home(), page);Navigation.RemovePage(page);await PopupNavigation.Instance.PopAsync(); } else { Constantce.Area = "Area"; DeirAlla.BackgroundColor = Color.White; DeirAlla.TextColor = Color.FromHex("#FF071D66"); } }
        async void Dherar_Clicked(object sender, EventArgs e) { if (Dherar.BackgroundColor == Color.White) { Constantce.Area = "Dherar"; Constantce.AreaLang = Dherar.Text; Dherar.TextColor = Color.White; Dherar.BackgroundColor = Color.FromHex("#FF071D66"); var existingPages = Navigation.NavigationStack.ToList();Page page = existingPages.FirstOrDefault();Navigation.InsertPageBefore(new Home(), page);Navigation.RemovePage(page);await PopupNavigation.Instance.PopAsync(); } else { Constantce.Area = "Area"; Dherar.BackgroundColor = Color.White; Dherar.TextColor = Color.FromHex("#FF071D66"); } }
        async void GhourKebed_Clicked(object sender, EventArgs e) { if (GhourKebed.BackgroundColor == Color.White) { Constantce.Area = "Ghour Kebed"; Constantce.AreaLang = GhourKebed.Text; GhourKebed.TextColor = Color.White; GhourKebed.BackgroundColor = Color.FromHex("#FF071D66"); var existingPages = Navigation.NavigationStack.ToList();Page page = existingPages.FirstOrDefault();Navigation.InsertPageBefore(new Home(), page);Navigation.RemovePage(page);await PopupNavigation.Instance.PopAsync(); } else { Constantce.Area = "Area"; GhourKebed.BackgroundColor = Color.White; GhourKebed.TextColor = Color.FromHex("#FF071D66"); } }
        async void Ira_Clicked(object sender, EventArgs e) { if (Ira.BackgroundColor == Color.White) { Constantce.Area = "Ira"; Constantce.AreaLang = Ira.Text; Ira.TextColor = Color.White; Ira.BackgroundColor = Color.FromHex("#FF071D66"); var existingPages = Navigation.NavigationStack.ToList();Page page = existingPages.FirstOrDefault();Navigation.InsertPageBefore(new Home(), page);Navigation.RemovePage(page);await PopupNavigation.Instance.PopAsync(); } else { Constantce.Area = "Area"; Ira.BackgroundColor = Color.White; Ira.TextColor = Color.FromHex("#FF071D66"); } }
        async void Jarriesh_Clicked(object sender, EventArgs e) { if (Jarriesh.BackgroundColor == Color.White) { Constantce.Area = "Jarriesh"; Constantce.AreaLang = Jarriesh.Text; Jarriesh.TextColor = Color.White; Jarriesh.BackgroundColor = Color.FromHex("#FF071D66"); var existingPages = Navigation.NavigationStack.ToList();Page page = existingPages.FirstOrDefault();Navigation.InsertPageBefore(new Home(), page);Navigation.RemovePage(page);await PopupNavigation.Instance.PopAsync(); } else { Constantce.Area = "Area"; Jarriesh.BackgroundColor = Color.White; Jarriesh.TextColor = Color.FromHex("#FF071D66"); } }
        async void JoafetElKafrain_Clicked(object sender, EventArgs e) { if (JoafetElKafrain.BackgroundColor == Color.White) { Constantce.Area = "Joafet El - Kafrain"; Constantce.AreaLang = JoafetElKafrain.Text; JoafetElKafrain.TextColor = Color.White; JoafetElKafrain.BackgroundColor = Color.FromHex("#FF071D66"); var existingPages = Navigation.NavigationStack.ToList();Page page = existingPages.FirstOrDefault();Navigation.InsertPageBefore(new Home(), page);Navigation.RemovePage(page);await PopupNavigation.Instance.PopAsync(); } else { Constantce.Area = "Area"; JoafetElKafrain.BackgroundColor = Color.White; JoafetElKafrain.TextColor = Color.FromHex("#FF071D66"); } }
        async void Khashfeh_Clicked(object sender, EventArgs e) { if (Khashfeh.BackgroundColor == Color.White) { Constantce.Area = "Khashfeh"; Constantce.AreaLang = Khashfeh.Text; Khashfeh.TextColor = Color.White; Khashfeh.BackgroundColor = Color.FromHex("#FF071D66"); var existingPages = Navigation.NavigationStack.ToList();Page page = existingPages.FirstOrDefault();Navigation.InsertPageBefore(new Home(), page);Navigation.RemovePage(page);await PopupNavigation.Instance.PopAsync(); } else { Constantce.Area = "Area"; Khashfeh.BackgroundColor = Color.White; Khashfeh.TextColor = Color.FromHex("#FF071D66"); } }
        async void Khazma_Clicked(object sender, EventArgs e) { if (Khazma.BackgroundColor == Color.White) { Constantce.Area = "Khazma"; Constantce.AreaLang = Khazma.Text; Khazma.TextColor = Color.White; Khazma.BackgroundColor = Color.FromHex("#FF071D66"); var existingPages = Navigation.NavigationStack.ToList();Page page = existingPages.FirstOrDefault();Navigation.InsertPageBefore(new Home(), page);Navigation.RemovePage(page);await PopupNavigation.Instance.PopAsync(); } else { Constantce.Area = "Area"; Khazma.BackgroundColor = Color.White; Khazma.TextColor = Color.FromHex("#FF071D66"); } }
        async void Mahes_Clicked(object sender, EventArgs e) { if (Mahes.BackgroundColor == Color.White) { Constantce.Area = "Mahes"; Constantce.AreaLang = Mahes.Text; Mahes.TextColor = Color.White; Mahes.BackgroundColor = Color.FromHex("#FF071D66"); var existingPages = Navigation.NavigationStack.ToList();Page page = existingPages.FirstOrDefault();Navigation.InsertPageBefore(new Home(), page);Navigation.RemovePage(page);await PopupNavigation.Instance.PopAsync(); } else { Constantce.Area = "Area"; Mahes.BackgroundColor = Color.White; Mahes.TextColor = Color.FromHex("#FF071D66"); } }
        async void Maisarah_Clicked(object sender, EventArgs e) { if (Maisarah.BackgroundColor == Color.White) { Constantce.Area = "Maisarah"; Constantce.AreaLang = Maisarah.Text; Maisarah.TextColor = Color.White; Maisarah.BackgroundColor = Color.FromHex("#FF071D66"); var existingPages = Navigation.NavigationStack.ToList();Page page = existingPages.FirstOrDefault();Navigation.InsertPageBefore(new Home(), page);Navigation.RemovePage(page);await PopupNavigation.Instance.PopAsync(); } else { Constantce.Area = "Area"; Maisarah.BackgroundColor = Color.White; Maisarah.TextColor = Color.FromHex("#FF071D66"); } }
        async void MaisaratFannosh_Clicked(object sender, EventArgs e) { if (MaisaratFannosh.BackgroundColor == Color.White) { Constantce.Area = "Maisarat Fannosh"; Constantce.AreaLang = MaisaratFannosh.Text; MaisaratFannosh.TextColor = Color.White; MaisaratFannosh.BackgroundColor = Color.FromHex("#FF071D66"); var existingPages = Navigation.NavigationStack.ToList();Page page = existingPages.FirstOrDefault();Navigation.InsertPageBefore(new Home(), page);Navigation.RemovePage(page);await PopupNavigation.Instance.PopAsync(); } else { Constantce.Area = "Area"; MaisaratFannosh.BackgroundColor = Color.White; MaisaratFannosh.TextColor = Color.FromHex("#FF071D66"); } }
        async void Maddi_Clicked(object sender, EventArgs e) { if (Maddi.BackgroundColor == Color.White) { Constantce.Area = "M'addi"; Constantce.AreaLang = Maddi.Text; Maddi.TextColor = Color.White; Maddi.BackgroundColor = Color.FromHex("#FF071D66"); var existingPages = Navigation.NavigationStack.ToList();Page page = existingPages.FirstOrDefault();Navigation.InsertPageBefore(new Home(), page);Navigation.RemovePage(page);await PopupNavigation.Instance.PopAsync(); } else { Constantce.Area = "Area"; Maddi.BackgroundColor = Color.White; Maddi.TextColor = Color.FromHex("#FF071D66"); } }
        async void Moobes_Clicked(object sender, EventArgs e) { if (Moobes.BackgroundColor == Color.White) { Constantce.Area = "Moobes"; Constantce.AreaLang = Moobes.Text; Moobes.TextColor = Color.White; Moobes.BackgroundColor = Color.FromHex("#FF071D66"); var existingPages = Navigation.NavigationStack.ToList();Page page = existingPages.FirstOrDefault();Navigation.InsertPageBefore(new Home(), page);Navigation.RemovePage(page);await PopupNavigation.Instance.PopAsync(); } else { Constantce.Area = "Area"; Moobes.BackgroundColor = Color.White; Moobes.TextColor = Color.FromHex("#FF071D66"); } }
        async void MuthallathElArdhah_Clicked(object sender, EventArgs e) { if (MuthallathElArdhah.BackgroundColor == Color.White) { Constantce.Area = "Muthallath El - Ardhah"; Constantce.AreaLang = MuthallathElArdhah.Text; MuthallathElArdhah.TextColor = Color.White; MuthallathElArdhah.BackgroundColor = Color.FromHex("#FF071D66"); var existingPages = Navigation.NavigationStack.ToList();Page page = existingPages.FirstOrDefault();Navigation.InsertPageBefore(new Home(), page);Navigation.RemovePage(page);await PopupNavigation.Instance.PopAsync(); } else { Constantce.Area = "Area"; MuthallathElArdhah.BackgroundColor = Color.White; MuthallathElArdhah.TextColor = Color.FromHex("#FF071D66"); } }
        async void MuthallathElMasri_Clicked(object sender, EventArgs e) { if (MuthallathElMasri.BackgroundColor == Color.White) { Constantce.Area = "Muthallath El - Masri"; Constantce.AreaLang = MuthallathElMasri.Text; MuthallathElMasri.TextColor = Color.White; MuthallathElMasri.BackgroundColor = Color.FromHex("#FF071D66"); var existingPages = Navigation.NavigationStack.ToList();Page page = existingPages.FirstOrDefault();Navigation.InsertPageBefore(new Home(), page);Navigation.RemovePage(page);await PopupNavigation.Instance.PopAsync(); } else { Constantce.Area = "Area"; MuthallathElMasri.BackgroundColor = Color.White; MuthallathElMasri.TextColor = Color.FromHex("#FF071D66"); } }
        async void KaretAbuNsair_Clicked(object sender, EventArgs e) { if (KaretAbuNsair.BackgroundColor == Color.White) { Constantce.Area = "Karet Abu Nsair"; Constantce.AreaLang = KaretAbuNsair.Text; KaretAbuNsair.TextColor = Color.White; KaretAbuNsair.BackgroundColor = Color.FromHex("#FF071D66"); var existingPages = Navigation.NavigationStack.ToList();Page page = existingPages.FirstOrDefault();Navigation.InsertPageBefore(new Home(), page);Navigation.RemovePage(page);await PopupNavigation.Instance.PopAsync(); } else { Constantce.Area = "Area"; KaretAbuNsair.BackgroundColor = Color.White; KaretAbuNsair.TextColor = Color.FromHex("#FF071D66"); } }
        async void Qsaib_Clicked(object sender, EventArgs e) { if (Qsaib.BackgroundColor == Color.White) { Constantce.Area = "Qsaib"; Constantce.AreaLang = Qsaib.Text; Qsaib.TextColor = Color.White; Qsaib.BackgroundColor = Color.FromHex("#FF071D66"); var existingPages = Navigation.NavigationStack.ToList();Page page = existingPages.FirstOrDefault();Navigation.InsertPageBefore(new Home(), page);Navigation.RemovePage(page);await PopupNavigation.Instance.PopAsync(); } else { Constantce.Area = "Area"; Qsaib.BackgroundColor = Color.White; Qsaib.TextColor = Color.FromHex("#FF071D66"); } }
        async void Safoot_Clicked(object sender, EventArgs e) { if (Safoot.BackgroundColor == Color.White) { Constantce.Area = "Safoot"; Constantce.AreaLang = Safoot.Text; Safoot.TextColor = Color.White; Safoot.BackgroundColor = Color.FromHex("#FF071D66"); var existingPages = Navigation.NavigationStack.ToList();Page page = existingPages.FirstOrDefault();Navigation.InsertPageBefore(new Home(), page);Navigation.RemovePage(page);await PopupNavigation.Instance.PopAsync(); } else { Constantce.Area = "Area"; Safoot.BackgroundColor = Color.White; Safoot.TextColor = Color.FromHex("#FF071D66"); } }
        async void Salhoob_Clicked(object sender, EventArgs e) { if (Salhoob.BackgroundColor == Color.White) { Constantce.Area = "Salhoob"; Constantce.AreaLang = Salhoob.Text; Salhoob.TextColor = Color.White; Salhoob.BackgroundColor = Color.FromHex("#FF071D66"); var existingPages = Navigation.NavigationStack.ToList();Page page = existingPages.FirstOrDefault();Navigation.InsertPageBefore(new Home(), page);Navigation.RemovePage(page);await PopupNavigation.Instance.PopAsync(); } else { Constantce.Area = "Area"; Salhoob.BackgroundColor = Color.White; Salhoob.TextColor = Color.FromHex("#FF071D66"); } }
        async void Siehan_Clicked(object sender, EventArgs e) { if (Siehan.BackgroundColor == Color.White) { Constantce.Area = "Siehan"; Constantce.AreaLang = Siehan.Text; Siehan.TextColor = Color.White; Siehan.BackgroundColor = Color.FromHex("#FF071D66"); var existingPages = Navigation.NavigationStack.ToList();Page page = existingPages.FirstOrDefault();Navigation.InsertPageBefore(new Home(), page);Navigation.RemovePage(page);await PopupNavigation.Instance.PopAsync(); } else { Constantce.Area = "Area"; Siehan.BackgroundColor = Color.White; Siehan.TextColor = Color.FromHex("#FF071D66"); } }
        async void Soomia_Clicked(object sender, EventArgs e) { if (Soomia.BackgroundColor == Color.White) { Constantce.Area = "Soomia"; Constantce.AreaLang = Soomia.Text; Soomia.TextColor = Color.White; Soomia.BackgroundColor = Color.FromHex("#FF071D66"); var existingPages = Navigation.NavigationStack.ToList();Page page = existingPages.FirstOrDefault();Navigation.InsertPageBefore(new Home(), page);Navigation.RemovePage(page);await PopupNavigation.Instance.PopAsync(); } else { Constantce.Area = "Area"; Soomia.BackgroundColor = Color.White; Soomia.TextColor = Color.FromHex("#FF071D66"); } }
        async void Swaimeh_Clicked(object sender, EventArgs e) { if (Swaimeh.BackgroundColor == Color.White) { Constantce.Area = "Swaimeh"; Constantce.AreaLang = Swaimeh.Text; Swaimeh.TextColor = Color.White; Swaimeh.BackgroundColor = Color.FromHex("#FF071D66"); var existingPages = Navigation.NavigationStack.ToList();Page page = existingPages.FirstOrDefault();Navigation.InsertPageBefore(new Home(), page);Navigation.RemovePage(page);await PopupNavigation.Instance.PopAsync(); } else { Constantce.Area = "Area"; Swaimeh.BackgroundColor = Color.White; Swaimeh.TextColor = Color.FromHex("#FF071D66"); } }
        async void Elaiqoon_Clicked(object sender, EventArgs e) { if (Elaiqoon.BackgroundColor == Color.White) { Constantce.Area = "Elaiqoon"; Constantce.AreaLang = Elaiqoon.Text; Elaiqoon.TextColor = Color.White; Elaiqoon.BackgroundColor = Color.FromHex("#FF071D66"); var existingPages = Navigation.NavigationStack.ToList();Page page = existingPages.FirstOrDefault();Navigation.InsertPageBefore(new Home(), page);Navigation.RemovePage(page);await PopupNavigation.Instance.PopAsync(); } else { Constantce.Area = "Area"; Elaiqoon.BackgroundColor = Color.White; Elaiqoon.TextColor = Color.FromHex("#FF071D66"); } }
        async void UmmEdananier_Clicked(object sender, EventArgs e) { if (UmmEdananier.BackgroundColor == Color.White) { Constantce.Area = "Umm Edananier"; Constantce.AreaLang = UmmEdananier.Text; UmmEdananier.TextColor = Color.White; UmmEdananier.BackgroundColor = Color.FromHex("#FF071D66"); var existingPages = Navigation.NavigationStack.ToList();Page page = existingPages.FirstOrDefault();Navigation.InsertPageBefore(new Home(), page);Navigation.RemovePage(page);await PopupNavigation.Instance.PopAsync(); } else { Constantce.Area = "Area"; UmmEdananier.BackgroundColor = Color.White; UmmEdananier.TextColor = Color.FromHex("#FF071D66"); } }
        async void UmmJauzeh_Clicked(object sender, EventArgs e) { if (UmmJauzeh.BackgroundColor == Color.White) { Constantce.Area = "Umm Jauzeh"; Constantce.AreaLang = UmmJauzeh.Text; UmmJauzeh.TextColor = Color.White; UmmJauzeh.BackgroundColor = Color.FromHex("#FF071D66"); var existingPages = Navigation.NavigationStack.ToList();Page page = existingPages.FirstOrDefault();Navigation.InsertPageBefore(new Home(), page);Navigation.RemovePage(page);await PopupNavigation.Instance.PopAsync(); } else { Constantce.Area = "Area"; UmmJauzeh.BackgroundColor = Color.White; UmmJauzeh.TextColor = Color.FromHex("#FF071D66"); } }
        async void UmmKarubah_Clicked(object sender, EventArgs e) { if (UmmKarubah.BackgroundColor == Color.White) { Constantce.Area = "Umm Karubah"; Constantce.AreaLang = UmmKarubah.Text; UmmKarubah.TextColor = Color.White; UmmKarubah.BackgroundColor = Color.FromHex("#FF071D66"); var existingPages = Navigation.NavigationStack.ToList();Page page = existingPages.FirstOrDefault();Navigation.InsertPageBefore(new Home(), page);Navigation.RemovePage(page);await PopupNavigation.Instance.PopAsync(); } else { Constantce.Area = "Area"; UmmKarubah.BackgroundColor = Color.White; UmmKarubah.TextColor = Color.FromHex("#FF071D66"); } }
        async void UmmNjasah_Clicked(object sender, EventArgs e) { if (UmmNjasah.BackgroundColor == Color.White) { Constantce.Area = "Umm Njasah"; Constantce.AreaLang = UmmNjasah.Text; UmmNjasah.TextColor = Color.White; UmmNjasah.BackgroundColor = Color.FromHex("#FF071D66"); var existingPages = Navigation.NavigationStack.ToList();Page page = existingPages.FirstOrDefault();Navigation.InsertPageBefore(new Home(), page);Navigation.RemovePage(page);await PopupNavigation.Instance.PopAsync(); } else { Constantce.Area = "Area"; UmmNjasah.BackgroundColor = Color.White; UmmNjasah.TextColor = Color.FromHex("#FF071D66"); } }
        async void UmmSendyaneh_Clicked(object sender, EventArgs e) { if (UmmSendyaneh.BackgroundColor == Color.White) { Constantce.Area = "Umm Sendyaneh"; Constantce.AreaLang = UmmSendyaneh.Text; UmmSendyaneh.TextColor = Color.White; UmmSendyaneh.BackgroundColor = Color.FromHex("#FF071D66"); var existingPages = Navigation.NavigationStack.ToList();Page page = existingPages.FirstOrDefault();Navigation.InsertPageBefore(new Home(), page);Navigation.RemovePage(page);await PopupNavigation.Instance.PopAsync(); } else { Constantce.Area = "Area"; UmmSendyaneh.BackgroundColor = Color.White; UmmSendyaneh.TextColor = Color.FromHex("#FF071D66"); } }
        async void WadiElhoor_Clicked(object sender, EventArgs e) { if (WadiElhoor.BackgroundColor == Color.White) { Constantce.Area = "Wadi Elhoor"; Constantce.AreaLang = WadiElhoor.Text; WadiElhoor.TextColor = Color.White; WadiElhoor.BackgroundColor = Color.FromHex("#FF071D66"); var existingPages = Navigation.NavigationStack.ToList();Page page = existingPages.FirstOrDefault();Navigation.InsertPageBefore(new Home(), page);Navigation.RemovePage(page);await PopupNavigation.Instance.PopAsync(); } else { Constantce.Area = "Area"; WadiElhoor.BackgroundColor = Color.White; WadiElhoor.TextColor = Color.FromHex("#FF071D66"); } }
        async void WadiEnnaqah_Clicked(object sender, EventArgs e) { if (WadiEnnaqah.BackgroundColor == Color.White) { Constantce.Area = "Wadi Ennaqah"; Constantce.AreaLang = WadiEnnaqah.Text; WadiEnnaqah.TextColor = Color.White; WadiEnnaqah.BackgroundColor = Color.FromHex("#FF071D66"); var existingPages = Navigation.NavigationStack.ToList();Page page = existingPages.FirstOrDefault();Navigation.InsertPageBefore(new Home(), page);Navigation.RemovePage(page);await PopupNavigation.Instance.PopAsync(); } else { Constantce.Area = "Area"; WadiEnnaqah.BackgroundColor = Color.White; WadiEnnaqah.TextColor = Color.FromHex("#FF071D66"); } }
        async void WadiEssahn_Clicked(object sender, EventArgs e) { if (WadiEssahn.BackgroundColor == Color.White) { Constantce.Area = "Wadi Essahn"; Constantce.AreaLang = WadiEssahn.Text; WadiEssahn.TextColor = Color.White; WadiEssahn.BackgroundColor = Color.FromHex("#FF071D66"); var existingPages = Navigation.NavigationStack.ToList();Page page = existingPages.FirstOrDefault();Navigation.InsertPageBefore(new Home(), page);Navigation.RemovePage(page);await PopupNavigation.Instance.PopAsync(); } else { Constantce.Area = "Area"; WadiEssahn.BackgroundColor = Color.White; WadiEssahn.TextColor = Color.FromHex("#FF071D66"); } }
        async void Yarqha_Clicked(object sender, EventArgs e) { if (Yarqha.BackgroundColor == Color.White) { Constantce.Area = "Yarqha"; Constantce.AreaLang = Yarqha.Text; Yarqha.TextColor = Color.White; Yarqha.BackgroundColor = Color.FromHex("#FF071D66"); var existingPages = Navigation.NavigationStack.ToList();Page page = existingPages.FirstOrDefault();Navigation.InsertPageBefore(new Home(), page);Navigation.RemovePage(page);await PopupNavigation.Instance.PopAsync(); } else { Constantce.Area = "Area"; Yarqha.BackgroundColor = Color.White; Yarqha.TextColor = Color.FromHex("#FF071D66"); } }
        async void DhahretErramel_Clicked(object sender, EventArgs e) { if (DhahretErramel.BackgroundColor == Color.White) { Constantce.Area = "Dhahret Erramel"; Constantce.AreaLang = DhahretErramel.Text; DhahretErramel.TextColor = Color.White; DhahretErramel.BackgroundColor = Color.FromHex("#FF071D66"); var existingPages = Navigation.NavigationStack.ToList();Page page = existingPages.FirstOrDefault();Navigation.InsertPageBefore(new Home(), page);Navigation.RemovePage(page);await PopupNavigation.Instance.PopAsync(); } else { Constantce.Area = "Area"; DhahretErramel.BackgroundColor = Color.White; DhahretErramel.TextColor = Color.FromHex("#FF071D66"); } }
        async void Zayy_Clicked(object sender, EventArgs e) { if (Zayy.BackgroundColor == Color.White) { Constantce.Area = "Zayy"; Constantce.AreaLang = Zayy.Text; Zayy.TextColor = Color.White; Zayy.BackgroundColor = Color.FromHex("#FF071D66"); var existingPages = Navigation.NavigationStack.ToList();Page page = existingPages.FirstOrDefault();Navigation.InsertPageBefore(new Home(), page);Navigation.RemovePage(page);await PopupNavigation.Instance.PopAsync(); } else { Constantce.Area = "Area"; Zayy.BackgroundColor = Color.White; Zayy.TextColor = Color.FromHex("#FF071D66"); } }

        //******************************End BAlqa Areas**********************************************************************

    }
}