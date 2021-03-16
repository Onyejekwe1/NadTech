using AutoMapper;
using NadTech.Core.Entities;
using NadTech.Service.Commands;
using NadTech.Service.Response;

namespace NadTech.Tests
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<Customer, CustomerDto>();
            CreateMap<CustomerDto, CreateCustomerCommand>();
            CreateMap<CreateCustomerCommand, Customer>();
        }
    }
}
