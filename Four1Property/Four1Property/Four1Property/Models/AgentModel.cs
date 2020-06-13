using DLToolkit.Forms.Controls.Helpers.FlowListView;
using System;
using System.Collections.Generic;
using System.Text;

namespace Four1Property.Models
{
    [Preserve]
    class AgentModel
    {
        public string AgentName { get; set; }
        public string AgentImage { get; set; }
        public string AgentRate { get; set; }
        public string AgentDetails { get; set; }
        public string AgentLocation { get; set; }
        public string AgentEmail { get; set; }
        public Int64 AgentPhone { get; set; }
        public string AgentWeb { get; set; }
    }
}
