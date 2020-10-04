using Domain;
using Repoistory.IRepository;
using Repoistory.Repository;
using Services.Dto;
using Services.IServices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace Services.Services
{
    public class EmployeeServices : IEmployeeServices
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

        public IEnumerable<EmployeeDto> GetAll(Expression<Func<Employee, bool>> filter = null)
        {
           var Employees =  _unitOfWork.Employee.GetAll(filter);
            var EmployeesDto = new List<EmployeeDto>();
            foreach(var item in Employees)
            {
                if(item.Gender == true)
                {
                    var EmployeeDto = new EmployeeDto() { Id = item.Id, Name = item.Name, BirthDay = item.BirthDay, Salary = item.Salary, Gender = "Male" };
                    EmployeesDto.Add(EmployeeDto);
                }
                else
                {
                    var EmployeeDto = new EmployeeDto() { Id = item.Id, Name = item.Name, BirthDay = item.BirthDay, Salary = item.Salary, Gender = "Female" };
                    EmployeesDto.Add(EmployeeDto);
                }       
            }
            return EmployeesDto;
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
