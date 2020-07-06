using Blazor_TrforBeginer.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Blazor_TrforBeginer.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options) { }
        public DbSet<EmployeeDb>  EmployeeDbs { get; set; }

       // public DbSet<Employee> Employees { get; set; }
    }
}
