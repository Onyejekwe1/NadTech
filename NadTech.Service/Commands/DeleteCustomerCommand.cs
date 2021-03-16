using MediatR;
using System;
using System.Collections.Generic;
using System.Text;

namespace NadTech.Service.Commands
{
    public class DeleteCustomerCommand : IRequest<bool>
    {
        public Guid Id { get; set; }

        public DeleteCustomerCommand(Guid id)
        {
            Id = id;
        }
    }
}
