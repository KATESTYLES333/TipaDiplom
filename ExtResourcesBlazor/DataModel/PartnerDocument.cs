using System;
using System.Collections.Generic;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace DataModel
{
    public partial class PartnerDocument
    {
        public Guid Id { get; set; }
        public Guid PartnerId { get; set; }
        public Guid DocumentId { get; set; }
        public string Notes { get; set; }

        [JsonIgnore]
        public virtual Document Document { get; set; }
        [JsonIgnore]
        public virtual Partner Partner { get; set; }
    }
}
