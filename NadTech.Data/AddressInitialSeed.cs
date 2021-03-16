using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using NadTech.Core.Entities;

namespace NadTech.Data
{
    public class AddressInitialSeed : IEntityTypeConfiguration<Address>
    {
        public void Configure(EntityTypeBuilder<Address> builder)
        {
            var customer = new List<Address>
            {
                 new Address
                {
                    Id = 1,
                    DateCreated = DateTime.Now,
                    DateModified = DateTime.Now,
                    HouseNumber = 41,
                    PostCode = "112001",
                    Street = "Lawn Street"
                },
                 new Address
                 {
                     Id = 2,
                     DateCreated = DateTime.Now,
                     DateModified = DateTime.Now,
                     HouseNumber = 34,
                     PostCode = "1234201",
                     Street = "Test2 Street"
                 },
                  new Address
                 {
                     Id = 3,
                     DateCreated = DateTime.Now,
                     DateModified = DateTime.Now,
                     HouseNumber = 24,
                     PostCode = "100001",
                     Street = "Test Street"
                 },
                  new Address
                  {
                      Id = 4,
                      DateCreated = DateTime.Now,
                      DateModified = DateTime.Now,
                      HouseNumber = 24,
                      PostCode = "100001",
                      Street = "Test Street"
                  }
            };

            builder.HasData(customer);
        }
    }
}
