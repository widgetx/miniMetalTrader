#pragma checksum "C:\Users\widge\source\repos\miniMetalTrader\miniMetalTrader\Pages\Index.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "3e9a2564c6eb56cc4dace31319d2b4ec4b9c18bb"
// <auto-generated/>
#pragma warning disable 1591
namespace miniMetalTrader.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\widge\source\repos\miniMetalTrader\miniMetalTrader\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\widge\source\repos\miniMetalTrader\miniMetalTrader\_Imports.razor"
using System.Net.Http.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\widge\source\repos\miniMetalTrader\miniMetalTrader\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\widge\source\repos\miniMetalTrader\miniMetalTrader\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\widge\source\repos\miniMetalTrader\miniMetalTrader\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\widge\source\repos\miniMetalTrader\miniMetalTrader\_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\widge\source\repos\miniMetalTrader\miniMetalTrader\_Imports.razor"
using Microsoft.AspNetCore.Components.WebAssembly.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\widge\source\repos\miniMetalTrader\miniMetalTrader\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\widge\source\repos\miniMetalTrader\miniMetalTrader\_Imports.razor"
using miniMetalTrader;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\widge\source\repos\miniMetalTrader\miniMetalTrader\Pages\Index.razor"
using miniMetalTrader.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\widge\source\repos\miniMetalTrader\miniMetalTrader\Pages\Index.razor"
using System.Linq;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/")]
    public partial class Index : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, @"<style>
    .positions {
        display: grid;
        grid-template-columns: 40% 20% 20% 60px;
        grid-template-rows: 20px 20px 20px 20px;
        justify-content: left;
    }

        .positions:first-child div {
            font: bold;
        }
</style>

");
            __builder.AddMarkupContent(1, "<h1>Metals</h1>");
#nullable restore
#line 22 "C:\Users\widge\source\repos\miniMetalTrader\miniMetalTrader\Pages\Index.razor"
 if (clients == null)
{

}
else
{
    // just show first client from test data unless use a param on the route..

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(2, "<div>Account:</div>");
#nullable restore
#line 30 "C:\Users\widge\source\repos\miniMetalTrader\miniMetalTrader\Pages\Index.razor"
     foreach (var client in clients)
    {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(3, "div");
            __builder.AddContent(4, 
#nullable restore
#line 32 "C:\Users\widge\source\repos\miniMetalTrader\miniMetalTrader\Pages\Index.razor"
              client.Name

#line default
#line hidden
#nullable disable
            );
            __builder.AddContent(5, " - ");
            __builder.OpenElement(6, "em");
            __builder.AddContent(7, 
#nullable restore
#line 32 "C:\Users\widge\source\repos\miniMetalTrader\miniMetalTrader\Pages\Index.razor"
                                 client.ClientId

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.OpenElement(8, "div");
            __builder.AddContent(9, 
#nullable restore
#line 34 "C:\Users\widge\source\repos\miniMetalTrader\miniMetalTrader\Pages\Index.razor"
              client.Account.Id

#line default
#line hidden
#nullable disable
            );
            __builder.AddContent(10, " - ");
            __builder.AddContent(11, 
#nullable restore
#line 34 "C:\Users\widge\source\repos\miniMetalTrader\miniMetalTrader\Pages\Index.razor"
                                   client.Account.Balance()

#line default
#line hidden
#nullable disable
            );
            __builder.AddContent(12, " ");
            __builder.AddContent(13, 
#nullable restore
#line 34 "C:\Users\widge\source\repos\miniMetalTrader\miniMetalTrader\Pages\Index.razor"
                                                             client.Account.Currency

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(14, "<h3>Valuation</h3>");
#nullable restore
#line 38 "C:\Users\widge\source\repos\miniMetalTrader\miniMetalTrader\Pages\Index.razor"
        var valuation = 0;


#line default
#line hidden
#nullable disable
            __builder.OpenElement(15, "div");
            __builder.AddContent(16, 
#nullable restore
#line 40 "C:\Users\widge\source\repos\miniMetalTrader\miniMetalTrader\Pages\Index.razor"
              client.Account.Positions.Where(t => t.Status == PositionStatus.Filled).Sum(t => t.Price * t.Quantity).ToString("#,##")

#line default
#line hidden
#nullable disable
            );
            __builder.AddContent(17, " ");
            __builder.AddContent(18, 
#nullable restore
#line 40 "C:\Users\widge\source\repos\miniMetalTrader\miniMetalTrader\Pages\Index.razor"
                                                                                                                                      client.Account.Currency

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(19, "<h3>Positions</h3>\r\n        \r\n        ");
            __builder.OpenElement(20, "button");
            __builder.AddAttribute(21, "class", "btn btn-primary");
            __builder.AddAttribute(22, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 44 "C:\Users\widge\source\repos\miniMetalTrader\miniMetalTrader\Pages\Index.razor"
                                                    () => NavManager.NavigateTo($"/buy/{clients.First().ClientId}")

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(23, "Buy");
            __builder.CloseElement();
            __builder.OpenElement(24, "div");
            __builder.AddAttribute(25, "class", "positions");
            __builder.AddMarkupContent(26, "<div>Description</div>");
            __builder.AddMarkupContent(27, "<div>Quantity</div>");
            __builder.AddMarkupContent(28, "<div>Price</div>");
            __builder.AddMarkupContent(29, "<div>Value</div>");
#nullable restore
#line 48 "C:\Users\widge\source\repos\miniMetalTrader\miniMetalTrader\Pages\Index.razor"
             foreach (var tx in client.Account.Positions.Where(t => t.Status == PositionStatus.Filled))
            {
                var val = (tx.Quantity * tx.Price).ToString("#,##");

#line default
#line hidden
#nullable disable
            __builder.OpenElement(30, "div");
            __builder.AddContent(31, 
#nullable restore
#line 51 "C:\Users\widge\source\repos\miniMetalTrader\miniMetalTrader\Pages\Index.razor"
                      tx.Instrument.Description

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.OpenElement(32, "div");
            __builder.AddContent(33, 
#nullable restore
#line 51 "C:\Users\widge\source\repos\miniMetalTrader\miniMetalTrader\Pages\Index.razor"
                                                           tx.Quantity

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.OpenElement(34, "div");
            __builder.AddContent(35, 
#nullable restore
#line 51 "C:\Users\widge\source\repos\miniMetalTrader\miniMetalTrader\Pages\Index.razor"
                                                                                  tx.Price

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.OpenElement(36, "div");
            __builder.AddContent(37, 
#nullable restore
#line 51 "C:\Users\widge\source\repos\miniMetalTrader\miniMetalTrader\Pages\Index.razor"
                                                                                                      val

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
#nullable restore
#line 52 "C:\Users\widge\source\repos\miniMetalTrader\miniMetalTrader\Pages\Index.razor"
            }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
#nullable restore
#line 54 "C:\Users\widge\source\repos\miniMetalTrader\miniMetalTrader\Pages\Index.razor"



    }

#line default
#line hidden
#nullable disable
#nullable restore
#line 57 "C:\Users\widge\source\repos\miniMetalTrader\miniMetalTrader\Pages\Index.razor"
     
}

#line default
#line hidden
#nullable disable
        }
        #pragma warning restore 1998
#nullable restore
#line 60 "C:\Users\widge\source\repos\miniMetalTrader\miniMetalTrader\Pages\Index.razor"
      

    private Client[] clients;

    protected override async Task OnInitializedAsync()
    {
        clients = ClientService.GetClients();
    }


#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager NavManager { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private miniMetalTrader.Shared.Services.ClientService ClientService { get; set; }
    }
}
#pragma warning restore 1591
