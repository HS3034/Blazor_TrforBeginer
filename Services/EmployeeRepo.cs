using Blazor_TrforBeginer.Data;
using Blazor_TrforBeginer.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Blazor_TrforBeginer.Services
{
    public class EmployeeRepo : IEmployeeRepo
    {

        private readonly DataContext _context;
      

        public EmployeeRepo(DataContext context) {
            _context = context;
        }

        public void Delete(EmployeeDb emp)
        {
            _context.EmployeeDbs.Remove(emp);
            _context.SaveChanges();
        }

        public List<EmployeeDb> GetAll()
        {
            return _context.EmployeeDbs.ToList();
        }

        public EmployeeDb GetByID(int id)
        {
            return _context.EmployeeDbs.Where(e => e.Id == id).FirstOrDefault();
        }

        public void Insert(EmployeeDb emp)
        {
            _context.EmployeeDbs.Add(emp);
            _context.SaveChanges();
        }

        public void Update(EmployeeDb emp)
        {
            _context.EmployeeDbs.Update(emp);
            _context.SaveChanges();
        }
    }
}
