using DLToolkit.Forms.Controls.Helpers.FlowListView;
using System;
using System.Collections.Generic;
using System.Text;

namespace Four1Property.Models
{
    [Preserve]
    public class Registration
    { 
        public string Email { get; set; }
        public string LastName { get; set; }
        public string FirstName { get; set; }
        public string BirthDate { get; set; }
        public string Phone { get; set; }
        public string Country { get; set; }
        public string City { get; set; }
        public string Postal { get; set; }
        public string Password { get; set; }
        public string ConfirmPassword { get; set; }
    }
}
