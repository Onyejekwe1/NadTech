using System.Collections.Generic;
using MediatR;
using NadTech.Service.Response;

namespace NadTech.Service.Queries
{
    public class GetAllCustomersQuery : IRequest<List<CustomerDto>>
    {
    }
}
