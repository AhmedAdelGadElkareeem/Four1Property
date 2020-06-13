using DLToolkit.Forms.Controls.Helpers.FlowListView;
using System;
using System.Collections.Generic;
using System.Text;

namespace Four1Property.Models
{
    [Preserve]
    public class Organization
    {
        public int ID { get; set; }

        ////[Required]
        //[StringLength(150, ErrorMessage = "Organization Title cannot be longer than 150 characters.")]
        //[Display(Name = "Title")]
        public string Title { get; set; }

        // Ignore because of Many to Many relation cause exception for Json (Properties/Features) requests.
        //[JsonIgnore]
        //[IgnoreDataMember]
        public virtual ICollection<Property> Properties { get; set; }
        //[JsonIgnore]
        //[IgnoreDataMember]
        public virtual ICollection<Ad> Ads { get; set; }
        //[JsonIgnore]
        //[IgnoreDataMember]
        public virtual ICollection<Address> Addresses { get; set; }
        //[JsonIgnore]
        //[IgnoreDataMember]
        public virtual ICollection<Configuration> Configurations { get; set; }
        //[JsonIgnore]
        //[IgnoreDataMember]
        public virtual ICollection<Feature> Features { get; set; }
        //[JsonIgnore]
        //[IgnoreDataMember]
        public virtual ICollection<Feedback> Feedbacks { get; set; }
        //[JsonIgnore]
        //[IgnoreDataMember]
        public virtual ICollection<OfSubType> OfSubTypes { get; set; }
        //[JsonIgnore]
        //[IgnoreDataMember]
        public virtual ICollection<OfType> OfTypes { get; set; }
        //[JsonIgnore]
        //[IgnoreDataMember]
        public virtual ICollection<Order> Orders { get; set; }
        //[JsonIgnore]
        //[IgnoreDataMember]
        public virtual ICollection<Photo> Photos { get; set; }
        //[JsonIgnore]
        //[IgnoreDataMember]
        public virtual ICollection<Renewal> Renewals { get; set; }
        //[JsonIgnore]
        //[IgnoreDataMember]
        public virtual ICollection<Reply> Replys { get; set; }
        //[JsonIgnore]
        //[IgnoreDataMember]
        public virtual ICollection<Request> Requests { get; set; }
        //[JsonIgnore]
        //[IgnoreDataMember]
        public virtual ICollection<Response> Responses { get; set; }
        //[JsonIgnore]
        //[IgnoreDataMember]
        public virtual ICollection<Review> Reviews { get; set; }
        //[JsonIgnore]
        //[IgnoreDataMember]


    }
}
