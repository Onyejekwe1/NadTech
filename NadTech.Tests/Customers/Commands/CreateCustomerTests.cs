using System.Threading;
using System.Threading.Tasks;
using AutoMapper;
using FluentAssertions;
using Moq;
using NadTech.Core;
using NadTech.Core.Entities;
using NadTech.Core.Repositories;
using NadTech.Service.Commands;
using NadTech.Service.Handlers.CommandHandlers;
using NadTech.Service.Response;
using NadTech.Tests.Mocks;
using Xunit;

namespace NadTech.Tests.Customers.Commands
{
    public class CreateCustomerTests
    {
        private readonly Mock<ICustomerRepository> _customerRepository;
        private readonly Mock<IUnitOfWork> _unitOfWork;
        private readonly IMapper _mapper;
        public CreateCustomerTests()
        {
            _customerRepository = CustomerRepositoryMock.GetCustomerRepository();
            _unitOfWork = new Mock<IUnitOfWork>();
            var configurationProvider = new MapperConfiguration(cfg =>
            {
                cfg.AddProfile<MappingProfile>();
            });

            _mapper = configurationProvider.CreateMapper();
        }

        [Fact]
        public async Task Handle_ValidCustomer_AddsCustomerToRepo()
        {
            var handler = new CreateCustomerCommandHandler(_customerRepository.Object, _unitOfWork.Object, _mapper);

           var result = await handler.Handle(new CreateCustomerCommand { FirstName = "Chima" }, CancellationToken.None);


            _customerRepository.Verify(x => x.Add(It.IsAny<Customer>()),Times.Once);
            result.Should().BeOfType<CustomerDto>();
        }


    }
}
