using System;
using System.Collections.Generic;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace DataModel
{
    public partial class EngagementOfPartner
    {
        public Guid Id { get; set; }
        public Guid ResourceWithRateId { get; set; }
        public string ProjectCode { get; set; }
        public string ProjectJira { get; set; }
        public string AccountManagerId { get; set; }
        public string ProjectManagerId { get; set; }
        public DateTime DateStart { get; set; }
        public DateTime? DateFinish { get; set; }
        public string Notes { get; set; }
        public int? PaymentId { get; set; }

        public virtual PaymentWay Payment { get; set; }
        [JsonIgnore]
        public virtual ResourceWithRate ResourceWithRate { get; set; }
    }
}
