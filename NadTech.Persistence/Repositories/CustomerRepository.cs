using NadTech.Core.Entities;
using NadTech.Core.Repositories;
using NadTech.Data;

namespace NadTech.Persistence.Repositories
{
    public class CustomerRepository : Repository<Customer>, ICustomerRepository
    {
        public CustomerRepository(NadTechCustomerDbContext context) : base(context)
        {
        }
    }
}
