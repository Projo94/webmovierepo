#pragma checksum "C:\Users\MarkoProjovic\Desktop\webappmovies-master\WebApp.Movies.Frontend\WebStoreApp\WebStoreApp\App.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "c62cf4c5394044433dca85b432e8621c0e73b5e1"
// <auto-generated/>
#pragma warning disable 1591
namespace WebApp
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\MarkoProjovic\Desktop\webappmovies-master\WebApp.Movies.Frontend\WebStoreApp\WebStoreApp\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\MarkoProjovic\Desktop\webappmovies-master\WebApp.Movies.Frontend\WebStoreApp\WebStoreApp\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\MarkoProjovic\Desktop\webappmovies-master\WebApp.Movies.Frontend\WebStoreApp\WebStoreApp\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\MarkoProjovic\Desktop\webappmovies-master\WebApp.Movies.Frontend\WebStoreApp\WebStoreApp\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\MarkoProjovic\Desktop\webappmovies-master\WebApp.Movies.Frontend\WebStoreApp\WebStoreApp\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\MarkoProjovic\Desktop\webappmovies-master\WebApp.Movies.Frontend\WebStoreApp\WebStoreApp\_Imports.razor"
using WebApp;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\MarkoProjovic\Desktop\webappmovies-master\WebApp.Movies.Frontend\WebStoreApp\WebStoreApp\_Imports.razor"
using WebApp.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\MarkoProjovic\Desktop\webappmovies-master\WebApp.Movies.Frontend\WebStoreApp\WebStoreApp\_Imports.razor"
using WebApp.Data.ApiCallService;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "C:\Users\MarkoProjovic\Desktop\webappmovies-master\WebApp.Movies.Frontend\WebStoreApp\WebStoreApp\_Imports.razor"
using WebApp.Model;

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "C:\Users\MarkoProjovic\Desktop\webappmovies-master\WebApp.Movies.Frontend\WebStoreApp\WebStoreApp\_Imports.razor"
using MatBlazor;

#line default
#line hidden
#nullable disable
#nullable restore
#line 13 "C:\Users\MarkoProjovic\Desktop\webappmovies-master\WebApp.Movies.Frontend\WebStoreApp\WebStoreApp\_Imports.razor"
using EmbeddedBlazorContent;

#line default
#line hidden
#nullable disable
#nullable restore
#line 14 "C:\Users\MarkoProjovic\Desktop\webappmovies-master\WebApp.Movies.Frontend\WebStoreApp\WebStoreApp\_Imports.razor"
using WebApp.Model.Account;

#line default
#line hidden
#nullable disable
#nullable restore
#line 15 "C:\Users\MarkoProjovic\Desktop\webappmovies-master\WebApp.Movies.Frontend\WebStoreApp\WebStoreApp\_Imports.razor"
using Blazored.LocalStorage;

#line default
#line hidden
#nullable disable
#nullable restore
#line 17 "C:\Users\MarkoProjovic\Desktop\webappmovies-master\WebApp.Movies.Frontend\WebStoreApp\WebStoreApp\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 19 "C:\Users\MarkoProjovic\Desktop\webappmovies-master\WebApp.Movies.Frontend\WebStoreApp\WebStoreApp\_Imports.razor"
using Blazored.Toast;

#line default
#line hidden
#nullable disable
#nullable restore
#line 20 "C:\Users\MarkoProjovic\Desktop\webappmovies-master\WebApp.Movies.Frontend\WebStoreApp\WebStoreApp\_Imports.razor"
using Blazored.Toast.Services;

#line default
#line hidden
#nullable disable
#nullable restore
#line 21 "C:\Users\MarkoProjovic\Desktop\webappmovies-master\WebApp.Movies.Frontend\WebStoreApp\WebStoreApp\_Imports.razor"
using Blazored.Toast.Configuration;

#line default
#line hidden
#nullable disable
#nullable restore
#line 22 "C:\Users\MarkoProjovic\Desktop\webappmovies-master\WebApp.Movies.Frontend\WebStoreApp\WebStoreApp\_Imports.razor"
using Radzen;

#line default
#line hidden
#nullable disable
#nullable restore
#line 23 "C:\Users\MarkoProjovic\Desktop\webappmovies-master\WebApp.Movies.Frontend\WebStoreApp\WebStoreApp\_Imports.razor"
using Radzen.Blazor;

#line default
#line hidden
#nullable disable
#nullable restore
#line 1 "C:\Users\MarkoProjovic\Desktop\webappmovies-master\WebApp.Movies.Frontend\WebStoreApp\WebStoreApp\App.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\MarkoProjovic\Desktop\webappmovies-master\WebApp.Movies.Frontend\WebStoreApp\WebStoreApp\App.razor"
using WebApp.Pages.Account;

#line default
#line hidden
#nullable disable
    public partial class App : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Routing.Router>(0);
            __builder.AddAttribute(1, "AppAssembly", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Reflection.Assembly>(
#nullable restore
#line 4 "C:\Users\MarkoProjovic\Desktop\webappmovies-master\WebApp.Movies.Frontend\WebStoreApp\WebStoreApp\App.razor"
                      typeof(Program).Assembly

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(2, "Found", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.RouteData>)((routeData) => (__builder2) => {
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Authorization.AuthorizeRouteView>(3);
                __builder2.AddAttribute(4, "RouteData", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.RouteData>(
#nullable restore
#line 6 "C:\Users\MarkoProjovic\Desktop\webappmovies-master\WebApp.Movies.Frontend\WebStoreApp\WebStoreApp\App.razor"
                                        routeData

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(5, "DefaultLayout", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Type>(
#nullable restore
#line 6 "C:\Users\MarkoProjovic\Desktop\webappmovies-master\WebApp.Movies.Frontend\WebStoreApp\WebStoreApp\App.razor"
                                                                   typeof(MainLayout)

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(6, "NotAuthorized", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Authorization.AuthenticationState>)((context) => (__builder3) => {
                    __builder3.OpenComponent<WebApp.Pages.Account.RedirectToLogin>(7);
                    __builder3.CloseComponent();
                }
                ));
                __builder2.CloseComponent();
            }
            ));
            __builder.AddAttribute(8, "NotFound", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Authorization.CascadingAuthenticationState>(9);
                __builder2.AddAttribute(10, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.OpenComponent<Microsoft.AspNetCore.Components.LayoutView>(11);
                    __builder3.AddAttribute(12, "Layout", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Type>(
#nullable restore
#line 15 "C:\Users\MarkoProjovic\Desktop\webappmovies-master\WebApp.Movies.Frontend\WebStoreApp\WebStoreApp\App.razor"
                                 typeof(MainLayout)

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(13, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder4) => {
                        __builder4.AddMarkupContent(14, "<p>Sorry, there\'s nothing at this address.</p>");
                    }
                    ));
                    __builder3.CloseComponent();
                }
                ));
                __builder2.CloseComponent();
            }
            ));
            __builder.CloseComponent();
        }
        #pragma warning restore 1998
    }
}
#pragma warning restore 1591
