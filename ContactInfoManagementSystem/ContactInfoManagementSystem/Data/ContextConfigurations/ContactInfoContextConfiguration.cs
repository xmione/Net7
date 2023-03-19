using ContactInfoManagementSystem.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
namespace ContactInfoManagementSystem.Data.ContextConfigurations
{
    public class ContactInfoContextConfiguration : IEntityTypeConfiguration<ContactInfo>
    {
        private Guid[] _ids;

        public ContactInfoContextConfiguration(Guid[] ids)
        {
            _ids = ids;
        }

        public void Configure(EntityTypeBuilder<ContactInfo> builder)
        {
            builder
                .HasData(
                    new ContactInfo
                    {
                        Id = Guid.NewGuid(),
                        BillingAddress = "BillingAddress 1",
                        DeliveryAddress = "DeliveryAddress 1",
                        EmailAddresses = "user1@test.com",
                        HomePhone = "1234564345",
                        WorkPhone = "4234452344",
                        MobilePhone = "3556351235"
                    },
                    new ContactInfo
                    {
                        Id = Guid.NewGuid(),
                        BillingAddress = "BillingAddress 2",
                        DeliveryAddress = "DeliveryAddress 2",
                        EmailAddresses = "user2@test.com",
                        HomePhone = "1234564345",
                        WorkPhone = "4234452344",
                        MobilePhone = "3556351235"
                    },
                    new ContactInfo
                    {
                        Id = Guid.NewGuid(),
                        BillingAddress = "BillingAddress 3",
                        DeliveryAddress = "DeliveryAddress 3",
                        EmailAddresses = "user3@test.com",
                        HomePhone = "1234564345",
                        WorkPhone = "4234452344",
                        MobilePhone = "3556351235"
                    },
                    new ContactInfo
                    {
                        Id = Guid.NewGuid(),
                        BillingAddress = "BillingAddress 4",
                        DeliveryAddress = "DeliveryAddress 4",
                        EmailAddresses = "user4@test.com",
                        HomePhone = "1234564345",
                        WorkPhone = "4234452344",
                        MobilePhone = "3556351235"
                    },
                    new ContactInfo
                    {
                        Id = Guid.NewGuid(),
                        BillingAddress = "BillingAddress 5",
                        DeliveryAddress = "DeliveryAddress 5",
                        EmailAddresses = "user5@test.com",
                        HomePhone = "1234564345",
                        WorkPhone = "4234452344",
                        MobilePhone = "3556351235"
                    }
                );
        }
    }
}
