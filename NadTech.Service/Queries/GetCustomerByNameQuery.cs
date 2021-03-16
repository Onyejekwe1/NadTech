using MediatR;
using NadTech.Service.Response;

namespace NadTech.Service.Queries
{
    public class GetCustomerByNameQuery : IRequest<CustomerDto>
    {
        public GetCustomerByNameQuery(string name)
        {
            Name = name;
        }
        public string Name { get; set; }    
    }
}
