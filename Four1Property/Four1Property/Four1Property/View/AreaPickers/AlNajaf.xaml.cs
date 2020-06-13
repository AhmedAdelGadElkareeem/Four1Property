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
	public partial class AlNajaf : PopupPage
    {
		public AlNajaf ()
		{
			InitializeComponent ();
            if (Application.Current.Properties["Language"].ToString() == "Arabic")
            {
                this.FlowDirection = FlowDirection.RightToLeft;
                UpText.Text = "الرجاء اختيار المنطقة";

                AlManathera.Text = "المناذرة";
                Kufa.Text = "الكوفة";
                Najaf.Text = "نجف";

            }
            else
            {
                this.FlowDirection = FlowDirection.LeftToRight;
                UpText.Text = "Please Select Area";

                AlManathera.Text = "Al - Manathera";
                Kufa.Text = "Kufa";
                Najaf.Text = "Najaf ";


            }
            if (Constantce.Area == "Al - Manathera"){ AlManathera.BackgroundColor = Color.FromHex("FF071D66"); AlManathera.TextColor = Color.White; }
            else if (Constantce.Area == "Kufa"){ Kufa.BackgroundColor = Color.FromHex("FF071D66"); Kufa.TextColor = Color.White; }
            else if (Constantce.Area == "Najaf "){ Najaf.BackgroundColor = Color.FromHex("FF071D66"); Najaf.TextColor = Color.White; }

        }
        async void AlManathera_Clicked(object sender, EventArgs e) { if (AlManathera.BackgroundColor == Color.White) { Constantce.Area = "Al - Manathera"; Constantce.AreaLang = AlManathera.Text; AlManathera.TextColor = Color.White; AlManathera.BackgroundColor = Color.FromHex("FF071D66"); var existingPages = Navigation.NavigationStack.ToList(); Page page = existingPages.FirstOrDefault(); Navigation.InsertPageBefore(new Home(), page); Navigation.RemovePage(page); await PopupNavigation.Instance.PopAsync(); } else {  Constantce.Area = "Area"; AlManathera.BackgroundColor = Color.White; AlManathera.TextColor = Color.FromHex("FF071D66"); } }
        async void Kufa_Clicked(object sender, EventArgs e) { if (Kufa.BackgroundColor == Color.White) { Constantce.Area = "Kufa"; Constantce.AreaLang = Kufa.Text; Kufa.TextColor = Color.White; Kufa.BackgroundColor = Color.FromHex("FF071D66"); var existingPages = Navigation.NavigationStack.ToList(); Page page = existingPages.FirstOrDefault(); Navigation.InsertPageBefore(new Home(), page); Navigation.RemovePage(page); await PopupNavigation.Instance.PopAsync(); } else {  Constantce.Area = "Area"; Kufa.BackgroundColor = Color.White; Kufa.TextColor = Color.FromHex("FF071D66"); } }
        async void Najaf_Clicked(object sender, EventArgs e) { if (Najaf.BackgroundColor == Color.White) { Constantce.Area = "Najaf "; Constantce.AreaLang = Najaf.Text; Najaf.TextColor = Color.White; Najaf.BackgroundColor = Color.FromHex("FF071D66"); var existingPages = Navigation.NavigationStack.ToList(); Page page = existingPages.FirstOrDefault(); Navigation.InsertPageBefore(new Home(), page); Navigation.RemovePage(page); await PopupNavigation.Instance.PopAsync(); } else {  Constantce.Area = "Area"; Najaf.BackgroundColor = Color.White; Najaf.TextColor = Color.FromHex("FF071D66"); } }

    }
}