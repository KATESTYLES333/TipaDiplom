using System;
using System.Collections.Generic;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace DataModel
{
    public partial class ResourceDocument
    {
        public Guid Id { get; set; }
        public Guid ResourceId { get; set; }
        public Guid DocumentId { get; set; }
        public string Notes { get; set; }

        [JsonIgnore]
        public virtual Document Document { get; set; }
        [JsonIgnore]
        public virtual Resource Resource { get; set; }
    }
}
