namespace GhostUI.Models
{

    public interface IContactInfo
    {
        int     Id            { get; }
        string? EmailAddresses  { get; set; }
        string? DeliveryAddress  { get; set; }
        string? BillingAddress  { get; set; }
        string? WorkPhone  { get; set; }
        string? HomePhone  { get; set; }
        string? MobilePhone  { get; set; }
    }
}
