using System;
using System.Collections.Generic;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace DataModel
{
    public partial class NonSolicitationType
    {
        public NonSolicitationType()
        {
            Partner = new HashSet<Partner>();
        }

        public int Id { get; set; }
        public string Name { get; set; }

        [JsonIgnore]
        public virtual ICollection<Partner> Partner { get; set; }
    }
}
