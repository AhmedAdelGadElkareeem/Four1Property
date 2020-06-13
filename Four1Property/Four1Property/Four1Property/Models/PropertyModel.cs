using DLToolkit.Forms.Controls.Helpers.FlowListView;
using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;

namespace Four1Property.Models
{
    [Preserve]
    public class PropertyModel :Base
    {
        public int ID { get; set; }
        public string IDName { get; set; }
        public string SID { get; set; }
        public string AgentID { get; set; }

        public string RightArrow { get; set; }

        public string Coomtext { get; set; }
        public string Wishtext { get; set; }
        public string Coomcolor { get; set; }
        public string Wishcolor { get; set; }
        public string Coomtcolor { get; set; }
        public string Wishtcolor { get; set; }

        public string LeftArrow { get; set; }

        public int AddressID { get; set; }

        public int OfTypeID { get; set; }

        public int? OrganizationID { get; set; }

        public int OfSubType { get; set; }

        public string Title { get; set; }
        public string Phone { get; set; }
        public string Review { get; set; }
        public string Color { get; set; }
        public string StatusLang { get; set; }
        public string TypeLang { get; set; }

        public string TitleAR { get; set; }

        public string Seller { get; set; }

        public string SellerAR { get; set; }

        public string Locality { get; set; }
        public string Photo { get; set; }

        public string AddressLAng { get; set; }


        public string LocalityAR { get; set; }

        public double? CoveredAreaMeasurement { get; set; }

        public AreaUnits? CoveredAreaUnits { get; set; }

        public double? BuildingArea { get; set; }

        public Condition? Condition { get; set; }

        public Furnished? Furnished { get; set; }

        public int? Stories { get; set; }

        public int? FloorNo { get; set; }

        public Flooring? Flooring { get; set; }

        public int? Baths { get; set; }

        public Kitchen? Kitchens { get; set; }

        public int? Beds { get; set; }

        public double? LandArea { get; set; }

        public int? LivingRooms { get; set; }

        public int? NumberOfRooms { get; set; }

        public int? StoreRooms { get; set; }

        public int? ServantQuarters { get; set; }

        public bool? Ad { get; set; }

        public Lawn? Lawn { get; set; }

        public CarSpaces? CarSpaces { get; set; }

        public MaidsRoom? MaidsRoom { get; set; }

        public DryCleanRoom? DryCleanRoom { get; set; }

        public Gym? Gym { get; set; }
        public Pool? Pool { get; set; }

        public Balcony? Balcony { get; set; }

        public AirConditioning? AirConditioning { get; set; }

        public StorageRoom? StorageRoom { get; set; }

        public int? Build { get; set; }

        public double AreaMeasurement { get; set; }

        public AreaUnits AreaUnits { get; set; }

        public double AreaDiLength { get; set; }

        public double AreaDiWidth { get; set; }

        public int Price { get; set; }

        public bool? LogedIN { get; set; }

        public For? For { get; set; }

        public Availability? Availability { get; set; }

        public int? Views { get; set; }

        public Status? Status { get; set; }

        public int? Discount { get; set; }

        public Featured? Featured { get; set; }

        public int? Flags { get; set; }

        public DateTime? PublishOn { get; set; }

        public DateTime? DateFrom { get; set; }

        public DateTime? DateTo { get; set; }

        public DateTime? LastEdit { get; set; }
        public bool? Bath{get; set;}
        public bool? Bed{get; set;}
        public bool? Floor{get; set;}
        public bool? Area{get; set;}
        public bool? Living{get; set;}
        public bool? ArrowPhoto{get; set;}

        public PromoteStatus? OrderStatus { get; set; }

        public AcceptStatus? PaymentStatus { get; set; }

        public AcceptStatus? AccountantStatus { get; set; }

        public AcceptStatus? AdminStatus { get; set; }

        //public virtual ICollection<Compare> Compare { get; set; }
        //public virtual ICollection<Wishlist> Wishlist { get; set; }
        public virtual ICollection<Request> Requests { get; set; }
        public virtual ICollection<Photo> AllPhotos { get; set; }
        public virtual ICollection<Photo> Photos { get; set; }
        public virtual Photo PhotosQ { get; set; }
        public virtual Photo PhotoQ { get; set; }
        public virtual Photo PhotoQ1 { get; set; }
        public virtual Photo PhotoQ2 { get; set; }
        public virtual Photo PhotoQ3 { get; set; }
        public virtual Photo PhotoQ4 { get; set; }
        public virtual Photo PhotoQ5 { get; set; }
        public virtual Photo PhotoQ6 { get; set; }
        public virtual Photo PhotoQ7 { get; set; }
        public virtual Photo PhotoQ8 { get; set; }
        public virtual Photo PhotoQ9 { get; set; }
        public virtual Photo PhotoQ10 { get; set; }
        public virtual Photo PhotoQ11 { get; set; }
        public virtual Photo PhotoQ12 { get; set; }

        public virtual ICollection<Renewal> Renewals { get; set; }
        public virtual Address Address { get; set; }

        public virtual ICollection<Feature> Features { get; set; }
        public virtual ICollection<Feedback> Feedbacks { get; set; }
        public virtual OfType OfType { get; set; }
        public virtual ICollection<Review> Reviews { get; set; }

        public virtual Organization Organization { get; set; }
    }
    
}
