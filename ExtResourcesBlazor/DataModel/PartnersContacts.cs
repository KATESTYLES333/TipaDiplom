using System;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace DataModel
{
    public partial class PartnersContacts
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public Guid? PrimaryContact { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Position { get; set; }
        public int? Rating { get; set; }
        public string Description { get; set; }
        public string Technologies { get; set; }
        public string Location { get; set; }
        public string BillingAddress { get; set; }
        public DateTime? Ndadate { get; set; }
        public int? Ndayears { get; set; }
        public bool? NdanonSolicitation { get; set; }
        public bool? NdanonSolicitationExtended { get; set; }
        public Guid Expr1 { get; set; }
        public string Expr2 { get; set; }
        public string Expr3 { get; set; }
        public Guid Expr4 { get; set; }
        public string Expr5 { get; set; }
        public string Expr6 { get; set; }
    }
}
