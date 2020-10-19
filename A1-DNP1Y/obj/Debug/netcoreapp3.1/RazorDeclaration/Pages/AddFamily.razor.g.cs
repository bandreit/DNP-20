#pragma checksum "C:\Users\andy2\RiderProjects\DNPStructureTest\A1-DNP1Y\Pages\AddFamily.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "daf365d2246443dd2470f1ce66dbdddbc8552db7"
// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace A1_DNP1Y.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\andy2\RiderProjects\DNPStructureTest\A1-DNP1Y\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\andy2\RiderProjects\DNPStructureTest\A1-DNP1Y\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\andy2\RiderProjects\DNPStructureTest\A1-DNP1Y\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\andy2\RiderProjects\DNPStructureTest\A1-DNP1Y\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\andy2\RiderProjects\DNPStructureTest\A1-DNP1Y\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\andy2\RiderProjects\DNPStructureTest\A1-DNP1Y\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\andy2\RiderProjects\DNPStructureTest\A1-DNP1Y\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\andy2\RiderProjects\DNPStructureTest\A1-DNP1Y\_Imports.razor"
using A1_DNP1Y;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\andy2\RiderProjects\DNPStructureTest\A1-DNP1Y\_Imports.razor"
using A1_DNP1Y.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\andy2\RiderProjects\DNPStructureTest\A1-DNP1Y\_Imports.razor"
using Syncfusion.Blazor;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\andy2\RiderProjects\DNPStructureTest\A1-DNP1Y\Pages\AddFamily.razor"
using A1_DNP1Y.Data.Impl;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\andy2\RiderProjects\DNPStructureTest\A1-DNP1Y\Pages\AddFamily.razor"
using A1_DNP1Y.Data;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\andy2\RiderProjects\DNPStructureTest\A1-DNP1Y\Pages\AddFamily.razor"
using A1_DNP1Y.Persistence;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\andy2\RiderProjects\DNPStructureTest\A1-DNP1Y\Pages\AddFamily.razor"
using global::Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\andy2\RiderProjects\DNPStructureTest\A1-DNP1Y\Pages\AddFamily.razor"
using Syncfusion.Blazor.Inputs;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\andy2\RiderProjects\DNPStructureTest\A1-DNP1Y\Pages\AddFamily.razor"
using Syncfusion.Blazor.DropDowns;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\andy2\RiderProjects\DNPStructureTest\A1-DNP1Y\Pages\AddFamily.razor"
using Syncfusion.Blazor.Buttons;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/add-family")]
    public partial class AddFamily : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 290 "C:\Users\andy2\RiderProjects\DNPStructureTest\A1-DNP1Y\Pages\AddFamily.razor"
       
    private Family _newFamily = new Family();

    public class SexFields
    {
        public string ID { get; set; }
        public string Text { get; set; }
    }

    private List<SexFields> Sexes = new List<SexFields>()
    {
        new SexFields() {ID = "F", Text = "Female"},
        new SexFields() {ID = "M", Text = "Male"},
        new SexFields() {ID = "Other", Text = "Other"},
    };

    private List<Interest> Interests = new List<Interest>()
    {
        new Interest() {Type = "Soccer"},
        new Interest() {Type = "Drawing"},
        new Interest() {Type = "Kite Flying"},
        new Interest() {Type = "Roller Blades"},
        new Interest() {Type = "Board Games"},
        new Interest() {Type = "Ballet"},
        new Interest() {Type = "Hockey"},
        new Interest() {Type = "Gaming"},
        new Interest() {Type = "Lego"},
        new Interest() {Type = "Scout"},
        new Interest() {Type = "Gymnastics"},
        new Interest() {Type = "Harry Potter"},
        new Interest() {Type = "Frozen"}
    };

    private string[] Value = new string[] {"Soccer"};
    
    protected async override Task OnInitializedAsync()
    {
    // var authState = await AuthenticationStateProvider.GetAuthenticationStateAsync();
    // var user = authState.User;
    // Claim userClaim = user.FindFirst(claim => claim.Type.Equals("Id"));
    // newTodoItem.UserId = Convert.ToInt32(userClaim.Value);
    }

    private void AddNewFamily()
    {
        FamilyService.AddFamily(_newFamily);
        NavigationManager.NavigateTo("/families");
    }


#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager NavigationManager { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IFamilyService FamilyService { get; set; }
    }
}
#pragma warning restore 1591
