using System;
using System.Threading;
using System.Threading.Tasks;
using AutoMapper;
using MediatR;
using NadTech.Core;
using NadTech.Core.Entities;
using NadTech.Core.Repositories;
using NadTech.Service.Commands;
using NadTech.Service.Response;

namespace NadTech.Service.Handlers.CommandHandlers
{
    public class CreateCustomerCommandHandler : IRequestHandler<CreateCustomerCommand, CustomerDto>
    {
        private readonly ICustomerRepository _customerRepository;
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;

        public CreateCustomerCommandHandler(ICustomerRepository customerRepository, IUnitOfWork unitOfWork, IMapper mapper)
        {
            _customerRepository = customerRepository;
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }

        public async Task<CustomerDto> Handle(CreateCustomerCommand request, CancellationToken cancellationToken)
        {
            try
            {
                var customer = _mapper.Map<Customer>(request);

                await _unitOfWork.BeginAsync();
                _customerRepository.Add(customer);
                await _unitOfWork.Complete();

                return _mapper.Map<CustomerDto>(customer);
            }
            catch (Exception e)
            {
                _unitOfWork.Rollback();
                Console.WriteLine(e);
                throw;
            }
            
        }
    }
}
