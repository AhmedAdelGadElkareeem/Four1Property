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
    public partial class AlSulaymaniyah : PopupPage
    {
        public AlSulaymaniyah()
        {
            InitializeComponent();
            if (Application.Current.Properties["Language"].ToString() == "Arabic")
            {
                this.FlowDirection = FlowDirection.RightToLeft;
                UpText.Text = "الرجاء اختيار المنطقة";

                Pshdar.Text = "قلاديزة";
                Chamchamal.Text = "جمجمال";
                Darbandokeh.Text = "دربنديخان";
                Dokan.Text = "دكان";
                Kalar.Text = "كلار";
                Rania.Text = "رانيا";
                Sharbazher.Text = "شربزار";
                Sulaymaniya.Text = "سليمانية";
                Saidsadiq.Text = "سيدصديق";
                Sharazoor.Text = "زرايان";
                Penjwin.Text = "بنجوين";
                Mawat.Text = "موات";
                Qaradagh.Text = "قراداغ";


            }
            else
            {
                this.FlowDirection = FlowDirection.LeftToRight;
                UpText.Text = "Please Select Area";

                Pshdar.Text = "Pshdar ";
                Chamchamal.Text = "Chamchamal ";
                Darbandokeh.Text = "Darbandokeh ";
                Dokan.Text = "Dokan ";
                Kalar.Text = "Kalar";
                Rania.Text = "Rania ";
                Sharbazher.Text = "Sharbazher ";
                Sulaymaniya.Text = "Sulaymaniya";
                Saidsadiq.Text = "Saidsadiq";
                Sharazoor.Text = "Sharazoor";
                Penjwin.Text = "Penjwin";
                Mawat.Text = "Mawat ";
                Qaradagh.Text = "Qaradagh ";

            }
            if (Constantce.Area == "Pshdar ") { Pshdar.BackgroundColor = Color.FromHex("FF071D66"); Pshdar.TextColor = Color.White; }
            else if (Constantce.Area == "Chamchamal ") { Chamchamal.BackgroundColor = Color.FromHex("FF071D66"); Chamchamal.TextColor = Color.White; }
            else if (Constantce.Area == "Darbandokeh ") { Darbandokeh.BackgroundColor = Color.FromHex("FF071D66"); Darbandokeh.TextColor = Color.White; }
            else if (Constantce.Area == "Dokan ") { Dokan.BackgroundColor = Color.FromHex("FF071D66"); Dokan.TextColor = Color.White; }
            else if (Constantce.Area == "Kalar") { Kalar.BackgroundColor = Color.FromHex("FF071D66"); Kalar.TextColor = Color.White; }
            else if (Constantce.Area == "Rania ") { Rania.BackgroundColor = Color.FromHex("FF071D66"); Rania.TextColor = Color.White; }
            else if (Constantce.Area == "Sharbazher ") { Sharbazher.BackgroundColor = Color.FromHex("FF071D66"); Sharbazher.TextColor = Color.White; }
            else if (Constantce.Area == "Sulaymaniya") { Sulaymaniya.BackgroundColor = Color.FromHex("FF071D66"); Sulaymaniya.TextColor = Color.White; }
            else if (Constantce.Area == "Saidsadiq") { Saidsadiq.BackgroundColor = Color.FromHex("FF071D66"); Saidsadiq.TextColor = Color.White; }
            else if (Constantce.Area == "Sharazoor") { Sharazoor.BackgroundColor = Color.FromHex("FF071D66"); Sharazoor.TextColor = Color.White; }
            else if (Constantce.Area == "Penjwin") { Penjwin.BackgroundColor = Color.FromHex("FF071D66"); Penjwin.TextColor = Color.White; }
            else if (Constantce.Area == "Mawat ") { Mawat.BackgroundColor = Color.FromHex("FF071D66"); Mawat.TextColor = Color.White; }
            else if (Constantce.Area == "Qaradagh ") { Qaradagh.BackgroundColor = Color.FromHex("FF071D66"); Qaradagh.TextColor = Color.White; }

        }
        async void Pshdar_Clicked(object sender, EventArgs e) { if (Pshdar.BackgroundColor == Color.White) { Constantce.Area = "Pshdar "; Constantce.AreaLang = Pshdar.Text; Pshdar.TextColor = Color.White; Pshdar.BackgroundColor = Color.FromHex("FF071D66"); var existingPages = Navigation.NavigationStack.ToList(); Page page = existingPages.FirstOrDefault(); Navigation.InsertPageBefore(new Home(), page); Navigation.RemovePage(page); await PopupNavigation.Instance.PopAsync(); } else { Constantce.Area = "Area"; Pshdar.BackgroundColor = Color.White; Pshdar.TextColor = Color.FromHex("FF071D66"); } }
        async void Chamchamal_Clicked(object sender, EventArgs e) { if (Chamchamal.BackgroundColor == Color.White) { Constantce.Area = "Chamchamal "; Constantce.AreaLang = Chamchamal.Text; Chamchamal.TextColor = Color.White; Chamchamal.BackgroundColor = Color.FromHex("FF071D66"); var existingPages = Navigation.NavigationStack.ToList(); Page page = existingPages.FirstOrDefault(); Navigation.InsertPageBefore(new Home(), page); Navigation.RemovePage(page); await PopupNavigation.Instance.PopAsync(); } else { Constantce.Area = "Area"; Chamchamal.BackgroundColor = Color.White; Chamchamal.TextColor = Color.FromHex("FF071D66"); } }
        async void Darbandokeh_Clicked(object sender, EventArgs e) { if (Darbandokeh.BackgroundColor == Color.White) { Constantce.Area = "Darbandokeh "; Constantce.AreaLang = Darbandokeh.Text; Darbandokeh.TextColor = Color.White; Darbandokeh.BackgroundColor = Color.FromHex("FF071D66"); var existingPages = Navigation.NavigationStack.ToList(); Page page = existingPages.FirstOrDefault(); Navigation.InsertPageBefore(new Home(), page); Navigation.RemovePage(page); await PopupNavigation.Instance.PopAsync(); } else { Constantce.Area = "Area"; Darbandokeh.BackgroundColor = Color.White; Darbandokeh.TextColor = Color.FromHex("FF071D66"); } }
        async void Dokan_Clicked(object sender, EventArgs e) { if (Dokan.BackgroundColor == Color.White) { Constantce.Area = "Dokan "; Constantce.AreaLang = Dokan.Text; Dokan.TextColor = Color.White; Dokan.BackgroundColor = Color.FromHex("FF071D66"); var existingPages = Navigation.NavigationStack.ToList(); Page page = existingPages.FirstOrDefault(); Navigation.InsertPageBefore(new Home(), page); Navigation.RemovePage(page); await PopupNavigation.Instance.PopAsync(); } else { Constantce.Area = "Area"; Dokan.BackgroundColor = Color.White; Dokan.TextColor = Color.FromHex("FF071D66"); } }
        async void Kalar_Clicked(object sender, EventArgs e) { if (Kalar.BackgroundColor == Color.White) { Constantce.Area = "Kalar"; Constantce.AreaLang = Kalar.Text; Kalar.TextColor = Color.White; Kalar.BackgroundColor = Color.FromHex("FF071D66"); var existingPages = Navigation.NavigationStack.ToList(); Page page = existingPages.FirstOrDefault(); Navigation.InsertPageBefore(new Home(), page); Navigation.RemovePage(page); await PopupNavigation.Instance.PopAsync(); } else { Constantce.Area = "Area"; Kalar.BackgroundColor = Color.White; Kalar.TextColor = Color.FromHex("FF071D66"); } }
        async void Rania_Clicked(object sender, EventArgs e) { if (Rania.BackgroundColor == Color.White) { Constantce.Area = "Rania "; Constantce.AreaLang = Rania.Text; Rania.TextColor = Color.White; Rania.BackgroundColor = Color.FromHex("FF071D66"); var existingPages = Navigation.NavigationStack.ToList(); Page page = existingPages.FirstOrDefault(); Navigation.InsertPageBefore(new Home(), page); Navigation.RemovePage(page); await PopupNavigation.Instance.PopAsync(); } else { Constantce.Area = "Area"; Rania.BackgroundColor = Color.White; Rania.TextColor = Color.FromHex("FF071D66"); } }
        async void Sharbazher_Clicked(object sender, EventArgs e) { if (Sharbazher.BackgroundColor == Color.White) { Constantce.Area = "Sharbazher "; Constantce.AreaLang = Sharbazher.Text; Sharbazher.TextColor = Color.White; Sharbazher.BackgroundColor = Color.FromHex("FF071D66"); var existingPages = Navigation.NavigationStack.ToList(); Page page = existingPages.FirstOrDefault(); Navigation.InsertPageBefore(new Home(), page); Navigation.RemovePage(page); await PopupNavigation.Instance.PopAsync(); } else { Constantce.Area = "Area"; Sharbazher.BackgroundColor = Color.White; Sharbazher.TextColor = Color.FromHex("FF071D66"); } }
        async void Sulaymaniya_Clicked(object sender, EventArgs e) { if (Sulaymaniya.BackgroundColor == Color.White) { Constantce.Area = "Sulaymaniya"; Constantce.AreaLang = Sulaymaniya.Text; Sulaymaniya.TextColor = Color.White; Sulaymaniya.BackgroundColor = Color.FromHex("FF071D66"); var existingPages = Navigation.NavigationStack.ToList(); Page page = existingPages.FirstOrDefault(); Navigation.InsertPageBefore(new Home(), page); Navigation.RemovePage(page); await PopupNavigation.Instance.PopAsync(); } else { Constantce.Area = "Area"; Sulaymaniya.BackgroundColor = Color.White; Sulaymaniya.TextColor = Color.FromHex("FF071D66"); } }
        async void Saidsadiq_Clicked(object sender, EventArgs e) { if (Saidsadiq.BackgroundColor == Color.White) { Constantce.Area = "Saidsadiq"; Constantce.AreaLang = Saidsadiq.Text; Saidsadiq.TextColor = Color.White; Saidsadiq.BackgroundColor = Color.FromHex("FF071D66"); var existingPages = Navigation.NavigationStack.ToList(); Page page = existingPages.FirstOrDefault(); Navigation.InsertPageBefore(new Home(), page); Navigation.RemovePage(page); await PopupNavigation.Instance.PopAsync(); } else { Constantce.Area = "Area"; Saidsadiq.BackgroundColor = Color.White; Saidsadiq.TextColor = Color.FromHex("FF071D66"); } }
        async void Sharazoor_Clicked(object sender, EventArgs e) { if (Sharazoor.BackgroundColor == Color.White) { Constantce.Area = "Sharazoor"; Constantce.AreaLang = Sharazoor.Text; Sharazoor.TextColor = Color.White; Sharazoor.BackgroundColor = Color.FromHex("FF071D66"); var existingPages = Navigation.NavigationStack.ToList(); Page page = existingPages.FirstOrDefault(); Navigation.InsertPageBefore(new Home(), page); Navigation.RemovePage(page); await PopupNavigation.Instance.PopAsync(); } else { Constantce.Area = "Area"; Sharazoor.BackgroundColor = Color.White; Sharazoor.TextColor = Color.FromHex("FF071D66"); } }
        async void Penjwin_Clicked(object sender, EventArgs e) { if (Penjwin.BackgroundColor == Color.White) { Constantce.Area = "Penjwin"; Constantce.AreaLang = Penjwin.Text; Penjwin.TextColor = Color.White; Penjwin.BackgroundColor = Color.FromHex("FF071D66"); var existingPages = Navigation.NavigationStack.ToList(); Page page = existingPages.FirstOrDefault(); Navigation.InsertPageBefore(new Home(), page); Navigation.RemovePage(page); await PopupNavigation.Instance.PopAsync(); } else { Constantce.Area = "Area"; Penjwin.BackgroundColor = Color.White; Penjwin.TextColor = Color.FromHex("FF071D66"); } }
        async void Mawat_Clicked(object sender, EventArgs e) { if (Mawat.BackgroundColor == Color.White) { Constantce.Area = "Mawat "; Constantce.AreaLang = Mawat.Text; Mawat.TextColor = Color.White; Mawat.BackgroundColor = Color.FromHex("FF071D66"); var existingPages = Navigation.NavigationStack.ToList(); Page page = existingPages.FirstOrDefault(); Navigation.InsertPageBefore(new Home(), page); Navigation.RemovePage(page); await PopupNavigation.Instance.PopAsync(); } else { Constantce.Area = "Area"; Mawat.BackgroundColor = Color.White; Mawat.TextColor = Color.FromHex("FF071D66"); } }
        async void Qaradagh_Clicked(object sender, EventArgs e) { if (Qaradagh.BackgroundColor == Color.White) { Constantce.Area = "Qaradagh "; Constantce.AreaLang = Qaradagh.Text; Qaradagh.TextColor = Color.White; Qaradagh.BackgroundColor = Color.FromHex("FF071D66"); var existingPages = Navigation.NavigationStack.ToList(); Page page = existingPages.FirstOrDefault(); Navigation.InsertPageBefore(new Home(), page); Navigation.RemovePage(page); await PopupNavigation.Instance.PopAsync(); } else { Constantce.Area = "Area"; Qaradagh.BackgroundColor = Color.White; Qaradagh.TextColor = Color.FromHex("FF071D66"); } }

    }
}