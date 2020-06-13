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
    public partial class Jarash : PopupPage
    {
        public Jarash()
        {
            InitializeComponent();
            if (Application.Current.Properties["Language"].ToString() == "Arabic")
            {
                this.FlowDirection = FlowDirection.RightToLeft;
                UpText.Text = "الرجاء اختيار المنطقة";

                AbarahJAR.Text = "العبارة";
                AlaymoonJAR.Text = "عليمون";
                AmamahJAR.Text = "عمامة";
                ArRyashiJAR.Text = "الرياشي";
                AsfoorJAR.Text = "عصفور";
                AshShakMfarrejJAR.Text = "الشيخ مفرج";
                BalielaJAR.Text = "بليلا";
                BormaJAR.Text = "برما";
                DeirElliyyatJAR.Text = "دير الليات";
                DibbeenJAR.Text = "دبين";
                EjbaratJAR.Text = "الجبارات";
                EnabehJAR.Text = "عنيبة";
                FawaraJAR.Text = "الفوارة";
                FayhaMshairfehElWestaJAR.Text = "الفيحاء";
                HadadehJAR.Text = "الحدادة";
                HamtaJAR.Text = "همتا";
                HasainiyyatJAR.Text = "الحسينيات";
                HazeahJAR.Text = "الحازية";
                HoonehJAR.Text = "الهونة";
                JabbaJAR.Text = "جبا";
                JamlaJAR.Text = "جملا";
                JazzazehJAR.Text = "الجزازة";
                JebbahJAR.Text = "جبة";
                JerashJAR.Text = "جرش";
                JerashCampJAR.Text = "مخيم غزة";
                JnaideyyehMshairfehSharqiyyehJAR.Text = "الجنيدية";
                KettehJAR.Text = "الكتة";
                KfairJAR.Text = "الكفير";
                KfarKhallJAR.Text = "كفر خل";
                MajdalJAR.Text = "المجدل";
                ManshtalFaisalJAR.Text = "مشتل فيصل";
                MansorahKhshaibehJAR.Text = "المنصورة";
                MastabahJAR.Text = "المصطبة";
                MeqeblehJAR.Text = "مقبلة";
                MersieJAR.Text = "مرصع";
                MshairfehGharbiyyehJAR.Text = "المشيرفة الغربية";
                NabiHoodJAR.Text = "النبي هود";
                NahlehJAR.Text = "نحلة";
                NajdehJAR.Text = "نجدة";
                QafqafaJAR.Text = "قفقفا";
                QraiaJAR.Text = "قريع";
                RahmaniyyehJAR.Text = "الرحمانية";
                RaiehJAR.Text = "الراية";
                RaimoonJAR.Text = "ريمون";
                RashaydehJAR.Text = "الرشايدة";
                SakebJAR.Text = "ساكب";
                SoofJAR.Text = "سوف";
                SoofCampJAR.Text = "مخيم سوف";
                TaletErrozJAR.Text = "تلعة الرز";
                UmmEzzaitoonJAR.Text = "ام الزيتون";
                UmmQontarahJAR.Text = "ام قنطرة";
                UmmRamehJAR.Text = "ام رامح";
                ZaqreetJAR.Text = "زقريط";


            }
            else
            {
                this.FlowDirection = FlowDirection.LeftToRight;
                UpText.Text = "Please Select Area";

                AbarahJAR.Text = "Abarah";
                AlaymoonJAR.Text = "Alaymoon";
                AmamahJAR.Text = "Amamah";
                ArRyashiJAR.Text = "Ar - Ryashi";
                AsfoorJAR.Text = "Asfoor";
                AshShakMfarrejJAR.Text = "Ash - Shak Mfarrej";
                BalielaJAR.Text = "Baliela";
                BormaJAR.Text = "Borma";
                DeirElliyyatJAR.Text = "Deir Elliyyat";
                DibbeenJAR.Text = "Dibbeen";
                EjbaratJAR.Text = "Ejbarat";
                EnabehJAR.Text = "Enabeh";
                FawaraJAR.Text = "Fawara";
                FayhaMshairfehElWestaJAR.Text = "Fayha Mshairfeh El-Westa";
                HadadehJAR.Text = "Hadadeh";
                HamtaJAR.Text = "Hamta";
                HasainiyyatJAR.Text = "Hasainiyyat";
                HazeahJAR.Text = "Hazeah";
                HoonehJAR.Text = "Hooneh";
                JabbaJAR.Text = "Jabba";
                JamlaJAR.Text = "Jamla";
                JazzazehJAR.Text = "Jazzazeh";
                JebbahJAR.Text = "Jebbah";
                JerashJAR.Text = "Jerash";
                JerashCampJAR.Text = "Jerash Camp";
                JnaideyyehMshairfehSharqiyyehJAR.Text = "Jnaideyyeh Mshairfeh Sharqiyyeh";
                KettehJAR.Text = "Ketteh";
                KfairJAR.Text = "Kfair";
                KfarKhallJAR.Text = "Kfar Khall";
                MajdalJAR.Text = "Majdal";
                ManshtalFaisalJAR.Text = "Manshtal Faisal";
                MansorahKhshaibehJAR.Text = "Mansorah Khshaibeh";
                MastabahJAR.Text = "Mastabah";
                MeqeblehJAR.Text = "Meqebleh";
                MersieJAR.Text = "Mersi'e";
                MshairfehGharbiyyehJAR.Text = "Mshairfeh Gharbiyyeh";
                NabiHoodJAR.Text = "Nabi Hood";
                NahlehJAR.Text = "Nahleh";
                NajdehJAR.Text = "Najdeh";
                QafqafaJAR.Text = "Qafqafa";
                QraiaJAR.Text = "Qraia'";
                RahmaniyyehJAR.Text = "Rahmaniyyeh";
                RaiehJAR.Text = "Raieh";
                RaimoonJAR.Text = "Raimoon";
                RashaydehJAR.Text = "Rashaydeh";
                SakebJAR.Text = "Sakeb";
                SoofJAR.Text = "Soof";
                SoofCampJAR.Text = "Soof Camp";
                TaletErrozJAR.Text = "Tal'et Erroz";
                UmmEzzaitoonJAR.Text = "Umm Ezzaitoon";
                UmmQontarahJAR.Text = "Umm Qontarah";
                UmmRamehJAR.Text = "Umm Rameh";
                ZaqreetJAR.Text = "Zaqreet";

            }
            if (Constantce.Area == "Abarah")
            {
                AbarahJAR.BackgroundColor = Color.FromHex("#FF071D66"); AbarahJAR.TextColor = Color.White;
            }
            else if (Constantce.Area == "Alaymoon")
            {
                AlaymoonJAR.BackgroundColor = Color.FromHex("#FF071D66"); AlaymoonJAR.TextColor = Color.White;
            }
            else if (Constantce.Area == "Amamah")
            {
                AmamahJAR.BackgroundColor = Color.FromHex("#FF071D66"); AmamahJAR.TextColor = Color.White;
            }
            else if (Constantce.Area == "Ar - Ryashi")
            {
                ArRyashiJAR.BackgroundColor = Color.FromHex("#FF071D66"); ArRyashiJAR.TextColor = Color.White;
            }
            else if (Constantce.Area == "Asfoor")
            {
                AsfoorJAR.BackgroundColor = Color.FromHex("#FF071D66"); AsfoorJAR.TextColor = Color.White;
            }
            else if (Constantce.Area == "Ash - Shak Mfarrej")
            {
                AshShakMfarrejJAR.BackgroundColor = Color.FromHex("#FF071D66"); AshShakMfarrejJAR.TextColor = Color.White;
            }
            else if (Constantce.Area == "Baliela")
            {
                BalielaJAR.BackgroundColor = Color.FromHex("#FF071D66"); BalielaJAR.TextColor = Color.White;
            }
            else if (Constantce.Area == "Borma")
            {
                BormaJAR.BackgroundColor = Color.FromHex("#FF071D66"); BormaJAR.TextColor = Color.White;
            }
            else if (Constantce.Area == "Deir Elliyyat")
            {
                DeirElliyyatJAR.BackgroundColor = Color.FromHex("#FF071D66"); DeirElliyyatJAR.TextColor = Color.White;
            }
            else if (Constantce.Area == "Dibbeen")
            {
                DibbeenJAR.BackgroundColor = Color.FromHex("#FF071D66"); DibbeenJAR.TextColor = Color.White;
            }
            else if (Constantce.Area == "Ejbarat")
            {
                EjbaratJAR.BackgroundColor = Color.FromHex("#FF071D66"); EjbaratJAR.TextColor = Color.White;
            }
            else if (Constantce.Area == "Enabeh")
            {
                EnabehJAR.BackgroundColor = Color.FromHex("#FF071D66"); EnabehJAR.TextColor = Color.White;
            }
            else if (Constantce.Area == "Fawara")
            {
                FawaraJAR.BackgroundColor = Color.FromHex("#FF071D66"); FawaraJAR.TextColor = Color.White;
            }
            else if (Constantce.Area == "Fayha Mshairfeh El-Westa")
            {
                FayhaMshairfehElWestaJAR.BackgroundColor = Color.FromHex("#FF071D66"); FayhaMshairfehElWestaJAR.TextColor = Color.White;
            }
            else if (Constantce.Area == "Hadadeh")
            {
                HadadehJAR.BackgroundColor = Color.FromHex("#FF071D66"); HadadehJAR.TextColor = Color.White;
            }
            else if (Constantce.Area == "Hamta")
            {
                HamtaJAR.BackgroundColor = Color.FromHex("#FF071D66"); HamtaJAR.TextColor = Color.White;
            }
            else if (Constantce.Area == "Hasainiyyat")
            {
                HasainiyyatJAR.BackgroundColor = Color.FromHex("#FF071D66"); HasainiyyatJAR.TextColor = Color.White;
            }
            else if (Constantce.Area == "Hazeah")
            {
                HazeahJAR.BackgroundColor = Color.FromHex("#FF071D66"); HazeahJAR.TextColor = Color.White;
            }
            else if (Constantce.Area == "Hooneh")
            {
                HoonehJAR.BackgroundColor = Color.FromHex("#FF071D66"); HoonehJAR.TextColor = Color.White;
            }
            else if (Constantce.Area == "Jabba")
            {
                JabbaJAR.BackgroundColor = Color.FromHex("#FF071D66"); JabbaJAR.TextColor = Color.White;
            }
            else if (Constantce.Area == "Jamla")
            {
                JamlaJAR.BackgroundColor = Color.FromHex("#FF071D66"); JamlaJAR.TextColor = Color.White;
            }
            else if (Constantce.Area == "Jazzazeh")
            {
                JazzazehJAR.BackgroundColor = Color.FromHex("#FF071D66"); JazzazehJAR.TextColor = Color.White;
            }
            else if (Constantce.Area == "Jebbah")
            {
                JebbahJAR.BackgroundColor = Color.FromHex("#FF071D66"); JebbahJAR.TextColor = Color.White;
            }
            else if (Constantce.Area == "Jerash")
            {
                JerashJAR.BackgroundColor = Color.FromHex("#FF071D66"); JerashJAR.TextColor = Color.White;
            }
            else if (Constantce.Area == "Jerash Camp")
            {
                JerashCampJAR.BackgroundColor = Color.FromHex("#FF071D66"); JerashCampJAR.TextColor = Color.White;
            }
            else if (Constantce.Area == "Jnaideyyeh Mshairfeh Sharqiyyeh")
            {
                JnaideyyehMshairfehSharqiyyehJAR.BackgroundColor = Color.FromHex("#FF071D66"); JnaideyyehMshairfehSharqiyyehJAR.TextColor = Color.White;
            }
            else if (Constantce.Area == "Ketteh")
            {
                KettehJAR.BackgroundColor = Color.FromHex("#FF071D66"); KettehJAR.TextColor = Color.White;
            }
            else if (Constantce.Area == "Kfair")
            {
                KfairJAR.BackgroundColor = Color.FromHex("#FF071D66"); KfairJAR.TextColor = Color.White;
            }
            else if (Constantce.Area == "Kfar Khall")
            {
                KfarKhallJAR.BackgroundColor = Color.FromHex("#FF071D66"); KfarKhallJAR.TextColor = Color.White;
            }
            else if (Constantce.Area == "Majdal")
            {
                MajdalJAR.BackgroundColor = Color.FromHex("#FF071D66"); MajdalJAR.TextColor = Color.White;
            }
            else if (Constantce.Area == "Manshtal Faisal")
            {
                ManshtalFaisalJAR.BackgroundColor = Color.FromHex("#FF071D66"); ManshtalFaisalJAR.TextColor = Color.White;
            }
            else if (Constantce.Area == "Mansorah Khshaibeh")
            {
                MansorahKhshaibehJAR.BackgroundColor = Color.FromHex("#FF071D66"); MansorahKhshaibehJAR.TextColor = Color.White;
            }
            else if (Constantce.Area == "Mastabah")
            {
                MastabahJAR.BackgroundColor = Color.FromHex("#FF071D66"); MastabahJAR.TextColor = Color.White;
            }
            else if (Constantce.Area == "Meqebleh")
            {
                MeqeblehJAR.BackgroundColor = Color.FromHex("#FF071D66"); MeqeblehJAR.TextColor = Color.White;
            }
            else if (Constantce.Area == "Mersi'e") { MersieJAR.BackgroundColor = Color.FromHex("#FF071D66"); MersieJAR.TextColor = Color.White; }
            else if (Constantce.Area == "Mshairfeh Gharbiyyeh")
            {
                MshairfehGharbiyyehJAR.BackgroundColor = Color.FromHex("#FF071D66"); MshairfehGharbiyyehJAR.TextColor = Color.White;
            }
            else if (Constantce.Area == "Nabi Hood")
            {
                NabiHoodJAR.BackgroundColor = Color.FromHex("#FF071D66"); NabiHoodJAR.TextColor = Color.White;
            }
            else if (Constantce.Area == "Nahleh")
            {
                NahlehJAR.BackgroundColor = Color.FromHex("#FF071D66"); NahlehJAR.TextColor = Color.White;
            }
            else if (Constantce.Area == "Najdeh")
            {
                NajdehJAR.BackgroundColor = Color.FromHex("#FF071D66"); NajdehJAR.TextColor = Color.White;
            }
            else if (Constantce.Area == "Qafqafa")
            {
                QafqafaJAR.BackgroundColor = Color.FromHex("#FF071D66"); QafqafaJAR.TextColor = Color.White;
            }
            else if (Constantce.Area == "Qraia'") { QraiaJAR.BackgroundColor = Color.FromHex("#FF071D66"); QraiaJAR.TextColor = Color.White; }
            else if (Constantce.Area == "Rahmaniyyeh")
            {
                RahmaniyyehJAR.BackgroundColor = Color.FromHex("#FF071D66"); RahmaniyyehJAR.TextColor = Color.White;
            }
            else if (Constantce.Area == "Raieh")
            {
                RaiehJAR.BackgroundColor = Color.FromHex("#FF071D66"); RaiehJAR.TextColor = Color.White;
            }
            else if (Constantce.Area == "Raimoon")
            {
                RaimoonJAR.BackgroundColor = Color.FromHex("#FF071D66"); RaimoonJAR.TextColor = Color.White;
            }
            else if (Constantce.Area == "Rashaydeh")
            {
                RashaydehJAR.BackgroundColor = Color.FromHex("#FF071D66"); RashaydehJAR.TextColor = Color.White;
            }
            else if (Constantce.Area == "Sakeb")
            {
                SakebJAR.BackgroundColor = Color.FromHex("#FF071D66"); SakebJAR.TextColor = Color.White;
            }
            else if (Constantce.Area == "Soof")
            {
                SoofJAR.BackgroundColor = Color.FromHex("#FF071D66"); SoofJAR.TextColor = Color.White;
            }
            else if (Constantce.Area == "Soof Camp") { SoofCampJAR.BackgroundColor = Color.FromHex("#FF071D66"); SoofCampJAR.TextColor = Color.White; }
            else if (Constantce.Area == "Tal'et Erroz") { TaletErrozJAR.BackgroundColor = Color.FromHex("#FF071D66"); TaletErrozJAR.TextColor = Color.White; }
            else if (Constantce.Area == "Umm Ezzaitoon") { UmmEzzaitoonJAR.BackgroundColor = Color.FromHex("#FF071D66"); UmmEzzaitoonJAR.TextColor = Color.White; }
            else if (Constantce.Area == "Umm Qontarah") { UmmQontarahJAR.BackgroundColor = Color.FromHex("#FF071D66"); UmmQontarahJAR.TextColor = Color.White; }
            else if (Constantce.Area == "Umm Rameh") { UmmRamehJAR.BackgroundColor = Color.FromHex("#FF071D66"); UmmRamehJAR.TextColor = Color.White; }
            else if (Constantce.Area == "Zaqreet") { ZaqreetJAR.BackgroundColor = Color.FromHex("#FF071D66"); ZaqreetJAR.TextColor = Color.White; }
            JarashArea.IsVisible = true;
        }


        //******************************End jarash Areas**********************************************************************
        async void AbarahJAR_Clicked(object sender, EventArgs e)
        {
            if (AbarahJAR.BackgroundColor == Color.White)
            {
                Constantce.Area = "Abarah"; Constantce.AreaLang = AbarahJAR.Text; AbarahJAR.TextColor = Color.White; AbarahJAR.BackgroundColor = Color.FromHex("#FF071D66"); var existingPages = Navigation.NavigationStack.ToList(); await Navigation.PushAsync(new Home()); foreach (var page in existingPages) { Navigation.RemovePage(page); }
                await Task.Delay(80); await PopupNavigation.Instance.PopAsync();
            }
            else { Constantce.Area = "Area"; AbarahJAR.BackgroundColor = Color.White; AbarahJAR.TextColor = Color.FromHex("#FF071D66"); }
        }
        async void AlaymoonJAR_Clicked(object sender, EventArgs e)
        {
            if (AlaymoonJAR.BackgroundColor == Color.White)
            {
                Constantce.Area = "Alaymoon"; Constantce.AreaLang = AlaymoonJAR.Text; AlaymoonJAR.TextColor = Color.White; AlaymoonJAR.BackgroundColor = Color.FromHex("#FF071D66"); var existingPages = Navigation.NavigationStack.ToList(); await Navigation.PushAsync(new Home()); foreach (var page in existingPages) { Navigation.RemovePage(page); }
                await Task.Delay(80); await PopupNavigation.Instance.PopAsync();
            }
            else { Constantce.Area = "Area"; AlaymoonJAR.BackgroundColor = Color.White; AlaymoonJAR.TextColor = Color.FromHex("#FF071D66"); }
        }
        async void AmamahJAR_Clicked(object sender, EventArgs e)
        {
            if (AmamahJAR.BackgroundColor == Color.White)
            {
                Constantce.Area = "Amamah"; Constantce.AreaLang = AmamahJAR.Text; AmamahJAR.TextColor = Color.White; AmamahJAR.BackgroundColor = Color.FromHex("#FF071D66"); var existingPages = Navigation.NavigationStack.ToList(); await Navigation.PushAsync(new Home()); foreach (var page in existingPages) { Navigation.RemovePage(page); }
                await Task.Delay(80); await PopupNavigation.Instance.PopAsync();
            }
            else { Constantce.Area = "Area"; AmamahJAR.BackgroundColor = Color.White; AmamahJAR.TextColor = Color.FromHex("#FF071D66"); }
        }
        async void ArRyashiJAR_Clicked(object sender, EventArgs e)
        {
            if (ArRyashiJAR.BackgroundColor == Color.White)
            {
                Constantce.Area = "Ar - Ryashi"; Constantce.AreaLang = ArRyashiJAR.Text; ArRyashiJAR.TextColor = Color.White; ArRyashiJAR.BackgroundColor = Color.FromHex("#FF071D66"); var existingPages = Navigation.NavigationStack.ToList(); await Navigation.PushAsync(new Home()); foreach (var page in existingPages) { Navigation.RemovePage(page); }
                await Task.Delay(80); await PopupNavigation.Instance.PopAsync();
            }
            else { Constantce.Area = "Area"; ArRyashiJAR.BackgroundColor = Color.White; ArRyashiJAR.TextColor = Color.FromHex("#FF071D66"); }
        }
        async void AsfoorJAR_Clicked(object sender, EventArgs e)
        {
            if (AsfoorJAR.BackgroundColor == Color.White)
            {
                Constantce.Area = "Asfoor"; Constantce.AreaLang = AsfoorJAR.Text; AsfoorJAR.TextColor = Color.White; AsfoorJAR.BackgroundColor = Color.FromHex("#FF071D66"); var existingPages = Navigation.NavigationStack.ToList(); await Navigation.PushAsync(new Home()); foreach (var page in existingPages) { Navigation.RemovePage(page); }
                await Task.Delay(80); await PopupNavigation.Instance.PopAsync();
            }
            else { Constantce.Area = "Area"; AsfoorJAR.BackgroundColor = Color.White; AsfoorJAR.TextColor = Color.FromHex("#FF071D66"); }
        }
        async void AshShakMfarrejJAR_Clicked(object sender, EventArgs e)
        {
            if (AshShakMfarrejJAR.BackgroundColor == Color.White)
            {
                Constantce.Area = "Ash - Shak Mfarrej"; Constantce.AreaLang = AshShakMfarrejJAR.Text; AshShakMfarrejJAR.TextColor = Color.White; AshShakMfarrejJAR.BackgroundColor = Color.FromHex("#FF071D66"); var existingPages = Navigation.NavigationStack.ToList(); await Navigation.PushAsync(new Home()); foreach (var page in existingPages) { Navigation.RemovePage(page); }
                await Task.Delay(80); await PopupNavigation.Instance.PopAsync();
            }
            else { Constantce.Area = "Area"; AshShakMfarrejJAR.BackgroundColor = Color.White; AshShakMfarrejJAR.TextColor = Color.FromHex("#FF071D66"); }
        }
        async void BalielaJAR_Clicked(object sender, EventArgs e)
        {
            if (BalielaJAR.BackgroundColor == Color.White)
            {
                Constantce.Area = "Baliela"; Constantce.AreaLang = BalielaJAR.Text; BalielaJAR.TextColor = Color.White; BalielaJAR.BackgroundColor = Color.FromHex("#FF071D66"); var existingPages = Navigation.NavigationStack.ToList(); await Navigation.PushAsync(new Home()); foreach (var page in existingPages) { Navigation.RemovePage(page); }
                await Task.Delay(80); await PopupNavigation.Instance.PopAsync();
            }
            else { Constantce.Area = "Area"; BalielaJAR.BackgroundColor = Color.White; BalielaJAR.TextColor = Color.FromHex("#FF071D66"); }
        }
        async void BormaJAR_Clicked(object sender, EventArgs e)
        {
            if (BormaJAR.BackgroundColor == Color.White)
            {
                Constantce.Area = "Borma"; Constantce.AreaLang = BormaJAR.Text; BormaJAR.TextColor = Color.White; BormaJAR.BackgroundColor = Color.FromHex("#FF071D66"); var existingPages = Navigation.NavigationStack.ToList(); await Navigation.PushAsync(new Home()); foreach (var page in existingPages) { Navigation.RemovePage(page); }
                await Task.Delay(80); await PopupNavigation.Instance.PopAsync();
            }
            else { Constantce.Area = "Area"; BormaJAR.BackgroundColor = Color.White; BormaJAR.TextColor = Color.FromHex("#FF071D66"); }
        }
        async void DeirElliyyatJAR_Clicked(object sender, EventArgs e)
        {
            if (DeirElliyyatJAR.BackgroundColor == Color.White)
            {
                Constantce.Area = "Deir Elliyyat"; Constantce.AreaLang = DeirElliyyatJAR.Text; DeirElliyyatJAR.TextColor = Color.White; DeirElliyyatJAR.BackgroundColor = Color.FromHex("#FF071D66"); var existingPages = Navigation.NavigationStack.ToList(); await Navigation.PushAsync(new Home()); foreach (var page in existingPages) { Navigation.RemovePage(page); }
                await Task.Delay(80); await PopupNavigation.Instance.PopAsync();
            }
            else { Constantce.Area = "Area"; DeirElliyyatJAR.BackgroundColor = Color.White; DeirElliyyatJAR.TextColor = Color.FromHex("#FF071D66"); }
        }
        async void DibbeenJAR_Clicked(object sender, EventArgs e)
        {
            if (DibbeenJAR.BackgroundColor == Color.White)
            {
                Constantce.Area = "Dibbeen"; Constantce.AreaLang = DibbeenJAR.Text; DibbeenJAR.TextColor = Color.White; DibbeenJAR.BackgroundColor = Color.FromHex("#FF071D66"); var existingPages = Navigation.NavigationStack.ToList(); await Navigation.PushAsync(new Home()); foreach (var page in existingPages) { Navigation.RemovePage(page); }
                await Task.Delay(80); await PopupNavigation.Instance.PopAsync();
            }
            else { Constantce.Area = "Area"; DibbeenJAR.BackgroundColor = Color.White; DibbeenJAR.TextColor = Color.FromHex("#FF071D66"); }
        }
        async void EjbaratJAR_Clicked(object sender, EventArgs e)
        {
            if (EjbaratJAR.BackgroundColor == Color.White)
            {
                Constantce.Area = "Ejbarat"; Constantce.AreaLang = EjbaratJAR.Text; EjbaratJAR.TextColor = Color.White; EjbaratJAR.BackgroundColor = Color.FromHex("#FF071D66"); var existingPages = Navigation.NavigationStack.ToList(); await Navigation.PushAsync(new Home()); foreach (var page in existingPages) { Navigation.RemovePage(page); }
                await Task.Delay(80); await PopupNavigation.Instance.PopAsync();
            }
            else { Constantce.Area = "Area"; EjbaratJAR.BackgroundColor = Color.White; EjbaratJAR.TextColor = Color.FromHex("#FF071D66"); }
        }
        async void EnabehJAR_Clicked(object sender, EventArgs e)
        {
            if (EnabehJAR.BackgroundColor == Color.White)
            {
                Constantce.Area = "Enabeh"; Constantce.AreaLang = EnabehJAR.Text; EnabehJAR.TextColor = Color.White; EnabehJAR.BackgroundColor = Color.FromHex("#FF071D66"); var existingPages = Navigation.NavigationStack.ToList(); await Navigation.PushAsync(new Home()); foreach (var page in existingPages) { Navigation.RemovePage(page); }
                await Task.Delay(80); await PopupNavigation.Instance.PopAsync();
            }
            else { Constantce.Area = "Area"; EnabehJAR.BackgroundColor = Color.White; EnabehJAR.TextColor = Color.FromHex("#FF071D66"); }
        }
        async void FawaraJAR_Clicked(object sender, EventArgs e)
        {
            if (FawaraJAR.BackgroundColor == Color.White)
            {
                Constantce.Area = "Fawara"; Constantce.AreaLang = FawaraJAR.Text; FawaraJAR.TextColor = Color.White; FawaraJAR.BackgroundColor = Color.FromHex("#FF071D66"); var existingPages = Navigation.NavigationStack.ToList(); await Navigation.PushAsync(new Home()); foreach (var page in existingPages) { Navigation.RemovePage(page); }
                await Task.Delay(80); await PopupNavigation.Instance.PopAsync();
            }
            else { Constantce.Area = "Area"; FawaraJAR.BackgroundColor = Color.White; FawaraJAR.TextColor = Color.FromHex("#FF071D66"); }
        }
        async void FayhaMshairfehElWestaJAR_Clicked(object sender, EventArgs e)
        {
            if (FayhaMshairfehElWestaJAR.BackgroundColor == Color.White)
            {
                Constantce.Area = "Fayha Mshairfeh El-Westa"; Constantce.AreaLang = FayhaMshairfehElWestaJAR.Text; FayhaMshairfehElWestaJAR.TextColor = Color.White; FayhaMshairfehElWestaJAR.BackgroundColor = Color.FromHex("#FF071D66"); var existingPages = Navigation.NavigationStack.ToList(); await Navigation.PushAsync(new Home()); foreach (var page in existingPages) { Navigation.RemovePage(page); }
                await Task.Delay(80); await PopupNavigation.Instance.PopAsync();
            }
            else { Constantce.Area = "Area"; FayhaMshairfehElWestaJAR.BackgroundColor = Color.White; FayhaMshairfehElWestaJAR.TextColor = Color.FromHex("#FF071D66"); }
        }
        async void HadadehJAR_Clicked(object sender, EventArgs e)
        {
            if (HadadehJAR.BackgroundColor == Color.White)
            {
                Constantce.Area = "Hadadeh"; Constantce.AreaLang = HadadehJAR.Text; HadadehJAR.TextColor = Color.White; HadadehJAR.BackgroundColor = Color.FromHex("#FF071D66"); var existingPages = Navigation.NavigationStack.ToList(); await Navigation.PushAsync(new Home()); foreach (var page in existingPages) { Navigation.RemovePage(page); }
                await Task.Delay(80); await PopupNavigation.Instance.PopAsync();
            }
            else { Constantce.Area = "Area"; HadadehJAR.BackgroundColor = Color.White; HadadehJAR.TextColor = Color.FromHex("#FF071D66"); }
        }
        async void HamtaJAR_Clicked(object sender, EventArgs e)
        {
            if (HamtaJAR.BackgroundColor == Color.White)
            {
                Constantce.Area = "Hamta"; Constantce.AreaLang = HamtaJAR.Text; HamtaJAR.TextColor = Color.White; HamtaJAR.BackgroundColor = Color.FromHex("#FF071D66"); var existingPages = Navigation.NavigationStack.ToList(); await Navigation.PushAsync(new Home()); foreach (var page in existingPages) { Navigation.RemovePage(page); }
                await Task.Delay(80); await PopupNavigation.Instance.PopAsync();
            }
            else { Constantce.Area = "Area"; HamtaJAR.BackgroundColor = Color.White; HamtaJAR.TextColor = Color.FromHex("#FF071D66"); }
        }
        async void HasainiyyatJAR_Clicked(object sender, EventArgs e)
        {
            if (HasainiyyatJAR.BackgroundColor == Color.White)
            {
                Constantce.Area = "Hasainiyyat"; Constantce.AreaLang = HasainiyyatJAR.Text; HasainiyyatJAR.TextColor = Color.White; HasainiyyatJAR.BackgroundColor = Color.FromHex("#FF071D66"); var existingPages = Navigation.NavigationStack.ToList(); await Navigation.PushAsync(new Home()); foreach (var page in existingPages) { Navigation.RemovePage(page); }
                await Task.Delay(80); await PopupNavigation.Instance.PopAsync();
            }
            else { Constantce.Area = "Area"; HasainiyyatJAR.BackgroundColor = Color.White; HasainiyyatJAR.TextColor = Color.FromHex("#FF071D66"); }
        }
        async void HazeahJAR_Clicked(object sender, EventArgs e)
        {
            if (HazeahJAR.BackgroundColor == Color.White)
            {
                Constantce.Area = "Hazeah"; Constantce.AreaLang = HazeahJAR.Text; HazeahJAR.TextColor = Color.White; HazeahJAR.BackgroundColor = Color.FromHex("#FF071D66"); var existingPages = Navigation.NavigationStack.ToList(); await Navigation.PushAsync(new Home()); foreach (var page in existingPages) { Navigation.RemovePage(page); }
                await Task.Delay(80); await PopupNavigation.Instance.PopAsync();
            }
            else { Constantce.Area = "Area"; HazeahJAR.BackgroundColor = Color.White; HazeahJAR.TextColor = Color.FromHex("#FF071D66"); }
        }
        async void HoonehJAR_Clicked(object sender, EventArgs e)
        {
            if (HoonehJAR.BackgroundColor == Color.White)
            {
                Constantce.Area = "Hooneh"; Constantce.AreaLang = HoonehJAR.Text; HoonehJAR.TextColor = Color.White; HoonehJAR.BackgroundColor = Color.FromHex("#FF071D66"); var existingPages = Navigation.NavigationStack.ToList(); await Navigation.PushAsync(new Home()); foreach (var page in existingPages) { Navigation.RemovePage(page); }
                await Task.Delay(80); await PopupNavigation.Instance.PopAsync();
            }
            else { Constantce.Area = "Area"; HoonehJAR.BackgroundColor = Color.White; HoonehJAR.TextColor = Color.FromHex("#FF071D66"); }
        }
        async void JabbaJAR_Clicked(object sender, EventArgs e)
        {
            if (JabbaJAR.BackgroundColor == Color.White)
            {
                Constantce.Area = "Jabba"; Constantce.AreaLang = JabbaJAR.Text; JabbaJAR.TextColor = Color.White; JabbaJAR.BackgroundColor = Color.FromHex("#FF071D66"); var existingPages = Navigation.NavigationStack.ToList(); await Navigation.PushAsync(new Home()); foreach (var page in existingPages) { Navigation.RemovePage(page); }
                await Task.Delay(80); await PopupNavigation.Instance.PopAsync();
            }
            else { Constantce.Area = "Area"; JabbaJAR.BackgroundColor = Color.White; JabbaJAR.TextColor = Color.FromHex("#FF071D66"); }
        }
        async void JamlaJAR_Clicked(object sender, EventArgs e)
        {
            if (JamlaJAR.BackgroundColor == Color.White)
            {
                Constantce.Area = "Jamla"; Constantce.AreaLang = JamlaJAR.Text; JamlaJAR.TextColor = Color.White; JamlaJAR.BackgroundColor = Color.FromHex("#FF071D66"); var existingPages = Navigation.NavigationStack.ToList(); await Navigation.PushAsync(new Home()); foreach (var page in existingPages) { Navigation.RemovePage(page); }
                await Task.Delay(80); await PopupNavigation.Instance.PopAsync();
            }
            else { Constantce.Area = "Area"; JamlaJAR.BackgroundColor = Color.White; JamlaJAR.TextColor = Color.FromHex("#FF071D66"); }
        }
        async void JazzazehJAR_Clicked(object sender, EventArgs e)
        {
            if (JazzazehJAR.BackgroundColor == Color.White)
            {
                Constantce.Area = "Jazzazeh"; Constantce.AreaLang = JazzazehJAR.Text; JazzazehJAR.TextColor = Color.White; JazzazehJAR.BackgroundColor = Color.FromHex("#FF071D66"); var existingPages = Navigation.NavigationStack.ToList(); await Navigation.PushAsync(new Home()); foreach (var page in existingPages) { Navigation.RemovePage(page); }
                await Task.Delay(80); await PopupNavigation.Instance.PopAsync();
            }
            else { Constantce.Area = "Area"; JazzazehJAR.BackgroundColor = Color.White; JazzazehJAR.TextColor = Color.FromHex("#FF071D66"); }
        }
        async void JebbahJAR_Clicked(object sender, EventArgs e)
        {
            if (JebbahJAR.BackgroundColor == Color.White)
            {
                Constantce.Area = "Jebbah"; Constantce.AreaLang = JebbahJAR.Text; JebbahJAR.TextColor = Color.White; JebbahJAR.BackgroundColor = Color.FromHex("#FF071D66"); var existingPages = Navigation.NavigationStack.ToList(); await Navigation.PushAsync(new Home()); foreach (var page in existingPages) { Navigation.RemovePage(page); }
                await Task.Delay(80); await PopupNavigation.Instance.PopAsync();
            }
            else { Constantce.Area = "Area"; JebbahJAR.BackgroundColor = Color.White; JebbahJAR.TextColor = Color.FromHex("#FF071D66"); }
        }
        async void JerashJAR_Clicked(object sender, EventArgs e)
        {
            if (JerashJAR.BackgroundColor == Color.White)
            {
                Constantce.Area = "Jerash"; Constantce.AreaLang = JerashJAR.Text; JerashJAR.TextColor = Color.White; JerashJAR.BackgroundColor = Color.FromHex("#FF071D66"); var existingPages = Navigation.NavigationStack.ToList(); await Navigation.PushAsync(new Home()); foreach (var page in existingPages) { Navigation.RemovePage(page); }
                await Task.Delay(80); await PopupNavigation.Instance.PopAsync();
            }
            else { Constantce.Area = "Area"; JerashJAR.BackgroundColor = Color.White; JerashJAR.TextColor = Color.FromHex("#FF071D66"); }
        }
        async void JerashCampJAR_Clicked(object sender, EventArgs e)
        {
            if (JerashCampJAR.BackgroundColor == Color.White)
            {
                Constantce.Area = "Jerash Camp"; Constantce.AreaLang = JerashCampJAR.Text; JerashCampJAR.TextColor = Color.White; JerashCampJAR.BackgroundColor = Color.FromHex("#FF071D66"); var existingPages = Navigation.NavigationStack.ToList(); await Navigation.PushAsync(new Home()); foreach (var page in existingPages) { Navigation.RemovePage(page); }
                await Task.Delay(80); await PopupNavigation.Instance.PopAsync();
            }
            else { Constantce.Area = "Area"; JerashCampJAR.BackgroundColor = Color.White; JerashCampJAR.TextColor = Color.FromHex("#FF071D66"); }
        }
        async void JnaideyyehMshairfehSharqiyyehJAR_Clicked(object sender, EventArgs e)
        {
            if (JnaideyyehMshairfehSharqiyyehJAR.BackgroundColor == Color.White)
            {
                Constantce.Area = "Jnaideyyeh Mshairfeh Sharqiyyeh"; Constantce.AreaLang = JnaideyyehMshairfehSharqiyyehJAR.Text; JnaideyyehMshairfehSharqiyyehJAR.TextColor = Color.White; JnaideyyehMshairfehSharqiyyehJAR.BackgroundColor = Color.FromHex("#FF071D66"); var existingPages = Navigation.NavigationStack.ToList(); await Navigation.PushAsync(new Home()); foreach (var page in existingPages) { Navigation.RemovePage(page); }
                await Task.Delay(80); await PopupNavigation.Instance.PopAsync();
            }
            else { Constantce.Area = "Area"; JnaideyyehMshairfehSharqiyyehJAR.BackgroundColor = Color.White; JnaideyyehMshairfehSharqiyyehJAR.TextColor = Color.FromHex("#FF071D66"); }
        }
        async void KettehJAR_Clicked(object sender, EventArgs e)
        {
            if (KettehJAR.BackgroundColor == Color.White)
            {
                Constantce.Area = "Ketteh"; Constantce.AreaLang = KettehJAR.Text; KettehJAR.TextColor = Color.White; KettehJAR.BackgroundColor = Color.FromHex("#FF071D66"); var existingPages = Navigation.NavigationStack.ToList(); await Navigation.PushAsync(new Home()); foreach (var page in existingPages) { Navigation.RemovePage(page); }
                await Task.Delay(80); await PopupNavigation.Instance.PopAsync();
            }
            else { Constantce.Area = "Area"; KettehJAR.BackgroundColor = Color.White; KettehJAR.TextColor = Color.FromHex("#FF071D66"); }
        }
        async void KfairJAR_Clicked(object sender, EventArgs e)
        {
            if (KfairJAR.BackgroundColor == Color.White)
            {
                Constantce.Area = "Kfair"; Constantce.AreaLang = KfairJAR.Text; KfairJAR.TextColor = Color.White; KfairJAR.BackgroundColor = Color.FromHex("#FF071D66"); var existingPages = Navigation.NavigationStack.ToList(); await Navigation.PushAsync(new Home()); foreach (var page in existingPages) { Navigation.RemovePage(page); }
                await Task.Delay(80); await PopupNavigation.Instance.PopAsync();
            }
            else { Constantce.Area = "Area"; KfairJAR.BackgroundColor = Color.White; KfairJAR.TextColor = Color.FromHex("#FF071D66"); }
        }
        async void KfarKhallJAR_Clicked(object sender, EventArgs e)
        {
            if (KfarKhallJAR.BackgroundColor == Color.White)
            {
                Constantce.Area = "Kfar Khall"; Constantce.AreaLang = KfarKhallJAR.Text; KfarKhallJAR.TextColor = Color.White; KfarKhallJAR.BackgroundColor = Color.FromHex("#FF071D66"); var existingPages = Navigation.NavigationStack.ToList(); await Navigation.PushAsync(new Home()); foreach (var page in existingPages) { Navigation.RemovePage(page); }
                await Task.Delay(80); await PopupNavigation.Instance.PopAsync();
            }
            else { Constantce.Area = "Area"; KfarKhallJAR.BackgroundColor = Color.White; KfarKhallJAR.TextColor = Color.FromHex("#FF071D66"); }
        }
        async void MajdalJAR_Clicked(object sender, EventArgs e)
        {
            if (MajdalJAR.BackgroundColor == Color.White)
            {
                Constantce.Area = "Majdal"; Constantce.AreaLang = MajdalJAR.Text; MajdalJAR.TextColor = Color.White; MajdalJAR.BackgroundColor = Color.FromHex("#FF071D66"); var existingPages = Navigation.NavigationStack.ToList(); await Navigation.PushAsync(new Home()); foreach (var page in existingPages) { Navigation.RemovePage(page); }
                await Task.Delay(80); await PopupNavigation.Instance.PopAsync();
            }
            else { Constantce.Area = "Area"; MajdalJAR.BackgroundColor = Color.White; MajdalJAR.TextColor = Color.FromHex("#FF071D66"); }
        }
        async void ManshtalFaisalJAR_Clicked(object sender, EventArgs e)
        {
            if (ManshtalFaisalJAR.BackgroundColor == Color.White)
            {
                Constantce.Area = "Manshtal Faisal"; Constantce.AreaLang = ManshtalFaisalJAR.Text; ManshtalFaisalJAR.TextColor = Color.White; ManshtalFaisalJAR.BackgroundColor = Color.FromHex("#FF071D66"); var existingPages = Navigation.NavigationStack.ToList(); await Navigation.PushAsync(new Home()); foreach (var page in existingPages) { Navigation.RemovePage(page); }
                await Task.Delay(80); await PopupNavigation.Instance.PopAsync();
            }
            else { Constantce.Area = "Area"; ManshtalFaisalJAR.BackgroundColor = Color.White; ManshtalFaisalJAR.TextColor = Color.FromHex("#FF071D66"); }
        }
        async void MansorahKhshaibehJAR_Clicked(object sender, EventArgs e)
        {
            if (MansorahKhshaibehJAR.BackgroundColor == Color.White)
            {
                Constantce.Area = "Mansorah Khshaibeh"; Constantce.AreaLang = MansorahKhshaibehJAR.Text; MansorahKhshaibehJAR.TextColor = Color.White; MansorahKhshaibehJAR.BackgroundColor = Color.FromHex("#FF071D66"); var existingPages = Navigation.NavigationStack.ToList(); await Navigation.PushAsync(new Home()); foreach (var page in existingPages) { Navigation.RemovePage(page); }
                await Task.Delay(80); await PopupNavigation.Instance.PopAsync();
            }
            else { Constantce.Area = "Area"; MansorahKhshaibehJAR.BackgroundColor = Color.White; MansorahKhshaibehJAR.TextColor = Color.FromHex("#FF071D66"); }
        }
        async void MastabahJAR_Clicked(object sender, EventArgs e)
        {
            if (MastabahJAR.BackgroundColor == Color.White)
            {
                Constantce.Area = "Mastabah"; Constantce.AreaLang = MastabahJAR.Text; MastabahJAR.TextColor = Color.White; MastabahJAR.BackgroundColor = Color.FromHex("#FF071D66"); var existingPages = Navigation.NavigationStack.ToList(); await Navigation.PushAsync(new Home()); foreach (var page in existingPages) { Navigation.RemovePage(page); }
                await Task.Delay(80); await PopupNavigation.Instance.PopAsync();
            }
            else { Constantce.Area = "Area"; MastabahJAR.BackgroundColor = Color.White; MastabahJAR.TextColor = Color.FromHex("#FF071D66"); }
        }
        async void MeqeblehJAR_Clicked(object sender, EventArgs e)
        {
            if (MeqeblehJAR.BackgroundColor == Color.White)
            {
                Constantce.Area = "Meqebleh"; Constantce.AreaLang = MeqeblehJAR.Text; MeqeblehJAR.TextColor = Color.White; MeqeblehJAR.BackgroundColor = Color.FromHex("#FF071D66"); var existingPages = Navigation.NavigationStack.ToList(); await Navigation.PushAsync(new Home()); foreach (var page in existingPages) { Navigation.RemovePage(page); }
                await Task.Delay(80); await PopupNavigation.Instance.PopAsync();
            }
            else { Constantce.Area = "Area"; MeqeblehJAR.BackgroundColor = Color.White; MeqeblehJAR.TextColor = Color.FromHex("#FF071D66"); }
        }
        async void MersieJAR_Clicked(object sender, EventArgs e)
        {
            if (MersieJAR.BackgroundColor == Color.White)
            {
                Constantce.Area = "Mersi'e"; Constantce.AreaLang = MersieJAR.Text; MersieJAR.TextColor = Color.White; MersieJAR.BackgroundColor = Color.FromHex("#FF071D66"); var existingPages = Navigation.NavigationStack.ToList(); await Navigation.PushAsync(new Home()); foreach (var page in existingPages) { Navigation.RemovePage(page); }
                await Task.Delay(80); await PopupNavigation.Instance.PopAsync();
            }
            else { Constantce.Area = "Area"; MersieJAR.BackgroundColor = Color.White; MersieJAR.TextColor = Color.FromHex("#FF071D66"); }
        }
        async void MshairfehGharbiyyehJAR_Clicked(object sender, EventArgs e)
        {
            if (MshairfehGharbiyyehJAR.BackgroundColor == Color.White)
            {
                Constantce.Area = "Mshairfeh Gharbiyyeh"; Constantce.AreaLang = MshairfehGharbiyyehJAR.Text; MshairfehGharbiyyehJAR.TextColor = Color.White; MshairfehGharbiyyehJAR.BackgroundColor = Color.FromHex("#FF071D66"); var existingPages = Navigation.NavigationStack.ToList(); await Navigation.PushAsync(new Home()); foreach (var page in existingPages) { Navigation.RemovePage(page); }
                await Task.Delay(80); await PopupNavigation.Instance.PopAsync();
            }
            else { Constantce.Area = "Area"; MshairfehGharbiyyehJAR.BackgroundColor = Color.White; MshairfehGharbiyyehJAR.TextColor = Color.FromHex("#FF071D66"); }
        }
        async void NabiHoodJAR_Clicked(object sender, EventArgs e)
        {
            if (NabiHoodJAR.BackgroundColor == Color.White)
            {
                Constantce.Area = "Nabi Hood"; Constantce.AreaLang = NabiHoodJAR.Text; NabiHoodJAR.TextColor = Color.White; NabiHoodJAR.BackgroundColor = Color.FromHex("#FF071D66"); var existingPages = Navigation.NavigationStack.ToList(); await Navigation.PushAsync(new Home()); foreach (var page in existingPages) { Navigation.RemovePage(page); }
                await Task.Delay(80); await PopupNavigation.Instance.PopAsync();
            }
            else { Constantce.Area = "Area"; NabiHoodJAR.BackgroundColor = Color.White; NabiHoodJAR.TextColor = Color.FromHex("#FF071D66"); }
        }
        async void NahlehJAR_Clicked(object sender, EventArgs e)
        {
            if (NahlehJAR.BackgroundColor == Color.White)
            {
                Constantce.Area = "Nahleh"; Constantce.AreaLang = NahlehJAR.Text; NahlehJAR.TextColor = Color.White; NahlehJAR.BackgroundColor = Color.FromHex("#FF071D66"); var existingPages = Navigation.NavigationStack.ToList(); await Navigation.PushAsync(new Home()); foreach (var page in existingPages) { Navigation.RemovePage(page); }
                await Task.Delay(80); await PopupNavigation.Instance.PopAsync();
            }
            else { Constantce.Area = "Area"; NahlehJAR.BackgroundColor = Color.White; NahlehJAR.TextColor = Color.FromHex("#FF071D66"); }
        }
        async void NajdehJAR_Clicked(object sender, EventArgs e)
        {
            if (NajdehJAR.BackgroundColor == Color.White)
            {
                Constantce.Area = "Najdeh"; Constantce.AreaLang = NajdehJAR.Text; NajdehJAR.TextColor = Color.White; NajdehJAR.BackgroundColor = Color.FromHex("#FF071D66"); var existingPages = Navigation.NavigationStack.ToList(); await Navigation.PushAsync(new Home()); foreach (var page in existingPages) { Navigation.RemovePage(page); }
                await Task.Delay(80); await PopupNavigation.Instance.PopAsync();
            }
            else { Constantce.Area = "Area"; NajdehJAR.BackgroundColor = Color.White; NajdehJAR.TextColor = Color.FromHex("#FF071D66"); }
        }
        async void QafqafaJAR_Clicked(object sender, EventArgs e)
        {
            if (QafqafaJAR.BackgroundColor == Color.White)
            {
                Constantce.Area = "Qafqafa"; Constantce.AreaLang = QafqafaJAR.Text; QafqafaJAR.TextColor = Color.White; QafqafaJAR.BackgroundColor = Color.FromHex("#FF071D66"); var existingPages = Navigation.NavigationStack.ToList(); await Navigation.PushAsync(new Home()); foreach (var page in existingPages) { Navigation.RemovePage(page); }
                await Task.Delay(80); await PopupNavigation.Instance.PopAsync();
            }
            else { Constantce.Area = "Area"; QafqafaJAR.BackgroundColor = Color.White; QafqafaJAR.TextColor = Color.FromHex("#FF071D66"); }
        }
        async void QraiaJAR_Clicked(object sender, EventArgs e)
        {
            if (QraiaJAR.BackgroundColor == Color.White)
            {
                Constantce.Area = "Qraia'"; Constantce.AreaLang = QraiaJAR.Text; QraiaJAR.TextColor = Color.White; QraiaJAR.BackgroundColor = Color.FromHex("#FF071D66"); var existingPages = Navigation.NavigationStack.ToList(); await Navigation.PushAsync(new Home()); foreach (var page in existingPages) { Navigation.RemovePage(page); }
                await Task.Delay(80); await PopupNavigation.Instance.PopAsync();
            }
            else { Constantce.Area = "Area"; QraiaJAR.BackgroundColor = Color.White; QraiaJAR.TextColor = Color.FromHex("#FF071D66"); }
        }
        async void RahmaniyyehJAR_Clicked(object sender, EventArgs e)
        {
            if (RahmaniyyehJAR.BackgroundColor == Color.White)
            {
                Constantce.Area = "Rahmaniyyeh"; Constantce.AreaLang = RahmaniyyehJAR.Text; RahmaniyyehJAR.TextColor = Color.White; RahmaniyyehJAR.BackgroundColor = Color.FromHex("#FF071D66"); var existingPages = Navigation.NavigationStack.ToList(); await Navigation.PushAsync(new Home()); foreach (var page in existingPages) { Navigation.RemovePage(page); }
                await Task.Delay(80); await PopupNavigation.Instance.PopAsync();
            }
            else { Constantce.Area = "Area"; RahmaniyyehJAR.BackgroundColor = Color.White; RahmaniyyehJAR.TextColor = Color.FromHex("#FF071D66"); }
        }
        async void RaiehJAR_Clicked(object sender, EventArgs e)
        {
            if (RaiehJAR.BackgroundColor == Color.White)
            {
                Constantce.Area = "Raieh"; Constantce.AreaLang = RaiehJAR.Text; RaiehJAR.TextColor = Color.White; RaiehJAR.BackgroundColor = Color.FromHex("#FF071D66"); var existingPages = Navigation.NavigationStack.ToList(); await Navigation.PushAsync(new Home()); foreach (var page in existingPages) { Navigation.RemovePage(page); }
                await Task.Delay(80); await PopupNavigation.Instance.PopAsync();
            }
            else { Constantce.Area = "Area"; RaiehJAR.BackgroundColor = Color.White; RaiehJAR.TextColor = Color.FromHex("#FF071D66"); }
        }
        async void RaimoonJAR_Clicked(object sender, EventArgs e)
        {
            if (RaimoonJAR.BackgroundColor == Color.White)
            {
                Constantce.Area = "Raimoon"; Constantce.AreaLang = RaimoonJAR.Text; RaimoonJAR.TextColor = Color.White; RaimoonJAR.BackgroundColor = Color.FromHex("#FF071D66"); var existingPages = Navigation.NavigationStack.ToList(); await Navigation.PushAsync(new Home()); foreach (var page in existingPages) { Navigation.RemovePage(page); }
                await Task.Delay(80); await PopupNavigation.Instance.PopAsync();
            }
            else { Constantce.Area = "Area"; RaimoonJAR.BackgroundColor = Color.White; RaimoonJAR.TextColor = Color.FromHex("#FF071D66"); }
        }
        async void RashaydehJAR_Clicked(object sender, EventArgs e)
        {
            if (RashaydehJAR.BackgroundColor == Color.White)
            {
                Constantce.Area = "Rashaydeh"; Constantce.AreaLang = RashaydehJAR.Text; RashaydehJAR.TextColor = Color.White; RashaydehJAR.BackgroundColor = Color.FromHex("#FF071D66"); var existingPages = Navigation.NavigationStack.ToList(); await Navigation.PushAsync(new Home()); foreach (var page in existingPages) { Navigation.RemovePage(page); }
                await Task.Delay(80); await PopupNavigation.Instance.PopAsync();
            }
            else { Constantce.Area = "Area"; RashaydehJAR.BackgroundColor = Color.White; RashaydehJAR.TextColor = Color.FromHex("#FF071D66"); }
        }
        async void SakebJAR_Clicked(object sender, EventArgs e)
        {
            if (SakebJAR.BackgroundColor == Color.White)
            {
                Constantce.Area = "Sakeb"; Constantce.AreaLang = SakebJAR.Text; SakebJAR.TextColor = Color.White; SakebJAR.BackgroundColor = Color.FromHex("#FF071D66"); var existingPages = Navigation.NavigationStack.ToList(); await Navigation.PushAsync(new Home()); foreach (var page in existingPages) { Navigation.RemovePage(page); }
                await Task.Delay(80); await PopupNavigation.Instance.PopAsync();
            }
            else { Constantce.Area = "Area"; SakebJAR.BackgroundColor = Color.White; SakebJAR.TextColor = Color.FromHex("#FF071D66"); }
        }
        async void SoofJAR_Clicked(object sender, EventArgs e)
        {
            if (SoofJAR.BackgroundColor == Color.White)
            {
                Constantce.Area = "Soof"; Constantce.AreaLang = SoofJAR.Text; SoofJAR.TextColor = Color.White; SoofJAR.BackgroundColor = Color.FromHex("#FF071D66"); var existingPages = Navigation.NavigationStack.ToList(); await Navigation.PushAsync(new Home()); foreach (var page in existingPages) { Navigation.RemovePage(page); }
                await Task.Delay(80); await PopupNavigation.Instance.PopAsync();
            }
            else { Constantce.Area = "Area"; SoofJAR.BackgroundColor = Color.White; SoofJAR.TextColor = Color.FromHex("#FF071D66"); }
        }
        async void SoofCampJAR_Clicked(object sender, EventArgs e)
        {
            if (SoofCampJAR.BackgroundColor == Color.White)
            {
                Constantce.Area = "Soof Camp"; Constantce.AreaLang = SoofCampJAR.Text; SoofCampJAR.TextColor = Color.White; SoofCampJAR.BackgroundColor = Color.FromHex("#FF071D66"); var existingPages = Navigation.NavigationStack.ToList(); await Navigation.PushAsync(new Home()); foreach (var page in existingPages) { Navigation.RemovePage(page); }
                await Task.Delay(80); await PopupNavigation.Instance.PopAsync();
            }
            else { Constantce.Area = "Area"; SoofCampJAR.BackgroundColor = Color.White; SoofCampJAR.TextColor = Color.FromHex("#FF071D66"); }
        }
        async void TaletErrozJAR_Clicked(object sender, EventArgs e)
        {
            if (TaletErrozJAR.BackgroundColor == Color.White)
            {
                Constantce.Area = "Tal'et Erroz"; Constantce.AreaLang = TaletErrozJAR.Text; TaletErrozJAR.TextColor = Color.White; TaletErrozJAR.BackgroundColor = Color.FromHex("#FF071D66"); var existingPages = Navigation.NavigationStack.ToList(); await Navigation.PushAsync(new Home()); foreach (var page in existingPages) { Navigation.RemovePage(page); }
                await Task.Delay(80); await PopupNavigation.Instance.PopAsync();
            }
            else { Constantce.Area = "Area"; TaletErrozJAR.BackgroundColor = Color.White; TaletErrozJAR.TextColor = Color.FromHex("#FF071D66"); }
        }
        async void UmmEzzaitoonJAR_Clicked(object sender, EventArgs e)
        {
            if (UmmEzzaitoonJAR.BackgroundColor == Color.White)
            {
                Constantce.Area = "Umm Ezzaitoon"; Constantce.AreaLang = UmmEzzaitoonJAR.Text; UmmEzzaitoonJAR.TextColor = Color.White; UmmEzzaitoonJAR.BackgroundColor = Color.FromHex("#FF071D66"); var existingPages = Navigation.NavigationStack.ToList(); await Navigation.PushAsync(new Home()); foreach (var page in existingPages) { Navigation.RemovePage(page); }
                await Task.Delay(80); await PopupNavigation.Instance.PopAsync();
            }
            else { Constantce.Area = "Area"; UmmEzzaitoonJAR.BackgroundColor = Color.White; UmmEzzaitoonJAR.TextColor = Color.FromHex("#FF071D66"); }
        }
        async void UmmQontarahJAR_Clicked(object sender, EventArgs e)
        {
            if (UmmQontarahJAR.BackgroundColor == Color.White)
            {
                Constantce.Area = "Umm Qontarah"; Constantce.AreaLang = UmmQontarahJAR.Text; UmmQontarahJAR.TextColor = Color.White; UmmQontarahJAR.BackgroundColor = Color.FromHex("#FF071D66"); var existingPages = Navigation.NavigationStack.ToList(); await Navigation.PushAsync(new Home()); foreach (var page in existingPages) { Navigation.RemovePage(page); }
                await Task.Delay(80); await PopupNavigation.Instance.PopAsync();
            }
            else { Constantce.Area = "Area"; UmmQontarahJAR.BackgroundColor = Color.White; UmmQontarahJAR.TextColor = Color.FromHex("#FF071D66"); }
        }
        async void UmmRamehJAR_Clicked(object sender, EventArgs e)
        {
            if (UmmRamehJAR.BackgroundColor == Color.White)
            {
                Constantce.Area = "Umm Rameh"; Constantce.AreaLang = UmmRamehJAR.Text; UmmRamehJAR.TextColor = Color.White; UmmRamehJAR.BackgroundColor = Color.FromHex("#FF071D66"); var existingPages = Navigation.NavigationStack.ToList(); await Navigation.PushAsync(new Home()); foreach (var page in existingPages) { Navigation.RemovePage(page); }
                await Task.Delay(80); await PopupNavigation.Instance.PopAsync();
            }
            else { Constantce.Area = "Area"; UmmRamehJAR.BackgroundColor = Color.White; UmmRamehJAR.TextColor = Color.FromHex("#FF071D66"); }
        }
        async void ZaqreetJAR_Clicked(object sender, EventArgs e)
        {
            if (ZaqreetJAR.BackgroundColor == Color.White)
            {
                Constantce.Area = "Zaqreet"; Constantce.AreaLang = ZaqreetJAR.Text; ZaqreetJAR.TextColor = Color.White; ZaqreetJAR.BackgroundColor = Color.FromHex("#FF071D66"); var existingPages = Navigation.NavigationStack.ToList(); await Navigation.PushAsync(new Home()); foreach (var page in existingPages) { Navigation.RemovePage(page); }
                await Task.Delay(80); await PopupNavigation.Instance.PopAsync();
            }
            else { Constantce.Area = "Area"; ZaqreetJAR.BackgroundColor = Color.White; ZaqreetJAR.TextColor = Color.FromHex("#FF071D66"); }
        }

    }
}