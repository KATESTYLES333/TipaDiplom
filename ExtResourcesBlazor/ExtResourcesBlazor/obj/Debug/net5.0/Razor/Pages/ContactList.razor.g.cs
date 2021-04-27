#pragma checksum "D:\DIPLOM\ExtResourcesBlazor\ExtResourcesBlazor\Pages\ContactList.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "82f9ec9c694d5f3c8a42f6ca7624b3c2f6fa147e"
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
    [Microsoft.AspNetCore.Components.RouteAttribute("/Contacts")]
    public partial class ContactList : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<div><h3>Contact List</h3>\n    <div class=\"form-group\"><a class=\"btn btn-success\" href=\"createContact\"><i class=\"oi oi-plus\"></i> Create New</a></div>\n    <br></div>\n");
            __builder.OpenElement(1, "div");
#nullable restore
#line 11 "D:\DIPLOM\ExtResourcesBlazor\ExtResourcesBlazor\Pages\ContactList.razor"
     if (Contacts != null)
    {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(2, "table");
            __builder.AddAttribute(3, "class", "table");
            __builder.AddMarkupContent(4, "<thead><tr><th scope=\"col\">ID</th>\n            <th scope=\"col\">FirstName</th>\n            <th scope=\"col\">LastName</th>\n            <th scope=\"col\">DOB</th></tr></thead>\n    ");
            __builder.OpenElement(5, "tbody");
#nullable restore
#line 23 "D:\DIPLOM\ExtResourcesBlazor\ExtResourcesBlazor\Pages\ContactList.razor"
         foreach (var Contact in Contacts)
        {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(6, "tr");
            __builder.OpenElement(7, "th");
            __builder.AddContent(8, 
#nullable restore
#line 26 "D:\DIPLOM\ExtResourcesBlazor\ExtResourcesBlazor\Pages\ContactList.razor"
         Contact.Id

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(9, "\n    ");
            __builder.OpenElement(10, "td");
            __builder.OpenElement(11, "a");
            __builder.AddAttribute(12, "href", 
#nullable restore
#line 27 "D:\DIPLOM\ExtResourcesBlazor\ExtResourcesBlazor\Pages\ContactList.razor"
                  $"Contactdetails/{Contact.Id}"

#line default
#line hidden
#nullable disable
            );
            __builder.AddContent(13, 
#nullable restore
#line 27 "D:\DIPLOM\ExtResourcesBlazor\ExtResourcesBlazor\Pages\ContactList.razor"
                                                   Contact.FirstName

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(14, "\n    ");
            __builder.OpenElement(15, "td");
            __builder.AddContent(16, 
#nullable restore
#line 28 "D:\DIPLOM\ExtResourcesBlazor\ExtResourcesBlazor\Pages\ContactList.razor"
         Contact.LastName

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(17, "\n    ");
            __builder.OpenElement(18, "td");
            __builder.AddContent(19, 
#nullable restore
#line 29 "D:\DIPLOM\ExtResourcesBlazor\ExtResourcesBlazor\Pages\ContactList.razor"
          Contact.DateOfBirth.HasValue ? Contact.DateOfBirth.Value.ToString("MM/dd/yyyy") : ""

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 30 "D:\DIPLOM\ExtResourcesBlazor\ExtResourcesBlazor\Pages\ContactList.razor"
     }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 32 "D:\DIPLOM\ExtResourcesBlazor\ExtResourcesBlazor\Pages\ContactList.razor"
        }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 35 "D:\DIPLOM\ExtResourcesBlazor\ExtResourcesBlazor\Pages\ContactList.razor"
        private IEnumerable<DataModel.Contact> Contacts;

    protected override async Task OnInitializedAsync()
    {
        Contacts = await Service.GetContacts();
    }

    

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private DataModel.IContactRepository Service { get; set; }
    }
}
#pragma warning restore 1591