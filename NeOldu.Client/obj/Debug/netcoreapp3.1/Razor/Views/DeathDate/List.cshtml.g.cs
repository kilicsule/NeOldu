#pragma checksum "C:\Users\EysanGuc\source\repos\NeOldu\NeOldu.Client\Views\DeathDate\List.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "7f5725c1722f0fb0d2f9a25b4e313ef47ca5f3fe"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_DeathDate_List), @"mvc.1.0.view", @"/Views/DeathDate/List.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7f5725c1722f0fb0d2f9a25b4e313ef47ca5f3fe", @"/Views/DeathDate/List.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"01446682c3305e7c0ff7765699817147f4af00a3", @"/Views/_ViewImports.cshtml")]
    public class Views_DeathDate_List : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<NeOldu.Client.Models.DeathDateViewModel.DeathDateHomeViewModel>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\EysanGuc\source\repos\NeOldu\NeOldu.Client\Views\DeathDate\List.cshtml"
 if (Model.PagedList.Count() > 0)
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <table class=\"table table-striped table-hover\">\r\n");
#nullable restore
#line 5 "C:\Users\EysanGuc\source\repos\NeOldu\NeOldu.Client\Views\DeathDate\List.cshtml"
           int Sayac = 1; 

#line default
#line hidden
#nullable disable
            WriteLiteral("        <thead>\r\n            <tr>\r\n                <th scope=\"col\"></th>\r\n                <th scope=\"col\">#</th>\r\n                <th scope=\"col\">Tarih</th>\r\n            </tr>\r\n        </thead>\r\n");
#nullable restore
#line 13 "C:\Users\EysanGuc\source\repos\NeOldu\NeOldu.Client\Views\DeathDate\List.cshtml"
         foreach (var item in Model.PagedList)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <tr>\r\n                <td>\r\n                    <div class=\"input-group-prepend\">\r\n                        <a class=\"btn btn-outline-secondary btn-sm\" title=\"Detay\"");
            BeginWriteAttribute("href", "\r\n                           href=\"", 621, "\"", 713, 1);
#nullable restore
#line 19 "C:\Users\EysanGuc\source\repos\NeOldu\NeOldu.Client\Views\DeathDate\List.cshtml"
WriteAttributeValue("", 656, Url.Action("Details", "DeathDate", new { id = item.Id }), 656, 57, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@">
                            <i class=""fa fa-eye""></i>
                        </a>
                        <button type=""button"" class=""btn btn-outline-secondary dropdown-toggle dropdown-toggle-split btn-sm"" data-toggle=""dropdown"" aria-haspopup=""true"" aria-expanded=""false"">
                            <span class=""sr-only"">Toggle Dropdown</span>
                        </button>
                        <div class=""dropdown-menu"">
                            <a class=""dropdown-item""");
            BeginWriteAttribute("href", " href=\"", 1209, "\"", 1270, 1);
#nullable restore
#line 26 "C:\Users\EysanGuc\source\repos\NeOldu\NeOldu.Client\Views\DeathDate\List.cshtml"
WriteAttributeValue("", 1216, Url.Action("Edit", "DeathDate", new { id = item.Id }), 1216, 54, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Güncelleme</a>\r\n                            <a class=\"dropdown-item\"");
            BeginWriteAttribute("href", " href=\"", 1340, "\"", 1412, 1);
#nullable restore
#line 27 "C:\Users\EysanGuc\source\repos\NeOldu\NeOldu.Client\Views\DeathDate\List.cshtml"
WriteAttributeValue("", 1347, Url.Action("DeathDateDelete", "DeathDate", new { id = item.Id }), 1347, 65, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Sil</a>\r\n                        </div>\r\n                    </div>\r\n                </td>\r\n                <td>");
#nullable restore
#line 31 "C:\Users\EysanGuc\source\repos\NeOldu\NeOldu.Client\Views\DeathDate\List.cshtml"
               Write(Sayac);

#line default
#line hidden
#nullable disable
            WriteLiteral(" ");
#nullable restore
#line 31 "C:\Users\EysanGuc\source\repos\NeOldu\NeOldu.Client\Views\DeathDate\List.cshtml"
                              Sayac += 1; 

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 32 "C:\Users\EysanGuc\source\repos\NeOldu\NeOldu.Client\Views\DeathDate\List.cshtml"
               Write(Html.DisplayFor(modelItem => item.Year));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            </tr>\r\n");
#nullable restore
#line 34 "C:\Users\EysanGuc\source\repos\NeOldu\NeOldu.Client\Views\DeathDate\List.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </table>\r\n");
#nullable restore
#line 36 "C:\Users\EysanGuc\source\repos\NeOldu\NeOldu.Client\Views\DeathDate\List.cshtml"
}
else
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <div class=\"card-body\">\r\n        ");
#nullable restore
#line 40 "C:\Users\EysanGuc\source\repos\NeOldu\NeOldu.Client\Views\DeathDate\List.cshtml"
   Write(await Html.PartialAsync("ErrorList", "Tarih Yok!"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    </div>\r\n");
#nullable restore
#line 42 "C:\Users\EysanGuc\source\repos\NeOldu\NeOldu.Client\Views\DeathDate\List.cshtml"
}

#line default
#line hidden
#nullable disable
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
