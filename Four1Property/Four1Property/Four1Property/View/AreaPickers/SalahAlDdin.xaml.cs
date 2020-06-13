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
	public partial class SalahAlDdin : PopupPage
    {
		public SalahAlDdin ()
		{
			InitializeComponent ();
            if (Application.Current.Properties["Language"].ToString() == "Arabic")
            {
                this.FlowDirection = FlowDirection.RightToLeft;
                UpText.Text = "الرجاء اختيار المنطقة";

                AlDaur.Text = "الدور";
                AlShirqat.Text = "الشرقات";
                Baiji.Text = "بيجي";
                Balad.Text = "بلد";
                Samarra.Text = "سامرة";
                Tikrit.Text = "تكريت";
                Tooz.Text = "توز";
                Dujail.Text = "دجايل";


            }
            else
            {
                this.FlowDirection = FlowDirection.LeftToRight;
                UpText.Text = "Please Select Area";

                AlDaur.Text = "Al - Daur";
                AlShirqat.Text = "Al - Shirqat";
                Baiji.Text = "Baiji ";
                Balad.Text = "Balad";
                Samarra.Text = "Samarra ";
                Tikrit.Text = "Tikrit ";
                Tooz.Text = "Tooz ";
                Dujail.Text = "Dujail ";

            }
            if (Constantce.Area == "Al - Daur"){ AlDaur.BackgroundColor = Color.FromHex("FF071D66"); AlDaur.TextColor = Color.White; }
           else if (Constantce.Area == "Al - Shirqat"){ AlShirqat.BackgroundColor = Color.FromHex("FF071D66"); AlShirqat.TextColor = Color.White; }
           else if (Constantce.Area == "Baiji "){ Baiji.BackgroundColor = Color.FromHex("FF071D66"); Baiji.TextColor = Color.White; }
           else if (Constantce.Area == "Balad"){ Balad.BackgroundColor = Color.FromHex("FF071D66"); Balad.TextColor = Color.White; }
           else if (Constantce.Area == "Samarra "){ Samarra.BackgroundColor = Color.FromHex("FF071D66"); Samarra.TextColor = Color.White; }
           else if (Constantce.Area == "Tikrit "){ Tikrit.BackgroundColor = Color.FromHex("FF071D66"); Tikrit.TextColor = Color.White; }
           else if (Constantce.Area == "Tooz "){ Tooz.BackgroundColor = Color.FromHex("FF071D66"); Tooz.TextColor = Color.White; }
           else if (Constantce.Area == "Dujail "){ Dujail.BackgroundColor = Color.FromHex("FF071D66"); Dujail.TextColor = Color.White; }

        }
        async void AlDaur_Clicked(object sender, EventArgs e) { if (AlDaur.BackgroundColor == Color.White) { Constantce.Area = "Al - Daur"; Constantce.AreaLang = AlDaur.Text; AlDaur.TextColor = Color.White; AlDaur.BackgroundColor = Color.FromHex("FF071D66"); var existingPages = Navigation.NavigationStack.ToList(); Page page = existingPages.FirstOrDefault(); Navigation.InsertPageBefore(new Home(), page); Navigation.RemovePage(page); await PopupNavigation.Instance.PopAsync(); } else {  Constantce.Area = "Area"; AlDaur.BackgroundColor = Color.White; AlDaur.TextColor = Color.FromHex("FF071D66"); } }
        async void AlShirqat_Clicked(object sender, EventArgs e) { if (AlShirqat.BackgroundColor == Color.White) { Constantce.Area = "Al - Shirqat"; Constantce.AreaLang = AlShirqat.Text; AlShirqat.TextColor = Color.White; AlShirqat.BackgroundColor = Color.FromHex("FF071D66"); var existingPages = Navigation.NavigationStack.ToList(); Page page = existingPages.FirstOrDefault(); Navigation.InsertPageBefore(new Home(), page); Navigation.RemovePage(page); await PopupNavigation.Instance.PopAsync(); } else {  Constantce.Area = "Area"; AlShirqat.BackgroundColor = Color.White; AlShirqat.TextColor = Color.FromHex("FF071D66"); } }
        async void Baiji_Clicked(object sender, EventArgs e) { if (Baiji.BackgroundColor == Color.White) { Constantce.Area = "Baiji "; Constantce.AreaLang = Baiji.Text; Baiji.TextColor = Color.White; Baiji.BackgroundColor = Color.FromHex("FF071D66"); var existingPages = Navigation.NavigationStack.ToList(); Page page = existingPages.FirstOrDefault(); Navigation.InsertPageBefore(new Home(), page); Navigation.RemovePage(page); await PopupNavigation.Instance.PopAsync(); } else {  Constantce.Area = "Area"; Baiji.BackgroundColor = Color.White; Baiji.TextColor = Color.FromHex("FF071D66"); } }
        async void Balad_Clicked(object sender, EventArgs e) { if (Balad.BackgroundColor == Color.White) { Constantce.Area = "Balad"; Constantce.AreaLang = Balad.Text; Balad.TextColor = Color.White; Balad.BackgroundColor = Color.FromHex("FF071D66"); var existingPages = Navigation.NavigationStack.ToList(); Page page = existingPages.FirstOrDefault(); Navigation.InsertPageBefore(new Home(), page); Navigation.RemovePage(page); await PopupNavigation.Instance.PopAsync(); } else {  Constantce.Area = "Area"; Balad.BackgroundColor = Color.White; Balad.TextColor = Color.FromHex("FF071D66"); } }
        async void Samarra_Clicked(object sender, EventArgs e) { if (Samarra.BackgroundColor == Color.White) { Constantce.Area = "Samarra "; Constantce.AreaLang = Samarra.Text; Samarra.TextColor = Color.White; Samarra.BackgroundColor = Color.FromHex("FF071D66"); var existingPages = Navigation.NavigationStack.ToList(); Page page = existingPages.FirstOrDefault(); Navigation.InsertPageBefore(new Home(), page); Navigation.RemovePage(page); await PopupNavigation.Instance.PopAsync(); } else {  Constantce.Area = "Area"; Samarra.BackgroundColor = Color.White; Samarra.TextColor = Color.FromHex("FF071D66"); } }
        async void Tikrit_Clicked(object sender, EventArgs e) { if (Tikrit.BackgroundColor == Color.White) { Constantce.Area = "Tikrit "; Constantce.AreaLang = Tikrit.Text; Tikrit.TextColor = Color.White; Tikrit.BackgroundColor = Color.FromHex("FF071D66"); var existingPages = Navigation.NavigationStack.ToList(); Page page = existingPages.FirstOrDefault(); Navigation.InsertPageBefore(new Home(), page); Navigation.RemovePage(page); await PopupNavigation.Instance.PopAsync(); } else {  Constantce.Area = "Area"; Tikrit.BackgroundColor = Color.White; Tikrit.TextColor = Color.FromHex("FF071D66"); } }
        async void Tooz_Clicked(object sender, EventArgs e) { if (Tooz.BackgroundColor == Color.White) { Constantce.Area = "Tooz "; Constantce.AreaLang = Tooz.Text; Tooz.TextColor = Color.White; Tooz.BackgroundColor = Color.FromHex("FF071D66"); var existingPages = Navigation.NavigationStack.ToList(); Page page = existingPages.FirstOrDefault(); Navigation.InsertPageBefore(new Home(), page); Navigation.RemovePage(page); await PopupNavigation.Instance.PopAsync(); } else {  Constantce.Area = "Area"; Tooz.BackgroundColor = Color.White; Tooz.TextColor = Color.FromHex("FF071D66"); } }
        async void Dujail_Clicked(object sender, EventArgs e) { if (Dujail.BackgroundColor == Color.White) { Constantce.Area = "Dujail "; Constantce.AreaLang = Dujail.Text; Dujail.TextColor = Color.White; Dujail.BackgroundColor = Color.FromHex("FF071D66"); var existingPages = Navigation.NavigationStack.ToList(); Page page = existingPages.FirstOrDefault(); Navigation.InsertPageBefore(new Home(), page); Navigation.RemovePage(page); await PopupNavigation.Instance.PopAsync(); } else {  Constantce.Area = "Area"; Dujail.BackgroundColor = Color.White; Dujail.TextColor = Color.FromHex("FF071D66"); } }

    }
}