using DLToolkit.Forms.Controls.Helpers.FlowListView;
using Four1Property.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Models
{
    [Preserve]
    public class AdsPhoto
    {
        public int ID { get; set; }
        public string AgentID { get; set; }
        public int AdsID { get; set; }
        public int? OrganizationID { get; set; }

        public string PhotoTitle { get; set; }

        public string UploadedFrom { get; set; }

        public string UploadedTo { get; set; }

        public double? Size { get; set; }

        public string Extension { get; set; }

        public BannerBox BannerBox { get; set; }
       
        public DateTime? UploadedOn { get; set; }

        public DateTime? LastEdit { get; set; }

        public virtual Ad Ad { get; set; }
        public virtual Organization Organization { get; set; }
    }
    public enum BannerBox
    {
        Banner,
        Box
    }
}
