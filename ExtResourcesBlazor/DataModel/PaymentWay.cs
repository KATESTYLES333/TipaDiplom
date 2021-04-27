using System;
using System.Collections.Generic;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace DataModel
{
    public partial class PaymentWay
    {
        public PaymentWay()
        {
            EngagementOfOwn = new HashSet<EngagementOfOwn>();
            EngagementOfPartner = new HashSet<EngagementOfPartner>();
        }

        public int Id { get; set; }
        public string Notes { get; set; }

        [JsonIgnore]
        public virtual ICollection<EngagementOfOwn> EngagementOfOwn { get; set; }
        [JsonIgnore]
        public virtual ICollection<EngagementOfPartner> EngagementOfPartner { get; set; }
    }
}
