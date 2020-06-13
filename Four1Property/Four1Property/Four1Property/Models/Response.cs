using DLToolkit.Forms.Controls.Helpers.FlowListView;
using System;
using System.Collections.Generic;
using System.Text;

namespace Four1Property.Models
{
    [Preserve]
    public class Response : Base
    {
        public int ID { get; set; }

        //[Required]
        public int RequestID { get; set; }

        //[Display(Name = "AgentID")]
        public string AgentID { get; set; }
        public int? OrganizationID { get; set; }
        //[Required]
        //[StringLength(90, ErrorMessage = "Reponse Title cannot be longer than 90 characters.")]
        //[Display(Name = "Title")]
        public string Title { get; set; }

        //[Required]
        //[StringLength(250)]
        //[DataType(DataType.MultilineText)]
        //[Display(Name = "Description")]
        public string Description { get; set; }

        //[Required]
        //[DataType(DataType.Date)]
        //[DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        //[Display(Name = "Response On")]
        public DateTime ResponseOn { get; set; }

        //[Required]
        //[Display(Name = "Response Status")]
        public ResponseStatus? ResponseStatus { get; set; }

        //[DataType(DataType.DateTime)]
        //[Display(Name = "Last Edit")]
        public DateTime? LastEdit { get; set; }

        //[ForeignKey("AgentID")]
        public virtual Request Request { get; set; }
        //[ForeignKey("OrganizationID")]
        public virtual Organization Organization { get; set; }
    }

    public enum ResponseStatus
    {
        Agree,
        Disagree
    }
}
