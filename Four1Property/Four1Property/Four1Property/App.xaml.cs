using Four1Property.Helper;
using Four1Property.View;
using System;
using System.Globalization;
using System.IO;
using System.Net;
using System.Threading.Tasks;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

[assembly: XamlCompilation(XamlCompilationOptions.Compile)]
namespace Four1Property
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();
            if (Application.Current.Properties.ContainsKey("Token"))
            {
                
                if (Application.Current.Properties["Token"].Equals("Null"))
                {
                    if (CultureInfo.CurrentCulture.DisplayName.Contains("Arabic"))
                    {
                        Application.Current.Properties["Language"] = "Arabic";
                    }
                    else
                    {
                        Application.Current.Properties["Language"] = "English";
                    }
                    MainPage = new NavigationPage(new Login())
                    {
                        BarBackgroundColor = Color.FromHex("#FF071D66")
                    };
                }

                else if (Application.Current.Properties.ContainsKey("Language"))
                {
                    if (Application.Current.Properties["Token"].ToString() != "Null" && Application.Current.Properties["Token"].ToString() != "Guest")
                    {
                        WishID();
                        ComID();
                    }
                    MainPage = new NavigationPage(new Home())
                    {
                        BarBackgroundColor = Color.FromHex("#FF071D66")
                    };
                }
            }
            else
            {
                Application.Current.Properties["Language"] = "English";
                Application.Current.Properties["Token"] = "Null";
                Application.Current.Properties["UEmail"] = "Null";
                Application.Current.Properties["WishP"] = "Null";
                Application.Current.Properties["ComP"] = "Null";
                Application.Current.SavePropertiesAsync();
                MainPage = new NavigationPage(new Login())
                {
                    BarBackgroundColor = Color.FromHex("#FF071D66")
                };

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
        protected override void OnStart()
        {
            WishID();
            ComID();
        }

        protected override void OnSleep()
        {
            // Handle when your app sleeps
        }

        protected override void OnResume()
        {
            // Handle when your app resumes
        }
    }
}
