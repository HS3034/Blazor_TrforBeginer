

using Microsoft.AspNetCore.Components;
using Blazor_TrforBeginer.Models;
using System.Collections.Generic;
using System.Threading.Tasks;
using Blazor_TrforBeginer.Services;

namespace Blazor_TrforBeginer.Pages
{
    public class EmployeeOverviewDbBase :ComponentBase
    {
        [Inject]
        public IEmployeeRepo employeeRepo { get; set; }
        public List<EmployeeDb>  EmployeeDbs {get;set;}  //return list

      //  public EmployeeDb EmployeeDb { get; set; }  

         protected override Task OnInitializedAsync()
        {
          
            EmployeeDbs = employeeRepo.GetAll();
            return base.OnInitializedAsync();

        }

      
        

 
    }
}