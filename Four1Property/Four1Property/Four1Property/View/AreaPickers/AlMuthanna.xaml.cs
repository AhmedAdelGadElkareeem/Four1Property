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
    public partial class AlMuthanna : PopupPage
    {
        public AlMuthanna()
        {
            InitializeComponent();
            if (Application.Current.Properties["Language"].ToString() == "Arabic")
            {
                this.FlowDirection = FlowDirection.RightToLeft;
                AlKhidhir.Text = "الخضير";
                UpText.Text = "الرجاء اختيار المنطقة";

                AlRumaitha.Text = "الرميثة";
                AlSalman.Text = "السلمان";
                AlSamawa.Text = "سماوة";

            }
            else
            {
                this.FlowDirection = FlowDirection.LeftToRight;
                UpText.Text = "Please Select Area";

                AlKhidhir.Text = "Al - Khidhir ";
                AlRumaitha.Text = "Al - Rumaitha";
                AlSalman.Text = "Al - Salman";
                AlSamawa.Text = "Al - Samawa";

            }
            if (Constantce.Area == "Al - Khidhir ") { AlKhidhir.BackgroundColor = Color.FromHex("FF071D66"); AlKhidhir.TextColor = Color.White; }
            else if (Constantce.Area == "Al - Rumaitha") { AlRumaitha.BackgroundColor = Color.FromHex("FF071D66"); AlRumaitha.TextColor = Color.White; }
            else if (Constantce.Area == "Al - Salman") { AlSalman.BackgroundColor = Color.FromHex("FF071D66"); AlSalman.TextColor = Color.White; }
            else if (Constantce.Area == "Al - Samawa") { AlSamawa.BackgroundColor = Color.FromHex("FF071D66"); AlSamawa.TextColor = Color.White; }

        }
        async void AlKhidhir_Clicked(object sender, EventArgs e) { if (AlKhidhir.BackgroundColor == Color.White) { Constantce.Area = "Al - Khidhir "; Constantce.AreaLang = AlKhidhir.Text; AlKhidhir.TextColor = Color.White; AlKhidhir.BackgroundColor = Color.FromHex("FF071D66"); var existingPages = Navigation.NavigationStack.ToList(); Page page = existingPages.FirstOrDefault(); Navigation.InsertPageBefore(new Home(), page); Navigation.RemovePage(page); await PopupNavigation.Instance.PopAsync(); } else { Constantce.Area = "Area"; AlKhidhir.BackgroundColor = Color.White; AlKhidhir.TextColor = Color.FromHex("FF071D66"); } }
        async void AlRumaitha_Clicked(object sender, EventArgs e) { if (AlRumaitha.BackgroundColor == Color.White) { Constantce.Area = "Al - Rumaitha"; Constantce.AreaLang = AlRumaitha.Text; AlRumaitha.TextColor = Color.White; AlRumaitha.BackgroundColor = Color.FromHex("FF071D66"); var existingPages = Navigation.NavigationStack.ToList(); Page page = existingPages.FirstOrDefault(); Navigation.InsertPageBefore(new Home(), page); Navigation.RemovePage(page); await PopupNavigation.Instance.PopAsync(); } else { Constantce.Area = "Area"; AlRumaitha.BackgroundColor = Color.White; AlRumaitha.TextColor = Color.FromHex("FF071D66"); } }
        async void AlSalman_Clicked(object sender, EventArgs e) { if (AlSalman.BackgroundColor == Color.White) { Constantce.Area = "Al - Salman"; Constantce.AreaLang = AlSalman.Text; AlSalman.TextColor = Color.White; AlSalman.BackgroundColor = Color.FromHex("FF071D66"); var existingPages = Navigation.NavigationStack.ToList(); Page page = existingPages.FirstOrDefault(); Navigation.InsertPageBefore(new Home(), page); Navigation.RemovePage(page); await PopupNavigation.Instance.PopAsync(); } else { Constantce.Area = "Area"; AlSalman.BackgroundColor = Color.White; AlSalman.TextColor = Color.FromHex("FF071D66"); } }
        async void AlSamawa_Clicked(object sender, EventArgs e) { if (AlSamawa.BackgroundColor == Color.White) { Constantce.Area = "Al - Samawa"; Constantce.AreaLang = AlSamawa.Text; AlSamawa.TextColor = Color.White; AlSamawa.BackgroundColor = Color.FromHex("FF071D66"); var existingPages = Navigation.NavigationStack.ToList(); Page page = existingPages.FirstOrDefault(); Navigation.InsertPageBefore(new Home(), page); Navigation.RemovePage(page); await PopupNavigation.Instance.PopAsync(); } else { Constantce.Area = "Area"; AlSamawa.BackgroundColor = Color.White; AlSamawa.TextColor = Color.FromHex("FF071D66"); } }

    }
}