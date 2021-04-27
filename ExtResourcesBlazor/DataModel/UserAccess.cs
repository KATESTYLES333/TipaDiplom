using System;
using System.Collections.Generic;

namespace DataModel
{
    public partial class UserAccess
    {
        public Guid Id { get; set; }
        public string UserOrGroupId { get; set; }
        public bool? CanViewResources { get; set; }
        public bool? CanViewPartners { get; set; }
        public bool? CanViewPartnerDocuments { get; set; }
        public bool? CanViewRates { get; set; }
        public bool? CanRequest { get; set; }
        public string Notes { get; set; }
    }
}
