#pragma checksum "C:\Users\admin\source\repos\Order_Management_App\Order_Management_Blazor_Server\Pages\Suppliers.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "de8f19bbf152805dc74fd21f9fed4cee2918d431"
// <auto-generated/>
#pragma warning disable 1591
namespace Order_Management_Blazor_Server.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\admin\source\repos\Order_Management_App\Order_Management_Blazor_Server\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\admin\source\repos\Order_Management_App\Order_Management_Blazor_Server\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\admin\source\repos\Order_Management_App\Order_Management_Blazor_Server\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\admin\source\repos\Order_Management_App\Order_Management_Blazor_Server\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\admin\source\repos\Order_Management_App\Order_Management_Blazor_Server\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\admin\source\repos\Order_Management_App\Order_Management_Blazor_Server\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\admin\source\repos\Order_Management_App\Order_Management_Blazor_Server\_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\admin\source\repos\Order_Management_App\Order_Management_Blazor_Server\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\admin\source\repos\Order_Management_App\Order_Management_Blazor_Server\_Imports.razor"
using Order_Management_Blazor_Server;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\admin\source\repos\Order_Management_App\Order_Management_Blazor_Server\_Imports.razor"
using Order_Management_Blazor_Server.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\admin\source\repos\Order_Management_App\Order_Management_Blazor_Server\Pages\Suppliers.razor"
using Order_Management_Blazor_Server.Data;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\admin\source\repos\Order_Management_App\Order_Management_Blazor_Server\Pages\Suppliers.razor"
using Order_Management_Blazor_Server.Models;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/suppliers")]
    public partial class Suppliers : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<h3>Suppliers</h3>");
#nullable restore
#line 8 "C:\Users\admin\source\repos\Order_Management_App\Order_Management_Blazor_Server\Pages\Suppliers.razor"
 if (ListSuppliers == null)
{

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(1, "<p><em>Loading...</em></p>");
#nullable restore
#line 11 "C:\Users\admin\source\repos\Order_Management_App\Order_Management_Blazor_Server\Pages\Suppliers.razor"
}
else
{

#line default
#line hidden
#nullable disable
            __builder.OpenElement(2, "table");
            __builder.AddAttribute(3, "class", "table");
            __builder.AddMarkupContent(4, @"<thead><tr><th>Name</th>
                <th>AddressLine1</th>
                <th>AddressLine2</th>
                <th>City</th>
                <th>PostalCode</th>
                <th>State</th>
                <th><ion-icon name=""create-outline""></ion-icon></th></tr></thead>
        ");
            __builder.OpenElement(5, "tbody");
#nullable restore
#line 27 "C:\Users\admin\source\repos\Order_Management_App\Order_Management_Blazor_Server\Pages\Suppliers.razor"
             foreach (var supplier in ListSuppliers)
            {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(6, "tr");
            __builder.OpenElement(7, "td");
#nullable restore
#line 30 "C:\Users\admin\source\repos\Order_Management_App\Order_Management_Blazor_Server\Pages\Suppliers.razor"
__builder.AddContent(8, supplier.SupplierName);

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.AddMarkupContent(9, "\r\n                    ");
            __builder.OpenElement(10, "td");
#nullable restore
#line 31 "C:\Users\admin\source\repos\Order_Management_App\Order_Management_Blazor_Server\Pages\Suppliers.razor"
__builder.AddContent(11, supplier.AddressLine1);

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.AddMarkupContent(12, "\r\n                    ");
            __builder.OpenElement(13, "td");
#nullable restore
#line 32 "C:\Users\admin\source\repos\Order_Management_App\Order_Management_Blazor_Server\Pages\Suppliers.razor"
__builder.AddContent(14, supplier.AddressLine2);

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.AddMarkupContent(15, "\r\n                    ");
            __builder.OpenElement(16, "td");
#nullable restore
#line 33 "C:\Users\admin\source\repos\Order_Management_App\Order_Management_Blazor_Server\Pages\Suppliers.razor"
__builder.AddContent(17, supplier.City);

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.AddMarkupContent(18, "\r\n                    ");
            __builder.OpenElement(19, "td");
#nullable restore
#line 34 "C:\Users\admin\source\repos\Order_Management_App\Order_Management_Blazor_Server\Pages\Suppliers.razor"
__builder.AddContent(20, supplier.PostalCode);

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.AddMarkupContent(21, "\r\n                    ");
            __builder.OpenElement(22, "td");
#nullable restore
#line 35 "C:\Users\admin\source\repos\Order_Management_App\Order_Management_Blazor_Server\Pages\Suppliers.razor"
__builder.AddContent(23, supplier.State);

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.AddMarkupContent(24, "\r\n                    ");
            __builder.AddMarkupContent(25, "<td><a class=\"btn btn success\" href=\"suppliers/update/1\">Edit</a></td>");
            __builder.CloseElement();
#nullable restore
#line 38 "C:\Users\admin\source\repos\Order_Management_App\Order_Management_Blazor_Server\Pages\Suppliers.razor"
            }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 41 "C:\Users\admin\source\repos\Order_Management_App\Order_Management_Blazor_Server\Pages\Suppliers.razor"
}

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(26, "<a class=\"btn btn success\" href=\"suppliers/create\">Create Supplier</a>");
        }
        #pragma warning restore 1998
#nullable restore
#line 48 "C:\Users\admin\source\repos\Order_Management_App\Order_Management_Blazor_Server\Pages\Suppliers.razor"
       
    private List<Supplier> ListSuppliers;

    protected override async Task OnInitializedAsync()
    {
        ListSuppliers = await _dataProvider.GetSuppliersAsync();
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private DataProviderService _dataProvider { get; set; }
    }
}
#pragma warning restore 1591