using Acr.UserDialogs;
using Four1Property.Helper;
using Four1Property.Models;
using Four1Property.View;
using Newtonsoft.Json;
using Rg.Plugins.Popup.Pages;
using Rg.Plugins.Popup.Services;
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

namespace View
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class MenuPop : PopupPage
    {
        public MenuPop()
        {
            InitializeComponent();
            if (Application.Current.Properties["Language"].ToString() == "Arabic")
            {
                
                this.FlowDirection = FlowDirection.RightToLeft;
                if (Application.Current.Properties["UEmail"].ToString() != "Null")
                {
                    IDLable.Text = "اهلا بك";
                    IDEmail.Text = Application.Current.Properties["UEmail"].ToString();
                }
                else
                {
                    IDLable.Text = "اهلا بك";
                }
                LoginorRegister.Text = "تسجيل الدخول";
                Profile.Text = "ملفي";
                Wishlist.Text = "المفضلة";
                Agents.Text = "العملاء";
                About.Text = "من نحن";
                LogOut.Text = "تسجيل الحروج";
            }
            else
            {
                this.FlowDirection = FlowDirection.LeftToRight;
                if (Application.Current.Properties["UEmail"].ToString() != "Null")
                {
                    IDLable.Text = "Welcome";
                    IDEmail.Text = Application.Current.Properties["UEmail"].ToString();
                }
                else
                {
                    IDLable.Text = "Welcome";
                }
                LoginorRegister.Text = "Login";
                Profile.Text = "Profile";
                Wishlist.Text = "Wishlist";
                Agents.Text = "Agents";
                About.Text = "About Us";
                LogOut.Text = "Logout";

            }
            if (Application.Current.Properties["Token"].ToString() != "Null" && Application.Current.Properties["Token"].ToString() != "Guest")
            {
                LoginorRegister.IsVisible = false;
                Profile.IsVisible = true;
                Wishlist.IsVisible = true;
                LogOut.IsVisible = true;
            }
            else
            {
                LoginorRegister.IsVisible = true;
                Profile.IsVisible = false;
                Wishlist.IsVisible = false;
                LogOut.IsVisible = false;
            }
        }

        private async void LoginorRegister_Clicked(object sender, EventArgs e)
        {
            Application.Current.Properties["Token"] = "Null";
            Application.Current.Properties["UEmail"] = "Null";
            var existingPages = Navigation.NavigationStack.ToList();
            await Navigation.PushAsync(new Login());
            foreach (var page in existingPages)
            {
                Navigation.RemovePage(page);
            }
            await PopupNavigation.Instance.PopAsync();
        }

        private async void Profile_Clicked(object sender, EventArgs e)
        {
            UserDialogs.Instance.ShowLoading();
            await Task.Delay(500);
            string userid = Application.Current.Properties["Token"].ToString();
            userid = userid.Replace("\"", "");
            var uri = string.Format(Constantce.URL + "/api/properties/GetWishList/?user={0}", userid);
            HttpWebRequest request = WebRequest.Create(uri) as HttpWebRequest;
            using (HttpWebResponse response = request.GetResponse() as HttpWebResponse)
            {
                StreamReader reader = new StreamReader(response.GetResponseStream());
                string Data = reader.ReadToEnd();
                ObservableCollection<Property> property = JsonConvert.DeserializeObject<ObservableCollection<Property>>(Data);
                await Navigation.PushAsync(new UserProfile(property));
                await PopupNavigation.Instance.PopAsync();
            }
            UserDialogs.Instance.HideLoading();
        }

        private async void Wishlist_Clicked(object sender, EventArgs e)
        {
            UserDialogs.Instance.ShowLoading();
            await Task.Delay(500);
            string userid = Application.Current.Properties["Token"].ToString();
            userid = userid.Replace("\"", "");
            var uri = string.Format(Constantce.URL + "/api/properties/GetWishList/?user={0}", userid);
            HttpWebRequest request = WebRequest.Create(uri) as HttpWebRequest;
            using (HttpWebResponse response = request.GetResponse() as HttpWebResponse)
            {
                StreamReader reader = new StreamReader(response.GetResponseStream());
                string Data = reader.ReadToEnd();
                ObservableCollection<Property> property = JsonConvert.DeserializeObject<ObservableCollection<Property>>(Data);
                await Navigation.PushAsync(new Wishlist(property));
                await PopupNavigation.Instance.PopAsync();
            }
            UserDialogs.Instance.HideLoading();
        }

        private async void Agents_Clicked(object sender, EventArgs e)
        {
            try
            {
               
                UserDialogs.Instance.ShowLoading();
                await Task.Delay(500);
                var uri = string.Format(Constantce.URL + "/api/properties/GetAgents");
                HttpWebRequest request = WebRequest.Create(uri) as HttpWebRequest;
                using (HttpWebResponse response = request.GetResponse() as HttpWebResponse)
                {
                    StreamReader reader = new StreamReader(response.GetResponseStream());
                    string Data = reader.ReadToEnd();
                    ObservableCollection<Agent> agent = JsonConvert.DeserializeObject<ObservableCollection<Agent>>(Data);
                    
                    await PopupNavigation.Instance.PopAsync();
                    await Navigation.PushAsync(new Agents(agent));
                }
                UserDialogs.Instance.HideLoading();
                // await Navigation.PushAsync(new Register());

            }

            catch
            {
                await DisplayAlert("Error", "Check App permissions. ", "Ok");
                return;
            }
        }

        private void About_Clicked(object sender, EventArgs e)
        {

        }

        private async void LogOut_Clicked(object sender, EventArgs e)
        {
            Application.Current.Properties["Token"] = "Null";
            Application.Current.Properties["UEmail"] = "Null";
            Application.Current.Properties["WishP"] = "Null";
            Application.Current.Properties["ComP"] = "Null";
            var existingPages = Navigation.NavigationStack.ToList();
            await Navigation.PushAsync(new Login());
            foreach (var page in existingPages)
            {
                Navigation.RemovePage(page);
            }
            await PopupNavigation.Instance.PopAsync();
        }
    }
}