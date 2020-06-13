using Four1Property.Models;
using System;
using System.Collections.ObjectModel;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Four1Property.View
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class Tapped : TabbedPage
	{
		public Tapped (ObservableCollection<Property> properties, HomeModel homeModel , double lon , double lat , ObservableCollection<Ad>ads)
		{
            try
            {
                InitializeComponent();
                if (Application.Current.Properties["Language"].ToString() == "Arabic")
                {
                    this.Title = "العقارات المتاحة";
                    this.FlowDirection = FlowDirection.RightToLeft;
                }
                else
                {
                    this.Title = "Properties Found";
                    this.FlowDirection = FlowDirection.LeftToRight;
                }
                this.Children.Add(new AcquaintanceList(properties, homeModel, lon, lat, ads));
                this.Children.Add(new MapView(properties, homeModel));
            }
            catch (Exception ex)
            {
                string er = ex.Message;
            }
		}
	}
}