#pragma checksum "C:\Users\andy2\RiderProjects\DNPStructureTest\Assignments\DNP-A4\DNP-A4-Client\Shared\MainLayout.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "ddc53fb3e2cfe82ccf045e65f2ce6b180c37da3b"
// <auto-generated/>
#pragma warning disable 1591
namespace DNP_A4_Client.Shared
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\andy2\RiderProjects\DNPStructureTest\Assignments\DNP-A4\DNP-A4-Client\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\andy2\RiderProjects\DNPStructureTest\Assignments\DNP-A4\DNP-A4-Client\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\andy2\RiderProjects\DNPStructureTest\Assignments\DNP-A4\DNP-A4-Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\andy2\RiderProjects\DNPStructureTest\Assignments\DNP-A4\DNP-A4-Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\andy2\RiderProjects\DNPStructureTest\Assignments\DNP-A4\DNP-A4-Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\andy2\RiderProjects\DNPStructureTest\Assignments\DNP-A4\DNP-A4-Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\andy2\RiderProjects\DNPStructureTest\Assignments\DNP-A4\DNP-A4-Client\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\andy2\RiderProjects\DNPStructureTest\Assignments\DNP-A4\DNP-A4-Client\_Imports.razor"
using DNP_A4_Client;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\andy2\RiderProjects\DNPStructureTest\Assignments\DNP-A4\DNP-A4-Client\_Imports.razor"
using DNP_A4_Client.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 1 "C:\Users\andy2\RiderProjects\DNPStructureTest\Assignments\DNP-A4\DNP-A4-Client\Shared\MainLayout.razor"
using A1_DNP1Y.Authentication;

#line default
#line hidden
#nullable disable
    public partial class MainLayout : LayoutComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "div");
            __builder.AddAttribute(1, "class", "sidebar");
            __builder.AddMarkupContent(2, "\r\n    ");
            __builder.OpenComponent<DNP_A4_Client.Shared.NavMenu>(3);
            __builder.CloseComponent();
            __builder.AddMarkupContent(4, "\r\n");
            __builder.CloseElement();
            __builder.AddMarkupContent(5, "\r\n\r\n");
            __builder.OpenElement(6, "div");
            __builder.AddAttribute(7, "class", "main");
            __builder.AddMarkupContent(8, "\r\n    ");
            __builder.OpenElement(9, "div");
            __builder.AddAttribute(10, "class", "top-row px-4");
            __builder.AddMarkupContent(11, "\r\n        ");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Authorization.AuthorizeView>(12);
            __builder.AddAttribute(13, "Authorized", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Authorization.AuthenticationState>)((context) => (__builder2) => {
                __builder2.AddMarkupContent(14, "\r\n                ");
                __builder2.OpenElement(15, "p");
                __builder2.AddAttribute(16, "style", "margin-bottom: 0");
                __builder2.AddContent(17, "Hi, ");
                __builder2.AddContent(18, 
#nullable restore
#line 14 "C:\Users\andy2\RiderProjects\DNPStructureTest\Assignments\DNP-A4\DNP-A4-Client\Shared\MainLayout.razor"
                                                 context.User.Identity.Name

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
                __builder2.AddMarkupContent(19, "\r\n                ");
                __builder2.OpenElement(20, "a");
                __builder2.AddAttribute(21, "href", "");
                __builder2.AddAttribute(22, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 15 "C:\Users\andy2\RiderProjects\DNPStructureTest\Assignments\DNP-A4\DNP-A4-Client\Shared\MainLayout.razor"
                                     PerformLogout

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddContent(23, " Log out ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(24, "\r\n            ");
            }
            ));
            __builder.AddAttribute(25, "NotAuthorized", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Authorization.AuthenticationState>)((context) => (__builder2) => {
                __builder2.AddMarkupContent(26, "\r\n                ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Routing.NavLink>(27);
                __builder2.AddAttribute(28, "href", "Login");
                __builder2.AddAttribute(29, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.AddContent(30, "Login");
                }
                ));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(31, "\r\n            ");
            }
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(32, "\r\n        ");
            __builder.AddMarkupContent(33, "<a href=\"https://docs.microsoft.com/aspnet/\" target=\"_blank\">About</a>\r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(34, "\r\n\r\n    ");
            __builder.OpenElement(35, "div");
            __builder.AddAttribute(36, "class", "content px-4");
            __builder.AddMarkupContent(37, "\r\n        ");
            __builder.AddContent(38, 
#nullable restore
#line 25 "C:\Users\andy2\RiderProjects\DNPStructureTest\Assignments\DNP-A4\DNP-A4-Client\Shared\MainLayout.razor"
         Body

#line default
#line hidden
#nullable disable
            );
            __builder.AddMarkupContent(39, "\r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(40, "\r\n");
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 29 "C:\Users\andy2\RiderProjects\DNPStructureTest\Assignments\DNP-A4\DNP-A4-Client\Shared\MainLayout.razor"
      

    [CascadingParameter]
    protected Task<AuthenticationState> AuthStat { get; set; }

    protected async override Task OnInitializedAsync()
    {
        base.OnInitialized();
        var user = (await AuthStat).User;
        if (!user.Identity.IsAuthenticated)
        {
            NavigationManager.NavigateTo($"/Login");
        }
    }

    public async Task PerformLogout()
    {
        try
        {
            ((CustomAuthenticationStateProvider) AuthenticationStateProvider).Logout();
            NavigationManager.NavigateTo("/");
        }
        catch (Exception e)
        {
        }
    }


#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager NavigationManager { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private AuthenticationStateProvider AuthenticationStateProvider { get; set; }
    }
}
#pragma warning restore 1591
