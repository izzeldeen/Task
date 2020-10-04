using System;
using System.Collections.Generic;
using System.Text;

namespace Services.Dto
{
   public  class EmployeeDto
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public DateTime BirthDay { get; set; }
        public decimal Salary { get; set; }
        public string Gender { get; set; }

    }
}
