using Acr.UserDialogs;
using Four1Property.Helper;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Four1Property.View
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Login : ContentPage
    {
        public Login()
        {
            InitializeComponent();
            if (Application.Current.Properties["Language"].ToString() == "Arabic")
            {
                this.FlowDirection = FlowDirection.RightToLeft;

                UserName.Text = "اسم المستخدم";
                PassWord.Text = "كلمة السر";
                Email.Placeholder = "البريد";
                Password.Placeholder = "كللمة السر";
                GUEST.Text = "التصفح كضيف";
                LoginButton.Text = "تسجيل الدخول";
                RegisterNow.Text = "حساب جديد";
                ForgetYourPassword.Text = "نسيت كلمة السر؟";
            }
            else
            {
                this.FlowDirection = FlowDirection.LeftToRight;
                UserName.Text = "User Name";
                PassWord.Text = "Password";
                Email.Placeholder = "Email";
                Password.Placeholder = "Password";
                GUEST.Text = "CONTINUE AS A GUEST";
                LoginButton.Text = "Login";
                RegisterNow.Text = "Register Now";
                ForgetYourPassword.Text = "Forget Your Password?";


            }
            Email.Keyboard = Keyboard.Email;
            Password.Keyboard = Keyboard.Default;
        }
        protected override void OnAppearing()
        {
            base.OnAppearing();
            MessagingCenter.Send(this, "preventLandScape");
            NavigationPage.SetHasNavigationBar(this, false);

        }

        private void GUEST_Clicked(object sender, EventArgs e)
        {
            Application.Current.Properties["Token"] = "Guest";
            var existingPages = Navigation.NavigationStack.ToList();
            Page page = existingPages.FirstOrDefault();
            Navigation.InsertPageBefore(new Home(), page);
            Navigation.RemovePage(page);
        }

        async private void RegisterNow_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Register());
        }

        private async void LoginButton_Clicked(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(Email.Text) || string.IsNullOrWhiteSpace(Password.Text))
            {
                if (Application.Current.Properties["Language"].ToString() == "Arabic")
                {
                    await DisplayAlert("يرجى ادخال البيانات", "اسم المستخدم او كلمة المرور غير صحيح", "موافق");
                }
                else
                {
                    await DisplayAlert("Fill The Blanks", "Invaild Email or Password", "OK");

                }
            }
            else
            {
                string logcheck = null;
                UserDialogs.Instance.ShowLoading();
                await Task.Delay(500);
                var uri = string.Format(Constantce.URL + "/api/properties/LoginMobile/?email={0}&password={1}", Email.Text, Password.Text);
                HttpWebRequest request = WebRequest.Create(uri) as HttpWebRequest;
                using (HttpWebResponse response = request.GetResponse() as HttpWebResponse)
                {
                    StreamReader reader = new StreamReader(response.GetResponseStream());
                    string Data = reader.ReadToEnd();
                    Application.Current.Properties["Token"] = Data.Replace("\"", "");
                    logcheck = Data;
                    logcheck = logcheck.Replace("\"", "");
                    Application.Current.Properties["UEmail"] = Email.Text;
                    if (logcheck == "InvalidEmail")
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
                    else if (logcheck == "InvalidPassword")
                    {
                        if (Application.Current.Properties["Language"].ToString() == "Arabic")
                        {
                            await DisplayAlert("يرجى ادخال البيانات", " كلمة المرور غير صحيحة", "موافق");
                        }
                        else
                        {
                            await DisplayAlert("Alert", "Invaild Password", "OK"); UserDialogs.Instance.HideLoading();
                        }
                    }
                    else
                    {

                        await WishID();
                        await ComID();
                        var existingPages = Navigation.NavigationStack.ToList();
                        Page page = existingPages.FirstOrDefault();
                        Navigation.InsertPageBefore(new Home(), page);
                        Navigation.RemovePage(page);
                    }
                }
                UserDialogs.Instance.HideLoading();
            }
        }
        public async Task WishID()
        {
            string userid = Application.Current.Properties["Token"].ToString();
            userid = userid.Replace("\"", "");
            var uri1 = string.Format(Constantce.URL + "/api/properties/WiswID?userid={0}", userid);
            HttpWebRequest request1 = WebRequest.Create(uri1) as HttpWebRequest;
            using (HttpWebResponse response1 = request1.GetResponse() as HttpWebResponse)
            {
                StreamReader reader1 = new StreamReader(response1.GetResponseStream());
                string Data1 = reader1.ReadToEnd();
                Application.Current.Properties["WishP"] = Data1.Replace("\"", "");

            }
            return;
        }
        public async Task ComID()
        {
            string userid = Application.Current.Properties["Token"].ToString();
            userid = userid.Replace("\"", "");
            var uri1 = string.Format(Constantce.URL + "/api/properties/CompID?userid={0}", userid);
            HttpWebRequest request1 = WebRequest.Create(uri1) as HttpWebRequest;
            using (HttpWebResponse response1 = request1.GetResponse() as HttpWebResponse)
            {
                StreamReader reader1 = new StreamReader(response1.GetResponseStream());
                string Data1 = reader1.ReadToEnd();
                Application.Current.Properties["ComP"] = Data1.Replace("\"", "");

            }
        }

        private void TapGestureRecognizer_Tapped(object sender, EventArgs e)
        {
            if (Password.IsPassword)
            {
                Password.IsPassword = false;
                ShowHide.Source = "HidePassword.png";
            }
            else
            {
                Password.IsPassword = true;
                ShowHide.Source = "ShowPassword2.png";

            }
        }
    }

}