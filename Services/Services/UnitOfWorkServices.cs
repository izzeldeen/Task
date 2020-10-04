using DataAcces;
using Repoistory.IRepository;
using Services.IServices;
using System;
using System.Collections.Generic;
using System.Text;

namespace Services.Services
{
    public class UnitOfWorkServices : IUnitOfWorkServices
    {
        private readonly IUnitOfWork _unitOfWorkRepo;
        public UnitOfWorkServices(IUnitOfWork unitOfWorkRepo)
        {
            _unitOfWorkRepo = unitOfWorkRepo;
            EmployeeService = new Lazy<IEmployeeServices>(() => (new EmployeeServices(_unitOfWorkRepo)));
            //Employee = new EmployeeServices(_unitOfWorkRepo);
        }

        public Lazy<IEmployeeServices> EmployeeService { get ; set ; }
        //public IEmployeeServices Employee { get; private set; }

        public void Dispose()
        {
            _unitOfWorkRepo.Dispose();            
        }

        public void Save()
        {
            _unitOfWorkRepo.Save();
        }
    }
}
