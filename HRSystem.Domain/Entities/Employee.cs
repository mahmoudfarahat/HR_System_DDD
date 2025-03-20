using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRSystem.Domain.Entities
{
    public class Employee
    {
        public Employee(int id,string name)
        {
            Name = name;
            Id = Id;
        }

        public int Id { get; set; }

        public string Name { get; set; }  

    }
}
