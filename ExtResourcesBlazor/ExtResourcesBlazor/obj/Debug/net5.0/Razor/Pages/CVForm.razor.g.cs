#pragma checksum "D:\DIPLOM\ExtResourcesBlazor\ExtResourcesBlazor\Pages\CVForm.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "02252453ea13680701eb7c346db7f5e24952e74e"
// <auto-generated/>
#pragma warning disable 1591
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
#line 14 "D:\DIPLOM\ExtResourcesBlazor\ExtResourcesBlazor\_Imports.razor"
using DataModel;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\DIPLOM\ExtResourcesBlazor\ExtResourcesBlazor\Pages\CVForm.razor"
using Syncfusion.Blazor.PdfViewerServer;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "D:\DIPLOM\ExtResourcesBlazor\ExtResourcesBlazor\Pages\CVForm.razor"
using Syncfusion.Blazor.DocumentEditor;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "D:\DIPLOM\ExtResourcesBlazor\ExtResourcesBlazor\Pages\CVForm.razor"
using Syncfusion.Blazor.Buttons;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "D:\DIPLOM\ExtResourcesBlazor\ExtResourcesBlazor\Pages\CVForm.razor"
using System.IO;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "D:\DIPLOM\ExtResourcesBlazor\ExtResourcesBlazor\Pages\CVForm.razor"
using Newtonsoft.Json;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/CVs/{id}")]
    public partial class CVForm : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
#nullable restore
#line 11 "D:\DIPLOM\ExtResourcesBlazor\ExtResourcesBlazor\Pages\CVForm.razor"
 if (IsPdf)
{

#line default
#line hidden
#nullable disable
            __builder.OpenComponent<Syncfusion.Blazor.PdfViewerServer.SfPdfViewerServer>(0);
            __builder.AddAttribute(1, "DocumentPath", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 13 "D:\DIPLOM\ExtResourcesBlazor\ExtResourcesBlazor\Pages\CVForm.razor"
                                      Path

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(2, "Height", "700px");
            __builder.AddAttribute(3, "Width", "1060px");
            __builder.CloseComponent();
#nullable restore
#line 14 "D:\DIPLOM\ExtResourcesBlazor\ExtResourcesBlazor\Pages\CVForm.razor"
}
else
{

#line default
#line hidden
#nullable disable
            __builder.OpenComponent<Syncfusion.Blazor.DocumentEditor.SfDocumentEditorContainer>(4);
            __builder.AddAttribute(5, "Height", "650px");
            __builder.AddAttribute(6, "Width", "1230px");
            __builder.AddComponentReferenceCapture(7, (__value) => {
#nullable restore
#line 17 "D:\DIPLOM\ExtResourcesBlazor\ExtResourcesBlazor\Pages\CVForm.razor"
                                     container = (Syncfusion.Blazor.DocumentEditor.SfDocumentEditorContainer)__value;

#line default
#line hidden
#nullable disable
            }
            );
            __builder.CloseComponent();
#nullable restore
#line 18 "D:\DIPLOM\ExtResourcesBlazor\ExtResourcesBlazor\Pages\CVForm.razor"
}

#line default
#line hidden
#nullable disable
        }
        #pragma warning restore 1998
#nullable restore
#line 20 "D:\DIPLOM\ExtResourcesBlazor\ExtResourcesBlazor\Pages\CVForm.razor"
       

    [Parameter]
    public string Id { get; set; }
    // [Parameter]
    // public string FileType { get; set; }
    public string Path { get; set; }
    public bool IsPdf { get; set; }
    SfDocumentEditorContainer container;
    public Resource Resource { get; set; } = new Resource();

    protected override async Task OnInitializedAsync()
    {
        Resource = await Service.GetResource(Guid.Parse(Id));

        if (Resource != null)
        {
            Path = @$"D:\DIPLOM\ExtResourcesBlazor\ExtResourcesBlazor\wwwroot\Files\{Resource.CvtoolLinkMaster}";

            var file = Resource.CvtoolLinkMaster.Split('.')[1];

            if (file == "pdf")
            {
                IsPdf = true;
            }
            else
            {
                IsPdf = false;
                //container.DocumentEditor.Open(Path);

                using (FileStream fileStream = new FileStream(Path, System.IO.FileMode.Open, System.IO.FileAccess.Read))
                {
                    WordDocument document = WordDocument.Load(fileStream, ImportFormatType.Docx);
                    string json = JsonConvert.SerializeObject(document);
                    document.Dispose();
                    //To observe the memory go down, null out the reference of document variable.
                    document = null;
                    SfDocumentEditor editor = container.DocumentEditor;
                    editor.Open(json);
                    //To observe the memory go down, null out the reference of json variable.
                    json = null;
                }
            }
        }

    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private DataModel.IResourceRepository Service { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private Microsoft.AspNetCore.Hosting.IWebHostEnvironment _appEnvironment { get; set; }
    }
}
#pragma warning restore 1591
