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
#nullable restore
#line 7 "D:\DIPLOM\ExtResourcesBlazor\ExtResourcesBlazor\Pages\CreateResource.razor"
using System.IO;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/createResource")]
    public partial class CreateResource : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 86 "D:\DIPLOM\ExtResourcesBlazor\ExtResourcesBlazor\Pages\CreateResource.razor"
       
    private Resource resource = new Resource();
    private IEnumerable<DataModel.Partner> Partners;
    private IEnumerable<DataModel.ResourceLevel> ResourceLevels;
    private List<IBrowserFile> Files = new List<IBrowserFile>();
    private long maxFileSize = 1024 * 1500;

    private async void HandleValidSubmit()
    {
        //var file = Files.First();
        // путь к папке files
        string path = "/Files/" + Files.First().Name;
        // сохраняем файл в папку Files в каталоге wwwroot
        using (var fileStream = new FileStream(_appEnvironment.WebRootPath + path, FileMode.Create))
        {
            await Files.First().OpenReadStream(maxFileSize).CopyToAsync(fileStream);
        }

        await Service.AddResource(resource, Files.First().Name);
    }

    protected override async Task OnInitializedAsync()
    {
        Partners = await partnersService.GetPartners();
        //ResourceLevels = await levService.GetLevels();
    }

    public Partner partner = new Partner();

    private Dictionary<IBrowserFile, string> loadedFiles =
        new Dictionary<IBrowserFile, string>();

    async Task LoadFiles(InputFileChangeEventArgs e)
    {
        //тут был иф
        Files.Clear();
        Files.Add(e.File);

        //FileModel file = new FileModel { Name = uploadedFile.FileName, Path = path };
        //resource.CvtoolLinkMaster = path + "1";
        //appcontext.Files.Add(file);
        //appcontext.SaveChanges();

    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private Microsoft.AspNetCore.Hosting.IWebHostEnvironment _appEnvironment { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager navManger { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IResourceLevelRepository levService { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IPartnerRepository partnersService { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IResourceRepository Service { get; set; }
    }
}
#pragma warning restore 1591
