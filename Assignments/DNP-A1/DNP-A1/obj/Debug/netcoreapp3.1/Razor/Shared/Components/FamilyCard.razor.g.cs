#pragma checksum "C:\Users\andy2\RiderProjects\DNPStructureTest\Assignments\DNP-A1\DNP-A1\Shared\Components\FamilyCard.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "e317c3e4c0393bfe8374569c3eb0bf56b7aaae05"
// <auto-generated/>
#pragma warning disable 1591
namespace DNP_A1.Shared.Components
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\andy2\RiderProjects\DNPStructureTest\Assignments\DNP-A1\DNP-A1\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\andy2\RiderProjects\DNPStructureTest\Assignments\DNP-A1\DNP-A1\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\andy2\RiderProjects\DNPStructureTest\Assignments\DNP-A1\DNP-A1\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\andy2\RiderProjects\DNPStructureTest\Assignments\DNP-A1\DNP-A1\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\andy2\RiderProjects\DNPStructureTest\Assignments\DNP-A1\DNP-A1\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\andy2\RiderProjects\DNPStructureTest\Assignments\DNP-A1\DNP-A1\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\andy2\RiderProjects\DNPStructureTest\Assignments\DNP-A1\DNP-A1\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\andy2\RiderProjects\DNPStructureTest\Assignments\DNP-A1\DNP-A1\_Imports.razor"
using DNP_A1;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\andy2\RiderProjects\DNPStructureTest\Assignments\DNP-A1\DNP-A1\_Imports.razor"
using DNP_A1.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 1 "C:\Users\andy2\RiderProjects\DNPStructureTest\Assignments\DNP-A1\DNP-A1\Shared\Components\FamilyCard.razor"
using Syncfusion.Blazor.Cards;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\andy2\RiderProjects\DNPStructureTest\Assignments\DNP-A1\DNP-A1\Shared\Components\FamilyCard.razor"
using Syncfusion.Blazor.Buttons;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\andy2\RiderProjects\DNPStructureTest\Assignments\DNP-A1\DNP-A1\Shared\Components\FamilyCard.razor"
using global::Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\andy2\RiderProjects\DNPStructureTest\Assignments\DNP-A1\DNP-A1\Shared\Components\FamilyCard.razor"
using A1_DNP1Y.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\andy2\RiderProjects\DNPStructureTest\Assignments\DNP-A1\DNP-A1\Shared\Components\FamilyCard.razor"
using A1_DNP1Y.Persistence;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\andy2\RiderProjects\DNPStructureTest\Assignments\DNP-A1\DNP-A1\Shared\Components\FamilyCard.razor"
using A1_DNP1Y.Data.Impl;

