#pragma checksum "C:\Users\admin\source\repos\Order_Management_App\Order_Management_Blazor_Server\Pages\UpdateSupplier.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "9077ef4b20513fe963866a6476943ed40d208f66"
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
#line 3 "C:\Users\admin\source\repos\Order_Management_App\Order_Management_Blazor_Server\Pages\UpdateSupplier.razor"
using Order_Management_Blazor_Server.Data;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\admin\source\repos\Order_Management_App\Order_Management_Blazor_Server\Pages\UpdateSupplier.razor"
using Order_Management_Blazor_Server.Models;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/suppliers/update/{Id:int}")]
    public partial class UpdateSupplier : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "h3");
            __builder.AddContent(1, "Update Supplier: ");
#nullable restore
#line 8 "C:\Users\admin\source\repos\Order_Management_App\Order_Management_Blazor_Server\Pages\UpdateSupplier.razor"
__builder.AddContent(2, Id);

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.AddMarkupContent(3, "\r\n\r\n");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Forms.EditForm>(4);
            __builder.AddAttribute(5, "Model", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Object>(
#nullable restore
#line 10 "C:\Users\admin\source\repos\Order_Management_App\Order_Management_Blazor_Server\Pages\UpdateSupplier.razor"
                  supplier

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(6, "OnValidSubmit", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Microsoft.AspNetCore.Components.Forms.EditContext>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Forms.EditContext>(this, 
#nullable restore
#line 10 "C:\Users\admin\source\repos\Order_Management_App\Order_Management_Blazor_Server\Pages\UpdateSupplier.razor"
                                            Update

#line default
#line hidden
#nullable disable
            )));
            __builder.AddAttribute(7, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Forms.EditContext>)((context) => (__builder2) => {
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.DataAnnotationsValidator>(8);
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(9, "\r\n    ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.ValidationSummary>(10);
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(11, "\r\n\r\n    ");
                __builder2.OpenElement(12, "table");
                __builder2.OpenElement(13, "tbody");
                __builder2.OpenElement(14, "tr");
                __builder2.AddMarkupContent(15, "<td>Name</td>\r\n                ");
                __builder2.OpenElement(16, "td");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputText>(17);
                __builder2.AddAttribute(18, "class", "input-field");
                __builder2.AddAttribute(19, "Value", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 18 "C:\Users\admin\source\repos\Order_Management_App\Order_Management_Blazor_Server\Pages\UpdateSupplier.razor"
                                                                 supplier.SupplierName

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(20, "ValueChanged", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => supplier.SupplierName = __value, supplier.SupplierName))));
                __builder2.AddAttribute(21, "ValueExpression", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => supplier.SupplierName));
                __builder2.CloseComponent();
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(22, "\r\n            ");
                __builder2.OpenElement(23, "tr");
                __builder2.AddMarkupContent(24, "<td>Address Line 1</td>\r\n                ");
                __builder2.OpenElement(25, "td");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputText>(26);
                __builder2.AddAttribute(27, "class", "input-field");
                __builder2.AddAttribute(28, "Value", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 22 "C:\Users\admin\source\repos\Order_Management_App\Order_Management_Blazor_Server\Pages\UpdateSupplier.razor"
                                                                 supplier.AddressLine1

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(29, "ValueChanged", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => supplier.AddressLine1 = __value, supplier.AddressLine1))));
                __builder2.AddAttribute(30, "ValueExpression", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => supplier.AddressLine1));
                __builder2.CloseComponent();
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(31, "\r\n            ");
                __builder2.OpenElement(32, "tr");
                __builder2.AddMarkupContent(33, "<td>Address Line 2</td>\r\n                ");
                __builder2.OpenElement(34, "td");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputText>(35);
                __builder2.AddAttribute(36, "class", "input-field");
                __builder2.AddAttribute(37, "Value", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 26 "C:\Users\admin\source\repos\Order_Management_App\Order_Management_Blazor_Server\Pages\UpdateSupplier.razor"
                                                                 supplier.AddressLine2

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(38, "ValueChanged", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => supplier.AddressLine2 = __value, supplier.AddressLine2))));
                __builder2.AddAttribute(39, "ValueExpression", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => supplier.AddressLine2));
                __builder2.CloseComponent();
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(40, "\r\n            ");
                __builder2.OpenElement(41, "tr");
                __builder2.AddMarkupContent(42, "<td>City</td>\r\n                ");
                __builder2.OpenElement(43, "td");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputText>(44);
                __builder2.AddAttribute(45, "class", "input-field");
                __builder2.AddAttribute(46, "Value", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 30 "C:\Users\admin\source\repos\Order_Management_App\Order_Management_Blazor_Server\Pages\UpdateSupplier.razor"
                                                                 supplier.City

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(47, "ValueChanged", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => supplier.City = __value, supplier.City))));
                __builder2.AddAttribute(48, "ValueExpression", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => supplier.City));
                __builder2.CloseComponent();
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(49, "\r\n            ");
                __builder2.OpenElement(50, "tr");
                __builder2.AddMarkupContent(51, "<td>Postal Code</td>\r\n                ");
                __builder2.OpenElement(52, "td");
                __Blazor.Order_Management_Blazor_Server.Pages.UpdateSupplier.TypeInference.CreateInputNumber_0(__builder2, 53, 54, "input-field", 55, 
#nullable restore
#line 34 "C:\Users\admin\source\repos\Order_Management_App\Order_Management_Blazor_Server\Pages\UpdateSupplier.razor"
                                                                   supplier.PostalCode

#line default
#line hidden
#nullable disable
                , 56, Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => supplier.PostalCode = __value, supplier.PostalCode)), 57, () => supplier.PostalCode);
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(58, "\r\n            ");
                __builder2.OpenElement(59, "tr");
                __builder2.AddAttribute(60, "class", "hide-state");
                __builder2.AddMarkupContent(61, "<td>State</td>\r\n                ");
                __builder2.OpenElement(62, "td");
                __Blazor.Order_Management_Blazor_Server.Pages.UpdateSupplier.TypeInference.CreateInputSelect_1(__builder2, 63, 64, "input-field", 65, 
#nullable restore
#line 38 "C:\Users\admin\source\repos\Order_Management_App\Order_Management_Blazor_Server\Pages\UpdateSupplier.razor"
                                                                   supplier.State

#line default
#line hidden
#nullable disable
                , 66, Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => supplier.State = __value, supplier.State)), 67, () => supplier.State);
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(68, "\r\n            ");
                __builder2.OpenElement(69, "tr");
                __builder2.AddMarkupContent(70, "<td>Dropdown</td>\r\n                ");
                __builder2.OpenElement(71, "select");
                __builder2.AddAttribute(72, "class", "input-select");
                __builder2.AddAttribute(73, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.ChangeEventArgs>(this, 
#nullable restore
#line 42 "C:\Users\admin\source\repos\Order_Management_App\Order_Management_Blazor_Server\Pages\UpdateSupplier.razor"
                                                        UpdateState

#line default
#line hidden
#nullable disable
                ));
