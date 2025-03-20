using HRSystem.Application.DTOs;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRSystem.Application.Commands
{

    public  class CreateEmployeeCommand: IRequest<EmployeeDto>  // EmployeeDto is the response
    {
        public int Id { get; set; }

        public string Name { get; set; }
    }
}
