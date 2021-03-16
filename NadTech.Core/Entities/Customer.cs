using System;
using System.Collections.Generic;
using NadTech.Core.Enums_and_Constants;

namespace NadTech.Core.Entities
{
    public class Customer : BaseEntity
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime Age { get; set; }
        public Enums.Gender Gender  { get; set; }
        public int AddressId { get; set; }  
        public virtual Address Address { get; set; }
        public ICollection<Order> Orders { get; set; }
    }

    
}
