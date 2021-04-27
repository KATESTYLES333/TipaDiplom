using System;
using System.Collections.Generic;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace DataModel
{
    public partial class EngagementOfOwn
    {
        public Guid Id { get; set; }
        public Guid ResourceWithRateId { get; set; }
        public Guid PartnerId { get; set; }
        public string ProjectCode { get; set; }
        public string ProjectJira { get; set; }
        public Guid PartnerManagerId { get; set; }
        public DateTime DateStart { get; set; }
        public DateTime? DateFinish { get; set; }
        public string Notes { get; set; }
        public int? PaymentId { get; set; }

        [JsonIgnore]
        public virtual Partner Partner { get; set; }
        [JsonIgnore]
        public virtual Contact PartnerManager { get; set; }
        public virtual PaymentWay Payment { get; set; }
        [JsonIgnore]
        public virtual ResourceWithRate ResourceWithRate { get; set; }
    }
}
