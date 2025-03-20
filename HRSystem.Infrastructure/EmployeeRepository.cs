using HRSystem.Domain;
using HRSystem.Domain.Entities;
using HRSystem.Infrastructure.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRSystem.Infrastructure
{
    public class EmployeeRepository : IEmployeeRepository
    {
        private readonly OrderDbContext _orderDbContext;

        public EmployeeRepository(OrderDbContext orderDbContext)
        {
           _orderDbContext = orderDbContext;
        }

        public async Task AddAsync(Employee employee)
        {
              await _orderDbContext.Employees.AddAsync(employee);
            await _orderDbContext.SaveChangesAsync();
        }
    }
}
