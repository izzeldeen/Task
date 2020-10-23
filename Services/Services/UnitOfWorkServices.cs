using DataAcces;
using Domain;
using Repoistory.IRepository;
using Services.IServices;
using System;
using System.Collections.Generic;
using System.Text;

namespace Services.Services
{
    public class UnitOfWorkServices : IUnitOfWorkServices 
    {
        private readonly IRepository<Employee> _unitOfWorkRepo;
        private readonly StoreContext _context;

        public UnitOfWorkServices(IRepository<Employee> unitOfWorkRepo , StoreContext context)
        {
            _unitOfWorkRepo = unitOfWorkRepo;
            EmployeeService = new EmployeeServices(_unitOfWorkRepo);
            _context = context;

        }

        public IEmployeeServices EmployeeService { get;  set; }
        //public IEmployeeServices Employee { get; private set; }

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
