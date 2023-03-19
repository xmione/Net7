using System.ComponentModel.DataAnnotations;

namespace ContactInfoManagementSystem.Models
{
    public class ContactInfo
    {
        [Key]
        public Guid Id { get; set; }
        public string? EmailAddresses { get; set; }
        public string? DeliveryAddress { get; set; }
        public string? BillingAddress { get; set; }
        public string? WorkPhone { get; set; }
        public string? HomePhone { get; set; }
        public string? MobilePhone { get; set; }
    }
}
