using System;
using System.Collections.Generic;

namespace DataModel
{
    public partial class ResourceRates
    {
        public Guid Id { get; set; }
        public Guid ResourceId { get; set; }
        public decimal RateIn { get; set; }
        public decimal RateOut { get; set; }
        public DateTime DateStart { get; set; }
        public DateTime? DateTill { get; set; }
        public string Currency { get; set; }
        public string Notes { get; set; }
        public bool? IsSpecial { get; set; }
    }
}
