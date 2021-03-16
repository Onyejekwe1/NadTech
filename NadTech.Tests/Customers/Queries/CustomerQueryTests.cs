using System;
using System.Threading;
using System.Threading.Tasks;
using AutoMapper;
using Moq;
using NadTech.Core.Repositories;
using NadTech.Service.Handlers.QueryHandlers;
using NadTech.Service.Queries;
using NadTech.Tests.Mocks;
using Xunit;

namespace NadTech.Tests.Customers.Queries
{
    public class CustomerQueryTests
    {

        private readonly Mock<ICustomerRepository> _customerRepository;
        private readonly IMapper _mapper;
        public CustomerQueryTests()
        {
            _customerRepository = CustomerRepositoryMock.GetCustomerRepository();
            var configurationProvider = new MapperConfiguration(cfg =>
            {
                cfg.AddProfile<MappingProfile>();
            });

            _mapper = configurationProvider.CreateMapper();
        }


        [Fact]
        public async Task GetAllCustomers_ReturnsAllCustomers()
        {
            var handler = new GetAllCustomersQuery();
        }

        [Fact]
        public async Task GetCustomerById_ValidId_ReturnsCustomer()
        {
            var id = Guid.Parse("B0788D2F-8003-43C1-92A4-EDC76A7C5DDE");

            var handler = new GetCustomerByIdQueryHandler(_customerRepository.Object, _mapper);

            var result = await handler.Handle(new GetCustomerByIdQuery(id), CancellationToken.None);

        }


        [Fact]
        public async Task GetCustomerById_InValidId_ReturnsNotFound()
        {
            var id = Guid.Parse("B0788D2F-8003-43C1-92A4-EDC76A7C5DDD");

            var handler = new GetCustomerByIdQueryHandler(_customerRepository.Object, _mapper);

            var result = await handler.Handle(new GetCustomerByIdQuery(id), CancellationToken.None);
        }

        [Fact]
        public async Task GetCustomerByName_ValidName_ReturnsCustomer()
        {
            var name = "John";

            var handler = new GetCustomerByNameQueryHandler(_customerRepository.Object, _mapper);

            var result = await handler.Handle(new GetCustomerByNameQuery(name), CancellationToken.None);
        }


        [Fact]
        public async Task GetCustomerByName_InValidName_ReturnsNotFound()
        {
            var name = "Kate";

            var handler = new GetCustomerByNameQueryHandler(_customerRepository.Object, _mapper);

            var result = await handler.Handle(new GetCustomerByNameQuery(name), CancellationToken.None);

        }
    }
}
