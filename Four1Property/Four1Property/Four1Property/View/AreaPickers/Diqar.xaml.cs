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
    public partial class Diqar : PopupPage
    {
        public Diqar()
        {
            InitializeComponent();
            if (Application.Current.Properties["Language"].ToString() == "Arabic")
            {
                this.FlowDirection = FlowDirection.RightToLeft;
                UpText.Text = "الرجاء اختيار المنطقة";

                AlChibayish.Text = "الجبايش";
                AlRifai.Text = "الرفاعي";
                AlShatra.Text = "الشطارة";
                Nassriya.Text = "ناصرية";
                SuqAlShoyokh.Text = "سوق الشيوخ";


            }
            else
            {
                this.FlowDirection = FlowDirection.LeftToRight;
                AlChibayish.Text = "Al - Chibayish ";
                UpText.Text = "Please Select Area";

                AlRifai.Text = "Al - Rifa'i";
                AlShatra.Text = "Al - Shatra";
                Nassriya.Text = "Nassriya";
                SuqAlShoyokh.Text = "Suq Al - Shoyokh";

            }
            if (Constantce.Area == "Al - Chibayish ") { AlChibayish.BackgroundColor = Color.FromHex("FF071D66"); AlChibayish.TextColor = Color.White; }
            else if (Constantce.Area == "Al - Rifa'i") { AlRifai.BackgroundColor = Color.FromHex("FF071D66"); AlRifai.TextColor = Color.White; }
            else if (Constantce.Area == "Al - Shatra") { AlShatra.BackgroundColor = Color.FromHex("FF071D66"); AlShatra.TextColor = Color.White; }
            else if (Constantce.Area == "Nassriya") { Nassriya.BackgroundColor = Color.FromHex("FF071D66"); Nassriya.TextColor = Color.White; }
            else if (Constantce.Area == "Suq Al - Shoyokh") { SuqAlShoyokh.BackgroundColor = Color.FromHex("FF071D66"); SuqAlShoyokh.TextColor = Color.White; }

        }
        async void AlChibayish_Clicked(object sender, EventArgs e) { if (AlChibayish.BackgroundColor == Color.White) { Constantce.Area = "Al - Chibayish "; Constantce.AreaLang = AlChibayish.Text; AlChibayish.TextColor = Color.White; AlChibayish.BackgroundColor = Color.FromHex("FF071D66"); var existingPages = Navigation.NavigationStack.ToList(); Page page = existingPages.FirstOrDefault(); Navigation.InsertPageBefore(new Home(), page); Navigation.RemovePage(page); await PopupNavigation.Instance.PopAsync(); } else { Constantce.Area = "Area"; AlChibayish.BackgroundColor = Color.White; AlChibayish.TextColor = Color.FromHex("FF071D66"); } }
        async void AlRifai_Clicked(object sender, EventArgs e) { if (AlRifai.BackgroundColor == Color.White) { Constantce.Area = "Al - Rifa'i"; Constantce.AreaLang = AlRifai.Text; AlRifai.TextColor = Color.White; AlRifai.BackgroundColor = Color.FromHex("FF071D66"); var existingPages = Navigation.NavigationStack.ToList(); Page page = existingPages.FirstOrDefault(); Navigation.InsertPageBefore(new Home(), page); Navigation.RemovePage(page); await PopupNavigation.Instance.PopAsync(); } else { Constantce.City = "City"; Constantce.Area = "Area"; AlRifai.BackgroundColor = Color.White; AlRifai.TextColor = Color.FromHex("FF071D66"); } }
        async void AlShatra_Clicked(object sender, EventArgs e) { if (AlShatra.BackgroundColor == Color.White) { Constantce.Area = "Al - Shatra"; Constantce.AreaLang = AlShatra.Text; AlShatra.TextColor = Color.White; AlShatra.BackgroundColor = Color.FromHex("FF071D66"); var existingPages = Navigation.NavigationStack.ToList(); Page page = existingPages.FirstOrDefault(); Navigation.InsertPageBefore(new Home(), page); Navigation.RemovePage(page); await PopupNavigation.Instance.PopAsync(); } else { Constantce.Area = "Area"; AlShatra.BackgroundColor = Color.White; AlShatra.TextColor = Color.FromHex("FF071D66"); } }
        async void Nassriya_Clicked(object sender, EventArgs e) { if (Nassriya.BackgroundColor == Color.White) { Constantce.Area = "Nassriya"; Constantce.AreaLang = Nassriya.Text; Nassriya.TextColor = Color.White; Nassriya.BackgroundColor = Color.FromHex("FF071D66"); var existingPages = Navigation.NavigationStack.ToList(); Page page = existingPages.FirstOrDefault(); Navigation.InsertPageBefore(new Home(), page); Navigation.RemovePage(page); await PopupNavigation.Instance.PopAsync(); } else { Constantce.Area = "Area"; Nassriya.BackgroundColor = Color.White; Nassriya.TextColor = Color.FromHex("FF071D66"); } }
        async void SuqAlShoyokh_Clicked(object sender, EventArgs e) { if (SuqAlShoyokh.BackgroundColor == Color.White) { Constantce.Area = "Suq Al - Shoyokh"; Constantce.AreaLang = SuqAlShoyokh.Text; SuqAlShoyokh.TextColor = Color.White; SuqAlShoyokh.BackgroundColor = Color.FromHex("FF071D66"); var existingPages = Navigation.NavigationStack.ToList(); Page page = existingPages.FirstOrDefault(); Navigation.InsertPageBefore(new Home(), page); Navigation.RemovePage(page); await PopupNavigation.Instance.PopAsync(); } else { Constantce.Area = "Area"; SuqAlShoyokh.BackgroundColor = Color.White; SuqAlShoyokh.TextColor = Color.FromHex("FF071D66"); } }

    }
}