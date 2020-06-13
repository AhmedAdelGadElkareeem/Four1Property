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
    public partial class AlTamin : PopupPage
    {
        public AlTamin()
        {
            InitializeComponent();
            if (Application.Current.Properties["Language"].ToString() == "Arabic")
            {
                this.FlowDirection = FlowDirection.RightToLeft;
                UpText.Text = "الرجاء اختيار المنطقة";

                AlHawiga.Text = "الحويجة";
                Daquq.Text = "داقوق";
                Kirkuk.Text = "كركوك";
                AlDibs.Text = "الدبس";

            }
            else
            {
                this.FlowDirection = FlowDirection.LeftToRight;
                UpText.Text = "Please Select Area";

                AlHawiga.Text = "Al - Hawiga";
                Daquq.Text = "Daquq";
                Kirkuk.Text = "Kirkuk ";
                AlDibs.Text = "Al - Dibs";

            }
            if (Constantce.Area == "Al - Hawiga") { AlHawiga.BackgroundColor = Color.FromHex("FF071D66"); AlHawiga.TextColor = Color.White; }
            else if (Constantce.Area == "Daquq") { Daquq.BackgroundColor = Color.FromHex("FF071D66"); Daquq.TextColor = Color.White; }
            else if (Constantce.Area == "Kirkuk ") { Kirkuk.BackgroundColor = Color.FromHex("FF071D66"); Kirkuk.TextColor = Color.White; }
            else if (Constantce.Area == "Al - Dibs") { AlDibs.BackgroundColor = Color.FromHex("FF071D66"); AlDibs.TextColor = Color.White; }

        }
        async void AlHawiga_Clicked(object sender, EventArgs e) { if (AlHawiga.BackgroundColor == Color.White) { Constantce.Area = "Al - Hawiga"; Constantce.AreaLang = AlHawiga.Text; AlHawiga.TextColor = Color.White; AlHawiga.BackgroundColor = Color.FromHex("FF071D66"); var existingPages = Navigation.NavigationStack.ToList(); Page page = existingPages.FirstOrDefault(); Navigation.InsertPageBefore(new Home(), page); Navigation.RemovePage(page); await PopupNavigation.Instance.PopAsync(); } else { Constantce.Area = "Area"; AlHawiga.BackgroundColor = Color.White; AlHawiga.TextColor = Color.FromHex("FF071D66"); } }
        async void Daquq_Clicked(object sender, EventArgs e) { if (Daquq.BackgroundColor == Color.White) { Constantce.Area = "Daquq"; Constantce.AreaLang = Daquq.Text; Daquq.TextColor = Color.White; Daquq.BackgroundColor = Color.FromHex("FF071D66"); var existingPages = Navigation.NavigationStack.ToList(); Page page = existingPages.FirstOrDefault(); Navigation.InsertPageBefore(new Home(), page); Navigation.RemovePage(page); await PopupNavigation.Instance.PopAsync(); } else { Constantce.Area = "Area"; Daquq.BackgroundColor = Color.White; Daquq.TextColor = Color.FromHex("FF071D66"); } }
        async void Kirkuk_Clicked(object sender, EventArgs e) { if (Kirkuk.BackgroundColor == Color.White) { Constantce.Area = "Kirkuk "; Constantce.AreaLang = Kirkuk.Text; Kirkuk.TextColor = Color.White; Kirkuk.BackgroundColor = Color.FromHex("FF071D66"); var existingPages = Navigation.NavigationStack.ToList(); Page page = existingPages.FirstOrDefault(); Navigation.InsertPageBefore(new Home(), page); Navigation.RemovePage(page); await PopupNavigation.Instance.PopAsync(); } else { Constantce.Area = "Area"; Kirkuk.BackgroundColor = Color.White; Kirkuk.TextColor = Color.FromHex("FF071D66"); } }
        async void AlDibs_Clicked(object sender, EventArgs e) { if (AlDibs.BackgroundColor == Color.White) { Constantce.Area = "Al - Dibs"; Constantce.AreaLang = AlDibs.Text; AlDibs.TextColor = Color.White; AlDibs.BackgroundColor = Color.FromHex("FF071D66"); var existingPages = Navigation.NavigationStack.ToList(); Page page = existingPages.FirstOrDefault(); Navigation.InsertPageBefore(new Home(), page); Navigation.RemovePage(page); await PopupNavigation.Instance.PopAsync(); } else { Constantce.Area = "Area"; AlDibs.BackgroundColor = Color.White; AlDibs.TextColor = Color.FromHex("FF071D66"); } }

    }
}