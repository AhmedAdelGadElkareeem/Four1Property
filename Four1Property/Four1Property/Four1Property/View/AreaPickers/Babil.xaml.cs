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
	public partial class Babil : PopupPage
    {
		public Babil ()
		{
			InitializeComponent ();
            if (Application.Current.Properties["Language"].ToString() == "Arabic")
            {
                this.FlowDirection = FlowDirection.RightToLeft;
                UpText.Text = "الرجاء اختيار المنطقة";

                AlMahawil.Text = "المهوي";
                AlMusayab.Text = "المسياب";
                Hashimiya.Text = "هاشمية";
                Hilla.Text = "حلة";


            }
            else
            {
                this.FlowDirection = FlowDirection.LeftToRight;
                UpText.Text = "Please Select Area";

                AlMahawil.Text = "Al - Mahawil";
                AlMusayab.Text = "Al - Musayab";
                Hashimiya.Text = "Hashimiya";
                Hilla.Text = "Hilla";

            }
            if (Constantce.Area == "Al - Mahawil"){ AlMahawil.BackgroundColor = Color.FromHex("FF071D66"); AlMahawil.TextColor = Color.White; }
           else if (Constantce.Area == "Al - Musayab"){ AlMusayab.BackgroundColor = Color.FromHex("FF071D66"); AlMusayab.TextColor = Color.White; }
           else if (Constantce.Area == "Hashimiya"){ Hashimiya.BackgroundColor = Color.FromHex("FF071D66"); Hashimiya.TextColor = Color.White; }
           else if (Constantce.Area == "Hilla"){ Hilla.BackgroundColor = Color.FromHex("FF071D66"); Hilla.TextColor = Color.White; }

        }
        async void AlMahawil_Clicked(object sender, EventArgs e) { if (AlMahawil.BackgroundColor == Color.White) { Constantce.Area = "Al - Mahawil"; Constantce.AreaLang = AlMahawil.Text; AlMahawil.TextColor = Color.White; AlMahawil.BackgroundColor = Color.FromHex("FF071D66"); var existingPages = Navigation.NavigationStack.ToList(); Page page = existingPages.FirstOrDefault(); Navigation.InsertPageBefore(new Home(), page); Navigation.RemovePage(page); await PopupNavigation.Instance.PopAsync(); } else {  Constantce.Area = "Area"; AlMahawil.BackgroundColor = Color.White; AlMahawil.TextColor = Color.FromHex("FF071D66"); } }
        async void AlMusayab_Clicked(object sender, EventArgs e) { if (AlMusayab.BackgroundColor == Color.White) { Constantce.Area = "Al - Musayab"; Constantce.AreaLang = AlMusayab.Text; AlMusayab.TextColor = Color.White; AlMusayab.BackgroundColor = Color.FromHex("FF071D66"); var existingPages = Navigation.NavigationStack.ToList(); Page page = existingPages.FirstOrDefault(); Navigation.InsertPageBefore(new Home(), page); Navigation.RemovePage(page); await PopupNavigation.Instance.PopAsync(); } else {  Constantce.Area = "Area"; AlMusayab.BackgroundColor = Color.White; AlMusayab.TextColor = Color.FromHex("FF071D66"); } }
        async void Hashimiya_Clicked(object sender, EventArgs e) { if (Hashimiya.BackgroundColor == Color.White) { Constantce.Area = "Hashimiya"; Constantce.AreaLang = Hashimiya.Text; Hashimiya.TextColor = Color.White; Hashimiya.BackgroundColor = Color.FromHex("FF071D66"); var existingPages = Navigation.NavigationStack.ToList(); Page page = existingPages.FirstOrDefault(); Navigation.InsertPageBefore(new Home(), page); Navigation.RemovePage(page); await PopupNavigation.Instance.PopAsync(); } else {  Constantce.Area = "Area"; Hashimiya.BackgroundColor = Color.White; Hashimiya.TextColor = Color.FromHex("FF071D66"); } }
        async void Hilla_Clicked(object sender, EventArgs e) { if (Hilla.BackgroundColor == Color.White) { Constantce.Area = "Hilla"; Constantce.AreaLang = Hilla.Text; Hilla.TextColor = Color.White; Hilla.BackgroundColor = Color.FromHex("FF071D66"); var existingPages = Navigation.NavigationStack.ToList(); Page page = existingPages.FirstOrDefault(); Navigation.InsertPageBefore(new Home(), page); Navigation.RemovePage(page); await PopupNavigation.Instance.PopAsync(); } else {  Constantce.Area = "Area"; Hilla.BackgroundColor = Color.White; Hilla.TextColor = Color.FromHex("FF071D66"); } }

    }
}