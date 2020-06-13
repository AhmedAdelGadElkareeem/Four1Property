using DLToolkit.Forms.Controls.Helpers.FlowListView;
using Four1Property.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Models
{
    [Preserve]
    public class AdsPage
    {
        public int ID { get; set; }
        public string AgentID { get; set; }
        public int? OrganizationID { get; set; }

        public string Title { get; set; }

        public string TitleAR { get; set; }

        public DateTime? LastEdit { get; set; }
        public virtual Organization Organization { get; set; }
    }
}
