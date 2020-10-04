using System;
using System.Collections.Generic;
using System.Text;

namespace Services.IServices
{
    public interface IUnitOfWorkServices : IDisposable
    {


        //IEmployeeServices Employee { get; set; }

        Lazy<IEmployeeServices> EmployeeService { get; set; }

        void Save();
    }
}
