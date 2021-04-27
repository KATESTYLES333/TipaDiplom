using System;
using System.Collections.Generic;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace DataModel
{
    public partial class Partner
    {
        public Partner()
        {
            Contact = new HashSet<Contact>();
            EngagementOfOwn = new HashSet<EngagementOfOwn>();
            PartnerDocument = new HashSet<PartnerDocument>();
            Request = new HashSet<Request>();
            Resource = new HashSet<Resource>();
        }

        public Guid Id { get; set; }
        public string Name { get; set; }
        public int? Rating { get; set; }
        public string Description { get; set; }
        public string Technologies { get; set; }
        public string Country { get; set; }
        public string City { get; set; }
        public string BillingAddress { get; set; }
        public DateTime? NdaDate { get; set; }
        public int? NdaYears { get; set; }
        public int? NonSolicitation { get; set; }

        public virtual NonSolicitationType NonSolicitationNavigation { get; set; }
        public virtual PartnerRating RatingNavigation { get; set; }
        [JsonIgnore]        
        public virtual ICollection<Contact> Contact { get; set; }
        [JsonIgnore]        
        public virtual ICollection<EngagementOfOwn> EngagementOfOwn { get; set; }
        [JsonIgnore]        
        public virtual ICollection<PartnerDocument> PartnerDocument { get; set; }
        [JsonIgnore]        
        public virtual ICollection<Request> Request { get; set; }
        [JsonIgnore]        
        public virtual ICollection<Resource> Resource { get; set; }
    }
}
