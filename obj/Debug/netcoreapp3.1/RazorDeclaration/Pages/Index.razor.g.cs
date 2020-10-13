#pragma checksum "C:\Projects\GitHubProjects\BlazorAppSelectMultiple\BlazorAppSelectMultiple\Pages\Index.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "b17d82216e2d587bf3326fec7c9f05216b00038a"
// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace BlazorAppSelectMultiple.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Projects\GitHubProjects\BlazorAppSelectMultiple\BlazorAppSelectMultiple\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Projects\GitHubProjects\BlazorAppSelectMultiple\BlazorAppSelectMultiple\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Projects\GitHubProjects\BlazorAppSelectMultiple\BlazorAppSelectMultiple\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Projects\GitHubProjects\BlazorAppSelectMultiple\BlazorAppSelectMultiple\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Projects\GitHubProjects\BlazorAppSelectMultiple\BlazorAppSelectMultiple\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Projects\GitHubProjects\BlazorAppSelectMultiple\BlazorAppSelectMultiple\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Projects\GitHubProjects\BlazorAppSelectMultiple\BlazorAppSelectMultiple\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Projects\GitHubProjects\BlazorAppSelectMultiple\BlazorAppSelectMultiple\_Imports.razor"
using BlazorAppSelectMultiple;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Projects\GitHubProjects\BlazorAppSelectMultiple\BlazorAppSelectMultiple\_Imports.razor"
using BlazorAppSelectMultiple.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Projects\GitHubProjects\BlazorAppSelectMultiple\BlazorAppSelectMultiple\Pages\Index.razor"
using BlazorAppSelectMultiple.Data;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/")]
    public partial class Index : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 30 "C:\Projects\GitHubProjects\BlazorAppSelectMultiple\BlazorAppSelectMultiple\Pages\Index.razor"
      

    private List<OptionElement> OptionElements = OptionElement.GetElements();
    private string CitiesSelected = "Select cities";

    private List<string> SelectCityList = new List<string>();



    private ElementReference MySelect { get; set; }

    private async Task OnChangeCitiesSelected()
    {
        string elementSelected = (await JSRuntime.InvokeAsync<object>("ResetValue.GetSelectedElement", "slt")).ToString();

        await Task.Run(() => CreateMultipleValue(elementSelected));

        await JSRuntime.InvokeAsync<object>("ResetValue.SelectElement", MySelect);
    }


    private void CreateMultipleValue(string elementSelected)
    {
        OptionElement optionElement = OptionElements.FirstOrDefault(x => x.Name == elementSelected);
        if (optionElement != null)
        {
            optionElement.Active = !optionElement.Active;

        }
        CitiesSelected = OptionElements.Any(x => !x.Active) ? string.Join(" , ", OptionElements.Where(x => !x.Active).Select(n=>n.Name)) : "Select cities";
        OptionElements = OptionElements.OrderByDescending(x => x.Active).ThenBy(x => x.Name).ToList();
    }


#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IJSRuntime JSRuntime { get; set; }
    }
}
#pragma warning restore 1591
