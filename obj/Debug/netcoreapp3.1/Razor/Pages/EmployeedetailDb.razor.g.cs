#pragma checksum "D:\WorkShop_DotnetCore\Blazor_TrforBeginer\Pages\EmployeedetailDb.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "594b926b10eb1e287423b5fc36594c729f02db1b"
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
    [Microsoft.AspNetCore.Components.RouteAttribute("/employeedetaildb/{id}")]
    public partial class EmployeedetailDb : EmployeedetailDbBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<h3>EmployeeDetailDb</h3>\r\n<br>\r\n\r\n");
            __builder.OpenElement(1, "h3");
            __builder.AddMarkupContent(2, "\r\n   ");
            __builder.AddContent(3, 
#nullable restore
#line 9 "D:\WorkShop_DotnetCore\Blazor_TrforBeginer\Pages\EmployeedetailDb.razor"
    employeeDb.Name

#line default
#line hidden
#nullable disable
            );
            __builder.AddMarkupContent(4, "\r\n    |\r\n    ");
            __builder.AddContent(5, 
#nullable restore
#line 11 "D:\WorkShop_DotnetCore\Blazor_TrforBeginer\Pages\EmployeedetailDb.razor"
     employeeDb.Job

#line default
#line hidden
#nullable disable
            );
            __builder.AddMarkupContent(6, "\r\n");
            __builder.CloseElement();
            __builder.AddMarkupContent(7, "\r\n\r\n");
            __builder.AddMarkupContent(8, "<a href=\"/employeedb\">Back</a>");
        }
        #pragma warning restore 1998
    }
}
#pragma warning restore 1591
