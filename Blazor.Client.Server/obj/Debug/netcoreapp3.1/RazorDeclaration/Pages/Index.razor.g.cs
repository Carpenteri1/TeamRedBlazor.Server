#pragma checksum "C:\Users\Admin\source\repos\AspNetProjekt\OfficialSolution\TeamRedBlazor.Server\Blazor.Client.Server\Pages\Index.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "caa718a8ed9ea325094b42ad9e7a44f9e6ec7d46"
// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace TeamRedBlazor.Client.Server.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\Admin\source\repos\AspNetProjekt\OfficialSolution\TeamRedBlazor.Server\Blazor.Client.Server\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Admin\source\repos\AspNetProjekt\OfficialSolution\TeamRedBlazor.Server\Blazor.Client.Server\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\Admin\source\repos\AspNetProjekt\OfficialSolution\TeamRedBlazor.Server\Blazor.Client.Server\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\Admin\source\repos\AspNetProjekt\OfficialSolution\TeamRedBlazor.Server\Blazor.Client.Server\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\Admin\source\repos\AspNetProjekt\OfficialSolution\TeamRedBlazor.Server\Blazor.Client.Server\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\Admin\source\repos\AspNetProjekt\OfficialSolution\TeamRedBlazor.Server\Blazor.Client.Server\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\Admin\source\repos\AspNetProjekt\OfficialSolution\TeamRedBlazor.Server\Blazor.Client.Server\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\Admin\source\repos\AspNetProjekt\OfficialSolution\TeamRedBlazor.Server\Blazor.Client.Server\_Imports.razor"
using TeamRedBlazor.Client.Server.Pages;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\Admin\source\repos\AspNetProjekt\OfficialSolution\TeamRedBlazor.Server\Blazor.Client.Server\_Imports.razor"
using TeamRedBlazor.Client.Server.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\Admin\source\repos\AspNetProjekt\OfficialSolution\TeamRedBlazor.Server\Blazor.Client.Server\_Imports.razor"
using TeamRedBlazor.Client.Server.Data.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "C:\Users\Admin\source\repos\AspNetProjekt\OfficialSolution\TeamRedBlazor.Server\Blazor.Client.Server\_Imports.razor"
using TeamRedBlazor.Client.Server.Data.Services;

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "C:\Users\Admin\source\repos\AspNetProjekt\OfficialSolution\TeamRedBlazor.Server\Blazor.Client.Server\_Imports.razor"
using Microsoft.AspNetCore.Http.Extensions;

#line default
#line hidden
#nullable disable
#nullable restore
#line 13 "C:\Users\Admin\source\repos\AspNetProjekt\OfficialSolution\TeamRedBlazor.Server\Blazor.Client.Server\_Imports.razor"
using Microsoft.AspNetCore.Http;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/")]
    public partial class Index : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 30 "C:\Users\Admin\source\repos\AspNetProjekt\OfficialSolution\TeamRedBlazor.Server\Blazor.Client.Server\Pages\Index.razor"
           

        private RealEstateModel[] RealEstatesArray;

        protected override async Task OnInitializedAsync()
        {
            RealEstatesArray = await Service.GetRealEstateAsync();
        }
    

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private RealEstateService Service { get; set; }
    }
}
#pragma warning restore 1591
