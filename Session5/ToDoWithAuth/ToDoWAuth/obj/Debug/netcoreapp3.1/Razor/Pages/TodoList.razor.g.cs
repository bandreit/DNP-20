#pragma checksum "C:\Users\andy2\RiderProjects\DNPStructureTest\Session5\ToDoWithAuth\ToDoWAuth\Pages\TodoList.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "91ae23351a5f2a81f3c1a0649bab1df9a0f658c7"
// <auto-generated/>
#pragma warning disable 1591
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
            __builder.AddMarkupContent(0, "<h3>TodoList</h3>\r\n");
            __builder.OpenElement(1, "p");
            __builder.AddMarkupContent(2, "\r\n    Filter by User Id:\r\n    ");
            __builder.OpenElement(3, "input");
            __builder.AddAttribute(4, "type", "number");
            __builder.AddAttribute(5, "oninput", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.ChangeEventArgs>(this, 
#nullable restore
#line 13 "C:\Users\andy2\RiderProjects\DNPStructureTest\Session5\ToDoWithAuth\ToDoWAuth\Pages\TodoList.razor"
                                     (arg) => FilterByUserId(arg)

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(6, "style", "width:50px");
            __builder.CloseElement();
            __builder.AddMarkupContent(7, "\r\n");
            __builder.CloseElement();
            __builder.AddMarkupContent(8, "\r\n\r\n");
            __builder.OpenElement(9, "p");
            __builder.AddMarkupContent(10, "\r\n    Filter by completed status:\r\n    ");
            __builder.OpenElement(11, "select");
            __builder.AddAttribute(12, "class", "form-control selectpicker");
            __builder.AddAttribute(13, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.ChangeEventArgs>(this, 
#nullable restore
#line 18 "C:\Users\andy2\RiderProjects\DNPStructureTest\Session5\ToDoWithAuth\ToDoWAuth\Pages\TodoList.razor"
                                                           (arg) => FilterByCompletedStatus(arg)

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(14, "style", "width:100px");
            __builder.AddMarkupContent(15, "\r\n        ");
            __builder.OpenElement(16, "option");
            __builder.AddContent(17, "Both");
            __builder.CloseElement();
            __builder.AddMarkupContent(18, "\r\n        ");
            __builder.OpenElement(19, "option");
            __builder.AddContent(20, "False");
            __builder.CloseElement();
            __builder.AddMarkupContent(21, "\r\n        ");
            __builder.OpenElement(22, "option");
            __builder.AddContent(23, "True");
            __builder.CloseElement();
            __builder.AddMarkupContent(24, "\r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(25, "\r\n");
            __builder.CloseElement();
            __builder.AddMarkupContent(26, "\r\n\r\n");
#nullable restore
#line 25 "C:\Users\andy2\RiderProjects\DNPStructureTest\Session5\ToDoWithAuth\ToDoWAuth\Pages\TodoList.razor"
 if (allTodos == null || ownTodosToShow == null)
{

#line default
#line hidden
#nullable disable
            __builder.AddContent(27, "    ");
            __builder.AddMarkupContent(28, "<p>\r\n        <em>Loading...</em>\r\n    </p>\r\n");
#nullable restore
#line 30 "C:\Users\andy2\RiderProjects\DNPStructureTest\Session5\ToDoWithAuth\ToDoWAuth\Pages\TodoList.razor"
}
else if (!allTodos.Any())
{

#line default
#line hidden
#nullable disable
            __builder.AddContent(29, "    ");
            __builder.AddMarkupContent(30, "<p>\r\n        <em>No ToDo items exist. Please add some.</em>\r\n    </p>\r\n");
#nullable restore
#line 36 "C:\Users\andy2\RiderProjects\DNPStructureTest\Session5\ToDoWithAuth\ToDoWAuth\Pages\TodoList.razor"
}
else
{

#line default
#line hidden
#nullable disable
            __builder.AddContent(31, "    ");
            __builder.OpenElement(32, "table");
            __builder.AddAttribute(33, "class", "table");
            __builder.AddMarkupContent(34, "\r\n        ");
            __builder.AddMarkupContent(35, "<thead>\r\n        <tr>\r\n            <th>User ID</th> <th>Todo ID</th> <th>Title</th> <th>Completed?</th>\r\n        </tr>\r\n        </thead>\r\n        ");
            __builder.OpenElement(36, "tbody");
            __builder.AddMarkupContent(37, "\r\n        ");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Authorization.AuthorizeView>(38);
            __builder.AddAttribute(39, "Policy", "PrivateToDoer");
            __builder.AddAttribute(40, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Authorization.AuthenticationState>)((PrivateToDoer) => (__builder2) => {
                __builder2.AddMarkupContent(41, "\r\n");
#nullable restore
#line 47 "C:\Users\andy2\RiderProjects\DNPStructureTest\Session5\ToDoWithAuth\ToDoWAuth\Pages\TodoList.razor"
             foreach (var item in todosToShow)
            {

#line default
#line hidden
#nullable disable
                __builder2.AddContent(42, "                ");
                __builder2.OpenElement(43, "tr");
                __builder2.AddMarkupContent(44, "\r\n                    ");
                __builder2.OpenElement(45, "td");
                __builder2.AddContent(46, 
#nullable restore
#line 50 "C:\Users\andy2\RiderProjects\DNPStructureTest\Session5\ToDoWithAuth\ToDoWAuth\Pages\TodoList.razor"
                         item.UserId

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
                __builder2.AddMarkupContent(47, "\r\n                    ");
                __builder2.OpenElement(48, "td");
                __builder2.AddContent(49, 
#nullable restore
#line 51 "C:\Users\andy2\RiderProjects\DNPStructureTest\Session5\ToDoWithAuth\ToDoWAuth\Pages\TodoList.razor"
                         item.TodoId

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
                __builder2.AddMarkupContent(50, "\r\n                    ");
                __builder2.AddMarkupContent(51, "<td>hinea</td>\r\n                    ");
                __builder2.OpenElement(52, "td");
                __builder2.AddAttribute(53, "style", "text-decoration:" + " " + (
#nullable restore
#line 53 "C:\Users\andy2\RiderProjects\DNPStructureTest\Session5\ToDoWithAuth\ToDoWAuth\Pages\TodoList.razor"
                                                  item.IsCompleted ? "line-through" : "none"

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddContent(54, 
#nullable restore
#line 53 "C:\Users\andy2\RiderProjects\DNPStructureTest\Session5\ToDoWithAuth\ToDoWAuth\Pages\TodoList.razor"
                                                                                                item.Title

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
                __builder2.AddMarkupContent(55, "\r\n                    ");
                __builder2.OpenElement(56, "td");
                __builder2.AddMarkupContent(57, "\r\n                        ");
                __builder2.OpenElement(58, "input");
                __builder2.AddAttribute(59, "type", "checkbox");
                __builder2.AddAttribute(60, "checked", 
#nullable restore
#line 55 "C:\Users\andy2\RiderProjects\DNPStructureTest\Session5\ToDoWithAuth\ToDoWAuth\Pages\TodoList.razor"
                                                        item.IsCompleted

#line default
#line hidden
#nullable disable
                );
                __builder2.AddAttribute(61, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.ChangeEventArgs>(this, 
#nullable restore
#line 55 "C:\Users\andy2\RiderProjects\DNPStructureTest\Session5\ToDoWithAuth\ToDoWAuth\Pages\TodoList.razor"
                                                                                      (arg) => CompletedChange(arg, item)

#line default
#line hidden
#nullable disable
                ));
                __builder2.CloseElement();
                __builder2.AddMarkupContent(62, "\r\n                    ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(63, "\r\n                    ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Authorization.AuthorizeView>(64);
                __builder2.AddAttribute(65, "Policy", "CanDeleteTodo");
                __builder2.AddAttribute(66, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Authorization.AuthenticationState>)((context) => (__builder3) => {
                    __builder3.AddMarkupContent(67, "\r\n                        ");
                    __builder3.OpenElement(68, "td");
                    __builder3.AddMarkupContent(69, "\r\n                            ");
                    __builder3.OpenElement(70, "button");
                    __builder3.AddAttribute(71, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 59 "C:\Users\andy2\RiderProjects\DNPStructureTest\Session5\ToDoWithAuth\ToDoWAuth\Pages\TodoList.razor"
                                               () => RemoveTodo(item.TodoId)

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddMarkupContent(72, "\r\n                                <i class=\"oi oi-trash\" style=\"color: red\"></i>\r\n                            ");
                    __builder3.CloseElement();
                    __builder3.AddMarkupContent(73, "\r\n                        ");
                    __builder3.CloseElement();
                    __builder3.AddMarkupContent(74, "\r\n                    ");
                }
                ));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(75, "\r\n                ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(76, "\r\n");
#nullable restore
#line 65 "C:\Users\andy2\RiderProjects\DNPStructureTest\Session5\ToDoWithAuth\ToDoWAuth\Pages\TodoList.razor"
            }

#line default
#line hidden
#nullable disable
                __builder2.AddContent(77, "        ");
            }
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(78, "\r\n        ");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Authorization.AuthorizeView>(79);
            __builder.AddAttribute(80, "Policy", "CanViewAllToDos");
            __builder.AddAttribute(81, "Authorized", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Authorization.AuthenticationState>)((CanViewAllToDos) => (__builder2) => {
                __builder2.AddMarkupContent(82, "\r\n");
#nullable restore
#line 69 "C:\Users\andy2\RiderProjects\DNPStructureTest\Session5\ToDoWithAuth\ToDoWAuth\Pages\TodoList.razor"
                 foreach (var item in ownTodosToShow)
                {

#line default
#line hidden
#nullable disable
                __builder2.AddContent(83, "                    ");
                __builder2.OpenElement(84, "tr");
                __builder2.AddMarkupContent(85, "\r\n                        ");
                __builder2.OpenElement(86, "td");
                __builder2.AddContent(87, 
#nullable restore
#line 72 "C:\Users\andy2\RiderProjects\DNPStructureTest\Session5\ToDoWithAuth\ToDoWAuth\Pages\TodoList.razor"
                             item.UserId

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
                __builder2.AddMarkupContent(88, "\r\n                        ");
                __builder2.OpenElement(89, "td");
                __builder2.AddContent(90, 
#nullable restore
#line 73 "C:\Users\andy2\RiderProjects\DNPStructureTest\Session5\ToDoWithAuth\ToDoWAuth\Pages\TodoList.razor"
                             item.TodoId

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
                __builder2.AddMarkupContent(91, "\r\n                        ");
                __builder2.OpenElement(92, "td");
                __builder2.AddAttribute(93, "style", "text-decoration:" + " " + (
#nullable restore
#line 74 "C:\Users\andy2\RiderProjects\DNPStructureTest\Session5\ToDoWithAuth\ToDoWAuth\Pages\TodoList.razor"
                                                      item.IsCompleted ? "line-through" : "none"

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddContent(94, 
#nullable restore
#line 74 "C:\Users\andy2\RiderProjects\DNPStructureTest\Session5\ToDoWithAuth\ToDoWAuth\Pages\TodoList.razor"
                                                                                                    item.Title

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
                __builder2.AddMarkupContent(95, "\r\n                        ");
                __builder2.OpenElement(96, "td");
                __builder2.AddMarkupContent(97, "\r\n                            ");
                __builder2.OpenElement(98, "input");
                __builder2.AddAttribute(99, "type", "checkbox");
                __builder2.AddAttribute(100, "checked", 
#nullable restore
#line 76 "C:\Users\andy2\RiderProjects\DNPStructureTest\Session5\ToDoWithAuth\ToDoWAuth\Pages\TodoList.razor"
                                                            item.IsCompleted

#line default
#line hidden
#nullable disable
                );
                __builder2.AddAttribute(101, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.ChangeEventArgs>(this, 
#nullable restore
#line 76 "C:\Users\andy2\RiderProjects\DNPStructureTest\Session5\ToDoWithAuth\ToDoWAuth\Pages\TodoList.razor"
                                                                                          (arg) => CompletedChange(arg, item)

#line default
#line hidden
#nullable disable
                ));
                __builder2.CloseElement();
                __builder2.AddMarkupContent(102, "\r\n                        ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(103, "\r\n                        ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Authorization.AuthorizeView>(104);
                __builder2.AddAttribute(105, "Policy", "CanDeleteTodo");
                __builder2.AddAttribute(106, "Authorized", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Authorization.AuthenticationState>)((context) => (__builder3) => {
                    __builder3.AddMarkupContent(107, "\r\n                                ");
                    __builder3.OpenElement(108, "td");
                    __builder3.AddMarkupContent(109, "\r\n                                    ");
                    __builder3.OpenElement(110, "button");
                    __builder3.AddAttribute(111, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 81 "C:\Users\andy2\RiderProjects\DNPStructureTest\Session5\ToDoWithAuth\ToDoWAuth\Pages\TodoList.razor"
                                                       () => RemoveTodo(item.TodoId)

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddMarkupContent(112, "\r\n                                        <i class=\"oi oi-trash\" style=\"color: red\"></i>\r\n                                    ");
                    __builder3.CloseElement();
                    __builder3.AddMarkupContent(113, "\r\n                                ");
                    __builder3.CloseElement();
                    __builder3.AddMarkupContent(114, "\r\n                            ");
                }
                ));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(115, "\r\n                    ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(116, "\r\n");
#nullable restore
#line 88 "C:\Users\andy2\RiderProjects\DNPStructureTest\Session5\ToDoWithAuth\ToDoWAuth\Pages\TodoList.razor"
                }

#line default
#line hidden
#nullable disable
                __builder2.AddContent(117, "            ");
            }
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(118, "\r\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(119, "\r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(120, "\r\n");
#nullable restore
#line 93 "C:\Users\andy2\RiderProjects\DNPStructureTest\Session5\ToDoWithAuth\ToDoWAuth\Pages\TodoList.razor"
}

#line default
#line hidden
#nullable disable
        }
        #pragma warning restore 1998
#nullable restore
#line 96 "C:\Users\andy2\RiderProjects\DNPStructureTest\Session5\ToDoWithAuth\ToDoWAuth\Pages\TodoList.razor"
       
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
        
        Console.Out.WriteLine(userClaim.Value);
        
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
