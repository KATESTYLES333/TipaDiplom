using System;
using System.Collections.Generic;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace DataModel
{
    public partial class ResourceLevel
    {
        public ResourceLevel()
        {
            Request = new HashSet<Request>();
            Resource = new HashSet<Resource>();
            ResourceFeedback = new HashSet<ResourceFeedback>();
        }

        public int Id { get; set; }
        public string Name { get; set; }

        [JsonIgnore]
        public virtual ICollection<Request> Request { get; set; }
        [JsonIgnore]
        public virtual ICollection<Resource> Resource { get; set; }
        [JsonIgnore]
        public virtual ICollection<ResourceFeedback> ResourceFeedback { get; set; }
    }
}
