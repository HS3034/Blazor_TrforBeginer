#pragma checksum "D:\WorkShop_DotnetCore\Blazor_TrforBeginer\Pages\EmployeeOverview.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "147edee66e9dad0ae31620aeaf45bc6f45254356"
// <auto-generated/>
#pragma warning disable 1591
namespace Blazor_TrforBeginer.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "D:\WorkShop_DotnetCore\Blazor_TrforBeginer\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\WorkShop_DotnetCore\Blazor_TrforBeginer\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "D:\WorkShop_DotnetCore\Blazor_TrforBeginer\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "D:\WorkShop_DotnetCore\Blazor_TrforBeginer\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "D:\WorkShop_DotnetCore\Blazor_TrforBeginer\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "D:\WorkShop_DotnetCore\Blazor_TrforBeginer\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "D:\WorkShop_DotnetCore\Blazor_TrforBeginer\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "D:\WorkShop_DotnetCore\Blazor_TrforBeginer\_Imports.razor"
using Blazor_TrforBeginer;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "D:\WorkShop_DotnetCore\Blazor_TrforBeginer\_Imports.razor"
using Blazor_TrforBeginer.Shared;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/employee")]
    public partial class EmployeeOverview : EmployeeOverviewBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<h3>Employee List</h3>\r\n\r\n\r\n");
            __builder.OpenElement(1, "table");
            __builder.AddAttribute(2, "class", "table table-bordered");
            __builder.AddMarkupContent(3, "\r\n    ");
            __builder.AddMarkupContent(4, "<tr>\r\n        <th>ID</th>\r\n        <th>Name</th>\r\n        <th>Job</th>\r\n        <th>Detail</th>\r\n    </tr>\r\n    ");
            __builder.OpenElement(5, "tbody");
            __builder.AddMarkupContent(6, "\r\n");
#nullable restore
#line 15 "D:\WorkShop_DotnetCore\Blazor_TrforBeginer\Pages\EmployeeOverview.razor"
         foreach (var item in empoyees)
        {

#line default
#line hidden
#nullable disable
            __builder.AddContent(7, "            ");
            __builder.OpenElement(8, "tr");
            __builder.AddMarkupContent(9, "\r\n                ");
            __builder.OpenElement(10, "td");
            __builder.AddMarkupContent(11, "\r\n                    ");
            __builder.AddContent(12, 
#nullable restore
#line 19 "D:\WorkShop_DotnetCore\Blazor_TrforBeginer\Pages\EmployeeOverview.razor"
                     item.Id

#line default
#line hidden
#nullable disable
            );
            __builder.AddMarkupContent(13, "\r\n                ");
            __builder.CloseElement();
            __builder.AddMarkupContent(14, "\r\n                ");
            __builder.OpenElement(15, "td");
            __builder.AddMarkupContent(16, "\r\n                    ");
            __builder.AddContent(17, 
#nullable restore
#line 22 "D:\WorkShop_DotnetCore\Blazor_TrforBeginer\Pages\EmployeeOverview.razor"
                     item.Name

#line default
#line hidden
#nullable disable
            );
            __builder.AddMarkupContent(18, "\r\n                ");
            __builder.CloseElement();
            __builder.AddMarkupContent(19, "\r\n                ");
            __builder.OpenElement(20, "td");
            __builder.AddMarkupContent(21, "\r\n                    ");
            __builder.AddContent(22, 
#nullable restore
#line 25 "D:\WorkShop_DotnetCore\Blazor_TrforBeginer\Pages\EmployeeOverview.razor"
                     item.Job

#line default
#line hidden
#nullable disable
            );
            __builder.AddMarkupContent(23, "\r\n                ");
            __builder.CloseElement();
            __builder.AddMarkupContent(24, "\r\n                ");
            __builder.OpenElement(25, "td");
            __builder.AddMarkupContent(26, "\r\n                    ");
            __builder.OpenElement(27, "a");
            __builder.AddAttribute(28, "href", 
#nullable restore
#line 28 "D:\WorkShop_DotnetCore\Blazor_TrforBeginer\Pages\EmployeeOverview.razor"
                               $"/employeedetail/{item.Id}"

#line default
#line hidden
#nullable disable
            );
            __builder.AddContent(29, "Detail");
            __builder.CloseElement();
            __builder.AddMarkupContent(30, "\r\n            \r\n                ");
            __builder.CloseElement();
            __builder.AddMarkupContent(31, "\r\n            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(32, "\r\n");
#nullable restore
#line 32 "D:\WorkShop_DotnetCore\Blazor_TrforBeginer\Pages\EmployeeOverview.razor"
        }

#line default
#line hidden
#nullable disable
            __builder.AddContent(33, "    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(34, "\r\n");
            __builder.CloseElement();
        }
        #pragma warning restore 1998
    }
}
#pragma warning restore 1591
