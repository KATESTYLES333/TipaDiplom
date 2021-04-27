using System;
using System.Collections.Generic;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace DataModel
{
    public partial class Resource
    {
        public Resource()
        {
            RequestResource = new HashSet<RequestResource>();
            ResourceAvailability = new HashSet<ResourceAvailability>();
            ResourceDocument = new HashSet<ResourceDocument>();
            ResourceFeedback = new HashSet<ResourceFeedback>();
            ResourceWithRate = new HashSet<ResourceWithRate>();
        }

        public Guid Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public Guid? PartnerId { get; set; }
        public string Title { get; set; }
        public string About { get; set; }
        public string Technologies { get; set; }
        public int? LevelDeclared { get; set; }
        public bool? EnglishSpoken { get; set; }
        public string EnglishFeedback { get; set; }
        public bool? Available { get; set; }
        public string CvtoolLinkMaster { get; set; }
        public DateTime? Added { get; set; }
        public DateTime? Updated { get; set; }

        public virtual ResourceLevel LevelDeclaredNavigation { get; set; }
        [JsonIgnore]
        public virtual Partner Partner { get; set; }
        [JsonIgnore]
        public virtual ICollection<RequestResource> RequestResource { get; set; }
        [JsonIgnore]
        public virtual ICollection<ResourceAvailability> ResourceAvailability { get; set; }
        [JsonIgnore]
        public virtual ICollection<ResourceDocument> ResourceDocument { get; set; }
        [JsonIgnore]
        public virtual ICollection<ResourceFeedback> ResourceFeedback { get; set; }
        [JsonIgnore]
        public virtual ICollection<ResourceWithRate> ResourceWithRate { get; set; }
    }
}
