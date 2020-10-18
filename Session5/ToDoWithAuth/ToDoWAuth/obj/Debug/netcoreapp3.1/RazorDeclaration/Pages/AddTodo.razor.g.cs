#pragma checksum "C:\Users\andy2\RiderProjects\DNPStructureTest\Session5\ToDoWithAuth\ToDoWAuth\Pages\AddTodo.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "6932630d2d7580b9b9176ac2c6f7b88ef6abcca4"
// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace ToDoWAuth.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\andy2\RiderProjects\DNPStructureTest\Session5\ToDoWithAuth\ToDoWAuth\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\andy2\RiderProjects\DNPStructureTest\Session5\ToDoWithAuth\ToDoWAuth\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\andy2\RiderProjects\DNPStructureTest\Session5\ToDoWithAuth\ToDoWAuth\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\andy2\RiderProjects\DNPStructureTest\Session5\ToDoWithAuth\ToDoWAuth\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\andy2\RiderProjects\DNPStructureTest\Session5\ToDoWithAuth\ToDoWAuth\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\andy2\RiderProjects\DNPStructureTest\Session5\ToDoWithAuth\ToDoWAuth\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\andy2\RiderProjects\DNPStructureTest\Session5\ToDoWithAuth\ToDoWAuth\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\andy2\RiderProjects\DNPStructureTest\Session5\ToDoWithAuth\ToDoWAuth\_Imports.razor"
using ToDoWAuth;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\andy2\RiderProjects\DNPStructureTest\Session5\ToDoWithAuth\ToDoWAuth\_Imports.razor"
using ToDoWAuth.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\andy2\RiderProjects\DNPStructureTest\Session5\ToDoWithAuth\ToDoWAuth\Pages\AddTodo.razor"
using ToDoWAuth.Data;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\andy2\RiderProjects\DNPStructureTest\Session5\ToDoWithAuth\ToDoWAuth\Pages\AddTodo.razor"
using ToDoWAuth.Model;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\andy2\RiderProjects\DNPStructureTest\Session5\ToDoWithAuth\ToDoWAuth\Pages\AddTodo.razor"
using System.Security.Claims;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/AddTodo")]
    public partial class AddTodo : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 37 "C:\Users\andy2\RiderProjects\DNPStructureTest\Session5\ToDoWithAuth\ToDoWAuth\Pages\AddTodo.razor"
       
    private Todo newTodoItem = new Todo();

    protected async override Task OnInitializedAsync()
    {
        var authState = await AuthenticationStateProvider.GetAuthenticationStateAsync();
        var user = authState.User;
        Claim userClaim = user.FindFirst(claim => claim.Type.Equals("Id"));
        newTodoItem.UserId = Convert.ToInt32(userClaim.Value);
    }

    private void AddNewTodo()
    {
        TodoService.AddTodo(newTodoItem);
        NavigationManager.NavigateTo("/TodoList");
    }


#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private AuthenticationStateProvider AuthenticationStateProvider { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager NavigationManager { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private ITodosService TodoService { get; set; }
    }
}
#pragma warning restore 1591
