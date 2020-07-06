using Microsoft.AspNetCore.Components;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

using Blazor_TrforBeginer.Models;
using Blazor_TrforBeginer.Services;
using Microsoft.AspNetCore.Razor.TagHelpers;

namespace Blazor_TrforBeginer.Pages
{
    public class EmployeeeditBase : ComponentBase
    {
        [Inject]
        public IEmployeeRepo EmployeeRepo { get; set; }
        [Parameter]
        public string Id { get; set; }
        public EmployeeDb EmployeeDb { get; set; } = new EmployeeDb();

        public string StatusClass = string.Empty;
        public string Message = string.Empty;
        public bool Save;

        protected override void OnInitialized() 
        {
            Save = false;

            int.TryParse(Id, out var EmpId);
            if (EmpId == 0)
            {
                EmployeeDb = new EmployeeDb() { Job = "", Name = "" };

               
            }
            else {
                EmployeeDb = EmployeeRepo.GetByID(int.Parse(Id));
                
            }

            
            base.OnInitialized();
        }

        protected async Task handleSubmit(){
            if (EmployeeDb.Id == 0)
            {
                EmployeeRepo.Insert(EmployeeDb);
                Message = "Saved New Employee";
                StatusClass = "alert-success";
                Save = true;
            }
            else
            {
                EmployeeRepo.Update(EmployeeDb);
                Message = "Update  Employee";
                StatusClass = "alert-success";
                Save = true;
            }
        }
    }
}
