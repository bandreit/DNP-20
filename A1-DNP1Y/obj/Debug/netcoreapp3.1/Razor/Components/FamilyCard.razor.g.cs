#pragma checksum "C:\Users\andy2\RiderProjects\DNPStructureTest\A1-DNP1Y\Components\FamilyCard.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "0c5935c58941b61b1a6d86fff313261110e0f20c"
// <auto-generated/>
#pragma warning disable 1591
namespace A1_DNP1Y.Components
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
#line 1 "C:\Users\andy2\RiderProjects\DNPStructureTest\A1-DNP1Y\Components\FamilyCard.razor"
using Syncfusion.Blazor.Cards;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\andy2\RiderProjects\DNPStructureTest\A1-DNP1Y\Components\FamilyCard.razor"
using Syncfusion.Blazor.Buttons;

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
            __builder.AddMarkupContent(2, "\r\n        ");
            __builder.OpenComponent<Syncfusion.Blazor.Cards.SfCard>(3);
            __builder.AddAttribute(4, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.AddMarkupContent(5, "\r\n            ");
                __builder2.OpenComponent<Syncfusion.Blazor.Cards.CardHeader>(6);
                __builder2.AddAttribute(7, "Title", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 7 "C:\Users\andy2\RiderProjects\DNPStructureTest\A1-DNP1Y\Components\FamilyCard.razor"
                                StreetName

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(8, "SubTitle", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 7 "C:\Users\andy2\RiderProjects\DNPStructureTest\A1-DNP1Y\Components\FamilyCard.razor"
                                                       HouseNumber.ToString()

#line default
#line hidden
#nullable disable
                ));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(9, "\r\n            ");
                __builder2.OpenComponent<Syncfusion.Blazor.Cards.CardContent>(10);
                __builder2.AddAttribute(11, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.AddMarkupContent(12, "\r\n                ");
                    __builder3.AddMarkupContent(13, @"<table style=""margin-bottom: 10px;"">
                    <tr>
                        <td>
                            <div class=""TempClass"">23°C</div>
                        </td>
                        <td>
                            <img src=""images/family.png"" alt=""family"" class=""img-fluid"">
                        </td>
                    </tr>
                    <tr>
                        <td>
                            <span class=""RainImage""></span>
                            <span class=""RainText"">2% preciptation</span>
                        </td>
                    </tr>
                </table>
");
#nullable restore
#line 28 "C:\Users\andy2\RiderProjects\DNPStructureTest\A1-DNP1Y\Components\FamilyCard.razor"
                 if (Expand)
                {

#line default
#line hidden
#nullable disable
                    __builder3.AddContent(14, "                    ");
                    __builder3.AddMarkupContent(15, "<table>\r\n                        <tr>\r\n                            <td>\r\n                                <div class=\"WeekDay\">Monday</div>\r\n                            </td>\r\n                            <td>\r\n                                <div class=\"CloudyImage TextCenter\"></div>\r\n                            </td>\r\n                            <td>\r\n                                <div class=\"MinMaxClass TextCenter\"><b>23°C</b> / 12°C</div>\r\n                            </td>\r\n                        </tr>\r\n                        <tr>\r\n                            <td>\r\n                                <div class=\"WeekDay\">Tuesday</div>\r\n                            </td>\r\n                            <td>\r\n                                <div class=\"SunnyImage TextCenter\"></div>\r\n                            </td>\r\n                            <td>\r\n                                <div class=\"MinMaxClass TextCenter\"><b>28°C</b> / 15°C</div>\r\n                            </td>\r\n                        </tr>\r\n                        <tr>\r\n                            <td>\r\n                                <div class=\"WeekDay\">Wednesday</div>\r\n                            </td>\r\n                            <td>\r\n                                <div class=\"SunnyImage TextCenter\"></div>\r\n                            </td>\r\n                            <td>\r\n                                <div class=\"MinMaxClass TextCenter\"><b>25°C</b> / 20°C</div>\r\n                            </td>\r\n                        </tr>\r\n                        <tr>\r\n                            <td>\r\n                                <div class=\"WeekDay\">Thursday</div>\r\n                            </td>\r\n                            <td>\r\n                                <div class=\"CloudyImage TextCenter\"></div>\r\n                            </td>\r\n                            <td>\r\n                                <div class=\"MinMaxClass TextCenter\"><b>20°C</b> / 12°C</div>\r\n                            </td>\r\n                        </tr>\r\n                        <tr>\r\n                            <td>\r\n                                <div class=\"WeekDay\">Friday</div>\r\n                            </td>\r\n                            <td>\r\n                                <div class=\"SunnyImage TextCenter\"></div>\r\n                            </td>\r\n                            <td>\r\n                                <div class=\"MinMaxClass TextCenter\"><b>23°C</b> / 15°C</div>\r\n                            </td>\r\n                        </tr>\r\n                    </table>\r\n");
#nullable restore
#line 87 "C:\Users\andy2\RiderProjects\DNPStructureTest\A1-DNP1Y\Components\FamilyCard.razor"
                }

#line default
#line hidden
#nullable disable
                    __builder3.AddContent(16, "            ");
                }
                ));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(17, "\r\n            ");
                __builder2.OpenComponent<Syncfusion.Blazor.Cards.CardContent>(18);
                __builder2.AddAttribute(19, "EnableSeperator", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 89 "C:\Users\andy2\RiderProjects\DNPStructureTest\A1-DNP1Y\Components\FamilyCard.razor"
                                          true

#line default
#line hidden
#nullable disable
                ));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(20, "\r\n            ");
                __builder2.OpenComponent<Syncfusion.Blazor.Cards.CardFooter>(21);
                __builder2.AddAttribute(22, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.AddMarkupContent(23, "\r\n                ");
                    __builder3.OpenComponent<Syncfusion.Blazor.Cards.CardFooterContent>(24);
                    __builder3.AddAttribute(25, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder4) => {
                        __builder4.AddMarkupContent(26, "\r\n                    ");
                        __builder4.OpenComponent<Syncfusion.Blazor.Buttons.SfButton>(27);
                        __builder4.AddAttribute(28, "CssClass", "e-outline");
                        __builder4.AddAttribute(29, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 92 "C:\Users\andy2\RiderProjects\DNPStructureTest\A1-DNP1Y\Components\FamilyCard.razor"
                                                               () => Expand = !Expand

#line default
#line hidden
#nullable disable
                        ));
                        __builder4.AddAttribute(30, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder5) => {
                            __builder5.AddContent(31, 
#nullable restore
#line 92 "C:\Users\andy2\RiderProjects\DNPStructureTest\A1-DNP1Y\Components\FamilyCard.razor"
                                                                                          Expand ? "Collapse" : "Expand"

#line default
#line hidden
#nullable disable
                            );
                        }
                        ));
                        __builder4.CloseComponent();
                        __builder4.AddMarkupContent(32, "\r\n                ");
                    }
                    ));
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(33, "\r\n            ");
                }
                ));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(34, "\r\n        ");
            }
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(35, "\r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(36, "\r\n\r\n\r\n");
            __builder.AddMarkupContent(37, @"<style>
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
#line 100 "C:\Users\andy2\RiderProjects\DNPStructureTest\A1-DNP1Y\Components\FamilyCard.razor"
      
    bool Expand = false;

#line default
#line hidden
#nullable disable
#nullable restore
#line 167 "C:\Users\andy2\RiderProjects\DNPStructureTest\A1-DNP1Y\Components\FamilyCard.razor"
       

    [Parameter]
    public string StreetName { get; set; }

    [Parameter]
    public int HouseNumber { get; set; }

    // [Parameter]
    // public RenderFragment ChildContent { get; set; }
    //
    // [Parameter]
    // public EventCallback<MouseEventArgs> OnClickCallback { get; set; }

#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591
