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
    public partial class Tafilih : PopupPage
    {
        public Tafilih()
        {
            InitializeComponent();

            if (Application.Current.Properties["Language"].ToString() == "Arabic")
            {
                this.FlowDirection = FlowDirection.RightToLeft;
                UpText.Text = "الرجاء اختيار المنطقة";

                AbelTAF.Text = "عابل";
                AboorTAF.Text = "عابور";
                AbuBannaTAF.Text = "ابو بنا";
                AfraTAF.Text = "عفرا";
                AimehTAF.Text = "عيمه";
                AinElBaidhaTAF.Text = "العين البيضا";
                ArafahTAF.Text = "عرفه";
                BarbietahTAF.Text = "البربيطة";
                BsairaTAF.Text = "بصيرا";
                DhanaTAF.Text = "ضانا";
                DhbaahTAF.Text = "اضباعة";
                ErhabTAF.Text = "ارحاب";
                ErwayyemTAF.Text = "ارويم";
                EzhaigahTAF.Text = "ازحيقة";
                GharandalTAF.Text = "غرندل";
                HarierTAF.Text = "الحرير";
                HasaTAF.Text = "الحسا";
                IesTAF.Text = "العيص";
                JeserElShohadaTAF.Text = "جسر الشهداء";
                JorofTAF.Text = "الجرف";
                LahdhahTAF.Text = "لحظه";
                LibanTAF.Text = "اللعبان";
                MajadelTAF.Text = "مجادل";
                MitanTAF.Text = "المعطن";
                NamtehTAF.Text = "النمته";
                NokhahTAF.Text = "نوخة";
                QarqoorTAF.Text = "قرقور";
                QhadesiyehTAF.Text = "القادسية";
                RashadiyyehTAF.Text = "الرشادية";
                SanfahahTAF.Text = "صنفحه";
                ShaidhamTAF.Text = "شيظم";
                SirahTAF.Text = "الصيرة";
                SwaimieTAF.Text = "صويميع";
                TafilahTAF.Text = "الطفيلة";
                TaletHussainTAF.Text = "تلعة حسين";
                UmmEssarabTAF.Text = "ام سراب";
                ZabdahTAF.Text = "زبدة";


            }
            else
            {
                this.FlowDirection = FlowDirection.LeftToRight;
                UpText.Text = "Please Select Area";

                AbelTAF.Text = "Abel";
                AboorTAF.Text = "Aboor";
                AbuBannaTAF.Text = "Abu Banna";
                AfraTAF.Text = "Afra";
                AimehTAF.Text = "Aimeh";
                AinElBaidhaTAF.Text = "Ain El - Baidha";
                ArafahTAF.Text = "Arafah";
                BarbietahTAF.Text = "Barbietah";
                BsairaTAF.Text = "Bsaira";
                DhanaTAF.Text = "Dhana";
                DhbaahTAF.Text = "Dhba'ah";
                ErhabTAF.Text = "Erhab";
                ErwayyemTAF.Text = "Erwayyem";
                EzhaigahTAF.Text = "Ezhaigah";
                GharandalTAF.Text = "Gharandal";
                HarierTAF.Text = "Harier";
                HasaTAF.Text = "Hasa";
                IesTAF.Text = "Ies";
                JeserElShohadaTAF.Text = "Jeser El - Shohada";
                JorofTAF.Text = "Jorof";
                LahdhahTAF.Text = "Lahdhah";
                LibanTAF.Text = "L'iban";
                MajadelTAF.Text = "Majadel";
                MitanTAF.Text = "Mitan";
                NamtehTAF.Text = "Namteh";
                NokhahTAF.Text = "Nokhah";
                QarqoorTAF.Text = "Qarqoor";
                QhadesiyehTAF.Text = "Qhadesiyeh";
                RashadiyyehTAF.Text = "Rashadiyyeh";
                SanfahahTAF.Text = "Sanfahah";
                ShaidhamTAF.Text = "Shaidham";
                SirahTAF.Text = "Sirah";
                SwaimieTAF.Text = "Swaimie";
                TafilahTAF.Text = "Tafilah";
                TaletHussainTAF.Text = "Tal'et Hussain";
                UmmEssarabTAF.Text = "Umm Essarab";
                ZabdahTAF.Text = "Zabdah";

            }

            if (Constantce.Area == "Abel") { AbelTAF.BackgroundColor = Color.FromHex("#ff071d66"); AbelTAF.TextColor = Color.White; }
            else if (Constantce.Area == "Aboor") { AboorTAF.BackgroundColor = Color.FromHex("#ff071d66"); AboorTAF.TextColor = Color.White; }
            else if (Constantce.Area == "Abu Banna") { AbuBannaTAF.BackgroundColor = Color.FromHex("#ff071d66"); AbuBannaTAF.TextColor = Color.White; }
            else if (Constantce.Area == "Afra") { AfraTAF.BackgroundColor = Color.FromHex("#ff071d66"); AfraTAF.TextColor = Color.White; }
            else if (Constantce.Area == "Aimeh") { AimehTAF.BackgroundColor = Color.FromHex("#ff071d66"); AimehTAF.TextColor = Color.White; }
            else if (Constantce.Area == "Ain El - Baidha") { AinElBaidhaTAF.BackgroundColor = Color.FromHex("#ff071d66"); AinElBaidhaTAF.TextColor = Color.White; }
            else if (Constantce.Area == "Arafah") { ArafahTAF.BackgroundColor = Color.FromHex("#ff071d66"); ArafahTAF.TextColor = Color.White; }
            else if (Constantce.Area == "Barbietah") { BarbietahTAF.BackgroundColor = Color.FromHex("#ff071d66"); BarbietahTAF.TextColor = Color.White; }
            else if (Constantce.Area == "Bsaira") { BsairaTAF.BackgroundColor = Color.FromHex("#ff071d66"); BsairaTAF.TextColor = Color.White; }
            else if (Constantce.Area == "Dhana") { DhanaTAF.BackgroundColor = Color.FromHex("#ff071d66"); DhanaTAF.TextColor = Color.White; }
            else if (Constantce.Area == "Dhba'ah") { DhbaahTAF.BackgroundColor = Color.FromHex("#ff071d66"); DhbaahTAF.TextColor = Color.White; }
            else if (Constantce.Area == "Erhab") { ErhabTAF.BackgroundColor = Color.FromHex("#ff071d66"); ErhabTAF.TextColor = Color.White; }
            else if (Constantce.Area == "Erwayyem") { ErwayyemTAF.BackgroundColor = Color.FromHex("#ff071d66"); ErwayyemTAF.TextColor = Color.White; }
            else if (Constantce.Area == "Ezhaigah") { EzhaigahTAF.BackgroundColor = Color.FromHex("#ff071d66"); EzhaigahTAF.TextColor = Color.White; }
            else if (Constantce.Area == "Gharandal") { GharandalTAF.BackgroundColor = Color.FromHex("#ff071d66"); GharandalTAF.TextColor = Color.White; }
            else if (Constantce.Area == "Harier") { HarierTAF.BackgroundColor = Color.FromHex("#ff071d66"); HarierTAF.TextColor = Color.White; }
            else if (Constantce.Area == "Hasa") { HasaTAF.BackgroundColor = Color.FromHex("#ff071d66"); HasaTAF.TextColor = Color.White; }
            else if (Constantce.Area == "Ies") { IesTAF.BackgroundColor = Color.FromHex("#ff071d66"); IesTAF.TextColor = Color.White; }
            else if (Constantce.Area == "Jeser El - Shohada") { JeserElShohadaTAF.BackgroundColor = Color.FromHex("#ff071d66"); JeserElShohadaTAF.TextColor = Color.White; }
            else if (Constantce.Area == "Jorof") { JorofTAF.BackgroundColor = Color.FromHex("#ff071d66"); JorofTAF.TextColor = Color.White; }
            else if (Constantce.Area == "Lahdhah") { LahdhahTAF.BackgroundColor = Color.FromHex("#ff071d66"); LahdhahTAF.TextColor = Color.White; }
            else if (Constantce.Area == "L'iban") { LibanTAF.BackgroundColor = Color.FromHex("#ff071d66"); LibanTAF.TextColor = Color.White; }
            else if (Constantce.Area == "Majadel") { MajadelTAF.BackgroundColor = Color.FromHex("#ff071d66"); MajadelTAF.TextColor = Color.White; }
            else if (Constantce.Area == "Mitan") { MitanTAF.BackgroundColor = Color.FromHex("#ff071d66"); MitanTAF.TextColor = Color.White; }
            else if (Constantce.Area == "Namteh") { NamtehTAF.BackgroundColor = Color.FromHex("#ff071d66"); NamtehTAF.TextColor = Color.White; }
            else if (Constantce.Area == "Nokhah") { NokhahTAF.BackgroundColor = Color.FromHex("#ff071d66"); NokhahTAF.TextColor = Color.White; }
            else if (Constantce.Area == "Qarqoor") { QarqoorTAF.BackgroundColor = Color.FromHex("#ff071d66"); QarqoorTAF.TextColor = Color.White; }
            else if (Constantce.Area == "Qhadesiyeh") { QhadesiyehTAF.BackgroundColor = Color.FromHex("#ff071d66"); QhadesiyehTAF.TextColor = Color.White; }
            else if (Constantce.Area == "Rashadiyyeh") { RashadiyyehTAF.BackgroundColor = Color.FromHex("#ff071d66"); RashadiyyehTAF.TextColor = Color.White; }
            else if (Constantce.Area == "Sanfahah") { SanfahahTAF.BackgroundColor = Color.FromHex("#ff071d66"); SanfahahTAF.TextColor = Color.White; }
            else if (Constantce.Area == "Shaidham") { ShaidhamTAF.BackgroundColor = Color.FromHex("#ff071d66"); ShaidhamTAF.TextColor = Color.White; }
            else if (Constantce.Area == "Sirah") { SirahTAF.BackgroundColor = Color.FromHex("#ff071d66"); SirahTAF.TextColor = Color.White; }
            else if (Constantce.Area == "Swaimie") { SwaimieTAF.BackgroundColor = Color.FromHex("#ff071d66"); SwaimieTAF.TextColor = Color.White; }
            else if (Constantce.Area == "Tafilah") { TafilahTAF.BackgroundColor = Color.FromHex("#ff071d66"); TafilahTAF.TextColor = Color.White; }
            else if (Constantce.Area == "Tal'et Hussain") { TaletHussainTAF.BackgroundColor = Color.FromHex("#ff071d66"); TaletHussainTAF.TextColor = Color.White; }
            else if (Constantce.Area == "Umm Essarab") { UmmEssarabTAF.BackgroundColor = Color.FromHex("#ff071d66"); UmmEssarabTAF.TextColor = Color.White; }
            else if (Constantce.Area == "Zabdah") { ZabdahTAF.BackgroundColor = Color.FromHex("#ff071d66"); ZabdahTAF.TextColor = Color.White; }


        }


        //******************************Start tafilih Areas**********************************************************************
        async void AbelTAF_Clicked(object sender, EventArgs e) { if (AbelTAF.BackgroundColor == Color.White) { Constantce.Area = "Abel"; Constantce.AreaLang = AbelTAF.Text; AbelTAF.TextColor = Color.White; AbelTAF.BackgroundColor = Color.FromHex("#ff071d66"); var existingPages = Navigation.NavigationStack.ToList();Page page = existingPages.FirstOrDefault();Navigation.InsertPageBefore(new Home(), page);Navigation.RemovePage(page);await PopupNavigation.Instance.PopAsync(); } else { Constantce.Area = "Area"; AbelTAF.BackgroundColor = Color.White; AbelTAF.TextColor = Color.FromHex("#ff071d66"); } }
        async void AboorTAF_Clicked(object sender, EventArgs e) { if (AboorTAF.BackgroundColor == Color.White) { Constantce.Area = "Aboor"; Constantce.AreaLang = AboorTAF.Text; AboorTAF.TextColor = Color.White; AboorTAF.BackgroundColor = Color.FromHex("#ff071d66"); var existingPages = Navigation.NavigationStack.ToList();Page page = existingPages.FirstOrDefault();Navigation.InsertPageBefore(new Home(), page);Navigation.RemovePage(page);await PopupNavigation.Instance.PopAsync(); } else { Constantce.Area = "Area"; AboorTAF.BackgroundColor = Color.White; AboorTAF.TextColor = Color.FromHex("#ff071d66"); } }
        async void AbuBannaTAF_Clicked(object sender, EventArgs e) { if (AbuBannaTAF.BackgroundColor == Color.White) { Constantce.Area = "Abu Banna"; Constantce.AreaLang = AbuBannaTAF.Text; AbuBannaTAF.TextColor = Color.White; AbuBannaTAF.BackgroundColor = Color.FromHex("#ff071d66"); var existingPages = Navigation.NavigationStack.ToList();Page page = existingPages.FirstOrDefault();Navigation.InsertPageBefore(new Home(), page);Navigation.RemovePage(page);await PopupNavigation.Instance.PopAsync(); } else { Constantce.Area = "Area"; AbuBannaTAF.BackgroundColor = Color.White; AbuBannaTAF.TextColor = Color.FromHex("#ff071d66"); } }
        async void AfraTAF_Clicked(object sender, EventArgs e) { if (AfraTAF.BackgroundColor == Color.White) { Constantce.Area = "Afra"; Constantce.AreaLang = AfraTAF.Text; AfraTAF.TextColor = Color.White; AfraTAF.BackgroundColor = Color.FromHex("#ff071d66"); var existingPages = Navigation.NavigationStack.ToList();Page page = existingPages.FirstOrDefault();Navigation.InsertPageBefore(new Home(), page);Navigation.RemovePage(page);await PopupNavigation.Instance.PopAsync(); } else { Constantce.Area = "Area"; AfraTAF.BackgroundColor = Color.White; AfraTAF.TextColor = Color.FromHex("#ff071d66"); } }
        async void AimehTAF_Clicked(object sender, EventArgs e) { if (AimehTAF.BackgroundColor == Color.White) { Constantce.Area = "Aimeh"; Constantce.AreaLang = AimehTAF.Text; AimehTAF.TextColor = Color.White; AimehTAF.BackgroundColor = Color.FromHex("#ff071d66"); var existingPages = Navigation.NavigationStack.ToList();Page page = existingPages.FirstOrDefault();Navigation.InsertPageBefore(new Home(), page);Navigation.RemovePage(page);await PopupNavigation.Instance.PopAsync(); } else { Constantce.Area = "Area"; AimehTAF.BackgroundColor = Color.White; AimehTAF.TextColor = Color.FromHex("#ff071d66"); } }
        async void AinElBaidhaTAF_Clicked(object sender, EventArgs e) { if (AinElBaidhaTAF.BackgroundColor == Color.White) { Constantce.Area = "Ain El - Baidha"; Constantce.AreaLang = AinElBaidhaTAF.Text; AinElBaidhaTAF.TextColor = Color.White; AinElBaidhaTAF.BackgroundColor = Color.FromHex("#ff071d66"); var existingPages = Navigation.NavigationStack.ToList();Page page = existingPages.FirstOrDefault();Navigation.InsertPageBefore(new Home(), page);Navigation.RemovePage(page);await PopupNavigation.Instance.PopAsync(); } else { Constantce.Area = "Area"; AinElBaidhaTAF.BackgroundColor = Color.White; AinElBaidhaTAF.TextColor = Color.FromHex("#ff071d66"); } }
        async void ArafahTAF_Clicked(object sender, EventArgs e) { if (ArafahTAF.BackgroundColor == Color.White) { Constantce.Area = "Arafah"; Constantce.AreaLang = ArafahTAF.Text; ArafahTAF.TextColor = Color.White; ArafahTAF.BackgroundColor = Color.FromHex("#ff071d66"); var existingPages = Navigation.NavigationStack.ToList();Page page = existingPages.FirstOrDefault();Navigation.InsertPageBefore(new Home(), page);Navigation.RemovePage(page);await PopupNavigation.Instance.PopAsync(); } else { Constantce.Area = "Area"; ArafahTAF.BackgroundColor = Color.White; ArafahTAF.TextColor = Color.FromHex("#ff071d66"); } }
        async void BarbietahTAF_Clicked(object sender, EventArgs e) { if (BarbietahTAF.BackgroundColor == Color.White) { Constantce.Area = "Barbietah"; Constantce.AreaLang = BarbietahTAF.Text; BarbietahTAF.TextColor = Color.White; BarbietahTAF.BackgroundColor = Color.FromHex("#ff071d66"); var existingPages = Navigation.NavigationStack.ToList();Page page = existingPages.FirstOrDefault();Navigation.InsertPageBefore(new Home(), page);Navigation.RemovePage(page);await PopupNavigation.Instance.PopAsync(); } else { Constantce.Area = "Area"; BarbietahTAF.BackgroundColor = Color.White; BarbietahTAF.TextColor = Color.FromHex("#ff071d66"); } }
        async void BsairaTAF_Clicked(object sender, EventArgs e) { if (BsairaTAF.BackgroundColor == Color.White) { Constantce.Area = "Bsaira"; Constantce.AreaLang = BsairaTAF.Text; BsairaTAF.TextColor = Color.White; BsairaTAF.BackgroundColor = Color.FromHex("#ff071d66"); var existingPages = Navigation.NavigationStack.ToList();Page page = existingPages.FirstOrDefault();Navigation.InsertPageBefore(new Home(), page);Navigation.RemovePage(page);await PopupNavigation.Instance.PopAsync(); } else { Constantce.Area = "Area"; BsairaTAF.BackgroundColor = Color.White; BsairaTAF.TextColor = Color.FromHex("#ff071d66"); } }
        async void DhanaTAF_Clicked(object sender, EventArgs e) { if (DhanaTAF.BackgroundColor == Color.White) { Constantce.Area = "Dhana"; Constantce.AreaLang = DhanaTAF.Text; DhanaTAF.TextColor = Color.White; DhanaTAF.BackgroundColor = Color.FromHex("#ff071d66"); var existingPages = Navigation.NavigationStack.ToList();Page page = existingPages.FirstOrDefault();Navigation.InsertPageBefore(new Home(), page);Navigation.RemovePage(page);await PopupNavigation.Instance.PopAsync(); } else { Constantce.Area = "Area"; DhanaTAF.BackgroundColor = Color.White; DhanaTAF.TextColor = Color.FromHex("#ff071d66"); } }
        async void DhbaahTAF_Clicked(object sender, EventArgs e) { if (DhbaahTAF.BackgroundColor == Color.White) { Constantce.Area = "Dhba'ah"; Constantce.AreaLang = DhbaahTAF.Text; DhbaahTAF.TextColor = Color.White; DhbaahTAF.BackgroundColor = Color.FromHex("#ff071d66"); var existingPages = Navigation.NavigationStack.ToList();Page page = existingPages.FirstOrDefault();Navigation.InsertPageBefore(new Home(), page);Navigation.RemovePage(page);await PopupNavigation.Instance.PopAsync(); } else { Constantce.Area = "Area"; DhbaahTAF.BackgroundColor = Color.White; DhbaahTAF.TextColor = Color.FromHex("#ff071d66"); } }
        async void ErhabTAF_Clicked(object sender, EventArgs e) { if (ErhabTAF.BackgroundColor == Color.White) { Constantce.Area = "Erhab"; Constantce.AreaLang = ErhabTAF.Text; ErhabTAF.TextColor = Color.White; ErhabTAF.BackgroundColor = Color.FromHex("#ff071d66"); var existingPages = Navigation.NavigationStack.ToList();Page page = existingPages.FirstOrDefault();Navigation.InsertPageBefore(new Home(), page);Navigation.RemovePage(page);await PopupNavigation.Instance.PopAsync(); } else { Constantce.Area = "Area"; ErhabTAF.BackgroundColor = Color.White; ErhabTAF.TextColor = Color.FromHex("#ff071d66"); } }
        async void ErwayyemTAF_Clicked(object sender, EventArgs e) { if (ErwayyemTAF.BackgroundColor == Color.White) { Constantce.Area = "Erwayyem"; Constantce.AreaLang = ErwayyemTAF.Text; ErwayyemTAF.TextColor = Color.White; ErwayyemTAF.BackgroundColor = Color.FromHex("#ff071d66"); var existingPages = Navigation.NavigationStack.ToList();Page page = existingPages.FirstOrDefault();Navigation.InsertPageBefore(new Home(), page);Navigation.RemovePage(page);await PopupNavigation.Instance.PopAsync(); } else { Constantce.Area = "Area"; ErwayyemTAF.BackgroundColor = Color.White; ErwayyemTAF.TextColor = Color.FromHex("#ff071d66"); } }
        async void EzhaigahTAF_Clicked(object sender, EventArgs e) { if (EzhaigahTAF.BackgroundColor == Color.White) { Constantce.Area = "Ezhaigah"; Constantce.AreaLang = EzhaigahTAF.Text; EzhaigahTAF.TextColor = Color.White; EzhaigahTAF.BackgroundColor = Color.FromHex("#ff071d66"); var existingPages = Navigation.NavigationStack.ToList();Page page = existingPages.FirstOrDefault();Navigation.InsertPageBefore(new Home(), page);Navigation.RemovePage(page);await PopupNavigation.Instance.PopAsync(); } else { Constantce.Area = "Area"; EzhaigahTAF.BackgroundColor = Color.White; EzhaigahTAF.TextColor = Color.FromHex("#ff071d66"); } }
        async void GharandalTAF_Clicked(object sender, EventArgs e) { if (GharandalTAF.BackgroundColor == Color.White) { Constantce.Area = "Gharandal"; Constantce.AreaLang = GharandalTAF.Text; GharandalTAF.TextColor = Color.White; GharandalTAF.BackgroundColor = Color.FromHex("#ff071d66"); var existingPages = Navigation.NavigationStack.ToList();Page page = existingPages.FirstOrDefault();Navigation.InsertPageBefore(new Home(), page);Navigation.RemovePage(page);await PopupNavigation.Instance.PopAsync(); } else { Constantce.Area = "Area"; GharandalTAF.BackgroundColor = Color.White; GharandalTAF.TextColor = Color.FromHex("#ff071d66"); } }
        async void HarierTAF_Clicked(object sender, EventArgs e) { if (HarierTAF.BackgroundColor == Color.White) { Constantce.Area = "Harier"; Constantce.AreaLang = HarierTAF.Text; HarierTAF.TextColor = Color.White; HarierTAF.BackgroundColor = Color.FromHex("#ff071d66"); var existingPages = Navigation.NavigationStack.ToList();Page page = existingPages.FirstOrDefault();Navigation.InsertPageBefore(new Home(), page);Navigation.RemovePage(page);await PopupNavigation.Instance.PopAsync(); } else { Constantce.Area = "Area"; HarierTAF.BackgroundColor = Color.White; HarierTAF.TextColor = Color.FromHex("#ff071d66"); } }
        async void HasaTAF_Clicked(object sender, EventArgs e) { if (HasaTAF.BackgroundColor == Color.White) { Constantce.Area = "Hasa"; Constantce.AreaLang = HasaTAF.Text; HasaTAF.TextColor = Color.White; HasaTAF.BackgroundColor = Color.FromHex("#ff071d66"); var existingPages = Navigation.NavigationStack.ToList();Page page = existingPages.FirstOrDefault();Navigation.InsertPageBefore(new Home(), page);Navigation.RemovePage(page);await PopupNavigation.Instance.PopAsync(); } else { Constantce.Area = "Area"; HasaTAF.BackgroundColor = Color.White; HasaTAF.TextColor = Color.FromHex("#ff071d66"); } }
        async void IesTAF_Clicked(object sender, EventArgs e) { if (IesTAF.BackgroundColor == Color.White) { Constantce.Area = "Ies"; Constantce.AreaLang = IesTAF.Text; IesTAF.TextColor = Color.White; IesTAF.BackgroundColor = Color.FromHex("#ff071d66"); var existingPages = Navigation.NavigationStack.ToList();Page page = existingPages.FirstOrDefault();Navigation.InsertPageBefore(new Home(), page);Navigation.RemovePage(page);await PopupNavigation.Instance.PopAsync(); } else { Constantce.Area = "Area"; IesTAF.BackgroundColor = Color.White; IesTAF.TextColor = Color.FromHex("#ff071d66"); } }
        async void JeserElShohadaTAF_Clicked(object sender, EventArgs e) { if (JeserElShohadaTAF.BackgroundColor == Color.White) { Constantce.Area = "Jeser El - Shohada"; Constantce.AreaLang = JeserElShohadaTAF.Text; JeserElShohadaTAF.TextColor = Color.White; JeserElShohadaTAF.BackgroundColor = Color.FromHex("#ff071d66"); var existingPages = Navigation.NavigationStack.ToList();Page page = existingPages.FirstOrDefault();Navigation.InsertPageBefore(new Home(), page);Navigation.RemovePage(page);await PopupNavigation.Instance.PopAsync(); } else { Constantce.Area = "Area"; JeserElShohadaTAF.BackgroundColor = Color.White; JeserElShohadaTAF.TextColor = Color.FromHex("#ff071d66"); } }
        async void JorofTAF_Clicked(object sender, EventArgs e) { if (JorofTAF.BackgroundColor == Color.White) { Constantce.Area = "Jorof"; Constantce.AreaLang = JorofTAF.Text; JorofTAF.TextColor = Color.White; JorofTAF.BackgroundColor = Color.FromHex("#ff071d66"); var existingPages = Navigation.NavigationStack.ToList();Page page = existingPages.FirstOrDefault();Navigation.InsertPageBefore(new Home(), page);Navigation.RemovePage(page);await PopupNavigation.Instance.PopAsync(); } else { Constantce.Area = "Area"; JorofTAF.BackgroundColor = Color.White; JorofTAF.TextColor = Color.FromHex("#ff071d66"); } }
        async void LahdhahTAF_Clicked(object sender, EventArgs e) { if (LahdhahTAF.BackgroundColor == Color.White) { Constantce.Area = "Lahdhah"; Constantce.AreaLang = LahdhahTAF.Text; LahdhahTAF.TextColor = Color.White; LahdhahTAF.BackgroundColor = Color.FromHex("#ff071d66"); var existingPages = Navigation.NavigationStack.ToList();Page page = existingPages.FirstOrDefault();Navigation.InsertPageBefore(new Home(), page);Navigation.RemovePage(page);await PopupNavigation.Instance.PopAsync(); } else { Constantce.Area = "Area"; LahdhahTAF.BackgroundColor = Color.White; LahdhahTAF.TextColor = Color.FromHex("#ff071d66"); } }
        async void LibanTAF_Clicked(object sender, EventArgs e) { if (LibanTAF.BackgroundColor == Color.White) { Constantce.Area = "L'iban"; Constantce.AreaLang = LibanTAF.Text; LibanTAF.TextColor = Color.White; LibanTAF.BackgroundColor = Color.FromHex("#ff071d66"); var existingPages = Navigation.NavigationStack.ToList();Page page = existingPages.FirstOrDefault();Navigation.InsertPageBefore(new Home(), page);Navigation.RemovePage(page);await PopupNavigation.Instance.PopAsync(); } else { Constantce.Area = "Area"; LibanTAF.BackgroundColor = Color.White; LibanTAF.TextColor = Color.FromHex("#ff071d66"); } }
        async void MajadelTAF_Clicked(object sender, EventArgs e) { if (MajadelTAF.BackgroundColor == Color.White) { Constantce.Area = "Majadel"; Constantce.AreaLang = MajadelTAF.Text; MajadelTAF.TextColor = Color.White; MajadelTAF.BackgroundColor = Color.FromHex("#ff071d66"); var existingPages = Navigation.NavigationStack.ToList();Page page = existingPages.FirstOrDefault();Navigation.InsertPageBefore(new Home(), page);Navigation.RemovePage(page);await PopupNavigation.Instance.PopAsync(); } else { Constantce.Area = "Area"; MajadelTAF.BackgroundColor = Color.White; MajadelTAF.TextColor = Color.FromHex("#ff071d66"); } }
        async void MitanTAF_Clicked(object sender, EventArgs e) { if (MitanTAF.BackgroundColor == Color.White) { Constantce.Area = "Mitan"; Constantce.AreaLang = MitanTAF.Text; MitanTAF.TextColor = Color.White; MitanTAF.BackgroundColor = Color.FromHex("#ff071d66"); var existingPages = Navigation.NavigationStack.ToList();Page page = existingPages.FirstOrDefault();Navigation.InsertPageBefore(new Home(), page);Navigation.RemovePage(page);await PopupNavigation.Instance.PopAsync(); } else { Constantce.Area = "Area"; MitanTAF.BackgroundColor = Color.White; MitanTAF.TextColor = Color.FromHex("#ff071d66"); } }
        async void NamtehTAF_Clicked(object sender, EventArgs e) { if (NamtehTAF.BackgroundColor == Color.White) { Constantce.Area = "Namteh"; Constantce.AreaLang = NamtehTAF.Text; NamtehTAF.TextColor = Color.White; NamtehTAF.BackgroundColor = Color.FromHex("#ff071d66"); var existingPages = Navigation.NavigationStack.ToList();Page page = existingPages.FirstOrDefault();Navigation.InsertPageBefore(new Home(), page);Navigation.RemovePage(page);await PopupNavigation.Instance.PopAsync(); } else { Constantce.Area = "Area"; NamtehTAF.BackgroundColor = Color.White; NamtehTAF.TextColor = Color.FromHex("#ff071d66"); } }
        async void NokhahTAF_Clicked(object sender, EventArgs e) { if (NokhahTAF.BackgroundColor == Color.White) { Constantce.Area = "Nokhah"; Constantce.AreaLang = NokhahTAF.Text; NokhahTAF.TextColor = Color.White; NokhahTAF.BackgroundColor = Color.FromHex("#ff071d66"); var existingPages = Navigation.NavigationStack.ToList();Page page = existingPages.FirstOrDefault();Navigation.InsertPageBefore(new Home(), page);Navigation.RemovePage(page);await PopupNavigation.Instance.PopAsync(); } else { Constantce.Area = "Area"; NokhahTAF.BackgroundColor = Color.White; NokhahTAF.TextColor = Color.FromHex("#ff071d66"); } }
        async void QarqoorTAF_Clicked(object sender, EventArgs e) { if (QarqoorTAF.BackgroundColor == Color.White) { Constantce.Area = "Qarqoor"; Constantce.AreaLang = QarqoorTAF.Text; QarqoorTAF.TextColor = Color.White; QarqoorTAF.BackgroundColor = Color.FromHex("#ff071d66"); var existingPages = Navigation.NavigationStack.ToList();Page page = existingPages.FirstOrDefault();Navigation.InsertPageBefore(new Home(), page);Navigation.RemovePage(page);await PopupNavigation.Instance.PopAsync(); } else { Constantce.Area = "Area"; QarqoorTAF.BackgroundColor = Color.White; QarqoorTAF.TextColor = Color.FromHex("#ff071d66"); } }
        async void QhadesiyehTAF_Clicked(object sender, EventArgs e) { if (QhadesiyehTAF.BackgroundColor == Color.White) { Constantce.Area = "Qhadesiyeh"; Constantce.AreaLang = QhadesiyehTAF.Text; QhadesiyehTAF.TextColor = Color.White; QhadesiyehTAF.BackgroundColor = Color.FromHex("#ff071d66"); var existingPages = Navigation.NavigationStack.ToList();Page page = existingPages.FirstOrDefault();Navigation.InsertPageBefore(new Home(), page);Navigation.RemovePage(page);await PopupNavigation.Instance.PopAsync(); } else { Constantce.Area = "Area"; QhadesiyehTAF.BackgroundColor = Color.White; QhadesiyehTAF.TextColor = Color.FromHex("#ff071d66"); } }
        async void RashadiyyehTAF_Clicked(object sender, EventArgs e) { if (RashadiyyehTAF.BackgroundColor == Color.White) { Constantce.Area = "Rashadiyyeh"; Constantce.AreaLang = RashadiyyehTAF.Text; RashadiyyehTAF.TextColor = Color.White; RashadiyyehTAF.BackgroundColor = Color.FromHex("#ff071d66"); var existingPages = Navigation.NavigationStack.ToList();Page page = existingPages.FirstOrDefault();Navigation.InsertPageBefore(new Home(), page);Navigation.RemovePage(page);await PopupNavigation.Instance.PopAsync(); } else { Constantce.Area = "Area"; RashadiyyehTAF.BackgroundColor = Color.White; RashadiyyehTAF.TextColor = Color.FromHex("#ff071d66"); } }
        async void SanfahahTAF_Clicked(object sender, EventArgs e) { if (SanfahahTAF.BackgroundColor == Color.White) { Constantce.Area = "Sanfahah"; Constantce.AreaLang = SanfahahTAF.Text; SanfahahTAF.TextColor = Color.White; SanfahahTAF.BackgroundColor = Color.FromHex("#ff071d66"); var existingPages = Navigation.NavigationStack.ToList();Page page = existingPages.FirstOrDefault();Navigation.InsertPageBefore(new Home(), page);Navigation.RemovePage(page);await PopupNavigation.Instance.PopAsync(); } else { Constantce.Area = "Area"; SanfahahTAF.BackgroundColor = Color.White; SanfahahTAF.TextColor = Color.FromHex("#ff071d66"); } }
        async void ShaidhamTAF_Clicked(object sender, EventArgs e) { if (ShaidhamTAF.BackgroundColor == Color.White) { Constantce.Area = "Shaidham"; Constantce.AreaLang = ShaidhamTAF.Text; ShaidhamTAF.TextColor = Color.White; ShaidhamTAF.BackgroundColor = Color.FromHex("#ff071d66"); var existingPages = Navigation.NavigationStack.ToList();Page page = existingPages.FirstOrDefault();Navigation.InsertPageBefore(new Home(), page);Navigation.RemovePage(page);await PopupNavigation.Instance.PopAsync(); } else { Constantce.Area = "Area"; ShaidhamTAF.BackgroundColor = Color.White; ShaidhamTAF.TextColor = Color.FromHex("#ff071d66"); } }
        async void SirahTAF_Clicked(object sender, EventArgs e) { if (SirahTAF.BackgroundColor == Color.White) { Constantce.Area = "Sirah"; Constantce.AreaLang = SirahTAF.Text; SirahTAF.TextColor = Color.White; SirahTAF.BackgroundColor = Color.FromHex("#ff071d66"); var existingPages = Navigation.NavigationStack.ToList();Page page = existingPages.FirstOrDefault();Navigation.InsertPageBefore(new Home(), page);Navigation.RemovePage(page);await PopupNavigation.Instance.PopAsync(); } else { Constantce.Area = "Area"; SirahTAF.BackgroundColor = Color.White; SirahTAF.TextColor = Color.FromHex("#ff071d66"); } }
        async void SwaimieTAF_Clicked(object sender, EventArgs e) { if (SwaimieTAF.BackgroundColor == Color.White) { Constantce.Area = "Swaimie"; Constantce.AreaLang = SwaimieTAF.Text; SwaimieTAF.TextColor = Color.White; SwaimieTAF.BackgroundColor = Color.FromHex("#ff071d66"); var existingPages = Navigation.NavigationStack.ToList();Page page = existingPages.FirstOrDefault();Navigation.InsertPageBefore(new Home(), page);Navigation.RemovePage(page);await PopupNavigation.Instance.PopAsync(); } else { Constantce.Area = "Area"; SwaimieTAF.BackgroundColor = Color.White; SwaimieTAF.TextColor = Color.FromHex("#ff071d66"); } }
        async void TafilahTAF_Clicked(object sender, EventArgs e) { if (TafilahTAF.BackgroundColor == Color.White) { Constantce.Area = "Tafilah"; Constantce.AreaLang = TafilahTAF.Text; TafilahTAF.TextColor = Color.White; TafilahTAF.BackgroundColor = Color.FromHex("#ff071d66"); var existingPages = Navigation.NavigationStack.ToList();Page page = existingPages.FirstOrDefault();Navigation.InsertPageBefore(new Home(), page);Navigation.RemovePage(page);await PopupNavigation.Instance.PopAsync(); } else { Constantce.Area = "Area"; TafilahTAF.BackgroundColor = Color.White; TafilahTAF.TextColor = Color.FromHex("#ff071d66"); } }
        async void TaletHussainTAF_Clicked(object sender, EventArgs e) { if (TaletHussainTAF.BackgroundColor == Color.White) { Constantce.Area = "Tal'et Hussain"; Constantce.AreaLang = TaletHussainTAF.Text; TaletHussainTAF.TextColor = Color.White; TaletHussainTAF.BackgroundColor = Color.FromHex("#ff071d66"); var existingPages = Navigation.NavigationStack.ToList();Page page = existingPages.FirstOrDefault();Navigation.InsertPageBefore(new Home(), page);Navigation.RemovePage(page);await PopupNavigation.Instance.PopAsync(); } else { Constantce.Area = "Area"; TaletHussainTAF.BackgroundColor = Color.White; TaletHussainTAF.TextColor = Color.FromHex("#ff071d66"); } }
        async void UmmEssarabTAF_Clicked(object sender, EventArgs e) { if (UmmEssarabTAF.BackgroundColor == Color.White) { Constantce.Area = "Umm Essarab"; Constantce.AreaLang = UmmEssarabTAF.Text; UmmEssarabTAF.TextColor = Color.White; UmmEssarabTAF.BackgroundColor = Color.FromHex("#ff071d66"); var existingPages = Navigation.NavigationStack.ToList();Page page = existingPages.FirstOrDefault();Navigation.InsertPageBefore(new Home(), page);Navigation.RemovePage(page);await PopupNavigation.Instance.PopAsync(); } else { Constantce.Area = "Area"; UmmEssarabTAF.BackgroundColor = Color.White; UmmEssarabTAF.TextColor = Color.FromHex("#ff071d66"); } }
        async void ZabdahTAF_Clicked(object sender, EventArgs e) { if (ZabdahTAF.BackgroundColor == Color.White) { Constantce.Area = "Zabdah"; Constantce.AreaLang = ZabdahTAF.Text; ZabdahTAF.TextColor = Color.White; ZabdahTAF.BackgroundColor = Color.FromHex("#ff071d66"); var existingPages = Navigation.NavigationStack.ToList();Page page = existingPages.FirstOrDefault();Navigation.InsertPageBefore(new Home(), page);Navigation.RemovePage(page);await PopupNavigation.Instance.PopAsync(); } else { Constantce.Area = "Area"; ZabdahTAF.BackgroundColor = Color.White; ZabdahTAF.TextColor = Color.FromHex("#ff071d66"); } }

        //******************************End tafilih Areas**********************************************************************

    }
}