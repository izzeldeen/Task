using DataAcces;
using Domain;
using Repoistory.IRepository;
using System;
using System.Collections.Generic;
using System.Text;

namespace Repoistory.Repository
{
    public class EmployeeRepository : Repoistory<Employee> , IEmployeeRepoistory
    {
        public EmployeeRepository(StoreContext context) : base(context)
        {

        }

    }
}
