using DLToolkit.Forms.Controls.Helpers.FlowListView;
using Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Four1Property.Models
{
    [Preserve]
    public class Ad : Base
    {
        public int ID { get; set; }

        public string AdminID { get; set; }

        public int? OrderID { get; set; }

        public int? OrganizationID { get; set; }

        public int Price { get; set; }
        public TFEnum? P1Check { get; set; }
        public TFEnum? P2Check { get; set; }
        public TFEnum? P3Check { get; set; }
        public TFEnum? P4Check { get; set; }
        //public int PageNumberID { get; set; }

        public int? PageNumber1 { get; set; }
        public int? PageNumber2 { get; set; }
        public int? PageNumber3 { get; set; }
        public int? PageNumber4 { get; set; }


        public int? PageSection1 { get; set; }
        public int? PageSection2 { get; set; }
        public int? PageSection3 { get; set; }
        public int? PageSection4 { get; set; }

        public AdStatus AdStatus { get; set; }

        public string Title { get; set; }


        public string TitleAR { get; set; }

        public Featured? Featured { get; set; }
        public int? Priorety { get; set; }


        public DateTime DateFrom { get; set; }


        public DateTime DateTo { get; set; }

        public AcceptStatus? AdminStatus { get; set; }

        public DateTime? LastEdit { get; set; }

        public DateTime? PublishOn { get; set; }
        public virtual ICollection<AdsPhoto> AdsPhotosR { get; set; }
        public virtual AdsPhoto AdsPhoto { get; set; }
        public virtual AdsPhoto AdsPhoto2 { get; set; }
        public virtual AdsPage AdsPage1 { get; set; }
        public virtual AdsPage AdsPage2 { get; set; }
        public virtual AdsPage AdsPage3 { get; set; }

        public virtual Organization Organization { get; set; }

        public virtual Order Order { get; set; }


    }

    public enum AdDuration
    {
        Hours_24 = 1,
        Days_2 = 2,
        Days_3 = 3,
        Week = 7
    }

    public enum AdStatus
    {
        Active,
        Inactive,
        Expired,
        Promotion
    }
    public enum TFEnum
    {
        Yes,
        No
    }
}
