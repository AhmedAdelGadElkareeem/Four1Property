using DLToolkit.Forms.Controls.Helpers.FlowListView;
using System;
using System.Collections.Generic;
using System.Text;

namespace Four1Property.Models
{
    [Preserve]
    public class Base
    {
        public string CreatedBy { get; set; }

        public string ModifiedBy { get; set; }

        public DateTime Created { get; set; }

        public DateTime? Modified { get; set; }

        public bool? Deleted { get; set; }
    }
}
