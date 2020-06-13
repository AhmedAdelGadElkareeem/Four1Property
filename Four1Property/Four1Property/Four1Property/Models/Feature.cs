using DLToolkit.Forms.Controls.Helpers.FlowListView;
using System;
using System.Collections.Generic;
using System.Text;

namespace Four1Property.Models
{
    [Preserve]
    public class Feature : Base
    {
        public int ID { get; set; }
        //[Display(Name = "AgentID")]
        public string AgentID { get; set; }

        public int? OrganizationID { get; set; }
        ////[Required]
        //[StringLength(50, ErrorMessage = "Feature Title cannot be longer than 50 characters.")]
        //[Display(Name = "Title")]
        public string Title { get; set; }

        //[DataType(DataType.ImageUrl)]
        //[Display(Name = "Image Icon")]
        public string ImageIcon { get; set; }

        public double? ImageSize { get; set; }

        ////[Required]
        //[StringLength(250)]
        //[DataType(DataType.MultilineText)]
        //[Display(Name = "Description")]
        public string Description { get; set; }

        //[DataType(DataType.DateTime)]
        //[Display(Name = "Last Edit")]
        public DateTime? LastEdit { get; set; }

        // Ignore because of Many to Many relation cause exception for Json (Properties/Features) requests.
        //[JsonIgnore]
        //[IgnoreDataMember] 
        public virtual ICollection<Property> Properties { get; set; }

        //[ForeignKey("OrganizationID")]
        public virtual Organization Organization { get; set; }

        //[ForeignKey("AgentID")]
    }
}
