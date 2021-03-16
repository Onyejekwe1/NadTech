using System;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore.Storage;
using NadTech.Core;
using NadTech.Core.Repositories;
using NadTech.Data;

namespace NadTech.Persistence
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly NadTechCustomerDbContext _context;
        private IDbContextTransaction _transaction;
        public UnitOfWork(ICustomerRepository customerRepository, NadTechCustomerDbContext context)
        {
            CustomerRepository = customerRepository;
            _context = context;
        }

        public ICustomerRepository CustomerRepository { get; }

        public async Task BeginAsync()
        {
            if (_transaction != null)
            {
                return;
            }

            _transaction = await _context.Database.BeginTransactionAsync().ConfigureAwait(false);
        }

        public async Task CommitAsync()
        {
            try
            {
                await Complete().ConfigureAwait(false);

                _transaction.Commit();
            }
            catch
            {
                Rollback();
                throw;
            }
            finally
            {
                if (_transaction != null)
                {
                    _transaction.Dispose();
                    _transaction = null;
                }
            }
        }

        public void Rollback()
        {
            try
            {
                _transaction.Rollback();
            }
            finally
            {
                if (_transaction != null)
                {
                    _transaction.Dispose();
                    _transaction = null;
                }
            }
        }

        public Task<int> Complete()
        {
            try
            {
               return _context.SaveChangesAsync();
            }
            catch (Exception ex)
            {
                ex.Message.ToString();
            }
            return Task.FromResult(0);
        }

        public void Dispose()
        {
           _context.Dispose();
        }
    }
}
