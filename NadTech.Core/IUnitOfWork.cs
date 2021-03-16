using System;
using System.Threading.Tasks;
using NadTech.Core.Repositories;

namespace NadTech.Core
{
    public interface IUnitOfWork : IDisposable
    {
        ICustomerRepository CustomerRepository { get; }
        Task BeginAsync();
        Task CommitAsync();
        void Rollback();
        Task<int> Complete();   
    }
}
