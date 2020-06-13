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
    public partial class City : PopupPage
    {
        public City()
        {
            InitializeComponent();
            if (Application.Current.Properties["Language"].ToString() == "Arabic")
            {
                this.FlowDirection = FlowDirection.RightToLeft;
                UpText.Text = "الرجاء اختيار المدينة";
                Ammanbtn.Text = "عمان";
                Ajlunbtn.Text = "عجلون";
                AlAqabahbtn.Text = "العقبة";
                AlBalqabtn.Text = "البلقاء";
                AlKarakbtn.Text = "الكرك";
                AlMafraqbtn.Text = "المفرق";
                AlTafilahbtn.Text = "الطفيله";
                AzZarqabtn.Text = "الزرقاء";
                Irbidbtn.Text = "اربد";
                Jarashbtn.Text = "جرش";
                Maanbtn.Text = "معان";
                Madababtn.Text = "مأدبا";
                Baghdad.Text = "بغداد";
                Ninawa.Text = "نينوا";
                AlBasrah.Text = "البصرة";
                Karbala.Text = "كربلاء";
                AlNajaf.Text = "النجف";
                AlMuthanna.Text = "المثنى";
                AlAnbar.Text = "الأنبار";
                SalahAlDdin.Text = "صلاح الدين";
                Arbil.Text = "أربيل";
                Dahuk.Text = "دهوك";
                AlSulaymaniyah.Text = "السليمانية";
                Babil.Text = "بابل";
                Maysan.Text = "ميسان";
                Diqar.Text = "ذي قار";
                Wasit.Text = "وسيط";
                AlTamin.Text = "الثامن";
                Diyalla.Text = "ديالا";
                AlQadsyiah.Text = "القادسية";
            }
            else
            {
                this.FlowDirection = FlowDirection.LeftToRight;
                UpText.Text = "Please Select City";
                Ammanbtn.Text = "Amman";
                Ajlunbtn.Text = "Ajlun";
                AlAqabahbtn.Text = "AlAqabah";
                AlBalqabtn.Text = "AlBalqa";
                AlKarakbtn.Text = "AlKarak";
                AlMafraqbtn.Text = "AlMafraq";
                AlTafilahbtn.Text = "AlTafilah";
                AzZarqabtn.Text = "AzZarqa";
                Irbidbtn.Text = "Irbid";
                Jarashbtn.Text = "Jarash";
                Maanbtn.Text = "Maan";
                Madababtn.Text = "Madaba";
                Baghdad.Text = "Baghdad";
                Ninawa.Text = "Ninawa";
                AlBasrah.Text = "AlBasrah";
                Karbala.Text = "Karbala";
                AlNajaf.Text = "AlNajaf";
                AlMuthanna.Text = "AlMuthanna";
                AlAnbar.Text = "AlAnbar";
                SalahAlDdin.Text = "SalahAlDdin";
                Arbil.Text = "Arbil";
                Dahuk.Text = "Arbil";
                AlSulaymaniyah.Text = "AlSulaymaniyah";
                Babil.Text = "Babil";
                Maysan.Text = "Maysan";
                Diqar.Text = "Maysan";
                Wasit.Text = "Wasit";
                AlTamin.Text = "AlTamin";
                Diyalla.Text = "Diyalla";
                AlQadsyiah.Text = "AlQadsyiah";
            }
            if (Constantce.Country == "Jordan")
            {
                JordanGrid.IsVisible = true;
            }
            if (Constantce.Country == "Iraq")
            {
                IraqGrid.IsVisible = true;
            }


            if (Constantce.City == "Amman")
            {
                Ammanbtn.BackgroundColor = Color.FromHex("FF071D66");
                Ammanbtn.TextColor = Color.White;
                
            }
            else if (Constantce.City == "Ajlun")
            {
                Ajlunbtn.TextColor = Color.White;
                Ajlunbtn.BackgroundColor = Color.FromHex("FF071D66");
                
            }
            else if (Constantce.City == "AlAqabah")
            {
                AlAqabahbtn.TextColor = Color.White;
                AlAqabahbtn.BackgroundColor = Color.FromHex("FF071D66");

            }
            else if (Constantce.City == "AlBalqa")
            {
                AlBalqabtn.TextColor = Color.White;
                AlBalqabtn.BackgroundColor = Color.FromHex("FF071D66");
               
            }
            else if (Constantce.City == "AlKarak")
            {
                AlKarakbtn.TextColor = Color.White;
                AlKarakbtn.BackgroundColor = Color.FromHex("FF071D66");
               
            }
            else if (Constantce.City == "AlMafraq")
            {
                AlMafraqbtn.TextColor = Color.White;
                AlMafraqbtn.BackgroundColor = Color.FromHex("FF071D66");
               
            }
            else if (Constantce.City == "AlTafilah")
            {
                AlTafilahbtn.TextColor = Color.White;
                AlTafilahbtn.BackgroundColor = Color.FromHex("FF071D66");
               
            }
            else if (Constantce.City == "AzZarqa")
            {
                AzZarqabtn.TextColor = Color.White;
                AzZarqabtn.BackgroundColor = Color.FromHex("FF071D66");
                
            }
            else if (Constantce.City == "Irbid")
            {
                Irbidbtn.TextColor = Color.White;
                Irbidbtn.BackgroundColor = Color.FromHex("FF071D66");
               
            }
            else if (Constantce.City == "Jarash")
            {
                Jarashbtn.TextColor = Color.White;
                Jarashbtn.BackgroundColor = Color.FromHex("FF071D66");
                
            }
            else if (Constantce.City == "Maan")
            {
                Maanbtn.TextColor = Color.White;
                Maanbtn.BackgroundColor = Color.FromHex("FF071D66");
                
            }
            else if (Constantce.City == "Madaba")
            {
                Madababtn.TextColor = Color.White;
                Madababtn.BackgroundColor = Color.FromHex("FF071D66");
               
            }


            if (Constantce.City == "Baghdad")
            {
                Baghdad.TextColor = Color.White;
                Baghdad.BackgroundColor = Color.FromHex("FF071D66");
               
            }
            else if (Constantce.City == "Ninawa")
            {
                Ninawa.TextColor = Color.White;
                Ninawa.BackgroundColor = Color.FromHex("FF071D66");
               
            }
            else if (Constantce.City == "AlBasrah")
            {
                AlBasrah.TextColor = Color.White;
                AlBasrah.BackgroundColor = Color.FromHex("FF071D66");
                
            }
            else if (Constantce.City == "Karbala")
            {
                Karbala.TextColor = Color.White;
                Karbala.BackgroundColor = Color.FromHex("FF071D66");
                
            }
            else if (Constantce.City == "AlNajaf")
            {
                AlNajaf.TextColor = Color.White;
                AlNajaf.BackgroundColor = Color.FromHex("FF071D66");
                
            }
            else if (Constantce.City == "AlMuthanna")
            {
                AlMuthanna.TextColor = Color.White;
                AlMuthanna.BackgroundColor = Color.FromHex("FF071D66");
               
            }
            else if (Constantce.City == "AlAnbar")
            {
                AlAnbar.TextColor = Color.White;
                AlAnbar.BackgroundColor = Color.FromHex("FF071D66");
              
            }
            else if (Constantce.City == "SalahAlDdin")
            {
                SalahAlDdin.TextColor = Color.White;
                SalahAlDdin.BackgroundColor = Color.FromHex("FF071D66");
              
            }
            else if (Constantce.City == "Arbil")
            {
                Arbil.TextColor = Color.White;
                Arbil.BackgroundColor = Color.FromHex("FF071D66");
               
            }
            else if (Constantce.City == "Dahuk")
            {
                Dahuk.TextColor = Color.White;
                Dahuk.BackgroundColor = Color.FromHex("FF071D66");
               
            }
            else if (Constantce.City == "AlSulaymaniyah")
            {
                AlSulaymaniyah.TextColor = Color.White;
                AlSulaymaniyah.BackgroundColor = Color.FromHex("FF071D66");
            
            }
            else if (Constantce.City == "Babil")
            {
                Babil.TextColor = Color.White;
                Babil.BackgroundColor = Color.FromHex("FF071D66");
               
            }
            else if (Constantce.City == "Maysan")
            {
                Maysan.TextColor = Color.White;
                Maysan.BackgroundColor = Color.FromHex("FF071D66");
              
            }
            else if (Constantce.City == "Diqar")
            {
                Diqar.TextColor = Color.White;
                Diqar.BackgroundColor = Color.FromHex("FF071D66");
              
            }
            else if (Constantce.City == "Wasit")
            {
                Wasit.TextColor = Color.White;
                Wasit.BackgroundColor = Color.FromHex("FF071D66");
              
            }
            else if (Constantce.City == "AlTamin")
            {
                AlTamin.TextColor = Color.White;
                AlTamin.BackgroundColor = Color.FromHex("FF071D66");
               
            }
            else if (Constantce.City == "Diyalla")
            {
                Diyalla.TextColor = Color.White;
                Diyalla.BackgroundColor = Color.FromHex("FF071D66");
               
            }
            else if (Constantce.City == "AlQadsyiah")
            {
                AlQadsyiah.TextColor = Color.White;
                AlQadsyiah.BackgroundColor = Color.FromHex("FF071D66");
               
            }
        }

        //Start Jordan Citeis
        async void Amman_Clicked(object sender, EventArgs e)
        {
            if (Ammanbtn.BackgroundColor == Color.White)
            {
                Constantce.City = "Amman";
                Constantce.Area = "Area";
                Constantce.CityLang = Ammanbtn.Text;
                Ammanbtn.TextColor = Color.White;
                Ammanbtn.BackgroundColor = Color.FromHex("FF071D66");
                var existingPages = Navigation.NavigationStack.ToList();
                Page page = existingPages.FirstOrDefault();

                Navigation.InsertPageBefore(new Home(), page);
                Navigation.RemovePage(page);
                await PopupNavigation.Instance.PopAsync();
            }
            else
            {
                Constantce.City = "City";
                Constantce.Area = "Area";
                Ammanbtn.BackgroundColor = Color.White;
                Ammanbtn.TextColor = Color.FromHex("FF071D66");
                

            }
        }

        async void Ajlun_Clicked(object sender, EventArgs e)
        {
            if (Ajlunbtn.BackgroundColor == Color.White)
            {
                Constantce.City = "Ajlun"; Constantce.Area = "Area";

                Constantce.CityLang = Ajlunbtn.Text;
                Ajlunbtn.TextColor = Color.White;
                Ajlunbtn.BackgroundColor = Color.FromHex("FF071D66");
                var existingPages = Navigation.NavigationStack.ToList();
                Page page = existingPages.FirstOrDefault();

                Navigation.InsertPageBefore(new Home(), page);
                Navigation.RemovePage(page);
                await PopupNavigation.Instance.PopAsync();
            }
            else
            {
                Constantce.City = "City";
                Constantce.Area = "Area";

                Ajlunbtn.BackgroundColor = Color.White;
                Ajlunbtn.TextColor = Color.FromHex("FF071D66");
               

            }
        }

        async void AlAqabah_Clicked(object sender, EventArgs e)
        {
            if (AlAqabahbtn.BackgroundColor == Color.White)
            {
                Constantce.City = "AlAqabah"; Constantce.Area = "Area";

                Constantce.CityLang = AlAqabahbtn.Text;
                AlAqabahbtn.TextColor = Color.White;
                AlAqabahbtn.BackgroundColor = Color.FromHex("FF071D66");
                var existingPages = Navigation.NavigationStack.ToList();
                Page page = existingPages.FirstOrDefault();

                Navigation.InsertPageBefore(new Home(), page);
                Navigation.RemovePage(page);
                await PopupNavigation.Instance.PopAsync();
            }
            else
            {
                Constantce.City = "City";
                Constantce.Area = "Area";

                AlAqabahbtn.BackgroundColor = Color.White;
                AlAqabahbtn.TextColor = Color.FromHex("FF071D66");
            }
        }

        async void AlBalqa_Clicked(object sender, EventArgs e)
        {
            if (AlBalqabtn.BackgroundColor == Color.White)
            {
                Constantce.City = "AlBalqa"; Constantce.Area = "Area";

                Constantce.CityLang = AlBalqabtn.Text;
                AlBalqabtn.TextColor = Color.White;
                AlBalqabtn.BackgroundColor = Color.FromHex("FF071D66");
                var existingPages = Navigation.NavigationStack.ToList();
                Page page = existingPages.FirstOrDefault();

                Navigation.InsertPageBefore(new Home(), page);
                Navigation.RemovePage(page);
                await PopupNavigation.Instance.PopAsync();
            }
            else
            {
                Constantce.City = "City";
                Constantce.Area = "Area";

                AlBalqabtn.BackgroundColor = Color.White;
                AlBalqabtn.TextColor = Color.FromHex("FF071D66");
                

            }
        }

        async void AlKarak_Clicked(object sender, EventArgs e)
        {
            if (AlKarakbtn.BackgroundColor == Color.White)
            {
                Constantce.City = "AlKarak"; Constantce.Area = "Area";

                Constantce.CityLang = AlKarakbtn.Text;
                AlKarakbtn.TextColor = Color.White;
                AlKarakbtn.BackgroundColor = Color.FromHex("FF071D66");
                var existingPages = Navigation.NavigationStack.ToList();
                Page page = existingPages.FirstOrDefault();

                Navigation.InsertPageBefore(new Home(), page);
                Navigation.RemovePage(page);
                await PopupNavigation.Instance.PopAsync();
            }
            else
            {
                Constantce.City = "City";
                Constantce.Area = "Area";

                AlKarakbtn.BackgroundColor = Color.White;
                AlKarakbtn.TextColor = Color.FromHex("FF071D66");
                

            }
        }

        async void AlMafraq_Clicked(object sender, EventArgs e)
        {
            if (AlMafraqbtn.BackgroundColor == Color.White)
            {
                Constantce.City = "AlMafraq"; Constantce.Area = "Area";

                Constantce.CityLang = AlMafraqbtn.Text;
                AlMafraqbtn.TextColor = Color.White;
                AlMafraqbtn.BackgroundColor = Color.FromHex("FF071D66");
                var existingPages = Navigation.NavigationStack.ToList();
                Page page = existingPages.FirstOrDefault();

                Navigation.InsertPageBefore(new Home(), page);
                Navigation.RemovePage(page);
                await PopupNavigation.Instance.PopAsync();
            }
            else
            {
                Constantce.City = "City";
                Constantce.Area = "Area";

                AlMafraqbtn.BackgroundColor = Color.White;
                AlMafraqbtn.TextColor = Color.FromHex("FF071D66");
               
            }
        }

        async void AlTafilah_Clicked(object sender, EventArgs e)
        {
            if (AlTafilahbtn.BackgroundColor == Color.White)
            {
                Constantce.City = "AlTafilah"; Constantce.Area = "Area";

                Constantce.CityLang = AlTafilahbtn.Text;
                AlTafilahbtn.TextColor = Color.White;
                AlTafilahbtn.BackgroundColor = Color.FromHex("FF071D66");
                var existingPages = Navigation.NavigationStack.ToList();
                Page page = existingPages.FirstOrDefault();

                Navigation.InsertPageBefore(new Home(), page);
                Navigation.RemovePage(page);
                await PopupNavigation.Instance.PopAsync();
            }
            else
            {
                Constantce.City = "City";
                Constantce.Area = "Area";

                AlTafilahbtn.BackgroundColor = Color.White;
                AlTafilahbtn.TextColor = Color.FromHex("FF071D66");
            }
        }

        async void AzZarqa_Clicked(object sender, EventArgs e)
        {
            if (AzZarqabtn.BackgroundColor == Color.White)
            {
                Constantce.City = "AzZarqa"; Constantce.Area = "Area";

                Constantce.CityLang = AzZarqabtn.Text;
                AzZarqabtn.TextColor = Color.White;
                AzZarqabtn.BackgroundColor = Color.FromHex("FF071D66");
                var existingPages = Navigation.NavigationStack.ToList();
                Page page = existingPages.FirstOrDefault();

                Navigation.InsertPageBefore(new Home(), page);
                Navigation.RemovePage(page);
                await PopupNavigation.Instance.PopAsync();
            }
            else
            {
                Constantce.City = "City";
                Constantce.Area = "Area";

                AzZarqabtn.BackgroundColor = Color.White;
                AzZarqabtn.TextColor = Color.FromHex("FF071D66");
                

            }
        }

        async void Irbid_Clicked(object sender, EventArgs e)
        {
            if (Irbidbtn.BackgroundColor == Color.White)
            {
                Constantce.City = "Irbid"; Constantce.Area = "Area";

                Constantce.CityLang = Irbidbtn.Text;
                Irbidbtn.TextColor = Color.White;
                Irbidbtn.BackgroundColor = Color.FromHex("FF071D66");
                var existingPages = Navigation.NavigationStack.ToList();
                Page page = existingPages.FirstOrDefault();

                Navigation.InsertPageBefore(new Home(), page);
                Navigation.RemovePage(page);
                await PopupNavigation.Instance.PopAsync();
            }
            else
            {
                Constantce.City = "City";
                Constantce.Area = "Area";

                Irbidbtn.BackgroundColor = Color.White;
                Irbidbtn.TextColor = Color.FromHex("FF071D66");
               

            }
        }

        async void Jarash_Clicked(object sender, EventArgs e)
        {
            if (Jarashbtn.BackgroundColor == Color.White)
            {
                Constantce.City = "Jarash"; Constantce.Area = "Area";

                Constantce.CityLang = Jarashbtn.Text;
                Jarashbtn.TextColor = Color.White;
                Jarashbtn.BackgroundColor = Color.FromHex("FF071D66");
                var existingPages = Navigation.NavigationStack.ToList();
                Page page = existingPages.FirstOrDefault();

                Navigation.InsertPageBefore(new Home(), page);
                Navigation.RemovePage(page);
                await PopupNavigation.Instance.PopAsync();
            }
            else
            {
                Constantce.City = "City";
                Constantce.Area = "Area";

                Jarashbtn.BackgroundColor = Color.White;
                Jarashbtn.TextColor = Color.FromHex("FF071D66");
               

            }
        }

        async void Maan_Clicked(object sender, EventArgs e)
        {
            if (Maanbtn.BackgroundColor == Color.White)
            {
                Constantce.City = "Maan"; Constantce.Area = "Area";

                Constantce.CityLang = Maanbtn.Text;
                Maanbtn.TextColor = Color.White;
                Maanbtn.BackgroundColor = Color.FromHex("FF071D66");
                var existingPages = Navigation.NavigationStack.ToList();
                 Navigation.PushAsync(new Home());
                foreach (var page in existingPages)
                {
                    Navigation.RemovePage(page);
                }
                await Task.Delay(80);
                await PopupNavigation.Instance.PopAsync();
            }
            else
            {
                Constantce.City = "City";
                Constantce.Area = "Area";

                Maanbtn.BackgroundColor = Color.White;
                Maanbtn.TextColor = Color.FromHex("FF071D66");

            }
        }

        async void Madaba_Clicked(object sender, EventArgs e)
        {
            if (Madababtn.BackgroundColor == Color.White)
            {
                Constantce.City = "Madaba"; Constantce.Area = "Area";

                Constantce.CityLang = Madababtn.Text;
                Madababtn.TextColor = Color.White;
                Madababtn.BackgroundColor = Color.FromHex("FF071D66");
                var existingPages = Navigation.NavigationStack.ToList();
                Page page = existingPages.FirstOrDefault();

                Navigation.InsertPageBefore(new Home(), page);
                Navigation.RemovePage(page);
                await PopupNavigation.Instance.PopAsync();
            }
            else
            {
                Constantce.City = "City";
                Constantce.Area = "Area";

                Madababtn.BackgroundColor = Color.White;
                Madababtn.TextColor = Color.FromHex("FF071D66");

            }
        }
        //End Jordan Citeis

        //Start Iraq Citeis
        async void Baghdad_Clicked(object sender, EventArgs e)
        {
            if (Baghdad.BackgroundColor == Color.White)
            {
                Constantce.City = "Baghdad"; Constantce.Area = "Area";

                Constantce.CityLang = Baghdad.Text;

                Baghdad.TextColor = Color.White;
                Baghdad.BackgroundColor = Color.FromHex("FF071D66");
                var existingPages = Navigation.NavigationStack.ToList();
                Page page = existingPages.FirstOrDefault();

                Navigation.InsertPageBefore(new Home(), page);
                Navigation.RemovePage(page);
                await PopupNavigation.Instance.PopAsync();
            }
            else
            {
                Constantce.City = "City";
                Constantce.Area = "Area";
                Baghdad.BackgroundColor = Color.White;
                Baghdad.TextColor = Color.FromHex("FF071D66");
              

            }
        }

        async void Ninawa_Clicked(object sender, EventArgs e)
        {
            if (Ninawa.BackgroundColor == Color.White)
            {
                Constantce.City = "Ninawa"; Constantce.Area = "Area";

                Constantce.CityLang = Ninawa.Text;

                Ninawa.TextColor = Color.White;
                Ninawa.BackgroundColor = Color.FromHex("FF071D66");
                var existingPages = Navigation.NavigationStack.ToList();
                Page page = existingPages.FirstOrDefault();

                Navigation.InsertPageBefore(new Home(), page);
                Navigation.RemovePage(page);
                await PopupNavigation.Instance.PopAsync();
            }
            else
            {
                Constantce.City = "City";
                Constantce.Area = "Area";
                
                Ninawa.BackgroundColor = Color.White;
                Ninawa.TextColor = Color.FromHex("FF071D66");
                

            }
        }

        async void AlBasrah_Clicked(object sender, EventArgs e)
        {
            if (AlBasrah.BackgroundColor == Color.White)
            {
                Constantce.City = "AlBasrah"; Constantce.Area = "Area";

                Constantce.CityLang = AlBasrah.Text;

                AlBasrah.TextColor = Color.White;
                AlBasrah.BackgroundColor = Color.FromHex("FF071D66");
                var existingPages = Navigation.NavigationStack.ToList();
                Page page = existingPages.FirstOrDefault();

                Navigation.InsertPageBefore(new Home(), page);
                Navigation.RemovePage(page);
                await PopupNavigation.Instance.PopAsync();
            }
            else
            {
                Constantce.City = "City";
                Constantce.Area = "Area";
                
                AlBasrah.BackgroundColor = Color.White;
                AlBasrah.TextColor = Color.FromHex("FF071D66");
               

            }

        }

        async void Karbala_Clicked(object sender, EventArgs e)
        {
            if (Karbala.BackgroundColor == Color.White)
            {
                Constantce.City = "Karbala"; Constantce.Area = "Area";

                Constantce.CityLang = Karbala.Text;

                Karbala.TextColor = Color.White;
                Karbala.BackgroundColor = Color.FromHex("FF071D66");
                var existingPages = Navigation.NavigationStack.ToList();
                Page page = existingPages.FirstOrDefault();

                Navigation.InsertPageBefore(new Home(), page);
                Navigation.RemovePage(page);
                await PopupNavigation.Instance.PopAsync();
            }
            else
            {
                Constantce.City = "City";
                Constantce.Area = "Area";
               
                Karbala.BackgroundColor = Color.White;
                Karbala.TextColor = Color.FromHex("FF071D66");
               

            }
        }

        async void AlNajaf_Clicked(object sender, EventArgs e)
        {
            if (AlNajaf.BackgroundColor == Color.White)
            {
                Constantce.City = "AlNajaf"; Constantce.Area = "Area";

                Constantce.CityLang = AlNajaf.Text;

                AlNajaf.TextColor = Color.White;
                AlNajaf.BackgroundColor = Color.FromHex("FF071D66");
                var existingPages = Navigation.NavigationStack.ToList();
                Page page = existingPages.FirstOrDefault();

                Navigation.InsertPageBefore(new Home(), page);
                Navigation.RemovePage(page);
                await PopupNavigation.Instance.PopAsync();
            }
            else
            {
                Constantce.City = "City";
                Constantce.Area = "Area";
               
                AlNajaf.BackgroundColor = Color.White;
                AlNajaf.TextColor = Color.FromHex("FF071D66");

            }
        }

        async void AlMuthanna_Clicked(object sender, EventArgs e)
        {
            if (AlMuthanna.BackgroundColor == Color.White)
            {
                Constantce.City = "AlMuthanna"; Constantce.Area = "Area";

                Constantce.CityLang = AlMuthanna.Text;

                AlMuthanna.TextColor = Color.White;
                AlMuthanna.BackgroundColor = Color.FromHex("FF071D66");
                var existingPages = Navigation.NavigationStack.ToList();
                Page page = existingPages.FirstOrDefault();

                Navigation.InsertPageBefore(new Home(), page);
                Navigation.RemovePage(page);
                await PopupNavigation.Instance.PopAsync();
            }
            else
            {
                Constantce.City = "City";
                Constantce.Area = "Area";
               
                AlMuthanna.BackgroundColor = Color.White;
                AlMuthanna.TextColor = Color.FromHex("FF071D66");
               

            }
        }

        async void AlAnbar_Clicked(object sender, EventArgs e)
        {
            if (AlAnbar.BackgroundColor == Color.White)
            {
                Constantce.City = "AlAnbar"; Constantce.Area = "Area";

                Constantce.CityLang = AlAnbar.Text;

                AlAnbar.TextColor = Color.White;
                AlAnbar.BackgroundColor = Color.FromHex("FF071D66");
                var existingPages = Navigation.NavigationStack.ToList();
                Page page = existingPages.FirstOrDefault();

                Navigation.InsertPageBefore(new Home(), page);
                Navigation.RemovePage(page);
                await PopupNavigation.Instance.PopAsync();
            }
            else
            {
                Constantce.City = "City";
                Constantce.Area = "Area";
               
                AlAnbar.BackgroundColor = Color.White;
                AlAnbar.TextColor = Color.FromHex("FF071D66");
               

            }
        }

        async void SalahAlDdin_Clicked(object sender, EventArgs e)
        {
            if (SalahAlDdin.BackgroundColor == Color.White)
            {
                Constantce.City = "SalahAlDdin"; Constantce.Area = "Area";

                Constantce.CityLang = SalahAlDdin.Text;

                SalahAlDdin.TextColor = Color.White;
                SalahAlDdin.BackgroundColor = Color.FromHex("FF071D66");
                var existingPages = Navigation.NavigationStack.ToList();
                Page page = existingPages.FirstOrDefault();

                Navigation.InsertPageBefore(new Home(), page);
                Navigation.RemovePage(page);
                await PopupNavigation.Instance.PopAsync();
            }
            else
            {
                Constantce.City = "City";
                Constantce.Area = "Area";
                
                SalahAlDdin.BackgroundColor = Color.White;
                SalahAlDdin.TextColor = Color.FromHex("FF071D66");
               

            }
        }

        async void Arbil_Clicked(object sender, EventArgs e)
        {
            if (Arbil.BackgroundColor == Color.White)
            {
                Constantce.City = "Arbil"; Constantce.Area = "Area";

                Constantce.CityLang = Arbil.Text;

                Arbil.TextColor = Color.White;
                Arbil.BackgroundColor = Color.FromHex("FF071D66");
                var existingPages = Navigation.NavigationStack.ToList();
                Page page = existingPages.FirstOrDefault();

                Navigation.InsertPageBefore(new Home(), page);
                Navigation.RemovePage(page);
                await PopupNavigation.Instance.PopAsync();
            }
            else
            {
                Constantce.City = "City";
                Constantce.Area = "Area";
                
                Arbil.BackgroundColor = Color.White;
                Arbil.TextColor = Color.FromHex("FF071D66");
               

            }
        }

        async void Dahuk_Clicked(object sender, EventArgs e)
        {
            if (Dahuk.BackgroundColor == Color.White)
            {
                Constantce.City = "Dahuk"; Constantce.Area = "Area";

                Constantce.CityLang = Dahuk.Text;

                Dahuk.TextColor = Color.White;
                Dahuk.BackgroundColor = Color.FromHex("FF071D66");
                var existingPages = Navigation.NavigationStack.ToList();
                Page page = existingPages.FirstOrDefault();

                Navigation.InsertPageBefore(new Home(), page);
                Navigation.RemovePage(page);
                await PopupNavigation.Instance.PopAsync();
            }
            else
            {
                Constantce.City = "City";
                Constantce.Area = "Area";
              
                Dahuk.BackgroundColor = Color.White;
                Dahuk.TextColor = Color.FromHex("FF071D66");
                

            }

        }

        async void AlSulaymaniyah_Clicked(object sender, EventArgs e)
        {
            if (AlSulaymaniyah.BackgroundColor == Color.White)
            {
                Constantce.City = "AlSulaymaniyah"; Constantce.Area = "Area";

                Constantce.CityLang = AlSulaymaniyah.Text;

                AlSulaymaniyah.TextColor = Color.White;
                AlSulaymaniyah.BackgroundColor = Color.FromHex("FF071D66");
                var existingPages = Navigation.NavigationStack.ToList();
                Page page = existingPages.FirstOrDefault();

                Navigation.InsertPageBefore(new Home(), page);
                Navigation.RemovePage(page);
                await PopupNavigation.Instance.PopAsync();
            }
            else
            {
                Constantce.City = "City";
                Constantce.Area = "Area";
                
                AlSulaymaniyah.BackgroundColor = Color.White;
                AlSulaymaniyah.TextColor = Color.FromHex("FF071D66");
                

            }
        }

        async void Babil_Clicked(object sender, EventArgs e)
        {
            if (Babil.BackgroundColor == Color.White)
            {
                Constantce.City = "Babil"; Constantce.Area = "Area";

                Constantce.CityLang = Babil.Text;

                Babil.TextColor = Color.White;
                Babil.BackgroundColor = Color.FromHex("FF071D66");
                var existingPages = Navigation.NavigationStack.ToList();
                Page page = existingPages.FirstOrDefault();

                Navigation.InsertPageBefore(new Home(), page);
                Navigation.RemovePage(page);
                await PopupNavigation.Instance.PopAsync();
            }
            else
            {
                Constantce.City = "City";
                Constantce.Area = "Area";
               
                Babil.BackgroundColor = Color.White;
                Babil.TextColor = Color.FromHex("FF071D66");
              

            }
        }

        async void Maysan_Clicked(object sender, EventArgs e)
        {
            if (Maysan.BackgroundColor == Color.White)
            {
                Constantce.City = "Maysan"; Constantce.Area = "Area";

                Constantce.CityLang = Maysan.Text;

                Maysan.TextColor = Color.White;
                Maysan.BackgroundColor = Color.FromHex("FF071D66");
                var existingPages = Navigation.NavigationStack.ToList();
                Page page = existingPages.FirstOrDefault();

                Navigation.InsertPageBefore(new Home(), page);
                Navigation.RemovePage(page);
                await PopupNavigation.Instance.PopAsync();
            }
            else
            {
                Constantce.City = "City";
                Constantce.Area = "Area";
               
                Maysan.BackgroundColor = Color.White;
                Maysan.TextColor = Color.FromHex("FF071D66");
               

            }
        }

        async void Diqar_Clicked(object sender, EventArgs e)
        {
            if (Diqar.BackgroundColor == Color.White)
            {
                Constantce.City = "Diqar"; Constantce.Area = "Area";

                Constantce.CityLang = Diqar.Text;

                Diqar.TextColor = Color.White;
                Diqar.BackgroundColor = Color.FromHex("FF071D66");
                var existingPages = Navigation.NavigationStack.ToList();
                Page page = existingPages.FirstOrDefault();

                Navigation.InsertPageBefore(new Home(), page);
                Navigation.RemovePage(page);
                await PopupNavigation.Instance.PopAsync();
            }
            else
            {
                Constantce.City = "City";
                Constantce.Area = "Area";
               
                Diqar.BackgroundColor = Color.White;
                Diqar.TextColor = Color.FromHex("FF071D66");
               

            }
        }

        async void Wasit_Clicked(object sender, EventArgs e)
        {
            if (Wasit.BackgroundColor == Color.White)
            {
                Constantce.City = "Wasit"; Constantce.Area = "Area";

                Constantce.CityLang = Wasit.Text;

                Wasit.TextColor = Color.White;
                Wasit.BackgroundColor = Color.FromHex("FF071D66");
                var existingPages = Navigation.NavigationStack.ToList();
                Page page = existingPages.FirstOrDefault();

                Navigation.InsertPageBefore(new Home(), page);
                Navigation.RemovePage(page);
                await PopupNavigation.Instance.PopAsync();
            }
            else
            {
                Constantce.City = "City";
                Constantce.Area = "Area";
               
                Wasit.BackgroundColor = Color.White;
                Wasit.TextColor = Color.FromHex("FF071D66");
               

            }
        }

        async void AlTamin_Clicked(object sender, EventArgs e)
        {
            if (AlTamin.BackgroundColor == Color.White)
            {
                Constantce.City = "AlTamin"; Constantce.Area = "Area";

                Constantce.CityLang = AlTamin.Text;

                AlTamin.TextColor = Color.White;
                AlTamin.BackgroundColor = Color.FromHex("FF071D66");
                var existingPages = Navigation.NavigationStack.ToList();
                Page page = existingPages.FirstOrDefault();

                Navigation.InsertPageBefore(new Home(), page);
                Navigation.RemovePage(page);
                await PopupNavigation.Instance.PopAsync();
            }
            else
            {
                Constantce.City = "City";
                Constantce.Area = "Area";
               
                AlTamin.BackgroundColor = Color.White;
                AlTamin.TextColor = Color.FromHex("FF071D66");
                

            }
        }

        async void Diyalla_Clicked(object sender, EventArgs e)
        {
            if (Diyalla.BackgroundColor == Color.White)
            {
                Constantce.City = "Diyalla"; Constantce.Area = "Area";

                Constantce.CityLang = Diyalla.Text;

                Diyalla.TextColor = Color.White;
                Diyalla.BackgroundColor = Color.FromHex("FF071D66");
                var existingPages = Navigation.NavigationStack.ToList();
                Page page = existingPages.FirstOrDefault();

                Navigation.InsertPageBefore(new Home(), page);
                Navigation.RemovePage(page);
                await PopupNavigation.Instance.PopAsync();
            }
            else
            {
                Constantce.City = "City";
                Constantce.Area = "Area";
               
                Diyalla.BackgroundColor = Color.White;
                Diyalla.TextColor = Color.FromHex("FF071D66");
                
            }
        }

        async void AlQadsyiah_Clicked(object sender, EventArgs e)
        {
            if (AlQadsyiah.BackgroundColor == Color.White)
            {
                Constantce.City = "AlQadsyiah"; Constantce.Area = "Area";

                Constantce.CityLang = AlQadsyiah.Text;

                AlQadsyiah.TextColor = Color.White;
                AlQadsyiah.BackgroundColor = Color.FromHex("FF071D66");
                var existingPages = Navigation.NavigationStack.ToList();
                Page page = existingPages.FirstOrDefault();

                Navigation.InsertPageBefore(new Home(), page);
                Navigation.RemovePage(page);
                await PopupNavigation.Instance.PopAsync();
            }
            else
            {
                Constantce.City = "City";
                Constantce.Area = "Area";
               
                AlQadsyiah.BackgroundColor = Color.White;
                AlQadsyiah.TextColor = Color.FromHex("FF071D66");

            }
        }
        //End Iraq Citeis




    }
}