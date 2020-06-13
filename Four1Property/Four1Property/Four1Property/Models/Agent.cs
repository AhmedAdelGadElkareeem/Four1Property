
using DLToolkit.Forms.Controls.Helpers.FlowListView;
using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;

namespace Four1Property.Models
{
    [Preserve]
    public class Agent
    {
        public int? OrganizationID { get; set; }

        public string FirstName { get; set; }

        public string FirstNameAR { get; set; }

        public string LastName { get; set; }

        public string LastNameAR { get; set; }

        public string Address { get; set; }

        public string AddressAR { get; set; }

        public double Longitude { get; set; }

        public double Latitude { get; set; }

        public string City { get; set; }

        public string CityAR { get; set; }

        public string State { get; set; }

        public string StateAR { get; set; }
        public string DirictionText { get; set; }
        public string WebText { get; set; }

        // Use a sensible display name for views:
        public string PostalCode { get; set; }

        public string DisplayAddress
        {
            get
            {
                string dspAddress =
                    string.IsNullOrWhiteSpace(this.Address) ? "" : this.Address;
                string dspCity =
                    string.IsNullOrWhiteSpace(this.City) ? "" : this.City;
                string dspState =
                    string.IsNullOrWhiteSpace(this.State) ? "" : this.State;
                string dspPostalCode =
                    string.IsNullOrWhiteSpace(this.PostalCode) ? "" : this.PostalCode;

                return string
                    .Format("{0} {1} {2} {3}", dspAddress, dspCity, dspState, dspPostalCode);
            }
        }

        public string DisplayAddressAR
        {
            get
            {
                string dspAddressAR =
                    string.IsNullOrWhiteSpace(this.AddressAR) ? "" : this.AddressAR;
                string dspCityAR =
                    string.IsNullOrWhiteSpace(this.CityAR) ? "" : this.CityAR;
                string dspStateAR =
                    string.IsNullOrWhiteSpace(this.StateAR) ? "" : this.StateAR;
                string dspPostalCode =
                    string.IsNullOrWhiteSpace(this.PostalCode) ? "" : this.PostalCode;

                return string
                    .Format("{0} {1} {2} {3}", dspAddressAR, dspCityAR, dspStateAR, dspPostalCode);
            }
        }

        public string FullName
        {
            get
            {
                string firstName =
                    string.IsNullOrWhiteSpace(this.FirstName) ? "" : this.FirstName;
                string lastName =
                    string.IsNullOrWhiteSpace(this.LastName) ? "" : this.LastName;

                return string
                    .Format("{0} {1}", firstName, lastName);
            }
        }

        public string FullNameAR
        {
            get
            {
                string firstNameAR =
                    string.IsNullOrWhiteSpace(this.FirstNameAR) ? "" : this.FirstNameAR;
                string lastNameAR =
                    string.IsNullOrWhiteSpace(this.LastNameAR) ? "" : this.LastNameAR;

                return string
                    .Format("{0} {1}", firstNameAR, lastNameAR);
            }
        }

        // Add birth date and home town for Google Auth - P4U
        public string HomeTown { get; set; }

        public System.DateTime? BirthDate { get; set; }


        public string ProfileImage { get; set; }

        public DateTime? JoinedDate { get; set; }

        public bool? Deleted { get; set; }

        public virtual Organization Organization { get; set; }

        public virtual IEnumerable<UserRating> UserRatings { get; set; }

        public virtual IEnumerable<Review> Reviews { get; set; }

    }

}

