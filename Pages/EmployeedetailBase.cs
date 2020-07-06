using Blazor_TrforBeginer.Models;
using Microsoft.AspNetCore.Components;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Blazor_TrforBeginer.Pages
{
    public class EmployeedetailBase : ComponentBase
    {
        public List<Employee> employees { get; set; }

        public Employee employee { get; set; }

        [Parameter]
        public string id { get; set; }
        protected override Task OnInitializedAsync()
        {
            Inittializeemployee();

            employee = employees.SingleOrDefault(x => x.Id == int.Parse(id));
            return base.OnInitializedAsync();

        }

        public void Inittializeemployee()
        {
            employees = new List<Employee>() {
                new Employee{Id=1,Name="tahz",Job="Devloper"},
                new Employee{Id=2,Name="addie",Job="Designer"},
                new Employee{Id=3,Name="smith",Job="Tester"},
                new Employee{Id=4,Name="Zala", Job="Seo Maket"}
            };
        }

    }
}
