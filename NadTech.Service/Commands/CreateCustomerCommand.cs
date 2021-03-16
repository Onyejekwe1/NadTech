using System;
using MediatR;
using NadTech.Service.Response;

namespace NadTech.Service.Commands
{
    public class CreateCustomerCommand : IRequest<CustomerDto>
    {
        public Guid Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public bool IsEmployee { get; set; }
        public bool IsAffiliate { get; set; }
    }
}
