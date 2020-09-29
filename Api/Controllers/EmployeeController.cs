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
        public EmployeeController(IUnitOfWorkServices unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }
        [HttpPost("Criteria")]
        public IActionResult GetEmployees(GetWithCrtiera model) => Ok(_unitOfWork.Employee.GetAll(filter: x => x.Salary > model.From && x.Salary < model.to || x.Name.Contains(model.Name)));
        [HttpGet("getall")]
        public IActionResult GetAll() => Ok(_unitOfWork.Employee.GetAll());
        [HttpGet("getbyId")]
        public IActionResult GetById(int Id) => Ok(_unitOfWork.Employee.get(Id));
        [HttpPost("Add")]
        public IActionResult Add(Employee employee)
        {
            _unitOfWork.Employee.Add(employee);
            return Ok("done");
        }
        [HttpPost("Upsert")]
        public IActionResult Update(Employee employee) {
            _unitOfWork.Employee.Update(employee);
            return Ok("done");
        }
    } 
}
