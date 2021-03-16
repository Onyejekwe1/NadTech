using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using NadTech.Core.Entities;
using NadTech.Core.Enums_and_Constants;

namespace NadTech.Data
{
    public class CustomerInitialSeed : IEntityTypeConfiguration<Customer>
    {
        public void Configure(EntityTypeBuilder<Customer> builder)
        {
            var customer = new List<Customer>
            {
                new Customer
                {
                    Id = Guid.NewGuid(),
                    Gender = Enums.Gender.Female,
                    Age = DateTime.Now.AddYears(-30),
                    FirstName = "Jane",
                    LastName = "Doe",
                    AddressId = 1
                },
                new Customer
                {
                    Id = Guid.NewGuid(),
                    Gender = Enums.Gender.Male,
                    Age = DateTime.Now.AddYears(-23),
                    FirstName = "Bash",
                    LastName = "Ali",
                    AddressId = 2
                },
                new Customer
                {
                    Id = Guid.NewGuid(),
                    Gender = Enums.Gender.Male,
                    Age = DateTime.Now.AddYears(-18),
                    FirstName = "Shina",
                    LastName = "Peters",
                    DateCreated = DateTime.Now.AddYears(-5),
                    AddressId = 3
                },
                new Customer
                {
                    Id = Guid.NewGuid(),
                    Gender = Enums.Gender.Male,
                    Age = DateTime.Now.AddYears(-35),
                    FirstName = "Victor",
                    LastName = "Ifeanyi",
                    AddressId = 4
                }
            };

            builder.HasData(customer);
        }
    }
}
