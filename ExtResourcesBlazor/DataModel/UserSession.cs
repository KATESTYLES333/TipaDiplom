using System;
using System.Collections.Generic;

namespace DataModel
{
    public partial class UserSession
    {
        public string UserId { get; set; }
        public DateTime Date { get; set; }
        public string Url { get; set; }
    }
}
