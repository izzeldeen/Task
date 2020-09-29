using DataAcces;
using Repoistory.IRepository;
using System;
using System.Collections.Generic;
using System.Net.Http.Headers;
using System.Text;

namespace Repoistory.Repository
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly StoreContext _context;
        public UnitOfWork(StoreContext context)
        {
            _context = context;
            Employee = new EmployeeRepository(_context);
        }


        public IEmployeeRepoistory Employee { get; private set; }

        public void Dispose()
        {
            _context.Dispose();
        }

        public void Save()
        {
            _context.SaveChanges();
        }
    }
}
