using DLToolkit.Forms.Controls.Helpers.FlowListView;
using System;
using System.Collections.Generic;
using System.Text;

namespace Four1Property.Models
{
    [Preserve]
    public class Address : Base
    {
        public int ID { get; set; }

        public string AgentID { get; set; }

        public int? OrganizationID { get; set; }

        public string Name { get; set; }

        public string NameAR { get; set; }

        public int Number { get; set; }

        public int Floor { get; set; }

        public string AreaName { get; set; }

        public string AreaNameAR { get; set; }

        public int Block { get; set; }

        public string Street { get; set; }

        public string StreetAR { get; set; }

        public string City { get; set; }

        public string CityAR { get; set; }

        public string State { get; set; }

        public string StateAR { get; set; }

        public string Country { get; set; }

        public string CountryAR { get; set; }

        public string PostalCode { get; set; }

        public string ZipCode { get; set; }

        public double Latitude { get; set; }

        public double Longitude { get; set; }

        public DateTime? LastEdit { get; set; }

        public virtual ICollection<Property> Properties { get; set; }

        public virtual Organization Organization { get; set; }

    }
}
