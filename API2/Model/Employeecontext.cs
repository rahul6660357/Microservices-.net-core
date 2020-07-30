using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace API2.Model
{
    public class Employeecontext : DbContext
    {
        public Employeecontext(DbContextOptions<Employeecontext> options)
            : base(options)
        {
        }

        public DbSet<Employee> Employees { get; set; }
    }
}
