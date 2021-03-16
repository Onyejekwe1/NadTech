using System;

namespace NadTech.Core.Entities
{
    public class Order : BaseEntity
    {
        public DateTime OrderDate { get; set; }
        public decimal Amount { get; set; } 
        public Customer Customer { get; set; }
    }
}
