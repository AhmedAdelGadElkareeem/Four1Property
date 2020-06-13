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
    public partial class Aqaba : PopupPage
    {
        public Aqaba()
        {
            InitializeComponent();

            if (Application.Current.Properties["Language"].ToString() == "Arabic")
            {
                this.FlowDirection = FlowDirection.RightToLeft;
                UpText.Text = "الرجاء اختيار المنطقة";

                Diesah.Text = "الديسه";
                AqabaArea.Text = "العقبة";
                Asaleah.Text = "العسليه";
                Ghal.Text = "الغال";
                Hmaimieh.Text = "الحميمه";
                HmaimiehJadiedeh.Text = "الحميمة الجديدة";
                Kaldi.Text = "الخالدي";
                Mezfer.Text = "المزفر";
                Quairah.Text = "القويره";
                Reisheh.Text = "الريشه";
                Rashdyah.Text = "الراشديه";
                Shakriyyeh.Text = "الشاكرية";
                Sallheiah.Text = "الصالحيه";
                Taweel.Text = "الطويل";
                Twaiseh.Text = "الطويسه";
                BadouAbuKhushibeh.Text = "بدو ابو خشيبه";
                BeirMathkoor.Text = "بئر مذكور";
                DabbetHanoot.Text = "دبة حانوت";
                Fienan.Text = "فينان";
                MujamaAlShahenat.Text = "مجمع الشاحنات";
                Mnaishier.Text = "منيشير";
                Qatar.Text = "قطر";
                Qraiqreh.Text = "قريقره";
                Rahmah.Text = "رحمه";
                Ramm.Text = "رم";
                ReaSaadeh.Text = "ريع سعاده";
                Tutun.Text = "تتن";
                UmmElBsateen.Text = "ام البساتين";
            }
            else
            {
                this.FlowDirection = FlowDirection.LeftToRight;
                UpText.Text = "Please Select Area";

                Diesah.Text = "Diesah";
                AqabaArea.Text = "Aqaba";
                Asaleah.Text = "Asaleah";
                Ghal.Text = "Ghal";
                Hmaimieh.Text = "Hmaimieh";
                HmaimiehJadiedeh.Text = "Hmaimieh Jadiedeh";
                Kaldi.Text = "Kaldi";
                Mezfer.Text = "Mezfer";
                Quairah.Text = "Quairah";
                Reisheh.Text = "Reisheh";
                Rashdyah.Text = "Rashdyah";
                Shakriyyeh.Text = "Shakriyyeh";
                Sallheiah.Text = "Sallheiah";
                Taweel.Text = "Taweel";
                Twaiseh.Text = "Twaiseh";
                BadouAbuKhushibeh.Text = "Badou Abu Khushibeh";
                BeirMathkoor.Text = "Beir Mathkoor";
                DabbetHanoot.Text = "Dabbet Hanoot";
                Fienan.Text = "Fienan";
                MujamaAlShahenat.Text = "Mujam'a Al-Shahenat";
                Mnaishier.Text = "Mnaishier";
                Qatar.Text = "Qatar";
                Qraiqreh.Text = "Qraiqreh";
                Rahmah.Text = "Rahmah";
                Ramm.Text = "Ramm";
                ReaSaadeh.Text = "Re'a Sa'adeh";
                Tutun.Text = "Tutun";
                UmmElBsateen.Text = "Umm El - Bsateen";
            }
            if (Constantce.Area == "Diesah") { Diesah.BackgroundColor = Color.FromHex("#FF071D66"); Diesah.TextColor = Color.White; }
            else if (Constantce.Area == "Aqaba") { AqabaArea.BackgroundColor = Color.FromHex("#FF071D66"); AqabaArea.TextColor = Color.White; }
            else if (Constantce.Area == "Asaleah") { Asaleah.BackgroundColor = Color.FromHex("#FF071D66"); Asaleah.TextColor = Color.White; }
            else if (Constantce.Area == "Ghal") { Ghal.BackgroundColor = Color.FromHex("#FF071D66"); Ghal.TextColor = Color.White; }
            else if (Constantce.Area == "Hmaimieh") { Hmaimieh.BackgroundColor = Color.FromHex("#FF071D66"); Hmaimieh.TextColor = Color.White; }
            else if (Constantce.Area == "Hmaimieh Jadiedeh") { HmaimiehJadiedeh.BackgroundColor = Color.FromHex("#FF071D66"); HmaimiehJadiedeh.TextColor = Color.White; }
            else if (Constantce.Area == "Kaldi") { Kaldi.BackgroundColor = Color.FromHex("#FF071D66"); Kaldi.TextColor = Color.White; }
            else if (Constantce.Area == "Mezfer") { Mezfer.BackgroundColor = Color.FromHex("#FF071D66"); Mezfer.TextColor = Color.White; }
            else if (Constantce.Area == "Quairah") { Quairah.BackgroundColor = Color.FromHex("#FF071D66"); Quairah.TextColor = Color.White; }
            else if (Constantce.Area == "Reisheh") { Reisheh.BackgroundColor = Color.FromHex("#FF071D66"); Reisheh.TextColor = Color.White; }
            else if (Constantce.Area == "Rashdyah") { Rashdyah.BackgroundColor = Color.FromHex("#FF071D66"); Rashdyah.TextColor = Color.White; }
            else if (Constantce.Area == "Shakriyyeh") { Shakriyyeh.BackgroundColor = Color.FromHex("#FF071D66"); Shakriyyeh.TextColor = Color.White; }
            else if (Constantce.Area == "Sallheiah") { Sallheiah.BackgroundColor = Color.FromHex("#FF071D66"); Sallheiah.TextColor = Color.White; }
            else if (Constantce.Area == "Taweel") { Taweel.BackgroundColor = Color.FromHex("#FF071D66"); Taweel.TextColor = Color.White; }
            else if (Constantce.Area == "Twaiseh") { Twaiseh.BackgroundColor = Color.FromHex("#FF071D66"); Twaiseh.TextColor = Color.White; }
            else if (Constantce.Area == "Badou Abu Khushibeh") { BadouAbuKhushibeh.BackgroundColor = Color.FromHex("#FF071D66"); BadouAbuKhushibeh.TextColor = Color.White; }
            else if (Constantce.Area == "Beir Mathkoor") { BeirMathkoor.BackgroundColor = Color.FromHex("#FF071D66"); BeirMathkoor.TextColor = Color.White; }
            else if (Constantce.Area == "Dabbet Hanoot") { DabbetHanoot.BackgroundColor = Color.FromHex("#FF071D66"); DabbetHanoot.TextColor = Color.White; }
            else if (Constantce.Area == "Fienan") { Fienan.BackgroundColor = Color.FromHex("#FF071D66"); Fienan.TextColor = Color.White; }
            else if (Constantce.Area == "Mujam'a Al-Shahenat") { MujamaAlShahenat.BackgroundColor = Color.FromHex("#FF071D66"); MujamaAlShahenat.TextColor = Color.White; }
            else if (Constantce.Area == "Mnaishier") { Mnaishier.BackgroundColor = Color.FromHex("#FF071D66"); Mnaishier.TextColor = Color.White; }
            else if (Constantce.Area == "Qatar") { Qatar.BackgroundColor = Color.FromHex("#FF071D66"); Qatar.TextColor = Color.White; }
            else if (Constantce.Area == "Qraiqreh") { Qraiqreh.BackgroundColor = Color.FromHex("#FF071D66"); Qraiqreh.TextColor = Color.White; }
            else if (Constantce.Area == "Rahmah") { Rahmah.BackgroundColor = Color.FromHex("#FF071D66"); Rahmah.TextColor = Color.White; }
            else if (Constantce.Area == "Ramm") { Ramm.BackgroundColor = Color.FromHex("#FF071D66"); Ramm.TextColor = Color.White; }
            else if (Constantce.Area == "Re'a Sa'adeh") { ReaSaadeh.BackgroundColor = Color.FromHex("#FF071D66"); ReaSaadeh.TextColor = Color.White; }
            else if (Constantce.Area == "Tutun") { Tutun.BackgroundColor = Color.FromHex("#FF071D66"); Tutun.TextColor = Color.White; }
            else if (Constantce.Area == "Umm El - Bsateen") { UmmElBsateen.BackgroundColor = Color.FromHex("#FF071D66"); UmmElBsateen.TextColor = Color.White; }
        }




        //******************************Start Aqaba Areas**********************************************************************
        async void Diesah_Clicked(object sender, EventArgs e) { if (Diesah.BackgroundColor == Color.White) { Constantce.Area = "Diesah"; Constantce.AreaLang = Diesah.Text; Diesah.TextColor = Color.White; Diesah.BackgroundColor = Color.FromHex("#FF071D66"); var existingPages = Navigation.NavigationStack.ToList();Page page = existingPages.FirstOrDefault();Navigation.InsertPageBefore(new Home(), page);Navigation.RemovePage(page);await PopupNavigation.Instance.PopAsync(); } else { Constantce.Area = "Area"; Diesah.BackgroundColor = Color.White; Diesah.TextColor = Color.FromHex("#FF071D66"); } }
        async void Aqaba_Clicked(object sender, EventArgs e) { if (AqabaArea.BackgroundColor == Color.White) { Constantce.Area = "Aqaba"; Constantce.AreaLang = AqabaArea.Text; AqabaArea.TextColor = Color.White; AqabaArea.BackgroundColor = Color.FromHex("#FF071D66"); var existingPages = Navigation.NavigationStack.ToList();Page page = existingPages.FirstOrDefault();Navigation.InsertPageBefore(new Home(), page);Navigation.RemovePage(page);await PopupNavigation.Instance.PopAsync(); } else { Constantce.Area = "Area"; AqabaArea.BackgroundColor = Color.White; AqabaArea.TextColor = Color.FromHex("#FF071D66"); } }
        async void Asaleah_Clicked(object sender, EventArgs e) { if (Asaleah.BackgroundColor == Color.White) { Constantce.Area = "Asaleah"; Constantce.AreaLang = Asaleah.Text; Asaleah.TextColor = Color.White; Asaleah.BackgroundColor = Color.FromHex("#FF071D66"); var existingPages = Navigation.NavigationStack.ToList();Page page = existingPages.FirstOrDefault();Navigation.InsertPageBefore(new Home(), page);Navigation.RemovePage(page);await PopupNavigation.Instance.PopAsync(); } else { Constantce.Area = "Area"; Asaleah.BackgroundColor = Color.White; Asaleah.TextColor = Color.FromHex("#FF071D66"); } }
        async void Ghal_Clicked(object sender, EventArgs e) { if (Ghal.BackgroundColor == Color.White) { Constantce.Area = "Ghal"; Constantce.AreaLang = Ghal.Text; Ghal.TextColor = Color.White; Ghal.BackgroundColor = Color.FromHex("#FF071D66"); var existingPages = Navigation.NavigationStack.ToList();Page page = existingPages.FirstOrDefault();Navigation.InsertPageBefore(new Home(), page);Navigation.RemovePage(page);await PopupNavigation.Instance.PopAsync(); } else { Constantce.Area = "Area"; Ghal.BackgroundColor = Color.White; Ghal.TextColor = Color.FromHex("#FF071D66"); } }
        async void Hmaimieh_Clicked(object sender, EventArgs e) { if (Hmaimieh.BackgroundColor == Color.White) { Constantce.Area = "Hmaimieh"; Constantce.AreaLang = Hmaimieh.Text; Hmaimieh.TextColor = Color.White; Hmaimieh.BackgroundColor = Color.FromHex("#FF071D66"); var existingPages = Navigation.NavigationStack.ToList();Page page = existingPages.FirstOrDefault();Navigation.InsertPageBefore(new Home(), page);Navigation.RemovePage(page);await PopupNavigation.Instance.PopAsync(); } else { Constantce.Area = "Area"; Hmaimieh.BackgroundColor = Color.White; Hmaimieh.TextColor = Color.FromHex("#FF071D66"); } }
        async void HmaimiehJadiedeh_Clicked(object sender, EventArgs e) { if (HmaimiehJadiedeh.BackgroundColor == Color.White) { Constantce.Area = "Hmaimieh Jadiedeh"; Constantce.AreaLang = HmaimiehJadiedeh.Text; HmaimiehJadiedeh.TextColor = Color.White; HmaimiehJadiedeh.BackgroundColor = Color.FromHex("#FF071D66"); var existingPages = Navigation.NavigationStack.ToList();Page page = existingPages.FirstOrDefault();Navigation.InsertPageBefore(new Home(), page);Navigation.RemovePage(page);await PopupNavigation.Instance.PopAsync(); } else { Constantce.Area = "Area"; HmaimiehJadiedeh.BackgroundColor = Color.White; HmaimiehJadiedeh.TextColor = Color.FromHex("#FF071D66"); } }
        async void Kaldi_Clicked(object sender, EventArgs e) { if (Kaldi.BackgroundColor == Color.White) { Constantce.Area = "Kaldi"; Constantce.AreaLang = Kaldi.Text; Kaldi.TextColor = Color.White; Kaldi.BackgroundColor = Color.FromHex("#FF071D66"); var existingPages = Navigation.NavigationStack.ToList();Page page = existingPages.FirstOrDefault();Navigation.InsertPageBefore(new Home(), page);Navigation.RemovePage(page);await PopupNavigation.Instance.PopAsync(); } else { Constantce.Area = "Area"; Kaldi.BackgroundColor = Color.White; Kaldi.TextColor = Color.FromHex("#FF071D66"); } }
        async void Mezfer_Clicked(object sender, EventArgs e) { if (Mezfer.BackgroundColor == Color.White) { Constantce.Area = "Mezfer"; Constantce.AreaLang = Mezfer.Text; Mezfer.TextColor = Color.White; Mezfer.BackgroundColor = Color.FromHex("#FF071D66"); var existingPages = Navigation.NavigationStack.ToList();Page page = existingPages.FirstOrDefault();Navigation.InsertPageBefore(new Home(), page);Navigation.RemovePage(page);await PopupNavigation.Instance.PopAsync(); } else { Constantce.Area = "Area"; Mezfer.BackgroundColor = Color.White; Mezfer.TextColor = Color.FromHex("#FF071D66"); } }
        async void Quairah_Clicked(object sender, EventArgs e) { if (Quairah.BackgroundColor == Color.White) { Constantce.Area = "Quairah"; Constantce.AreaLang = Quairah.Text; Quairah.TextColor = Color.White; Quairah.BackgroundColor = Color.FromHex("#FF071D66"); var existingPages = Navigation.NavigationStack.ToList();Page page = existingPages.FirstOrDefault();Navigation.InsertPageBefore(new Home(), page);Navigation.RemovePage(page);await PopupNavigation.Instance.PopAsync(); } else { Constantce.Area = "Area"; Quairah.BackgroundColor = Color.White; Quairah.TextColor = Color.FromHex("#FF071D66"); } }
        async void Reisheh_Clicked(object sender, EventArgs e) { if (Reisheh.BackgroundColor == Color.White) { Constantce.Area = "Reisheh"; Constantce.AreaLang = Reisheh.Text; Reisheh.TextColor = Color.White; Reisheh.BackgroundColor = Color.FromHex("#FF071D66"); var existingPages = Navigation.NavigationStack.ToList();Page page = existingPages.FirstOrDefault();Navigation.InsertPageBefore(new Home(), page);Navigation.RemovePage(page);await PopupNavigation.Instance.PopAsync(); } else { Constantce.Area = "Area"; Reisheh.BackgroundColor = Color.White; Reisheh.TextColor = Color.FromHex("#FF071D66"); } }
        async void Rashdyah_Clicked(object sender, EventArgs e) { if (Rashdyah.BackgroundColor == Color.White) { Constantce.Area = "Rashdyah"; Constantce.AreaLang = Rashdyah.Text; Rashdyah.TextColor = Color.White; Rashdyah.BackgroundColor = Color.FromHex("#FF071D66"); var existingPages = Navigation.NavigationStack.ToList();Page page = existingPages.FirstOrDefault();Navigation.InsertPageBefore(new Home(), page);Navigation.RemovePage(page);await PopupNavigation.Instance.PopAsync(); } else { Constantce.Area = "Area"; Rashdyah.BackgroundColor = Color.White; Rashdyah.TextColor = Color.FromHex("#FF071D66"); } }
        async void Shakriyyeh_Clicked(object sender, EventArgs e) { if (Shakriyyeh.BackgroundColor == Color.White) { Constantce.Area = "Shakriyyeh"; Constantce.AreaLang = Shakriyyeh.Text; Shakriyyeh.TextColor = Color.White; Shakriyyeh.BackgroundColor = Color.FromHex("#FF071D66"); var existingPages = Navigation.NavigationStack.ToList();Page page = existingPages.FirstOrDefault();Navigation.InsertPageBefore(new Home(), page);Navigation.RemovePage(page);await PopupNavigation.Instance.PopAsync(); } else { Constantce.Area = "Area"; Shakriyyeh.BackgroundColor = Color.White; Shakriyyeh.TextColor = Color.FromHex("#FF071D66"); } }
        async void Sallheiah_Clicked(object sender, EventArgs e) { if (Sallheiah.BackgroundColor == Color.White) { Constantce.Area = "Sallheiah"; Constantce.AreaLang = Sallheiah.Text; Sallheiah.TextColor = Color.White; Sallheiah.BackgroundColor = Color.FromHex("#FF071D66"); var existingPages = Navigation.NavigationStack.ToList();Page page = existingPages.FirstOrDefault();Navigation.InsertPageBefore(new Home(), page);Navigation.RemovePage(page);await PopupNavigation.Instance.PopAsync(); } else { Constantce.Area = "Area"; Sallheiah.BackgroundColor = Color.White; Sallheiah.TextColor = Color.FromHex("#FF071D66"); } }
        async void Taweel_Clicked(object sender, EventArgs e) { if (Taweel.BackgroundColor == Color.White) { Constantce.Area = "Taweel"; Constantce.AreaLang = Taweel.Text; Taweel.TextColor = Color.White; Taweel.BackgroundColor = Color.FromHex("#FF071D66"); var existingPages = Navigation.NavigationStack.ToList();Page page = existingPages.FirstOrDefault();Navigation.InsertPageBefore(new Home(), page);Navigation.RemovePage(page);await PopupNavigation.Instance.PopAsync(); } else { Constantce.Area = "Area"; Taweel.BackgroundColor = Color.White; Taweel.TextColor = Color.FromHex("#FF071D66"); } }
        async void Twaiseh_Clicked(object sender, EventArgs e) { if (Twaiseh.BackgroundColor == Color.White) { Constantce.Area = "Twaiseh"; Constantce.AreaLang = Twaiseh.Text; Twaiseh.TextColor = Color.White; Twaiseh.BackgroundColor = Color.FromHex("#FF071D66"); var existingPages = Navigation.NavigationStack.ToList();Page page = existingPages.FirstOrDefault();Navigation.InsertPageBefore(new Home(), page);Navigation.RemovePage(page);await PopupNavigation.Instance.PopAsync(); } else { Constantce.Area = "Area"; Twaiseh.BackgroundColor = Color.White; Twaiseh.TextColor = Color.FromHex("#FF071D66"); } }
        async void BadouAbuKhushibeh_Clicked(object sender, EventArgs e) { if (BadouAbuKhushibeh.BackgroundColor == Color.White) { Constantce.Area = "Badou Abu Khushibeh"; Constantce.AreaLang = BadouAbuKhushibeh.Text; BadouAbuKhushibeh.TextColor = Color.White; BadouAbuKhushibeh.BackgroundColor = Color.FromHex("#FF071D66"); var existingPages = Navigation.NavigationStack.ToList();Page page = existingPages.FirstOrDefault();Navigation.InsertPageBefore(new Home(), page);Navigation.RemovePage(page);await PopupNavigation.Instance.PopAsync(); } else { Constantce.Area = "Area"; BadouAbuKhushibeh.BackgroundColor = Color.White; BadouAbuKhushibeh.TextColor = Color.FromHex("#FF071D66"); } }
        async void BeirMathkoor_Clicked(object sender, EventArgs e) { if (BeirMathkoor.BackgroundColor == Color.White) { Constantce.Area = "Beir Mathkoor"; Constantce.AreaLang = BeirMathkoor.Text; BeirMathkoor.TextColor = Color.White; BeirMathkoor.BackgroundColor = Color.FromHex("#FF071D66"); var existingPages = Navigation.NavigationStack.ToList();Page page = existingPages.FirstOrDefault();Navigation.InsertPageBefore(new Home(), page);Navigation.RemovePage(page);await PopupNavigation.Instance.PopAsync(); } else { Constantce.Area = "Area"; BeirMathkoor.BackgroundColor = Color.White; BeirMathkoor.TextColor = Color.FromHex("#FF071D66"); } }
        async void DabbetHanoot_Clicked(object sender, EventArgs e) { if (DabbetHanoot.BackgroundColor == Color.White) { Constantce.Area = "Dabbet Hanoot"; Constantce.AreaLang = DabbetHanoot.Text; DabbetHanoot.TextColor = Color.White; DabbetHanoot.BackgroundColor = Color.FromHex("#FF071D66"); var existingPages = Navigation.NavigationStack.ToList();Page page = existingPages.FirstOrDefault();Navigation.InsertPageBefore(new Home(), page);Navigation.RemovePage(page);await PopupNavigation.Instance.PopAsync(); } else { Constantce.Area = "Area"; DabbetHanoot.BackgroundColor = Color.White; DabbetHanoot.TextColor = Color.FromHex("#FF071D66"); } }
        async void Fienan_Clicked(object sender, EventArgs e) { if (Fienan.BackgroundColor == Color.White) { Constantce.Area = "Fienan"; Constantce.AreaLang = Fienan.Text; Fienan.TextColor = Color.White; Fienan.BackgroundColor = Color.FromHex("#FF071D66"); var existingPages = Navigation.NavigationStack.ToList();Page page = existingPages.FirstOrDefault();Navigation.InsertPageBefore(new Home(), page);Navigation.RemovePage(page);await PopupNavigation.Instance.PopAsync(); } else { Constantce.Area = "Area"; Fienan.BackgroundColor = Color.White; Fienan.TextColor = Color.FromHex("#FF071D66"); } }
        async void MujamaAlShahenat_Clicked(object sender, EventArgs e) { if (MujamaAlShahenat.BackgroundColor == Color.White) { Constantce.Area = "Mujam'a Al-Shahenat"; Constantce.AreaLang = MujamaAlShahenat.Text; MujamaAlShahenat.TextColor = Color.White; MujamaAlShahenat.BackgroundColor = Color.FromHex("#FF071D66"); var existingPages = Navigation.NavigationStack.ToList();Page page = existingPages.FirstOrDefault();Navigation.InsertPageBefore(new Home(), page);Navigation.RemovePage(page);await PopupNavigation.Instance.PopAsync(); } else { Constantce.Area = "Area"; MujamaAlShahenat.BackgroundColor = Color.White; MujamaAlShahenat.TextColor = Color.FromHex("#FF071D66"); } }
        async void Mnaishier_Clicked(object sender, EventArgs e) { if (Mnaishier.BackgroundColor == Color.White) { Constantce.Area = "Mnaishier"; Constantce.AreaLang = Mnaishier.Text; Mnaishier.TextColor = Color.White; Mnaishier.BackgroundColor = Color.FromHex("#FF071D66"); var existingPages = Navigation.NavigationStack.ToList();Page page = existingPages.FirstOrDefault();Navigation.InsertPageBefore(new Home(), page);Navigation.RemovePage(page);await PopupNavigation.Instance.PopAsync(); } else { Constantce.Area = "Area"; Mnaishier.BackgroundColor = Color.White; Mnaishier.TextColor = Color.FromHex("#FF071D66"); } }
        async void Qatar_Clicked(object sender, EventArgs e) { if (Qatar.BackgroundColor == Color.White) { Constantce.Area = "Qatar"; Constantce.AreaLang = Qatar.Text; Qatar.TextColor = Color.White; Qatar.BackgroundColor = Color.FromHex("#FF071D66"); var existingPages = Navigation.NavigationStack.ToList();Page page = existingPages.FirstOrDefault();Navigation.InsertPageBefore(new Home(), page);Navigation.RemovePage(page);await PopupNavigation.Instance.PopAsync(); } else { Constantce.Area = "Area"; Qatar.BackgroundColor = Color.White; Qatar.TextColor = Color.FromHex("#FF071D66"); } }
        async void Qraiqreh_Clicked(object sender, EventArgs e) { if (Qraiqreh.BackgroundColor == Color.White) { Constantce.Area = "Qraiqreh"; Constantce.AreaLang = Qraiqreh.Text; Qraiqreh.TextColor = Color.White; Qraiqreh.BackgroundColor = Color.FromHex("#FF071D66"); var existingPages = Navigation.NavigationStack.ToList();Page page = existingPages.FirstOrDefault();Navigation.InsertPageBefore(new Home(), page);Navigation.RemovePage(page);await PopupNavigation.Instance.PopAsync(); } else { Constantce.Area = "Area"; Qraiqreh.BackgroundColor = Color.White; Qraiqreh.TextColor = Color.FromHex("#FF071D66"); } }
        async void Rahmah_Clicked(object sender, EventArgs e) { if (Rahmah.BackgroundColor == Color.White) { Constantce.Area = "Rahmah"; Constantce.AreaLang = Rahmah.Text; Rahmah.TextColor = Color.White; Rahmah.BackgroundColor = Color.FromHex("#FF071D66"); var existingPages = Navigation.NavigationStack.ToList();Page page = existingPages.FirstOrDefault();Navigation.InsertPageBefore(new Home(), page);Navigation.RemovePage(page);await PopupNavigation.Instance.PopAsync(); } else { Constantce.Area = "Area"; Rahmah.BackgroundColor = Color.White; Rahmah.TextColor = Color.FromHex("#FF071D66"); } }
        async void Ramm_Clicked(object sender, EventArgs e) { if (Ramm.BackgroundColor == Color.White) { Constantce.Area = "Ramm"; Constantce.AreaLang = Ramm.Text; Ramm.TextColor = Color.White; Ramm.BackgroundColor = Color.FromHex("#FF071D66"); var existingPages = Navigation.NavigationStack.ToList();Page page = existingPages.FirstOrDefault();Navigation.InsertPageBefore(new Home(), page);Navigation.RemovePage(page);await PopupNavigation.Instance.PopAsync(); } else { Constantce.Area = "Area"; Ramm.BackgroundColor = Color.White; Ramm.TextColor = Color.FromHex("#FF071D66"); } }
        async void ReaSaadeh_Clicked(object sender, EventArgs e) { if (ReaSaadeh.BackgroundColor == Color.White) { Constantce.Area = "Re'a Sa'adeh"; Constantce.AreaLang = ReaSaadeh.Text; ReaSaadeh.TextColor = Color.White; ReaSaadeh.BackgroundColor = Color.FromHex("#FF071D66"); var existingPages = Navigation.NavigationStack.ToList();Page page = existingPages.FirstOrDefault();Navigation.InsertPageBefore(new Home(), page);Navigation.RemovePage(page);await PopupNavigation.Instance.PopAsync(); } else { Constantce.Area = "Area"; ReaSaadeh.BackgroundColor = Color.White; ReaSaadeh.TextColor = Color.FromHex("#FF071D66"); } }
        async void Tutun_Clicked(object sender, EventArgs e) { if (Tutun.BackgroundColor == Color.White) { Constantce.Area = "Tutun"; Constantce.AreaLang = Tutun.Text; Tutun.TextColor = Color.White; Tutun.BackgroundColor = Color.FromHex("#FF071D66"); var existingPages = Navigation.NavigationStack.ToList();Page page = existingPages.FirstOrDefault();Navigation.InsertPageBefore(new Home(), page);Navigation.RemovePage(page);await PopupNavigation.Instance.PopAsync(); } else { Constantce.Area = "Area"; Tutun.BackgroundColor = Color.White; Tutun.TextColor = Color.FromHex("#FF071D66"); } }
        async void UmmElBsateen_Clicked(object sender, EventArgs e) { if (UmmElBsateen.BackgroundColor == Color.White) { Constantce.Area = "Umm El - Bsateen"; Constantce.AreaLang = UmmElBsateen.Text; UmmElBsateen.TextColor = Color.White; UmmElBsateen.BackgroundColor = Color.FromHex("#FF071D66"); var existingPages = Navigation.NavigationStack.ToList();Page page = existingPages.FirstOrDefault();Navigation.InsertPageBefore(new Home(), page);Navigation.RemovePage(page);await PopupNavigation.Instance.PopAsync(); } else { Constantce.Area = "Area"; UmmElBsateen.BackgroundColor = Color.White; UmmElBsateen.TextColor = Color.FromHex("#FF071D66"); } }


    }
}