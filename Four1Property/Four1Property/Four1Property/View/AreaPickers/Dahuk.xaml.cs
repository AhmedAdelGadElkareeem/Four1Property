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
	public partial class Dahuk : PopupPage
    {
		public Dahuk ()
		{
			InitializeComponent ();
            if (Application.Current.Properties["Language"].ToString() == "Arabic")
            {
                this.FlowDirection = FlowDirection.RightToLeft;
                UpText.Text = "الرجاء اختيار المنطقة";

                Amadiya.Text = "عمادية";
                DahukBTN.Text = "دهوك";
                Sumel.Text = "سومل";
                Zakho.Text = "زاخو";

            }
            else
            {
                this.FlowDirection = FlowDirection.LeftToRight;
                Amadiya.Text = "Amadiya ";
                UpText.Text = "Please Select Area";

                DahukBTN.Text = "Dahuk";
                Sumel.Text = "Sumel ";
                Zakho.Text = "Zakho ";
            }
            if (Constantce.Area == "Amadiya "){ Amadiya.BackgroundColor = Color.FromHex("FF071D66"); Amadiya.TextColor = Color.White; }
           else if (Constantce.Area == "Dahuk"){ DahukBTN.BackgroundColor = Color.FromHex("FF071D66"); DahukBTN.TextColor = Color.White; }
           else if (Constantce.Area == "Sumel "){ Sumel.BackgroundColor = Color.FromHex("FF071D66"); Sumel.TextColor = Color.White; }
           else if (Constantce.Area == "Zakho "){ Zakho.BackgroundColor = Color.FromHex("FF071D66"); Zakho.TextColor = Color.White; }

        }
        async void Amadiya_Clicked(object sender, EventArgs e) { if (Amadiya.BackgroundColor == Color.White) { Constantce.Area = "Amadiya "; Constantce.AreaLang = Amadiya.Text; Amadiya.TextColor = Color.White; Amadiya.BackgroundColor = Color.FromHex("FF071D66"); var existingPages = Navigation.NavigationStack.ToList(); Page page = existingPages.FirstOrDefault(); Navigation.InsertPageBefore(new Home(), page); Navigation.RemovePage(page); await PopupNavigation.Instance.PopAsync(); } else {  Constantce.Area = "Area"; Amadiya.BackgroundColor = Color.White; Amadiya.TextColor = Color.FromHex("FF071D66"); } }
        async void DahukBTN_Clicked(object sender, EventArgs e) { if (DahukBTN.BackgroundColor == Color.White) { Constantce.Area = "Dahuk"; Constantce.AreaLang = DahukBTN.Text; DahukBTN.TextColor = Color.White; DahukBTN.BackgroundColor = Color.FromHex("FF071D66"); var existingPages = Navigation.NavigationStack.ToList(); Page page = existingPages.FirstOrDefault(); Navigation.InsertPageBefore(new Home(), page); Navigation.RemovePage(page); await PopupNavigation.Instance.PopAsync(); } else {  Constantce.Area = "Area"; DahukBTN.BackgroundColor = Color.White; DahukBTN.TextColor = Color.FromHex("FF071D66"); } }
        async void Sumel_Clicked(object sender, EventArgs e) { if (Sumel.BackgroundColor == Color.White) { Constantce.Area = "Sumel "; Constantce.AreaLang = Sumel.Text; Sumel.TextColor = Color.White; Sumel.BackgroundColor = Color.FromHex("FF071D66"); var existingPages = Navigation.NavigationStack.ToList(); Page page = existingPages.FirstOrDefault(); Navigation.InsertPageBefore(new Home(), page); Navigation.RemovePage(page); await PopupNavigation.Instance.PopAsync(); } else {  Constantce.Area = "Area"; Sumel.BackgroundColor = Color.White; Sumel.TextColor = Color.FromHex("FF071D66"); } }
        async void Zakho_Clicked(object sender, EventArgs e) { if (Zakho.BackgroundColor == Color.White) { Constantce.Area = "Zakho "; Constantce.AreaLang = Zakho.Text; Zakho.TextColor = Color.White; Zakho.BackgroundColor = Color.FromHex("FF071D66"); var existingPages = Navigation.NavigationStack.ToList(); Page page = existingPages.FirstOrDefault(); Navigation.InsertPageBefore(new Home(), page); Navigation.RemovePage(page); await PopupNavigation.Instance.PopAsync(); } else {  Constantce.Area = "Area"; Zakho.BackgroundColor = Color.White; Zakho.TextColor = Color.FromHex("FF071D66"); } }

    }
}