#line default
#line hidden
#nullable disable
    public partial class FamilyCard : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "div");
            __builder.AddAttribute(1, "class", "col-xl-3 col-lg-4 col-md-6 col-sm-6 my-2");
            __builder.AddMarkupContent(2, "\r\n    ");
            __builder.OpenComponent<Syncfusion.Blazor.Cards.SfCard>(3);
            __builder.AddAttribute(4, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.AddMarkupContent(5, "\r\n        ");
                __builder2.OpenComponent<Syncfusion.Blazor.Cards.CardHeader>(6);
                __builder2.AddAttribute(7, "Title", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 12 "C:\Users\andy2\RiderProjects\DNPStructureTest\Assignments\DNP-A1\DNP-A1\Shared\Components\FamilyCard.razor"
                            Family.GetLastNames()

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(8, "SubTitle", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 12 "C:\Users\andy2\RiderProjects\DNPStructureTest\Assignments\DNP-A1\DNP-A1\Shared\Components\FamilyCard.razor"
                                                               $"{Family.Adults.Count + Family.Children.Count} {(Family.Adults.Count + Family.Children.Count > 1 ? "people" : Family.Adults.Count + Family.Children.Count == 1 ? "person" : "people")}"

#line default
#line hidden
#nullable disable
                ));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(9, "\r\n        ");
                __builder2.OpenComponent<Syncfusion.Blazor.Cards.CardContent>(10);
                __builder2.AddAttribute(11, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.AddMarkupContent(12, "\r\n            ");
                    __builder3.OpenElement(13, "table");
                    __builder3.AddAttribute(14, "style", "margin-bottom: 10px;");
                    __builder3.AddMarkupContent(15, "\r\n                ");
                    __builder3.OpenElement(16, "tr");
                    __builder3.AddMarkupContent(17, "\r\n                    ");
                    __builder3.OpenElement(18, "td");
                    __builder3.AddMarkupContent(19, "\r\n");
#nullable restore
#line 17 "C:\Users\andy2\RiderProjects\DNPStructureTest\Assignments\DNP-A1\DNP-A1\Shared\Components\FamilyCard.razor"
                         if (Family.Children.Count > 0)
                        {

#line default
#line hidden
#nullable disable
                    __builder3.AddMarkupContent(20, "                            <img src=\"images/family.png\" alt=\"family\" class=\"img-fluid\">\r\n");
#nullable restore
#line 20 "C:\Users\andy2\RiderProjects\DNPStructureTest\Assignments\DNP-A1\DNP-A1\Shared\Components\FamilyCard.razor"
                        }
                        else
                        {

#line default
#line hidden
#nullable disable
                    __builder3.AddMarkupContent(21, "                            <img src=\"images/relationship.png\" alt=\"relationship\" class=\"img-fluid\">\r\n");
#nullable restore
#line 24 "C:\Users\andy2\RiderProjects\DNPStructureTest\Assignments\DNP-A1\DNP-A1\Shared\Components\FamilyCard.razor"
                        }

#line default
#line hidden
#nullable disable
                    __builder3.AddContent(22, "                    ");
                    __builder3.CloseElement();
                    __builder3.AddMarkupContent(23, "\r\n                ");
                    __builder3.CloseElement();
                    __builder3.AddMarkupContent(24, "\r\n                ");
                    __builder3.OpenElement(25, "tr");
                    __builder3.AddMarkupContent(26, "\r\n                    ");
                    __builder3.OpenElement(27, "div");
                    __builder3.AddAttribute(28, "style", "font-size: 16px");
                    __builder3.AddContent(29, 
#nullable restore
#line 28 "C:\Users\andy2\RiderProjects\DNPStructureTest\Assignments\DNP-A1\DNP-A1\Shared\Components\FamilyCard.razor"
                                                  Family.StreetName

#line default
#line hidden
#nullable disable
                    );
                    __builder3.AddContent(30, " ");
                    __builder3.AddContent(31, 
#nullable restore
#line 28 "C:\Users\andy2\RiderProjects\DNPStructureTest\Assignments\DNP-A1\DNP-A1\Shared\Components\FamilyCard.razor"
                                                                     Family.HouseNumber

#line default
#line hidden
#nullable disable
                    );
                    __builder3.CloseElement();
                    __builder3.AddMarkupContent(32, "\r\n                ");
                    __builder3.CloseElement();
                    __builder3.AddMarkupContent(33, "\r\n            ");
                    __builder3.CloseElement();
                    __builder3.AddMarkupContent(34, "\r\n");
#nullable restore
#line 31 "C:\Users\andy2\RiderProjects\DNPStructureTest\Assignments\DNP-A1\DNP-A1\Shared\Components\FamilyCard.razor"
             if (Expand)
            {
                List<Adult> adults = Family.Adults;
                List<Child> kids = Family.Children;
                List<Pet> pets = Family.Pets;

                

#line default
#line hidden
#nullable disable
#nullable restore
#line 37 "C:\Users\andy2\RiderProjects\DNPStructureTest\Assignments\DNP-A1\DNP-A1\Shared\Components\FamilyCard.razor"
                 if (adults.Count > 0)
                {

#line default
#line hidden
#nullable disable
                    __builder3.AddContent(35, "                    ");
                    __builder3.AddMarkupContent(36, "<p>Adults:</p>\r\n                    ");
                    __builder3.OpenElement(37, "div");
                    __builder3.AddAttribute(38, "style", "padding-left: 10px");
                    __builder3.AddMarkupContent(39, "\r\n");
#nullable restore
#line 41 "C:\Users\andy2\RiderProjects\DNPStructureTest\Assignments\DNP-A1\DNP-A1\Shared\Components\FamilyCard.razor"
                         foreach (var adult in adults)
                        {

#line default
#line hidden
#nullable disable
                    __builder3.AddContent(40, "                            ");
                    __builder3.OpenElement(41, "p");
                    __builder3.AddContent(42, 
#nullable restore
#line 43 "C:\Users\andy2\RiderProjects\DNPStructureTest\Assignments\DNP-A1\DNP-A1\Shared\Components\FamilyCard.razor"
                                adult.FirstName

#line default
#line hidden
#nullable disable
                    );
                    __builder3.AddContent(43, " ");
                    __builder3.AddContent(44, 
#nullable restore
#line 43 "C:\Users\andy2\RiderProjects\DNPStructureTest\Assignments\DNP-A1\DNP-A1\Shared\Components\FamilyCard.razor"
                                                 adult.LastName

#line default
#line hidden
#nullable disable
                    );
                    __builder3.CloseElement();
                    __builder3.AddMarkupContent(45, "\r\n");
#nullable restore
#line 44 "C:\Users\andy2\RiderProjects\DNPStructureTest\Assignments\DNP-A1\DNP-A1\Shared\Components\FamilyCard.razor"
                        }

#line default
#line hidden
#nullable disable
                    __builder3.AddContent(46, "                    ");
                    __builder3.CloseElement();
                    __builder3.AddMarkupContent(47, "\r\n");
#nullable restore
#line 46 "C:\Users\andy2\RiderProjects\DNPStructureTest\Assignments\DNP-A1\DNP-A1\Shared\Components\FamilyCard.razor"
                }

#line default
#line hidden
#nullable disable
#nullable restore
#line 48 "C:\Users\andy2\RiderProjects\DNPStructureTest\Assignments\DNP-A1\DNP-A1\Shared\Components\FamilyCard.razor"
                 if (kids.Count > 0)
                {

#line default
#line hidden
#nullable disable
                    __builder3.AddContent(48, "                    ");
                    __builder3.AddMarkupContent(49, "<p>Kids:</p>\r\n                    ");
                    __builder3.OpenElement(50, "div");
                    __builder3.AddAttribute(51, "style", "padding-left: 10px");
                    __builder3.AddMarkupContent(52, "\r\n");
#nullable restore
#line 52 "C:\Users\andy2\RiderProjects\DNPStructureTest\Assignments\DNP-A1\DNP-A1\Shared\Components\FamilyCard.razor"
                         foreach (var kid in kids)
                        {

#line default
#line hidden
#nullable disable
                    __builder3.AddContent(53, "                            ");
                    __builder3.OpenElement(54, "p");
                    __builder3.AddContent(55, 
#nullable restore
#line 54 "C:\Users\andy2\RiderProjects\DNPStructureTest\Assignments\DNP-A1\DNP-A1\Shared\Components\FamilyCard.razor"
                                kid.FirstName

#line default
#line hidden
#nullable disable
                    );
                    __builder3.AddContent(56, " ");
                    __builder3.AddContent(57, 
#nullable restore
#line 54 "C:\Users\andy2\RiderProjects\DNPStructureTest\Assignments\DNP-A1\DNP-A1\Shared\Components\FamilyCard.razor"
                                               kid.LastName

#line default
#line hidden
#nullable disable
                    );
                    __builder3.CloseElement();
                    __builder3.AddMarkupContent(58, "\r\n");
#nullable restore
#line 55 "C:\Users\andy2\RiderProjects\DNPStructureTest\Assignments\DNP-A1\DNP-A1\Shared\Components\FamilyCard.razor"
                        }

#line default
#line hidden
#nullable disable
                    __builder3.AddContent(59, "                    ");
                    __builder3.CloseElement();
                    __builder3.AddMarkupContent(60, "\r\n");
#nullable restore
#line 57 "C:\Users\andy2\RiderProjects\DNPStructureTest\Assignments\DNP-A1\DNP-A1\Shared\Components\FamilyCard.razor"
                }

#line default
#line hidden
#nullable disable
#nullable restore
#line 59 "C:\Users\andy2\RiderProjects\DNPStructureTest\Assignments\DNP-A1\DNP-A1\Shared\Components\FamilyCard.razor"
                 if (!(pets is null))
                {

#line default
#line hidden
#nullable disable
                    __builder3.AddContent(61, "                    ");
                    __builder3.AddMarkupContent(62, "<p>Pets:</p>\r\n                    ");
                    __builder3.OpenElement(63, "div");
                    __builder3.AddAttribute(64, "style", "padding-left: 10px");
                    __builder3.AddMarkupContent(65, "\r\n");
#nullable restore
#line 63 "C:\Users\andy2\RiderProjects\DNPStructureTest\Assignments\DNP-A1\DNP-A1\Shared\Components\FamilyCard.razor"
                         foreach (var pet in pets)
                        {

#line default
#line hidden
#nullable disable
                    __builder3.AddContent(66, "                            ");
                    __builder3.OpenElement(67, "p");
                    __builder3.AddContent(68, 
#nullable restore
#line 65 "C:\Users\andy2\RiderProjects\DNPStructureTest\Assignments\DNP-A1\DNP-A1\Shared\Components\FamilyCard.razor"
                                pet.Name

#line default
#line hidden
#nullable disable
                    );
                    __builder3.CloseElement();
                    __builder3.AddMarkupContent(69, "\r\n");
#nullable restore
#line 66 "C:\Users\andy2\RiderProjects\DNPStructureTest\Assignments\DNP-A1\DNP-A1\Shared\Components\FamilyCard.razor"
                        }

#line default
#line hidden
#nullable disable
                    __builder3.AddContent(70, "                    ");
                    __builder3.CloseElement();
                    __builder3.AddMarkupContent(71, "\r\n");
#nullable restore
#line 68 "C:\Users\andy2\RiderProjects\DNPStructureTest\Assignments\DNP-A1\DNP-A1\Shared\Components\FamilyCard.razor"
                }

#line default
#line hidden
#nullable disable
#nullable restore
#line 68 "C:\Users\andy2\RiderProjects\DNPStructureTest\Assignments\DNP-A1\DNP-A1\Shared\Components\FamilyCard.razor"
                 
            }

#line default
#line hidden
#nullable disable
                    __builder3.AddContent(72, "        ");
                }
                ));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(73, "\r\n        ");
                __builder2.OpenComponent<Syncfusion.Blazor.Cards.CardContent>(74);
                __builder2.AddAttribute(75, "EnableSeperator", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 71 "C:\Users\andy2\RiderProjects\DNPStructureTest\Assignments\DNP-A1\DNP-A1\Shared\Components\FamilyCard.razor"
                                      true

#line default
#line hidden
#nullable disable
                ));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(76, "\r\n        ");
                __builder2.OpenComponent<Syncfusion.Blazor.Cards.CardFooter>(77);
                __builder2.AddAttribute(78, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.AddMarkupContent(79, "\r\n            ");
                    __builder3.OpenComponent<Syncfusion.Blazor.Cards.CardFooterContent>(80);
                    __builder3.AddAttribute(81, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder4) => {
                        __builder4.AddMarkupContent(82, "\r\n                ");
                        __builder4.OpenComponent<Syncfusion.Blazor.Buttons.SfButton>(83);
                        __builder4.AddAttribute(84, "CssClass", "e-outline");
                        __builder4.AddAttribute(85, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 74 "C:\Users\andy2\RiderProjects\DNPStructureTest\Assignments\DNP-A1\DNP-A1\Shared\Components\FamilyCard.razor"
                                                           () => Expand = !Expand

#line default
#line hidden
#nullable disable
                        ));
                        __builder4.AddAttribute(86, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder5) => {
                            __builder5.AddContent(87, 
#nullable restore
#line 74 "C:\Users\andy2\RiderProjects\DNPStructureTest\Assignments\DNP-A1\DNP-A1\Shared\Components\FamilyCard.razor"
                                                                                      Expand ? "Collapse" : "Expand"

#line default
#line hidden
#nullable disable
                            );
                        }
                        ));
                        __builder4.CloseComponent();
                        __builder4.AddMarkupContent(88, "\r\n                ");
                        __builder4.OpenComponent<Microsoft.AspNetCore.Components.Authorization.AuthorizeView>(89);
                        __builder4.AddAttribute(90, "Policy", "HighLevelAdmin");
                        __builder4.AddAttribute(91, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Authorization.AuthenticationState>)((context) => (__builder5) => {
                            __builder5.AddMarkupContent(92, "\r\n                    ");
                            __builder5.OpenComponent<Syncfusion.Blazor.Buttons.SfButton>(93);
                            __builder5.AddAttribute(94, "CssClass", "e-danger");
                            __builder5.AddAttribute(95, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 76 "C:\Users\andy2\RiderProjects\DNPStructureTest\Assignments\DNP-A1\DNP-A1\Shared\Components\FamilyCard.razor"
                                                             () => RemoveFamily.InvokeAsync(Family.Id)

#line default
#line hidden
#nullable disable
                            ));
                            __builder5.AddAttribute(96, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder6) => {
                                __builder6.AddContent(97, "Delete Family");
                            }
                            ));
                            __builder5.CloseComponent();
                            __builder5.AddMarkupContent(98, "\r\n                ");
                        }
                        ));
                        __builder4.CloseComponent();
                        __builder4.AddMarkupContent(99, "\r\n            ");
                    }
                    ));
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(100, "\r\n        ");
                }
                ));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(101, "\r\n    ");
            }
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(102, "\r\n");
            __builder.CloseElement();
            __builder.AddMarkupContent(103, "\r\n\r\n\r\n");
            __builder.AddMarkupContent(104, @"<style>
    .TempClass {
        font-size: 30px;
    }
    .FontSize50{
            font-size: 50px;
        }
    .TempImage {
        background-image: url(https://ej2.syncfusion.com/demos/src/chart/images/sunny.png);
        height: 40px;
        width: 40px;
    }
    .SunnyImage {
        height: 40px;
        width: 40px;
        background-image: url(https://ej2.syncfusion.com/demos/src/chart/images/sunny.png);
    }
    .CloudyImage {
        height: 40px;
        width: 40px;
        background-image: url(https://ej2.syncfusion.com/demos/src/chart/images/cloud.png);
    }
    .e-card .e-card-header .e-card-header-caption .e-card-header-title {
        font-size: 25px;
        line-height: 32px;
    }
    .e-card .e-card-header .e-card-header-caption .e-card-sub-title {
        font-size: 16px;
        line-height: 20px;
    }
    .e-card .e-card-content {
        padding-top: 0px;
    }
    .e-card {
        background-color: white;
    }
    .RainText {
        color: blue;
    }
    .RainImage {
        height: 20px;
        width: 20px;
        background-image: url(https://ej2.syncfusion.com/demos/src/chart/images/cloud.png);
    }
    table {
        width: 100%;
    }
    .TextCenter {
        text-align: center;
    }
   
</style>");
        }
        #pragma warning restore 1998
#nullable restore
#line 83 "C:\Users\andy2\RiderProjects\DNPStructureTest\Assignments\DNP-A1\DNP-A1\Shared\Components\FamilyCard.razor"
      
    bool Expand = false;

#line default
#line hidden
#nullable disable
#nullable restore
#line 140 "C:\Users\andy2\RiderProjects\DNPStructureTest\Assignments\DNP-A1\DNP-A1\Shared\Components\FamilyCard.razor"
       

    [Parameter]
    public Family Family { get; set; }

    [Parameter]
    public EventCallback<int?> RemoveFamily { get; set; }

    private string LastNames { get; set; } = "";

    protected async override Task OnInitializedAsync()
    {
    }


#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IFamilyService FamilyService { get; set; }
    }
}
#pragma warning restore 1591