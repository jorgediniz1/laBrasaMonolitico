#pragma checksum "C:\Treinee\lBrasa\Shared\MainLayout.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "8a1363fa87b2c842030951a435f7c5a6de8a1f99"
// <auto-generated/>
#pragma warning disable 1591
namespace lBrasa.Shared
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Treinee\lBrasa\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Treinee\lBrasa\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Treinee\lBrasa\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Treinee\lBrasa\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Treinee\lBrasa\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Treinee\lBrasa\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Treinee\lBrasa\_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Treinee\lBrasa\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Treinee\lBrasa\_Imports.razor"
using lBrasa;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Treinee\lBrasa\_Imports.razor"
using lBrasa.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "C:\Treinee\lBrasa\_Imports.razor"
using MudBlazor;

#line default
#line hidden
#nullable disable
    public partial class MainLayout : LayoutComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenComponent<MudBlazor.MudThemeProvider>(0);
            __builder.CloseComponent();
            __builder.AddMarkupContent(1, "\r\n");
            __builder.OpenComponent<MudBlazor.MudDialogProvider>(2);
            __builder.CloseComponent();
            __builder.AddMarkupContent(3, "\r\n");
            __builder.OpenComponent<MudBlazor.MudSnackbarProvider>(4);
            __builder.CloseComponent();
            __builder.AddMarkupContent(5, "\r\n\r\n");
            __builder.OpenElement(6, "div");
            __builder.AddAttribute(7, "class", "page");
            __builder.AddAttribute(8, "b-sh1v6279fv");
            __builder.OpenElement(9, "div");
            __builder.AddAttribute(10, "class", "sidebar");
            __builder.AddAttribute(11, "b-sh1v6279fv");
            __builder.OpenComponent<lBrasa.Shared.NavMenu>(12);
            __builder.CloseComponent();
            __builder.CloseElement();
            __builder.AddMarkupContent(13, "\r\n\r\n    ");
            __builder.OpenElement(14, "div");
            __builder.AddAttribute(15, "class", "main");
            __builder.AddAttribute(16, "b-sh1v6279fv");
            __builder.AddMarkupContent(17, "<div class=\"top-row px-4\" b-sh1v6279fv><a href=\"http://blazor.net\" target=\"_blank\" class=\"ml-md-auto\" b-sh1v6279fv>About</a></div>\r\n\r\n        ");
            __builder.OpenElement(18, "div");
            __builder.AddAttribute(19, "class", "content px-4");
            __builder.AddAttribute(20, "b-sh1v6279fv");
            __builder.AddContent(21, 
#nullable restore
#line 18 "C:\Treinee\lBrasa\Shared\MainLayout.razor"
             Body

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
        }
        #pragma warning restore 1998
    }
}
#pragma warning restore 1591
