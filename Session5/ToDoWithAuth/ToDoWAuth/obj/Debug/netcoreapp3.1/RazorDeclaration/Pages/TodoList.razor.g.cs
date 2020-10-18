#pragma checksum "C:\Users\andy2\RiderProjects\DNPStructureTest\Session5\ToDoWithAuth\ToDoWAuth\Pages\TodoList.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "b0d354e8289c3ede35dbf3045a79d559ca1245d7"
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
#line 2 "C:\Users\andy2\RiderProjects\DNPStructureTest\Session5\ToDoWithAuth\ToDoWAuth\Pages\TodoList.razor"
using ToDoWAuth.Data;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\andy2\RiderProjects\DNPStructureTest\Session5\ToDoWithAuth\ToDoWAuth\Pages\TodoList.razor"
using ToDoWAuth.Model;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\andy2\RiderProjects\DNPStructureTest\Session5\ToDoWithAuth\ToDoWAuth\Pages\TodoList.razor"
using System.Text.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\andy2\RiderProjects\DNPStructureTest\Session5\ToDoWithAuth\ToDoWAuth\Pages\TodoList.razor"
using Microsoft.AspNetCore.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\andy2\RiderProjects\DNPStructureTest\Session5\ToDoWithAuth\ToDoWAuth\Pages\TodoList.razor"
using System.Security.Claims;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/TodoList")]
    public partial class TodoList : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 117 "C:\Users\andy2\RiderProjects\DNPStructureTest\Session5\ToDoWithAuth\ToDoWAuth\Pages\TodoList.razor"
       
    private IList<Todo> todosToShow;
    private IList<Todo> allTodos;
    private IList<Todo> ownTodosToShow;
    private int? filterById;
    private bool? filterByIsCompleted;

    private void FilterByUserId(ChangeEventArgs changeEventArgs)
    {
        filterById = null;
        try
        {
            filterById = int.Parse(changeEventArgs.Value.ToString());
        }
        catch (Exception e)
        {
        }
        ExecuteFilter();
    }

    private void FilterByCompletedStatus(ChangeEventArgs args)
    {
        filterByIsCompleted = null;
        try
        {
            filterByIsCompleted = bool.Parse(args.Value.ToString());
        }
        catch (Exception e)
        {
        }
        ExecuteFilter();
    }

    private void ExecuteFilter()
    {
        todosToShow = allTodos.Where(t =>
            (filterById != null && t.UserId == filterById || filterById == null) &&
            (filterByIsCompleted != null && t.IsCompleted == filterByIsCompleted || filterByIsCompleted == null)
            ).ToList();
    }


    protected override async Task OnInitializedAsync()
    {
        allTodos = TodosService.GetTodos();
        todosToShow = allTodos;

        var authState = await AuthenticationStateProvider.GetAuthenticationStateAsync();
        var user = authState.User;
        Claim userClaim = user.FindFirst(claim => claim.Type.Equals("Id"));
        ownTodosToShow = allTodos.Where(t =>
            t.UserId == Convert.ToInt32(userClaim.Value)).ToList();
    }

    private void RemoveTodo(int todoId)
    {
        Todo todoToRemove = allTodos.First(t => t.TodoId == todoId);
        TodosService.RemoveTodo(todoId);
        allTodos.Remove(todoToRemove);
    }

    private void CompletedChange(ChangeEventArgs evt, Todo todo)
    {
        todo.IsCompleted = (bool) evt.Value;
        TodosService.Update(todo);
    }


#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private AuthenticationStateProvider AuthenticationStateProvider { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private ITodosService TodosService { get; set; }
    }
}
#pragma warning restore 1591