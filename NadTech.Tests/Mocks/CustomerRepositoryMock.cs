using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using Moq;
using NadTech.Core.Entities;
using NadTech.Core.Enums_and_Constants;
using NadTech.Core.Repositories;

namespace NadTech.Tests.Mocks
{
    public class CustomerRepositoryMock
    {
        public static Mock<ICustomerRepository> GetCustomerRepository()
        {
            var customers = new List<Customer>
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


            var mockedcustomerRepository = new Mock<ICustomerRepository>();
            mockedcustomerRepository.Setup(x => x.GetAllAsync()).ReturnsAsync(customers);

            mockedcustomerRepository.Setup(x => x.Add(It.IsAny<Customer>()));



            return mockedcustomerRepository;
        }
    }
}
