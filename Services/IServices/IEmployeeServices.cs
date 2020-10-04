using Domain;
using Services.Dto;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace Services.IServices
{
    public interface IEmployeeServices : IServices<Employee>
    {

        Employee get(int Id);
        IEnumerable<EmployeeDto> GetAll(
           Expression<Func<Employee, bool>> filter = null);
        void Add(Employee entity);
        void Update(Employee entity);
        void Remove(Employee entity);
        void Remove(int Id);
        void RemoveRange(IEnumerable<Employee> entity);
    }
}
