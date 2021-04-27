using System;
using System.Collections.Generic;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace DataModel
{
    public partial class ResourceFeedback
    {
        public Guid Id { get; set; }
        public Guid ResourceId { get; set; }
        public DateTime Date { get; set; }
        public string ScnSoftAccountId { get; set; }
        public string Notes { get; set; }
        public string Position { get; set; }
        public int LevelIdentified { get; set; }

        public virtual ResourceLevel LevelIdentifiedNavigation { get; set; }
        [JsonIgnore]
        public virtual Resource Resource { get; set; }
    }
}
