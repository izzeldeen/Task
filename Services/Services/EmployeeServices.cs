using Domain;
using Repoistory.IRepository;
using Repoistory.Repository;
using Services.IServices;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace Services.Services
{
   public  class EmployeeServices : Services<Employee>, IEmployeeServices
    {
        private readonly IUnitOfWork _unitOfWork;
        public EmployeeServices(IUnitOfWork unitOfWork) 
        {
            _unitOfWork = unitOfWork; 
        }

        public void Add(Employee entity)
        {
            _unitOfWork.Employee.Add(entity);

        }

        public Employee get(int Id)
        {
           return _unitOfWork.Employee.get(Id);
        }

        public IEnumerable<Employee> GetAll(Expression<Func<Employee, bool>> filter = null)
        {
          return   _unitOfWork.Employee.GetAll(filter);
        }

        

        public void Remove(Employee entity)
        {
            _unitOfWork.Employee.Remove(entity);
        }

        public void Remove(int Id)
        {
            var entity = _unitOfWork.Employee.get(Id);
            _unitOfWork.Employee.Remove(entity);
        }

        public void RemoveRange(IEnumerable<Employee> entity)
        {
            _unitOfWork.Employee.RemoveRange(entity);
        }

        public void Update(Employee entity)
        {
           _unitOfWork.Employee.Update(entity);
        }
    }
}
