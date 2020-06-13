using DLToolkit.Forms.Controls.Helpers.FlowListView;
using System;
using System.Collections.Generic;
using System.Text;

namespace Four1Property.Models
{
    [Preserve]
    public class UserRating : Base
    {
        public int RatingID { get; set; }
        public string UserID { get; set; }
        public string RateUserID { get; set; }
        public int Rate { get; set; }


    }
}
