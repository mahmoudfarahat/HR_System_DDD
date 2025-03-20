using HRSystem.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRSystem.Domain
{
    public interface IEmployeeRepository
    {
        Task AddAsync(Employee product);

    }
}
