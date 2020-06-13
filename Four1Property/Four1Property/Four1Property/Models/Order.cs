using DLToolkit.Forms.Controls.Helpers.FlowListView;
using System;
using System.Collections.Generic;
using System.Text;

namespace Four1Property.Models
{
    [Preserve]
    public class Order : Base
    {
        public int ID { get; set; }

        ////[Required]
        //[Display(Name = "AgentID")]
        public string AgentID { get; set; }
        public int? OrganizationID { get; set; }
        ////[Required]
        //[StringLength(50, ErrorMessage = "Order Title cannot be longer than 50 characters.")]
        //[Display(Name = "Title")]
        public string Title { get; set; }

        ////[Required]
        //[StringLength(250)]
        //[DataType(DataType.MultilineText)]
        //[Display(Name = "Description")]
        public string Description { get; set; }

        ////[Required]
        //[Display(Name = "Size")]
        public Size? Size { get; set; }

        ////[Required]
        //[Display(Name = "Home Page or Internal Pages")]
        public ExternalorInternal ExternalorInternal { get; set; }

        ////[Required]
        //[DataType(DataType.ImageUrl)]
        //[Display(Name = "Image File")]
        public string ZipFilePath { get; set; }

        //[Display(Name = "Image Size")]
        public double? ZipFileSize { get; set; }


        ////[Required]
        //[DataType(DataType.Date)]
        //[DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        //[Display(Name = "Date From")]
        public DateTime DateFrom { get; set; }

        ////[Required]
        //[Display(Name = "Order Status")]
        public OrderStatus? OrderStatus { get; set; }

        //[DataType(DataType.MultilineText)]
        public string Remedies { get; set; }

        //[DataType(DataType.DateTime)]
        //[Display(Name = "Last Edit")]
        public DateTime? LastEdit { get; set; }

        //[Display(Name = "Payment Status")]
        public AcceptStatus? PaymentStatus { get; set; }

        //[Display(Name = "Accountant Status")]
        public AcceptStatus? AccountantStatus { get; set; }

        //[Display(Name = "Admin Status")]
        public AcceptStatus? AdminStatus { get; set; }

        ////[Required]
        //[DataType(DataType.Date)]
        //[DisplayFormat(HtmlEncode = false,DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        //[Display(Name = "Date To")]
        public DateTime DateTo { get; set; }

        //[ForeignKey("AgentID")]
        public virtual ICollection<Ad> Ads { get; set; }

        //[ForeignKey("OrganizationID")]
        public virtual Organization Organization { get; set; }
    }

    public enum Size
    {
        //[Display(Name = "Full Banner")]
        FullBanner,
        //[Display(Name = "Small Banner")]
        SmallBanner,
        //[Display(Name = "Square")]
        Square,
        //[Display(Name = "Fat Skyscraper")]
        FatSkyscraper
    }

    public enum ExternalorInternal
    {
        //[Display(Name = "Home Page")]
        Home = 1,
        //[Display(Name = "Inner Pages")]
        Inner = 2
    }

    public enum OrderStatus
    {
        Pending,
        Process,
        Approved,
        Rejected,
        Expired,
        Deleted
    }
    public enum AcceptStatus
    {
        Pending,
        Approved
    }
}
