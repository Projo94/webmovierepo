// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace WebStoreApp.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\MarkoProjovic\Source\Repos\WebStoreAPP\WebStoreApp\WebStoreApp\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\MarkoProjovic\Source\Repos\WebStoreAPP\WebStoreApp\WebStoreApp\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\MarkoProjovic\Source\Repos\WebStoreAPP\WebStoreApp\WebStoreApp\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\MarkoProjovic\Source\Repos\WebStoreAPP\WebStoreApp\WebStoreApp\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\MarkoProjovic\Source\Repos\WebStoreAPP\WebStoreApp\WebStoreApp\_Imports.razor"
using WebStoreApp;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\MarkoProjovic\Source\Repos\WebStoreAPP\WebStoreApp\WebStoreApp\_Imports.razor"
using WebStoreApp.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\MarkoProjovic\Source\Repos\WebStoreAPP\WebStoreApp\WebStoreApp\_Imports.razor"
using WebStoreApp.Data.ApiCallService;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "C:\Users\MarkoProjovic\Source\Repos\WebStoreAPP\WebStoreApp\WebStoreApp\_Imports.razor"
using WebStoreApp.Model;

#line default
#line hidden
#nullable disable
#nullable restore
#line 13 "C:\Users\MarkoProjovic\Source\Repos\WebStoreAPP\WebStoreApp\WebStoreApp\_Imports.razor"
using WebStoreApp.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 14 "C:\Users\MarkoProjovic\Source\Repos\WebStoreAPP\WebStoreApp\WebStoreApp\_Imports.razor"
using EmbeddedBlazorContent;

#line default
#line hidden
#nullable disable
#nullable restore
#line 15 "C:\Users\MarkoProjovic\Source\Repos\WebStoreAPP\WebStoreApp\WebStoreApp\_Imports.razor"
using WebStoreApp.Model.Account;

#line default
#line hidden
#nullable disable
#nullable restore
#line 16 "C:\Users\MarkoProjovic\Source\Repos\WebStoreAPP\WebStoreApp\WebStoreApp\_Imports.razor"
using Blazored.LocalStorage;

#line default
#line hidden
#nullable disable
#nullable restore
#line 17 "C:\Users\MarkoProjovic\Source\Repos\WebStoreAPP\WebStoreApp\WebStoreApp\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 18 "C:\Users\MarkoProjovic\Source\Repos\WebStoreAPP\WebStoreApp\WebStoreApp\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 19 "C:\Users\MarkoProjovic\Source\Repos\WebStoreAPP\WebStoreApp\WebStoreApp\_Imports.razor"
using Radzen.Blazor;

#line default
#line hidden
#nullable disable
#nullable restore
#line 20 "C:\Users\MarkoProjovic\Source\Repos\WebStoreAPP\WebStoreApp\WebStoreApp\_Imports.razor"
using Blazored.Toast;

#line default
#line hidden
#nullable disable
#nullable restore
#line 21 "C:\Users\MarkoProjovic\Source\Repos\WebStoreAPP\WebStoreApp\WebStoreApp\_Imports.razor"
using Blazored.Toast.Services;

#line default
#line hidden
#nullable disable
#nullable restore
#line 22 "C:\Users\MarkoProjovic\Source\Repos\WebStoreAPP\WebStoreApp\WebStoreApp\_Imports.razor"
using Blazored.Toast.Configuration;

#line default
#line hidden
#nullable disable
#nullable restore
#line 1 "C:\Users\MarkoProjovic\Source\Repos\WebStoreAPP\WebStoreApp\WebStoreApp\Pages\SelectCategories.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\MarkoProjovic\Source\Repos\WebStoreAPP\WebStoreApp\WebStoreApp\Pages\SelectCategories.razor"
using MatBlazor;

#line default
#line hidden
#nullable disable
    public partial class SelectCategories : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 29 "C:\Users\MarkoProjovic\Source\Repos\WebStoreAPP\WebStoreApp\WebStoreApp\Pages\SelectCategories.razor"
       


   


    bool checked1 = false;
    protected bool IsSelected { get; set; }
    [Parameter]
    public EventCallback<bool> OnCategorySelection { get; set; }


    protected async Task CheckBoxChanged(ChangeEventArgs e)
    {
        IsSelected = (bool)e.Value;
        await OnCategorySelection.InvokeAsync(IsSelected);
    }


    string getLabel(bool val)
    {
        return !val ? "Check me!" : "Uncheck me?";
    }

    public List<int> CheckBox { get; set; } = new List<int>();

    void CheckboxClicked(int CheckID, object checkedValue)
    {
        if ((bool)checkedValue)
        {
            if (!CheckBox.Contains(CheckID))
            {
                CheckBox.Add(CheckID);
            }
        }
        else
        {
            if (CheckBox.Contains(CheckID))
            {
                CheckBox.Remove(CheckID);
            }
        }
    }








    [Parameter]
    public EventCallback<ChangeEventArgs> OnChangeEvent { get; set; }

    public static List<Category> Categories { get; set; }

    protected override async Task OnAfterRenderAsync(bool firstRender)
    {
        if (firstRender && Categories == null)
        {
            try
            {
                Categories = await apiCallService.GetAllAsList("products/categories");
                //await JSRuntime.InvokeAsync<Category[]>("getCategories");

                StateHasChanged();
            }
            catch (Exception ex)
            {

                //throw;
            }

        }
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IApiCallService<Category> apiCallService { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IJSRuntime JSRuntime { get; set; }
    }
}
#pragma warning restore 1591
