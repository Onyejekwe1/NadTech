using System.Threading;
using System.Threading.Tasks;
using AutoMapper;
using MediatR;
using NadTech.Core.Repositories;
using NadTech.Service.Queries;
using NadTech.Service.Response;

namespace NadTech.Service.Handlers.QueryHandlers
{
    public class GetCustomerByIdQueryHandler : IRequestHandler<GetCustomerByIdQuery, CustomerDto>
    {
        private readonly ICustomerRepository _customerRepository;
        private readonly IMapper _mapper;

        public GetCustomerByIdQueryHandler(ICustomerRepository customerRepository, IMapper mapper)
        {
            _customerRepository = customerRepository;
            _mapper = mapper;
        }

        public async Task<CustomerDto> Handle(GetCustomerByIdQuery request, CancellationToken cancellationToken)
        {
            var customer = await _customerRepository.FirstOrDefaultAsync(c => c.Id == request.Id);
            return _mapper.Map<CustomerDto>(customer);
        }
    }
}
