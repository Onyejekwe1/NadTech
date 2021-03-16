using System;
using System.Collections.Generic;
using System.Text;
using MediatR;
using NadTech.Service.Response;

namespace NadTech.Service.Commands
{
    public class UpdateCustomerCommand  : IRequest<CustomerDto>
    {
        public Guid Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public bool IsEmployee { get; set; }
        public bool IsAffiliate { get; set; }
    }
}
