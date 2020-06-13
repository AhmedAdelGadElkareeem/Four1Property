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
	public partial class Karbala : PopupPage
    {
		public Karbala ()
		{
			InitializeComponent ();
            if (Application.Current.Properties["Language"].ToString() == "Arabic")
            {
                this.FlowDirection = FlowDirection.RightToLeft;
                UpText.Text = "الرجاء اختيار المنطقة";

                AinAlTamur.Text = "عين التمر";
                AlHindiya.Text = "الهندية";
                Kerbala.Text = "كربلاء";

            }
            else
            {
                this.FlowDirection = FlowDirection.LeftToRight;
                UpText.Text = "Please Select Area";

                AinAlTamur.Text = "Ain Al - Tamur ";
                AlHindiya.Text = "Al - Hindiya ";
                Kerbala.Text = "Kerbala ";

            }
            if (Constantce.Area == "Ain Al - Tamur "){ AinAlTamur.BackgroundColor = Color.FromHex("FF071D66"); AinAlTamur.TextColor = Color.White; }
            else if (Constantce.Area == "Al - Hindiya "){ AlHindiya.BackgroundColor = Color.FromHex("FF071D66"); AlHindiya.TextColor = Color.White; }
            else if (Constantce.Area == "Kerbala "){ Kerbala.BackgroundColor = Color.FromHex("FF071D66"); Kerbala.TextColor = Color.White; }


        }
        async void AinAlTamur_Clicked(object sender, EventArgs e) { if (AinAlTamur.BackgroundColor == Color.White) { Constantce.Area = "Ain Al - Tamur "; Constantce.AreaLang = AinAlTamur.Text; AinAlTamur.TextColor = Color.White; AinAlTamur.BackgroundColor = Color.FromHex("FF071D66"); var existingPages = Navigation.NavigationStack.ToList(); Page page = existingPages.FirstOrDefault(); Navigation.InsertPageBefore(new Home(), page); Navigation.RemovePage(page); await PopupNavigation.Instance.PopAsync(); } else {  Constantce.Area = "Area"; AinAlTamur.BackgroundColor = Color.White; AinAlTamur.TextColor = Color.FromHex("FF071D66"); } }
        async void AlHindiya_Clicked(object sender, EventArgs e) { if (AlHindiya.BackgroundColor == Color.White) { Constantce.Area = "Al - Hindiya "; Constantce.AreaLang = AlHindiya.Text; AlHindiya.TextColor = Color.White; AlHindiya.BackgroundColor = Color.FromHex("FF071D66"); var existingPages = Navigation.NavigationStack.ToList(); Page page = existingPages.FirstOrDefault(); Navigation.InsertPageBefore(new Home(), page); Navigation.RemovePage(page); await PopupNavigation.Instance.PopAsync(); } else {  Constantce.Area = "Area"; AlHindiya.BackgroundColor = Color.White; AlHindiya.TextColor = Color.FromHex("FF071D66"); } }
        async void Kerbala_Clicked(object sender, EventArgs e) { if (Kerbala.BackgroundColor == Color.White) { Constantce.Area = "Kerbala "; Constantce.AreaLang = Kerbala.Text; Kerbala.TextColor = Color.White; Kerbala.BackgroundColor = Color.FromHex("FF071D66"); var existingPages = Navigation.NavigationStack.ToList(); Page page = existingPages.FirstOrDefault(); Navigation.InsertPageBefore(new Home(), page); Navigation.RemovePage(page); await PopupNavigation.Instance.PopAsync(); } else {  Constantce.Area = "Area"; Kerbala.BackgroundColor = Color.White; Kerbala.TextColor = Color.FromHex("FF071D66"); } }

    }
}