using System;
using System.Collections.Generic;
using System.Text;

namespace Domain
{
    public class Employee
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public DateTime BirthDay { get; set; }

        public decimal Salary { get; set; }

        public bool Gender { get; set; }
    }
}
