using System;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace DataModel
{
    public partial class FavoriteResource
    {
        public Guid ResourceId { get; set; }
        public string UserId { get; set; }

        public virtual Resource Resource { get; set; }
    }
}
