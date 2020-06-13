using Four1Property.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;

namespace Four1Property.Helper
{
    public class Constantce
    {
        public static string URL = "https://property1111.com";
        public static string APIName = "GetProperties";
        public static string APINameTest = "GetProperties";
        public static string City = "City";
        public static string Area = "Area";
        public static string Country = "Country";
        public static string saleorrent = "saleorrent";
        public static string CountryLang = "";
        public static string CityLang = "";
        public static string AreaLang = "";
        public static int Bed = 2;
        public static int Mapkength = 10;
        public static int listkength = 10;
        public static int Bath = 0;
        public static int Arealand = 0;
        public static int Minprice = 0;
        public static int Maxprice = 0;
        public static int adnumber = 0;
        public static HomeModel homeModelC = new HomeModel();
        public static double Lat = 0.0;
        public static ObservableCollection<PropertyModel> propertyListModel = new ObservableCollection<PropertyModel>();
        public static double lon = 0.0;
    }
}
