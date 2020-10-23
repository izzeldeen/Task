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
    public class EmployeeServices : Services<Employee> , IEmployeeServices
    {
       

        public EmployeeServices(IRepository<Employee> repository) : base(repository)
        {

        }
      

    }
}
