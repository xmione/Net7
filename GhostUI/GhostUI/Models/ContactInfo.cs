using System;

namespace GhostUI.Models
{
    public class ContactInfo : IContactInfo
    {
        public int Id { get; set; }
        public string? EmailAddresses { get; set; }
        public string? DeliveryAddress { get; set; }
        public string? BillingAddress { get; set; }
        public string? WorkPhone { get; set; }
        public string? HomePhone { get; set; }
        public string? MobilePhone { get; set; }

    }
}
