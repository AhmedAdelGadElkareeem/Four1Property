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
	public partial class Maysan : PopupPage
    {
		public Maysan ()
		{
			InitializeComponent ();
            if (Application.Current.Properties["Language"].ToString() == "Arabic")
            {
                this.FlowDirection = FlowDirection.RightToLeft;
                UpText.Text = "الرجاء اختيار المنطقة";

                AliAlGharbi.Text = "الي الغربي";
                AlKahla.Text = "الكحلة";
                AlMaimouna.Text = "الميمونة";
                AlMejarAlKabi.Text = "المجر الكبي";
                Amara.Text = "العمارة";
                QalatSaleh.Text = "قلعة صالح";

            }
            else
            {
                this.FlowDirection = FlowDirection.LeftToRight;
                UpText.Text = "Please Select Area";

                AliAlGharbi.Text = "Ali Al - Gharbi ";
                AlKahla.Text = "Al - Kahla ";
                AlMaimouna.Text = "Al - Maimouna ";
                AlMejarAlKabi.Text = "Al - Mejar Al - Kabi";
                Amara.Text = "Amara ";
                QalatSaleh.Text = "Qal'at Saleh ";



            }
            if (Constantce.Area == "Ali Al - Gharbi "){ AliAlGharbi.BackgroundColor = Color.FromHex("FF071D66"); AliAlGharbi.TextColor = Color.White; }
            else if (Constantce.Area == "Al - Kahla "){ AlKahla.BackgroundColor = Color.FromHex("FF071D66"); AlKahla.TextColor = Color.White; }
            else if (Constantce.Area == "Al - Maimouna "){ AlMaimouna.BackgroundColor = Color.FromHex("FF071D66"); AlMaimouna.TextColor = Color.White; }
            else if (Constantce.Area == "Al - Mejar Al - Kabi"){ AlMejarAlKabi.BackgroundColor = Color.FromHex("FF071D66"); AlMejarAlKabi.TextColor = Color.White; }
            else if (Constantce.Area == "Amara "){ Amara.BackgroundColor = Color.FromHex("FF071D66"); Amara.TextColor = Color.White; }
            else if (Constantce.Area == "Qal'at Saleh "){QalatSaleh.BackgroundColor = Color.FromHex("FF071D66"); QalatSaleh.TextColor = Color.White;}

        }
        async void AliAlGharbi_Clicked(object sender, EventArgs e) { if (AliAlGharbi.BackgroundColor == Color.White) { Constantce.Area = "Ali Al - Gharbi "; Constantce.AreaLang = AliAlGharbi.Text; AliAlGharbi.TextColor = Color.White; AliAlGharbi.BackgroundColor = Color.FromHex("FF071D66"); var existingPages = Navigation.NavigationStack.ToList(); Page page = existingPages.FirstOrDefault(); Navigation.InsertPageBefore(new Home(), page); Navigation.RemovePage(page); await PopupNavigation.Instance.PopAsync(); } else {  Constantce.Area = "Area"; AliAlGharbi.BackgroundColor = Color.White; AliAlGharbi.TextColor = Color.FromHex("FF071D66"); } }
        async void AlKahla_Clicked(object sender, EventArgs e) { if (AlKahla.BackgroundColor == Color.White) { Constantce.Area = "Al - Kahla "; Constantce.AreaLang = AlKahla.Text; AlKahla.TextColor = Color.White; AlKahla.BackgroundColor = Color.FromHex("FF071D66"); var existingPages = Navigation.NavigationStack.ToList(); Page page = existingPages.FirstOrDefault(); Navigation.InsertPageBefore(new Home(), page); Navigation.RemovePage(page); await PopupNavigation.Instance.PopAsync(); } else {  Constantce.Area = "Area"; AlKahla.BackgroundColor = Color.White; AlKahla.TextColor = Color.FromHex("FF071D66"); } }
        async void AlMaimouna_Clicked(object sender, EventArgs e) { if (AlMaimouna.BackgroundColor == Color.White) { Constantce.Area = "Al - Maimouna "; Constantce.AreaLang = AlMaimouna.Text; AlMaimouna.TextColor = Color.White; AlMaimouna.BackgroundColor = Color.FromHex("FF071D66"); var existingPages = Navigation.NavigationStack.ToList(); Page page = existingPages.FirstOrDefault(); Navigation.InsertPageBefore(new Home(), page); Navigation.RemovePage(page); await PopupNavigation.Instance.PopAsync(); } else {  Constantce.Area = "Area"; AlMaimouna.BackgroundColor = Color.White; AlMaimouna.TextColor = Color.FromHex("FF071D66"); } }
        async void AlMejarAlKabi_Clicked(object sender, EventArgs e) { if (AlMejarAlKabi.BackgroundColor == Color.White) { Constantce.Area = "Al - Mejar Al - Kabi"; Constantce.AreaLang = AlMejarAlKabi.Text; AlMejarAlKabi.TextColor = Color.White; AlMejarAlKabi.BackgroundColor = Color.FromHex("FF071D66"); var existingPages = Navigation.NavigationStack.ToList(); Page page = existingPages.FirstOrDefault(); Navigation.InsertPageBefore(new Home(), page); Navigation.RemovePage(page); await PopupNavigation.Instance.PopAsync(); } else {  Constantce.Area = "Area"; AlMejarAlKabi.BackgroundColor = Color.White; AlMejarAlKabi.TextColor = Color.FromHex("FF071D66"); } }
        async void Amara_Clicked(object sender, EventArgs e) { if (Amara.BackgroundColor == Color.White) { Constantce.Area = "Amara "; Constantce.AreaLang = Amara.Text; Amara.TextColor = Color.White; Amara.BackgroundColor = Color.FromHex("FF071D66"); var existingPages = Navigation.NavigationStack.ToList(); Page page = existingPages.FirstOrDefault(); Navigation.InsertPageBefore(new Home(), page); Navigation.RemovePage(page); await PopupNavigation.Instance.PopAsync(); } else {  Constantce.Area = "Area"; Amara.BackgroundColor = Color.White; Amara.TextColor = Color.FromHex("FF071D66"); } }
        async void QalatSaleh_Clicked(object sender, EventArgs e){if (QalatSaleh.BackgroundColor == Color.White){Constantce.Area = "Qal'at Saleh ";Constantce.AreaLang =QalatSaleh.Text;QalatSaleh.TextColor = Color.White;QalatSaleh.BackgroundColor = Color.FromHex("FF071D66");var existingPages = Navigation.NavigationStack.ToList();Page page = existingPages.FirstOrDefault();Navigation.InsertPageBefore(new Home(), page);Navigation.RemovePage(page);await PopupNavigation.Instance.PopAsync();}else{Constantce.Area = "Area";QalatSaleh.BackgroundColor = Color.White;QalatSaleh.TextColor = Color.FromHex("FF071D66");}}
    }
        }