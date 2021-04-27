using System;
using System.Collections.Generic;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace DataModel
{
    public partial class WayOfCommunication
    {
        public WayOfCommunication()
        {
            Contact = new HashSet<Contact>();
        }

        public int Id { get; set; }
        public string Name { get; set; }

        [JsonIgnore]
        public virtual ICollection<Contact> Contact { get; set; }
    }
}
