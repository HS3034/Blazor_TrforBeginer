using Blazor_TrforBeginer.Models;
using Blazor_TrforBeginer.Services;
using Microsoft.AspNetCore.Components;
using Microsoft.JSInterop;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Blazor_TrforBeginer.Pages
{
    public class EmployeedetailDbBase : ComponentBase
    {
        [Inject]
        public IEmployeeRepo employeeRepo { get; set; }  //call interface
       // public List<EmployeeDb> employeeDbs { get; set; }
        public EmployeeDb employeeDb { get; set; }  //not return list

        [Parameter]
        public string id { get; set; }
        protected override Task OnInitializedAsync()
        {


            employeeDb = employeeRepo.GetByID(int.Parse(id));
            return base.OnInitializedAsync();

        }

    }
}
