using Microsoft.AspNetCore.Components;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Blazor_TrforBeginer.Models;

namespace Blazor_TrforBeginer.Pages
{
    public class BindingexsampleBase : ComponentBase
    {
        public Employee employees{ get; set; }

        protected override Task OnInitializedAsync()
        {
            

            employees = new Employee()
            {
                Id = 1,
                Name = "aaa",
                Job = "Auther"
            };

            return base.OnInitializedAsync();
        }
    }
}