#nullable restore
#line 43 "C:\Users\admin\source\repos\Order_Management_App\Order_Management_Blazor_Server\Pages\UpdateSupplier.razor"
                     foreach (var state in states)
                    {

#line default
#line hidden
#nullable disable
                __builder2.OpenElement(74, "option");
                __builder2.AddAttribute(75, "value", 
#nullable restore
#line 45 "C:\Users\admin\source\repos\Order_Management_App\Order_Management_Blazor_Server\Pages\UpdateSupplier.razor"
                                       state

#line default
#line hidden
#nullable disable
                );
#nullable restore
#line 45 "C:\Users\admin\source\repos\Order_Management_App\Order_Management_Blazor_Server\Pages\UpdateSupplier.razor"
__builder2.AddContent(76, state);

#line default
#line hidden
#nullable disable
                __builder2.CloseElement();
#nullable restore
#line 46 "C:\Users\admin\source\repos\Order_Management_App\Order_Management_Blazor_Server\Pages\UpdateSupplier.razor"
                    }

#line default
#line hidden
#nullable disable
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(77, "\r\n\r\n\r\n\r\n    ");
                __builder2.OpenElement(78, "div");
                __builder2.AddAttribute(79, "style", "margin-top: 20px;");
                __builder2.AddMarkupContent(80, "<button class=\"btn btn-success\" type=\"submit\">Update</button>\r\n        ");
                __builder2.OpenElement(81, "a");
                __builder2.AddAttribute(82, "class", "btn btn-danger");
                __builder2.AddAttribute(83, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 56 "C:\Users\admin\source\repos\Order_Management_App\Order_Management_Blazor_Server\Pages\UpdateSupplier.razor"
                                              e => DeleteSupplier(supplier.Id)

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddContent(84, "Delete");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(85, "\r\n        ");
                __builder2.AddMarkupContent(86, "<a class=\"btn btn-primary\" href=\"suppliers\">Cancel</a>");
                __builder2.CloseElement();
            }
            ));
            __builder.CloseComponent();
        }
        #pragma warning restore 1998
#nullable restore
#line 63 "C:\Users\admin\source\repos\Order_Management_App\Order_Management_Blazor_Server\Pages\UpdateSupplier.razor"
       
    [Parameter]
    public int Id { get; set; }

    private Supplier supplier = new Supplier();

    private List<string> states = new List<string>();

    protected override async Task OnInitializedAsync()
    {
        supplier = await _dataProvider.GetSupplierByIdAsync(Id);
        if (supplier != null)
        {
            //editContext = new(supplier);

            SelectedString = supplier.State;
            states = NeededData.GetStates();
        }
        else
        {
            _navigationManager.NavigateTo("/suppliers");
        }
    }

    private async void Update()
    {
        await _dataProvider.UpdateSupplierAsync(supplier);
    }

    private async void DeleteSupplier(int id)
    {
        var status = await _dataProvider.DeleteSupplierAsync(id);
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
namespace __Blazor.Order_Management_Blazor_Server.Pages.UpdateSupplier
{
    #line hidden
    internal static class TypeInference
    {
        public static void CreateInputNumber_0<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, System.Object __arg0, int __seq1, TValue __arg1, int __seq2, global::Microsoft.AspNetCore.Components.EventCallback<TValue> __arg2, int __seq3, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg3)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.InputNumber<TValue>>(seq);
        __builder.AddAttribute(__seq0, "class", __arg0);
        __builder.AddAttribute(__seq1, "Value", __arg1);
        __builder.AddAttribute(__seq2, "ValueChanged", __arg2);
        __builder.AddAttribute(__seq3, "ValueExpression", __arg3);
        __builder.CloseComponent();
        }
        public static void CreateInputSelect_1<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, System.Object __arg0, int __seq1, TValue __arg1, int __seq2, global::Microsoft.AspNetCore.Components.EventCallback<TValue> __arg2, int __seq3, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg3)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.InputSelect<TValue>>(seq);
        __builder.AddAttribute(__seq0, "class", __arg0);
        __builder.AddAttribute(__seq1, "Value", __arg1);
        __builder.AddAttribute(__seq2, "ValueChanged", __arg2);
        __builder.AddAttribute(__seq3, "ValueExpression", __arg3);
        __builder.CloseComponent();
        }
    }
}
#pragma warning restore 1591
