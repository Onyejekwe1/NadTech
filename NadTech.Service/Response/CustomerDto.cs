using System;
using NadTech.Core.Entities;
using NadTech.Core.Enums_and_Constants;
using NadTech.Service.MappingConfig;

namespace NadTech.Service.Response
{
    public class CustomerDto : IMap<Customer>
    {
        
        public Guid Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }    
        public DateTime Age { get; set; }
        public Enums.Gender Gender { get; set; }
        public int AddressId { get; set; }
    }
}
