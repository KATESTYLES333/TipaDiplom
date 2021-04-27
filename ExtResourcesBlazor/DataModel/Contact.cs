using System;
using System.Collections.Generic;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace DataModel
{
    public partial class Contact
    {
        public Contact()
        {
            EngagementOfOwn = new HashSet<EngagementOfOwn>();
        }

        public Guid Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Position { get; set; }
        public string Skype { get; set; }
        public string Telegram { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
        public string Notes { get; set; }
        public Guid? PartnerId { get; set; }
        public DateTime? DateOfBirth { get; set; }
        public int? PreferredWayOfCommunication { get; set; }
        public string Gender { get; set; }

        public virtual Partner Partner { get; set; }
        public virtual WayOfCommunication PreferredWayOfCommunicationNavigation { get; set; }
        [JsonIgnore]        
        public virtual ICollection<EngagementOfOwn> EngagementOfOwn { get; set; }
    }
}
