// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace miniMetalTrader.Pages
{
    #line hidden
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
#line 2 "C:\Users\widge\source\repos\miniMetalTrader\miniMetalTrader\Pages\Buy.razor"
using System;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\widge\source\repos\miniMetalTrader\miniMetalTrader\Pages\Buy.razor"
using miniMetalTrader.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\widge\source\repos\miniMetalTrader\miniMetalTrader\Pages\Buy.razor"
using System.Linq;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/buy/{id}/{ticker}")]
    public partial class Buy : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 53 "C:\Users\widge\source\repos\miniMetalTrader\miniMetalTrader\Pages\Buy.razor"
       

    [Parameter]
    public string Id { get; set; }

    [Parameter]
    public string Ticker { get; set; }

    private Instrument Instrument { get; set; }
    private Client client { get; set; }
    private Order order { get; set; }

    protected async Task Preview()
    {
        order = await OrderService.CreateOrderAsync(order);
    }

    protected async Task Confirm()
    {
        //NavManager.NavigateTo($"/confirm/{order.PositionId}");

        order = await OrderService.CommitOrderAsync(order);
        client.Account.Balance -= order.Value();
        client.Account.Positions.Add(order);
    }

    protected override async Task OnInitializedAsync()
    {
        this.Instrument = ClientService.GetInstruments().Where(i => i.Ticker == Ticker).FirstOrDefault();
        this.client = ClientService.GetClients().Where(c => c.ClientId == Id).First();
        order = new Order
        {
            Instrument = this.Instrument,
            OrderType = OrderTypes.Buy,
            Price = Instrument.Price,
            Quantity = this.Instrument.MinBuyOrder
        };

        // async POST to create the order... when order is created nav OR post the data as part of page
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager NavManager { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private miniMetalTrader.Shared.Services.OrderService OrderService { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private miniMetalTrader.Shared.Services.RatesService RatesService { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private miniMetalTrader.Shared.Services.ClientService ClientService { get; set; }
    }
}
#pragma warning restore 1591
