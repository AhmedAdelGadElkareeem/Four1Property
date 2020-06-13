using Acr.UserDialogs;
using Four1Property.Helper;
using Four1Property.Models;
using Newtonsoft.Json;
using Plugin.Media;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Four1Property.View
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Register : ContentPage
    {
        Stream Stream;
        public Register()
        {
            InitializeComponent();
            if (Application.Current.Properties["Language"].ToString() == "Arabic")
            {
                this.FlowDirection = FlowDirection.RightToLeft;

                UserName.Text = "اسم المستخدم";
                Password.Text = "كلمة السر";
                Email.Placeholder = "البريد";
                PasswordEN.Placeholder = "كللمة السر";
                PhoneNumber.Text = "رقم الهاتف";
                Number.Placeholder = "+96.....";
                CREATENEWACCOUNT.Text = " فتح حساب جديد";
            }
            else
            {
                this.FlowDirection = FlowDirection.LeftToRight;
                UserName.Text = "User Name";
                Password.Text = "Password";
                Email.Placeholder = "Email";
                PasswordEN.Placeholder = "Password";
                PhoneNumber.Text = "Phone Number";
                Number.Placeholder = "+96.....";
                CREATENEWACCOUNT.Text = "CREATE NEW ACCOUNT";


            }
            Email.Keyboard = Keyboard.Email;
            PasswordEN.Keyboard = Keyboard.Default;
            Number.Keyboard = Keyboard.Numeric;
        }
        protected override void OnAppearing()
        {
            base.OnAppearing();
            MessagingCenter.Send(this, "preventLandScape");
        }

        private async void CREATENEWACCOUNT_Clicked(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(Email.Text) || string.IsNullOrWhiteSpace(PasswordEN.Text) || string.IsNullOrWhiteSpace(Number.Text))
            {
                if (Application.Current.Properties["Language"].ToString() == "Arabic")
                {
                    await DisplayAlert("تنويه", "يرجى تعبة جميع الحقول", "موافق");
                }
                else
                {
                    await DisplayAlert("Alert", "PLease Fill All Blanks", "OK");
                }
            }
            else if (!Email.Text.Contains(".") || !Email.Text.Contains("@") || !Email.Text.Contains(".com"))
            {
                if (Application.Current.Properties["Language"].ToString() == "Arabic")
                {
                    await DisplayAlert("يرجى ادخال البيانات", "اسم المستخدم غير صحيح", "موافق");
                }
                else
                {
                    await DisplayAlert("Alert", "Invaild Email", "OK");
                }

            }
            else
            {
                string logcheck = null;
                UserDialogs.Instance.ShowLoading();
                await Task.Delay(500);
                var uri = string.Format(Constantce.URL + "/api/properties/SignupMobile/?email={0}&password={1}&number={2}", Email.Text, Password.Text, Number.Text );
                HttpWebRequest request = WebRequest.Create(uri) as HttpWebRequest;
                using (HttpWebResponse response = request.GetResponse() as HttpWebResponse)
                {
                    StreamReader reader = new StreamReader(response.GetResponseStream());
                    string Data = reader.ReadToEnd();
                    Application.Current.Properties["Token"] = Data.Replace("\"", "");
                    logcheck = Data;
                    logcheck = logcheck.Replace("\"", "");
                    Application.Current.Properties["UEmail"] = Email.Text;
                    if (logcheck != "EmailAlreadyAdded")
                    {
                        var existingPages = Navigation.NavigationStack.ToList();
                        await Navigation.PushAsync(new Home());
                        foreach (var page in existingPages)
                        {
                            Navigation.RemovePage(page);
                        }
                        UserDialogs.Instance.HideLoading();
                    }
                    else
                    {
                        if (Application.Current.Properties["Language"].ToString() == "Arabic")
                        {
                            await DisplayAlert("يرجى ادخال البيانات", "اسم المستخدم غير صحيح", "موافق");
                        }
                        else
                        {
                            await DisplayAlert("Alert", "Invaild Email", "OK"); UserDialogs.Instance.HideLoading();
                        }

                    }



                }
            }
        }

        private async void TapGestureRecognizer_Tapped(object sender, EventArgs e)
        {
            if (!CrossMedia.Current.IsPickPhotoSupported)
            {
                await DisplayAlert("no upload", "picking a photo is not supported", "ok");
                return;
            }

            var file = await CrossMedia.Current.PickPhotoAsync();
            Stream = file.GetStream();
            if (file == null)
               return;

            AddPhoto.Source = ImageSource.FromStream(() => file.GetStream());
        }

        private void TapGestureRecognizer_Tapped_1(object sender, EventArgs e)
        {
            if (PasswordEN.IsPassword)
            {
                PasswordEN.IsPassword = false;
                ShwoHide.Source = "HidePassword.png";

            }
            else
            {
                PasswordEN.IsPassword = true;
                ShwoHide.Source = "ShowPassword2.png";

            }
        }
    }
}