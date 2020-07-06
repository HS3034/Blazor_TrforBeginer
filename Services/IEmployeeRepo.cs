using Blazor_TrforBeginer.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Blazor_TrforBeginer.Services
{
    public interface IEmployeeRepo
    {
        List<EmployeeDb> GetAll();
        EmployeeDb GetByID(int id);

        void Insert(EmployeeDb emp);  //bind with <editform>
        void Delete(EmployeeDb emp);
        void Update(EmployeeDb emp);
    }
}
