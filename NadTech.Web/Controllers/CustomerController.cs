using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using NadTech.Service.Commands;
using NadTech.Service.Queries;
using NadTech.Service.Response;

namespace NadTech.Web.Controllers
{
    public class CustomerController : BaseController
    {
        private readonly IMapper _mapper;

        public CustomerController(IMapper mapper)
        {
            _mapper = mapper;
        }

        [HttpGet("customers/all")]
        [ProducesResponseType(typeof(List<CustomerDto>), StatusCodes.Status200OK)]
        public async Task<IActionResult> GetAllCustomers()
        {
            var query = new GetAllCustomersQuery();
            var result = await Mediator.Send(query);
            return Ok(result);
        }

        [HttpGet("customer/{id:guid}", Name = "GetCustomerById")]
        [ProducesResponseType(typeof(CustomerDto), StatusCodes.Status200OK)]
        public async Task<IActionResult> GetCustomerById(Guid id)   
        {
            var result = await Mediator.Send(new GetCustomerByIdQuery(id));

            return Ok(result);
        }

        [HttpGet("customer/{name}", Name = "GetCustomerByName")]
        [ProducesResponseType(typeof(CustomerDto), StatusCodes.Status200OK)]
        public async Task<IActionResult> GetCustomerByName(string name)
        {
            var result = await Mediator.Send(new GetCustomerByNameQuery(name));

            return Ok(result);
        }

        [HttpDelete("customer/{id}", Name = "DeleteCustomer")]
        public async Task<IActionResult> DeleteCustomer(Guid id)
        {
            var result = await Mediator.Send(new DeleteCustomerCommand(id));

            return Ok(result);
        }

        [HttpPut("customer/update", Name = "UpdateCustomer")]
        public async Task<IActionResult> UpdateCustomer(UpdateCustomerCommand command)
        {
            var result = await Mediator.Send(command);

            return Ok(result);
        }

        [HttpPost("customer")]
        [ProducesResponseType(typeof(CustomerDto), StatusCodes.Status200OK)]
        public async Task<IActionResult> CreateCustomer(CreateCustomerCommand command)  
        {
            var result = await Mediator.Send(command);
            return Ok(result);
        }

    }
}
