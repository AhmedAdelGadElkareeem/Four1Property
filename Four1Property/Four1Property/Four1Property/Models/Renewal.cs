using DLToolkit.Forms.Controls.Helpers.FlowListView;
using System;
using System.Collections.Generic;
using System.Text;

namespace Four1Property.Models
{
    [Preserve]
    public class Renewal : Base
    {
        public int ID { get; set; }

        //[Required]
        public int PropertyID { get; set; }
        public int? OrganizationID { get; set; }
        //[Required]
        //[StringLength(300)]
        //[DataType(DataType.MultilineText)]
        //[Display(Name = "Description")]
        public string Description { get; set; }

        //[Required]
        //[DataType(DataType.Currency)]
        //[Display(Name = "Price")]
        public double Price { get; set; }

        //[Required]
        //[Display(Name = "Status")]
        public ReStatus? Status { get; set; }

        //[Required]
        //[DataType(DataType.Date)]
        //[DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        //[Display(Name = "Dated")]
        public DateTime Dated { get; set; }

        //[DataType(DataType.DateTime)]
        //[Display(Name = "Last Edit")]
        public DateTime? LastEdit { get; set; }

        public virtual Property Property { get; set; }
        //[ForeignKey("OrganizationID")]
        public virtual Organization Organization { get; set; }
    }

    public enum ReStatus
    {
        Active,
        Inactive,
        Blocked,
        Expired
    }
}
