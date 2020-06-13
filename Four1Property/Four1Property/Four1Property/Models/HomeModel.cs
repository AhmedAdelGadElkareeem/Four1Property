using DLToolkit.Forms.Controls.Helpers.FlowListView;
using System;
using System.Collections.Generic;
using System.Text;

namespace Four1Property.Models
{
    [Preserve]
    public class HomeModel
    {
        public int SaleOrRent { get; set; }

        public string Category { get; set; }

        public int SubCategory { get;set; }

    }
    public enum TypeSaleOrRent
    {
        sale,
        rent
    }
}
