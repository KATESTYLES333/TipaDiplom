using System;
using System.Collections.Generic;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace DataModel
{
    public partial class ContactsPartners
    {
        public Guid? PartnerId { get; set; }
        public Guid Id { get; set; }
        public Guid Expr1 { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Position { get; set; }
        public string Skype { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
        public string Notes { get; set; }
        public string Name { get; set; }
    }
}
