using System;
using System.Collections.Generic;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace DataModel
{
    public partial class RequestResource
    {
        public Guid Id { get; set; }
        public Guid RequestId { get; set; }
        public Guid ResourceWithRateId { get; set; }
        public int? MatchIndex { get; set; }

        [JsonIgnore]
        public virtual Request Request { get; set; }
        [JsonIgnore]
        public virtual Resource ResourceWithRate { get; set; }
        [JsonIgnore]
        public virtual ResourceWithRate ResourceWithRateNavigation { get; set; }
    }
}
