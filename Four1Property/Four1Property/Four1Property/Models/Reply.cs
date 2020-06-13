using DLToolkit.Forms.Controls.Helpers.FlowListView;
using System;
using System.Collections.Generic;
using System.Text;

namespace Four1Property.Models
{
    [Preserve]
    public class Reply : Base
    {
        public int ID { get; set; }

        //[Required]
        //[Display(Name = "AgentID")]
        public string AgentID { get; set; }

        //[Required]
        public int ReviewID { get; set; }
        public int? OrganizationID { get; set; }
        //[Required]
        //[StringLength(250)]
        //[DataType(DataType.MultilineText)]
        //[Display(Name = "Description")]
        public string Description { get; set; }

        //[Required]
        //[DataType(DataType.DateTime)]
        //[Display(Name = "Reply On")]
        public DateTime ReplyOn { get; set; }

        //[ForeignKey("AgentID")]
        public virtual Review Review { get; set; }
        //[ForeignKey("OrganizationID")]
        public virtual Organization Organization { get; set; }
    }
}
