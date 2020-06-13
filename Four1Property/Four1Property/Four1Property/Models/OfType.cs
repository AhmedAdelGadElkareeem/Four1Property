using DLToolkit.Forms.Controls.Helpers.FlowListView;
using System;
using System.Collections.Generic;
using System.Text;

namespace Four1Property.Models
{
    [Preserve]
    public class OfType : Base
    {
        public int ID { get; set; }
        //[Display(Name = "AgentID")]
        public string AgentID { get; set; }
        public int? OrganizationID { get; set; }
        ////[Required]
        //[StringLength(50, ErrorMessage = "Type Title cannot be longer than 50 characters.")]
        //[Display(Name = "Title")]
        public string Title { get; set; }
        public string TitleAR { get; set; }

        //[DataType(DataType.ImageUrl)]
        //[Display(Name = "Image File")]
        public string ImageFile { get; set; }

        public double? ImageSize { get; set; }

        //[StringLength(250)]
        //[DataType(DataType.MultilineText)]
        //[Display(Name = "Description")]
        public string Description { get; set; }

        //[DataType(DataType.DateTime)]
        //[Display(Name = "Last Edit")]
        public DateTime? LastEdit { get; set; }

        //[ForeignKey("OrganizationID")]
        public virtual Organization Organization { get; set; }
        //[ForeignKey("AgentID")]
    }
}
