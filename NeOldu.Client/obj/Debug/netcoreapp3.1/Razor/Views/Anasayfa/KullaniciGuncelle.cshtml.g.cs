#pragma checksum "C:\Users\EysanGuc\source\repos\NeOldu\NeOldu.Client\Views\Anasayfa\KullaniciGuncelle.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "37f4299d6266fa8b91e2bb03d61c64c525d1ce0a"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Anasayfa_KullaniciGuncelle), @"mvc.1.0.view", @"/Views/Anasayfa/KullaniciGuncelle.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"37f4299d6266fa8b91e2bb03d61c64c525d1ce0a", @"/Views/Anasayfa/KullaniciGuncelle.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"01446682c3305e7c0ff7765699817147f4af00a3", @"/Views/_ViewImports.cshtml")]
    public class Views_Anasayfa_KullaniciGuncelle : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<NeOldu.Client.Models.ApplicationUserViewModel.ApplicationUserCEViewModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("text-danger"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        #pragma warning restore 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __backed__tagHelperScopeManager = null;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __tagHelperScopeManager
        {
            get
            {
                if (__backed__tagHelperScopeManager == null)
                {
                    __backed__tagHelperScopeManager = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager(StartTagHelperWritingScope, EndTagHelperWritingScope);
                }
                return __backed__tagHelperScopeManager;
            }
        }
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.ValidationMessageTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_ValidationMessageTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\EysanGuc\source\repos\NeOldu\NeOldu.Client\Views\Anasayfa\KullaniciGuncelle.cshtml"
   Layout = ""; 

#line default
#line hidden
#nullable disable
            WriteLiteral("\n<!DOCTYPE html>\n<html lang=\"en\">\n\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "37f4299d6266fa8b91e2bb03d61c64c525d1ce0a4086", async() => {
                WriteLiteral(@"
    <meta charset=""UTF-8"" />
    <meta name=""viewport"" content=""width=device-width, initial-scale=1.0"" />
    <link rel=""stylesheet"" href=""https://maxcdn.bootstrapcdn.com/bootstrap/4.0.0/css/bootstrap.min.css""
          integrity=""sha384-Gn5384xqQ1aoWXA+058RXPxPg6fy4IWvTNh0E263XmFcJlSAwiGgFAW/dAiS6JXm"" crossorigin=""anonymous"" />
    <link rel=""stylesheet"" href=""/css/style.css"">
    <title>Araştırın</title>
");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\n\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "37f4299d6266fa8b91e2bb03d61c64c525d1ce0a5478", async() => {
                WriteLiteral("\n    ");
#nullable restore
#line 17 "C:\Users\EysanGuc\source\repos\NeOldu\NeOldu.Client\Views\Anasayfa\KullaniciGuncelle.cshtml"
Write(await Html.PartialAsync("_Navbar.cshtml"));

#line default
#line hidden
#nullable disable
                WriteLiteral("\n    <div>\n        ");
#nullable restore
#line 19 "C:\Users\EysanGuc\source\repos\NeOldu\NeOldu.Client\Views\Anasayfa\KullaniciGuncelle.cshtml"
   Write(Html.BeginForm("KullaniciGuncelleConfirmed", "Anasayfa", FormMethod.Post));

#line default
#line hidden
#nullable disable
                WriteLiteral(@"
        <div class=""slice slice-lg bg-section-secondary"">
            <div class=""container pt-5"">
                <div class=""row d-flex justify-content-center"">
                    <div class=""col-md-6"">
                        <h3>Üye olmak için aşağıda istenen bilgileri eksiksiz doldurunuz.</h3>
                        <div>
                            <div class=""row form-group"">
                                <div class=""col-md-6"">
                                    <label for=""lname"">Ad</label>
                                    ");
#nullable restore
#line 29 "C:\Users\EysanGuc\source\repos\NeOldu\NeOldu.Client\Views\Anasayfa\KullaniciGuncelle.cshtml"
                               Write(Html.TextBoxFor(p => p.FirstName, new { @class = "form-control" }));

#line default
#line hidden
#nullable disable
                WriteLiteral("\n                                    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("span", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "37f4299d6266fa8b91e2bb03d61c64c525d1ce0a7226", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_ValidationMessageTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.ValidationMessageTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_ValidationMessageTagHelper);
#nullable restore
#line 30 "C:\Users\EysanGuc\source\repos\NeOldu\NeOldu.Client\Views\Anasayfa\KullaniciGuncelle.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_ValidationMessageTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.FirstName);

#line default
#line hidden
#nullable disable
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-validation-for", __Microsoft_AspNetCore_Mvc_TagHelpers_ValidationMessageTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\n                                </div>\n                                <div class=\"col-md-6\">\n                                    <label for=\"lname\">Soyad</label>\n                                    ");
#nullable restore
#line 34 "C:\Users\EysanGuc\source\repos\NeOldu\NeOldu.Client\Views\Anasayfa\KullaniciGuncelle.cshtml"
                               Write(Html.TextBoxFor(p => p.LastName, new { @class = "form-control" }));

#line default
#line hidden
#nullable disable
                WriteLiteral("\n                                    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("span", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "37f4299d6266fa8b91e2bb03d61c64c525d1ce0a9445", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_ValidationMessageTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.ValidationMessageTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_ValidationMessageTagHelper);
#nullable restore
#line 35 "C:\Users\EysanGuc\source\repos\NeOldu\NeOldu.Client\Views\Anasayfa\KullaniciGuncelle.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_ValidationMessageTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.LastName);

#line default
#line hidden
#nullable disable
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-validation-for", __Microsoft_AspNetCore_Mvc_TagHelpers_ValidationMessageTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral(@"
                                </div>
                            </div>
                            <div class=""row form-group"">
                                <div class=""col-md-6"">
                                    <label for=""fname"">Kullanıcı Adı</label>
                                    ");
#nullable restore
#line 41 "C:\Users\EysanGuc\source\repos\NeOldu\NeOldu.Client\Views\Anasayfa\KullaniciGuncelle.cshtml"
                               Write(Html.TextBoxFor(p => p.UserName, new { @class = "form-control" }));

#line default
#line hidden
#nullable disable
                WriteLiteral("\n                                    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("span", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "37f4299d6266fa8b91e2bb03d61c64c525d1ce0a11762", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_ValidationMessageTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.ValidationMessageTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_ValidationMessageTagHelper);
#nullable restore
#line 42 "C:\Users\EysanGuc\source\repos\NeOldu\NeOldu.Client\Views\Anasayfa\KullaniciGuncelle.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_ValidationMessageTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.UserName);

#line default
#line hidden
#nullable disable
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-validation-for", __Microsoft_AspNetCore_Mvc_TagHelpers_ValidationMessageTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\n                                </div>\n                                <div class=\"col-md-6\">\n                                    <label for=\"fname\">Parola</label>\n                                    ");
#nullable restore
#line 46 "C:\Users\EysanGuc\source\repos\NeOldu\NeOldu.Client\Views\Anasayfa\KullaniciGuncelle.cshtml"
                               Write(Html.TextBoxFor(p => p.Password, new { @class = "form-control", @type = "password" }));

#line default
#line hidden
#nullable disable
                WriteLiteral("\n                                    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("span", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "37f4299d6266fa8b91e2bb03d61c64c525d1ce0a14002", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_ValidationMessageTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.ValidationMessageTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_ValidationMessageTagHelper);
#nullable restore
#line 47 "C:\Users\EysanGuc\source\repos\NeOldu\NeOldu.Client\Views\Anasayfa\KullaniciGuncelle.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_ValidationMessageTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.Password);

#line default
#line hidden
#nullable disable
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-validation-for", __Microsoft_AspNetCore_Mvc_TagHelpers_ValidationMessageTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral(@"
                                </div>
                            </div>
                            <div class=""row form-group"">
                                <div class=""col-md-12"">
                                    <label for=""email"">E-Posta</label>
                                    ");
#nullable restore
#line 53 "C:\Users\EysanGuc\source\repos\NeOldu\NeOldu.Client\Views\Anasayfa\KullaniciGuncelle.cshtml"
                               Write(Html.TextBoxFor(p => p.Email, new { @class = "form-control" }));

#line default
#line hidden
#nullable disable
                WriteLiteral("\n                                    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("span", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "37f4299d6266fa8b91e2bb03d61c64c525d1ce0a16312", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_ValidationMessageTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.ValidationMessageTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_ValidationMessageTagHelper);
#nullable restore
#line 54 "C:\Users\EysanGuc\source\repos\NeOldu\NeOldu.Client\Views\Anasayfa\KullaniciGuncelle.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_ValidationMessageTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.Email);

#line default
#line hidden
#nullable disable
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-validation-for", __Microsoft_AspNetCore_Mvc_TagHelpers_ValidationMessageTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\n                                </div>\n                            </div>\n                            <div class=\"row form-group\">\n                                <div class=\"col-md-12\">\n                                    ");
#nullable restore
#line 59 "C:\Users\EysanGuc\source\repos\NeOldu\NeOldu.Client\Views\Anasayfa\KullaniciGuncelle.cshtml"
                               Write(Html.Label("Resim"));

#line default
#line hidden
#nullable disable
                WriteLiteral("\n                                    ");
#nullable restore
#line 60 "C:\Users\EysanGuc\source\repos\NeOldu\NeOldu.Client\Views\Anasayfa\KullaniciGuncelle.cshtml"
                               Write(Html.HiddenFor(p=>p.Image));

#line default
#line hidden
#nullable disable
                WriteLiteral(@"
                                    <div class=""custom-file"">
                                        <input type=""file"" class=""custom-file-input"" id=""ImageFile"" name=""ImageFile"">
                                        <label class=""custom-file-label"" for=""validatedCustomFile"">Resim</label>
                                    </div>
                                </div>
                            </div>
                            <div class=""form-group"">
                                <button type=""submit"" class=""btn btn-primary"">Güncelle</button>
                            </div>
                        </div>
                    </div>
                </div>
            </div>
        </div>
    </div>
    ");
#nullable restore
#line 76 "C:\Users\EysanGuc\source\repos\NeOldu\NeOldu.Client\Views\Anasayfa\KullaniciGuncelle.cshtml"
Write(await Html.PartialAsync("_Footer.cshtml"));

#line default
#line hidden
#nullable disable
                WriteLiteral(@"
    <script src=""https://code.jquery.com/jquery-3.2.1.slim.min.js""
            integrity=""sha384-KJ3o2DKtIkvYIK3UENzmM7KCkRr/rE9/Qpg6aAZGJwFDMVNA/GpGFF93hXpG5KkN""
            crossorigin=""anonymous""></script>
    <script src=""https://cdnjs.cloudflare.com/ajax/libs/popper.js/1.12.9/umd/popper.min.js""
            integrity=""sha384-ApNbgh9B+Y1QKtv3Rn7W3mgPxhU9K/ScQsAP7hUibX39j7fakFPskvXusvfa0b4Q""
            crossorigin=""anonymous""></script>
    <script src=""https://maxcdn.bootstrapcdn.com/bootstrap/4.0.0/js/bootstrap.min.js""
            integrity=""sha384-JZR6Spejh4U02d8jOt6vLEHfe/JQGiRRSQQxSfFWpi1MquVdAyjUar5+76PVCmYl""
            crossorigin=""anonymous""></script>
");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\n</html>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<NeOldu.Client.Models.ApplicationUserViewModel.ApplicationUserCEViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
