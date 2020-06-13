using DLToolkit.Forms.Controls.Helpers.FlowListView;
using System;
using System.Collections.Generic;
using System.Text;

namespace Four1Property.Models
{
    [Preserve]
    public class Photo : Base
    {
        public int ID { get; set; }

        public string AgentID { get; set; }

        public string PropertyID { get; set; }

        public int? OrganizationID { get; set; }

        public string PhotoTitle { get; set; }

        public string AltText { get; set; }

        public int NumberPhoto {get; set; }

        public string Caption { get; set; }

        public string UploadedFrom { get; set; }

        public string UploadedTo { get; set; }

        public double? Size { get; set; }

        public string Extension { get; set; }

        public DateTime UploadedOn { get; set; }

        public DateTime? LastEdit { get; set; }

        public virtual Property Property { get; set; }

        public virtual Organization Organization { get; set; }
    }
}
