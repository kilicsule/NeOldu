#pragma checksum "C:\Users\EysanGuc\source\repos\NeOldu\NeOldu.Client\Views\ApplicaitonBlock\ApplicaitonBlockDelete.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "ea8c24dca1fd396531931a5c8243ba232180cd43"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_ApplicaitonBlock_ApplicaitonBlockDelete), @"mvc.1.0.view", @"/Views/ApplicaitonBlock/ApplicaitonBlockDelete.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ea8c24dca1fd396531931a5c8243ba232180cd43", @"/Views/ApplicaitonBlock/ApplicaitonBlockDelete.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"01446682c3305e7c0ff7765699817147f4af00a3", @"/Views/_ViewImports.cshtml")]
    public class Views_ApplicaitonBlock_ApplicaitonBlockDelete : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Neoldu.Data.Domain.Entities.ApplicaitonBlock>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\EysanGuc\source\repos\NeOldu\NeOldu.Client\Views\ApplicaitonBlock\ApplicaitonBlockDelete.cshtml"
 using (Html.BeginForm("DeleteConfirmed", "ApplicaitonBlock", FormMethod.Post))
{

    

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\EysanGuc\source\repos\NeOldu\NeOldu.Client\Views\ApplicaitonBlock\ApplicaitonBlockDelete.cshtml"
Write(Html.HiddenFor(p => p.Id));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"    <div class=""row"">
        <div class=""col-md-12"">
            <div class=""card shadow-sm"">
                <div class=""card-body"">
                    <div class=""row"">
                        <div class=""col-md-6"">
                            <div class=""col-12"">
");
#nullable restore
#line 13 "C:\Users\EysanGuc\source\repos\NeOldu\NeOldu.Client\Views\ApplicaitonBlock\ApplicaitonBlockDelete.cshtml"
                                  var Fotograf = "";
                                    if (Model.People.Image != null)
                                        Fotograf = "http://localhost:50000/Images/" + Model.People.Image;
                                    else
                                        Fotograf = "/img/avatar.png";
                                

#line default
#line hidden
#nullable disable
            WriteLiteral("                                <div style=\"width:100%; text-align:center\">\r\n                                    <img");
            BeginWriteAttribute("src", " src=\"", 942, "\"", 957, 1);
#nullable restore
#line 20 "C:\Users\EysanGuc\source\repos\NeOldu\NeOldu.Client\Views\ApplicaitonBlock\ApplicaitonBlockDelete.cshtml"
WriteAttributeValue("", 948, Fotograf, 948, 9, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@" class=""img-thumbnail"" alt=""..."">
                                </div>
                            </div>
                            <div class=""col-md-12"">
                                <ul class=""list-group"">
                                    <li class=""list-group-item"">
                                        Ad:
                                        <span class=""float-right"">");
#nullable restore
#line 27 "C:\Users\EysanGuc\source\repos\NeOldu\NeOldu.Client\Views\ApplicaitonBlock\ApplicaitonBlockDelete.cshtml"
                                                             Write(Html.DisplayFor(m => m.People.FirstName));

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n                                    </li>\r\n                                    <li class=\"list-group-item\">\r\n                                        Soyadı:\r\n                                        <span class=\"float-right\">");
#nullable restore
#line 31 "C:\Users\EysanGuc\source\repos\NeOldu\NeOldu.Client\Views\ApplicaitonBlock\ApplicaitonBlockDelete.cshtml"
                                                             Write(Html.DisplayFor(m => m.People.LastName));

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n                                    </li>\r\n                                    <li class=\"list-group-item\">\r\n                                        Haber:\r\n                                        <span class=\"float-right\">");
#nullable restore
#line 35 "C:\Users\EysanGuc\source\repos\NeOldu\NeOldu.Client\Views\ApplicaitonBlock\ApplicaitonBlockDelete.cshtml"
                                                             Write(Html.DisplayFor(m => m.People.News));

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n                                    </li>\r\n                                    <li class=\"list-group-item\">\r\n                                        Haber Kaynağı:\r\n                                        <span class=\"float-right\">");
#nullable restore
#line 39 "C:\Users\EysanGuc\source\repos\NeOldu\NeOldu.Client\Views\ApplicaitonBlock\ApplicaitonBlockDelete.cshtml"
                                                             Write(Html.DisplayFor(m => m.People.SourceLink));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</span>
                                    </li>
                                </ul>
                            </div>
                        </div>
                        <div class=""col-md-6"">
                            <div class=""col-md-12"">
                                <ul class=""list-group"">
");
#nullable restore
#line 47 "C:\Users\EysanGuc\source\repos\NeOldu\NeOldu.Client\Views\ApplicaitonBlock\ApplicaitonBlockDelete.cshtml"
                                     foreach (var item in Model.ApplicationBlock_ApplicationUsers)
                                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                        <li class=\"list-group-item\">\r\n                                            <b>Ad Soyad:</b>\r\n                                            <span class=\"float-right text-muted\">");
#nullable restore
#line 51 "C:\Users\EysanGuc\source\repos\NeOldu\NeOldu.Client\Views\ApplicaitonBlock\ApplicaitonBlockDelete.cshtml"
                                                                            Write(Html.DisplayFor(p => item.ApplicationUser.FirstName));

#line default
#line hidden
#nullable disable
            WriteLiteral(" ");
#nullable restore
#line 51 "C:\Users\EysanGuc\source\repos\NeOldu\NeOldu.Client\Views\ApplicaitonBlock\ApplicaitonBlockDelete.cshtml"
                                                                                                                                  Write(Html.DisplayFor(p => item.ApplicationUser.LastName));

#line default
#line hidden
#nullable disable
            WriteLiteral(" </span>\r\n                                        </li>\r\n");
#nullable restore
#line 53 "C:\Users\EysanGuc\source\repos\NeOldu\NeOldu.Client\Views\ApplicaitonBlock\ApplicaitonBlockDelete.cshtml"
                                    }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                                </ul>
                            </div>
                        </div>
                    </div>
                </div>
            </div>
        </div>
    </div>
    <div class=""float-right mt-2"">
        <button class=""btn btn-outline-primary"" type=""submit""> Silin </button>
    </div>
    <div class=""float-right mt-2"">
        <a class=""btn btn-outline-success""");
            BeginWriteAttribute("href", " href=\"", 3504, "\"", 3551, 1);
#nullable restore
#line 66 "C:\Users\EysanGuc\source\repos\NeOldu\NeOldu.Client\Views\ApplicaitonBlock\ApplicaitonBlockDelete.cshtml"
WriteAttributeValue("", 3511, Url.Action("Index", "ApplicaitonBlock"), 3511, 40, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral("> Geri </a>\r\n    </div>\r\n");
#nullable restore
#line 68 "C:\Users\EysanGuc\source\repos\NeOldu\NeOldu.Client\Views\ApplicaitonBlock\ApplicaitonBlockDelete.cshtml"
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Neoldu.Data.Domain.Entities.ApplicaitonBlock> Html { get; private set; }
    }
}
#pragma warning restore 1591
