// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace ExtResourcesBlazor.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "D:\DIPLOM\ExtResourcesBlazor\ExtResourcesBlazor\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\DIPLOM\ExtResourcesBlazor\ExtResourcesBlazor\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "D:\DIPLOM\ExtResourcesBlazor\ExtResourcesBlazor\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "D:\DIPLOM\ExtResourcesBlazor\ExtResourcesBlazor\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "D:\DIPLOM\ExtResourcesBlazor\ExtResourcesBlazor\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "D:\DIPLOM\ExtResourcesBlazor\ExtResourcesBlazor\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "D:\DIPLOM\ExtResourcesBlazor\ExtResourcesBlazor\_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "D:\DIPLOM\ExtResourcesBlazor\ExtResourcesBlazor\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "D:\DIPLOM\ExtResourcesBlazor\ExtResourcesBlazor\_Imports.razor"
using ExtResourcesBlazor.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "D:\DIPLOM\ExtResourcesBlazor\ExtResourcesBlazor\_Imports.razor"
using Syncfusion.Blazor;

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "D:\DIPLOM\ExtResourcesBlazor\ExtResourcesBlazor\_Imports.razor"
using Syncfusion.Blazor.PdfViewer;

#line default
#line hidden
#nullable disable
#nullable restore
#line 13 "D:\DIPLOM\ExtResourcesBlazor\ExtResourcesBlazor\_Imports.razor"
using Syncfusion.Blazor.PdfViewerServer;

#line default
#line hidden
#nullable disable
#nullable restore
#line 14 "D:\DIPLOM\ExtResourcesBlazor\ExtResourcesBlazor\_Imports.razor"
using DataModel;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/Resources")]
    public partial class ResourceList : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 66 "D:\DIPLOM\ExtResourcesBlazor\ExtResourcesBlazor\Pages\ResourceList.razor"
        private IEnumerable<DataModel.Resource> Resources;
    private IEnumerable<DataModel.Partner> Partners;

    protected override async Task OnInitializedAsync()
    {
       
        Resources = await Service.GetResources();
        //Partners = await service.GetPartners();

    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private DataModel.IPartnerRepository service { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private DataModel.IResourceRepository Service { get; set; }
    }
}
#pragma warning restore 1591
