using System;
using System.Collections.Generic;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace DataModel
{
    public partial class Request
    {
        public Request()
        {
            RequestResource = new HashSet<RequestResource>();
        }

        public Guid Id { get; set; }
        public Guid? IssuerPartnerId { get; set; }
        public string IssuerAccountId { get; set; }
        public string Notes { get; set; }
        public DateTime IssuedDate { get; set; }
        public DateTime? StartDate { get; set; }
        public DateTime? EndDate { get; set; }
        public string ApproximateDuration { get; set; }
        public string Description { get; set; }
        public string Technologies { get; set; }
        public bool? EnglishSpoken { get; set; }
        public bool? IsActive { get; set; }
        public string FinalNotes { get; set; }
        public string LinkJira { get; set; }
        public string LinkCollab { get; set; }
        public int? ResourceLevel { get; set; }

        [JsonIgnore]
        public virtual Partner IssuerPartner { get; set; }
        public virtual ResourceLevel ResourceLevelNavigation { get; set; }
        [JsonIgnore]
        public virtual ICollection<RequestResource> RequestResource { get; set; }
    }
}
