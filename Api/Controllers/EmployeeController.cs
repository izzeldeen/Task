using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Domain;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Repoistory.IRepository;
using Services.Dto;
using Services.IServices;

namespace Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmployeeController : ControllerBase
    {
        private readonly IUnitOfWorkServices _unitOfWork;
        private readonly IServices<Employee> _services;
        public EmployeeController(IUnitOfWorkServices unitOfWork , IServices<Employee> services)
        {
            _unitOfWork = unitOfWork;
            _services = services;
        }
        //[HttpPost("Criteria")]
        //public IActionResult GetEmployees(GetWithCrtiera model) => Ok(_unitOfWork.EmployeeService.Value.GetAll(filter: x => x.Salary > model.From && x.Salary < model.to && x.Name.Contains(model.Name)));
        //[HttpGet("GetAll")]
        //public IActionResult GetAll() => Ok(_unitOfWork.EmployeeService.Value.GetAll());
        //[HttpGet("getbyId")]
        //public IActionResult GetById(int Id) => Ok(_unitOfWork.EmployeeService.Value.get(Id));
        //[HttpGet("Search")]
        //public IActionResult Search(string Name) =>
        //    Ok(_unitOfWork.EmployeeService.Value.GetAll(filter:x=> x.Name.Contains(Name)));
        
        [HttpGet("get")]
        public IActionResult Add(int  Id)
        {
          return  Ok(_unitOfWork.EmployeeService.get(Id));
           
        }
        [HttpPost("Upsert")]
        public IActionResult Update(Employee employee) {
            _unitOfWork.EmployeeService.Update(employee);
            return Ok("done");
        }
    } 
}
