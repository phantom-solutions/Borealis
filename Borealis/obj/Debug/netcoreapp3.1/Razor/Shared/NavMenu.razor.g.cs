#pragma checksum "C:\Users\nicole.rappe\Source\Repos\Borealis\Borealis\Shared\NavMenu.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "6070b685667a9e2e3e9e909a6410e07165d21d2d"
// <auto-generated/>
#pragma warning disable 1591
namespace Borealis.Shared
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\nicole.rappe\Source\Repos\Borealis\Borealis\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\nicole.rappe\Source\Repos\Borealis\Borealis\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\nicole.rappe\Source\Repos\Borealis\Borealis\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\nicole.rappe\Source\Repos\Borealis\Borealis\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\nicole.rappe\Source\Repos\Borealis\Borealis\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\nicole.rappe\Source\Repos\Borealis\Borealis\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\nicole.rappe\Source\Repos\Borealis\Borealis\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\nicole.rappe\Source\Repos\Borealis\Borealis\_Imports.razor"
using Borealis;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\nicole.rappe\Source\Repos\Borealis\Borealis\_Imports.razor"
using Borealis.Shared;

#line default
#line hidden
#nullable disable
    public partial class NavMenu : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "div");
            __builder.AddAttribute(1, "class", "top-row pl-4 navbar navbar-dark");
            __builder.AddMarkupContent(2, "<a class=\"navbar-brand\" href>Borealis Server Manager</a>\r\n    ");
            __builder.OpenElement(3, "button");
            __builder.AddAttribute(4, "class", "navbar-toggler");
            __builder.AddAttribute(5, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 3 "C:\Users\nicole.rappe\Source\Repos\Borealis\Borealis\Shared\NavMenu.razor"
                                             ToggleNavMenu

#line default
#line hidden
#nullable disable
            ));
            __builder.AddMarkupContent(6, "<span class=\"navbar-toggler-icon\"></span>");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(7, "\r\n\r\n");
            __builder.OpenElement(8, "div");
            __builder.AddAttribute(9, "class", 
#nullable restore
#line 8 "C:\Users\nicole.rappe\Source\Repos\Borealis\Borealis\Shared\NavMenu.razor"
             NavMenuCssClass

#line default
#line hidden
#nullable disable
            );
            __builder.AddAttribute(10, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 8 "C:\Users\nicole.rappe\Source\Repos\Borealis\Borealis\Shared\NavMenu.razor"
                                        ToggleNavMenu

#line default
#line hidden
#nullable disable
            ));
            __builder.OpenElement(11, "ul");
            __builder.AddAttribute(12, "class", "nav flex-column");
            __builder.OpenElement(13, "li");
            __builder.AddAttribute(14, "class", "nav-item px-3");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Routing.NavLink>(15);
            __builder.AddAttribute(16, "class", "nav-link");
            __builder.AddAttribute(17, "href", "");
            __builder.AddAttribute(18, "Match", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.Routing.NavLinkMatch>(
#nullable restore
#line 11 "C:\Users\nicole.rappe\Source\Repos\Borealis\Borealis\Shared\NavMenu.razor"
                                                     NavLinkMatch.All

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(19, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.AddMarkupContent(20, "<span class=\"oi oi-dashboard\" aria-hidden=\"true\"></span> Dashboard\r\n            ");
            }
            ));
            __builder.CloseComponent();
            __builder.CloseElement();
            __builder.AddMarkupContent(21, "\r\n        ");
            __builder.OpenElement(22, "li");
            __builder.AddAttribute(23, "class", "nav-item px-3");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Routing.NavLink>(24);
            __builder.AddAttribute(25, "class", "nav-link");
            __builder.AddAttribute(26, "href", "deploy_gameservers");
            __builder.AddAttribute(27, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.AddMarkupContent(28, "<span class=\"oi oi-monitor\" aria-hidden=\"true\"></span> Deploy GameServers\r\n            ");
            }
            ));
            __builder.CloseComponent();
            __builder.CloseElement();
            __builder.AddMarkupContent(29, "\r\n        ");
            __builder.OpenElement(30, "li");
            __builder.AddAttribute(31, "class", "nav-item px-3");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Routing.NavLink>(32);
            __builder.AddAttribute(33, "class", "nav-link");
            __builder.AddAttribute(34, "href", "manage_gameservers");
            __builder.AddAttribute(35, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.AddMarkupContent(36, "<span class=\"oi oi-cog\" aria-hidden=\"true\"></span> Manage GameServers\r\n            ");
            }
            ));
            __builder.CloseComponent();
            __builder.CloseElement();
            __builder.AddMarkupContent(37, "\r\n        ");
            __builder.OpenElement(38, "li");
            __builder.AddAttribute(39, "class", "nav-item px-3");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Routing.NavLink>(40);
            __builder.AddAttribute(41, "class", "nav-link");
            __builder.AddAttribute(42, "href", "control_gameservers");
            __builder.AddAttribute(43, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.AddMarkupContent(44, "<span class=\"oi oi-code\" aria-hidden=\"true\"></span> Control GameServers\r\n            ");
            }
            ));
            __builder.CloseComponent();
            __builder.CloseElement();
            __builder.AddMarkupContent(45, "\r\n        ");
            __builder.OpenElement(46, "li");
            __builder.AddAttribute(47, "class", "nav-item px-3");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Routing.NavLink>(48);
            __builder.AddAttribute(49, "class", "nav-link");
            __builder.AddAttribute(50, "href", "scheduled_tasks");
            __builder.AddAttribute(51, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.AddMarkupContent(52, "<span class=\"oi oi-calendar\" aria-hidden=\"true\"></span> Scheduled Tasks\r\n            ");
            }
            ));
            __builder.CloseComponent();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 38 "C:\Users\nicole.rappe\Source\Repos\Borealis\Borealis\Shared\NavMenu.razor"
       
    private bool collapseNavMenu = true;

    private string NavMenuCssClass => collapseNavMenu ? "collapse" : null;

    private void ToggleNavMenu()
    {
        collapseNavMenu = !collapseNavMenu;
    }

#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591
