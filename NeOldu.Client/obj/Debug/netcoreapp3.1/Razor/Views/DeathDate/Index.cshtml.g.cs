#pragma checksum "C:\Users\EysanGuc\source\repos\NeOldu\NeOldu.Client\Views\DeathDate\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "841501e0d42f58ae3fbd96b12343c7fafc40e78f"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_DeathDate_Index), @"mvc.1.0.view", @"/Views/DeathDate/Index.cshtml")]
namespace AspNetCore
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
#nullable restore
#line 1 "C:\Users\EysanGuc\source\repos\NeOldu\NeOldu.Client\Views\_ViewImports.cshtml"
using NeOldu.Client;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\EysanGuc\source\repos\NeOldu\NeOldu.Client\Views\_ViewImports.cshtml"
using NeOldu.Client.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\EysanGuc\source\repos\NeOldu\NeOldu.Client\Views\DeathDate\Index.cshtml"
using X.PagedList.Mvc.Core;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\EysanGuc\source\repos\NeOldu\NeOldu.Client\Views\DeathDate\Index.cshtml"
using X.PagedList;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"841501e0d42f58ae3fbd96b12343c7fafc40e78f", @"/Views/DeathDate/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"01446682c3305e7c0ff7765699817147f4af00a3", @"/Views/_ViewImports.cshtml")]
    public class Views_DeathDate_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<NeOldu.Client.Models.DeathDateViewModel.DeathDateHomeViewModel>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 5 "C:\Users\EysanGuc\source\repos\NeOldu\NeOldu.Client\Views\DeathDate\Index.cshtml"
  
    ViewBag.Title = " Kayıplarımız";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"<style>
    .pagination {
        float: right;
        margin-top: 5px;
    }
</style>

<div class=""card mt-3 shadow"">
    <div class=""card-header"">
        <div>
            <h4 class=""float-left"">
                Tarih Listesi
            </h4>
            <p class=""float-right"">
                ");
#nullable restore
#line 22 "C:\Users\EysanGuc\source\repos\NeOldu\NeOldu.Client\Views\DeathDate\Index.cshtml"
           Write(Html.ActionLink(" Tarih Ekle", "Create", "DeathDate", null, new { @class = "btn btn-primary", title = "Haber Ekle" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </p>\r\n            <div class=\"clearfix\"></div>\r\n        </div>\r\n    </div>\r\n    <div id=\"AddressGridContainer\">\r\n        ");
#nullable restore
#line 28 "C:\Users\EysanGuc\source\repos\NeOldu\NeOldu.Client\Views\DeathDate\Index.cshtml"
   Write(await Html.PartialAsync("List", Model));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    </div>\r\n</div>\r\n\r\n");
#nullable restore
#line 32 "C:\Users\EysanGuc\source\repos\NeOldu\NeOldu.Client\Views\DeathDate\Index.cshtml"
Write(Html.PagedListPager(Model.PagedList, page => Url.Action("Index", new { page = page }),
    new X.PagedList.Mvc.Common.PagedListRenderOptions
    {
        DisplayItemSliceAndTotal = true,
        ContainerDivClasses = new[] { "navigation" },
        LiElementClasses = new[] { "page-item" },
        PageClasses = new[] { "page-link" },
    }
    ));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n");
            DefineSection("Scripts", async() => {
                WriteLiteral("\r\n    <script>\r\n        $(document).ready(function () {\r\n            $(\'ul.pagination > li.disabled > a\').addClass(\'page-link\');\r\n            $(\'li.disabled > a\').text(\'List\');\r\n        })\r\n    </script>\r\n");
            }
            );
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<NeOldu.Client.Models.DeathDateViewModel.DeathDateHomeViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
