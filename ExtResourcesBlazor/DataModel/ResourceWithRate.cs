using System;
using System.Collections.Generic;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace DataModel
{
    public partial class ResourceWithRate
    {
        public ResourceWithRate()
        {
            EngagementOfOwn = new HashSet<EngagementOfOwn>();
            EngagementOfPartner = new HashSet<EngagementOfPartner>();
            RequestResource = new HashSet<RequestResource>();
        }

        public Guid Id { get; set; }
        public Guid? PartnerResourceId { get; set; }
        public string ScnSoftResourceAccountId { get; set; }
        public decimal RateIn { get; set; }
        public decimal RateOut { get; set; }
        public DateTime DateStart { get; set; }
        public DateTime? DateTill { get; set; }
        public string Currency { get; set; }
        public string Notes { get; set; }
        public bool? IsSpecial { get; set; }
        public string CvtoolLinkSnapshot { get; set; }

        [JsonIgnore]
        public virtual Resource PartnerResource { get; set; }
        [JsonIgnore]
        public virtual ICollection<EngagementOfOwn> EngagementOfOwn { get; set; }
        [JsonIgnore]
        public virtual ICollection<EngagementOfPartner> EngagementOfPartner { get; set; }
        public virtual ICollection<RequestResource> RequestResource { get; set; }
    }
}
