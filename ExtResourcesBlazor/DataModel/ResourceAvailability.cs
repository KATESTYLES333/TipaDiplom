using System;
using System.Collections.Generic;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace DataModel
{
    public partial class ResourceAvailability
    {
        public Guid Id { get; set; }
        public Guid ResourceId { get; set; }
        public DateTime? AvailableFrom { get; set; }
        public DateTime? AvailableTill { get; set; }
        public DateTime? VacationFrom { get; set; }
        public DateTime? VacationTill { get; set; }
        public string Notes { get; set; }

        [JsonIgnore]
        public virtual Resource Resource { get; set; }
    }
}
