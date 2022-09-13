// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

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
#line 2 "C:\Users\admin\source\repos\Order_Management_App\Order_Management_Blazor_Server\Pages\CreateSupplier.razor"
using Order_Management_Blazor_Server.Data;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\admin\source\repos\Order_Management_App\Order_Management_Blazor_Server\Pages\CreateSupplier.razor"
using Order_Management_Blazor_Server.Models;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/suppliers/create")]
    public partial class CreateSupplier : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 69 "C:\Users\admin\source\repos\Order_Management_App\Order_Management_Blazor_Server\Pages\CreateSupplier.razor"
       
    private Supplier supplier = new Supplier();

    private List<string> states = NeededData.GetStates();

    private async void Create()
    {
        await _dataProvider.CreateSupplierAsync(supplier);
        _navigationManager.NavigateTo("/suppliers");
    }

    string SelectedString = "Available";

    void UpdateState(ChangeEventArgs e)
    {
        SelectedString = e.Value.ToString();
        supplier.State = e.Value.ToString();
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager _navigationManager { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private DataProviderService _dataProvider { get; set; }
    }
}
#pragma warning restore 1591
