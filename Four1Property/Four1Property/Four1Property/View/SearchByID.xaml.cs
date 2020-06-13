using Four1Property.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Http;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using Newtonsoft.Json;
using System.Net;
using System.IO;
using Plugin.Connectivity;
using Acr.UserDialogs;
using System.Collections.ObjectModel;
using Four1Property.Helper;
using Rg.Plugins.Popup.Services;
using View;
using Plugin.Geolocator;
using Rg.Plugins.Popup.Pages;
using Four1Property.View;

namespace View
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class SearchByID : PopupPage
    {
        public SearchByID()
        {
            InitializeComponent();
            if (Application.Current.Properties["Language"].ToString() == "Arabic")
            {
                this.FlowDirection = FlowDirection.RightToLeft;
                IDLable.Text = "رقم العقار";
                IDEntry.Placeholder = "ادخل رقم العقار";
                SearchID.Text = "بحث";
            }
            else
            {
                this.FlowDirection = FlowDirection.LeftToRight;
                IDLable.Text = "Property ID";
                IDEntry.Placeholder = "Enter ID Number";
                SearchID.Text = "Search";
            }
        }

        private async void SearchByID_Clicked(object sender, EventArgs e)
        {
            if (IDEntry.Text != null && IDEntry.Text != "0" && !IDEntry.Text.StartsWith("0") && IDEntry.Text != " " && !IDEntry.Text.StartsWith(" "))
            {
                var ID = IDEntry.Text;
                var value = false;
                UserDialogs.Instance.ShowLoading();
                await Task.Delay(500);
                var uri = "";
                if (ID.Contains("RA") || ID.Contains("ra") || ID.Contains("Ra")) { uri = string.Format(Constantce.URL + "/api/properties/SearchAppartment?ID={0}", ID); value = true; }
                else if (ID.Contains("RB") || ID.Contains("rb") || ID.Contains("Rb")) { uri = string.Format(Constantce.URL + "/api/properties/SearchBuilding?ID={0}", ID); value = true; }
                else if (ID.Contains("RF") || ID.Contains("rf") || ID.Contains("Rf")) { uri = string.Format(Constantce.URL + "/api/properties/SearchFlat?ID={0}", ID); value = true; }
                else if (ID.Contains("RH") || ID.Contains("rh") || ID.Contains("Rh")) { uri = string.Format(Constantce.URL + "/api/properties/SearchHouse?ID={0}", ID); value = true; }
                else if (ID.Contains("IB") || ID.Contains("ib") || ID.Contains("Ib")) { uri = string.Format(Constantce.URL + "/api/properties/Searchindbuilding?ID={0}", ID); value = true; }
                else if (ID.Contains("IH") || ID.Contains("ih") || ID.Contains("Ih")) { uri = string.Format(Constantce.URL + "/api/properties/Searchindhangar?ID={0}", ID); value = true; }
                else if (ID.Contains("LA") || ID.Contains("la") || ID.Contains("La")) { uri = string.Format(Constantce.URL + "/api/properties/Searchlandagre?ID={0}", ID); value = true; }
                else if (ID.Contains("LC") || ID.Contains("lc") || ID.Contains("Lc")) { uri = string.Format(Constantce.URL + "/api/properties/Searchlandcom?ID={0}", ID); value = true; }
                else if (ID.Contains("LI") || ID.Contains("li") || ID.Contains("Li")) { uri = string.Format(Constantce.URL + "/api/properties/Searchlandind?ID={0}", ID); value = true; }
                else if (ID.Contains("LR") || ID.Contains("lr") || ID.Contains("Lr")) { uri = string.Format(Constantce.URL + "/api/properties/Searchlandres?ID={0}", ID); value = true; }
                else if (ID.Contains("CR") || ID.Contains("cr") || ID.Contains("Cr")) { uri = string.Format(Constantce.URL + "/api/properties/Searchcomshowroom?ID={0}", ID); value = true; }
                else if (ID.Contains("CO") || ID.Contains("co") || ID.Contains("Co")) { uri = string.Format(Constantce.URL + "/api/properties/Searchcomoffice?ID={0}", ID); value = true; }
                else if (ID.Contains("CS") || ID.Contains("cs") || ID.Contains("Cs")) { uri = string.Format(Constantce.URL + "/api/properties/Searchcomshop?ID={0}", ID); value = true; }
                else if (ID.Contains("CB") || ID.Contains("cb") || ID.Contains("Cb")) { uri = string.Format(Constantce.URL + "/api/properties/Searchcombuilding?ID={0}", ID); value = true; }
                if (value == true)
                {
                    HttpWebRequest request = WebRequest.Create(uri) as HttpWebRequest;
                    using (HttpWebResponse response = request.GetResponse() as HttpWebResponse)
                    {
                        StreamReader reader = new StreamReader(response.GetResponseStream());
                        string Data = reader.ReadToEnd();
                        ObservableCollection<PropertyModel> property = JsonConvert.DeserializeObject<ObservableCollection<PropertyModel>>(Data);
                        if (property.Count != 0)
                        {
                            PropertyModel PropertyID = property.FirstOrDefault();
                            PropertyID.AllPhotos = PropertyID.Photos;
                            PropertyID.AllPhotos.Add(PropertyID.PhotoQ);
                            if (PropertyID.PhotoQ2 != null) { PropertyID.AllPhotos.Add(PropertyID.PhotoQ2); }
                            if (PropertyID.PhotoQ3 != null) { PropertyID.AllPhotos.Add(PropertyID.PhotoQ3); }
                            if (PropertyID.PhotoQ4 != null) { PropertyID.AllPhotos.Add(PropertyID.PhotoQ4); }
                            if (PropertyID.PhotoQ5 != null) { PropertyID.AllPhotos.Add(PropertyID.PhotoQ5); }
                            if (PropertyID.PhotoQ6 != null) { PropertyID.AllPhotos.Add(PropertyID.PhotoQ6); }
                            if (PropertyID.PhotoQ7 != null) { PropertyID.AllPhotos.Add(PropertyID.PhotoQ7); }
                            if (PropertyID.PhotoQ8 != null) { PropertyID.AllPhotos.Add(PropertyID.PhotoQ8); }
                            if (PropertyID.PhotoQ9 != null) { PropertyID.AllPhotos.Add(PropertyID.PhotoQ9); }
                            if (PropertyID.PhotoQ10 != null) { PropertyID.AllPhotos.Add(PropertyID.PhotoQ10); }
                            if (PropertyID.PhotoQ11 != null) { PropertyID.AllPhotos.Add(PropertyID.PhotoQ11); }
                            if (PropertyID.PhotoQ12 != null) { PropertyID.AllPhotos.Add(PropertyID.PhotoQ12); }
                            await Navigation.PushAsync(new PropertyProfile(PropertyID));
                            await PopupNavigation.Instance.PopAsync();
                        }
                        else
                        {
                            UserDialogs.Instance.HideLoading();
                            if (Application.Current.Properties["Language"].ToString() == "Arabic")
                            {
                                IDEntry.Text = "";
                                IDEntry.Placeholder = "يرجى ادخال رقم العقار الصحيح";
                                IDEntry.PlaceholderColor = Color.Red;
                            }
                            else
                            {
                                IDEntry.Text = "";
                                IDEntry.Placeholder = "Please Enter a valid Property ID";
                                IDEntry.PlaceholderColor = Color.Red;
                            }
                        }
                    }
                    UserDialogs.Instance.HideLoading();
                }
                else
                {
                    UserDialogs.Instance.HideLoading();
                    if (Application.Current.Properties["Language"].ToString() == "Arabic")
                    {
                        IDEntry.Text = "";
                        IDEntry.Placeholder = "يرجى ادخال رقم العقار الصحيح";
                        IDEntry.PlaceholderColor = Color.Red;
                    }
                    else
                    {
                        IDEntry.Text = "";
                        IDEntry.Placeholder = "Please Enter a valid Property ID";
                        IDEntry.PlaceholderColor = Color.Red;
                    }
                }
            }
            else
            {
                if (Application.Current.Properties["Language"].ToString() == "Arabic")
                {
                    IDEntry.Text = "";
                    IDEntry.Placeholder = "يرجى ادخال رقم العقار";
                    IDEntry.PlaceholderColor = Color.Red;
                }
                else
                {
                    IDEntry.Text = "";
                    IDEntry.Placeholder = "Please Enter Property ID";
                    IDEntry.PlaceholderColor = Color.Red;
                }
            }
        }
    }
}