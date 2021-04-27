using System;
using System.Collections.Generic;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace DataModel
{
    public partial class Document
    {
        public Document()
        {
            PartnerDocument = new HashSet<PartnerDocument>();
            ResourceDocument = new HashSet<ResourceDocument>();
        }

        public Guid Id { get; set; }
        public string FileName { get; set; }
        public DateTime FileDate { get; set; }
        public int FileSize { get; set; }
        public string ContentType { get; set; }
        public byte[] ContentData { get; set; }
        public string Notes { get; set; }

        [JsonIgnore]
        public virtual ICollection<PartnerDocument> PartnerDocument { get; set; }
        [JsonIgnore]
        public virtual ICollection<ResourceDocument> ResourceDocument { get; set; }
    }
}
