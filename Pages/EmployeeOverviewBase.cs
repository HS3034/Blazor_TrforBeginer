

using Microsoft.AspNetCore.Components;
using Blazor_TrforBeginer.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Blazor_TrforBeginer.Pages
{
    public class EmployeeOverviewBase :ComponentBase
    {
        public List<Employee> empoyees {get;set;}

         protected override Task OnInitializedAsync()
        {
            Inittializeemployee();
            return base.OnInitializedAsync();

        }

        public void Inittializeemployee()
        {
            empoyees = new List<Employee>() {
                new Employee{Id=1,Name="tahz",Job="Devloper"},
                new Employee{Id=2,Name="addie",Job="Designer"},
                new Employee{Id=3,Name="smith",Job="Tester"},
                new Employee{Id=4,Name="zala", Job="Seo"}
            };
        }

 
    }
}