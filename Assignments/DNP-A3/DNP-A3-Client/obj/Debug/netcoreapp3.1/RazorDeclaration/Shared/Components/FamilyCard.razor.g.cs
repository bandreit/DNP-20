#pragma checksum "C:\Users\andy2\RiderProjects\DNPStructureTest\Assignments\DNP-A3\DNP-A3-Client\Shared\Components\FamilyCard.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "0357434179cf1238aff184d5b8f61bbe3313ccf5"
// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace DNP_A3.Shared.Components
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\andy2\RiderProjects\DNPStructureTest\Assignments\DNP-A3\DNP-A3-Client\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\andy2\RiderProjects\DNPStructureTest\Assignments\DNP-A3\DNP-A3-Client\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\andy2\RiderProjects\DNPStructureTest\Assignments\DNP-A3\DNP-A3-Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\andy2\RiderProjects\DNPStructureTest\Assignments\DNP-A3\DNP-A3-Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\andy2\RiderProjects\DNPStructureTest\Assignments\DNP-A3\DNP-A3-Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\andy2\RiderProjects\DNPStructureTest\Assignments\DNP-A3\DNP-A3-Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\andy2\RiderProjects\DNPStructureTest\Assignments\DNP-A3\DNP-A3-Client\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\andy2\RiderProjects\DNPStructureTest\Assignments\DNP-A3\DNP-A3-Client\_Imports.razor"
using DNP_A3;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\andy2\RiderProjects\DNPStructureTest\Assignments\DNP-A3\DNP-A3-Client\_Imports.razor"
using DNP_A3.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 1 "C:\Users\andy2\RiderProjects\DNPStructureTest\Assignments\DNP-A3\DNP-A3-Client\Shared\Components\FamilyCard.razor"
using Syncfusion.Blazor.Cards;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\andy2\RiderProjects\DNPStructureTest\Assignments\DNP-A3\DNP-A3-Client\Shared\Components\FamilyCard.razor"
using Syncfusion.Blazor.Buttons;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\andy2\RiderProjects\DNPStructureTest\Assignments\DNP-A3\DNP-A3-Client\Shared\Components\FamilyCard.razor"
using global::Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\andy2\RiderProjects\DNPStructureTest\Assignments\DNP-A3\DNP-A3-Client\Shared\Components\FamilyCard.razor"
using A1_DNP1Y.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\andy2\RiderProjects\DNPStructureTest\Assignments\DNP-A3\DNP-A3-Client\Shared\Components\FamilyCard.razor"
using A1_DNP1Y.Data.Impl;

#line default
#line hidden
#nullable disable
    public partial class FamilyCard : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 84 "C:\Users\andy2\RiderProjects\DNPStructureTest\Assignments\DNP-A3\DNP-A3-Client\Shared\Components\FamilyCard.razor"
      
    bool Expand = false;

#line default
#line hidden
#nullable disable
#nullable restore
#line 141 "C:\Users\andy2\RiderProjects\DNPStructureTest\Assignments\DNP-A3\DNP-A3-Client\Shared\Components\FamilyCard.razor"
       

    [Parameter]
    public Family Family { get; set; }

    [Parameter]
    public Func<string, int, Task> RemoveFamily { get; set; }
    
    [Parameter]
    public EventCallback<int?> EditThisFamily { get; set; }

    private string LastNames { get; set; } = "";

    protected async override Task OnInitializedAsync()
    {
    }



#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IWebFamilyService WebFamilyService { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager NavigationManager { get; set; }
    }
}
#pragma warning restore 1591
