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
    public partial class Wasit : PopupPage
    {
        public Wasit()
        {
            InitializeComponent();
            if (Application.Current.Properties["Language"].ToString() == "Arabic")
            {
                this.FlowDirection = FlowDirection.RightToLeft;
                UpText.Text = "الرجاء اختيار المنطقة";

                AlHai.Text = "الحاي";
                AlNamaniya.Text = "النعيمانية";
                AlSuwaira.Text = "السويرة";
                Badra.Text = "بدرة";
                Kut.Text = "كوت";

            }
            else
            {
                this.FlowDirection = FlowDirection.LeftToRight;
                UpText.Text = "Please Select Area";

                AlHai.Text = "Al - Hai";
                AlNamaniya.Text = "Al - Na'maniya ";
                AlSuwaira.Text = "Al - Suwaira ";
                Badra.Text = "Badra ";
                Kut.Text = "Kut ";

            }
            if (Constantce.Area == "Al - Hai") { AlHai.BackgroundColor = Color.FromHex("FF071D66"); AlHai.TextColor = Color.White; }
            else if (Constantce.Area == "Al - Na'maniya ") { AlNamaniya.BackgroundColor = Color.FromHex("FF071D66"); AlNamaniya.TextColor = Color.White; }
            else if (Constantce.Area == "Al - Suwaira ") { AlSuwaira.BackgroundColor = Color.FromHex("FF071D66"); AlSuwaira.TextColor = Color.White; }
            else if (Constantce.Area == "Badra ") { Badra.BackgroundColor = Color.FromHex("FF071D66"); Badra.TextColor = Color.White; }
            else if (Constantce.Area == "Kut ") { Kut.BackgroundColor = Color.FromHex("FF071D66"); Kut.TextColor = Color.White; }

        }
        async void AlHai_Clicked(object sender, EventArgs e) { if (AlHai.BackgroundColor == Color.White) { Constantce.Area = "Al - Hai"; Constantce.AreaLang = AlHai.Text; AlHai.TextColor = Color.White; AlHai.BackgroundColor = Color.FromHex("FF071D66"); var existingPages = Navigation.NavigationStack.ToList(); Page page = existingPages.FirstOrDefault(); Navigation.InsertPageBefore(new Home(), page); Navigation.RemovePage(page); await PopupNavigation.Instance.PopAsync(); } else { Constantce.Area = "Area"; AlHai.BackgroundColor = Color.White; AlHai.TextColor = Color.FromHex("FF071D66"); } }
        async void AlNamaniya_Clicked(object sender, EventArgs e) { if (AlNamaniya.BackgroundColor == Color.White) { Constantce.Area = "Al - Na'maniya "; Constantce.AreaLang = AlNamaniya.Text; AlNamaniya.TextColor = Color.White; AlNamaniya.BackgroundColor = Color.FromHex("FF071D66"); var existingPages = Navigation.NavigationStack.ToList(); Page page = existingPages.FirstOrDefault(); Navigation.InsertPageBefore(new Home(), page); Navigation.RemovePage(page); await PopupNavigation.Instance.PopAsync(); } else { Constantce.Area = "Area"; AlNamaniya.BackgroundColor = Color.White; AlNamaniya.TextColor = Color.FromHex("FF071D66"); } }
        async void AlSuwaira_Clicked(object sender, EventArgs e) { if (AlSuwaira.BackgroundColor == Color.White) { Constantce.Area = "Al - Suwaira "; Constantce.AreaLang = AlSuwaira.Text; AlSuwaira.TextColor = Color.White; AlSuwaira.BackgroundColor = Color.FromHex("FF071D66"); var existingPages = Navigation.NavigationStack.ToList(); Page page = existingPages.FirstOrDefault(); Navigation.InsertPageBefore(new Home(), page); Navigation.RemovePage(page); await PopupNavigation.Instance.PopAsync(); } else { Constantce.Area = "Area"; AlSuwaira.BackgroundColor = Color.White; AlSuwaira.TextColor = Color.FromHex("FF071D66"); } }
        async void Badra_Clicked(object sender, EventArgs e) { if (Badra.BackgroundColor == Color.White) { Constantce.Area = "Badra "; Constantce.AreaLang = Badra.Text; Badra.TextColor = Color.White; Badra.BackgroundColor = Color.FromHex("FF071D66"); var existingPages = Navigation.NavigationStack.ToList(); Page page = existingPages.FirstOrDefault(); Navigation.InsertPageBefore(new Home(), page); Navigation.RemovePage(page); await PopupNavigation.Instance.PopAsync(); } else { Constantce.Area = "Area"; Badra.BackgroundColor = Color.White; Badra.TextColor = Color.FromHex("FF071D66"); } }
        async void Kut_Clicked(object sender, EventArgs e) { if (Kut.BackgroundColor == Color.White) { Constantce.Area = "Kut "; Constantce.AreaLang = Kut.Text; Kut.TextColor = Color.White; Kut.BackgroundColor = Color.FromHex("FF071D66"); var existingPages = Navigation.NavigationStack.ToList(); Page page = existingPages.FirstOrDefault(); Navigation.InsertPageBefore(new Home(), page); Navigation.RemovePage(page); await PopupNavigation.Instance.PopAsync(); } else { Constantce.Area = "Area"; Kut.BackgroundColor = Color.White; Kut.TextColor = Color.FromHex("FF071D66"); } }

    }
}